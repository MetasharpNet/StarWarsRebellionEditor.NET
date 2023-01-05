namespace SwRebellionEditor
{
    public partial class ManufacturingFacilitiesForm : ManufacturingFacilitiesDesignForm
    {
        #region .ctor

        public ManufacturingFacilitiesForm()
        {
            GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\MANFACSD.DAT";
            GameFile = DatFile.Load<MANFACSD>(GameFilePath);
            InitializeComponent();
            InitializeBaseComponent(selector);
        }

        #endregion

        #region Business Layer

        protected override void DisplaySelectedGameObject(int selectorIndex)
        {
            var previousUnsavedData = GameFile.UnsavedData;
            var manufacturingFacility = GameFile.ManufacturingFacilities[selectorIndex];
            bombardmentDefense.Value = manufacturingFacility.BombardmentDefense;
            constructionCost.Value = manufacturingFacility.RefinedMaterialCost;
            name.Text = manufacturingFacility.Name;
            familyId.Value = manufacturingFacility.FamilyId;
            familyIdHexLabel.Text = "0x" + manufacturingFacility.FamilyId.ToString("X");
            isAllianceUnit.Checked = manufacturingFacility.IsAllianceUnit > 0U;
            isEmpireUnit.Checked = manufacturingFacility.IsEmpireUnit > 0U;
            maintenanceCost.Value = manufacturingFacility.MaintenanceCost;
            nextProductionFacility.Value = manufacturingFacility.NextProductionFacility;
            productionFacility.Value = manufacturingFacility.ProductionFacility;
            productionRate.Value = manufacturingFacility.ProductionRate;
            researchDifficulty.Value = manufacturingFacility.ResearchDifficulty;
            researchOrder.Value = manufacturingFacility.ResearchOrder;
            textStraDllId.Value = manufacturingFacility.TextStraDllId;
            unitId.Value = manufacturingFacility.UnitId;
            unitIdHexLabel.Text = "0x" + manufacturingFacility.UnitId.ToString("X");
            unknown2.Value = manufacturingFacility.Field7_Unknown;

            var edataId = 3 + selectorIndex;
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
            GameFile.UnsavedData = previousUnsavedData;
        }
        protected override void LoadSideInfo()
        {
            foreach (var mf in GameFile.ManufacturingFacilities)
                mf.Name = TextStra.GetString(mf.TextStraDllId);
        }

        #endregion

        #region Changed events

        private void bombardmentDefense_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].BombardmentDefense = (uint)bombardmentDefense.Value;
            GameFile.UnsavedData = true;
        }
        private void constructionCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].RefinedMaterialCost = (uint)constructionCost.Value;
            GameFile.UnsavedData = true;
        }
        private void familyId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].FamilyId = (uint)familyId.Value;
            GameFile.UnsavedData = true;
        }
        private void isEmpireUnit_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].IsEmpireUnit = isEmpireUnit.Checked ? 1U : 0U;
            GameFile.UnsavedData = true;
        }
        private void isAllianceUnit_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].IsAllianceUnit = isAllianceUnit.Checked ? 1U : 0U;
            GameFile.UnsavedData = true;
        }
        private void maintenanceCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].MaintenanceCost = (uint)maintenanceCost.Value;
            GameFile.UnsavedData = true;
        }
        private void nextProductionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].NextProductionFacility = (uint)nextProductionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void productionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].ProductionFacility = (uint)productionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void productionRate_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].ProductionRate = (uint)productionRate.Value;
            GameFile.UnsavedData = true;
        }
        private void researchDifficulty_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].ResearchDifficulty = (uint)researchDifficulty.Value;
            GameFile.UnsavedData = true;
        }
        private void researchOrder_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].ResearchOrder = (uint)researchOrder.Value;
            GameFile.UnsavedData = true;
        }

        #endregion
    }
}
