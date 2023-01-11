﻿namespace SwRebellionEditor;

public partial class SectorsForm : SectorsDesignForm
{
    #region .ctor

    public SectorsForm()
    {
        GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\SECTORSD.DAT";
        GameFile = DatFile.Load<SECTORSD>(GameFilePath);
        InitializeComponent();
        InitializeBaseComponent(selector);
        selector.Maximum = (int)GameFile.SectorsCount - 1;
    }

    #endregion

    #region Business Layer

    protected override void DisplaySelectedGameObject(int selectorIndex)
    {
        var previousUnsavedData = GameFile.UnsavedData;
        var sector = GameFile.Sectors[selectorIndex];
        encyclopediaDescription.Text = sector.EncyclopediaDescription;
        familyId.Value = sector.FamilyId;
        familyIdHexLabel.Text = "0x" + sector.FamilyId.ToString("X");
        field2_1.Value = sector.Field2_1;
        field7_2.Value = sector.Field7_2;
        galaxySize.Value = sector.GalaxySize;
        id.Value = sector.Id;
        idHexLabel.Text = "0x" + sector.Id.ToString("X");
        name.Text = sector.Name;
        nextProductionFamily_0.Value = sector.NextProductionFamily_0;
        productionFamily_0.Value = sector.ProductionFamily_0;
        secImport.Value = sector.SecImport;
        textStraDllId.Value = sector.TextStraDllId;
        xPosition.Value = sector.XPosition;
        yPosition.Value = sector.YPosition;
        GameFile.UnsavedData = previousUnsavedData;
    }
    protected override void LoadSideInfo()
    {
        foreach (var s in GameFile.Sectors)
            s.Name = TextStra.GetString(s.TextStraDllId);
    }
    protected override void SaveSideInfo()
    {
        TextStra.SaveString(Convert.ToUInt16(textStraDllId.Value), name.Text);
        //EncyText.SaveString(Convert.ToUInt16(xxx.Value), name.Text);
    }

    #endregion

    #region Changed events

    private void encyclopediaDescription_TextChanged(object sender, EventArgs e)
    {
        GameFile.Sectors[selector.Value].EncyclopediaDescription = encyclopediaDescription.Text;
        GameFile.UnsavedData = true;
    }
    private void familyId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Sectors[selector.Value].FamilyId = (uint)familyId.Value;
        GameFile.UnsavedData = true;
    }
    private void field2_1_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Sectors[selector.Value].Field2_1 = (uint)field2_1.Value;
        GameFile.UnsavedData = true;
    }
    private void field7_2_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Sectors[selector.Value].Field7_2 = (ushort)field7_2.Value;
        GameFile.UnsavedData = true;
    }
    private void galaxySize_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Sectors[selector.Value].GalaxySize = (uint)galaxySize.Value;
        GameFile.UnsavedData = true;
    }
    private void id_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Sectors[selector.Value].Id = (uint)id.Value;
        GameFile.UnsavedData = true;
    }
    private void name_TextChanged(object sender, EventArgs e)
    {
        GameFile.Sectors[selector.Value].Name = name.Text;
        GameFile.UnsavedData = true;
    }
    private void nextProductionFamily_0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Sectors[selector.Value].NextProductionFamily_0 = (uint)nextProductionFamily_0.Value;
        GameFile.UnsavedData = true;
    }
    private void productionFamily_0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Sectors[selector.Value].ProductionFamily_0 = (uint)productionFamily_0.Value;
        GameFile.UnsavedData = true;
    }
    private void secImport_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Sectors[selector.Value].SecImport = (uint)secImport.Value;
        GameFile.UnsavedData = true;
    }
    private void textStraDllId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Sectors[selector.Value].TextStraDllId = (ushort)textStraDllId.Value;
        GameFile.UnsavedData = true;
    }
    private void xPosition_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Sectors[selector.Value].XPosition = (ushort)xPosition.Value;
        GameFile.UnsavedData = true;
    }
    private void yPosition_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Sectors[selector.Value].YPosition = (ushort)yPosition.Value;
        GameFile.UnsavedData = true;
    }

    #endregion
}
