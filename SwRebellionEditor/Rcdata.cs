using System.Runtime.InteropServices;

namespace SwRebellionEditor
{
    public class Rcdata
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr BeginUpdateResource(string pFileName, [MarshalAs(UnmanagedType.Bool)] bool bDeleteExistingResources);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool EndUpdateResource(IntPtr hUpdate, bool fDiscard);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr FindResource(IntPtr hModule, string lpName, string lpType);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);
        [DllImport("Kernel32.dll", EntryPoint = "LoadResource", SetLastError = true)]
        private static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResource);
        [DllImport("Kernel32.dll", EntryPoint = "SizeofResource", SetLastError = true)]
        private static extern uint SizeofResource(IntPtr hModule, IntPtr hResource);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool UpdateResource(IntPtr hUpdate, string lpType, string lpName, ushort wLanguage, IntPtr lpData, uint cbData);

        private static IntPtr ToPtr(object data)
        {
            GCHandle h = GCHandle.Alloc(data, GCHandleType.Pinned);
            IntPtr ptr;
            try
            {
                ptr = h.AddrOfPinnedObject();
            }
            finally
            {
                h.Free();
            }
            return ptr;

        }

        public static bool InjectResource(string filename, byte[] bytes, string resourceName)
        {
            try
            {
                IntPtr handle = BeginUpdateResource(filename, false);
                byte[] file1 = bytes;
                IntPtr fileptr = ToPtr(file1);
                bool res = UpdateResource(handle, resourceName,
                    //"RT_RCDATA",
                    "0", 0, fileptr, Convert.ToUInt32(file1.Length));
                EndUpdateResource(handle, false);
            }
            catch
            {
                return false;
            }
            return true;

        }

        public static void CopyStream(Stream input, Stream output, long sz)
        {
            // Insert null checking here for production
            byte[] buffer = new byte[sz];

            int bytesRead;
            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, bytesRead);
            }
        }



        public static byte[] GetFromResource(String resourceName)
        {
            try
            {
                IntPtr hModule = GetModuleHandle(System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName);
                IntPtr loc = FindResource(hModule, "0", resourceName);
                uint size = SizeofResource(hModule, loc);
                IntPtr x = LoadResource(hModule, loc);
                byte[] bPtr = new byte[size];
                Marshal.Copy(x, bPtr, 0, (int)(size));
                return bPtr;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                System.Environment.Exit(0);
                return null;
            }
        }
    }
}
