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
            var previousUnsavedData = GameFile.UnsavedData;
            var defenseFacility = GameFile.DefenseFacilities[selectorIndex];
            attackStrength.Value = defenseFacility.AttackStrength;
            bombardmentDefense.Value = defenseFacility.BombardmentDefense;
            familyId.Value = defenseFacility.FamilyId;
            familyIdHexLabel.Text = "0x" + defenseFacility.FamilyId.ToString("X");
            field2_Unknown.Value = defenseFacility.Field2_Unknown;
            field7_Unknown.Value = defenseFacility.Field7_Unknown;
            id.Value = defenseFacility.Id;
            idHexLabel.Text = "0x" + defenseFacility.Id.ToString("X");
            isAllianceUnit.Checked = defenseFacility.IsAllianceUnit > 0U;
            isEmpireUnit.Checked = defenseFacility.IsEmpireUnit > 0U;
            maintenanceCost.Value = defenseFacility.MaintenanceCost;
            name.Text = defenseFacility.Name;
            nextProductionFacility.Value = defenseFacility.NextProductionFacility;
            productionFacility.Value = defenseFacility.ProductionFacility;
            refinedMaterialCost.Value = defenseFacility.RefinedMaterialCost;
            researchDifficulty.Value = defenseFacility.ResearchDifficulty;
            researchOrder.Value = defenseFacility.ResearchOrder;
            shieldStrength.Value = defenseFacility.ShieldStrength;
            textStraDllId.Value = defenseFacility.TextStraDllId;

            picture.SizeMode = PictureBoxSizeMode.Zoom;
            var edataId = 9 + selectorIndex;
            if (edataId == 12)
                edataId = 14;
            else if (edataId > 12)
                --edataId;
            picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
            GameFile.UnsavedData = previousUnsavedData;
        }
        protected override void LoadSideInfo()
        {
            foreach (var df in GameFile.DefenseFacilities)
                df.Name = TextStra.GetString(df.TextStraDllId);
        }
        protected override void SaveSideInfo()
        {
            TextStra.SaveString(Convert.ToUInt16(textStraDllId.Value), name.Text);
            //EncyText.SaveString(Convert.ToUInt16(xxx.Value), name.Text);
        }

        #endregion

        #region Changed events

        private void attackStrength_ValueChanged(object sender, EventArgs e)
        {
            GameFile.DefenseFacilities[selector.Value].AttackStrength = (uint)attackStrength.Value;
            GameFile.UnsavedData = true;
        }
        private void bombardmentDefense_ValueChanged(object sender, EventArgs e)
        {
            GameFile.DefenseFacilities[selector.Value].BombardmentDefense = (uint)bombardmentDefense.Value;
            GameFile.UnsavedData = true;
        }
        private void familyId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.DefenseFacilities[selector.Value].FamilyId = (uint)familyId.Value;
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
        private void name_TextChanged(object sender, EventArgs e)
        {
            GameFile.DefenseFacilities[selector.Value].Name = name.Text;
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
        private void refinedMaterialCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.DefenseFacilities[selector.Value].RefinedMaterialCost = (uint)refinedMaterialCost.Value;
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
        private void shieldStrength_ValueChanged(object sender, EventArgs e)
        {
            GameFile.DefenseFacilities[selector.Value].ShieldStrength = (uint)shieldStrength.Value;
            GameFile.UnsavedData = true;
        }

        #endregion
    }
}
