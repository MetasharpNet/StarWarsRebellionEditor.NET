using Vestris.ResourceLib;

namespace SwRebellionEditor
{
    public class ResourceFile
    {
        private string _filePath;
        public Dictionary<ushort, string> RT_STRING;

        public ResourceFile(string filePath)
        {
            _filePath = filePath;
            RT_STRING = new Dictionary<ushort, string>();
            Load();
        }

        public void Load()
        {
            using (ResourceInfo ri = new ResourceInfo())
            {
                ri.Load(_filePath);
                foreach (StringResource sr in ri[Kernel32.ResourceTypes.RT_STRING])
                {
                    foreach (var s in sr.Strings)
                        RT_STRING.Add(s.Key, s.Value);
                }
            }
        }

        public void Save()
        {
            foreach (var key in RT_STRING.Keys)
                SaveString(key, RT_STRING[key]);
        }

        public void SaveString(ushort id, string text)
        {
            RT_STRING[id] = text;
            var sr = new StringResource();
            sr.Name = new ResourceId(StringResource.GetBlockId(id));
            sr.LoadFrom(_filePath);
            sr[id] = text;
            sr.SaveTo(_filePath);
        }

        // deprecated
        public static void AddToDictionary(Resource resource, Dictionary<ushort, string> dic)
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
                    ushort id;
                    string val = "";
                    if (lines[l].IndexOf(" ") < 0)
                        id = Convert.ToUInt16(lines[l]);
                    else
                    {
                        id = Convert.ToUInt16(lines[l].Substring(0, lines[l].IndexOf(" ")));
                        val = lines[l].Substring(lines[l].IndexOf(" ") + 1);
                    }
                    dic.Add(id, val);
                }
            }
            else
            {
                //dic.Add(resource.Name.Name, Tools.ToString(resource.WriteAndGetBytes()));
            }
        }
    }
}
