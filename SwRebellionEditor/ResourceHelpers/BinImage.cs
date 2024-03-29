﻿namespace SwRebellionEditor.ResourceHelpers;

using System.Drawing.Imaging;

public class BinImage
{
    public byte[] Bytes;
    // Format
    // uint: Width
    // uint: Height
    // [byte, byte] list : [occurences, color table's color index] with occurences=00 meaning 255
    public int Width;
    public int Height;
    public List<BinPixelOccurences> BinPixelsOccurences = new List<BinPixelOccurences>();

    public AdobeColorTable ColorTable = new AdobeColorTable();

    public byte[,] IndexedColors;

    public BinImage()
    {
    }
    public BinImage(string filePath)
    {
        Set(File.ReadAllBytes(filePath));
    }
    public BinImage(byte[] bytes)
    {
        Set(bytes);
    }
    public BinImage(Bitmap bitmap)
    {
        // TODO: add embedded color table usage
        Width = bitmap.Width;
        Height = bitmap.Height;
        var colorTableBytes = new List<byte>();
        var dic = new Dictionary<Color, byte>();
        var bytes = new List<byte>();
        bytes.AddRange(BitConverter.GetBytes(Width));
        bytes.AddRange(BitConverter.GetBytes(Height));
        byte paletteId = 0;
        for (int y = 0; y < Height; ++y)
            for (int x = 0; x < Width; ++x)
            {
                var color = bitmap.GetPixel(x, y);
                if (!dic.ContainsKey(color))
                {
                    dic.Add(color, paletteId++);
                    ColorTable.Colors.Add(color);
                    colorTableBytes.Add(color.R);
                    colorTableBytes.Add(color.G);
                    colorTableBytes.Add(color.B);
                }
                // could be smaller by cumulating successive identical pixels by increasing 1 to that amount
                bytes.Add(1);
                bytes.Add(dic[color]);
            }
        Set(bytes.ToArray());
        ColorTable.Set(colorTableBytes.ToArray());
    }
    public BinImage(Bitmap bitmap, AdobeColorTable colorTable, bool restricted = true, int width = -1, int height = -1)
    {
        // possible resize
        if (width > -1 && height > -1)
            bitmap = new Bitmap(bitmap.GetThumbnailImage(width, height, null, IntPtr.Zero));
        Width = bitmap.Width;
        Height = bitmap.Height;
        ColorTable = colorTable;
        Bytes = new byte[Width * Height];
        var bytes = new List<byte>(Width * Height);
        bytes.AddRange(BitConverter.GetBytes(Width));
        bytes.AddRange(BitConverter.GetBytes(Height));
        if (!restricted)
            ExtendColorTable(bitmap);
        var matches = new Dictionary<Color, byte>(); ;
        for (int y = 0; y < Height; ++y)
            for (int x = 0; x < Width; ++x)
            {
                var color = bitmap.GetPixel(x, y);
                byte colorTableIndex;
                if (matches.ContainsKey(color))
                    colorTableIndex = matches[color];
                else
                {
                    colorTableIndex = FindClosestColor(color, colorTable, restricted);
                    matches.Add(color, colorTableIndex);
                }
                // could be smaller by cumulating successive identical pixels by increasing 1 to that amount
                bytes.Add(1);
                bytes.Add(colorTableIndex);
            }
        Set(bytes.ToArray());
    }
    // color palette tester
    public BinImage(int pixelSquaresWidthPerColor)
    {
        Width = pixelSquaresWidthPerColor * 16;
        Height = pixelSquaresWidthPerColor * 16;
        ColorTable = null;
        Bytes = new byte[Width * Height];
        var bytes = new List<byte>();
        bytes.AddRange(BitConverter.GetBytes(Width));
        bytes.AddRange(BitConverter.GetBytes(Height));
        for (int y = 0; y < 16; ++y)
            for (int py = 0; py < pixelSquaresWidthPerColor; ++py)
                for (int x = 0; x < 16; ++x)
                    for (int px = 0; px < pixelSquaresWidthPerColor; ++px)
                    {
                        byte color = (byte)(y * 16 + x);
                        bytes.Add(1);
                        bytes.Add(color);
                    }
        Set(bytes.ToArray());
    }
    public void Set(byte[] bytes)
    {
        Bytes = bytes;
        BinPixelsOccurences.Clear();
        Width = BitConverter.ToInt32(bytes, 0);
        Height = BitConverter.ToInt32(bytes, 4);
        IndexedColors = new byte[Width, Height];
        int x = 0;
        int y = 0;
        for (int b = 8; b < bytes.Length; ++b)
        {
            var binPixelOccurences = new BinPixelOccurences();
            binPixelOccurences.Occcurences = bytes[b];
            ++b;
            if (b < bytes.Length)
            {
                binPixelOccurences.ColorIndex = bytes[b];
                BinPixelsOccurences.Add(binPixelOccurences);
                for (var o = 0; o < binPixelOccurences.RealOccurences; ++o)
                {
                    if (y >= Height)
                        break;
                    IndexedColors[x, y] = binPixelOccurences.ColorIndex;
                    ++x;
                    if (x >= Width)
                    {
                        x = 0;
                        ++y;
                    }
                }
            }

        }
    }
    public void Save(string filePath)
    {
        File.WriteAllBytes(filePath, Bytes);
    }
    public Bitmap ToBitmap(AdobeColorTable palette)
    {
        if (palette == null)
            throw new ArgumentNullException(nameof(ColorTable));
        ColorTable = palette;
        return ToBitmap();
    }
    public Bitmap ToBitmap(bool indexed = true)
    {
        if (ColorTable == null)
            throw new ApplicationException("ColorTable=null");
        if (IndexedColors == null)
            throw new ApplicationException("Pixels=null");

        if (!indexed)
        {
            var rgbBitmap = new Bitmap(Width, Height);
            for (int y = 0; y < Height; ++y)
                for (int x = 0; x < Width; ++x)
                    rgbBitmap.SetPixel(x, y, ColorTable.Colors[IndexedColors[x, y]]);
            return rgbBitmap;
        }

        var bitmap = new Bitmap(Width, Height, PixelFormat.Format8bppIndexed);
        BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, Width, Height), ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
        try
        {
            IntPtr ptr = bitmapData.Scan0;
            int stride = bitmapData.Stride;
            byte[] pixelValues = new byte[stride * Height];
            for (int y = 0; y < Height; ++y)
            {
                for (int x = 0; x < Width; ++x)
                {
                    int index = y * stride + x;
                    pixelValues[index] = IndexedColors[x, y];
                }
            }
            System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, ptr, pixelValues.Length);
        }
        finally
        {
            bitmap.UnlockBits(bitmapData);
        }
        ColorPalette colorPalette = bitmap.Palette;
        for (int i = 0; i < 256; ++i)
        {
            colorPalette.Entries[i] = ColorTable.Colors[i];
        }
        bitmap.Palette = colorPalette;
        return bitmap;
    }
    private void ExtendColorTable(Bitmap bitmap)
    {
        var thumbnail = new Bitmap(bitmap.GetThumbnailImage(48, 48, null, IntPtr.Zero));
        ColorTable.SetColors(Color.Black);
        ColorTable.SetColor(Color.White, 255);

        var thumbnailColors = new Color[thumbnail.Width, thumbnail.Height];
        for (int y = 0; y < thumbnail.Height; ++y)
            for (int x = 0; x < thumbnail.Width; ++x)
                thumbnailColors[x, y] = thumbnail.GetPixel(x, y);

        // for each open palette color slot
        for (int colorTableIndex = 160; colorTableIndex < 246; ++colorTableIndex)
        {
            int maxDistanceToClosestTableColor = 0;
            Color mostFarClosestThumbnailPixelColor = Color.Black;
            // for each pixel of the thumbnailed picture
            for (int y = 0; y < thumbnail.Height; ++y)
            {
                for (int x = 0; x < thumbnail.Width; ++x)
                {
                    int distanceToClosestTableColor = int.MaxValue;
                    Color closestThumbnailPixelColor = Color.Black;
                    Color thumbnailPixelColor = thumbnailColors[x, y];
                    // for each color of the color table
                    for (int p = 0; p < ColorTable.Colors.Count; ++p)
                    {
                        var dist = ComputeColorDistance(thumbnailPixelColor, ColorTable.Colors[p]);
                        if (dist < distanceToClosestTableColor)
                        {
                            distanceToClosestTableColor = dist;
                            closestThumbnailPixelColor = thumbnailPixelColor;
                        }
                        if (distanceToClosestTableColor == 0)
                            break;
                    }
                    if (distanceToClosestTableColor > maxDistanceToClosestTableColor)
                    {
                        maxDistanceToClosestTableColor = distanceToClosestTableColor;
                        mostFarClosestThumbnailPixelColor = closestThumbnailPixelColor;
                    }
                }
            }
            if (maxDistanceToClosestTableColor == 0)
                break;
            ColorTable.SetColor(mostFarClosestThumbnailPixelColor, colorTableIndex);
        }
    }
    private static byte FindClosestColor(Color color, AdobeColorTable colorTable, bool restricted = true)
    {
        // restricted allows using 0-159 and 246-254 in the color table only
        short index = 0;
        int minDistance = int.MaxValue;
        for (short p = 0; p < colorTable.Colors.Count; ++p)
        {
            if (restricted && p == 160)
            {
                p = 245;
                continue;
            }
            if (restricted && p == 254)
                break;
            int distance = ComputeColorDistance(color, colorTable.Colors[p]);
            if (distance < minDistance)
            {
                index = p;
                minDistance = distance;
            }
            if (minDistance == 0)
                break;
        }
        return (byte)index;
    }
    private static int ComputeColorDistance(Color color1, Color color2)
    {
        if (color1 == color2)
            return 0;
        int r = color1.R - color2.R;
        int g = color1.G - color2.G;
        int b = color1.B - color2.B;
        return r * r + g * g + b * b;
    }
}
