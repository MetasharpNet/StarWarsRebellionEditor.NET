using Microsoft.Win32;
using System.Windows.Forms;

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
        try
        {
            _registrykey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\LucasArts Entertainment Company LLC\\Star Wars Rebellion");
            DataLocation = GetValue<string>("DataLocation");
            DllLocation = GetValue<string>("DllLocation");
            EncyLocation = GetValue<string>("EncyLocation");
            ExePath = GetValue<string>("EXEPath");
            InstalledLocation = GetValue<string>("InstalledLocation");
        }
        catch (NullReferenceException ex)
        {
            var openFolderDialog = new FolderBrowserDialog();
            openFolderDialog.Description = "Please select the folder where your Star Wars Rebellion game is installed.";
            openFolderDialog.InitialDirectory = "C:\\";
            if (openFolderDialog.ShowDialog() == DialogResult.OK)
            {
                DataLocation = openFolderDialog.SelectedPath;
                DllLocation = openFolderDialog.SelectedPath;
                EncyLocation = Path.Combine(openFolderDialog.SelectedPath, "EData");
                ExePath = Path.Combine(openFolderDialog.SelectedPath, "REBEXE.EXE");
                InstalledLocation = openFolderDialog.SelectedPath;
            }
        }
    }

    private static TReturn GetValue<TReturn>(string name)
    {
        return (TReturn)_registrykey.GetValue(name);
    }
}
