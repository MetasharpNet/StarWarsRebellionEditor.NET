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
        private Label idLabel;
        private NumericUpDown textStraDllId;
        private Label unkown3Label;
        private NumericUpDown field7_Unknown;
        private NumericUpDown familyId;
        private Label familyLabel;
        private NumericUpDown nextProductionFacility;
        private Label secProdFacNumlabel;
        private Label prodLabel;
        private NumericUpDown productionFacility;
        private CheckBox isEmpireUnit;
        private CheckBox isAllianceUnit;
        private PictureBox picture;
        private Label familyIdHexLabel;
        private Label idHexLabel;
        private NumericUpDown id;
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
            this.idLabel = new System.Windows.Forms.Label();
            this.textStraDllId = new System.Windows.Forms.NumericUpDown();
            this.unkown3Label = new System.Windows.Forms.Label();
            this.field7_Unknown = new System.Windows.Forms.NumericUpDown();
            this.familyId = new System.Windows.Forms.NumericUpDown();
            this.familyLabel = new System.Windows.Forms.Label();
            this.nextProductionFacility = new System.Windows.Forms.NumericUpDown();
            this.secProdFacNumlabel = new System.Windows.Forms.Label();
            this.prodLabel = new System.Windows.Forms.Label();
            this.productionFacility = new System.Windows.Forms.NumericUpDown();
            this.isEmpireUnit = new System.Windows.Forms.CheckBox();
            this.isAllianceUnit = new System.Windows.Forms.CheckBox();
            this.selector = new System.Windows.Forms.TrackBar();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.idHexLabel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.CostsGroup = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FirePowerlabel = new System.Windows.Forms.Label();
            this.attackStrength = new System.Windows.Forms.NumericUpDown();
            this.conCostLabel = new System.Windows.Forms.Label();
            this.refinedMaterialCost = new System.Windows.Forms.NumericUpDown();
            this.maintCostLabel = new System.Windows.Forms.Label();
            this.ShieldLabel = new System.Windows.Forms.Label();
            this.maintenanceCost = new System.Windows.Forms.NumericUpDown();
            this.shieldStrength = new System.Windows.Forms.NumericUpDown();
            this.bombardmentDefense = new System.Windows.Forms.NumericUpDown();
            this.UnkownMoralHPlabel = new System.Windows.Forms.Label();
            this.researchDifficulty = new System.Windows.Forms.NumericUpDown();
            this.resDiffLabel = new System.Windows.Forms.Label();
            this.researchOrder = new System.Windows.Forms.NumericUpDown();
            this.researchLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7_Unknown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.CostsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attackStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refinedMaterialCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardmentDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // openNew
            // 
            this.openNew.Location = new System.Drawing.Point(332, 272);
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
            this.SaveAs.Location = new System.Drawing.Point(237, 272);
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
            this.Cancel.Location = new System.Drawing.Point(123, 272);
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
            this.Ok.Location = new System.Drawing.Point(28, 272);
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
            this.encyText.Location = new System.Drawing.Point(211, 34);
            this.encyText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.encyText.Name = "encyText";
            this.encyText.Size = new System.Drawing.Size(270, 104);
            this.encyText.TabIndex = 67;
            this.encyText.TabStop = false;
            this.encyText.Text = "Not Implemented yet....Encylopedia Data...Will add .Someday";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(234, 247);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(78, 15);
            this.idLabel.TabIndex = 68;
            this.idLabel.Text = "TextStra.dll ID";
            // 
            // textStraDllId
            // 
            this.textStraDllId.Enabled = false;
            this.textStraDllId.Location = new System.Drawing.Point(330, 243);
            this.textStraDllId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textStraDllId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.textStraDllId.Name = "textStraDllId";
            this.textStraDllId.Size = new System.Drawing.Size(59, 23);
            this.textStraDllId.TabIndex = 74;
            this.textStraDllId.TabStop = false;
            this.textStraDllId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textStraDllId.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // unkown3Label
            // 
            this.unkown3Label.AutoSize = true;
            this.unkown3Label.Location = new System.Drawing.Point(14, 247);
            this.unkown3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unkown3Label.Name = "unkown3Label";
            this.unkown3Label.Size = new System.Drawing.Size(94, 15);
            this.unkown3Label.TabIndex = 71;
            this.unkown3Label.Text = "Field7_Unknown";
            // 
            // field7_Unknown
            // 
            this.field7_Unknown.Enabled = false;
            this.field7_Unknown.Location = new System.Drawing.Point(114, 243);
            this.field7_Unknown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.field7_Unknown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.field7_Unknown.Name = "field7_Unknown";
            this.field7_Unknown.Size = new System.Drawing.Size(59, 23);
            this.field7_Unknown.TabIndex = 72;
            this.field7_Unknown.TabStop = false;
            this.field7_Unknown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.field7_Unknown.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // familyId
            // 
            this.familyId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.familyId.Enabled = false;
            this.familyId.Location = new System.Drawing.Point(576, 241);
            this.familyId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.familyId.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.familyId.Name = "familyId";
            this.familyId.Size = new System.Drawing.Size(59, 23);
            this.familyId.TabIndex = 73;
            this.familyId.TabStop = false;
            this.familyId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.familyLabel.Location = new System.Drawing.Point(512, 245);
            this.familyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyLabel.Name = "familyLabel";
            this.familyLabel.Size = new System.Drawing.Size(56, 15);
            this.familyLabel.TabIndex = 66;
            this.familyLabel.Text = "Family ID";
            // 
            // nextProductionFacility
            // 
            this.nextProductionFacility.BackColor = System.Drawing.SystemColors.Window;
            this.nextProductionFacility.Location = new System.Drawing.Point(637, 91);
            this.nextProductionFacility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextProductionFacility.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nextProductionFacility.Name = "nextProductionFacility";
            this.nextProductionFacility.Size = new System.Drawing.Size(59, 23);
            this.nextProductionFacility.TabIndex = 58;
            this.nextProductionFacility.TabStop = false;
            this.nextProductionFacility.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.secProdFacNumlabel.Location = new System.Drawing.Point(511, 96);
            this.secProdFacNumlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secProdFacNumlabel.Name = "secProdFacNumlabel";
            this.secProdFacNumlabel.Size = new System.Drawing.Size(123, 15);
            this.secProdFacNumlabel.TabIndex = 59;
            this.secProdFacNumlabel.Text = "Production Facility +1";
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.Enabled = false;
            this.prodLabel.Location = new System.Drawing.Point(511, 70);
            this.prodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(106, 15);
            this.prodLabel.TabIndex = 57;
            this.prodLabel.Text = "Production Facility";
            // 
            // productionFacility
            // 
            this.productionFacility.BackColor = System.Drawing.SystemColors.Window;
            this.productionFacility.Location = new System.Drawing.Point(637, 66);
            this.productionFacility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productionFacility.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.productionFacility.Name = "productionFacility";
            this.productionFacility.Size = new System.Drawing.Size(59, 23);
            this.productionFacility.TabIndex = 55;
            this.productionFacility.TabStop = false;
            this.productionFacility.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.productionFacility.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.productionFacility.ValueChanged += new System.EventHandler(this.productionFacility_ValueChanged);
            // 
            // isEmpireUnit
            // 
            this.isEmpireUnit.AutoSize = true;
            this.isEmpireUnit.Location = new System.Drawing.Point(402, 35);
            this.isEmpireUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isEmpireUnit.Name = "isEmpireUnit";
            this.isEmpireUnit.Size = new System.Drawing.Size(63, 19);
            this.isEmpireUnit.TabIndex = 78;
            this.isEmpireUnit.Text = "Empire";
            this.isEmpireUnit.UseVisualStyleBackColor = true;
            this.isEmpireUnit.CheckStateChanged += new System.EventHandler(this.isEmpireUnit_CheckStateChanged);
            // 
            // isAllianceUnit
            // 
            this.isAllianceUnit.AutoSize = true;
            this.isAllianceUnit.Location = new System.Drawing.Point(402, 17);
            this.isAllianceUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isAllianceUnit.Name = "isAllianceUnit";
            this.isAllianceUnit.Size = new System.Drawing.Size(68, 19);
            this.isAllianceUnit.TabIndex = 77;
            this.isAllianceUnit.Text = "Alliance";
            this.isAllianceUnit.UseVisualStyleBackColor = true;
            this.isAllianceUnit.CheckStateChanged += new System.EventHandler(this.isAllianceUnit_CheckStateChanged);
            // 
            // selector
            // 
            this.selector.LargeChange = 3;
            this.selector.Location = new System.Drawing.Point(162, 57);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 5;
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(211, 45);
            this.selector.TabIndex = 75;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            // 
            // familyIdHexLabel
            // 
            this.familyIdHexLabel.AutoSize = true;
            this.familyIdHexLabel.Enabled = false;
            this.familyIdHexLabel.Location = new System.Drawing.Point(637, 245);
            this.familyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdHexLabel.Name = "familyIdHexLabel";
            this.familyIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.familyIdHexLabel.TabIndex = 1123;
            this.familyIdHexLabel.Text = "hex";
            // 
            // idHexLabel
            // 
            this.idHexLabel.AutoSize = true;
            this.idHexLabel.Enabled = false;
            this.idHexLabel.Location = new System.Drawing.Point(252, 32);
            this.idHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idHexLabel.Name = "idHexLabel";
            this.idHexLabel.Size = new System.Drawing.Size(26, 15);
            this.idHexLabel.TabIndex = 1122;
            this.idHexLabel.Text = "hex";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.ControlLight;
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(191, 30);
            this.id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.id.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(59, 23);
            this.id.TabIndex = 1121;
            this.id.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 1120;
            this.label1.Text = "Id";
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(6, 6);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(147, 74);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 76;
            this.picture.TabStop = false;
            // 
            // CostsGroup
            // 
            this.CostsGroup.Controls.Add(this.label9);
            this.CostsGroup.Controls.Add(this.FirePowerlabel);
            this.CostsGroup.Controls.Add(this.attackStrength);
            this.CostsGroup.Controls.Add(this.conCostLabel);
            this.CostsGroup.Controls.Add(this.refinedMaterialCost);
            this.CostsGroup.Controls.Add(this.maintCostLabel);
            this.CostsGroup.Controls.Add(this.encyText);
            this.CostsGroup.Controls.Add(this.ShieldLabel);
            this.CostsGroup.Controls.Add(this.maintenanceCost);
            this.CostsGroup.Controls.Add(this.shieldStrength);
            this.CostsGroup.Controls.Add(this.bombardmentDefense);
            this.CostsGroup.Controls.Add(this.UnkownMoralHPlabel);
            this.CostsGroup.Location = new System.Drawing.Point(6, 93);
            this.CostsGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CostsGroup.Name = "CostsGroup";
            this.CostsGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CostsGroup.Size = new System.Drawing.Size(484, 144);
            this.CostsGroup.TabIndex = 0;
            this.CostsGroup.TabStop = false;
            this.CostsGroup.Text = "In Game Data";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(397, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 1125;
            this.label9.Text = "Description";
            // 
            // FirePowerlabel
            // 
            this.FirePowerlabel.AutoSize = true;
            this.FirePowerlabel.Location = new System.Drawing.Point(7, 117);
            this.FirePowerlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirePowerlabel.Name = "FirePowerlabel";
            this.FirePowerlabel.Size = new System.Drawing.Size(89, 15);
            this.FirePowerlabel.TabIndex = 62;
            this.FirePowerlabel.Text = "Attack Strength";
            // 
            // attackStrength
            // 
            this.attackStrength.Location = new System.Drawing.Point(142, 115);
            this.attackStrength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.attackStrength.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.attackStrength.Name = "attackStrength";
            this.attackStrength.Size = new System.Drawing.Size(61, 23);
            this.attackStrength.TabIndex = 82;
            this.attackStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attackStrength.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.attackStrength.ValueChanged += new System.EventHandler(this.firePowerRating_ValueChanged);
            // 
            // conCostLabel
            // 
            this.conCostLabel.AutoSize = true;
            this.conCostLabel.Location = new System.Drawing.Point(8, 19);
            this.conCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conCostLabel.Name = "conCostLabel";
            this.conCostLabel.Size = new System.Drawing.Size(120, 15);
            this.conCostLabel.TabIndex = 69;
            this.conCostLabel.Text = "Refined Material Cost";
            // 
            // refinedMaterialCost
            // 
            this.refinedMaterialCost.Location = new System.Drawing.Point(142, 15);
            this.refinedMaterialCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.refinedMaterialCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.refinedMaterialCost.Name = "refinedMaterialCost";
            this.refinedMaterialCost.Size = new System.Drawing.Size(61, 23);
            this.refinedMaterialCost.TabIndex = 79;
            this.refinedMaterialCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.refinedMaterialCost.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.refinedMaterialCost.ValueChanged += new System.EventHandler(this.constructionCost_ValueChanged);
            // 
            // maintCostLabel
            // 
            this.maintCostLabel.AutoSize = true;
            this.maintCostLabel.Location = new System.Drawing.Point(7, 44);
            this.maintCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maintCostLabel.Name = "maintCostLabel";
            this.maintCostLabel.Size = new System.Drawing.Size(103, 15);
            this.maintCostLabel.TabIndex = 70;
            this.maintCostLabel.Text = "Maintenance Cost";
            // 
            // ShieldLabel
            // 
            this.ShieldLabel.AutoSize = true;
            this.ShieldLabel.Location = new System.Drawing.Point(8, 92);
            this.ShieldLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShieldLabel.Name = "ShieldLabel";
            this.ShieldLabel.Size = new System.Drawing.Size(87, 15);
            this.ShieldLabel.TabIndex = 61;
            this.ShieldLabel.Text = "Shield Strength";
            // 
            // maintenanceCost
            // 
            this.maintenanceCost.Location = new System.Drawing.Point(142, 40);
            this.maintenanceCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maintenanceCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maintenanceCost.Name = "maintenanceCost";
            this.maintenanceCost.Size = new System.Drawing.Size(61, 23);
            this.maintenanceCost.TabIndex = 80;
            this.maintenanceCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maintenanceCost.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maintenanceCost.ValueChanged += new System.EventHandler(this.maintenanceCost_ValueChanged);
            // 
            // shieldStrength
            // 
            this.shieldStrength.Location = new System.Drawing.Point(142, 90);
            this.shieldStrength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shieldStrength.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.shieldStrength.Name = "shieldStrength";
            this.shieldStrength.Size = new System.Drawing.Size(61, 23);
            this.shieldStrength.TabIndex = 83;
            this.shieldStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shieldStrength.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.shieldStrength.ValueChanged += new System.EventHandler(this.shieldRating_ValueChanged);
            // 
            // bombardmentDefense
            // 
            this.bombardmentDefense.Location = new System.Drawing.Point(142, 65);
            this.bombardmentDefense.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bombardmentDefense.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bombardmentDefense.Name = "bombardmentDefense";
            this.bombardmentDefense.Size = new System.Drawing.Size(61, 23);
            this.bombardmentDefense.TabIndex = 87;
            this.bombardmentDefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bombardmentDefense.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bombardmentDefense.ValueChanged += new System.EventHandler(this.unknownMoralHp_ValueChanged);
            // 
            // UnkownMoralHPlabel
            // 
            this.UnkownMoralHPlabel.AutoSize = true;
            this.UnkownMoralHPlabel.Location = new System.Drawing.Point(8, 69);
            this.UnkownMoralHPlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnkownMoralHPlabel.Name = "UnkownMoralHPlabel";
            this.UnkownMoralHPlabel.Size = new System.Drawing.Size(129, 15);
            this.UnkownMoralHPlabel.TabIndex = 56;
            this.UnkownMoralHPlabel.Text = "Bombardment Defense";
            // 
            // researchDifficulty
            // 
            this.researchDifficulty.Location = new System.Drawing.Point(637, 41);
            this.researchDifficulty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchDifficulty.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchDifficulty.Name = "researchDifficulty";
            this.researchDifficulty.Size = new System.Drawing.Size(59, 23);
            this.researchDifficulty.TabIndex = 86;
            this.researchDifficulty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.resDiffLabel.Location = new System.Drawing.Point(512, 43);
            this.resDiffLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resDiffLabel.Name = "resDiffLabel";
            this.resDiffLabel.Size = new System.Drawing.Size(105, 15);
            this.resDiffLabel.TabIndex = 64;
            this.resDiffLabel.Text = "Research Difficulty";
            // 
            // researchOrder
            // 
            this.researchOrder.Location = new System.Drawing.Point(637, 16);
            this.researchOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchOrder.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchOrder.Name = "researchOrder";
            this.researchOrder.Size = new System.Drawing.Size(59, 23);
            this.researchOrder.TabIndex = 81;
            this.researchOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.researchOrder.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchOrder.ValueChanged += new System.EventHandler(this.researchOrder_ValueChanged);
            // 
            // researchLabel
            // 
            this.researchLabel.AutoSize = true;
            this.researchLabel.Location = new System.Drawing.Point(512, 18);
            this.researchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.researchLabel.Name = "researchLabel";
            this.researchLabel.Size = new System.Drawing.Size(87, 15);
            this.researchLabel.TabIndex = 60;
            this.researchLabel.Text = "Research Order";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(162, 8);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 15);
            this.name.TabIndex = 1124;
            this.name.Text = "NAME";
            // 
            // DefenseFacilitiesForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(706, 306);
            this.Controls.Add(this.researchLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.researchOrder);
            this.Controls.Add(this.resDiffLabel);
            this.Controls.Add(this.researchDifficulty);
            this.Controls.Add(this.CostsGroup);
            this.Controls.Add(this.familyIdHexLabel);
            this.Controls.Add(this.prodLabel);
            this.Controls.Add(this.openNew);
            this.Controls.Add(this.idHexLabel);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.productionFacility);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.secProdFacNumlabel);
            this.Controls.Add(this.nextProductionFacility);
            this.Controls.Add(this.isEmpireUnit);
            this.Controls.Add(this.familyLabel);
            this.Controls.Add(this.isAllianceUnit);
            this.Controls.Add(this.familyId);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.field7_Unknown);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.textStraDllId);
            this.Controls.Add(this.unkown3Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "DefenseFacilitiesForm";
            this.Text = "Defense Facilities (DEFFACSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.Enter += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7_Unknown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.CostsGroup.ResumeLayout(false);
            this.CostsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attackStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refinedMaterialCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardmentDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox CostsGroup;
        private Label conCostLabel;
        private NumericUpDown refinedMaterialCost;
        private Label maintCostLabel;
        private NumericUpDown maintenanceCost;
        private Label researchLabel;
        private NumericUpDown researchOrder;
        private Label resDiffLabel;
        private NumericUpDown researchDifficulty;
        private Label FirePowerlabel;
        private NumericUpDown attackStrength;
        private Label ShieldLabel;
        private NumericUpDown shieldStrength;
        private Label UnkownMoralHPlabel;
        private NumericUpDown bombardmentDefense;
        private Label name;
        private Label label9;
    }
}