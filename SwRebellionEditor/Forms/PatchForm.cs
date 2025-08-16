using SwRebellionEditor.Forms;
using SwRebellionEditor.ResourceHelpers;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace SwRebellionEditor;

public partial class PatchForm : PatchDesignForm
{
    #region .ctor

    private BackgroundWorker backgroundWorker;
    private LogForm logForm;

    public PatchForm()
    {
        InitializeComponent();
    }

    #endregion

    #region Events
    protected override void LoadSideInfo()
    {
    }
    private void cancel_Click(object sender, EventArgs e)
    {
        Close();
    }
    private void unitsWithoutStatsCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (unitsWithoutStatsCheckBox.Checked)
            unitsWithStatsCheckBox.Checked = false;
    }
    private void unitsWithStatsCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (unitsWithStatsCheckBox.Checked)
            unitsWithoutStatsCheckBox.Checked = false;
    }

    private void compatibleGalaxyMapCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (compatibleGalaxyMapCheckBox.Checked)
            accurateGalaxyMapCheckBox.Checked = false;
    }

    private void accurateGalaxyMapCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (accurateGalaxyMapCheckBox.Checked)
            compatibleGalaxyMapCheckBox.Checked = false;
    }
    private void patch_Click(object sender, EventArgs e)
    {
        backgroundWorker = new BackgroundWorker();
        backgroundWorker.DoWork += BackgroundWorker_PatchFull;
        backgroundWorker.RunWorkerCompleted += BackgroundWorker_PatchCompleted;
        var coordinates = this.PointToScreen(new Point(0, 0));
        logForm = new LogForm();
        logForm.Text = "25th Anniversary Patch";
        logForm.StartPosition = FormStartPosition.Manual;
        logForm.Location = new Point(coordinates.X, coordinates.Y);
        logForm.Show(this);
        backgroundWorker.RunWorkerAsync();
    }

    private void patchTest_Click(object sender, EventArgs e)
    {
        backgroundWorker = new BackgroundWorker();
        backgroundWorker.DoWork += BackgroundWorker_PatchTest;
        backgroundWorker.RunWorkerCompleted += BackgroundWorker_PatchCompleted;
        var coordinates = this.PointToScreen(new Point(0, 0));
        logForm = new LogForm();
        logForm.Text = "Test Folder Patch";
        logForm.StartPosition = FormStartPosition.Manual;
        logForm.Location = new Point(coordinates.X, coordinates.Y);
        logForm.Show(this);
        backgroundWorker.RunWorkerAsync();
    }

    private void BackgroundWorker_PatchCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
        logForm.OkButton.Enabled = true;
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

    private void BackgroundWorker_PatchTest(object sender, DoWorkEventArgs e)
    {
        Patch(true);
    }

    private void BackgroundWorker_PatchFull(object sender, DoWorkEventArgs e)
    {
        Patch(false);
    }

    private void Patch(bool testOnly)
    {
        if (!File.Exists(Settings.Current.REBEXEFilePath))
        {
            try { logForm.AppendMessage("[ERROR] Please set in the editor a proper game folder. Current: " + Path.GetDirectoryName(Settings.Current.REBEXEFilePath)); }
            catch { logForm.AppendMessage("[ERROR] Please set in the editor a proper game folder."); }
            return;
        }
        if (testOnly)
        {
            logForm.AppendMessage("[PATCH MODE] Test content folder only");
        }
        else
        {
            logForm.AppendMessage("[PATCH MODE] 25th Anniversary");
        }
        logForm.AppendMessage("[INFO] Will take some time to complete, please wait until completed.");
        // test texture
        //var bix = new BinImage(16);
        //bix.Save("test.bmp-256 colors palette 256x256.bin");

        //this.Enabled = false;
        // MANDATORY EXPECTATIONS
        // systems
        // id = 265, sectorid = 36   (Coruscant)
        // id = 289, sectorid = 38   (Yavin)
        // sectors
        // id = 36, galaxysize = 1, importance = 1
        // id = 38, galaxysize = 1

        // --------------------------- CLEANUP ---------------------------
        logForm.AppendMessage("[INFO] Old Files Cleanup");
        try { File.Delete(Path.Combine(Settings.Current.GameFolder, "_dgvoodoo_settings_suggestion_1_general.jpg")); } catch (Exception ex) { logForm.AppendMessage("[WARNING] " + ex.Message); }
        try { File.Delete(Path.Combine(Settings.Current.GameFolder, "_dgvoodoo_settings_suggestion_3_directx.jpg")); } catch (Exception ex) { logForm.AppendMessage("[WARNING] " + ex.Message); }
        logForm.AppendMessage("[INFO] Old Files Cleanup -> Done");

        // ------------------------- GAME UPDATE -------------------------
        if (!testOnly)
        {
            logForm.AppendMessage("[INFO] Game Update");
            if (File.Exists(Path.Combine(Settings.Current.GameFolder, "DDrawCompat-REBEXE.ini")))
            {
                File.Copy(Path.Combine("game-update", "d3drm.dll"), Path.Combine(Settings.Current.GameFolder, "d3drm.dll"), true);
                File.Copy(Path.Combine("game-update", "wined3d.dll"), Path.Combine(Settings.Current.GameFolder, "wined3d.dll"), true);
                File.Copy(Path.Combine("game-update", "winethc.dll"), Path.Combine(Settings.Current.GameFolder, "winethc.dll"), true);
                File.Copy(Path.Combine("game-update", "REBEXE-FULLSCREEN.cmd"), Path.Combine(Settings.Current.GameFolder, "REBEXE-FULLSCREEN.cmd"), true);
                var filePath = Path.Combine(Settings.Current.GameFolder, "REBEXE-FULLSCREEN.cmd");
                var content = File.ReadAllText(filePath).Replace("-w", "-fullscreen");
                File.WriteAllText(filePath, content);
            }
            else
            {
                foreach (var filePath in Directory.GetFiles("game-update"))
                {
                    //if (Path.GetExtension(filePath).ToLowerInvariant() == ".txt")
                    //    continue;
                    var filename = Path.GetFileName(filePath);
                    if (filename == "_patch_exe.txt")
                        continue; // skip that file
                    try
                    {
                        logForm.AppendMessage("Source: " + filePath + " -> Destination: " + Path.Combine(Settings.Current.GameFolder, filename));
                        File.Copy(filePath, Path.Combine(Settings.Current.GameFolder, filename), true);
                    }
                    catch (Exception ex)
                    {
                        logForm.AppendMessage("[ERROR] " + ex.Message);
                    }
                }
            }
            logForm.AppendMessage("[INFO] Game Update -> Done");
        }
        else if (Directory.Exists("test\\game-update"))
        {
            logForm.AppendMessage("[INFO] Game Update");
            if (File.Exists(Path.Combine(Settings.Current.GameFolder, "DDrawCompat-REBEXE.ini")))
            {
                File.Copy(Path.Combine("test\\game-update", "d3drm.dll"), Path.Combine(Settings.Current.GameFolder, "d3drm.dll"), true);
                File.Copy(Path.Combine("test\\game-update", "wined3d.dll"), Path.Combine(Settings.Current.GameFolder, "wined3d.dll"), true);
                File.Copy(Path.Combine("test\\game-update", "winethc.dll"), Path.Combine(Settings.Current.GameFolder, "winethc.dll"), true);
                File.Copy(Path.Combine("test\\game-update", "REBEXE-FULLSCREEN.cmd"), Path.Combine(Settings.Current.GameFolder, "REBEXE-FULLSCREEN.cmd"), true);
                var filePath = Path.Combine("test\\game-update", "REBEXE-FULLSCREEN.cmd");
                var content = File.ReadAllText(filePath).Replace("-w", "-fullscreen");
                File.WriteAllText(filePath, content);
            }
            else
            {
                foreach (var filePath in Directory.GetFiles("test\\game-update"))
                {
                    //if (Path.GetExtension(filePath).ToLowerInvariant() == ".txt")
                    //    continue;
                    var filename = Path.GetFileName(filePath);
                    try
                    {
                        logForm.AppendMessage("Source: " + filePath + " -> Destination: " + Path.Combine(Settings.Current.GameFolder, filename));
                        File.Copy(filePath, Path.Combine(Settings.Current.GameFolder, filename), true);
                    }
                    catch (Exception ex)
                    {
                        logForm.AppendMessage("[ERROR] " + ex.Message);
                    }
                }
            }
            logForm.AppendMessage("[INFO] Game Update -> Done");
        }

        // ---------------------------- FOLDERS ---------------------------

        logForm.AppendMessage("[INFO] Folders");
        var defaultTacticalPalette = new AdobeColorTable(ResourcesDlls.Tactical.RT_303["5557"]);
        int coruscantId = -1;
        foreach (var setFolder in Directory.GetDirectories("."))
        {
            if (!Directory.Exists(setFolder))
                continue; // skip if not a folder
            var setFolderOnly = Path.GetFileName(setFolder);
            if (!testOnly)
            {
                if (setFolderOnly == "game-update")
                    continue;
                if (setFolderOnly == "export")
                    continue;
                if (setFolderOnly == "test")
                    continue;
                if (setFolderOnly == "units+stats" && unitsWithoutStatsCheckBox.Checked)
                    continue;
                if (setFolderOnly == "units-stats" && unitsWithStatsCheckBox.Checked)
                    continue;
            }
            else if (setFolderOnly != "test")
                continue;
            logForm.AppendMessage("[INFO] Folder: " + setFolder);

            // ---------------------------- CSV ---------------------------
            var csvFiles = new List<string>();
            csvFiles.AddRange(Directory.GetFiles(setFolder, "*.csv"));
            foreach (var folder in Directory.GetDirectories(setFolder))
            {
                csvFiles.AddRange(Directory.GetFiles(folder, "*.csv"));
            }
            foreach (var filePath in csvFiles)
            {
                if (Path.GetExtension(filePath).ToLowerInvariant() == ".csv")
                {
                    logForm.AppendMessage("[INFO] Apply CSV: " + filePath);
                    try
                    {
                        if (compatibleGalaxyMapCheckBox.Checked && Path.GetFileName(filePath).ToLowerInvariant().Contains("sectors-compatible.csv"))
                        {
                            var sectorsGameFilePath = Path.Combine(Settings.Current.GDataFolder, "SECTORSD.DAT");
                            var sectorsGameFile = DatFile.Load<SECTORSD>(sectorsGameFilePath);
                            sectorsGameFile.CsvToEntries(File.ReadAllText(filePath), "Sectors", "SectorsCount");
                            sectorsGameFile.Save(sectorsGameFilePath);
                        }
                        else if (accurateGalaxyMapCheckBox.Checked && Path.GetFileName(filePath).ToLowerInvariant().Contains("sectors-accurate.csv"))
                        {
                            var sectorsGameFilePath = Path.Combine(Settings.Current.GDataFolder, "SECTORSD.DAT");
                            var sectorsGameFile = DatFile.Load<SECTORSD>(sectorsGameFilePath);
                            sectorsGameFile.CsvToEntries(File.ReadAllText(filePath), "Sectors", "SectorsCount");
                            sectorsGameFile.Save(sectorsGameFilePath);
                        }
                        else if (Path.GetFileName(filePath).ToLowerInvariant().Contains("sectors.csv"))
                        {
                            var sectorsGameFilePath = Path.Combine(Settings.Current.GDataFolder, "SECTORSD.DAT");
                            var sectorsGameFile = DatFile.Load<SECTORSD>(sectorsGameFilePath);
                            sectorsGameFile.CsvToEntries(File.ReadAllText(filePath), "Sectors", "SectorsCount");
                            sectorsGameFile.Save(sectorsGameFilePath);
                        }
                        if (compatibleGalaxyMapCheckBox.Checked && Path.GetFileName(filePath).ToLowerInvariant().Contains("systems-compatible.csv"))
                        {
                            GameFilePath = Path.Combine(Settings.Current.GDataFolder, "SYSTEMSD.DAT");
                            GameFile = DatFile.Load<SYSTEMSD>(GameFilePath);
                            GameFile.CsvToEntries(File.ReadAllText(filePath), "Systems", "SystemsCount");
                            GameFile.Save(GameFilePath);
                        }
                        else if (accurateGalaxyMapCheckBox.Checked && Path.GetFileName(filePath).ToLowerInvariant().Contains("systems-accurate.csv"))
                        {
                            GameFilePath = Path.Combine(Settings.Current.GDataFolder, "SYSTEMSD.DAT");
                            GameFile = DatFile.Load<SYSTEMSD>(GameFilePath);
                            GameFile.CsvToEntries(File.ReadAllText(filePath), "Systems", "SystemsCount");
                            GameFile.Save(GameFilePath);
                        }
                        else if (Path.GetFileName(filePath).ToLowerInvariant().Contains("systems.csv"))
                        {
                            GameFilePath = Path.Combine(Settings.Current.GDataFolder, "SYSTEMSD.DAT");
                            GameFile = DatFile.Load<SYSTEMSD>(GameFilePath);
                            GameFile.CsvToEntries(File.ReadAllText(filePath), "Systems", "SystemsCount");
                            GameFile.Save(GameFilePath);
                        }
                        if (Path.GetFileName(filePath).ToLowerInvariant().Contains("majorcharacters.csv"))
                        {
                            var majorCharactersGameFilePath = Path.Combine(Settings.Current.GDataFolder, "MJCHARSD.DAT");
                            var majorCharactersGameFile = DatFile.Load<MJCHARSD>(majorCharactersGameFilePath);
                            majorCharactersGameFile.CsvToEntries(File.ReadAllText(filePath), "MajorCharacters", "MajorCharactersCount");
                            majorCharactersGameFile.Save(majorCharactersGameFilePath);
                        }
                        if (Path.GetFileName(filePath).ToLowerInvariant().Contains("minorcharacters.csv"))
                        {
                            var minorCharactersGameFilePath = Path.Combine(Settings.Current.GDataFolder, "MNCHARSD.DAT");
                            var minorCharactersGameFile = DatFile.Load<MNCHARSD>(minorCharactersGameFilePath);
                            minorCharactersGameFile.CsvToEntries(File.ReadAllText(filePath), "MinorCharacters", "MinorCharactersCount");
                            minorCharactersGameFile.Save(minorCharactersGameFilePath);
                        }
                        if (Path.GetFileName(filePath).ToLowerInvariant().Contains("troops.csv"))
                        {
                            var troopsGameFilePath = Path.Combine(Settings.Current.GDataFolder, "TROOPSD.DAT");
                            var troopsGameFile = DatFile.Load<TROOPSD>(troopsGameFilePath);
                            troopsGameFile.CsvToEntries(File.ReadAllText(filePath), "Troops", "TroopsCount");
                            troopsGameFile.Save(troopsGameFilePath);
                        }
                        if (Path.GetFileName(filePath).ToLowerInvariant().Contains("specialforces.csv"))
                        {
                            var specialForcesGameFilePath = Path.Combine(Settings.Current.GDataFolder, "SPECFCSD.DAT");
                            var specialForcesGameFile = DatFile.Load<SPECFCSD>(specialForcesGameFilePath);
                            specialForcesGameFile.CsvToEntries(File.ReadAllText(filePath), "SpecialForces", "SpecialForcesCount");
                            specialForcesGameFile.Save(specialForcesGameFilePath);
                        }
                        if (Path.GetFileName(filePath).ToLowerInvariant().Contains("specialforces.csv"))
                        {
                            var specialForcesGameFilePath = Path.Combine(Settings.Current.GDataFolder, "SPECFCSD.DAT");
                            var specialForcesGameFile = DatFile.Load<SPECFCSD>(specialForcesGameFilePath);
                            specialForcesGameFile.CsvToEntries(File.ReadAllText(filePath), "SpecialForces", "SpecialForcesCount");
                            specialForcesGameFile.Save(specialForcesGameFilePath);
                        }
                        if (Path.GetFileName(filePath).ToLowerInvariant().Contains("capitalships.csv"))
                        {
                            var capitalShipsGameFilePath = Path.Combine(Settings.Current.GDataFolder, "CAPSHPSD.DAT");
                            var capitalShipsGameFile = DatFile.Load<CAPSHPSD>(capitalShipsGameFilePath);
                            capitalShipsGameFile.CsvToEntries(File.ReadAllText(filePath), "CapitalShips", "CapitalShipsCount");
                            capitalShipsGameFile.Save(capitalShipsGameFilePath);
                        }
                        if (Path.GetFileName(filePath).ToLowerInvariant().Contains("fighters.csv"))
                        {
                            var fightersGameFilePath = Path.Combine(Settings.Current.GDataFolder, "FIGHTSD.DAT");
                            var fightersGameFile = DatFile.Load<FIGHTSD>(fightersGameFilePath);
                            fightersGameFile.CsvToEntries(File.ReadAllText(filePath), "Fighters", "FightersCount");
                            fightersGameFile.Save(fightersGameFilePath);
                        }
                        if (Path.GetFileName(filePath).ToLowerInvariant().Contains("defenseFacilities.csv"))
                        {
                            var defenseFacilitiesGameFilePath = Path.Combine(Settings.Current.GDataFolder, "DEFFACSD.DAT");
                            var defenseFacilitiesGameFile = DatFile.Load<DEFFACSD>(defenseFacilitiesGameFilePath);
                            defenseFacilitiesGameFile.CsvToEntries(File.ReadAllText(filePath), "DefenseFacilities", "DefenseFacilitiesCount");
                            defenseFacilitiesGameFile.Save(defenseFacilitiesGameFilePath);
                        }
                        if (Path.GetFileName(filePath).ToLowerInvariant().Contains("manufacturingFacilities.csv"))
                        {
                            var manufacturingFacilitiesGameFilePath = Path.Combine(Settings.Current.GDataFolder, "MANFACSD.DAT");
                            var manufacturingFacilitiesGameFile = DatFile.Load<MANFACSD>(manufacturingFacilitiesGameFilePath);
                            manufacturingFacilitiesGameFile.CsvToEntries(File.ReadAllText(filePath), "ManufacturingFacilities", "ManufacturingFacilitiesCount");
                            manufacturingFacilitiesGameFile.Save(manufacturingFacilitiesGameFilePath);
                        }
                        if (Path.GetFileName(filePath).ToLowerInvariant().Contains("productionFacilities.csv"))
                        {
                            var productionFacilitiesGameFilePath = Path.Combine(Settings.Current.GDataFolder, "PROFACSD.DAT");
                            var productionFacilitiesGameFile = DatFile.Load<PROFACSD>(productionFacilitiesGameFilePath);
                            productionFacilitiesGameFile.CsvToEntries(File.ReadAllText(filePath), "ProductionFacilities", "ProductionFacilitiesCount");
                            productionFacilitiesGameFile.Save(productionFacilitiesGameFilePath);
                        }
                        logForm.AppendMessage("[INFO] CSV: " + filePath + " -> Done");
                    }
                    catch (Exception ex)
                    {
                        logForm.AppendMessage("[ERROR] " + ex.Message);
                    }
                }
            }

            // ---------------------------- RSRC ---------------------------

            foreach (var patchFolder in Directory.GetDirectories(setFolder))
            {
                var patchFolderOnly = Path.GetFileName(patchFolder);
                if (patchFolderOnly == "game-update")
                    continue; // skip for test mode
                logForm.AppendMessage("[INFO] Sub-Folder: " + patchFolderOnly);
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
                        logForm.AppendMessage("Source: " + filePath + " -> Destination: " + Path.Combine(Settings.Current.EDataFolder, "EDATA." + ebId));
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
                        logForm.AppendMessage("Source: " + filePath + " -> Destination: " + Path.Combine(Settings.Current.EDataFolder, "MDATA." + mwId));
                        File.Copy(filePath, Path.Combine(Settings.Current.MDATAFolder, "MDATA." + mwId), true);
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
                                {
                                    logForm.AppendMessage("Source: " + filePath + " DestinationResource: 301/" + id301);
                                    ResourcesDlls.Tactical.Save301(id301, bytes);
                                }
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
                                    logForm.AppendMessage("Source: " + filePath + " DestinationResource: 303/" + id303);
                                    ResourcesDlls.Tactical.Save303(id303, bytes);
                                    if (res > 10000)
                                    {
                                        var id303PalId = (Convert.ToInt32(id303) + 1000).ToString();
                                        logForm.AppendMessage("Source: DefaultTacticalPalette DestinationResource: 303/" + id303PalId);
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
                                {
                                    logForm.AppendMessage("Source: " + filePath + " DestinationResource: bitmap/" + id);
                                    ResourcesDlls.Alsprite.SaveBitmap(id, filePath);
                                }
                                else if (patchFolderOnly == "COMMON.DLL")
                                {
                                    if (!((filePath.ToLowerInvariant().Contains("20001-1033-common-main-screen-compatible.bmp") && !compatibleGalaxyMapCheckBox.Checked) ||
                                         (filePath.ToLowerInvariant().Contains("20001-1033-common-main-screen-accurate.bmp") && !accurateGalaxyMapCheckBox.Checked)))
                                    {
                                        logForm.AppendMessage("Source: " + filePath + " DestinationResource: bitmap/" + id);
                                        ResourcesDlls.Common.SaveBitmap(id, filePath);
                                    }
                                }
                                else if (patchFolderOnly == "EMSPRITE.DLL")
                                {
                                    logForm.AppendMessage("Source: " + filePath + " DestinationResource: bitmap/" + id);
                                    ResourcesDlls.Emsprite.SaveBitmap(id, filePath);
                                }
                                else if (patchFolderOnly == "GOKRES.DLL")
                                {
                                    logForm.AppendMessage("Source: " + filePath + " DestinationResource: bitmap/" + id);
                                    ResourcesDlls.Gokres.SaveBitmap(id, filePath);
                                }
                                else if (patchFolderOnly == "REBDLOG.DLL")
                                {
                                    logForm.AppendMessage("Source: " + filePath + " DestinationResource: bitmap/" + id);
                                    ResourcesDlls.Rebdlog.SaveBitmap(id, filePath);
                                }
                                else if (patchFolderOnly == "STRATEGY.DLL")
                                {
                                    if (coruscantId < 0 && coruscantFile != null)
                                        coruscantId = Convert.ToUInt16(Path.GetFileName(coruscantFile).Split("-")[0]);
                                    int idAsInt;
                                    if (Int32.TryParse(id, out idAsInt) && idAsInt > 10000)
                                        idsFound.Add(idAsInt);
                                    logForm.AppendMessage("Source: " + filePath + " DestinationResource: bitmap/" + id);
                                    ResourcesDlls.Strategy.SaveBitmap(id, filePath);
                                }
                                else if (patchFolderOnly == "TACTICAL.DLL")
                                {
                                    logForm.AppendMessage("Source: " + filePath + " DestinationResource: bitmap/" + id);
                                    ResourcesDlls.Tactical.SaveBitmap(id, filePath);
                                }
                            }
                            if (idsFound.Any())
                            { // if only a few planets are provided, use the wireframe for the rest
                                var f = files.FirstOrDefault(f => f.Contains("wireframe"));
                                if (f != null)
                                {
                                    for (int p = 14001; p <= 14200; ++p)
                                    {
                                        var key = p.ToString();
                                        if (!ResourcesDlls.Strategy.RT_BITMAP.ContainsKey(key))
                                        {
                                            logForm.AppendMessage("Source: " + f + " DestinationResource: bitmap/" + key);
                                            ResourcesDlls.Strategy.SaveBitmap(key, f);
                                        }
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
                                {
                                    logForm.AppendMessage("Source: " + filePath + " DestinationResource: wave/" + idWave);
                                    ResourcesDlls.Alsprite.SaveWave(idWave, bytes);
                                }
                                else if (patchFolderOnly == "COMMON.DLL")
                                {
                                    logForm.AppendMessage("Source: " + filePath + " DestinationResource: wave/" + idWave);
                                    ResourcesDlls.Common.SaveWave(idWave, bytes);
                                }
                                else if (patchFolderOnly == "EMSPRITE.DLL")
                                {
                                    logForm.AppendMessage("Source: " + filePath + " DestinationResource: wave/" + idWave);
                                    ResourcesDlls.Emsprite.SaveWave(idWave, bytes);
                                }
                                else if (patchFolderOnly == "STRATEGY.DLL")
                                {
                                    logForm.AppendMessage("Source: " + filePath + " DestinationResource: wave/" + idWave);
                                    ResourcesDlls.Strategy.SaveWave(idWave, bytes);
                                }
                                else if (patchFolderOnly == "TACTICAL.DLL")
                                {
                                    logForm.AppendMessage("Source: " + filePath + " DestinationResource: wave/" + idWave);
                                    ResourcesDlls.Tactical.SaveWave(idWave, bytes);
                                }
                                else if (patchFolderOnly == "VOICEFXA.DLL")
                                {
                                    logForm.AppendMessage("Source: " + filePath + " DestinationResource: wave/" + idWave);
                                    ResourcesDlls.Voicefxa.SaveWave(idWave, bytes);
                                }
                                else if (patchFolderOnly == "VOICEFXE.DLL")
                                {
                                    logForm.AppendMessage("Source: " + filePath + " DestinationResource: wave/" + idWave);
                                    ResourcesDlls.Voicefxe.SaveWave(idWave, bytes);
                                }
                            }
                        }
                    }
                }
            }
        }
        logForm.AppendMessage("[INFO] Folders -> Done");

        // ---------------------------- REBEXE.EXE ----------------------------

        if (!testOnly || File.Exists("test\\game-update\\_patch_exe.txt"))
        {
            // patching rebexe.exe
            logForm.AppendMessage("[INFO] Patching rebexe.exe");
            try
            {
                using (var stream = new FileStream(Settings.Current.REBEXEFilePath, FileMode.Open, FileAccess.ReadWrite))
                {
                    // to use 14001+ ids for galaxy map planet sprites
                    // before @ 5B1E4=373220 (1.02) : ... 8B442404 [4883F8190F87] 89000000 ...
                    // before @ 5BD74=376180 (1.0v4): ... 8B442404 [4883F8190F87] 89000000 ...
                    //stream.Position = int.Parse("5B1E4", NumberStyles.HexNumber);
                    var pos = FindPosition(stream, "4883F8190F8789000000", "8B442404");
                    if (pos > -1)
                    {
                        stream.Position = pos;
                        stream.WriteByte(0x05); // add eax, 14000
                        stream.WriteByte(0xB0);
                        stream.WriteByte(0x36);
                        stream.WriteByte(0x00);
                        stream.WriteByte(0x00);
                        stream.WriteByte(0xC3); // retn
                    }
                    else
                    {
                        logForm.AppendMessage("[ERROR] Unable to find position for 14001+ ids for galaxy map planet sprites.");
                    }
                    if (coruscantId > 0) // 1068 usually
                    {
                        // to use coruscant sprite for empire objective to keep coruscant
                        // before @ 4A46F=304239 (1.02) : ... 136A0A68 [FA27] 0000578B ...
                        // before @ 4B00F=307215 (1.0v4): ... 136A0A68 [FA27] 0000578B ...
                        //stream.Position = int.Parse("4A46F", NumberStyles.HexNumber);
                        pos = FindPosition(stream, "FA270000578B", "136A0A68");
                        if (pos > -1)
                        {
                            stream.Position = pos;
                            stream.WriteByte((byte)(coruscantId & 0x00FF)); // 14036 36D4 => D4 then 36
                            stream.WriteByte((byte)((coruscantId & 0xFF00) >> 8));
                        }
                        else
                        {
                            logForm.AppendMessage("[ERROR] Unable to find position for coruscant sprite for empire objective to keep coruscant.");
                        }

                        // to use coruscant sprite for rebel alliance objective to take coruscant
                        // before @ 49BCF=302031 (1.02) : ... 116A0A68 [FA27] 0000578B ...
                        // before @ 4A76F=305007 (1.0v4): ... 116A0A68 [FA27] 0000578B ...
                        //stream.Position = int.Parse("49BCF", NumberStyles.HexNumber);
                        pos = FindPosition(stream, "FA270000578B", "116A0A68");
                        if (pos > -1)
                        {
                            stream.Position = pos;
                            stream.WriteByte((byte)(coruscantId & 0x00FF)); // 14036 36D4 => D4 then 36
                            stream.WriteByte((byte)((coruscantId & 0xFF00) >> 8));
                        }
                        else
                        {
                            logForm.AppendMessage("[ERROR] Unable to find position for coruscant sprite for rebel alliance objective to take coruscant.");
                        }
                    }

                    // to use 14001+ ids for encyclopedia edata planets pictures
                    // before @ 5DED6=384726 (1.02) : ... 240433C0 [4983F9190F87D40000] 00FF248D ...
                    // before @ 5EA66=387686 (1.0v4): ... 240433C0 [4983F9190F87D40000] 00FF248D ...
                    //stream.Position = int.Parse("5DED6", NumberStyles.HexNumber);
                    pos = FindPosition(stream, "4983F9190F87D4000000FF248D", "240433C0");
                    if (pos > -1)
                    {
                        stream.Position = pos;
                        stream.WriteByte(0x89); // move eax, ecx
                        stream.WriteByte(0xC8);
                        stream.WriteByte(0x05); // add eax, 14000
                        stream.WriteByte(0xB0);
                        stream.WriteByte(0x36);
                        stream.WriteByte(0x00);
                        stream.WriteByte(0x00);
                        stream.WriteByte(0xC2); // retn 4
                        stream.WriteByte(0x04);
                    }
                    else
                    {
                        logForm.AppendMessage("[ERROR] Unable to find position for 14001+ ids for encyclopedia edata planets pictures.");
                    }

                    // to use 14001+ ids for tactical planets bin images
                    // before @ 1AA022=1744930 (1.02) : ... 006681C2 [7C15] 518B4C24 ...
                    // before @ 1AB9B2=1751474 (1.0v4): ... 006681C2 [7C15] 518B4C24 ...
                    //stream.Position = int.Parse("1AA022", NumberStyles.HexNumber);
                    pos = FindPosition(stream, "7C15518B4C24", "86CC0800006681C2");
                    if (pos > -1)
                    {
                        stream.Position = pos;
                        stream.WriteByte(0xB0); // 14000
                        stream.WriteByte(0x36);
                    }
                    else
                    {
                        logForm.AppendMessage("[ERROR] Unable to find position for 14001+ ids for tactical planets bin images.");
                    }

                    // to use 15001+ ids for tactical planets bin palettes
                    // before @ 19456E=1656174 (1.02) : ... 00006605 [7C15] C3909090 ...
                    // before @ 195EDE=1662686 (1.0v4): ... 00006605 [7C15] C3909090 ...
                    //stream.Position = int.Parse("19456E", NumberStyles.HexNumber);
                    pos = FindPosition(stream, "7C15C3909090", "00006605");
                    if (pos > -1)
                    {
                        stream.Position = pos;
                        stream.WriteByte(0x98); // 15000
                        stream.WriteByte(0x3A);
                    }
                    else
                    {
                        logForm.AppendMessage("[ERROR] Unable to find position for 15001+ ids for tactical planets bin palettes (part 1).");
                    }

                    // before @ 1C0929=1837353 (1.02) : ... FDFF83C0 [1E] 682F0100 ...
                    // before @ 1C2279=1843833 (1.0v4): ... FDFF83C0 [1E] 682F0100 ...
                    //stream.Position = int.Parse("1C0929", NumberStyles.HexNumber);
                    pos = FindPosition(stream, "1E682F0100", "FDFF83C0");
                    if (pos > -1)
                    {
                        stream.Position = pos;
                        stream.WriteByte(0x00); // +0
                    }
                    else
                    {
                        logForm.AppendMessage("[ERROR] Unable to find position for 15001+ ids for tactical planets bin palettes (part 2).");
                    }

                    // to use 14000 ids for tactical destroyed planet
                    // before @ 197A25=1668669 (1.02) : ... 241C026A [1B] EB1D83EC ...
                    // before @ 199395=1676181 (1.0v4): ... 241C026A [1B] EB1D83EC ...
                    //stream.Position = int.Parse("197A25", NumberStyles.HexNumber);
                    pos = FindPosition(stream, "1BEB1D83EC", "241C026A");
                    if (pos > -1)
                    {
                        stream.Position = pos;
                        stream.WriteByte(0x00); // +0
                    }
                    else
                    {
                        logForm.AppendMessage("[ERROR] Unable to find position for 14000 ids for tactical destroyed planet.");
                    }
                }
                logForm.AppendMessage("[INFO] Patching rebexe.exe -> Done");
            }
            catch (Exception ex)
            {
                logForm.AppendMessage("[ERROR] " + ex.Message);
            }
        }

        if (testOnly)
        {
            logForm.AppendMessage("[PATCH MODE] Test content folder only -> Done");
            logForm.AppendMessage("You can now close the window and play the game.");
            return;
        }


        logForm.AppendMessage("[PATCH MODE] 25th Anniversary -> Done");
        logForm.AppendMessage("You can now close the window and play the game.");
    }

    // method to find an hexadecimal space free pattern position given as a string + a string preceeding it in a stream
    private static long FindPosition(Stream stream, string hexadecimalPattern, string preceedingHexadecimalPattern = "")
    {
        var pattern = (preceedingHexadecimalPattern + hexadecimalPattern).Replace(" ", "").ToUpperInvariant();
        var patternBytes = HexadecimalToBytes(pattern);
        // stream .Position = 0; // reset stream position
        if (stream.Length < patternBytes.Length)
            return -1; // not enough data in stream
        // stream to byte[]
        if (stream.Position != 0)
            stream.Position = 0; // reset stream position
        var streamBytes = new byte[stream.Length];
        stream.Read(streamBytes, 0, (int)stream.Length);
        // find pattern in stream
        for (var start = 0; start <= streamBytes.Length - patternBytes.Length; start++)
        {
            bool found = true;
            for (var p = 0; p < patternBytes.Length; p++)
            {
                if (streamBytes[start + p] != patternBytes[p])
                {
                    found = false;
                    break;
                }
            }
            if (found)
            {
                return start + (preceedingHexadecimalPattern.Length / 2); // found at position s
            }
        }
        return -1; // not found
    }
    private static byte[] HexadecimalToBytes(string hexadecimal)
    {
        if (hexadecimal.Length % 2 != 0)
            throw new ArgumentException("Hexadecimal string must have an even length.", nameof(hexadecimal));
        var bytes = new byte[hexadecimal.Length / 2];
        for (int i = 0; i < hexadecimal.Length; i += 2)
        {
            bytes[i / 2] = Convert.ToByte(hexadecimal.Substring(i, 2), 16);
        }
        return bytes;
    }

    #endregion

}