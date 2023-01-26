namespace SwRebellionEditor;

public static class Strategy
{
    public static ResourceFile Resources;

    static Strategy()
    {
        Resources = new ResourceFile(Path.Combine(Settings.Current.GameFolder, "STRATEGY.DLL"));
    }
}
