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
        /////// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TrackBar selector;
        private Button Open;
        private Button SaveAs;
        private Button Cancel;
        private Button Ok;
        private RichTextBox encyclopediaDescription;
        private Label textStraDllIdLabel;
        private NumericUpDown textStraDllId;
        private Label field7_2Label;
        private NumericUpDown field7_2;
        private NumericUpDown familyId;
        private Label familyIdLabel;
        private NumericUpDown nextProductionFamily;
        private Label nextProductionFamilyLabel;
        private Label productionFamilyLabel;
        private NumericUpDown productionFamily;
        private NumericUpDown uprisingDefense;
        private Label UprisingDefenseLabel;
        private NumericUpDown researchDifficulty;
        private Label researchDifficultyLabel;
        private CheckBox isEmpire;
        private CheckBox isAlliance;
        private Label detectionLabel;
        private NumericUpDown detection;
        private Label researchOrderLabel;
        private NumericUpDown researchOrder;
        private NumericUpDown maintenanceCost;
        private Label maintenanceCostLabel;
        private PictureBox picture;
        private NumericUpDown refinedMaterialCost;
        private Label refinedMaterialCostLabel;
        private GroupBox attackStrengthGroupBox;
        private Label foreLabel;
        private Label turbolaserRangeLabel;
        private Label starboardLabel;
        private Label portLabel;
        private Label aftLabel;
        private NumericUpDown turbolaserStarboard;
        private NumericUpDown turbolaserPort;
        private NumericUpDown turbolaserAft;
        private NumericUpDown turbolaserFore;
        private Label turboLaserLabel;
        private NumericUpDown ionCannonRange;
        private NumericUpDown ionCannonStarboard;
        private NumericUpDown ionCannonPort;
        private NumericUpDown ionCannonAft;
        private NumericUpDown turbolaserRange;
        private NumericUpDown ionCannonFore;
        private NumericUpDown laserCannonFore;
        private Label laserCannonLabel;
        private Label ionCannonLabel;
        private NumericUpDown laserCannonRange;
        private NumericUpDown laserCannonStarboard;
        private NumericUpDown laserCannonPort;
        private NumericUpDown laserCannonAft;
        private NumericUpDown bombardmentDefense;
        private Label bombardmentDefenseLabel;
        private GroupBox inGameDataGroupBox;
        private NumericUpDown shieldStrength;
        private Label shieldStrengthLabel;
        private NumericUpDown hyperdrive;
        private Label maneuverabilityLabel;
        private NumericUpDown maneuverability;
        private Label subLightEngineLabel;
        private NumericUpDown subLightEngine;
        private Label hyperdriveIfDamagedLabel;
        private NumericUpDown hyperdriveIfDamaged;
        private NumericUpDown ionCannonAttackStrength;
        private NumericUpDown laserCannonAttackStrength;
        private NumericUpDown turbolaserAttackStrength;
        private NumericUpDown overallAttackStrength;
        private NumericUpDown id;
        private Label idLabel;
        private Label familyIdHexLabel;
        private Label idHexLabel;


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
            this.Open = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.encyclopediaDescription = new System.Windows.Forms.RichTextBox();
            this.textStraDllIdLabel = new System.Windows.Forms.Label();
            this.textStraDllId = new System.Windows.Forms.NumericUpDown();
            this.field7_2Label = new System.Windows.Forms.Label();
            this.field7_2 = new System.Windows.Forms.NumericUpDown();
            this.familyId = new System.Windows.Forms.NumericUpDown();
            this.familyIdLabel = new System.Windows.Forms.Label();
            this.nextProductionFamily = new System.Windows.Forms.NumericUpDown();
            this.nextProductionFamilyLabel = new System.Windows.Forms.Label();
            this.productionFamilyLabel = new System.Windows.Forms.Label();
            this.productionFamily = new System.Windows.Forms.NumericUpDown();
            this.uprisingDefense = new System.Windows.Forms.NumericUpDown();
            this.UprisingDefenseLabel = new System.Windows.Forms.Label();
            this.researchDifficulty = new System.Windows.Forms.NumericUpDown();
            this.researchDifficultyLabel = new System.Windows.Forms.Label();
            this.isEmpire = new System.Windows.Forms.CheckBox();
            this.isAlliance = new System.Windows.Forms.CheckBox();
            this.selector = new System.Windows.Forms.TrackBar();
            this.detectionLabel = new System.Windows.Forms.Label();
            this.detection = new System.Windows.Forms.NumericUpDown();
            this.researchOrderLabel = new System.Windows.Forms.Label();
            this.researchOrder = new System.Windows.Forms.NumericUpDown();
            this.maintenanceCost = new System.Windows.Forms.NumericUpDown();
            this.maintenanceCostLabel = new System.Windows.Forms.Label();
            this.refinedMaterialCost = new System.Windows.Forms.NumericUpDown();
            this.refinedMaterialCostLabel = new System.Windows.Forms.Label();
            this.bombardmentDefense = new System.Windows.Forms.NumericUpDown();
            this.bombardmentDefenseLabel = new System.Windows.Forms.Label();
            this.attackStrengthGroupBox = new System.Windows.Forms.GroupBox();
            this.torpedoes = new System.Windows.Forms.NumericUpDown();
            this.torpedoesLabel = new System.Windows.Forms.Label();
            this.laserCannonStarboard = new System.Windows.Forms.NumericUpDown();
            this.laserCannonPort = new System.Windows.Forms.NumericUpDown();
            this.laserCannonAft = new System.Windows.Forms.NumericUpDown();
            this.ionCannonStarboard = new System.Windows.Forms.NumericUpDown();
            this.overallAttackStrength = new System.Windows.Forms.NumericUpDown();
            this.ionCannonPort = new System.Windows.Forms.NumericUpDown();
            this.overallLabel = new System.Windows.Forms.Label();
            this.ionCannonAft = new System.Windows.Forms.NumericUpDown();
            this.ionCannonFore = new System.Windows.Forms.NumericUpDown();
            this.laserCannonFore = new System.Windows.Forms.NumericUpDown();
            this.laserCannonLabel = new System.Windows.Forms.Label();
            this.ionCannonLabel = new System.Windows.Forms.Label();
            this.turboLaserLabel = new System.Windows.Forms.Label();
            this.turbolaserStarboard = new System.Windows.Forms.NumericUpDown();
            this.turbolaserPort = new System.Windows.Forms.NumericUpDown();
            this.turbolaserAft = new System.Windows.Forms.NumericUpDown();
            this.turbolaserFore = new System.Windows.Forms.NumericUpDown();
            this.starboardLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.totalAttackLabel = new System.Windows.Forms.Label();
            this.ionCannonAttackStrength = new System.Windows.Forms.NumericUpDown();
            this.aftLabel = new System.Windows.Forms.Label();
            this.laserCannonAttackStrength = new System.Windows.Forms.NumericUpDown();
            this.foreLabel = new System.Windows.Forms.Label();
            this.turbolaserAttackStrength = new System.Windows.Forms.NumericUpDown();
            this.laserCannonRange = new System.Windows.Forms.NumericUpDown();
            this.ionCannonRange = new System.Windows.Forms.NumericUpDown();
            this.turbolaserRange = new System.Windows.Forms.NumericUpDown();
            this.turbolaserRangeLabel = new System.Windows.Forms.Label();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.idHexLabel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.NumericUpDown();
            this.idLabel = new System.Windows.Forms.Label();
            this.inGameDataGroupBox = new System.Windows.Forms.GroupBox();
            this.squadronSizeLabel = new System.Windows.Forms.Label();
            this.squadronSize = new System.Windows.Forms.NumericUpDown();
            this.name = new System.Windows.Forms.TextBox();
            this.encyclopediaDescriptionLabel = new System.Windows.Forms.Label();
            this.shieldStrengthLabel = new System.Windows.Forms.Label();
            this.shieldStrength = new System.Windows.Forms.NumericUpDown();
            this.picture = new System.Windows.Forms.PictureBox();
            this.maneuverabilityLabel = new System.Windows.Forms.Label();
            this.hyperdriveLabel = new System.Windows.Forms.Label();
            this.subLightEngineLabel = new System.Windows.Forms.Label();
            this.subLightEngine = new System.Windows.Forms.NumericUpDown();
            this.maneuverability = new System.Windows.Forms.NumericUpDown();
            this.hyperdrive = new System.Windows.Forms.NumericUpDown();
            this.hyperdriveIfDamagedLabel = new System.Windows.Forms.Label();
            this.hyperdriveIfDamaged = new System.Windows.Forms.NumericUpDown();
            this.field2_1 = new System.Windows.Forms.NumericUpDown();
            this.field2_1Label = new System.Windows.Forms.Label();
            this.hiddenDataGroupBox = new System.Windows.Forms.GroupBox();
            this.torpedoesRangeLabel = new System.Windows.Forms.Label();
            this.torpedoesRange = new System.Windows.Forms.NumericUpDown();
            this.laserCannonRangeLabel = new System.Windows.Forms.Label();
            this.ionCannonRangeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uprisingDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refinedMaterialCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardmentDefense)).BeginInit();
            this.attackStrengthGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.torpedoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonStarboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonAft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonStarboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overallAttackStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonAft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonFore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonFore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserStarboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserAft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserFore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonAttackStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonAttackStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserAttackStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            this.inGameDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.squadronSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subLightEngine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maneuverability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperdrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperdriveIfDamaged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2_1)).BeginInit();
            this.hiddenDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.torpedoesRange)).BeginInit();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(362, 517);
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
            this.SaveAs.Location = new System.Drawing.Point(270, 517);
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
            this.Cancel.Location = new System.Drawing.Point(179, 517);
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
            this.Ok.Location = new System.Drawing.Point(88, 517);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 38;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // encyclopediaDescription
            // 
            this.encyclopediaDescription.Location = new System.Drawing.Point(5, 402);
            this.encyclopediaDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.encyclopediaDescription.Name = "encyclopediaDescription";
            this.encyclopediaDescription.Size = new System.Drawing.Size(428, 66);
            this.encyclopediaDescription.TabIndex = 0;
            this.encyclopediaDescription.TabStop = false;
            this.encyclopediaDescription.Text = "";
            this.encyclopediaDescription.TextChanged += new System.EventHandler(this.encyclopediaDescription_TextChanged);
            // 
            // textStraDllIdLabel
            // 
            this.textStraDllIdLabel.AutoSize = true;
            this.textStraDllIdLabel.ForeColor = System.Drawing.Color.Red;
            this.textStraDllIdLabel.Location = new System.Drawing.Point(7, 148);
            this.textStraDllIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textStraDllIdLabel.Name = "textStraDllIdLabel";
            this.textStraDllIdLabel.Size = new System.Drawing.Size(77, 15);
            this.textStraDllIdLabel.TabIndex = 106;
            this.textStraDllIdLabel.Text = "TextStra.dll Id";
            // 
            // textStraDllId
            // 
            this.textStraDllId.ForeColor = System.Drawing.Color.Red;
            this.textStraDllId.Location = new System.Drawing.Point(141, 146);
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
            this.textStraDllId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textStraDllId.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.textStraDllId.ValueChanged += new System.EventHandler(this.textStraDllId_ValueChanged);
            // 
            // field7_2Label
            // 
            this.field7_2Label.AutoSize = true;
            this.field7_2Label.ForeColor = System.Drawing.Color.Red;
            this.field7_2Label.Location = new System.Drawing.Point(7, 173);
            this.field7_2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field7_2Label.Name = "field7_2Label";
            this.field7_2Label.Size = new System.Drawing.Size(93, 15);
            this.field7_2Label.TabIndex = 109;
            this.field7_2Label.Text = "Field7 (always 2)";
            // 
            // field7_2
            // 
            this.field7_2.ForeColor = System.Drawing.Color.Red;
            this.field7_2.Location = new System.Drawing.Point(141, 171);
            this.field7_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.field7_2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.field7_2.Name = "field7_2";
            this.field7_2.Size = new System.Drawing.Size(59, 23);
            this.field7_2.TabIndex = 110;
            this.field7_2.TabStop = false;
            this.field7_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.field7_2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.field7_2.ValueChanged += new System.EventHandler(this.field7_2_ValueChanged);
            // 
            // familyId
            // 
            this.familyId.BackColor = System.Drawing.SystemColors.Window;
            this.familyId.ForeColor = System.Drawing.Color.Red;
            this.familyId.Location = new System.Drawing.Point(141, 121);
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
            this.familyId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.familyId.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.familyId.ValueChanged += new System.EventHandler(this.familyId_ValueChanged);
            // 
            // familyIdLabel
            // 
            this.familyIdLabel.AutoSize = true;
            this.familyIdLabel.ForeColor = System.Drawing.Color.Red;
            this.familyIdLabel.Location = new System.Drawing.Point(7, 123);
            this.familyIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdLabel.Name = "familyIdLabel";
            this.familyIdLabel.Size = new System.Drawing.Size(55, 15);
            this.familyIdLabel.TabIndex = 104;
            this.familyIdLabel.Text = "Family Id";
            // 
            // nextProductionFamily
            // 
            this.nextProductionFamily.BackColor = System.Drawing.SystemColors.Window;
            this.nextProductionFamily.Location = new System.Drawing.Point(141, 96);
            this.nextProductionFamily.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextProductionFamily.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nextProductionFamily.Name = "nextProductionFamily";
            this.nextProductionFamily.Size = new System.Drawing.Size(59, 23);
            this.nextProductionFamily.TabIndex = 96;
            this.nextProductionFamily.TabStop = false;
            this.nextProductionFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nextProductionFamily.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nextProductionFamily.ValueChanged += new System.EventHandler(this.nextProductionFamily_ValueChanged);
            // 
            // nextProductionFamilyLabel
            // 
            this.nextProductionFamilyLabel.AutoSize = true;
            this.nextProductionFamilyLabel.Location = new System.Drawing.Point(7, 98);
            this.nextProductionFamilyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nextProductionFamilyLabel.Name = "nextProductionFamilyLabel";
            this.nextProductionFamilyLabel.Size = new System.Drawing.Size(121, 15);
            this.nextProductionFamilyLabel.TabIndex = 97;
            this.nextProductionFamilyLabel.Text = "Production Family +1";
            // 
            // productionFamilyLabel
            // 
            this.productionFamilyLabel.AutoSize = true;
            this.productionFamilyLabel.Location = new System.Drawing.Point(7, 73);
            this.productionFamilyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productionFamilyLabel.Name = "productionFamilyLabel";
            this.productionFamilyLabel.Size = new System.Drawing.Size(104, 15);
            this.productionFamilyLabel.TabIndex = 95;
            this.productionFamilyLabel.Text = "Production Family";
            // 
            // productionFamily
            // 
            this.productionFamily.BackColor = System.Drawing.SystemColors.Window;
            this.productionFamily.Location = new System.Drawing.Point(141, 71);
            this.productionFamily.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productionFamily.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.productionFamily.Name = "productionFamily";
            this.productionFamily.Size = new System.Drawing.Size(59, 23);
            this.productionFamily.TabIndex = 93;
            this.productionFamily.TabStop = false;
            this.productionFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.productionFamily.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.productionFamily.ValueChanged += new System.EventHandler(this.productionFamily_ValueChanged);
            // 
            // uprisingDefense
            // 
            this.uprisingDefense.BackColor = System.Drawing.SystemColors.Window;
            this.uprisingDefense.Location = new System.Drawing.Point(141, 246);
            this.uprisingDefense.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uprisingDefense.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.uprisingDefense.Name = "uprisingDefense";
            this.uprisingDefense.Size = new System.Drawing.Size(59, 23);
            this.uprisingDefense.TabIndex = 125;
            this.uprisingDefense.TabStop = false;
            this.uprisingDefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.uprisingDefense.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.uprisingDefense.ValueChanged += new System.EventHandler(this.uprisingDefense_ValueChanged);
            // 
            // UprisingDefenseLabel
            // 
            this.UprisingDefenseLabel.AutoSize = true;
            this.UprisingDefenseLabel.Location = new System.Drawing.Point(7, 248);
            this.UprisingDefenseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UprisingDefenseLabel.Name = "UprisingDefenseLabel";
            this.UprisingDefenseLabel.Size = new System.Drawing.Size(96, 15);
            this.UprisingDefenseLabel.TabIndex = 94;
            this.UprisingDefenseLabel.Text = "Uprising Defense";
            // 
            // researchDifficulty
            // 
            this.researchDifficulty.Location = new System.Drawing.Point(141, 221);
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
            this.researchDifficulty.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchDifficulty.ValueChanged += new System.EventHandler(this.researchDifficulty_ValueChanged);
            // 
            // researchDifficultyLabel
            // 
            this.researchDifficultyLabel.AutoSize = true;
            this.researchDifficultyLabel.Location = new System.Drawing.Point(7, 223);
            this.researchDifficultyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.researchDifficultyLabel.Name = "researchDifficultyLabel";
            this.researchDifficultyLabel.Size = new System.Drawing.Size(105, 15);
            this.researchDifficultyLabel.TabIndex = 0;
            this.researchDifficultyLabel.Text = "Research Difficulty";
            // 
            // isEmpire
            // 
            this.isEmpire.AutoSize = true;
            this.isEmpire.Location = new System.Drawing.Point(242, 74);
            this.isEmpire.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isEmpire.Name = "isEmpire";
            this.isEmpire.Size = new System.Drawing.Size(63, 19);
            this.isEmpire.TabIndex = 16;
            this.isEmpire.Text = "Empire";
            this.isEmpire.UseVisualStyleBackColor = true;
            this.isEmpire.CheckedChanged += new System.EventHandler(this.isEmpire_CheckedChanged);
            // 
            // isAlliance
            // 
            this.isAlliance.AutoSize = true;
            this.isAlliance.Location = new System.Drawing.Point(242, 53);
            this.isAlliance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isAlliance.Name = "isAlliance";
            this.isAlliance.Size = new System.Drawing.Size(68, 19);
            this.isAlliance.TabIndex = 15;
            this.isAlliance.Text = "Alliance";
            this.isAlliance.UseVisualStyleBackColor = true;
            this.isAlliance.CheckedChanged += new System.EventHandler(this.isAlliance_CheckedChanged);
            // 
            // selector
            // 
            this.selector.LargeChange = 1;
            this.selector.Location = new System.Drawing.Point(7, 5);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 7;
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(443, 45);
            this.selector.TabIndex = 1;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            // 
            // detectionLabel
            // 
            this.detectionLabel.AutoSize = true;
            this.detectionLabel.Location = new System.Drawing.Point(228, 178);
            this.detectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detectionLabel.Name = "detectionLabel";
            this.detectionLabel.Size = new System.Drawing.Size(58, 15);
            this.detectionLabel.TabIndex = 0;
            this.detectionLabel.Text = "Detection";
            // 
            // detection
            // 
            this.detection.Location = new System.Drawing.Point(365, 176);
            this.detection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.detection.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.detection.Name = "detection";
            this.detection.Size = new System.Drawing.Size(59, 23);
            this.detection.TabIndex = 5;
            this.detection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.detection.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.detection.ValueChanged += new System.EventHandler(this.detection_ValueChanged);
            // 
            // researchOrderLabel
            // 
            this.researchOrderLabel.AutoSize = true;
            this.researchOrderLabel.Location = new System.Drawing.Point(7, 198);
            this.researchOrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.researchOrderLabel.Name = "researchOrderLabel";
            this.researchOrderLabel.Size = new System.Drawing.Size(87, 15);
            this.researchOrderLabel.TabIndex = 0;
            this.researchOrderLabel.Text = "Research Order";
            // 
            // researchOrder
            // 
            this.researchOrder.Location = new System.Drawing.Point(141, 196);
            this.researchOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchOrder.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.researchOrder.Name = "researchOrder";
            this.researchOrder.Size = new System.Drawing.Size(59, 23);
            this.researchOrder.TabIndex = 7;
            this.researchOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.researchOrder.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.researchOrder.ValueChanged += new System.EventHandler(this.researchOrder_ValueChanged);
            // 
            // maintenanceCost
            // 
            this.maintenanceCost.Location = new System.Drawing.Point(146, 151);
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
            // maintenanceCostLabel
            // 
            this.maintenanceCostLabel.AutoSize = true;
            this.maintenanceCostLabel.Location = new System.Drawing.Point(13, 155);
            this.maintenanceCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maintenanceCostLabel.Name = "maintenanceCostLabel";
            this.maintenanceCostLabel.Size = new System.Drawing.Size(103, 15);
            this.maintenanceCostLabel.TabIndex = 0;
            this.maintenanceCostLabel.Text = "Maintenance Cost";
            // 
            // refinedMaterialCost
            // 
            this.refinedMaterialCost.Location = new System.Drawing.Point(146, 126);
            this.refinedMaterialCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.refinedMaterialCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.refinedMaterialCost.Name = "refinedMaterialCost";
            this.refinedMaterialCost.Size = new System.Drawing.Size(59, 23);
            this.refinedMaterialCost.TabIndex = 2;
            this.refinedMaterialCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.refinedMaterialCost.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.refinedMaterialCost.ValueChanged += new System.EventHandler(this.refinedMaterialCost_ValueChanged);
            // 
            // refinedMaterialCostLabel
            // 
            this.refinedMaterialCostLabel.AutoSize = true;
            this.refinedMaterialCostLabel.Location = new System.Drawing.Point(13, 130);
            this.refinedMaterialCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.refinedMaterialCostLabel.Name = "refinedMaterialCostLabel";
            this.refinedMaterialCostLabel.Size = new System.Drawing.Size(120, 15);
            this.refinedMaterialCostLabel.TabIndex = 0;
            this.refinedMaterialCostLabel.Text = "Refined Material Cost";
            // 
            // bombardmentDefense
            // 
            this.bombardmentDefense.Location = new System.Drawing.Point(365, 201);
            this.bombardmentDefense.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bombardmentDefense.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bombardmentDefense.Name = "bombardmentDefense";
            this.bombardmentDefense.Size = new System.Drawing.Size(59, 23);
            this.bombardmentDefense.TabIndex = 37;
            this.bombardmentDefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bombardmentDefense.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bombardmentDefense.ValueChanged += new System.EventHandler(this.bombardmentDefense_ValueChanged);
            // 
            // bombardmentDefenseLabel
            // 
            this.bombardmentDefenseLabel.AutoSize = true;
            this.bombardmentDefenseLabel.BackColor = System.Drawing.SystemColors.Control;
            this.bombardmentDefenseLabel.Location = new System.Drawing.Point(228, 203);
            this.bombardmentDefenseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bombardmentDefenseLabel.Name = "bombardmentDefenseLabel";
            this.bombardmentDefenseLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bombardmentDefenseLabel.Size = new System.Drawing.Size(129, 15);
            this.bombardmentDefenseLabel.TabIndex = 0;
            this.bombardmentDefenseLabel.Text = "Bombardment Defense";
            this.bombardmentDefenseLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // attackStrengthGroupBox
            // 
            this.attackStrengthGroupBox.Controls.Add(this.torpedoes);
            this.attackStrengthGroupBox.Controls.Add(this.torpedoesLabel);
            this.attackStrengthGroupBox.Controls.Add(this.laserCannonStarboard);
            this.attackStrengthGroupBox.Controls.Add(this.laserCannonPort);
            this.attackStrengthGroupBox.Controls.Add(this.laserCannonAft);
            this.attackStrengthGroupBox.Controls.Add(this.ionCannonStarboard);
            this.attackStrengthGroupBox.Controls.Add(this.overallAttackStrength);
            this.attackStrengthGroupBox.Controls.Add(this.ionCannonPort);
            this.attackStrengthGroupBox.Controls.Add(this.overallLabel);
            this.attackStrengthGroupBox.Controls.Add(this.ionCannonAft);
            this.attackStrengthGroupBox.Controls.Add(this.ionCannonFore);
            this.attackStrengthGroupBox.Controls.Add(this.laserCannonFore);
            this.attackStrengthGroupBox.Controls.Add(this.laserCannonLabel);
            this.attackStrengthGroupBox.Controls.Add(this.ionCannonLabel);
            this.attackStrengthGroupBox.Controls.Add(this.turboLaserLabel);
            this.attackStrengthGroupBox.Controls.Add(this.turbolaserStarboard);
            this.attackStrengthGroupBox.Controls.Add(this.turbolaserPort);
            this.attackStrengthGroupBox.Controls.Add(this.turbolaserAft);
            this.attackStrengthGroupBox.Controls.Add(this.turbolaserFore);
            this.attackStrengthGroupBox.Controls.Add(this.starboardLabel);
            this.attackStrengthGroupBox.Controls.Add(this.portLabel);
            this.attackStrengthGroupBox.Controls.Add(this.totalAttackLabel);
            this.attackStrengthGroupBox.Controls.Add(this.ionCannonAttackStrength);
            this.attackStrengthGroupBox.Controls.Add(this.aftLabel);
            this.attackStrengthGroupBox.Controls.Add(this.laserCannonAttackStrength);
            this.attackStrengthGroupBox.Controls.Add(this.foreLabel);
            this.attackStrengthGroupBox.Controls.Add(this.turbolaserAttackStrength);
            this.attackStrengthGroupBox.Location = new System.Drawing.Point(5, 225);
            this.attackStrengthGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.attackStrengthGroupBox.Name = "attackStrengthGroupBox";
            this.attackStrengthGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.attackStrengthGroupBox.Size = new System.Drawing.Size(428, 162);
            this.attackStrengthGroupBox.TabIndex = 10;
            this.attackStrengthGroupBox.TabStop = false;
            this.attackStrengthGroupBox.Text = "Attack Strength";
            // 
            // torpedoes
            // 
            this.torpedoes.Location = new System.Drawing.Point(91, 133);
            this.torpedoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.torpedoes.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.torpedoes.Name = "torpedoes";
            this.torpedoes.Size = new System.Drawing.Size(59, 23);
            this.torpedoes.TabIndex = 156;
            this.torpedoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.torpedoes.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.torpedoes.ValueChanged += new System.EventHandler(this.torpedoes_ValueChanged);
            // 
            // torpedoesLabel
            // 
            this.torpedoesLabel.AutoSize = true;
            this.torpedoesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.torpedoesLabel.Location = new System.Drawing.Point(8, 135);
            this.torpedoesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.torpedoesLabel.Name = "torpedoesLabel";
            this.torpedoesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.torpedoesLabel.Size = new System.Drawing.Size(61, 15);
            this.torpedoesLabel.TabIndex = 155;
            this.torpedoesLabel.Text = "Torpedoes";
            this.torpedoesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // laserCannonStarboard
            // 
            this.laserCannonStarboard.Location = new System.Drawing.Point(291, 108);
            this.laserCannonStarboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.laserCannonStarboard.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonStarboard.Name = "laserCannonStarboard";
            this.laserCannonStarboard.Size = new System.Drawing.Size(59, 23);
            this.laserCannonStarboard.TabIndex = 30;
            this.laserCannonStarboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.laserCannonStarboard.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonStarboard.ValueChanged += new System.EventHandler(this.laserCannonStarboard_ValueChanged);
            // 
            // laserCannonPort
            // 
            this.laserCannonPort.Location = new System.Drawing.Point(224, 108);
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
            this.laserCannonAft.Location = new System.Drawing.Point(158, 108);
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
            // ionCannonStarboard
            // 
            this.ionCannonStarboard.Location = new System.Drawing.Point(291, 83);
            this.ionCannonStarboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ionCannonStarboard.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonStarboard.Name = "ionCannonStarboard";
            this.ionCannonStarboard.Size = new System.Drawing.Size(59, 23);
            this.ionCannonStarboard.TabIndex = 29;
            this.ionCannonStarboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ionCannonStarboard.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonStarboard.ValueChanged += new System.EventHandler(this.ionCannonStarboard_ValueChanged);
            // 
            // overallAttackStrength
            // 
            this.overallAttackStrength.BackColor = System.Drawing.SystemColors.Menu;
            this.overallAttackStrength.Enabled = false;
            this.overallAttackStrength.Location = new System.Drawing.Point(360, 15);
            this.overallAttackStrength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.overallAttackStrength.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.overallAttackStrength.Name = "overallAttackStrength";
            this.overallAttackStrength.Size = new System.Drawing.Size(59, 23);
            this.overallAttackStrength.TabIndex = 152;
            this.overallAttackStrength.TabStop = false;
            this.overallAttackStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.overallAttackStrength.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.overallAttackStrength.ValueChanged += new System.EventHandler(this.overallAttackStrength_ValueChanged);
            // 
            // ionCannonPort
            // 
            this.ionCannonPort.Location = new System.Drawing.Point(224, 83);
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
            // overallLabel
            // 
            this.overallLabel.AutoSize = true;
            this.overallLabel.BackColor = System.Drawing.SystemColors.Control;
            this.overallLabel.Location = new System.Drawing.Point(308, 19);
            this.overallLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.overallLabel.Name = "overallLabel";
            this.overallLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.overallLabel.Size = new System.Drawing.Size(44, 15);
            this.overallLabel.TabIndex = 154;
            this.overallLabel.Text = "Overall";
            this.overallLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ionCannonAft
            // 
            this.ionCannonAft.Location = new System.Drawing.Point(158, 83);
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
            // ionCannonFore
            // 
            this.ionCannonFore.Location = new System.Drawing.Point(91, 83);
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
            this.laserCannonFore.Location = new System.Drawing.Point(91, 108);
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
            // laserCannonLabel
            // 
            this.laserCannonLabel.AutoSize = true;
            this.laserCannonLabel.BackColor = System.Drawing.SystemColors.Control;
            this.laserCannonLabel.Location = new System.Drawing.Point(7, 110);
            this.laserCannonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laserCannonLabel.Name = "laserCannonLabel";
            this.laserCannonLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laserCannonLabel.Size = new System.Drawing.Size(79, 15);
            this.laserCannonLabel.TabIndex = 0;
            this.laserCannonLabel.Text = "Laser Cannon";
            this.laserCannonLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ionCannonLabel
            // 
            this.ionCannonLabel.AutoSize = true;
            this.ionCannonLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ionCannonLabel.Location = new System.Drawing.Point(7, 85);
            this.ionCannonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ionCannonLabel.Name = "ionCannonLabel";
            this.ionCannonLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ionCannonLabel.Size = new System.Drawing.Size(69, 15);
            this.ionCannonLabel.TabIndex = 0;
            this.ionCannonLabel.Text = "Ion Cannon";
            this.ionCannonLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // turboLaserLabel
            // 
            this.turboLaserLabel.AutoSize = true;
            this.turboLaserLabel.BackColor = System.Drawing.SystemColors.Control;
            this.turboLaserLabel.Location = new System.Drawing.Point(6, 60);
            this.turboLaserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.turboLaserLabel.Name = "turboLaserLabel";
            this.turboLaserLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.turboLaserLabel.Size = new System.Drawing.Size(62, 15);
            this.turboLaserLabel.TabIndex = 0;
            this.turboLaserLabel.Text = "Turbolaser";
            this.turboLaserLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // turbolaserStarboard
            // 
            this.turbolaserStarboard.Location = new System.Drawing.Point(291, 58);
            this.turbolaserStarboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turbolaserStarboard.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserStarboard.Name = "turbolaserStarboard";
            this.turbolaserStarboard.Size = new System.Drawing.Size(59, 23);
            this.turbolaserStarboard.TabIndex = 28;
            this.turbolaserStarboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.turbolaserStarboard.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserStarboard.ValueChanged += new System.EventHandler(this.turbolaserStarboard_ValueChanged);
            // 
            // turbolaserPort
            // 
            this.turbolaserPort.Location = new System.Drawing.Point(224, 58);
            this.turbolaserPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turbolaserPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserPort.Name = "turbolaserPort";
            this.turbolaserPort.Size = new System.Drawing.Size(59, 23);
            this.turbolaserPort.TabIndex = 25;
            this.turbolaserPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.turbolaserPort.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserPort.ValueChanged += new System.EventHandler(this.turbolaserPort_ValueChanged);
            // 
            // turbolaserAft
            // 
            this.turbolaserAft.Location = new System.Drawing.Point(158, 58);
            this.turbolaserAft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turbolaserAft.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserAft.Name = "turbolaserAft";
            this.turbolaserAft.Size = new System.Drawing.Size(59, 23);
            this.turbolaserAft.TabIndex = 22;
            this.turbolaserAft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.turbolaserAft.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserAft.ValueChanged += new System.EventHandler(this.turbolaserAft_ValueChanged);
            // 
            // turbolaserFore
            // 
            this.turbolaserFore.Location = new System.Drawing.Point(91, 58);
            this.turbolaserFore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turbolaserFore.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserFore.Name = "turbolaserFore";
            this.turbolaserFore.Size = new System.Drawing.Size(59, 23);
            this.turbolaserFore.TabIndex = 19;
            this.turbolaserFore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.turbolaserFore.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserFore.ValueChanged += new System.EventHandler(this.turbolaserFore_ValueChanged);
            // 
            // starboardLabel
            // 
            this.starboardLabel.AutoSize = true;
            this.starboardLabel.BackColor = System.Drawing.SystemColors.Control;
            this.starboardLabel.Location = new System.Drawing.Point(291, 41);
            this.starboardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.starboardLabel.Name = "starboardLabel";
            this.starboardLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.starboardLabel.Size = new System.Drawing.Size(58, 15);
            this.starboardLabel.TabIndex = 0;
            this.starboardLabel.Text = "Starboard";
            this.starboardLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.BackColor = System.Drawing.SystemColors.Control;
            this.portLabel.Location = new System.Drawing.Point(224, 41);
            this.portLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.portLabel.Size = new System.Drawing.Size(29, 15);
            this.portLabel.TabIndex = 0;
            this.portLabel.Text = "Port";
            this.portLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // totalAttackLabel
            // 
            this.totalAttackLabel.AutoSize = true;
            this.totalAttackLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalAttackLabel.Location = new System.Drawing.Point(355, 41);
            this.totalAttackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalAttackLabel.Name = "totalAttackLabel";
            this.totalAttackLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalAttackLabel.Size = new System.Drawing.Size(69, 15);
            this.totalAttackLabel.TabIndex = 153;
            this.totalAttackLabel.Text = "Total Attack";
            this.totalAttackLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ionCannonAttackStrength
            // 
            this.ionCannonAttackStrength.BackColor = System.Drawing.SystemColors.Menu;
            this.ionCannonAttackStrength.Enabled = false;
            this.ionCannonAttackStrength.Location = new System.Drawing.Point(360, 83);
            this.ionCannonAttackStrength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ionCannonAttackStrength.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonAttackStrength.Name = "ionCannonAttackStrength";
            this.ionCannonAttackStrength.Size = new System.Drawing.Size(59, 23);
            this.ionCannonAttackStrength.TabIndex = 150;
            this.ionCannonAttackStrength.TabStop = false;
            this.ionCannonAttackStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ionCannonAttackStrength.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonAttackStrength.ValueChanged += new System.EventHandler(this.ionCannonAttackStrength_ValueChanged);
            // 
            // aftLabel
            // 
            this.aftLabel.AutoSize = true;
            this.aftLabel.BackColor = System.Drawing.SystemColors.Control;
            this.aftLabel.Location = new System.Drawing.Point(158, 41);
            this.aftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aftLabel.Name = "aftLabel";
            this.aftLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aftLabel.Size = new System.Drawing.Size(23, 15);
            this.aftLabel.TabIndex = 0;
            this.aftLabel.Text = "Aft";
            this.aftLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // laserCannonAttackStrength
            // 
            this.laserCannonAttackStrength.BackColor = System.Drawing.SystemColors.Menu;
            this.laserCannonAttackStrength.Enabled = false;
            this.laserCannonAttackStrength.Location = new System.Drawing.Point(360, 108);
            this.laserCannonAttackStrength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.laserCannonAttackStrength.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonAttackStrength.Name = "laserCannonAttackStrength";
            this.laserCannonAttackStrength.Size = new System.Drawing.Size(59, 23);
            this.laserCannonAttackStrength.TabIndex = 149;
            this.laserCannonAttackStrength.TabStop = false;
            this.laserCannonAttackStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.laserCannonAttackStrength.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonAttackStrength.ValueChanged += new System.EventHandler(this.laserCannonAttackStrength_ValueChanged);
            // 
            // foreLabel
            // 
            this.foreLabel.AutoSize = true;
            this.foreLabel.BackColor = System.Drawing.SystemColors.Control;
            this.foreLabel.Location = new System.Drawing.Point(91, 41);
            this.foreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foreLabel.Name = "foreLabel";
            this.foreLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.foreLabel.Size = new System.Drawing.Size(30, 15);
            this.foreLabel.TabIndex = 0;
            this.foreLabel.Text = "Fore";
            this.foreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // turbolaserAttackStrength
            // 
            this.turbolaserAttackStrength.BackColor = System.Drawing.SystemColors.Menu;
            this.turbolaserAttackStrength.Enabled = false;
            this.turbolaserAttackStrength.Location = new System.Drawing.Point(360, 58);
            this.turbolaserAttackStrength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turbolaserAttackStrength.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserAttackStrength.Name = "turbolaserAttackStrength";
            this.turbolaserAttackStrength.Size = new System.Drawing.Size(59, 23);
            this.turbolaserAttackStrength.TabIndex = 145;
            this.turbolaserAttackStrength.TabStop = false;
            this.turbolaserAttackStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.turbolaserAttackStrength.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserAttackStrength.ValueChanged += new System.EventHandler(this.turbolaserAttackStrength_ValueChanged);
            // 
            // laserCannonRange
            // 
            this.laserCannonRange.Location = new System.Drawing.Point(7, 371);
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
            // ionCannonRange
            // 
            this.ionCannonRange.Location = new System.Drawing.Point(7, 346);
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
            // turbolaserRange
            // 
            this.turbolaserRange.Location = new System.Drawing.Point(7, 321);
            this.turbolaserRange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turbolaserRange.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserRange.Name = "turbolaserRange";
            this.turbolaserRange.Size = new System.Drawing.Size(59, 23);
            this.turbolaserRange.TabIndex = 31;
            this.turbolaserRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.turbolaserRange.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserRange.ValueChanged += new System.EventHandler(this.turbolaserRange_ValueChanged);
            // 
            // turbolaserRangeLabel
            // 
            this.turbolaserRangeLabel.AutoSize = true;
            this.turbolaserRangeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.turbolaserRangeLabel.Location = new System.Drawing.Point(70, 323);
            this.turbolaserRangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.turbolaserRangeLabel.Name = "turbolaserRangeLabel";
            this.turbolaserRangeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.turbolaserRangeLabel.Size = new System.Drawing.Size(98, 15);
            this.turbolaserRangeLabel.TabIndex = 0;
            this.turbolaserRangeLabel.Text = "Turbolaser Range";
            this.turbolaserRangeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // familyIdHexLabel
            // 
            this.familyIdHexLabel.AutoSize = true;
            this.familyIdHexLabel.Enabled = false;
            this.familyIdHexLabel.ForeColor = System.Drawing.Color.Red;
            this.familyIdHexLabel.Location = new System.Drawing.Point(201, 123);
            this.familyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdHexLabel.Name = "familyIdHexLabel";
            this.familyIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.familyIdHexLabel.TabIndex = 1115;
            this.familyIdHexLabel.Text = "hex";
            // 
            // idHexLabel
            // 
            this.idHexLabel.AutoSize = true;
            this.idHexLabel.Enabled = false;
            this.idHexLabel.ForeColor = System.Drawing.Color.Red;
            this.idHexLabel.Location = new System.Drawing.Point(201, 23);
            this.idHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idHexLabel.Name = "idHexLabel";
            this.idHexLabel.Size = new System.Drawing.Size(26, 15);
            this.idHexLabel.TabIndex = 1114;
            this.idHexLabel.Text = "hex";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.Window;
            this.id.ForeColor = System.Drawing.Color.Red;
            this.id.Location = new System.Drawing.Point(141, 21);
            this.id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.id.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(59, 23);
            this.id.TabIndex = 1113;
            this.id.TabStop = false;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.id.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.id.ValueChanged += new System.EventHandler(this.id_ValueChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.ForeColor = System.Drawing.Color.Red;
            this.idLabel.Location = new System.Drawing.Point(7, 23);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(17, 15);
            this.idLabel.TabIndex = 1112;
            this.idLabel.Text = "Id";
            // 
            // inGameDataGroupBox
            // 
            this.inGameDataGroupBox.Controls.Add(this.squadronSizeLabel);
            this.inGameDataGroupBox.Controls.Add(this.squadronSize);
            this.inGameDataGroupBox.Controls.Add(this.name);
            this.inGameDataGroupBox.Controls.Add(this.encyclopediaDescriptionLabel);
            this.inGameDataGroupBox.Controls.Add(this.bombardmentDefense);
            this.inGameDataGroupBox.Controls.Add(this.shieldStrengthLabel);
            this.inGameDataGroupBox.Controls.Add(this.bombardmentDefenseLabel);
            this.inGameDataGroupBox.Controls.Add(this.attackStrengthGroupBox);
            this.inGameDataGroupBox.Controls.Add(this.shieldStrength);
            this.inGameDataGroupBox.Controls.Add(this.maintenanceCost);
            this.inGameDataGroupBox.Controls.Add(this.refinedMaterialCostLabel);
            this.inGameDataGroupBox.Controls.Add(this.maintenanceCostLabel);
            this.inGameDataGroupBox.Controls.Add(this.refinedMaterialCost);
            this.inGameDataGroupBox.Controls.Add(this.encyclopediaDescription);
            this.inGameDataGroupBox.Controls.Add(this.picture);
            this.inGameDataGroupBox.Controls.Add(this.isEmpire);
            this.inGameDataGroupBox.Controls.Add(this.isAlliance);
            this.inGameDataGroupBox.Controls.Add(this.maneuverabilityLabel);
            this.inGameDataGroupBox.Controls.Add(this.hyperdriveLabel);
            this.inGameDataGroupBox.Controls.Add(this.subLightEngineLabel);
            this.inGameDataGroupBox.Controls.Add(this.subLightEngine);
            this.inGameDataGroupBox.Controls.Add(this.detection);
            this.inGameDataGroupBox.Controls.Add(this.detectionLabel);
            this.inGameDataGroupBox.Controls.Add(this.maneuverability);
            this.inGameDataGroupBox.Controls.Add(this.hyperdrive);
            this.inGameDataGroupBox.Location = new System.Drawing.Point(7, 40);
            this.inGameDataGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inGameDataGroupBox.Name = "inGameDataGroupBox";
            this.inGameDataGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inGameDataGroupBox.Size = new System.Drawing.Size(439, 474);
            this.inGameDataGroupBox.TabIndex = 2;
            this.inGameDataGroupBox.TabStop = false;
            this.inGameDataGroupBox.Text = "In Game Data";
            // 
            // squadronSizeLabel
            // 
            this.squadronSizeLabel.AutoSize = true;
            this.squadronSizeLabel.Location = new System.Drawing.Point(229, 103);
            this.squadronSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.squadronSizeLabel.Name = "squadronSizeLabel";
            this.squadronSizeLabel.Size = new System.Drawing.Size(81, 15);
            this.squadronSizeLabel.TabIndex = 1118;
            this.squadronSizeLabel.Text = "Squadron Size";
            // 
            // squadronSize
            // 
            this.squadronSize.Location = new System.Drawing.Point(364, 101);
            this.squadronSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.squadronSize.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.squadronSize.Name = "squadronSize";
            this.squadronSize.Size = new System.Drawing.Size(59, 23);
            this.squadronSize.TabIndex = 1119;
            this.squadronSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.squadronSize.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.squadronSize.ValueChanged += new System.EventHandler(this.squadronSize_ValueChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(220, 20);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(213, 23);
            this.name.TabIndex = 1117;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // encyclopediaDescriptionLabel
            // 
            this.encyclopediaDescriptionLabel.AutoSize = true;
            this.encyclopediaDescriptionLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.encyclopediaDescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.encyclopediaDescriptionLabel.Location = new System.Drawing.Point(288, 389);
            this.encyclopediaDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encyclopediaDescriptionLabel.Name = "encyclopediaDescriptionLabel";
            this.encyclopediaDescriptionLabel.Size = new System.Drawing.Size(140, 15);
            this.encyclopediaDescriptionLabel.TabIndex = 19;
            this.encyclopediaDescriptionLabel.Text = "Encyclopedia Description";
            // 
            // shieldStrengthLabel
            // 
            this.shieldStrengthLabel.AutoSize = true;
            this.shieldStrengthLabel.Location = new System.Drawing.Point(13, 178);
            this.shieldStrengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shieldStrengthLabel.Name = "shieldStrengthLabel";
            this.shieldStrengthLabel.Size = new System.Drawing.Size(87, 15);
            this.shieldStrengthLabel.TabIndex = 0;
            this.shieldStrengthLabel.Text = "Shield Strength";
            // 
            // shieldStrength
            // 
            this.shieldStrength.Location = new System.Drawing.Point(146, 176);
            this.shieldStrength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shieldStrength.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.shieldStrength.Name = "shieldStrength";
            this.shieldStrength.Size = new System.Drawing.Size(59, 23);
            this.shieldStrength.TabIndex = 13;
            this.shieldStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shieldStrength.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.shieldStrength.ValueChanged += new System.EventHandler(this.shieldStrength_ValueChanged);
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(8, 20);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(205, 104);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 114;
            this.picture.TabStop = false;
            // 
            // maneuverabilityLabel
            // 
            this.maneuverabilityLabel.AutoSize = true;
            this.maneuverabilityLabel.Location = new System.Drawing.Point(228, 153);
            this.maneuverabilityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maneuverabilityLabel.Name = "maneuverabilityLabel";
            this.maneuverabilityLabel.Size = new System.Drawing.Size(92, 15);
            this.maneuverabilityLabel.TabIndex = 0;
            this.maneuverabilityLabel.Text = "Maneuverability";
            // 
            // hyperdriveLabel
            // 
            this.hyperdriveLabel.AutoSize = true;
            this.hyperdriveLabel.Location = new System.Drawing.Point(13, 204);
            this.hyperdriveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hyperdriveLabel.Name = "hyperdriveLabel";
            this.hyperdriveLabel.Size = new System.Drawing.Size(132, 15);
            this.hyperdriveLabel.TabIndex = 115;
            this.hyperdriveLabel.Text = "Hyperdrive (low=faster)";
            // 
            // subLightEngineLabel
            // 
            this.subLightEngineLabel.AutoSize = true;
            this.subLightEngineLabel.Location = new System.Drawing.Point(229, 128);
            this.subLightEngineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subLightEngineLabel.Name = "subLightEngineLabel";
            this.subLightEngineLabel.Size = new System.Drawing.Size(98, 15);
            this.subLightEngineLabel.TabIndex = 0;
            this.subLightEngineLabel.Text = "Sub-Light Engine";
            // 
            // subLightEngine
            // 
            this.subLightEngine.Location = new System.Drawing.Point(365, 126);
            this.subLightEngine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.subLightEngine.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.subLightEngine.Name = "subLightEngine";
            this.subLightEngine.Size = new System.Drawing.Size(59, 23);
            this.subLightEngine.TabIndex = 9;
            this.subLightEngine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.subLightEngine.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.subLightEngine.ValueChanged += new System.EventHandler(this.subLightEngine_ValueChanged);
            // 
            // maneuverability
            // 
            this.maneuverability.Location = new System.Drawing.Point(365, 151);
            this.maneuverability.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maneuverability.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maneuverability.Name = "maneuverability";
            this.maneuverability.Size = new System.Drawing.Size(59, 23);
            this.maneuverability.TabIndex = 10;
            this.maneuverability.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maneuverability.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maneuverability.ValueChanged += new System.EventHandler(this.maneuverability_ValueChanged);
            // 
            // hyperdrive
            // 
            this.hyperdrive.Location = new System.Drawing.Point(146, 201);
            this.hyperdrive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hyperdrive.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.hyperdrive.Name = "hyperdrive";
            this.hyperdrive.Size = new System.Drawing.Size(59, 23);
            this.hyperdrive.TabIndex = 11;
            this.hyperdrive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hyperdrive.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.hyperdrive.ValueChanged += new System.EventHandler(this.hyperdrive_ValueChanged);
            // 
            // hyperdriveIfDamagedLabel
            // 
            this.hyperdriveIfDamagedLabel.AutoSize = true;
            this.hyperdriveIfDamagedLabel.Location = new System.Drawing.Point(7, 273);
            this.hyperdriveIfDamagedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hyperdriveIfDamagedLabel.Name = "hyperdriveIfDamagedLabel";
            this.hyperdriveIfDamagedLabel.Size = new System.Drawing.Size(129, 15);
            this.hyperdriveIfDamagedLabel.TabIndex = 0;
            this.hyperdriveIfDamagedLabel.Text = "Hyperdrive if Damaged";
            // 
            // hyperdriveIfDamaged
            // 
            this.hyperdriveIfDamaged.Location = new System.Drawing.Point(141, 271);
            this.hyperdriveIfDamaged.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hyperdriveIfDamaged.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.hyperdriveIfDamaged.Name = "hyperdriveIfDamaged";
            this.hyperdriveIfDamaged.Size = new System.Drawing.Size(59, 23);
            this.hyperdriveIfDamaged.TabIndex = 12;
            this.hyperdriveIfDamaged.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hyperdriveIfDamaged.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.hyperdriveIfDamaged.ValueChanged += new System.EventHandler(this.hyperdriveIfDamaged_ValueChanged);
            // 
            // field2_1
            // 
            this.field2_1.ForeColor = System.Drawing.Color.Red;
            this.field2_1.Location = new System.Drawing.Point(141, 46);
            this.field2_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.field2_1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.field2_1.Name = "field2_1";
            this.field2_1.Size = new System.Drawing.Size(59, 23);
            this.field2_1.TabIndex = 1121;
            this.field2_1.TabStop = false;
            this.field2_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.field2_1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.field2_1.ValueChanged += new System.EventHandler(this.field2_1_ValueChanged);
            // 
            // field2_1Label
            // 
            this.field2_1Label.AutoSize = true;
            this.field2_1Label.ForeColor = System.Drawing.Color.Red;
            this.field2_1Label.Location = new System.Drawing.Point(7, 48);
            this.field2_1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field2_1Label.Name = "field2_1Label";
            this.field2_1Label.Size = new System.Drawing.Size(93, 15);
            this.field2_1Label.TabIndex = 1120;
            this.field2_1Label.Text = "Field2 (always 1)";
            // 
            // hiddenDataGroupBox
            // 
            this.hiddenDataGroupBox.Controls.Add(this.torpedoesRangeLabel);
            this.hiddenDataGroupBox.Controls.Add(this.torpedoesRange);
            this.hiddenDataGroupBox.Controls.Add(this.laserCannonRangeLabel);
            this.hiddenDataGroupBox.Controls.Add(this.nextProductionFamilyLabel);
            this.hiddenDataGroupBox.Controls.Add(this.turbolaserRange);
            this.hiddenDataGroupBox.Controls.Add(this.ionCannonRangeLabel);
            this.hiddenDataGroupBox.Controls.Add(this.field2_1);
            this.hiddenDataGroupBox.Controls.Add(this.ionCannonRange);
            this.hiddenDataGroupBox.Controls.Add(this.turbolaserRangeLabel);
            this.hiddenDataGroupBox.Controls.Add(this.laserCannonRange);
            this.hiddenDataGroupBox.Controls.Add(this.field2_1Label);
            this.hiddenDataGroupBox.Controls.Add(this.idLabel);
            this.hiddenDataGroupBox.Controls.Add(this.researchDifficultyLabel);
            this.hiddenDataGroupBox.Controls.Add(this.nextProductionFamily);
            this.hiddenDataGroupBox.Controls.Add(this.textStraDllId);
            this.hiddenDataGroupBox.Controls.Add(this.textStraDllIdLabel);
            this.hiddenDataGroupBox.Controls.Add(this.productionFamilyLabel);
            this.hiddenDataGroupBox.Controls.Add(this.field7_2Label);
            this.hiddenDataGroupBox.Controls.Add(this.familyId);
            this.hiddenDataGroupBox.Controls.Add(this.productionFamily);
            this.hiddenDataGroupBox.Controls.Add(this.researchOrderLabel);
            this.hiddenDataGroupBox.Controls.Add(this.familyIdLabel);
            this.hiddenDataGroupBox.Controls.Add(this.researchDifficulty);
            this.hiddenDataGroupBox.Controls.Add(this.idHexLabel);
            this.hiddenDataGroupBox.Controls.Add(this.hyperdriveIfDamaged);
            this.hiddenDataGroupBox.Controls.Add(this.familyIdHexLabel);
            this.hiddenDataGroupBox.Controls.Add(this.field7_2);
            this.hiddenDataGroupBox.Controls.Add(this.researchOrder);
            this.hiddenDataGroupBox.Controls.Add(this.UprisingDefenseLabel);
            this.hiddenDataGroupBox.Controls.Add(this.id);
            this.hiddenDataGroupBox.Controls.Add(this.uprisingDefense);
            this.hiddenDataGroupBox.Controls.Add(this.hyperdriveIfDamagedLabel);
            this.hiddenDataGroupBox.Location = new System.Drawing.Point(448, 2);
            this.hiddenDataGroupBox.Name = "hiddenDataGroupBox";
            this.hiddenDataGroupBox.Size = new System.Drawing.Size(233, 425);
            this.hiddenDataGroupBox.TabIndex = 1122;
            this.hiddenDataGroupBox.TabStop = false;
            this.hiddenDataGroupBox.Text = "Hidden Data";
            // 
            // torpedoesRangeLabel
            // 
            this.torpedoesRangeLabel.AutoSize = true;
            this.torpedoesRangeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.torpedoesRangeLabel.Location = new System.Drawing.Point(70, 398);
            this.torpedoesRangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.torpedoesRangeLabel.Name = "torpedoesRangeLabel";
            this.torpedoesRangeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.torpedoesRangeLabel.Size = new System.Drawing.Size(97, 15);
            this.torpedoesRangeLabel.TabIndex = 1125;
            this.torpedoesRangeLabel.Text = "Torpedoes Range";
            this.torpedoesRangeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // torpedoesRange
            // 
            this.torpedoesRange.Location = new System.Drawing.Point(7, 396);
            this.torpedoesRange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.torpedoesRange.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.torpedoesRange.Name = "torpedoesRange";
            this.torpedoesRange.Size = new System.Drawing.Size(59, 23);
            this.torpedoesRange.TabIndex = 1124;
            this.torpedoesRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.torpedoesRange.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.torpedoesRange.ValueChanged += new System.EventHandler(this.torpedoes_ValueChanged);
            // 
            // laserCannonRangeLabel
            // 
            this.laserCannonRangeLabel.AutoSize = true;
            this.laserCannonRangeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.laserCannonRangeLabel.Location = new System.Drawing.Point(70, 373);
            this.laserCannonRangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laserCannonRangeLabel.Name = "laserCannonRangeLabel";
            this.laserCannonRangeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laserCannonRangeLabel.Size = new System.Drawing.Size(115, 15);
            this.laserCannonRangeLabel.TabIndex = 1123;
            this.laserCannonRangeLabel.Text = "Laser Cannon Range";
            this.laserCannonRangeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ionCannonRangeLabel
            // 
            this.ionCannonRangeLabel.AutoSize = true;
            this.ionCannonRangeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ionCannonRangeLabel.Location = new System.Drawing.Point(70, 348);
            this.ionCannonRangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ionCannonRangeLabel.Name = "ionCannonRangeLabel";
            this.ionCannonRangeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ionCannonRangeLabel.Size = new System.Drawing.Size(105, 15);
            this.ionCannonRangeLabel.TabIndex = 1122;
            this.ionCannonRangeLabel.Text = "Ion Cannon Range";
            this.ionCannonRangeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FightersForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(686, 548);
            this.Controls.Add(this.hiddenDataGroupBox);
            this.Controls.Add(this.inGameDataGroupBox);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.selector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(702, 587);
            this.MinimumSize = new System.Drawing.Size(702, 587);
            this.Name = "FightersForm";
            this.Text = "Fighters (FIGHTSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.Enter += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uprisingDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refinedMaterialCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardmentDefense)).EndInit();
            this.attackStrengthGroupBox.ResumeLayout(false);
            this.attackStrengthGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.torpedoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonStarboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonAft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonStarboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overallAttackStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonAft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonFore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonFore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserStarboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserAft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserFore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonAttackStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonAttackStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserAttackStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            this.inGameDataGroupBox.ResumeLayout(false);
            this.inGameDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.squadronSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subLightEngine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maneuverability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperdrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperdriveIfDamaged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2_1)).EndInit();
            this.hiddenDataGroupBox.ResumeLayout(false);
            this.hiddenDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.torpedoesRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label encyclopediaDescriptionLabel;
        private Label hyperdriveLabel;
        private Label totalAttackLabel;
        private Label overallLabel;
        private NumericUpDown field2_1;
        private Label field2_1Label;
        private GroupBox hiddenDataGroupBox;
        private TextBox name;
        private Label laserCannonRangeLabel;
        private Label ionCannonRangeLabel;
        private NumericUpDown torpedoes;
        private Label torpedoesLabel;
        private Label squadronSizeLabel;
        private NumericUpDown squadronSize;
        private Label torpedoesRangeLabel;
        private NumericUpDown torpedoesRange;
    }
}