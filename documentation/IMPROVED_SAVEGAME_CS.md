# Proposed Replacement for `SwRebellionEditor/SaveGame/SAVEGAME.cs`

The current `SAVEGAME.cs` uses `test001`-`test030` placeholders and assumes a
fixed-size 4-u32 header followed by 200 records of 30 u32s each.

The actual format is variable-length sequential records (see
`01_SAVEGAME_FORMAT_SPEC.md`). Below is a proposed replacement that matches
the real format.

---

## Proposed `SAVEGAME.cs`

```csharp
namespace SwRebellionEditor;

public class SAVEGAME
{
    public string SaveName;
    public uint FormatVersion;       // always 1
    public uint Reserved1;            // always 0
    public uint Reserved2;            // always 1
    public uint SaveIteration;        // increments per save (1, 2, 3...)
    public byte[] DataSectionHeader;  // remaining header bytes (varies)

    public List<SaveEntity> Entities;
    public List<SaveMessage> Messages;

    public static SAVEGAME Load(string path)
    {
        var bytes = File.ReadAllBytes(path);
        var save = new SAVEGAME();

        // Parse length-prefixed save name
        int offset = 0;
        ushort nameLen = BitConverter.ToUInt16(bytes, offset);
        offset += 2;
        save.SaveName = Encoding.ASCII.GetString(bytes, offset, nameLen);
        offset += nameLen;

        // Parse fixed header (16 bytes after save name)
        save.FormatVersion  = BitConverter.ToUInt32(bytes, offset + 0);
        save.Reserved1      = BitConverter.ToUInt32(bytes, offset + 4);
        save.Reserved2      = BitConverter.ToUInt32(bytes, offset + 8);
        save.SaveIteration  = BitConverter.ToUInt32(bytes, offset + 12);

        // Walk file scanning for entity records
        save.Entities = ParseEntities(bytes);
        save.Messages = ParseMessages(bytes);

        return save;
    }

    private static List<SaveEntity> ParseEntities(byte[] data)
    {
        var entities = new List<SaveEntity>();
        for (int i = 0; i < data.Length - 16; i++)
        {
            // Entity signature: 00 00 [faction] 00 00 [marker:0x80|0x90]
            if (data[i] != 0x00 || data[i+1] != 0x00 ||
                data[i+3] != 0x00 || data[i+4] != 0x00 ||
                (data[i+5] != 0x80 && data[i+5] != 0x90))
                continue;

            byte faction = data[i+2];
            byte marker  = data[i+5];

            if (i + 16 >= data.Length) break;

            uint subtype = BitConverter.ToUInt32(data, i + 6);
            uint count   = BitConverter.ToUInt32(data, i + 10);
            ushort nameLen = BitConverter.ToUInt16(data, i + 14);

            // Sanity checks
            if (nameLen < 1 || nameLen >= 80) continue;
            if (count < 1 || count > 1000) continue;
            if (subtype >= 0x1000) continue;  // subtypes we've seen are small
            if (i + 16 + nameLen > data.Length) continue;

            // Check name is printable ASCII
            bool allPrintable = true;
            for (int j = 0; j < nameLen; j++)
            {
                if (data[i + 16 + j] < 32 || data[i + 16 + j] >= 127)
                {
                    allPrintable = false;
                    break;
                }
            }
            if (!allPrintable) continue;

            string name = Encoding.ASCII.GetString(data, i + 16, nameLen);

            // Look back 12 bytes to find the family byte
            byte family = 0;
            if (i >= 12)
                family = data[i - 12];

            uint fullId = ((uint)family << 24) | subtype;

            entities.Add(new SaveEntity
            {
                Offset = i,
                FullIdentifier = (Identifiers)fullId,
                Subtype = subtype,
                Family = family,
                Faction = (FactionMarker)faction,
                PositionMarker = (PositionMarker)marker,
                Count = count,
                Name = name,
            });

            i += 16 + nameLen - 1;  // skip past this record
        }
        return entities;
    }

    private static List<SaveMessage> ParseMessages(byte[] data)
    {
        var messages = new List<SaveMessage>();
        var patterns = new Dictionary<byte[], MessageCategory>
        {
            { new byte[] {0x10,0x00,0x00,0x00,0x10,0x00,0x00,0x00}, MessageCategory.MissionReport },
            { new byte[] {0x00,0x01,0x00,0x00,0x10,0x00,0x00,0x00}, MessageCategory.BattleEvent },
            { new byte[] {0x00,0x02,0x00,0x00,0x10,0x00,0x00,0x00}, MessageCategory.TutorialTopic },
            { new byte[] {0x00,0x02,0x00,0x00,0x00,0x00,0x00,0x00}, MessageCategory.Notification },
            { new byte[] {0x08,0x00,0x00,0x00,0x10,0x00,0x00,0x00}, MessageCategory.ConstructionStatus },
        };

        foreach (var (pattern, category) in patterns)
        {
            for (int i = 0; i < data.Length - pattern.Length - 4; i++)
            {
                if (!data.AsSpan(i, pattern.Length).SequenceEqual(pattern)) continue;

                int textStart = i + pattern.Length;
                if (textStart + 2 > data.Length) continue;

                ushort textLen = BitConverter.ToUInt16(data, textStart);
                if (textLen < 3 || textLen >= 100) continue;
                if (textStart + 2 + textLen > data.Length) continue;

                bool allPrintable = true;
                for (int j = 0; j < textLen; j++)
                {
                    if (data[textStart + 2 + j] < 32 || data[textStart + 2 + j] >= 127)
                    {
                        allPrintable = false;
                        break;
                    }
                }
                if (!allPrintable) continue;

                string text = Encoding.ASCII.GetString(data, textStart + 2, textLen);
                messages.Add(new SaveMessage
                {
                    Offset = i,
                    Category = category,
                    Text = text,
                });
            }
        }

        return messages;
    }
}

public class SaveEntity
{
    public int Offset;
    public Identifiers FullIdentifier;  // from Identifiers.cs
    public uint Subtype;                // low 16 bits
    public byte Family;                  // high byte
    public FactionMarker Faction;
    public PositionMarker PositionMarker;
    public uint Count;
    public string Name;
}

public class SaveMessage
{
    public int Offset;
    public MessageCategory Category;
    public string Text;
}

public enum FactionMarker : byte
{
    Alliance       = 0x41,
    Alliance_Alt   = 0x51,
    Alliance_Other = 0x62,
    Empire         = 0x81,
    Empire_Alt     = 0xA1,
    System         = 0x92,
}

public enum PositionMarker : byte
{
    InSector = 0x80,  // matches Identifiers.SectorByte
    OnSystem = 0x90,  // matches Identifiers.SystemByte
}

public enum MessageCategory
{
    MissionReport,
    BattleEvent,
    TutorialTopic,
    Notification,
    ConstructionStatus,
}
```

