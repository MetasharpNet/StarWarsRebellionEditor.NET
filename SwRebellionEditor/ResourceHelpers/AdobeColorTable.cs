namespace SwRebellionEditor;

/// <summary>
///  Adobe Color Table file format (.act files)
/// </summary>
public class AdobeColorTable
{
    public List<Color> Colors = new List<Color>();
    public byte[] Bytes = new byte[0];

    public AdobeColorTable()
    {
    }
    public AdobeColorTable(string filePath)
    {
        Set(File.ReadAllBytes(filePath));
    }
    public AdobeColorTable(byte[] bytes)
    {
        Set(bytes);
    }
    public void Save(string filePath)
    {
        File.WriteAllBytes(filePath, Bytes);
    }
    public void Set(byte[] bytes)
    {
        Bytes = bytes;
        Colors.Clear();
        for (int b = 0; b < bytes.Length; ++b)
        {
            byte red = bytes[b];
            byte green = 0;
            byte blue = 0;
            ++b;
            if (b < bytes.Length)
            {
                green = bytes[b];
                ++b;
                if (b < bytes.Length)
                    blue = bytes[b];
            }
            Colors.Add(Color.FromArgb(red, green, blue));
        }
    }
    public void SetColor(Color color, int colorIndex)
    {
        Colors[colorIndex] = color;
        Bytes[(3 * colorIndex) + 0] = color.R;
        Bytes[(3 * colorIndex) + 1] = color.G;
        Bytes[(3 * colorIndex) + 2] = color.B;
    }
    public void SetColors(Color color, int minIndex = 160, int maxIndex = 245)
    {
        if (Colors.Count < maxIndex + 1)
            throw new ArgumentException("Out of range: " + maxIndex, "maxIndex");
        for (int colorIndex = minIndex; colorIndex <= maxIndex; ++colorIndex)
            SetColor(color, colorIndex);
    }
    public Bitmap ToBitmap()
    {
        var height = (Colors.Count / 16) + (Colors.Count % 16 > 0 ? 1 : 0);
        var bitmap = new Bitmap(16, height);
        var c = 0;
        for (int y = 0; y < height; ++y)
            for (int x = 0; x < 16; ++x)
                bitmap.SetPixel(x, y, Colors[c++]);
        return bitmap;
    }
}
