namespace SwRebellionEditor
{
    public partial class SystemsForm : SystemsDesignForm
    {
        #region .ctor

        private SECTORSD SectorsGameFile;

        public SystemsForm()
        {
            SectorsGameFile = DatFile.Load<SECTORSD>(RegistryKeys.InstalledLocation + "\\GData\\SECTORSD.DAT");
            GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\SYSTEMSD.DAT";
            GameFile = DatFile.Load<SYSTEMSD>(GameFilePath);
            InitializeComponent();
            InitializeBaseComponent(selector);
        }

        #endregion

        #region Business Layer

        protected override void DisplayGameItemsImages()
        {
            systemsListView.Sorting = SortOrder.None;
            systemsImageList.Images.Clear();
            for (int selectorIndex = 0; selectorIndex < GameFile.SystemsCount; ++selectorIndex)
            {
                var edataId = 165 + GameFile.Systems[selectorIndex].PictureId;
                systemsImageList.Images.Add(Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000")));
                systemsListView.Items.Add(GameFile.Systems[selectorIndex].EncyclopediaName, selectorIndex);
            }
        }
        protected override void DisplaySelectedGameObject(int selectorIndex)
        {
            var previousUnsavedData = GameFile.UnsavedData;
            var system = GameFile.Systems[selectorIndex];
            encyclopediaName.Text = system.EncyclopediaName;
            familyId.Value = system.FamilyId;
            familyIdHexLabel.Text = "0x" + system.FamilyId.ToString("X");
            nextProductionFacility.Value = system.NextProductionFacility;
            pictureId.Value = system.PictureId;
            productionFacility.Value = system.ProductionFacility;
            sectorId.Value = system.SectorId;
            systemId.Value = system.SystemId;
            SystemIdHexLabel.Text = "0x" + system.SystemId.ToString("X");
            textStraDllId.Value = system.TextStraDllId;
            unknown1.Value = system.Unknown1;
            unknown2.Value = system.Unknown2;
            unknown3.Value = system.Unknown3;
            unknown4.Value = system.Unknown4;
            xPosition.Value = system.XPosition;
            yPosition.Value = system.YPosition;

            var sector = SectorsGameFile.Sectors[system.SectorId - 20U];
            sectorEncyclopediaName.Text = sector.EncyclopediaName;
            sectorFamilyId.Value = sector.FamilyId;
            sectorFamilyIdHexLabel.Text = "0x" + sector.FamilyId.ToString("X");
            sectorGalaxySize.Value = sector.GalaxySize;
            sectorSecImport.Value = sector.SecImport;
            sectorTextStraDllId.Value = sector.TextStraDllId;
            sectorXPosition.Value = sector.YPosition;
            sectorYPosition.Value = sector.XPosition;
            
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            var edataId = 165 + system.PictureId;
            picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
            GameFile.UnsavedData = previousUnsavedData;
        }

        #endregion

        #region Control events

        private void picture_Click(object sender, EventArgs e)
        {
            if (systemsListView.Items.Count > selector.Value + 1 && selector.Value - 1 >= 0)
            {
                systemsListView.Items[selector.Value + 1].EnsureVisible();
                systemsListView.Items[selector.Value - 1].EnsureVisible();
            }
            else
                systemsListView.Items[selector.Value].EnsureVisible();
            selector.Select();
        }
        private void systemsListView_DoubleClick(object sender, EventArgs e)
        {
            selector.Value = systemsListView.Items.IndexOf(systemsListView.FocusedItem);
            DisplaySelectedGameObject(selector.Value);
            selector.Select();
        }
        private void systemsListView_Click(object sender, EventArgs e)
        {
            selector.Value = systemsListView.Items.IndexOf(systemsListView.FocusedItem);
            DisplaySelectedGameObject(selector.Value);
            selector.Select();
        }

        #endregion

        #region Changed events

        private void familyId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].FamilyId = (uint)familyId.Value;
            GameFile.UnsavedData = true;
        }
        private void nextProductionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].NextProductionFacility = (uint)nextProductionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void pictureId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].PictureId = (uint)pictureId.Value;
            GameFile.UnsavedData = true;
        }
        private void productionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].ProductionFacility = (uint)productionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void sectorId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].SectorId = (uint)sectorId.Value;
            GameFile.UnsavedData = true;
        }
        private void systemId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].SystemId = (uint)systemId.Value;
            GameFile.UnsavedData = true;
        }
        private void textStraDllId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].TextStraDllId = (ushort)textStraDllId.Value;
            GameFile.UnsavedData = true;
        }
        private void unknown1_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].Unknown1 = (uint)unknown1.Value;
            GameFile.UnsavedData = true;
        }
        private void unknown2_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].Unknown2 = (ushort)unknown2.Value;
            GameFile.UnsavedData = true;
        }
        private void unknown3_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].Unknown3 = (uint)unknown3.Value;
            GameFile.UnsavedData = true;
        }
        private void unknown4_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].Unknown4 = (uint)unknown4.Value;
            GameFile.UnsavedData = true;
        }
        private void xPosition_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].XPosition = (ushort)xPosition.Value;
            GameFile.UnsavedData = true;
        }
        private void yPosition_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].YPosition = (ushort)yPosition.Value;
            GameFile.UnsavedData = true;
        }

        #endregion
    }
}
