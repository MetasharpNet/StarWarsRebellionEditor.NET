using System.Text;

namespace SwRebellionEditor;

/// <summary>
/// Parser for Star Wars: Rebellion SAVEGAME.NNN files.
///
/// Save file format (reverse-engineered, verified against 3 real saves):
///   1. Header: u16 NameLength + ASCII SaveName + 16-byte fixed header
///   2. Variable-length entity records (Fleets, Ships, Characters, Buildings)
///   3. Embedded UI message log records (mission reports, battle events, tutorials, notifications, construction status)
///
/// NOTE: The previous version of this file used `test001`-`test030` placeholders and assumed
/// a fixed 200×120-byte layout. That format spec was incorrect.
///
/// See: documentation/SAVEGAME_FORMAT_SPEC.md for full byte-level specification.
/// </summary>
public class SAVEGAME
{
    private static OpenFileDialog? openFileDialog;
    private static string SaveGameFullPathname = "";
    public static bool unsavedSaveGameData;
    private static bool lockChange;

    // Parsed file contents
    public static SaveFileHeader Header;
    public static List<SaveEntity> Entities = new();
    public static List<SaveMessage> Messages = new();
    public static byte[] RawData = Array.Empty<byte>();

    public SAVEGAME()
    {
        ClearUnsavedData();
        LoadSaveGameData(SetInitialFileName());
    }

    private static string SetInitialFileName()
    {
        if (Settings.Current.GameFolder == null)
        {
            openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                throw new Exception("No SaveGame Data File Specified");
            SetSaveGamePath(openFileDialog.FileName);
            return GetSaveGamePath();
        }
        SetSaveGamePath(Path.Combine(Settings.Current.SaveGameFolder, "SAVEGAME.003"));
        return GetSaveGamePath();
    }

    public static string GetSaveGamePath() => SaveGameFullPathname;
    public static bool SetSaveGamePath(string p) { SaveGameFullPathname = p; return true; }
    public static void SetUnsavedData() { if (!lockChange) unsavedSaveGameData = true; }
    public static void ClearUnsavedData() => unsavedSaveGameData = false;
    public static void LockChange() => lockChange = true;
    public static void UnlockChange() => lockChange = false;

    /// <summary>
    /// Load and parse a Rebellion save file.
    /// </summary>
    public static bool LoadSaveGameData(string? saveGameDataFile)
    {
        if (saveGameDataFile == null) return false;

        RawData = File.ReadAllBytes(saveGameDataFile);
        Entities = new List<SaveEntity>();
        Messages = new List<SaveMessage>();

        try
        {
            ParseHeader();
            ParseEntities();
            ParseMessages();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Save parse error: {ex.Message}");
            return false;
        }

        return true;
    }

    /// <summary>
    /// Save modified data back to disk. Currently writes raw bytes; field-level
    /// modification requires extending this method to re-serialize entity/message records.
    /// </summary>
    public static bool SaveSaveGameData(string saveFileName)
    {
        try
        {
            File.WriteAllBytes(saveFileName, RawData);
            SetSaveGamePath(saveFileName);
            ClearUnsavedData();
            return true;
        }
        catch { return false; }
    }

    public static void OpenNewSaveGameFile()
    {
        openFileDialog = new OpenFileDialog();
        if (openFileDialog.ShowDialog() != DialogResult.OK) return;
        LoadSaveGameData(openFileDialog.FileName);
        SetSaveGamePath(openFileDialog.FileName);
        ClearUnsavedData();
    }

    // ===== Parsing =====

    private static int _dataStart;

    private static void ParseHeader()
    {
        // u16 name length + ASCII save name
        ushort nameLen = BitConverter.ToUInt16(RawData, 0);
        string name = Encoding.ASCII.GetString(RawData, 2, nameLen);

        int afterName = 2 + nameLen;
        Header = new SaveFileHeader
        {
            NameLength     = nameLen,
            SaveName       = name,
            FormatVersion  = BitConverter.ToUInt32(RawData, afterName + 0),
            Reserved1      = BitConverter.ToUInt32(RawData, afterName + 4),
            Reserved2      = BitConverter.ToUInt32(RawData, afterName + 8),
            SaveIteration  = BitConverter.ToUInt32(RawData, afterName + 12),
        };
        _dataStart = afterName + 16;
    }

    private static void ParseEntities()
    {
        var data = RawData;

        for (int i = _dataStart; i < data.Length - 16; i++)
        {
            // Entity signature: 00 00 [faction] 00 00 [marker:0x80|0x90]
            if (data[i] != 0x00 || data[i + 1] != 0x00 ||
                data[i + 3] != 0x00 || data[i + 4] != 0x00 ||
                (data[i + 5] != 0x80 && data[i + 5] != 0x90))
                continue;

            byte faction = data[i + 2];
            byte marker  = data[i + 5];

            if (i + 16 >= data.Length) break;

            uint subtype  = BitConverter.ToUInt32(data, i + 6);
            uint count    = BitConverter.ToUInt32(data, i + 10);
            ushort nameLen = BitConverter.ToUInt16(data, i + 14);

            // Sanity checks
            if (nameLen < 1 || nameLen >= 80) continue;
            if (count < 1 || count > 1000) continue;
            if (subtype >= 0x1000) continue;
            if (i + 16 + nameLen > data.Length) continue;

            bool allPrintable = true;
            for (int j = 0; j < nameLen; j++)
            {
                byte b = data[i + 16 + j];
                if (b < 32 || b >= 127) { allPrintable = false; break; }
            }
            if (!allPrintable) continue;

            string name = Encoding.ASCII.GetString(data, i + 16, nameLen);

            // Family byte is stored 12 bytes BEFORE the record start in the surrounding struct
            byte family = (i >= 12) ? data[i - 12] : (byte)0;
            uint fullId = ((uint)family << 24) | subtype;

            Entities.Add(new SaveEntity
            {
                Offset         = i,
                FullIdentifier = (Identifiers)fullId,
                EntitySubtype  = subtype,
                Family         = family,
                Faction        = (FactionMarker)faction,
                PositionMarker = (PositionMarker)marker,
                Count          = count,
                Name           = name,
            });

            i += 16 + nameLen - 1;  // skip past this record
        }
    }

    private static void ParseMessages()
    {
        var data = RawData;

        foreach (var (category, pattern) in MessagePatterns.Headers)
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
                    byte b = data[textStart + 2 + j];
                    if (b < 32 || b >= 127) { allPrintable = false; break; }
                }
                if (!allPrintable) continue;

                string text = Encoding.ASCII.GetString(data, textStart + 2, textLen);
                Messages.Add(new SaveMessage
                {
                    Offset   = i,
                    Category = category,
                    Text     = text,
                });
            }
        }
    }

    // ===== Query helpers =====

    public static List<SaveEntity> EntitiesByFaction(FactionMarker faction)
        => Entities.Where(e => e.Faction == faction).ToList();

    public static List<SaveEntity> EntitiesByType(uint fullId)
        => Entities.Where(e => (uint)e.FullIdentifier == fullId).ToList();

    public static List<SaveEntity> FindEntities(string nameSubstring)
        => Entities.Where(e => e.Name.Contains(nameSubstring)).ToList();
}
