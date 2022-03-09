namespace SwRebellionEditor
{
    public partial class DefenseFacilitiesForm : DefenseFacilitiesDesignForm
    {
        #region .ctor

        public DefenseFacilitiesForm()
        {
            GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\DEFFACSD.DAT";
            GameFile = DatFile.Load<DEFFACSD>(GameFilePath);
            InitializeComponent();
            InitializeBaseComponent(selector);
        }

        #endregion

        #region Business Layer

        protected override void DisplaySelectedGameObject(int selectorIndex)
        {
            var defenseFacility = GameFile.DefenseFacilities[selectorIndex];
            constructionCost.Value = defenseFacility.ConstructionCost;
            encyclopediaName.Text = defenseFacility.EncyclopediaName;
            familyId.Value = defenseFacility.FamilyId;
            familyIdHexLabel.Text = defenseFacility.FamilyId.ToString("X");
            firePowerRating.Value = defenseFacility.FirePowerRating;
            isAllianceUnit.Checked = defenseFacility.IsAllianceUnit > 0U;
            isEmpireUnit.Checked = defenseFacility.IsEmpireUnit > 0U;
            maintenanceCost.Value = defenseFacility.MaintenanceCost;
            nextProductionFacility.Value = defenseFacility.NextProductionFacility;
            productionFacility.Value = defenseFacility.ProductionFacility;
            researchDifficulty.Value = defenseFacility.ResearchDifficulty;
            researchOrder.Value = defenseFacility.ResearchOrder;
            shieldRating.Value = defenseFacility.ShieldRating;
            textStraDllId.Value = defenseFacility.TextStraDllId;
            unitId.Value = defenseFacility.UnitId;
            unitIdHexLabel.Text = defenseFacility.UnitId.ToString("X");
            unknownMoralHp.Value = defenseFacility.UnknownMoralHp;
            unknown3Num.Value = defenseFacility.Unknown2;

            picture.SizeMode = PictureBoxSizeMode.Zoom;
            var edataId = 9 + selectorIndex;
            picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
        }

        #endregion

        #region Changed events

        private void constructionCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.DefenseFacilities[selector.Value].ConstructionCost = (uint)constructionCost.Value;
            GameFile.UnsavedData = true;
        }
        private void familyId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.DefenseFacilities[selector.Value].FamilyId = (uint)familyId.Value;
            GameFile.UnsavedData = true;
        }
        private void firePowerRating_ValueChanged(object sender, EventArgs e)
        {
            GameFile.DefenseFacilities[selector.Value].FirePowerRating = (uint)firePowerRating.Value;
            GameFile.UnsavedData = true;
        }
        private void isAllianceUnit_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.DefenseFacilities[selector.Value].IsAllianceUnit = !isAllianceUnit.Checked ? 0U : 1U;
            GameFile.UnsavedData = true;
        }
        private void isEmpireUnit_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.DefenseFacilities[selector.Value].IsEmpireUnit = !isEmpireUnit.Checked ? 0U : 1U;
            GameFile.UnsavedData = true;
        }
        private void maintenanceCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.DefenseFacilities[selector.Value].MaintenanceCost = (uint)maintenanceCost.Value;
            GameFile.UnsavedData = true;
        }
        private void nextProductionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.DefenseFacilities[selector.Value].NextProductionFacility = (uint)nextProductionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void productionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.DefenseFacilities[selector.Value].ProductionFacility = (uint)productionFacility.Value;
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
        private void shieldRating_ValueChanged(object sender, EventArgs e)
        {
            GameFile.DefenseFacilities[selector.Value].ShieldRating = (uint)shieldRating.Value;
            GameFile.UnsavedData = true;
        }
        private void unknownMoralHp_ValueChanged(object sender, EventArgs e)
        {
            GameFile.DefenseFacilities[selector.Value].UnknownMoralHp = (uint)unknownMoralHp.Value;
            GameFile.UnsavedData = true;
        }

        #endregion
    }
}
