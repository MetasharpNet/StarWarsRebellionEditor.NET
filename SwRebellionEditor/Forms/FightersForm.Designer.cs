using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class FightersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;
        private Button Open;
        private Button SaveAs;
        private Button Cancel;
        private Button Ok;
        private TrackBar selector;
        private GroupBox hyperdriveGroup;
        private NumericUpDown hyperdriveBackup;
        private Label hyperLabel;
        private Label hyper2Label;
        private NumericUpDown hyperdrivePrimary;
        private GroupBox sublightGroup;
        private Label manuverLabel;
        private NumericUpDown sublightManoeuvrability;
        private Label sublightLabel;
        private NumericUpDown sublightSpeed;
        private GroupBox BasicGroup;
        private NumericUpDown detectionRating;
        private Label DetectionLabel;
        private GroupBox shieldGroup;
        private NumericUpDown shieldsMaxCapacity;
        private Label shieldLabel;
        private GroupBox buildByGroup;
        private CheckBox isAllianceUnit;
        private CheckBox isEmpireUnit;
        private GroupBox costsGroup;
        private Label conCostLabel;
        private NumericUpDown constructionCost;
        private Label maintCostLabel;
        private NumericUpDown maintenanceCost;
        private GroupBox researchGroup;
        private NumericUpDown researchOrder;
        private Label researchLabel;
        private Label resDiffLabel;
        private NumericUpDown researchDifficulty;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private NumericUpDown bombardmentMod;
        private Label bombardLabel;
        private GroupBox wepFPGroup;
        private NumericUpDown laserRanNum;
        private NumericUpDown fpArc12Num;
        private NumericUpDown fpArc9Num;
        private NumericUpDown fpArc6Num;
        private NumericUpDown ionRanNum;
        private NumericUpDown fpArc11Num;
        private NumericUpDown fpArc8Num;
        private NumericUpDown fpArc5Num;
        private NumericUpDown turboRanNum;
        private NumericUpDown fpArc2Num;
        private NumericUpDown fpArc3Num;
        private Label wepLaserLabel;
        private Label wepIonLabel;
        private Label wepTurboLabel;
        private NumericUpDown fpArc10Num;
        private NumericUpDown fpArc7Num;
        private NumericUpDown fpArc4Num;
        private NumericUpDown fpArc1Num;
        private Label wepRanLabel;
        private Label wepStarLabel;
        private Label wepPortLabel;
        private Label wepAftLabel;
        private Label wepForeLabel;
        private Label wepTypeLabel;
        private TabPage tabPage2;
        private RichTextBox encyText;
        private TabPage tabPage3;
        private Label label31;
        private GroupBox groupBox13;
        private NumericUpDown sumFPNum;
        private Label label16;
        private Label label30;
        private NumericUpDown sumIonNum;
        private Label label29;
        private NumericUpDown sumLaserNum;
        private NumericUpDown sumTurboNum;
        private Label label26;
        private Label label28;
        private Label label27;
        private Label UnkownMoralHPlabel;
        private NumericUpDown unknownMoralHp;
        private NumericUpDown unknown3Num;
        private NumericUpDown textStraDllId;
        private NumericUpDown productionFacility;
        private Label unkown3Label;
        private NumericUpDown familyId;
        private Label prodLabel;
        private Label idLabel;
        private Label familyLabel;
        private Label secProdFacNumlabel;
        private NumericUpDown secProdFacNum;
        private Label encyclopediaName;
        private PictureBox picture;
        private NumericUpDown torpRanNum;
        private NumericUpDown torpPowNum;
        private Label wepTorpLabel;
        private NumericUpDown squadSizeNum;
        private Label squadSizeLabel;
        private Label familyIdHexLabel;
        private Label fighterIdHexLabel;
        private NumericUpDown fighterId;
        private Label label1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FightersForm));
            this.hyperdriveGroup = new System.Windows.Forms.GroupBox();
            this.hyperdriveBackup = new System.Windows.Forms.NumericUpDown();
            this.hyperLabel = new System.Windows.Forms.Label();
            this.hyper2Label = new System.Windows.Forms.Label();
            this.hyperdrivePrimary = new System.Windows.Forms.NumericUpDown();
            this.sublightGroup = new System.Windows.Forms.GroupBox();
            this.manuverLabel = new System.Windows.Forms.Label();
            this.sublightManoeuvrability = new System.Windows.Forms.NumericUpDown();
            this.sublightLabel = new System.Windows.Forms.Label();
            this.sublightSpeed = new System.Windows.Forms.NumericUpDown();
            this.BasicGroup = new System.Windows.Forms.GroupBox();
            this.detectionRating = new System.Windows.Forms.NumericUpDown();
            this.DetectionLabel = new System.Windows.Forms.Label();
            this.shieldGroup = new System.Windows.Forms.GroupBox();
            this.shieldsMaxCapacity = new System.Windows.Forms.NumericUpDown();
            this.shieldLabel = new System.Windows.Forms.Label();
            this.buildByGroup = new System.Windows.Forms.GroupBox();
            this.isAllianceUnit = new System.Windows.Forms.CheckBox();
            this.isEmpireUnit = new System.Windows.Forms.CheckBox();
            this.costsGroup = new System.Windows.Forms.GroupBox();
            this.conCostLabel = new System.Windows.Forms.Label();
            this.constructionCost = new System.Windows.Forms.NumericUpDown();
            this.maintCostLabel = new System.Windows.Forms.Label();
            this.maintenanceCost = new System.Windows.Forms.NumericUpDown();
            this.researchGroup = new System.Windows.Forms.GroupBox();
            this.researchOrder = new System.Windows.Forms.NumericUpDown();
            this.researchLabel = new System.Windows.Forms.Label();
            this.resDiffLabel = new System.Windows.Forms.Label();
            this.researchDifficulty = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.squadSizeNum = new System.Windows.Forms.NumericUpDown();
            this.wepFPGroup = new System.Windows.Forms.GroupBox();
            this.torpRanNum = new System.Windows.Forms.NumericUpDown();
            this.torpPowNum = new System.Windows.Forms.NumericUpDown();
            this.wepTorpLabel = new System.Windows.Forms.Label();
            this.bombardmentMod = new System.Windows.Forms.NumericUpDown();
            this.laserRanNum = new System.Windows.Forms.NumericUpDown();
            this.fpArc12Num = new System.Windows.Forms.NumericUpDown();
            this.bombardLabel = new System.Windows.Forms.Label();
            this.fpArc9Num = new System.Windows.Forms.NumericUpDown();
            this.fpArc6Num = new System.Windows.Forms.NumericUpDown();
            this.ionRanNum = new System.Windows.Forms.NumericUpDown();
            this.fpArc11Num = new System.Windows.Forms.NumericUpDown();
            this.fpArc8Num = new System.Windows.Forms.NumericUpDown();
            this.fpArc5Num = new System.Windows.Forms.NumericUpDown();
            this.turboRanNum = new System.Windows.Forms.NumericUpDown();
            this.fpArc2Num = new System.Windows.Forms.NumericUpDown();
            this.fpArc3Num = new System.Windows.Forms.NumericUpDown();
            this.wepLaserLabel = new System.Windows.Forms.Label();
            this.wepIonLabel = new System.Windows.Forms.Label();
            this.wepTurboLabel = new System.Windows.Forms.Label();
            this.fpArc10Num = new System.Windows.Forms.NumericUpDown();
            this.fpArc7Num = new System.Windows.Forms.NumericUpDown();
            this.fpArc4Num = new System.Windows.Forms.NumericUpDown();
            this.fpArc1Num = new System.Windows.Forms.NumericUpDown();
            this.wepRanLabel = new System.Windows.Forms.Label();
            this.wepStarLabel = new System.Windows.Forms.Label();
            this.wepPortLabel = new System.Windows.Forms.Label();
            this.wepAftLabel = new System.Windows.Forms.Label();
            this.wepForeLabel = new System.Windows.Forms.Label();
            this.wepTypeLabel = new System.Windows.Forms.Label();
            this.squadSizeLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.encyText = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.fighterIdHexLabel = new System.Windows.Forms.Label();
            this.fighterId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.sumFPNum = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.sumIonNum = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.sumLaserNum = new System.Windows.Forms.NumericUpDown();
            this.sumTurboNum = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.UnkownMoralHPlabel = new System.Windows.Forms.Label();
            this.unknownMoralHp = new System.Windows.Forms.NumericUpDown();
            this.unknown3Num = new System.Windows.Forms.NumericUpDown();
            this.textStraDllId = new System.Windows.Forms.NumericUpDown();
            this.productionFacility = new System.Windows.Forms.NumericUpDown();
            this.unkown3Label = new System.Windows.Forms.Label();
            this.familyId = new System.Windows.Forms.NumericUpDown();
            this.prodLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.familyLabel = new System.Windows.Forms.Label();
            this.secProdFacNumlabel = new System.Windows.Forms.Label();
            this.secProdFacNum = new System.Windows.Forms.NumericUpDown();
            this.Open = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.encyclopediaName = new System.Windows.Forms.Label();
            this.selector = new System.Windows.Forms.TrackBar();
            this.picture = new System.Windows.Forms.PictureBox();

            ((System.ComponentModel.ISupportInitialize)(this.hyperdriveBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperdrivePrimary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sublightManoeuvrability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sublightSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectionRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldsMaxCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constructionCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squadSizeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torpRanNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torpPowNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardmentMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserRanNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc12Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc9Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc6Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionRanNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc11Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc8Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc5Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turboRanNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc2Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc3Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc10Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc7Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc4Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc1Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fighterId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumFPNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumIonNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumLaserNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumTurboNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknownMoralHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown3Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secProdFacNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();

            this.hyperdriveGroup.SuspendLayout();
            this.sublightGroup.SuspendLayout();
            this.BasicGroup.SuspendLayout();
            this.shieldGroup.SuspendLayout();
            this.buildByGroup.SuspendLayout();
            this.costsGroup.SuspendLayout();
            this.researchGroup.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.wepFPGroup.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // hyperdriveGroup
            // 
            this.hyperdriveGroup.Controls.Add(this.hyperdriveBackup);
            this.hyperdriveGroup.Controls.Add(this.hyperLabel);
            this.hyperdriveGroup.Controls.Add(this.hyper2Label);
            this.hyperdriveGroup.Controls.Add(this.hyperdrivePrimary);
            this.hyperdriveGroup.Location = new System.Drawing.Point(246, 197);
            this.hyperdriveGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hyperdriveGroup.Name = "hyperdriveGroup";
            this.hyperdriveGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hyperdriveGroup.Size = new System.Drawing.Size(212, 76);
            this.hyperdriveGroup.TabIndex = 124;
            this.hyperdriveGroup.TabStop = false;
            this.hyperdriveGroup.Text = "HyperDrive";
            // 
            // hyper2Num
            // 
            this.hyperdriveBackup.Location = new System.Drawing.Point(125, 46);
            this.hyperdriveBackup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hyperdriveBackup.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.hyperdriveBackup.Name = "hyper2Num";
            this.hyperdriveBackup.Size = new System.Drawing.Size(59, 23);
            this.hyperdriveBackup.TabIndex = 12;
            this.hyperdriveBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hyperdriveBackup.ValueChanged += new System.EventHandler(this.updateHyper2Num);
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
            // hyperNum
            // 
            this.hyperdrivePrimary.Location = new System.Drawing.Point(125, 16);
            this.hyperdrivePrimary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hyperdrivePrimary.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.hyperdrivePrimary.Name = "hyperNum";
            this.hyperdrivePrimary.Size = new System.Drawing.Size(59, 23);
            this.hyperdrivePrimary.TabIndex = 11;
            this.hyperdrivePrimary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hyperdrivePrimary.ValueChanged += new System.EventHandler(this.updateHyperNum);
            // 
            // sublightGroup
            // 
            this.sublightGroup.Controls.Add(this.manuverLabel);
            this.sublightGroup.Controls.Add(this.sublightManoeuvrability);
            this.sublightGroup.Controls.Add(this.sublightLabel);
            this.sublightGroup.Controls.Add(this.sublightSpeed);
            this.sublightGroup.Location = new System.Drawing.Point(246, 110);
            this.sublightGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sublightGroup.Name = "sublightGroup";
            this.sublightGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sublightGroup.Size = new System.Drawing.Size(212, 81);
            this.sublightGroup.TabIndex = 123;
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
            // maneuverNum
            // 
            this.sublightManoeuvrability.Location = new System.Drawing.Point(125, 46);
            this.sublightManoeuvrability.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sublightManoeuvrability.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sublightManoeuvrability.Name = "maneuverNum";
            this.sublightManoeuvrability.Size = new System.Drawing.Size(59, 23);
            this.sublightManoeuvrability.TabIndex = 10;
            this.sublightManoeuvrability.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sublightManoeuvrability.ValueChanged += new System.EventHandler(this.updateManeuverNum);
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
            // sublightNum
            // 
            this.sublightSpeed.Location = new System.Drawing.Point(125, 16);
            this.sublightSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sublightSpeed.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sublightSpeed.Name = "sublightNum";
            this.sublightSpeed.Size = new System.Drawing.Size(59, 23);
            this.sublightSpeed.TabIndex = 9;
            this.sublightSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sublightSpeed.ValueChanged += new System.EventHandler(this.updateSublightNum);
            // 
            // BasicGroup
            // 
            this.BasicGroup.Controls.Add(this.detectionRating);
            this.BasicGroup.Controls.Add(this.DetectionLabel);
            this.BasicGroup.Location = new System.Drawing.Point(12, 197);
            this.BasicGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BasicGroup.Name = "BasicGroup";
            this.BasicGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BasicGroup.Size = new System.Drawing.Size(214, 115);
            this.BasicGroup.TabIndex = 121;
            this.BasicGroup.TabStop = false;
            this.BasicGroup.Text = "Basic Info";
            // 
            // detectionNum
            // 
            this.detectionRating.Location = new System.Drawing.Point(121, 50);
            this.detectionRating.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.detectionRating.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.detectionRating.Name = "detectionNum";
            this.detectionRating.Size = new System.Drawing.Size(59, 23);
            this.detectionRating.TabIndex = 5;
            this.detectionRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.detectionRating.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.detectionRating.ValueChanged += new System.EventHandler(this.updateDetectionNum);
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
            // shieldGroup
            // 
            this.shieldGroup.Controls.Add(this.shieldsMaxCapacity);
            this.shieldGroup.Controls.Add(this.shieldLabel);
            this.shieldGroup.Location = new System.Drawing.Point(246, 295);
            this.shieldGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shieldGroup.Name = "shieldGroup";
            this.shieldGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shieldGroup.Size = new System.Drawing.Size(212, 118);
            this.shieldGroup.TabIndex = 125;
            this.shieldGroup.TabStop = false;
            this.shieldGroup.Text = "Shields";
            // 
            // shieldNum
            // 
            this.shieldsMaxCapacity.Location = new System.Drawing.Point(125, 37);
            this.shieldsMaxCapacity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shieldsMaxCapacity.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.shieldsMaxCapacity.Name = "shieldNum";
            this.shieldsMaxCapacity.Size = new System.Drawing.Size(59, 23);
            this.shieldsMaxCapacity.TabIndex = 13;
            this.shieldsMaxCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shieldsMaxCapacity.ValueChanged += new System.EventHandler(this.updateShieldNum);
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
            // buildByGroup
            // 
            this.buildByGroup.Controls.Add(this.isAllianceUnit);
            this.buildByGroup.Controls.Add(this.isEmpireUnit);
            this.buildByGroup.Location = new System.Drawing.Point(470, 21);
            this.buildByGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buildByGroup.Name = "buildByGroup";
            this.buildByGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buildByGroup.Size = new System.Drawing.Size(182, 84);
            this.buildByGroup.TabIndex = 126;
            this.buildByGroup.TabStop = false;
            this.buildByGroup.Text = "Build by";
            // 
            // rebelUnit
            // 
            this.isAllianceUnit.AutoSize = true;
            this.isAllianceUnit.Location = new System.Drawing.Point(7, 22);
            this.isAllianceUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isAllianceUnit.Name = "rebelUnit";
            this.isAllianceUnit.Size = new System.Drawing.Size(93, 19);
            this.isAllianceUnit.TabIndex = 15;
            this.isAllianceUnit.Text = "Alliance Unit";
            this.isAllianceUnit.UseVisualStyleBackColor = true;
            this.isAllianceUnit.CheckStateChanged += new System.EventHandler(this.updateRebelUnitCheck);
            // 
            // empireUnit
            // 
            this.isEmpireUnit.AutoSize = true;
            this.isEmpireUnit.Location = new System.Drawing.Point(7, 48);
            this.isEmpireUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isEmpireUnit.Name = "empireUnit";
            this.isEmpireUnit.Size = new System.Drawing.Size(94, 19);
            this.isEmpireUnit.TabIndex = 16;
            this.isEmpireUnit.Text = "Imperial Unit";
            this.isEmpireUnit.UseVisualStyleBackColor = true;
            this.isEmpireUnit.CheckStateChanged += new System.EventHandler(this.updateEmpireUnitCheck);
            // 
            // costsGroup
            // 
            this.costsGroup.Controls.Add(this.conCostLabel);
            this.costsGroup.Controls.Add(this.constructionCost);
            this.costsGroup.Controls.Add(this.maintCostLabel);
            this.costsGroup.Controls.Add(this.maintenanceCost);
            this.costsGroup.Location = new System.Drawing.Point(12, 110);
            this.costsGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.costsGroup.Name = "costsGroup";
            this.costsGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.costsGroup.Size = new System.Drawing.Size(212, 81);
            this.costsGroup.TabIndex = 120;
            this.costsGroup.TabStop = false;
            this.costsGroup.Text = "Costs";
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
            // conCostNum
            // 
            this.constructionCost.Location = new System.Drawing.Point(121, 17);
            this.constructionCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.constructionCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.constructionCost.Name = "conCostNum";
            this.constructionCost.Size = new System.Drawing.Size(59, 23);
            this.constructionCost.TabIndex = 2;
            this.constructionCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.constructionCost.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.constructionCost.ValueChanged += new System.EventHandler(this.updateConCost);
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
            // maintCostNum
            // 
            this.maintenanceCost.Location = new System.Drawing.Point(121, 47);
            this.maintenanceCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maintenanceCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maintenanceCost.Name = "maintCostNum";
            this.maintenanceCost.Size = new System.Drawing.Size(59, 23);
            this.maintenanceCost.TabIndex = 3;
            this.maintenanceCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maintenanceCost.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maintenanceCost.ValueChanged += new System.EventHandler(this.updateMaintCost);
            // 
            // researchGroup
            // 
            this.researchGroup.Controls.Add(this.researchOrder);
            this.researchGroup.Controls.Add(this.researchLabel);
            this.researchGroup.Controls.Add(this.resDiffLabel);
            this.researchGroup.Controls.Add(this.researchDifficulty);
            this.researchGroup.Location = new System.Drawing.Point(12, 320);
            this.researchGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchGroup.Name = "researchGroup";
            this.researchGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchGroup.Size = new System.Drawing.Size(212, 93);
            this.researchGroup.TabIndex = 122;
            this.researchGroup.TabStop = false;
            this.researchGroup.Text = "Research";
            // 
            // researchNum
            // 
            this.researchOrder.Location = new System.Drawing.Point(121, 22);
            this.researchOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchOrder.Name = "researchNum";
            this.researchOrder.Size = new System.Drawing.Size(59, 23);
            this.researchOrder.TabIndex = 7;
            this.researchOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.researchOrder.ValueChanged += new System.EventHandler(this.updateResearchNum);
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
            // resDiffNum
            // 
            this.researchDifficulty.Location = new System.Drawing.Point(121, 55);
            this.researchDifficulty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchDifficulty.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchDifficulty.Name = "resDiffNum";
            this.researchDifficulty.Size = new System.Drawing.Size(59, 23);
            this.researchDifficulty.TabIndex = 8;
            this.researchDifficulty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.researchDifficulty.ValueChanged += new System.EventHandler(this.updateResDiffNum);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(465, 111);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 362);
            this.tabControl1.TabIndex = 128;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.squadSizeNum);
            this.tabPage1.Controls.Add(this.wepFPGroup);
            this.tabPage1.Controls.Add(this.squadSizeLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(452, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Weapons";
            // 
            // squadSizeNum
            // 
            this.squadSizeNum.Location = new System.Drawing.Point(248, 279);
            this.squadSizeNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.squadSizeNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.squadSizeNum.Name = "squadSizeNum";
            this.squadSizeNum.Size = new System.Drawing.Size(59, 23);
            this.squadSizeNum.TabIndex = 44;
            this.squadSizeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.squadSizeNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.squadSizeNum.ValueChanged += new System.EventHandler(this.updateSquadSizeNum);
            // 
            // wepFPGroup
            // 
            this.wepFPGroup.Controls.Add(this.torpRanNum);
            this.wepFPGroup.Controls.Add(this.torpPowNum);
            this.wepFPGroup.Controls.Add(this.wepTorpLabel);
            this.wepFPGroup.Controls.Add(this.bombardmentMod);
            this.wepFPGroup.Controls.Add(this.laserRanNum);
            this.wepFPGroup.Controls.Add(this.fpArc12Num);
            this.wepFPGroup.Controls.Add(this.bombardLabel);
            this.wepFPGroup.Controls.Add(this.fpArc9Num);
            this.wepFPGroup.Controls.Add(this.fpArc6Num);
            this.wepFPGroup.Controls.Add(this.ionRanNum);
            this.wepFPGroup.Controls.Add(this.fpArc11Num);
            this.wepFPGroup.Controls.Add(this.fpArc8Num);
            this.wepFPGroup.Controls.Add(this.fpArc5Num);
            this.wepFPGroup.Controls.Add(this.turboRanNum);
            this.wepFPGroup.Controls.Add(this.fpArc2Num);
            this.wepFPGroup.Controls.Add(this.fpArc3Num);
            this.wepFPGroup.Controls.Add(this.wepLaserLabel);
            this.wepFPGroup.Controls.Add(this.wepIonLabel);
            this.wepFPGroup.Controls.Add(this.wepTurboLabel);
            this.wepFPGroup.Controls.Add(this.fpArc10Num);
            this.wepFPGroup.Controls.Add(this.fpArc7Num);
            this.wepFPGroup.Controls.Add(this.fpArc4Num);
            this.wepFPGroup.Controls.Add(this.fpArc1Num);
            this.wepFPGroup.Controls.Add(this.wepRanLabel);
            this.wepFPGroup.Controls.Add(this.wepStarLabel);
            this.wepFPGroup.Controls.Add(this.wepPortLabel);
            this.wepFPGroup.Controls.Add(this.wepAftLabel);
            this.wepFPGroup.Controls.Add(this.wepForeLabel);
            this.wepFPGroup.Controls.Add(this.wepTypeLabel);
            this.wepFPGroup.Location = new System.Drawing.Point(7, 7);
            this.wepFPGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.wepFPGroup.Name = "wepFPGroup";
            this.wepFPGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.wepFPGroup.Size = new System.Drawing.Size(430, 235);
            this.wepFPGroup.TabIndex = 10;
            this.wepFPGroup.TabStop = false;
            this.wepFPGroup.Text = "Weapons FirePower";
            // 
            // torpRanNum
            // 
            this.torpRanNum.Location = new System.Drawing.Point(365, 135);
            this.torpRanNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.torpRanNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.torpRanNum.Name = "torpRanNum";
            this.torpRanNum.Size = new System.Drawing.Size(59, 23);
            this.torpRanNum.TabIndex = 34;
            this.torpRanNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.torpRanNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.torpRanNum.ValueChanged += new System.EventHandler(this.updateTorpRanNum);
            // 
            // torpPowNum
            // 
            this.torpPowNum.Location = new System.Drawing.Point(99, 135);
            this.torpPowNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.torpPowNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.torpPowNum.Name = "torpPowNum";
            this.torpPowNum.Size = new System.Drawing.Size(59, 23);
            this.torpPowNum.TabIndex = 22;
            this.torpPowNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.torpPowNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.torpPowNum.ValueChanged += new System.EventHandler(this.updateTorpPowNum);
            // 
            // wepTorpLabel
            // 
            this.wepTorpLabel.AutoSize = true;
            this.wepTorpLabel.BackColor = System.Drawing.Color.LightGray;
            this.wepTorpLabel.Location = new System.Drawing.Point(7, 137);
            this.wepTorpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wepTorpLabel.Name = "wepTorpLabel";
            this.wepTorpLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wepTorpLabel.Size = new System.Drawing.Size(50, 15);
            this.wepTorpLabel.TabIndex = 38;
            this.wepTorpLabel.Text = "Torpedo";
            this.wepTorpLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bombardNum
            // 
            this.bombardmentMod.Location = new System.Drawing.Point(241, 182);
            this.bombardmentMod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bombardmentMod.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bombardmentMod.Name = "bombardNum";
            this.bombardmentMod.Size = new System.Drawing.Size(59, 23);
            this.bombardmentMod.TabIndex = 35;
            this.bombardmentMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bombardmentMod.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bombardmentMod.ValueChanged += new System.EventHandler(this.updateBombardNum);
            // 
            // laserRanNum
            // 
            this.laserRanNum.Location = new System.Drawing.Point(365, 106);
            this.laserRanNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.laserRanNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserRanNum.Name = "laserRanNum";
            this.laserRanNum.Size = new System.Drawing.Size(59, 23);
            this.laserRanNum.TabIndex = 33;
            this.laserRanNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.laserRanNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserRanNum.ValueChanged += new System.EventHandler(this.updateLaserRanNum);
            // 
            // fpArc12Num
            // 
            this.fpArc12Num.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fpArc12Num.Location = new System.Drawing.Point(299, 106);
            this.fpArc12Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fpArc12Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc12Num.Name = "fpArc12Num";
            this.fpArc12Num.Size = new System.Drawing.Size(59, 23);
            this.fpArc12Num.TabIndex = 30;
            this.fpArc12Num.TabStop = false;
            this.fpArc12Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fpArc12Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc12Num.ValueChanged += new System.EventHandler(this.updateFpArc12Num);
            // 
            // bombardLabel
            // 
            this.bombardLabel.AutoSize = true;
            this.bombardLabel.BackColor = System.Drawing.Color.LightGray;
            this.bombardLabel.Location = new System.Drawing.Point(217, 164);
            this.bombardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bombardLabel.Name = "bombardLabel";
            this.bombardLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bombardLabel.Size = new System.Drawing.Size(112, 15);
            this.bombardLabel.TabIndex = 0;
            this.bombardLabel.Text = "Bombardment Mod";
            this.bombardLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fpArc9Num
            // 
            this.fpArc9Num.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fpArc9Num.Location = new System.Drawing.Point(232, 106);
            this.fpArc9Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fpArc9Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc9Num.Name = "fpArc9Num";
            this.fpArc9Num.Size = new System.Drawing.Size(59, 23);
            this.fpArc9Num.TabIndex = 27;
            this.fpArc9Num.TabStop = false;
            this.fpArc9Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fpArc9Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc9Num.ValueChanged += new System.EventHandler(this.updateFpArc9Num);
            // 
            // fpArc6Num
            // 
            this.fpArc6Num.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fpArc6Num.Location = new System.Drawing.Point(166, 106);
            this.fpArc6Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fpArc6Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc6Num.Name = "fpArc6Num";
            this.fpArc6Num.Size = new System.Drawing.Size(59, 23);
            this.fpArc6Num.TabIndex = 24;
            this.fpArc6Num.TabStop = false;
            this.fpArc6Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fpArc6Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc6Num.ValueChanged += new System.EventHandler(this.updateFpArc6Num);
            // 
            // ionRanNum
            // 
            this.ionRanNum.Location = new System.Drawing.Point(365, 76);
            this.ionRanNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ionRanNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionRanNum.Name = "ionRanNum";
            this.ionRanNum.Size = new System.Drawing.Size(59, 23);
            this.ionRanNum.TabIndex = 32;
            this.ionRanNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ionRanNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionRanNum.ValueChanged += new System.EventHandler(this.updateIonRanNum);
            // 
            // fpArc11Num
            // 
            this.fpArc11Num.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fpArc11Num.Location = new System.Drawing.Point(299, 76);
            this.fpArc11Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fpArc11Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc11Num.Name = "fpArc11Num";
            this.fpArc11Num.Size = new System.Drawing.Size(59, 23);
            this.fpArc11Num.TabIndex = 29;
            this.fpArc11Num.TabStop = false;
            this.fpArc11Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fpArc11Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc11Num.ValueChanged += new System.EventHandler(this.updateFpArc11Num);
            // 
            // fpArc8Num
            // 
            this.fpArc8Num.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fpArc8Num.Location = new System.Drawing.Point(232, 76);
            this.fpArc8Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fpArc8Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc8Num.Name = "fpArc8Num";
            this.fpArc8Num.Size = new System.Drawing.Size(59, 23);
            this.fpArc8Num.TabIndex = 26;
            this.fpArc8Num.TabStop = false;
            this.fpArc8Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fpArc8Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc8Num.ValueChanged += new System.EventHandler(this.updateFpArc8Num);
            // 
            // fpArc5Num
            // 
            this.fpArc5Num.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fpArc5Num.Location = new System.Drawing.Point(166, 76);
            this.fpArc5Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fpArc5Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc5Num.Name = "fpArc5Num";
            this.fpArc5Num.Size = new System.Drawing.Size(59, 23);
            this.fpArc5Num.TabIndex = 23;
            this.fpArc5Num.TabStop = false;
            this.fpArc5Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fpArc5Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc5Num.ValueChanged += new System.EventHandler(this.updateFpArc5Num);
            // 
            // turboRanNum
            // 
            this.turboRanNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.turboRanNum.Location = new System.Drawing.Point(365, 46);
            this.turboRanNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turboRanNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turboRanNum.Name = "turboRanNum";
            this.turboRanNum.Size = new System.Drawing.Size(59, 23);
            this.turboRanNum.TabIndex = 31;
            this.turboRanNum.TabStop = false;
            this.turboRanNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.turboRanNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turboRanNum.ValueChanged += new System.EventHandler(this.updateTurboRanNum);
            // 
            // fpArc2Num
            // 
            this.fpArc2Num.Location = new System.Drawing.Point(99, 76);
            this.fpArc2Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fpArc2Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc2Num.Name = "fpArc2Num";
            this.fpArc2Num.Size = new System.Drawing.Size(59, 23);
            this.fpArc2Num.TabIndex = 20;
            this.fpArc2Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fpArc2Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc2Num.ValueChanged += new System.EventHandler(this.updateFpArc2Num);
            // 
            // fpArc3Num
            // 
            this.fpArc3Num.Location = new System.Drawing.Point(99, 106);
            this.fpArc3Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fpArc3Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc3Num.Name = "fpArc3Num";
            this.fpArc3Num.Size = new System.Drawing.Size(59, 23);
            this.fpArc3Num.TabIndex = 21;
            this.fpArc3Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fpArc3Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc3Num.ValueChanged += new System.EventHandler(this.updateFpArc3Num);
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
            // fpArc10Num
            // 
            this.fpArc10Num.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fpArc10Num.Location = new System.Drawing.Point(299, 46);
            this.fpArc10Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fpArc10Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc10Num.Name = "fpArc10Num";
            this.fpArc10Num.Size = new System.Drawing.Size(59, 23);
            this.fpArc10Num.TabIndex = 28;
            this.fpArc10Num.TabStop = false;
            this.fpArc10Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fpArc10Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc10Num.ValueChanged += new System.EventHandler(this.updateFpArc10Num);
            // 
            // fpArc7Num
            // 
            this.fpArc7Num.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fpArc7Num.Location = new System.Drawing.Point(232, 46);
            this.fpArc7Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fpArc7Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc7Num.Name = "fpArc7Num";
            this.fpArc7Num.Size = new System.Drawing.Size(59, 23);
            this.fpArc7Num.TabIndex = 25;
            this.fpArc7Num.TabStop = false;
            this.fpArc7Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fpArc7Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc7Num.ValueChanged += new System.EventHandler(this.updateFpArc7Num);
            // 
            // fpArc4Num
            // 
            this.fpArc4Num.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fpArc4Num.Location = new System.Drawing.Point(166, 46);
            this.fpArc4Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fpArc4Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc4Num.Name = "fpArc4Num";
            this.fpArc4Num.Size = new System.Drawing.Size(59, 23);
            this.fpArc4Num.TabIndex = 22;
            this.fpArc4Num.TabStop = false;
            this.fpArc4Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fpArc4Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc4Num.ValueChanged += new System.EventHandler(this.updateFpArc4Num);
            // 
            // fpArc1Num
            // 
            this.fpArc1Num.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fpArc1Num.Location = new System.Drawing.Point(99, 46);
            this.fpArc1Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fpArc1Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc1Num.Name = "fpArc1Num";
            this.fpArc1Num.Size = new System.Drawing.Size(59, 23);
            this.fpArc1Num.TabIndex = 19;
            this.fpArc1Num.TabStop = false;
            this.fpArc1Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fpArc1Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fpArc1Num.ValueChanged += new System.EventHandler(this.updateFpArc1Num);
            // 
            // wepRanLabel
            // 
            this.wepRanLabel.AutoSize = true;
            this.wepRanLabel.BackColor = System.Drawing.Color.Silver;
            this.wepRanLabel.Location = new System.Drawing.Point(365, 25);
            this.wepRanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wepRanLabel.Name = "wepRanLabel";
            this.wepRanLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wepRanLabel.Size = new System.Drawing.Size(40, 15);
            this.wepRanLabel.TabIndex = 0;
            this.wepRanLabel.Text = "Range";
            this.wepRanLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wepStarLabel
            // 
            this.wepStarLabel.AutoSize = true;
            this.wepStarLabel.BackColor = System.Drawing.Color.Silver;
            this.wepStarLabel.Location = new System.Drawing.Point(299, 25);
            this.wepStarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wepStarLabel.Name = "wepStarLabel";
            this.wepStarLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wepStarLabel.Size = new System.Drawing.Size(27, 15);
            this.wepStarLabel.TabIndex = 0;
            this.wepStarLabel.Text = "Star";
            this.wepStarLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // squadSizeLabel
            // 
            this.squadSizeLabel.AutoSize = true;
            this.squadSizeLabel.BackColor = System.Drawing.Color.LightGray;
            this.squadSizeLabel.Location = new System.Drawing.Point(224, 261);
            this.squadSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.squadSizeLabel.Name = "squadSizeLabel";
            this.squadSizeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.squadSizeLabel.Size = new System.Drawing.Size(81, 15);
            this.squadSizeLabel.TabIndex = 43;
            this.squadSizeLabel.Text = "Squadron Size";
            this.squadSizeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.familyIdHexLabel);
            this.tabPage3.Controls.Add(this.fighterIdHexLabel);
            this.tabPage3.Controls.Add(this.fighterId);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label31);
            this.tabPage3.Controls.Add(this.groupBox13);
            this.tabPage3.Controls.Add(this.UnkownMoralHPlabel);
            this.tabPage3.Controls.Add(this.unknownMoralHp);
            this.tabPage3.Controls.Add(this.unknown3Num);
            this.tabPage3.Controls.Add(this.textStraDllId);
            this.tabPage3.Controls.Add(this.productionFacility);
            this.tabPage3.Controls.Add(this.unkown3Label);
            this.tabPage3.Controls.Add(this.familyId);
            this.tabPage3.Controls.Add(this.prodLabel);
            this.tabPage3.Controls.Add(this.idLabel);
            this.tabPage3.Controls.Add(this.familyLabel);
            this.tabPage3.Controls.Add(this.secProdFacNumlabel);
            this.tabPage3.Controls.Add(this.secProdFacNum);
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
            this.familyIdHexLabel.TabIndex = 1119;
            this.familyIdHexLabel.Text = "hex";
            // 
            // shipHexLabel
            // 
            this.fighterIdHexLabel.AutoSize = true;
            this.fighterIdHexLabel.Enabled = false;
            this.fighterIdHexLabel.Location = new System.Drawing.Point(412, 204);
            this.fighterIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fighterIdHexLabel.Name = "shipHexLabel";
            this.fighterIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.fighterIdHexLabel.TabIndex = 1118;
            this.fighterIdHexLabel.Text = "hex";
            // 
            // shipNum
            // 
            this.fighterId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fighterId.Enabled = false;
            this.fighterId.Location = new System.Drawing.Point(351, 202);
            this.fighterId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fighterId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.fighterId.Name = "shipNum";
            this.fighterId.Size = new System.Drawing.Size(59, 23);
            this.fighterId.TabIndex = 1117;
            this.fighterId.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(234, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1116;
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
            this.groupBox13.Controls.Add(this.sumFPNum);
            this.groupBox13.Controls.Add(this.label16);
            this.groupBox13.Controls.Add(this.label30);
            this.groupBox13.Controls.Add(this.sumIonNum);
            this.groupBox13.Controls.Add(this.label29);
            this.groupBox13.Controls.Add(this.sumLaserNum);
            this.groupBox13.Controls.Add(this.sumTurboNum);
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
            // sumFPNum
            // 
            this.sumFPNum.Enabled = false;
            this.sumFPNum.Location = new System.Drawing.Point(99, 138);
            this.sumFPNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sumFPNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sumFPNum.Name = "sumFPNum";
            this.sumFPNum.Size = new System.Drawing.Size(59, 23);
            this.sumFPNum.TabIndex = 152;
            this.sumFPNum.TabStop = false;
            this.sumFPNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sumFPNum.Value = new decimal(new int[] {
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
            // sumIonNum
            // 
            this.sumIonNum.Enabled = false;
            this.sumIonNum.Location = new System.Drawing.Point(99, 78);
            this.sumIonNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sumIonNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sumIonNum.Name = "sumIonNum";
            this.sumIonNum.Size = new System.Drawing.Size(59, 23);
            this.sumIonNum.TabIndex = 150;
            this.sumIonNum.TabStop = false;
            this.sumIonNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sumIonNum.Value = new decimal(new int[] {
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
            // sumLaserNum
            // 
            this.sumLaserNum.Enabled = false;
            this.sumLaserNum.Location = new System.Drawing.Point(99, 108);
            this.sumLaserNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sumLaserNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sumLaserNum.Name = "sumLaserNum";
            this.sumLaserNum.Size = new System.Drawing.Size(59, 23);
            this.sumLaserNum.TabIndex = 149;
            this.sumLaserNum.TabStop = false;
            this.sumLaserNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sumLaserNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // sumTurboNum
            // 
            this.sumTurboNum.Enabled = false;
            this.sumTurboNum.Location = new System.Drawing.Point(99, 48);
            this.sumTurboNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sumTurboNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sumTurboNum.Name = "sumTurboNum";
            this.sumTurboNum.Size = new System.Drawing.Size(59, 23);
            this.sumTurboNum.TabIndex = 145;
            this.sumTurboNum.TabStop = false;
            this.sumTurboNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sumTurboNum.Value = new decimal(new int[] {
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
            // UnkownMoralHPlabel
            // 
            this.UnkownMoralHPlabel.AutoSize = true;
            this.UnkownMoralHPlabel.Location = new System.Drawing.Point(239, 18);
            this.UnkownMoralHPlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnkownMoralHPlabel.Name = "UnkownMoralHPlabel";
            this.UnkownMoralHPlabel.Size = new System.Drawing.Size(95, 15);
            this.UnkownMoralHPlabel.TabIndex = 94;
            this.UnkownMoralHPlabel.Text = "Unknown - ?HP?";
            // 
            // unknownMoralHpNum
            // 
            this.unknownMoralHp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.unknownMoralHp.Location = new System.Drawing.Point(351, 21);
            this.unknownMoralHp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknownMoralHp.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.unknownMoralHp.Name = "unknownMoralHpNum";
            this.unknownMoralHp.Size = new System.Drawing.Size(59, 23);
            this.unknownMoralHp.TabIndex = 125;
            this.unknownMoralHp.TabStop = false;
            this.unknownMoralHp.ValueChanged += new System.EventHandler(this.updateUnknownMoralHpNum);
            // 
            // unknown3Num
            // 
            this.unknown3Num.Enabled = false;
            this.unknown3Num.Location = new System.Drawing.Point(351, 142);
            this.unknown3Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknown3Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknown3Num.Name = "unknown3Num";
            this.unknown3Num.Size = new System.Drawing.Size(59, 23);
            this.unknown3Num.TabIndex = 110;
            this.unknown3Num.TabStop = false;
            // 
            // idNum
            // 
            this.textStraDllId.Enabled = false;
            this.textStraDllId.Location = new System.Drawing.Point(351, 172);
            this.textStraDllId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textStraDllId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.textStraDllId.Name = "idNum";
            this.textStraDllId.Size = new System.Drawing.Size(59, 23);
            this.textStraDllId.TabIndex = 112;
            this.textStraDllId.TabStop = false;
            // 
            // prodFacNum
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
            this.productionFacility.Name = "prodFacNum";
            this.productionFacility.Size = new System.Drawing.Size(59, 23);
            this.productionFacility.TabIndex = 93;
            this.productionFacility.TabStop = false;
            this.productionFacility.ValueChanged += new System.EventHandler(this.updateProdFacNum);
            // 
            // unkown3Label
            // 
            this.unkown3Label.AutoSize = true;
            this.unkown3Label.Enabled = false;
            this.unkown3Label.Location = new System.Drawing.Point(239, 144);
            this.unkown3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unkown3Label.Name = "unkown3Label";
            this.unkown3Label.Size = new System.Drawing.Size(58, 15);
            this.unkown3Label.TabIndex = 109;
            this.unkown3Label.Text = "Unknown";
            // 
            // familyIdNum
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
            this.familyId.Name = "familyIdNum";
            this.familyId.Size = new System.Drawing.Size(59, 23);
            this.familyId.TabIndex = 111;
            this.familyId.TabStop = false;
            this.familyId.ValueChanged += new System.EventHandler(this.updateFamilyIdNum);
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.Enabled = false;
            this.prodLabel.Location = new System.Drawing.Point(239, 53);
            this.prodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(106, 15);
            this.prodLabel.TabIndex = 95;
            this.prodLabel.Text = "Production Facility";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Enabled = false;
            this.idLabel.Location = new System.Drawing.Point(239, 174);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(85, 15);
            this.idLabel.TabIndex = 106;
            this.idLabel.Text = "TextStra.DLL ID";
            // 
            // familyLabel
            // 
            this.familyLabel.AutoSize = true;
            this.familyLabel.Enabled = false;
            this.familyLabel.Location = new System.Drawing.Point(239, 110);
            this.familyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyLabel.Name = "familyLabel";
            this.familyLabel.Size = new System.Drawing.Size(56, 15);
            this.familyLabel.TabIndex = 104;
            this.familyLabel.Text = "Family ID";
            // 
            // secProdFacNumlabel
            // 
            this.secProdFacNumlabel.AutoSize = true;
            this.secProdFacNumlabel.Enabled = false;
            this.secProdFacNumlabel.Location = new System.Drawing.Point(239, 82);
            this.secProdFacNumlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secProdFacNumlabel.Name = "secProdFacNumlabel";
            this.secProdFacNumlabel.Size = new System.Drawing.Size(92, 15);
            this.secProdFacNumlabel.TabIndex = 97;
            this.secProdFacNumlabel.Text = "Prod Facility + 1";
            // 
            // secProdFacNum
            // 
            this.secProdFacNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.secProdFacNum.Enabled = false;
            this.secProdFacNum.Location = new System.Drawing.Point(351, 82);
            this.secProdFacNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secProdFacNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.secProdFacNum.Name = "secProdFacNum";
            this.secProdFacNum.Size = new System.Drawing.Size(59, 23);
            this.secProdFacNum.TabIndex = 96;
            this.secProdFacNum.TabStop = false;
            this.secProdFacNum.ValueChanged += new System.EventHandler(this.updateSecProdFacNum);
            // 
            // openNew
            // 
            this.Open.Location = new System.Drawing.Point(371, 443);
            this.Open.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Open.Name = "openNew";
            this.Open.Size = new System.Drawing.Size(88, 27);
            this.Open.TabIndex = 116;
            this.Open.TabStop = false;
            this.Open.Text = "Open...";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Location = new System.Drawing.Point(276, 443);
            this.SaveAs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(88, 27);
            this.SaveAs.TabIndex = 115;
            this.SaveAs.TabStop = false;
            this.SaveAs.Text = "&SaveAs...";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(106, 443);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 27);
            this.Cancel.TabIndex = 130;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(12, 443);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 129;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // ItemName
            // 
            this.encyclopediaName.AutoSize = true;
            this.encyclopediaName.Location = new System.Drawing.Point(243, 82);
            this.encyclopediaName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encyclopediaName.Name = "ItemName";
            this.encyclopediaName.Size = new System.Drawing.Size(116, 15);
            this.encyclopediaName.TabIndex = 118;
            this.encyclopediaName.Text = "-- Item name here --";
            // 
            // ItemSelect
            // 
            this.selector.LargeChange = 4;
            this.selector.Location = new System.Drawing.Point(246, 27);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 7;
            this.selector.Name = "ItemSelect";
            this.selector.Size = new System.Drawing.Size(121, 45);
            this.selector.TabIndex = 119;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            // 
            // ItemPicture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(12, 7);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picture.Name = "ItemPicture";
            this.picture.Size = new System.Drawing.Size(205, 104);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 130;
            this.picture.TabStop = false;
            // 
            // FighterForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(926, 474);
            this.Controls.Add(this.hyperdriveGroup);
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
            this.Name = "FighterForm";
            this.Text = "Fighters (FIGHTSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.Enter += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.hyperdriveBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperdrivePrimary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sublightManoeuvrability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sublightSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectionRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldsMaxCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constructionCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squadSizeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torpRanNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torpPowNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardmentMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserRanNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc12Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc9Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc6Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionRanNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc11Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc8Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc5Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turboRanNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc2Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc3Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc10Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc7Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc4Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpArc1Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fighterId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumFPNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumIonNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumLaserNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumTurboNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknownMoralHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown3Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secProdFacNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();

            this.hyperdriveGroup.ResumeLayout(false);
            this.hyperdriveGroup.PerformLayout();
            this.sublightGroup.ResumeLayout(false);
            this.sublightGroup.PerformLayout();
            this.BasicGroup.ResumeLayout(false);
            this.BasicGroup.PerformLayout();
            this.shieldGroup.ResumeLayout(false);
            this.shieldGroup.PerformLayout();
            this.buildByGroup.ResumeLayout(false);
            this.buildByGroup.PerformLayout();
            this.costsGroup.ResumeLayout(false);
            this.costsGroup.PerformLayout();
            this.researchGroup.ResumeLayout(false);
            this.researchGroup.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.wepFPGroup.ResumeLayout(false);
            this.wepFPGroup.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}