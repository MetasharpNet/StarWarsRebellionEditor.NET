using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class ManufacturingFacilitiesForm
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
        private RichTextBox encyText;
        private Label name;
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
        private NumericUpDown bombardmentDefense;
        private Label UnkownMoralHPlabel;
        private NumericUpDown researchDifficulty;
        private Label resDiffLabel;
        private CheckBox isEmpireUnit;
        private CheckBox isAllianceUnit;
        private Label DetectionLabel;
        private NumericUpDown productionRate;
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label familyIdHexLabel;
        private Label unitIdHexLabel;
        private NumericUpDown unitId;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManufacturingFacilitiesForm));
            this.Open = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.encyText = new System.Windows.Forms.RichTextBox();
            this.name = new System.Windows.Forms.Label();
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
            this.bombardmentDefense = new System.Windows.Forms.NumericUpDown();
            this.UnkownMoralHPlabel = new System.Windows.Forms.Label();
            this.researchDifficulty = new System.Windows.Forms.NumericUpDown();
            this.resDiffLabel = new System.Windows.Forms.Label();
            this.isEmpireUnit = new System.Windows.Forms.CheckBox();
            this.isAllianceUnit = new System.Windows.Forms.CheckBox();
            this.selector = new System.Windows.Forms.TrackBar();
            this.DetectionLabel = new System.Windows.Forms.Label();
            this.productionRate = new System.Windows.Forms.NumericUpDown();
            this.researchLabel = new System.Windows.Forms.Label();
            this.researchOrder = new System.Windows.Forms.NumericUpDown();
            this.maintenanceCost = new System.Windows.Forms.NumericUpDown();
            this.maintCostLabel = new System.Windows.Forms.Label();
            this.constructionCost = new System.Windows.Forms.NumericUpDown();
            this.conCostLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.unitIdHexLabel = new System.Windows.Forms.Label();
            this.unitId = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardmentDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constructionCost)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitId)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(327, 487);
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
            this.SaveAs.Location = new System.Drawing.Point(232, 487);
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
            this.Cancel.Location = new System.Drawing.Point(118, 487);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 27);
            this.Cancel.TabIndex = 10;
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
            this.Ok.TabIndex = 9;
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
            this.encyText.TabIndex = 29;
            this.encyText.TabStop = false;
            this.encyText.Text = "Not Implemented yet....Encylopedia Data...Will add .Someday";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(240, 73);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(112, 15);
            this.name.TabIndex = 51;
            this.name.Text = "--item name label--";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Enabled = false;
            this.idLabel.Location = new System.Drawing.Point(7, 141);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(85, 15);
            this.idLabel.TabIndex = 30;
            this.idLabel.Text = "TextStra.DLL ID";
            // 
            // textStraDllId
            // 
            this.textStraDllId.Enabled = false;
            this.textStraDllId.Location = new System.Drawing.Point(119, 138);
            this.textStraDllId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textStraDllId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.textStraDllId.Name = "textStraDllId";
            this.textStraDllId.Size = new System.Drawing.Size(59, 23);
            this.textStraDllId.TabIndex = 36;
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
            this.unkown3Label.Location = new System.Drawing.Point(7, 111);
            this.unkown3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unkown3Label.Name = "unkown3Label";
            this.unkown3Label.Size = new System.Drawing.Size(58, 15);
            this.unkown3Label.TabIndex = 33;
            this.unkown3Label.Text = "Unknown";
            // 
            // unknown3Num
            // 
            this.unknown2.Enabled = false;
            this.unknown2.Location = new System.Drawing.Point(119, 108);
            this.unknown2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknown2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknown2.Name = "unknown3Num";
            this.unknown2.Size = new System.Drawing.Size(59, 23);
            this.unknown2.TabIndex = 34;
            this.unknown2.TabStop = false;
            this.unknown2.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // familyId
            // 
            this.familyId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.familyId.Enabled = false;
            this.familyId.Location = new System.Drawing.Point(119, 78);
            this.familyId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.familyId.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.familyId.Name = "familyId";
            this.familyId.Size = new System.Drawing.Size(59, 23);
            this.familyId.TabIndex = 35;
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
            this.familyLabel.Location = new System.Drawing.Point(7, 76);
            this.familyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyLabel.Name = "familyLabel";
            this.familyLabel.Size = new System.Drawing.Size(56, 15);
            this.familyLabel.TabIndex = 28;
            this.familyLabel.Text = "Family ID";
            // 
            // nextProductionFacility
            // 
            this.nextProductionFacility.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nextProductionFacility.Enabled = false;
            this.nextProductionFacility.Location = new System.Drawing.Point(119, 48);
            this.nextProductionFacility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextProductionFacility.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nextProductionFacility.Name = "nextProductionFacility";
            this.nextProductionFacility.Size = new System.Drawing.Size(59, 23);
            this.nextProductionFacility.TabIndex = 20;
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
            this.secProdFacNumlabel.Location = new System.Drawing.Point(7, 48);
            this.secProdFacNumlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secProdFacNumlabel.Name = "secProdFacNumlabel";
            this.secProdFacNumlabel.Size = new System.Drawing.Size(92, 15);
            this.secProdFacNumlabel.TabIndex = 21;
            this.secProdFacNumlabel.Text = "Prod Facility + 1";
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.Enabled = false;
            this.prodLabel.Location = new System.Drawing.Point(7, 20);
            this.prodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(106, 15);
            this.prodLabel.TabIndex = 19;
            this.prodLabel.Text = "Production Facility";
            // 
            // productionFacility
            // 
            this.productionFacility.BackColor = System.Drawing.SystemColors.ControlLight;
            this.productionFacility.Enabled = false;
            this.productionFacility.Location = new System.Drawing.Point(119, 17);
            this.productionFacility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productionFacility.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.productionFacility.Name = "productionFacility";
            this.productionFacility.Size = new System.Drawing.Size(59, 23);
            this.productionFacility.TabIndex = 17;
            this.productionFacility.TabStop = false;
            this.productionFacility.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.productionFacility.ValueChanged += new System.EventHandler(this.productionFacility_ValueChanged);
            // 
            // bombardmentDefense
            // 
            this.bombardmentDefense.Location = new System.Drawing.Point(112, 48);
            this.bombardmentDefense.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bombardmentDefense.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bombardmentDefense.Name = "bombardmentDefense";
            this.bombardmentDefense.Size = new System.Drawing.Size(59, 23);
            this.bombardmentDefense.TabIndex = 49;
            this.bombardmentDefense.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bombardmentDefense.ValueChanged += new System.EventHandler(this.bombardmentDefense_ValueChanged);
            // 
            // UnkownMoralHPlabel
            // 
            this.UnkownMoralHPlabel.AutoSize = true;
            this.UnkownMoralHPlabel.Location = new System.Drawing.Point(0, 52);
            this.UnkownMoralHPlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnkownMoralHPlabel.Name = "UnkownMoralHPlabel";
            this.UnkownMoralHPlabel.Size = new System.Drawing.Size(108, 15);
            this.UnkownMoralHPlabel.TabIndex = 18;
            this.UnkownMoralHPlabel.Text = "Bombardment Def.";
            // 
            // researchDifficulty
            // 
            this.researchDifficulty.Location = new System.Drawing.Point(112, 48);
            this.researchDifficulty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchDifficulty.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.researchDifficulty.Name = "researchDifficulty";
            this.researchDifficulty.Size = new System.Drawing.Size(59, 23);
            this.researchDifficulty.TabIndex = 48;
            this.researchDifficulty.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.researchDifficulty.ValueChanged += new System.EventHandler(this.researchDifficulty_ValueChanged);
            // 
            // resDiffLabel
            // 
            this.resDiffLabel.AutoSize = true;
            this.resDiffLabel.Location = new System.Drawing.Point(0, 48);
            this.resDiffLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resDiffLabel.Name = "resDiffLabel";
            this.resDiffLabel.Size = new System.Drawing.Size(105, 15);
            this.resDiffLabel.TabIndex = 26;
            this.resDiffLabel.Text = "Research Difficulty";
            // 
            // isEmpireUnit
            // 
            this.isEmpireUnit.AutoSize = true;
            this.isEmpireUnit.Location = new System.Drawing.Point(130, 97);
            this.isEmpireUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isEmpireUnit.Name = "isEmpireUnit";
            this.isEmpireUnit.Size = new System.Drawing.Size(94, 19);
            this.isEmpireUnit.TabIndex = 3;
            this.isEmpireUnit.Text = "Imperial Unit";
            this.isEmpireUnit.UseVisualStyleBackColor = true;
            this.isEmpireUnit.CheckStateChanged += new System.EventHandler(this.isEmpireUnit_CheckStateChanged);
            // 
            // isAllianceUnit
            // 
            this.isAllianceUnit.AutoSize = true;
            this.isAllianceUnit.Location = new System.Drawing.Point(23, 97);
            this.isAllianceUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isAllianceUnit.Name = "isAllianceUnit";
            this.isAllianceUnit.Size = new System.Drawing.Size(93, 19);
            this.isAllianceUnit.TabIndex = 2;
            this.isAllianceUnit.Text = "Alliance Unit";
            this.isAllianceUnit.UseVisualStyleBackColor = true;
            this.isAllianceUnit.CheckStateChanged += new System.EventHandler(this.isAllianceUnit_CheckStateChanged);
            // 
            // selector
            // 
            this.selector.LargeChange = 3;
            this.selector.Location = new System.Drawing.Point(244, 17);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 5;
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(121, 45);
            this.selector.TabIndex = 1;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            // 
            // DetectionLabel
            // 
            this.DetectionLabel.AutoSize = true;
            this.DetectionLabel.Location = new System.Drawing.Point(0, 20);
            this.DetectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DetectionLabel.Name = "DetectionLabel";
            this.DetectionLabel.Size = new System.Drawing.Size(92, 15);
            this.DetectionLabel.TabIndex = 27;
            this.DetectionLabel.Text = "Production Rate";
            // 
            // productionRate
            // 
            this.productionRate.Location = new System.Drawing.Point(112, 16);
            this.productionRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productionRate.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.productionRate.Name = "productionRate";
            this.productionRate.Size = new System.Drawing.Size(58, 23);
            this.productionRate.TabIndex = 47;
            this.productionRate.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.productionRate.ValueChanged += new System.EventHandler(this.productionRate_ValueChanged);
            // 
            // researchLabel
            // 
            this.researchLabel.AutoSize = true;
            this.researchLabel.Location = new System.Drawing.Point(0, 21);
            this.researchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.researchLabel.Name = "researchLabel";
            this.researchLabel.Size = new System.Drawing.Size(54, 15);
            this.researchLabel.TabIndex = 22;
            this.researchLabel.Text = "Research";
            // 
            // researchOrder
            // 
            this.researchOrder.Location = new System.Drawing.Point(112, 18);
            this.researchOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchOrder.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchOrder.Name = "researchOrder";
            this.researchOrder.Size = new System.Drawing.Size(58, 23);
            this.researchOrder.TabIndex = 43;
            this.researchOrder.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchOrder.ValueChanged += new System.EventHandler(this.researchOrder_ValueChanged);
            // 
            // maintenanceCost
            // 
            this.maintenanceCost.Location = new System.Drawing.Point(112, 52);
            this.maintenanceCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maintenanceCost.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.maintenanceCost.Name = "maintenanceCost";
            this.maintenanceCost.Size = new System.Drawing.Size(58, 23);
            this.maintenanceCost.TabIndex = 42;
            this.maintenanceCost.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.maintenanceCost.ValueChanged += new System.EventHandler(this.maintenanceCost_ValueChanged);
            // 
            // maintCostLabel
            // 
            this.maintCostLabel.AutoSize = true;
            this.maintCostLabel.Location = new System.Drawing.Point(0, 50);
            this.maintCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maintCostLabel.Name = "maintCostLabel";
            this.maintCostLabel.Size = new System.Drawing.Size(103, 15);
            this.maintCostLabel.TabIndex = 32;
            this.maintCostLabel.Text = "Maintenance Cost";
            // 
            // constructionCost
            // 
            this.constructionCost.Location = new System.Drawing.Point(112, 22);
            this.constructionCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.constructionCost.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.constructionCost.Name = "constructionCost";
            this.constructionCost.Size = new System.Drawing.Size(58, 23);
            this.constructionCost.TabIndex = 41;
            this.constructionCost.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.constructionCost.ValueChanged += new System.EventHandler(this.constructionCost_ValueChanged);
            // 
            // conCostLabel
            // 
            this.conCostLabel.AutoSize = true;
            this.conCostLabel.Location = new System.Drawing.Point(0, 22);
            this.conCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conCostLabel.Name = "conCostLabel";
            this.conCostLabel.Size = new System.Drawing.Size(103, 15);
            this.conCostLabel.TabIndex = 31;
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
            this.tabControl1.Size = new System.Drawing.Size(427, 358);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(419, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Data";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.familyIdHexLabel);
            this.groupBox4.Controls.Add(this.unitIdHexLabel);
            this.groupBox4.Controls.Add(this.unitId);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.prodLabel);
            this.groupBox4.Controls.Add(this.productionFacility);
            this.groupBox4.Controls.Add(this.secProdFacNumlabel);
            this.groupBox4.Controls.Add(this.nextProductionFacility);
            this.groupBox4.Controls.Add(this.familyLabel);
            this.groupBox4.Controls.Add(this.familyId);
            this.groupBox4.Controls.Add(this.idLabel);
            this.groupBox4.Controls.Add(this.unknown2);
            this.groupBox4.Controls.Add(this.textStraDllId);
            this.groupBox4.Controls.Add(this.unkown3Label);
            this.groupBox4.Location = new System.Drawing.Point(202, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(209, 300);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DAT Misc";
            // 
            // familyIdHexLabel
            // 
            this.familyIdHexLabel.AutoSize = true;
            this.familyIdHexLabel.Enabled = false;
            this.familyIdHexLabel.Location = new System.Drawing.Point(180, 83);
            this.familyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdHexLabel.Name = "familyIdHexLabel";
            this.familyIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.familyIdHexLabel.TabIndex = 1143;
            this.familyIdHexLabel.Text = "hex";
            // 
            // unitIdHexLabel
            // 
            this.unitIdHexLabel.AutoSize = true;
            this.unitIdHexLabel.Enabled = false;
            this.unitIdHexLabel.Location = new System.Drawing.Point(180, 171);
            this.unitIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitIdHexLabel.Name = "unitIdHexLabel";
            this.unitIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.unitIdHexLabel.TabIndex = 1142;
            this.unitIdHexLabel.Text = "hex";
            // 
            // unitId
            // 
            this.unitId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.unitId.Enabled = false;
            this.unitId.Location = new System.Drawing.Point(119, 168);
            this.unitId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unitId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.unitId.Name = "unitId";
            this.unitId.Size = new System.Drawing.Size(59, 23);
            this.unitId.TabIndex = 1141;
            this.unitId.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(7, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 1140;
            this.label4.Text = "Unit ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DetectionLabel);
            this.groupBox3.Controls.Add(this.productionRate);
            this.groupBox3.Controls.Add(this.UnkownMoralHPlabel);
            this.groupBox3.Controls.Add(this.bombardmentDefense);
            this.groupBox3.Location = new System.Drawing.Point(7, 196);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(187, 115);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc Stats";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.researchOrder);
            this.groupBox2.Controls.Add(this.researchLabel);
            this.groupBox2.Controls.Add(this.resDiffLabel);
            this.groupBox2.Controls.Add(this.researchDifficulty);
            this.groupBox2.Location = new System.Drawing.Point(7, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(187, 85);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Research";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.constructionCost);
            this.groupBox1.Controls.Add(this.conCostLabel);
            this.groupBox1.Controls.Add(this.maintCostLabel);
            this.groupBox1.Controls.Add(this.maintenanceCost);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(187, 89);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Costs";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.encyText);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(419, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ency. Data";
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(23, 14);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(147, 74);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 38;
            this.picture.TabStop = false;
            // 
            // ManufacturingFacilitiesForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(436, 520);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.name);
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
            this.Name = "ManufacturingFacilitiesForm";
            this.Text = "Manufacturing Facilities (MANFACSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.Enter += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardmentDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constructionCost)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitId)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}