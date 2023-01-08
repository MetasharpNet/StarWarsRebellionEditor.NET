using System.Linq;
using Vestris.ResourceLib;

namespace SwRebellionEditor
{
    // resource lib: https://github.com/resourcelib/resourcelib

    public class ResourceFile
    {
        private string _filePath;
        private ushort _language;
        public Dictionary<string, string> RT_RCDATA;
        public Dictionary<ushort, string> RT_STRING;

        public ResourceFile(string filePath)
        {
            _filePath = filePath;
            RT_RCDATA = new Dictionary<string, string>();
            RT_STRING = new Dictionary<ushort, string>();
            Load();
        }

        public void Load()
        {
            using (ResourceInfo ri = new ResourceInfo())
            {
                ri.Load(_filePath);
                if (ri.ResourceTypes.Any(t => t.Name == (((int)Kernel32.ResourceTypes.RT_RCDATA).ToString())))
                {
                    foreach (var r in ri[Kernel32.ResourceTypes.RT_RCDATA])
                    {
                        RT_RCDATA.Add(r.Name.Name, Tools.ToString(r.WriteAndGetBytes()));
                    }
                }
                if (ri.ResourceTypes.Any(t => t.Name == (((int)Kernel32.ResourceTypes.RT_STRING).ToString())))
                {
                    foreach (StringResource sr in ri[Kernel32.ResourceTypes.RT_STRING])
                    {
                        foreach (var s in sr.Strings)
                        {
                            _language = sr.Language;
                            RT_STRING.Add(s.Key, s.Value);
                        }
                    }
                }
            }
        }

        public ushort GetStringLanguage(ushort stringId)
        {
            using (ResourceInfo ri = new ResourceInfo())
            {
                ri.Load(_filePath);
                if (ri.ResourceTypes.Any(t => t.Name == (((int)Kernel32.ResourceTypes.RT_STRING).ToString())))
                {
                    foreach (StringResource sr in ri[Kernel32.ResourceTypes.RT_STRING])
                    {
                        sr.Name = new ResourceId(StringResource.GetBlockId(stringId));
                        sr.LoadFrom(_filePath);
                        return sr.Language;
                    }
                }
            }
            return 0;
        }

        public void Save()
        {
            foreach (var key in RT_STRING.Keys)
                SaveString(key, RT_STRING[key]);
        }

        public void SaveString(ushort id, string text)
        {
            var lang = GetStringLanguage(id);
            RT_STRING[id] = text;
            var sr = new StringResource();
            sr.Name = new ResourceId(StringResource.GetBlockId(id));
            sr.LoadFrom(_filePath);
            sr[id] = text;
            sr.Language = lang;
            sr.SaveTo(_filePath);
        }
    }
}
