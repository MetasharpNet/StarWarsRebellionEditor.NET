namespace SwRebellionEditor;

public partial class SpecialForcesForm : SpecialForcesDesignForm
{
    #region .ctor

    public SpecialForcesForm()
    {
        GameFilePath = Path.Combine(Settings.Current.GDataFolder, "SPECFCSD.DAT");
        GameFile = DatFile.Load<SPECFCSD>(GameFilePath);
        InitializeComponent();
        InitializeBaseComponent(selector);
        selector.Maximum = (int)GameFile.SpecialForcesCount - 1;
    }

    #endregion

    #region Business Layer

    protected override void DisplayGameItemsImages()
    {
        specialForcesListView.Sorting = SortOrder.None;
        specialForcesImages.Images.Clear();
        for (int selectorIndex = 0; selectorIndex < GameFile.SpecialForcesCount; ++selectorIndex)
        {
            var edataId = 25 + selectorIndex;
            var filepath = Path.Combine(Settings.Current.EDataFolder, "EDATA." + edataId.ToString("000"));
            if (File.Exists(filepath))
                specialForcesImages.Images.Add(Image.FromFile(filepath));
            specialForcesListView.Items.Add(GameFile.SpecialForces[selectorIndex].Name, selectorIndex);
        }
    }
    protected override void DisplaySelectedGameObject(int selectorIndex)
    {
        var previousUnsavedData = GameFile.UnsavedData;
        var specialForce = GameFile.SpecialForces[selectorIndex];
        combatBase.Value = specialForce.CombatBase;
        combatVariance.Value = specialForce.CombatVariance;
        diplomacyBase.Value = specialForce.DiplomacyBase;
        diplomacyVariance.Value = specialForce.DiplomacyVariance;
        encyclopediaDescription.Text = specialForce.EncyclopediaDescription;
        espionageBase.Value = specialForce.EspionageBase;
        espionageVariance.Value = specialForce.EspionageVariance;
        facilityDesignBase_0.Value = specialForce.FacilityDesignBase_0;
        facilityDesignVariance_0.Value = specialForce.FacilityDesignVariance_0;
        familyId.Value = specialForce.FamilyId;
        familyIdHexLabel.Text = "0x" + specialForce.FamilyId.ToString("X");
        field2_1.Value = specialForce.Field2_1;
        field7_2.Value = specialForce.Field7_2;
        id.Value = specialForce.Id;
        idHexLabel.Text = "0x" + specialForce.Id.ToString("X");
        isAlliance.Checked = specialForce.IsAlliance > 0U;
        isEmpire.Checked = specialForce.IsEmpire > 0U;
        leadershipBase.Value = specialForce.LeadershipBase;
        leadershipVariance.Value = specialForce.LeadershipVariance;
        loyaltyBase.Value = specialForce.LoyaltyBase;
        loyaltyVariance.Value = specialForce.LoyaltyVariance;
        maintenanceCost.Value = specialForce.MaintenanceCost;
        missionId.Value = specialForce.MissionId;
        name.Text = specialForce.Name;
        nextProductionFamily.Value = specialForce.NextProductionFamily;
        productionFamily.Value = specialForce.ProductionFamily;
        refinedMaterialCost.Value = specialForce.RefinedMaterialCost;
        researchDifficulty.Value = specialForce.ResearchDifficulty_0;
        researchOrder_0.Value = specialForce.ResearchOrder_0;
        shipDesignBase_0.Value = specialForce.ShipDesignBase_0;
        shipDesignVariance_0.Value = specialForce.ShipDesignVariance_0;
        textStraDllId.Value = specialForce.TextStraDllId;
        troopTrainingBase_0.Value = specialForce.TroopTrainingBase_0;
        troopTrainingVariance_0.Value = specialForce.TroopTrainingVariance_0;

        picture.SizeMode = PictureBoxSizeMode.Zoom;
        var edataId = 25 + selectorIndex;
        var filepath = Path.Combine(Settings.Current.EDataFolder, "EDATA." + edataId.ToString("000"));
        if (File.Exists(filepath))
            picture.Image = Image.FromFile(filepath);
        else
            picture.Image = null;
        GameFile.UnsavedData = previousUnsavedData;
    }
    protected override void LoadSideInfo()
    {
        foreach (var sf in GameFile.SpecialForces)
        {
            sf.Name = TextStra.Resources.GetString(sf.TextStraDllId);
            sf.EncyclopediaDescription = EncyText.Resources.GetRcdata((sf.TextStraDllId - 4096).ToString());
        }
    }
    protected override void SaveSideInfo()
    {
        TextStra.Resources.SaveString(Convert.ToUInt16(textStraDllId.Value), name.Text);
        EncyText.Resources.UpdateRcdata((textStraDllId.Value - 4096).ToString(), encyclopediaDescription.Text);
    }

    #endregion

    #region Control events

