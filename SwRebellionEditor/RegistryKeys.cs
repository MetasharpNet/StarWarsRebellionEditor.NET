using Microsoft.Win32;

public class RegistryKeys
{
    private static RegistryKey? _registrykey;
    public static string InstalledLocation = "";

    static RegistryKeys()
    {
        while (!File.Exists(Path.Combine(InstalledLocation, "REBEXE.EXE")))
        {
            var askPath = false;
            try
            {
                _registrykey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\LucasArts Entertainment Company LLC\\Star Wars Rebellion");
                InstalledLocation = GetValue<string>("InstalledLocation");
                if (String.IsNullOrWhiteSpace(InstalledLocation))
                {
                    _registrykey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\GOG.com\\Games\\1421404828");
                    InstalledLocation = GetValue<string>("workingDir");
                }
                if (String.IsNullOrWhiteSpace(InstalledLocation))
                    askPath = true;
            }
            catch (Exception ex)
            {
                askPath = true;
            }
            if (askPath)
            {
                var openFolderDialog = new FolderBrowserDialog();
                openFolderDialog.Description = "Please select the folder where your Star Wars Rebellion game is installed.";
                openFolderDialog.InitialDirectory = "C:\\";
                if (openFolderDialog.ShowDialog() == DialogResult.OK)
                    InstalledLocation = openFolderDialog.SelectedPath;
                else
                    Environment.Exit(0);
            }
        }
    }

    private static TReturn GetValue<TReturn>(string name)
    {
        if (_registrykey == null)
            return default(TReturn);
        return (TReturn)_registrykey.GetValue(name);
    }
}
