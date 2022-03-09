using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class TroopsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label conCostLabel;
        private NumericUpDown conCostNum;
        private PictureBox troopPicture;
        private Label maintCostLabel;
        private NumericUpDown maintCostNum;
        private NumericUpDown researchNum;
        private Label researchLabel;
        private Label BombardLabel;
        private NumericUpDown bombardNum;
        private NumericUpDown defNum;
        private Label defenseLabel;
        private NumericUpDown attackNum;
        private Label attacklabel;
        private Label DetectionLabel;
        private NumericUpDown detectNum;
        private TrackBar ItemSelect;
        private CheckBox rebelUnit;
        private CheckBox empireUnit;
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
        private Label troopName;
        private RichTextBox encyText;
        private Button Ok;
        private Button Cancel;
        private Button SaveAs;
        private SaveFileDialog saveFileDialog;
        private Button openNew;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox costGroup;
        private TabPage tabPage2;
        private GroupBox researchBox;
        private GroupBox troopStatsBox;
        private GroupBox miscDATGroup;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TroopsForm));
            this.conCostLabel = new System.Windows.Forms.Label();
            this.conCostNum = new System.Windows.Forms.NumericUpDown();
            this.maintCostLabel = new System.Windows.Forms.Label();
            this.maintCostNum = new System.Windows.Forms.NumericUpDown();
            this.researchNum = new System.Windows.Forms.NumericUpDown();
            this.researchLabel = new System.Windows.Forms.Label();
            this.BombardLabel = new System.Windows.Forms.Label();
            this.bombardNum = new System.Windows.Forms.NumericUpDown();
            this.defNum = new System.Windows.Forms.NumericUpDown();
            this.defenseLabel = new System.Windows.Forms.Label();
            this.attackNum = new System.Windows.Forms.NumericUpDown();
            this.attacklabel = new System.Windows.Forms.Label();
            this.DetectionLabel = new System.Windows.Forms.Label();
            this.detectNum = new System.Windows.Forms.NumericUpDown();
            this.ItemSelect = new System.Windows.Forms.TrackBar();
            this.rebelUnit = new System.Windows.Forms.CheckBox();
            this.empireUnit = new System.Windows.Forms.CheckBox();
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
            this.troopName = new System.Windows.Forms.Label();
            this.encyText = new System.Windows.Forms.RichTextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openNew = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.miscDATGroup = new System.Windows.Forms.GroupBox();
            this.famHexLabel = new System.Windows.Forms.Label();
            this.unitHexLabel = new System.Windows.Forms.Label();
            this.unitNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.troopStatsBox = new System.Windows.Forms.GroupBox();
            this.researchBox = new System.Windows.Forms.GroupBox();
            this.costGroup = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.troopPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.conCostNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintCostNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown3Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyIdNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secProdFacNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodFacNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknownMoralHpNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resDiffNum)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.miscDATGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitNum)).BeginInit();
            this.troopStatsBox.SuspendLayout();
            this.researchBox.SuspendLayout();
            this.costGroup.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.troopPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // conCostLabel
            // 
            this.conCostLabel.AutoSize = true;
            this.conCostLabel.Location = new System.Drawing.Point(7, 18);
            this.conCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conCostLabel.Name = "conCostLabel";
            this.conCostLabel.Size = new System.Drawing.Size(103, 15);
            this.conCostLabel.TabIndex = 0;
            this.conCostLabel.Text = "Construction Cost";
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
            this.conCostNum.Size = new System.Drawing.Size(59, 23);
            this.conCostNum.TabIndex = 4;
            this.conCostNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.conCostNum.ValueChanged += new System.EventHandler(this.updateConCost);
            // 
            // maintCostLabel
            // 
            this.maintCostLabel.AutoSize = true;
            this.maintCostLabel.Location = new System.Drawing.Point(7, 46);
            this.maintCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maintCostLabel.Name = "maintCostLabel";
            this.maintCostLabel.Size = new System.Drawing.Size(103, 15);
            this.maintCostLabel.TabIndex = 0;
            this.maintCostLabel.Text = "Maintenance Cost";
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
            this.maintCostNum.Size = new System.Drawing.Size(59, 23);
            this.maintCostNum.TabIndex = 5;
            this.maintCostNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maintCostNum.ValueChanged += new System.EventHandler(this.updateMaintCost);
            // 
            // researchNum
            // 
            this.researchNum.Location = new System.Drawing.Point(119, 16);
            this.researchNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.researchNum.Name = "researchNum";
            this.researchNum.Size = new System.Drawing.Size(59, 23);
            this.researchNum.TabIndex = 6;
            this.researchNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.researchNum.ValueChanged += new System.EventHandler(this.updateResearchNum);
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
            // BombardLabel
            // 
            this.BombardLabel.AutoSize = true;
            this.BombardLabel.Location = new System.Drawing.Point(7, 81);
            this.BombardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BombardLabel.Name = "BombardLabel";
            this.BombardLabel.Size = new System.Drawing.Size(96, 15);
            this.BombardLabel.TabIndex = 0;
            this.BombardLabel.Text = "Bombard. Rating";
            // 
            // bombardNum
            // 
            this.bombardNum.Location = new System.Drawing.Point(119, 78);
            this.bombardNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bombardNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bombardNum.Name = "bombardNum";
            this.bombardNum.Size = new System.Drawing.Size(59, 23);
            this.bombardNum.TabIndex = 9;
            this.bombardNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bombardNum.ValueChanged += new System.EventHandler(this.updateBombardNum);
            // 
            // defNum
            // 
            this.defNum.Location = new System.Drawing.Point(119, 48);
            this.defNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.defNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.defNum.Name = "defNum";
            this.defNum.Size = new System.Drawing.Size(59, 23);
            this.defNum.TabIndex = 8;
            this.defNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.defNum.ValueChanged += new System.EventHandler(this.updateDefNum);
            // 
            // defenseLabel
            // 
            this.defenseLabel.AutoSize = true;
            this.defenseLabel.Location = new System.Drawing.Point(7, 48);
            this.defenseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.defenseLabel.Name = "defenseLabel";
            this.defenseLabel.Size = new System.Drawing.Size(86, 15);
            this.defenseLabel.TabIndex = 0;
            this.defenseLabel.Text = "Defense Rating";
            // 
            // attackNum
            // 
            this.attackNum.Location = new System.Drawing.Point(119, 18);
            this.attackNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.attackNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.attackNum.Name = "attackNum";
            this.attackNum.Size = new System.Drawing.Size(59, 23);
            this.attackNum.TabIndex = 7;
            this.attackNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.attackNum.ValueChanged += new System.EventHandler(this.updateAttackNum);
            // 
            // attacklabel
            // 
            this.attacklabel.AutoSize = true;
            this.attacklabel.Location = new System.Drawing.Point(7, 18);
            this.attacklabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.attacklabel.Name = "attacklabel";
            this.attacklabel.Size = new System.Drawing.Size(78, 15);
            this.attacklabel.TabIndex = 0;
            this.attacklabel.Text = "Attack Rating";
            // 
            // DetectionLabel
            // 
            this.DetectionLabel.AutoSize = true;
            this.DetectionLabel.Location = new System.Drawing.Point(7, 111);
            this.DetectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DetectionLabel.Name = "DetectionLabel";
            this.DetectionLabel.Size = new System.Drawing.Size(95, 15);
            this.DetectionLabel.TabIndex = 0;
            this.DetectionLabel.Text = "Detection Rating";
            // 
            // detectNum
            // 
            this.detectNum.Location = new System.Drawing.Point(119, 108);
            this.detectNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.detectNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.detectNum.Name = "detectNum";
            this.detectNum.Size = new System.Drawing.Size(59, 23);
            this.detectNum.TabIndex = 10;
            this.detectNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.detectNum.ValueChanged += new System.EventHandler(this.updateDetectNum);
            // 
            // ItemSelect
            // 
            this.ItemSelect.Location = new System.Drawing.Point(236, 20);
            this.ItemSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ItemSelect.Maximum = 9;
            this.ItemSelect.Name = "ItemSelect";
            this.ItemSelect.Size = new System.Drawing.Size(121, 45);
            this.ItemSelect.TabIndex = 1;
            this.ItemSelect.ValueChanged += new System.EventHandler(this.TroopFormUpdateUI);
            // 
            // rebelUnit
            // 
            this.rebelUnit.AutoSize = true;
            this.rebelUnit.Location = new System.Drawing.Point(26, 97);
            this.rebelUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rebelUnit.Name = "rebelUnit";
            this.rebelUnit.Size = new System.Drawing.Size(93, 19);
            this.rebelUnit.TabIndex = 2;
            this.rebelUnit.Text = "Alliance Unit";
            this.rebelUnit.UseVisualStyleBackColor = true;
            this.rebelUnit.CheckStateChanged += new System.EventHandler(this.updateRebelUnitCheck);
            // 
            // empireUnit
            // 
            this.empireUnit.AutoSize = true;
            this.empireUnit.Location = new System.Drawing.Point(132, 97);
            this.empireUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empireUnit.Name = "empireUnit";
            this.empireUnit.Size = new System.Drawing.Size(94, 19);
            this.empireUnit.TabIndex = 3;
            this.empireUnit.Text = "Imperial Unit";
            this.empireUnit.UseVisualStyleBackColor = true;
            this.empireUnit.CheckStateChanged += new System.EventHandler(this.updateEmpireUnitCheck);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Enabled = false;
            this.idLabel.Location = new System.Drawing.Point(7, 165);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(85, 15);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "TextStra.DLL ID";
            // 
            // idNum
            // 
            this.idNum.Enabled = false;
            this.idNum.Location = new System.Drawing.Point(118, 163);
            this.idNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.idNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.idNum.Name = "idNum";
            this.idNum.Size = new System.Drawing.Size(59, 23);
            this.idNum.TabIndex = 0;
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
            this.unkown3Label.Location = new System.Drawing.Point(7, 135);
            this.unkown3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unkown3Label.Name = "unkown3Label";
            this.unkown3Label.Size = new System.Drawing.Size(58, 15);
            this.unkown3Label.TabIndex = 0;
            this.unkown3Label.Text = "Unknown";
            // 
            // unknown3Num
            // 
            this.unknown3Num.Enabled = false;
            this.unknown3Num.Location = new System.Drawing.Point(118, 133);
            this.unknown3Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknown3Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknown3Num.Name = "unknown3Num";
            this.unknown3Num.Size = new System.Drawing.Size(59, 23);
            this.unknown3Num.TabIndex = 0;
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
            this.familyIdNum.Location = new System.Drawing.Point(118, 103);
            this.familyIdNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.familyIdNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.familyIdNum.Name = "familyIdNum";
            this.familyIdNum.Size = new System.Drawing.Size(59, 23);
            this.familyIdNum.TabIndex = 0;
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
            this.familyLabel.Location = new System.Drawing.Point(7, 105);
            this.familyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyLabel.Name = "familyLabel";
            this.familyLabel.Size = new System.Drawing.Size(56, 15);
            this.familyLabel.TabIndex = 0;
            this.familyLabel.Text = "Family ID";
            // 
            // secProdFacNum
            // 
            this.secProdFacNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.secProdFacNum.Enabled = false;
            this.secProdFacNum.Location = new System.Drawing.Point(118, 73);
            this.secProdFacNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secProdFacNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.secProdFacNum.Name = "secProdFacNum";
            this.secProdFacNum.Size = new System.Drawing.Size(59, 23);
            this.secProdFacNum.TabIndex = 0;
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
            this.secProdFacNumlabel.Location = new System.Drawing.Point(7, 75);
            this.secProdFacNumlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secProdFacNumlabel.Name = "secProdFacNumlabel";
            this.secProdFacNumlabel.Size = new System.Drawing.Size(92, 15);
            this.secProdFacNumlabel.TabIndex = 0;
            this.secProdFacNumlabel.Text = "Prod Facility + 1";
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.Enabled = false;
            this.prodLabel.Location = new System.Drawing.Point(7, 45);
            this.prodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(106, 15);
            this.prodLabel.TabIndex = 0;
            this.prodLabel.Text = "Production Facility";
            // 
            // prodFacNum
            // 
            this.prodFacNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.prodFacNum.Enabled = false;
            this.prodFacNum.Location = new System.Drawing.Point(118, 43);
            this.prodFacNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prodFacNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.prodFacNum.Name = "prodFacNum";
            this.prodFacNum.Size = new System.Drawing.Size(59, 23);
            this.prodFacNum.TabIndex = 0;
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
            this.unknownMoralHpNum.Location = new System.Drawing.Point(118, 13);
            this.unknownMoralHpNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknownMoralHpNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknownMoralHpNum.Name = "unknownMoralHpNum";
            this.unknownMoralHpNum.Size = new System.Drawing.Size(59, 23);
            this.unknownMoralHpNum.TabIndex = 12;
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
            this.UnkownMoralHPlabel.Location = new System.Drawing.Point(6, 15);
            this.UnkownMoralHPlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnkownMoralHPlabel.Name = "UnkownMoralHPlabel";
            this.UnkownMoralHPlabel.Size = new System.Drawing.Size(95, 15);
            this.UnkownMoralHPlabel.TabIndex = 0;
            this.UnkownMoralHPlabel.Text = "Unknown - ?HP?";
            // 
            // resDiffNum
            // 
            this.resDiffNum.Location = new System.Drawing.Point(119, 43);
            this.resDiffNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resDiffNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.resDiffNum.Name = "resDiffNum";
            this.resDiffNum.Size = new System.Drawing.Size(59, 23);
            this.resDiffNum.TabIndex = 11;
            this.resDiffNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.resDiffNum.ValueChanged += new System.EventHandler(this.updateResDiffNum);
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
            // troopName
            // 
            this.troopName.AutoSize = true;
            this.troopName.Location = new System.Drawing.Point(232, 75);
            this.troopName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.troopName.Name = "troopName";
            this.troopName.Size = new System.Drawing.Size(0, 15);
            this.troopName.TabIndex = 13;
            // 
            // encyText
            // 
            this.encyText.Enabled = false;
            this.encyText.Location = new System.Drawing.Point(0, 0);
            this.encyText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.encyText.Name = "encyText";
            this.encyText.Size = new System.Drawing.Size(400, 118);
            this.encyText.TabIndex = 0;
            this.encyText.TabStop = false;
            this.encyText.Text = "Not Implemented yet....Encylopedia Data...Will add .Someday";
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(22, 487);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 13;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(117, 487);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 27);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Location = new System.Drawing.Point(231, 487);
            this.SaveAs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(88, 27);
            this.SaveAs.TabIndex = 15;
            this.SaveAs.Text = "&SaveAs...";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "DAT";
            this.saveFileDialog.Filter = "Data files|*.dat";
            // 
            // openNew
            // 
            this.openNew.Location = new System.Drawing.Point(326, 487);
            this.openNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openNew.Name = "openNew";
            this.openNew.Size = new System.Drawing.Size(88, 27);
            this.openNew.TabIndex = 16;
            this.openNew.Text = "Open...";
            this.openNew.UseVisualStyleBackColor = true;
            this.openNew.Click += new System.EventHandler(this.openNew_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 123);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(421, 358);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.miscDATGroup);
            this.tabPage1.Controls.Add(this.troopStatsBox);
            this.tabPage1.Controls.Add(this.researchBox);
            this.tabPage1.Controls.Add(this.costGroup);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(413, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Troop Data";
            // 
            // miscDATGroup
            // 
            this.miscDATGroup.Controls.Add(this.famHexLabel);
            this.miscDATGroup.Controls.Add(this.UnkownMoralHPlabel);
            this.miscDATGroup.Controls.Add(this.unitHexLabel);
            this.miscDATGroup.Controls.Add(this.unknownMoralHpNum);
            this.miscDATGroup.Controls.Add(this.unitNum);
            this.miscDATGroup.Controls.Add(this.label1);
            this.miscDATGroup.Controls.Add(this.prodFacNum);
            this.miscDATGroup.Controls.Add(this.prodLabel);
            this.miscDATGroup.Controls.Add(this.secProdFacNumlabel);
            this.miscDATGroup.Controls.Add(this.secProdFacNum);
            this.miscDATGroup.Controls.Add(this.familyLabel);
            this.miscDATGroup.Controls.Add(this.idLabel);
            this.miscDATGroup.Controls.Add(this.familyIdNum);
            this.miscDATGroup.Controls.Add(this.idNum);
            this.miscDATGroup.Controls.Add(this.unknown3Num);
            this.miscDATGroup.Controls.Add(this.unkown3Label);
            this.miscDATGroup.Location = new System.Drawing.Point(192, 7);
            this.miscDATGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.miscDATGroup.Name = "miscDATGroup";
            this.miscDATGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.miscDATGroup.Size = new System.Drawing.Size(212, 314);
            this.miscDATGroup.TabIndex = 7;
            this.miscDATGroup.TabStop = false;
            this.miscDATGroup.Text = "DAT Misc Data";
            // 
            // famHexLabel
            // 
            this.famHexLabel.AutoSize = true;
            this.famHexLabel.Enabled = false;
            this.famHexLabel.Location = new System.Drawing.Point(178, 107);
            this.famHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.famHexLabel.Name = "famHexLabel";
            this.famHexLabel.Size = new System.Drawing.Size(26, 15);
            this.famHexLabel.TabIndex = 1119;
            this.famHexLabel.Text = "hex";
            // 
            // unitHexLabel
            // 
            this.unitHexLabel.AutoSize = true;
            this.unitHexLabel.Enabled = false;
            this.unitHexLabel.Location = new System.Drawing.Point(178, 195);
            this.unitHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitHexLabel.Name = "unitHexLabel";
            this.unitHexLabel.Size = new System.Drawing.Size(26, 15);
            this.unitHexLabel.TabIndex = 1118;
            this.unitHexLabel.Text = "hex";
            // 
            // unitNum
            // 
            this.unitNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.unitNum.Enabled = false;
            this.unitNum.Location = new System.Drawing.Point(118, 193);
            this.unitNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unitNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.unitNum.Name = "unitNum";
            this.unitNum.Size = new System.Drawing.Size(59, 23);
            this.unitNum.TabIndex = 1117;
            this.unitNum.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(6, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1116;
            this.label1.Text = "Troop ID";
            // 
            // troopStatsBox
            // 
            this.troopStatsBox.Controls.Add(this.attacklabel);
            this.troopStatsBox.Controls.Add(this.attackNum);
            this.troopStatsBox.Controls.Add(this.defenseLabel);
            this.troopStatsBox.Controls.Add(this.defNum);
            this.troopStatsBox.Controls.Add(this.bombardNum);
            this.troopStatsBox.Controls.Add(this.BombardLabel);
            this.troopStatsBox.Controls.Add(this.detectNum);
            this.troopStatsBox.Controls.Add(this.DetectionLabel);
            this.troopStatsBox.Location = new System.Drawing.Point(4, 181);
            this.troopStatsBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopStatsBox.Name = "troopStatsBox";
            this.troopStatsBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopStatsBox.Size = new System.Drawing.Size(182, 144);
            this.troopStatsBox.TabIndex = 6;
            this.troopStatsBox.TabStop = false;
            this.troopStatsBox.Text = "Troop Stats";
            // 
            // researchBox
            // 
            this.researchBox.Controls.Add(this.researchLabel);
            this.researchBox.Controls.Add(this.researchNum);
            this.researchBox.Controls.Add(this.resDiffLabel);
            this.researchBox.Controls.Add(this.resDiffNum);
            this.researchBox.Location = new System.Drawing.Point(4, 96);
            this.researchBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchBox.Name = "researchBox";
            this.researchBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchBox.Size = new System.Drawing.Size(182, 78);
            this.researchBox.TabIndex = 5;
            this.researchBox.TabStop = false;
            this.researchBox.Text = "Research";
            // 
            // costGroup
            // 
            this.costGroup.Controls.Add(this.conCostLabel);
            this.costGroup.Controls.Add(this.conCostNum);
            this.costGroup.Controls.Add(this.maintCostLabel);
            this.costGroup.Controls.Add(this.maintCostNum);
            this.costGroup.Location = new System.Drawing.Point(4, 3);
            this.costGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.costGroup.Name = "costGroup";
            this.costGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.costGroup.Size = new System.Drawing.Size(182, 85);
            this.costGroup.TabIndex = 4;
            this.costGroup.TabStop = false;
            this.costGroup.Text = "Costs";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.encyText);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(413, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ency Data";
            // 
            // troopPicture
            // 
            this.troopPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.troopPicture.InitialImage = null;
            this.troopPicture.Location = new System.Drawing.Point(26, 14);
            this.troopPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopPicture.Name = "troopPicture";
            this.troopPicture.Size = new System.Drawing.Size(147, 74);
            this.troopPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.troopPicture.TabIndex = 2;
            this.troopPicture.TabStop = false;
            // 
            // TroopsForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(425, 520);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.openNew);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.troopName);
            this.Controls.Add(this.empireUnit);
            this.Controls.Add(this.rebelUnit);
            this.Controls.Add(this.ItemSelect);
            this.Controls.Add(this.troopPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(441, 559);
            this.MinimumSize = new System.Drawing.Size(441, 559);
            this.Name = "TroopsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Troops (TROOPSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TroopForm_FormClosing);
            this.Load += new System.EventHandler(this.TroopForm_Load);
            this.Enter += new System.EventHandler(this.TroopFormUpdateUI);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TroopForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.conCostNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintCostNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown3Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyIdNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secProdFacNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodFacNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknownMoralHpNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resDiffNum)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.miscDATGroup.ResumeLayout(false);
            this.miscDATGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitNum)).EndInit();
            this.troopStatsBox.ResumeLayout(false);
            this.troopStatsBox.PerformLayout();
            this.researchBox.ResumeLayout(false);
            this.researchBox.PerformLayout();
            this.costGroup.ResumeLayout(false);
            this.costGroup.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.troopPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}