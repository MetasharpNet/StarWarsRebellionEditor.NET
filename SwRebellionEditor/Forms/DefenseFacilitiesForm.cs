namespace SwRebellionEditor;

public partial class DefenseFacilitiesForm : DefenseFacilitiesDesignForm
{
    #region .ctor

    public DefenseFacilitiesForm()
    {
        GameFilePath = Path.Combine(Settings.Current.GDataFolder, "DEFFACSD.DAT");
        GameFile = DatFile.Load<DEFFACSD>(GameFilePath);
        InitializeComponent();
        InitializeBaseComponent(selector);
        selector.Maximum = (int)GameFile.DefenseFacilitiesCount - 1;
    }

    #endregion

    #region Business Layer

    protected override void DisplaySelectedGameObject(int selectorIndex)
    {
        var previousUnsavedData = GameFile.UnsavedData;
        var defenseFacility = GameFile.DefenseFacilities[selectorIndex];
        attackStrength.Value = defenseFacility.AttackStrength;
        bombardmentDefense.Value = defenseFacility.BombardmentDefense;
        encyclopediaDescription.Text = defenseFacility.EncyclopediaDescription;
        familyId.Value = defenseFacility.FamilyId;
        familyIdHexLabel.Text = "0x" + defenseFacility.FamilyId.ToString("X");
        field2_1.Value = defenseFacility.Field2_1;
        field7_2.Value = defenseFacility.Field7_2;
        id.Value = defenseFacility.Id;
        idHexLabel.Text = "0x" + defenseFacility.Id.ToString("X");
        isAlliance.Checked = defenseFacility.IsAlliance > 0U;
        isEmpire.Checked = defenseFacility.IsEmpire > 0U;
        maintenanceCost.Value = defenseFacility.MaintenanceCost;
        name.Text = defenseFacility.Name;
        nextProductionFamily.Value = defenseFacility.NextProductionFamily;
        productionFamily.Value = defenseFacility.ProductionFamily;
        refinedMaterialCost.Value = defenseFacility.RefinedMaterialCost;
        researchDifficulty.Value = defenseFacility.ResearchDifficulty;
        researchOrder.Value = defenseFacility.ResearchOrder;
        shieldStrength.Value = defenseFacility.ShieldStrength;
        textStraDllId.Value = defenseFacility.TextStraDllId;

        picture.SizeMode = PictureBoxSizeMode.Zoom;
        var edataId = 9 + selectorIndex;
        if (edataId == 12)
            edataId = 14;
        else if (edataId > 12)
            --edataId;
        var filepath = Path.Combine(Settings.Current.EDataFolder, "EDATA." + edataId.ToString("000"));
        if (File.Exists(filepath))
            picture.Image = Image.FromFile(filepath);
        else
            picture.Image = null;
        GameFile.UnsavedData = previousUnsavedData;
    }
    protected override void LoadSideInfo()
    {
        foreach (var df in GameFile.DefenseFacilities)
        {
            df.Name = TextStra.Resources.GetString(df.TextStraDllId);
            df.EncyclopediaDescription = EncyText.Resources.GetRcdata((df.TextStraDllId - 4096).ToString());
        }
    }
    protected override void SaveSideInfo()
    {
        TextStra.Resources.SaveString(Convert.ToUInt16(textStraDllId.Value), name.Text);
        EncyText.Resources.UpdateRcdata((textStraDllId.Value - 4096).ToString(), encyclopediaDescription.Text);
    }

    #endregion

    #region Changed events

    private void attackStrength_ValueChanged(object sender, EventArgs e)
    {
        GameFile.DefenseFacilities[selector.Value].AttackStrength = (uint)attackStrength.Value;
        GameFile.UnsavedData = true;
    }
    private void bombardmentDefense_ValueChanged(object sender, EventArgs e)
    {
        GameFile.DefenseFacilities[selector.Value].BombardmentDefense = (uint)bombardmentDefense.Value;
        GameFile.UnsavedData = true;
    }
    private void encyclopediaDescription_TextChanged(object sender, EventArgs e)
    {
        GameFile.DefenseFacilities[selector.Value].EncyclopediaDescription = encyclopediaDescription.Text;
        GameFile.UnsavedData = true;
    }
    private void familyId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.DefenseFacilities[selector.Value].FamilyId = (uint)familyId.Value;
        GameFile.UnsavedData = true;
    }
    private void field2_1_ValueChanged(object sender, EventArgs e)
    {
        GameFile.DefenseFacilities[selector.Value].Field2_1 = (uint)field2_1.Value;
        GameFile.UnsavedData = true;
    }
    private void field7_2_ValueChanged(object sender, EventArgs e)
    {
        GameFile.DefenseFacilities[selector.Value].Field7_2 = (ushort)field7_2.Value;
        GameFile.UnsavedData = true;
    }
    private void id_ValueChanged(object sender, EventArgs e)
    {
        GameFile.DefenseFacilities[selector.Value].Id = (uint)id.Value;
        GameFile.UnsavedData = true;
    }
    private void isAlliance_CheckStateChanged(object sender, EventArgs e)
    {
        GameFile.DefenseFacilities[selector.Value].IsAlliance = !isAlliance.Checked ? 0U : 1U;
        GameFile.UnsavedData = true;
    }
    private void isEmpire_CheckStateChanged(object sender, EventArgs e)
    {
        GameFile.DefenseFacilities[selector.Value].IsEmpire = !isEmpire.Checked ? 0U : 1U;
        GameFile.UnsavedData = true;
    }
    private void maintenanceCost_ValueChanged(object sender, EventArgs e)
    {
        GameFile.DefenseFacilities[selector.Value].MaintenanceCost = (uint)maintenanceCost.Value;
        GameFile.UnsavedData = true;
    }
    private void name_TextChanged(object sender, EventArgs e)
    {
        GameFile.DefenseFacilities[selector.Value].Name = name.Text;
        GameFile.UnsavedData = true;
    }
    private void nextProductionFamily_ValueChanged(object sender, EventArgs e)
    {
        GameFile.DefenseFacilities[selector.Value].NextProductionFamily = (uint)nextProductionFamily.Value;
        GameFile.UnsavedData = true;
    }
    private void productionFamily_ValueChanged(object sender, EventArgs e)
    {
        GameFile.DefenseFacilities[selector.Value].ProductionFamily = (uint)productionFamily.Value;
        GameFile.UnsavedData = true;
    }
    private void refinedMaterialCost_ValueChanged(object sender, EventArgs e)
    {
        GameFile.DefenseFacilities[selector.Value].RefinedMaterialCost = (uint)refinedMaterialCost.Value;
        GameFile.UnsavedData = true;
    }
    private void researchDifficulty_ValueChanged(object sender, EventArgs e)
    {
        GameFile.DefenseFacilities[selector.Value].ResearchDifficulty = (uint)researchDifficulty.Value;
        GameFile.UnsavedData = true;
    }
    private void researchOrder_ValueChanged(object sender, EventArgs e)
    {
        GameFile.DefenseFacilities[selector.Value].ResearchOrder = (uint)researchOrder.Value;
        GameFile.UnsavedData = true;
    }
    private void shieldStrength_ValueChanged(object sender, EventArgs e)
    {
        GameFile.DefenseFacilities[selector.Value].ShieldStrength = (uint)shieldStrength.Value;
        GameFile.UnsavedData = true;
    }
    private void textStraDllId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.DefenseFacilities[selector.Value].TextStraDllId = (ushort)textStraDllId.Value;
        GameFile.UnsavedData = true;
    }

    #endregion
}
