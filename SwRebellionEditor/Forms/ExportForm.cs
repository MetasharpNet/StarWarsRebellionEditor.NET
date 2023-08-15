using SwRebellionEditor.ResourceHelpers;
using System.Drawing.Imaging;
using System.Globalization;

namespace SwRebellionEditor;

public partial class ExportForm : ExportDesignForm
{
    #region .ctor

    private string SectorsGameFilePath;
    private SECTORSD SectorsGameFile;

    public ExportForm()
    {
        SectorsGameFilePath = Path.Combine(Settings.Current.GDataFolder, "SECTORSD.DAT");
        SectorsGameFile = DatFile.Load<SECTORSD>(SectorsGameFilePath);
        GameFilePath = Path.Combine(Settings.Current.GDataFolder, "SYSTEMSD.DAT");
        GameFile = DatFile.Load<SYSTEMSD>(GameFilePath);
        InitializeComponent();
    }

    #endregion

    #region Events
    protected override void LoadSideInfo()
    {
        foreach (var s in GameFile.Systems)
        {
            s.Name = TextStra.Resources.RT_STRING[s.TextStraDllId];
            s.EncyclopediaDescription = EncyText.Resources.RT_RCDATA[(s.TextStraDllId - 4096).ToString()];
        }
    }
    private void cancel_Click(object sender, EventArgs e)
    {
        Close();
    }
    private void export_Click(object sender, EventArgs e)
    {
        this.Enabled = false;
        // MANDATORY EXPECTATIONS
        // systems
        // id = 265, sectorid = 36   (Coruscant)
        // id = 289, sectorid = 38   (Yavin)
        // sectors
        // id = 36, galaxysize = 1, importance = 1
        // id = 38, galaxysize = 1

        try { Directory.Delete("export", true); } catch { }
        Directory.CreateDirectory("export");

        // ---------------------------- EDATA ----------------------------
        Directory.CreateDirectory("export\\EDATA");
        var files = Directory.GetFiles(Settings.Current.EDataFolder);
        foreach (var filePath in files)
        {
            var fileName = Path.GetFileName(filePath);
            var newFileName = Path.GetExtension(fileName).Substring(1) + "-.bmp";
            File.Copy(filePath, Path.Combine(".\\export\\EDATA", newFileName), true);
        }

        // -------------------------- COMMON.DLL -------------------------
        // WAVE, Bitmap, RCData
        Directory.CreateDirectory("export\\COMMON.DLL");
        Directory.CreateDirectory("export\\COMMON.DLL\\Bitmap");
        var ids = Common.Resources.RT_BITMAP.Keys;
        foreach (var id in ids)
        {
            var lang = Common.Resources.GetBitmapLanguage(id);
            DIB.ToDDB(Common.Resources.RT_BITMAP[id].Bitmap, ".\\export\\COMMON.DLL\\Bitmap\\" + id + "-" + lang + "-" + ".bmp");
        }

        // -------------------------- GOKRES.DLL -------------------------
        // Bitmap
        Directory.CreateDirectory("export\\GOKRES.DLL");
        Directory.CreateDirectory("export\\GOKRES.DLL\\Bitmap");
        ids = Gokres.Resources.RT_BITMAP.Keys;
        foreach (var id in ids)
        {
            var lang = Gokres.Resources.GetBitmapLanguage(id);
            DIB.ToDDB(Gokres.Resources.RT_BITMAP[id].Bitmap, ".\\export\\GOKRES.DLL\\Bitmap\\" + id + "-" + lang + "-" + ".bmp");
        }


        // -------------------------- STRATEGY.DLL -------------------------
        // WAVE, Bitmap, RCData
        Directory.CreateDirectory("export\\STRATEGY.DLL");
        Directory.CreateDirectory("export\\STRATEGY.DLL\\Bitmap");
        ids = Strategy.Resources.RT_BITMAP.Keys;
        foreach (var id in ids)
        {
            var lang = Strategy.Resources.GetBitmapLanguage(id);
            DIB.ToDDB(Strategy.Resources.RT_BITMAP[id].Bitmap, ".\\export\\STRATEGY.DLL\\Bitmap\\" + id + "-" + lang + "-" + ".bmp");
        }

        // -------------------------- TACTICAL.DLL -------------------------
        // WAVE, Cursor, Bitmap, RCData, Cursor Group, 301, 303
        Directory.CreateDirectory("export\\TACTICAL.DLL");
        Directory.CreateDirectory("export\\TACTICAL.DLL\\Bitmap");
        ids = Tactical.Resources.RT_BITMAP.Keys;
        foreach (var id in ids)
        {
            var lang = Tactical.Resources.GetBitmapLanguage(id);
            DIB.ToDDB(Tactical.Resources.RT_BITMAP[id].Bitmap, ".\\export\\TACTICAL.DLL\\Bitmap\\" + id + "-" + lang + "-" + ".bmp");
        }

        this.Close();
    }

    public string TrimDecimal(string s)
    {
        if (s.IndexOf(',') > -1)
            s = s.Substring(0, s.IndexOf(","));
        if (s.IndexOf('.') > -1)
            s = s.Substring(0, s.IndexOf("."));
        if (s.Length < 1)
            s = "0";
        return s;
    }

    #endregion
}