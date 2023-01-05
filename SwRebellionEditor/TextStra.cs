using System.Resources;
using Vestris.ResourceLib;

namespace SwRebellionEditor
{
    public static class TextStra
    {
        private static ResourceFile Resources;

        static TextStra()
        {
            Resources = new ResourceFile(RegistryKeys.InstalledLocation + "\\TEXTSTRA.DLL");
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
