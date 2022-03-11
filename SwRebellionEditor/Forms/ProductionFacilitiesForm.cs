namespace SwRebellionEditor
{
    public partial class ProductionFacilitiesForm : ProductionFacilitiesDesignForm
    {
        #region .ctor

        public ProductionFacilitiesForm()
        {
            GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\PROFACSD.DAT";
            GameFile = DatFile.Load<PROFACSD>(GameFilePath);
            InitializeComponent();
            InitializeBaseComponent(selector);
        }

        #endregion

        #region Business Layer

        protected override void DisplaySelectedGameObject(int selectorIndex)
        {
            var productionFacility = GameFile.ProductionFacilities[selectorIndex];
            bombardmentDefense.Value = productionFacility.BombardmentDefense;
            constructionCost.Value = productionFacility.ConstructionCost;
            encyclopediaName.Text = productionFacility.EncyclopediaName;
            familyId.Value = productionFacility.FamilyId;
            familyIdHexLabel.Text = "0x" + productionFacility.FamilyId.ToString("X");
            isAllianceUnit.Checked = productionFacility.IsAllianceUnit > 0U;
            isEmpireUnit.Checked = productionFacility.IsEmpireUnit > 0U;
            maintenanceCost.Value = productionFacility.MaintenanceCost;
            nextProductionFacility.Value = productionFacility.NextProductionFacility;
            this.productionFacility.Value = productionFacility.ProductionFacility;
            productionRate.Value = productionFacility.ProductionRate;
            researchDifficulty.Value = productionFacility.ResearchDifficulty;
            researchOrder.Value = productionFacility.ResearchOrder;
            textStraDllId.Value = productionFacility.TextStraDllId;
            unitId.Value = productionFacility.UnitId;
            unitIdHexLabel.Text = "0x" + productionFacility.UnitId.ToString("X");
            unknown2.Value = productionFacility.Unknown2;

            var edataId = 1 + selectorIndex;
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
        }

        #endregion

        #region Changed events

        private void bombardmentDefense_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].BombardmentDefense = (uint)bombardmentDefense.Value;
            GameFile.UnsavedData = true;
        }
        private void constructionCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].ConstructionCost = (uint)constructionCost.Value;
            GameFile.UnsavedData = true;
        }
        private void familyId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].FamilyId = (uint)familyId.Value;
            GameFile.UnsavedData = true;
        }
        private void isAllianceUnit_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].IsAllianceUnit = !isAllianceUnit.Checked ? 0U : 1U;
            GameFile.UnsavedData = true;
        }
        private void isEmpireUnit_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].IsEmpireUnit = !isEmpireUnit.Checked ? 0U : 1U;
            GameFile.UnsavedData = true;
        }
        private void maintenanceCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].MaintenanceCost = (uint)maintenanceCost.Value;
            GameFile.UnsavedData = true;
        }
        private void nextProductionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].NextProductionFacility = (uint)nextProductionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void productionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].ProductionFacility = (uint)productionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void productionRate_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].ProductionRate = (uint)productionRate.Value;
            GameFile.UnsavedData = true;
        }
        private void researchDifficulty_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].ResearchDifficulty = (uint)researchDifficulty.Value;
            GameFile.UnsavedData = true;
        }
        private void researchOrder_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].ResearchOrder = (uint)researchOrder.Value;
            GameFile.UnsavedData = true;
        }

        #endregion
    }
}
