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
        private ToolStripMenuItem GeneralParametersTables_ToolStripMenuItem;
        private ToolStripMenuItem Size1280x1024_ToolStripMenuItem;
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip = new MenuStrip();
            File_Menu = new ToolStripMenuItem();
            Exit_ToolStripMenuItem = new ToolStripMenuItem();
            Options_Menu = new ToolStripMenuItem();
            DisplayToolBar_ToolStripMenuItem = new ToolStripMenuItem();
            DisplayStatusBar_ToolStripMenuItem = new ToolStripMenuItem();
            PlayMusic_ToolStripMenuItem = new ToolStripMenuItem();
            PlaySounds_ToolStripMenuItem = new ToolStripMenuItem();
            changeGameFolderToolStripMenuItem = new ToolStripMenuItem();
            Editor_Menu = new ToolStripMenuItem();
            Galaxy_ToolStripMenuItem = new ToolStripMenuItem();
            mapToolStripMenuItem = new ToolStripMenuItem();
            Sectors_ToolStripMenuItem = new ToolStripMenuItem();
            Systems_ToolStripMenuItem = new ToolStripMenuItem();
            CharactersAndTroops_ToolStripMenuItem = new ToolStripMenuItem();
            MajorCharacters_ToolStripMenuItem = new ToolStripMenuItem();
            MinorCharacters_ToolStripMenuItem = new ToolStripMenuItem();
            Troops_ToolStripMenuItem = new ToolStripMenuItem();
            SpecialForces_ToolStripMenuItem = new ToolStripMenuItem();
            Ships_ToolStripMenuItem = new ToolStripMenuItem();
            CapitalShips_ToolStripMenuItem = new ToolStripMenuItem();
            Fighters_ToolStripMenuItem = new ToolStripMenuItem();
            Facilities_ToolStripMenuItem = new ToolStripMenuItem();
            DefensiveFacilities_ToolStripMenuItem = new ToolStripMenuItem();
            ManufacturingFacilities_ToolStripMenuItem = new ToolStripMenuItem();
            ProductionFacilties_ToolStripMenuItem = new ToolStripMenuItem();
            initialGameSetupToolStripMenuItem = new ToolStripMenuItem();
            generalParametersToolStripMenuItem = new ToolStripMenuItem();
            sideParametersToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            mineshardcodedInExeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            coreSystemsFacilitiesToolStripMenuItem = new ToolStripMenuItem();
            rimSystemsFacilitiesToolStripMenuItem = new ToolStripMenuItem();
            allianceHeadquarterFacilitiesToolStripMenuItem = new ToolStripMenuItem();
            empireCoruscantFacilitiesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            systemsGarrisonTroopsSideParams2435ToolStripMenuItem = new ToolStripMenuItem();
            systemsRandomUnitsSideParametersToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator9 = new ToolStripSeparator();
            systemsRandomUnitsSideParams23ToolStripMenuItem = new ToolStripMenuItem();
            allianceRandomUnitsToolStripMenuItem = new ToolStripMenuItem();
            empireRandomUnitsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            allianceYavin4UnitsToolStripMenuItem = new ToolStripMenuItem();
            allianceHeadquarterUnitsToolStripMenuItem = new ToolStripMenuItem();
            empireCoruscantUnitsToolStripMenuItem = new ToolStripMenuItem();
            allianceFleetsToolStripMenuItem = new ToolStripMenuItem();
            empireFleetsToolStripMenuItem = new ToolStripMenuItem();
            Patch_ToolStripMenuItem = new ToolStripMenuItem();
            Export_ToolStripMenuItem = new ToolStripMenuItem();
            Windows_Menu = new ToolStripMenuItem();
            Cascade_ToolStripMenuItem = new ToolStripMenuItem();
            TileVertical_ToolStripMenuItem = new ToolStripMenuItem();
            TileHorizontal_ToolStripMenuItem = new ToolStripMenuItem();
            CloseAll_ToolStripMenuItem = new ToolStripMenuItem();
            ArrangeIcons_ToolStripMenuItem = new ToolStripMenuItem();
            Options_ToolStripMenuItem = new ToolStripMenuItem();
            Size1280x1024_ToolStripMenuItem = new ToolStripMenuItem();
            Size1024x768_ToolStripMenuItem = new ToolStripMenuItem();
            Size800x600_ToolStripMenuItem = new ToolStripMenuItem();
            Size640x480_ToolStripMenuItem = new ToolStripMenuItem();
            RestoreDefaults_ToolStripMenuItem = new ToolStripMenuItem();
            Help_Menu = new ToolStripMenuItem();
            About_ToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            Save_ToolStripStatusLabel = new ToolStripStatusLabel();
            roopDataStatus = new ToolStripStatusLabel();
            majorCharDataStatus = new ToolStripStatusLabel();
            minorCharDataStatus = new ToolStripStatusLabel();
            specOpDataStatus = new ToolStripStatusLabel();
            CapShipDataStatus = new ToolStripStatusLabel();
            fighterDataStatus = new ToolStripStatusLabel();
            ToolTip = new ToolTip(components);
            imageList1 = new ImageList(components);
            Sectors_Button = new ToolStripButton();
            Systems_Button = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            MajorCharacters_Button = new ToolStripButton();
            MinorCharacters_Button = new ToolStripButton();
            Troops_ToolStripButton = new ToolStripButton();
            SpecialForces_Button = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            CapitalShips_Button = new ToolStripButton();
            Fighters_Button = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            DefensiveFacilities_Button = new ToolStripButton();
            ManufacturingFacilities_Button = new ToolStripButton();
            ProductionFacilities_Button = new ToolStripButton();
            toolStrip = new ToolStrip();
            galaxyMapButton = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            Patch_Button = new ToolStripButton();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { File_Menu, Options_Menu, Editor_Menu, Windows_Menu, Help_Menu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.MdiWindowListItem = Windows_Menu;
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(1008, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // File_Menu
            // 
            File_Menu.DropDownItems.AddRange(new ToolStripItem[] { Exit_ToolStripMenuItem });
            File_Menu.ImageTransparentColor = SystemColors.ActiveBorder;
            File_Menu.Name = "File_Menu";
            File_Menu.Size = new Size(37, 20);
            File_Menu.Text = "&File";
            // 
            // Exit_ToolStripMenuItem
            // 
            Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem";
            Exit_ToolStripMenuItem.Size = new Size(93, 22);
            Exit_ToolStripMenuItem.Text = "Exit";
            Exit_ToolStripMenuItem.Click += Exit_ToolsStripMenuItem_Click;
            // 
            // Options_Menu
            // 
            Options_Menu.DropDownItems.AddRange(new ToolStripItem[] { DisplayToolBar_ToolStripMenuItem, DisplayStatusBar_ToolStripMenuItem, PlayMusic_ToolStripMenuItem, PlaySounds_ToolStripMenuItem, changeGameFolderToolStripMenuItem });
            Options_Menu.Name = "Options_Menu";
            Options_Menu.Size = new Size(61, 20);
            Options_Menu.Text = "&Options";
            // 
            // DisplayToolBar_ToolStripMenuItem
            // 
            DisplayToolBar_ToolStripMenuItem.AutoToolTip = true;
            DisplayToolBar_ToolStripMenuItem.Checked = true;
            DisplayToolBar_ToolStripMenuItem.CheckOnClick = true;
            DisplayToolBar_ToolStripMenuItem.CheckState = CheckState.Checked;
            DisplayToolBar_ToolStripMenuItem.Name = "DisplayToolBar_ToolStripMenuItem";
            DisplayToolBar_ToolStripMenuItem.Size = new Size(185, 22);
            DisplayToolBar_ToolStripMenuItem.Text = "Display Toolbar";
            DisplayToolBar_ToolStripMenuItem.Click += DisplayToolBar_ToolStripMenuItem_Click;
            // 
            // DisplayStatusBar_ToolStripMenuItem
            // 
            DisplayStatusBar_ToolStripMenuItem.Checked = true;
            DisplayStatusBar_ToolStripMenuItem.CheckOnClick = true;
            DisplayStatusBar_ToolStripMenuItem.CheckState = CheckState.Checked;
            DisplayStatusBar_ToolStripMenuItem.Name = "DisplayStatusBar_ToolStripMenuItem";
            DisplayStatusBar_ToolStripMenuItem.Size = new Size(185, 22);
            DisplayStatusBar_ToolStripMenuItem.Text = "Display Status Bar";
            DisplayStatusBar_ToolStripMenuItem.Click += DisplayStatusBar_ToolStripMenuItem_Click;
            // 
            // PlayMusic_ToolStripMenuItem
            // 
            PlayMusic_ToolStripMenuItem.Name = "PlayMusic_ToolStripMenuItem";
            PlayMusic_ToolStripMenuItem.Size = new Size(185, 22);
            PlayMusic_ToolStripMenuItem.Text = "Play Music";
            PlayMusic_ToolStripMenuItem.Click += PlayMusic_ToolStripMenuItem_Click;
            // 
            // PlaySounds_ToolStripMenuItem
            // 
            PlaySounds_ToolStripMenuItem.Name = "PlaySounds_ToolStripMenuItem";
            PlaySounds_ToolStripMenuItem.Size = new Size(185, 22);
            PlaySounds_ToolStripMenuItem.Text = "Play Sounds";
            PlaySounds_ToolStripMenuItem.Click += PlaySounds_ToolStripMenuItem_Click;
            // 
            // changeGameFolderToolStripMenuItem
            // 
            changeGameFolderToolStripMenuItem.Name = "changeGameFolderToolStripMenuItem";
            changeGameFolderToolStripMenuItem.Size = new Size(185, 22);
            changeGameFolderToolStripMenuItem.Text = "Change Game Folder";
            changeGameFolderToolStripMenuItem.Click += changeGameFolderToolStripMenuItem_Click;
            // 
            // Editor_Menu
            // 
            Editor_Menu.DropDownItems.AddRange(new ToolStripItem[] { Galaxy_ToolStripMenuItem, CharactersAndTroops_ToolStripMenuItem, Ships_ToolStripMenuItem, Facilities_ToolStripMenuItem, initialGameSetupToolStripMenuItem, Patch_ToolStripMenuItem, Export_ToolStripMenuItem });
            Editor_Menu.Name = "Editor_Menu";
            Editor_Menu.Size = new Size(50, 20);
            Editor_Menu.Text = "&Editor";
            // 
            // Galaxy_ToolStripMenuItem
            // 
            Galaxy_ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mapToolStripMenuItem, Sectors_ToolStripMenuItem, Systems_ToolStripMenuItem });
            Galaxy_ToolStripMenuItem.Image = Resources.galaxy_16x16_bmp;
            Galaxy_ToolStripMenuItem.Name = "Galaxy_ToolStripMenuItem";
            Galaxy_ToolStripMenuItem.Size = new Size(195, 22);
            Galaxy_ToolStripMenuItem.Text = "Galaxy";
            // 
            // mapToolStripMenuItem
            // 
            mapToolStripMenuItem.Image = Resources.galaxy_16x16_bmp;
            mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            mapToolStripMenuItem.Size = new Size(117, 22);
            mapToolStripMenuItem.Text = "Map";
            mapToolStripMenuItem.Click += Map_ToolStripMenuItem_Click;
            // 
            // Sectors_ToolStripMenuItem
            // 
            Sectors_ToolStripMenuItem.Image = Resources.sector_16x16_bmp;
            Sectors_ToolStripMenuItem.Name = "Sectors_ToolStripMenuItem";
            Sectors_ToolStripMenuItem.Size = new Size(117, 22);
            Sectors_ToolStripMenuItem.Text = "Sectors";
            Sectors_ToolStripMenuItem.Click += Sectors_ToolStripMenuItem_Click;
            // 
            // Systems_ToolStripMenuItem
            // 
            Systems_ToolStripMenuItem.Image = Resources.planet_37x37_bmp;
            Systems_ToolStripMenuItem.Name = "Systems_ToolStripMenuItem";
            Systems_ToolStripMenuItem.Size = new Size(117, 22);
            Systems_ToolStripMenuItem.Text = "Systems";
            Systems_ToolStripMenuItem.Click += Systems_ToolStripMenuItem_Click;
            // 
            // CharactersAndTroops_ToolStripMenuItem
            // 
            CharactersAndTroops_ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MajorCharacters_ToolStripMenuItem, MinorCharacters_ToolStripMenuItem, Troops_ToolStripMenuItem, SpecialForces_ToolStripMenuItem });
            CharactersAndTroops_ToolStripMenuItem.Image = Resources.luke_16x16_bmp;
            CharactersAndTroops_ToolStripMenuItem.Name = "CharactersAndTroops_ToolStripMenuItem";
            CharactersAndTroops_ToolStripMenuItem.Size = new Size(195, 22);
            CharactersAndTroops_ToolStripMenuItem.Text = "Characters and Troops";
            // 
            // MajorCharacters_ToolStripMenuItem
            // 
            MajorCharacters_ToolStripMenuItem.Image = Resources.luke_16x16_bmp;
            MajorCharacters_ToolStripMenuItem.Name = "MajorCharacters_ToolStripMenuItem";
            MajorCharacters_ToolStripMenuItem.Size = new Size(165, 22);
            MajorCharacters_ToolStripMenuItem.Text = "Major Characters";
            MajorCharacters_ToolStripMenuItem.Click += MajorCharacters_ToolStripMenuItem_Click;
            // 
            // MinorCharacters_ToolStripMenuItem
            // 
            MinorCharacters_ToolStripMenuItem.Image = Resources.thrawn_16x16_bmp;
            MinorCharacters_ToolStripMenuItem.Name = "MinorCharacters_ToolStripMenuItem";
            MinorCharacters_ToolStripMenuItem.Size = new Size(165, 22);
            MinorCharacters_ToolStripMenuItem.Text = "Minor Characters";
            MinorCharacters_ToolStripMenuItem.Click += MinorCharacters_ToolStripMenuItem_Click;
            // 
            // Troops_ToolStripMenuItem
            // 
            Troops_ToolStripMenuItem.Image = Resources.stormtrooper_16x16_bmp;
            Troops_ToolStripMenuItem.Name = "Troops_ToolStripMenuItem";
            Troops_ToolStripMenuItem.Size = new Size(165, 22);
            Troops_ToolStripMenuItem.Text = "Troops";
            Troops_ToolStripMenuItem.Click += Troops_ToolStripMenuItem_Click;
            // 
            // SpecialForces_ToolStripMenuItem
            // 
            SpecialForces_ToolStripMenuItem.Image = Resources.c3po_16x16_bmp;
            SpecialForces_ToolStripMenuItem.Name = "SpecialForces_ToolStripMenuItem";
            SpecialForces_ToolStripMenuItem.Size = new Size(165, 22);
            SpecialForces_ToolStripMenuItem.Text = "Special Forces";
            SpecialForces_ToolStripMenuItem.Click += SpecialForces_ToolStripMenuItem_Click;
            // 
            // Ships_ToolStripMenuItem
            // 
            Ships_ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CapitalShips_ToolStripMenuItem, Fighters_ToolStripMenuItem });
            Ships_ToolStripMenuItem.Image = Resources.star_destroyer_16x16_bmp;
            Ships_ToolStripMenuItem.Name = "Ships_ToolStripMenuItem";
            Ships_ToolStripMenuItem.Size = new Size(195, 22);
            Ships_ToolStripMenuItem.Text = "Ships";
            // 
            // CapitalShips_ToolStripMenuItem
            // 
            CapitalShips_ToolStripMenuItem.Image = Resources.star_destroyer_16x16_bmp;
            CapitalShips_ToolStripMenuItem.Name = "CapitalShips_ToolStripMenuItem";
            CapitalShips_ToolStripMenuItem.Size = new Size(142, 22);
            CapitalShips_ToolStripMenuItem.Text = "Capital Ships";
            CapitalShips_ToolStripMenuItem.Click += CapitalShips_ToolStripMenuItem_Click;
            // 
            // Fighters_ToolStripMenuItem
            // 
            Fighters_ToolStripMenuItem.Image = Resources.tie_fighter_16x16_bmp;
            Fighters_ToolStripMenuItem.Name = "Fighters_ToolStripMenuItem";
            Fighters_ToolStripMenuItem.Size = new Size(142, 22);
            Fighters_ToolStripMenuItem.Text = "Fighters";
            Fighters_ToolStripMenuItem.Click += Fighters_ToolStripMenuItem_Click;
            // 
            // Facilities_ToolStripMenuItem
            // 
            Facilities_ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DefensiveFacilities_ToolStripMenuItem, ManufacturingFacilities_ToolStripMenuItem, ProductionFacilties_ToolStripMenuItem });
            Facilities_ToolStripMenuItem.Image = Resources.mine_16x16_bmp;
            Facilities_ToolStripMenuItem.Name = "Facilities_ToolStripMenuItem";
            Facilities_ToolStripMenuItem.Size = new Size(195, 22);
            Facilities_ToolStripMenuItem.Text = "Facilities";
            // 
            // DefensiveFacilities_ToolStripMenuItem
            // 
            DefensiveFacilities_ToolStripMenuItem.Image = Resources.defense_facility_16x16_bmp;
            DefensiveFacilities_ToolStripMenuItem.Name = "DefensiveFacilities_ToolStripMenuItem";
            DefensiveFacilities_ToolStripMenuItem.Size = new Size(201, 22);
            DefensiveFacilities_ToolStripMenuItem.Text = "Defensive Facilities";
            DefensiveFacilities_ToolStripMenuItem.Click += Defensive_ToolStripMenuItem_Click;
            // 
            // ManufacturingFacilities_ToolStripMenuItem
            // 
            ManufacturingFacilities_ToolStripMenuItem.Image = Resources.shipyard_16x16_bmp;
            ManufacturingFacilities_ToolStripMenuItem.Name = "ManufacturingFacilities_ToolStripMenuItem";
            ManufacturingFacilities_ToolStripMenuItem.Size = new Size(201, 22);
            ManufacturingFacilities_ToolStripMenuItem.Text = "Manufacturing Facilities";
            ManufacturingFacilities_ToolStripMenuItem.Click += Manufacturing_ToolStripMenuItem_Click;
            // 
            // ProductionFacilties_ToolStripMenuItem
            // 
            ProductionFacilties_ToolStripMenuItem.Image = Resources.mine_16x16_bmp;
            ProductionFacilties_ToolStripMenuItem.Name = "ProductionFacilties_ToolStripMenuItem";
            ProductionFacilties_ToolStripMenuItem.Size = new Size(201, 22);
            ProductionFacilties_ToolStripMenuItem.Text = "Production Facilities";
            ProductionFacilties_ToolStripMenuItem.Click += Production_ToolStripMenuItem_Click;
            // 
            // initialGameSetupToolStripMenuItem
            // 
            initialGameSetupToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generalParametersToolStripMenuItem, sideParametersToolStripMenuItem, toolStripSeparator5, mineshardcodedInExeToolStripMenuItem, toolStripSeparator7, coreSystemsFacilitiesToolStripMenuItem, rimSystemsFacilitiesToolStripMenuItem, allianceHeadquarterFacilitiesToolStripMenuItem, empireCoruscantFacilitiesToolStripMenuItem, toolStripSeparator6, systemsGarrisonTroopsSideParams2435ToolStripMenuItem, systemsRandomUnitsSideParametersToolStripMenuItem, toolStripSeparator9, systemsRandomUnitsSideParams23ToolStripMenuItem, allianceRandomUnitsToolStripMenuItem, empireRandomUnitsToolStripMenuItem, toolStripSeparator8, allianceYavin4UnitsToolStripMenuItem, allianceHeadquarterUnitsToolStripMenuItem, empireCoruscantUnitsToolStripMenuItem, allianceFleetsToolStripMenuItem, empireFleetsToolStripMenuItem });
            initialGameSetupToolStripMenuItem.Name = "initialGameSetupToolStripMenuItem";
            initialGameSetupToolStripMenuItem.Size = new Size(195, 22);
            initialGameSetupToolStripMenuItem.Text = "Initial Game Setup";
            // 
            // generalParametersToolStripMenuItem
            // 
            generalParametersToolStripMenuItem.Name = "generalParametersToolStripMenuItem";
            generalParametersToolStripMenuItem.Size = new Size(370, 22);
            generalParametersToolStripMenuItem.Text = "General Parameters";
            generalParametersToolStripMenuItem.Click += generalParametersToolStripMenuItem_Click;
            // 
            // sideParametersToolStripMenuItem
            // 
            sideParametersToolStripMenuItem.Name = "sideParametersToolStripMenuItem";
            sideParametersToolStripMenuItem.Size = new Size(370, 22);
            sideParametersToolStripMenuItem.Text = "Side Parameters";
            sideParametersToolStripMenuItem.Click += sideParametersToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(367, 6);
            // 
            // mineshardcodedInExeToolStripMenuItem
            // 
            mineshardcodedInExeToolStripMenuItem.Enabled = false;
            mineshardcodedInExeToolStripMenuItem.Name = "mineshardcodedInExeToolStripMenuItem";
            mineshardcodedInExeToolStripMenuItem.Size = new Size(370, 22);
            mineshardcodedInExeToolStripMenuItem.Text = "Mines (hardcoded in exe)";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(367, 6);
            // 
            // coreSystemsFacilitiesToolStripMenuItem
            // 
            coreSystemsFacilitiesToolStripMenuItem.Name = "coreSystemsFacilitiesToolStripMenuItem";
            coreSystemsFacilitiesToolStripMenuItem.Size = new Size(370, 22);
            coreSystemsFacilitiesToolStripMenuItem.Text = "Core Systems: Facilities";
            coreSystemsFacilitiesToolStripMenuItem.Click += coreSystemsFacilitiesToolStripMenuItem_Click;
            // 
            // rimSystemsFacilitiesToolStripMenuItem
            // 
            rimSystemsFacilitiesToolStripMenuItem.Name = "rimSystemsFacilitiesToolStripMenuItem";
            rimSystemsFacilitiesToolStripMenuItem.Size = new Size(370, 22);
            rimSystemsFacilitiesToolStripMenuItem.Text = "Rim Systems: Facilities";
            rimSystemsFacilitiesToolStripMenuItem.Click += rimSystemsFacilitiesToolStripMenuItem_Click;
            // 
            // allianceHeadquarterFacilitiesToolStripMenuItem
            // 
            allianceHeadquarterFacilitiesToolStripMenuItem.Name = "allianceHeadquarterFacilitiesToolStripMenuItem";
            allianceHeadquarterFacilitiesToolStripMenuItem.Size = new Size(370, 22);
            allianceHeadquarterFacilitiesToolStripMenuItem.Text = "Alliance: Headquarter Facilities";
            allianceHeadquarterFacilitiesToolStripMenuItem.Click += allianceHeadquarterFacilitiesToolStripMenuItem_Click;
            // 
            // empireCoruscantFacilitiesToolStripMenuItem
            // 
            empireCoruscantFacilitiesToolStripMenuItem.Name = "empireCoruscantFacilitiesToolStripMenuItem";
            empireCoruscantFacilitiesToolStripMenuItem.Size = new Size(370, 22);
            empireCoruscantFacilitiesToolStripMenuItem.Text = "Empire: Coruscant Facilities";
            empireCoruscantFacilitiesToolStripMenuItem.Click += empireCoruscantFacilitiesToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(367, 6);
            // 
            // systemsGarrisonTroopsSideParams2435ToolStripMenuItem
            // 
            systemsGarrisonTroopsSideParams2435ToolStripMenuItem.Enabled = false;
            systemsGarrisonTroopsSideParams2435ToolStripMenuItem.Name = "systemsGarrisonTroopsSideParams2435ToolStripMenuItem";
            systemsGarrisonTroopsSideParams2435ToolStripMenuItem.Size = new Size(370, 22);
            systemsGarrisonTroopsSideParams2435ToolStripMenuItem.Text = "Core Systems: Garrison Troops (Side Params 34-35)";
            // 
            // systemsRandomUnitsSideParametersToolStripMenuItem
            // 
            systemsRandomUnitsSideParametersToolStripMenuItem.Enabled = false;
            systemsRandomUnitsSideParametersToolStripMenuItem.Name = "systemsRandomUnitsSideParametersToolStripMenuItem";
            systemsRandomUnitsSideParametersToolStripMenuItem.Size = new Size(370, 22);
            systemsRandomUnitsSideParametersToolStripMenuItem.Text = "Core Systems: Garrison Troops (General Params 207-208)";
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(367, 6);
            // 
            // systemsRandomUnitsSideParams23ToolStripMenuItem
            // 
            systemsRandomUnitsSideParams23ToolStripMenuItem.Enabled = false;
            systemsRandomUnitsSideParams23ToolStripMenuItem.Name = "systemsRandomUnitsSideParams23ToolStripMenuItem";
            systemsRandomUnitsSideParams23ToolStripMenuItem.Size = new Size(370, 22);
            systemsRandomUnitsSideParams23ToolStripMenuItem.Text = "Systems: Random Units (Side Params 21-23)";
            // 
            // allianceRandomUnitsToolStripMenuItem
            // 
            allianceRandomUnitsToolStripMenuItem.Name = "allianceRandomUnitsToolStripMenuItem";
            allianceRandomUnitsToolStripMenuItem.Size = new Size(370, 22);
            allianceRandomUnitsToolStripMenuItem.Text = "Alliance: Random Units";
            allianceRandomUnitsToolStripMenuItem.Click += allianceRandomUnitsToolStripMenuItem_Click;
            // 
            // empireRandomUnitsToolStripMenuItem
            // 
            empireRandomUnitsToolStripMenuItem.Name = "empireRandomUnitsToolStripMenuItem";
            empireRandomUnitsToolStripMenuItem.Size = new Size(370, 22);
            empireRandomUnitsToolStripMenuItem.Text = "Empire: Random Units";
            empireRandomUnitsToolStripMenuItem.Click += empireRandomUnitsToolStripMenuItem_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(367, 6);
            // 
            // allianceYavin4UnitsToolStripMenuItem
            // 
            allianceYavin4UnitsToolStripMenuItem.Name = "allianceYavin4UnitsToolStripMenuItem";
            allianceYavin4UnitsToolStripMenuItem.Size = new Size(370, 22);
            allianceYavin4UnitsToolStripMenuItem.Text = "Alliance: Yavin 4 Units";
            allianceYavin4UnitsToolStripMenuItem.Click += allianceYavin4UnitsToolStripMenuItem_Click;
            // 
            // allianceHeadquarterUnitsToolStripMenuItem
            // 
            allianceHeadquarterUnitsToolStripMenuItem.Name = "allianceHeadquarterUnitsToolStripMenuItem";
            allianceHeadquarterUnitsToolStripMenuItem.Size = new Size(370, 22);
            allianceHeadquarterUnitsToolStripMenuItem.Text = "Alliance: Headquarter Units";
            allianceHeadquarterUnitsToolStripMenuItem.Click += allianceHeadquarterUnitsToolStripMenuItem_Click;
            // 
            // empireCoruscantUnitsToolStripMenuItem
            // 
            empireCoruscantUnitsToolStripMenuItem.Name = "empireCoruscantUnitsToolStripMenuItem";
            empireCoruscantUnitsToolStripMenuItem.Size = new Size(370, 22);
            empireCoruscantUnitsToolStripMenuItem.Text = "Empire: Coruscant Units";
            empireCoruscantUnitsToolStripMenuItem.Click += empireCoruscantUnitsToolStripMenuItem_Click;
            // 
            // allianceFleetsToolStripMenuItem
            // 
            allianceFleetsToolStripMenuItem.Name = "allianceFleetsToolStripMenuItem";
            allianceFleetsToolStripMenuItem.Size = new Size(370, 22);
            allianceFleetsToolStripMenuItem.Text = "Alliance: Fleet (Headquarter or Yavin 4)";
            allianceFleetsToolStripMenuItem.Click += allianceFleetToolStripMenuItem_Click;
            // 
            // empireFleetsToolStripMenuItem
            // 
            empireFleetsToolStripMenuItem.Name = "empireFleetsToolStripMenuItem";
            empireFleetsToolStripMenuItem.Size = new Size(370, 22);
            empireFleetsToolStripMenuItem.Text = "Empire: Fleet (Coruscant)";
            empireFleetsToolStripMenuItem.Click += empireFleetToolStripMenuItem_Click;
            // 
            // Patch_ToolStripMenuItem
            // 
            Patch_ToolStripMenuItem.Image = Resources.death_star_16x16xbmp;
            Patch_ToolStripMenuItem.Name = "Patch_ToolStripMenuItem";
            Patch_ToolStripMenuItem.Size = new Size(195, 22);
            Patch_ToolStripMenuItem.Text = "25th Anniversary Patch";
            Patch_ToolStripMenuItem.Click += Patch_ToolStripMenuItem_Click;
            // 
            // Export_ToolStripMenuItem
            // 
            Export_ToolStripMenuItem.Name = "Export_ToolStripMenuItem";
            Export_ToolStripMenuItem.Size = new Size(195, 22);
            Export_ToolStripMenuItem.Text = "Export Game Data";
            Export_ToolStripMenuItem.Click += Export_ToolStripMenuItem_Click;
            // 
            // Windows_Menu
            // 
            Windows_Menu.DropDownItems.AddRange(new ToolStripItem[] { Cascade_ToolStripMenuItem, TileVertical_ToolStripMenuItem, TileHorizontal_ToolStripMenuItem, CloseAll_ToolStripMenuItem, ArrangeIcons_ToolStripMenuItem, Options_ToolStripMenuItem });
            Windows_Menu.Name = "Windows_Menu";
            Windows_Menu.Size = new Size(68, 20);
            Windows_Menu.Text = "&Windows";
            // 
            // Cascade_ToolStripMenuItem
            // 
            Cascade_ToolStripMenuItem.Name = "Cascade_ToolStripMenuItem";
            Cascade_ToolStripMenuItem.Size = new Size(150, 22);
            Cascade_ToolStripMenuItem.Text = "Cascade";
            Cascade_ToolStripMenuItem.Click += Cascade_ToolStripMenuItem_Click;
            // 
            // TileVertical_ToolStripMenuItem
            // 
            TileVertical_ToolStripMenuItem.Name = "TileVertical_ToolStripMenuItem";
            TileVertical_ToolStripMenuItem.Size = new Size(150, 22);
            TileVertical_ToolStripMenuItem.Text = "Tile Vertical";
            TileVertical_ToolStripMenuItem.Click += TileVertical_ToolStripMenuItem_Click;
            // 
            // TileHorizontal_ToolStripMenuItem
            // 
            TileHorizontal_ToolStripMenuItem.Name = "TileHorizontal_ToolStripMenuItem";
            TileHorizontal_ToolStripMenuItem.Size = new Size(150, 22);
            TileHorizontal_ToolStripMenuItem.Text = "Tile Horizontal";
            TileHorizontal_ToolStripMenuItem.Click += TileHorizontal_ToolStripMenuItem_Click;
            // 
            // CloseAll_ToolStripMenuItem
            // 
            CloseAll_ToolStripMenuItem.Name = "CloseAll_ToolStripMenuItem";
            CloseAll_ToolStripMenuItem.Size = new Size(150, 22);
            CloseAll_ToolStripMenuItem.Text = "Close All";
            CloseAll_ToolStripMenuItem.Click += CloseAll_ToolStripMenuItem_Click;
            // 
            // ArrangeIcons_ToolStripMenuItem
            // 
            ArrangeIcons_ToolStripMenuItem.Name = "ArrangeIcons_ToolStripMenuItem";
            ArrangeIcons_ToolStripMenuItem.Size = new Size(150, 22);
            ArrangeIcons_ToolStripMenuItem.Text = "Arrange Icons";
            ArrangeIcons_ToolStripMenuItem.Click += ArrangeIcons_ToolStripMenuItem_Click;
            // 
            // Options_ToolStripMenuItem
            // 
            Options_ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Size1280x1024_ToolStripMenuItem, Size1024x768_ToolStripMenuItem, Size800x600_ToolStripMenuItem, Size640x480_ToolStripMenuItem, RestoreDefaults_ToolStripMenuItem });
            Options_ToolStripMenuItem.Name = "Options_ToolStripMenuItem";
            Options_ToolStripMenuItem.Size = new Size(150, 22);
            Options_ToolStripMenuItem.Text = "Options";
            // 
            // Size1280x1024_ToolStripMenuItem
            // 
            Size1280x1024_ToolStripMenuItem.Name = "Size1280x1024_ToolStripMenuItem";
            Size1280x1024_ToolStripMenuItem.Size = new Size(159, 22);
            Size1280x1024_ToolStripMenuItem.Text = "Size 1280x1024";
            Size1280x1024_ToolStripMenuItem.Click += Size1280x1024_ToolStripMenuItem_Click;
            // 
            // Size1024x768_ToolStripMenuItem
            // 
            Size1024x768_ToolStripMenuItem.Name = "Size1024x768_ToolStripMenuItem";
            Size1024x768_ToolStripMenuItem.Size = new Size(159, 22);
            Size1024x768_ToolStripMenuItem.Text = "Size 1024x768";
            Size1024x768_ToolStripMenuItem.Click += Size1024x768_ToolStripMenuItem_Click;
            // 
            // Size800x600_ToolStripMenuItem
            // 
            Size800x600_ToolStripMenuItem.Name = "Size800x600_ToolStripMenuItem";
            Size800x600_ToolStripMenuItem.Size = new Size(159, 22);
            Size800x600_ToolStripMenuItem.Text = "Size 800x600";
            Size800x600_ToolStripMenuItem.Click += Size800x600_ToolStripMenuItem_Click;
            // 
            // Size640x480_ToolStripMenuItem
            // 
            Size640x480_ToolStripMenuItem.Name = "Size640x480_ToolStripMenuItem";
            Size640x480_ToolStripMenuItem.Size = new Size(159, 22);
            Size640x480_ToolStripMenuItem.Text = "Size 640x480";
            Size640x480_ToolStripMenuItem.Click += Size640x480_ToolStripMenuItem_Click;
            // 
            // RestoreDefaults_ToolStripMenuItem
            // 
            RestoreDefaults_ToolStripMenuItem.Name = "RestoreDefaults_ToolStripMenuItem";
            RestoreDefaults_ToolStripMenuItem.Size = new Size(159, 22);
            RestoreDefaults_ToolStripMenuItem.Text = "Restore Defaults";
            RestoreDefaults_ToolStripMenuItem.Click += RestoreDefaults_ToolStripMenuItem_Click;
            // 
            // Help_Menu
            // 
            Help_Menu.DropDownItems.AddRange(new ToolStripItem[] { About_ToolStripMenuItem });
            Help_Menu.Name = "Help_Menu";
            Help_Menu.Size = new Size(44, 20);
            Help_Menu.Text = "&Help";
            // 
            // About_ToolStripMenuItem
            // 
            About_ToolStripMenuItem.Name = "About_ToolStripMenuItem";
            About_ToolStripMenuItem.Size = new Size(107, 22);
            About_ToolStripMenuItem.Text = "&About";
            About_ToolStripMenuItem.Click += About_ToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { Save_ToolStripStatusLabel, roopDataStatus, majorCharDataStatus, minorCharDataStatus, specOpDataStatus, CapShipDataStatus, fighterDataStatus });
            statusStrip.Location = new Point(0, 707);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1008, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            ToolTip.SetToolTip(statusStrip, "TBD");
            // 
            // Save_ToolStripStatusLabel
            // 
            Save_ToolStripStatusLabel.Name = "Save_ToolStripStatusLabel";
            Save_ToolStripStatusLabel.Size = new Size(130, 17);
            Save_ToolStripStatusLabel.Text = "Save Status: (not in yet)";
            // 
            // roopDataStatus
            // 
            roopDataStatus.Name = "roopDataStatus";
            roopDataStatus.Padding = new Padding(10, 0, 10, 0);
            roopDataStatus.Size = new Size(105, 17);
            roopDataStatus.Text = "Unsaved Troop";
            // 
            // majorCharDataStatus
            // 
            majorCharDataStatus.Name = "majorCharDataStatus";
            majorCharDataStatus.Padding = new Padding(10, 0, 10, 0);
            majorCharDataStatus.Size = new Size(109, 17);
            majorCharDataStatus.Text = "Unsaved Major ";
            // 
            // minorCharDataStatus
            // 
            minorCharDataStatus.Name = "minorCharDataStatus";
            minorCharDataStatus.Padding = new Padding(10, 0, 10, 0);
            minorCharDataStatus.Size = new Size(107, 17);
            minorCharDataStatus.Text = "Unsaved Minor";
            // 
            // specOpDataStatus
            // 
            specOpDataStatus.Name = "specOpDataStatus";
            specOpDataStatus.Padding = new Padding(10, 0, 10, 0);
            specOpDataStatus.Size = new Size(116, 17);
            specOpDataStatus.Text = "Unsaved SpecOp";
            // 
            // CapShipDataStatus
            // 
            CapShipDataStatus.Name = "CapShipDataStatus";
            CapShipDataStatus.Size = new Size(102, 17);
            CapShipDataStatus.Text = "Unsaved Cap Ship";
            // 
            // fighterDataStatus
            // 
            fighterDataStatus.Name = "fighterDataStatus";
            fighterDataStatus.Size = new Size(92, 17);
            fighterDataStatus.Text = "Unsaved Fighter";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Sectors_Button
            // 
            Sectors_Button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Sectors_Button.Image = Resources.sector_16x16_bmp;
            Sectors_Button.ImageTransparentColor = Color.Magenta;
            Sectors_Button.Name = "Sectors_Button";
            Sectors_Button.Size = new Size(23, 22);
            Sectors_Button.ToolTipText = "Sectors";
            Sectors_Button.Click += Sectors_Button_Click;
            // 
            // Systems_Button
            // 
            Systems_Button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Systems_Button.Image = Resources.planet_37x37_bmp;
            Systems_Button.ImageTransparentColor = Color.Magenta;
            Systems_Button.Name = "Systems_Button";
            Systems_Button.Size = new Size(23, 22);
            Systems_Button.ToolTipText = "Systems";
            Systems_Button.Click += Systems_Button_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // MajorCharacters_Button
            // 
            MajorCharacters_Button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            MajorCharacters_Button.Image = Resources.luke_16x16_bmp;
            MajorCharacters_Button.ImageTransparentColor = Color.Magenta;
            MajorCharacters_Button.Name = "MajorCharacters_Button";
            MajorCharacters_Button.Size = new Size(23, 22);
            MajorCharacters_Button.ToolTipText = "Major Characters";
            MajorCharacters_Button.Click += MajorCharacters_Button_Click;
            // 
            // MinorCharacters_Button
            // 
            MinorCharacters_Button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            MinorCharacters_Button.Image = Resources.thrawn_16x16_bmp;
            MinorCharacters_Button.ImageTransparentColor = Color.Magenta;
            MinorCharacters_Button.Name = "MinorCharacters_Button";
            MinorCharacters_Button.Size = new Size(23, 22);
            MinorCharacters_Button.ToolTipText = "Minor Characters";
            MinorCharacters_Button.Click += MinorCharacters_Button_Click;
            // 
            // Troops_ToolStripButton
            // 
            Troops_ToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Troops_ToolStripButton.Image = Resources.stormtrooper_16x16_bmp;
            Troops_ToolStripButton.ImageTransparentColor = Color.Magenta;
            Troops_ToolStripButton.Name = "Troops_ToolStripButton";
            Troops_ToolStripButton.Size = new Size(23, 22);
            Troops_ToolStripButton.ToolTipText = "Troops ";
            Troops_ToolStripButton.Click += Troops_ToolStripButton_Click;
            // 
            // SpecialForces_Button
            // 
            SpecialForces_Button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SpecialForces_Button.Image = Resources.c3po_16x16_bmp;
            SpecialForces_Button.ImageTransparentColor = Color.Magenta;
            SpecialForces_Button.Name = "SpecialForces_Button";
            SpecialForces_Button.Size = new Size(23, 22);
            SpecialForces_Button.ToolTipText = "Special Forces";
            SpecialForces_Button.Click += SpecialForces_Button_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // CapitalShips_Button
            // 
            CapitalShips_Button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            CapitalShips_Button.Image = Resources.star_destroyer_16x16_bmp;
            CapitalShips_Button.ImageTransparentColor = Color.Magenta;
            CapitalShips_Button.Name = "CapitalShips_Button";
            CapitalShips_Button.Size = new Size(23, 22);
            CapitalShips_Button.ToolTipText = "Capital Ships";
            CapitalShips_Button.Click += CapitalShips_Button_Click;
            // 
            // Fighters_Button
            // 
            Fighters_Button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Fighters_Button.Image = Resources.tie_fighter_16x16_bmp;
            Fighters_Button.ImageTransparentColor = Color.Magenta;
            Fighters_Button.Name = "Fighters_Button";
            Fighters_Button.Size = new Size(23, 22);
            Fighters_Button.ToolTipText = "Fighters";
            Fighters_Button.Click += Fighter_Button_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // DefensiveFacilities_Button
            // 
            DefensiveFacilities_Button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            DefensiveFacilities_Button.Image = Resources.defense_facility_16x16_bmp;
            DefensiveFacilities_Button.ImageTransparentColor = Color.Magenta;
            DefensiveFacilities_Button.Name = "DefensiveFacilities_Button";
            DefensiveFacilities_Button.Size = new Size(23, 22);
            DefensiveFacilities_Button.ToolTipText = "Defensive Facilities";
            DefensiveFacilities_Button.Click += Defensive_Button_Click;
            // 
            // ManufacturingFacilities_Button
            // 
            ManufacturingFacilities_Button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ManufacturingFacilities_Button.Image = Resources.shipyard_16x16_bmp;
            ManufacturingFacilities_Button.ImageTransparentColor = Color.Magenta;
            ManufacturingFacilities_Button.Name = "ManufacturingFacilities_Button";
            ManufacturingFacilities_Button.Size = new Size(23, 22);
            ManufacturingFacilities_Button.ToolTipText = "Manufacturing Facilities";
            ManufacturingFacilities_Button.Click += Manufacturing_Button_Click;
            // 
            // ProductionFacilities_Button
            // 
            ProductionFacilities_Button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ProductionFacilities_Button.Image = Resources.mine_16x16_bmp;
            ProductionFacilities_Button.ImageTransparentColor = Color.Magenta;
            ProductionFacilities_Button.Name = "ProductionFacilities_Button";
            ProductionFacilities_Button.Size = new Size(23, 22);
            ProductionFacilities_Button.ToolTipText = "Production Facilities";
            ProductionFacilities_Button.Click += Production_Button_Click;
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new ToolStripItem[] { galaxyMapButton, Sectors_Button, Systems_Button, toolStripSeparator1, MajorCharacters_Button, MinorCharacters_Button, Troops_ToolStripButton, SpecialForces_Button, toolStripSeparator2, CapitalShips_Button, Fighters_Button, toolStripSeparator3, DefensiveFacilities_Button, ManufacturingFacilities_Button, ProductionFacilities_Button, toolStripSeparator4, Patch_Button });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(1008, 25);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "ToolStrip";
            // 
            // galaxyMapButton
            // 
            galaxyMapButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            galaxyMapButton.Image = Resources.galaxy_16x16_bmp;
            galaxyMapButton.ImageTransparentColor = Color.Magenta;
            galaxyMapButton.Name = "galaxyMapButton";
            galaxyMapButton.Size = new Size(23, 22);
            galaxyMapButton.ToolTipText = "Galaxy map";
            galaxyMapButton.Click += Map_Button_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // Patch_Button
            // 
            Patch_Button.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Patch_Button.Image = Resources.death_star_16x16xbmp;
            Patch_Button.ImageTransparentColor = Color.Magenta;
            Patch_Button.Name = "Patch_Button";
            Patch_Button.Size = new Size(23, 22);
            Patch_Button.Text = "Patch";
            Patch_Button.Click += Patch_Button_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resources.galaxy_640x480_bmp;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(toolStrip);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            KeyPreview = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(640, 480);
            Name = "MainForm";
            Text = "Star Wars Rebellion Editor .NET";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private ToolStripButton galaxyMapButton;
        private ToolStripMenuItem mapToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton Patch_Button;
        private ToolStripMenuItem Patch_ToolStripMenuItem;
        private ToolStripMenuItem changeGameFolderToolStripMenuItem;
        private ToolStripMenuItem Export_ToolStripMenuItem;
        private ToolStripMenuItem initialGameSetupToolStripMenuItem;
        private ToolStripMenuItem allianceFleetsToolStripMenuItem;
        private ToolStripMenuItem allianceHeadquarterUnitsToolStripMenuItem;
        private ToolStripMenuItem allianceHeadquarterFacilitiesToolStripMenuItem;
        private ToolStripMenuItem allianceRandomUnitsToolStripMenuItem;
        private ToolStripMenuItem allianceYavin4UnitsToolStripMenuItem;
        private ToolStripMenuItem empireCoruscantUnitsToolStripMenuItem;
        private ToolStripMenuItem empireFleetsToolStripMenuItem;
        private ToolStripMenuItem empireRandomUnitsToolStripMenuItem;
        private ToolStripMenuItem empireCoruscantFacilitiesToolStripMenuItem;
        private ToolStripMenuItem generalParametersToolStripMenuItem;
        private ToolStripMenuItem sideParametersToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem coreSystemsFacilitiesToolStripMenuItem;
        private ToolStripMenuItem rimSystemsFacilitiesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem mineshardcodedInExeToolStripMenuItem;
        private ToolStripMenuItem systemsRandomUnitsSideParametersToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem systemsGarrisonTroopsSideParams2435ToolStripMenuItem;
        private ToolStripMenuItem systemsRandomUnitsSideParams23ToolStripMenuItem;
    }
}
#endregion
