using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing;
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
    // https://www.pinvoke.net/default.aspx/Enums/BitmapCompressionMode.html
    // http://search.microsoft.com/search/results.aspx?qu=BitmapCompressionMode
    public enum BitmapCompressionMode : uint
    {
        BI_RGB = 0, // 	Uncompressed format.
        BI_RLE8 = 1, // A run-length encoded (RLE) format for bitmaps with 8 bpp. The compression format is a 2-byte format consisting of a count byte followed by a byte containing a color index.
        BI_RLE4 = 2, // An RLE format for bitmaps with 4 bpp. The compression format is a 2-byte format consisting of a count byte followed by two word-length color indexes.
        BI_BITFIELDS = 3, // Uncompressed using a 3 DWORD (RGB) color masks table for each pixel. Valid for 16/32bpp.
        BI_JPEG = 4, // JPEG image.
        BI_PNG = 5 // PNG image.
    }

    // https://www.pinvoke.net/default.aspx/Structures/BITMAPINFOHEADER.html
    // http://msdn.microsoft.com/en-us/library/dd183376
    [StructLayout(LayoutKind.Sequential)]
    public struct BITMAPINFOHEADER
    {
        public uint biSize; // BITMAPINFOHEADER structure size in bytes
        public int biWidth; // Bitmap width in pixels (decompressed width if biCompression=BI_JPEG/BI_PNG)
        public int biHeight; // Bitmap height in pixels (decompressed width if biCompression=BI_JPEG/BI_PNG). biHeight>0 means bottom-up DIB: lower-left corner is 0,0. biHeight<0 means a top-down DIB: upper-left corner is 0,0 and biCompression=BI_RGB/BI_BITFIELDS.
        public ushort biPlanes; // Always 1. Target device planes.
        public ushort biBitCount; // Bits-per-pixel: 0 (for JPG/PNG), 1/4/8 (for indexed colors), 16/24/32 (for direct/indexed colors).
        public BitmapCompressionMode biCompression;
        public uint biSizeImage; // Image size in bytes. Can be 0 for BI_RGB. JPEG/PNG image buffer size if biCompression=BI_JPEG/BI_PNG.
        public int biXPelsPerMeter; // Target device horizontal resolution in pixels-per-meter for the bitmap.
        public int biYPelsPerMeter; // Target device vertical resolution in pixels-per-meter for the bitmap.
        public uint biClrUsed; // Used color table indexed colors. If 0, maximum number of colors for biBitCount/biCompression combo.
        public uint biClrImportant; // Required color indexes to display the bitmap. If 0, all colors are required.
        public void Init()
        {
            biSize = (uint)Marshal.SizeOf(this);
        }
    }

    public static Bitmap ToDDB(DeviceIndependentBitmap dib)
    {
        // get the handle for the byte array and "pin" that memory (i.e. prevent immediate garbage collecttion)
        var gcHandle = GCHandle.Alloc(dib.Data, GCHandleType.Pinned);
        var dibInfoHeader = (BITMAPINFOHEADER)Marshal.PtrToStructure(gcHandle.AddrOfPinnedObject(), typeof(BITMAPINFOHEADER));

        if (dibInfoHeader.biPlanes != 1)
            throw new ArgumentException("Invalid DIB header. biPlanes=1 expected. biPlanes=" + dibInfoHeader.biPlanes + " found.", "dib");

        bool isFormat16bppRgb555 = true;
        Bitmap ddb = null;
        if (dibInfoHeader.biBitCount == 8)
        {
            var dibStartPointer = gcHandle.AddrOfPinnedObject();
            var dibAfterHeaderPointer = dibStartPointer + dibInfoHeader.biSize;
            ddb = new Bitmap(dibInfoHeader.biWidth, dibInfoHeader.biHeight, PixelFormat.Format8bppIndexed);

            // set resolution if used
            if (dibInfoHeader.biXPelsPerMeter > 0 && dibInfoHeader.biYPelsPerMeter > 0)
                ddb.SetResolution((100f * (float)dibInfoHeader.biXPelsPerMeter) / 2.54f, (100f * (float)dibInfoHeader.biYPelsPerMeter) / 2.54f);

            // set the palette through temporary object, else the changes won't applied
            var ddbTmpPalette = ddb.Palette;
            var dibPointer = new IntPtr(dibAfterHeaderPointer);
            for (int e = 0; e < ddbTmpPalette.Entries.Count(); ++e)
            {
                uint dibColor = (uint)Marshal.ReadInt32(dibPointer);
                //int a = (int)((dibColor & 0xFF000000) >> 24);
                int r = (int)((dibColor & 0xFF0000) >> 16);
                int g = (int)((dibColor & 0xFF00) >> 8);
                int b = (int)((dibColor & 0xFF));
                ddbTmpPalette.Entries[e] = Color.FromArgb(r, g, b);
                dibPointer += 4;
            }
            ddb.Palette = ddbTmpPalette;

            // now write the remaining bmp data to our bitmap
            var ddbBitmapData = ddb.LockBits(new Rectangle(0, 0, ddb.Width, ddb.Height), ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
            var dibAfterPaletteOffset = (IntPtr)(dibInfoHeader.biSize + ddbTmpPalette.Entries.Count() * 4);
            Marshal.Copy(dib.Data, (int)dibAfterPaletteOffset, ddbBitmapData.Scan0, ddbBitmapData.Stride * ddbBitmapData.Height);
            ddb.UnlockBits(ddbBitmapData);
        }
        else if (dibInfoHeader.biBitCount == 16 && dibInfoHeader.biCompression == BitmapCompressionMode.BI_BITFIELDS)
        {
            var dibAfterPaletteOffset = dibInfoHeader.biSize + dibInfoHeader.biClrUsed * 4;
            var dibPointer = new IntPtr(gcHandle.AddrOfPinnedObject() + dibAfterPaletteOffset);
            var redMask = (ushort)Marshal.ReadInt16(dibPointer);
            dibPointer = new IntPtr(dibPointer.ToInt64() + (2 * Marshal.SizeOf(typeof(UInt16))));
            var greenMask = (ushort)Marshal.ReadInt16(dibPointer);
            dibPointer = new IntPtr(dibPointer.ToInt64() + (2 * Marshal.SizeOf(typeof(UInt16))));
            var blueMask = (ushort)Marshal.ReadInt16(dibPointer);
            isFormat16bppRgb555 = ((redMask == 0x7C00) && (greenMask == 0x03E0) && (blueMask == 0x001F));
        }
        // release the "pin"
        gcHandle.Free();

        if (dibInfoHeader.biCompression != BitmapCompressionMode.BI_RGB && dibInfoHeader.biCompression != BitmapCompressionMode.BI_BITFIELDS)
            throw new ArgumentException("Unsupported BitmapCompressionMode=" + dibInfoHeader.biCompression, "dib");

        if (ddb == null)
        {
            // we need to know beforehand the pixel-depth of our bitmap
            var pixelFormat = PixelFormat.Format24bppRgb;
            switch (dibInfoHeader.biBitCount)
            {
                case 32:
                    pixelFormat = PixelFormat.Format32bppRgb;
                    break;
                case 24:
                    pixelFormat = PixelFormat.Format24bppRgb;
                    break;
                case 16:
                    pixelFormat = (isFormat16bppRgb555) ? PixelFormat.Format16bppRgb555 : PixelFormat.Format16bppRgb565;
                    break;
                default:
                    return null;
            }
            // prepare for our output bitmap
            ddb = new Bitmap(dibInfoHeader.biWidth, dibInfoHeader.biHeight, pixelFormat);
            // load our "empty" bitmap into memory and lock it for writing in the format we specified
            var ddbBitmapData = ddb.LockBits(new Rectangle(0, 0, ddb.Width, ddb.Height), ImageLockMode.WriteOnly, pixelFormat);
            // marshal our device independent bitmap data over to our output bitmap
            Marshal.Copy(dib.Data, Marshal.SizeOf(dibInfoHeader), ddbBitmapData.Scan0, ddbBitmapData.Stride * ddbBitmapData.Height);
            // we're done marshalling, so release our bitmapdata lock
            ddb.UnlockBits(ddbBitmapData);
        }
        if (dibInfoHeader.biHeight > 0) // as explained in DIB specs, flip if height>0
            ddb.RotateFlip(RotateFlipType.RotateNoneFlipY);
        return ddb;
    }
}