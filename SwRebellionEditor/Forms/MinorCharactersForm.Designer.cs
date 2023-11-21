using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class MinorCharactersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button Open;
        private Button SaveAs;
        private Button Cancel;
        private Button Ok;
        private TrackBar selector;
        private CheckBox isAlliance;
        private CheckBox isEmpire;
        private NumericUpDown combatVariance;
        private NumericUpDown diplomacyVariance;
        private NumericUpDown espionageVariance;
        private Label combatLabel;
        private NumericUpDown combatBase;
        private Label diplomacyLabel;
        private NumericUpDown diplomacyBase;
        private NumericUpDown espionageBase;
        private Label espionageLabel;
        private NumericUpDown facilityDesignVariance;
        private NumericUpDown shipDesignVariance;
        private NumericUpDown troopTrainingVariance;
        private Label facilityDesignLabel;
        private NumericUpDown facilityDesignBase;
        private Label shipDesignLabel;
        private NumericUpDown shipDesignBase;
        private NumericUpDown troopTrainingBase;
        private Label troopTrainingLabel;
        private NumericUpDown loyaltyVariance;
        private NumericUpDown loyaltyBase;
        private Label loyaltyLabel;
        private Label varianceLabel;
        private Label baseLabel;
        private CheckBox isUnableToBetray;
        private GroupBox hiddenDataGroupBox;
        private Label hiddenVarianceLabel;
        private Label hiddenBaseLabel;
        private NumericUpDown jediLevelVariance;
        private Label jediProbabilityLabel;
        private NumericUpDown jediProbability;
        private NumericUpDown jediLevelBase;
        private Label jediLevelLabel;
        private CheckBox canBeCommander;
        private CheckBox canBeAdmiral;
        private CheckBox canBeGeneral;
        private NumericUpDown jediEspionageBase;
        private NumericUpDown jediDiplomacyBase;
        private NumericUpDown jediCombatBase;
        private NumericUpDown jediLeadershipBase;
        private CheckBox isJediTrainer;
        private CheckBox isKnownJedi;
        private RichTextBox encyclopediaDescription;
        private PictureBox picture;
        private ImageList minorCharactersImages;
        private Label leiaForceLabel;
        private ListView minorCharactersListView;
        private NumericUpDown field2_1;
        private NumericUpDown textStraDllId;
        private NumericUpDown productionFamily_0;
        private Label field2_1Label;
        private NumericUpDown familyId;
        private Label productionFamily_0Label;
        private Label textStraDllIdLabel;
        private Label familyIdLabel;
        private Label nextProductionFamily_0Label;
        private NumericUpDown nextProductionFamily_0;
        private Label familyIdHexLabel;
        private Label idHexLabel;
        private NumericUpDown id;
        private Label idLabel;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinorCharactersForm));
            this.leiaForceLabel = new System.Windows.Forms.Label();
            this.jediEspionageBase = new System.Windows.Forms.NumericUpDown();
            this.jediDiplomacyBase = new System.Windows.Forms.NumericUpDown();
            this.jediCombatBase = new System.Windows.Forms.NumericUpDown();
            this.jediLeadershipBase = new System.Windows.Forms.NumericUpDown();
            this.hiddenDataGroupBox = new System.Windows.Forms.GroupBox();
            this.researchDifficulty_0 = new System.Windows.Forms.NumericUpDown();
            this.loyaltyBase = new System.Windows.Forms.NumericUpDown();
            this.isUnableToBetray = new System.Windows.Forms.CheckBox();
            this.researchDifficulty_0Label = new System.Windows.Forms.Label();
            this.researchOrder_0 = new System.Windows.Forms.NumericUpDown();
            this.loyaltyVariance = new System.Windows.Forms.NumericUpDown();
            this.researchOrder_0Label = new System.Windows.Forms.Label();
            this.maintenanceCost = new System.Windows.Forms.NumericUpDown();
            this.loyaltyLabel = new System.Windows.Forms.Label();
            this.maintenanceCostLabel = new System.Windows.Forms.Label();
            this.refinedMaterialCost_0 = new System.Windows.Forms.NumericUpDown();
            this.refinedMaterialCost_0Label = new System.Windows.Forms.Label();
            this.field7_2 = new System.Windows.Forms.NumericUpDown();
            this.field7_2Label = new System.Windows.Forms.Label();
            this.textStraDllId = new System.Windows.Forms.NumericUpDown();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.textStraDllIdLabel = new System.Windows.Forms.Label();
            this.hiddenVarianceLabel = new System.Windows.Forms.Label();
            this.field2_1 = new System.Windows.Forms.NumericUpDown();
            this.familyId = new System.Windows.Forms.NumericUpDown();
            this.productionFamily_0 = new System.Windows.Forms.NumericUpDown();
            this.idHexLabel = new System.Windows.Forms.Label();
            this.familyIdLabel = new System.Windows.Forms.Label();
            this.hiddenBaseLabel = new System.Windows.Forms.Label();
            this.productionFamily_0Label = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.NumericUpDown();
            this.field2_1Label = new System.Windows.Forms.Label();
            this.nextProductionFamily_0Label = new System.Windows.Forms.Label();
            this.jediLevelVariance = new System.Windows.Forms.NumericUpDown();
            this.nextProductionFamily_0 = new System.Windows.Forms.NumericUpDown();
            this.idLabel = new System.Windows.Forms.Label();
            this.jediProbabilityLabel = new System.Windows.Forms.Label();
            this.jediProbability = new System.Windows.Forms.NumericUpDown();
            this.jediLevelBase = new System.Windows.Forms.NumericUpDown();
            this.jediLevelLabel = new System.Windows.Forms.Label();
            this.facilityDesignVariance = new System.Windows.Forms.NumericUpDown();
            this.shipDesignVariance = new System.Windows.Forms.NumericUpDown();
            this.troopTrainingVariance = new System.Windows.Forms.NumericUpDown();
            this.facilityDesignLabel = new System.Windows.Forms.Label();
            this.facilityDesignBase = new System.Windows.Forms.NumericUpDown();
            this.shipDesignLabel = new System.Windows.Forms.Label();
            this.shipDesignBase = new System.Windows.Forms.NumericUpDown();
            this.troopTrainingBase = new System.Windows.Forms.NumericUpDown();
            this.troopTrainingLabel = new System.Windows.Forms.Label();
            this.varianceLabel = new System.Windows.Forms.Label();
            this.combatVariance = new System.Windows.Forms.NumericUpDown();
            this.diplomacyVariance = new System.Windows.Forms.NumericUpDown();
            this.espionageVariance = new System.Windows.Forms.NumericUpDown();
            this.encyclopediaDescription = new System.Windows.Forms.RichTextBox();
            this.isJediTrainer = new System.Windows.Forms.CheckBox();
            this.isKnownJedi = new System.Windows.Forms.CheckBox();
            this.baseLabel = new System.Windows.Forms.Label();
            this.combatLabel = new System.Windows.Forms.Label();
            this.combatBase = new System.Windows.Forms.NumericUpDown();
            this.diplomacyLabel = new System.Windows.Forms.Label();
            this.diplomacyBase = new System.Windows.Forms.NumericUpDown();
            this.espionageBase = new System.Windows.Forms.NumericUpDown();
            this.espionageLabel = new System.Windows.Forms.Label();
            this.selector = new System.Windows.Forms.TrackBar();
            this.isAlliance = new System.Windows.Forms.CheckBox();
            this.isEmpire = new System.Windows.Forms.CheckBox();
            this.canBeCommander = new System.Windows.Forms.CheckBox();
            this.canBeAdmiral = new System.Windows.Forms.CheckBox();
            this.canBeGeneral = new System.Windows.Forms.CheckBox();
            this.Open = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.minorCharactersImages = new System.Windows.Forms.ImageList(this.components);
            this.minorCharactersListView = new System.Windows.Forms.ListView();
            this.picture = new System.Windows.Forms.PictureBox();
            this.gameDataGroupBox = new System.Windows.Forms.GroupBox();
            this.encyclopediaDescriptionLabel = new System.Windows.Forms.Label();
            this.baseJediModsLabel = new System.Windows.Forms.Label();
            this.leadershipVariance = new System.Windows.Forms.NumericUpDown();
            this.leadershipBase = new System.Windows.Forms.NumericUpDown();
            this.leadershipLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.jediEspionageBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediDiplomacyBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediCombatBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediLeadershipBase)).BeginInit();
            this.hiddenDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyaltyBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyaltyVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refinedMaterialCost_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFamily_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediLevelVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFamily_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediLevelBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityDesignVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipDesignVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopTrainingVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityDesignBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipDesignBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopTrainingBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomacyVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espionageVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomacyBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espionageBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.gameDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leadershipVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadershipBase)).BeginInit();
            this.SuspendLayout();
            // 
            // leiaForceLabel
            // 
            this.leiaForceLabel.AutoSize = true;
            this.leiaForceLabel.ForeColor = System.Drawing.Color.Red;
            this.leiaForceLabel.Location = new System.Drawing.Point(6, 435);
            this.leiaForceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leiaForceLabel.Name = "leiaForceLabel";
            this.leiaForceLabel.Size = new System.Drawing.Size(79, 15);
            this.leiaForceLabel.TabIndex = 28;
            this.leiaForceLabel.Text = "--Leia Label--";
            // 
            // jediEspionageBase
            // 
            this.jediEspionageBase.Enabled = false;
            this.jediEspionageBase.Location = new System.Drawing.Point(231, 179);
            this.jediEspionageBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediEspionageBase.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.jediEspionageBase.Name = "jediEspionageBase";
            this.jediEspionageBase.Size = new System.Drawing.Size(59, 23);
            this.jediEspionageBase.TabIndex = 0;
            this.jediEspionageBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediEspionageBase.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            // 
            // jediDiplomacyBase
            // 
            this.jediDiplomacyBase.Enabled = false;
            this.jediDiplomacyBase.Location = new System.Drawing.Point(231, 153);
            this.jediDiplomacyBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediDiplomacyBase.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.jediDiplomacyBase.Name = "jediDiplomacyBase";
            this.jediDiplomacyBase.Size = new System.Drawing.Size(59, 23);
            this.jediDiplomacyBase.TabIndex = 0;
            this.jediDiplomacyBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediDiplomacyBase.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            // 
            // jediCombatBase
            // 
            this.jediCombatBase.Enabled = false;
            this.jediCombatBase.Location = new System.Drawing.Point(231, 205);
            this.jediCombatBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediCombatBase.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.jediCombatBase.Name = "jediCombatBase";
            this.jediCombatBase.Size = new System.Drawing.Size(59, 23);
            this.jediCombatBase.TabIndex = 0;
            this.jediCombatBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediCombatBase.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            // 
            // jediLeadershipBase
            // 
            this.jediLeadershipBase.Enabled = false;
            this.jediLeadershipBase.Location = new System.Drawing.Point(231, 231);
            this.jediLeadershipBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediLeadershipBase.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.jediLeadershipBase.Name = "jediLeadershipBase";
            this.jediLeadershipBase.Size = new System.Drawing.Size(59, 23);
            this.jediLeadershipBase.TabIndex = 0;
            this.jediLeadershipBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediLeadershipBase.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            // 
            // hiddenDataGroupBox
            // 
            this.hiddenDataGroupBox.Controls.Add(this.leiaForceLabel);
            this.hiddenDataGroupBox.Controls.Add(this.researchDifficulty_0);
            this.hiddenDataGroupBox.Controls.Add(this.loyaltyBase);
            this.hiddenDataGroupBox.Controls.Add(this.isUnableToBetray);
            this.hiddenDataGroupBox.Controls.Add(this.researchDifficulty_0Label);
            this.hiddenDataGroupBox.Controls.Add(this.researchOrder_0);
            this.hiddenDataGroupBox.Controls.Add(this.loyaltyVariance);
            this.hiddenDataGroupBox.Controls.Add(this.researchOrder_0Label);
            this.hiddenDataGroupBox.Controls.Add(this.maintenanceCost);
            this.hiddenDataGroupBox.Controls.Add(this.loyaltyLabel);
            this.hiddenDataGroupBox.Controls.Add(this.maintenanceCostLabel);
            this.hiddenDataGroupBox.Controls.Add(this.refinedMaterialCost_0);
            this.hiddenDataGroupBox.Controls.Add(this.refinedMaterialCost_0Label);
            this.hiddenDataGroupBox.Controls.Add(this.field7_2);
            this.hiddenDataGroupBox.Controls.Add(this.field7_2Label);
            this.hiddenDataGroupBox.Controls.Add(this.textStraDllId);
            this.hiddenDataGroupBox.Controls.Add(this.familyIdHexLabel);
            this.hiddenDataGroupBox.Controls.Add(this.textStraDllIdLabel);
            this.hiddenDataGroupBox.Controls.Add(this.hiddenVarianceLabel);
            this.hiddenDataGroupBox.Controls.Add(this.field2_1);
            this.hiddenDataGroupBox.Controls.Add(this.familyId);
            this.hiddenDataGroupBox.Controls.Add(this.productionFamily_0);
            this.hiddenDataGroupBox.Controls.Add(this.idHexLabel);
            this.hiddenDataGroupBox.Controls.Add(this.familyIdLabel);
            this.hiddenDataGroupBox.Controls.Add(this.hiddenBaseLabel);
            this.hiddenDataGroupBox.Controls.Add(this.productionFamily_0Label);
            this.hiddenDataGroupBox.Controls.Add(this.id);
            this.hiddenDataGroupBox.Controls.Add(this.field2_1Label);
            this.hiddenDataGroupBox.Controls.Add(this.nextProductionFamily_0Label);
            this.hiddenDataGroupBox.Controls.Add(this.jediLevelVariance);
            this.hiddenDataGroupBox.Controls.Add(this.nextProductionFamily_0);
            this.hiddenDataGroupBox.Controls.Add(this.idLabel);
            this.hiddenDataGroupBox.Controls.Add(this.jediProbabilityLabel);
            this.hiddenDataGroupBox.Controls.Add(this.jediProbability);
            this.hiddenDataGroupBox.Controls.Add(this.jediLevelBase);
            this.hiddenDataGroupBox.Controls.Add(this.jediLevelLabel);
            this.hiddenDataGroupBox.Location = new System.Drawing.Point(566, 6);
            this.hiddenDataGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hiddenDataGroupBox.Name = "hiddenDataGroupBox";
            this.hiddenDataGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hiddenDataGroupBox.Size = new System.Drawing.Size(264, 464);
            this.hiddenDataGroupBox.TabIndex = 6;
            this.hiddenDataGroupBox.TabStop = false;
            this.hiddenDataGroupBox.Text = "Hidden Data";
            // 
            // researchDifficulty_0
            // 
            this.researchDifficulty_0.BackColor = System.Drawing.SystemColors.Window;
            this.researchDifficulty_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.researchDifficulty_0.Location = new System.Drawing.Point(136, 279);
            this.researchDifficulty_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchDifficulty_0.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.researchDifficulty_0.Name = "researchDifficulty_0";
            this.researchDifficulty_0.Size = new System.Drawing.Size(59, 23);
            this.researchDifficulty_0.TabIndex = 1137;
            this.researchDifficulty_0.TabStop = false;
            this.researchDifficulty_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.researchDifficulty_0.ValueChanged += new System.EventHandler(this.researchDifficulty_0_ValueChanged);
            // 
            // loyaltyBase
            // 
            this.loyaltyBase.Location = new System.Drawing.Point(136, 325);
            this.loyaltyBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loyaltyBase.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.loyaltyBase.Name = "loyaltyBase";
            this.loyaltyBase.Size = new System.Drawing.Size(59, 23);
            this.loyaltyBase.TabIndex = 10;
            this.loyaltyBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.loyaltyBase.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.loyaltyBase.ValueChanged += new System.EventHandler(this.loyaltyBase_ValueChanged);
            // 
            // isUnableToBetray
            // 
            this.isUnableToBetray.AutoSize = true;
            this.isUnableToBetray.Location = new System.Drawing.Point(7, 411);
            this.isUnableToBetray.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isUnableToBetray.Name = "isUnableToBetray";
            this.isUnableToBetray.Size = new System.Drawing.Size(113, 19);
            this.isUnableToBetray.TabIndex = 17;
            this.isUnableToBetray.Text = "Unable to Betray";
            this.isUnableToBetray.UseVisualStyleBackColor = true;
            this.isUnableToBetray.CheckStateChanged += new System.EventHandler(this.isUnableToBetray_CheckStateChanged);
            // 
            // researchDifficulty_0Label
            // 
            this.researchDifficulty_0Label.AutoSize = true;
            this.researchDifficulty_0Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.researchDifficulty_0Label.Location = new System.Drawing.Point(7, 281);
            this.researchDifficulty_0Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.researchDifficulty_0Label.Name = "researchDifficulty_0Label";
            this.researchDifficulty_0Label.Size = new System.Drawing.Size(105, 15);
            this.researchDifficulty_0Label.TabIndex = 1136;
            this.researchDifficulty_0Label.Text = "Research Difficulty";
            // 
            // researchOrder_0
            // 
            this.researchOrder_0.BackColor = System.Drawing.SystemColors.Window;
            this.researchOrder_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.researchOrder_0.Location = new System.Drawing.Point(136, 253);
            this.researchOrder_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchOrder_0.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.researchOrder_0.Name = "researchOrder_0";
            this.researchOrder_0.Size = new System.Drawing.Size(59, 23);
            this.researchOrder_0.TabIndex = 1135;
            this.researchOrder_0.TabStop = false;
            this.researchOrder_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.researchOrder_0.ValueChanged += new System.EventHandler(this.researchOrder_0_ValueChanged);
            // 
            // loyaltyVariance
            // 
            this.loyaltyVariance.Location = new System.Drawing.Point(199, 325);
            this.loyaltyVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loyaltyVariance.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.loyaltyVariance.Name = "loyaltyVariance";
            this.loyaltyVariance.Size = new System.Drawing.Size(59, 23);
            this.loyaltyVariance.TabIndex = 11;
            this.loyaltyVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.loyaltyVariance.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.loyaltyVariance.ValueChanged += new System.EventHandler(this.loyaltyVariance_ValueChanged);
            // 
            // researchOrder_0Label
            // 
            this.researchOrder_0Label.AutoSize = true;
            this.researchOrder_0Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.researchOrder_0Label.Location = new System.Drawing.Point(7, 255);
            this.researchOrder_0Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.researchOrder_0Label.Name = "researchOrder_0Label";
            this.researchOrder_0Label.Size = new System.Drawing.Size(87, 15);
            this.researchOrder_0Label.TabIndex = 1134;
            this.researchOrder_0Label.Text = "Research Order";
            // 
            // maintenanceCost
            // 
            this.maintenanceCost.BackColor = System.Drawing.SystemColors.Window;
            this.maintenanceCost.ForeColor = System.Drawing.SystemColors.WindowText;
            this.maintenanceCost.Location = new System.Drawing.Point(136, 227);
            this.maintenanceCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maintenanceCost.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.maintenanceCost.Name = "maintenanceCost";
            this.maintenanceCost.Size = new System.Drawing.Size(59, 23);
            this.maintenanceCost.TabIndex = 1133;
            this.maintenanceCost.TabStop = false;
            this.maintenanceCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maintenanceCost.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.maintenanceCost.ValueChanged += new System.EventHandler(this.maintenanceCost_ValueChanged);
            // 
            // loyaltyLabel
            // 
            this.loyaltyLabel.AutoSize = true;
            this.loyaltyLabel.Location = new System.Drawing.Point(7, 327);
            this.loyaltyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loyaltyLabel.Name = "loyaltyLabel";
            this.loyaltyLabel.Size = new System.Drawing.Size(45, 15);
            this.loyaltyLabel.TabIndex = 12;
            this.loyaltyLabel.Text = "Loyalty";
            // 
            // maintenanceCostLabel
            // 
            this.maintenanceCostLabel.AutoSize = true;
            this.maintenanceCostLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.maintenanceCostLabel.Location = new System.Drawing.Point(7, 229);
            this.maintenanceCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maintenanceCostLabel.Name = "maintenanceCostLabel";
            this.maintenanceCostLabel.Size = new System.Drawing.Size(103, 15);
            this.maintenanceCostLabel.TabIndex = 1132;
            this.maintenanceCostLabel.Text = "Maintenance Cost";
            // 
            // refinedMaterialCost_0
            // 
            this.refinedMaterialCost_0.BackColor = System.Drawing.SystemColors.Window;
            this.refinedMaterialCost_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.refinedMaterialCost_0.Location = new System.Drawing.Point(136, 201);
            this.refinedMaterialCost_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.refinedMaterialCost_0.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.refinedMaterialCost_0.Name = "refinedMaterialCost_0";
            this.refinedMaterialCost_0.Size = new System.Drawing.Size(59, 23);
            this.refinedMaterialCost_0.TabIndex = 1131;
            this.refinedMaterialCost_0.TabStop = false;
            this.refinedMaterialCost_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.refinedMaterialCost_0.ValueChanged += new System.EventHandler(this.refinedMaterialCost_0_ValueChanged);
            // 
            // refinedMaterialCost_0Label
            // 
            this.refinedMaterialCost_0Label.AutoSize = true;
            this.refinedMaterialCost_0Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.refinedMaterialCost_0Label.Location = new System.Drawing.Point(6, 203);
            this.refinedMaterialCost_0Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.refinedMaterialCost_0Label.Name = "refinedMaterialCost_0Label";
            this.refinedMaterialCost_0Label.Size = new System.Drawing.Size(120, 15);
            this.refinedMaterialCost_0Label.TabIndex = 1130;
            this.refinedMaterialCost_0Label.Text = "Refined Material Cost";
            // 
            // field7_2
            // 
            this.field7_2.BackColor = System.Drawing.SystemColors.Window;
            this.field7_2.ForeColor = System.Drawing.Color.Red;
            this.field7_2.Location = new System.Drawing.Point(136, 175);
            this.field7_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.field7_2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.field7_2.Name = "field7_2";
            this.field7_2.Size = new System.Drawing.Size(59, 23);
            this.field7_2.TabIndex = 1129;
            this.field7_2.TabStop = false;
            this.field7_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.field7_2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.field7_2.ValueChanged += new System.EventHandler(this.field7_2_ValueChanged);
            // 
            // field7_2Label
            // 
            this.field7_2Label.AutoSize = true;
            this.field7_2Label.ForeColor = System.Drawing.Color.Red;
            this.field7_2Label.Location = new System.Drawing.Point(6, 177);
            this.field7_2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field7_2Label.Name = "field7_2Label";
            this.field7_2Label.Size = new System.Drawing.Size(93, 15);
            this.field7_2Label.TabIndex = 1128;
            this.field7_2Label.Text = "Field7 (always 2)";
            // 
            // textStraDllId
            // 
            this.textStraDllId.BackColor = System.Drawing.SystemColors.Window;
            this.textStraDllId.ForeColor = System.Drawing.Color.Red;
            this.textStraDllId.Location = new System.Drawing.Point(136, 149);
            this.textStraDllId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textStraDllId.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.textStraDllId.Name = "textStraDllId";
            this.textStraDllId.Size = new System.Drawing.Size(59, 23);
            this.textStraDllId.TabIndex = 148;
            this.textStraDllId.TabStop = false;
            this.textStraDllId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textStraDllId.Value = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.textStraDllId.ValueChanged += new System.EventHandler(this.textStraDllId_ValueChanged);
            // 
            // familyIdHexLabel
            // 
            this.familyIdHexLabel.AutoSize = true;
            this.familyIdHexLabel.ForeColor = System.Drawing.Color.Red;
            this.familyIdHexLabel.Location = new System.Drawing.Point(197, 128);
            this.familyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdHexLabel.Name = "familyIdHexLabel";
            this.familyIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.familyIdHexLabel.TabIndex = 1127;
            this.familyIdHexLabel.Text = "hex";
            // 
            // textStraDllIdLabel
            // 
            this.textStraDllIdLabel.AutoSize = true;
            this.textStraDllIdLabel.ForeColor = System.Drawing.Color.Red;
            this.textStraDllIdLabel.Location = new System.Drawing.Point(7, 151);
            this.textStraDllIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textStraDllIdLabel.Name = "textStraDllIdLabel";
            this.textStraDllIdLabel.Size = new System.Drawing.Size(77, 15);
            this.textStraDllIdLabel.TabIndex = 144;
            this.textStraDllIdLabel.Text = "TextStra.dll Id";
            // 
            // hiddenVarianceLabel
            // 
            this.hiddenVarianceLabel.AutoSize = true;
            this.hiddenVarianceLabel.BackColor = System.Drawing.Color.Silver;
            this.hiddenVarianceLabel.Location = new System.Drawing.Point(199, 307);
            this.hiddenVarianceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hiddenVarianceLabel.Name = "hiddenVarianceLabel";
            this.hiddenVarianceLabel.Size = new System.Drawing.Size(51, 15);
            this.hiddenVarianceLabel.TabIndex = 11;
            this.hiddenVarianceLabel.Text = "Variance";
            // 
            // field2_1
            // 
            this.field2_1.BackColor = System.Drawing.SystemColors.Window;
            this.field2_1.ForeColor = System.Drawing.Color.Red;
            this.field2_1.Location = new System.Drawing.Point(136, 45);
            this.field2_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.field2_1.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.field2_1.Name = "field2_1";
            this.field2_1.Size = new System.Drawing.Size(59, 23);
            this.field2_1.TabIndex = 146;
            this.field2_1.TabStop = false;
            this.field2_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.field2_1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.field2_1.ValueChanged += new System.EventHandler(this.field2_1_ValueChanged);
            // 
            // familyId
            // 
            this.familyId.BackColor = System.Drawing.SystemColors.Window;
            this.familyId.ForeColor = System.Drawing.Color.Red;
            this.familyId.Location = new System.Drawing.Point(136, 123);
            this.familyId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.familyId.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.familyId.Name = "familyId";
            this.familyId.Size = new System.Drawing.Size(59, 23);
            this.familyId.TabIndex = 147;
            this.familyId.TabStop = false;
            this.familyId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.familyId.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.familyId.ValueChanged += new System.EventHandler(this.familyId_ValueChanged);
            // 
            // productionFamily_0
            // 
            this.productionFamily_0.BackColor = System.Drawing.SystemColors.Window;
            this.productionFamily_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.productionFamily_0.Location = new System.Drawing.Point(136, 71);
            this.productionFamily_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productionFamily_0.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.productionFamily_0.Name = "productionFamily_0";
            this.productionFamily_0.Size = new System.Drawing.Size(59, 23);
            this.productionFamily_0.TabIndex = 138;
            this.productionFamily_0.TabStop = false;
            this.productionFamily_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.productionFamily_0.ValueChanged += new System.EventHandler(this.productionFamily_0_ValueChanged);
            // 
            // idHexLabel
            // 
            this.idHexLabel.AutoSize = true;
            this.idHexLabel.ForeColor = System.Drawing.Color.Red;
            this.idHexLabel.Location = new System.Drawing.Point(197, 21);
            this.idHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idHexLabel.Name = "idHexLabel";
            this.idHexLabel.Size = new System.Drawing.Size(26, 15);
            this.idHexLabel.TabIndex = 1126;
            this.idHexLabel.Text = "hex";
            // 
            // familyIdLabel
            // 
            this.familyIdLabel.AutoSize = true;
            this.familyIdLabel.ForeColor = System.Drawing.Color.Red;
            this.familyIdLabel.Location = new System.Drawing.Point(7, 125);
            this.familyIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdLabel.Name = "familyIdLabel";
            this.familyIdLabel.Size = new System.Drawing.Size(55, 15);
            this.familyIdLabel.TabIndex = 143;
            this.familyIdLabel.Text = "Family Id";
            // 
            // hiddenBaseLabel
            // 
            this.hiddenBaseLabel.AutoSize = true;
            this.hiddenBaseLabel.BackColor = System.Drawing.Color.Silver;
            this.hiddenBaseLabel.Location = new System.Drawing.Point(136, 307);
            this.hiddenBaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hiddenBaseLabel.Name = "hiddenBaseLabel";
            this.hiddenBaseLabel.Size = new System.Drawing.Size(31, 15);
            this.hiddenBaseLabel.TabIndex = 10;
            this.hiddenBaseLabel.Text = "Base";
            // 
            // productionFamily_0Label
            // 
            this.productionFamily_0Label.AutoSize = true;
            this.productionFamily_0Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.productionFamily_0Label.Location = new System.Drawing.Point(6, 73);
            this.productionFamily_0Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productionFamily_0Label.Name = "productionFamily_0Label";
            this.productionFamily_0Label.Size = new System.Drawing.Size(104, 15);
            this.productionFamily_0Label.TabIndex = 140;
            this.productionFamily_0Label.Text = "Production Family";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.Window;
            this.id.ForeColor = System.Drawing.Color.Red;
            this.id.Location = new System.Drawing.Point(136, 19);
            this.id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.id.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(59, 23);
            this.id.TabIndex = 1125;
            this.id.TabStop = false;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.id.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.id.ValueChanged += new System.EventHandler(this.id_ValueChanged);
            // 
            // field2_1Label
            // 
            this.field2_1Label.AutoSize = true;
            this.field2_1Label.ForeColor = System.Drawing.Color.Red;
            this.field2_1Label.Location = new System.Drawing.Point(6, 47);
            this.field2_1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field2_1Label.Name = "field2_1Label";
            this.field2_1Label.Size = new System.Drawing.Size(93, 15);
            this.field2_1Label.TabIndex = 145;
            this.field2_1Label.Text = "Field2 (always 1)";
            // 
            // nextProductionFamily_0Label
            // 
            this.nextProductionFamily_0Label.AutoSize = true;
            this.nextProductionFamily_0Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.nextProductionFamily_0Label.Location = new System.Drawing.Point(7, 99);
            this.nextProductionFamily_0Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nextProductionFamily_0Label.Name = "nextProductionFamily_0Label";
            this.nextProductionFamily_0Label.Size = new System.Drawing.Size(121, 15);
            this.nextProductionFamily_0Label.TabIndex = 142;
            this.nextProductionFamily_0Label.Text = "Production Family +1";
            // 
            // jediLevelVariance
            // 
            this.jediLevelVariance.Location = new System.Drawing.Point(199, 377);
            this.jediLevelVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediLevelVariance.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.jediLevelVariance.Name = "jediLevelVariance";
            this.jediLevelVariance.Size = new System.Drawing.Size(59, 23);
            this.jediLevelVariance.TabIndex = 25;
            this.jediLevelVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediLevelVariance.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.jediLevelVariance.ValueChanged += new System.EventHandler(this.jediLevelVariance_ValueChanged);
            // 
            // nextProductionFamily_0
            // 
            this.nextProductionFamily_0.BackColor = System.Drawing.SystemColors.Window;
            this.nextProductionFamily_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.nextProductionFamily_0.Location = new System.Drawing.Point(136, 97);
            this.nextProductionFamily_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextProductionFamily_0.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nextProductionFamily_0.Name = "nextProductionFamily_0";
            this.nextProductionFamily_0.Size = new System.Drawing.Size(59, 23);
            this.nextProductionFamily_0.TabIndex = 141;
            this.nextProductionFamily_0.TabStop = false;
            this.nextProductionFamily_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nextProductionFamily_0.ValueChanged += new System.EventHandler(this.nextProductionFamily_0_ValueChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.ForeColor = System.Drawing.Color.Red;
            this.idLabel.Location = new System.Drawing.Point(7, 21);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(17, 15);
            this.idLabel.TabIndex = 1124;
            this.idLabel.Text = "Id";
            // 
            // jediProbabilityLabel
            // 
            this.jediProbabilityLabel.AutoSize = true;
            this.jediProbabilityLabel.Location = new System.Drawing.Point(7, 353);
            this.jediProbabilityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jediProbabilityLabel.Name = "jediProbabilityLabel";
            this.jediProbabilityLabel.Size = new System.Drawing.Size(87, 15);
            this.jediProbabilityLabel.TabIndex = 0;
            this.jediProbabilityLabel.Text = "Jedi Probability";
            // 
            // jediProbability
            // 
            this.jediProbability.Location = new System.Drawing.Point(136, 351);
            this.jediProbability.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediProbability.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.jediProbability.Name = "jediProbability";
            this.jediProbability.Size = new System.Drawing.Size(59, 23);
            this.jediProbability.TabIndex = 23;
            this.jediProbability.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediProbability.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.jediProbability.ValueChanged += new System.EventHandler(this.jediProbability_ValueChanged);
            // 
            // jediLevelBase
            // 
            this.jediLevelBase.Location = new System.Drawing.Point(136, 377);
            this.jediLevelBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediLevelBase.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.jediLevelBase.Name = "jediLevelBase";
            this.jediLevelBase.Size = new System.Drawing.Size(59, 23);
            this.jediLevelBase.TabIndex = 24;
            this.jediLevelBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediLevelBase.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.jediLevelBase.ValueChanged += new System.EventHandler(this.jediLevelBase_ValueChanged);
            // 
            // jediLevelLabel
            // 
            this.jediLevelLabel.AutoSize = true;
            this.jediLevelLabel.Location = new System.Drawing.Point(7, 380);
            this.jediLevelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jediLevelLabel.Name = "jediLevelLabel";
            this.jediLevelLabel.Size = new System.Drawing.Size(57, 15);
            this.jediLevelLabel.TabIndex = 0;
            this.jediLevelLabel.Text = "Jedi Level";
            // 
            // facilityDesignVariance
            // 
            this.facilityDesignVariance.Location = new System.Drawing.Point(165, 309);
            this.facilityDesignVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityDesignVariance.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.facilityDesignVariance.Name = "facilityDesignVariance";
            this.facilityDesignVariance.Size = new System.Drawing.Size(59, 23);
            this.facilityDesignVariance.TabIndex = 9;
            this.facilityDesignVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.facilityDesignVariance.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.facilityDesignVariance.ValueChanged += new System.EventHandler(this.facilityDesignVariance_ValueChanged);
            // 
            // shipDesignVariance
            // 
            this.shipDesignVariance.Location = new System.Drawing.Point(165, 257);
            this.shipDesignVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shipDesignVariance.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.shipDesignVariance.Name = "shipDesignVariance";
            this.shipDesignVariance.Size = new System.Drawing.Size(59, 23);
            this.shipDesignVariance.TabIndex = 5;
            this.shipDesignVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shipDesignVariance.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.shipDesignVariance.ValueChanged += new System.EventHandler(this.shipDesignVariance_ValueChanged);
            // 
            // troopTrainingVariance
            // 
            this.troopTrainingVariance.Location = new System.Drawing.Point(165, 283);
            this.troopTrainingVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopTrainingVariance.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.troopTrainingVariance.Name = "troopTrainingVariance";
            this.troopTrainingVariance.Size = new System.Drawing.Size(59, 23);
            this.troopTrainingVariance.TabIndex = 7;
            this.troopTrainingVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.troopTrainingVariance.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.troopTrainingVariance.ValueChanged += new System.EventHandler(this.troopTrainingVariance_ValueChanged);
            // 
            // facilityDesignLabel
            // 
            this.facilityDesignLabel.AutoSize = true;
            this.facilityDesignLabel.Location = new System.Drawing.Point(12, 311);
            this.facilityDesignLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.facilityDesignLabel.Name = "facilityDesignLabel";
            this.facilityDesignLabel.Size = new System.Drawing.Size(83, 15);
            this.facilityDesignLabel.TabIndex = 0;
            this.facilityDesignLabel.Text = "Facility Design";
            // 
            // facilityDesignBase
            // 
            this.facilityDesignBase.Location = new System.Drawing.Point(102, 309);
            this.facilityDesignBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityDesignBase.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.facilityDesignBase.Name = "facilityDesignBase";
            this.facilityDesignBase.Size = new System.Drawing.Size(59, 23);
            this.facilityDesignBase.TabIndex = 8;
            this.facilityDesignBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.facilityDesignBase.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.facilityDesignBase.ValueChanged += new System.EventHandler(this.facilityDesignBase_ValueChanged);
            // 
            // shipDesignLabel
            // 
            this.shipDesignLabel.AutoSize = true;
            this.shipDesignLabel.Location = new System.Drawing.Point(12, 259);
            this.shipDesignLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shipDesignLabel.Name = "shipDesignLabel";
            this.shipDesignLabel.Size = new System.Drawing.Size(69, 15);
            this.shipDesignLabel.TabIndex = 0;
            this.shipDesignLabel.Text = "Ship Design";
            // 
            // shipDesignBase
            // 
            this.shipDesignBase.Location = new System.Drawing.Point(102, 257);
            this.shipDesignBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shipDesignBase.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.shipDesignBase.Name = "shipDesignBase";
            this.shipDesignBase.Size = new System.Drawing.Size(59, 23);
            this.shipDesignBase.TabIndex = 4;
            this.shipDesignBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shipDesignBase.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.shipDesignBase.ValueChanged += new System.EventHandler(this.shipDesignBase_ValueChanged);
            // 
            // troopTrainingBase
            // 
            this.troopTrainingBase.Location = new System.Drawing.Point(102, 283);
            this.troopTrainingBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopTrainingBase.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.troopTrainingBase.Name = "troopTrainingBase";
            this.troopTrainingBase.Size = new System.Drawing.Size(59, 23);
            this.troopTrainingBase.TabIndex = 6;
            this.troopTrainingBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.troopTrainingBase.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.troopTrainingBase.ValueChanged += new System.EventHandler(this.troopTrainingBase_ValueChanged);
            // 
            // troopTrainingLabel
            // 
            this.troopTrainingLabel.AutoSize = true;
            this.troopTrainingLabel.Location = new System.Drawing.Point(12, 285);
            this.troopTrainingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.troopTrainingLabel.Name = "troopTrainingLabel";
            this.troopTrainingLabel.Size = new System.Drawing.Size(82, 15);
            this.troopTrainingLabel.TabIndex = 0;
            this.troopTrainingLabel.Text = "Troop Training";
            // 
            // varianceLabel
            // 
            this.varianceLabel.AutoSize = true;
            this.varianceLabel.BackColor = System.Drawing.Color.Silver;
            this.varianceLabel.Enabled = false;
            this.varianceLabel.Location = new System.Drawing.Point(165, 135);
            this.varianceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.varianceLabel.Name = "varianceLabel";
            this.varianceLabel.Size = new System.Drawing.Size(51, 15);
            this.varianceLabel.TabIndex = 11;
            this.varianceLabel.Text = "Variance";
            // 
            // combatVariance
            // 
            this.combatVariance.Location = new System.Drawing.Point(165, 205);
            this.combatVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combatVariance.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.combatVariance.Name = "combatVariance";
            this.combatVariance.Size = new System.Drawing.Size(59, 23);
            this.combatVariance.TabIndex = 9;
            this.combatVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.combatVariance.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.combatVariance.ValueChanged += new System.EventHandler(this.combatVariance_ValueChanged);
            // 
            // diplomacyVariance
            // 
            this.diplomacyVariance.Location = new System.Drawing.Point(165, 153);
            this.diplomacyVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.diplomacyVariance.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.diplomacyVariance.Name = "diplomacyVariance";
            this.diplomacyVariance.Size = new System.Drawing.Size(59, 23);
            this.diplomacyVariance.TabIndex = 5;
            this.diplomacyVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.diplomacyVariance.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.diplomacyVariance.ValueChanged += new System.EventHandler(this.diplomacyVariance_ValueChanged);
            // 
            // espionageVariance
            // 
            this.espionageVariance.Location = new System.Drawing.Point(165, 179);
            this.espionageVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.espionageVariance.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.espionageVariance.Name = "espionageVariance";
            this.espionageVariance.Size = new System.Drawing.Size(59, 23);
            this.espionageVariance.TabIndex = 7;
            this.espionageVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.espionageVariance.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.espionageVariance.ValueChanged += new System.EventHandler(this.espionageVariance_ValueChanged);
            // 
            // encyclopediaDescription
            // 
            this.encyclopediaDescription.Location = new System.Drawing.Point(7, 338);
            this.encyclopediaDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.encyclopediaDescription.Name = "encyclopediaDescription";
            this.encyclopediaDescription.Size = new System.Drawing.Size(364, 82);
            this.encyclopediaDescription.TabIndex = 134;
            this.encyclopediaDescription.TabStop = false;
            this.encyclopediaDescription.Text = "";
            this.encyclopediaDescription.TextChanged += new System.EventHandler(this.encyclopediaDescription_TextChanged);
            // 
            // isJediTrainer
            // 
            this.isJediTrainer.AutoSize = true;
            this.isJediTrainer.Location = new System.Drawing.Point(247, 113);
            this.isJediTrainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isJediTrainer.Name = "isJediTrainer";
            this.isJediTrainer.Size = new System.Drawing.Size(84, 19);
            this.isJediTrainer.TabIndex = 22;
            this.isJediTrainer.Text = "Jedi Trainer";
            this.isJediTrainer.UseVisualStyleBackColor = true;
            this.isJediTrainer.CheckStateChanged += new System.EventHandler(this.isJediTrainer_CheckStateChanged);
            // 
            // isKnownJedi
            // 
            this.isKnownJedi.AutoSize = true;
            this.isKnownJedi.Location = new System.Drawing.Point(247, 96);
            this.isKnownJedi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isKnownJedi.Name = "isKnownJedi";
            this.isKnownJedi.Size = new System.Drawing.Size(86, 19);
            this.isKnownJedi.TabIndex = 21;
            this.isKnownJedi.Text = "Known Jedi";
            this.isKnownJedi.UseVisualStyleBackColor = true;
            this.isKnownJedi.CheckStateChanged += new System.EventHandler(this.isKnownJedi_CheckStateChanged);
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.BackColor = System.Drawing.Color.Silver;
            this.baseLabel.Enabled = false;
            this.baseLabel.Location = new System.Drawing.Point(102, 135);
            this.baseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(31, 15);
            this.baseLabel.TabIndex = 10;
            this.baseLabel.Text = "Base";
            // 
            // combatLabel
            // 
            this.combatLabel.AutoSize = true;
            this.combatLabel.Location = new System.Drawing.Point(12, 207);
            this.combatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.combatLabel.Name = "combatLabel";
            this.combatLabel.Size = new System.Drawing.Size(50, 15);
            this.combatLabel.TabIndex = 0;
            this.combatLabel.Text = "Combat";
            // 
            // combatBase
            // 
            this.combatBase.Location = new System.Drawing.Point(102, 205);
            this.combatBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combatBase.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.combatBase.Name = "combatBase";
            this.combatBase.Size = new System.Drawing.Size(59, 23);
            this.combatBase.TabIndex = 8;
            this.combatBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.combatBase.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.combatBase.ValueChanged += new System.EventHandler(this.combatBase_ValueChanged);
            // 
            // diplomacyLabel
            // 
            this.diplomacyLabel.AutoSize = true;
            this.diplomacyLabel.Location = new System.Drawing.Point(12, 155);
            this.diplomacyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diplomacyLabel.Name = "diplomacyLabel";
            this.diplomacyLabel.Size = new System.Drawing.Size(64, 15);
            this.diplomacyLabel.TabIndex = 0;
            this.diplomacyLabel.Text = "Diplomacy";
            // 
            // diplomacyBase
            // 
            this.diplomacyBase.Location = new System.Drawing.Point(102, 153);
            this.diplomacyBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.diplomacyBase.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.diplomacyBase.Name = "diplomacyBase";
            this.diplomacyBase.Size = new System.Drawing.Size(59, 23);
            this.diplomacyBase.TabIndex = 4;
            this.diplomacyBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.diplomacyBase.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.diplomacyBase.ValueChanged += new System.EventHandler(this.diplomacyBase_ValueChanged);
            // 
            // espionageBase
            // 
            this.espionageBase.Location = new System.Drawing.Point(102, 179);
            this.espionageBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.espionageBase.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.espionageBase.Name = "espionageBase";
            this.espionageBase.Size = new System.Drawing.Size(59, 23);
            this.espionageBase.TabIndex = 6;
            this.espionageBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.espionageBase.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.espionageBase.ValueChanged += new System.EventHandler(this.espionageBase_ValueChanged);
            // 
            // espionageLabel
            // 
            this.espionageLabel.AutoSize = true;
            this.espionageLabel.Location = new System.Drawing.Point(12, 181);
            this.espionageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.espionageLabel.Name = "espionageLabel";
            this.espionageLabel.Size = new System.Drawing.Size(61, 15);
            this.espionageLabel.TabIndex = 0;
            this.espionageLabel.Text = "Espionage";
            // 
            // selector
            // 
            this.selector.LargeChange = 1;
            this.selector.Location = new System.Drawing.Point(186, 6);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 53;
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(376, 45);
            this.selector.TabIndex = 1;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            // 
            // isAlliance
            // 
            this.isAlliance.AutoSize = true;
            this.isAlliance.Location = new System.Drawing.Point(247, 47);
            this.isAlliance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isAlliance.Name = "isAlliance";
            this.isAlliance.Size = new System.Drawing.Size(68, 19);
            this.isAlliance.TabIndex = 15;
            this.isAlliance.Text = "Alliance";
            this.isAlliance.UseVisualStyleBackColor = true;
            this.isAlliance.CheckStateChanged += new System.EventHandler(this.isAlliance_CheckStateChanged);
            // 
            // isEmpire
            // 
            this.isEmpire.AutoSize = true;
            this.isEmpire.Location = new System.Drawing.Point(247, 64);
            this.isEmpire.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isEmpire.Name = "isEmpire";
            this.isEmpire.Size = new System.Drawing.Size(63, 19);
            this.isEmpire.TabIndex = 16;
            this.isEmpire.Text = "Empire";
            this.isEmpire.UseVisualStyleBackColor = true;
            this.isEmpire.CheckStateChanged += new System.EventHandler(this.isEmpire_CheckStateChanged);
            // 
            // canBeCommander
            // 
            this.canBeCommander.AutoSize = true;
            this.canBeCommander.Location = new System.Drawing.Point(252, 301);
            this.canBeCommander.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.canBeCommander.Name = "canBeCommander";
            this.canBeCommander.Size = new System.Drawing.Size(93, 19);
            this.canBeCommander.TabIndex = 20;
            this.canBeCommander.Text = "Commander";
            this.canBeCommander.UseVisualStyleBackColor = true;
            this.canBeCommander.CheckStateChanged += new System.EventHandler(this.canBeCommander_CheckStateChanged);
            // 
            // canBeAdmiral
            // 
            this.canBeAdmiral.AutoSize = true;
            this.canBeAdmiral.Location = new System.Drawing.Point(252, 267);
            this.canBeAdmiral.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.canBeAdmiral.Name = "canBeAdmiral";
            this.canBeAdmiral.Size = new System.Drawing.Size(68, 19);
            this.canBeAdmiral.TabIndex = 18;
            this.canBeAdmiral.Text = "Admiral";
            this.canBeAdmiral.UseVisualStyleBackColor = true;
            this.canBeAdmiral.CheckStateChanged += new System.EventHandler(this.canBeAdmiral_CheckStateChanged);
            // 
            // canBeGeneral
            // 
            this.canBeGeneral.AutoSize = true;
            this.canBeGeneral.Location = new System.Drawing.Point(252, 284);
            this.canBeGeneral.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.canBeGeneral.Name = "canBeGeneral";
            this.canBeGeneral.Size = new System.Drawing.Size(66, 19);
            this.canBeGeneral.TabIndex = 19;
            this.canBeGeneral.Text = "General";
            this.canBeGeneral.UseVisualStyleBackColor = true;
            this.canBeGeneral.CheckStateChanged += new System.EventHandler(this.canBeGeneral_CheckStateChanged);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(459, 481);
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
            this.SaveAs.Location = new System.Drawing.Point(364, 481);
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
            this.Cancel.Location = new System.Drawing.Point(186, 481);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 27);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(91, 481);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 7;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // minorCharactersImages
            // 
            this.minorCharactersImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.minorCharactersImages.ImageSize = new System.Drawing.Size(120, 60);
            this.minorCharactersImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // minorCharactersListView
            // 
            this.minorCharactersListView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.minorCharactersListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minorCharactersListView.GridLines = true;
            this.minorCharactersListView.LargeImageList = this.minorCharactersImages;
            this.minorCharactersListView.Location = new System.Drawing.Point(0, 0);
            this.minorCharactersListView.Margin = new System.Windows.Forms.Padding(0);
            this.minorCharactersListView.MultiSelect = false;
            this.minorCharactersListView.Name = "minorCharactersListView";
            this.minorCharactersListView.ShowGroups = false;
            this.minorCharactersListView.Size = new System.Drawing.Size(179, 476);
            this.minorCharactersListView.TabIndex = 0;
            this.minorCharactersListView.TabStop = false;
            this.minorCharactersListView.UseCompatibleStateImageBehavior = false;
            this.minorCharactersListView.Click += new System.EventHandler(this.minorCharactersListView_Click);
            this.minorCharactersListView.DoubleClick += new System.EventHandler(this.minorCharactersListView_DoubleClick);
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(7, 22);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(220, 110);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 134;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // gameDataGroupBox
            // 
            this.gameDataGroupBox.Controls.Add(this.encyclopediaDescriptionLabel);
            this.gameDataGroupBox.Controls.Add(this.baseJediModsLabel);
            this.gameDataGroupBox.Controls.Add(this.canBeCommander);
            this.gameDataGroupBox.Controls.Add(this.encyclopediaDescription);
            this.gameDataGroupBox.Controls.Add(this.leadershipVariance);
            this.gameDataGroupBox.Controls.Add(this.canBeAdmiral);
            this.gameDataGroupBox.Controls.Add(this.jediEspionageBase);
            this.gameDataGroupBox.Controls.Add(this.canBeGeneral);
            this.gameDataGroupBox.Controls.Add(this.jediLeadershipBase);
            this.gameDataGroupBox.Controls.Add(this.jediDiplomacyBase);
            this.gameDataGroupBox.Controls.Add(this.leadershipBase);
            this.gameDataGroupBox.Controls.Add(this.jediCombatBase);
            this.gameDataGroupBox.Controls.Add(this.facilityDesignVariance);
            this.gameDataGroupBox.Controls.Add(this.leadershipLabel);
            this.gameDataGroupBox.Controls.Add(this.isJediTrainer);
            this.gameDataGroupBox.Controls.Add(this.shipDesignVariance);
            this.gameDataGroupBox.Controls.Add(this.varianceLabel);
            this.gameDataGroupBox.Controls.Add(this.troopTrainingVariance);
            this.gameDataGroupBox.Controls.Add(this.name);
            this.gameDataGroupBox.Controls.Add(this.combatVariance);
            this.gameDataGroupBox.Controls.Add(this.facilityDesignLabel);
            this.gameDataGroupBox.Controls.Add(this.isKnownJedi);
            this.gameDataGroupBox.Controls.Add(this.diplomacyVariance);
            this.gameDataGroupBox.Controls.Add(this.facilityDesignBase);
            this.gameDataGroupBox.Controls.Add(this.isAlliance);
            this.gameDataGroupBox.Controls.Add(this.espionageVariance);
            this.gameDataGroupBox.Controls.Add(this.shipDesignLabel);
            this.gameDataGroupBox.Controls.Add(this.baseLabel);
            this.gameDataGroupBox.Controls.Add(this.shipDesignBase);
            this.gameDataGroupBox.Controls.Add(this.isEmpire);
            this.gameDataGroupBox.Controls.Add(this.picture);
            this.gameDataGroupBox.Controls.Add(this.troopTrainingBase);
            this.gameDataGroupBox.Controls.Add(this.diplomacyBase);
            this.gameDataGroupBox.Controls.Add(this.espionageLabel);
            this.gameDataGroupBox.Controls.Add(this.troopTrainingLabel);
            this.gameDataGroupBox.Controls.Add(this.combatLabel);
            this.gameDataGroupBox.Controls.Add(this.espionageBase);
            this.gameDataGroupBox.Controls.Add(this.combatBase);
            this.gameDataGroupBox.Controls.Add(this.diplomacyLabel);
            this.gameDataGroupBox.Location = new System.Drawing.Point(186, 43);
            this.gameDataGroupBox.Name = "gameDataGroupBox";
            this.gameDataGroupBox.Size = new System.Drawing.Size(376, 427);
            this.gameDataGroupBox.TabIndex = 135;
            this.gameDataGroupBox.TabStop = false;
            this.gameDataGroupBox.Text = "In Game Data";
            // 
            // encyclopediaDescriptionLabel
            // 
            this.encyclopediaDescriptionLabel.AutoSize = true;
            this.encyclopediaDescriptionLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.encyclopediaDescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.encyclopediaDescriptionLabel.Location = new System.Drawing.Point(227, 324);
            this.encyclopediaDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encyclopediaDescriptionLabel.Name = "encyclopediaDescriptionLabel";
            this.encyclopediaDescriptionLabel.Size = new System.Drawing.Size(140, 15);
            this.encyclopediaDescriptionLabel.TabIndex = 1127;
            this.encyclopediaDescriptionLabel.Text = "Encyclopedia Description";
            // 
            // baseJediModsLabel
            // 
            this.baseJediModsLabel.AutoSize = true;
            this.baseJediModsLabel.BackColor = System.Drawing.Color.Silver;
            this.baseJediModsLabel.Enabled = false;
            this.baseJediModsLabel.Location = new System.Drawing.Point(232, 135);
            this.baseJediModsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baseJediModsLabel.Name = "baseJediModsLabel";
            this.baseJediModsLabel.Size = new System.Drawing.Size(98, 15);
            this.baseJediModsLabel.TabIndex = 139;
            this.baseJediModsLabel.Text = "Base + Jedi mods";
            // 
            // leadershipVariance
            // 
            this.leadershipVariance.Location = new System.Drawing.Point(165, 231);
            this.leadershipVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.leadershipVariance.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.leadershipVariance.Name = "leadershipVariance";
            this.leadershipVariance.Size = new System.Drawing.Size(59, 23);
            this.leadershipVariance.TabIndex = 138;
            this.leadershipVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.leadershipVariance.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.leadershipVariance.ValueChanged += new System.EventHandler(this.leadershipVariance_ValueChanged);
            // 
            // leadershipBase
            // 
            this.leadershipBase.Location = new System.Drawing.Point(102, 231);
            this.leadershipBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.leadershipBase.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.leadershipBase.Name = "leadershipBase";
            this.leadershipBase.Size = new System.Drawing.Size(59, 23);
            this.leadershipBase.TabIndex = 137;
            this.leadershipBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.leadershipBase.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.leadershipBase.ValueChanged += new System.EventHandler(this.leadershipBase_ValueChanged);
            // 
            // leadershipLabel
            // 
            this.leadershipLabel.AutoSize = true;
            this.leadershipLabel.Location = new System.Drawing.Point(12, 233);
            this.leadershipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leadershipLabel.Name = "leadershipLabel";
            this.leadershipLabel.Size = new System.Drawing.Size(64, 15);
            this.leadershipLabel.TabIndex = 136;
            this.leadershipLabel.Text = "Leadership";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(234, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(137, 23);
            this.name.TabIndex = 135;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // MinorCharactersForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(834, 512);
            this.Controls.Add(this.hiddenDataGroupBox);
            this.Controls.Add(this.gameDataGroupBox);
            this.Controls.Add(this.minorCharactersListView);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.selector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 551);
            this.MinimumSize = new System.Drawing.Size(850, 551);
            this.Name = "MinorCharactersForm";
            this.Text = "Minor Characters (MNCHARSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.Enter += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.jediEspionageBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediDiplomacyBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediCombatBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediLeadershipBase)).EndInit();
            this.hiddenDataGroupBox.ResumeLayout(false);
            this.hiddenDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyaltyBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyaltyVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refinedMaterialCost_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFamily_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediLevelVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFamily_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediLevelBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityDesignVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipDesignVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopTrainingVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityDesignBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipDesignBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopTrainingBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomacyVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espionageVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomacyBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espionageBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.gameDataGroupBox.ResumeLayout(false);
            this.gameDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leadershipVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadershipBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gameDataGroupBox;
        private TextBox name;
        private NumericUpDown leadershipVariance;
        private NumericUpDown leadershipBase;
        private Label leadershipLabel;
        private NumericUpDown field7_2;
        private Label field7_2Label;
        private NumericUpDown researchDifficulty_0;
        private Label researchDifficulty_0Label;
        private NumericUpDown researchOrder_0;
        private Label researchOrder_0Label;
        private NumericUpDown maintenanceCost;
        private Label maintenanceCostLabel;
        private NumericUpDown refinedMaterialCost_0;
        private Label refinedMaterialCost_0Label;
        private Label baseJediModsLabel;
        private Label encyclopediaDescriptionLabel;
    }
}