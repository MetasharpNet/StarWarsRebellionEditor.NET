using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace SwRebellionEditor;


// DPI Rendering: https://github.com/dotnet/winforms/blob/main/docs/designer/designer-high-dpi-mode.md
//                https://learn.microsoft.com/fr-fr/visualstudio/designers/scaling-percentage-display-setting-message?view=vs-2022&WT.mc_id=visualstudio_ide_fwlink_875609
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