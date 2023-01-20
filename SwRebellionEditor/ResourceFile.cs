using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using Vestris.ResourceLib;

namespace SwRebellionEditor;

// resource lib: https://github.com/resourcelib/resourcelib

public class ResourceFile
{
    #region kernel32.dll
    /// <summary>
    /// Returns a handle to either a language-neutral portable executable file (LN file) or a 
    /// language-specific resource file (.mui file) that can be used by the UpdateResource function 
    /// to add, delete, or replace resources in a binary module.
    /// </summary>
    /// <param name="pFileName">Pointer to a null-terminated string that specifies the binary file in which to update resources.</param>
    /// <param name="bDeleteExistingResources">Specifies whether to delete the pFileName parameter's existing resources.</param>
    /// <returns>If the function succeeds, the return value is a handle that can be used by the UpdateResource and EndUpdateResource functions.</returns>
    [DllImport("kernel32.dll", EntryPoint = "BeginUpdateResourceW", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    internal static extern IntPtr BeginUpdateResource(string pFileName, bool bDeleteExistingResources);
    /// <summary>
    /// Adds, deletes, or replaces a resource in a portable executable (PE) file. 
    /// There are some restrictions on resource updates in files that contain Resource Configuration (RC Config) data: 
    /// language-neutral (LN) files and language-specific resource (.mui) files.
    /// </summary>
    /// <param name="hUpdate">A module handle returned by the BeginUpdateResource function, referencing the file to be updated.</param>
    /// <param name="lpType">Pointer to a null-terminated string specifying the resource type to be updated.</param>
    /// <param name="lpName">Pointer to a null-terminated string specifying the name of the resource to be updated.</param>
    /// <param name="wLanguage">Specifies the language identifier of the resource to be updated.</param>
    /// <param name="lpData">Pointer to the resource data to be inserted into the file indicated by hUpdate.</param>
    /// <param name="cbData">Specifies the size, in bytes, of the resource data at lpData.</param>
    /// <returns>Returns TRUE if successful or FALSE otherwise.</returns>
    [DllImport("kernel32.dll", EntryPoint = "UpdateResourceW", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    internal static extern bool UpdateResource(IntPtr hUpdate, IntPtr lpType, IntPtr lpName, UInt16 wLanguage, byte[] lpData, UInt32 cbData);
    /// <summary>
    /// Commits or discards changes made prior to a call to UpdateResource.
    /// </summary>
    /// <param name="hUpdate">A module handle returned by the BeginUpdateResource function, and used by UpdateResource, referencing the file to be updated.</param>
    /// <param name="fDiscard">Specifies whether to write the resource updates to the file. If this parameter is TRUE, no changes are made. If it is FALSE, the changes are made: the resource updates will take effect.</param>
    /// <returns>Returns TRUE if the function succeeds; FALSE otherwise.</returns>
    [DllImport("kernel32.dll", EntryPoint = "EndUpdateResourceW", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    internal static extern bool EndUpdateResource(IntPtr hUpdate, bool fDiscard);
    #endregion

    #region variables
    private string _filePath;
    private ushort _language;
    public Dictionary<string, BitmapResource> RT_BITMAP;
    public Dictionary<string, string> RT_RCDATA;
    public Dictionary<ushort, string> RT_STRING;
    #endregion

    #region .ctor
    public ResourceFile(string filePath)
    {
        _filePath = filePath;
        RT_BITMAP = new Dictionary<string, BitmapResource>();
        RT_RCDATA = new Dictionary<string, string>();
        RT_STRING = new Dictionary<ushort, string>();
        Load();
    }
    #endregion

    #region Load (RT_RCDATA, RT_BITMAP, RT_STRING)
    public void Load()
    {
        using (ResourceInfo ri = new ResourceInfo())
        {
            ri.Load(_filePath);
            if (ri.ResourceTypes.Any(t => t.Name == (((int)Kernel32.ResourceTypes.RT_RCDATA).ToString())))
            {
                foreach (var r in ri[Kernel32.ResourceTypes.RT_RCDATA])
                {
                    _language = r.Language;
                    RT_RCDATA.Add(r.Name.Name, Encoding.Latin1.GetString(r.WriteAndGetBytes()));
                }
            }
            if (ri.ResourceTypes.Any(t => t.Name == (((int)Kernel32.ResourceTypes.RT_BITMAP).ToString())))
            {
                foreach (BitmapResource br in ri[Kernel32.ResourceTypes.RT_BITMAP])
                {
                    _language = br.Language;
                    RT_BITMAP.Add(br.Name.Name, br);
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
    #endregion

    #region GetXXXXXXXXLanguage
    public ushort GetBitmapLanguage(string bitmapId)
    {
        using (ResourceInfo ri = new ResourceInfo())
        {
            ri.Load(_filePath);
            if (ri.ResourceTypes.Any(t => t.Name == (((int)Kernel32.ResourceTypes.RT_BITMAP).ToString())))
            {
                foreach (BitmapResource br in ri[Kernel32.ResourceTypes.RT_BITMAP])
                {
                    if (br.Name.Name == bitmapId)
                        return br.Language;
                }
            }
        }
        return 0;
    }
    public ushort GetRcdataLanguage(ushort rcdataId)
    {
        using (ResourceInfo ri = new ResourceInfo())
        {
            ri.Load(_filePath);
            if (ri.ResourceTypes.Any(t => t.Name == (((int)Kernel32.ResourceTypes.RT_RCDATA).ToString())))
            {
                foreach (Resource r in ri[Kernel32.ResourceTypes.RT_RCDATA])
                {
                    if (r.Name.Name == rcdataId.ToString())
                        return r.Language;
                }
            }
        }
        return 0;
    }
    public ushort GetStringLanguage(ushort stringId)
    {
        using (ResourceInfo ri = new ResourceInfo())
        {
            ri.Load(_filePath);
            if (ri.ResourceTypes.Any(t => t.Name == (((int)Kernel32.ResourceTypes.RT_STRING).ToString())))
            {
                var blockId = new ResourceId(StringResource.GetBlockId(stringId));
                foreach (StringResource sr in ri[Kernel32.ResourceTypes.RT_STRING])
                {
                    if (sr.Name.Name == blockId.Name)
                        return sr.Language;
                }
            }
        }
        return 0;
    }
    #endregion

    #region SaveXXXXXXXX
    public void Save()
    {
        foreach (var key in RT_STRING.Keys)
            SaveString(key, RT_STRING[key]);
        foreach (var key in RT_RCDATA.Keys)
            SaveRcdata(key, RT_RCDATA[key]);
        foreach (var key in RT_BITMAP.Keys)
            SaveBitmap(key, RT_BITMAP[key]);
    }
    public void SaveBitmap(string id, string bitmapFilePath)
    {
        var br = RT_BITMAP[id];
        br.Bitmap = new BitmapFile(bitmapFilePath).Bitmap;
        SaveBitmap(id, br);
    }
    public void SaveBitmap(string id, BitmapResource bitmapResource)
    {
        RT_BITMAP[id] = bitmapResource;
        bitmapResource.SaveTo(_filePath);
    }
    public void SaveRcdata(string id, string text)
    {
        using (ResourceInfo ri = new ResourceInfo())
        {
            ri.Load(_filePath);
            if (ri.ResourceTypes.Any(t => t.Name == (((int)Kernel32.ResourceTypes.RT_RCDATA).ToString())))
            {
                var r = ri[Kernel32.ResourceTypes.RT_RCDATA].FirstOrDefault(x => x?.Name?.Name == id);
                if (r != null)
                {
                    IntPtr h = BeginUpdateResource(_filePath, false);
                    if (h == IntPtr.Zero)
                        throw new Win32Exception(Marshal.GetLastWin32Error());
                    var bytes = Encoding.Latin1.GetBytes(text);
                    Array.Resize(ref bytes, bytes.Length + 1);
                    if (bytes != null && bytes.Length == 0)
                        bytes = null;
                    if (!UpdateResource(h, r.Type.Id, r.Name.Id, r.Language, bytes, (bytes == null ? 0 : (uint)bytes.Length)))
                        throw new Win32Exception(Marshal.GetLastWin32Error());
                    ri.Dispose();
                    if (!EndUpdateResource(h, false))
                        throw new Win32Exception(Marshal.GetLastWin32Error());
                    RT_RCDATA[id] = text;
                }
            }
        }
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
    #endregion
}
