using System.Text;

namespace SwRebellionEditor;

public static class Tools
{
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
