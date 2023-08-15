using System.ComponentModel;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Vestris.ResourceLib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SwRebellionEditor;

// resource lib: https://github.com/resourcelib/resourcelib

#region LoadLibraryExFlags

[Flags]
public enum LoadLibraryExFlags : uint
{
    None = 0,
    LOAD_LIBRARY_AS_IMAGE_RESOURCE = 0x20
}

#endregion

public class ResourceFile
{
    #region kernel32.dll

    [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    protected static extern IntPtr BeginUpdateResourceW(string pFileName, bool bDeleteExistingResources);

    [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    protected static extern bool UpdateResourceW(IntPtr hUpdate, IntPtr lpType, IntPtr lpName, ushort wLanguage, byte[] lpData, UInt32 cbData);

    [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    protected static extern bool EndUpdateResourceW(IntPtr hUpdate, bool fDiscard);

    #endregion

    #region variables
    protected string _filePath;
    public Dictionary<string, byte[]> RT_301;
    public Dictionary<string, ushort> RT_301_lang;
    public Dictionary<string, byte[]> RT_303;
    public Dictionary<string, ushort> RT_303_lang;
    public Dictionary<string, BitmapResource> RT_BITMAP;
    public Dictionary<string, ushort> RT_BITMAP_lang;
    public Dictionary<string, string> RT_RCDATA;
    public Dictionary<string, ushort> RT_RCDATA_lang;
    public Dictionary<ushort, string> RT_STRING;
    public Dictionary<ushort, ushort> RT_STRING_lang;
    public ushort RT_301_lang_default => RT_301_lang.Values.GroupBy(l => l).OrderByDescending(g => g.Count()).First().Key;
    public ushort RT_303_lang_default => RT_303_lang.Values.GroupBy(l => l).OrderByDescending(g => g.Count()).First().Key;
    public ushort RT_BITMAP_lang_default => RT_BITMAP_lang.Values.GroupBy(l => l).OrderByDescending(g => g.Count()).First().Key;
    public ushort RT_RCDATA_lang_default => RT_RCDATA_lang.Values.GroupBy(l => l).OrderByDescending(g => g.Count()).First().Key;
    public ushort RT_STRING_lang_default => RT_STRING_lang.Values.GroupBy(l => l).OrderByDescending(g => g.Count()).First().Key;
    #endregion

    #region .ctor
    public ResourceFile(string filePath)
    {
        _filePath = filePath;
        RT_301 = new Dictionary<string, byte[]>();
        RT_301_lang = new Dictionary<string, ushort>();
        RT_303 = new Dictionary<string, byte[]>();
        RT_303_lang = new Dictionary<string, ushort>();
        RT_BITMAP = new Dictionary<string, BitmapResource>();
        RT_BITMAP_lang = new Dictionary<string, ushort>();
        RT_RCDATA = new Dictionary<string, string>();
        RT_RCDATA_lang = new Dictionary<string, ushort>();
        RT_STRING = new Dictionary<ushort, string>();
        RT_STRING_lang = new Dictionary<ushort, ushort>();
        Load();
    }
    #endregion

    #region Load/Save (RT_RCDATA, RT_BITMAP, RT_STRING, RT_303)
    public void Load()
    {
        using (ResourceInfo ri = new ResourceInfo())
        {
            ri.Load(_filePath);
            if (ri.ResourceTypes.Any(t => t.Name == (((int)Kernel32.ResourceTypes.RT_RCDATA).ToString())))
            {
                foreach (var r in ri[Kernel32.ResourceTypes.RT_RCDATA])
                {
                    RT_RCDATA.Add(r.Name.Name, Encoding.Latin1.GetString(r.WriteAndGetBytes()));
                    RT_RCDATA_lang.Add(r.Name.Name, r.Language);
                }
            }
            if (ri.ResourceTypes.Any(t => t.Name == (((int)Kernel32.ResourceTypes.RT_BITMAP).ToString())))
            {
                foreach (BitmapResource br in ri[Kernel32.ResourceTypes.RT_BITMAP])
                {
                    RT_BITMAP.Add(br.Name.Name, br);
                    RT_BITMAP_lang.Add(br.Name.Name, br.Language);
                }
            }
            if (ri.ResourceTypes.Any(t => t.Name == (((int)Kernel32.ResourceTypes.RT_STRING).ToString())))
            {
                foreach (StringResource sr in ri[Kernel32.ResourceTypes.RT_STRING])
                {
                    foreach (var s in sr.Strings)
                    {
                        RT_STRING.Add(s.Key, s.Value);
                        RT_STRING_lang.Add(s.Key, sr.Language);
                    }
                }
            }
            if (ri.ResourceTypes.Any(t => t.Name == "301"))
            {
                var resources = ri.Resources.FirstOrDefault(dr => dr.Key.TypeName == "301").Value;
                foreach (var r in resources)
                {
                    RT_301.Add(r.Name.Name, r.WriteAndGetBytes());
                    RT_301_lang.Add(r.Name.Name, r.Language);
                }
            }
            if (ri.ResourceTypes.Any(t => t.Name == "303"))
            {
                var resources = ri.Resources.FirstOrDefault(dr => dr.Key.TypeName == "303").Value;
                foreach (var r in resources)
                {
                    RT_303.Add(r.Name.Name, r.WriteAndGetBytes());
                    RT_303_lang.Add(r.Name.Name, r.Language);
                }
            }
            ri.Dispose();
        }
    }
    public void Save()
    {
        foreach (var key in RT_STRING.Keys)
            SaveString(key, RT_STRING[key]);
        foreach (var key in RT_RCDATA.Keys)
            SaveRcdata(key, RT_RCDATA[key]);
        foreach (var key in RT_BITMAP.Keys)
            SaveBitmap(key, RT_BITMAP[key]);
        foreach (var key in RT_303.Keys)
            Save303(key, RT_303[key]);
    }
    #endregion

    #region RT_301
    public ushort Get301Language(string id)
    {
        if (RT_301_lang.ContainsKey(id))
            return RT_301_lang[id];
        return RT_301_lang_default;
    }
    public void Save301(string id, byte[] bytes)
    {
        var lang = Get301Language(id);
        nint idAsNint;
        try
        {
            idAsNint = Convert.ToInt32(id);
        }
        catch
        {
            idAsNint = new ResourceId(id).Id;
        }

        IntPtr h = BeginUpdateResourceW(_filePath, false);
        if (h == IntPtr.Zero)
            throw new Win32Exception(Marshal.GetLastWin32Error());

        if (bytes != null && bytes.Length == 0)
            bytes = null;

        if (!UpdateResourceW(h, 301, idAsNint, lang, bytes, (bytes == null ? 0 : (uint)bytes.Length)))
            throw new Win32Exception(Marshal.GetLastWin32Error());

        if (!EndUpdateResourceW(h, false))
            throw new Win32Exception(Marshal.GetLastWin32Error());

        if (RT_301.ContainsKey(id))
            RT_301[id] = bytes;
        else
        {
            RT_301.Add(id, bytes);
            RT_301_lang.Add(id, lang);
        }
    }
    #endregion

    #region RT_303
    public ushort Get303Language(string id)
    {
        if (RT_303_lang.ContainsKey(id))
            return RT_303_lang[id];
        return RT_303_lang_default;
    }
    public void Save303(string id, byte[] bytes)
    {
        var lang = Get303Language(id);
        nint idAsNint;
        try
        {
            idAsNint = Convert.ToInt32(id);
        }
        catch
        {
            idAsNint = new ResourceId(id).Id;
        }

        IntPtr h = BeginUpdateResourceW(_filePath, false);
        if (h == IntPtr.Zero)
            throw new Win32Exception(Marshal.GetLastWin32Error());

        if (bytes != null && bytes.Length == 0)
            bytes = null;

        if (!UpdateResourceW(h, 303, idAsNint, lang, bytes, (bytes == null ? 0 : (uint)bytes.Length)))
            throw new Win32Exception(Marshal.GetLastWin32Error());
        
        if (!EndUpdateResourceW(h, false))
            throw new Win32Exception(Marshal.GetLastWin32Error());

        if (RT_303.ContainsKey(id))
            RT_303[id] = bytes;
        else
        {
            RT_303.Add(id, bytes);
            RT_303_lang.Add(id, lang);
        }
    }
    #endregion

    #region RT_BITMAP
    public ushort GetBitmapLanguage(string id)
    {
        if (RT_BITMAP_lang.ContainsKey(id))
            return RT_BITMAP_lang[id];
        return RT_BITMAP_lang_default;
    }
    public void SaveBitmap(string id, BitmapResource bitmapResource)
    {
        RT_BITMAP[id] = bitmapResource;
        bitmapResource.SaveTo(_filePath);
    }
    public void SaveBitmap(string id, string bitmapFilePath)
    {
        var lang = GetBitmapLanguage(id);

        IntPtr h = BeginUpdateResourceW(_filePath, false);
        if (h == IntPtr.Zero)
            throw new Win32Exception(Marshal.GetLastWin32Error());

        var bitmapFile = new BitmapFile(bitmapFilePath);
        var bytes = bitmapFile.Bitmap.Data;
        if (bytes != null && bytes.Length == 0)
            bytes = null;

        if (!UpdateResourceW(h, 2, Convert.ToInt32(id), lang, bytes, (bytes == null ? 0 : (uint)bytes.Length)))
            throw new Win32Exception(Marshal.GetLastWin32Error());

        if (!EndUpdateResourceW(h, false))
            throw new Win32Exception(Marshal.GetLastWin32Error());

        using (ResourceInfo ri = new ResourceInfo())
        {
            ri.Load(_filePath);
            foreach (BitmapResource br in ri[Kernel32.ResourceTypes.RT_BITMAP])
                if (br.Name.Name == id)
                {
                    if (RT_BITMAP.ContainsKey(id))
                        RT_BITMAP[id] = br;
                    else
                    {
                        RT_BITMAP.Add(id, br);
                        RT_BITMAP_lang.Add(id, lang);
                    }
                }
        }
    }
    #endregion

    #region RT_RCDATA
    public ushort GetRcdataLanguage(string id)
    {
        if (RT_RCDATA_lang.ContainsKey(id))
            return RT_RCDATA_lang[id];
        return RT_RCDATA_lang_default;
    }
    public void SaveRcdata(string id, string text)
    {
        var lang = GetRcdataLanguage(id);

        IntPtr h = BeginUpdateResourceW(_filePath, false);
        if (h == IntPtr.Zero)
            throw new Win32Exception(Marshal.GetLastWin32Error());

        var bytes = Encoding.Latin1.GetBytes(text);
        if (bytes != null)
            Array.Resize(ref bytes, bytes.Length + 1); // end of string 0

        if (!UpdateResourceW(h, 10, Convert.ToInt32(id), lang, bytes, (bytes == null ? 0 : (uint)bytes.Length)))
            throw new Win32Exception(Marshal.GetLastWin32Error());

        if (!EndUpdateResourceW(h, false))
            throw new Win32Exception(Marshal.GetLastWin32Error());

        if (RT_RCDATA.ContainsKey(id))
            RT_RCDATA[id] = text;
        else
        {
            RT_RCDATA.Add(id, text);
            RT_RCDATA_lang.Add(id, lang);
        }
    }
    #endregion

    #region RT_STRING
    public ushort GetStringLanguage(ushort id)
    {
        if (RT_STRING_lang.ContainsKey(id))
            return RT_STRING_lang[id];
        return RT_STRING_lang_default;
    }
    public void SaveString(ushort id, string text)
    {
        var sr = new StringResource();
        sr.Name = new ResourceId(StringResource.GetBlockId(id));
        sr.Language = GetStringLanguage(id);
        try
        {
            sr.LoadFrom(_filePath);
        }
        catch { }
        if (!RT_STRING.ContainsKey(id))
            sr.Strings.Add(id, text);
        else
            sr[id] = text;
        RT_STRING[id] = text;
        sr.SaveTo(_filePath);
    }
    #endregion
}
