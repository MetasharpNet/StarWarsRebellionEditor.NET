namespace SwRebellionEditor
{
    public partial class SectorsForm : SectorsDesignForm
    {
        #region .ctor

        public SectorsForm()
        {
            GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\SECTORSD.DAT";
            GameFile = DatFile.Load<SECTORSD>(GameFilePath);
            InitializeComponent();
            InitializeBaseComponent(selector);
        }

        #endregion

        #region Business Layer

        protected override void DisplaySelectedGameObject(int selectorIndex)
        {
            var previousUnsavedData = GameFile.UnsavedData;
            var sector = GameFile.Sectors[selectorIndex];
            encyclopediaName.Text = sector.EncyclopediaName;
            familyId.Value = sector.FamilyId;
            familyIdHexLabel.Text = "0x" + sector.FamilyId.ToString("X");
            galaxySize.Value = sector.GalaxySize;
            nextProductionFacility.Value = sector.NextProductionFacility;
            productionFacility.Value = sector.ProductionFacility;
            secImport.Value = sector.SecImport;
            sectorId.Value = sector.SectorId;
            sectorIdHexLabel.Text = "0x" + sector.SectorId.ToString("X");
            textStraDllId.Value = sector.TextStraDllId;
            unknown1.Value = sector.Field2_Unknown;
            unknown2.Value = sector.Field7_Unknown;
            xPosition.Value = sector.XPosition;
            yPosition.Value = sector.YPosition;
            GameFile.UnsavedData = previousUnsavedData;
        }

        #endregion

        #region Changed events

        private void familyId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Sectors[selector.Value].FamilyId = (uint)familyId.Value;
            GameFile.UnsavedData = true;
        }
        private void galaxySize_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Sectors[selector.Value].GalaxySize = (uint)galaxySize.Value;
            GameFile.UnsavedData = true;
        }
        private void nextProductionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Sectors[selector.Value].NextProductionFacility = (uint)nextProductionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void productionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Sectors[selector.Value].ProductionFacility = (uint)productionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void sectorId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Sectors[selector.Value].SectorId = (uint)sectorId.Value;
            GameFile.UnsavedData = true;
        }
        private void secImport_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Sectors[selector.Value].SecImport = (uint)secImport.Value;
            GameFile.UnsavedData = true;
        }
        private void textStraDllId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Sectors[selector.Value].TextStraDllId = (ushort)textStraDllId.Value;
            GameFile.UnsavedData = true;
        }
        private void unknown1_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Sectors[selector.Value].Field2_Unknown = (uint)unknown1.Value;
            GameFile.UnsavedData = true;
        }
        private void unknown2_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Sectors[selector.Value].Field7_Unknown = (ushort)unknown2.Value;
            GameFile.UnsavedData = true;
        }
        private void xPosition_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Sectors[selector.Value].XPosition = (ushort)xPosition.Value;
            GameFile.UnsavedData = true;
        }
        private void yPosition_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Sectors[selector.Value].YPosition = (ushort)yPosition.Value;
            GameFile.UnsavedData = true;
        }

        #endregion
    }
}
