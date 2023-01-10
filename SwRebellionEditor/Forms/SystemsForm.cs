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
            selector.Maximum = (int)GameFile.SystemsCount - 1;
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
            encyclopediaDescription.Text = system.EncyclopediaDescription;
            familyId.Value = system.FamilyId;
            familyIdHexLabel.Text = "0x" + system.FamilyId.ToString("X");
            field2_1.Value = system.Field2_1;
            field7_2.Value = system.Field7_2;
            field10_1.Value = system.Field10_1;
            field13_0.Value = system.Field13_0;
            id.Value = system.Id;
            idHexLabel.Text = "0x" + system.Id.ToString("X");
            name.Text = system.Name;
            nextProductionFamily_0.Value = system.NextProductionFamily_0;
            pictureId.Value = system.PictureId;
            productionFamily_0.Value = system.ProductionFamily_0;
            sectorId.Value = system.SectorId;
            textStraDllId.Value = system.TextStraDllId;
            xPosition.Value = system.XPosition;
            yPosition.Value = system.YPosition;
            LoadSector(system.SectorId);

            picture.SizeMode = PictureBoxSizeMode.Zoom;
            var edataId = 165 + system.PictureId;
            picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
            GameFile.UnsavedData = previousUnsavedData;
        }
        private void LoadSector(uint sectorId)
        {
            var sector = SectorsGameFile.Sectors[sectorId - 20U];
            sectorName.Text = TextStra.GetString(sector.TextStraDllId);
            sectorFamilyId.Value = sector.FamilyId;
            sectorFamilyIdHexLabel.Text = "0x" + sector.FamilyId.ToString("X");
            sectorGalaxySize.Value = sector.GalaxySize;
            sectorSecImport.Value = sector.SecImport;
            sectorTextStraDllId.Value = sector.TextStraDllId;
            sectorXPosition.Value = sector.XPosition;
            sectorYPosition.Value = sector.YPosition;
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

        private void encyclopediaDescription_TextChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].EncyclopediaDescription = encyclopediaDescription.Text;
            GameFile.UnsavedData = true;
        }
        private void familyId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].FamilyId = (uint)familyId.Value;
            GameFile.UnsavedData = true;
        }
        private void field2_1_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].Field2_1 = (uint)field2_1.Value;
            GameFile.UnsavedData = true;
        }
        private void field7_2_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].Field7_2 = (ushort)field7_2.Value;
            GameFile.UnsavedData = true;
        }
        private void field10_1_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].Field10_1 = (uint)field10_1.Value;
            GameFile.UnsavedData = true;
        }
        private void field13_0_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].Field13_0 = (uint)field13_0.Value;
            GameFile.UnsavedData = true;
        }
        private void id_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].Id = (uint)id.Value;
            GameFile.UnsavedData = true;
        }
        private void name_TextChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].Name = name.Text;
            GameFile.UnsavedData = true;
        }
        private void nextProductionFamily_0_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].NextProductionFamily_0 = (uint)nextProductionFamily_0.Value;
            GameFile.UnsavedData = true;
        }
        private void pictureId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].PictureId = (uint)pictureId.Value;
            GameFile.UnsavedData = true;
        }
        private void productionFamily_0_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].ProductionFamily_0 = (uint)productionFamily_0.Value;
            GameFile.UnsavedData = true;
        }
        private void sectorId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].SectorId = (uint)sectorId.Value;
            LoadSector(GameFile.Systems[selector.Value].SectorId);
            GameFile.UnsavedData = true;
        }
        private void textStraDllId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Systems[selector.Value].TextStraDllId = (ushort)textStraDllId.Value;
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
