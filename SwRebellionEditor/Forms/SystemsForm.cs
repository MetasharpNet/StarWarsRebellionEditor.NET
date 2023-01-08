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
                systemsListView.Items.Add(GameFile.Systems[selectorIndex].Name, selectorIndex);
            }
        }
        protected override void DisplaySelectedGameObject(int selectorIndex)
        {
            var previousUnsavedData = GameFile.UnsavedData;
            var system = GameFile.Systems[selectorIndex];
            name.Text = system.Name;
            familyId.Value = system.FamilyId;
            familyIdHexLabel.Text = "0x" + system.FamilyId.ToString("X");
            nextProductionFacility.Value = system.NextProductionFacility_0;
            pictureId.Value = system.PictureId;
            productionFacility.Value = system.ProductionFacility_0;
            sectorId.Value = system.SectorId;
            systemId.Value = system.Id;
            SystemIdHexLabel.Text = "0x" + system.Id.ToString("X");
            textStraDllId.Value = system.TextStraDllId;
            description.Text = system.EncyclopediaDescription;
            unknown1.Value = system.Field2_1;
            unknown2.Value = system.Field7_2;
            unknown3.Value = system.Field10_1;
            unknown4.Value = system.Field13_0;
            xPosition.Value = system.XPosition;
            yPosition.Value = system.YPosition;

            var sector = SectorsGameFile.Sectors[system.SectorId - 20U];
            sectorEncyclopediaName.Text = sector.Name;
            sectorFamilyId.Value = sector.FamilyId;
            sectorFamilyIdHexLabel.Text = "0x" + sector.FamilyId.ToString("X");
            sectorGalaxySize.Value = sector.GalaxySize;
            sectorSecImport.Value = sector.SecImport;
            sectorTextStraDllId.Value = sector.TextStraDllId;
            sectorXPosition.Value = sector.XPosition;
            sectorYPosition.Value = sector.YPosition;
            
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            var edataId = 165 + system.PictureId;
            picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
            GameFile.UnsavedData = previousUnsavedData;
        }
        protected override void LoadSideInfo()
        {
            foreach (var s in GameFile.Systems)
            {
                s.Name = TextStra.GetString(s.TextStraDllId);
            }
        }
        protected override void SaveSideInfo()
        {
            TextStra.SaveString(Convert.ToUInt16(textStraDllId.Value), name.Text);
            //EncyText.SaveString(Convert.ToUInt16(xxx.Value), name.Text);
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
        private void name_TextChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].Name = name.Text;
            GameFile.UnsavedData = true;
        }
        private void nextProductionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].NextProductionFacility_0 = (uint)nextProductionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void pictureId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].PictureId = (uint)pictureId.Value;
            GameFile.UnsavedData = true;
        }
        private void productionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].ProductionFacility_0 = (uint)productionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void sectorId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].SectorId = (uint)sectorId.Value;
            GameFile.UnsavedData = true;
        }
        private void systemId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].Id = (uint)systemId.Value;
            GameFile.UnsavedData = true;
        }
        private void textStraDllId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].TextStraDllId = (ushort)textStraDllId.Value;
            GameFile.UnsavedData = true;
        }
        private void unknown1_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].Field2_1 = (uint)unknown1.Value;
            GameFile.UnsavedData = true;
        }
        private void unknown2_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].Field7_2 = (ushort)unknown2.Value;
            GameFile.UnsavedData = true;
        }
        private void unknown3_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].Field10_1 = (uint)unknown3.Value;
            GameFile.UnsavedData = true;
        }
        private void unknown4_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].Field13_0 = (uint)unknown4.Value;
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
