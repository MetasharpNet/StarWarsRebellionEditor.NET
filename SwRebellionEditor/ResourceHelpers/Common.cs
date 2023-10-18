namespace SwRebellionEditor;

// WAVE, Bitmap, RCData, Version Info

public class Common : ResourcesDll
{
    public Common(string fileName) : base(fileName)
    {
        NamesBitmap = new Dictionary<string, string>
            {
                { "20001", "main-screen" },
            };
        NamesWave = new Dictionary<string, string>
            {
            };
    }
}
