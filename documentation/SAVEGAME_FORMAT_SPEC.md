# SAVEGAME.001 File Format Specification

This document specifies the structure of `SAVEGAME.001`-`SAVEGAME.009` files
created by Star Wars: Rebellion.

**Status**: Partially reverse-engineered (entity records and message records fully decoded; some header fields and per-entity payloads still unknown).

**Verified against**: 3 real save files at known game states (day 0, day 70, day 130).

---

## High-Level Structure

```
+-----------------------+
| File Header           |   length-prefixed save name
+-----------------------+
| Data Section          |
|   - GameState fields  |
|   - Entity records    |   ~50-70 entities depending on game progress
|   - Message log       |   UI events, mission reports, tutorials seen
|   - (unknown trailing)|
+-----------------------+
```

**No "REBX" magic bytes.** The file starts directly with the save name's length prefix.

---

## 1. File Header

```
Offset  Size  Field           Type     Description
------  ----  --------------  -------  -------------------------------------
0x00    2     name_length     u16 LE   Length of save name string (typically 1-50)
0x02    N     save_name       ASCII    Player-entered save name (no null term)
0x02+N  ...   data_section    bytes    Begins immediately after save name
```

### Verified examples

| File | Bytes 0-N | Decoded |
|------|-----------|---------|
| Test save 1 | `09 00 52 55 53 54 5F 54 45 53 54` | length=9, name="RUST_TEST" |
| Test save 2 | `10 00 52 55 53 54 5F 54 45 53 54 5F 37 30 44 41 59 53` | length=16, name="RUST_TEST_70DAYS" |
| Test save 3 | `0C 00 31 33 30 44 41 59 53 5F 52 55 53 54` | length=12, name="130DAYS_RUST" |

---

## 2. Data Section Header (16 bytes)

The first 16 bytes after the save name are **identical across all saves** for
the first 12 bytes, with byte 12-15 varying as a save iteration counter:

```
Offset  Size  Field           Value                Notes
------  ----  --------------  -------------------  ---------------------
+0x00   4     format_version  u32 = 1              Constant across all saves
+0x04   4     reserved_1      u32 = 0              Constant
+0x08   4     reserved_2      u32 = 1              Constant
+0x0C   4     save_iteration  u32 = 1, 2, 3...     Increments per save
```

### Bytes +0x10 onward (still varying analysis)

```
Offset  Size  S1    S2    S3    Notes
------  ----  ----  ----  ----  -----
+0x10   4     ?     ?     ?     possibly entity_count or version field
+0x14   4     0     0     0     reserved/padding
+0x18   4     35    42    38    counter (unknown — possibly system count, day-related, or research index)
+0x1C   4     1     1     1     constant flag
+0x20   4     2     2     2     possibly faction_count (always 2 in vanilla)
+0x28   4     0     0.9f  0.9f  S1 has 0, S2/S3 have IEEE float 0.9 — possibly difficulty modifier
+0x2C   4     55    62    58    counter (varies with game progress)
+0x30   4     59    66    62    counter
+0x40   4     61    1878  1284  larger counter (S2/S3 much higher than S1)
+0x50   4     91    98    94    counter (~+7 between S1→S2)
+0x54   4     95    102   98    counter (~+7 between S1→S2)
```

Many of these are likely sub-counts that the existing DAT-file-schema work might decode given enough comparison saves.

---

## 3. Entity Record Format

Game entities (Fleets, Ships, Characters, Buildings) are embedded as records
throughout the file. Each record follows this pattern:

```
Offset  Size  Field            Type      Description
------  ----  ---------------  --------  -----------------------------------
+0x00   1     marker_lo        u8 = 0x00
+0x01   1     marker_hi        u8 = 0x00
+0x02   1     faction          u8        Faction marker (see section 4)
+0x03   1     pad              u8 = 0x00
+0x04   1     pad              u8 = 0x00
+0x05   1     position_marker  u8        0x80 = sector position, 0x90 = system position
+0x06   4     entity_subtype   u32 LE    Low 16 bits of full Identifier
+0x0A   4     count            u32 LE    Usually 1
+0x0E   2     name_length      u16 LE    Length of name string
+0x10   N     name             ASCII     Entity name (no null term)
+0x10+N ...   extra_data       bytes     Type-specific trailing data (NOT YET DECODED)
```

### Critical detail: subtype vs full ID

The save file stores only the **low 16 bits** of the full 32-bit Identifier
from `Identifiers.cs`. The high family byte is encoded elsewhere — likely 12
bytes BEFORE the record start (see character record analysis below).

To get the full Identifier:
1. Read the subtype field at +0x06
2. Read 4 bytes at offset `record_start - 12` to get family byte
3. Combine: `full_id = (family << 24) | subtype`

### Character record example (General Piett)

