using Vestris.ResourceLib;

namespace SwRebellionEditor
{
    public static class TextStra
    {
        private static Dictionary<string, string> _dic;

        static TextStra()
        {
            var filePath = RegistryKeys.InstalledLocation + "\\TEXTSTRA.DLL";
            _dic = new Dictionary<string, string>();
            using (ResourceInfo vi = new ResourceInfo())
            {
                vi.Load(filePath);
                foreach (ResourceId id in vi.ResourceTypes)
                {
                    foreach (Resource resource in vi.Resources[id])
                        Tools.AddToDictionary(resource, _dic);
                }
            }
        }

        public static string Get(string id)
        {
            return _dic[id];
        }
    }
}
