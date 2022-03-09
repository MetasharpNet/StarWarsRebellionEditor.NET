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
        private Button openNew;
        private Button SaveAs;
        private Button Cancel;
        private Button Ok;
        private RichTextBox encyText;
        private Label ItemName;
        private Label idLabel;
        private NumericUpDown idNum;
        private Label unkown3Label;
        private NumericUpDown unknown3Num;
        private NumericUpDown familyIdNum;
        private Label familyLabel;
        private NumericUpDown secProdFacNum;
        private Label secProdFacNumlabel;
        private Label prodLabel;
        private NumericUpDown prodFacNum;
        private NumericUpDown unknownMoralHpNum;
        private Label UnkownMoralHPlabel;
        private NumericUpDown resDiffNum;
        private Label resDiffLabel;
        private CheckBox empireUnit;
        private CheckBox rebelUnit;
        private TrackBar ItemSelect;
        private Label DetectionLabel;
        private NumericUpDown RateNum;
        private Label researchLabel;
        private NumericUpDown researchNum;
        private PictureBox ItemPicture;
        private GroupBox groupBox2;
        private NumericUpDown maintCostNum;
        private Label conCostLabel;
        private Label maintCostLabel;
        private NumericUpDown conCostNum;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label famHexLabel;
        private Label unitHexLabel;
        private NumericUpDown unitNum;
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
            this.openNew = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.encyText = new System.Windows.Forms.RichTextBox();
            this.ItemName = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.idNum = new System.Windows.Forms.NumericUpDown();
            this.unkown3Label = new System.Windows.Forms.Label();
            this.unknown3Num = new System.Windows.Forms.NumericUpDown();
            this.familyIdNum = new System.Windows.Forms.NumericUpDown();
            this.familyLabel = new System.Windows.Forms.Label();
            this.secProdFacNum = new System.Windows.Forms.NumericUpDown();
            this.secProdFacNumlabel = new System.Windows.Forms.Label();
            this.prodLabel = new System.Windows.Forms.Label();
            this.prodFacNum = new System.Windows.Forms.NumericUpDown();
            this.unknownMoralHpNum = new System.Windows.Forms.NumericUpDown();
            this.UnkownMoralHPlabel = new System.Windows.Forms.Label();
            this.resDiffNum = new System.Windows.Forms.NumericUpDown();
            this.resDiffLabel = new System.Windows.Forms.Label();
            this.empireUnit = new System.Windows.Forms.CheckBox();
            this.rebelUnit = new System.Windows.Forms.CheckBox();
            this.ItemSelect = new System.Windows.Forms.TrackBar();
            this.DetectionLabel = new System.Windows.Forms.Label();
            this.RateNum = new System.Windows.Forms.NumericUpDown();
            this.researchLabel = new System.Windows.Forms.Label();
            this.researchNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maintCostNum = new System.Windows.Forms.NumericUpDown();
            this.conCostLabel = new System.Windows.Forms.Label();
            this.maintCostLabel = new System.Windows.Forms.Label();
            this.conCostNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.famHexLabel = new System.Windows.Forms.Label();
            this.unitHexLabel = new System.Windows.Forms.Label();
            this.unitNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ItemPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.idNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown3Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyIdNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secProdFacNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodFacNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknownMoralHpNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resDiffNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maintCostNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conCostNum)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitNum)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // openNew
            // 
            this.openNew.Location = new System.Drawing.Point(327, 487);
            this.openNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openNew.Name = "openNew";
            this.openNew.Size = new System.Drawing.Size(88, 27);
            this.openNew.TabIndex = 0;
            this.openNew.TabStop = false;
            this.openNew.Text = "Open...";
            this.openNew.UseVisualStyleBackColor = true;
            this.openNew.Click += new System.EventHandler(this.openNew_Click);
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
            this.ItemName.AutoSize = true;
            this.ItemName.Location = new System.Drawing.Point(240, 73);
            this.ItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(112, 15);
            this.ItemName.TabIndex = 89;
            this.ItemName.Text = "--item name label--";
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
            this.idNum.Enabled = false;
            this.idNum.Location = new System.Drawing.Point(119, 140);
            this.idNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.idNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.idNum.Name = "idNum";
            this.idNum.Size = new System.Drawing.Size(59, 23);
            this.idNum.TabIndex = 74;
            this.idNum.TabStop = false;
            this.idNum.Value = new decimal(new int[] {
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
            this.unknown3Num.Enabled = false;
            this.unknown3Num.Location = new System.Drawing.Point(119, 110);
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
            this.familyIdNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.familyIdNum.Enabled = false;
            this.familyIdNum.Location = new System.Drawing.Point(119, 80);
            this.familyIdNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.familyIdNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.familyIdNum.Name = "familyIdNum";
            this.familyIdNum.Size = new System.Drawing.Size(59, 23);
            this.familyIdNum.TabIndex = 73;
            this.familyIdNum.TabStop = false;
            this.familyIdNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.familyIdNum.ValueChanged += new System.EventHandler(this.updateFamilyIdNum);
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
            this.secProdFacNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.secProdFacNum.Enabled = false;
            this.secProdFacNum.Location = new System.Drawing.Point(119, 50);
            this.secProdFacNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secProdFacNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.secProdFacNum.Name = "secProdFacNum";
            this.secProdFacNum.Size = new System.Drawing.Size(59, 23);
            this.secProdFacNum.TabIndex = 58;
            this.secProdFacNum.TabStop = false;
            this.secProdFacNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.secProdFacNum.ValueChanged += new System.EventHandler(this.updateSecProdFacNum);
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
            this.prodFacNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.prodFacNum.Enabled = false;
            this.prodFacNum.Location = new System.Drawing.Point(119, 18);
            this.prodFacNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prodFacNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.prodFacNum.Name = "prodFacNum";
            this.prodFacNum.Size = new System.Drawing.Size(59, 23);
            this.prodFacNum.TabIndex = 55;
            this.prodFacNum.TabStop = false;
            this.prodFacNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.prodFacNum.ValueChanged += new System.EventHandler(this.updateProdFacNum);
            // 
            // unknownMoralHpNum
            // 
            this.unknownMoralHpNum.Location = new System.Drawing.Point(119, 51);
            this.unknownMoralHpNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknownMoralHpNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknownMoralHpNum.Name = "unknownMoralHpNum";
            this.unknownMoralHpNum.Size = new System.Drawing.Size(59, 23);
            this.unknownMoralHpNum.TabIndex = 87;
            this.unknownMoralHpNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknownMoralHpNum.ValueChanged += new System.EventHandler(this.updateUnknownMoralHpNum);
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
            this.resDiffNum.Location = new System.Drawing.Point(119, 46);
            this.resDiffNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resDiffNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.resDiffNum.Name = "resDiffNum";
            this.resDiffNum.Size = new System.Drawing.Size(59, 23);
            this.resDiffNum.TabIndex = 86;
            this.resDiffNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.resDiffNum.ValueChanged += new System.EventHandler(this.updateResDiffNum);
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
            this.empireUnit.AutoSize = true;
            this.empireUnit.Location = new System.Drawing.Point(130, 97);
            this.empireUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empireUnit.Name = "empireUnit";
            this.empireUnit.Size = new System.Drawing.Size(94, 19);
            this.empireUnit.TabIndex = 3;
            this.empireUnit.Text = "Imperial Unit";
            this.empireUnit.UseVisualStyleBackColor = true;
            // 
            // rebelUnit
            // 
            this.rebelUnit.AutoSize = true;
            this.rebelUnit.Location = new System.Drawing.Point(23, 97);
            this.rebelUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rebelUnit.Name = "rebelUnit";
            this.rebelUnit.Size = new System.Drawing.Size(93, 19);
            this.rebelUnit.TabIndex = 2;
            this.rebelUnit.Text = "Alliance Unit";
            this.rebelUnit.UseVisualStyleBackColor = true;
            // 
            // ItemSelect
            // 
            this.ItemSelect.LargeChange = 1;
            this.ItemSelect.Location = new System.Drawing.Point(244, 17);
            this.ItemSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ItemSelect.Maximum = 1;
            this.ItemSelect.Name = "ItemSelect";
            this.ItemSelect.Size = new System.Drawing.Size(121, 45);
            this.ItemSelect.TabIndex = 75;
            this.ItemSelect.ValueChanged += new System.EventHandler(this.ProdFacFormUpdateUI);
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
            this.RateNum.Location = new System.Drawing.Point(119, 16);
            this.RateNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RateNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.RateNum.Name = "RateNum";
            this.RateNum.Size = new System.Drawing.Size(58, 23);
            this.RateNum.TabIndex = 85;
            this.RateNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.RateNum.ValueChanged += new System.EventHandler(this.updateRateNum);
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
            this.researchNum.Location = new System.Drawing.Point(119, 16);
            this.researchNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchNum.Name = "researchNum";
            this.researchNum.Size = new System.Drawing.Size(58, 23);
            this.researchNum.TabIndex = 81;
            this.researchNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchNum.ValueChanged += new System.EventHandler(this.updateResearchNum);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maintCostNum);
            this.groupBox2.Controls.Add(this.conCostLabel);
            this.groupBox2.Controls.Add(this.maintCostLabel);
            this.groupBox2.Controls.Add(this.conCostNum);
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
            this.maintCostNum.Location = new System.Drawing.Point(119, 48);
            this.maintCostNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maintCostNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maintCostNum.Name = "maintCostNum";
            this.maintCostNum.Size = new System.Drawing.Size(58, 23);
            this.maintCostNum.TabIndex = 97;
            this.maintCostNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maintCostNum.ValueChanged += new System.EventHandler(this.updateMaintCost);
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
            this.conCostNum.Location = new System.Drawing.Point(119, 18);
            this.conCostNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.conCostNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.conCostNum.Name = "conCostNum";
            this.conCostNum.Size = new System.Drawing.Size(58, 23);
            this.conCostNum.TabIndex = 96;
            this.conCostNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.conCostNum.ValueChanged += new System.EventHandler(this.updateConCost);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.researchLabel);
            this.groupBox3.Controls.Add(this.researchNum);
            this.groupBox3.Controls.Add(this.resDiffLabel);
            this.groupBox3.Controls.Add(this.resDiffNum);
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
            this.groupBox4.Controls.Add(this.RateNum);
            this.groupBox4.Controls.Add(this.UnkownMoralHPlabel);
            this.groupBox4.Controls.Add(this.unknownMoralHpNum);
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
            this.groupBox5.Controls.Add(this.famHexLabel);
            this.groupBox5.Controls.Add(this.prodLabel);
            this.groupBox5.Controls.Add(this.unitHexLabel);
            this.groupBox5.Controls.Add(this.prodFacNum);
            this.groupBox5.Controls.Add(this.unitNum);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.secProdFacNumlabel);
            this.groupBox5.Controls.Add(this.secProdFacNum);
            this.groupBox5.Controls.Add(this.familyLabel);
            this.groupBox5.Controls.Add(this.familyIdNum);
            this.groupBox5.Controls.Add(this.unknown3Num);
            this.groupBox5.Controls.Add(this.idLabel);
            this.groupBox5.Controls.Add(this.unkown3Label);
            this.groupBox5.Controls.Add(this.idNum);
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
            this.famHexLabel.AutoSize = true;
            this.famHexLabel.Enabled = false;
            this.famHexLabel.Location = new System.Drawing.Point(180, 84);
            this.famHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.famHexLabel.Name = "famHexLabel";
            this.famHexLabel.Size = new System.Drawing.Size(26, 15);
            this.famHexLabel.TabIndex = 1135;
            this.famHexLabel.Text = "hex";
            // 
            // unitHexLabel
            // 
            this.unitHexLabel.AutoSize = true;
            this.unitHexLabel.Enabled = false;
            this.unitHexLabel.Location = new System.Drawing.Point(180, 172);
            this.unitHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitHexLabel.Name = "unitHexLabel";
            this.unitHexLabel.Size = new System.Drawing.Size(26, 15);
            this.unitHexLabel.TabIndex = 1134;
            this.unitHexLabel.Text = "hex";
            // 
            // unitNum
            // 
            this.unitNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.unitNum.Enabled = false;
            this.unitNum.Location = new System.Drawing.Point(119, 170);
            this.unitNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unitNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.unitNum.Name = "unitNum";
            this.unitNum.Size = new System.Drawing.Size(59, 23);
            this.unitNum.TabIndex = 1133;
            this.unitNum.TabStop = false;
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
            this.ItemPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemPicture.InitialImage = null;
            this.ItemPicture.Location = new System.Drawing.Point(23, 14);
            this.ItemPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ItemPicture.Name = "ItemPicture";
            this.ItemPicture.Size = new System.Drawing.Size(147, 74);
            this.ItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ItemPicture.TabIndex = 76;
            this.ItemPicture.TabStop = false;
            // 
            // ProductionFacilitiesForm
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
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.empireUnit);
            this.Controls.Add(this.rebelUnit);
            this.Controls.Add(this.ItemSelect);
            this.Controls.Add(this.ItemPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(452, 559);
            this.MinimumSize = new System.Drawing.Size(452, 559);
            this.Name = "ProductionFacilitiesForm";
            this.Text = "Production Facilities (PROFACSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProdFacForm_FormClosing);
            this.Load += new System.EventHandler(this.ProdFacForm_Load);
            this.Enter += new System.EventHandler(this.ProdFacFormUpdateUI);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProdFacForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.idNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown3Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyIdNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secProdFacNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodFacNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknownMoralHpNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resDiffNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maintCostNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conCostNum)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitNum)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}