using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class CapitalShipsForm
    {
        /// <summary>
        /////// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TrackBar selector;
        private Button Open;
        private Button SaveAs;
        private Button Cancel;
        private Button Ok;
        private RichTextBox encyText;
        private Label encyclopediaName;
        private Label idLabel;
        private NumericUpDown textStraDllId;
        private Label unkown3Label;
        private NumericUpDown unknown2;
        private NumericUpDown familyId;
        private Label familyLabel;
        private NumericUpDown nextProductionFacility;
        private Label secProdFacNumlabel;
        private Label prodLabel;
        private NumericUpDown productionFacility;
        private NumericUpDown unknownMoralHp;
        private Label UnkownMoralHPlabel;
        private NumericUpDown researchDifficulty;
        private Label resDiffLabel;
        private CheckBox isEmpireUnit;
        private CheckBox isAllianceUnit;
        private Label DetectionLabel;
        private NumericUpDown detectionRating;
        private Label researchLabel;
        private NumericUpDown researchOrder;
        private NumericUpDown maintenanceCost;
        private Label maintCostLabel;
        private PictureBox picture;
        private NumericUpDown constructionCost;
        private Label conCostLabel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox wepFPGroup;
        private Label wepTypeLabel;
        private Label wepForeLabel;
        private Label label6;
        private Label label5;
        private Label wepPortLabel;
        private Label wepAftLabel;
        private NumericUpDown turboLaserStar;
        private NumericUpDown turboLaserPort;
        private NumericUpDown turboLaserAft;
        private NumericUpDown turboLaserFore;
        private Label wepTurboLabel;
        private NumericUpDown ionCannonRange;
        private NumericUpDown ionCannonStar;
        private NumericUpDown ionCannonPort;
        private NumericUpDown ionCannonAft;
        private NumericUpDown turboLaserRange;
        private NumericUpDown ionCannonFore;
        private NumericUpDown laserCannonFore;
        private Label wepLaserLabel;
        private Label wepIonLabel;
        private NumericUpDown laserCannonRange;
        private NumericUpDown laserCannonStar;
        private NumericUpDown laserCannonPort;
        private NumericUpDown laserCannonAft;
        private GroupBox GravityGroup;
        private GroupBox tractorGroup;
        private GroupBox weaponsGroup;
        private NumericUpDown bombardmentMod;
        private NumericUpDown weaponsRecharge;
        private Label bombardLabel;
        private Label wepRechLabel;
        private NumericUpDown tractorBeamRange;
        private NumericUpDown tractorBeamPower;
        private Label tractRanLabel;
        private Label tractPowLabel;
        private NumericUpDown gravityUnknown2;
        private NumericUpDown gravityUnknown1;
        private CheckBox doesInterdiction;
        private Label gravWell2Label;
        private Label gravWell1Label;
        private TabPage tabPage3;
        private GroupBox researchGroup;
        private GroupBox costsGroup;
        private GroupBox buildByGroup;
        private GroupBox shieldGroup;
        private NumericUpDown shieldsRechargeRate;
        private Label shieldRechLabel;
        private NumericUpDown shieldsMaxCapacity;
        private Label shieldLabel;
        private GroupBox BasicGroup;
        private Label damageConLabel;
        private NumericUpDown damageControl;
        private Label hullLabel;
        private NumericUpDown hullStrength;
        private GroupBox sublightGroup;
        private Label hyperLabel;
        private NumericUpDown hyperdrivePrimary;
        private Label manuverLabel;
        private NumericUpDown sublightManoeuvrability;
        private Label sublightLabel;
        private NumericUpDown sublightSpeed;
        private Label hyper2Label;
        private NumericUpDown hyperdriveBackup;
        private GroupBox CarryGroup;
        private NumericUpDown cargoFighters;
        private Label fighterNumLabel;
        private NumericUpDown cargoTroops;
        private Label infRegNumLabel;
        private GroupBox hyperdriveGroup;
        private GroupBox groupBox13;
        private Label label30;
        private NumericUpDown ionCannonTotalFirePower;
        private Label label29;
        private NumericUpDown laserCannonTotalFirePower;
        private NumericUpDown turboLaserTotalFirePower;
        private Label label26;
        private Label label28;
        private Label label27;
        private Label label31;
        private NumericUpDown totalFirePower;
        private Label label16;
        private NumericUpDown capitalShipId;
        private Label label1;
        private Label familyIdHexLabel;
        private Label capitalShipIdHexLabel;


        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapitalShipsForm));

            this.Open = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.encyText = new System.Windows.Forms.RichTextBox();
            this.encyclopediaName = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.textStraDllId = new System.Windows.Forms.NumericUpDown();
            this.unkown3Label = new System.Windows.Forms.Label();
            this.unknown2 = new System.Windows.Forms.NumericUpDown();
            this.familyId = new System.Windows.Forms.NumericUpDown();
            this.familyLabel = new System.Windows.Forms.Label();
            this.nextProductionFacility = new System.Windows.Forms.NumericUpDown();
            this.secProdFacNumlabel = new System.Windows.Forms.Label();
            this.prodLabel = new System.Windows.Forms.Label();
            this.productionFacility = new System.Windows.Forms.NumericUpDown();
            this.unknownMoralHp = new System.Windows.Forms.NumericUpDown();
            this.UnkownMoralHPlabel = new System.Windows.Forms.Label();
            this.researchDifficulty = new System.Windows.Forms.NumericUpDown();
            this.resDiffLabel = new System.Windows.Forms.Label();
            this.isEmpireUnit = new System.Windows.Forms.CheckBox();
            this.isAllianceUnit = new System.Windows.Forms.CheckBox();
            this.selector = new System.Windows.Forms.TrackBar();
            this.DetectionLabel = new System.Windows.Forms.Label();
            this.detectionRating = new System.Windows.Forms.NumericUpDown();
            this.researchLabel = new System.Windows.Forms.Label();
            this.researchOrder = new System.Windows.Forms.NumericUpDown();
            this.maintenanceCost = new System.Windows.Forms.NumericUpDown();
            this.maintCostLabel = new System.Windows.Forms.Label();
            this.constructionCost = new System.Windows.Forms.NumericUpDown();
            this.conCostLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.weaponsGroup = new System.Windows.Forms.GroupBox();
            this.bombardmentMod = new System.Windows.Forms.NumericUpDown();
            this.weaponsRecharge = new System.Windows.Forms.NumericUpDown();
            this.bombardLabel = new System.Windows.Forms.Label();
            this.wepRechLabel = new System.Windows.Forms.Label();
            this.GravityGroup = new System.Windows.Forms.GroupBox();
            this.gravWell2Label = new System.Windows.Forms.Label();
            this.gravWell1Label = new System.Windows.Forms.Label();
            this.gravityUnknown2 = new System.Windows.Forms.NumericUpDown();
            this.gravityUnknown1 = new System.Windows.Forms.NumericUpDown();
            this.doesInterdiction = new System.Windows.Forms.CheckBox();
            this.tractorGroup = new System.Windows.Forms.GroupBox();
            this.tractorBeamRange = new System.Windows.Forms.NumericUpDown();
            this.tractorBeamPower = new System.Windows.Forms.NumericUpDown();
            this.tractRanLabel = new System.Windows.Forms.Label();
            this.tractPowLabel = new System.Windows.Forms.Label();
            this.wepFPGroup = new System.Windows.Forms.GroupBox();
            this.laserCannonRange = new System.Windows.Forms.NumericUpDown();
            this.laserCannonStar = new System.Windows.Forms.NumericUpDown();
            this.laserCannonPort = new System.Windows.Forms.NumericUpDown();
            this.laserCannonAft = new System.Windows.Forms.NumericUpDown();
            this.ionCannonRange = new System.Windows.Forms.NumericUpDown();
            this.ionCannonStar = new System.Windows.Forms.NumericUpDown();
            this.ionCannonPort = new System.Windows.Forms.NumericUpDown();
            this.ionCannonAft = new System.Windows.Forms.NumericUpDown();
            this.turboLaserRange = new System.Windows.Forms.NumericUpDown();
            this.ionCannonFore = new System.Windows.Forms.NumericUpDown();
            this.laserCannonFore = new System.Windows.Forms.NumericUpDown();
            this.wepLaserLabel = new System.Windows.Forms.Label();
            this.wepIonLabel = new System.Windows.Forms.Label();
            this.wepTurboLabel = new System.Windows.Forms.Label();
            this.turboLaserStar = new System.Windows.Forms.NumericUpDown();
            this.turboLaserPort = new System.Windows.Forms.NumericUpDown();
            this.turboLaserAft = new System.Windows.Forms.NumericUpDown();
            this.turboLaserFore = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wepPortLabel = new System.Windows.Forms.Label();
            this.wepAftLabel = new System.Windows.Forms.Label();
            this.wepForeLabel = new System.Windows.Forms.Label();
            this.wepTypeLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.capitalShipIdHexLabel = new System.Windows.Forms.Label();
            this.capitalShipId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.totalFirePower = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.ionCannonTotalFirePower = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.laserCannonTotalFirePower = new System.Windows.Forms.NumericUpDown();
            this.turboLaserTotalFirePower = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.researchGroup = new System.Windows.Forms.GroupBox();
            this.costsGroup = new System.Windows.Forms.GroupBox();
            this.buildByGroup = new System.Windows.Forms.GroupBox();
            this.shieldGroup = new System.Windows.Forms.GroupBox();
            this.shieldsRechargeRate = new System.Windows.Forms.NumericUpDown();
            this.shieldRechLabel = new System.Windows.Forms.Label();
            this.shieldsMaxCapacity = new System.Windows.Forms.NumericUpDown();
            this.shieldLabel = new System.Windows.Forms.Label();
            this.BasicGroup = new System.Windows.Forms.GroupBox();
            this.damageConLabel = new System.Windows.Forms.Label();
            this.damageControl = new System.Windows.Forms.NumericUpDown();
            this.hullLabel = new System.Windows.Forms.Label();
            this.hullStrength = new System.Windows.Forms.NumericUpDown();
            this.sublightGroup = new System.Windows.Forms.GroupBox();
            this.manuverLabel = new System.Windows.Forms.Label();
            this.sublightManoeuvrability = new System.Windows.Forms.NumericUpDown();
            this.sublightLabel = new System.Windows.Forms.Label();
            this.sublightSpeed = new System.Windows.Forms.NumericUpDown();
            this.hyperLabel = new System.Windows.Forms.Label();
            this.hyperdrivePrimary = new System.Windows.Forms.NumericUpDown();
            this.hyper2Label = new System.Windows.Forms.Label();
            this.hyperdriveBackup = new System.Windows.Forms.NumericUpDown();
            this.CarryGroup = new System.Windows.Forms.GroupBox();
            this.cargoFighters = new System.Windows.Forms.NumericUpDown();
            this.fighterNumLabel = new System.Windows.Forms.Label();
            this.cargoTroops = new System.Windows.Forms.NumericUpDown();
            this.infRegNumLabel = new System.Windows.Forms.Label();
            this.hyperdriveGroup = new System.Windows.Forms.GroupBox();
            this.picture = new System.Windows.Forms.PictureBox();

            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknownMoralHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectionRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constructionCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardmentMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponsRecharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravityUnknown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravityUnknown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractorBeamRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractorBeamPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonAft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonAft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turboLaserRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonFore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonFore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turboLaserStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turboLaserPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turboLaserAft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turboLaserFore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitalShipId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalFirePower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonTotalFirePower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonTotalFirePower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turboLaserTotalFirePower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldsRechargeRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldsMaxCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hullStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sublightManoeuvrability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sublightSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperdrivePrimary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperdriveBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoFighters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoTroops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();

            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.weaponsGroup.SuspendLayout();
            this.GravityGroup.SuspendLayout();
            this.tractorGroup.SuspendLayout();
            this.wepFPGroup.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.researchGroup.SuspendLayout();
            this.costsGroup.SuspendLayout();
            this.buildByGroup.SuspendLayout();
            this.shieldGroup.SuspendLayout();
            this.BasicGroup.SuspendLayout();
            this.sublightGroup.SuspendLayout();
            this.CarryGroup.SuspendLayout();
            this.hyperdriveGroup.SuspendLayout();
            this.SuspendLayout();

            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(373, 436);
            this.Open.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(88, 27);
            this.Open.TabIndex = 0;
            this.Open.TabStop = false;
            this.Open.Text = "Open...";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Location = new System.Drawing.Point(279, 436);
            this.SaveAs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(88, 27);
            this.SaveAs.TabIndex = 0;
            this.SaveAs.TabStop = false;
            this.SaveAs.Text = "&SaveAs...";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(108, 436);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 27);
            this.Cancel.TabIndex = 39;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(14, 436);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 38;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // encyText
            // 
            this.encyText.Cursor = System.Windows.Forms.Cursors.No;
            this.encyText.Enabled = false;
            this.encyText.Location = new System.Drawing.Point(0, 0);
            this.encyText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.encyText.Name = "encyText";
            this.encyText.Size = new System.Drawing.Size(448, 176);
            this.encyText.TabIndex = 0;
            this.encyText.TabStop = false;
            this.encyText.Text = "Not Implemented yet....Encylopedia Data...Will add .Someday";
            // 
            // ItemName
            // 
            this.encyclopediaName.AutoSize = true;
            this.encyclopediaName.Location = new System.Drawing.Point(245, 75);
            this.encyclopediaName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encyclopediaName.Name = "ItemName";
            this.encyclopediaName.Size = new System.Drawing.Size(116, 15);
            this.encyclopediaName.TabIndex = 0;
            this.encyclopediaName.Text = "-- Item name here --";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Enabled = false;
            this.idLabel.Location = new System.Drawing.Point(234, 174);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(85, 15);
            this.idLabel.TabIndex = 106;
            this.idLabel.Text = "TextStra.DLL ID";
            // 
            // textStraDllId
            // 
            this.textStraDllId.Enabled = false;
            this.textStraDllId.Location = new System.Drawing.Point(351, 172);
            this.textStraDllId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textStraDllId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.textStraDllId.Name = "textStraDllId";
            this.textStraDllId.Size = new System.Drawing.Size(59, 23);
            this.textStraDllId.TabIndex = 112;
            this.textStraDllId.TabStop = false;
            // 
            // unkown3Label
            // 
            this.unkown3Label.AutoSize = true;
            this.unkown3Label.Enabled = false;
            this.unkown3Label.Location = new System.Drawing.Point(234, 144);
            this.unkown3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unkown3Label.Name = "unkown3Label";
            this.unkown3Label.Size = new System.Drawing.Size(58, 15);
            this.unkown3Label.TabIndex = 109;
            this.unkown3Label.Text = "Unknown";
            // 
            // unknown
            // 
            this.unknown2.Enabled = false;
            this.unknown2.Location = new System.Drawing.Point(351, 142);
            this.unknown2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknown2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknown2.Name = "unknown";
            this.unknown2.Size = new System.Drawing.Size(59, 23);
            this.unknown2.TabIndex = 110;
            this.unknown2.TabStop = false;
            // 
            // familyId
            // 
            this.familyId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.familyId.Enabled = false;
            this.familyId.Location = new System.Drawing.Point(351, 112);
            this.familyId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.familyId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.familyId.Name = "familyId";
            this.familyId.Size = new System.Drawing.Size(59, 23);
            this.familyId.TabIndex = 111;
            this.familyId.TabStop = false;
            this.familyId.ValueChanged += new System.EventHandler(this.familyId_ValueChanged);
            // 
            // familyLabel
            // 
            this.familyLabel.AutoSize = true;
            this.familyLabel.Enabled = false;
            this.familyLabel.Location = new System.Drawing.Point(234, 117);
            this.familyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyLabel.Name = "familyLabel";
            this.familyLabel.Size = new System.Drawing.Size(56, 15);
            this.familyLabel.TabIndex = 104;
            this.familyLabel.Text = "Family ID";
            // 
            // nextProductionFacility
            // 
            this.nextProductionFacility.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nextProductionFacility.Enabled = false;
            this.nextProductionFacility.Location = new System.Drawing.Point(351, 82);
            this.nextProductionFacility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextProductionFacility.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nextProductionFacility.Name = "nextProductionFacility";
            this.nextProductionFacility.Size = new System.Drawing.Size(59, 23);
            this.nextProductionFacility.TabIndex = 96;
            this.nextProductionFacility.TabStop = false;
            this.nextProductionFacility.ValueChanged += new System.EventHandler(this.nextProductionFacility_ValueChanged);
            // 
            // secProdFacNumlabel
            // 
            this.secProdFacNumlabel.AutoSize = true;
            this.secProdFacNumlabel.Enabled = false;
            this.secProdFacNumlabel.Location = new System.Drawing.Point(234, 87);
            this.secProdFacNumlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secProdFacNumlabel.Name = "secProdFacNumlabel";
            this.secProdFacNumlabel.Size = new System.Drawing.Size(92, 15);
            this.secProdFacNumlabel.TabIndex = 97;
            this.secProdFacNumlabel.Text = "Prod Facility + 1";
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.Enabled = false;
            this.prodLabel.Location = new System.Drawing.Point(234, 57);
            this.prodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(106, 15);
            this.prodLabel.TabIndex = 95;
            this.prodLabel.Text = "Production Facility";
            // 
            // productionFacility
            // 
            this.productionFacility.BackColor = System.Drawing.SystemColors.ControlLight;
            this.productionFacility.Enabled = false;
            this.productionFacility.Location = new System.Drawing.Point(351, 51);
            this.productionFacility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productionFacility.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.productionFacility.Name = "productionFacility";
            this.productionFacility.Size = new System.Drawing.Size(59, 23);
            this.productionFacility.TabIndex = 93;
            this.productionFacility.TabStop = false;
            this.productionFacility.ValueChanged += new System.EventHandler(this.productionFacility_ValueChanged);
            // 
            // unknownMoralHp
            // 
            this.unknownMoralHp.BackColor = System.Drawing.SystemColors.Window;
            this.unknownMoralHp.Location = new System.Drawing.Point(351, 21);
            this.unknownMoralHp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknownMoralHp.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.unknownMoralHp.Name = "unknownMoralHp";
            this.unknownMoralHp.Size = new System.Drawing.Size(59, 23);
            this.unknownMoralHp.TabIndex = 125;
            this.unknownMoralHp.TabStop = false;
            this.unknownMoralHp.ValueChanged += new System.EventHandler(this.unknownMoralHp_ValueChanged);
            // 
            // UnkownMoralHPlabel
            // 
            this.UnkownMoralHPlabel.AutoSize = true;
            this.UnkownMoralHPlabel.Location = new System.Drawing.Point(234, 25);
            this.UnkownMoralHPlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnkownMoralHPlabel.Name = "UnkownMoralHPlabel";
            this.UnkownMoralHPlabel.Size = new System.Drawing.Size(95, 15);
            this.UnkownMoralHPlabel.TabIndex = 94;
            this.UnkownMoralHPlabel.Text = "Unknown - ?HP?";
            // 
            // researchDifficulty
            // 
            this.researchDifficulty.Location = new System.Drawing.Point(121, 55);
            this.researchDifficulty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchDifficulty.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchDifficulty.Name = "researchDifficulty";
            this.researchDifficulty.Size = new System.Drawing.Size(59, 23);
            this.researchDifficulty.TabIndex = 8;
            this.researchDifficulty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.researchDifficulty.ValueChanged += new System.EventHandler(this.researchDifficulty_ValueChanged);
            // 
            // resDiffLabel
            // 
            this.resDiffLabel.AutoSize = true;
            this.resDiffLabel.Location = new System.Drawing.Point(9, 55);
            this.resDiffLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resDiffLabel.Name = "resDiffLabel";
            this.resDiffLabel.Size = new System.Drawing.Size(55, 15);
            this.resDiffLabel.TabIndex = 0;
            this.resDiffLabel.Text = "Difficulty";
            // 
            // isEmpireUnit
            // 
            this.isEmpireUnit.AutoSize = true;
            this.isEmpireUnit.Location = new System.Drawing.Point(7, 48);
            this.isEmpireUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isEmpireUnit.Name = "isEmpireUnit";
            this.isEmpireUnit.Size = new System.Drawing.Size(94, 19);
            this.isEmpireUnit.TabIndex = 16;
            this.isEmpireUnit.Text = "Imperial Unit";
            this.isEmpireUnit.UseVisualStyleBackColor = true;
            this.isEmpireUnit.CheckedChanged += new System.EventHandler(this.isEmpireUnit_CheckedChanged);
            // 
            // isAllianceUnit
            // 
            this.isAllianceUnit.AutoSize = true;
            this.isAllianceUnit.Location = new System.Drawing.Point(7, 22);
            this.isAllianceUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isAllianceUnit.Name = "isAllianceUnit";
            this.isAllianceUnit.Size = new System.Drawing.Size(93, 19);
            this.isAllianceUnit.TabIndex = 15;
            this.isAllianceUnit.Text = "Alliance Unit";
            this.isAllianceUnit.UseVisualStyleBackColor = true;
            this.isAllianceUnit.CheckedChanged += new System.EventHandler(this.isAllianceUnit_CheckedChanged);
            // 
            // selector
            // 
            this.selector.LargeChange = 15;
            this.selector.Location = new System.Drawing.Point(248, 20);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 29;
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(121, 45);
            this.selector.TabIndex = 1;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            // 
            // DetectionLabel
            // 
            this.DetectionLabel.AutoSize = true;
            this.DetectionLabel.Location = new System.Drawing.Point(9, 52);
            this.DetectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DetectionLabel.Name = "DetectionLabel";
            this.DetectionLabel.Size = new System.Drawing.Size(98, 15);
            this.DetectionLabel.TabIndex = 0;
            this.DetectionLabel.Text = "Detection Rating ";
            // 
            // detectionRating
            // 
            this.detectionRating.Location = new System.Drawing.Point(121, 50);
            this.detectionRating.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.detectionRating.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.detectionRating.Name = "detectionRating";
            this.detectionRating.Size = new System.Drawing.Size(59, 23);
            this.detectionRating.TabIndex = 5;
            this.detectionRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.detectionRating.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.detectionRating.ValueChanged += new System.EventHandler(this.detectionRating_ValueChanged);
            // 
            // researchLabel
            // 
            this.researchLabel.AutoSize = true;
            this.researchLabel.Location = new System.Drawing.Point(9, 24);
            this.researchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.researchLabel.Name = "researchLabel";
            this.researchLabel.Size = new System.Drawing.Size(37, 15);
            this.researchLabel.TabIndex = 0;
            this.researchLabel.Text = "Order";
            // 
            // researchOrder
            // 
            this.researchOrder.Location = new System.Drawing.Point(121, 22);
            this.researchOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchOrder.Name = "researchOrder";
            this.researchOrder.Size = new System.Drawing.Size(59, 23);
            this.researchOrder.TabIndex = 7;
            this.researchOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.researchOrder.ValueChanged += new System.EventHandler(this.researchOrder_ValueChanged);
            // 
            // maintenanceCost
            // 
            this.maintenanceCost.Location = new System.Drawing.Point(121, 47);
            this.maintenanceCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maintenanceCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maintenanceCost.Name = "maintenanceCost";
            this.maintenanceCost.Size = new System.Drawing.Size(59, 23);
            this.maintenanceCost.TabIndex = 3;
            this.maintenanceCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maintenanceCost.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maintenanceCost.ValueChanged += new System.EventHandler(this.maintenanceCost_ValueChanged);
            // 
            // maintCostLabel
            // 
            this.maintCostLabel.AutoSize = true;
            this.maintCostLabel.Location = new System.Drawing.Point(7, 45);
            this.maintCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maintCostLabel.Name = "maintCostLabel";
            this.maintCostLabel.Size = new System.Drawing.Size(76, 15);
            this.maintCostLabel.TabIndex = 0;
            this.maintCostLabel.Text = "Maintenance";
            // 
            // constructionCost
            // 
            this.constructionCost.Location = new System.Drawing.Point(121, 17);
            this.constructionCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.constructionCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.constructionCost.Name = "constructionCost";
            this.constructionCost.Size = new System.Drawing.Size(59, 23);
            this.constructionCost.TabIndex = 2;
            this.constructionCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.constructionCost.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.constructionCost.ValueChanged += new System.EventHandler(this.constructionCost_ValueChanged);
            // 
            // conCostLabel
            // 
            this.conCostLabel.AutoSize = true;
            this.conCostLabel.Location = new System.Drawing.Point(7, 18);
            this.conCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conCostLabel.Name = "conCostLabel";
            this.conCostLabel.Size = new System.Drawing.Size(76, 15);
            this.conCostLabel.TabIndex = 0;
            this.conCostLabel.Text = "Construction";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(468, 104);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 362);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.weaponsGroup);
            this.tabPage1.Controls.Add(this.GravityGroup);
            this.tabPage1.Controls.Add(this.tractorGroup);
            this.tabPage1.Controls.Add(this.wepFPGroup);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(452, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Weapons";
            // 
            // weaponsGroup
            // 
            this.weaponsGroup.Controls.Add(this.bombardmentMod);
            this.weaponsGroup.Controls.Add(this.weaponsRecharge);
            this.weaponsGroup.Controls.Add(this.bombardLabel);
            this.weaponsGroup.Controls.Add(this.wepRechLabel);
            this.weaponsGroup.Location = new System.Drawing.Point(239, 158);
            this.weaponsGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.weaponsGroup.Name = "weaponsGroup";
            this.weaponsGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.weaponsGroup.Size = new System.Drawing.Size(198, 74);
            this.weaponsGroup.TabIndex = 12;
            this.weaponsGroup.TabStop = false;
            this.weaponsGroup.Text = "Weapons";
            // 
            // bombardmentMod
            // 
            this.bombardmentMod.Location = new System.Drawing.Point(102, 37);
            this.bombardmentMod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bombardmentMod.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bombardmentMod.Name = "bombardmentMod";
            this.bombardmentMod.Size = new System.Drawing.Size(59, 23);
            this.bombardmentMod.TabIndex = 37;
            this.bombardmentMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bombardmentMod.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bombardmentMod.ValueChanged += new System.EventHandler(this.bombardmentMod_ValueChanged);
            // 
            // weaponsRecharge
            // 
            this.weaponsRecharge.Location = new System.Drawing.Point(10, 37);
            this.weaponsRecharge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.weaponsRecharge.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.weaponsRecharge.Name = "weaponsRecharge";
            this.weaponsRecharge.Size = new System.Drawing.Size(59, 23);
            this.weaponsRecharge.TabIndex = 36;
            this.weaponsRecharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.weaponsRecharge.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.weaponsRecharge.ValueChanged += new System.EventHandler(this.weaponsRecharge_ValueChanged);
            // 
            // bombardLabel
            // 
            this.bombardLabel.AutoSize = true;
            this.bombardLabel.BackColor = System.Drawing.Color.LightGray;
            this.bombardLabel.Location = new System.Drawing.Point(77, 18);
            this.bombardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bombardLabel.Name = "bombardLabel";
            this.bombardLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bombardLabel.Size = new System.Drawing.Size(112, 15);
            this.bombardLabel.TabIndex = 0;
            this.bombardLabel.Text = "Bombardment Mod";
            this.bombardLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wepRechLabel
            // 
            this.wepRechLabel.AutoSize = true;
            this.wepRechLabel.BackColor = System.Drawing.Color.LightGray;
            this.wepRechLabel.Location = new System.Drawing.Point(7, 18);
            this.wepRechLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wepRechLabel.Name = "wepRechLabel";
            this.wepRechLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wepRechLabel.Size = new System.Drawing.Size(56, 15);
            this.wepRechLabel.TabIndex = 0;
            this.wepRechLabel.Text = "Recharge";
            this.wepRechLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GravityGroup
            // 
            this.GravityGroup.Controls.Add(this.gravWell2Label);
            this.GravityGroup.Controls.Add(this.gravWell1Label);
            this.GravityGroup.Controls.Add(this.gravityUnknown2);
            this.GravityGroup.Controls.Add(this.gravityUnknown1);
            this.GravityGroup.Controls.Add(this.doesInterdiction);
            this.GravityGroup.Location = new System.Drawing.Point(7, 254);
            this.GravityGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GravityGroup.Name = "GravityGroup";
            this.GravityGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GravityGroup.Size = new System.Drawing.Size(430, 66);
            this.GravityGroup.TabIndex = 13;
            this.GravityGroup.TabStop = false;
            this.GravityGroup.Text = "Gravity Well Generator";
            // 
            // gravWell2Label
            // 
            this.gravWell2Label.AutoSize = true;
            this.gravWell2Label.BackColor = System.Drawing.Color.LightGray;
            this.gravWell2Label.Location = new System.Drawing.Point(329, 18);
            this.gravWell2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gravWell2Label.Name = "gravWell2Label";
            this.gravWell2Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gravWell2Label.Size = new System.Drawing.Size(56, 15);
            this.gravWell2Label.TabIndex = 0;
            this.gravWell2Label.Text = "Raw Data";
            this.gravWell2Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gravWell1Label
            // 
            this.gravWell1Label.AutoSize = true;
            this.gravWell1Label.BackColor = System.Drawing.Color.LightGray;
            this.gravWell1Label.Location = new System.Drawing.Point(239, 18);
            this.gravWell1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gravWell1Label.Name = "gravWell1Label";
            this.gravWell1Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gravWell1Label.Size = new System.Drawing.Size(56, 15);
            this.gravWell1Label.TabIndex = 0;
            this.gravWell1Label.Text = "Raw Data";
            this.gravWell1Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gravityUnknown2
            // 
            this.gravityUnknown2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gravityUnknown2.Location = new System.Drawing.Point(332, 35);
            this.gravityUnknown2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gravityUnknown2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.gravityUnknown2.Name = "gravityUnknown2";
            this.gravityUnknown2.Size = new System.Drawing.Size(59, 23);
            this.gravityUnknown2.TabIndex = 0;
            this.gravityUnknown2.TabStop = false;
            this.gravityUnknown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gravityUnknown2.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.gravityUnknown2.ValueChanged += new System.EventHandler(this.gravityUnknown2_ValueChanged);
            // 
            // gravityUnknown1
            // 
            this.gravityUnknown1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gravityUnknown1.Location = new System.Drawing.Point(243, 36);
            this.gravityUnknown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gravityUnknown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.gravityUnknown1.Name = "gravityUnknown1";
            this.gravityUnknown1.Size = new System.Drawing.Size(59, 23);
            this.gravityUnknown1.TabIndex = 0;
            this.gravityUnknown1.TabStop = false;
            this.gravityUnknown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gravityUnknown1.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.gravityUnknown1.ValueChanged += new System.EventHandler(this.gravityUnknown1_ValueChanged);
            // 
            // doesInterdiction
            // 
            this.doesInterdiction.AutoSize = true;
            this.doesInterdiction.Location = new System.Drawing.Point(20, 28);
            this.doesInterdiction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.doesInterdiction.Name = "doesInterdiction";
            this.doesInterdiction.Size = new System.Drawing.Size(109, 19);
            this.doesInterdiction.TabIndex = 38;
            this.doesInterdiction.Text = "Full Interdiction";
            this.doesInterdiction.UseVisualStyleBackColor = true;
            this.doesInterdiction.CheckedChanged += new System.EventHandler(this.doesInterdiction_CheckedChanged);
            // 
            // tractorGroup
            // 
            this.tractorGroup.Controls.Add(this.tractorBeamRange);
            this.tractorGroup.Controls.Add(this.tractorBeamPower);
            this.tractorGroup.Controls.Add(this.tractRanLabel);
            this.tractorGroup.Controls.Add(this.tractPowLabel);
            this.tractorGroup.Location = new System.Drawing.Point(7, 158);
            this.tractorGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tractorGroup.Name = "tractorGroup";
            this.tractorGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tractorGroup.Size = new System.Drawing.Size(189, 74);
            this.tractorGroup.TabIndex = 11;
            this.tractorGroup.TabStop = false;
            this.tractorGroup.Text = "Tractor Beam";
            // 
            // tractorBeamRange
            // 
            this.tractorBeamRange.Location = new System.Drawing.Point(74, 37);
            this.tractorBeamRange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tractorBeamRange.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.tractorBeamRange.Name = "tractorBeamRange";
            this.tractorBeamRange.Size = new System.Drawing.Size(59, 23);
            this.tractorBeamRange.TabIndex = 35;
            this.tractorBeamRange.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.tractorBeamRange.ValueChanged += new System.EventHandler(this.tractorBeamRange_ValueChanged);
            // 
            // tractorBeamPower
            // 
            this.tractorBeamPower.Location = new System.Drawing.Point(7, 37);
            this.tractorBeamPower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tractorBeamPower.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.tractorBeamPower.Name = "tractorBeamPower";
            this.tractorBeamPower.Size = new System.Drawing.Size(59, 23);
            this.tractorBeamPower.TabIndex = 34;
            this.tractorBeamPower.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.tractorBeamPower.ValueChanged += new System.EventHandler(this.tractorBeamPower_ValueChanged);
            // 
            // tractRanLabel
            // 
            this.tractRanLabel.AutoSize = true;
            this.tractRanLabel.BackColor = System.Drawing.Color.LightGray;
            this.tractRanLabel.Location = new System.Drawing.Point(70, 18);
            this.tractRanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tractRanLabel.Name = "tractRanLabel";
            this.tractRanLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tractRanLabel.Size = new System.Drawing.Size(40, 15);
            this.tractRanLabel.TabIndex = 0;
            this.tractRanLabel.Text = "Range";
            this.tractRanLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tractPowLabel
            // 
            this.tractPowLabel.AutoSize = true;
            this.tractPowLabel.BackColor = System.Drawing.Color.LightGray;
            this.tractPowLabel.Location = new System.Drawing.Point(7, 18);
            this.tractPowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tractPowLabel.Name = "tractPowLabel";
            this.tractPowLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tractPowLabel.Size = new System.Drawing.Size(40, 15);
            this.tractPowLabel.TabIndex = 0;
            this.tractPowLabel.Text = "Power";
            this.tractPowLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wepFPGroup
            // 
            this.wepFPGroup.Controls.Add(this.laserCannonRange);
            this.wepFPGroup.Controls.Add(this.laserCannonStar);
            this.wepFPGroup.Controls.Add(this.laserCannonPort);
            this.wepFPGroup.Controls.Add(this.laserCannonAft);
            this.wepFPGroup.Controls.Add(this.ionCannonRange);
            this.wepFPGroup.Controls.Add(this.ionCannonStar);
            this.wepFPGroup.Controls.Add(this.ionCannonPort);
            this.wepFPGroup.Controls.Add(this.ionCannonAft);
            this.wepFPGroup.Controls.Add(this.turboLaserRange);
            this.wepFPGroup.Controls.Add(this.ionCannonFore);
            this.wepFPGroup.Controls.Add(this.laserCannonFore);
            this.wepFPGroup.Controls.Add(this.wepLaserLabel);
            this.wepFPGroup.Controls.Add(this.wepIonLabel);
            this.wepFPGroup.Controls.Add(this.wepTurboLabel);
            this.wepFPGroup.Controls.Add(this.turboLaserStar);
            this.wepFPGroup.Controls.Add(this.turboLaserPort);
            this.wepFPGroup.Controls.Add(this.turboLaserAft);
            this.wepFPGroup.Controls.Add(this.turboLaserFore);
            this.wepFPGroup.Controls.Add(this.label6);
            this.wepFPGroup.Controls.Add(this.label5);
            this.wepFPGroup.Controls.Add(this.wepPortLabel);
            this.wepFPGroup.Controls.Add(this.wepAftLabel);
            this.wepFPGroup.Controls.Add(this.wepForeLabel);
            this.wepFPGroup.Controls.Add(this.wepTypeLabel);
            this.wepFPGroup.Location = new System.Drawing.Point(7, 7);
            this.wepFPGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.wepFPGroup.Name = "wepFPGroup";
            this.wepFPGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.wepFPGroup.Size = new System.Drawing.Size(430, 144);
            this.wepFPGroup.TabIndex = 10;
            this.wepFPGroup.TabStop = false;
            this.wepFPGroup.Text = "Weapons FirePower";
            // 
            // laserCannonRange
            // 
            this.laserCannonRange.Location = new System.Drawing.Point(365, 106);
            this.laserCannonRange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.laserCannonRange.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonRange.Name = "laserCannonRange";
            this.laserCannonRange.Size = new System.Drawing.Size(59, 23);
            this.laserCannonRange.TabIndex = 33;
            this.laserCannonRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.laserCannonRange.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonRange.ValueChanged += new System.EventHandler(this.laserCannonRange_ValueChanged);
            // 
            // laserCannonStar
            // 
            this.laserCannonStar.Location = new System.Drawing.Point(299, 106);
            this.laserCannonStar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.laserCannonStar.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonStar.Name = "laserCannonStar";
            this.laserCannonStar.Size = new System.Drawing.Size(59, 23);
            this.laserCannonStar.TabIndex = 30;
            this.laserCannonStar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.laserCannonStar.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonStar.ValueChanged += new System.EventHandler(this.laserCannonStar_ValueChanged);
            // 
            // laserCannonPort
            // 
            this.laserCannonPort.Location = new System.Drawing.Point(232, 106);
            this.laserCannonPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.laserCannonPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonPort.Name = "laserCannonPort";
            this.laserCannonPort.Size = new System.Drawing.Size(59, 23);
            this.laserCannonPort.TabIndex = 27;
            this.laserCannonPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.laserCannonPort.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonPort.ValueChanged += new System.EventHandler(this.laserCannonPort_ValueChanged);
            // 
            // laserCannonAft
            // 
            this.laserCannonAft.Location = new System.Drawing.Point(166, 106);
            this.laserCannonAft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.laserCannonAft.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonAft.Name = "laserCannonAft";
            this.laserCannonAft.Size = new System.Drawing.Size(59, 23);
            this.laserCannonAft.TabIndex = 24;
            this.laserCannonAft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.laserCannonAft.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonAft.ValueChanged += new System.EventHandler(this.laserCannonAft_ValueChanged);
            // 
            // ionCannonRange
            // 
            this.ionCannonRange.Location = new System.Drawing.Point(365, 76);
            this.ionCannonRange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ionCannonRange.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonRange.Name = "ionCannonRange";
            this.ionCannonRange.Size = new System.Drawing.Size(59, 23);
            this.ionCannonRange.TabIndex = 32;
            this.ionCannonRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ionCannonRange.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonRange.ValueChanged += new System.EventHandler(this.ionCannonRange_ValueChanged);
            // 
            // ionCannonStar
            // 
            this.ionCannonStar.Location = new System.Drawing.Point(299, 76);
            this.ionCannonStar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ionCannonStar.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonStar.Name = "ionCannonStar";
            this.ionCannonStar.Size = new System.Drawing.Size(59, 23);
            this.ionCannonStar.TabIndex = 29;
            this.ionCannonStar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ionCannonStar.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonStar.ValueChanged += new System.EventHandler(this.ionCannonStar_ValueChanged);
            // 
            // ionCannonPort
            // 
            this.ionCannonPort.Location = new System.Drawing.Point(232, 76);
            this.ionCannonPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ionCannonPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonPort.Name = "ionCannonPort";
            this.ionCannonPort.Size = new System.Drawing.Size(59, 23);
            this.ionCannonPort.TabIndex = 26;
            this.ionCannonPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ionCannonPort.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonPort.ValueChanged += new System.EventHandler(this.ionCannonPort_ValueChanged);
            // 
            // ionCannonAft
            // 
            this.ionCannonAft.Location = new System.Drawing.Point(166, 76);
            this.ionCannonAft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ionCannonAft.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonAft.Name = "ionCannonAft";
            this.ionCannonAft.Size = new System.Drawing.Size(59, 23);
            this.ionCannonAft.TabIndex = 23;
            this.ionCannonAft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ionCannonAft.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonAft.ValueChanged += new System.EventHandler(this.ionCannonAft_ValueChanged);
            // 
            // turboLaserRange
            // 
            this.turboLaserRange.Location = new System.Drawing.Point(365, 46);
            this.turboLaserRange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turboLaserRange.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turboLaserRange.Name = "turboLaserRange";
            this.turboLaserRange.Size = new System.Drawing.Size(59, 23);
            this.turboLaserRange.TabIndex = 31;
            this.turboLaserRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.turboLaserRange.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turboLaserRange.ValueChanged += new System.EventHandler(this.turboLaserRange_ValueChanged);
            // 
            // ionCannonFore
            // 
            this.ionCannonFore.Location = new System.Drawing.Point(99, 76);
            this.ionCannonFore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ionCannonFore.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonFore.Name = "ionCannonFore";
            this.ionCannonFore.Size = new System.Drawing.Size(59, 23);
            this.ionCannonFore.TabIndex = 20;
            this.ionCannonFore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ionCannonFore.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonFore.ValueChanged += new System.EventHandler(this.ionCannonFore_ValueChanged);
            // 
            // laserCannonFore
            // 
            this.laserCannonFore.Location = new System.Drawing.Point(99, 106);
            this.laserCannonFore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.laserCannonFore.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonFore.Name = "laserCannonFore";
            this.laserCannonFore.Size = new System.Drawing.Size(59, 23);
            this.laserCannonFore.TabIndex = 21;
            this.laserCannonFore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.laserCannonFore.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonFore.ValueChanged += new System.EventHandler(this.laserCannonFore_ValueChanged);
            // 
            // wepLaserLabel
            // 
            this.wepLaserLabel.AutoSize = true;
            this.wepLaserLabel.BackColor = System.Drawing.Color.LightGray;
            this.wepLaserLabel.Location = new System.Drawing.Point(7, 112);
            this.wepLaserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wepLaserLabel.Name = "wepLaserLabel";
            this.wepLaserLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wepLaserLabel.Size = new System.Drawing.Size(79, 15);
            this.wepLaserLabel.TabIndex = 0;
            this.wepLaserLabel.Text = "Laser Cannon";
            this.wepLaserLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wepIonLabel
            // 
            this.wepIonLabel.AutoSize = true;
            this.wepIonLabel.BackColor = System.Drawing.Color.LightGray;
            this.wepIonLabel.Location = new System.Drawing.Point(7, 78);
            this.wepIonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wepIonLabel.Name = "wepIonLabel";
            this.wepIonLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wepIonLabel.Size = new System.Drawing.Size(69, 15);
            this.wepIonLabel.TabIndex = 0;
            this.wepIonLabel.Text = "Ion Cannon";
            this.wepIonLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wepTurboLabel
            // 
            this.wepTurboLabel.AutoSize = true;
            this.wepTurboLabel.BackColor = System.Drawing.Color.LightGray;
            this.wepTurboLabel.Location = new System.Drawing.Point(7, 50);
            this.wepTurboLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wepTurboLabel.Name = "wepTurboLabel";
            this.wepTurboLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wepTurboLabel.Size = new System.Drawing.Size(62, 15);
            this.wepTurboLabel.TabIndex = 0;
            this.wepTurboLabel.Text = "Turbolaser";
            this.wepTurboLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // turboLaserStar
            // 
            this.turboLaserStar.Location = new System.Drawing.Point(299, 46);
            this.turboLaserStar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turboLaserStar.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turboLaserStar.Name = "turboLaserStar";
            this.turboLaserStar.Size = new System.Drawing.Size(59, 23);
            this.turboLaserStar.TabIndex = 28;
            this.turboLaserStar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.turboLaserStar.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turboLaserStar.ValueChanged += new System.EventHandler(this.turboLaserStar_ValueChanged);
            // 
            // turboLaserPort
            // 
            this.turboLaserPort.Location = new System.Drawing.Point(232, 46);
            this.turboLaserPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turboLaserPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turboLaserPort.Name = "turboLaserPort";
            this.turboLaserPort.Size = new System.Drawing.Size(59, 23);
            this.turboLaserPort.TabIndex = 25;
            this.turboLaserPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.turboLaserPort.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turboLaserPort.ValueChanged += new System.EventHandler(this.turboLaserPort_ValueChanged);
            // 
            // turboLaserAft
            // 
            this.turboLaserAft.Location = new System.Drawing.Point(166, 46);
            this.turboLaserAft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turboLaserAft.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turboLaserAft.Name = "turboLaserAft";
            this.turboLaserAft.Size = new System.Drawing.Size(59, 23);
            this.turboLaserAft.TabIndex = 22;
            this.turboLaserAft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.turboLaserAft.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turboLaserAft.ValueChanged += new System.EventHandler(this.turboLaserAft_ValueChanged);
            // 
            // turboLaserFore
            // 
            this.turboLaserFore.Location = new System.Drawing.Point(99, 46);
            this.turboLaserFore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turboLaserFore.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turboLaserFore.Name = "turboLaserFore";
            this.turboLaserFore.Size = new System.Drawing.Size(59, 23);
            this.turboLaserFore.TabIndex = 19;
            this.turboLaserFore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.turboLaserFore.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turboLaserFore.ValueChanged += new System.EventHandler(this.turboLaserFore_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(365, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Range";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(299, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Star";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wepPortLabel
            // 
            this.wepPortLabel.AutoSize = true;
            this.wepPortLabel.BackColor = System.Drawing.Color.Silver;
            this.wepPortLabel.Location = new System.Drawing.Point(232, 25);
            this.wepPortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wepPortLabel.Name = "wepPortLabel";
            this.wepPortLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wepPortLabel.Size = new System.Drawing.Size(29, 15);
            this.wepPortLabel.TabIndex = 0;
            this.wepPortLabel.Text = "Port";
            this.wepPortLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wepAftLabel
            // 
            this.wepAftLabel.AutoSize = true;
            this.wepAftLabel.BackColor = System.Drawing.Color.Silver;
            this.wepAftLabel.Location = new System.Drawing.Point(166, 25);
            this.wepAftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wepAftLabel.Name = "wepAftLabel";
            this.wepAftLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wepAftLabel.Size = new System.Drawing.Size(23, 15);
            this.wepAftLabel.TabIndex = 0;
            this.wepAftLabel.Text = "Aft";
            this.wepAftLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wepForeLabel
            // 
            this.wepForeLabel.AutoSize = true;
            this.wepForeLabel.BackColor = System.Drawing.Color.Silver;
            this.wepForeLabel.Location = new System.Drawing.Point(99, 25);
            this.wepForeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wepForeLabel.Name = "wepForeLabel";
            this.wepForeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wepForeLabel.Size = new System.Drawing.Size(30, 15);
            this.wepForeLabel.TabIndex = 0;
            this.wepForeLabel.Text = "Fore";
            this.wepForeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wepTypeLabel
            // 
            this.wepTypeLabel.AutoSize = true;
            this.wepTypeLabel.BackColor = System.Drawing.Color.Silver;
            this.wepTypeLabel.Location = new System.Drawing.Point(7, 25);
            this.wepTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wepTypeLabel.Name = "wepTypeLabel";
            this.wepTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wepTypeLabel.Size = new System.Drawing.Size(31, 15);
            this.wepTypeLabel.TabIndex = 0;
            this.wepTypeLabel.Text = "Type";
            this.wepTypeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.encyText);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(452, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ency Text";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.familyIdHexLabel);
            this.tabPage3.Controls.Add(this.capitalShipIdHexLabel);
            this.tabPage3.Controls.Add(this.capitalShipId);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label31);
            this.tabPage3.Controls.Add(this.groupBox13);
            this.tabPage3.Controls.Add(this.UnkownMoralHPlabel);
            this.tabPage3.Controls.Add(this.unknownMoralHp);
            this.tabPage3.Controls.Add(this.unknown2);
            this.tabPage3.Controls.Add(this.textStraDllId);
            this.tabPage3.Controls.Add(this.productionFacility);
            this.tabPage3.Controls.Add(this.unkown3Label);
            this.tabPage3.Controls.Add(this.familyId);
            this.tabPage3.Controls.Add(this.prodLabel);
            this.tabPage3.Controls.Add(this.idLabel);
            this.tabPage3.Controls.Add(this.familyLabel);
            this.tabPage3.Controls.Add(this.secProdFacNumlabel);
            this.tabPage3.Controls.Add(this.nextProductionFacility);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Size = new System.Drawing.Size(452, 334);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DAT Misc";
            // 
            // famHexLabel
            // 
            this.familyIdHexLabel.AutoSize = true;
            this.familyIdHexLabel.Enabled = false;
            this.familyIdHexLabel.Location = new System.Drawing.Point(412, 117);
            this.familyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdHexLabel.Name = "famHexLabel";
            this.familyIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.familyIdHexLabel.TabIndex = 1115;
            this.familyIdHexLabel.Text = "hex";
            // 
            // shipHexLabel
            // 
            this.capitalShipIdHexLabel.AutoSize = true;
            this.capitalShipIdHexLabel.Enabled = false;
            this.capitalShipIdHexLabel.Location = new System.Drawing.Point(412, 204);
            this.capitalShipIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.capitalShipIdHexLabel.Name = "shipHexLabel";
            this.capitalShipIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.capitalShipIdHexLabel.TabIndex = 1114;
            this.capitalShipIdHexLabel.Text = "hex";
            // 
            // shipId
            // 
            this.capitalShipId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.capitalShipId.Enabled = false;
            this.capitalShipId.Location = new System.Drawing.Point(351, 202);
            this.capitalShipId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.capitalShipId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.capitalShipId.Name = "shipId";
            this.capitalShipId.Size = new System.Drawing.Size(59, 23);
            this.capitalShipId.TabIndex = 1113;
            this.capitalShipId.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(234, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1112;
            this.label1.Text = "Ship ID";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Enabled = false;
            this.label31.Location = new System.Drawing.Point(79, 313);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(249, 15);
            this.label31.TabIndex = 152;
            this.label31.Text = "Welcome to the the island of misfit data fields";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.totalFirePower);
            this.groupBox13.Controls.Add(this.label16);
            this.groupBox13.Controls.Add(this.label30);
            this.groupBox13.Controls.Add(this.ionCannonTotalFirePower);
            this.groupBox13.Controls.Add(this.label29);
            this.groupBox13.Controls.Add(this.laserCannonTotalFirePower);
            this.groupBox13.Controls.Add(this.turboLaserTotalFirePower);
            this.groupBox13.Controls.Add(this.label26);
            this.groupBox13.Controls.Add(this.label28);
            this.groupBox13.Controls.Add(this.label27);
            this.groupBox13.Location = new System.Drawing.Point(8, 6);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox13.Size = new System.Drawing.Size(195, 183);
            this.groupBox13.TabIndex = 1111;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Weapons Total FirePower";
            // 
            // totalFirePower
            // 
            this.totalFirePower.Enabled = false;
            this.totalFirePower.Location = new System.Drawing.Point(99, 138);
            this.totalFirePower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.totalFirePower.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.totalFirePower.Name = "totalFirePower";
            this.totalFirePower.Size = new System.Drawing.Size(59, 23);
            this.totalFirePower.TabIndex = 152;
            this.totalFirePower.TabStop = false;
            this.totalFirePower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalFirePower.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.LightGray;
            this.label16.Location = new System.Drawing.Point(7, 144);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(48, 15);
            this.label16.TabIndex = 151;
            this.label16.Text = "Total FP";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Silver;
            this.label30.Location = new System.Drawing.Point(7, 28);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label30.Size = new System.Drawing.Size(31, 15);
            this.label30.TabIndex = 143;
            this.label30.Text = "Type";
            this.label30.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ionCannonTotalFirePower
            // 
            this.ionCannonTotalFirePower.Enabled = false;
            this.ionCannonTotalFirePower.Location = new System.Drawing.Point(99, 78);
            this.ionCannonTotalFirePower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ionCannonTotalFirePower.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonTotalFirePower.Name = "ionCannonTotalFirePower";
            this.ionCannonTotalFirePower.Size = new System.Drawing.Size(59, 23);
            this.ionCannonTotalFirePower.TabIndex = 150;
            this.ionCannonTotalFirePower.TabStop = false;
            this.ionCannonTotalFirePower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ionCannonTotalFirePower.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Silver;
            this.label29.Location = new System.Drawing.Point(99, 28);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label29.Size = new System.Drawing.Size(48, 15);
            this.label29.TabIndex = 144;
            this.label29.Text = "FP Total";
            this.label29.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // laserCannonTotalFirePower
            // 
            this.laserCannonTotalFirePower.Enabled = false;
            this.laserCannonTotalFirePower.Location = new System.Drawing.Point(99, 108);
            this.laserCannonTotalFirePower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.laserCannonTotalFirePower.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonTotalFirePower.Name = "laserCannonTotalFirePower";
            this.laserCannonTotalFirePower.Size = new System.Drawing.Size(59, 23);
            this.laserCannonTotalFirePower.TabIndex = 149;
            this.laserCannonTotalFirePower.TabStop = false;
            this.laserCannonTotalFirePower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.laserCannonTotalFirePower.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // turboLaserTotalFirePower
            // 
            this.turboLaserTotalFirePower.Enabled = false;
            this.turboLaserTotalFirePower.Location = new System.Drawing.Point(99, 48);
            this.turboLaserTotalFirePower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turboLaserTotalFirePower.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turboLaserTotalFirePower.Name = "turboLaserTotalFirePower";
            this.turboLaserTotalFirePower.Size = new System.Drawing.Size(59, 23);
            this.turboLaserTotalFirePower.TabIndex = 145;
            this.turboLaserTotalFirePower.TabStop = false;
            this.turboLaserTotalFirePower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.turboLaserTotalFirePower.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.LightGray;
            this.label26.Location = new System.Drawing.Point(7, 114);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label26.Size = new System.Drawing.Size(79, 15);
            this.label26.TabIndex = 148;
            this.label26.Text = "Laser Cannon";
            this.label26.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.LightGray;
            this.label28.Location = new System.Drawing.Point(7, 52);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label28.Size = new System.Drawing.Size(62, 15);
            this.label28.TabIndex = 146;
            this.label28.Text = "Turbolaser";
            this.label28.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.LightGray;
            this.label27.Location = new System.Drawing.Point(7, 81);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label27.Size = new System.Drawing.Size(69, 15);
            this.label27.TabIndex = 147;
            this.label27.Text = "Ion Cannon";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // researchGroup
            // 
            this.researchGroup.Controls.Add(this.researchOrder);
            this.researchGroup.Controls.Add(this.researchLabel);
            this.researchGroup.Controls.Add(this.resDiffLabel);
            this.researchGroup.Controls.Add(this.researchDifficulty);
            this.researchGroup.Location = new System.Drawing.Point(14, 313);
            this.researchGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchGroup.Name = "researchGroup";
            this.researchGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchGroup.Size = new System.Drawing.Size(212, 93);
            this.researchGroup.TabIndex = 4;
            this.researchGroup.TabStop = false;
            this.researchGroup.Text = "Research";
            // 
            // costsGroup
            // 
            this.costsGroup.Controls.Add(this.conCostLabel);
            this.costsGroup.Controls.Add(this.constructionCost);
            this.costsGroup.Controls.Add(this.maintCostLabel);
            this.costsGroup.Controls.Add(this.maintenanceCost);
            this.costsGroup.Location = new System.Drawing.Point(14, 103);
            this.costsGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.costsGroup.Name = "costsGroup";
            this.costsGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.costsGroup.Size = new System.Drawing.Size(212, 81);
            this.costsGroup.TabIndex = 2;
            this.costsGroup.TabStop = false;
            this.costsGroup.Text = "Costs";
            // 
            // buildByGroup
            // 
            this.buildByGroup.Controls.Add(this.isAllianceUnit);
            this.buildByGroup.Controls.Add(this.isEmpireUnit);
            this.buildByGroup.Location = new System.Drawing.Point(472, 14);
            this.buildByGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buildByGroup.Name = "buildByGroup";
            this.buildByGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buildByGroup.Size = new System.Drawing.Size(182, 84);
            this.buildByGroup.TabIndex = 8;
            this.buildByGroup.TabStop = false;
            this.buildByGroup.Text = "Build by";
            // 
            // shieldGroup
            // 
            this.shieldGroup.Controls.Add(this.shieldsRechargeRate);
            this.shieldGroup.Controls.Add(this.shieldRechLabel);
            this.shieldGroup.Controls.Add(this.shieldsMaxCapacity);
            this.shieldGroup.Controls.Add(this.shieldLabel);
            this.shieldGroup.Location = new System.Drawing.Point(248, 288);
            this.shieldGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shieldGroup.Name = "shieldGroup";
            this.shieldGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shieldGroup.Size = new System.Drawing.Size(212, 118);
            this.shieldGroup.TabIndex = 7;
            this.shieldGroup.TabStop = false;
            this.shieldGroup.Text = "Shields";
            // 
            // shieldsRechargeRate
            // 
            this.shieldsRechargeRate.Location = new System.Drawing.Point(125, 67);
            this.shieldsRechargeRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shieldsRechargeRate.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.shieldsRechargeRate.Name = "shieldsRechargeRate";
            this.shieldsRechargeRate.Size = new System.Drawing.Size(59, 23);
            this.shieldsRechargeRate.TabIndex = 14;
            this.shieldsRechargeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shieldsRechargeRate.ValueChanged += new System.EventHandler(this.shieldsRechargeRate_ValueChanged);
            // 
            // shieldRechLabel
            // 
            this.shieldRechLabel.AutoSize = true;
            this.shieldRechLabel.Location = new System.Drawing.Point(7, 66);
            this.shieldRechLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shieldRechLabel.Name = "shieldRechLabel";
            this.shieldRechLabel.Size = new System.Drawing.Size(82, 15);
            this.shieldRechLabel.TabIndex = 0;
            this.shieldRechLabel.Text = "Recharge Rate";
            // 
            // shieldsMaxCapacity
            // 
            this.shieldsMaxCapacity.Location = new System.Drawing.Point(125, 37);
            this.shieldsMaxCapacity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shieldsMaxCapacity.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.shieldsMaxCapacity.Name = "shieldsMaxCapacity";
            this.shieldsMaxCapacity.Size = new System.Drawing.Size(59, 23);
            this.shieldsMaxCapacity.TabIndex = 13;
            this.shieldsMaxCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shieldsMaxCapacity.ValueChanged += new System.EventHandler(this.shieldsMaxCapacity_ValueChanged);
            // 
            // shieldLabel
            // 
            this.shieldLabel.AutoSize = true;
            this.shieldLabel.Location = new System.Drawing.Point(7, 39);
            this.shieldLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shieldLabel.Name = "shieldLabel";
            this.shieldLabel.Size = new System.Drawing.Size(79, 15);
            this.shieldLabel.TabIndex = 0;
            this.shieldLabel.Text = "Max Capacity";
            // 
            // BasicGroup
            // 
            this.BasicGroup.Controls.Add(this.damageConLabel);
            this.BasicGroup.Controls.Add(this.damageControl);
            this.BasicGroup.Controls.Add(this.hullLabel);
            this.BasicGroup.Controls.Add(this.hullStrength);
            this.BasicGroup.Controls.Add(this.detectionRating);
            this.BasicGroup.Controls.Add(this.DetectionLabel);
            this.BasicGroup.Location = new System.Drawing.Point(14, 190);
            this.BasicGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BasicGroup.Name = "BasicGroup";
            this.BasicGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BasicGroup.Size = new System.Drawing.Size(214, 115);
            this.BasicGroup.TabIndex = 3;
            this.BasicGroup.TabStop = false;
            this.BasicGroup.Text = "Basic Info";
            // 
            // damageConLabel
            // 
            this.damageConLabel.AutoSize = true;
            this.damageConLabel.Location = new System.Drawing.Point(9, 82);
            this.damageConLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.damageConLabel.Name = "damageConLabel";
            this.damageConLabel.Size = new System.Drawing.Size(94, 15);
            this.damageConLabel.TabIndex = 0;
            this.damageConLabel.Text = "Damage Control";
            // 
            // damageControl
            // 
            this.damageControl.Location = new System.Drawing.Point(121, 80);
            this.damageControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.damageControl.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.damageControl.Name = "damageControl";
            this.damageControl.Size = new System.Drawing.Size(59, 23);
            this.damageControl.TabIndex = 6;
            this.damageControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.damageControl.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.damageControl.ValueChanged += new System.EventHandler(this.damageControl_ValueChanged);
            // 
            // hullLabel
            // 
            this.hullLabel.AutoSize = true;
            this.hullLabel.Location = new System.Drawing.Point(9, 18);
            this.hullLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hullLabel.Name = "hullLabel";
            this.hullLabel.Size = new System.Drawing.Size(77, 15);
            this.hullLabel.TabIndex = 0;
            this.hullLabel.Text = "Hull Strength";
            // 
            // hullStrength
            // 
            this.hullStrength.Location = new System.Drawing.Point(121, 16);
            this.hullStrength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hullStrength.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.hullStrength.Name = "hullStrength";
            this.hullStrength.Size = new System.Drawing.Size(59, 23);
            this.hullStrength.TabIndex = 4;
            this.hullStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hullStrength.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.hullStrength.ValueChanged += new System.EventHandler(this.hullStrength_ValueChanged);
            // 
            // sublightGroup
            // 
            this.sublightGroup.Controls.Add(this.manuverLabel);
            this.sublightGroup.Controls.Add(this.sublightManoeuvrability);
            this.sublightGroup.Controls.Add(this.sublightLabel);
            this.sublightGroup.Controls.Add(this.sublightSpeed);
            this.sublightGroup.Location = new System.Drawing.Point(248, 103);
            this.sublightGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sublightGroup.Name = "sublightGroup";
            this.sublightGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sublightGroup.Size = new System.Drawing.Size(212, 81);
            this.sublightGroup.TabIndex = 5;
            this.sublightGroup.TabStop = false;
            this.sublightGroup.Text = "Sublight Engines";
            // 
            // manuverLabel
            // 
            this.manuverLabel.AutoSize = true;
            this.manuverLabel.Location = new System.Drawing.Point(7, 50);
            this.manuverLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manuverLabel.Name = "manuverLabel";
            this.manuverLabel.Size = new System.Drawing.Size(83, 15);
            this.manuverLabel.TabIndex = 0;
            this.manuverLabel.Text = "Manuverablity";
            // 
            // sublightManoeuvrability
            // 
            this.sublightManoeuvrability.Location = new System.Drawing.Point(125, 46);
            this.sublightManoeuvrability.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sublightManoeuvrability.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sublightManoeuvrability.Name = "sublightManoeuvrability";
            this.sublightManoeuvrability.Size = new System.Drawing.Size(59, 23);
            this.sublightManoeuvrability.TabIndex = 10;
            this.sublightManoeuvrability.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sublightManoeuvrability.ValueChanged += new System.EventHandler(this.sublightManoeuvrability_ValueChanged);
            // 
            // sublightLabel
            // 
            this.sublightLabel.AutoSize = true;
            this.sublightLabel.Location = new System.Drawing.Point(7, 21);
            this.sublightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sublightLabel.Name = "sublightLabel";
            this.sublightLabel.Size = new System.Drawing.Size(86, 15);
            this.sublightLabel.TabIndex = 0;
            this.sublightLabel.Text = "Sublight Speed";
            // 
            // sublightSpeed
            // 
            this.sublightSpeed.Location = new System.Drawing.Point(125, 16);
            this.sublightSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sublightSpeed.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sublightSpeed.Name = "sublightSpeed";
            this.sublightSpeed.Size = new System.Drawing.Size(59, 23);
            this.sublightSpeed.TabIndex = 9;
            this.sublightSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sublightSpeed.ValueChanged += new System.EventHandler(this.sublightSpeed_ValueChanged);
            // 
            // hyperLabel
            // 
            this.hyperLabel.AutoSize = true;
            this.hyperLabel.Location = new System.Drawing.Point(7, 18);
            this.hyperLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hyperLabel.Name = "hyperLabel";
            this.hyperLabel.Size = new System.Drawing.Size(48, 15);
            this.hyperLabel.TabIndex = 0;
            this.hyperLabel.Text = "Primary\r\n";
            // 
            // hyperdrivePrimary
            // 
            this.hyperdrivePrimary.Location = new System.Drawing.Point(125, 16);
            this.hyperdrivePrimary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hyperdrivePrimary.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.hyperdrivePrimary.Name = "hyperdrivePrimary";
            this.hyperdrivePrimary.Size = new System.Drawing.Size(59, 23);
            this.hyperdrivePrimary.TabIndex = 11;
            this.hyperdrivePrimary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hyperdrivePrimary.ValueChanged += new System.EventHandler(this.hyperdrivePrimary_ValueChanged);
            // 
            // hyper2Label
            // 
            this.hyper2Label.AutoSize = true;
            this.hyper2Label.Location = new System.Drawing.Point(7, 48);
            this.hyper2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hyper2Label.Name = "hyper2Label";
            this.hyper2Label.Size = new System.Drawing.Size(46, 15);
            this.hyper2Label.TabIndex = 0;
            this.hyper2Label.Text = "Backup";
            // 
            // hyperdriveBackup
            // 
            this.hyperdriveBackup.Location = new System.Drawing.Point(125, 46);
            this.hyperdriveBackup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hyperdriveBackup.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.hyperdriveBackup.Name = "hyperdriveBackup";
            this.hyperdriveBackup.Size = new System.Drawing.Size(59, 23);
            this.hyperdriveBackup.TabIndex = 12;
            this.hyperdriveBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hyperdriveBackup.ValueChanged += new System.EventHandler(this.hyperdriveBackup_ValueChanged);
            // 
            // CarryGroup
            // 
            this.CarryGroup.Controls.Add(this.cargoFighters);
            this.CarryGroup.Controls.Add(this.fighterNumLabel);
            this.CarryGroup.Controls.Add(this.cargoTroops);
            this.CarryGroup.Controls.Add(this.infRegNumLabel);
            this.CarryGroup.Location = new System.Drawing.Point(700, 14);
            this.CarryGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CarryGroup.Name = "CarryGroup";
            this.CarryGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CarryGroup.Size = new System.Drawing.Size(212, 84);
            this.CarryGroup.TabIndex = 9;
            this.CarryGroup.TabStop = false;
            this.CarryGroup.Text = "Carry Capacity";
            // 
            // cargoFighters
            // 
            this.cargoFighters.Location = new System.Drawing.Point(127, 24);
            this.cargoFighters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cargoFighters.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.cargoFighters.Name = "cargoFighters";
            this.cargoFighters.Size = new System.Drawing.Size(59, 23);
            this.cargoFighters.TabIndex = 17;
            this.cargoFighters.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cargoFighters.ValueChanged += new System.EventHandler(this.cargoFighters_ValueChanged);
            // 
            // fighterNumLabel
            // 
            this.fighterNumLabel.AutoSize = true;
            this.fighterNumLabel.Location = new System.Drawing.Point(15, 28);
            this.fighterNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fighterNumLabel.Name = "fighterNumLabel";
            this.fighterNumLabel.Size = new System.Drawing.Size(84, 15);
            this.fighterNumLabel.TabIndex = 0;
            this.fighterNumLabel.Text = "Fighters Cargo";
            // 
            // cargoTroops
            // 
            this.cargoTroops.Location = new System.Drawing.Point(127, 52);
            this.cargoTroops.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cargoTroops.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.cargoTroops.Name = "cargoTroops";
            this.cargoTroops.Size = new System.Drawing.Size(59, 23);
            this.cargoTroops.TabIndex = 18;
            this.cargoTroops.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cargoTroops.ValueChanged += new System.EventHandler(this.cargoTroops_ValueChanged);
            // 
            // infRegNumLabel
            // 
            this.infRegNumLabel.AutoSize = true;
            this.infRegNumLabel.Location = new System.Drawing.Point(15, 55);
            this.infRegNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infRegNumLabel.Name = "infRegNumLabel";
            this.infRegNumLabel.Size = new System.Drawing.Size(77, 15);
            this.infRegNumLabel.TabIndex = 0;
            this.infRegNumLabel.Text = "Troops Cargo";
            // 
            // hyperdriveGroup
            // 
            this.hyperdriveGroup.Controls.Add(this.hyperdriveBackup);
            this.hyperdriveGroup.Controls.Add(this.hyperLabel);
            this.hyperdriveGroup.Controls.Add(this.hyper2Label);
            this.hyperdriveGroup.Controls.Add(this.hyperdrivePrimary);
            this.hyperdriveGroup.Location = new System.Drawing.Point(248, 190);
            this.hyperdriveGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hyperdriveGroup.Name = "hyperdriveGroup";
            this.hyperdriveGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hyperdriveGroup.Size = new System.Drawing.Size(212, 76);
            this.hyperdriveGroup.TabIndex = 6;
            this.hyperdriveGroup.TabStop = false;
            this.hyperdriveGroup.Text = "HyperDrive";
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(14, 0);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(205, 104);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 114;
            this.picture.TabStop = false;
            // 
            // CapitalShipsForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(926, 474);
            this.Controls.Add(this.hyperdriveGroup);
            this.Controls.Add(this.CarryGroup);
            this.Controls.Add(this.sublightGroup);
            this.Controls.Add(this.BasicGroup);
            this.Controls.Add(this.shieldGroup);
            this.Controls.Add(this.buildByGroup);
            this.Controls.Add(this.costsGroup);
            this.Controls.Add(this.researchGroup);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.encyclopediaName);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(942, 513);
            this.MinimumSize = new System.Drawing.Size(942, 513);
            this.Name = "CapitalShipsForm";
            this.Text = "Capital Ships (CAPSHPSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.Enter += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);

            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknownMoralHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectionRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constructionCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardmentMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponsRecharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravityUnknown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravityUnknown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractorBeamRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractorBeamPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonAft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonAft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turboLaserRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonFore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonFore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turboLaserStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turboLaserPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turboLaserAft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turboLaserFore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitalShipId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalFirePower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonTotalFirePower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonTotalFirePower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turboLaserTotalFirePower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldsRechargeRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldsMaxCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hullStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sublightManoeuvrability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sublightSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperdrivePrimary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperdriveBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoFighters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoTroops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();

            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.weaponsGroup.ResumeLayout(false);
            this.weaponsGroup.PerformLayout();
            this.GravityGroup.ResumeLayout(false);
            this.GravityGroup.PerformLayout();
            this.tractorGroup.ResumeLayout(false);
            this.tractorGroup.PerformLayout();
            this.wepFPGroup.ResumeLayout(false);
            this.wepFPGroup.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.researchGroup.ResumeLayout(false);
            this.researchGroup.PerformLayout();
            this.costsGroup.ResumeLayout(false);
            this.costsGroup.PerformLayout();
            this.buildByGroup.ResumeLayout(false);
            this.buildByGroup.PerformLayout();
            this.shieldGroup.ResumeLayout(false);
            this.shieldGroup.PerformLayout();
            this.BasicGroup.ResumeLayout(false);
            this.BasicGroup.PerformLayout();
            this.sublightGroup.ResumeLayout(false);
            this.sublightGroup.PerformLayout();
            this.CarryGroup.ResumeLayout(false);
            this.CarryGroup.PerformLayout();
            this.hyperdriveGroup.ResumeLayout(false);
            this.hyperdriveGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}