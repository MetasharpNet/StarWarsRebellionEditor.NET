namespace SwRebellionEditor;

public static class EncyText
{
    public static ResourceFile Resources;

    static EncyText()
    {
        Resources = new ResourceFile(RegistryKeys.InstalledLocation + "ENCYTEXT.DLL");
    }
}
