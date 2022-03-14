namespace SwRebellionEditor
{
    public partial class SpecialForcesForm : SpecialForcesDesignForm
    {
        #region .ctor

        public SpecialForcesForm()
        {
            GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\SPECFCSD.DAT";
            GameFile = DatFile.Load<SPECFCSD>(GameFilePath);
            InitializeComponent();
            InitializeBaseComponent(selector);
        }

        #endregion

        #region Business Layer

        protected override void DisplayGameItemsImages()
        {
            specialForcesListView.Sorting = SortOrder.None;
            SpecialForcesImageList.Images.Clear();
            for (int selectorIndex = 0; selectorIndex < GameFile.SpecialForcesCount; ++selectorIndex)
            {
                var edataId = 25 + selectorIndex;
                SpecialForcesImageList.Images.Add(Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000")));
                specialForcesListView.Items.Add(GameFile.SpecialForces[selectorIndex].EncyclopediaName, selectorIndex);
            }
        }
        protected override void DisplaySelectedGameObject(int selectorIndex)
        {
            var previousUnsavedData = GameFile.UnsavedData;
            var specialForce = GameFile.SpecialForces[selectorIndex];
            combatBase.Value = specialForce.CombatBase;
            combatVariance.Value = specialForce.CombatVariance;
            constructionCost.Value = specialForce.ConstructionCost;
            diplomacyBase.Value = specialForce.DiplomacyBase;
            diplomacyVariance.Value = specialForce.DiplomacyVariance;
            encyclopediaName.Text = specialForce.EncyclopediaName;
            espionageBase.Value = specialForce.EspionageBase;
            espionageVariance.Value = specialForce.EspionageVariance;
            facilitiesResearchBase.Value = specialForce.FacilitiesResearchBase;
            facilitiesResearchVariance.Value = specialForce.FacilitiesResearchVariance;
            familyId.Value = specialForce.FamilyId;
            familyIdHexLabel.Text = "0x" + specialForce.FamilyId.ToString("X");
            isAllianceUnit.Checked = specialForce.IsAllianceUnit > 0U;
            isEmpireUnit.Checked = specialForce.IsEmpireUnit > 0U;
            loyaltyBase.Value = specialForce.LoyaltyBase;
            loyaltyVariance.Value = specialForce.LoyaltyVariance;
            maintenanceCost.Value = specialForce.MaintenanceCost;
            missionId.Value = specialForce.MissionId;
            nextProductionFacility.Value = specialForce.NextProductionFacility;
            productionFacility.Value = specialForce.ProductionFacility;
            researchDifficulty.Value = specialForce.ResearchDifficulty;
            researchOrder.Value = specialForce.ResearchOrder;
            shipsResearchBase.Value = specialForce.ShipsResearchBase;
            shipsResearchVariance.Value = specialForce.ShipsResearchVariance;
            specialForceId.Value = specialForce.SpecialForceId;
            specialForceIdHexLabel.Text = "0x" + specialForce.SpecialForceId.ToString("X");
            textStraDllId.Value = specialForce.TextStraDllId;
            troopsResearchBase.Value = specialForce.TroopsResearchBase;
            troopsResearchVariance.Value = specialForce.TroopsResearchVariance;
            unknown2.Value = specialForce.Unknown2;

            picture.SizeMode = PictureBoxSizeMode.Zoom;
            var edataId = 25 + selectorIndex;
            picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
            GameFile.UnsavedData = previousUnsavedData;
        }

        #endregion

        #region Control events

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
        private void constructionCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.SpecialForces[selector.Value].ConstructionCost = (uint)constructionCost.Value;
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
        private void facilitiesResearchBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.SpecialForces[selector.Value].FacilitiesResearchBase = (uint)facilitiesResearchBase.Value;
            GameFile.UnsavedData = true;
        }
        private void facilitiesResearchVariance_ValueChanged(object sender, EventArgs e)
        {
            GameFile.SpecialForces[selector.Value].FacilitiesResearchVariance = (uint)facilitiesResearchVariance.Value;
            GameFile.UnsavedData = true;
        }
        private void familyId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.SpecialForces[selector.Value].FamilyId = (uint)familyId.Value;
            GameFile.UnsavedData = true;
        }
        private void isAllianceUnit_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.SpecialForces[selector.Value].IsAllianceUnit = !isAllianceUnit.Checked ? 0U : 1U;
            GameFile.UnsavedData = true;
        }
        private void isEmpireUnit_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.SpecialForces[selector.Value].IsEmpireUnit = !isEmpireUnit.Checked ? 0U : 1U;
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
        private void nextProductionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.SpecialForces[selector.Value].NextProductionFacility = (uint)nextProductionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void productionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.SpecialForces[selector.Value].ProductionFacility = (uint)productionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void researchDifficulty_ValueChanged(object sender, EventArgs e)
        {
            GameFile.SpecialForces[selector.Value].ResearchDifficulty = (uint)researchDifficulty.Value;
            GameFile.UnsavedData = true;
        }
        private void researchOrder_ValueChanged(object sender, EventArgs e)
        {
            GameFile.SpecialForces[selector.Value].ResearchOrder = (uint)researchOrder.Value;
            GameFile.UnsavedData = true;
        }
        private void shipsResearchBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.SpecialForces[selector.Value].ShipsResearchBase = (uint)shipsResearchBase.Value;
            GameFile.UnsavedData = true;
        }
        private void shipsResearchVariance_ValueChanged(object sender, EventArgs e)
        {
            GameFile.SpecialForces[selector.Value].ShipsResearchVariance = (uint)shipsResearchVariance.Value;
            GameFile.UnsavedData = true;
        }
        private void troopsResearchBase_ValueChanged(object sender, EventArgs e)
        {
            GameFile.SpecialForces[selector.Value].TroopsResearchBase = (uint)troopsResearchBase.Value;
            GameFile.UnsavedData = true;
        }
        private void troopsResearchVariance_ValueChanged(object sender, EventArgs e)
        {
            GameFile.SpecialForces[selector.Value].TroopsResearchVariance = (uint)troopsResearchVariance.Value;
            GameFile.UnsavedData = true;
        }

        #endregion
    }
}
