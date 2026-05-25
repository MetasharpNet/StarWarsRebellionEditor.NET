# Fleet Record Structure (Runtime Memory)

This document describes the runtime C++ object layout of Fleet records in
REBEXE.EXE's process memory. Useful for any feature that needs to read or
modify fleet state at runtime (live editing, save game extraction via memory,
fleet movement automation, etc.).

**Discovery method**: Live REBEXE memory inspection via `pymem` + manual
pattern recognition against `Identifiers.cs` family bytes.

**Verified state**: Day 192, Fleet 2 in transit (arrival date 210).

---

## Fleet Record Size

**320 bytes per record** (0x140), but the meaningful field area appears to span
the first ~256 bytes. Trailing bytes hold ship list pointers and padding.

---

## Field Layout

| Offset | Size | Type | Field Name | Description / Example |
|--------|------|------|------------|------------------------|
| `+0x00` | 4 | u32 ptr | `next_record_ptr` | Pointer to next record in chain (heap address) |
| `+0x04` | 4 | u32 | `sector_id` | Full Identifier with `0x80` family byte. e.g., `0x80000041` = sector 0x41 |
| `+0x08` | 4 | u32 ptr | `pointer_unknown_1` | Heap pointer (purpose TBD) |
| `+0x0C` | 4 | u32 ptr | `pointer_unknown_2` | Heap pointer (purpose TBD) |
| `+0x10` | 4 | u32 ptr | `vtable_position_record` | Always `REBEXE.exe+0x25D430` — vtable for position/state record class |
| `+0x14` | 4 | u32 ptr | `self_pointer` | Points to this record's start |
| `+0x18` | 4 | u32 | `faction_id` | Faction owner. Observed: `1` and `2` |
| `+0x1C` | 4 | u32 | `current_system_id` | Full Identifier with `0x90` family byte. e.g., `0x9000009C` = current system 0x9C |
| `+0x20` | 4 | u32 | `flags_or_coords` | Packed bits, observed: `0x00010200`, `0x00010400`, `0x00000100` |
| `+0x24` | 4 | u32 | **`arrival_date`** | ⭐ Day on which fleet will arrive at destination. **0 if not traveling** |
| `+0x28` | 4 | u32 | `unknown_1` | Often 0 |
| `+0x2C` | 4 | u32 | `unknown_2` | Often 0 |
| `+0x30` | 4 | u32 | `unknown_3` | Often 0 |
| `+0x34` | 4 | u32 ptr | `child_array_ptr` | Pointer to nearby structure |
| `+0x38` | 4 | u32 | `child_count?` | Usually 1 |
| `+0x3C` | 4 | u32 | `unknown_4` | |
| `+0x40` | 4 | u32 ptr | **`vtable_Fleet_class`** | ⭐ Always `REBEXE.exe+0x26DCA8` — Fleet class vtable. **Use this to find all fleets via pattern scan** |
| `+0x44` | 4 | u32 ptr | `self_pointer_2` | Another self-reference |
| `+0x48` | 4 | u32 | `init_flag` | Usually 1 |
| `+0x4C` | 2 | u16 | `name_length` | Length of name string |
| `+0x4E` | 2 | u16 | `pad?` | |
| `+0x50` | N | char[] | **`name`** | ⭐ Fleet name (e.g., "Fleet 2", null-terminated within record) |
| `+0x60` | 4 | u32 ptr | `vtable_2` | `REBEXE.exe+0x262140` — another vtable (perhaps for travel/mission state) |
| `+0x6C` | 4 | u32 | **`destination_system_id`** | ⭐ Full Identifier with `0x90` family. e.g., `0x90000106` = destination system 0x106. **0 if not traveling** |
| `+0x70` | 4 | u32 | `jumps_or_distance` | Possibly hyperspace jumps remaining. Observed: 5, 10 |
| `+0x80` | 4 | u32 ptr | `vtable_ship_list` | `REBEXE.exe+0x26A174` — vtable for ship roster |
| `+0x84` | 4 | u32 ptr | `ship_ptr_1` | Pointer to first ship in fleet (heap, points to CapitalShip object) |
| `+0x88` | 4 | u32 ptr | `ship_ptr_2` | Second ship |
| `+0x8C` | 4 | u32 ptr | `ship_ptr_3` | Third ship |
| `+0x94` | 4 | u32 | `unknown_count` | Observed: 1, 2 |
| `+0x98` | 4 | u32 | `large_counter` | Tick-related? Observed: 2540-2581 (close to current tick 2556) |
| `+0xA0` | 4 | u32 | `ship_count` | Number of ships in fleet roster |
| `+0xA4` | 4 | u32 ptr | `children_list_start` | Pointer to ship list array |
| `+0xA8` | 4 | u32 ptr | `children_list_alt` | |
| `+0xAC` | 4 | u32 ptr | `children_list_end?` | |
| `+0xB0` | 4 | u32 ptr | `vtable_3` | `REBEXE.exe+0x26A168` — yet another vtable |
| `+0xB4`-`+0xCC` | ... | various | secondary record block | Appears to be a duplicated/mirrored sub-block |
| `+0xD0` | ... | ... | embedded ship records | First few ship names appear as embedded ASCII strings (e.g., "Corellian Corvette 1" at offset +0xF0) |

