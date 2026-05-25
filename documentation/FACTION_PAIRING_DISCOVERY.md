# Faction Marker Pairing Discovery

A subtle but important discovery: **entity records appear in PAIRS** with
related faction markers.

This means every entity (Fleet, Character, Capital Ship) typically has TWO
records in the save file — not just one.

---

## The Pattern

Faction markers come in pairs that always have **identical counts** in any
given save:

| Primary | Paired Alt | Affiliation |
|---------|-----------|-------------|
| 0x41 | 0x51 | Alliance |
| 0x81 | 0xA1 | Empire |

### Evidence: counts always match

| Save File | 0x41 count | 0x51 count | 0x81 count | 0xA1 count |
|-----------|-----------|-----------|-----------|-----------|
| SAVEGAME.001 (RUST_TEST, day 0)        | 13 | 13 | 12 | 12 |
| SAVEGAME.002 (RUST_TEST_70DAYS)        | 13 | 13 | 14 | 14 |
| SAVEGAME.003 (130DAYS_RUST)            | 11 | 11 | 17 | 17 |

These counts are exact, in every save, over three different game states. This is not coincidence.

### Same entity, paired records

For example, "General Piett" appears TWICE in SAVEGAME.002:
- Once with faction marker 0x81 (Empire primary)
- Once with faction marker 0xA1 (Empire alt)

```
Found Piett at offset 0x018B76 with faction 0x81  <-- primary
Found Piett at offset 0x09548A with faction 0xA1  <-- paired
```

Same character, two records, ~487 KB apart in the file. Same applies to "Punisher" (Imperial Star Destroyer), "Hydra" (Galleon), and all other named entities.

---

## Hypothesis

The pairing likely represents two different references to the same entity:
- **Primary record (0x41/0x81)** — the entity itself, with its full game state
- **Paired record (0x51/0xA1)** — a reference within a parent container or relationship table (e.g., "fleet membership", "character assignment to ship", "system garrison")

This is consistent with how object-oriented game state would be serialized:
- Object instances written once with full data
- References written separately as part of containing objects

---

## Bit-Pattern Analysis

| Marker | Binary | Notes |
|--------|--------|-------|
| 0x41 | 0100 0001 | bit 6 set + bit 0 ("alive"?) |
| 0x51 | 0101 0001 | bits 6,4 set + bit 0 |
| 0x62 | 0110 0010 | bits 6,5 set + bit 1 (rarer variant) |
| 0x81 | 1000 0001 | bit 7 set + bit 0 |
| 0xA1 | 1010 0001 | bits 7,5 set + bit 0 |
| 0x92 | 1001 0010 | bit 7,4 set + bit 1 (rare special) |

Patterns suggest:
- **Bit 0 (=1)** = ?most? always present (active/alive flag)
- **Bit 6 (=0x40)** = Alliance side
- **Bit 7 (=0x80)** = Empire side
- **Bit 4 (=0x10)** = "alt/paired" marker (set in 0x51 and 0xA1)
- **Bit 5 (=0x20)** = secondary variant (set in 0xA1, 0x62)

Possible higher-level interpretation:
```
Primary records:   0x41 (Alliance) / 0x81 (Empire)
Paired/Alt:        0x51 (Alliance) / 0xA1 (Empire)  -- bit 4 set means "alternate"
Variants:          0x62 (Alliance variant) / 0x92 (Special)
```

---

## Implications for Editor

When making changes to entities, the editor needs to update BOTH records to
keep the save consistent. Specifically:

1. **Renaming an entity** must update both the primary AND alt records
2. **Adding a new entity** requires adding BOTH records
3. **Removing an entity** requires removing BOTH records

Failing to do this could leave dangling references that cause game crashes or
inconsistent UI state.

---

## Proposed Editor Helper

```csharp
public static class EntityHelper
{
    /// <summary>
    /// Get the paired faction marker for a given primary marker.
    /// </summary>
    public static byte? GetPairedMarker(byte primary) => primary switch
    {
        0x41 => 0x51,
        0x51 => 0x41,
        0x81 => 0xA1,
        0xA1 => 0x81,
        _ => null,
    };

    /// <summary>
    /// Find both records (primary + paired) for a named entity in a save.
    /// </summary>
    public static (SaveEntity? primary, SaveEntity? paired) FindBothRecords(
        SAVEGAME save, string entityName)
    {
        var matches = save.Entities.Where(e => e.Name == entityName).ToList();
        if (matches.Count == 0) return (null, null);
        if (matches.Count == 1) return (matches[0], null);

        // Find the pair: same name, one is primary, one is alt
        var primary = matches.FirstOrDefault(e => (byte)e.Faction == 0x41 || (byte)e.Faction == 0x81);
        var paired  = matches.FirstOrDefault(e => (byte)e.Faction == 0x51 || (byte)e.Faction == 0xA1);
        return (primary, paired);
    }
}
```

---

## Open Questions

1. Is one record always "active state" and the other "definition"? Or are they truly mirrored?
2. Why does 0x62 (Alliance variant) appear only in some saves but not others?
3. What does 0x92 (only 1-2 occurrences per save) represent?

Further work needed: examine the bytes AFTER the entity name in primary vs
paired records — if their trailing data differs, that confirms different roles.
