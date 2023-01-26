namespace SwRebellionEditor;

public static class EncyBmap
{
    public static ResourceFile Resources;

    static EncyBmap()
    {
        Resources = new ResourceFile(Path.Combine(Settings.Current.GameFolder, "ENCYBMAP.DLL"));
    }
}
