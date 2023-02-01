namespace SwRebellionEditor;

public static class Tactical
{
    public static ResourceFile Resources;

    static Tactical()
    {
        Resources = new ResourceFile(Path.Combine(Settings.Current.GameFolder, "TACTICAL.DLL"));
    }
}
