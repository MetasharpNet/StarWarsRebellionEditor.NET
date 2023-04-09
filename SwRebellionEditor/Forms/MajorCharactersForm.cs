namespace SwRebellionEditor;

public partial class MajorCharactersForm : MajorCharactersDesignForm
{
    #region .ctor

    public MajorCharactersForm()
    {
        GameFilePath = Path.Combine(Settings.Current.GDataFolder, "MJCHARSD.DAT");
        GameFile = DatFile.Load<MJCHARSD>(GameFilePath);
        InitializeComponent();
        InitializeBaseComponent(selector);
        selector.Maximum = (int)GameFile.MajorCharactersCount - 1;
    }

    #endregion

    #region Business Layer

    protected override void DisplayGameItemsImages()
    {
        majorCharactersListView.Sorting = SortOrder.None;
        majorCharactersImages.Images.Clear();
        for (int selectorIndex = 0; selectorIndex < GameFile.MajorCharactersCount; ++selectorIndex)
        {
            GetEncyclopediaImageAndAddToList(72 + selectorIndex, majorCharactersImages);
            majorCharactersListView.Items.Add(GameFile.MajorCharacters[selectorIndex].Name, selectorIndex);
        }
    }
    protected override void DisplaySelectedGameObject(int selectorIndex)
    {
        var previousUnsavedData = GameFile.UnsavedData;
        var majorCharacter = GameFile.MajorCharacters[selectorIndex];
        canBeAdmiral.Checked = majorCharacter.CanBeAdmiral > 0U;
        canBeCommander.Checked = majorCharacter.CanBeCommander > 0U;
        canBeGeneral.Checked = majorCharacter.CanBeGeneral > 0U;
        combatBase.Value = majorCharacter.CombatBase;
        combatVariance.Value = majorCharacter.CombatVariance;
        diplomacyBase.Value = majorCharacter.DiplomacyBase;
        diplomacyVariance.Value = majorCharacter.DiplomacyVariance;
        encyclopediaDescription.Text = majorCharacter.EncyclopediaDescription;
        espionageBase.Value = majorCharacter.EspionageBase;
        espionageVariance.Value = majorCharacter.EspionageVariance;
        facilityDesignBase.Value = majorCharacter.FacilityDesignBase;
        facilityDesignVariance.Value = majorCharacter.FacilityDesignVariance;
        familyId.Value = majorCharacter.FamilyId;
        familyIdHexLabel.Text = "0x" + majorCharacter.FamilyId.ToString("X");
        field2_1.Value = majorCharacter.Field2_1;
        field7_2.Value = majorCharacter.Field7_2;
        id.Value = majorCharacter.Id;
        idHexLabel.Text = "0x" + majorCharacter.Id.ToString("X");
        isAlliance.Checked = majorCharacter.IsAlliance > 0U;
        isEmpire.Checked = majorCharacter.IsEmpire > 0U;
        isJediTrainer.Checked = majorCharacter.IsJediTrainer > 0U;
        isKnownJedi.Checked = majorCharacter.IsKnownJedi > 0U;
        isUnableToBetray.Checked = majorCharacter.IsUnableToBetray > 0U;
        jediLevelBase.Value = majorCharacter.JediLevelBase;
        jediLevelVariance.Value = majorCharacter.JediLevelVariance;
        jediProbability.Value = majorCharacter.JediProbability;
        leadershipBase.Value = majorCharacter.LeadershipBase;
        leadershipVariance.Value = majorCharacter.LeadershipVariance;
        loyaltyBase.Value = majorCharacter.LoyaltyBase;
        loyaltyVariance.Value = majorCharacter.LoyaltyVariance;
        maintenanceCost.Value = majorCharacter.MaintenanceCost;
        name.Text = majorCharacter.Name;
        nextProductionFamily_0.Value = majorCharacter.NextProductionFamily_0;
        productionFamily_0.Value = majorCharacter.ProductionFamily_0;
        refinedMaterialCost_0.Value = majorCharacter.RefinedMaterialCost_0;
        researchDifficulty_0.Value = majorCharacter.ResearchDifficulty_0;
        researchOrder_0.Value = majorCharacter.ResearchOrder_0;
        shipDesignBase.Value = majorCharacter.ShipDesignBase;
        shipDesignVariance.Value = majorCharacter.ShipDesignVariance;
        textStraDllId.Value = majorCharacter.TextStraDllId;
        troopTrainingBase.Value = majorCharacter.TroopTrainingBase;
        troopTrainingVariance.Value = majorCharacter.TroopTrainingVariance;

        if (majorCharacter.Name == "Leia Organa")
       {
            leiaForceLabel.Text = "Leia has no Force ability at start of game";
            jediCombatBase.Value = majorCharacter.CombatBase;
            jediDiplomacyBase.Value = majorCharacter.DiplomacyBase;
            jediEspionageBase.Value = majorCharacter.EspionageBase;
            jediLeadershipBase.Value = majorCharacter.LeadershipBase;
        }
        else
        {
            leiaForceLabel.Text = "";
            jediCombatBase.Value = (int)(majorCharacter.CombatBase + majorCharacter.CombatBase * (double)(majorCharacter.JediLevelBase / 100f));
            jediDiplomacyBase.Value = (int)(majorCharacter.DiplomacyBase + majorCharacter.DiplomacyBase * (double)(majorCharacter.JediLevelBase / 100f));
            jediEspionageBase.Value = (int)(majorCharacter.EspionageBase + majorCharacter.EspionageBase * (double)(majorCharacter.JediLevelBase / 100f));
            jediLeadershipBase.Value = (int)(majorCharacter.LeadershipBase);
        }

        picture.SizeMode = PictureBoxSizeMode.Zoom;
        picture.Image = GetEncyclopediaImageAndAddToList(72 + selectorIndex);
        GameFile.UnsavedData = previousUnsavedData;
    }
    protected override void LoadSideInfo()
    {
        foreach (var mc in GameFile.MajorCharacters)
        {
            mc.Name = TextStra.Resources.RT_STRING[mc.TextStraDllId];
            mc.EncyclopediaDescription = EncyText.Resources.RT_RCDATA[(mc.TextStraDllId - 4096).ToString()];
        }
    }
    protected override void SaveSideInfo()
    {
        TextStra.SaveCharacterName(Convert.ToUInt16(textStraDllId.Value), name.Text);
        EncyText.Resources.SaveRcdata((textStraDllId.Value - 4096).ToString(), encyclopediaDescription.Text);
    }

