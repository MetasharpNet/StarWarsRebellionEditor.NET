using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class SpecialForcesForm
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
        private NumericUpDown facilityDesignVariance_0;
        private NumericUpDown shipDesignVariance_0;
        private NumericUpDown troopTrainingVariance_0;
        private Label facilityDesign_0Label;
        private NumericUpDown facilityDesignBase_0;
        private Label shipDesign_0Label;
        private NumericUpDown shipDesignBase_0;
        private NumericUpDown troopTrainingBase_0;
        private Label troopTraining_0Label;
        private NumericUpDown loyaltyVariance;
        private NumericUpDown loyaltyBase;
        private Label loyaltyLabel;
        private Label varianceLabel;
        private Label baseLabel;
        private GroupBox hiddenDataGroupBox;
        private Label hiddenVarianceLabel;
        private Label hiddenBaseLabel;
        private RichTextBox encyclopediaDescription;
        private PictureBox picture;
        private ImageList specialForcesImages;
        private ListView specialForcesListView;
        private NumericUpDown field2_1;
        private NumericUpDown textStraDllId;
        private NumericUpDown productionFamily;
        private Label field2_1Label;
        private NumericUpDown familyId;
        private Label productionFamilyLabel;
        private Label textStraDllIdLabel;
        private Label familyIdLabel;
        private Label nextProductionFacilityLabel;
        private NumericUpDown nextProductionFamily;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialForcesForm));
            this.hiddenDataGroupBox = new System.Windows.Forms.GroupBox();
            this.missionId = new System.Windows.Forms.NumericUpDown();
            this.missionIdLabel = new System.Windows.Forms.Label();
            this.researchDifficulty = new System.Windows.Forms.NumericUpDown();
            this.loyaltyBase = new System.Windows.Forms.NumericUpDown();
            this.facilityDesignVariance_0 = new System.Windows.Forms.NumericUpDown();
            this.researchDifficulty_0Label = new System.Windows.Forms.Label();
            this.researchOrder_0 = new System.Windows.Forms.NumericUpDown();
            this.loyaltyVariance = new System.Windows.Forms.NumericUpDown();
            this.shipDesignVariance_0 = new System.Windows.Forms.NumericUpDown();
            this.researchOrder_0Label = new System.Windows.Forms.Label();
            this.loyaltyLabel = new System.Windows.Forms.Label();
            this.field7_2 = new System.Windows.Forms.NumericUpDown();
            this.troopTrainingVariance_0 = new System.Windows.Forms.NumericUpDown();
            this.field7_2Label = new System.Windows.Forms.Label();
            this.facilityDesign_0Label = new System.Windows.Forms.Label();
            this.textStraDllId = new System.Windows.Forms.NumericUpDown();
            this.facilityDesignBase_0 = new System.Windows.Forms.NumericUpDown();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.troopTraining_0Label = new System.Windows.Forms.Label();
            this.textStraDllIdLabel = new System.Windows.Forms.Label();
            this.shipDesign_0Label = new System.Windows.Forms.Label();
            this.troopTrainingBase_0 = new System.Windows.Forms.NumericUpDown();
            this.hiddenVarianceLabel = new System.Windows.Forms.Label();
            this.shipDesignBase_0 = new System.Windows.Forms.NumericUpDown();
            this.field2_1 = new System.Windows.Forms.NumericUpDown();
            this.familyId = new System.Windows.Forms.NumericUpDown();
            this.productionFamily = new System.Windows.Forms.NumericUpDown();
            this.idHexLabel = new System.Windows.Forms.Label();
            this.familyIdLabel = new System.Windows.Forms.Label();
            this.hiddenBaseLabel = new System.Windows.Forms.Label();
            this.productionFamilyLabel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.NumericUpDown();
            this.field2_1Label = new System.Windows.Forms.Label();
            this.nextProductionFacilityLabel = new System.Windows.Forms.Label();
            this.nextProductionFamily = new System.Windows.Forms.NumericUpDown();
            this.idLabel = new System.Windows.Forms.Label();
            this.maintenanceCost = new System.Windows.Forms.NumericUpDown();
            this.maintenanceCostLabel = new System.Windows.Forms.Label();
            this.refinedMaterialCost = new System.Windows.Forms.NumericUpDown();
            this.refinedMaterialCostLabel = new System.Windows.Forms.Label();
            this.varianceLabel = new System.Windows.Forms.Label();
            this.combatVariance = new System.Windows.Forms.NumericUpDown();
            this.diplomacyVariance = new System.Windows.Forms.NumericUpDown();
            this.espionageVariance = new System.Windows.Forms.NumericUpDown();
            this.encyclopediaDescription = new System.Windows.Forms.RichTextBox();
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
            this.Open = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.specialForcesImages = new System.Windows.Forms.ImageList(this.components);
            this.specialForcesListView = new System.Windows.Forms.ListView();
            this.picture = new System.Windows.Forms.PictureBox();
            this.gameDataGroupBox = new System.Windows.Forms.GroupBox();
            this.encyclopediaDescriptionLabel = new System.Windows.Forms.Label();
            this.leadershipVariance = new System.Windows.Forms.NumericUpDown();
            this.name = new System.Windows.Forms.TextBox();
            this.leadershipBase = new System.Windows.Forms.NumericUpDown();
            this.leadershipLabel = new System.Windows.Forms.Label();
            this.hiddenDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.missionId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyaltyBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityDesignVariance_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyaltyVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipDesignVariance_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopTrainingVariance_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityDesignBase_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopTrainingBase_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipDesignBase_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refinedMaterialCost)).BeginInit();
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
            // hiddenDataGroupBox
            // 
            this.hiddenDataGroupBox.Controls.Add(this.missionId);
            this.hiddenDataGroupBox.Controls.Add(this.missionIdLabel);
            this.hiddenDataGroupBox.Controls.Add(this.researchDifficulty);
            this.hiddenDataGroupBox.Controls.Add(this.loyaltyBase);
            this.hiddenDataGroupBox.Controls.Add(this.facilityDesignVariance_0);
            this.hiddenDataGroupBox.Controls.Add(this.researchDifficulty_0Label);
            this.hiddenDataGroupBox.Controls.Add(this.researchOrder_0);
            this.hiddenDataGroupBox.Controls.Add(this.loyaltyVariance);
            this.hiddenDataGroupBox.Controls.Add(this.shipDesignVariance_0);
            this.hiddenDataGroupBox.Controls.Add(this.researchOrder_0Label);
            this.hiddenDataGroupBox.Controls.Add(this.loyaltyLabel);
            this.hiddenDataGroupBox.Controls.Add(this.field7_2);
            this.hiddenDataGroupBox.Controls.Add(this.troopTrainingVariance_0);
            this.hiddenDataGroupBox.Controls.Add(this.field7_2Label);
            this.hiddenDataGroupBox.Controls.Add(this.facilityDesign_0Label);
            this.hiddenDataGroupBox.Controls.Add(this.textStraDllId);
            this.hiddenDataGroupBox.Controls.Add(this.facilityDesignBase_0);
            this.hiddenDataGroupBox.Controls.Add(this.familyIdHexLabel);
            this.hiddenDataGroupBox.Controls.Add(this.troopTraining_0Label);
            this.hiddenDataGroupBox.Controls.Add(this.textStraDllIdLabel);
            this.hiddenDataGroupBox.Controls.Add(this.shipDesign_0Label);
            this.hiddenDataGroupBox.Controls.Add(this.troopTrainingBase_0);
            this.hiddenDataGroupBox.Controls.Add(this.hiddenVarianceLabel);
            this.hiddenDataGroupBox.Controls.Add(this.shipDesignBase_0);
            this.hiddenDataGroupBox.Controls.Add(this.field2_1);
            this.hiddenDataGroupBox.Controls.Add(this.familyId);
            this.hiddenDataGroupBox.Controls.Add(this.productionFamily);
            this.hiddenDataGroupBox.Controls.Add(this.idHexLabel);
            this.hiddenDataGroupBox.Controls.Add(this.familyIdLabel);
            this.hiddenDataGroupBox.Controls.Add(this.hiddenBaseLabel);
            this.hiddenDataGroupBox.Controls.Add(this.productionFamilyLabel);
            this.hiddenDataGroupBox.Controls.Add(this.id);
            this.hiddenDataGroupBox.Controls.Add(this.field2_1Label);
            this.hiddenDataGroupBox.Controls.Add(this.nextProductionFacilityLabel);
            this.hiddenDataGroupBox.Controls.Add(this.nextProductionFamily);
            this.hiddenDataGroupBox.Controls.Add(this.idLabel);
            this.hiddenDataGroupBox.Location = new System.Drawing.Point(566, 6);
            this.hiddenDataGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hiddenDataGroupBox.Name = "hiddenDataGroupBox";
            this.hiddenDataGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hiddenDataGroupBox.Size = new System.Drawing.Size(264, 464);
            this.hiddenDataGroupBox.TabIndex = 6;
            this.hiddenDataGroupBox.TabStop = false;
            this.hiddenDataGroupBox.Text = "Hidden Data";
            // 
            // missionId
            // 
            this.missionId.BackColor = System.Drawing.SystemColors.Window;
            this.missionId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.missionId.Location = new System.Drawing.Point(136, 377);
            this.missionId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.missionId.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.missionId.Name = "missionId";
            this.missionId.Size = new System.Drawing.Size(59, 23);
            this.missionId.TabIndex = 1139;
            this.missionId.TabStop = false;
            this.missionId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.missionId.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.missionId.ValueChanged += new System.EventHandler(this.missionId_ValueChanged);
            // 
            // missionIdLabel
            // 
            this.missionIdLabel.AutoSize = true;
            this.missionIdLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.missionIdLabel.Location = new System.Drawing.Point(6, 379);
            this.missionIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.missionIdLabel.Name = "missionIdLabel";
            this.missionIdLabel.Size = new System.Drawing.Size(61, 15);
            this.missionIdLabel.TabIndex = 1138;
            this.missionIdLabel.Text = "Mission Id";
            // 
            // researchDifficulty
            // 
            this.researchDifficulty.BackColor = System.Drawing.SystemColors.Window;
            this.researchDifficulty.ForeColor = System.Drawing.SystemColors.WindowText;
            this.researchDifficulty.Location = new System.Drawing.Point(136, 227);
            this.researchDifficulty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchDifficulty.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.researchDifficulty.Name = "researchDifficulty";
            this.researchDifficulty.Size = new System.Drawing.Size(59, 23);
            this.researchDifficulty.TabIndex = 1137;
            this.researchDifficulty.TabStop = false;
            this.researchDifficulty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.researchDifficulty.ValueChanged += new System.EventHandler(this.researchDifficulty_0_ValueChanged);
            // 
            // loyaltyBase
            // 
            this.loyaltyBase.Location = new System.Drawing.Point(136, 351);
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
            // facilityDesignVariance_0
            // 
            this.facilityDesignVariance_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.facilityDesignVariance_0.Location = new System.Drawing.Point(199, 325);
            this.facilityDesignVariance_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityDesignVariance_0.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.facilityDesignVariance_0.Name = "facilityDesignVariance_0";
            this.facilityDesignVariance_0.Size = new System.Drawing.Size(59, 23);
            this.facilityDesignVariance_0.TabIndex = 9;
            this.facilityDesignVariance_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.facilityDesignVariance_0.ValueChanged += new System.EventHandler(this.facilityDesignVariance_0_ValueChanged);
            // 
            // researchDifficulty_0Label
            // 
            this.researchDifficulty_0Label.AutoSize = true;
            this.researchDifficulty_0Label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.researchDifficulty_0Label.Location = new System.Drawing.Point(7, 229);
            this.researchDifficulty_0Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.researchDifficulty_0Label.Name = "researchDifficulty_0Label";
            this.researchDifficulty_0Label.Size = new System.Drawing.Size(105, 15);
            this.researchDifficulty_0Label.TabIndex = 1136;
            this.researchDifficulty_0Label.Text = "Research Difficulty";
            // 
            // researchOrder_0
            // 
            this.researchOrder_0.BackColor = System.Drawing.SystemColors.Window;
            this.researchOrder_0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.researchOrder_0.Location = new System.Drawing.Point(136, 201);
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
            this.loyaltyVariance.Location = new System.Drawing.Point(199, 351);
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
            // shipDesignVariance_0
            // 
            this.shipDesignVariance_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.shipDesignVariance_0.Location = new System.Drawing.Point(199, 273);
            this.shipDesignVariance_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shipDesignVariance_0.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.shipDesignVariance_0.Name = "shipDesignVariance_0";
            this.shipDesignVariance_0.Size = new System.Drawing.Size(59, 23);
            this.shipDesignVariance_0.TabIndex = 5;
            this.shipDesignVariance_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shipDesignVariance_0.ValueChanged += new System.EventHandler(this.shipDesignVariance_0_ValueChanged);
            // 
            // researchOrder_0Label
            // 
            this.researchOrder_0Label.AutoSize = true;
            this.researchOrder_0Label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.researchOrder_0Label.Location = new System.Drawing.Point(7, 203);
            this.researchOrder_0Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.researchOrder_0Label.Name = "researchOrder_0Label";
            this.researchOrder_0Label.Size = new System.Drawing.Size(87, 15);
            this.researchOrder_0Label.TabIndex = 1134;
            this.researchOrder_0Label.Text = "Research Order";
            // 
            // loyaltyLabel
            // 
            this.loyaltyLabel.AutoSize = true;
            this.loyaltyLabel.Location = new System.Drawing.Point(6, 353);
            this.loyaltyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loyaltyLabel.Name = "loyaltyLabel";
            this.loyaltyLabel.Size = new System.Drawing.Size(45, 15);
            this.loyaltyLabel.TabIndex = 12;
            this.loyaltyLabel.Text = "Loyalty";
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
            // troopTrainingVariance_0
            // 
            this.troopTrainingVariance_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.troopTrainingVariance_0.Location = new System.Drawing.Point(199, 299);
            this.troopTrainingVariance_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopTrainingVariance_0.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.troopTrainingVariance_0.Name = "troopTrainingVariance_0";
            this.troopTrainingVariance_0.Size = new System.Drawing.Size(59, 23);
            this.troopTrainingVariance_0.TabIndex = 7;
            this.troopTrainingVariance_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.troopTrainingVariance_0.ValueChanged += new System.EventHandler(this.troopTrainingVariance_0_ValueChanged);
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
            // facilityDesign_0Label
            // 
            this.facilityDesign_0Label.AutoSize = true;
            this.facilityDesign_0Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.facilityDesign_0Label.Location = new System.Drawing.Point(7, 327);
            this.facilityDesign_0Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.facilityDesign_0Label.Name = "facilityDesign_0Label";
            this.facilityDesign_0Label.Size = new System.Drawing.Size(83, 15);
            this.facilityDesign_0Label.TabIndex = 0;
            this.facilityDesign_0Label.Text = "Facility Design";
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
            // facilityDesignBase_0
            // 
            this.facilityDesignBase_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.facilityDesignBase_0.Location = new System.Drawing.Point(136, 325);
            this.facilityDesignBase_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityDesignBase_0.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.facilityDesignBase_0.Name = "facilityDesignBase_0";
            this.facilityDesignBase_0.Size = new System.Drawing.Size(59, 23);
            this.facilityDesignBase_0.TabIndex = 8;
            this.facilityDesignBase_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.facilityDesignBase_0.ValueChanged += new System.EventHandler(this.facilityDesignBase_0_ValueChanged);
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
            // troopTraining_0Label
            // 
            this.troopTraining_0Label.AutoSize = true;
            this.troopTraining_0Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.troopTraining_0Label.Location = new System.Drawing.Point(7, 301);
            this.troopTraining_0Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.troopTraining_0Label.Name = "troopTraining_0Label";
            this.troopTraining_0Label.Size = new System.Drawing.Size(82, 15);
            this.troopTraining_0Label.TabIndex = 0;
            this.troopTraining_0Label.Text = "Troop Training";
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
            // shipDesign_0Label
            // 
            this.shipDesign_0Label.AutoSize = true;
            this.shipDesign_0Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.shipDesign_0Label.Location = new System.Drawing.Point(7, 275);
            this.shipDesign_0Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shipDesign_0Label.Name = "shipDesign_0Label";
            this.shipDesign_0Label.Size = new System.Drawing.Size(69, 15);
            this.shipDesign_0Label.TabIndex = 0;
            this.shipDesign_0Label.Text = "Ship Design";
            // 
            // troopTrainingBase_0
            // 
            this.troopTrainingBase_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.troopTrainingBase_0.Location = new System.Drawing.Point(136, 299);
            this.troopTrainingBase_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopTrainingBase_0.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.troopTrainingBase_0.Name = "troopTrainingBase_0";
            this.troopTrainingBase_0.Size = new System.Drawing.Size(59, 23);
            this.troopTrainingBase_0.TabIndex = 6;
            this.troopTrainingBase_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.troopTrainingBase_0.ValueChanged += new System.EventHandler(this.troopTrainingBase_0_ValueChanged);
            // 
            // hiddenVarianceLabel
            // 
            this.hiddenVarianceLabel.AutoSize = true;
            this.hiddenVarianceLabel.BackColor = System.Drawing.Color.Silver;
            this.hiddenVarianceLabel.Location = new System.Drawing.Point(199, 255);
            this.hiddenVarianceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hiddenVarianceLabel.Name = "hiddenVarianceLabel";
            this.hiddenVarianceLabel.Size = new System.Drawing.Size(51, 15);
            this.hiddenVarianceLabel.TabIndex = 11;
            this.hiddenVarianceLabel.Text = "Variance";
            // 
            // shipDesignBase_0
            // 
            this.shipDesignBase_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.shipDesignBase_0.Location = new System.Drawing.Point(136, 273);
            this.shipDesignBase_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shipDesignBase_0.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.shipDesignBase_0.Name = "shipDesignBase_0";
            this.shipDesignBase_0.Size = new System.Drawing.Size(59, 23);
            this.shipDesignBase_0.TabIndex = 4;
            this.shipDesignBase_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shipDesignBase_0.ValueChanged += new System.EventHandler(this.shipDesignBase_0_ValueChanged);
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
            -1,
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
            // productionFamily
            // 
            this.productionFamily.BackColor = System.Drawing.SystemColors.Window;
            this.productionFamily.ForeColor = System.Drawing.SystemColors.WindowText;
            this.productionFamily.Location = new System.Drawing.Point(136, 71);
            this.productionFamily.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productionFamily.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.productionFamily.Name = "productionFamily";
            this.productionFamily.Size = new System.Drawing.Size(59, 23);
            this.productionFamily.TabIndex = 138;
            this.productionFamily.TabStop = false;
            this.productionFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.productionFamily.ValueChanged += new System.EventHandler(this.productionFamily_ValueChanged);
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
            this.hiddenBaseLabel.Location = new System.Drawing.Point(136, 255);
            this.hiddenBaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hiddenBaseLabel.Name = "hiddenBaseLabel";
            this.hiddenBaseLabel.Size = new System.Drawing.Size(31, 15);
            this.hiddenBaseLabel.TabIndex = 10;
            this.hiddenBaseLabel.Text = "Base";
            // 
            // productionFamilyLabel
            // 
            this.productionFamilyLabel.AutoSize = true;
            this.productionFamilyLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.productionFamilyLabel.Location = new System.Drawing.Point(6, 73);
            this.productionFamilyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productionFamilyLabel.Name = "productionFamilyLabel";
            this.productionFamilyLabel.Size = new System.Drawing.Size(104, 15);
            this.productionFamilyLabel.TabIndex = 140;
            this.productionFamilyLabel.Text = "Production Family";
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
            // nextProductionFacilityLabel
            // 
            this.nextProductionFacilityLabel.AutoSize = true;
            this.nextProductionFacilityLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nextProductionFacilityLabel.Location = new System.Drawing.Point(7, 99);
            this.nextProductionFacilityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nextProductionFacilityLabel.Name = "nextProductionFacilityLabel";
            this.nextProductionFacilityLabel.Size = new System.Drawing.Size(121, 15);
            this.nextProductionFacilityLabel.TabIndex = 142;
            this.nextProductionFacilityLabel.Text = "Production Family +1";
            // 
            // nextProductionFamily
            // 
            this.nextProductionFamily.BackColor = System.Drawing.SystemColors.Window;
            this.nextProductionFamily.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nextProductionFamily.Location = new System.Drawing.Point(136, 97);
            this.nextProductionFamily.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextProductionFamily.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nextProductionFamily.Name = "nextProductionFamily";
            this.nextProductionFamily.Size = new System.Drawing.Size(59, 23);
            this.nextProductionFamily.TabIndex = 141;
            this.nextProductionFamily.TabStop = false;
            this.nextProductionFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nextProductionFamily.ValueChanged += new System.EventHandler(this.nextProductionFamily_ValueChanged);
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
            // maintenanceCost
            // 
            this.maintenanceCost.BackColor = System.Drawing.SystemColors.Window;
            this.maintenanceCost.ForeColor = System.Drawing.SystemColors.WindowText;
            this.maintenanceCost.Location = new System.Drawing.Point(148, 164);
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
            // maintenanceCostLabel
            // 
            this.maintenanceCostLabel.AutoSize = true;
            this.maintenanceCostLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.maintenanceCostLabel.Location = new System.Drawing.Point(19, 166);
            this.maintenanceCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maintenanceCostLabel.Name = "maintenanceCostLabel";
            this.maintenanceCostLabel.Size = new System.Drawing.Size(103, 15);
            this.maintenanceCostLabel.TabIndex = 1132;
            this.maintenanceCostLabel.Text = "Maintenance Cost";
            // 
            // refinedMaterialCost
            // 
            this.refinedMaterialCost.BackColor = System.Drawing.SystemColors.Window;
            this.refinedMaterialCost.ForeColor = System.Drawing.SystemColors.WindowText;
            this.refinedMaterialCost.Location = new System.Drawing.Point(148, 138);
            this.refinedMaterialCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.refinedMaterialCost.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.refinedMaterialCost.Name = "refinedMaterialCost";
            this.refinedMaterialCost.Size = new System.Drawing.Size(59, 23);
            this.refinedMaterialCost.TabIndex = 1131;
            this.refinedMaterialCost.TabStop = false;
            this.refinedMaterialCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.refinedMaterialCost.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.refinedMaterialCost.ValueChanged += new System.EventHandler(this.refinedMaterialCost_ValueChanged);
            // 
            // refinedMaterialCostLabel
            // 
            this.refinedMaterialCostLabel.AutoSize = true;
            this.refinedMaterialCostLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.refinedMaterialCostLabel.Location = new System.Drawing.Point(18, 140);
            this.refinedMaterialCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.refinedMaterialCostLabel.Name = "refinedMaterialCostLabel";
            this.refinedMaterialCostLabel.Size = new System.Drawing.Size(120, 15);
            this.refinedMaterialCostLabel.TabIndex = 1130;
            this.refinedMaterialCostLabel.Text = "Refined Material Cost";
            // 
            // varianceLabel
            // 
            this.varianceLabel.AutoSize = true;
            this.varianceLabel.BackColor = System.Drawing.Color.Silver;
            this.varianceLabel.Enabled = false;
            this.varianceLabel.Location = new System.Drawing.Point(211, 192);
            this.varianceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.varianceLabel.Name = "varianceLabel";
            this.varianceLabel.Size = new System.Drawing.Size(51, 15);
            this.varianceLabel.TabIndex = 11;
            this.varianceLabel.Text = "Variance";
            // 
            // combatVariance
            // 
            this.combatVariance.Location = new System.Drawing.Point(211, 262);
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
            this.diplomacyVariance.Location = new System.Drawing.Point(211, 210);
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
            this.espionageVariance.Location = new System.Drawing.Point(211, 236);
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
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.BackColor = System.Drawing.Color.Silver;
            this.baseLabel.Enabled = false;
            this.baseLabel.Location = new System.Drawing.Point(148, 192);
            this.baseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(31, 15);
            this.baseLabel.TabIndex = 10;
            this.baseLabel.Text = "Base";
            // 
            // combatLabel
            // 
            this.combatLabel.AutoSize = true;
            this.combatLabel.Location = new System.Drawing.Point(18, 264);
            this.combatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.combatLabel.Name = "combatLabel";
            this.combatLabel.Size = new System.Drawing.Size(50, 15);
            this.combatLabel.TabIndex = 0;
            this.combatLabel.Text = "Combat";
            // 
            // combatBase
            // 
            this.combatBase.Location = new System.Drawing.Point(148, 262);
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
            this.diplomacyLabel.Location = new System.Drawing.Point(18, 212);
            this.diplomacyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diplomacyLabel.Name = "diplomacyLabel";
            this.diplomacyLabel.Size = new System.Drawing.Size(64, 15);
            this.diplomacyLabel.TabIndex = 0;
            this.diplomacyLabel.Text = "Diplomacy";
            // 
            // diplomacyBase
            // 
            this.diplomacyBase.Location = new System.Drawing.Point(148, 210);
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
            this.espionageBase.Location = new System.Drawing.Point(148, 236);
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
            this.espionageLabel.Location = new System.Drawing.Point(18, 238);
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
            this.selector.Maximum = 7;
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
            // specialForcesImages
            // 
            this.specialForcesImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.specialForcesImages.ImageSize = new System.Drawing.Size(120, 60);
            this.specialForcesImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // specialForcesListView
            // 
            this.specialForcesListView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.specialForcesListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.specialForcesListView.GridLines = true;
            this.specialForcesListView.LargeImageList = this.specialForcesImages;
            this.specialForcesListView.Location = new System.Drawing.Point(0, 0);
            this.specialForcesListView.Margin = new System.Windows.Forms.Padding(0);
            this.specialForcesListView.MultiSelect = false;
            this.specialForcesListView.Name = "specialForcesListView";
            this.specialForcesListView.ShowGroups = false;
            this.specialForcesListView.Size = new System.Drawing.Size(179, 476);
            this.specialForcesListView.TabIndex = 0;
            this.specialForcesListView.TabStop = false;
            this.specialForcesListView.UseCompatibleStateImageBehavior = false;
            this.specialForcesListView.Click += new System.EventHandler(this.specialForcesListView_Click);
            this.specialForcesListView.DoubleClick += new System.EventHandler(this.specialForcesListView_DoubleClick);
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
            this.gameDataGroupBox.Controls.Add(this.encyclopediaDescription);
            this.gameDataGroupBox.Controls.Add(this.leadershipVariance);
            this.gameDataGroupBox.Controls.Add(this.name);
            this.gameDataGroupBox.Controls.Add(this.isAlliance);
            this.gameDataGroupBox.Controls.Add(this.leadershipBase);
            this.gameDataGroupBox.Controls.Add(this.isEmpire);
            this.gameDataGroupBox.Controls.Add(this.picture);
            this.gameDataGroupBox.Controls.Add(this.refinedMaterialCostLabel);
            this.gameDataGroupBox.Controls.Add(this.refinedMaterialCost);
            this.gameDataGroupBox.Controls.Add(this.leadershipLabel);
            this.gameDataGroupBox.Controls.Add(this.maintenanceCost);
            this.gameDataGroupBox.Controls.Add(this.maintenanceCostLabel);
            this.gameDataGroupBox.Controls.Add(this.baseLabel);
            this.gameDataGroupBox.Controls.Add(this.diplomacyBase);
            this.gameDataGroupBox.Controls.Add(this.varianceLabel);
            this.gameDataGroupBox.Controls.Add(this.espionageVariance);
            this.gameDataGroupBox.Controls.Add(this.espionageLabel);
            this.gameDataGroupBox.Controls.Add(this.combatLabel);
            this.gameDataGroupBox.Controls.Add(this.diplomacyVariance);
            this.gameDataGroupBox.Controls.Add(this.diplomacyLabel);
            this.gameDataGroupBox.Controls.Add(this.espionageBase);
            this.gameDataGroupBox.Controls.Add(this.combatVariance);
            this.gameDataGroupBox.Controls.Add(this.combatBase);
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
            // leadershipVariance
            // 
            this.leadershipVariance.Location = new System.Drawing.Point(211, 288);
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
            // name
            // 
            this.name.Location = new System.Drawing.Point(234, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(137, 23);
            this.name.TabIndex = 135;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // leadershipBase
            // 
            this.leadershipBase.Location = new System.Drawing.Point(148, 288);
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
            this.leadershipLabel.Location = new System.Drawing.Point(18, 290);
            this.leadershipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leadershipLabel.Name = "leadershipLabel";
            this.leadershipLabel.Size = new System.Drawing.Size(64, 15);
            this.leadershipLabel.TabIndex = 136;
            this.leadershipLabel.Text = "Leadership";
            // 
            // SpecialForcesForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(834, 512);
            this.Controls.Add(this.hiddenDataGroupBox);
            this.Controls.Add(this.gameDataGroupBox);
            this.Controls.Add(this.specialForcesListView);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.selector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 551);
            this.Name = "SpecialForcesForm";
            this.Text = "Special Forces (SPECFCSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.Enter += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);
            this.hiddenDataGroupBox.ResumeLayout(false);
            this.hiddenDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.missionId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyaltyBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityDesignVariance_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyaltyVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipDesignVariance_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopTrainingVariance_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityDesignBase_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopTrainingBase_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipDesignBase_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refinedMaterialCost)).EndInit();
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
        private NumericUpDown researchDifficulty;
        private Label researchDifficulty_0Label;
        private NumericUpDown researchOrder_0;
        private Label researchOrder_0Label;
        private NumericUpDown maintenanceCost;
        private Label maintenanceCostLabel;
        private NumericUpDown refinedMaterialCost;
        private Label refinedMaterialCostLabel;
        private Label encyclopediaDescriptionLabel;
        private NumericUpDown missionId;
        private Label missionIdLabel;
    }
}