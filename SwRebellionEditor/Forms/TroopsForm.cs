namespace SwRebellionEditor;

public partial class TroopsForm : TroopsDesignForm
{
    #region .ctor

    public TroopsForm()
    {
        GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\TROOPSD.DAT";
        GameFile = DatFile.Load<TROOPSD>(GameFilePath);
        InitializeComponent();
        InitializeBaseComponent(selector);
        selector.Maximum = (int)GameFile.TroopsCount - 1;
    }

    #endregion

    #region Business Layer

    protected override void DisplayGameItemsImages()
    {
        troopsListView.Sorting = SortOrder.None;
        troopsImages.Images.Clear();
        for (int selectorIndex = 0; selectorIndex < GameFile.TroopsCount; ++selectorIndex)
        {
            var edataId = 15 + selectorIndex;
            troopsImages.Images.Add(Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000")));
            troopsListView.Items.Add(GameFile.Troops[selectorIndex].Name, selectorIndex);
        }
    }
    protected override void DisplaySelectedGameObject(int selectorIndex)
    {
        var previousUnsavedData = GameFile.UnsavedData;
        var troop = GameFile.Troops[selectorIndex];
        attackStrength.Value = troop.AttackStrength;
        bombardmentDefense.Value = troop.BombardmentDefense;
        defenseStrength.Value = troop.DefenseStrength;
        detection.Value = troop.Detection;
        encyclopediaDescription.Text = troop.EncyclopediaDescription;
        familyId.Value = troop.FamilyId;
        familyIdHexLabel.Text = "0x" + troop.FamilyId.ToString("X");
        field2_1.Value = troop.Field2_1;
        field7_2.Value = troop.Field7_2;
        id.Value = troop.Id;
        idHexLabel.Text = "0x" + troop.Id.ToString("X");
        isAlliance.Checked = troop.IsAlliance > 0U;
        isEmpire.Checked = troop.IsEmpire > 0U;
        maintenanceCost.Value = troop.MaintenanceCost;
        name.Text = troop.Name;
        nextProductionFamily.Value = troop.NextProductionFamily;
        productionFamily.Value = troop.ProductionFamily;
        refinedMaterialCost.Value = troop.RefinedMaterialCost;
        researchDifficulty.Value = troop.ResearchDifficulty;
        researchOrder.Value = troop.ResearchOrder;
        textStraDllId.Value = troop.TextStraDllId;
        uprisingDefense.Value = troop.UprisingDefense;

        picture.SizeMode = PictureBoxSizeMode.Zoom;
        var edataId = 15 + selectorIndex;
        picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
        GameFile.UnsavedData = previousUnsavedData;
    }
    protected override void LoadSideInfo()
    {
        foreach (var mc in GameFile.Troops)
            mc.Name = TextStra.GetString(mc.TextStraDllId);
    }
    protected override void SaveSideInfo()
    {
        TextStra.SaveString(Convert.ToUInt16(textStraDllId.Value), name.Text);
        //EncyText.SaveString(Convert.ToUInt16(xxx.Value), name.Text);
    }

    #endregion

    #region Control events

    private void troopsListView_DoubleClick(object sender, EventArgs e)
    {
        selector.Value = troopsListView.Items.IndexOf(troopsListView.FocusedItem);
        DisplaySelectedGameObject(selector.Value);
        selector.Select();
    }
    private void troopsListView_Click(object sender, EventArgs e)
    {
        selector.Value = troopsListView.Items.IndexOf(troopsListView.FocusedItem);
        DisplaySelectedGameObject(selector.Value);
        selector.Select();
    }
    private void picture_Click(object sender, EventArgs e)
    {
        if (troopsListView.Items.Count > selector.Value + 1 && selector.Value - 1 >= 0)
        {
            troopsListView.Items[selector.Value + 1].EnsureVisible();
            troopsListView.Items[selector.Value - 1].EnsureVisible();
        }
        else
            troopsListView.Items[selector.Value].EnsureVisible();
        selector.Select();
    }

    #endregion

    #region Changed events

    private void attackStrength_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].AttackStrength = (uint)attackStrength.Value;
        GameFile.UnsavedData = true;
    }
    private void bombardmentDefense_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].BombardmentDefense = (uint)bombardmentDefense.Value;
        GameFile.UnsavedData = true;
    }
    private void defenseStrength_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].DefenseStrength = (uint)defenseStrength.Value;
        GameFile.UnsavedData = true;
    }
    private void detection_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].Detection = (uint)detection.Value;
        GameFile.UnsavedData = true;
    }
    private void encyclopediaDescription_TextChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].EncyclopediaDescription = encyclopediaDescription.Text;
        GameFile.UnsavedData = true;
    }
    private void familyId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].FamilyId = (uint)familyId.Value;
        GameFile.UnsavedData = true;
    }
    private void field2_1_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].Field2_1 = (uint)field2_1.Value;
        GameFile.UnsavedData = true;
    }
    private void field7_2_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].Field7_2 = (ushort)field7_2.Value;
        GameFile.UnsavedData = true;
    }
    private void id_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].Id = (uint)id.Value;
        GameFile.UnsavedData = true;
    }
    private void isAlliance_CheckStateChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].IsAlliance = isAlliance.Checked ? 1U : 0U;
        GameFile.UnsavedData = true;
    }
    private void isEmpire_CheckStateChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].IsEmpire = isEmpire.Checked ? 1U : 0U;
        GameFile.UnsavedData = true;
    }
    private void maintenanceCost_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].MaintenanceCost = (uint)maintenanceCost.Value;
        GameFile.UnsavedData = true;
    }
    private void name_TextChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].Name = name.Text;
        GameFile.UnsavedData = true;
    }
    private void nextProductionFamily_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].NextProductionFamily = (uint)nextProductionFamily.Value;
        GameFile.UnsavedData = true;
    }
    private void productionFamily_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].ProductionFamily = (uint)productionFamily.Value;
        GameFile.UnsavedData = true;
    }
    private void refinedMaterialCost_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].RefinedMaterialCost = (uint)refinedMaterialCost.Value;
        GameFile.UnsavedData = true;
    }
    private void researchDifficulty_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].ResearchDifficulty = (uint)researchDifficulty.Value;
        GameFile.UnsavedData = true;
    }
    private void researchOrder_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].ResearchOrder = (uint)researchOrder.Value;
        GameFile.UnsavedData = true;
    }
    private void textStraDllId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].TextStraDllId = (ushort)textStraDllId.Value;
        GameFile.UnsavedData = true;
    }
    private void uprisingDefense_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Troops[selector.Value].UprisingDefense = (uint)uprisingDefense.Value;
        GameFile.UnsavedData = true;
    }

    #endregion
}
