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
