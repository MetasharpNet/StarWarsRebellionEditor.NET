# Pull Request: Save File Format Decoding + Runtime Memory Documentation

**Title suggestion:** `Decode SAVEGAME format and add runtime memory structures`

**Branch:** `feature/savegame-format-and-runtime-memory`

---

## Summary

This PR replaces the placeholder `SAVEGAME.cs` implementation with a working
parser for the actual save file format, and adds comprehensive documentation
for REBEXE.EXE's runtime memory layouts (previously undocumented in this repo).

The contribution is purely additive for the runtime work — no existing files
deleted besides one stub. The save format work replaces the previous incorrect
spec.

## Motivation

The previous `SAVEGAME.cs` used field placeholders (`test001` through
`test030`) and assumed a fixed 200×120-byte record array after a 4-u32 header.
This spec is incorrect; actual save files use a length-prefixed save name,
sequential variable-length entity records, and embedded message logs.

This PR fixes the spec based on verification against three real saves.

Additionally, since the existing editor only covers static `.DAT` file editing,
this PR documents REBEXE's runtime memory layouts so future "live editing"
features (real-time fleet inspector, resource editor, instant arrival, etc.)
have a foundation to build on.

---

## Changes

### Code Changes

#### `SwRebellionEditor/SaveGame/SAVEGAME.cs` (rewritten)

The old code expected `headerUnknown1..3` + 200 × 30-uint records.
The new code parses:

1. **u16 save name length** + ASCII save name
2. **16-byte header** (format version, reserved, save iteration counter)
3. **Variable-length entity records** — signature `00 00 [faction] 00 00 [0x80|0x90]` followed by type/count/name
4. **Message log records** — 5 distinct categories (mission, battle, tutorial, notification, construction status)

Provides query helpers: `EntitiesByFaction`, `EntitiesByType`, `FindEntities`.

#### `SwRebellionEditor/Structs/SaveFileHeader.cs` (new)

Replaces placeholder structures with the actual header layout.

#### `SwRebellionEditor/Structs/SaveEntity.cs` (new)

Entity record class + `FactionMarker` enum (6 values observed) + `PositionMarker` enum (0x80/0x90).

#### `SwRebellionEditor/Structs/SaveMessage.cs` (new)

Message record class + `MessageCategory` enum (5 categories) + `MessagePatterns` dictionary of byte signatures.

#### `SwRebellionEditor/Structs/SavegameChunks.cs` (deleted)

Was a placeholder struct (`test001`-`test030`). No longer used.

### Documentation Added

All in new `documentation/` directory:

| File | Topic |
|------|-------|
| `README.md` | Index of all docs |
| `SAVEGAME_FORMAT_SPEC.md` | Complete byte-level save format spec |
| `IMPROVED_SAVEGAME_CS.md` | Design notes for the rewritten parser |
| `MESSAGE_LOG_PATTERNS.md` | UI message record patterns |
| `FACTION_PAIRING_DISCOVERY.md` | Discovery of entity record pairing |
| `TEST_SAVES_NOTES.md` | Verification methodology |
| `RUNTIME_MEMORY_ANALYSIS.md` | How to inspect REBEXE memory (pymem + Frida) |
| `GAMESTATE_STRUCT.md` | Day counter + GameState struct layout |
| `FLEET_RECORD_STRUCTURE.md` | Fleet C++ object: 320 bytes, fully decoded |
| `FACTION_STRUCT.md` | Per-faction state: Raw/Refined materials |
| `reference_parser.py` | Working Python parser (passes 67/67 tests) |

---

## Verification

The new parser was verified against three real save files using the included
Python reference parser:

| Test Save | Day | Size | Entities Parsed | Messages Parsed |
|-----------|-----|------|-----------------|-----------------|
| RUST_TEST | 0 | 764 KB | 54 | 9 |
| RUST_TEST_70DAYS | 70 | 814 KB | 68 | 50 |
| 130DAYS_RUST | 130 | 824 KB | 67 | 25 |

**67 of 67 assertions pass**, covering:

- Format version field
- Save iteration counter increments correctly
- All character names match Identifiers.cs (Piett, Ozzel, Brandei, Luke Skywalker, Daala, Needa, Screed, Grammel)
- Faction pairing math: Alliance 0x41 count == 0x51 count in every save
- Faction pairing math: Empire 0x81 count == 0xA1 count in every save
- All entity offsets unique and within file bounds
- All message texts printable ASCII
- Fleet records correctly classified as Fleet entities
- Capital ship records classified as their proper types (Imperial Star Destroyer, Galleon, Victory Destroyer, etc.)

---

## Key Discoveries Worth Noting

