using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SwRebellionEditor;

public partial class SystemsForm : SystemsDesignForm
{
    #region .ctor

    private string SectorsGameFilePath;
    private SECTORSD SectorsGameFile;

    public SystemsForm()
    {
        SectorsGameFilePath = RegistryKeys.InstalledLocation + "\\GData\\SECTORSD.DAT";
        SectorsGameFile = DatFile.Load<SECTORSD>(SectorsGameFilePath);
        GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\SYSTEMSD.DAT";
        GameFile = DatFile.Load<SYSTEMSD>(GameFilePath);
        InitializeComponent();
        InitializeBaseComponent(selector);
        selector.Maximum = (int)GameFile.SystemsCount - 1;
    }

    #endregion

    #region Business Layer

    protected override void DisplayGameItemsImages()
    {
        systemsListView.Sorting = SortOrder.None;
        systemsImageList.Images.Clear();
        for (int selectorIndex = 0; selectorIndex < GameFile.SystemsCount; ++selectorIndex)
        {
            var edataId = 165 + GameFile.Systems[selectorIndex].PictureId;
            var filepath = RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000");
            if (File.Exists(filepath))
                systemsImageList.Images.Add(Image.FromFile(filepath));
            systemsListView.Items.Add(GameFile.Systems[selectorIndex].Name, selectorIndex);
        }
    }

    protected override void DisplaySelectedGameObject(int selectorIndex)
    {
        var previousUnsavedData = GameFile.UnsavedData;
        var system = GameFile.Systems[selectorIndex];
        encyclopediaDescription.Text = system.EncyclopediaDescription;
        familyId.Value = system.FamilyId;
        familyIdHexLabel.Text = "0x" + system.FamilyId.ToString("X");
        field2_1.Value = system.Field2_1;
        field7_2.Value = system.Field7_2;
        field10_1.Value = system.Field10_1;
        field13_0.Value = system.Field13_0;
        id.Value = system.Id;
        idHexLabel.Text = "0x" + system.Id.ToString("X");
        name.Text = system.Name;
        nextProductionFamily_0.Value = system.NextProductionFamily_0;
        pictureId.Value = system.PictureId;
        productionFamily_0.Value = system.ProductionFamily_0;
        sectorId.Value = system.SectorId;
        textStraDllId.Value = system.TextStraDllId;
        xPosition.Value = system.XPosition;
        yPosition.Value = system.YPosition;
        LoadSector(system.SectorId);

        picture.SizeMode = PictureBoxSizeMode.Zoom;
        var edataId = 165 + system.PictureId;
        var filepath = RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000");
        if (File.Exists(filepath))
            picture.Image = Image.FromFile(filepath);
        else
            picture.Image = null;
        GameFile.UnsavedData = previousUnsavedData;
    }
    private void LoadSector(uint sectorId)
    {
        var sector = SectorsGameFile.Sectors[sectorId - 20U];
        sectorName.Text = TextStra.GetString(sector.TextStraDllId);
        sectorFamilyId.Value = sector.FamilyId;
        sectorFamilyIdHexLabel.Text = "0x" + sector.FamilyId.ToString("X");
        sectorGalaxySize.Value = sector.GalaxySize;
        sectorSecImport.Value = sector.Importance;
        sectorTextStraDllId.Value = sector.TextStraDllId;
        sectorXPosition.Value = sector.XPosition;
        sectorYPosition.Value = sector.YPosition;
    }
    protected override void LoadSideInfo()
    {
        foreach (var s in GameFile.Systems)
        {
            s.Name = TextStra.GetString(s.TextStraDllId);
            s.EncyclopediaDescription = EncyText.GetRcdata((s.TextStraDllId - 4096).ToString());
        }
    }
    protected override void SaveSideInfo()
    {
        TextStra.SaveString(Convert.ToUInt16(textStraDllId.Value), name.Text);
        EncyText.SaveRcdata((textStraDllId.Value - 4096).ToString(), encyclopediaDescription.Text);
    }

    #endregion

    #region Control events

    private void picture_Click(object sender, EventArgs e)
    {
        if (systemsListView.Items.Count > selector.Value + 1 && selector.Value - 1 >= 0)
        {
            systemsListView.Items[selector.Value + 1].EnsureVisible();
            systemsListView.Items[selector.Value - 1].EnsureVisible();
        }
        else
            systemsListView.Items[selector.Value].EnsureVisible();
        selector.Select();
    }
    private void systemsListView_DoubleClick(object sender, EventArgs e)
    {
        selector.Value = systemsListView.Items.IndexOf(systemsListView.FocusedItem);
        DisplaySelectedGameObject(selector.Value);
        selector.Select();
    }
    private void systemsListView_Click(object sender, EventArgs e)
    {
        selector.Value = systemsListView.Items.IndexOf(systemsListView.FocusedItem);
        DisplaySelectedGameObject(selector.Value);
        selector.Select();
    }

