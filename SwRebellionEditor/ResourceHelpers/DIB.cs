using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Vestris.ResourceLib;

namespace SwRebellionEditor;

// https://learn.microsoft.com/en-us/windows/win32/gdi/device-independent-bitmaps?redirectedfrom=MSDN
// http://www.herdsoft.com/ti/davincie/imex3j8i.htm#:~:text=DIB%2C%20or%20Device%20Independent%20Bitmap,pixels%2Dper%2Dinch).
// https://www-user.tu-chemnitz.de/~heha/petzold/ch15b.htm
// https://www.codeguru.com/multimedia/converting-dib-to-ddb/
// http://vb-helper.com/howto_make_8bit_dib.html
// https://github.com/ArashPartow/bitmap/blob/master/bitmap_image.hpp
// https://bytes.com/topic/visual-basic-net/answers/678944-how-display-dib-draw-into-bitmap
//is the 1078 byte marker related to the bitmaps from strategy.dll?

static public class DIB
{
    public static Bitmap ToDDB(DeviceIndependentBitmap dib, string filePath = null)
    {
        var ddbHeaderSize = 54;
        int dibWidth = dib.Image.Width;
        int ddbWidth = dib.Image.Width;
        int dibHeight = dib.Image.Height;
        int ddbHeight = dibHeight < 0 ? -dibHeight : dibHeight;
        uint dibHeaderSize = dib.Header.biSize;
        var dibPaletteEntriesUsed = dib.Header.biClrUsed == 0 ? 256 : dib.Header.biClrUsed;

        if (dib.Image.PixelFormat == PixelFormat.Format8bppIndexed)
        {
            if (dib.Header.biCompression != 0)
                throw new ArgumentException("Unsupported BitmapCompressionMode=" + dib.Header.biCompression, "dib");
            var ddbPaletteSize = 4 * dibPaletteEntriesUsed;
            var ddbBytesSize = dib.Data.Length - dibHeaderSize + ddbHeaderSize;
            // pad ddbBytesSize to 4 bytes
            ddbBytesSize = ddbBytesSize + ((4 - ddbBytesSize % 4) % 4);
            var ddbBytes = new byte[ddbBytesSize];
            // header
            ddbBytes[0] = 0x42;                                     // B
            ddbBytes[1] = 0x4D;                                     // M
            Tools.SetBytes(ddbBytes, ddbBytesSize, 2);                    // file size
            Tools.SetBytes(ddbBytes, 0, 6);                               // 2x 2 bytes reserved, usually unused
            Tools.SetBytes(ddbBytes, ddbHeaderSize + ddbPaletteSize, 10); // offset to pixel data
            Tools.SetBytes(ddbBytes, dibHeaderSize, 14);                  // size of BITMAPINFO structure (the header)
            Tools.SetBytes(ddbBytes, dibWidth, 18);                       // width
            Tools.SetBytes(ddbBytes, dibHeight, 22);                      // height
            Tools.SetBytes(ddbBytes, (short)1, 26);                       // number of planes
            Tools.SetBytes(ddbBytes, (short)8, 28);                       // bits per pixel
            Tools.SetBytes(ddbBytes, 0, 30);                              // compression (0 for BI_RGB = uncompressed) https://www.pinvoke.net/default.aspx/Enums/BitmapCompressionMode.html
            Tools.SetBytes(ddbBytes, 0, 34);                              // size of image data (0 if uncompressed)
            Tools.SetBytes(ddbBytes, dib.Header.biXPelsPerMeter, 38);     // horizontal resolution
            Tools.SetBytes(ddbBytes, dib.Header.biYPelsPerMeter, 42);     // vertical resolution
            Tools.SetBytes(ddbBytes, dib.Header.biClrUsed, 46);           // number of colors
            Tools.SetBytes(ddbBytes, dib.Header.biClrImportant, 50);      // number of important colors (0 = all)
            // palette (colors table)
            int ddbPos = ddbHeaderSize;
            int dibPos = (int)dibHeaderSize;
            while (dibPos < ddbPaletteSize)
                ddbBytes[ddbPos++] = dib.Data[dibPos++];
            // pixels
            if (dibHeight > 0)
            {
                while (dibPos < dib.Data.Length)
                    ddbBytes[ddbPos++] = dib.Data[dibPos++];
            }
            else
            {
                for (int y = ddbHeight - 1; y >= -1 ; y--)
                    for (int x = 0; x < ddbWidth; x++)
                        if (dibPos < dib.Data.Length)
                            ddbBytes[ddbPos + y * ddbWidth + x] = dib.Data[dibPos++];
            }
            ddbPos += ddbWidth * ddbHeight;
            while (ddbPos < ddbBytesSize)
                ddbBytes[ddbPos++] = 0;
            if (filePath != null)
            {
                File.WriteAllBytes(filePath, ddbBytes);
                return null;
            }
            // create the DDB
            MemoryStream stream = new MemoryStream(ddbBytes);
            var ddb = new Bitmap(stream);
            stream.Dispose();
            return ddb;
        }
        else
            throw new ArgumentException("Unsupported PixelFormat=" + dib.Image.PixelFormat, "dib");
    }
}