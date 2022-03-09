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
        private ListView charListView;
        private PictureBox ItemPicture;
        private Button openNew;
        private Button SaveAs;
        private Button Cancel;
        private Button Ok;
        private GroupBox charLoyalGroup;
        private CheckBox rebelUnit;
        private CheckBox empireUnit;
        private Label ItemName;
        private TrackBar ItemSelect;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox researchGroup;
        private Label resVarLabel;
        private Label resBaseLabel;
        private NumericUpDown facResVarNum;
        private NumericUpDown shipResVarNum;
        private NumericUpDown troopResVarNum;
        private Label facResLabel;
        private NumericUpDown facResBaseNum;
        private Label shipResLabel;
        private NumericUpDown shipResBaseNum;
        private NumericUpDown troopResBaseNum;
        private Label troopResLabel;
        private GroupBox BasicGroup;
        private NumericUpDown loyalVarNum;
        private NumericUpDown loyalBaseNum;
        private Label loyaltyLabel;
        private Label statsVarLabel;
        private Label statsBaseLabel;
        private NumericUpDown combatVarNum;
        private NumericUpDown dipVarNum;
        private NumericUpDown espVarNum;
        private Label combatLabel;
        private NumericUpDown combatBaseNum;
        private Label diploLabel;
        private NumericUpDown dipBaseNum;
        private NumericUpDown espBaseNum;
        private Label espLabel;
        private TabPage tabPage2;
        private RichTextBox encyText;
        private ImageList SpecOpImageList;
        private GroupBox costGroup;
        private Label label1;
        private NumericUpDown conCostNum;
        private Label label2;
        private NumericUpDown maintCostNum;
        private Label conCostLabel;
        private NumericUpDown conCostNum2;
        private Label maintCostLabel;
        private NumericUpDown maintCostNum2;
        private GroupBox researchBox;
        private Label researchLabel;
        private NumericUpDown researchNum;
        private Label resDiffLabel;
        private NumericUpDown resDiffNum;
        private GroupBox groupBox1;
        private NumericUpDown unknown3Num;
        private NumericUpDown idNum;
        private NumericUpDown prodFacNum;
        private Label unkown3Label;
        private NumericUpDown familyIdNum;
        private Label prodLabel;
        private Label idLabel;
        private Label familyLabel;
        private Label secProdFacNumlabel;
        private NumericUpDown secProdFacNum;
        private NumericUpDown missionIdNum;
        private Label label3;
        private Label famHexLabel;
        private Label unitHexLabel;
        private NumericUpDown unitNum;
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
            this.charListView = new System.Windows.Forms.ListView();
            this.SpecOpImageList = new System.Windows.Forms.ImageList(this.components);
            this.openNew = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.charLoyalGroup = new System.Windows.Forms.GroupBox();
            this.rebelUnit = new System.Windows.Forms.CheckBox();
            this.empireUnit = new System.Windows.Forms.CheckBox();
            this.ItemName = new System.Windows.Forms.Label();
            this.ItemSelect = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.researchBox = new System.Windows.Forms.GroupBox();
            this.researchLabel = new System.Windows.Forms.Label();
            this.researchNum = new System.Windows.Forms.NumericUpDown();
            this.resDiffLabel = new System.Windows.Forms.Label();
            this.resDiffNum = new System.Windows.Forms.NumericUpDown();
            this.costGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.conCostNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.maintCostNum = new System.Windows.Forms.NumericUpDown();
            this.researchGroup = new System.Windows.Forms.GroupBox();
            this.resVarLabel = new System.Windows.Forms.Label();
            this.resBaseLabel = new System.Windows.Forms.Label();
            this.facResVarNum = new System.Windows.Forms.NumericUpDown();
            this.shipResVarNum = new System.Windows.Forms.NumericUpDown();
            this.troopResVarNum = new System.Windows.Forms.NumericUpDown();
            this.facResLabel = new System.Windows.Forms.Label();
            this.facResBaseNum = new System.Windows.Forms.NumericUpDown();
            this.shipResLabel = new System.Windows.Forms.Label();
            this.shipResBaseNum = new System.Windows.Forms.NumericUpDown();
            this.troopResBaseNum = new System.Windows.Forms.NumericUpDown();
            this.troopResLabel = new System.Windows.Forms.Label();
            this.BasicGroup = new System.Windows.Forms.GroupBox();
            this.loyalVarNum = new System.Windows.Forms.NumericUpDown();
            this.loyalBaseNum = new System.Windows.Forms.NumericUpDown();
            this.loyaltyLabel = new System.Windows.Forms.Label();
            this.statsVarLabel = new System.Windows.Forms.Label();
            this.statsBaseLabel = new System.Windows.Forms.Label();
            this.combatVarNum = new System.Windows.Forms.NumericUpDown();
            this.dipVarNum = new System.Windows.Forms.NumericUpDown();
            this.espVarNum = new System.Windows.Forms.NumericUpDown();
            this.combatLabel = new System.Windows.Forms.Label();
            this.combatBaseNum = new System.Windows.Forms.NumericUpDown();
            this.diploLabel = new System.Windows.Forms.Label();
            this.dipBaseNum = new System.Windows.Forms.NumericUpDown();
            this.espBaseNum = new System.Windows.Forms.NumericUpDown();
            this.espLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.famHexLabel = new System.Windows.Forms.Label();
            this.unitHexLabel = new System.Windows.Forms.Label();
            this.unitNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.missionIdNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.unknown3Num = new System.Windows.Forms.NumericUpDown();
            this.idNum = new System.Windows.Forms.NumericUpDown();
            this.prodFacNum = new System.Windows.Forms.NumericUpDown();
            this.unkown3Label = new System.Windows.Forms.Label();
            this.familyIdNum = new System.Windows.Forms.NumericUpDown();
            this.prodLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.familyLabel = new System.Windows.Forms.Label();
            this.secProdFacNumlabel = new System.Windows.Forms.Label();
            this.secProdFacNum = new System.Windows.Forms.NumericUpDown();
            this.encyText = new System.Windows.Forms.RichTextBox();
            this.conCostLabel = new System.Windows.Forms.Label();
            this.conCostNum2 = new System.Windows.Forms.NumericUpDown();
            this.maintCostLabel = new System.Windows.Forms.Label();
            this.maintCostNum2 = new System.Windows.Forms.NumericUpDown();
            this.ItemPicture = new System.Windows.Forms.PictureBox();
            this.charLoyalGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSelect)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.researchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.researchNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resDiffNum)).BeginInit();
            this.costGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conCostNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintCostNum)).BeginInit();
            this.researchGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facResVarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipResVarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopResVarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facResBaseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipResBaseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopResBaseNum)).BeginInit();
            this.BasicGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loyalVarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyalBaseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatVarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipVarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espVarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBaseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipBaseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espBaseNum)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionIdNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown3Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodFacNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyIdNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secProdFacNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conCostNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintCostNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // charListView
            // 
            this.charListView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.charListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.charListView.GridLines = true;
            this.charListView.LargeImageList = this.SpecOpImageList;
            this.charListView.Location = new System.Drawing.Point(0, 110);
            this.charListView.Margin = new System.Windows.Forms.Padding(0);
            this.charListView.MultiSelect = false;
            this.charListView.Name = "charListView";
            this.charListView.ShowGroups = false;
            this.charListView.Size = new System.Drawing.Size(220, 475);
            this.charListView.TabIndex = 148;
            this.charListView.TabStop = false;
            this.charListView.UseCompatibleStateImageBehavior = false;
            this.charListView.Click += new System.EventHandler(this.charListView_Click);
            this.charListView.DoubleClick += new System.EventHandler(this.charListView_DoubleClick);
            // 
            // SpecOpImageList
            // 
            this.SpecOpImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.SpecOpImageList.ImageSize = new System.Drawing.Size(120, 60);
            this.SpecOpImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openNew
            // 
            this.openNew.Location = new System.Drawing.Point(663, 545);
            this.openNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openNew.Name = "openNew";
            this.openNew.Size = new System.Drawing.Size(88, 27);
            this.openNew.TabIndex = 146;
            this.openNew.TabStop = false;
            this.openNew.Text = "Open...";
            this.openNew.UseVisualStyleBackColor = true;
            this.openNew.Click += new System.EventHandler(this.openNew_Click);
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
            this.charLoyalGroup.Controls.Add(this.rebelUnit);
            this.charLoyalGroup.Controls.Add(this.empireUnit);
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
            this.rebelUnit.AutoSize = true;
            this.rebelUnit.Location = new System.Drawing.Point(7, 22);
            this.rebelUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rebelUnit.Name = "rebelUnit";
            this.rebelUnit.Size = new System.Drawing.Size(68, 19);
            this.rebelUnit.TabIndex = 15;
            this.rebelUnit.Text = "Alliance";
            this.rebelUnit.UseVisualStyleBackColor = true;
            this.rebelUnit.CheckStateChanged += new System.EventHandler(this.updateRebelUnitCheck);
            // 
            // empireUnit
            // 
            this.empireUnit.AutoSize = true;
            this.empireUnit.Location = new System.Drawing.Point(7, 48);
            this.empireUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empireUnit.Name = "empireUnit";
            this.empireUnit.Size = new System.Drawing.Size(69, 19);
            this.empireUnit.TabIndex = 16;
            this.empireUnit.Text = "Imperial";
            this.empireUnit.UseVisualStyleBackColor = true;
            this.empireUnit.CheckStateChanged += new System.EventHandler(this.updateEmpireUnitCheck);
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Location = new System.Drawing.Point(230, 78);
            this.ItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(116, 15);
            this.ItemName.TabIndex = 155;
            this.ItemName.Text = "-- Item name here --";
            // 
            // ItemSelect
            // 
            this.ItemSelect.LargeChange = 4;
            this.ItemSelect.Location = new System.Drawing.Point(233, 23);
            this.ItemSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ItemSelect.Maximum = 8;
            this.ItemSelect.Name = "ItemSelect";
            this.ItemSelect.Size = new System.Drawing.Size(121, 45);
            this.ItemSelect.TabIndex = 149;
            this.ItemSelect.ValueChanged += new System.EventHandler(this.SpecOpFormUpdateUI);
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
            this.researchBox.Controls.Add(this.researchNum);
            this.researchBox.Controls.Add(this.resDiffLabel);
            this.researchBox.Controls.Add(this.resDiffNum);
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
            this.researchNum.Location = new System.Drawing.Point(119, 16);
            this.researchNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.researchNum.Name = "researchNum";
            this.researchNum.Size = new System.Drawing.Size(50, 23);
            this.researchNum.TabIndex = 6;
            this.researchNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.researchNum.ValueChanged += new System.EventHandler(this.updateResNumNum);
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
            this.resDiffNum.Location = new System.Drawing.Point(119, 43);
            this.resDiffNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resDiffNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.resDiffNum.Name = "resDiffNum";
            this.resDiffNum.Size = new System.Drawing.Size(50, 23);
            this.resDiffNum.TabIndex = 11;
            this.resDiffNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.resDiffNum.ValueChanged += new System.EventHandler(this.updateResDiffNum);
            // 
            // costGroup
            // 
            this.costGroup.Controls.Add(this.label1);
            this.costGroup.Controls.Add(this.conCostNum);
            this.costGroup.Controls.Add(this.label2);
            this.costGroup.Controls.Add(this.maintCostNum);
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
            this.conCostNum.Location = new System.Drawing.Point(119, 18);
            this.conCostNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.conCostNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.conCostNum.Name = "conCostNum";
            this.conCostNum.Size = new System.Drawing.Size(50, 23);
            this.conCostNum.TabIndex = 4;
            this.conCostNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.conCostNum.ValueChanged += new System.EventHandler(this.updateConCostNum);
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
            this.maintCostNum.Location = new System.Drawing.Point(119, 48);
            this.maintCostNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maintCostNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.maintCostNum.Name = "maintCostNum";
            this.maintCostNum.Size = new System.Drawing.Size(50, 23);
            this.maintCostNum.TabIndex = 5;
            this.maintCostNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.maintCostNum.ValueChanged += new System.EventHandler(this.updateMaintCostNum);
            // 
            // researchGroup
            // 
            this.researchGroup.Controls.Add(this.resVarLabel);
            this.researchGroup.Controls.Add(this.resBaseLabel);
            this.researchGroup.Controls.Add(this.facResVarNum);
            this.researchGroup.Controls.Add(this.shipResVarNum);
            this.researchGroup.Controls.Add(this.troopResVarNum);
            this.researchGroup.Controls.Add(this.facResLabel);
            this.researchGroup.Controls.Add(this.facResBaseNum);
            this.researchGroup.Controls.Add(this.shipResLabel);
            this.researchGroup.Controls.Add(this.shipResBaseNum);
            this.researchGroup.Controls.Add(this.troopResBaseNum);
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
            this.facResVarNum.Enabled = false;
            this.facResVarNum.Location = new System.Drawing.Point(186, 99);
            this.facResVarNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facResVarNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.facResVarNum.Name = "facResVarNum";
            this.facResVarNum.Size = new System.Drawing.Size(59, 23);
            this.facResVarNum.TabIndex = 9;
            this.facResVarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.facResVarNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.facResVarNum.ValueChanged += new System.EventHandler(this.updateFacResVarNum);
            // 
            // shipResVarNum
            // 
            this.shipResVarNum.Enabled = false;
            this.shipResVarNum.Location = new System.Drawing.Point(186, 36);
            this.shipResVarNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shipResVarNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.shipResVarNum.Name = "shipResVarNum";
            this.shipResVarNum.Size = new System.Drawing.Size(59, 23);
            this.shipResVarNum.TabIndex = 5;
            this.shipResVarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shipResVarNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.shipResVarNum.ValueChanged += new System.EventHandler(this.updateShipResVarNum);
            // 
            // troopResVarNum
            // 
            this.troopResVarNum.Enabled = false;
            this.troopResVarNum.Location = new System.Drawing.Point(186, 69);
            this.troopResVarNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopResVarNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.troopResVarNum.Name = "troopResVarNum";
            this.troopResVarNum.Size = new System.Drawing.Size(59, 23);
            this.troopResVarNum.TabIndex = 7;
            this.troopResVarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.troopResVarNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.troopResVarNum.ValueChanged += new System.EventHandler(this.updateTroopResVarNum);
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
            this.facResBaseNum.Enabled = false;
            this.facResBaseNum.Location = new System.Drawing.Point(119, 99);
            this.facResBaseNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facResBaseNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.facResBaseNum.Name = "facResBaseNum";
            this.facResBaseNum.Size = new System.Drawing.Size(59, 23);
            this.facResBaseNum.TabIndex = 8;
            this.facResBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.facResBaseNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.facResBaseNum.ValueChanged += new System.EventHandler(this.updateFacResBaseNum);
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
            this.shipResBaseNum.Enabled = false;
            this.shipResBaseNum.Location = new System.Drawing.Point(119, 36);
            this.shipResBaseNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shipResBaseNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.shipResBaseNum.Name = "shipResBaseNum";
            this.shipResBaseNum.Size = new System.Drawing.Size(59, 23);
            this.shipResBaseNum.TabIndex = 4;
            this.shipResBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shipResBaseNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.shipResBaseNum.ValueChanged += new System.EventHandler(this.updateShipResBaseNum);
            // 
            // troopResBaseNum
            // 
            this.troopResBaseNum.Enabled = false;
            this.troopResBaseNum.Location = new System.Drawing.Point(119, 69);
            this.troopResBaseNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopResBaseNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.troopResBaseNum.Name = "troopResBaseNum";
            this.troopResBaseNum.Size = new System.Drawing.Size(59, 23);
            this.troopResBaseNum.TabIndex = 6;
            this.troopResBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.troopResBaseNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.troopResBaseNum.ValueChanged += new System.EventHandler(this.updateTroopResBaseNum);
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
            this.BasicGroup.Controls.Add(this.loyalVarNum);
            this.BasicGroup.Controls.Add(this.loyalBaseNum);
            this.BasicGroup.Controls.Add(this.loyaltyLabel);
            this.BasicGroup.Controls.Add(this.statsVarLabel);
            this.BasicGroup.Controls.Add(this.statsBaseLabel);
            this.BasicGroup.Controls.Add(this.combatVarNum);
            this.BasicGroup.Controls.Add(this.dipVarNum);
            this.BasicGroup.Controls.Add(this.espVarNum);
            this.BasicGroup.Controls.Add(this.combatLabel);
            this.BasicGroup.Controls.Add(this.combatBaseNum);
            this.BasicGroup.Controls.Add(this.diploLabel);
            this.BasicGroup.Controls.Add(this.dipBaseNum);
            this.BasicGroup.Controls.Add(this.espBaseNum);
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
            this.loyalVarNum.Location = new System.Drawing.Point(186, 129);
            this.loyalVarNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loyalVarNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.loyalVarNum.Name = "loyalVarNum";
            this.loyalVarNum.Size = new System.Drawing.Size(59, 23);
            this.loyalVarNum.TabIndex = 11;
            this.loyalVarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.loyalVarNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.loyalVarNum.ValueChanged += new System.EventHandler(this.updateLoyalVarNum);
            // 
            // loyalBaseNum
            // 
            this.loyalBaseNum.Location = new System.Drawing.Point(119, 129);
            this.loyalBaseNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loyalBaseNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.loyalBaseNum.Name = "loyalBaseNum";
            this.loyalBaseNum.Size = new System.Drawing.Size(59, 23);
            this.loyalBaseNum.TabIndex = 10;
            this.loyalBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.loyalBaseNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.loyalBaseNum.ValueChanged += new System.EventHandler(this.updateLoyalBaseNum);
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
            this.combatVarNum.Location = new System.Drawing.Point(186, 99);
            this.combatVarNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combatVarNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.combatVarNum.Name = "combatVarNum";
            this.combatVarNum.Size = new System.Drawing.Size(59, 23);
            this.combatVarNum.TabIndex = 9;
            this.combatVarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.combatVarNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.combatVarNum.ValueChanged += new System.EventHandler(this.updateCombatVarNum);
            // 
            // dipVarNum
            // 
            this.dipVarNum.Location = new System.Drawing.Point(186, 36);
            this.dipVarNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dipVarNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.dipVarNum.Name = "dipVarNum";
            this.dipVarNum.Size = new System.Drawing.Size(59, 23);
            this.dipVarNum.TabIndex = 5;
            this.dipVarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dipVarNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.dipVarNum.ValueChanged += new System.EventHandler(this.updateDipVarNum);
            // 
            // espVarNum
            // 
            this.espVarNum.Location = new System.Drawing.Point(186, 69);
            this.espVarNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.espVarNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.espVarNum.Name = "espVarNum";
            this.espVarNum.Size = new System.Drawing.Size(59, 23);
            this.espVarNum.TabIndex = 7;
            this.espVarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.espVarNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.espVarNum.ValueChanged += new System.EventHandler(this.updateEspVarNum);
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
            this.combatBaseNum.Location = new System.Drawing.Point(119, 99);
            this.combatBaseNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combatBaseNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.combatBaseNum.Name = "combatBaseNum";
            this.combatBaseNum.Size = new System.Drawing.Size(59, 23);
            this.combatBaseNum.TabIndex = 8;
            this.combatBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.combatBaseNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.combatBaseNum.ValueChanged += new System.EventHandler(this.updateCombatBaseNum);
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
            this.dipBaseNum.Location = new System.Drawing.Point(119, 36);
            this.dipBaseNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dipBaseNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.dipBaseNum.Name = "dipBaseNum";
            this.dipBaseNum.Size = new System.Drawing.Size(59, 23);
            this.dipBaseNum.TabIndex = 4;
            this.dipBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dipBaseNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.dipBaseNum.ValueChanged += new System.EventHandler(this.updateDipBaseNum);
            // 
            // espBaseNum
            // 
            this.espBaseNum.Location = new System.Drawing.Point(119, 69);
            this.espBaseNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.espBaseNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.espBaseNum.Name = "espBaseNum";
            this.espBaseNum.Size = new System.Drawing.Size(59, 23);
            this.espBaseNum.TabIndex = 6;
            this.espBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.espBaseNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.espBaseNum.ValueChanged += new System.EventHandler(this.updateEspBaseNum);
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
            this.groupBox1.Controls.Add(this.famHexLabel);
            this.groupBox1.Controls.Add(this.unitHexLabel);
            this.groupBox1.Controls.Add(this.unitNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.missionIdNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.unknown3Num);
            this.groupBox1.Controls.Add(this.idNum);
            this.groupBox1.Controls.Add(this.prodFacNum);
            this.groupBox1.Controls.Add(this.unkown3Label);
            this.groupBox1.Controls.Add(this.familyIdNum);
            this.groupBox1.Controls.Add(this.prodLabel);
            this.groupBox1.Controls.Add(this.idLabel);
            this.groupBox1.Controls.Add(this.familyLabel);
            this.groupBox1.Controls.Add(this.secProdFacNumlabel);
            this.groupBox1.Controls.Add(this.secProdFacNum);
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
            this.famHexLabel.AutoSize = true;
            this.famHexLabel.Enabled = false;
            this.famHexLabel.Location = new System.Drawing.Point(198, 92);
            this.famHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.famHexLabel.Name = "famHexLabel";
            this.famHexLabel.Size = new System.Drawing.Size(26, 15);
            this.famHexLabel.TabIndex = 1139;
            this.famHexLabel.Text = "hex";
            // 
            // unitHexLabel
            // 
            this.unitHexLabel.AutoSize = true;
            this.unitHexLabel.Enabled = false;
            this.unitHexLabel.Location = new System.Drawing.Point(198, 180);
            this.unitHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitHexLabel.Name = "unitHexLabel";
            this.unitHexLabel.Size = new System.Drawing.Size(26, 15);
            this.unitHexLabel.TabIndex = 1138;
            this.unitHexLabel.Text = "hex";
            // 
            // unitNum
            // 
            this.unitNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.unitNum.Enabled = false;
            this.unitNum.Location = new System.Drawing.Point(138, 178);
            this.unitNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unitNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.unitNum.Name = "unitNum";
            this.unitNum.Size = new System.Drawing.Size(59, 23);
            this.unitNum.TabIndex = 1137;
            this.unitNum.TabStop = false;
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
            this.missionIdNum.Enabled = false;
            this.missionIdNum.Location = new System.Drawing.Point(392, 32);
            this.missionIdNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.missionIdNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.missionIdNum.Name = "missionIdNum";
            this.missionIdNum.Size = new System.Drawing.Size(59, 23);
            this.missionIdNum.TabIndex = 148;
            this.missionIdNum.TabStop = false;
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
            this.unknown3Num.Enabled = false;
            this.unknown3Num.Location = new System.Drawing.Point(138, 118);
            this.unknown3Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknown3Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknown3Num.Name = "unknown3Num";
            this.unknown3Num.Size = new System.Drawing.Size(59, 23);
            this.unknown3Num.TabIndex = 144;
            this.unknown3Num.TabStop = false;
            // 
            // idNum
            // 
            this.idNum.Enabled = false;
            this.idNum.Location = new System.Drawing.Point(138, 148);
            this.idNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.idNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.idNum.Name = "idNum";
            this.idNum.Size = new System.Drawing.Size(59, 23);
            this.idNum.TabIndex = 146;
            this.idNum.TabStop = false;
            // 
            // prodFacNum
            // 
            this.prodFacNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.prodFacNum.Enabled = false;
            this.prodFacNum.Location = new System.Drawing.Point(138, 27);
            this.prodFacNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prodFacNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.prodFacNum.Name = "prodFacNum";
            this.prodFacNum.Size = new System.Drawing.Size(59, 23);
            this.prodFacNum.TabIndex = 137;
            this.prodFacNum.TabStop = false;
            this.prodFacNum.ValueChanged += new System.EventHandler(this.updateProdFacNum);
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
            this.familyIdNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.familyIdNum.Enabled = false;
            this.familyIdNum.Location = new System.Drawing.Point(138, 88);
            this.familyIdNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.familyIdNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.familyIdNum.Name = "familyIdNum";
            this.familyIdNum.Size = new System.Drawing.Size(59, 23);
            this.familyIdNum.TabIndex = 145;
            this.familyIdNum.TabStop = false;
            this.familyIdNum.ValueChanged += new System.EventHandler(this.updateFamilyNum);
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
            this.secProdFacNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.secProdFacNum.Enabled = false;
            this.secProdFacNum.Location = new System.Drawing.Point(138, 58);
            this.secProdFacNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secProdFacNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.secProdFacNum.Name = "secProdFacNum";
            this.secProdFacNum.Size = new System.Drawing.Size(59, 23);
            this.secProdFacNum.TabIndex = 139;
            this.secProdFacNum.TabStop = false;
            this.secProdFacNum.ValueChanged += new System.EventHandler(this.updateSecProdFacNum);
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
            this.ItemPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemPicture.InitialImage = null;
            this.ItemPicture.Location = new System.Drawing.Point(0, 0);
            this.ItemPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ItemPicture.Name = "ItemPicture";
            this.ItemPicture.Size = new System.Drawing.Size(220, 110);
            this.ItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ItemPicture.TabIndex = 156;
            this.ItemPicture.TabStop = false;
            this.ItemPicture.Click += new System.EventHandler(this.ItemPicture_Click);
            // 
            // SpecialForcesForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(810, 578);
            this.Controls.Add(this.charListView);
            this.Controls.Add(this.ItemPicture);
            this.Controls.Add(this.openNew);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.charLoyalGroup);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.ItemSelect);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(826, 617);
            this.MinimumSize = new System.Drawing.Size(826, 617);
            this.Name = "SpecialForcesForm";
            this.Text = "Special Forces (SPECFCSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpecOpForm_FormClosing);
            this.Load += new System.EventHandler(this.SpecOpForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpecOpForm_KeyDown);
            this.charLoyalGroup.ResumeLayout(false);
            this.charLoyalGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSelect)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.researchBox.ResumeLayout(false);
            this.researchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.researchNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resDiffNum)).EndInit();
            this.costGroup.ResumeLayout(false);
            this.costGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conCostNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintCostNum)).EndInit();
            this.researchGroup.ResumeLayout(false);
            this.researchGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facResVarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipResVarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopResVarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facResBaseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipResBaseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopResBaseNum)).EndInit();
            this.BasicGroup.ResumeLayout(false);
            this.BasicGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loyalVarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyalBaseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatVarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipVarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espVarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBaseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipBaseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espBaseNum)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionIdNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown3Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodFacNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyIdNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secProdFacNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conCostNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintCostNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}