    #endregion

    #region Changed events

    private void encyclopediaDescription_TextChanged(object sender, EventArgs e)
    {
        GameFile.Systems[selector.Value].EncyclopediaDescription = encyclopediaDescription.Text;
        GameFile.UnsavedData = true;
    }
    private void familyId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Systems[selector.Value].FamilyId = (uint)familyId.Value;
        GameFile.UnsavedData = true;
    }
    private void field2_1_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Systems[selector.Value].Field2_1 = (uint)field2_1.Value;
        GameFile.UnsavedData = true;
    }
    private void field7_2_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Systems[selector.Value].Field7_2 = (ushort)field7_2.Value;
        GameFile.UnsavedData = true;
    }
    private void field10_1_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Systems[selector.Value].Field10_1 = (uint)field10_1.Value;
        GameFile.UnsavedData = true;
    }
    private void field13_0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Systems[selector.Value].Field13_0 = (uint)field13_0.Value;
        GameFile.UnsavedData = true;
    }
    private void id_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Systems[selector.Value].Id = (uint)id.Value;
        GameFile.UnsavedData = true;
    }
    private void name_TextChanged(object sender, EventArgs e)
    {
        GameFile.Systems[selector.Value].Name = name.Text;
        GameFile.UnsavedData = true;
    }
    private void nextProductionFamily_0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Systems[selector.Value].NextProductionFamily_0 = (uint)nextProductionFamily_0.Value;
        GameFile.UnsavedData = true;
    }
    private void pictureId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Systems[selector.Value].PictureId = (uint)pictureId.Value;
        GameFile.UnsavedData = true;
    }
    private void productionFamily_0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Systems[selector.Value].ProductionFamily_0 = (uint)productionFamily_0.Value;
        GameFile.UnsavedData = true;
    }
    private void sectorId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Systems[selector.Value].SectorId = (uint)sectorId.Value;
        LoadSector(GameFile.Systems[selector.Value].SectorId);
        GameFile.UnsavedData = true;
    }
    private void textStraDllId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Systems[selector.Value].TextStraDllId = (ushort)textStraDllId.Value;
        GameFile.UnsavedData = true;
    }
    private void xPosition_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Systems[selector.Value].XPosition = (ushort)xPosition.Value;
        GameFile.UnsavedData = true;
    }
    private void yPosition_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Systems[selector.Value].YPosition = (ushort)yPosition.Value;
        GameFile.UnsavedData = true;
    }

    #endregion

    private void export_Click(object sender, EventArgs e)
    {
        string export = "";
        foreach (var s in GameFile.Systems)
            export = export + s.Name + ";" + (s.FamilyId == 144 ? "Core" : "Rim") + ";\"" + s.EncyclopediaDescription + "\"" + Environment.NewLine;
        File.WriteAllText("systems.csv", export);
    }

    private void import_Click(object sender, EventArgs e)
    {
        // sectors
        var sectors = SectorsGameFile.Sectors;
        var newSectorsAsString = File.ReadAllText("new-sectors.csv");
        var newSectorsLines = newSectorsAsString.Split(Environment.NewLine);
        int i = -1;
        foreach (var newSectorsLine in newSectorsLines)
        {
            if (newSectorsLine.Length <= 0) continue;
            if (i == -1)
            {
                i = 0;
                continue;
            }
            var sectorColumns = newSectorsLine.Split(';');
            sectors[i].Name = sectorColumns[0];
            sectors[i].XPosition = Convert.ToUInt16(sectorColumns[1]);
            sectors[i].YPosition = Convert.ToUInt16(sectorColumns[2]);
            if (sectorColumns[3] == "High")
                sectors[i].Importance = 1;
            if (sectorColumns[3] == "Medium")
                sectors[i].Importance = 2;
            if (sectorColumns[3] == "Low")
                sectors[i].Importance = 3;
            if (sectorColumns[4] == "Standard")
                sectors[i].GalaxySize = 1;
            if (sectorColumns[4] == "Large")
                sectors[i].GalaxySize = 2;
            if (sectorColumns[4] == "Huge")
                sectors[i].GalaxySize = 3;
            ++i;
        }
        // systems
        var prevSystems = new List<SYSTEMSD_System>(GameFile.Systems);
        var newSystemsAsString = File.ReadAllText("new-systems.csv");
        var newSystemsLines = newSystemsAsString.Split(Environment.NewLine);
        i = -1;
        var coruscantIndex = prevSystems.FindIndex(s => s.Name.ToLowerInvariant().Contains("coruscant"));
        var yavinIndex = prevSystems.FindIndex(s => s.Name.ToLowerInvariant().Contains("yavin"));
        bool coruscantOrYavin = false;
        foreach (var newSystemsLine in newSystemsLines)
        {
            int j = -1;
            if (newSystemsLine.Length <= 0) continue;
            if (i == -1)
            {
                i = 0;
                continue;
            }
            var systemColumns = newSystemsLine.Split(';');
            if ((i == coruscantIndex && systemColumns[0].ToLowerInvariant() != "coruscant") ||
                (i == yavinIndex && systemColumns[0].ToLowerInvariant() != "yavin 4 (moon)"))
                ++i;
            if (systemColumns[0].ToLowerInvariant() == "coruscant")
            {
                coruscantOrYavin = true;
                j = i - 1;
                i = coruscantIndex;
            }
            if (systemColumns[0].ToLowerInvariant() == "yavin 4 (moon)")
            {
                coruscantOrYavin = true;
                j = i - 1;
                i = yavinIndex;
            }
            var syst = new SYSTEMSD_System();
            syst.Id = prevSystems[i].Id;
            syst.Field2_1 = prevSystems[i].Field2_1;
            syst.ProductionFamily_0 = prevSystems[i].ProductionFamily_0;
            syst.NextProductionFamily_0 = prevSystems[i].NextProductionFamily_0;
            syst.TextStraDllId = prevSystems[i].TextStraDllId;
            syst.Field7_2 = prevSystems[i].Field7_2;
            syst.PictureId = prevSystems[i].PictureId;
            syst.Field10_1 = prevSystems[i].Field10_1;
            syst.Field13_0 = prevSystems[i].Field13_0;
            syst.Name = systemColumns[0];
            syst.SectorId = sectors.First(s => s.Name == systemColumns[1]).Id;
            syst.XPosition = Convert.ToUInt16(systemColumns[2]);
            syst.YPosition = Convert.ToUInt16(systemColumns[3]);
            syst.FamilyId = (uint)(systemColumns[4] == "Rim" ? 146 : 144);
            var existingSystem = prevSystems.FirstOrDefault(s => s.Name == syst.Name);
            if (existingSystem != null)
            {
                syst.EncyclopediaDescription = EncyText.GetRcdata((existingSystem.TextStraDllId - 4096).ToString());
                syst.PictureId = existingSystem.PictureId;
            }
            else
                syst.EncyclopediaDescription = "Missing description.";
            GameFile.Systems[i] = syst;
            if (coruscantOrYavin)
            {
                i = j;
                coruscantOrYavin = false;
            }
            else
                ++i;
        }
        // Coruscant sector should be 36
        var coruscant = GameFile.Systems.First(s => s.Name.ToLowerInvariant().Contains("coruscant"));
        var oldCoruscantSectorId = coruscant.SectorId;
        if (oldCoruscantSectorId != 36)
        {
            var oldCoruscantSectorSystems = GameFile.Systems.Where(s => s.SectorId == oldCoruscantSectorId).ToList();
            var old36CoruscantSectorSystems = GameFile.Systems.Where(s => s.SectorId == 36).ToList();

            foreach (var system in oldCoruscantSectorSystems)
                system.SectorId = 36;
            foreach (var system in old36CoruscantSectorSystems)
                system.SectorId = oldCoruscantSectorId;

            var oldsector = SectorsGameFile.Sectors.First(s => s.Id == oldCoruscantSectorId);
            var old36sector = SectorsGameFile.Sectors.First(s => s.Id == 36);
            oldsector.Id = 36;
            old36sector.Id = oldCoruscantSectorId;
            SectorsGameFile.Sectors = SectorsGameFile.Sectors.OrderBy(s => s.Id).ToArray();
        }

        // save
        SectorsGameFile.Save(SectorsGameFilePath);
        foreach (var sector in SectorsGameFile.Sectors)
            TextStra.SaveString(Convert.ToUInt16(sector.TextStraDllId), sector.Name);
        GameFile.Save(GameFilePath);
        foreach (var system in GameFile.Systems)
        {
            TextStra.SaveString(Convert.ToUInt16(system.TextStraDllId), system.Name);
            EncyText.SaveRcdata((system.TextStraDllId - 4096).ToString(), system.EncyclopediaDescription);
        }
        SaveSideInfo();
        MessageBox.Show("Import Done");
    }
}