---

## Field Encoding: Full Identifier IDs

Several fields use the `Identifiers.cs` 32-bit ID format `[family:8][reserved:8=00][subtype:16]`:

| Field | Family Byte | Family Name | Lookup |
|-------|-------------|-------------|--------|
| `sector_id` (+0x04) | 0x80 | SectorByte | Cross-reference with SECTORSD.DAT |
| `current_system_id` (+0x1C) | 0x90 / 0x92 | SystemByte / RimSystemByte | Cross-reference with SYSTEMSD.DAT |
| `destination_system_id` (+0x6C) | 0x90 / 0x92 | SystemByte / RimSystemByte | Same as above |

---

## Reverse Engineering Method

To find all fleets in REBEXE memory:

1. Pattern-scan REBEXE memory for the value `0x0066DCA8` (Fleet class vtable address)
2. For each hit at address `X`, the fleet record starts at `X - 0x40`
3. Parse fields per the table above

```python
import pymem

pm = pymem.Pymem("REBEXE.EXE")
FLEET_VTABLE = 0x0066DCA8

# Find all fleet records via vtable pattern scan
fleets = []
for region in get_committed_regions(pm):
    data = pm.read_bytes(region.base, region.size)
    for offset in range(0, len(data) - 4, 4):
        val = int.from_bytes(data[offset:offset+4], 'little')
        if val == FLEET_VTABLE:
            fleet_record_start = region.base + offset - 0x40
            fleets.append(parse_fleet_record(pm, fleet_record_start))

print(f"Found {len(fleets)} fleets in memory")
```

---

## Live Travel Time Computation

REBEXE does NOT store "days remaining" anywhere. Instead it displays:

```
days_remaining = arrival_date (+0x24) - current_day_counter
```

The `current_day_counter` is in the GameState struct at offset `+0x20` from
the GameState base. See `09_GAMESTATE_STRUCT.md` for that struct's layout.

To monitor fleet travel:
```python
day = pm.read_uint(GAMESTATE_BASE + 0x20)
arrival = pm.read_uint(FLEET_RECORD_BASE + 0x24)
days_remaining = arrival - day if arrival > day else 0  # 0 = arrived/idle
```

---

## Multi-Record Phenomenon

A fleet named "Fleet 2" may appear 8+ times in memory. This is because:
1. Both Alliance and Empire can have fleets named "Fleet 2" simultaneously
2. Each fleet record exists in multiple subsystems (active list, UI cache, AI planner)

The records with **`arrival_date` (+0x24) != 0** are the actively-traveling fleets.

---

## Proposed C# Struct Definition

