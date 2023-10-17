namespace SwRebellionEditor;

// WAVE, Bitmap, RCData, Version Info, 302

public class Alsprite : ResourcesDll
{
    public Alsprite(string fileName) : base(fileName)
    {
        NamesBitmap = new Dictionary<string, string>
            {
            };
        NamesWave = new Dictionary<string, string>
            {
            };
    }
}
