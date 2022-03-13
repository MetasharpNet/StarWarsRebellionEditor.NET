namespace SwRebellionEditor
{
    public partial class SystemsForm : SystemsDesignForm
    {
        #region .ctor

        public SystemsForm()
        {
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
            unknown3.Value = system.Unknown2;
            unknown4.Value = system.Unknown4;
            unknown5.Value = system.Unknown3;
            xPosition.Value = system.XPosition;
            yPosition.Value = system.YPosition;

            /*
            sectorName.Text = "Sector(" + SECTORSD.Sectors[system.SectorId - 20U].swrName + ")";
            secNameLabel.Text = SECTORSD.Sectors[system.SectorId - 20U].swrName;
            sectorImport.Value = SECTORSD.Sectors[system.SectorId - 20U].secImport;
            galSize.Value = SECTORSD.Sectors[system.SectorId - 20U].galSize;
            sectorXpos.Value = SECTORSD.Sectors[system.SectorId - 20U].yPos;
            sectorYpos.Value = SECTORSD.Sectors[system.SectorId - 20U].xPos;
            sectorProductionFacility.Value = SECTORSD.Sectors[system.SectorId - 20U].prodFacilityNum;
            sectorNextProductionFacility.Value = SECTORSD.Sectors[system.SectorId - 20U].unknown2;
            sectorFamilyId.Value = SECTORSD.Sectors[system.SectorId - 20U].familyNum;
            sectorUnknown3.Value = SECTORSD.Sectors[system.SectorId - 20U].unknown3;
            sectorTextStraDllId.Value = SECTORSD.Sectors[system.SectorId - 20U].textstratNum;
            secfamHexLabel.Text = SECTORSD.Sectors[system.SectorId - 20U].familyNum.ToString("X");
            sectorSectorId.Value = SECTORSD.Sectors[system.SectorId - 20U].number;
            secUnitHexLabel.Text = SECTORSD.Sectors[system.SectorId - 20U].number.ToString("X");
            */
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            var edataId = 165 + system.PictureId;
            picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
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

        #endregion
    }
}
