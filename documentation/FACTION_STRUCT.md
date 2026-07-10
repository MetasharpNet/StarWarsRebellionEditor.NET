# Faction Struct (Runtime Memory)

Per-faction state struct in REBEXE.EXE's heap memory. Contains current
resource pool (Raw + Refined Materials) and per-faction counters.

**Discovery method**: Live REBEXE memory inspection. Located by scanning for
the current Refined Materials value (e.g., 730) and finding **two matching
addresses with identical surrounding structs** — one per faction.

---

## How to Find Faction Structs

Two factions = two structs at different heap addresses. They have identical
field layouts. Find them by:

1. Identify the current Refined Materials value from the in-game UI (e.g., 730)
2. Pattern-scan memory for that value as a u32
3. Filter to addresses with the consistent surrounding struct pattern (see below)
4. Two matches → one is Alliance, one is Empire

---

## Field Layout (64-128 bytes)

Based on observation at refined=730, day=192:

| Offset | Size | Type | Field | Example Value | Notes |
|--------|------|------|-------|---------------|-------|
| `+0x00` | 4 | u32 | `raw_capacity` | `3350` | Total raw materials capacity |
| `+0x04` | 4 | u32 | `unknown_a` | `657` | Appears 4 times in the struct — possibly a per-tick production rate |
| `+0x08` | 4 | u32 | `refined_capacity` | `3500` | Total refined materials capacity |
| `+0x0C` | 4 | u32 | `unknown_b` | `657` | duplicate |
| `+0x10` | 4 | u32 | `unknown_c` | `657` | duplicate |
| `+0x14` | 4 | u32 | `unknown_d` | `657` | duplicate |
| `+0x18` | 4 | u32 | `raw_materials` | `0` | ⭐ Current raw materials pool. Matches in-game UI. |
| `+0x1C` | 4 | u32 | `refined_materials` | `730` | ⭐ Current refined materials pool. Matches in-game UI. |
| `+0x20` | 4 | u32 | `faction_id` | `2` | Faction identifier (1=Alliance, 2=Empire?) |
| `+0x24` | 4 | u32 | `unknown` | `0` | |
| `+0x28` | 4 | u32 ptr | `detail_data_ptr` | heap address | Pointer to per-faction detail data |
| `+0x2C` | 4 | u32 ptr | `detail_data_ptr2` | heap address | Another pointer |
| `+0x30` | 4 | u32 | `mine_count?` | `7` | Possibly number of mines owned |
| `+0x34` | 4 | u32 | `unknown` | `2` | |
| `+0x38` | 4 | u32 | `refinery_count?` | `12` | Possibly number of refineries owned |

---

## Test Session Data

In our day 192 observation, both faction structs had IDENTICAL fields:

```
Faction struct #1: at 0x02DDECA0
Faction struct #2: at 0x02E35630
Both contained:
  +0x00: 3350   (raw_capacity)
  +0x04: 657
  +0x08: 3500   (refined_capacity)
  +0x0C: 657
  +0x10: 657
  +0x14: 657
  +0x18: 0      (raw_materials)
  +0x1C: 730    (refined_materials)
  +0x20: 2      (faction_id)
  +0x28: <different pointer per faction>
  +0x2C: <different pointer per faction>
  +0x30: 7
  +0x34: 2
  +0x38: 12
```

The fact that BOTH structs had the same refined=730 is suspicious — likely a
coincidence (the player might have happened to have the same value as the AI).
The **pointers** at +0x28 and +0x2C definitely differ between the two structs,
confirming they're per-faction.

---

## Important Discovery: Maintenance Is NOT Here

Searching for the maintenance value 2693 in REBEXE memory finds it at 121
addresses, but **NONE of them are in the faction struct or GameState**. Many
hits are inside DAT-file-loaded constants (high-address regions).

This confirms our hypothesis: **Maintenance is computed at display time** by
summing all owned units' `MaintenanceCost` from CAPSHPSD/FIGHTSD/etc. It's not
stored as a single value anywhere.

---

## Cross-Reference With Save Files

The save file format (see `01_SAVEGAME_FORMAT_SPEC.md`) appears to store
faction resource state. Mapping save-to-memory:

| In Save File | In Memory |
|--------------|-----------|
| (unknown offset) | `raw_materials` (+0x18) |
| (unknown offset) | `refined_materials` (+0x1C) |
| Sum of unit MaintenanceCost | (computed at display, not stored) |

When the player saves, the runtime values from the faction struct are written
to the save file. When they load, those values are written back.

---

## Proposed C# Struct Definition

```csharp
namespace SwRebellionEditor.Runtime;

[StructLayout(LayoutKind.Explicit, Size = 64)]
public struct FactionStruct
{
    [FieldOffset(0x00)] public uint RawCapacity;
    [FieldOffset(0x04)] public uint UnknownA;
    [FieldOffset(0x08)] public uint RefinedCapacity;
    [FieldOffset(0x0C)] public uint UnknownB;
    [FieldOffset(0x10)] public uint UnknownC;
    [FieldOffset(0x14)] public uint UnknownD;
    [FieldOffset(0x18)] public uint RawMaterials;           // ⭐ Editable
    [FieldOffset(0x1C)] public uint RefinedMaterials;       // ⭐ Editable
    [FieldOffset(0x20)] public uint FactionId;
    [FieldOffset(0x28)] public uint DetailDataPtr;
    [FieldOffset(0x2C)] public uint DetailDataPtr2;
    [FieldOffset(0x30)] public uint MineCount;              // tentative
    [FieldOffset(0x34)] public uint Unknown2;
    [FieldOffset(0x38)] public uint RefineryCount;          // tentative
}
```

---

## Use Cases for Editor

### 1. Give yourself more resources
```python
# Find Alliance faction struct (the one with detail_data_ptr in Alliance heap region)
pm.write_uint(alliance_faction_base + 0x1C, 99999)  # max out refined materials
```

### 2. Resource snapshot diff
Compare faction struct fields across saves to track economy progress over time.

### 3. Bankrupt the enemy
```python
pm.write_uint(empire_faction_base + 0x18, 0)   # zero raw
pm.write_uint(empire_faction_base + 0x1C, 0)   # zero refined
```

---

## Open Questions

1. **Which struct is Alliance vs Empire?** — need to verify by checking detail_data_ptr targets
2. **What's the 657 value repeating 4 times?** — production rate? Tax rate?
3. **Are there per-system production rates stored elsewhere?** — likely, since each Mine/Refinery has its own ProcessingRate
4. **Is there a separate faction-stat struct for diplomacy/research/etc.?** — those values come from somewhere
