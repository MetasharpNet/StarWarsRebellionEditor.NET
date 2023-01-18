using System.Runtime.InteropServices;
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
        sectorSecImport.Value = sector.Group;
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
        string export = "Name;Id;TextStraDllId;X;Y;FamilyId;SectorId;EncyclopediaDescription" + Environment.NewLine;
        foreach (var s in GameFile.Systems)
            export = export + s.Name + ";"
                            + s.Id + ";"
                            + s.TextStraDllId + ";"
                            + s.XPosition + ";"
                            + s.YPosition + ";"
                            + (s.FamilyId == 144 ? "Core" : "Rim") + ";"
                            + s.SectorId + ";\""
                            + s.EncyclopediaDescription + "\""
                            + Environment.NewLine;
        File.WriteAllText("systems.csv", export);
    }

    private void import_Click(object sender, EventArgs e)
    {
        this.Enabled = false;
        // MANDATORY EXPECTATIONS

        // systems
        // id = 265, sectorid = 36   (Coruscant)
        // id = 289, sectorid = 38   (Yavin)

        // sectors
        // id = 36, galaxysize = 1, importance = 1
        // id = 38, galaxysize = 1

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
        //SectorsGameFile.Sectors = SectorsGameFile.Sectors.OrderBy(s => s.Id).ToArray();
        // systems
        var descDic = new Dictionary<string, string>();
        var pictDic = new Dictionary<string, uint>();
        foreach (var system in GameFile.Systems)
        {
            descDic.Add(system.Name.ToLowerInvariant(), system.EncyclopediaDescription);
            pictDic.Add(system.Name.ToLowerInvariant(), system.PictureId);
        }
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
            if (descDic.ContainsKey(GameFile.Systems[i].Name.ToLowerInvariant()))
            {
                GameFile.Systems[i].EncyclopediaDescription = descDic[GameFile.Systems[i].Name.ToLowerInvariant()];
                GameFile.Systems[i].PictureId = pictDic[GameFile.Systems[i].Name.ToLowerInvariant()];
            }
            else
                GameFile.Systems[i].EncyclopediaDescription = "Missing description.";
            ++i;
        }
        //GameFile.Systems = GameFile.Systems.OrderBy(s => s.Id).ToArray();

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
}