namespace SwRebellionEditor;

public static class EncyText
{
    public static ResourceFile Resources;

    static EncyText()
    {
        Resources = new ResourceFile(Path.Combine(Settings.Current.GameFolder, "ENCYTEXT.DLL"));
    }
}
