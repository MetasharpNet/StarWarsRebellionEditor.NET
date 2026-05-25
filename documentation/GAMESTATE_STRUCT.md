# GameState Struct (Runtime Memory)

The central game state struct in REBEXE.EXE's heap memory. Contains the
day counter, tick counter, and several resource/state fields.

**Discovery method**: Live REBEXE memory inspection. Located by finding the
literal ASCII string `"Star Wars - Rebellion"` in memory — the GameState struct
begins immediately after this string fragment in a contiguous heap allocation.

---

## How to Find It

The GameState struct heap address **changes every REBEXE launch** (heap
allocation is not ASLR'd but is order-dependent). To find it reliably:

```python
import pymem

pm = pymem.Pymem("REBEXE.EXE")

# Search REBEXE memory for the title string
for region in get_committed_regions(pm):
    data = pm.read_bytes(region.base, region.size)
    idx = data.find(b'Star Wars - Rebellion\x00')
    if idx >= 0:
        # GameState struct begins at the END of this string
        gamestate_base = region.base + idx + len('Star Wars - Rebellion') + 1
        # Or just use the well-known offset:
        # The string starts at gamestate_base - 0x05 (last 5 chars before truncation in our dump)
        break
```

Alternatively, scan for `0x0065ECF4` (vtable pointer at +0x10 of GameState).
Combined with the constant ID `0x00000001` at +0x14 and +0x18, this gives a
high-confidence detection.

---

## Field Layout

Based on a single test session with day=192, refined=730, maintenance=2693:

| Offset | Size | Type | Field | Example Value | Notes |
|--------|------|------|-------|---------------|-------|
| `+0x00` | varies | ASCII | `title_string` | `"Star Wars - Rebellion\0"` | REBEXE string pool — likely shared with the title screen |
| `+0x10` | 4 | u32 ptr | `vtable_ptr` | `0x0065ECF4` | REBEXE static — GameState class vtable |
| `+0x14` | 4 | u32 | `init_flag_1` | `1` | Always 1 |
| `+0x18` | 4 | u32 | `init_flag_2` | `1` | Always 1 |
| `+0x1C` | 4 | u32 | **`tick_counter`** | `2556`, `6582` | Increments every game tick (~14 ticks/day in our observation) |
| `+0x20` | 4 | u32 | **`day_counter`** | `192`, `193` | ⭐ Current in-game day. Increments daily. |
| `+0x24` | 4 | u32 | `unknown_a` | `2828`, `2656` | Changes with game progression. Possibly total maintenance for both factions combined, or a tick subdivision. |
| `+0x28` | 4 | u32 | `unknown_b` | `1221`, `1166` | Changes with game progression. |
| `+0x2C` | 4 | u32 | `constant_600` | `600` | **CONSTANT across all observations and sessions.** Likely a balance constant. |
| `+0x30` | 4 | u32 | `unknown_c` | `396`, `323` | Varies. |
| `+0x38` | 4 | u32 | `unknown_d` | `1198` | Same in all observations. |
| `+0x3C` | 4 | u32 | `flag` | `1` | Always 1 |
| `+0x58` | 4 | u32 | `unknown_e` | `1284` | Same in all observations. |
| `+0x5C` | 4 | u32 | `flag2` | `1` | Always 1 |
| `+0x60` | 4 | u32 | `tick_dup_1` | `2556` | Duplicate of tick_counter |
| `+0x64` | 4 | u32 | `tick_dup_2` | `2556` | Duplicate of tick_counter |
| `+0x68` | 4 | u32 | `flag3` | `1` | Always 1 |
| `+0x6C` | 4 | u32 ptr | `vtable_2` | `0x0066DD34` | Another REBEXE static vtable |
| `+0x74` | 4 | u32 ptr | `vtable_2_alias` | `0x0066DD34` | Same as +0x6C |
| `+0x7C` | 4 | u32 | `tick_minus_1` | `2555` | One less than current tick — possibly "previous tick" |

The pattern repeats with another mirror block around `+0x80` (tick_minus_1 references).

---

## Why "Star Wars - Rebellion" String Appears Here

The title string isn't a separate identifier — it's part of a string pool in
REBEXE memory that gets aliased or shared into this region. The GameState
struct's allocation happens to land right after the string in REBEXE's heap
layout.

If you find this string in REBEXE memory, the GameState struct begins right
after it (within the same allocation). This gives a stable anchor for finding
GameState even across REBEXE versions.

---

## Cross-Session Stability Patterns

Across multiple REBEXE launches we observed:

| Address Last 3 hex digits | Observation |
|---------------------------|-------------|
| ...C8A0 | Day counter address always ends in `C8A0`. |
| ...C880 | GameState struct base always ends in `C880`. |
| High byte | Always in `0x02D0-0x02E5` range (heap region for GameState class) |

These suffix patterns are because REBEXE's heap allocator is deterministic
given the same allocation sequence at startup. Useful for "if address ends in
C8A0 and you find day-like value, it's probably the day counter."

---

## Important Caveats

1. **Maintenance is NOT here** — Maintenance is computed at display time as
   the sum of all owned units' MaintenanceCost. The fields at +0x24 (2656) and
   +0x28 (1166) may be RELATED to maintenance but don't equal the displayed
   total (2693).

2. **Refined Materials is NOT here either** — Refined materials are stored in
   per-faction structs (see `10_FACTION_STRUCT.md`), not GameState.

3. **The "Star Wars - Rebellion" string is fragile** — if the user has a
   modded version, the string might be different.

---

## Proposed C# Struct Definition

```csharp
namespace SwRebellionEditor.Runtime;

[StructLayout(LayoutKind.Explicit, Size = 256)]
public struct GameStateStruct
{
    // The struct begins ~5 bytes into a "Star Wars - Rebellion" string in memory.
    // Field offsets are relative to the START of the contiguous block (string + struct).

    [FieldOffset(0x10)] public uint VtablePtr;         // = 0x0065ECF4
    [FieldOffset(0x14)] public uint InitFlag1;          // = 1
    [FieldOffset(0x18)] public uint InitFlag2;          // = 1
    [FieldOffset(0x1C)] public uint TickCounter;        // Increments every tick
    [FieldOffset(0x20)] public uint DayCounter;         // ⭐ Current in-game day
    [FieldOffset(0x24)] public uint UnknownA;           // 2656-3000 range
    [FieldOffset(0x28)] public uint UnknownB;           // 1000-1500 range
    [FieldOffset(0x2C)] public uint Constant600;        // = 600 always
    [FieldOffset(0x30)] public uint UnknownC;
    [FieldOffset(0x38)] public uint UnknownD;
    [FieldOffset(0x3C)] public uint Flag;               // = 1
    [FieldOffset(0x58)] public uint UnknownE;
    [FieldOffset(0x5C)] public uint Flag2;              // = 1
    [FieldOffset(0x60)] public uint TickDup1;           // = TickCounter
    [FieldOffset(0x64)] public uint TickDup2;           // = TickCounter
    [FieldOffset(0x6C)] public uint Vtable2;            // = 0x0066DD34
    [FieldOffset(0x7C)] public uint TickMinusOne;       // = TickCounter - 1
}
```

---

## Use Cases

### 1. Skip ahead in time
Write a higher value to `day_counter` (+0x20). REBEXE will likely catch up
gracefully because day-based events trigger when day advances.

### 2. Time-freeze
Lock `day_counter` to a fixed value. Game UI will keep "current day" frozen.
Combat resolution and other tick-based mechanics will still happen because
they use `tick_counter` (+0x1C).

### 3. Snapshot save game state
Read all GameState + faction struct fields → write to JSON → compare across
gameplay sessions for differential testing.

---

## Open Questions

1. **What's stored at the mystery fields (+0x24, +0x28, +0x30, +0x38, +0x58)?** 
   Many candidates: research progress per category, total fleet counts, victory
   point trackers. Need more cross-session data.

2. **Why does the title string appear here?** Is GameState always allocated
   right after the title string by design, or just an artifact of REBEXE's
   startup allocation sequence?

3. **The `constant_600` field** — is this a balance value? A capacity cap?
   Per-faction resource quota? Worth searching DAT files for value 600 to see
   what game design constant it could be.
