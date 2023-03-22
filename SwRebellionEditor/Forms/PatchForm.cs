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



        // ---------------------------- SPRITES ----------------------------

        // new encybmap ids for encyclopedia pictures EDATA.13001 to 13200
        foreach (var filePath in Directory.GetFiles("new-systems-encyclopedia-pictures"))
        {
            if (Path.GetExtension(filePath).ToLowerInvariant() == ".txt")
                continue;
            var ebId = Path.GetFileNameWithoutExtension(filePath);
            if (ebId.Contains("-"))
                ebId = ebId.Split('-')[0];
            else if (ebId.StartsWith("EDATA."))
                ebId = ebId.Split('.')[1];
            if (Convert.ToInt32(ebId) < 166 || Convert.ToInt32(ebId) > 191)
                EncyBmap.Resources.SaveString(Convert.ToUInt16(ebId), "EDATA." + ebId);
            File.Copy(filePath, Path.Combine(Settings.Current.EDataFolder, "EDATA." + ebId), true);
        }

        var defaultTacticalPalette = new AdobeColorTable(Tactical.Resources.RT_303["5557"]);
        // new 256x256 tactical systems sprites using global color table
        foreach (var filePath in Directory.GetFiles("new-systems-tactical"))
        {
            if (Path.GetExtension(filePath).ToLowerInvariant() == ".txt")
                continue;
            var taId = Path.GetFileNameWithoutExtension(filePath).Split('-')[0];
            var taPalId = (Convert.ToInt32(taId) + 1000).ToString();
            var b = new Bitmap(filePath);
            var bi = new BinImage(b, defaultTacticalPalette, true, 256, 256);
            Tactical.Resources.Save303(taId, bi.Bytes);
            Tactical.Resources.Save303(taPalId, bi.ColorTable.Bytes);
        }

        // new 3D models
        foreach (var filePath in Directory.GetFiles("new-3d-models-301"))
        {
            var extension = Path.GetExtension(filePath).ToLowerInvariant();
            if (extension == ".txt")
                continue;
            var id301 = Path.GetFileNameWithoutExtension(filePath).Split('-')[0];
            byte[] bytes;
            if (extension == ".x")
                bytes = File.ReadAllBytes(filePath);
            else
                throw new ApplicationException("Accepted 3D model extension: x. File provided: " + filePath);
            Tactical.Resources.Save301(id301, bytes);
        }

        // new 3D models textures
        foreach (var filePath in Directory.GetFiles("new-3d-textures-303"))
        {
            var extension = Path.GetExtension(filePath).ToLowerInvariant();
            if (extension == ".txt")
                continue;
            var id303 = Path.GetFileNameWithoutExtension(filePath).Split('-')[0];
            int res;
            if (!Int32.TryParse(id303, out res) && !id303.Contains("."))
                id303 = Path.GetFileName(filePath);
            byte[] bytes;
            if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp")
            {
                var b = new Bitmap(filePath);
                var bi = new BinImage(b, defaultTacticalPalette, true);
                bytes = bi.Bytes;
            }
            else if (extension == ".bin")
                bytes = File.ReadAllBytes(filePath);
            else
                throw new ApplicationException("Accepted 3D model textures extensions: jpg, jpeg, bmp, png, bin. File provided: " + filePath);
            Tactical.Resources.Save303(id303, bytes);
        }

        // planets-sprites
        var t = new ResourceFile(Path.Combine(Settings.Current.GameFolder, "STRATEGY.DLL"));
        // identify coruscant id
        var f = Directory.GetFiles("new-systems-sprites").First(f => f.ToLowerInvariant().Contains("coruscant"));
        var coruscantId = Convert.ToUInt16(Path.GetFileName(f).Split("-")[0]);
        // pre-init resource slots with a specific sprite to avoid sprite being displayed on top of the names
        f = Directory.GetFiles("new-systems-sprites").First(f => f.Contains("14000-wireframe.bmp"));
        for (int p = 0; p <= 200; ++p)
        {
            var key = (14000 + p).ToString();
            if (!t.RT_BITMAP.ContainsKey(key))
                t.SaveBitmap(key, f);
        }
        foreach (var filePath in Directory.GetFiles("new-systems-sprites"))
        {
            if (Path.GetExtension(filePath).ToLowerInvariant() == ".txt")
                continue;
            var id = Path.GetFileNameWithoutExtension(filePath).Split('-')[0];
            t.SaveBitmap(id, filePath);
        }

        // ---------------------------- REBEXE.EXE ----------------------------

        // patching rebexe.exe
        using (var stream = new FileStream(Settings.Current.REBEXEFilePath, FileMode.Open, FileAccess.ReadWrite))
        {
            // to use 14001+ ids for galaxy map planet sprites
            stream.Position = int.Parse("5B1E4", NumberStyles.HexNumber);
            stream.WriteByte(0x05); // add eax, 14000
            stream.WriteByte(0xB0);
            stream.WriteByte(0x36);
            stream.WriteByte(0x00);
            stream.WriteByte(0x00);
            stream.WriteByte(0xC3); // retn
            // to use coruscant sprite for empire objective to keep coruscant
            stream.Position = int.Parse("4A46F", NumberStyles.HexNumber);
            stream.WriteByte((byte)(coruscantId & 0x00FF)); // 14036 36D4 => D4 then 36
            stream.WriteByte((byte)((coruscantId & 0xFF00) >> 8));
            // to use coruscant sprite for rebel alliance objective to take coruscant
            stream.Position = int.Parse("49BCF", NumberStyles.HexNumber);
            stream.WriteByte((byte)(coruscantId & 0x00FF)); // 14036 36D4 => D4 then 36
            stream.WriteByte((byte)((coruscantId & 0xFF00) >> 8));
            // to use 14001+ ids for encyclopedia edata planets pictures
            stream.Position = int.Parse("5DED6", NumberStyles.HexNumber);
            stream.WriteByte(0x89); // move eax, ecx
            stream.WriteByte(0xC8);
            stream.WriteByte(0x05); // add eax, 14000
            stream.WriteByte(0xB0);
            stream.WriteByte(0x36);
            stream.WriteByte(0x00);
            stream.WriteByte(0x00);
            stream.WriteByte(0xC2); // retn 4
            stream.WriteByte(0x04);
            // to use 14001+ ids for tactical planets bin images
            stream.Position = int.Parse("1AA022", NumberStyles.HexNumber);
            stream.WriteByte(0xB0); // 14000
            stream.WriteByte(0x36);
            // to use 15001+ ids for tactical planets bin palettes
            stream.Position = int.Parse("19456E", NumberStyles.HexNumber);
            stream.WriteByte(0x98); // 15000
            stream.WriteByte(0x3A);
            stream.Position = int.Parse("1C0929", NumberStyles.HexNumber);
            stream.WriteByte(0x00); // +0
            // to use 14000 ids for tactical destroyed planet
            stream.Position = int.Parse("197A25", NumberStyles.HexNumber);
            stream.WriteByte(0x00); // +0
        }

        // ---------------------------- DATA ----------------------------

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
            if (!Strategy.Resources.RT_BITMAP.ContainsKey((14000 + Convert.ToInt32(systemColumns[7])).ToString()))
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