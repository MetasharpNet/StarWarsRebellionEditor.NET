using System.Resources;
using Vestris.ResourceLib;

namespace SwRebellionEditor
{
    public static class EncyText
    {
        private static ResourceFile Resources;

        static EncyText()
        {
            Resources = new ResourceFile(RegistryKeys.InstalledLocation + "\\ENCYTEXT.DLL");
        }

        public static string GetRcdata(string id)
        {
            return Resources.RT_RCDATA[id];
        }

        public static string GetString(ushort id)
        {
            return Resources.RT_STRING[id];
        }

        public static void SaveString(ushort id, string text)
        {
            Resources.SaveString(id, text);
        }
    }
}
