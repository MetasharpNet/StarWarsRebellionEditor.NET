namespace SwRebellionEditor;

public static class EncyBmap
{
    private static ResourceFile Resources;

    static EncyBmap()
    {
        Resources = new ResourceFile(RegistryKeys.InstalledLocation + "ENCYBMAP.DLL");
    }

    public static string GetString(ushort id)
    {
        return Resources.RT_STRING[id];
    }

    public static void SaveString(ushort id, string text)
    {
        Resources.SaveString(id, text);
    }
}
