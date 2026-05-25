# UI Message Log Patterns

Save files contain a complete log of UI events, mission reports, and tutorial
topics the player has seen. These follow 5 distinct header patterns.

This is currently NOT captured anywhere in the editor — adding support would
unlock features like "show mission history", "list tutorials seen", or
"replay battle log".

---

## Pattern Table

Each pattern is 8 bytes, followed by a `u16 text_length` and the ASCII text.

| Header bytes (hex) | Category | Example records |
|---|---|---|
| `10 00 00 00 10 00 00 00` | Mission Report | "Leia Organa Mission Report", "Han Solo Captured", "Chewbacca Captured", "Diplomacy Mission Report", "Brandei Captured" |
| `00 01 00 00 10 00 00 00` | Battle Event | "Orbital bombardment of Bortras" (repeated × 10 turns), "Orbital bombardment of Uvena" |
| `00 02 00 00 10 00 00 00` | Tutorial Topic | "Maintenance Points", "Fleet Window", "Galaxy Overview", "Characters and Special Forces" |
| `00 02 00 00 00 00 00 00` | Notification | "Advice Available", "Furthering Our Cause", "Adjusting Time", "Manufacturing New Items" |
| `08 00 00 00 10 00 00 00` | Construction Status | "Construction Yard Idle on Klatooine", "Construction Yard Deployed at Byss" |

---

## Counts in Test Saves

| Save | Mission | Battle | Tutorial | Notification | Construction | Total |
|------|---------|--------|----------|--------------|--------------|-------|
| S1 (RUST_TEST, day 0)     | 0  | 0  | 0  | 9 | 0 | 9 |
| S2 (RUST_TEST_70DAYS)     | 21 | 10 | 9  | 9 | 1 | 50 |
| S3 (130DAYS_RUST)         | 1  | 1  | 7  | 9 | 7 | 25 |

Notes:
- The 9 notifications appear in all 3 saves identically — these are the **default tutorial popup queue** seeded at game start
- Battle/mission counts grow with game progress (S2 has more than S3 because the player wrapped up missions before saving S3)
- Construction status messages appear when players queue up or deploy Construction Yards

---

## Record Structure

```
Offset  Size  Field
------  ----  ---------
+0      8     Pattern (one of the 5 above)
+8      2     u16 text_length
+10     N     ASCII text
```

### Example: "Han Solo Captured"

```
10 00 00 00 10 00 00 00      <- mission_report pattern
11 00                          <- text_length = 17 = 0x11
"Han Solo Captured"            <- 17 bytes
```

---

## Edge Cases

### Repeated battle events

In SAVEGAME.002 (day 70), "Orbital bombardment of Bortras" appears **7 times**
as separate records. Each appears to be a per-turn entry — the save preserves
the full turn-by-turn battle log, not just unique events.

### Multi-event sequences

Mission report patterns can contain related events for the same mission:
- "Leia Organa Mission Report" (start)
- "Han Solo Mission Foiled" (failure event)
- "Han Solo Captured" (resolution)
- "Brandei Captured" (related capture)

These appear sequentially in the save.

---

## Proposed C# Enum

```csharp
namespace SwRebellionEditor;

public enum MessageCategory
{
    MissionReport,        // Pattern: 10 00 00 00 10 00 00 00
    BattleEvent,          // Pattern: 00 01 00 00 10 00 00 00
    TutorialTopic,        // Pattern: 00 02 00 00 10 00 00 00
    Notification,         // Pattern: 00 02 00 00 00 00 00 00
    ConstructionStatus,   // Pattern: 08 00 00 00 10 00 00 00
}

public static class MessagePatterns
{
    public static readonly Dictionary<MessageCategory, byte[]> Headers = new()
    {
        [MessageCategory.MissionReport]      = new byte[] {0x10,0x00,0x00,0x00,0x10,0x00,0x00,0x00},
        [MessageCategory.BattleEvent]        = new byte[] {0x00,0x01,0x00,0x00,0x10,0x00,0x00,0x00},
        [MessageCategory.TutorialTopic]      = new byte[] {0x00,0x02,0x00,0x00,0x10,0x00,0x00,0x00},
        [MessageCategory.Notification]       = new byte[] {0x00,0x02,0x00,0x00,0x00,0x00,0x00,0x00},
        [MessageCategory.ConstructionStatus] = new byte[] {0x08,0x00,0x00,0x00,0x10,0x00,0x00,0x00},
    };
}
```

---

## Use Cases

Adding message log support would enable editor features like:
- **"Reset Tutorial Status"** — clear the tutorial_topic records so popups re-appear
- **"Mission History Browser"** — show all mission reports in chronological order
- **"Battle Log Viewer"** — see every orbital bombardment, every assault
- **"Game Summary"** — generate a narrative from the message log
- **"Clear Notifications"** — remove pending notifications without loading game

---

## Verified by

`tools/rebellion_save_parser.py` extracts all 5 categories. Cross-verified by
viewing extracted text — all messages match in-game UI strings.
