using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Serialization;

namespace SwRebellionEditor;

[Serializable]
public class Settings
{
    [NonSerialized]
    public bool UnsavedData = false;

    public string EDataFolder => Path.Combine(GameFolder + "EData");
    public string REBEXEFilePath => Path.Combine(GameFolder + "REBEXE.EXE");
    public string GDataFolder => Path.Combine(GameFolder + "GData");
    public bool IsRebellionCdLoaded => Directory.Exists(MDATAFolder);
    public string MDATAFolder => Path.Combine(GameFolder + "MDATA");
    public string SaveGameFolder => Path.Combine(GameFolder + "SaveGame");

    #region consts

    public const string SettingsXmlFilename = "SwRebellionEditor.xml";

    #endregion

    #region static Current

    private static string SettingsXmlFilepath;

    [NonSerialized]
    public static Settings Current;

    static Settings()
    {
        SettingsXmlFilepath = Path.Combine(Directory.GetCurrentDirectory(), SettingsXmlFilename);
        Current = Deserialize(SettingsXmlFilepath);
    }

    #endregion

    public Size BackgroundSize;
    public string GameFolder;
    public bool IsFirstStartup;
    public Point MainWindowTopLeftCornerPosition;
    public bool PlaySounds;
    public bool PlayMusic;

    public void SetDefaultValues()
    {
        BackgroundSize = new Size(1024, 768);
        GameFolder = RegistryKeys.InstalledLocation;
        IsFirstStartup = true;
        MainWindowTopLeftCornerPosition = new Point(0, 0);
        PlayMusic = false;
        PlaySounds = false;
    }

    #region CreateDefaultIfMissing, Deserialize, Serialize

    private static void CreateDefaultIfMissing(string filePath)
    {
        if (File.Exists(filePath) == false)
        {
            var s = new Settings();
            s.SetDefaultValues();
            Serialize(s, filePath);
        }
    }

    public static Settings Deserialize()
    {
        return Deserialize(SettingsXmlFilepath);
    }
    public static Settings Deserialize(string filePath)
    {
        CreateDefaultIfMissing(filePath);
        var deserializer = new XmlSerializer(typeof(Settings));
        TextReader textReader = new StreamReader(filePath);
        var settings = (Settings)deserializer.Deserialize(textReader);
        textReader.Close();
        return settings;
    }

    public void Serialize()
    {
        Serialize(this, SettingsXmlFilepath);
    }
    public static void Serialize(Settings settings)
    {
        Serialize(settings, SettingsXmlFilepath);
    }
    public void Serialize(string filePath)
    {
        Serialize(this, filePath);
    }
    public static void Serialize(Settings settings, string filePath)
    {
        var serializer = new XmlSerializer(typeof(Settings));
        TextWriter textWriter = new StreamWriter(filePath);
        serializer.Serialize(textWriter, settings);
        textWriter.Close();
    }

    #endregion
}