### 1. The `0x41`/`0x51` and `0x81`/`0xA1` Pairing

Faction markers appear in **exact pairs** across every save:

| Save | 0x41 | 0x51 | 0x81 | 0xA1 |
|------|------|------|------|------|
| S1 | 13 | 13 | 12 | 12 |
| S2 | 13 | 13 | 14 | 14 |
| S3 | 11 | 11 | 17 | 17 |

This suggests every entity has TWO records: a primary (0x41 or 0x81) and a
paired alt (0x51 or 0xA1). Editing tools need to update BOTH records to keep
saves consistent. Details in `documentation/FACTION_PAIRING_DISCOVERY.md`.

### 2. Maintenance Is Computed, Not Stored

The Maintenance value shown in the in-game UI is NOT stored anywhere in saves
or memory as a single value. It's computed at display time as the sum of all
owned units' `MaintenanceCost` from CAPSHPSD/FIGHTSD/TROOPSD/MJCHARSD/MNCHARSD.

This means editing "current maintenance" in a save has no effect — it'll be
recomputed on load.

### 3. Travel Time Is Computed From `arrival_date - current_day`

REBEXE doesn't store "days remaining" anywhere. Each Fleet record has an
`arrival_date` field (offset +0x24); GameState has a `day_counter` (+0x20).
Display value = `arrival_date - day_counter`.

This was verified live: Day 191, Fleet 2 arrival_date = 210, displayed
"19 days remaining". Day 192, same arrival_date, displayed "18 days remaining".

### 4. Runtime Fleet Record Layout (320 bytes)

Verified across 8 real Empire fleets in memory:

```
+0x00  next_record_ptr           (heap ptr)
+0x04  sector_id                 (0x80FFXXXX — Identifiers.SectorByte family)
+0x10  vtable_pos                STATIC: 0x0065D430
+0x18  faction                   1=Alliance, 2=Empire
+0x1C  current_system            (0x90FFXXXX — Identifiers.SystemByte family)
+0x24  arrival_date              0 if idle, else day fleet arrives
+0x40  vtable_fleet              STATIC: 0x0066DCA8 (anchor for memory scan)
+0x50  name                      ASCII null-terminated
+0x60  vtable_2                  STATIC: 0x00662140
+0x6C  destination_system_id     0 if idle, else target system
+0x70  jumps_remaining           hyperspace jumps to destination
+0x80  vtable_shiplist           STATIC: 0x0066A174
+0x84  ship_ptr_1                pointer to first ship in fleet
+0xA0  ship_count                number of ships in fleet
```

This same vtable layout is shared with other named game entities (characters,
capital ships, buildings) — they all derive from the same C++ base class.

---

## Test Plan

To verify this PR:

```bash
# Build the project
dotnet build SwRebellionEditor.sln

# Run with one of the test saves (or any real save)
dotnet run --project SwRebellionEditor.csproj
```

Then load `SAVEGAME.NNN`. The parser will populate `SAVEGAME.Header`,
`SAVEGAME.Entities`, and `SAVEGAME.Messages` instead of `SAVEGAME.SaveGame[]`.

For the Python reference parser:

```bash
cd documentation
python reference_parser.py /path/to/SAVEGAME.001
```

---

## What This Enables Going Forward

With the save format now properly decoded, the editor could add:

- **Mission History Browser** — show all mission reports from `Messages` list
- **Battle Log Viewer** — display orbital bombardments per system per turn
- **Tutorial Reset** — remove tutorial topic records so popups show again
- **Entity Editor** — modify Fleet/Ship/Character records directly
- **Save Validation** — detect corrupted records via signature checking

With the runtime memory work, a future "Live Mode" could:

- Show current day, resources, fleet positions in real-time as user plays
- Allow live editing without restarting the game
- Detect anomalies (e.g., negative resources, broken pointers)

---

## Notes for Reviewer

- The Python reference parser is included for cross-validation; you can run it
  independently and compare its output against the C# parser
- All STATIC values (`0x0066DCA8`, `0x0065D430`, etc.) are from a single REBEXE
  process — they're stable within a session but heap-allocated addresses
  differ across REBEXE launches
- For Pattern signatures and memory scanning examples, see the Python tools
  referenced in `documentation/RUNTIME_MEMORY_ANALYSIS.md`

---

## Credits

Discovery work used `pymem`, `Frida`, and Cheat Engine for live memory
inspection. Save format reverse-engineered through cross-comparison of real
save files and pattern-matching against `Identifiers.cs`.

Special thanks to the comprehensive `Identifiers.cs` and DAT file schemas in
this repo — they provided the foundation that made decoding the save format
much faster than starting from scratch.
