using System.Text;
using Vestris.ResourceLib;

namespace SwRebellionEditor
{
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

        public static void AddToDictionary(Resource resource, Dictionary<string, string> dic)
        {
            var lines = resource.ToString().Split("\r\n");
            if (lines.Length > 0 && lines[0] == "STRINGTABLE")
            {
                if (lines.Length < 1 || lines[1] != "BEGIN")
                    return;
                for (int l = 2; l < lines.Length - 1; ++l)
                {
                    lines[l] = lines[l].Trim();
                    if (lines[l] == "END")
                        break;
                    string id;
                    string val = "";
                    if (lines[l].IndexOf(" ") < 0)
                        id = lines[l];
                    else
                    {
                        id = lines[l].Substring(0, lines[l].IndexOf(" "));
                        val = lines[l].Substring(lines[l].IndexOf(" ") + 1);
                    }
                    dic.Add(id, val);
                }
            }
            else
            {
                dic.Add(resource.Name.Name, Tools.ToString(resource.WriteAndGetBytes()));
            }
        }
    }
}