```csharp
namespace SwRebellionEditor.Runtime;

[StructLayout(LayoutKind.Explicit, Size = 320)]
public struct FleetRecord
{
    [FieldOffset(0x00)] public uint NextRecordPtr;
    [FieldOffset(0x04)] public uint SectorId;            // 0x80FFXXXX
    [FieldOffset(0x10)] public uint VtablePositionRecord;
    [FieldOffset(0x14)] public uint SelfPointer;
    [FieldOffset(0x18)] public uint FactionId;
    [FieldOffset(0x1C)] public uint CurrentSystemId;     // 0x90FFXXXX
    [FieldOffset(0x20)] public uint FlagsOrCoords;
    [FieldOffset(0x24)] public uint ArrivalDate;         // 0 = not traveling
    [FieldOffset(0x40)] public uint VtableFleetClass;    // == 0x0066DCA8
    [FieldOffset(0x44)] public uint SelfPointer2;
    [FieldOffset(0x48)] public uint InitFlag;
    [FieldOffset(0x4C)] public ushort NameLength;
    // Name string follows at +0x50 (variable length, max ~15 chars observed)
    [FieldOffset(0x6C)] public uint DestinationSystemId; // 0 if idle
    [FieldOffset(0x70)] public uint JumpsRemaining;
    [FieldOffset(0x80)] public uint VtableShipList;
    [FieldOffset(0x84)] public uint Ship1Ptr;
    [FieldOffset(0x88)] public uint Ship2Ptr;
    [FieldOffset(0x8C)] public uint Ship3Ptr;
    [FieldOffset(0x98)] public uint LargeCounter;
    [FieldOffset(0xA0)] public uint ShipCount;
    [FieldOffset(0xA4)] public uint ChildrenListStart;
}
```

---

## Use Cases for Editor

### 1. Live Fleet Inspection
Display all fleets in real-time as the player plays:
- Name, faction, current system, destination system, ETA

### 2. Fleet Teleport
Write to `current_system_id` (+0x1C) and clear `destination_system_id` (+0x6C) to teleport a fleet:
```python
pm.write_uint(fleet_addr + 0x1C, target_system_id)
pm.write_uint(fleet_addr + 0x6C, 0)
pm.write_uint(fleet_addr + 0x24, 0)  # clear arrival_date
```

### 3. Instant Arrival
Write current day to `arrival_date` to make fleet arrive immediately:
```python
pm.write_uint(fleet_addr + 0x24, current_day)
```

### 4. Faction Conversion
Write to `faction_id` (+0x18) to convert fleet (visual only? or also gameplay?):
```python
pm.write_uint(fleet_addr + 0x18, NEW_FACTION_ID)
```

---

## Open Questions

1. **What's at `+0x20`?** — packed coordinates? bit flags? Always 0x10200/0x10400 pattern observed.
2. **What's the difference between fields at +0xA4, +0xA8, +0xAC?** — three pointers, all to nearby heap addresses
3. **Trailing bytes** — what's stored beyond +0x140 (next fleet record begins?)
4. **Mission/task fields** — fleets can have orders (move, patrol, attack). Where are those stored?
5. **Combat state** — when a fleet is in combat, what fields update?

---

## Test Data

All observations from a single REBEXE session (day 192):
- 8 records found for "Fleet 2" via string search
- 2 records contained `arrival_date == 210` (the actively-traveling Fleet 2 for each faction)
- All records share the same vtable at +0x40 (`0x0066DCA8`)
- Field structure consistent across all 8 records

---

## Verified Field Consistency (Across 8 Real Empire Fleets)

