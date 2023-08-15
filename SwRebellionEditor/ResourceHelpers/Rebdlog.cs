namespace SwRebellionEditor;

public static class Rebdlog
{
    public static ResourceFile Resources;

    static Rebdlog()
    {
        Resources = new ResourceFile(Path.Combine(Settings.Current.GameFolder, "REBDLOG.DLL"));
    }
}
