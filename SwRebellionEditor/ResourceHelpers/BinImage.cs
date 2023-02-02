using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwRebellionEditor.ResourceHelpers
{
    public class BinImage
    {
        // Format
        // uint: Width
        // uint: Height
        // [byte, byte] list : [occurences, palette's color index] with occurences=00 meaning 255
        public int Width;
        public int Height;
        public List<BinPixelOccurences> PixelsOccurences;

        public byte[] Bytes;
        public byte[,] Pixels;

        public BinPalette Palette;

        public BinImage(string filePath)
        {
            var bytes = File.ReadAllBytes(filePath);
            Set(bytes);
        }
        public BinImage(byte[] bytes)
        {
            Set(bytes);
        }
        public BinImage(Bitmap bitmap)
        {
            Width = bitmap.Width;
            Height = bitmap.Height;
            Palette = new BinPalette();
            Palette.colors = new List<Color>();
            var dic = new Dictionary<string, byte>();
            var by = new List<byte>();
            by.AddRange(BitConverter.GetBytes(Width));
            by.AddRange(BitConverter.GetBytes(Height));
            byte paletteId = 0;
            for (int y = 0; y < Height; ++y)
                for (int x = 0; x < Width; ++x)
                {
                    var pixel = bitmap.GetPixel(x, y);
                    var color = Color.FromArgb(pixel.R, pixel.G, pixel.B);
                    if (!dic.ContainsKey(color.Name))
                    {
                        dic.Add(color.Name, paletteId++);
                        Palette.colors.Add(color);
                    }
                    by.Add(1);
                    by.Add(dic[color.Name]);
                }
            Bytes = by.ToArray();
        }
        public void Set(byte[] bytes)
        {
            Bytes = bytes;
            Width = BitConverter.ToInt32(bytes, 0);
            Height = BitConverter.ToInt32(bytes, 4);
            PixelsOccurences = new List<BinPixelOccurences>();
            Pixels = new byte[Width, Height];

            int row = 0;
            int column = 0;
            for (int b = 8; b < bytes.Length; ++b)
            {
                var binPixelOccurences = new BinPixelOccurences();
                binPixelOccurences.Occcurences = bytes[b];
                ++b;
                if (b < bytes.Length)
                {
                    binPixelOccurences.ColorIndex = bytes[b];
                    PixelsOccurences.Add(binPixelOccurences);
                    for (var o = 0; o < binPixelOccurences.RealOccurences; ++o)
                    {
                        if (row >= Height)
                            continue;
                        Pixels[column, row] = binPixelOccurences.ColorIndex;
                        ++column;
                        if (column >= Width)
                        {
                            column = 0;
                            ++row;
                        }
                    }
                }

            }
        }
        public void Save(string filePath)
        {
            File.WriteAllBytes(filePath, Bytes);
        }
        public Bitmap ToBitmap(BinPalette palette)
        {
            if (palette == null)
                throw new ArgumentNullException(nameof(Palette));
            Palette = palette;
            return ToBitmap();
        }
        public Bitmap ToBitmap()
        {
            if (Palette == null)
                throw new ArgumentNullException(nameof(Palette));
            var bitmap = new Bitmap(Width, Height);
            for (int row = 0; row < Width; ++row)
                for (int column = 0; column < Height; ++column)
                    bitmap.SetPixel(column, row, Palette.colors[Pixels[column, row]]);
            return bitmap;
        }
    }
}
