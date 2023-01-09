namespace SwRebellionEditor
{
    public partial class TroopsForm : TroopsDesignForm
    {
        #region .ctor

        public TroopsForm()
        {
            GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\TROOPSD.DAT";
            GameFile = DatFile.Load<TROOPSD>(GameFilePath);
            InitializeComponent();
            InitializeBaseComponent(selector);
        }

        #endregion

        #region Business Layer

        protected override void DisplaySelectedGameObject(int selectorIndex)
        {
            var previousUnsavedData = GameFile.UnsavedData;
            var troop = GameFile.Troops[selectorIndex];
            atttackRating.Value = troop.AttackStrength;
            bombardmentRating.Value = troop.BombardmentDefense;
            constructionCost.Value = troop.RefinedMaterialCost;
            defenseRating.Value = troop.DefenseStrength;
            name.Text = troop.Name;
            familyIdHexLabel.Text = "0x" + troop.FamilyId.ToString("X");
            isAllianceUnit.Checked = troop.IsAlliance > 0U;
            isEmpireUnit.Checked = troop.IsEmpire > 0U;
            maintenanceCost.Value = troop.MaintenanceCost;
            nextProductionFamily.Value = troop.NextProductionFamily;
            productionFamily.Value = troop.ProductionFamily;
            researchDifficulty.Value = troop.ResearchDifficulty;
            researchOrder.Value = troop.ResearchOrder;
            textStraDllId.Value = troop.TextStraDllId;
            troopId.Value = troop.Id;
            troopIdHexLabel.Text = "0x" + troop.Id.ToString("X");
            unknwown2.Value = troop.Field7_2;
            unknownMoralHp.Value = troop.UnknownMoralHp;

            picture.SizeMode = PictureBoxSizeMode.Zoom;
            var edataId = 15 + selectorIndex;
            picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
            GameFile.UnsavedData = previousUnsavedData;
        }
        protected override void LoadSideInfo()
        {
            foreach (var t in GameFile.Troops)
                t.Name = TextStra.GetString(t.TextStraDllId);
        }

        #endregion

        #region Changed events

        private void atttackRating_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Troops[selector.Value].AttackStrength = (uint)atttackRating.Value;
            GameFile.UnsavedData = true;
        }
        private void bombardmentRating_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Troops[selector.Value].BombardmentDefense = (uint)bombardmentRating.Value;
            GameFile.UnsavedData = true;
        }
        private void constructionCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Troops[selector.Value].RefinedMaterialCost = (uint)constructionCost.Value;
            GameFile.UnsavedData = true;
        }
        private void defenseRating_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Troops[selector.Value].DefenseStrength = (uint)defenseRating.Value;
            GameFile.UnsavedData = true;
        }
        private void detectionRating_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Troops[selector.Value].DetectionRating = (uint)detectionRating.Value;
            GameFile.UnsavedData = true;
        }
        private void familyId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Troops[selector.Value].FamilyId = (uint)familyId.Value;
            GameFile.UnsavedData = true;
        }
        private void isAllianceUnit_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.Troops[selector.Value].IsAlliance = !isAllianceUnit.Checked ? 0U : 1U;
            GameFile.UnsavedData = true;
        }
        private void isEmpireUnit_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.Troops[selector.Value].IsEmpire = !isEmpireUnit.Checked ? 0U : 1U;
            GameFile.UnsavedData = true;
        }
        private void maintenanceCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Troops[selector.Value].MaintenanceCost = (uint)maintenanceCost.Value;
            GameFile.UnsavedData = true;
        }
        private void nextProductionFamily_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Troops[selector.Value].NextProductionFamily = (uint)nextProductionFamily.Value;
            GameFile.UnsavedData = true;
        }
        private void productionFamily_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Troops[selector.Value].ProductionFamily = (uint)productionFamily.Value;
            GameFile.UnsavedData = true;
        }
        private void researchDifficulty_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Troops[selector.Value].ResearchDifficulty = (uint)researchDifficulty.Value;
            GameFile.UnsavedData = true;
        }
        private void researchOrder_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Troops[selector.Value].ResearchOrder = (uint)researchOrder.Value;
            GameFile.UnsavedData = true;
        }
        private void unknownMoralHp_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Troops[selector.Value].UnknownMoralHp = (uint)unknownMoralHp.Value;
            GameFile.UnsavedData = true;
        }

        #endregion
    }
}
