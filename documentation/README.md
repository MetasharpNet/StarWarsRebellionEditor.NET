# SwRebellionEditor — Reverse Engineering Documentation

This directory contains reverse-engineering documentation contributed to extend
SwRebellionEditor with **save file parsing** and **runtime memory inspection**.

## What's New in This Contribution

Previously, `SaveGame/SAVEGAME.cs` used `test001`-`test030` placeholders and
assumed a fixed 200×120-byte layout. The actual save format is variable-length
sequential records and is now fully specified.

Additionally, **runtime memory inspection** is documented for the first time —
allowing live edit features beyond static DAT file editing.

---

## Documents

### Save File Format

| Document | Coverage |
|----------|----------|
| [SAVEGAME_FORMAT_SPEC.md](SAVEGAME_FORMAT_SPEC.md) | Complete byte-level specification of the SAVEGAME.NNN format |
| [IMPROVED_SAVEGAME_CS.md](IMPROVED_SAVEGAME_CS.md) | Design notes for the rewritten `SAVEGAME.cs` |
| [MESSAGE_LOG_PATTERNS.md](MESSAGE_LOG_PATTERNS.md) | UI message log record patterns (mission reports, battles, tutorials, notifications, construction status) |
| [FACTION_PAIRING_DISCOVERY.md](FACTION_PAIRING_DISCOVERY.md) | Discovery: faction markers 0x41/0x51 and 0x81/0xA1 appear in EXACT pairs with matching counts |
| [TEST_SAVES_NOTES.md](TEST_SAVES_NOTES.md) | Test save files used for verification (3 saves at known game states: day 0, day 70, day 130) |

### Runtime Memory Inspection (NEW capability)

| Document | Coverage |
|----------|----------|
| [RUNTIME_MEMORY_ANALYSIS.md](RUNTIME_MEMORY_ANALYSIS.md) | Methodology for inspecting REBEXE.EXE's live process memory |
| [GAMESTATE_STRUCT.md](GAMESTATE_STRUCT.md) | Central GameState struct: day counter, tick counter, mystery fields |
| [FLEET_RECORD_STRUCTURE.md](FLEET_RECORD_STRUCTURE.md) | Fleet C++ object layout (320 bytes), verified across 8 fleets with STATIC vs DYNAMIC field classification |
| [FACTION_STRUCT.md](FACTION_STRUCT.md) | Per-faction state struct: Raw + Refined Materials pools, capacities |

### Reference Implementation

| File | Purpose |
|------|---------|
| [reference_parser.py](reference_parser.py) | Working Python parser. Used to verify the format spec against real saves (passes 67/67 assertions across 3 test saves) |

---

## Code Changes Summary

### Files Modified

| File | Change |
|------|--------|
| `SwRebellionEditor/SaveGame/SAVEGAME.cs` | Rewritten to parse the actual save format (was placeholder code) |

### Files Added

| File | Purpose |
|------|---------|
| `SwRebellionEditor/Structs/SaveFileHeader.cs` | Header struct (NameLength, SaveName, FormatVersion, etc.) |
| `SwRebellionEditor/Structs/SaveEntity.cs` | Entity record class + `FactionMarker` and `PositionMarker` enums |
| `SwRebellionEditor/Structs/SaveMessage.cs` | Message log record class + `MessageCategory` enum + pattern table |
| `documentation/*.md` | This documentation set |
| `documentation/reference_parser.py` | Python cross-reference implementation |

### Files Removed

| File | Reason |
|------|--------|
| `SwRebellionEditor/Structs/SavegameChunks.cs` | Was a placeholder (test001-test030 fields). No longer needed. |

---

## Verification

The format spec was verified against three real save files:

| File | Save Name | Game State | Size |
|------|-----------|------------|------|
| SAVEGAME.001 | "RUST_TEST" | Day 0 / early game | 764,410 bytes |
| SAVEGAME.002 | "RUST_TEST_70DAYS" | Day 70 | 814,050 bytes |
| SAVEGAME.003 | "130DAYS_RUST" | Day 130 | 824,350 bytes |

The Python parser passes **67/67 assertions** across all 3 saves, confirming:
- All known characters identified by name (Piett, Ozzel, Brandei, Luke Skywalker, etc.)
- Faction pairing math verified
- All entity offsets unique and within file bounds
- All message texts printable

---

## Methodology

Findings come from:

1. **Cross-comparing 3 real save files** at known game states (day 0, 70, 130)
2. **Pattern-matching unit/character names** against `Identifiers.cs`
3. **Live REBEXE memory inspection** via `pymem` + Frida hooks (see `RUNTIME_MEMORY_ANALYSIS.md`)
4. **Cross-referencing** DAT file schemas with save file records and runtime memory layouts

---

## What Could Come Next

The runtime memory work opens new editor features beyond static DAT editing:

- **Live Mode** — read/write REBEXE memory while game is running (no restart needed)
- **Fleet Inspector** — show all fleets, their locations, and travel times in real-time
- **Resource Editor** — directly modify Raw/Refined Materials pools
- **Fleet Teleporter** — instantly move any fleet to any system
- **Save File Browser** — read mission/battle history embedded in save messages

See individual `.md` files for proposed C# struct definitions and code samples.
