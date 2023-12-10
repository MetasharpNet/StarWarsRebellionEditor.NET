using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace SwRebellionEditor;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        // disable cleartype rendering
        //Application.EnableVisualStyles();
        //Application.SetCompatibleTextRenderingDefault(true); // Set this to true
        
        Application.Run(new MainForm());
    }
}