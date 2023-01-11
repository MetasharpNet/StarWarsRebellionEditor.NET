namespace SwRebellionEditor
{
    public partial class MinorCharactersForm : MinorCharactersDesignForm
    {
        #region .ctor

        public MinorCharactersForm()
        {
            GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\MNCHARSD.DAT";
            GameFile = DatFile.Load<MNCHARSD>(GameFilePath);
            InitializeComponent();
            InitializeBaseComponent(selector);
            selector.Maximum = (int)GameFile.MinorCharactersCount - 1;
        }

        #endregion

        #region Business Layer

        protected override void DisplayGameItemsImages()
        {
            minorCharactersListView.Sorting = SortOrder.None;
            minorCharactersImages.Images.Clear();
            for (int selectorIndex = 0; selectorIndex < GameFile.MinorCharactersCount; ++selectorIndex)
            {
                var edataId = 78 + selectorIndex;
                minorCharactersImages.Images.Add(Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000")));
                minorCharactersListView.Items.Add(GameFile.MinorCharacters[selectorIndex].Name, selectorIndex);
            }
        }
        protected override void DisplaySelectedGameObject(int selectorIndex)
        {
            var previousUnsavedData = GameFile.UnsavedData;
            var minorCharacter = GameFile.MinorCharacters[selectorIndex];
            canBeAdmiral.Checked = minorCharacter.CanBeAdmiral > 0U;
            canBeCommander.Checked = minorCharacter.CanBeCommander > 0U;
            canBeGeneral.Checked = minorCharacter.CanBeGeneral > 0U;
            combatBase.Value = minorCharacter.CombatBase;
            combatVariance.Value = minorCharacter.CombatVariance;
            diplomacyBase.Value = minorCharacter.DiplomacyBase;
            diplomacyVariance.Value = minorCharacter.DiplomacyVariance;
            encyclopediaDescription.Text = minorCharacter.EncyclopediaDescription;
            espionageBase.Value = minorCharacter.EspionageBase;
            espionageVariance.Value = minorCharacter.EspionageVariance;
            facilityDesignBase.Value = minorCharacter.FacilityDesignBase;
            facilityDesignVariance.Value = minorCharacter.FacilityDesignVariance;
            familyId.Value = minorCharacter.FamilyId;
            familyIdHexLabel.Text = "0x" + minorCharacter.FamilyId.ToString("X");
            field2_1.Value = minorCharacter.Field2_1;
            field7_2.Value = minorCharacter.Field7_2;
            id.Value = minorCharacter.Id;
            idHexLabel.Text = "0x" + minorCharacter.Id.ToString("X");
            isAlliance.Checked = minorCharacter.IsAlliance > 0U;
            isEmpire.Checked = minorCharacter.IsEmpire > 0U;
            isJediTrainer.Checked = minorCharacter.IsJediTrainer > 0U;
            isKnownJedi.Checked = minorCharacter.IsKnownJedi > 0U;
            isUnableToBetray.Checked = minorCharacter.IsUnableToBetray > 0U;
            jediLevelBase.Value = minorCharacter.JediLevelBase;
            jediLevelVariance.Value = minorCharacter.JediLevelVariance;
            jediProbability.Value = minorCharacter.JediProbability;
            leadershipBase.Value = minorCharacter.LeadershipBase;
            leadershipVariance.Value = minorCharacter.LeadershipVariance;
            loyaltyBase.Value = minorCharacter.LoyaltyBase;
            loyaltyVariance.Value = minorCharacter.LoyaltyVariance;
            maintenanceCost.Value = minorCharacter.MaintenanceCost;
            name.Text = minorCharacter.Name;
            nextProductionFamily_0.Value = minorCharacter.NextProductionFamily_0;
            productionFamily_0.Value = minorCharacter.ProductionFamily_0;
            refinedMaterialCost_0.Value = minorCharacter.RefinedMaterialCost_0;
            researchDifficulty_0.Value = minorCharacter.ResearchDifficulty_0;
            researchOrder_0.Value = minorCharacter.ResearchOrder_0;
            shipDesignBase.Value = minorCharacter.ShipDesignBase;
            shipDesignVariance.Value = minorCharacter.ShipDesignVariance;
            textStraDllId.Value = minorCharacter.TextStraDllId;
            troopTrainingBase.Value = minorCharacter.TroopTrainingBase;
            troopTrainingVariance.Value = minorCharacter.TroopTrainingVariance;

            if (minorCharacter.Name == "Leia Organa")
            {
                leiaForceLabel.Text = "Leia has no Force ability at start of game";
                jediCombatBase.Value = minorCharacter.CombatBase;
                jediDiplomacyBase.Value = minorCharacter.DiplomacyBase;
                jediEspionageBase.Value = minorCharacter.EspionageBase;
                jediLeadershipBase.Value = minorCharacter.LeadershipBase;
            }
            else
            {
                leiaForceLabel.Text = "";
                jediCombatBase.Value = (int)(minorCharacter.CombatBase + minorCharacter.CombatBase * (double)(minorCharacter.JediLevelBase / 100f));
                jediDiplomacyBase.Value = (int)(minorCharacter.DiplomacyBase + minorCharacter.DiplomacyBase * (double)(minorCharacter.JediLevelBase / 100f));
                jediEspionageBase.Value = (int)(minorCharacter.EspionageBase + minorCharacter.EspionageBase * (double)(minorCharacter.JediLevelBase / 100f));
                jediLeadershipBase.Value = (int)(minorCharacter.LeadershipBase + minorCharacter.LeadershipBase * (double)(minorCharacter.JediLevelBase / 100f));
            }

            picture.SizeMode = PictureBoxSizeMode.Zoom;
            var edataId = 78 + selectorIndex;
            picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
            GameFile.UnsavedData = previousUnsavedData;
        }
        protected override void LoadSideInfo()
        {
            foreach (var mc in GameFile.MinorCharacters)
                mc.Name = TextStra.GetString(mc.TextStraDllId);
        }
        protected override void SaveSideInfo()
        {
            TextStra.SaveCharacterName(Convert.ToUInt16(textStraDllId.Value), name.Text);
            //EncyText.SaveString(Convert.ToUInt16(xxx.Value), name.Text);
        }

        #endregion

        #region Control events

        private void minorCharactersListView_DoubleClick(object sender, EventArgs e)
        {
            selector.Value = minorCharactersListView.Items.IndexOf(minorCharactersListView.FocusedItem);
            DisplaySelectedGameObject(selector.Value);
            selector.Select();
        }
        private void minorCharactersListView_Click(object sender, EventArgs e)
        {
            selector.Value = minorCharactersListView.Items.IndexOf(minorCharactersListView.FocusedItem);
            DisplaySelectedGameObject(selector.Value);
            selector.Select();
        }
        private void picture_Click(object sender, EventArgs e)
        {
            if (minorCharactersListView.Items.Count > selector.Value + 1 && selector.Value - 1 >= 0)
            {
                minorCharactersListView.Items[selector.Value + 1].EnsureVisible();
                minorCharactersListView.Items[selector.Value - 1].EnsureVisible();
            }
            else
                minorCharactersListView.Items[selector.Value].EnsureVisible();
            selector.Select();
        }

        #endregion

        #region Changed events

        private void canBeAdmiral_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].CanBeAdmiral = canBeAdmiral.Checked ? 1U : 0U;
            GameFile.UnsavedData = true;
        }
        private void canBeCommander_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].CanBeCommander = canBeCommander.Checked ? 1U : 0U;
            GameFile.UnsavedData = true;
        }
        private void canBeGeneral_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].CanBeGeneral = canBeGeneral.Checked ? 1U : 0U;
            GameFile.UnsavedData = true;
        }
        private void combatBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].CombatBase = (uint)combatBase.Value;
            GameFile.UnsavedData = true;
        }
        private void combatVariance_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].CombatVariance = (uint)combatVariance.Value;
            GameFile.UnsavedData = true;
        }
        private void diplomacyBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].DiplomacyBase = (uint)diplomacyBase.Value;
            GameFile.UnsavedData = true;
        }
        private void diplomacyVariance_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].DiplomacyVariance = (uint)diplomacyVariance.Value;
            GameFile.UnsavedData = true;
        }
        private void encyclopediaDescription_TextChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].EncyclopediaDescription = encyclopediaDescription.Text;
            GameFile.UnsavedData = true;
        }
        private void espionageBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].EspionageBase = (uint)espionageBase.Value;
            GameFile.UnsavedData = true;
        }
        private void espionageVariance_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].EspionageVariance = (uint)espionageVariance.Value;
            GameFile.UnsavedData = true;
        }
        private void facilityDesignBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].FacilityDesignBase = (uint)facilityDesignBase.Value;
            GameFile.UnsavedData = true;
        }
        private void facilityDesignVariance_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].FacilityDesignVariance = (uint)facilityDesignVariance.Value;
            GameFile.UnsavedData = true;
        }
        private void familyId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].FamilyId = (uint)familyId.Value;
            GameFile.UnsavedData = true;
        }
        private void field2_1_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].Field2_1 = (uint)field2_1.Value;
            GameFile.UnsavedData = true;
        }
        private void field7_2_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].Field7_2 = (ushort)field7_2.Value;
            GameFile.UnsavedData = true;
        }
        private void id_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].Id = (uint)id.Value;
            GameFile.UnsavedData = true;
        }
        private void isAlliance_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].IsAlliance = isAlliance.Checked ? 1U : 0U;
            GameFile.UnsavedData = true;
        }
        private void isEmpire_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].IsEmpire = isEmpire.Checked ? 1U : 0U;
            GameFile.UnsavedData = true;
        }
        private void isJediTrainer_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].IsJediTrainer = isJediTrainer.Checked ? 1U : 0U;
            GameFile.UnsavedData = true;
        }
        private void isKnownJedi_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].IsKnownJedi = isKnownJedi.Checked ? 1U : 0U;
            GameFile.UnsavedData = true;
        }
        private void isUnableToBetray_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].IsUnableToBetray = isUnableToBetray.Checked ? 1U : 0U;
            GameFile.UnsavedData = true;
        }
        private void jediLevelBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].JediLevelBase = (uint)jediLevelBase.Value;
            GameFile.UnsavedData = true;
        }
        private void jediLevelVariance_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].JediLevelVariance = (uint)jediLevelVariance.Value;
            GameFile.UnsavedData = true;
        }
        private void jediProbability_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].JediProbability = (uint)jediProbability.Value;
            GameFile.UnsavedData = true;
        }
        private void leadershipBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].LeadershipBase = (uint)leadershipBase.Value;
            GameFile.UnsavedData = true;
        }
        private void leadershipVariance_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].LeadershipVariance = (uint)leadershipVariance.Value;
            GameFile.UnsavedData = true;
        }
        private void loyaltyBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].LoyaltyBase = (uint)loyaltyBase.Value;
            GameFile.UnsavedData = true;
        }
        private void loyaltyVariance_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].LoyaltyVariance = (uint)loyaltyVariance.Value;
            GameFile.UnsavedData = true;
        }
        private void maintenanceCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].MaintenanceCost = (uint)maintenanceCost.Value;
            GameFile.UnsavedData = true;
        }
        private void name_TextChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].Name = name.Text;
            GameFile.UnsavedData = true;
        }
        private void nextProductionFamily_0_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].NextProductionFamily_0 = (uint)nextProductionFamily_0.Value;
            GameFile.UnsavedData = true;
        }
        private void productionFamily_0_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].ProductionFamily_0 = (uint)productionFamily_0.Value;
            GameFile.UnsavedData = true;
        }
        private void refinedMaterialCost_0_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].RefinedMaterialCost_0 = (uint)refinedMaterialCost_0.Value;
            GameFile.UnsavedData = true;
        }
        private void researchDifficulty_0_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].ResearchDifficulty_0 = (uint)researchDifficulty_0.Value;
            GameFile.UnsavedData = true;
        }
        private void researchOrder_0_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].ResearchOrder_0 = (uint)researchOrder_0.Value;
            GameFile.UnsavedData = true;
        }
        private void shipDesignBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].ShipDesignBase = (uint)shipDesignBase.Value;
            GameFile.UnsavedData = true;
        }
        private void shipDesignVariance_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].ShipDesignVariance = (uint)shipDesignVariance.Value;
            GameFile.UnsavedData = true;
        }
        private void textStraDllId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].TextStraDllId = (ushort)textStraDllId.Value;
            GameFile.UnsavedData = true;
        }
        private void troopTrainingBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].TroopTrainingBase = (uint)troopTrainingBase.Value;
            GameFile.UnsavedData = true;
        }
        private void troopTrainingVariance_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].TroopTrainingVariance = (uint)troopTrainingVariance.Value;
            GameFile.UnsavedData = true;
        }

        #endregion
    }
}
