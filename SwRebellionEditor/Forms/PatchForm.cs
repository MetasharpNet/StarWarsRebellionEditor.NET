﻿using SwRebellionEditor.ResourceHelpers;
using System.Globalization;

namespace SwRebellionEditor;

public partial class PatchForm : PatchDesignForm
{
    #region .ctor

    private string CapitalShipsGameFilePath;
    private CAPSHPSD CapitalShipsGameFile;
    private string SectorsGameFilePath;
    private SECTORSD SectorsGameFile;

    public PatchForm()
    {
        CapitalShipsGameFilePath = Path.Combine(Settings.Current.GDataFolder, "CAPSHPSD.DAT");
        CapitalShipsGameFile = DatFile.Load<CAPSHPSD>(CapitalShipsGameFilePath);
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
            s.Name = ResourcesDlls.Textstra.RT_STRING[s.TextStraDllId];
            s.EncyclopediaDescription = ResourcesDlls.Encytext.RT_RCDATA[(s.TextStraDllId - 4096).ToString()];
        }
    }
    private void cancel_Click(object sender, EventArgs e)
    {
        Close();
    }
    private void charactersWithoutStatsCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (charactersWithoutStatsCheckBox.Checked)
            charactersWithStatsCheckBox.Checked = false;
    }
    private void charactersWithStatsCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (charactersWithStatsCheckBox.Checked)
            charactersWithoutStatsCheckBox.Checked = false;
    }
    private void patch_Click(object sender, EventArgs e)
    {
        Patch(false);
    }

    private void patchTest_Click(object sender, EventArgs e)
    {
        Patch(true);
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

    #region Patch

    private void Patch(bool testOnly)
    {
        if (!File.Exists(Settings.Current.REBEXEFilePath))
        {
            try { MessageBox.Show("Please set in the editor a proper game folder. Current: " + Path.GetDirectoryName(Settings.Current.REBEXEFilePath)); }
            catch { MessageBox.Show("Please set in the editor a proper game folder."); }
            return;
        }

        // test texture
        //var bix = new BinImage(16);
        //bix.Save("test.bmp-256 colors palette 256x256.bin");

        this.Enabled = false;
        // MANDATORY EXPECTATIONS
        // systems
        // id = 265, sectorid = 36   (Coruscant)
        // id = 289, sectorid = 38   (Yavin)
        // sectors
        // id = 36, galaxysize = 1, importance = 1
        // id = 38, galaxysize = 1

        // ---------------------------- PATCH ----------------------------
        try { File.Delete(Path.Combine(Settings.Current.GameFolder, "_dgvoodoo_settings_suggestion_1_general.jpg")); } catch { }
        try { File.Delete(Path.Combine(Settings.Current.GameFolder, "_dgvoodoo_settings_suggestion_3_directx.jpg")); } catch { }
        if (!testOnly)
        {
            foreach (var filePath in Directory.GetFiles("game-update"))
            {
                if (Path.GetExtension(filePath).ToLowerInvariant() == ".txt")
                    continue;
                var filename = Path.GetFileName(filePath);
                File.Copy(filePath, Path.Combine(Settings.Current.GameFolder, filename), true);
            }
        }

        // ---------------------------- PICTURES ---------------------------

        var defaultTacticalPalette = new AdobeColorTable(ResourcesDlls.Tactical.RT_303["5557"]);
        int coruscantId = -1;
        foreach (var setFolder in Directory.GetDirectories("."))
        {
            var setFolderOnly = Path.GetFileName(setFolder);
            if (!testOnly)
            {
                if (setFolderOnly == "game-update")
                    continue;
                if (setFolderOnly == "export")
                    continue;
                if (setFolderOnly == "test")
                    continue;
                if (setFolderOnly == "characters+stats" && charactersWithoutStatsCheckBox.Checked)
                    continue;
                if (setFolderOnly == "characters-stats" && charactersWithStatsCheckBox.Checked)
                    continue;
            }
            else if (setFolderOnly != "test")
                continue;

            // ---------------------------- CSV ---------------------------

            foreach (var filePath in Directory.GetFiles(setFolder))
            {
                if (Path.GetExtension(filePath).ToLowerInvariant() == ".csv")
                {
                    if (Path.GetFileNameWithoutExtension(filePath).Contains("capitalships"))
                    {
                        var newCapitalShipsAsString = File.ReadAllText(filePath);
                        var newCapitalShipsLines = newCapitalShipsAsString.Split(Environment.NewLine);
                        int i = -1;
                        foreach (var newCapitalShipsLine in newCapitalShipsLines)
                        {
                            if (newCapitalShipsLine.Length <= 0) continue;
                            if (i == -1)
                            { // skip header line
                                i = 0;
                                continue;
                            }
                            var capitalShipColumns = newCapitalShipsLine.Split(';');
                            var row = new CAPSHPSD_CapitalShip();
                            row.Name = capitalShipColumns[0];
                            row.Id = Convert.ToUInt32(capitalShipColumns[1]);
                            row.EncyclopediaDescription = capitalShipColumns[2];

                            var gdEntry = CapitalShipsGameFile.CapitalShips.FirstOrDefault(p => p.Id == row.Id);
                            if (gdEntry != null)
                            {
                                gdEntry.Name = row.Name;
                                ResourcesDlls.Textstra.SaveString(Convert.ToUInt16(gdEntry.TextStraDllId), gdEntry.Name);
                                gdEntry.EncyclopediaDescription = row.EncyclopediaDescription;
                                ResourcesDlls.Encytext.SaveRcdata((gdEntry.TextStraDllId - 4096).ToString(), gdEntry.EncyclopediaDescription);
                            }

                            ++i;
                        }
                    }
                    CapitalShipsGameFile.Save(CapitalShipsGameFilePath);

                    if (Path.GetFileNameWithoutExtension(filePath).Contains("sectors"))
                    {
                        var newSectorsAsString = File.ReadAllText(filePath);
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
                            else if (sectorColumns[4] == "Rim (inner)")
                                SectorsGameFile.Sectors[i].Group = 2;
                            else if (sectorColumns[4] == "Rim (outer)")
                                SectorsGameFile.Sectors[i].Group = 3;
                            else
                                SectorsGameFile.Sectors[i].Group = uint.Parse(sectorColumns[4]);
                            if (sectorColumns[5] == "Standard")
                                SectorsGameFile.Sectors[i].GalaxySize = 1;
                            else if (sectorColumns[5] == "Large")
                                SectorsGameFile.Sectors[i].GalaxySize = 2;
                            else if (sectorColumns[5] == "Huge")
                                SectorsGameFile.Sectors[i].GalaxySize = 3;
                            else
                                SectorsGameFile.Sectors[i].GalaxySize = uint.Parse(sectorColumns[5]);
                            ++i;
                        }
                    }
                    SectorsGameFile.Save(SectorsGameFilePath);
                    foreach (var sector in SectorsGameFile.Sectors)
                        ResourcesDlls.Textstra.SaveString(Convert.ToUInt16(sector.TextStraDllId), sector.Name);

                    if (Path.GetFileNameWithoutExtension(filePath).Contains("systems"))
                    {
                        var descDic = new Dictionary<string, string>();
                        foreach (var system in GameFile.Systems)
                            descDic.Add(system.Name.ToLowerInvariant(), system.EncyclopediaDescription);
                        var newSystemsAsString = File.ReadAllText(filePath);
                        var newSystemsLines = newSystemsAsString.Split(Environment.NewLine);
                        int i = -1;
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
                            try
                            {
                                GameFile.Systems[i].SectorId = SectorsGameFile.Sectors.First(s => s.Name == systemColumns[3]).Id;
                            }
                            catch
                            {
                                GameFile.Systems[i].SectorId = uint.Parse(systemColumns[3]);
                            }
                            GameFile.Systems[i].XPosition = Convert.ToUInt16(TrimDecimal(systemColumns[4]));
                            GameFile.Systems[i].YPosition = Convert.ToUInt16(TrimDecimal(systemColumns[5]));
                            GameFile.Systems[i].FamilyId = (uint)(systemColumns[6] == "Explored" ? 144 : (systemColumns[6] == "Unexplored" ? 146 : uint.Parse(systemColumns[6])));
                            GameFile.Systems[i].PictureId = Convert.ToUInt32(TrimDecimal(systemColumns[7]));
                            //if (!ResourcesDlls.Strategy.RT_BITMAP.ContainsKey((14000 + Convert.ToInt32(systemColumns[7])).ToString()))
                            //    GameFile.Systems[i].PictureId = 0;
                            if (systemColumns[8]?.Length > 0)
                                GameFile.Systems[i].EncyclopediaDescription = systemColumns[8].TrimStart('"').TrimEnd('"');
                            else if (descDic.ContainsKey(GameFile.Systems[i].Name.ToLowerInvariant()))
                                GameFile.Systems[i].EncyclopediaDescription = descDic[GameFile.Systems[i].Name.ToLowerInvariant()];
                            else
                                GameFile.Systems[i].EncyclopediaDescription = "";
                            ++i;
                        }
                    }
                    GameFile.Save(GameFilePath);
                    foreach (var system in GameFile.Systems)
                    {
                        ResourcesDlls.Textstra.SaveString(Convert.ToUInt16(system.TextStraDllId), system.Name);
                        ResourcesDlls.Encytext.SaveRcdata((system.TextStraDllId - 4096).ToString(), system.EncyclopediaDescription);
                    }
                }
            }

            // ---------------------------- RSRC ---------------------------

            foreach (var patchFolder in Directory.GetDirectories(setFolder))
            {
                var patchFolderOnly = Path.GetFileName(patchFolder);
                if (patchFolderOnly == "EDATA")
                { // encyclopedia
                    foreach (var filePath in Directory.GetFiles(patchFolder))
                    {
                        if (Path.GetExtension(filePath).ToLowerInvariant() == ".txt")
                            continue;
                        var ebId = Path.GetFileNameWithoutExtension(filePath);
                        if (ebId.Contains("-"))
                            ebId = ebId.Split('-')[0];
                        else if (ebId.StartsWith("EDATA."))
                            ebId = ebId.Split('.')[1];
                        ResourcesDlls.Encybmap.SaveString(Convert.ToUInt16(ebId), "EDATA." + ebId);
                        File.Copy(filePath, Path.Combine(Settings.Current.EDataFolder, "EDATA." + ebId), true);
                    }
                }
                else if (patchFolderOnly == "MDATA")
                { // media (smk videos, wav sounds)
                    foreach (var filePath in Directory.GetFiles(patchFolder))
                    {
                        if (Path.GetExtension(filePath).ToLowerInvariant() == ".txt")
                            continue;
                        var mwId = Path.GetFileNameWithoutExtension(filePath);
                        if (mwId.Contains("-"))
                            mwId = mwId.Split('-')[0];
                        else if (mwId.StartsWith("MDATA."))
                            mwId = mwId.Split('.')[1];
                        File.Copy(filePath, Path.Combine(Settings.Current.EDataFolder, "MDATA." + mwId), true);
                    }
                }
                else if (patchFolderOnly.EndsWith(".DLL"))
                { // dll resources
                    foreach (var resourceFolder in Directory.GetDirectories(patchFolder))
                    {
                        var resourceFolderOnly = Path.GetFileName(resourceFolder);
                        if (resourceFolderOnly == "301")
                        {
                            foreach (var filePath in Directory.GetFiles(resourceFolder))
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
                                if (patchFolderOnly == "TACTICAL.DLL")
                                    ResourcesDlls.Tactical.Save301(id301, bytes);
                            }
                        }
                        else if (resourceFolderOnly == "303")
                        {
                            foreach (var filePath in Directory.GetFiles(resourceFolder))
                            {
                                if (Path.GetExtension(filePath).ToLowerInvariant() == ".txt")
                                    continue;
                                var extension = Path.GetExtension(filePath).ToLowerInvariant();
                                var id303 = Path.GetFileNameWithoutExtension(filePath).Split('-')[0];
                                int res = -1;
                                if (!Int32.TryParse(id303, out res) && !id303.Contains("."))
                                    id303 = Path.GetFileName(filePath);
                                byte[] bytes;
                                BinImage bi = new BinImage();
                                if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp")
                                {
                                    var b = new Bitmap(filePath);
                                    if (res > 10000)
                                        bi = new BinImage(b, defaultTacticalPalette, true, 256, 256); // resizing tactical system sprites to 256x256
                                    else
                                        bi = new BinImage(b, defaultTacticalPalette, true);
                                    bytes = bi.Bytes;
                                }
                                else if (extension == ".bin")
                                    bytes = File.ReadAllBytes(filePath);
                                else
                                    throw new ApplicationException("Accepted extensions: jpg, jpeg, bmp, png, bin. File provided: " + filePath);
                                if (patchFolderOnly == "TACTICAL.DLL")
                                {
                                    ResourcesDlls.Tactical.Save303(id303, bytes);
                                    if (res > 10000)
                                    {
                                        var id303PalId = (Convert.ToInt32(id303) + 1000).ToString();
                                        ResourcesDlls.Tactical.Save303(id303PalId, bi.ColorTable.Bytes);
                                    }
                                }
                            }
                        }
                        else if (resourceFolderOnly.ToLowerInvariant() == "bitmap")
                        {
                            var files = Directory.GetFiles(resourceFolder);
                            var coruscantFile = files.FirstOrDefault(f => f.ToLowerInvariant().Contains("coruscant"));
                            var idsFound = new HashSet<int>();
                            foreach (var filePath in files)
                            {
                                if (Path.GetExtension(filePath).ToLowerInvariant() == ".txt")
                                    continue;
                                var id = Path.GetFileNameWithoutExtension(filePath).Split('-')[0];
                                if (patchFolderOnly == "ALSPRITE.DLL")
                                    ResourcesDlls.Alsprite.SaveBitmap(id, filePath);
                                else if (patchFolderOnly == "COMMON.DLL")
                                    ResourcesDlls.Common.SaveBitmap(id, filePath);
                                if (patchFolderOnly == "EMSPRITE.DLL")
                                    ResourcesDlls.Emsprite.SaveBitmap(id, filePath);
                                else if (patchFolderOnly == "GOKRES.DLL")
                                    ResourcesDlls.Gokres.SaveBitmap(id, filePath);
                                else if (patchFolderOnly == "REBDLOG.DLL")
                                    ResourcesDlls.Rebdlog.SaveBitmap(id, filePath);
                                else if (patchFolderOnly == "STRATEGY.DLL")
                                {
                                    if (coruscantId < 0 && coruscantFile != null)
                                        coruscantId = Convert.ToUInt16(Path.GetFileName(coruscantFile).Split("-")[0]);
                                    int idAsInt;
                                    if (Int32.TryParse(id, out idAsInt) && idAsInt > 10000)
                                        idsFound.Add(idAsInt);
                                    ResourcesDlls.Strategy.SaveBitmap(id, filePath);
                                }
                                else if (patchFolderOnly == "TACTICAL.DLL")
                                    ResourcesDlls.Tactical.SaveBitmap(id, filePath);
                            }
                            if (idsFound.Any())
                            { // if only a few planets are provided, use the wireframe for the rest
                                var f = files.FirstOrDefault(f => f.Contains("wireframe"));
                                if (f != null)
                                {
                                    for (int p = 14001; p <= 14200; ++p)
                                    {
                                        var key = p.ToString();
                                        if (!ResourcesDlls.Tactical.RT_BITMAP.ContainsKey(key))
                                            ResourcesDlls.Tactical.SaveBitmap(key, f);
                                    }
                                }
                            }
                        }
                        else if (resourceFolderOnly.ToLowerInvariant() == "wave")
                        {
                            var files = Directory.GetFiles(resourceFolder);
                            foreach (var filePath in files)
                            {
                                var extension = Path.GetExtension(filePath).ToLowerInvariant();
                                if (extension == ".txt")
                                    continue;
                                var idWave = Path.GetFileNameWithoutExtension(filePath).Split('-')[0];
                                byte[] bytes;
                                if (extension == ".wav")
                                    bytes = File.ReadAllBytes(filePath);
                                else
                                    throw new ApplicationException("Accepted sound extension: wav. File provided: " + filePath);
                                if (patchFolderOnly == "ALSPRITE.DLL")
                                    ResourcesDlls.Alsprite.SaveWave(idWave, bytes);
                                else if (patchFolderOnly == "COMMON.DLL")
                                    ResourcesDlls.Common.SaveWave(idWave, bytes);
                                else if (patchFolderOnly == "EMSPRITE.DLL")
                                    ResourcesDlls.Emsprite.SaveWave(idWave, bytes);
                                else if (patchFolderOnly == "STRATEGY.DLL")
                                    ResourcesDlls.Strategy.SaveWave(idWave, bytes);
                                else if (patchFolderOnly == "TACTICAL.DLL")
                                    ResourcesDlls.Tactical.SaveWave(idWave, bytes);
                                else if (patchFolderOnly == "VOICEFXA.DLL")
                                    ResourcesDlls.Voicefxa.SaveWave(idWave, bytes);
                                else if (patchFolderOnly == "VOICEFXE.DLL")
                                    ResourcesDlls.Voicefxe.SaveWave(idWave, bytes);
                            }
                        }
                    }
                }
            }
        }

        if (testOnly)
        {
            Close();
            return;
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
            if (coruscantId > 0)
            {
                // to use coruscant sprite for empire objective to keep coruscant
                stream.Position = int.Parse("4A46F", NumberStyles.HexNumber);
                stream.WriteByte((byte)(coruscantId & 0x00FF)); // 14036 36D4 => D4 then 36
                stream.WriteByte((byte)((coruscantId & 0xFF00) >> 8));
                // to use coruscant sprite for rebel alliance objective to take coruscant
                stream.Position = int.Parse("49BCF", NumberStyles.HexNumber);
                stream.WriteByte((byte)(coruscantId & 0x00FF)); // 14036 36D4 => D4 then 36
                stream.WriteByte((byte)((coruscantId & 0xFF00) >> 8));
            }
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

        Close();
    }

    #endregion
}