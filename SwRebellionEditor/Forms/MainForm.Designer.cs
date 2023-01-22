using System.Media;

namespace SwRebellionEditor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip;
        private ToolStripStatusLabel Save_ToolStripStatusLabel;
        private ToolStripMenuItem About_ToolStripMenuItem;
        private ToolStripMenuItem TileHorizontal_ToolStripMenuItem;
        private ToolStripMenuItem File_Menu;
        private ToolStripMenuItem Exit_ToolStripMenuItem;
        private ToolStripMenuItem Options_Menu;
        private ToolStripMenuItem DisplayToolBar_ToolStripMenuItem;
        private ToolStripMenuItem DisplayStatusBar_ToolStripMenuItem;
        private ToolStripMenuItem Editor_Menu;
        private ToolStripMenuItem Windows_Menu;
        private ToolStripMenuItem Cascade_ToolStripMenuItem;
        private ToolStripMenuItem TileVertical_ToolStripMenuItem;
        private ToolStripMenuItem CloseAll_ToolStripMenuItem;
        private ToolStripMenuItem ArrangeIcons_ToolStripMenuItem;
        private ToolStripMenuItem Help_Menu;
        private ToolTip ToolTip;
        private ToolStripMenuItem CharactersAndTroops_ToolStripMenuItem;
        private ToolStripMenuItem MajorCharacters_ToolStripMenuItem;
        private ToolStripMenuItem MinorCharacters_ToolStripMenuItem;
        private ToolStripMenuItem Troops_ToolStripMenuItem;
        private ToolStripMenuItem SpecialForces_ToolStripMenuItem;
        private ToolStripMenuItem Ships_ToolStripMenuItem;
        private ToolStripMenuItem CapitalShips_ToolStripMenuItem;
        private ToolStripMenuItem Fighters_ToolStripMenuItem;
        private ToolStripMenuItem Facilities_ToolStripMenuItem;
        private ToolStripMenuItem ProductionFacilties_ToolStripMenuItem;
        private ToolStripMenuItem DefensiveFacilities_ToolStripMenuItem;
        private ToolStripMenuItem ManufacturingFacilities_ToolStripMenuItem;
        private ImageList imageList1;
        private ToolStripStatusLabel roopDataStatus;
        private ToolStripStatusLabel majorCharDataStatus;
        private ToolStripStatusLabel minorCharDataStatus;
        private ToolStripStatusLabel specOpDataStatus;
        private ToolStripStatusLabel CapShipDataStatus;
        public StatusStrip statusStrip;
        public ToolStripStatusLabel fighterDataStatus;
        private ToolStripMenuItem Galaxy_ToolStripMenuItem;
        private ToolStripMenuItem Sectors_ToolStripMenuItem;
        private ToolStripMenuItem Systems_ToolStripMenuItem;
        private ToolStripMenuItem Options_ToolStripMenuItem;
        private ToolStripMenuItem Size1024x768_ToolStripMenuItem;
        private ToolStripMenuItem Size800x600_ToolStripMenuItem;
        private ToolStripMenuItem Size640x480_ToolStripMenuItem;
        private ToolStripMenuItem RestoreDefaults_ToolStripMenuItem;
        private ToolStripMenuItem RestorePreviousSave_ToolStripMenuItem;
        private ToolStripMenuItem TestCode_ToolStripMenuItem;
        private ToolStripMenuItem GeneralParametersTables_ToolStripMenuItem;
        private ToolStripMenuItem ProbabilityTables_ToolStripMenuItem;
        private ToolStripMenuItem SystemFacilitiesCoreTables_ToolStripMenuItem;
        private ToolStripMenuItem Size1280x1024_ToolStripMenuItem;
        private ToolStripMenuItem SystemFacilitiesRimTables_ToolStripMenuItem;
        private ToolStripMenuItem StartingArmies_ToolStripMenuItem;
        private ToolStripMenuItem EmpireHq_ToolStripMenuItem;
        private ToolStripMenuItem CMUNEmpireTables_ToolStripMenuItem;
        private ToolStripMenuItem AllianceHq_ToolStripMenuItem;
        private ToolStripButton Sectors_Button;
        private ToolStripButton Systems_Button;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton MajorCharacters_Button;
        private ToolStripButton MinorCharacters_Button;
        private ToolStripButton Troops_ToolStripButton;
        private ToolStripButton SpecialForces_Button;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton CapitalShips_Button;
        private ToolStripButton Fighters_Button;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton DefensiveFacilities_Button;
        private ToolStripButton ManufacturingFacilities_Button;
        private ToolStripButton ProductionFacilities_Button;
        private ToolStrip toolStrip;
        private ToolStripMenuItem PlayMusic_ToolStripMenuItem;
        private ToolStripMenuItem PlaySounds_ToolStripMenuItem;
        private ToolStripMenuItem CMUNAllianceTables_ToolStripMenuItem;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.File_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Options_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayToolBar_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayStatusBar_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayMusic_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlaySounds_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Editor_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Galaxy_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sectors_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Systems_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CharactersAndTroops_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MajorCharacters_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MinorCharacters_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Troops_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpecialForces_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ships_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CapitalShips_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Fighters_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Facilities_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DefensiveFacilities_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManufacturingFacilities_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductionFacilties_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Patch_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestCode_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneralParametersTables_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProbabilityTables_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemFacilitiesCoreTables_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemFacilitiesRimTables_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartingArmies_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpireHq_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMUNEmpireTables_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllianceHq_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMUNAllianceTables_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Windows_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Cascade_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TileVertical_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TileHorizontal_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAll_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArrangeIcons_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Options_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Size1280x1024_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Size1024x768_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Size800x600_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Size640x480_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestoreDefaults_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestorePreviousSave_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.About_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.Save_ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.roopDataStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.majorCharDataStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.minorCharDataStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.specOpDataStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.CapShipDataStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.fighterDataStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Sectors_Button = new System.Windows.Forms.ToolStripButton();
            this.Systems_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MajorCharacters_Button = new System.Windows.Forms.ToolStripButton();
            this.MinorCharacters_Button = new System.Windows.Forms.ToolStripButton();
            this.Troops_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SpecialForces_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CapitalShips_Button = new System.Windows.Forms.ToolStripButton();
            this.Fighters_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DefensiveFacilities_Button = new System.Windows.Forms.ToolStripButton();
            this.ManufacturingFacilities_Button = new System.Windows.Forms.ToolStripButton();
            this.ProductionFacilities_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.galaxyMapButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Patch_Button = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_Menu,
            this.Options_Menu,
            this.Editor_Menu,
            this.Windows_Menu,
            this.Help_Menu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.Windows_Menu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // File_Menu
            // 
            this.File_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit_ToolStripMenuItem});
            this.File_Menu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.File_Menu.Name = "File_Menu";
            this.File_Menu.Size = new System.Drawing.Size(37, 20);
            this.File_Menu.Text = "&File";
            // 
            // Exit_ToolStripMenuItem
            // 
            this.Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem";
            this.Exit_ToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.Exit_ToolStripMenuItem.Text = "Exit";
            this.Exit_ToolStripMenuItem.Click += new System.EventHandler(this.Exit_ToolsStripMenuItem_Click);
            // 
            // Options_Menu
            // 
            this.Options_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DisplayToolBar_ToolStripMenuItem,
            this.DisplayStatusBar_ToolStripMenuItem,
            this.PlayMusic_ToolStripMenuItem,
            this.PlaySounds_ToolStripMenuItem});
            this.Options_Menu.Name = "Options_Menu";
            this.Options_Menu.Size = new System.Drawing.Size(61, 20);
            this.Options_Menu.Text = "&Options";
            // 
            // DisplayToolBar_ToolStripMenuItem
            // 
            this.DisplayToolBar_ToolStripMenuItem.AutoToolTip = true;
            this.DisplayToolBar_ToolStripMenuItem.Checked = true;
            this.DisplayToolBar_ToolStripMenuItem.CheckOnClick = true;
            this.DisplayToolBar_ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisplayToolBar_ToolStripMenuItem.Name = "DisplayToolBar_ToolStripMenuItem";
            this.DisplayToolBar_ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.DisplayToolBar_ToolStripMenuItem.Text = "Display Toolbar";
            this.DisplayToolBar_ToolStripMenuItem.Click += new System.EventHandler(this.DisplayToolBar_ToolStripMenuItem_Click);
            // 
            // DisplayStatusBar_ToolStripMenuItem
            // 
            this.DisplayStatusBar_ToolStripMenuItem.Checked = true;
            this.DisplayStatusBar_ToolStripMenuItem.CheckOnClick = true;
            this.DisplayStatusBar_ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisplayStatusBar_ToolStripMenuItem.Name = "DisplayStatusBar_ToolStripMenuItem";
            this.DisplayStatusBar_ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.DisplayStatusBar_ToolStripMenuItem.Text = "Display Status Bar";
            this.DisplayStatusBar_ToolStripMenuItem.Click += new System.EventHandler(this.DisplayStatusBar_ToolStripMenuItem_Click);
            // 
            // PlayMusic_ToolStripMenuItem
            // 
            this.PlayMusic_ToolStripMenuItem.Name = "PlayMusic_ToolStripMenuItem";
            this.PlayMusic_ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.PlayMusic_ToolStripMenuItem.Text = "Play Music";
            this.PlayMusic_ToolStripMenuItem.Click += new System.EventHandler(this.PlayMusic_ToolStripMenuItem_Click);
            // 
            // PlaySounds_ToolStripMenuItem
            // 
            this.PlaySounds_ToolStripMenuItem.Name = "PlaySounds_ToolStripMenuItem";
            this.PlaySounds_ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.PlaySounds_ToolStripMenuItem.Text = "Play Sounds";
            this.PlaySounds_ToolStripMenuItem.Click += new System.EventHandler(this.PlaySounds_ToolStripMenuItem_Click);
            // 
            // Editor_Menu
            // 
            this.Editor_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Galaxy_ToolStripMenuItem,
            this.CharactersAndTroops_ToolStripMenuItem,
            this.Ships_ToolStripMenuItem,
            this.Facilities_ToolStripMenuItem,
            this.Patch_ToolStripMenuItem,
            this.TestCode_ToolStripMenuItem});
            this.Editor_Menu.Name = "Editor_Menu";
            this.Editor_Menu.Size = new System.Drawing.Size(50, 20);
            this.Editor_Menu.Text = "&Editor";
            // 
            // Galaxy_ToolStripMenuItem
            // 
            this.Galaxy_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapToolStripMenuItem,
            this.Sectors_ToolStripMenuItem,
            this.Systems_ToolStripMenuItem});
            this.Galaxy_ToolStripMenuItem.Image = global::SwRebellionEditor.Resources.galaxy_16x16_bmp;
            this.Galaxy_ToolStripMenuItem.Name = "Galaxy_ToolStripMenuItem";
            this.Galaxy_ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.Galaxy_ToolStripMenuItem.Text = "Galaxy";
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.Image = global::SwRebellionEditor.Resources.galaxy_16x16_bmp;
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.mapToolStripMenuItem.Text = "Map";
            this.mapToolStripMenuItem.Click += new System.EventHandler(this.Map_ToolStripMenuItem_Click);
            // 
            // Sectors_ToolStripMenuItem
            // 
            this.Sectors_ToolStripMenuItem.Image = global::SwRebellionEditor.Resources.sector_16x16_bmp;
            this.Sectors_ToolStripMenuItem.Name = "Sectors_ToolStripMenuItem";
            this.Sectors_ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.Sectors_ToolStripMenuItem.Text = "Sectors";
            this.Sectors_ToolStripMenuItem.Click += new System.EventHandler(this.Sectors_ToolStripMenuItem_Click);
            // 
            // Systems_ToolStripMenuItem
            // 
            this.Systems_ToolStripMenuItem.Image = global::SwRebellionEditor.Resources.planet_37x37_bmp;
            this.Systems_ToolStripMenuItem.Name = "Systems_ToolStripMenuItem";
            this.Systems_ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.Systems_ToolStripMenuItem.Text = "Systems";
            this.Systems_ToolStripMenuItem.Click += new System.EventHandler(this.Systems_ToolStripMenuItem_Click);
            // 
            // CharactersAndTroops_ToolStripMenuItem
            // 
            this.CharactersAndTroops_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MajorCharacters_ToolStripMenuItem,
            this.MinorCharacters_ToolStripMenuItem,
            this.Troops_ToolStripMenuItem,
            this.SpecialForces_ToolStripMenuItem});
            this.CharactersAndTroops_ToolStripMenuItem.Image = global::SwRebellionEditor.Resources.luke_16x16_bmp;
            this.CharactersAndTroops_ToolStripMenuItem.Name = "CharactersAndTroops_ToolStripMenuItem";
            this.CharactersAndTroops_ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.CharactersAndTroops_ToolStripMenuItem.Text = "Characters and Troops";
            // 
            // MajorCharacters_ToolStripMenuItem
            // 
            this.MajorCharacters_ToolStripMenuItem.Image = global::SwRebellionEditor.Resources.luke_16x16_bmp;
            this.MajorCharacters_ToolStripMenuItem.Name = "MajorCharacters_ToolStripMenuItem";
            this.MajorCharacters_ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.MajorCharacters_ToolStripMenuItem.Text = "Major Characters";
            this.MajorCharacters_ToolStripMenuItem.Click += new System.EventHandler(this.MajorCharacters_ToolStripMenuItem_Click);
            // 
            // MinorCharacters_ToolStripMenuItem
            // 
            this.MinorCharacters_ToolStripMenuItem.Image = global::SwRebellionEditor.Resources.thrawn_16x16_bmp;
            this.MinorCharacters_ToolStripMenuItem.Name = "MinorCharacters_ToolStripMenuItem";
            this.MinorCharacters_ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.MinorCharacters_ToolStripMenuItem.Text = "Minor Characters";
            this.MinorCharacters_ToolStripMenuItem.Click += new System.EventHandler(this.MinorCharacters_ToolStripMenuItem_Click);
            // 
            // Troops_ToolStripMenuItem
            // 
            this.Troops_ToolStripMenuItem.Image = global::SwRebellionEditor.Resources.stormtrooper_16x16_bmp;
            this.Troops_ToolStripMenuItem.Name = "Troops_ToolStripMenuItem";
            this.Troops_ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.Troops_ToolStripMenuItem.Text = "Troops";
            this.Troops_ToolStripMenuItem.Click += new System.EventHandler(this.Troops_ToolStripMenuItem_Click);
            // 
            // SpecialForces_ToolStripMenuItem
            // 
            this.SpecialForces_ToolStripMenuItem.Image = global::SwRebellionEditor.Resources.c3po_16x16_bmp;
            this.SpecialForces_ToolStripMenuItem.Name = "SpecialForces_ToolStripMenuItem";
            this.SpecialForces_ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.SpecialForces_ToolStripMenuItem.Text = "Special Forces";
            this.SpecialForces_ToolStripMenuItem.Click += new System.EventHandler(this.SpecialForces_ToolStripMenuItem_Click);
            // 
            // Ships_ToolStripMenuItem
            // 
            this.Ships_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CapitalShips_ToolStripMenuItem,
            this.Fighters_ToolStripMenuItem});
            this.Ships_ToolStripMenuItem.Image = global::SwRebellionEditor.Resources.star_destroyer_16x16_bmp;
            this.Ships_ToolStripMenuItem.Name = "Ships_ToolStripMenuItem";
            this.Ships_ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.Ships_ToolStripMenuItem.Text = "Ships";
            // 
            // CapitalShips_ToolStripMenuItem
            // 
            this.CapitalShips_ToolStripMenuItem.Image = global::SwRebellionEditor.Resources.star_destroyer_16x16_bmp;
            this.CapitalShips_ToolStripMenuItem.Name = "CapitalShips_ToolStripMenuItem";
            this.CapitalShips_ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.CapitalShips_ToolStripMenuItem.Text = "Capital Ships";
            this.CapitalShips_ToolStripMenuItem.Click += new System.EventHandler(this.CapitalShips_ToolStripMenuItem_Click);
            // 
            // Fighters_ToolStripMenuItem
            // 
            this.Fighters_ToolStripMenuItem.Image = global::SwRebellionEditor.Resources.tie_fighter_16x16_bmp;
            this.Fighters_ToolStripMenuItem.Name = "Fighters_ToolStripMenuItem";
            this.Fighters_ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.Fighters_ToolStripMenuItem.Text = "Fighters";
            this.Fighters_ToolStripMenuItem.Click += new System.EventHandler(this.Fighters_ToolStripMenuItem_Click);
            // 
            // Facilities_ToolStripMenuItem
            // 
            this.Facilities_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DefensiveFacilities_ToolStripMenuItem,
            this.ManufacturingFacilities_ToolStripMenuItem,
            this.ProductionFacilties_ToolStripMenuItem});
            this.Facilities_ToolStripMenuItem.Image = global::SwRebellionEditor.Resources.mine_16x16_bmp;
            this.Facilities_ToolStripMenuItem.Name = "Facilities_ToolStripMenuItem";
            this.Facilities_ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.Facilities_ToolStripMenuItem.Text = "Facilities";
            // 
            // DefensiveFacilities_ToolStripMenuItem
            // 
            this.DefensiveFacilities_ToolStripMenuItem.Image = global::SwRebellionEditor.Resources.defense_facility_16x16_bmp;
            this.DefensiveFacilities_ToolStripMenuItem.Name = "DefensiveFacilities_ToolStripMenuItem";
            this.DefensiveFacilities_ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.DefensiveFacilities_ToolStripMenuItem.Text = "Defensive Facilities";
            this.DefensiveFacilities_ToolStripMenuItem.Click += new System.EventHandler(this.Defensive_ToolStripMenuItem_Click);
            // 
            // ManufacturingFacilities_ToolStripMenuItem
            // 
            this.ManufacturingFacilities_ToolStripMenuItem.Image = global::SwRebellionEditor.Resources.shipyard_16x16_bmp;
            this.ManufacturingFacilities_ToolStripMenuItem.Name = "ManufacturingFacilities_ToolStripMenuItem";
            this.ManufacturingFacilities_ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ManufacturingFacilities_ToolStripMenuItem.Text = "Manufacturing Facilities";
            this.ManufacturingFacilities_ToolStripMenuItem.Click += new System.EventHandler(this.Manufacturing_ToolStripMenuItem_Click);
            // 
            // ProductionFacilties_ToolStripMenuItem
            // 
            this.ProductionFacilties_ToolStripMenuItem.Image = global::SwRebellionEditor.Resources.mine_16x16_bmp;
            this.ProductionFacilties_ToolStripMenuItem.Name = "ProductionFacilties_ToolStripMenuItem";
            this.ProductionFacilties_ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ProductionFacilties_ToolStripMenuItem.Text = "Production Facilities";
            this.ProductionFacilties_ToolStripMenuItem.Click += new System.EventHandler(this.Production_ToolStripMenuItem_Click);
            // 
            // Patch_ToolStripMenuItem
            // 
            this.Patch_ToolStripMenuItem.Image = global::SwRebellionEditor.Resources.death_star_16x16xbmp;
            this.Patch_ToolStripMenuItem.Name = "Patch_ToolStripMenuItem";
            this.Patch_ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.Patch_ToolStripMenuItem.Text = "25th Anniversary Patch";
            this.Patch_ToolStripMenuItem.Click += new System.EventHandler(this.Patch_ToolStripMenuItem_Click);
            // 
            // TestCode_ToolStripMenuItem
            // 
            this.TestCode_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GeneralParametersTables_ToolStripMenuItem,
            this.ProbabilityTables_ToolStripMenuItem,
            this.StartingArmies_ToolStripMenuItem});
            this.TestCode_ToolStripMenuItem.Name = "TestCode_ToolStripMenuItem";
            this.TestCode_ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.TestCode_ToolStripMenuItem.Text = "Test Code";
            // 
            // GeneralParametersTables_ToolStripMenuItem
            // 
            this.GeneralParametersTables_ToolStripMenuItem.Name = "GeneralParametersTables_ToolStripMenuItem";
            this.GeneralParametersTables_ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.GeneralParametersTables_ToolStripMenuItem.Text = "HyperSpace Speeds";
            this.GeneralParametersTables_ToolStripMenuItem.Click += new System.EventHandler(this.GeneralParametersTables_ToolStripMenuItem_Click);
            // 
            // ProbabilityTables_ToolStripMenuItem
            // 
            this.ProbabilityTables_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemFacilitiesCoreTables_ToolStripMenuItem,
            this.SystemFacilitiesRimTables_ToolStripMenuItem});
            this.ProbabilityTables_ToolStripMenuItem.Name = "ProbabilityTables_ToolStripMenuItem";
            this.ProbabilityTables_ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ProbabilityTables_ToolStripMenuItem.Text = "Probability Tables";
            // 
            // SystemFacilitiesCoreTables_ToolStripMenuItem
            // 
            this.SystemFacilitiesCoreTables_ToolStripMenuItem.Name = "SystemFacilitiesCoreTables_ToolStripMenuItem";
            this.SystemFacilitiesCoreTables_ToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.SystemFacilitiesCoreTables_ToolStripMenuItem.Text = "Sytem Facilities Core Tables";
            this.SystemFacilitiesCoreTables_ToolStripMenuItem.Click += new System.EventHandler(this.SystemFacilitiesCoreTables_ToolStripMenuItem_Click);
            // 
            // SystemFacilitiesRimTables_ToolStripMenuItem
            // 
            this.SystemFacilitiesRimTables_ToolStripMenuItem.Name = "SystemFacilitiesRimTables_ToolStripMenuItem";
            this.SystemFacilitiesRimTables_ToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.SystemFacilitiesRimTables_ToolStripMenuItem.Text = "System Facilities Rim Tables";
            this.SystemFacilitiesRimTables_ToolStripMenuItem.Click += new System.EventHandler(this.SystemFacilitiesRimTables_ToolStripMenuItem_Click);
            // 
            // StartingArmies_ToolStripMenuItem
            // 
            this.StartingArmies_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmpireHq_ToolStripMenuItem,
            this.CMUNEmpireTables_ToolStripMenuItem,
            this.AllianceHq_ToolStripMenuItem,
            this.CMUNAllianceTables_ToolStripMenuItem});
            this.StartingArmies_ToolStripMenuItem.Name = "StartingArmies_ToolStripMenuItem";
            this.StartingArmies_ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.StartingArmies_ToolStripMenuItem.Text = "Starting Armies";
            // 
            // EmpireHq_ToolStripMenuItem
            // 
            this.EmpireHq_ToolStripMenuItem.Enabled = false;
            this.EmpireHq_ToolStripMenuItem.Name = "EmpireHq_ToolStripMenuItem";
            this.EmpireHq_ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.EmpireHq_ToolStripMenuItem.Text = "Empire HQ Fleet";
            this.EmpireHq_ToolStripMenuItem.ToolTipText = "Starting Fleet on Coruscant";
            // 
            // CMUNEmpireTables_ToolStripMenuItem
            // 
            this.CMUNEmpireTables_ToolStripMenuItem.Enabled = false;
            this.CMUNEmpireTables_ToolStripMenuItem.Name = "CMUNEmpireTables_ToolStripMenuItem";
            this.CMUNEmpireTables_ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.CMUNEmpireTables_ToolStripMenuItem.Text = "Empire Random";
            this.CMUNEmpireTables_ToolStripMenuItem.ToolTipText = "Randomly Generated Empiral Starting Fleet";
            this.CMUNEmpireTables_ToolStripMenuItem.Click += new System.EventHandler(this.CMUNEmpireTables_ToolStripMenuItem_Click);
            // 
            // AllianceHq_ToolStripMenuItem
            // 
            this.AllianceHq_ToolStripMenuItem.Enabled = false;
            this.AllianceHq_ToolStripMenuItem.Name = "AllianceHq_ToolStripMenuItem";
            this.AllianceHq_ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.AllianceHq_ToolStripMenuItem.Text = "Rebel HQ";
            this.AllianceHq_ToolStripMenuItem.ToolTipText = "Starting Fleet with Rebel Headquarters";
            // 
            // CMUNAllianceTables_ToolStripMenuItem
            // 
            this.CMUNAllianceTables_ToolStripMenuItem.Name = "CMUNAllianceTables_ToolStripMenuItem";
            this.CMUNAllianceTables_ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.CMUNAllianceTables_ToolStripMenuItem.Text = "Rebel Random";
            this.CMUNAllianceTables_ToolStripMenuItem.ToolTipText = "Randomly Generated Rebel Starting Fleet";
            this.CMUNAllianceTables_ToolStripMenuItem.Click += new System.EventHandler(this.CMUNAllianceTables_ToolStripMenuItem_Click);
            // 
            // Windows_Menu
            // 
            this.Windows_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cascade_ToolStripMenuItem,
            this.TileVertical_ToolStripMenuItem,
            this.TileHorizontal_ToolStripMenuItem,
            this.CloseAll_ToolStripMenuItem,
            this.ArrangeIcons_ToolStripMenuItem,
            this.Options_ToolStripMenuItem});
            this.Windows_Menu.Name = "Windows_Menu";
            this.Windows_Menu.Size = new System.Drawing.Size(68, 20);
            this.Windows_Menu.Text = "&Windows";
            // 
            // Cascade_ToolStripMenuItem
            // 
            this.Cascade_ToolStripMenuItem.Name = "Cascade_ToolStripMenuItem";
            this.Cascade_ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.Cascade_ToolStripMenuItem.Text = "Cascade";
            this.Cascade_ToolStripMenuItem.Click += new System.EventHandler(this.Cascade_ToolStripMenuItem_Click);
            // 
            // TileVertical_ToolStripMenuItem
            // 
            this.TileVertical_ToolStripMenuItem.Name = "TileVertical_ToolStripMenuItem";
            this.TileVertical_ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.TileVertical_ToolStripMenuItem.Text = "Tile Vertical";
            this.TileVertical_ToolStripMenuItem.Click += new System.EventHandler(this.TileVertical_ToolStripMenuItem_Click);
            // 
            // TileHorizontal_ToolStripMenuItem
            // 
            this.TileHorizontal_ToolStripMenuItem.Name = "TileHorizontal_ToolStripMenuItem";
            this.TileHorizontal_ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.TileHorizontal_ToolStripMenuItem.Text = "Tile Horizontal";
            this.TileHorizontal_ToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontal_ToolStripMenuItem_Click);
            // 
            // CloseAll_ToolStripMenuItem
            // 
            this.CloseAll_ToolStripMenuItem.Name = "CloseAll_ToolStripMenuItem";
            this.CloseAll_ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.CloseAll_ToolStripMenuItem.Text = "Close All";
            this.CloseAll_ToolStripMenuItem.Click += new System.EventHandler(this.CloseAll_ToolStripMenuItem_Click);
            // 
            // ArrangeIcons_ToolStripMenuItem
            // 
            this.ArrangeIcons_ToolStripMenuItem.Name = "ArrangeIcons_ToolStripMenuItem";
            this.ArrangeIcons_ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ArrangeIcons_ToolStripMenuItem.Text = "Arrange Icons";
            this.ArrangeIcons_ToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIcons_ToolStripMenuItem_Click);
            // 
            // Options_ToolStripMenuItem
            // 
            this.Options_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Size1280x1024_ToolStripMenuItem,
            this.Size1024x768_ToolStripMenuItem,
            this.Size800x600_ToolStripMenuItem,
            this.Size640x480_ToolStripMenuItem,
            this.RestoreDefaults_ToolStripMenuItem,
            this.RestorePreviousSave_ToolStripMenuItem});
            this.Options_ToolStripMenuItem.Name = "Options_ToolStripMenuItem";
            this.Options_ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.Options_ToolStripMenuItem.Text = "Options";
            // 
            // Size1280x1024_ToolStripMenuItem
            // 
            this.Size1280x1024_ToolStripMenuItem.Name = "Size1280x1024_ToolStripMenuItem";
            this.Size1280x1024_ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.Size1280x1024_ToolStripMenuItem.Text = "Size 1280x1024";
            this.Size1280x1024_ToolStripMenuItem.Click += new System.EventHandler(this.Size1280x1024_ToolStripMenuItem_Click);
            // 
            // Size1024x768_ToolStripMenuItem
            // 
            this.Size1024x768_ToolStripMenuItem.Name = "Size1024x768_ToolStripMenuItem";
            this.Size1024x768_ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.Size1024x768_ToolStripMenuItem.Text = "Size 1024x768";
            this.Size1024x768_ToolStripMenuItem.Click += new System.EventHandler(this.Size1024x768_ToolStripMenuItem_Click);
            // 
            // Size800x600_ToolStripMenuItem
            // 
            this.Size800x600_ToolStripMenuItem.Name = "Size800x600_ToolStripMenuItem";
            this.Size800x600_ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.Size800x600_ToolStripMenuItem.Text = "Size 800x600";
            this.Size800x600_ToolStripMenuItem.Click += new System.EventHandler(this.Size800x600_ToolStripMenuItem_Click);
            // 
            // Size640x480_ToolStripMenuItem
            // 
            this.Size640x480_ToolStripMenuItem.Name = "Size640x480_ToolStripMenuItem";
            this.Size640x480_ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.Size640x480_ToolStripMenuItem.Text = "Size 640x480";
            this.Size640x480_ToolStripMenuItem.Click += new System.EventHandler(this.Size640x480_ToolStripMenuItem_Click);
            // 
            // RestoreDefaults_ToolStripMenuItem
            // 
            this.RestoreDefaults_ToolStripMenuItem.Name = "RestoreDefaults_ToolStripMenuItem";
            this.RestoreDefaults_ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.RestoreDefaults_ToolStripMenuItem.Text = "Restore Defaults";
            this.RestoreDefaults_ToolStripMenuItem.Click += new System.EventHandler(this.RestoreDefaults_ToolStripMenuItem_Click);
            // 
            // RestorePreviousSave_ToolStripMenuItem
            // 
            this.RestorePreviousSave_ToolStripMenuItem.Name = "RestorePreviousSave_ToolStripMenuItem";
            this.RestorePreviousSave_ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.RestorePreviousSave_ToolStripMenuItem.Text = "Restore Previous Save";
            this.RestorePreviousSave_ToolStripMenuItem.Click += new System.EventHandler(this.RestorePreviousSave_ToolStripMenuItem_Click);
            // 
            // Help_Menu
            // 
            this.Help_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About_ToolStripMenuItem});
            this.Help_Menu.Name = "Help_Menu";
            this.Help_Menu.Size = new System.Drawing.Size(44, 20);
            this.Help_Menu.Text = "&Help";
            // 
            // About_ToolStripMenuItem
            // 
            this.About_ToolStripMenuItem.Name = "About_ToolStripMenuItem";
            this.About_ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.About_ToolStripMenuItem.Text = "&About";
            this.About_ToolStripMenuItem.Click += new System.EventHandler(this.About_ToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_ToolStripStatusLabel,
            this.roopDataStatus,
            this.majorCharDataStatus,
            this.minorCharDataStatus,
            this.specOpDataStatus,
            this.CapShipDataStatus,
            this.fighterDataStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 707);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            this.ToolTip.SetToolTip(this.statusStrip, "TBD");
            // 
            // Save_ToolStripStatusLabel
            // 
            this.Save_ToolStripStatusLabel.Name = "Save_ToolStripStatusLabel";
            this.Save_ToolStripStatusLabel.Size = new System.Drawing.Size(130, 17);
            this.Save_ToolStripStatusLabel.Text = "Save Status: (not in yet)";
            // 
            // roopDataStatus
            // 
            this.roopDataStatus.Name = "roopDataStatus";
            this.roopDataStatus.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roopDataStatus.Size = new System.Drawing.Size(105, 17);
            this.roopDataStatus.Text = "Unsaved Troop";
            // 
            // majorCharDataStatus
            // 
            this.majorCharDataStatus.Name = "majorCharDataStatus";
            this.majorCharDataStatus.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.majorCharDataStatus.Size = new System.Drawing.Size(109, 17);
            this.majorCharDataStatus.Text = "Unsaved Major ";
            // 
            // minorCharDataStatus
            // 
            this.minorCharDataStatus.Name = "minorCharDataStatus";
            this.minorCharDataStatus.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.minorCharDataStatus.Size = new System.Drawing.Size(107, 17);
            this.minorCharDataStatus.Text = "Unsaved Minor";
            // 
            // specOpDataStatus
            // 
            this.specOpDataStatus.Name = "specOpDataStatus";
            this.specOpDataStatus.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.specOpDataStatus.Size = new System.Drawing.Size(116, 17);
            this.specOpDataStatus.Text = "Unsaved SpecOp";
            // 
            // CapShipDataStatus
            // 
            this.CapShipDataStatus.Name = "CapShipDataStatus";
            this.CapShipDataStatus.Size = new System.Drawing.Size(102, 17);
            this.CapShipDataStatus.Text = "Unsaved Cap Ship";
            // 
            // fighterDataStatus
            // 
            this.fighterDataStatus.Name = "fighterDataStatus";
            this.fighterDataStatus.Size = new System.Drawing.Size(92, 17);
            this.fighterDataStatus.Text = "Unsaved Fighter";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Sectors_Button
            // 
            this.Sectors_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Sectors_Button.Image = global::SwRebellionEditor.Resources.sector_16x16_bmp;
            this.Sectors_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sectors_Button.Name = "Sectors_Button";
            this.Sectors_Button.Size = new System.Drawing.Size(23, 22);
            this.Sectors_Button.Click += new System.EventHandler(this.Sectors_Button_Click);
            // 
            // Systems_Button
            // 
            this.Systems_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Systems_Button.Image = global::SwRebellionEditor.Resources.planet_37x37_bmp;
            this.Systems_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Systems_Button.Name = "Systems_Button";
            this.Systems_Button.Size = new System.Drawing.Size(23, 22);
            this.Systems_Button.ToolTipText = "Systems";
            this.Systems_Button.Click += new System.EventHandler(this.Systems_Button_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // MajorCharacters_Button
            // 
            this.MajorCharacters_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MajorCharacters_Button.Image = global::SwRebellionEditor.Resources.luke_16x16_bmp;
            this.MajorCharacters_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MajorCharacters_Button.Name = "MajorCharacters_Button";
            this.MajorCharacters_Button.Size = new System.Drawing.Size(23, 22);
            this.MajorCharacters_Button.ToolTipText = "Major Characters";
            this.MajorCharacters_Button.Click += new System.EventHandler(this.MajorCharacters_Button_Click);
            // 
            // MinorCharacters_Button
            // 
            this.MinorCharacters_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MinorCharacters_Button.Image = global::SwRebellionEditor.Resources.thrawn_16x16_bmp;
            this.MinorCharacters_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MinorCharacters_Button.Name = "MinorCharacters_Button";
            this.MinorCharacters_Button.Size = new System.Drawing.Size(23, 22);
            this.MinorCharacters_Button.ToolTipText = "Minor Characters";
            this.MinorCharacters_Button.Click += new System.EventHandler(this.MinorCharacters_Button_Click);
            // 
            // Troops_ToolStripButton
            // 
            this.Troops_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Troops_ToolStripButton.Image = global::SwRebellionEditor.Resources.stormtrooper_16x16_bmp;
            this.Troops_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Troops_ToolStripButton.Name = "Troops_ToolStripButton";
            this.Troops_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Troops_ToolStripButton.ToolTipText = "Troops ";
            this.Troops_ToolStripButton.Click += new System.EventHandler(this.Troops_ToolStripButton_Click);
            // 
            // SpecialForces_Button
            // 
            this.SpecialForces_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SpecialForces_Button.Image = global::SwRebellionEditor.Resources.c3po_16x16_bmp;
            this.SpecialForces_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SpecialForces_Button.Name = "SpecialForces_Button";
            this.SpecialForces_Button.Size = new System.Drawing.Size(23, 22);
            this.SpecialForces_Button.ToolTipText = "Special Forces";
            this.SpecialForces_Button.Click += new System.EventHandler(this.SpecialForces_Button_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // CapitalShips_Button
            // 
            this.CapitalShips_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CapitalShips_Button.Image = global::SwRebellionEditor.Resources.star_destroyer_16x16_bmp;
            this.CapitalShips_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CapitalShips_Button.Name = "CapitalShips_Button";
            this.CapitalShips_Button.Size = new System.Drawing.Size(23, 22);
            this.CapitalShips_Button.ToolTipText = "Capital Ships";
            this.CapitalShips_Button.Click += new System.EventHandler(this.CapitalShips_Button_Click);
            // 
            // Fighters_Button
            // 
            this.Fighters_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Fighters_Button.Image = global::SwRebellionEditor.Resources.tie_fighter_16x16_bmp;
            this.Fighters_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Fighters_Button.Name = "Fighters_Button";
            this.Fighters_Button.Size = new System.Drawing.Size(23, 22);
            this.Fighters_Button.ToolTipText = "Fighters";
            this.Fighters_Button.Click += new System.EventHandler(this.Fighter_Button_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // DefensiveFacilities_Button
            // 
            this.DefensiveFacilities_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DefensiveFacilities_Button.Image = global::SwRebellionEditor.Resources.defense_facility_16x16_bmp;
            this.DefensiveFacilities_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DefensiveFacilities_Button.Name = "DefensiveFacilities_Button";
            this.DefensiveFacilities_Button.Size = new System.Drawing.Size(23, 22);
            this.DefensiveFacilities_Button.ToolTipText = "Defensive Facilities";
            this.DefensiveFacilities_Button.Click += new System.EventHandler(this.Defensive_Button_Click);
            // 
            // ManufacturingFacilities_Button
            // 
            this.ManufacturingFacilities_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ManufacturingFacilities_Button.Image = global::SwRebellionEditor.Resources.shipyard_16x16_bmp;
            this.ManufacturingFacilities_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ManufacturingFacilities_Button.Name = "ManufacturingFacilities_Button";
            this.ManufacturingFacilities_Button.Size = new System.Drawing.Size(23, 22);
            this.ManufacturingFacilities_Button.ToolTipText = "Manufacturing Facilities";
            this.ManufacturingFacilities_Button.Click += new System.EventHandler(this.Manufacturing_Button_Click);
            // 
            // ProductionFacilities_Button
            // 
            this.ProductionFacilities_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ProductionFacilities_Button.Image = global::SwRebellionEditor.Resources.mine_16x16_bmp;
            this.ProductionFacilities_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProductionFacilities_Button.Name = "ProductionFacilities_Button";
            this.ProductionFacilities_Button.Size = new System.Drawing.Size(23, 22);
            this.ProductionFacilities_Button.ToolTipText = "Production Facilities";
            this.ProductionFacilities_Button.Click += new System.EventHandler(this.Production_Button_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.galaxyMapButton,
            this.Sectors_Button,
            this.Systems_Button,
            this.toolStripSeparator1,
            this.MajorCharacters_Button,
            this.MinorCharacters_Button,
            this.Troops_ToolStripButton,
            this.SpecialForces_Button,
            this.toolStripSeparator2,
            this.CapitalShips_Button,
            this.Fighters_Button,
            this.toolStripSeparator3,
            this.DefensiveFacilities_Button,
            this.ManufacturingFacilities_Button,
            this.ProductionFacilities_Button,
            this.toolStripSeparator4,
            this.Patch_Button});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // galaxyMapButton
            // 
            this.galaxyMapButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.galaxyMapButton.Image = global::SwRebellionEditor.Resources.galaxy_16x16_bmp;
            this.galaxyMapButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.galaxyMapButton.Name = "galaxyMapButton";
            this.galaxyMapButton.Size = new System.Drawing.Size(23, 22);
            this.galaxyMapButton.Click += new System.EventHandler(this.Map_Button_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // Patch_Button
            // 
            this.Patch_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Patch_Button.Image = global::SwRebellionEditor.Resources.death_star_16x16xbmp;
            this.Patch_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Patch_Button.Name = "Patch_Button";
            this.Patch_Button.Size = new System.Drawing.Size(23, 22);
            this.Patch_Button.Text = "Patch";
            this.Patch_Button.Click += new System.EventHandler(this.Patch_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SwRebellionEditor.Resources.galaxy_640x480_bmp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "Star Wars Rebellion Editor .NET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ToolStripButton galaxyMapButton;
        private ToolStripMenuItem mapToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton Patch_Button;
        private ToolStripMenuItem Patch_ToolStripMenuItem;
    }
}
#endregion
