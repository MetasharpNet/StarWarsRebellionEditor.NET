namespace SwRebellionEditor;

public static class EncyBmap
{
    public static ResourceFile Resources;

    static EncyBmap()
    {
        Resources = new ResourceFile(RegistryKeys.InstalledLocation + "ENCYBMAP.DLL");
    }
}
