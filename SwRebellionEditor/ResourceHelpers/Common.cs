namespace SwRebellionEditor;

public static class Common
{
    public static ResourceFile Resources;

    static Common()
    {
        Resources = new ResourceFile(Path.Combine(Settings.Current.GameFolder, "COMMON.DLL"));
    }
}
