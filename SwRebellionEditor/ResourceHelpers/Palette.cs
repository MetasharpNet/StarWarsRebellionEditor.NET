namespace SwRebellionEditor;

public class Palette
{
    public List<Color> colors;
    public int Size => colors.Count;

    public Palette(string filePath)
    {
        var bytes = File.ReadAllBytes(filePath);
        Set(bytes);
    }
    public Palette(byte[] bytes)
    {
        Set(bytes);
    }
    public void Set(byte[] bytes)
    {
        colors = new List<Color>();
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
            colors.Add(Color.FromArgb(red, green, blue));
        }
    }
    public void Save(string filePath)
    {
        var bytes = new byte[colors.Count * 3];
        int b = 0;
        for (int c = 0; c < colors.Count; ++c)
        {
            bytes[b++] = colors[c].R;
            bytes[b++] = colors[c].G;
            bytes[b++] = colors[c].B;
        }
        File.WriteAllBytes(filePath, bytes);
    }
}