```
Bytes 32 BEFORE the record start, then the record:
15 00 00 00  CC 00 00 00  00 00 00 00  38 00 00 00  <- family (0x38 MinorCharacter)
82 03 00 00                                            <- subtype (0x0382 Piett)
[81 00 00 80] <- record header detected here (faction=0x81 Empire, marker=0x80 sector)
82 03 00 00 01 00 00 00 0D 00                          <- subtype repeat, count, name_len
"General Piett"                                        <- 13-byte ASCII name
```

Combined: `0x38000382 = Piett` (exact match with Identifiers.cs).

### Pattern signature for scanning

To find all entity records:

```python
pattern = rb'\x00\x00.\x00\x00[\x80\x90]'  # 6 bytes: 00 00 [faction] 00 00 [80|90]
```

Match offsets are entity record starts. See `06_PYTHON_REFERENCE_PARSER.py` for full implementation.

---

## 4. Faction Markers

Faction markers appear at offset +0x02 of every entity record:

| Byte | Meaning |
|------|---------|
| 0x41 | Alliance (primary record) |
| 0x51 | Alliance (paired/child record) |
| 0x62 | Alliance (variant — observed in some saves) |
| 0x81 | Empire (primary record) |
| 0xA1 | Empire (paired/child record) |
| 0x92 | System/Special (rare, 1-2 occurrences per save) |

### Faction pairing observation

Counts always match exactly within pairs:

| Save | 0x41 | 0x51 | 0x81 | 0xA1 |
|------|------|------|------|------|
| S1   | 13   | 13   | 12   | 12   |
| S2   | 13   | 13   | 14   | 14   |
| S3   | 11   | 11   | 17   | 17   |

This suggests each entity gets TWO records — one as the entity itself (primary)
and one as a reference within a parent container (alt/paired). See
`04_FACTION_PAIRING_DISCOVERY.md`.

---

## 5. Position Markers (Byte +0x05)

| Byte | Meaning |
|------|---------|
| 0x80 | Entity positioned in a Sector (from `Identifiers.cs` SectorByte) |
| 0x90 | Entity positioned on a System (SystemByte) |

This explains why fleets (in space) have 0x80 while Construction Yards (on planets) have 0x90.

---

## 6. Message Log Records

The save also contains UI events, mission reports, tutorials seen, etc.
These use distinct header patterns:

| Header Pattern (8 bytes hex) | Category | Examples |
|------------------------------|----------|----------|
| `10 00 00 00 10 00 00 00` | mission_report | "Leia Organa Mission Report", "Han Solo Captured" |
| `00 01 00 00 10 00 00 00` | battle_event | "Orbital bombardment of Bortras" |
| `00 02 00 00 10 00 00 00` | tutorial_topic | "Maintenance Points", "Fleet Window" |
| `00 02 00 00 00 00 00 00` | notification | "Advice Available", "Furthering Our Cause" |
| `08 00 00 00 10 00 00 00` | construction_status | "Construction Yard Idle on Klatooine" |

Followed by `u16 name_length + ASCII name`.

See `03_MESSAGE_LOG_PATTERNS.md` for full details.

---

## 7. Known Entity Type IDs Cross-Reference

These low-16-bit subtypes were verified in saves and match Identifiers.cs full IDs:

| Subtype | Full ID | Name |
|---------|---------|------|
| 0x04 | (Fleet container) | Fleet |
| 0x41 | 0x14000041 | Bulk_Cruiser |
| 0x45 | 0x14000045 | Corellian_Corvette |
| 0x46 | 0x14000046 | Medium_Transport |
| 0x84 | 0x14000084 | Victory_Destroyer |
| 0x85 | 0x14000085 | Imperial_Star_Destroyer |
| 0x89 | 0x14000089 | Galleon |
| 0x109 | 0x90000109 | Coruscant (system reference) |
| 0x242 | 0x32000242 | Luke_Skywalker |
| 0x381 | 0x38000381 | Ozzel |
| 0x382 | 0x38000382 | Piett |
| 0x384 | 0x38000384 | Brandei |
| 0x389 | 0x38000389 | Grammel |
| 0x38C | 0x3800038C | Needa |
| 0x390 | 0x38000390 | Screed |
| 0x393 | 0x38000393 | Daala |

---

## 8. Unknown / TODO

These need further reverse-engineering work:

- **Current day counter location** — variable position (after entity list which has variable length)
- **Resource pool values** (Raw Materials, Refined Materials, Maintenance)
- **System ownership/loyalty** per planet
- **Character assignment** (which character is commanding which fleet)
- **Mission queue** (active player missions)
- **Per-entity payload structure** (bytes after the name field)
- **Header bytes** +0x10 through +0x60 of data section

---

## Verification

Python reference parser available in `06_PYTHON_REFERENCE_PARSER.py`. Passes
67/67 assertions on real save files:
- Format version correctly identified
- Entity counts match expectations
- Faction pairing math verified
- All character/ship names extracted cleanly
- All record offsets unique and within file bounds