---

## Proposed `Structs/SavegameChunks.cs` Update

Replace with proper structures:

```csharp
namespace SwRebellionEditor;

// Was: 30 fields named test001-test030.
// Now: Real record structures.

public struct SaveFileHeader
{
    public ushort NameLength;
    public string SaveName;
    public uint FormatVersion;   // = 1
    public uint Reserved1;        // = 0
    public uint Reserved2;        // = 1
    public uint SaveIteration;    // 1, 2, 3, ...
}

public struct EntityRecordHeader
{
    public byte MarkerLo;          // = 0x00
    public byte MarkerHi;          // = 0x00
    public byte Faction;           // 0x41/0x51/0x62/0x81/0xA1/0x92
    public byte Pad1;              // = 0x00
    public byte Pad2;              // = 0x00
    public byte PositionMarker;    // 0x80 (sector) or 0x90 (system)
    public uint EntitySubtype;     // low 16 bits of Identifier
    public uint Count;             // typically 1
    public ushort NameLength;
    // followed by: byte[NameLength] Name
}

public struct MessageRecordHeader
{
    public byte[] Pattern;          // 8 bytes — see MessageCategory enum
    public ushort TextLength;
    // followed by: byte[TextLength] Text
}
```

---

## What this fixes

1. **Real save name parsing** instead of misinterpreting the first 4 bytes as a u32 header
2. **Variable-length file walking** instead of assuming fixed 200×120-byte records
3. **Named entity records** that link back to `Identifiers.cs`
4. **Message log support** — the existing code ignores tutorials/notifications entirely
5. **Faction enum** with all 6 observed faction markers
6. **Position marker enum** documenting the 0x80/0x90 distinction

The existing read/write logic at `LoadSaveGameData()` would be replaced
entirely with `SAVEGAME.Load(path)` shown above.
