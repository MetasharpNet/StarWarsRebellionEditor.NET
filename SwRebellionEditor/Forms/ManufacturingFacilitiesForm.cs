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
            selector.Maximum = (int)GameFile.ManufacturingFacilitiesCount - 1;
        }

        #endregion

        #region Business Layer

        protected override void DisplaySelectedGameObject(int selectorIndex)
        {
            var previousUnsavedData = GameFile.UnsavedData;
            var manufacturingFacility = GameFile.ManufacturingFacilities[selectorIndex];
            bombardmentDefense.Value = manufacturingFacility.BombardmentDefense;
            encyclopediaDescription.Text = manufacturingFacility.EncyclopediaDescription;
            familyId.Value = manufacturingFacility.FamilyId;
            familyIdHexLabel.Text = "0x" + manufacturingFacility.FamilyId.ToString("X");
            field2_1.Value = manufacturingFacility.Field2_1;
            field7_2.Value = manufacturingFacility.Field7_2;
            id.Value = manufacturingFacility.Id;
            idHexLabel.Text = "0x" + manufacturingFacility.Id.ToString("X");
            isAlliance.Checked = manufacturingFacility.IsAlliance > 0U;
            isEmpire.Checked = manufacturingFacility.IsEmpire > 0U;
            maintenanceCost.Value = manufacturingFacility.MaintenanceCost;
            name.Text = manufacturingFacility.Name;
            nextProductionFamily.Value = manufacturingFacility.NextProductionFamily;
            productionFamily.Value = manufacturingFacility.ProductionFamily;
            processingRate.Value = manufacturingFacility.ProcessingRate;
            refinedMaterialCost.Value = manufacturingFacility.RefinedMaterialCost;
            researchDifficulty.Value = manufacturingFacility.ResearchDifficulty;
            researchOrder.Value = manufacturingFacility.ResearchOrder;
            textStraDllId.Value = manufacturingFacility.TextStraDllId;

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
        protected override void SaveSideInfo()
        {
            TextStra.SaveString(Convert.ToUInt16(textStraDllId.Value), name.Text);
            //EncyText.SaveString(Convert.ToUInt16(xxx.Value), name.Text);
        }

        #endregion

        #region Changed events

        private void bombardmentDefense_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].BombardmentDefense = (uint)bombardmentDefense.Value;
            GameFile.UnsavedData = true;
        }
        private void encyclopediaText_TextChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].EncyclopediaDescription = encyclopediaDescription.Text;
            GameFile.UnsavedData = true;
        }
        private void familyId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].FamilyId = (uint)familyId.Value;
            GameFile.UnsavedData = true;
        }
        private void field2_1_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].Field2_1 = (uint)field2_1.Value;
            GameFile.UnsavedData = true;
        }
        private void field7_2_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].Field7_2 = (ushort)field7_2.Value;
            GameFile.UnsavedData = true;
        }
        private void id_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].Id = (uint)id.Value;
            GameFile.UnsavedData = true;
        }
        private void isAlliance_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].IsAlliance = isAlliance.Checked ? 1U : 0U;
            GameFile.UnsavedData = true;
        }
        private void isEmpire_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].IsEmpire = isEmpire.Checked ? 1U : 0U;
            GameFile.UnsavedData = true;
        }
        private void maintenanceCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].MaintenanceCost = (uint)maintenanceCost.Value;
            GameFile.UnsavedData = true;
        }
        private void name_TextChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].Name = name.Text;
            GameFile.UnsavedData = true;
        }
        private void nextProductionFamily_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].NextProductionFamily = (uint)nextProductionFamily.Value;
            GameFile.UnsavedData = true;
        }
        private void productionFamily_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].ProductionFamily = (uint)productionFamily.Value;
            GameFile.UnsavedData = true;
        }
        private void processingRate_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].ProcessingRate = (uint)processingRate.Value;
            GameFile.UnsavedData = true;
        }
        private void refinedMaterialCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].RefinedMaterialCost = (uint)refinedMaterialCost.Value;
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
        private void textStraDllId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ManufacturingFacilities[selector.Value].TextStraDllId = (ushort)textStraDllId.Value;
            GameFile.UnsavedData = true;
        }

        #endregion
    }
}
