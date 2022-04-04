namespace SwRebellionEditor
{
    /// <summary>
    /// When derivating this class:
    /// - create an intermediate classe with an empty parameterless constructor that you will inherit with your final form class (else design won't work)
    /// - override void DisplaySelectedGameObject(int selectorIndex)
    /// - Create a TrackBar object (named selector in code below) in WinForms designer in your Form, then assign to ValueChanged event : GameObjectsSelector_ValueChanged
    /// - In the constructor call in this order :
    ///         GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\YOURDATFILE.DAT";
    ///         GameFile = DatFile.Load<YOURDATFILECLASS>(GameFilePath);
    ///         InitializeComponent();
    ///         InitializeBaseComponent(selector);
    /// - Assign provided events to your form : GameObjectsListForm_FormClosing, GameObjectsListForm_KeyDown, GameObjectsListForm_Load
    /// - Assign provided events to your controls : Cancel_Click, Ok_Click, Open_Click, SaveAs_Click
    /// </summary>
    public abstract class GameObjectsListForm<TDatFile> : Form
        where TDatFile : DatFile, new()
    {
        public TDatFile GameFile;
        public string GameFilePath;
        protected TrackBar TrackBarSelector;

        #region Business Layer

        protected virtual void DisplayGameItemsImages()
        {
        }
        protected virtual void DisplaySelectedGameObject(int selectorIndex = -1)
        {
        }
        protected virtual void LoadSideInfo()
        {
        }
        protected void InitializeBaseComponent(TrackBar selector)
        {
            TrackBarSelector = selector;
        }
        protected void OpenSpecificGameFile()
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            GameFilePath = openFileDialog.FileName;
            GameFile = DatFile.Load<TDatFile>(GameFilePath);
            LoadSideInfo();
            GameFile.UnsavedData = false;
        }

        #endregion

        #region Form events

        protected void GameObjectsListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (RegistryKeys.PlaySounds)
                Sound.Play(Resources.close_wav);
            if (!RegistryKeys.PlayMusic)
                return;
            Sound.PlayRandomMusic();
        }
        protected void GameObjectsListForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (TrackBarSelector == null)
                return;
            if (e.KeyCode == Keys.F4)
            {
                if (e.Shift)
                {
                    if (TrackBarSelector.Value - TrackBarSelector.LargeChange > TrackBarSelector.Minimum)
                        TrackBarSelector.Value -= TrackBarSelector.LargeChange;
                    else
                        TrackBarSelector.Value = TrackBarSelector.Minimum;
                }
                else
                {
                    if (TrackBarSelector.Value <= TrackBarSelector.Minimum)
                        return;
                    --TrackBarSelector.Value;
                }
            }
            else
            {
                if (e.KeyCode != Keys.F3)
                    return;
                if (e.Shift)
                {
                    if (TrackBarSelector.Value + TrackBarSelector.LargeChange < TrackBarSelector.Maximum)
                        TrackBarSelector.Value += TrackBarSelector.LargeChange;
                    else
                        TrackBarSelector.Value = TrackBarSelector.Maximum;
                }
                else
                {
                    if (TrackBarSelector.Value >= TrackBarSelector.Maximum)
                        return;
                    ++TrackBarSelector.Value;
                }
            }
        }
        protected void GameObjectsListForm_Load(object sender, EventArgs e)
        {
            if (RegistryKeys.PlaySounds)
                Sound.Play(Resources.open_wav);
            if (RegistryKeys.PlayMusic)
                Sound.PlayRandomMusic();
            LoadSideInfo();
            if (TrackBarSelector != null)
                DisplaySelectedGameObject(TrackBarSelector.Value);
            else
                DisplaySelectedGameObject(-1);
            DisplayGameItemsImages();
            if (TrackBarSelector != null)
                TrackBarSelector.Select();
        }

        #endregion

        #region Controls events

        protected void Cancel_Click(object sender, EventArgs e)
        {
            if (GameFile.UnsavedData && MessageBox.Show(this, "Unsaved data, are you sure you want to Close this Dialog?", "Save data", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            Close();
        }
        protected void Ok_Click(object sender, EventArgs e)
        {
            if (GameFile.UnsavedData)
            {
                GameFile.Save(GameFilePath);
                GameFile.UnsavedData = false;
            }
            Close();
        }
        protected void Open_Click(object sender, EventArgs e)
        {
            if (GameFile.UnsavedData && MessageBox.Show(this, "Save file before opening a new one?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GameFile.Save(GameFilePath);
                GameFile.UnsavedData = false;
            }
            OpenSpecificGameFile();
            if (TrackBarSelector != null)
                DisplaySelectedGameObject(TrackBarSelector.Value);
            else
                DisplaySelectedGameObject(-1);
            DisplayGameItemsImages();
            if (TrackBarSelector != null)
                TrackBarSelector.Select();
        }
        protected void SaveAs_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = RegistryKeys.InstalledLocation + "\\GData";
            saveFileDialog.Filter = "Data Files (*.dat)| *.dat";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                GameFile.Save(saveFileDialog.FileName);
                GameFile.UnsavedData = false;
                int num = (int)MessageBox.Show(this, "File saved", "", MessageBoxButtons.OK);
            }
            TrackBarSelector.Focus();
        }

        #endregion

        #region Changed events

        protected void GameObjectsSelector_ValueChanged(object sender, EventArgs e)
        {
            if (TrackBarSelector != null)
                DisplaySelectedGameObject(TrackBarSelector.Value);
            else
                DisplaySelectedGameObject(-1);
        }

        #endregion
    }
}
