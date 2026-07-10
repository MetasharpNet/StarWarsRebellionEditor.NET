# Runtime Memory Analysis Notes

How REBEXE.EXE loads and manages its data in memory at runtime. Useful for:
- Live game inspection (without modifying saves)
- Verifying DAT file edits actually loaded
- Building "live edit" features in the editor

---

## DAT Files Are Loaded Into Static Memory

When REBEXE starts, it loads all `.DAT` files (GNPRTB, CAPSHPSD, etc.) into
predictable memory regions. These addresses tend to be **stable across game
restarts** because:

1. REBEXE has a fixed image base (0x00400000)
2. The 1998 binary predates ASLR
3. DAT data is loaded into specific high-address regions early in startup

In our testing, the value at address `0x623675E8` consistently held the same value (699)
across multiple REBEXE process launches. This region is in a high virtual address (~1.6 GB),
likely a memory-mapped or fixed-address region for DAT data.

### Implication for editor

If you can find the memory addresses where DAT data lives at runtime, you
could potentially edit values **without saving the DAT file** — i.e., live
hot-reload of game balance changes during play.

---

## GameState Is Heap-Allocated

Unlike DAT data, the live `GameState` struct is allocated on the heap and
its address **changes every REBEXE launch**.

In our testing, we found the day counter at:
- Run 1: `0x02E1C8A0`
- Run 2: different address (process re-launched)

The day counter was identified by:
1. Scanning all REBEXE memory for the current day value
2. Waiting for game to advance to next day
3. Re-scanning for the new value
4. Repeating to narrow down to a single address

### GameState surrounding fields (from memory dumps)

At the GameState heap location, we observed this layout:

```
+0x00  string fragment   ("...Star Wars - Rebellion" plus next strings)
+0x10  pointer            -> REBEXE static data (likely vtable for GameState class)
+0x14  u32 = 1            init/active flag
+0x18  u32 = 1            secondary flag
+0x1C  u32                tick counter (3675 = ~50 days × 73 ticks/day)
+0x20  u32                DAY COUNTER ⭐
+0x24  u32                unknown counter (380 → ?, varies by save)
+0x28  u32                unknown counter (371 → ?)
+0x2C  u32                unknown counter (600 → ?, stayed constant in obs)
+0x30  u32                unknown counter (263 → 152, changed in obs)
+0x34  u32 = 0            padding/reserved
+0x38  u32 = 0            padding/reserved
+0x3C  u32 = 1            flag
```

The 4 mystery counters at +0x24/+0x28/+0x2C/+0x30 are likely some combination
of resources, mission points, or other faction-level state. Their exact
semantics require more comparison data.

---

## How to Find GameState Address Dynamically

For runtime editor features, you'd need a way to find GameState's current
heap address. Two approaches:

### Approach 1: Value-based search (what we used)

```python
# Pseudocode
process = OpenProcess("REBEXE.EXE", PROCESS_VM_READ)
current_day = get_day_from_ui()  # ask user to tell us
candidates = scan_memory_for_value(process, current_day, type=u32)

wait_for_day_change()
new_day = current_day + 1
candidates = scan_memory_for_value(process, new_day, type=u32, restrict_to=candidates)

# After 2-3 day changes, candidates narrows to a single address = day counter
```

### Approach 2: Static pointer scan (preferred for production)

The GameState struct must be reachable from some static REBEXE pointer.
Use pattern-scanning to find the assembly instruction that loads the
GameState pointer:

```
; Hypothetical REBEXE assembly:
mov eax, [0x005FE800]  ; load GameState* from static address
mov ecx, [eax+0x20]    ; load current_day field
```

If we find the byte pattern of this instruction in REBEXE's `.text` section,
we can extract `0x005FE800` and dereference it at runtime to get the current
GameState address. This pattern is stable across REBEXE launches because
the executable's `.text` section is identical.

`pymem` library provides `pattern_scan_module()` for this exact pattern.

---

## Critical Distinction: Stored vs Computed Values

Some UI values are NOT stored in saves and NOT directly stored in any one
memory address — they're **computed on-demand**.

| UI Value | Stored in Save? | Stored in Memory? | Source |
|----------|-----------------|--------------------|--------|
| Day counter | ✅ Yes | ✅ Yes (GameState +0x20) | Direct field |
| Raw Materials pool | ✅ Yes | ✅ Yes | (location TBD) |
| Refined Materials pool | ✅ Yes | ✅ Yes | (location TBD) |
| **Maintenance** | ❌ No | ❌ Not directly | **Computed**: sum of all owned units' `MaintenanceCost` from CAPSHPSD/FIGHTSD/TROOPSD/MJCHARSD/MNCHARSD |
| **Tick counter** | ❌ No | ✅ Yes (GameState +0x1C) | Derived from day + sub-tick |
| Production rates | ❌ No | ✅ Yes (cached) | Computed from facilities |

This matters for editor features: changing "maintenance" in the save isn't
meaningful because it'll be recomputed on load.

---

## Recommended Tools

Two Python libraries we found extremely useful for runtime analysis:

### `pymem` (https://pypi.org/project/Pymem/)
- Simple read/write of process memory
- Pattern scanning with wildcards
- `pip install pymem`

### `Frida` (https://frida.re/)
- Hook any function in running REBEXE
- Inject JavaScript that runs INSIDE the process
- Intercept Windows messages, file I/O, malloc, etc.
- `pip install frida frida-tools`

Example combined use:
```python
import pymem
import frida

pm = pymem.Pymem("REBEXE.EXE")
day_counter = pm.read_int(0x02E1C8A0)  # read live value

session = frida.attach("REBEXE.EXE")
script = session.create_script("""
    // Hook DispatchMessageA to log every UI input
    Interceptor.attach(Module.getExportByName('user32.dll', 'DispatchMessageA'), {
        onEnter: function(args) { send({msg: 'input event'}); }
    });
""")
script.load()
```

---

## Suggested Editor Feature: Live Mode

A "Live Mode" tab in the editor could:

1. Attach to running REBEXE via `pymem` (no admin if launching as user)
2. Detect GameState address via pattern scan
3. Display current values in real-time (day, resources, etc.)
4. Allow direct editing of values (write back via `pymem.write_int()`)

This complements the existing DAT-file editing — instead of "edit DAT then
restart game", users could tweak values mid-game.

Caveats:
- Requires Admin (process memory access)
- Heap addresses change per launch — need pattern scanning
- Some values are computed, not stored — editing them won't stick
