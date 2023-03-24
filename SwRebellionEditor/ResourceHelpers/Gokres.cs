namespace SwRebellionEditor;

public static class Gokres
{
    public static ResourceFile Resources;

    static Gokres()
    {
        Resources = new ResourceFile(Path.Combine(Settings.Current.GameFolder, "GOKRES.DLL"));
    }
}
