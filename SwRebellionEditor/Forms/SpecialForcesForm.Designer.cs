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
        private ListView specialForcesListView;
        private PictureBox picture;
        private GroupBox charLoyalGroup;
        private CheckBox isAllianceUnit;
        private CheckBox isEmpireUnit;
        private Label encyclopediaName;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox researchGroup;
        private Label resVarLabel;
        private Label resBaseLabel;
        private NumericUpDown facilitiesResearchVariance;
        private NumericUpDown shipsResearchVariance;
        private NumericUpDown troopsResearchVariance;
        private Label facResLabel;
        private NumericUpDown facilitiesResearchBase;
        private Label shipResLabel;
        private NumericUpDown shipsResearchBase;
        private NumericUpDown troopsResearchBase;
        private Label troopResLabel;
        private GroupBox BasicGroup;
        private NumericUpDown loyaltyVariance;
        private NumericUpDown loyaltyBase;
        private Label loyaltyLabel;
        private Label statsVarLabel;
        private Label statsBaseLabel;
        private NumericUpDown combatVariance;
        private NumericUpDown diplomacyVariance;
        private NumericUpDown espionageVariance;
        private Label combatLabel;
        private NumericUpDown combatBase;
        private Label diploLabel;
        private NumericUpDown diplomacyBase;
        private NumericUpDown espionageBase;
        private Label espLabel;
        private TabPage tabPage2;
        private RichTextBox encyText;
        private ImageList SpecialForcesImageList;
        private GroupBox costGroup;
        private Label label1;
        private NumericUpDown constructionCost;
        private Label label2;
        private NumericUpDown maintenanceCost;
        private Label conCostLabel;
        private NumericUpDown conCostNum2;
        private Label maintCostLabel;
        private NumericUpDown maintCostNum2;
        private GroupBox researchBox;
        private Label researchLabel;
        private NumericUpDown researchOrder;
        private Label resDiffLabel;
        private NumericUpDown researchDifficulty;
        private GroupBox groupBox1;
        private NumericUpDown unknown2;
        private NumericUpDown textStraDllId;
        private NumericUpDown productionFacility;
        private Label unkown3Label;
        private NumericUpDown familyId;
        private Label prodLabel;
        private Label idLabel;
        private Label familyLabel;
        private Label secProdFacNumlabel;
        private NumericUpDown nextProductionFacility;
        private NumericUpDown missionId;
        private Label label3;
        private Label familyIdHexLabel;
        private Label specialForceIdHexLabel;
        private NumericUpDown specialForceId;
        private Label label4;

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
            this.specialForcesListView = new System.Windows.Forms.ListView();
            this.SpecialForcesImageList = new System.Windows.Forms.ImageList(this.components);
            this.Open = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.charLoyalGroup = new System.Windows.Forms.GroupBox();
            this.isAllianceUnit = new System.Windows.Forms.CheckBox();
            this.isEmpireUnit = new System.Windows.Forms.CheckBox();
            this.encyclopediaName = new System.Windows.Forms.Label();
            this.selector = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.researchBox = new System.Windows.Forms.GroupBox();
            this.researchLabel = new System.Windows.Forms.Label();
            this.researchOrder = new System.Windows.Forms.NumericUpDown();
            this.resDiffLabel = new System.Windows.Forms.Label();
            this.researchDifficulty = new System.Windows.Forms.NumericUpDown();
            this.costGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.constructionCost = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.maintenanceCost = new System.Windows.Forms.NumericUpDown();
            this.researchGroup = new System.Windows.Forms.GroupBox();
            this.resVarLabel = new System.Windows.Forms.Label();
            this.resBaseLabel = new System.Windows.Forms.Label();
            this.facilitiesResearchVariance = new System.Windows.Forms.NumericUpDown();
            this.shipsResearchVariance = new System.Windows.Forms.NumericUpDown();
            this.troopsResearchVariance = new System.Windows.Forms.NumericUpDown();
            this.facResLabel = new System.Windows.Forms.Label();
            this.facilitiesResearchBase = new System.Windows.Forms.NumericUpDown();
            this.shipResLabel = new System.Windows.Forms.Label();
            this.shipsResearchBase = new System.Windows.Forms.NumericUpDown();
            this.troopsResearchBase = new System.Windows.Forms.NumericUpDown();
            this.troopResLabel = new System.Windows.Forms.Label();
            this.BasicGroup = new System.Windows.Forms.GroupBox();
            this.loyaltyVariance = new System.Windows.Forms.NumericUpDown();
            this.loyaltyBase = new System.Windows.Forms.NumericUpDown();
            this.loyaltyLabel = new System.Windows.Forms.Label();
            this.statsVarLabel = new System.Windows.Forms.Label();
            this.statsBaseLabel = new System.Windows.Forms.Label();
            this.combatVariance = new System.Windows.Forms.NumericUpDown();
            this.diplomacyVariance = new System.Windows.Forms.NumericUpDown();
            this.espionageVariance = new System.Windows.Forms.NumericUpDown();
            this.combatLabel = new System.Windows.Forms.Label();
            this.combatBase = new System.Windows.Forms.NumericUpDown();
            this.diploLabel = new System.Windows.Forms.Label();
            this.diplomacyBase = new System.Windows.Forms.NumericUpDown();
            this.espionageBase = new System.Windows.Forms.NumericUpDown();
            this.espLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.specialForceIdHexLabel = new System.Windows.Forms.Label();
            this.specialForceId = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.missionId = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.unknown2 = new System.Windows.Forms.NumericUpDown();
            this.textStraDllId = new System.Windows.Forms.NumericUpDown();
            this.productionFacility = new System.Windows.Forms.NumericUpDown();
            this.unkown3Label = new System.Windows.Forms.Label();
            this.familyId = new System.Windows.Forms.NumericUpDown();
            this.prodLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.familyLabel = new System.Windows.Forms.Label();
            this.secProdFacNumlabel = new System.Windows.Forms.Label();
            this.nextProductionFacility = new System.Windows.Forms.NumericUpDown();
            this.encyText = new System.Windows.Forms.RichTextBox();
            this.conCostLabel = new System.Windows.Forms.Label();
            this.conCostNum2 = new System.Windows.Forms.NumericUpDown();
            this.maintCostLabel = new System.Windows.Forms.Label();
            this.maintCostNum2 = new System.Windows.Forms.NumericUpDown();
            this.picture = new System.Windows.Forms.PictureBox();
            this.charLoyalGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.researchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).BeginInit();
            this.costGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.constructionCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).BeginInit();
            this.researchGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facilitiesResearchVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipsResearchVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopsResearchVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilitiesResearchBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipsResearchBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopsResearchBase)).BeginInit();
            this.BasicGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loyaltyVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyaltyBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomacyVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espionageVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomacyBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espionageBase)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialForceId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conCostNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintCostNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // charListView
            // 
            this.specialForcesListView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.specialForcesListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.specialForcesListView.GridLines = true;
            this.specialForcesListView.LargeImageList = this.SpecialForcesImageList;
            this.specialForcesListView.Location = new System.Drawing.Point(0, 110);
            this.specialForcesListView.Margin = new System.Windows.Forms.Padding(0);
            this.specialForcesListView.MultiSelect = false;
            this.specialForcesListView.Name = "charListView";
            this.specialForcesListView.ShowGroups = false;
            this.specialForcesListView.Size = new System.Drawing.Size(220, 475);
            this.specialForcesListView.TabIndex = 148;
            this.specialForcesListView.TabStop = false;
            this.specialForcesListView.UseCompatibleStateImageBehavior = false;
            this.specialForcesListView.Click += new System.EventHandler(this.specialForcesListView_Click);
            this.specialForcesListView.DoubleClick += new System.EventHandler(this.specialForcesListView_DoubleClick);
            // 
            // SpecOpImageList
            // 
            this.SpecialForcesImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.SpecialForcesImageList.ImageSize = new System.Drawing.Size(120, 60);
            this.SpecialForcesImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openNew
            // 
            this.Open.Location = new System.Drawing.Point(663, 545);
            this.Open.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Open.Name = "openNew";
            this.Open.Size = new System.Drawing.Size(88, 27);
            this.Open.TabIndex = 146;
            this.Open.TabStop = false;
            this.Open.Text = "Open...";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Location = new System.Drawing.Point(568, 545);
            this.SaveAs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(88, 27);
            this.SaveAs.TabIndex = 147;
            this.SaveAs.TabStop = false;
            this.SaveAs.Text = "&SaveAs...";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(390, 545);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 27);
            this.Cancel.TabIndex = 154;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(295, 545);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 153;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // charLoyalGroup
            // 
            this.charLoyalGroup.Controls.Add(this.isAllianceUnit);
            this.charLoyalGroup.Controls.Add(this.isEmpireUnit);
            this.charLoyalGroup.Location = new System.Drawing.Point(398, 23);
            this.charLoyalGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.charLoyalGroup.Name = "charLoyalGroup";
            this.charLoyalGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.charLoyalGroup.Size = new System.Drawing.Size(182, 98);
            this.charLoyalGroup.TabIndex = 150;
            this.charLoyalGroup.TabStop = false;
            this.charLoyalGroup.Text = "Character Loyalty";
            // 
            // rebelUnit
            // 
            this.isAllianceUnit.AutoSize = true;
            this.isAllianceUnit.Location = new System.Drawing.Point(7, 22);
            this.isAllianceUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isAllianceUnit.Name = "rebelUnit";
            this.isAllianceUnit.Size = new System.Drawing.Size(68, 19);
            this.isAllianceUnit.TabIndex = 15;
            this.isAllianceUnit.Text = "Alliance";
            this.isAllianceUnit.UseVisualStyleBackColor = true;
            this.isAllianceUnit.CheckStateChanged += new System.EventHandler(this.isAllianceUnit_CheckStateChanged);
            // 
            // empireUnit
            // 
            this.isEmpireUnit.AutoSize = true;
            this.isEmpireUnit.Location = new System.Drawing.Point(7, 48);
            this.isEmpireUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isEmpireUnit.Name = "empireUnit";
            this.isEmpireUnit.Size = new System.Drawing.Size(69, 19);
            this.isEmpireUnit.TabIndex = 16;
            this.isEmpireUnit.Text = "Imperial";
            this.isEmpireUnit.UseVisualStyleBackColor = true;
            this.isEmpireUnit.CheckStateChanged += new System.EventHandler(this.isEmpireUnit_CheckStateChanged);
            // 
            // ItemName
            // 
            this.encyclopediaName.AutoSize = true;
            this.encyclopediaName.Location = new System.Drawing.Point(230, 78);
            this.encyclopediaName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encyclopediaName.Name = "ItemName";
            this.encyclopediaName.Size = new System.Drawing.Size(116, 15);
            this.encyclopediaName.TabIndex = 155;
            this.encyclopediaName.Text = "-- Item name here --";
            // 
            // ItemSelect
            // 
            this.selector.LargeChange = 4;
            this.selector.Location = new System.Drawing.Point(233, 23);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 8;
            this.selector.Name = "ItemSelect";
            this.selector.Size = new System.Drawing.Size(121, 45);
            this.selector.TabIndex = 149;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(233, 128);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(561, 410);
            this.tabControl1.TabIndex = 152;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.researchBox);
            this.tabPage1.Controls.Add(this.costGroup);
            this.tabPage1.Controls.Add(this.researchGroup);
            this.tabPage1.Controls.Add(this.BasicGroup);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(553, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stats";
            // 
            // researchBox
            // 
            this.researchBox.Controls.Add(this.researchLabel);
            this.researchBox.Controls.Add(this.researchOrder);
            this.researchBox.Controls.Add(this.resDiffLabel);
            this.researchBox.Controls.Add(this.researchDifficulty);
            this.researchBox.Location = new System.Drawing.Point(273, 192);
            this.researchBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchBox.Name = "researchBox";
            this.researchBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchBox.Size = new System.Drawing.Size(182, 78);
            this.researchBox.TabIndex = 6;
            this.researchBox.TabStop = false;
            this.researchBox.Text = "Research";
            // 
            // researchLabel
            // 
            this.researchLabel.AutoSize = true;
            this.researchLabel.Location = new System.Drawing.Point(7, 18);
            this.researchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.researchLabel.Name = "researchLabel";
            this.researchLabel.Size = new System.Drawing.Size(54, 15);
            this.researchLabel.TabIndex = 0;
            this.researchLabel.Text = "Research";
            // 
            // researchNum
            // 
            this.researchOrder.Location = new System.Drawing.Point(119, 16);
            this.researchOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchOrder.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.researchOrder.Name = "researchNum";
            this.researchOrder.Size = new System.Drawing.Size(50, 23);
            this.researchOrder.TabIndex = 6;
            this.researchOrder.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.researchOrder.ValueChanged += new System.EventHandler(this.researchOrder_ValueChanged);
            // 
            // resDiffLabel
            // 
            this.resDiffLabel.AutoSize = true;
            this.resDiffLabel.Location = new System.Drawing.Point(7, 43);
            this.resDiffLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resDiffLabel.Name = "resDiffLabel";
            this.resDiffLabel.Size = new System.Drawing.Size(105, 15);
            this.resDiffLabel.TabIndex = 0;
            this.resDiffLabel.Text = "Research Difficulty";
            // 
            // resDiffNum
            // 
            this.researchDifficulty.Location = new System.Drawing.Point(119, 43);
            this.researchDifficulty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchDifficulty.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.researchDifficulty.Name = "resDiffNum";
            this.researchDifficulty.Size = new System.Drawing.Size(50, 23);
            this.researchDifficulty.TabIndex = 11;
            this.researchDifficulty.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.researchDifficulty.ValueChanged += new System.EventHandler(this.researchDifficulty_ValueChanged);
            // 
            // costGroup
            // 
            this.costGroup.Controls.Add(this.label1);
            this.costGroup.Controls.Add(this.constructionCost);
            this.costGroup.Controls.Add(this.label2);
            this.costGroup.Controls.Add(this.maintenanceCost);
            this.costGroup.Location = new System.Drawing.Point(7, 185);
            this.costGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.costGroup.Name = "costGroup";
            this.costGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.costGroup.Size = new System.Drawing.Size(182, 85);
            this.costGroup.TabIndex = 6;
            this.costGroup.TabStop = false;
            this.costGroup.Text = "Costs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Construction Cost";
            // 
            // conCostNum
            // 
            this.constructionCost.Location = new System.Drawing.Point(119, 18);
            this.constructionCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.constructionCost.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.constructionCost.Name = "conCostNum";
            this.constructionCost.Size = new System.Drawing.Size(50, 23);
            this.constructionCost.TabIndex = 4;
            this.constructionCost.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.constructionCost.ValueChanged += new System.EventHandler(this.constructionCost_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Maintenance Cost";
            // 
            // maintCostNum
            // 
            this.maintenanceCost.Location = new System.Drawing.Point(119, 48);
            this.maintenanceCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maintenanceCost.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.maintenanceCost.Name = "maintCostNum";
            this.maintenanceCost.Size = new System.Drawing.Size(50, 23);
            this.maintenanceCost.TabIndex = 5;
            this.maintenanceCost.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.maintenanceCost.ValueChanged += new System.EventHandler(this.maintenanceCost_ValueChanged);
            // 
            // researchGroup
            // 
            this.researchGroup.Controls.Add(this.resVarLabel);
            this.researchGroup.Controls.Add(this.resBaseLabel);
            this.researchGroup.Controls.Add(this.facilitiesResearchVariance);
            this.researchGroup.Controls.Add(this.shipsResearchVariance);
            this.researchGroup.Controls.Add(this.troopsResearchVariance);
            this.researchGroup.Controls.Add(this.facResLabel);
            this.researchGroup.Controls.Add(this.facilitiesResearchBase);
            this.researchGroup.Controls.Add(this.shipResLabel);
            this.researchGroup.Controls.Add(this.shipsResearchBase);
            this.researchGroup.Controls.Add(this.troopsResearchBase);
            this.researchGroup.Controls.Add(this.troopResLabel);
            this.researchGroup.Location = new System.Drawing.Point(273, 7);
            this.researchGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchGroup.Name = "researchGroup";
            this.researchGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchGroup.Size = new System.Drawing.Size(262, 171);
            this.researchGroup.TabIndex = 5;
            this.researchGroup.TabStop = false;
            this.researchGroup.Text = "Research Stats";
            // 
            // resVarLabel
            // 
            this.resVarLabel.AutoSize = true;
            this.resVarLabel.BackColor = System.Drawing.Color.Silver;
            this.resVarLabel.Enabled = false;
            this.resVarLabel.Location = new System.Drawing.Point(182, 17);
            this.resVarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resVarLabel.Name = "resVarLabel";
            this.resVarLabel.Size = new System.Drawing.Size(51, 15);
            this.resVarLabel.TabIndex = 11;
            this.resVarLabel.Text = "Variance";
            // 
            // resBaseLabel
            // 
            this.resBaseLabel.AutoSize = true;
            this.resBaseLabel.BackColor = System.Drawing.Color.Silver;
            this.resBaseLabel.Enabled = false;
            this.resBaseLabel.Location = new System.Drawing.Point(115, 17);
            this.resBaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resBaseLabel.Name = "resBaseLabel";
            this.resBaseLabel.Size = new System.Drawing.Size(31, 15);
            this.resBaseLabel.TabIndex = 10;
            this.resBaseLabel.Text = "Base";
            // 
            // facResVarNum
            // 
            this.facilitiesResearchVariance.Enabled = false;
            this.facilitiesResearchVariance.Location = new System.Drawing.Point(186, 99);
            this.facilitiesResearchVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilitiesResearchVariance.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.facilitiesResearchVariance.Name = "facResVarNum";
            this.facilitiesResearchVariance.Size = new System.Drawing.Size(59, 23);
            this.facilitiesResearchVariance.TabIndex = 9;
            this.facilitiesResearchVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.facilitiesResearchVariance.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.facilitiesResearchVariance.ValueChanged += new System.EventHandler(this.facilitiesResearchVariance_ValueChanged);
            // 
            // shipResVarNum
            // 
            this.shipsResearchVariance.Enabled = false;
            this.shipsResearchVariance.Location = new System.Drawing.Point(186, 36);
            this.shipsResearchVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shipsResearchVariance.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.shipsResearchVariance.Name = "shipResVarNum";
            this.shipsResearchVariance.Size = new System.Drawing.Size(59, 23);
            this.shipsResearchVariance.TabIndex = 5;
            this.shipsResearchVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shipsResearchVariance.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.shipsResearchVariance.ValueChanged += new System.EventHandler(this.shipsResearchVariance_ValueChanged);
            // 
            // troopResVarNum
            // 
            this.troopsResearchVariance.Enabled = false;
            this.troopsResearchVariance.Location = new System.Drawing.Point(186, 69);
            this.troopsResearchVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopsResearchVariance.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.troopsResearchVariance.Name = "troopResVarNum";
            this.troopsResearchVariance.Size = new System.Drawing.Size(59, 23);
            this.troopsResearchVariance.TabIndex = 7;
            this.troopsResearchVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.troopsResearchVariance.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.troopsResearchVariance.ValueChanged += new System.EventHandler(this.troopsResearchVariance_ValueChanged);
            // 
            // facResLabel
            // 
            this.facResLabel.AutoSize = true;
            this.facResLabel.Enabled = false;
            this.facResLabel.Location = new System.Drawing.Point(7, 102);
            this.facResLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.facResLabel.Name = "facResLabel";
            this.facResLabel.Size = new System.Drawing.Size(44, 15);
            this.facResLabel.TabIndex = 0;
            this.facResLabel.Text = "Facility";
            // 
            // facResBaseNum
            // 
            this.facilitiesResearchBase.Enabled = false;
            this.facilitiesResearchBase.Location = new System.Drawing.Point(119, 99);
            this.facilitiesResearchBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilitiesResearchBase.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.facilitiesResearchBase.Name = "facResBaseNum";
            this.facilitiesResearchBase.Size = new System.Drawing.Size(59, 23);
            this.facilitiesResearchBase.TabIndex = 8;
            this.facilitiesResearchBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.facilitiesResearchBase.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.facilitiesResearchBase.ValueChanged += new System.EventHandler(this.facilitiesResearchBase_ValueChanged);
            // 
            // shipResLabel
            // 
            this.shipResLabel.AutoSize = true;
            this.shipResLabel.Enabled = false;
            this.shipResLabel.Location = new System.Drawing.Point(7, 38);
            this.shipResLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shipResLabel.Name = "shipResLabel";
            this.shipResLabel.Size = new System.Drawing.Size(30, 15);
            this.shipResLabel.TabIndex = 0;
            this.shipResLabel.Text = "Ship";
            // 
            // shipResBaseNum
            // 
            this.shipsResearchBase.Enabled = false;
            this.shipsResearchBase.Location = new System.Drawing.Point(119, 36);
            this.shipsResearchBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shipsResearchBase.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.shipsResearchBase.Name = "shipResBaseNum";
            this.shipsResearchBase.Size = new System.Drawing.Size(59, 23);
            this.shipsResearchBase.TabIndex = 4;
            this.shipsResearchBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shipsResearchBase.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.shipsResearchBase.ValueChanged += new System.EventHandler(this.shipsResearchBase_ValueChanged);
            // 
            // troopResBaseNum
            // 
            this.troopsResearchBase.Enabled = false;
            this.troopsResearchBase.Location = new System.Drawing.Point(119, 69);
            this.troopsResearchBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopsResearchBase.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.troopsResearchBase.Name = "troopResBaseNum";
            this.troopsResearchBase.Size = new System.Drawing.Size(59, 23);
            this.troopsResearchBase.TabIndex = 6;
            this.troopsResearchBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.troopsResearchBase.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.troopsResearchBase.ValueChanged += new System.EventHandler(this.troopsResearchBase_ValueChanged);
            // 
            // troopResLabel
            // 
            this.troopResLabel.AutoSize = true;
            this.troopResLabel.Enabled = false;
            this.troopResLabel.Location = new System.Drawing.Point(7, 72);
            this.troopResLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.troopResLabel.Name = "troopResLabel";
            this.troopResLabel.Size = new System.Drawing.Size(37, 15);
            this.troopResLabel.TabIndex = 0;
            this.troopResLabel.Text = "Troop";
            // 
            // BasicGroup
            // 
            this.BasicGroup.Controls.Add(this.loyaltyVariance);
            this.BasicGroup.Controls.Add(this.loyaltyBase);
            this.BasicGroup.Controls.Add(this.loyaltyLabel);
            this.BasicGroup.Controls.Add(this.statsVarLabel);
            this.BasicGroup.Controls.Add(this.statsBaseLabel);
            this.BasicGroup.Controls.Add(this.combatVariance);
            this.BasicGroup.Controls.Add(this.diplomacyVariance);
            this.BasicGroup.Controls.Add(this.espionageVariance);
            this.BasicGroup.Controls.Add(this.combatLabel);
            this.BasicGroup.Controls.Add(this.combatBase);
            this.BasicGroup.Controls.Add(this.diploLabel);
            this.BasicGroup.Controls.Add(this.diplomacyBase);
            this.BasicGroup.Controls.Add(this.espionageBase);
            this.BasicGroup.Controls.Add(this.espLabel);
            this.BasicGroup.Location = new System.Drawing.Point(4, 3);
            this.BasicGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BasicGroup.Name = "BasicGroup";
            this.BasicGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BasicGroup.Size = new System.Drawing.Size(262, 174);
            this.BasicGroup.TabIndex = 4;
            this.BasicGroup.TabStop = false;
            this.BasicGroup.Text = "Basic Stats";
            // 
            // loyalVarNum
            // 
            this.loyaltyVariance.Location = new System.Drawing.Point(186, 129);
            this.loyaltyVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loyaltyVariance.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.loyaltyVariance.Name = "loyalVarNum";
            this.loyaltyVariance.Size = new System.Drawing.Size(59, 23);
            this.loyaltyVariance.TabIndex = 11;
            this.loyaltyVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.loyaltyVariance.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.loyaltyVariance.ValueChanged += new System.EventHandler(this.loyaltyVariance_ValueChanged);
            // 
            // loyalBaseNum
            // 
            this.loyaltyBase.Location = new System.Drawing.Point(119, 129);
            this.loyaltyBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loyaltyBase.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.loyaltyBase.Name = "loyalBaseNum";
            this.loyaltyBase.Size = new System.Drawing.Size(59, 23);
            this.loyaltyBase.TabIndex = 10;
            this.loyaltyBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.loyaltyBase.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.loyaltyBase.ValueChanged += new System.EventHandler(this.loyaltyBase_ValueChanged);
            // 
            // loyaltyLabel
            // 
            this.loyaltyLabel.AutoSize = true;
            this.loyaltyLabel.Location = new System.Drawing.Point(7, 137);
            this.loyaltyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loyaltyLabel.Name = "loyaltyLabel";
            this.loyaltyLabel.Size = new System.Drawing.Size(45, 15);
            this.loyaltyLabel.TabIndex = 12;
            this.loyaltyLabel.Text = "Loyalty";
            // 
            // statsVarLabel
            // 
            this.statsVarLabel.AutoSize = true;
            this.statsVarLabel.BackColor = System.Drawing.Color.Silver;
            this.statsVarLabel.Enabled = false;
            this.statsVarLabel.Location = new System.Drawing.Point(182, 17);
            this.statsVarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statsVarLabel.Name = "statsVarLabel";
            this.statsVarLabel.Size = new System.Drawing.Size(51, 15);
            this.statsVarLabel.TabIndex = 11;
            this.statsVarLabel.Text = "Variance";
            // 
            // statsBaseLabel
            // 
            this.statsBaseLabel.AutoSize = true;
            this.statsBaseLabel.BackColor = System.Drawing.Color.Silver;
            this.statsBaseLabel.Enabled = false;
            this.statsBaseLabel.Location = new System.Drawing.Point(115, 17);
            this.statsBaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statsBaseLabel.Name = "statsBaseLabel";
            this.statsBaseLabel.Size = new System.Drawing.Size(31, 15);
            this.statsBaseLabel.TabIndex = 10;
            this.statsBaseLabel.Text = "Base";
            // 
            // combatVarNum
            // 
            this.combatVariance.Location = new System.Drawing.Point(186, 99);
            this.combatVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combatVariance.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.combatVariance.Name = "combatVarNum";
            this.combatVariance.Size = new System.Drawing.Size(59, 23);
            this.combatVariance.TabIndex = 9;
            this.combatVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.combatVariance.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.combatVariance.ValueChanged += new System.EventHandler(this.combatVariance_ValueChanged);
            // 
            // dipVarNum
            // 
            this.diplomacyVariance.Location = new System.Drawing.Point(186, 36);
            this.diplomacyVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.diplomacyVariance.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.diplomacyVariance.Name = "dipVarNum";
            this.diplomacyVariance.Size = new System.Drawing.Size(59, 23);
            this.diplomacyVariance.TabIndex = 5;
            this.diplomacyVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.diplomacyVariance.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.diplomacyVariance.ValueChanged += new System.EventHandler(this.diplomacyVariance_ValueChanged);
            // 
            // espVarNum
            // 
            this.espionageVariance.Location = new System.Drawing.Point(186, 69);
            this.espionageVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.espionageVariance.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.espionageVariance.Name = "espVarNum";
            this.espionageVariance.Size = new System.Drawing.Size(59, 23);
            this.espionageVariance.TabIndex = 7;
            this.espionageVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.espionageVariance.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.espionageVariance.ValueChanged += new System.EventHandler(this.espionageVariance_ValueChanged);
            // 
            // combatLabel
            // 
            this.combatLabel.AutoSize = true;
            this.combatLabel.Location = new System.Drawing.Point(7, 102);
            this.combatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.combatLabel.Name = "combatLabel";
            this.combatLabel.Size = new System.Drawing.Size(50, 15);
            this.combatLabel.TabIndex = 0;
            this.combatLabel.Text = "Combat";
            // 
            // combatBaseNum
            // 
            this.combatBase.Location = new System.Drawing.Point(119, 99);
            this.combatBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combatBase.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.combatBase.Name = "combatBaseNum";
            this.combatBase.Size = new System.Drawing.Size(59, 23);
            this.combatBase.TabIndex = 8;
            this.combatBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.combatBase.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.combatBase.ValueChanged += new System.EventHandler(this.combatBase_ValueChanged);
            // 
            // diploLabel
            // 
            this.diploLabel.AutoSize = true;
            this.diploLabel.Location = new System.Drawing.Point(7, 38);
            this.diploLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diploLabel.Name = "diploLabel";
            this.diploLabel.Size = new System.Drawing.Size(64, 15);
            this.diploLabel.TabIndex = 0;
            this.diploLabel.Text = "Diplomacy";
            // 
            // dipBaseNum
            // 
            this.diplomacyBase.Location = new System.Drawing.Point(119, 36);
            this.diplomacyBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.diplomacyBase.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.diplomacyBase.Name = "dipBaseNum";
            this.diplomacyBase.Size = new System.Drawing.Size(59, 23);
            this.diplomacyBase.TabIndex = 4;
            this.diplomacyBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.diplomacyBase.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.diplomacyBase.ValueChanged += new System.EventHandler(this.diplomacyBase_ValueChanged);
            // 
            // espBaseNum
            // 
            this.espionageBase.Location = new System.Drawing.Point(119, 69);
            this.espionageBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.espionageBase.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.espionageBase.Name = "espBaseNum";
            this.espionageBase.Size = new System.Drawing.Size(59, 23);
            this.espionageBase.TabIndex = 6;
            this.espionageBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.espionageBase.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.espionageBase.ValueChanged += new System.EventHandler(this.espionageBase_ValueChanged);
            // 
            // espLabel
            // 
            this.espLabel.AutoSize = true;
            this.espLabel.Location = new System.Drawing.Point(7, 72);
            this.espLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.espLabel.Name = "espLabel";
            this.espLabel.Size = new System.Drawing.Size(61, 15);
            this.espLabel.TabIndex = 0;
            this.espLabel.Text = "Espionage";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.encyText);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(553, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ency";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.familyIdHexLabel);
            this.groupBox1.Controls.Add(this.specialForceIdHexLabel);
            this.groupBox1.Controls.Add(this.specialForceId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.missionId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.unknown2);
            this.groupBox1.Controls.Add(this.textStraDllId);
            this.groupBox1.Controls.Add(this.productionFacility);
            this.groupBox1.Controls.Add(this.unkown3Label);
            this.groupBox1.Controls.Add(this.familyId);
            this.groupBox1.Controls.Add(this.prodLabel);
            this.groupBox1.Controls.Add(this.idLabel);
            this.groupBox1.Controls.Add(this.familyLabel);
            this.groupBox1.Controls.Add(this.secProdFacNumlabel);
            this.groupBox1.Controls.Add(this.nextProductionFacility);
            this.groupBox1.Location = new System.Drawing.Point(0, 162);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(545, 211);
            this.groupBox1.TabIndex = 135;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DAT misc";
            // 
            // famHexLabel
            // 
            this.familyIdHexLabel.AutoSize = true;
            this.familyIdHexLabel.Enabled = false;
            this.familyIdHexLabel.Location = new System.Drawing.Point(198, 92);
            this.familyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdHexLabel.Name = "famHexLabel";
            this.familyIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.familyIdHexLabel.TabIndex = 1139;
            this.familyIdHexLabel.Text = "hex";
            // 
            // unitHexLabel
            // 
            this.specialForceIdHexLabel.AutoSize = true;
            this.specialForceIdHexLabel.Enabled = false;
            this.specialForceIdHexLabel.Location = new System.Drawing.Point(198, 180);
            this.specialForceIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.specialForceIdHexLabel.Name = "unitHexLabel";
            this.specialForceIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.specialForceIdHexLabel.TabIndex = 1138;
            this.specialForceIdHexLabel.Text = "hex";
            // 
            // unitNum
            // 
            this.specialForceId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.specialForceId.Enabled = false;
            this.specialForceId.Location = new System.Drawing.Point(138, 178);
            this.specialForceId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.specialForceId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.specialForceId.Name = "unitNum";
            this.specialForceId.Size = new System.Drawing.Size(59, 23);
            this.specialForceId.TabIndex = 1137;
            this.specialForceId.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(26, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 1136;
            this.label4.Text = "Unit ID";
            // 
            // missionIdNum
            // 
            this.missionId.Enabled = false;
            this.missionId.Location = new System.Drawing.Point(392, 32);
            this.missionId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.missionId.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.missionId.Name = "missionIdNum";
            this.missionId.Size = new System.Drawing.Size(59, 23);
            this.missionId.TabIndex = 148;
            this.missionId.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(280, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 147;
            this.label3.Text = "Mission ID";
            // 
            // unknown3Num
            // 
            this.unknown2.Enabled = false;
            this.unknown2.Location = new System.Drawing.Point(138, 118);
            this.unknown2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknown2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknown2.Name = "unknown3Num";
            this.unknown2.Size = new System.Drawing.Size(59, 23);
            this.unknown2.TabIndex = 144;
            this.unknown2.TabStop = false;
            // 
            // idNum
            // 
            this.textStraDllId.Enabled = false;
            this.textStraDllId.Location = new System.Drawing.Point(138, 148);
            this.textStraDllId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textStraDllId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.textStraDllId.Name = "idNum";
            this.textStraDllId.Size = new System.Drawing.Size(59, 23);
            this.textStraDllId.TabIndex = 146;
            this.textStraDllId.TabStop = false;
            // 
            // prodFacNum
            // 
            this.productionFacility.BackColor = System.Drawing.SystemColors.ControlLight;
            this.productionFacility.Enabled = false;
            this.productionFacility.Location = new System.Drawing.Point(138, 27);
            this.productionFacility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productionFacility.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.productionFacility.Name = "prodFacNum";
            this.productionFacility.Size = new System.Drawing.Size(59, 23);
            this.productionFacility.TabIndex = 137;
            this.productionFacility.TabStop = false;
            this.productionFacility.ValueChanged += new System.EventHandler(this.productionFacility_ValueChanged);
            // 
            // unkown3Label
            // 
            this.unkown3Label.AutoSize = true;
            this.unkown3Label.Enabled = false;
            this.unkown3Label.Location = new System.Drawing.Point(26, 120);
            this.unkown3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unkown3Label.Name = "unkown3Label";
            this.unkown3Label.Size = new System.Drawing.Size(58, 15);
            this.unkown3Label.TabIndex = 143;
            this.unkown3Label.Text = "Unknown";
            // 
            // familyIdNum
            // 
            this.familyId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.familyId.Enabled = false;
            this.familyId.Location = new System.Drawing.Point(138, 88);
            this.familyId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.familyId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.familyId.Name = "familyIdNum";
            this.familyId.Size = new System.Drawing.Size(59, 23);
            this.familyId.TabIndex = 145;
            this.familyId.TabStop = false;
            this.familyId.ValueChanged += new System.EventHandler(this.familyId_ValueChanged);
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.Enabled = false;
            this.prodLabel.Location = new System.Drawing.Point(26, 29);
            this.prodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(106, 15);
            this.prodLabel.TabIndex = 138;
            this.prodLabel.Text = "Production Facility";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Enabled = false;
            this.idLabel.Location = new System.Drawing.Point(26, 150);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(85, 15);
            this.idLabel.TabIndex = 142;
            this.idLabel.Text = "TextStra.DLL ID";
            // 
            // familyLabel
            // 
            this.familyLabel.AutoSize = true;
            this.familyLabel.Enabled = false;
            this.familyLabel.Location = new System.Drawing.Point(26, 85);
            this.familyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyLabel.Name = "familyLabel";
            this.familyLabel.Size = new System.Drawing.Size(56, 15);
            this.familyLabel.TabIndex = 141;
            this.familyLabel.Text = "Family ID";
            // 
            // secProdFacNumlabel
            // 
            this.secProdFacNumlabel.AutoSize = true;
            this.secProdFacNumlabel.Enabled = false;
            this.secProdFacNumlabel.Location = new System.Drawing.Point(26, 58);
            this.secProdFacNumlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secProdFacNumlabel.Name = "secProdFacNumlabel";
            this.secProdFacNumlabel.Size = new System.Drawing.Size(92, 15);
            this.secProdFacNumlabel.TabIndex = 140;
            this.secProdFacNumlabel.Text = "Prod Facility + 1";
            // 
            // secProdFacNum
            // 
            this.nextProductionFacility.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nextProductionFacility.Enabled = false;
            this.nextProductionFacility.Location = new System.Drawing.Point(138, 58);
            this.nextProductionFacility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextProductionFacility.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nextProductionFacility.Name = "secProdFacNum";
            this.nextProductionFacility.Size = new System.Drawing.Size(59, 23);
            this.nextProductionFacility.TabIndex = 139;
            this.nextProductionFacility.TabStop = false;
            this.nextProductionFacility.ValueChanged += new System.EventHandler(this.nextProductionFacility_ValueChanged);
            // 
            // encyText
            // 
            this.encyText.Cursor = System.Windows.Forms.Cursors.No;
            this.encyText.Enabled = false;
            this.encyText.Location = new System.Drawing.Point(0, 0);
            this.encyText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.encyText.Name = "encyText";
            this.encyText.Size = new System.Drawing.Size(551, 154);
            this.encyText.TabIndex = 134;
            this.encyText.TabStop = false;
            this.encyText.Text = "Not Implemented yet....Encylopedia Data...Will add .Someday";
            // 
            // conCostLabel
            // 
            this.conCostLabel.AutoSize = true;
            this.conCostLabel.Location = new System.Drawing.Point(6, 16);
            this.conCostLabel.Name = "conCostLabel";
            this.conCostLabel.Size = new System.Drawing.Size(90, 13);
            this.conCostLabel.TabIndex = 0;
            this.conCostLabel.Text = "Construction Cost";
            // 
            // conCostNum2
            // 
            this.conCostNum2.Location = new System.Drawing.Point(0, 0);
            this.conCostNum2.Name = "conCostNum2";
            this.conCostNum2.Size = new System.Drawing.Size(100, 23);
            this.conCostNum2.TabIndex = 4;
            // 
            // maintCostLabel
            // 
            this.maintCostLabel.AutoSize = true;
            this.maintCostLabel.Location = new System.Drawing.Point(6, 40);
            this.maintCostLabel.Name = "maintCostLabel";
            this.maintCostLabel.Size = new System.Drawing.Size(93, 13);
            this.maintCostLabel.TabIndex = 0;
            this.maintCostLabel.Text = "Maintenance Cost";
            // 
            // maintCostNum2
            // 
            this.maintCostNum2.Location = new System.Drawing.Point(102, 42);
            this.maintCostNum2.Name = "maintCostNum2";
            this.maintCostNum2.Size = new System.Drawing.Size(43, 23);
            this.maintCostNum2.TabIndex = 5;
            // 
            // ItemPicture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picture.Name = "ItemPicture";
            this.picture.Size = new System.Drawing.Size(220, 110);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 156;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // SpecialForcesForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(810, 578);
            this.Controls.Add(this.specialForcesListView);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.charLoyalGroup);
            this.Controls.Add(this.encyclopediaName);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(826, 617);
            this.MinimumSize = new System.Drawing.Size(826, 617);
            this.Name = "SpecialForcesForm";
            this.Text = "Special Forces (SPECFCSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);
            this.charLoyalGroup.ResumeLayout(false);
            this.charLoyalGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.researchBox.ResumeLayout(false);
            this.researchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).EndInit();
            this.costGroup.ResumeLayout(false);
            this.costGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.constructionCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).EndInit();
            this.researchGroup.ResumeLayout(false);
            this.researchGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facilitiesResearchVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipsResearchVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopsResearchVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilitiesResearchBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipsResearchBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopsResearchBase)).EndInit();
            this.BasicGroup.ResumeLayout(false);
            this.BasicGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loyaltyVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyaltyBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomacyVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espionageVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomacyBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espionageBase)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialForceId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conCostNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintCostNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}