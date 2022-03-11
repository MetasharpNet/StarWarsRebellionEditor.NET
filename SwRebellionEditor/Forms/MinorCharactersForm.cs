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
                minorCharactersListView.Items.Add(GameFile.MinorCharacters[selectorIndex].EncyclopediaName, selectorIndex);
            }
        }
        protected override void DisplaySelectedGameObject(int selectorIndex)
        {
            var minorCharacter = GameFile.MinorCharacters[selectorIndex];
            canBeAdmiral.Checked = minorCharacter.CanBeAdmiral > 0U;
            canBeCommander.Checked = minorCharacter.canBeCommander > 0U;
            canBeGeneral.Checked = minorCharacter.CanBeGeneral > 0U;
            combatBase.Value = minorCharacter.CombatBase;
            combatVariance.Value = minorCharacter.CombatVariance;
            diplomacyBase.Value = minorCharacter.DiplomacyBase;
            diplomacyVariance.Value = minorCharacter.DiplomacyVariance;
            encyclopediaName.Text = minorCharacter.EncyclopediaName;
            espionageBase.Value = minorCharacter.EspionageBase;
            espionageVariance.Value = minorCharacter.EspionageVariance;
            facilitiesResearchBase.Value = minorCharacter.FacilitiesResearchBase;
            facilitiesResearchVariance.Value = minorCharacter.FacilitiesResearchVariance;
            familyId.Value = minorCharacter.FamilyId;
            familyIdHexLabel.Text = "0x" + minorCharacter.FamilyId.ToString("X");
            isAllianceUnit.Checked = minorCharacter.IsAllianceUnit > 0U;
            isEmpireUnit.Checked = minorCharacter.IsEmpireUnit > 0U;
            isJediTrainer.Checked = minorCharacter.IsJediTrainer > 0U;
            isKnownJedi.Checked = minorCharacter.IsKnownJedi > 0U;
            isUnableToBetray.Checked = minorCharacter.IsUnableToBetray > 0U;
            jediLevelBase.Value = minorCharacter.JediLevelBase;
            jediLevelVariance.Value = minorCharacter.JediLevelVariance;
            jediProbabilityBase.Value = minorCharacter.JediProbabilityBase;
            loyaltyBase.Value = minorCharacter.LoyaltyBase;
            loyaltyVariance.Value = minorCharacter.LoyaltyVariance;
            shipResearchBase.Value = minorCharacter.ShipResearchBase;
            shipResearchVariance.Value = minorCharacter.ShipResearchVariance;
            textStraDllId.Value = minorCharacter.TextStraDllId;
            troopsResearchBase.Value = minorCharacter.TroopsResearchBase;
            troopsResearchVariance.Value = minorCharacter.TroopsResearchVariance;
            unitId.Value = minorCharacter.UnitId;
            unitIdHexLabel.Text = "0x" + minorCharacter.UnitId.ToString("X");

            if (minorCharacter.EncyclopediaName == "Leia Organa")
            {
                leiaForceLabel.Text = "Leia has no Force ability at start of game";
                jediCombatBase.Value = minorCharacter.CombatBase;
                jediDiplomacyBase.Value = minorCharacter.DiplomacyBase;
                jediEspionageBase.Value = minorCharacter.EspionageBase;
            }
            else
            {
                leiaForceLabel.Text = "";
                jediCombatBase.Value = (int)(minorCharacter.CombatBase + minorCharacter.CombatBase * (double)(minorCharacter.JediLevelBase / 100f));
                jediCombatVariance.Value = minorCharacter.CombatVariance;
                jediDiplomacyBase.Value = (int)(minorCharacter.DiplomacyBase + minorCharacter.DiplomacyBase * (double)(minorCharacter.JediLevelBase / 100f));
                jediDiplomacyVariance.Value = minorCharacter.DiplomacyVariance;
                jediEspionageBase.Value = (int)(minorCharacter.EspionageBase + minorCharacter.EspionageBase * (double)(minorCharacter.JediLevelBase / 100f));
                jediEspionageVariance.Value = minorCharacter.EspionageVariance;
            }

            picture.SizeMode = PictureBoxSizeMode.Zoom;
            var edataId = 78 + selectorIndex;
            picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
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
            GameFile.MinorCharacters[selector.Value].canBeCommander = canBeCommander.Checked ? 1U : 0U;
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
        private void facilitiesResearchBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].FacilitiesResearchBase = (uint)facilitiesResearchBase.Value;
            GameFile.UnsavedData = true;
        }
        private void facilitiesResearchVariance_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].FacilitiesResearchVariance = (uint)facilitiesResearchVariance.Value;
            GameFile.UnsavedData = true;
        }
        private void familyId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].FamilyId = (uint)familyId.Value;
            GameFile.UnsavedData = true;
        }
        private void isAllianceUnit_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].IsAllianceUnit = isAllianceUnit.Checked ? 1U : 0U;
            GameFile.UnsavedData = true;
        }
        private void isEmpireUnit_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].IsEmpireUnit = isEmpireUnit.Checked ? 1U : 0U;
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
        private void jediProbabilityBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].JediProbabilityBase = (uint)jediProbabilityBase.Value;
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
        private void nextProductionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].NextProductionFacility = (uint)nextProductionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void productionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].ProductionFacility = (uint)productionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void shipResearchBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].ShipResearchBase = (uint)shipResearchBase.Value;
            GameFile.UnsavedData = true;
        }
        private void shipResearchVariance_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].ShipResearchVariance = (uint)shipResearchVariance.Value;
            GameFile.UnsavedData = true;
        }
        private void troopsResearchBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].TroopsResearchBase = (uint)troopsResearchBase.Value;
            GameFile.UnsavedData = true;
        }
        private void troopsResearchVariance_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MinorCharacters[selector.Value].TroopsResearchVariance = (uint)troopsResearchVariance.Value;
            GameFile.UnsavedData = true;
        }

        #endregion
    }
}
