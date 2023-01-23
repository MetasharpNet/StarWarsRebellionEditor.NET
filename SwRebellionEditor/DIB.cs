using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Vestris.ResourceLib;

namespace SwRebellionEditor;

//https://www.codeguru.com/multimedia/converting-dib-to-ddb/
//http://vb-helper.com/howto_make_8bit_dib.html
//https://github.com/ArashPartow/bitmap/blob/master/bitmap_image.hpp
//https://bytes.com/topic/visual-basic-net/answers/678944-how-display-dib-draw-into-bitmap
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

    public static Bitmap ToDDB(BitmapResource br)
    {
        var dib = br.Bitmap.Image;
        // get byte array of device independent bitmap
        var dibBytes = br.Bitmap.Data;

        // get the handle for the byte array and "pin" that memory (i.e. prevent garbage collector from gobbling it up right away)...
        var gcHandle = GCHandle.Alloc(dibBytes, GCHandleType.Pinned);

        // marshal our data into a BITMAPINFOHEADER struct per Win32 definition of BITMAPINFOHEADER
        var dibInfoHeader = (BITMAPINFOHEADER)Marshal.PtrToStructure(gcHandle.AddrOfPinnedObject(), typeof(BITMAPINFOHEADER));

        bool is555 = true;

        Bitmap ddb = null;

        if (dibInfoHeader.biBitCount == 8)
        {
            var dibPointer = gcHandle.AddrOfPinnedObject().ToInt64();
            var dibPointerAfterHeader = dibPointer + dibInfoHeader.biSize;
            ddb = new Bitmap(dibInfoHeader.biWidth, dibInfoHeader.biHeight, PixelFormat.Format8bppIndexed);

            // this was uncommented in the original code, but would throw exceptions on some images. commenting it out resulted in "successful" resulting image and no exception.
            if (dibInfoHeader.biXPelsPerMeter > 0 && dibInfoHeader.biYPelsPerMeter > 0)
                ddb.SetResolution((100f * (float)dibInfoHeader.biXPelsPerMeter) / 2.54f, (100f * (float)dibInfoHeader.biYPelsPerMeter) / 2.54f);

            // use a temporary Palette object, else the changes won't applied
            var ddbPalette = ddb.Palette;

            var dibPalettePointer = new IntPtr(dibPointerAfterHeader);
            for (int e = 0; e < ddbPalette.Entries.Count(); ++e)
            {
                uint dibColor = (uint)Marshal.ReadInt32(dibPalettePointer);
                int a = (int)((dibColor & 0xFF000000) >> 24);
                int r = (int)((dibColor & 0xFF0000) >> 16);
                int g = (int)((dibColor & 0xFF00) >> 8);
                int b = (int)((dibColor & 0xFF));
                ddbPalette.Entries[e] = Color.FromArgb(r, g, b);
                dibPalettePointer += 4;
            }
            // apply the new palette
            ddb.Palette = ddbPalette;

            // now write the remaining bmp data to our bitmap
            var ddbBitmapData = ddb.LockBits(new Rectangle(0, 0, ddb.Width, ddb.Height), ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);

            dibPalettePointer -= gcHandle.AddrOfPinnedObject();

            Marshal.Copy(dibBytes, (int)dibPalettePointer, ddbBitmapData.Scan0, ddbBitmapData.Stride * ddbBitmapData.Height);

            ddb.UnlockBits(ddbBitmapData);
        }

        else if ((dibInfoHeader.biBitCount == 16) && (dibInfoHeader.biCompression == BitmapCompressionMode.BI_BITFIELDS))
        {
            Int64 jumpTo = (Int64)(dibInfoHeader.biClrUsed * (uint)4 + dibInfoHeader.biSize);
            IntPtr ptr = new IntPtr(gcHandle.AddrOfPinnedObject().ToInt64() + jumpTo);
            ushort redMask = (ushort)Marshal.ReadInt16(ptr);
            ptr = new IntPtr(ptr.ToInt64() + (2 * Marshal.SizeOf(typeof(UInt16))));
            ushort greenMask = (ushort)Marshal.ReadInt16(ptr);
            ptr = new IntPtr(ptr.ToInt64() + (2 * Marshal.SizeOf(typeof(UInt16))));
            ushort blueMask = (ushort)Marshal.ReadInt16(ptr);

            is555 = ((redMask == 0x7C00) && (greenMask == 0x03E0) && (blueMask == 0x001F));
        }

        // go ahead and release the "pin" from our handle on that memory
        gcHandle.Free();

        // If the target device does not have one plane, or we're working with a bitmap other
        // than a non-compressed (BI_RGB) bitmap, we're not gonna work woith it
        if (dibInfoHeader.biPlanes != 1 || (dibInfoHeader.biCompression != 0 && dibInfoHeader.biCompression != BitmapCompressionMode.BI_BITFIELDS)) return null;

        if (ddb == null)
        {

            // we need to know beforehand the pixel-depth of our bitmap

            PixelFormat fmt = PixelFormat.Format24bppRgb;

            switch (dibInfoHeader.biBitCount)

            {

                case 32:

                    fmt = PixelFormat.Format32bppRgb;

                    break;

                case 24:

                    fmt = PixelFormat.Format24bppRgb;

                    break;

                case 16:

                    fmt = (is555) ? PixelFormat.Format16bppRgb555 :

                    PixelFormat.Format16bppRgb565;

                    break;

                default:

                    return null;

            }

            // prepare for our output bitmap

            ddb = new Bitmap(dibInfoHeader.biWidth, dibInfoHeader.biHeight, fmt);

            // load our "empty" bitmap into memory and lock it for

            // writing in the format we specified

            BitmapData bd = ddb.LockBits(new Rectangle(0, 0, ddb.Width, ddb.Height), ImageLockMode.WriteOnly, fmt);

            // marshal our device independent bitmap data over to our output bitmap

            Marshal.Copy(dibBytes, Marshal.SizeOf(dibInfoHeader), bd.Scan0, bd.Stride * bd.Height);

            // we're done marshalling, so release our bitmapdata lock

            ddb.UnlockBits(bd);

        }

        if (dibInfoHeader.biHeight > 0)
        {
            // DIB data is upside-down for some reason, so flip it
            ddb.RotateFlip(RotateFlipType.RotateNoneFlipY);
        }

        // return our bitmap
        return ddb;

    }
}