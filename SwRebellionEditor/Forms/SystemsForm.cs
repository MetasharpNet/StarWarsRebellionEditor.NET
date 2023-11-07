using System.Globalization;

namespace SwRebellionEditor;

public partial class SystemsForm : SystemsDesignForm
{
    #region .ctor

    private string SectorsGameFilePath;
    private SECTORSD SectorsGameFile;
    private bool HasPatchedRebexeForSprites;
    private bool HasPatchedRebexeForEncyclopedia;

    public SystemsForm()
    {
        SectorsGameFilePath = Path.Combine(Settings.Current.GDataFolder, "SECTORSD.DAT");
        SectorsGameFile = DatFile.Load<SECTORSD>(SectorsGameFilePath);
        GameFilePath = Path.Combine(Settings.Current.GDataFolder, "SYSTEMSD.DAT");
        GameFile = DatFile.Load<SYSTEMSD>(GameFilePath);
        InitializeComponent();
        InitializeBaseComponent(selector);
        selector.Maximum = (int)GameFile.SystemsCount - 1;
        // checking if patched rebexe.exe
        using (var stream = new FileStream(Settings.Current.REBEXEFilePath, FileMode.Open, FileAccess.ReadWrite))
        {
            // to use 14001+ ids for planet sprites
            stream.Position = int.Parse("5B1E5", NumberStyles.HexNumber);
            int bB0 = stream.ReadByte();
            int b36 = stream.ReadByte();
            Console.WriteLine(bB0 + " " + b36);
            if (bB0 == 176 && b36 == 54)
                HasPatchedRebexeForSprites = true;
            // to use 14001+ ids for encyclopedia edata planets pictures
            stream.Position = int.Parse("5DED9", NumberStyles.HexNumber);
            bB0 = stream.ReadByte();
            b36 = stream.ReadByte();
            Console.WriteLine(bB0 + " " + b36);
            if (bB0 == 176 && b36 == 54)
                HasPatchedRebexeForEncyclopedia = true;
        }
    }

    #endregion

    #region Business Layer

    private uint GetStrategyId(uint pictureId)
    {
        if (HasPatchedRebexeForEncyclopedia)
            return 14000 + pictureId;
        if (pictureId < 24)
            return 10211 + pictureId;
        if (pictureId > 24)
            return 10211 + pictureId + 1;
        return 10211 + pictureId + 4;
    }
    private uint GetEncybmapId(uint pictureId)
    {
        if (HasPatchedRebexeForEncyclopedia)
            return 14000 + pictureId;
        if (pictureId < 24)
            return 11099 + pictureId;
        if (pictureId > 24)
            return 11099 + pictureId - 1;
        return 11099 + pictureId + 2;
    }

    protected override void DisplayGameItemsImages()
    {
        systemsListView.Sorting = SortOrder.None;
        systemsImageList.Images.Clear();
        for (int selectorIndex = 0; selectorIndex < GameFile.SystemsCount; ++selectorIndex)
        {
            ushort encybmapId = (ushort)GetEncybmapId(GameFile.Systems[selectorIndex].PictureId);
            GetEncyclopediaImageAndAddToList(ResourcesDlls.Encybmap.RT_STRING[encybmapId], systemsImageList, Resources.missing_encyclopedia_picture_400x200_bmp);
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
        ushort encybmapId = (ushort)GetEncybmapId(GameFile.Systems[selectorIndex].PictureId);
        picture.Image = GetEncyclopediaImageAndAddToList(ResourcesDlls.Encybmap.RT_STRING[encybmapId], null, Resources.missing_encyclopedia_picture_400x200_bmp);

        sprite.SizeMode = PictureBoxSizeMode.Zoom;
        var strategyId = GetStrategyId(GameFile.Systems[selectorIndex].PictureId).ToString();
        try
        {
            sprite.Image = DIB.ToDDB(ResourcesDlls.Strategy.RT_BITMAP[strategyId].Bitmap);
        }
        catch { sprite.Image = null; }
        GameFile.UnsavedData = previousUnsavedData;
    }
    private void LoadSector(uint sectorId)
    {
        var sector = SectorsGameFile.Sectors[sectorId - 20U];
        sectorName.Text = ResourcesDlls.Textstra.RT_STRING[sector.TextStraDllId];
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
            s.Name = ResourcesDlls.Textstra.RT_STRING[s.TextStraDllId];
            s.EncyclopediaDescription = ResourcesDlls.Encytext.RT_RCDATA[(s.TextStraDllId - 4096).ToString()];
        }
    }
    protected override void SaveSideInfo()
    {
        ResourcesDlls.Textstra.SaveString(Convert.ToUInt16(textStraDllId.Value), name.Text);
        ResourcesDlls.Encytext.SaveRcdata((textStraDllId.Value - 4096).ToString(), encyclopediaDescription.Text);
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

    #region Drag&Drop events
    private void sprite_DragDrop(object sender, DragEventArgs e)
    {
        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        if (files.Length > 0)
        {
            string file = files[0];
            if (File.Exists(file) && Path.GetExtension(file).ToLowerInvariant() == ".bmp")
            {
                sprite.Image = Image.FromFile(file);
                ResourcesDlls.Strategy.SaveBitmap(GetStrategyId(Convert.ToUInt32(pictureId.Value)).ToString(), file);
            }
        }
    }
    private void sprite_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            e.Effect = DragDropEffects.Copy;
        }
        else
        {
            e.Effect = DragDropEffects.None;
        }
    }
    #endregion
}