    private void specialForcesListView_DoubleClick(object sender, EventArgs e)
    {
        selector.Value = specialForcesListView.Items.IndexOf(specialForcesListView.FocusedItem);
        DisplaySelectedGameObject(selector.Value);
        selector.Select();
    }
    private void specialForcesListView_Click(object sender, EventArgs e)
    {
        selector.Value = specialForcesListView.Items.IndexOf(specialForcesListView.FocusedItem);
        DisplaySelectedGameObject(selector.Value);
        selector.Select();
    }
    private void picture_Click(object sender, EventArgs e)
    {
        if (specialForcesListView.Items.Count > selector.Value + 1 && selector.Value - 1 >= 0)
        {
            specialForcesListView.Items[selector.Value + 1].EnsureVisible();
            specialForcesListView.Items[selector.Value - 1].EnsureVisible();
        }
        else
            specialForcesListView.Items[selector.Value].EnsureVisible();
        selector.Select();
    }

    #endregion

    #region Changed events

    private void combatBase_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].CombatBase = (uint)combatBase.Value;
        GameFile.UnsavedData = true;
    }
    private void combatVariance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].CombatVariance = (uint)combatVariance.Value;
        GameFile.UnsavedData = true;
    }
    private void diplomacyBase_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].DiplomacyBase = (uint)diplomacyBase.Value;
        GameFile.UnsavedData = true;
    }
    private void diplomacyVariance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].DiplomacyVariance = (uint)diplomacyVariance.Value;
        GameFile.UnsavedData = true;
    }
    private void encyclopediaDescription_TextChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].EncyclopediaDescription = encyclopediaDescription.Text;
        GameFile.UnsavedData = true;
    }
    private void espionageBase_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].EspionageBase = (uint)espionageBase.Value;
        GameFile.UnsavedData = true;
    }
    private void espionageVariance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].EspionageVariance = (uint)espionageVariance.Value;
        GameFile.UnsavedData = true;
    }
    private void facilityDesignBase_0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].FacilityDesignBase_0 = (uint)facilityDesignBase_0.Value;
        GameFile.UnsavedData = true;
    }
    private void facilityDesignVariance_0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].FacilityDesignVariance_0 = (uint)facilityDesignVariance_0.Value;
        GameFile.UnsavedData = true;
    }
    private void familyId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].FamilyId = (uint)familyId.Value;
        GameFile.UnsavedData = true;
    }
    private void field2_1_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].Field2_1 = (uint)field2_1.Value;
        GameFile.UnsavedData = true;
    }
    private void field7_2_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].Field7_2 = (ushort)field7_2.Value;
        GameFile.UnsavedData = true;
    }
    private void id_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].Id = (uint)id.Value;
        GameFile.UnsavedData = true;
    }
    private void isAlliance_CheckStateChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].IsAlliance = isAlliance.Checked ? 1U : 0U;
        GameFile.UnsavedData = true;
    }
    private void isEmpire_CheckStateChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].IsEmpire = isEmpire.Checked ? 1U : 0U;
        GameFile.UnsavedData = true;
    }
    private void leadershipBase_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].LeadershipBase = (uint)leadershipBase.Value;
        GameFile.UnsavedData = true;
    }
    private void leadershipVariance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].LeadershipVariance = (uint)leadershipVariance.Value;
        GameFile.UnsavedData = true;
    }
    private void loyaltyBase_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].LoyaltyBase = (uint)loyaltyBase.Value;
        GameFile.UnsavedData = true;
    }
    private void loyaltyVariance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].LoyaltyVariance = (uint)loyaltyVariance.Value;
        GameFile.UnsavedData = true;
    }
    private void maintenanceCost_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].MaintenanceCost = (uint)maintenanceCost.Value;
        GameFile.UnsavedData = true;
    }
    private void missionId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].MissionId = (uint)missionId.Value;
        GameFile.UnsavedData = true;
    }
    private void name_TextChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].Name = name.Text;
        GameFile.UnsavedData = true;
    }
    private void nextProductionFamily_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].NextProductionFamily = (uint)nextProductionFamily.Value;
        GameFile.UnsavedData = true;
    }
    private void productionFamily_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].ProductionFamily = (uint)productionFamily.Value;
        GameFile.UnsavedData = true;
    }
    private void refinedMaterialCost_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].RefinedMaterialCost = (uint)refinedMaterialCost.Value;
        GameFile.UnsavedData = true;
    }
    private void researchDifficulty_0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].ResearchDifficulty_0 = (uint)researchDifficulty.Value;
        GameFile.UnsavedData = true;
    }
    private void researchOrder_0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].ResearchOrder_0 = (uint)researchOrder_0.Value;
        GameFile.UnsavedData = true;
    }
    private void shipDesignBase_0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].ShipDesignBase_0 = (uint)shipDesignBase_0.Value;
        GameFile.UnsavedData = true;
    }
    private void shipDesignVariance_0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].ShipDesignVariance_0 = (uint)shipDesignVariance_0.Value;
        GameFile.UnsavedData = true;
    }
    private void textStraDllId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].TextStraDllId = (ushort)textStraDllId.Value;
        GameFile.UnsavedData = true;
    }
    private void troopTrainingBase_0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].TroopTrainingBase_0 = (uint)troopTrainingBase_0.Value;
        GameFile.UnsavedData = true;
    }
    private void troopTrainingVariance_0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SpecialForces[selector.Value].TroopTrainingVariance_0 = (uint)troopTrainingVariance_0.Value;
        GameFile.UnsavedData = true;
    }

    #endregion
}
