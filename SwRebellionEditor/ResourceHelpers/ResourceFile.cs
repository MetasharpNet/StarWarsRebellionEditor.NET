using System.ComponentModel;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;
using Vestris.ResourceLib;

namespace SwRebellionEditor;

// resource lib: https://github.com/resourcelib/resourcelib

public class ResourceFile
{
    #region kernel32.dll
    [DllImport("kernel32.dll", SetLastError = true)]
    protected static extern IntPtr FindResource(IntPtr hModule, string lpName, string lpType);
    [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern IntPtr GetModuleHandle([MarshalAs(UnmanagedType.LPWStr)] string lpModuleName);
    [DllImport("kernel32.dll", SetLastError = true)]
    static extern IntPtr LoadLibraryEx(string lpFileName, IntPtr hReservedNull, LoadLibraryFlags dwFlags);
    [DllImport("kernel32.dll", SetLastError = true)]
    protected static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);
    [DllImport("kernel32.dll", SetLastError = true)]
    protected static extern IntPtr LockResource(IntPtr hResData);
    [DllImport("kernel32.dll", SetLastError = true)]
    protected static extern int SizeofResource(IntPtr hModule, IntPtr hResInfo);
    /// <summary>
    /// Returns a handle to either a language-neutral portable executable file (LN file) or a 
    /// language-specific resource file (.mui file) that can be used by the UpdateResource function 
    /// to add, delete, or replace resources in a binary module.
    /// </summary>
    /// <param name="pFileName">Pointer to a null-terminated string that specifies the binary file in which to update resources.</param>
    /// <param name="bDeleteExistingResources">Specifies whether to delete the pFileName parameter's existing resources.</param>
    /// <returns>If the function succeeds, the return value is a handle that can be used by the UpdateResource and EndUpdateResource functions.</returns>
    [DllImport("kernel32.dll", EntryPoint = "BeginUpdateResourceW", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    protected static extern IntPtr BeginUpdateResource(string pFileName, bool bDeleteExistingResources);
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
    protected static extern bool UpdateResource(IntPtr hUpdate, IntPtr lpType, IntPtr lpName, UInt16 wLanguage, byte[] lpData, UInt32 cbData);
    /// <summary>
    /// Commits or discards changes made prior to a call to UpdateResource.
    /// </summary>
    /// <param name="hUpdate">A module handle returned by the BeginUpdateResource function, and used by UpdateResource, referencing the file to be updated.</param>
    /// <param name="fDiscard">Specifies whether to write the resource updates to the file. If this parameter is TRUE, no changes are made. If it is FALSE, the changes are made: the resource updates will take effect.</param>
    /// <returns>Returns TRUE if the function succeeds; FALSE otherwise.</returns>
    [DllImport("kernel32.dll", EntryPoint = "EndUpdateResourceW", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    protected static extern bool EndUpdateResource(IntPtr hUpdate, bool fDiscard);
    #endregion

    #region variables
    protected string _filePath;
    protected ushort _language;
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

    #region Load/Save (RT_RCDATA, RT_BITMAP, RT_STRING)
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
    public void Save()
    {
        foreach (var key in RT_STRING.Keys)
            SaveString(key, RT_STRING[key]);
        foreach (var key in RT_RCDATA.Keys)
            UpdateRcdata(key, RT_RCDATA[key]);
        foreach (var key in RT_BITMAP.Keys)
            SaveBitmap(key, RT_BITMAP[key]);
    }
    #endregion

    #region RT_BITMAP
    public BitmapResource GetBitmap(string id)
    {
        return RT_BITMAP[id];
    }
    public Bitmap GetBitmapThroughKernel32(string id)
    {
        //IntPtr hModule = GetModuleHandle(_filePath);
        IntPtr hModule = LoadLibraryEx(_filePath, IntPtr.Zero, LoadLibraryFlags.DONT_RESOLVE_DLL_REFERENCES | LoadLibraryFlags.LOAD_LIBRARY_AS_IMAGE_RESOURCE);
        IntPtr hResInfo = FindResource(hModule, id, "RT_BITMAP");
        IntPtr hResData = LoadResource(hModule, hResInfo);
        IntPtr pResData = LockResource(hResData);
        int size = SizeofResource(hModule, hResInfo);
        // Copy the resource data to a byte array
        var data = new byte[size];
        Marshal.Copy(pResData, data, 0, size);
        // Create a GCHandle to pin the data in memory
        GCHandle handle = GCHandle.Alloc(data, GCHandleType.Pinned);
        // Get a pointer to the data
        IntPtr pData = handle.AddrOfPinnedObject();
        // Copy the data to a BITMAP struct
        BITMAP bmp = (BITMAP)Marshal.PtrToStructure(pData, typeof(BITMAP));
        // Create a Bitmap object from the BITMAP struct
        Bitmap bitmap = new Bitmap(bmp.bmWidth, bmp.bmHeight, bmp.bmWidthBytes, PixelFormat.Format24bppRgb, bmp.bmBits);
        handle.Free();
        return bitmap;
    }

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
    public void SaveBitmap(string id, string bitmapFilePath)
    {
        if (!RT_BITMAP.ContainsKey(id))
            SaveNewBitmap(id, bitmapFilePath);
        var br = RT_BITMAP[id];
        br.Bitmap = new BitmapFile(bitmapFilePath).Bitmap;
        SaveBitmap(id, br);
    }
    public void SaveBitmap(string id, BitmapResource bitmapResource)
    {
        RT_BITMAP[id] = bitmapResource;
        bitmapResource.SaveTo(_filePath);
    }
    public void SaveNewBitmap(string id, string bitmapFilePath)
    {
        var bitmapFile = new BitmapFile(bitmapFilePath);
        //var bytes2 = File.ReadAllBytes(bitmapFilePath);
        using (ResourceInfo ri = new ResourceInfo())
        {
            ri.Load(_filePath);
            if (ri.ResourceTypes.Any(t => t.Name == (((int)Kernel32.ResourceTypes.RT_BITMAP).ToString())))
            {
                var r = ri[Kernel32.ResourceTypes.RT_BITMAP].FirstOrDefault(x => x?.Name?.Name == id);
                if (r == null)
                {
                    IntPtr h = BeginUpdateResource(_filePath, false);
                    if (h == IntPtr.Zero)
                        throw new Win32Exception(Marshal.GetLastWin32Error());
                    var bytes = bitmapFile.Bitmap.Data;
                    Array.Resize(ref bytes, bytes.Length + 1);
                    if (bytes != null && bytes.Length == 0)
                        bytes = null;
                    if (!UpdateResource(h, 2, Convert.ToInt32(id), _language, bytes, (bytes == null ? 0 : (uint)bytes.Length)))
                        throw new Win32Exception(Marshal.GetLastWin32Error());
                    ri.Dispose();
                    if (!EndUpdateResource(h, false))
                        throw new Win32Exception(Marshal.GetLastWin32Error());
                    // add in dictionary
                    ri.Load(_filePath);
                    foreach (BitmapResource br in ri[Kernel32.ResourceTypes.RT_BITMAP])
                        if (br.Name.Name == id)
                            RT_BITMAP.Add(id, br);
                }
            }
        }
    }
    #endregion

    #region RT_RCDATA
    public string GetRcdata(string id)
    {
        return RT_RCDATA[id];
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
    public void UpdateRcdata(string id, string text)
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
                    if (!UpdateResource(h, 10, r.Name.Id, r.Language, bytes, (bytes == null ? 0 : (uint)bytes.Length)))
                        throw new Win32Exception(Marshal.GetLastWin32Error());
                    ri.Dispose();
                    if (!EndUpdateResource(h, false))
                        throw new Win32Exception(Marshal.GetLastWin32Error());
                    RT_RCDATA[id] = text;
                }
            }
        }
    }
    #endregion

    #region RT_STRING
    public string GetString(ushort id)
    {
        return RT_STRING[id];
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
    public void SaveString(ushort id, string text)
    {
        var sr = new StringResource();
        sr.Name = new ResourceId(StringResource.GetBlockId(id));
        sr.Language = _language;
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

[StructLayout(LayoutKind.Sequential)]
struct BITMAP
{
    public int bmType;
    public int bmWidth;
    public int bmHeight;
    public int bmWidthBytes;
    public ushort bmPlanes;
    public ushort bmBitsPixel;
    public IntPtr bmBits;
}
[System.Flags]
enum LoadLibraryFlags : uint
{
    None = 0,
    DONT_RESOLVE_DLL_REFERENCES = 0x00000001,
    LOAD_IGNORE_CODE_AUTHZ_LEVEL = 0x00000010,
    LOAD_LIBRARY_AS_DATAFILE = 0x00000002,
    LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE = 0x00000040,
    LOAD_LIBRARY_AS_IMAGE_RESOURCE = 0x00000020,
    LOAD_LIBRARY_SEARCH_APPLICATION_DIR = 0x00000200,
    LOAD_LIBRARY_SEARCH_DEFAULT_DIRS = 0x00001000,
    LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR = 0x00000100,
    LOAD_LIBRARY_SEARCH_SYSTEM32 = 0x00000800,
    LOAD_LIBRARY_SEARCH_USER_DIRS = 0x00000400,
    LOAD_WITH_ALTERED_SEARCH_PATH = 0x00000008,
    LOAD_LIBRARY_REQUIRE_SIGNED_TARGET = 0x00000080,
    LOAD_LIBRARY_SAFE_CURRENT_DIRS = 0x00002000,
}