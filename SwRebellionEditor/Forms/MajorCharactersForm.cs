namespace SwRebellionEditor
{
    public partial class MajorCharactersForm : MajorCharactersDesignForm
    {
        #region .ctor

        public MajorCharactersForm()
        {
            GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\MJCHARSD.DAT";
            GameFile = DatFile.Load<MJCHARSD>(GameFilePath);
            InitializeComponent();
            InitializeBaseComponent(selector);
        }

        #endregion

        #region Business Layer

        protected override void DisplaySelectedGameObject(int selectorIndex)
        {
            var majorCharacter = GameFile.MajorCharacters[selectorIndex];
            canBeAdmiral.Checked = majorCharacter.CanBeAdmiral > 0U;
            canBeCommander.Checked = majorCharacter.CanBeCommander > 0U;
            canBeGeneral.Checked = majorCharacter.CanBeGeneral > 0U;
            combatBase.Value = majorCharacter.CombatBase;
            combatVariance.Value = majorCharacter.CombatVariance;
            diplomacyBase.Value = majorCharacter.DiplomacyBase;
            diplomacyVariance.Value = majorCharacter.DiplomacyVariance;
            encyclopediaName.Text = majorCharacter.EncyclopediaName;
            espionageBase.Value = majorCharacter.EspionageBase;
            espionageVariance.Value = majorCharacter.EspionageVariance;
            facilitiesResearchBase.Value = majorCharacter.FacilitiesResearchBase;
            facilitiesResearchVariance.Value = majorCharacter.FacilitiesResearchVariance;
            familyId.Value = majorCharacter.FamilyId;
            familyIdHexLabel.Text = majorCharacter.FamilyId.ToString("X");
            isAllianceUnit.Checked = majorCharacter.IsAllianceUnit > 0U;
            isEmpireUnit.Checked = majorCharacter.IsEmpireUnit > 0U;
            isJediTrainer.Checked = majorCharacter.IsJediTrainer > 0U;
            isKnownJedi.Checked = majorCharacter.IsKnownJedi > 0U;
            isUnableToBetray.Checked = majorCharacter.IsUnableToBetray > 0U;
            jediLevelBase.Value = majorCharacter.JediLevelBase;
            jediLevelVariance.Value = majorCharacter.JediLevelVariance;
            jediProbabilityBase.Value = majorCharacter.JediProbabilityBase;
            loyaltyBase.Value = majorCharacter.LoyaltyBase;
            loyaltyVariance.Value = majorCharacter.LoyaltyVariance;
            shipResearchBase.Value = majorCharacter.ShipResearchBase;
            shipResearchVariance.Value = majorCharacter.ShipResearchVariance;
            textStraDllId.Value = majorCharacter.TextStraDllId;
            troopsResearchBase.Value = majorCharacter.TroopsResearchBase;
            troopsReseachVariance.Value = majorCharacter.TroopsReseachVariance;
            unitId.Value = majorCharacter.UnitId;
            unitIdHexLabel.Text = majorCharacter.UnitId.ToString("X");

            if (majorCharacter.EncyclopediaName == "Leia Organa")
            {
                leiaForceLabel.Text = "Leia has no Force ability at start of game";
                jediCombatBase.Value = majorCharacter.CombatBase;
                jediDiplomacyBase.Value = majorCharacter.DiplomacyBase;
                jediEspionageBase.Value = majorCharacter.EspionageBase;
            }
            else
            {
                leiaForceLabel.Text = "";
                jediCombatBase.Value = (int)(majorCharacter.CombatBase + majorCharacter.CombatBase * (double)(majorCharacter.JediLevelBase / 100f));
                jediCombatVariance.Value = majorCharacter.CombatVariance;
                jediDiplomacyBase.Value = (int)(majorCharacter.DiplomacyBase + majorCharacter.DiplomacyBase * (double)(majorCharacter.JediLevelBase / 100f));
                jediDiplomacyVariance.Value = majorCharacter.DiplomacyVariance;
                jediEspionageBase.Value = (int)(majorCharacter.EspionageBase + majorCharacter.EspionageBase * (double)(majorCharacter.JediLevelBase / 100f));
                jediEspionageVariance.Value = majorCharacter.EspionageVariance;
            }

            picture.SizeMode = PictureBoxSizeMode.Zoom;
            var edataId = 72 + selectorIndex;
            picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
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
        private void facilitiesResearchBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].FacilitiesResearchBase = (uint)facilitiesResearchBase.Value;
            GameFile.UnsavedData = true;
        }
        private void facilitiesResearchVariance_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].FacilitiesResearchVariance = (uint)facilitiesResearchVariance.Value;
            GameFile.UnsavedData = true;
        }
        private void familyId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].FamilyId = (uint)familyId.Value;
            GameFile.UnsavedData = true;
        }
        private void isAllianceUnit_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].IsAllianceUnit = isAllianceUnit.Checked ? 1U : 0U;
            GameFile.UnsavedData = true;
        }
        private void isEmpireUnit_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].IsEmpireUnit = isEmpireUnit.Checked ? 1U : 0U;
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
        private void jediProbabilityBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].JediProbabilityBase = (uint)jediProbabilityBase.Value;
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
        private void nextProductionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].NextProductionFacility = (uint)nextProductionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void productionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].ProductionFacility = (uint)productionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void shipResearchBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].ShipResearchBase = (uint)shipResearchBase.Value;
            GameFile.UnsavedData = true;
        }
        private void shipResearchVariance_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].ShipResearchVariance = (uint)shipResearchVariance.Value;
            GameFile.UnsavedData = true;
        }
        private void troopsResearchBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].TroopsResearchBase = (uint)troopsResearchBase.Value;
            GameFile.UnsavedData = true;
        }
        private void troopsReseachVariance_ValueChanged(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].TroopsReseachVariance = (uint)troopsReseachVariance.Value;
            GameFile.UnsavedData = true;
        }

        #endregion









        private void loadMajCharImageList()
        {
            charListView.Sorting = SortOrder.None;
            majCharImageList.Images.Clear();
            for (int selectorIndex = 0; selectorIndex < GameFile.MajorCharactersCount; ++selectorIndex)
            {
                var edataId = 72 + selectorIndex;
                majCharImageList.Images.Add(Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000")));
                charListView.Items.Add(GameFile.MajorCharacters[selectorIndex].EncyclopediaName, selectorIndex);
            }
        }

        private void charListView_NewSelection()
        {
            selector.Value = charListView.Items.IndexOf(charListView.FocusedItem);
            //DisplayMajCharData(selector.Value);
            selector.Select();
        }

        private void charListView_DoubleClick(object sender, EventArgs e)
        {
            charListView_NewSelection();
        }

        private void charListView_Click(object sender, EventArgs e)
        {
            charListView_NewSelection();
        }

        private void ItemPicture_Click(object sender, EventArgs e)
        {
            if (charListView.Items.Count > selector.Value + 1 && selector.Value - 1 >= 0)
            {
                charListView.Items[selector.Value + 1].EnsureVisible();
                charListView.Items[selector.Value - 1].EnsureVisible();
            }
            else
            {
                charListView.Items[selector.Value].EnsureVisible();
            }

            selector.Select();
        }

        private void MajCharForm_Load(object sender, EventArgs e)
        {
            if (RegistryKeys.PlaySounds)
            {
                Sound.Play(Resources.open_wav);
            }

            if (RegistryKeys.PlayMusic)
            {
                Sound.PlayRandomMusic();
            }

            //DisplayMajCharData(selector.Value);
            loadMajCharImageList();
            selector.Select();
        }
    }
}
