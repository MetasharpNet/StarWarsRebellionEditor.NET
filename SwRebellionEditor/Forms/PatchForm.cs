using SwRebellionEditor.ResourceHelpers;
using System.Globalization;

namespace SwRebellionEditor;

public partial class PatchForm : PatchDesignForm
{
    #region .ctor

    private string SectorsGameFilePath;
    private SECTORSD SectorsGameFile;

    public PatchForm()
    {
        SectorsGameFilePath = Path.Combine(Settings.Current.GDataFolder, "SECTORSD.DAT");
        SectorsGameFile = DatFile.Load<SECTORSD>(SectorsGameFilePath);
        GameFilePath = Path.Combine(Settings.Current.GDataFolder , "SYSTEMSD.DAT");
        GameFile = DatFile.Load<SYSTEMSD>(GameFilePath);
        InitializeComponent();
        var rt303 = Tactical.Resources.RT_303;
        //var bin = new BinImage("5511.bin");
        //var pal = new BinPalette("5541.pal");
        var bin = new BinImage(rt303["5511"]);
        var pal = new BinPalette(rt303["5541"]);
        //binPicture.Image = pal.ToBitmap();
        binPicture.Image = bin.ToBitmap(pal);
        //rt303["ASSFRG_M.BMP"] = rt303["ASSFRG52.BMP"];
        //Tactical.Resources.Save();
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
    private void patch_Click(object sender, EventArgs e)
    {
        this.Enabled = false;
        // MANDATORY EXPECTATIONS

        // systems
        // id = 265, sectorid = 36   (Coruscant)
        // id = 289, sectorid = 38   (Yavin)

        // sectors
        // id = 36, galaxysize = 1, importance = 1
        // id = 38, galaxysize = 1

        // patching rebexe.exe
        using (var stream = new FileStream(Settings.Current.REBEXEFilePath, FileMode.Open, FileAccess.ReadWrite))
        {
            // to use 13001+ ids for galaxy map planet sprites
            stream.Position = int.Parse("5B1E4", NumberStyles.HexNumber);
            stream.WriteByte(0x05); // add eax, 13000
            stream.WriteByte(0xC8);
            stream.WriteByte(0x32);
            stream.WriteByte(0x00);
            stream.WriteByte(0x00); 
            stream.WriteByte(0xC3); // retn
            // to use 13001+ ids for encyclopedia edata planets pictures
            stream.Position = int.Parse("5DED6", NumberStyles.HexNumber);
            stream.WriteByte(0x89); // move eax, ecx
            stream.WriteByte(0xC8);
            stream.WriteByte(0x05); // add eax, 13000
            stream.WriteByte(0xC8);
            stream.WriteByte(0x32);
            stream.WriteByte(0x00);
            stream.WriteByte(0x00);
            stream.WriteByte(0xC2); // retn 4
            stream.WriteByte(0x04);
        }

        // new encybmap ids for encyclopedia pictures EDATA.13001 to 13200
        foreach (var filesPath in Directory.GetFiles("new-systems-encyclopedia-pictures"))
        {
            var ebId = Path.GetFileNameWithoutExtension(filesPath);
            if (ebId.Contains("-"))
                ebId = ebId.Split('-')[0];
            else if (ebId.StartsWith("EDATA."))
                ebId = ebId.Split('.')[1];
            if (Convert.ToInt32(ebId) < 166 || Convert.ToInt32(ebId) > 191)
                EncyBmap.Resources.SaveString(Convert.ToUInt16(ebId), "EDATA." + ebId);
            File.Copy(filesPath, Path.Combine(Settings.Current.EDataFolder, "EDATA." + ebId), true);
        }

        // planets-sprites
        var t = new ResourceFile(Path.Combine(Settings.Current.GameFolder, "STRATEGY.DLL"));
        // pre-init resource slots with a specific sprite to avoid sprite being displayed on top of the names
        var f = Directory.GetFiles("new-systems-sprites").First(f => f.Contains("10240-debris.bmp"));
        for (int p = 0; p <= 200; ++p)
        {
            var key = (13000 + p).ToString();
            if (!t.RT_BITMAP.ContainsKey(key))
                t.SaveBitmap(key, f);
        }
        foreach (var filesPath in Directory.GetFiles("new-systems-sprites"))
        {
            var id = Path.GetFileNameWithoutExtension(filesPath).Split('-')[0];
            t.SaveBitmap(id, filesPath);
        }

        // sectors
        var newSectorsAsString = File.ReadAllText("new-sectors.csv");
        var newSectorsLines = newSectorsAsString.Split(Environment.NewLine);
        int i = -1;
        foreach (var newSectorsLine in newSectorsLines)
        {
            if (newSectorsLine.Length <= 0) continue;
            if (i == -1)
            { // skip header line
                i = 0;
                continue;
            }
            var sectorColumns = newSectorsLine.Split(';');
            SectorsGameFile.Sectors[i].Name = sectorColumns[0];
            SectorsGameFile.Sectors[i].Id = Convert.ToUInt32(sectorColumns[1]);
            SectorsGameFile.Sectors[i].XPosition = Convert.ToUInt16(TrimDecimal(sectorColumns[2]));
            SectorsGameFile.Sectors[i].YPosition = Convert.ToUInt16(TrimDecimal(sectorColumns[3]));
            if (sectorColumns[4] == "Core")
                SectorsGameFile.Sectors[i].Group = 1;
            if (sectorColumns[4] == "Rim (inner)")
                SectorsGameFile.Sectors[i].Group = 2;
            if (sectorColumns[4] == "Rim (outer)")
                SectorsGameFile.Sectors[i].Group = 3;
            if (sectorColumns[5] == "Standard")
                SectorsGameFile.Sectors[i].GalaxySize = 1;
            if (sectorColumns[5] == "Large")
                SectorsGameFile.Sectors[i].GalaxySize = 2;
            if (sectorColumns[5] == "Huge")
                SectorsGameFile.Sectors[i].GalaxySize = 3;
            ++i;
        }

        // systems
        var descDic = new Dictionary<string, string>();
        foreach (var system in GameFile.Systems)
            descDic.Add(system.Name.ToLowerInvariant(), system.EncyclopediaDescription);
        var newSystemsAsString = File.ReadAllText("new-systems.csv");
        var newSystemsLines = newSystemsAsString.Split(Environment.NewLine);
        i = -1;
        foreach (var newSystemsLine in newSystemsLines)
        {
            if (newSystemsLine.Length <= 0) continue;
            if (i == -1)
            { // skip header line
                i = 0;
                continue;
            }
            var systemColumns = newSystemsLine.Split(';');
            GameFile.Systems[i].Name = systemColumns[0];
            GameFile.Systems[i].Id = Convert.ToUInt32(systemColumns[1]);
            GameFile.Systems[i].TextStraDllId = Convert.ToUInt16(systemColumns[2]);
            GameFile.Systems[i].SectorId = SectorsGameFile.Sectors.First(s => s.Name == systemColumns[3]).Id;
            GameFile.Systems[i].XPosition = Convert.ToUInt16(TrimDecimal(systemColumns[4]));
            GameFile.Systems[i].YPosition = Convert.ToUInt16(TrimDecimal(systemColumns[5]));
            GameFile.Systems[i].FamilyId = (uint)(systemColumns[6] == "Rim" ? 146 : 144);
            GameFile.Systems[i].PictureId = Convert.ToUInt32(TrimDecimal(systemColumns[7]));
            if (!Strategy.Resources.RT_BITMAP.ContainsKey((13000+Convert.ToInt32(systemColumns[7])).ToString()))
                GameFile.Systems[i].PictureId = 0;
            if (systemColumns[8]?.Length > 0)
                GameFile.Systems[i].EncyclopediaDescription = systemColumns[8].TrimStart('"').TrimEnd('"');
            else if (descDic.ContainsKey(GameFile.Systems[i].Name.ToLowerInvariant()))
                GameFile.Systems[i].EncyclopediaDescription = descDic[GameFile.Systems[i].Name.ToLowerInvariant()];
            else
                GameFile.Systems[i].EncyclopediaDescription = "";
            ++i;
        }

        // save
        SectorsGameFile.Save(SectorsGameFilePath);
        foreach (var sector in SectorsGameFile.Sectors)
            TextStra.Resources.SaveString(Convert.ToUInt16(sector.TextStraDllId), sector.Name);
        GameFile.Save(GameFilePath);
        foreach (var system in GameFile.Systems)
        {
            TextStra.Resources.SaveString(Convert.ToUInt16(system.TextStraDllId), system.Name);
            EncyText.Resources.SaveRcdata((system.TextStraDllId - 4096).ToString(), system.EncyclopediaDescription);
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