To verify the fleet record structure, we pattern-scanned all 3,154 occurrences
of `0x0066DCA8` in memory, then filtered to records whose name starts with
`"Fleet "` AND has a valid faction ID. Result: **8 unique fleet records** (all
Empire, since this session's player is Empire).

Field-by-field analysis:

| Field | Classification | Notes |
|-------|----------------|-------|
| `+0x00 next_ptr` | DYNAMIC (8 unique) | Pointer, naturally varies |
| `+0x04 sector_id` | SEMI-STATIC | 3 unique values: `0x80000081` (×4), `0x80000041` (×3), `0x80000141` (×1). Maps fleets to sectors. |
| `+0x10 vtable_pos` | **STATIC** `0x0065D430` | Position/state vtable — same for all fleets |
| `+0x14 self_ptr_1` | DYNAMIC | Self-reference, varies per fleet |
| `+0x18 faction` | **STATIC** `2` (all observations) | Only because user is Empire; would be `1` for Alliance |
| `+0x1C current_system` | SEMI-STATIC | 3 unique: `2` (×5, "idle/in-sector"), `0x90000096` (×2), `0x9000009C` (×1) |
| `+0x20 flags` | DYNAMIC | 6 unique values (0 to 66560) |
| `+0x24 arrival_date` | DYNAMIC | 4 unique: `0` (×5 idle), `202`, `203`, `210` (traveling fleets) |
| `+0x40 vtable_fleet` | **STATIC** `0x0066DCA8` | The pattern-scan anchor itself |
| `+0x44 self_ptr_2` | DYNAMIC | Self-reference |
| `+0x48 init_flag` | **STATIC** `1` | Always 1 — entity initialized flag |
| `+0x4C name_len` | STATIC `0` | NOTE: our parser was reading wrong offset for name_len. Real name length is stored differently. |
| `+0x60 vtable_2` | **STATIC** `0x00662140` | Travel/mission state vtable |
| `+0x6C destination` | DYNAMIC | 6 unique values |
| `+0x70 jumps_remaining` | DYNAMIC | 5 unique (0 to 10) — number of hyperspace jumps to reach destination |
| `+0x80 vtable_shiplist` | **STATIC** `0x0066A174` | Ship roster vtable |
| `+0x84 ship1_ptr` | DYNAMIC | Pointer to first ship |
| `+0xA0 ship_count` | STATIC `8` | All 8 observed fleets have exactly 8 slots. Likely a fixed max-fleet-size cap. |

### Observed fleet roster (Empire, day 192)

```
0x02D6CDC0  Fleet 2   current=0x96 dest=0x115 arrive=202  sector=0x81
0x02D6D490  Fleet 11  current=0x02 dest=0x02  arrive=  0  sector=0x81  (idle)
0x02D719F0  Fleet 4   current=0x02 dest=0x9A  arrive=  0  sector=0x41  (idle*)
0x02DBB380  Fleet 2   current=0x9C dest=0x106 arrive=210  sector=0x41  (TRAVELING)
0x02DBF790  Fleet 6   current=0x02 dest=0x109 arrive=  0  sector=0x81  (idle)
0x02DC2E70  Fleet 6   current=0x02 dest=0x10A arrive=  0  sector=0x41  (idle)
0x02DCDBB0  Fleet 8   current=0x96 dest=0x115 arrive=203  sector=0x81  (traveling, arrives day 203)
0x02DDCD70  Fleet 1   current=0x02 dest=0x10A arrive=  0  sector=0x141 (idle)
```

Note: Two fleets named "Fleet 2" exist simultaneously — REBEXE allows duplicate names
across sectors/factions.

### Confirmed STATIC fields (use these as anchors for pattern scanning)

- `+0x10` = `0x0065D430`
- `+0x40` = `0x0066DCA8` ⭐ (primary anchor for fleet scanning)
- `+0x60` = `0x00662140`
- `+0x80` = `0x0066A174`

A more reliable fleet detector would check that ALL FOUR vtables match
at the expected offsets, virtually eliminating false positives.

### Confirmed DYNAMIC fields (game state)

These are the editable values for live editing tools:
- `+0x04 sector_id`
- `+0x18 faction` (changes when fleet captured?)
- `+0x1C current_system`
- `+0x24 arrival_date`
- `+0x6C destination`
- `+0x70 jumps_remaining`
- `+0xA0 ship_count` (when adding/removing ships)
- Ship list pointers at `+0x84`, `+0x88`, `+0x8C`

### Important context

The vtable `0x0066DCA8` is **shared** with other named entity types — when scanning all
of memory for this value, we got 3,154 hits across:
- 8 real Fleets (above)
- ~50 Characters (Piett, Ozzel, Daala, etc.)
- ~30 Capital Ships (Hydra, Gorgon, Punisher, etc.)
- Buildings (Alliance HQ, Advanced Shipyard, Training Facility)
- 3,000+ false positives (random 4-byte sequences)

So the vtable alone is NOT a unique Fleet identifier. To filter to ONLY fleets, validate:
1. Name string at `+0x50` starts with `"Fleet "`
2. `faction` (+0x18) is 1 or 2
3. `ship_count` (+0xA0) is 0-20
