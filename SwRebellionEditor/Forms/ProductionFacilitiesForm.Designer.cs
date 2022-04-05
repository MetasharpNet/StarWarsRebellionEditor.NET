using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class ProductionFacilitiesForm
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
        private PictureBox picture;
        private GroupBox groupBox2;
        private NumericUpDown maintenanceCost;
        private Label conCostLabel;
        private Label maintCostLabel;
        private NumericUpDown constructionCost;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionFacilitiesForm));
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maintenanceCost = new System.Windows.Forms.NumericUpDown();
            this.conCostLabel = new System.Windows.Forms.Label();
            this.maintCostLabel = new System.Windows.Forms.Label();
            this.constructionCost = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.unitIdHexLabel = new System.Windows.Forms.Label();
            this.unitId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constructionCost)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitId)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // openNew
            // 
            this.Open.Location = new System.Drawing.Point(327, 487);
            this.Open.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Open.Name = "openNew";
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
            this.encyText.TabIndex = 67;
            this.encyText.TabStop = false;
            this.encyText.Text = "Not Implemented yet....Encylopedia Data...Will add .Someday";
            // 
            // ItemName
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(240, 73);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "ItemName";
            this.name.Size = new System.Drawing.Size(112, 15);
            this.name.TabIndex = 89;
            this.name.Text = "--item name label--";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Enabled = false;
            this.idLabel.Location = new System.Drawing.Point(7, 142);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(85, 15);
            this.idLabel.TabIndex = 68;
            this.idLabel.Text = "TextStra.DLL ID";
            // 
            // idNum
            // 
            this.textStraDllId.Enabled = false;
            this.textStraDllId.Location = new System.Drawing.Point(119, 140);
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
            this.unkown3Label.Location = new System.Drawing.Point(7, 112);
            this.unkown3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unkown3Label.Name = "unkown3Label";
            this.unkown3Label.Size = new System.Drawing.Size(58, 15);
            this.unkown3Label.TabIndex = 71;
            this.unkown3Label.Text = "Unknown";
            // 
            // unknown3Num
            // 
            this.unknown2.Enabled = false;
            this.unknown2.Location = new System.Drawing.Point(119, 110);
            this.unknown2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknown2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknown2.Name = "unknown3Num";
            this.unknown2.Size = new System.Drawing.Size(59, 23);
            this.unknown2.TabIndex = 72;
            this.unknown2.TabStop = false;
            this.unknown2.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // familyIdNum
            // 
            this.familyId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.familyId.Enabled = false;
            this.familyId.Location = new System.Drawing.Point(119, 80);
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
            this.familyLabel.Location = new System.Drawing.Point(7, 77);
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
            this.nextProductionFacility.Location = new System.Drawing.Point(119, 50);
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
            this.secProdFacNumlabel.Location = new System.Drawing.Point(7, 50);
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
            this.prodLabel.Location = new System.Drawing.Point(7, 21);
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
            this.productionFacility.Location = new System.Drawing.Point(119, 18);
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
            this.bombardmentDefense.Location = new System.Drawing.Point(119, 51);
            this.bombardmentDefense.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bombardmentDefense.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bombardmentDefense.Name = "unknownMoralHpNum";
            this.bombardmentDefense.Size = new System.Drawing.Size(59, 23);
            this.bombardmentDefense.TabIndex = 87;
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
            this.UnkownMoralHPlabel.Location = new System.Drawing.Point(7, 48);
            this.UnkownMoralHPlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnkownMoralHPlabel.Name = "UnkownMoralHPlabel";
            this.UnkownMoralHPlabel.Size = new System.Drawing.Size(108, 15);
            this.UnkownMoralHPlabel.TabIndex = 56;
            this.UnkownMoralHPlabel.Text = "Bombardment Def.";
            // 
            // resDiffNum
            // 
            this.researchDifficulty.Location = new System.Drawing.Point(119, 46);
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
            this.resDiffLabel.Location = new System.Drawing.Point(7, 46);
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
            this.isEmpireUnit.TabIndex = 3;
            this.isEmpireUnit.Text = "Imperial Unit";
            this.isEmpireUnit.UseVisualStyleBackColor = true;
            // 
            // rebelUnit
            // 
            this.isAllianceUnit.AutoSize = true;
            this.isAllianceUnit.Location = new System.Drawing.Point(23, 97);
            this.isAllianceUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isAllianceUnit.Name = "rebelUnit";
            this.isAllianceUnit.Size = new System.Drawing.Size(93, 19);
            this.isAllianceUnit.TabIndex = 2;
            this.isAllianceUnit.Text = "Alliance Unit";
            this.isAllianceUnit.UseVisualStyleBackColor = true;
            // 
            // ItemSelect
            // 
            this.selector.LargeChange = 1;
            this.selector.Location = new System.Drawing.Point(244, 17);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 1;
            this.selector.Name = "ItemSelect";
            this.selector.Size = new System.Drawing.Size(121, 45);
            this.selector.TabIndex = 75;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            // 
            // DetectionLabel
            // 
            this.DetectionLabel.AutoSize = true;
            this.DetectionLabel.Location = new System.Drawing.Point(7, 18);
            this.DetectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DetectionLabel.Name = "DetectionLabel";
            this.DetectionLabel.Size = new System.Drawing.Size(92, 15);
            this.DetectionLabel.TabIndex = 65;
            this.DetectionLabel.Text = "Production Rate";
            // 
            // RateNum
            // 
            this.productionRate.Location = new System.Drawing.Point(119, 16);
            this.productionRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productionRate.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.productionRate.Name = "RateNum";
            this.productionRate.Size = new System.Drawing.Size(58, 23);
            this.productionRate.TabIndex = 85;
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
            this.researchOrder.Size = new System.Drawing.Size(58, 23);
            this.researchOrder.TabIndex = 81;
            this.researchOrder.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchOrder.ValueChanged += new System.EventHandler(this.researchOrder_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maintenanceCost);
            this.groupBox2.Controls.Add(this.conCostLabel);
            this.groupBox2.Controls.Add(this.maintCostLabel);
            this.groupBox2.Controls.Add(this.constructionCost);
            this.groupBox2.Location = new System.Drawing.Point(4, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(187, 97);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Costs";
            // 
            // maintCostNum
            // 
            this.maintenanceCost.Location = new System.Drawing.Point(119, 48);
            this.maintenanceCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maintenanceCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maintenanceCost.Name = "maintCostNum";
            this.maintenanceCost.Size = new System.Drawing.Size(58, 23);
            this.maintenanceCost.TabIndex = 97;
            this.maintenanceCost.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maintenanceCost.ValueChanged += new System.EventHandler(this.maintenanceCost_ValueChanged);
            // 
            // conCostLabel
            // 
            this.conCostLabel.AutoSize = true;
            this.conCostLabel.Location = new System.Drawing.Point(7, 18);
            this.conCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conCostLabel.Name = "conCostLabel";
            this.conCostLabel.Size = new System.Drawing.Size(103, 15);
            this.conCostLabel.TabIndex = 94;
            this.conCostLabel.Text = "Construction Cost";
            // 
            // maintCostLabel
            // 
            this.maintCostLabel.AutoSize = true;
            this.maintCostLabel.Location = new System.Drawing.Point(7, 46);
            this.maintCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maintCostLabel.Name = "maintCostLabel";
            this.maintCostLabel.Size = new System.Drawing.Size(103, 15);
            this.maintCostLabel.TabIndex = 95;
            this.maintCostLabel.Text = "Maintenance Cost";
            // 
            // conCostNum
            // 
            this.constructionCost.Location = new System.Drawing.Point(119, 18);
            this.constructionCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.constructionCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.constructionCost.Name = "conCostNum";
            this.constructionCost.Size = new System.Drawing.Size(58, 23);
            this.constructionCost.TabIndex = 96;
            this.constructionCost.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.constructionCost.ValueChanged += new System.EventHandler(this.constructionCost_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.researchLabel);
            this.groupBox3.Controls.Add(this.researchOrder);
            this.groupBox3.Controls.Add(this.resDiffLabel);
            this.groupBox3.Controls.Add(this.researchDifficulty);
            this.groupBox3.Location = new System.Drawing.Point(4, 107);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(187, 98);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Research";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DetectionLabel);
            this.groupBox4.Controls.Add(this.productionRate);
            this.groupBox4.Controls.Add(this.UnkownMoralHPlabel);
            this.groupBox4.Controls.Add(this.bombardmentDefense);
            this.groupBox4.Location = new System.Drawing.Point(4, 212);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(187, 98);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Misc Stats";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.familyIdHexLabel);
            this.groupBox5.Controls.Add(this.prodLabel);
            this.groupBox5.Controls.Add(this.unitIdHexLabel);
            this.groupBox5.Controls.Add(this.productionFacility);
            this.groupBox5.Controls.Add(this.unitId);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.secProdFacNumlabel);
            this.groupBox5.Controls.Add(this.nextProductionFacility);
            this.groupBox5.Controls.Add(this.familyLabel);
            this.groupBox5.Controls.Add(this.familyId);
            this.groupBox5.Controls.Add(this.unknown2);
            this.groupBox5.Controls.Add(this.idLabel);
            this.groupBox5.Controls.Add(this.unkown3Label);
            this.groupBox5.Controls.Add(this.textStraDllId);
            this.groupBox5.Location = new System.Drawing.Point(206, 7);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(209, 303);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DAT Misc";
            // 
            // famHexLabel
            // 
            this.familyIdHexLabel.AutoSize = true;
            this.familyIdHexLabel.Enabled = false;
            this.familyIdHexLabel.Location = new System.Drawing.Point(180, 84);
            this.familyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdHexLabel.Name = "famHexLabel";
            this.familyIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.familyIdHexLabel.TabIndex = 1135;
            this.familyIdHexLabel.Text = "hex";
            // 
            // unitHexLabel
            // 
            this.unitIdHexLabel.AutoSize = true;
            this.unitIdHexLabel.Enabled = false;
            this.unitIdHexLabel.Location = new System.Drawing.Point(180, 172);
            this.unitIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitIdHexLabel.Name = "unitHexLabel";
            this.unitIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.unitIdHexLabel.TabIndex = 1134;
            this.unitIdHexLabel.Text = "hex";
            // 
            // unitNum
            // 
            this.unitId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.unitId.Enabled = false;
            this.unitId.Location = new System.Drawing.Point(119, 170);
            this.unitId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unitId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.unitId.Name = "unitNum";
            this.unitId.Size = new System.Drawing.Size(59, 23);
            this.unitId.TabIndex = 1133;
            this.unitId.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(7, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1132;
            this.label1.Text = "Unit ID";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 123);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 358);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(412, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Data";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.encyText);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(412, 330);
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
            // ProductionFacilitiesForm
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
            this.Name = "ProductionFacilitiesForm";
            this.Text = "Production Facilities (PROFACSD.DAT)";
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constructionCost)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitId)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}