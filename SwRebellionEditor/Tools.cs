using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;

namespace SwRebellionEditor;

public static class Tools
{
    public static void SetBytes<T>(byte[] bytes, T value, int position)
        where T : struct
    {
        int valueSize = Marshal.SizeOf<T>();

        if (typeof(T).IsPrimitive && !typeof(T).IsArray && valueSize <= 8)
        {
            IntPtr ptr = Marshal.AllocHGlobal(valueSize);

            try
            {
                Marshal.StructureToPtr(value, ptr, false);
                Marshal.Copy(ptr, bytes, position, valueSize);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }
        else
        {
            if (value is float floatValue)
            {
                byte[] floatBytes = BitConverter.GetBytes(floatValue);
                Array.Copy(floatBytes, 0, bytes, position, floatBytes.Length);
            }
            if (value is double doubleValue)
            {
                byte[] doubleBytes = BitConverter.GetBytes(doubleValue);
                Array.Copy(doubleBytes, 0, bytes, position, doubleBytes.Length);
            }
            // Add more cases for other non-blittable types if needed
        }
    }

    public static string ShortenFilePath(string filePath, int maxLength = 260) // MAX_PATH
    {
        filePath = Path.GetFullPath(filePath);
        if (filePath.Length <= maxLength)
            return filePath;

        string directory = Path.GetDirectoryName(filePath);
        string fileName = Path.GetFileNameWithoutExtension(filePath);
        string extension = Path.GetExtension(filePath);

        int maxFileNameLength = maxLength - directory.Length - extension.Length - 1; // 1 for the backslash

        if (maxFileNameLength <= 0)
            throw new ArgumentException("The maximum length is too short to accommodate the directory and extension.");

        string shortenedFileName = fileName.Substring(0, maxFileNameLength);

        return Path.Combine(directory, shortenedFileName + extension);
    }

    public static Bitmap ToMemoryBitmap(Bitmap b)
    {
        if (b == null)
            return null;
        var ms = new MemoryStream();
        b.Save(ms, ImageFormat.Bmp);
        ms.Seek(0, SeekOrigin.Begin);
        return new Bitmap(ms);
    }
    public static Bitmap ToMemoryBitmap(string filePath)
    {
        if (filePath == null || !File.Exists(filePath))
            return null;
        var bytes = File.ReadAllBytes(filePath);
        var ms = new MemoryStream(bytes);
        return new Bitmap(ms);
    }
    public static string ToString(byte[] text)
    {
        if (text == null || text.Length < 1)
            return "";
        if (text.Length % 2 != 0)
            return Encoding.UTF8.GetString(text);
        if ((text.Length == 2 && text[1] == 0) ||
            (text.Length == 4 && text[1] == 0 && text[3] == 0) ||
            (text.Length >= 6 && text[1] == 0 && text[3] == 0 && text[5] == 0))
            return Encoding.Unicode.GetString(text);
        return Encoding.UTF8.GetString(text);
    }
}
