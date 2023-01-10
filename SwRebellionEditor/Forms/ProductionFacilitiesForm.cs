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
            selector.Maximum = (int)GameFile.ProductionFacilitiesCount - 1;
        }

        #endregion

        #region Business Layer

        protected override void DisplaySelectedGameObject(int selectorIndex)
        {
            var previousUnsavedData = GameFile.UnsavedData;
            var productionFacility = GameFile.ProductionFacilities[selectorIndex];
            bombardmentDefense.Value = productionFacility.BombardmentDefense;
            encyclopediaDescription.Text = productionFacility.EncyclopediaDescription;
            familyId.Value = productionFacility.FamilyId;
            familyIdHexLabel.Text = "0x" + productionFacility.FamilyId.ToString("X");
            field2_1.Value = productionFacility.Field2_1;
            field7_2.Value = productionFacility.Field7_2;
            id.Value = productionFacility.Id;
            idHexLabel.Text = "0x" + productionFacility.Id.ToString("X");
            isAlliance.Checked = productionFacility.IsAlliance > 0U;
            isEmpire.Checked = productionFacility.IsEmpire > 0U;
            maintenanceCost.Value = productionFacility.MaintenanceCost;
            name.Text = productionFacility.Name;
            nextProductionFamily.Value = productionFacility.NextProductionFamily;
            this.productionFamily.Value = productionFacility.ProductionFamily;
            productionRate.Value = productionFacility.ProductionRate;
            refinedMaterialCost.Value = productionFacility.RefinedMaterialCost;
            researchDifficulty.Value = productionFacility.ResearchDifficulty;
            researchOrder.Value = productionFacility.ResearchOrder;
            textStraDllId.Value = productionFacility.TextStraDllId;

            var edataId = 1 + selectorIndex;
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
            GameFile.UnsavedData = previousUnsavedData;
        }
        protected override void LoadSideInfo()
        {
            foreach (var pf in GameFile.ProductionFacilities)
                pf.Name = TextStra.GetString(pf.TextStraDllId);
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
            GameFile.ProductionFacilities[selector.Value].BombardmentDefense = (uint)bombardmentDefense.Value;
            GameFile.UnsavedData = true;
        }
        private void encyclopediaDescription_TextChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].EncyclopediaDescription = encyclopediaDescription.Text;
            GameFile.UnsavedData = true;
        }
        private void familyId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].FamilyId = (uint)familyId.Value;
            GameFile.UnsavedData = true;
        }
        private void field2_1_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].Field2_1 = (uint)field2_1.Value;
            GameFile.UnsavedData = true;
        }
        private void field7_2_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].Field7_2 = (ushort)field7_2.Value;
            GameFile.UnsavedData = true;
        }
        private void id_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].Id = (uint)id.Value;
            GameFile.UnsavedData = true;
        }
        private void isAlliance_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].IsAlliance = !isAlliance.Checked ? 0U : 1U;
            GameFile.UnsavedData = true;
        }
        private void isEmpire_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].IsEmpire = !isEmpire.Checked ? 0U : 1U;
            GameFile.UnsavedData = true;
        }
        private void maintenanceCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].MaintenanceCost = (uint)maintenanceCost.Value;
            GameFile.UnsavedData = true;
        }
        private void name_TextChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].Name = name.Text;
            GameFile.UnsavedData = true;
        }
        private void nextProductionFamily_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].NextProductionFamily = (uint)nextProductionFamily.Value;
            GameFile.UnsavedData = true;
        }
        private void productionFamily_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].ProductionFamily = (uint)productionFamily.Value;
            GameFile.UnsavedData = true;
        }
        private void productionRate_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].ProductionRate = (uint)productionRate.Value;
            GameFile.UnsavedData = true;
        }
        private void refinedMaterialCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].RefinedMaterialCost = (uint)refinedMaterialCost.Value;
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
        private void textStraDllId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.ProductionFacilities[selector.Value].TextStraDllId = (ushort)textStraDllId.Value;
            GameFile.UnsavedData = true;
        }

        #endregion
    }
}
