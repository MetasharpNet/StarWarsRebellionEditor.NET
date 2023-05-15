namespace SwRebellionEditor;

public partial class MainForm : Form
{
    #region Business Layer

    private void LoadSettings()
    {
        Size = Settings.Current.BackgroundSize;
        Location = Settings.Current.MainWindowTopLeftCornerPosition;
        if (Settings.Current.PlayMusic)
            PlayMusic_ToolStripMenuItem.Checked = true;
        else
            PlayMusic_ToolStripMenuItem.Checked = false;
        if (Settings.Current.PlaySounds)
            PlaySounds_ToolStripMenuItem.Checked = true;
        else
            PlaySounds_ToolStripMenuItem.Checked = false;
        if (!Settings.Current.IsFirstStartup)
            return;
        Settings.Current.IsFirstStartup = false;
        Settings.Current.Serialize();
    }

    private void OpenFile(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Title = "Please select the folder where your Star Wars Rebellion game is installed.";
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        if (openFileDialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        string fileName = openFileDialog.FileName;
    }

    private void Show<TForm>()
        where TForm : Form, new()
    {
        var f = new TForm();
        f.MdiParent = this;
        f.Show();
    }

    public static void updateFighterDataStatus()
    {
        //fighterDataChanged = FIGHTSD.unsavedData;
    }

    #endregion

    #region .ctor

    public MainForm()
    {
        InitializeComponent();
        Text = "Star Wars Rebellion Editor .NET " + GetType().Assembly.GetName().Version.ToString() + " final";
    }

    #endregion

    #region Form events

    private void MainForm_Load(object sender, EventArgs e)
    {
        LoadSettings();
        if (Settings.Current.PlaySounds)
            Sound.Play(Resources.droid_ding_wav);

        if (Settings.Current.PlayMusic)
            Sound.PlayRandomMusic();

        roopDataStatus.Text = "";
        majorCharDataStatus.Text = "";
        minorCharDataStatus.Text = "";
        specOpDataStatus.Text = "";
        CapShipDataStatus.Text = "";
        fighterDataStatus.Text = "";
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (WindowState == FormWindowState.Minimized)
            WindowState = FormWindowState.Normal;

        Settings.Current.BackgroundSize = Size;
        Settings.Current.MainWindowTopLeftCornerPosition = Location;
        Settings.Current.Serialize();
        Sound.StopMusic();

        if (Settings.Current.PlaySounds)
            Sound.Play(Resources.door_opening_wav);
    }

    private void MainForm_KeyDown(object sender, KeyEventArgs keyEventArgs)
    {
        if (keyEventArgs.Alt)
        {
            if (keyEventArgs.Shift && keyEventArgs.KeyCode == Keys.F11)
                Sound.Play(Resources.these_guys_just_dont_know_when_to_quit_wav);
            if (keyEventArgs.Control)
            {
                if (keyEventArgs.KeyCode == Keys.F6)
                    Sound.Play(Resources.there_is_a_trauma_in_the_force_wav);
                if (keyEventArgs.Shift && keyEventArgs.KeyCode == Keys.F6)
                    Sound.Play(Resources.you_failed_your_highness_i_am_a_jedi_wav);
            }
            if (keyEventArgs.KeyCode != Keys.F6)
                return;
            Sound.Play(Resources.you_like_your_father_are_now_mine_wav);
        }
        else if (keyEventArgs.Control)
        {
            if (!keyEventArgs.Shift)
                return;
            if (keyEventArgs.KeyCode == Keys.F11)
                Sound.Play(Resources.look_jabba_i_was_on_my_way_to_pay_you_back_wav);
            if (keyEventArgs.KeyCode != Keys.F6)
                return;

            Sound.Play(Resources.the_force_is_with_you_young_skywalker_wav);
        }
        else if (keyEventArgs.Shift)
        {
            if (keyEventArgs.KeyCode == Keys.F11)
                Sound.Play(Resources.ahhh_ah_ah_ah_ahhhhh_wav);
            if (keyEventArgs.KeyCode != Keys.F6)
                return;

            Sound.Play(Resources.obiwan_has_tought_you_well_wav);
        }
        else
        {
            if (keyEventArgs.KeyCode != Keys.F11)
                return;

            Settings.Current.PlayMusic = true;
            Settings.Current.Serialize();
            PlayMusic_ToolStripMenuItem.Checked = true;
            Sound.PlayRandomMusic();
        }
    }

    #endregion

    #region Menus events

    // File - Exit
    private void Exit_ToolsStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    // Options - Display Toolbar
    private void DisplayToolBar_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        toolStrip.Visible = DisplayToolBar_ToolStripMenuItem.Checked;
    }
    // Options - Display Status Bar
    private void DisplayStatusBar_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        statusStrip.Visible = DisplayStatusBar_ToolStripMenuItem.Checked;
    }
    // Options - Play Music
    private void PlayMusic_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        PlayMusic_ToolStripMenuItem.Checked = !PlayMusic_ToolStripMenuItem.Checked;
        if (PlayMusic_ToolStripMenuItem.Checked)
        {
            Settings.Current.PlayMusic = true;
            Sound.PlayRandomMusic();
        }
        else
        {
            Settings.Current.PlayMusic = false;
            Sound.StopMusic();
        }
        Settings.Current.Serialize();
    }
    // Options - Play Sounds
    private void PlaySounds_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        PlaySounds_ToolStripMenuItem.Checked = !PlaySounds_ToolStripMenuItem.Checked;
        if (PlaySounds_ToolStripMenuItem.Checked)
        {
            Settings.Current.PlaySounds = true;
            PlaySounds_ToolStripMenuItem.Checked = true;
        }
        else
        {
            Settings.Current.PlaySounds = false;
            PlaySounds_ToolStripMenuItem.Checked = false;
        }
        Settings.Current.Serialize();
    }
    // Options - Change Game Folder
    private void changeGameFolderToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using (var folderDialog = new FolderBrowserDialog())
        {
            folderDialog.InitialDirectory = Settings.Current.GameFolder;
            folderDialog.Description = "Select your Star Wars Rebellion Folder";
            folderDialog.UseDescriptionForTitle = true;
            var dialogResult = folderDialog.ShowDialog();
            if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
            {
                Settings.Current.GameFolder = folderDialog.SelectedPath;
                Settings.Current.Serialize();
            }
        }
    }

    // Editor - Galaxy Map
    private void Map_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show<GalaxyMapForm>();
    }
    private void Map_Button_Click(object sender, EventArgs e)
    {
        Show<GalaxyMapForm>();
    }
    // Editor - Galaxy - Sectors
    private void Sectors_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show<SectorsForm>();
    }
    private void Sectors_Button_Click(object sender, EventArgs e)
    {
        Show<SectorsForm>();
    }
    // Editor - Galaxy - Systems
    private void Systems_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show<SystemsForm>();
    }
    private void Systems_Button_Click(object sender, EventArgs e)
    {
        Show<SystemsForm>();
    }

    // Editor - Characters and Troops - Major Characters
    private void MajorCharacters_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show<MajorCharactersForm>();
    }
    private void MajorCharacters_Button_Click(object sender, EventArgs e)
    {
        Show<MajorCharactersForm>();
    }
    // Editor - Characters and Troops - Minor Characters
    private void MinorCharacters_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show<MinorCharactersForm>();
    }
    private void MinorCharacters_Button_Click(object sender, EventArgs e)
    {
        Show<MinorCharactersForm>();
    }
    // Editor - Characters and Troops - Troops
    private void Troops_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show<TroopsForm>();
    }
    private void Troops_ToolStripButton_Click(object sender, EventArgs e)
    {
        Show<TroopsForm>();
    }
    // Editor - Characters and Troops - Special Forces
    private void SpecialForces_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show<SpecialForcesForm>();
    }
    private void SpecialForces_Button_Click(object sender, EventArgs e)
    {
        Show<SpecialForcesForm>();
    }

    // Editor - Ships - Capital Ships
    private void CapitalShips_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show<CapitalShipsForm>();
    }
    private void CapitalShips_Button_Click(object sender, EventArgs e)
    {
        Show<CapitalShipsForm>();
    }
    // Editor - Ships - Fighters
    private void Fighters_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show<FightersForm>();
    }
    private void Fighter_Button_Click(object sender, EventArgs e)
    {
        Show<FightersForm>();
    }

    // Editor - Facilities - Defensive
    private void Defensive_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show<DefenseFacilitiesForm>();
    }
    private void Defensive_Button_Click(object sender, EventArgs e)
    {
        Show<DefenseFacilitiesForm>();
    }
    // Editor - Facilities - Manufacturing
    private void Manufacturing_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show<ManufacturingFacilitiesForm>();
    }
    private void Manufacturing_Button_Click(object sender, EventArgs e)
    {
        Show<ManufacturingFacilitiesForm>();
    }
    // Editor - Facilities - Production
    private void Production_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show<ProductionFacilitiesForm>();
    }
    private void Production_Button_Click(object sender, EventArgs e)
    {
        Show<ProductionFacilitiesForm>();
    }

    // Editor - Patch
    private void Patch_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show<PatchForm>();
    }
    private void Patch_Button_Click(object sender, EventArgs e)
    {
        Show<PatchForm>();
    }

    // Editor - Test Code - General Parameters Tables
    private void GeneralParametersTables_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show<GeneralParametersTablesForm>();
    }
    // Editor - Test Code - Side Param Entry Table
    private void sideParamEntryTableToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show<SideParamEntryTableForm>();
    }
    // Editor - Test Code - Probability Tables - System Facilities Core Tables
    private void SystemFacilitiesCoreTables_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show<SystemFacilitiesCoreTablesForm>();
    }
    // Editor - Test Code - Probability Tables - System Facilities Rim Tables
    private void SystemFacilitiesRimTables_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show<SystemFacilitiesRimTablesForm>();
    }
    // Editor - Test Code - Starting Fleets - Empire HQ
    // Editor - Test Code - Starting Fleets - Empire Random
    private void CMUNEmpireTables_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //Show<CMUNEmpireTablesForm>(); // EMPIRE version
    }
    // Editor - Test Code - Starting Fleets - Rebel HQ
    // Editor - Test Code - Starting Fleets - Rebel Random
    private void CMUNAllianceTables_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show<CMUNAllianceTablesForm>();
    }

    // Windows - Cascade
    private void Cascade_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.Cascade);
    }
    // Windows - Tile Vertical
    private void TileVertical_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.TileVertical);
    }
    // Windows - Tile Horizontal
    private void TileHorizontal_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.TileHorizontal);
    }
    // Windows - Close All
    private void CloseAll_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        foreach (var mdiChild in MdiChildren)
            mdiChild.Close();
    }
    // Windows - Arrange Icons
    private void ArrangeIcons_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.ArrangeIcons);
    }
    // Windows - Options - Size 1280x1024
    private void Size1280x1024_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Location = new Point(0, 0);
        Size = new Size(1280, 1024);
    }
    // Windows - Options - Size 1024x768
    private void Size1024x768_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Location = new Point(0, 0);
        Size = new Size(1024, 768);
    }
    // Windows - Options - Size 800x600
    private void Size800x600_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Location = new Point(0, 0);
        Size = new Size(800, 600);
    }
    // Windows - Options - Size 640x480
    private void Size640x480_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Location = new Point(0, 0);
        Size = new Size(640, 480);
    }
    // Windows - Options - Restore Defaults
    private void RestoreDefaults_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (DialogResult.OK != MessageBox.Show("Restore application default window size and location?", "Restore Settings", MessageBoxButtons.OKCancel))
            return;

        Sound.StopMusic();
        Settings.Current.SetDefaultValues();
        Location = Settings.Current.MainWindowTopLeftCornerPosition;
        Size = Settings.Current.BackgroundSize;
        if (Settings.Current.PlayMusic)
            PlayMusic_ToolStripMenuItem.Checked = true;
        else
            PlayMusic_ToolStripMenuItem.Checked = false;
        if (Settings.Current.PlaySounds)
            PlaySounds_ToolStripMenuItem.Checked = true;
        else
            PlaySounds_ToolStripMenuItem.Checked = false;
    }

    // Help - About
    private void About_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Show<AboutForm>();
    }

    #endregion
}
