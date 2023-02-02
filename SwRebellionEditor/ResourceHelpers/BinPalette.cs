namespace SwRebellionEditor;

public class BinPalette
{
    public List<Color> Colors;
    public int Size => Colors.Count;
    public byte[] Bytes;

    public BinPalette(string filePath)
    {
        var bytes = File.ReadAllBytes(filePath);
        Set(bytes);
    }
    public BinPalette(byte[] bytes)
    {
        Bytes = bytes;
        Set(bytes);
    }
    public BinPalette()
    {
    }
    public void Set(byte[] bytes)
    {
        Bytes = bytes;
        Colors = new List<Color>();
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
    public void Save(string filePath)
    {
        var bytes = new byte[Colors.Count * 3];
        int b = 0;
        for (int c = 0; c < Colors.Count; ++c)
        {
            bytes[b++] = Colors[c].R;
            bytes[b++] = Colors[c].G;
            bytes[b++] = Colors[c].B;
        }
        Bytes = bytes;
        File.WriteAllBytes(filePath, bytes);
    }
    public Bitmap ToBitmap()
    {
        var height = (Size / 16) + (Size % 16 > 0 ? 1 : 0);
        var bitmap = new Bitmap(16, height);
        var c = 0;
        for (int row = 0; row < height; ++row)
            for (int column = 0; column < 16; ++column)
                bitmap.SetPixel(column, row, Colors[c++]);
        return bitmap;
    }
}
