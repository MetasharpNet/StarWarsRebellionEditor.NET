using Microsoft.Win32;

public class RegistryKeys
{
    public static bool PlayAudio;
    public static bool PlayMusic;
    public static bool PlaySounds;
    public static bool IsFirstStart = false;
    public static bool UnsavedFighterData;

    private static RegistryKey? _registrykey;
    public static readonly string InstalledLocation;
    public static readonly string ExePath;
    public static readonly string EncyLocation;
    public static readonly string DataLocation;
    public static readonly string DllLocation;
    public static bool IsRebellionCdLoaded => Directory.Exists(DllLocation + "\\MDATA");

    static RegistryKeys()
    {
        _registrykey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\LucasArts Entertainment Company LLC\\Star Wars Rebellion");
        DataLocation = GetValue<string>("DataLocation");
        DllLocation = GetValue<string>("DllLocation");
        EncyLocation = GetValue<string>("EncyLocation");
        ExePath = GetValue<string>("EXEPath");
        InstalledLocation = GetValue<string>("InstalledLocation");
    }

    private static TReturn GetValue<TReturn>(string name)
    {
        try
        {
            return (TReturn)_registrykey.GetValue(name);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Couldn't find in LocalMachine registry: SOFTWARE\\LucasArts Entertainment Company LLC\\Star Wars Rebellion\\" + name);
            MessageBox.Show(ex.Message);
            return default(TReturn);
        }
    }
}
