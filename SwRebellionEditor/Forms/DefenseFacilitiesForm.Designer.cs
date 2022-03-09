using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class DefenseFacilitiesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;
        private Button openNew;
        private Button SaveAs;
        private Button Cancel;
        private Button Ok;
        private TrackBar selector;
        private RichTextBox encyText;
        private Label encyclopediaName;
        private Label idLabel;
        private NumericUpDown textStraDllId;
        private Label unkown3Label;
        private NumericUpDown unknown3Num;
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
        private NumericUpDown shieldRating;
        private Label ShieldLabel;
        private NumericUpDown firePowerRating;
        private Label FirePowerlabel;
        private Label researchLabel;
        private NumericUpDown researchOrder;
        private NumericUpDown maintenanceCost;
        private Label maintCostLabel;
        private PictureBox picture;
        private NumericUpDown constructionCost;
        private Label conCostLabel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox CostsGroup;
        private TabPage tabPage2;
        private GroupBox DATgroup;
        private GroupBox miscGroup;
        private GroupBox ReserachGroup;
        private Label familyIdHexLabel;
        private Label unitIdHexLabel;
        private NumericUpDown unitId;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefenseFacilitiesForm));
            this.openNew = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.encyText = new System.Windows.Forms.RichTextBox();
            this.encyclopediaName = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.textStraDllId = new System.Windows.Forms.NumericUpDown();
            this.unkown3Label = new System.Windows.Forms.Label();
            this.unknown3Num = new System.Windows.Forms.NumericUpDown();
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
            this.shieldRating = new System.Windows.Forms.NumericUpDown();
            this.ShieldLabel = new System.Windows.Forms.Label();
            this.firePowerRating = new System.Windows.Forms.NumericUpDown();
            this.FirePowerlabel = new System.Windows.Forms.Label();
            this.researchLabel = new System.Windows.Forms.Label();
            this.researchOrder = new System.Windows.Forms.NumericUpDown();
            this.maintenanceCost = new System.Windows.Forms.NumericUpDown();
            this.maintCostLabel = new System.Windows.Forms.Label();
            this.constructionCost = new System.Windows.Forms.NumericUpDown();
            this.conCostLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DATgroup = new System.Windows.Forms.GroupBox();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.unitIdHexLabel = new System.Windows.Forms.Label();
            this.unitId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.miscGroup = new System.Windows.Forms.GroupBox();
            this.ReserachGroup = new System.Windows.Forms.GroupBox();
            this.CostsGroup = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown3Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknownMoralHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firePowerRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constructionCost)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.DATgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitId)).BeginInit();
            this.miscGroup.SuspendLayout();
            this.ReserachGroup.SuspendLayout();
            this.CostsGroup.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // openNew
            // 
            this.openNew.Location = new System.Drawing.Point(327, 487);
            this.openNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openNew.Name = "openNew";
            this.openNew.Size = new System.Drawing.Size(88, 27);
            this.openNew.TabIndex = 92;
            this.openNew.Text = "Open...";
            this.openNew.UseVisualStyleBackColor = true;
            this.openNew.Click += new System.EventHandler(this.Open_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Location = new System.Drawing.Point(232, 487);
            this.SaveAs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(88, 27);
            this.SaveAs.TabIndex = 91;
            this.SaveAs.Text = "&SaveAs...";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(118, 487);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 27);
            this.Cancel.TabIndex = 90;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(23, 487);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 88;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // encyText
            // 
            this.encyText.Enabled = false;
            this.encyText.Location = new System.Drawing.Point(0, 0);
            this.encyText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.encyText.Name = "encyText";
            this.encyText.Size = new System.Drawing.Size(400, 145);
            this.encyText.TabIndex = 67;
            this.encyText.TabStop = false;
            this.encyText.Text = "Not Implemented yet....Encylopedia Data...Will add .Someday";
            // 
            // ItemName
            // 
            this.encyclopediaName.AutoSize = true;
            this.encyclopediaName.Location = new System.Drawing.Point(230, 75);
            this.encyclopediaName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encyclopediaName.Name = "ItemName";
            this.encyclopediaName.Size = new System.Drawing.Size(0, 15);
            this.encyclopediaName.TabIndex = 89;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Enabled = false;
            this.idLabel.Location = new System.Drawing.Point(7, 143);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(85, 15);
            this.idLabel.TabIndex = 68;
            this.idLabel.Text = "TextStra.DLL ID";
            // 
            // idNum
            // 
            this.textStraDllId.Enabled = false;
            this.textStraDllId.Location = new System.Drawing.Point(119, 141);
            this.textStraDllId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textStraDllId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.textStraDllId.Name = "idNum";
            this.textStraDllId.Size = new System.Drawing.Size(59, 23);
            this.textStraDllId.TabIndex = 74;
            this.textStraDllId.TabStop = false;
            this.textStraDllId.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // unkown3Label
            // 
            this.unkown3Label.AutoSize = true;
            this.unkown3Label.Enabled = false;
            this.unkown3Label.Location = new System.Drawing.Point(7, 113);
            this.unkown3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unkown3Label.Name = "unkown3Label";
            this.unkown3Label.Size = new System.Drawing.Size(58, 15);
            this.unkown3Label.TabIndex = 71;
            this.unkown3Label.Text = "Unknown";
            // 
            // unknown3Num
            // 
            this.unknown3Num.Enabled = false;
            this.unknown3Num.Location = new System.Drawing.Point(119, 111);
            this.unknown3Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknown3Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknown3Num.Name = "unknown3Num";
            this.unknown3Num.Size = new System.Drawing.Size(59, 23);
            this.unknown3Num.TabIndex = 72;
            this.unknown3Num.TabStop = false;
            this.unknown3Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // familyIdNum
            // 
            this.familyId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.familyId.Enabled = false;
            this.familyId.Location = new System.Drawing.Point(119, 81);
            this.familyId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.familyId.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.familyId.Name = "familyIdNum";
            this.familyId.Size = new System.Drawing.Size(59, 23);
            this.familyId.TabIndex = 73;
            this.familyId.TabStop = false;
            this.familyId.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.familyId.ValueChanged += new System.EventHandler(this.familyId_ValueChanged);
            // 
            // familyLabel
            // 
            this.familyLabel.AutoSize = true;
            this.familyLabel.Enabled = false;
            this.familyLabel.Location = new System.Drawing.Point(7, 78);
            this.familyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyLabel.Name = "familyLabel";
            this.familyLabel.Size = new System.Drawing.Size(56, 15);
            this.familyLabel.TabIndex = 66;
            this.familyLabel.Text = "Family ID";
            // 
            // secProdFacNum
            // 
            this.nextProductionFacility.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nextProductionFacility.Enabled = false;
            this.nextProductionFacility.Location = new System.Drawing.Point(119, 51);
            this.nextProductionFacility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextProductionFacility.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nextProductionFacility.Name = "secProdFacNum";
            this.nextProductionFacility.Size = new System.Drawing.Size(59, 23);
            this.nextProductionFacility.TabIndex = 58;
            this.nextProductionFacility.TabStop = false;
            this.nextProductionFacility.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nextProductionFacility.ValueChanged += new System.EventHandler(this.nextProductionFacility_ValueChanged);
            // 
            // secProdFacNumlabel
            // 
            this.secProdFacNumlabel.AutoSize = true;
            this.secProdFacNumlabel.Enabled = false;
            this.secProdFacNumlabel.Location = new System.Drawing.Point(7, 51);
            this.secProdFacNumlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secProdFacNumlabel.Name = "secProdFacNumlabel";
            this.secProdFacNumlabel.Size = new System.Drawing.Size(92, 15);
            this.secProdFacNumlabel.TabIndex = 59;
            this.secProdFacNumlabel.Text = "Prod Facility + 1";
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.Enabled = false;
            this.prodLabel.Location = new System.Drawing.Point(7, 22);
            this.prodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(106, 15);
            this.prodLabel.TabIndex = 57;
            this.prodLabel.Text = "Production Facility";
            // 
            // prodFacNum
            // 
            this.productionFacility.BackColor = System.Drawing.SystemColors.ControlLight;
            this.productionFacility.Enabled = false;
            this.productionFacility.Location = new System.Drawing.Point(119, 20);
            this.productionFacility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productionFacility.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.productionFacility.Name = "prodFacNum";
            this.productionFacility.Size = new System.Drawing.Size(59, 23);
            this.productionFacility.TabIndex = 55;
            this.productionFacility.TabStop = false;
            this.productionFacility.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.productionFacility.ValueChanged += new System.EventHandler(this.productionFacility_ValueChanged);
            // 
            // unknownMoralHpNum
            // 
            this.unknownMoralHp.Location = new System.Drawing.Point(119, 83);
            this.unknownMoralHp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknownMoralHp.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknownMoralHp.Name = "unknownMoralHpNum";
            this.unknownMoralHp.Size = new System.Drawing.Size(59, 23);
            this.unknownMoralHp.TabIndex = 87;
            this.unknownMoralHp.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknownMoralHp.ValueChanged += new System.EventHandler(this.unknownMoralHp_ValueChanged);
            // 
            // UnkownMoralHPlabel
            // 
            this.UnkownMoralHPlabel.AutoSize = true;
            this.UnkownMoralHPlabel.Location = new System.Drawing.Point(7, 81);
            this.UnkownMoralHPlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnkownMoralHPlabel.Name = "UnkownMoralHPlabel";
            this.UnkownMoralHPlabel.Size = new System.Drawing.Size(80, 15);
            this.UnkownMoralHPlabel.TabIndex = 56;
            this.UnkownMoralHPlabel.Text = "Bombard Def.";
            // 
            // resDiffNum
            // 
            this.researchDifficulty.Location = new System.Drawing.Point(119, 43);
            this.researchDifficulty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchDifficulty.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchDifficulty.Name = "resDiffNum";
            this.researchDifficulty.Size = new System.Drawing.Size(59, 23);
            this.researchDifficulty.TabIndex = 86;
            this.researchDifficulty.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchDifficulty.ValueChanged += new System.EventHandler(this.researchDifficulty_ValueChanged);
            // 
            // resDiffLabel
            // 
            this.resDiffLabel.AutoSize = true;
            this.resDiffLabel.Location = new System.Drawing.Point(7, 43);
            this.resDiffLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resDiffLabel.Name = "resDiffLabel";
            this.resDiffLabel.Size = new System.Drawing.Size(105, 15);
            this.resDiffLabel.TabIndex = 64;
            this.resDiffLabel.Text = "Research Difficulty";
            // 
            // empireUnit
            // 
            this.isEmpireUnit.AutoSize = true;
            this.isEmpireUnit.Location = new System.Drawing.Point(130, 97);
            this.isEmpireUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isEmpireUnit.Name = "empireUnit";
            this.isEmpireUnit.Size = new System.Drawing.Size(94, 19);
            this.isEmpireUnit.TabIndex = 78;
            this.isEmpireUnit.Text = "Imperial Unit";
            this.isEmpireUnit.UseVisualStyleBackColor = true;
            this.isEmpireUnit.CheckStateChanged += new System.EventHandler(this.isEmpireUnit_CheckStateChanged);
            // 
            // rebelUnit
            // 
            this.isAllianceUnit.AutoSize = true;
            this.isAllianceUnit.Location = new System.Drawing.Point(23, 97);
            this.isAllianceUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isAllianceUnit.Name = "rebelUnit";
            this.isAllianceUnit.Size = new System.Drawing.Size(93, 19);
            this.isAllianceUnit.TabIndex = 77;
            this.isAllianceUnit.Text = "Alliance Unit";
            this.isAllianceUnit.UseVisualStyleBackColor = true;
            this.isAllianceUnit.CheckStateChanged += new System.EventHandler(this.isAllianceUnit_CheckStateChanged);
            // 
            // ItemSelect
            // 
            this.selector.LargeChange = 3;
            this.selector.Location = new System.Drawing.Point(233, 20);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 5;
            this.selector.Name = "ItemSelect";
            this.selector.Size = new System.Drawing.Size(121, 45);
            this.selector.TabIndex = 75;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            // 
            // ShieldNum
            // 
            this.shieldRating.Location = new System.Drawing.Point(119, 48);
            this.shieldRating.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shieldRating.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.shieldRating.Name = "ShieldNum";
            this.shieldRating.Size = new System.Drawing.Size(61, 23);
            this.shieldRating.TabIndex = 83;
            this.shieldRating.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.shieldRating.ValueChanged += new System.EventHandler(this.shieldRating_ValueChanged);
            // 
            // ShieldLabel
            // 
            this.ShieldLabel.AutoSize = true;
            this.ShieldLabel.Location = new System.Drawing.Point(7, 46);
            this.ShieldLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShieldLabel.Name = "ShieldLabel";
            this.ShieldLabel.Size = new System.Drawing.Size(76, 15);
            this.ShieldLabel.TabIndex = 61;
            this.ShieldLabel.Text = "Shield Rating";
            // 
            // FirePowerNum
            // 
            this.firePowerRating.Location = new System.Drawing.Point(119, 18);
            this.firePowerRating.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firePowerRating.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.firePowerRating.Name = "FirePowerNum";
            this.firePowerRating.Size = new System.Drawing.Size(61, 23);
            this.firePowerRating.TabIndex = 82;
            this.firePowerRating.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.firePowerRating.ValueChanged += new System.EventHandler(this.firePowerRating_ValueChanged);
            // 
            // FirePowerlabel
            // 
            this.FirePowerlabel.AutoSize = true;
            this.FirePowerlabel.Location = new System.Drawing.Point(7, 18);
            this.FirePowerlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirePowerlabel.Name = "FirePowerlabel";
            this.FirePowerlabel.Size = new System.Drawing.Size(96, 15);
            this.FirePowerlabel.TabIndex = 62;
            this.FirePowerlabel.Text = "FirePower Rating";
            // 
            // researchLabel
            // 
            this.researchLabel.AutoSize = true;
            this.researchLabel.Location = new System.Drawing.Point(7, 18);
            this.researchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.researchLabel.Name = "researchLabel";
            this.researchLabel.Size = new System.Drawing.Size(54, 15);
            this.researchLabel.TabIndex = 60;
            this.researchLabel.Text = "Research";
            // 
            // researchNum
            // 
            this.researchOrder.Location = new System.Drawing.Point(119, 16);
            this.researchOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchOrder.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchOrder.Name = "researchNum";
            this.researchOrder.Size = new System.Drawing.Size(61, 23);
            this.researchOrder.TabIndex = 81;
            this.researchOrder.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchOrder.ValueChanged += new System.EventHandler(this.researchOrder_ValueChanged);
            // 
            // maintCostNum
            // 
            this.maintenanceCost.Location = new System.Drawing.Point(119, 47);
            this.maintenanceCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maintenanceCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maintenanceCost.Name = "maintCostNum";
            this.maintenanceCost.Size = new System.Drawing.Size(61, 23);
            this.maintenanceCost.TabIndex = 80;
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
            this.maintCostLabel.Size = new System.Drawing.Size(103, 15);
            this.maintCostLabel.TabIndex = 70;
            this.maintCostLabel.Text = "Maintenance Cost";
            // 
            // conCostNum
            // 
            this.constructionCost.Location = new System.Drawing.Point(119, 17);
            this.constructionCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.constructionCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.constructionCost.Name = "conCostNum";
            this.constructionCost.Size = new System.Drawing.Size(61, 23);
            this.constructionCost.TabIndex = 79;
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
            this.conCostLabel.Location = new System.Drawing.Point(7, 17);
            this.conCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conCostLabel.Name = "conCostLabel";
            this.conCostLabel.Size = new System.Drawing.Size(103, 15);
            this.conCostLabel.TabIndex = 69;
            this.conCostLabel.Text = "Construction Cost";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 123);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 358);
            this.tabControl1.TabIndex = 93;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.DATgroup);
            this.tabPage1.Controls.Add(this.miscGroup);
            this.tabPage1.Controls.Add(this.ReserachGroup);
            this.tabPage1.Controls.Add(this.CostsGroup);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(418, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Data";
            // 
            // DATgroup
            // 
            this.DATgroup.Controls.Add(this.familyIdHexLabel);
            this.DATgroup.Controls.Add(this.prodLabel);
            this.DATgroup.Controls.Add(this.unitIdHexLabel);
            this.DATgroup.Controls.Add(this.productionFacility);
            this.DATgroup.Controls.Add(this.unitId);
            this.DATgroup.Controls.Add(this.label1);
            this.DATgroup.Controls.Add(this.secProdFacNumlabel);
            this.DATgroup.Controls.Add(this.nextProductionFacility);
            this.DATgroup.Controls.Add(this.familyLabel);
            this.DATgroup.Controls.Add(this.familyId);
            this.DATgroup.Controls.Add(this.unknown3Num);
            this.DATgroup.Controls.Add(this.idLabel);
            this.DATgroup.Controls.Add(this.unkown3Label);
            this.DATgroup.Controls.Add(this.textStraDllId);
            this.DATgroup.Location = new System.Drawing.Point(206, 3);
            this.DATgroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DATgroup.Name = "DATgroup";
            this.DATgroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DATgroup.Size = new System.Drawing.Size(215, 317);
            this.DATgroup.TabIndex = 1;
            this.DATgroup.TabStop = false;
            this.DATgroup.Text = "DAT misc";
            // 
            // famHexLabel
            // 
            this.familyIdHexLabel.AutoSize = true;
            this.familyIdHexLabel.Enabled = false;
            this.familyIdHexLabel.Location = new System.Drawing.Point(180, 85);
            this.familyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdHexLabel.Name = "famHexLabel";
            this.familyIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.familyIdHexLabel.TabIndex = 1123;
            this.familyIdHexLabel.Text = "hex";
            // 
            // unitHexLabel
            // 
            this.unitIdHexLabel.AutoSize = true;
            this.unitIdHexLabel.Enabled = false;
            this.unitIdHexLabel.Location = new System.Drawing.Point(180, 173);
            this.unitIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitIdHexLabel.Name = "unitHexLabel";
            this.unitIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.unitIdHexLabel.TabIndex = 1122;
            this.unitIdHexLabel.Text = "hex";
            // 
            // unitNum
            // 
            this.unitId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.unitId.Enabled = false;
            this.unitId.Location = new System.Drawing.Point(119, 171);
            this.unitId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unitId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.unitId.Name = "unitNum";
            this.unitId.Size = new System.Drawing.Size(59, 23);
            this.unitId.TabIndex = 1121;
            this.unitId.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(7, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1120;
            this.label1.Text = "Unit ID";
            // 
            // miscGroup
            // 
            this.miscGroup.Controls.Add(this.FirePowerlabel);
            this.miscGroup.Controls.Add(this.firePowerRating);
            this.miscGroup.Controls.Add(this.ShieldLabel);
            this.miscGroup.Controls.Add(this.shieldRating);
            this.miscGroup.Controls.Add(this.UnkownMoralHPlabel);
            this.miscGroup.Controls.Add(this.unknownMoralHp);
            this.miscGroup.Location = new System.Drawing.Point(4, 192);
            this.miscGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.miscGroup.Name = "miscGroup";
            this.miscGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.miscGroup.Size = new System.Drawing.Size(187, 112);
            this.miscGroup.TabIndex = 1;
            this.miscGroup.TabStop = false;
            this.miscGroup.Text = "Misc Data";
            // 
            // ReserachGroup
            // 
            this.ReserachGroup.Controls.Add(this.researchLabel);
            this.ReserachGroup.Controls.Add(this.researchOrder);
            this.ReserachGroup.Controls.Add(this.resDiffLabel);
            this.ReserachGroup.Controls.Add(this.researchDifficulty);
            this.ReserachGroup.Location = new System.Drawing.Point(4, 100);
            this.ReserachGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReserachGroup.Name = "ReserachGroup";
            this.ReserachGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReserachGroup.Size = new System.Drawing.Size(187, 84);
            this.ReserachGroup.TabIndex = 1;
            this.ReserachGroup.TabStop = false;
            this.ReserachGroup.Text = "Research";
            // 
            // CostsGroup
            // 
            this.CostsGroup.Controls.Add(this.conCostLabel);
            this.CostsGroup.Controls.Add(this.constructionCost);
            this.CostsGroup.Controls.Add(this.maintCostLabel);
            this.CostsGroup.Controls.Add(this.maintenanceCost);
            this.CostsGroup.Location = new System.Drawing.Point(4, 3);
            this.CostsGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CostsGroup.Name = "CostsGroup";
            this.CostsGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CostsGroup.Size = new System.Drawing.Size(187, 87);
            this.CostsGroup.TabIndex = 0;
            this.CostsGroup.TabStop = false;
            this.CostsGroup.Text = "Costs";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.encyText);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(418, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ency. Data";
            // 
            // ItemPicture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(23, 14);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picture.Name = "ItemPicture";
            this.picture.Size = new System.Drawing.Size(147, 74);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 76;
            this.picture.TabStop = false;
            // 
            // DefenseFacilitiesForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(436, 520);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.openNew);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.encyclopediaName);
            this.Controls.Add(this.isEmpireUnit);
            this.Controls.Add(this.isAllianceUnit);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(452, 559);
            this.MinimumSize = new System.Drawing.Size(452, 559);
            this.Name = "DefenseFacilitiesForm";
            this.Text = "Defense Facilities (DEFFACSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.Enter += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown3Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknownMoralHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firePowerRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constructionCost)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.DATgroup.ResumeLayout(false);
            this.DATgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitId)).EndInit();
            this.miscGroup.ResumeLayout(false);
            this.miscGroup.PerformLayout();
            this.ReserachGroup.ResumeLayout(false);
            this.ReserachGroup.PerformLayout();
            this.CostsGroup.ResumeLayout(false);
            this.CostsGroup.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}