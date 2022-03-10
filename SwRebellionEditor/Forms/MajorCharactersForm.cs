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
            troopsReseachVariance.Value = majorCharacter.troopsReseachVariance;
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





        #endregion








        private void updateDipBaseNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].DiplomacyBase = (uint)diplomacyBase.Value;
            GameFile.UnsavedData = true;
        }
        private void updateDipVarNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].DiplomacyVariance = (uint)diplomacyVariance.Value;
            GameFile.UnsavedData = true;
        }
        private void updateEspBaseNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].EspionageBase = (uint)espionageBase.Value;
            GameFile.UnsavedData = true;
        }
        private void updateEspVarNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].EspionageVariance = (uint)espionageVariance.Value;
            GameFile.UnsavedData = true;
        }

        private void updateCombatBaseNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].CombatBase = (uint)combatBase.Value;
            GameFile.UnsavedData = true;
        }

        private void updateCombatVarNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].CombatVariance = (uint)combatVariance.Value;
            GameFile.UnsavedData = true;
        }

        private void updateLoyalBaseNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].LoyaltyBase = (uint)loyaltyBase.Value;
            GameFile.UnsavedData = true;
        }

        private void updateLoyalVarNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].LoyaltyVariance = (uint)loyaltyVariance.Value;
            GameFile.UnsavedData = true;
        }

        private void updateShipResBaseNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].ShipResearchBase = (uint)shipResearchBase.Value;
            GameFile.UnsavedData = true;
        }

        private void updateShipResVarNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].ShipResearchVariance = (uint)shipResearchVariance.Value;
            GameFile.UnsavedData = true;
        }

        private void updateTroopResBaseNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].TroopsResearchBase = (uint)troopsResearchBase.Value;
            GameFile.UnsavedData = true;
        }

        private void updateTroopResVarNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].troopsReseachVariance = (uint)troopsReseachVariance.Value;
            GameFile.UnsavedData = true;
        }

        private void updateFacResBaseNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].FacilitiesResearchBase = (uint)facilitiesResearchBase.Value;
            GameFile.UnsavedData = true;
        }

        private void updateFacResVarNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].FacilitiesResearchVariance = (uint)facilitiesResearchVariance.Value;
            GameFile.UnsavedData = true;
        }

        private void updateJediProbBaseNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].JediProbabilityBase = (uint)jediProbabilityBase.Value;
            GameFile.UnsavedData = true;
        }

        private void updateJediLevelBaseNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].JediLevelBase = (uint)jediLevelBase.Value;
            GameFile.UnsavedData = true;
        }

        private void updateJediLevelVarNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].JediLevelVariance = (uint)jediLevelVariance.Value;
            GameFile.UnsavedData = true;
        }

        private void updateknownJediCheck(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].IsKnownJedi = !isKnownJedi.Checked ? 0U : 1U;
            GameFile.UnsavedData = true;
        }

        private void updateTrainJediCheck(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].IsJediTrainer = !isJediTrainer.Checked ? 0U : 1U;
            GameFile.UnsavedData = true;
        }

        private void updateRebelUnitCheck(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].IsAllianceUnit = !isAllianceUnit.Checked ? 0U : 1U;
            GameFile.UnsavedData = true;
        }

        private void updateEmpireUnitCheck(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].IsEmpireUnit = !isEmpireUnit.Checked ? 0U : 1U;
            GameFile.UnsavedData = true;
        }

        private void updateBetrayFlagCheck(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].IsUnableToBetray = !isUnableToBetray.Checked ? 0U : 1U;
            GameFile.UnsavedData = true;
        }

        private void updateCmdAdmCheck(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].CanBeAdmiral = !canBeAdmiral.Checked ? 0U : 1U;
            GameFile.UnsavedData = true;
        }

        private void updateCmdGenCheck(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].CanBeGeneral = !canBeGeneral.Checked ? 0U : 1U;
            GameFile.UnsavedData = true;
        }

        private void updateCmdCommCheck(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].CanBeCommander = !canBeCommander.Checked ? 0U : 1U;
            GameFile.UnsavedData = true;
        }

        private void updateProdFacNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].prodFacilityNum = (uint)prodFacNum.Value;
            GameFile.UnsavedData = true;
        }

        private void updateSecProdFacNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].unknown2 = (uint)secProdFacNum.Value;
            GameFile.UnsavedData = true;
        }

        private void updateFamilyIdNum(object sender, EventArgs e)
        {
            GameFile.MajorCharacters[selector.Value].FamilyId = (uint)familyId.Value;
            GameFile.UnsavedData = true;
        }

        private void loadMajCharImageList()
        {
            int num = 72;
            charListView.Sorting = SortOrder.None;
            majCharImageList.Images.Clear();
            for (int index = num; index <= num + GameFile.MajorCharactersCount - 1; ++index)
            {
                majCharImageList.Images.Add(Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA.0" + index));
                charListView.Items.Add(GameFile.MajorCharacters[index - num].EncyclopediaName, index - num);
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
