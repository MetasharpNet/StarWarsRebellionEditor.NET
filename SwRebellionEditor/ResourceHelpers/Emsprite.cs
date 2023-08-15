namespace SwRebellionEditor;

public static class Emsprite
{
    public static ResourceFile Resources;

    static Emsprite()
    {
        Resources = new ResourceFile(Path.Combine(Settings.Current.GameFolder, "EMSPRITE.DLL"));
    }
}
