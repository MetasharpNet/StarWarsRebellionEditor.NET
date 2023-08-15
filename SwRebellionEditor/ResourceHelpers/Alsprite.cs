namespace SwRebellionEditor;

public static class Alsprite
{
    public static ResourceFile Resources;

    static Alsprite()
    {
        Resources = new ResourceFile(Path.Combine(Settings.Current.GameFolder, "ALSPRITE.DLL"));
    }
}
