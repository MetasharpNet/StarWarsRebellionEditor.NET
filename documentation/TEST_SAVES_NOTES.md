# Test Saves & Verification Notes

## Test Save Files Used

3 real save files at known game states, used to verify all findings:

| File | Save Name | Game State | File Size |
|------|-----------|------------|-----------|
| SAVEGAME.001 | "RUST_TEST" | Day 0 / early game | 764,410 bytes |
| SAVEGAME.002 | "RUST_TEST_70DAYS" | Day 70 | 814,050 bytes |
| SAVEGAME.003 | "130DAYS_RUST" | Day 130 | 824,350 bytes |

(File names = `SAVEGAME.NNN` where NNN matches save slot number 1-9 in REBEXE.)

## Verification Results

Python reference parser (included as `06_PYTHON_REFERENCE_PARSER.py`) passes
**67 of 67** assertions across all 3 saves:

```
PARSER VERIFICATION SUITE
======================================================================
Loaded 173 identifiers from Identifiers.cs
Parser has 93 entity types mapped
Parser has 6 faction markers mapped

=== SAVEGAME.001 ===
  [OK] Format version = 1 (got 1)
  [OK] File size > 0 (764,410 bytes)
  [OK] Save name parsed ('RUST_TEST')
  [OK] Save iteration >= 1 (got 1)
  [OK] Entities found (54)
  [OK] Has Fleets (found 23)
  [OK] Alliance pairing: 0x41 count (13) == 0x51 count (13)
  [OK] Empire pairing: 0x81 count (12) == 0xA1 count (12)
  ... (13 assertions for S1)

=== SAVEGAME.002 ===
  [OK] Format version = 1
  [OK] Entities found (68)
  [OK] Alliance pairing: 13 == 13
  [OK] Empire pairing: 14 == 14
  [INFO] Characters found: {Grammel, Brandei, Luke_Skywalker, Ozzel, Piett}
  ... (24 assertions for S2)

=== SAVEGAME.003 ===
  [OK] Format version = 1
  [OK] Entities found (67)
  [OK] Alliance pairing: 11 == 11
  [OK] Empire pairing: 17 == 17
  [INFO] Characters found: {Grammel, Daala, Needa, Brandei, Ozzel, Piett, Screed}
  ... (30 assertions for S3)

======================================================================
RESULTS: 67 passed, 0 failed
======================================================================
```

## Notable Findings

### Character verification across saves

Characters with their Identifiers.cs subtype, verified in saves:
- Piett (0x382), Ozzel (0x381), Grammel (0x389), Brandei (0x384)
- Luke Skywalker (0x242)
- Daala (0x393), Needa (0x38C), Screed (0x390)

Each character correctly mapped to its name from Identifiers.cs.

### Entity counts grow with game time

| Type | S1 (day 0) | S2 (day 70) | S3 (day 130) |
|------|-----------|-------------|--------------|
| Fleets | 23 | 19 | 18 |
| Medium Transports | 9 | 12 | 11 |
| Corellian Corvettes | 8 | 9 | 9 |
| Galleons | 6 | 6 | 6 |
| Imperial Star Destroyers | 4 | 4 | 4 |
| Total entities | 54 | 68 | 67 |
| Total messages | 9 | 50 | 25 |

Entity count grows initially then stabilizes. Message count varies based
on how many events occurred between saves.

### Message log evolution

S1 (day 0): just 9 startup notifications  
S2 (day 70): 21 mission reports, 10 battle events, 9 tutorials viewed, 9 notifications, 1 construction status  
S3 (day 130): fewer mission reports (1) suggests player wrapped up missions before saving

## Setup for Other Contributors

To verify on your own saves:

```bash
# Clone our parser
git clone <this-repo>
cd contributions/SwRebellionEditor

# Run parser on your save
python 06_PYTHON_REFERENCE_PARSER.py path/to/SAVEGAME.001
```

To create new test saves:
1. Start REBEXE.EXE
2. Load any game (or start new)
3. Play to a known state (write down: current day, fleet count, etc.)
4. Save to slot 1 with descriptive name like "TEST_DAY_X"
5. Save file appears at `SAVEGAME.001` in game directory