    #endregion

    #region Control events

    private void majorCharactersListView_DoubleClick(object sender, EventArgs e)
    {
        selector.Value = majorCharactersListView.Items.IndexOf(majorCharactersListView.FocusedItem);
        DisplaySelectedGameObject(selector.Value);
        selector.Select();
    }
    private void majorCharactersListView_Click(object sender, EventArgs e)
    {
        selector.Value = majorCharactersListView.Items.IndexOf(majorCharactersListView.FocusedItem);
        DisplaySelectedGameObject(selector.Value);
        selector.Select();
    }
    private void picture_Click(object sender, EventArgs e)
    {
        if (majorCharactersListView.Items.Count > selector.Value + 1 && selector.Value - 1 >= 0)
        {
            majorCharactersListView.Items[selector.Value + 1].EnsureVisible();
            majorCharactersListView.Items[selector.Value - 1].EnsureVisible();
        }
        else
            majorCharactersListView.Items[selector.Value].EnsureVisible();
        selector.Select();
    }

    #endregion

    #region Changed events

    private void canBeAdmiral_CheckStateChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].CanBeAdmiral = canBeAdmiral.Checked ? 1U : 0U;
        GameFile.UnsavedData = true;
    }
    private void canBeCommander_CheckStateChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].CanBeCommander = canBeCommander.Checked ? 1U : 0U;
        GameFile.UnsavedData = true;
    }
    private void canBeGeneral_CheckStateChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].CanBeGeneral = canBeGeneral.Checked ? 1U : 0U;
        GameFile.UnsavedData = true;
    }
    private void combatBase_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].CombatBase = (uint)combatBase.Value;
        GameFile.UnsavedData = true;
    }
    private void combatVariance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].CombatVariance = (uint)combatVariance.Value;
        GameFile.UnsavedData = true;
    }
    private void diplomacyBase_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].DiplomacyBase = (uint)diplomacyBase.Value;
        GameFile.UnsavedData = true;
    }
    private void diplomacyVariance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].DiplomacyVariance = (uint)diplomacyVariance.Value;
        GameFile.UnsavedData = true;
    }
    private void encyclopediaDescription_TextChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].EncyclopediaDescription = encyclopediaDescription.Text;
        GameFile.UnsavedData = true;
    }
    private void espionageBase_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].EspionageBase = (uint)espionageBase.Value;
        GameFile.UnsavedData = true;
    }
    private void espionageVariance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].EspionageVariance = (uint)espionageVariance.Value;
        GameFile.UnsavedData = true;
    }
    private void facilityDesignBase_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].FacilityDesignBase = (uint)facilityDesignBase.Value;
        GameFile.UnsavedData = true;
    }
    private void facilityDesignVariance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].FacilityDesignVariance = (uint)facilityDesignVariance.Value;
        GameFile.UnsavedData = true;
    }
    private void familyId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].FamilyId = (uint)familyId.Value;
        GameFile.UnsavedData = true;
    }
    private void field2_1_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].Field2_1 = (uint)field2_1.Value;
        GameFile.UnsavedData = true;
    }
    private void field7_2_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].Field7_2 = (ushort)field7_2.Value;
        GameFile.UnsavedData = true;
    }
    private void id_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].Id = (uint)id.Value;
        GameFile.UnsavedData = true;
    }
    private void isAlliance_CheckStateChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].IsAlliance = isAlliance.Checked ? 1U : 0U;
        GameFile.UnsavedData = true;
    }
    private void isEmpire_CheckStateChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].IsEmpire = isEmpire.Checked ? 1U : 0U;
        GameFile.UnsavedData = true;
    }
    private void isJediTrainer_CheckStateChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].IsJediTrainer = isJediTrainer.Checked ? 1U : 0U;
        GameFile.UnsavedData = true;
    }
    private void isKnownJedi_CheckStateChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].IsKnownJedi = isKnownJedi.Checked ? 1U : 0U;
        GameFile.UnsavedData = true;
    }
    private void isUnableToBetray_CheckStateChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].IsUnableToBetray = isUnableToBetray.Checked ? 1U : 0U;
        GameFile.UnsavedData = true;
    }
    private void jediLevelBase_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].JediLevelBase = (uint)jediLevelBase.Value;
        GameFile.UnsavedData = true;
    }
    private void jediLevelVariance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].JediLevelVariance = (uint)jediLevelVariance.Value;
        GameFile.UnsavedData = true;
    }
    private void jediProbability_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].JediProbability = (uint)jediProbability.Value;
        GameFile.UnsavedData = true;
    }
    private void leadershipBase_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].LeadershipBase = (uint)leadershipBase.Value;
        GameFile.UnsavedData = true;
    }
    private void leadershipVariance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].LeadershipVariance = (uint)leadershipVariance.Value;
        GameFile.UnsavedData = true;
    }
    private void loyaltyBase_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].LoyaltyBase = (uint)loyaltyBase.Value;
        GameFile.UnsavedData = true;
    }
    private void loyaltyVariance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].LoyaltyVariance = (uint)loyaltyVariance.Value;
        GameFile.UnsavedData = true;
    }
    private void maintenanceCost_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].MaintenanceCost = (uint)maintenanceCost.Value;
        GameFile.UnsavedData = true;
    }
    private void name_TextChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].Name = name.Text;
        GameFile.UnsavedData = true;
    }
    private void nextProductionFamily_0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].NextProductionFamily_0 = (uint)nextProductionFamily_0.Value;
        GameFile.UnsavedData = true;
    }
    private void productionFamily_0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].ProductionFamily_0 = (uint)productionFamily_0.Value;
        GameFile.UnsavedData = true;
    }
    private void refinedMaterialCost_0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].RefinedMaterialCost_0 = (uint)refinedMaterialCost_0.Value;
        GameFile.UnsavedData = true;
    }
    private void researchDifficulty_0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].ResearchDifficulty_0 = (uint)researchDifficulty_0.Value;
        GameFile.UnsavedData = true;
    }
    private void researchOrder_0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].ResearchOrder_0 = (uint)researchOrder_0.Value;
        GameFile.UnsavedData = true;
    }
    private void shipDesignBase_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].ShipDesignBase = (uint)shipDesignBase.Value;
        GameFile.UnsavedData = true;
    }
    private void shipDesignVariance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].ShipDesignVariance = (uint)shipDesignVariance.Value;
        GameFile.UnsavedData = true;
    }
    private void textStraDllId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].TextStraDllId = (ushort)textStraDllId.Value;
        GameFile.UnsavedData = true;
    }
    private void troopTrainingBase_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].TroopTrainingBase = (uint)troopTrainingBase.Value;
        GameFile.UnsavedData = true;
    }
    private void troopTrainingVariance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.MajorCharacters[selector.Value].TroopTrainingVariance = (uint)troopTrainingVariance.Value;
        GameFile.UnsavedData = true;
    }

    #endregion
}
