namespace SwRebellionEditor;

public static class Strategy
{
    public static ResourceFile Resources;

    static Strategy()
    {
        Resources = new ResourceFile(RegistryKeys.InstalledLocation + "STRATEGY.DLL");
    }
}
