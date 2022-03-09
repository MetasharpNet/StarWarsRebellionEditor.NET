using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class SystemsForm
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
        private Label ItemName;
        private TrackBar ItemSelect;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox BasicGroup;
        private NumericUpDown loyalVarNum;
        private NumericUpDown loyalBaseNum;
        private Label loyaltyLabel;
        private NumericUpDown espVarNum;
        private Label combatLabel;
        private NumericUpDown combatBaseNum;
        private Label diploLabel;
        private NumericUpDown dipBaseNum;
        private NumericUpDown espBaseNum;
        private Label espLabel;
        private TabPage tabPage2;
        private GroupBox groupBox5;
        private RichTextBox encyText;
        private ImageList SystemImageList;
        private Label sectorName;
        private GroupBox miscDATGroup;
        private NumericUpDown prodFacNum;
        private Label prodLabel;
        private Label secProdFacNumlabel;
        private NumericUpDown secProdFacNum;
        private Label familyLabel;
        private Label idLabel;
        private NumericUpDown familyIdNum;
        private NumericUpDown idNum;
        private NumericUpDown unknown3Num;
        private Label unkown3Label;
        private GroupBox groupBox2;
        private NumericUpDown sectorProdFacNum;
        private Label label7;
        private Label label8;
        private NumericUpDown sectorSecProdFacNum;
        private Label label9;
        private Label label10;
        private NumericUpDown sectorFamilyIdNum;
        private NumericUpDown sectorIdNum;
        private NumericUpDown sectorUnknown3Num;
        private Label label11;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private NumericUpDown sectorYposNum;
        private NumericUpDown sectorXposNum;
        private Label label1;
        private NumericUpDown sectorYpos;
        private NumericUpDown sectorXpos;
        private Label label4;
        private Label label6;
        private Label secNameLabel;
        private Label sysfamHexLabel;
        private Label sysHexLabel;
        private NumericUpDown sysNum;
        private Label label5;
        private Label secfamHexLabel;
        private Label secUnitHexLabel;
        private NumericUpDown secNum;
        private Label label15;
        private Label label12;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemsForm));
            this.charListView = new System.Windows.Forms.ListView();
            this.SystemImageList = new System.Windows.Forms.ImageList(this.components);
            this.openNew = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.ItemName = new System.Windows.Forms.Label();
            this.ItemSelect = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.secfamHexLabel = new System.Windows.Forms.Label();
            this.sectorProdFacNum = new System.Windows.Forms.NumericUpDown();
            this.secUnitHexLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.secNum = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sectorSecProdFacNum = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sectorFamilyIdNum = new System.Windows.Forms.NumericUpDown();
            this.sectorIdNum = new System.Windows.Forms.NumericUpDown();
            this.sectorUnknown3Num = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.secNameLabel = new System.Windows.Forms.Label();
            this.sectorYpos = new System.Windows.Forms.NumericUpDown();
            this.sectorXpos = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sectorYposNum = new System.Windows.Forms.NumericUpDown();
            this.sectorXposNum = new System.Windows.Forms.NumericUpDown();
            this.miscDATGroup = new System.Windows.Forms.GroupBox();
            this.sysfamHexLabel = new System.Windows.Forms.Label();
            this.prodFacNum = new System.Windows.Forms.NumericUpDown();
            this.prodLabel = new System.Windows.Forms.Label();
            this.sysHexLabel = new System.Windows.Forms.Label();
            this.secProdFacNumlabel = new System.Windows.Forms.Label();
            this.secProdFacNum = new System.Windows.Forms.NumericUpDown();
            this.sysNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.familyLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.familyIdNum = new System.Windows.Forms.NumericUpDown();
            this.idNum = new System.Windows.Forms.NumericUpDown();
            this.unknown3Num = new System.Windows.Forms.NumericUpDown();
            this.unkown3Label = new System.Windows.Forms.Label();
            this.BasicGroup = new System.Windows.Forms.GroupBox();
            this.loyalVarNum = new System.Windows.Forms.NumericUpDown();
            this.loyalBaseNum = new System.Windows.Forms.NumericUpDown();
            this.loyaltyLabel = new System.Windows.Forms.Label();
            this.espVarNum = new System.Windows.Forms.NumericUpDown();
            this.combatLabel = new System.Windows.Forms.Label();
            this.combatBaseNum = new System.Windows.Forms.NumericUpDown();
            this.diploLabel = new System.Windows.Forms.Label();
            this.dipBaseNum = new System.Windows.Forms.NumericUpDown();
            this.espBaseNum = new System.Windows.Forms.NumericUpDown();
            this.espLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.encyText = new System.Windows.Forms.RichTextBox();
            this.sectorName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemPicture = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSelect)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorProdFacNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorSecProdFacNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorFamilyIdNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorIdNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorUnknown3Num)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorYpos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorXpos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorYposNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorXposNum)).BeginInit();
            this.miscDATGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodFacNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secProdFacNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyIdNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown3Num)).BeginInit();
            this.BasicGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loyalVarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyalBaseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espVarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBaseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipBaseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espBaseNum)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // charListView
            // 
            this.charListView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.charListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.charListView.GridLines = true;
            this.charListView.LargeImageList = this.SystemImageList;
            this.charListView.Location = new System.Drawing.Point(0, 108);
            this.charListView.Margin = new System.Windows.Forms.Padding(0);
            this.charListView.MultiSelect = false;
            this.charListView.Name = "charListView";
            this.charListView.ShowGroups = false;
            this.charListView.Size = new System.Drawing.Size(220, 475);
            this.charListView.TabIndex = 148;
            this.charListView.TabStop = false;
            this.charListView.UseCompatibleStateImageBehavior = false;
            this.charListView.Click += new System.EventHandler(this.ListView_Click);
            this.charListView.DoubleClick += new System.EventHandler(this.ListView_DoubleClick);
            // 
            // SystemImageList
            // 
            this.SystemImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.SystemImageList.ImageSize = new System.Drawing.Size(120, 60);
            this.SystemImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openNew
            // 
            this.openNew.Location = new System.Drawing.Point(663, 543);
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
            this.SaveAs.Location = new System.Drawing.Point(568, 543);
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
            this.Cancel.Location = new System.Drawing.Point(390, 543);
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
            this.Ok.Location = new System.Drawing.Point(295, 543);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 153;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Location = new System.Drawing.Point(230, 77);
            this.ItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(116, 15);
            this.ItemName.TabIndex = 155;
            this.ItemName.Text = "-- Item name here --";
            // 
            // ItemSelect
            // 
            this.ItemSelect.LargeChange = 10;
            this.ItemSelect.Location = new System.Drawing.Point(233, 22);
            this.ItemSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ItemSelect.Maximum = 199;
            this.ItemSelect.Name = "ItemSelect";
            this.ItemSelect.Size = new System.Drawing.Size(121, 45);
            this.ItemSelect.TabIndex = 149;
            this.ItemSelect.ValueChanged += new System.EventHandler(this.SystemFormUpdateUI);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(233, 108);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 428);
            this.tabControl1.TabIndex = 152;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.miscDATGroup);
            this.tabPage1.Controls.Add(this.BasicGroup);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(575, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stats";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.secfamHexLabel);
            this.groupBox2.Controls.Add(this.sectorProdFacNum);
            this.groupBox2.Controls.Add(this.secUnitHexLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.secNum);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.sectorSecProdFacNum);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.sectorFamilyIdNum);
            this.groupBox2.Controls.Add(this.sectorIdNum);
            this.groupBox2.Controls.Add(this.sectorUnknown3Num);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(308, 196);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(204, 198);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(sector) DAT Misc Data";
            // 
            // secfamHexLabel
            // 
            this.secfamHexLabel.AutoSize = true;
            this.secfamHexLabel.Enabled = false;
            this.secfamHexLabel.Location = new System.Drawing.Point(173, 82);
            this.secfamHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secfamHexLabel.Name = "secfamHexLabel";
            this.secfamHexLabel.Size = new System.Drawing.Size(26, 15);
            this.secfamHexLabel.TabIndex = 1151;
            this.secfamHexLabel.Text = "hex";
            // 
            // sectorProdFacNum
            // 
            this.sectorProdFacNum.Enabled = false;
            this.sectorProdFacNum.Location = new System.Drawing.Point(112, 16);
            this.sectorProdFacNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorProdFacNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sectorProdFacNum.Name = "sectorProdFacNum";
            this.sectorProdFacNum.Size = new System.Drawing.Size(59, 23);
            this.sectorProdFacNum.TabIndex = 0;
            this.sectorProdFacNum.TabStop = false;
            this.sectorProdFacNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // secUnitHexLabel
            // 
            this.secUnitHexLabel.AutoSize = true;
            this.secUnitHexLabel.Enabled = false;
            this.secUnitHexLabel.Location = new System.Drawing.Point(173, 170);
            this.secUnitHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secUnitHexLabel.Name = "secUnitHexLabel";
            this.secUnitHexLabel.Size = new System.Drawing.Size(26, 15);
            this.secUnitHexLabel.TabIndex = 1150;
            this.secUnitHexLabel.Text = "hex";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(0, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Production Facility";
            // 
            // secNum
            // 
            this.secNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.secNum.Enabled = false;
            this.secNum.Location = new System.Drawing.Point(112, 167);
            this.secNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.secNum.Name = "secNum";
            this.secNum.Size = new System.Drawing.Size(59, 23);
            this.secNum.TabIndex = 1149;
            this.secNum.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(0, 170);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 15);
            this.label15.TabIndex = 1148;
            this.label15.Text = "Sector ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(0, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Prod Facility + 1";
            // 
            // sectorSecProdFacNum
            // 
            this.sectorSecProdFacNum.Enabled = false;
            this.sectorSecProdFacNum.Location = new System.Drawing.Point(112, 47);
            this.sectorSecProdFacNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorSecProdFacNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sectorSecProdFacNum.Name = "sectorSecProdFacNum";
            this.sectorSecProdFacNum.Size = new System.Drawing.Size(59, 23);
            this.sectorSecProdFacNum.TabIndex = 0;
            this.sectorSecProdFacNum.TabStop = false;
            this.sectorSecProdFacNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(0, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Family ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(0, 140);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "TextStra.DLL ID";
            // 
            // sectorFamilyIdNum
            // 
            this.sectorFamilyIdNum.Enabled = false;
            this.sectorFamilyIdNum.Location = new System.Drawing.Point(112, 77);
            this.sectorFamilyIdNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorFamilyIdNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sectorFamilyIdNum.Name = "sectorFamilyIdNum";
            this.sectorFamilyIdNum.Size = new System.Drawing.Size(59, 23);
            this.sectorFamilyIdNum.TabIndex = 0;
            this.sectorFamilyIdNum.TabStop = false;
            this.sectorFamilyIdNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // sectorIdNum
            // 
            this.sectorIdNum.Enabled = false;
            this.sectorIdNum.Location = new System.Drawing.Point(112, 137);
            this.sectorIdNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorIdNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.sectorIdNum.Name = "sectorIdNum";
            this.sectorIdNum.Size = new System.Drawing.Size(59, 23);
            this.sectorIdNum.TabIndex = 0;
            this.sectorIdNum.TabStop = false;
            this.sectorIdNum.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // sectorUnknown3Num
            // 
            this.sectorUnknown3Num.Enabled = false;
            this.sectorUnknown3Num.Location = new System.Drawing.Point(112, 107);
            this.sectorUnknown3Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorUnknown3Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sectorUnknown3Num.Name = "sectorUnknown3Num";
            this.sectorUnknown3Num.Size = new System.Drawing.Size(59, 23);
            this.sectorUnknown3Num.TabIndex = 0;
            this.sectorUnknown3Num.TabStop = false;
            this.sectorUnknown3Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(0, 110);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Unknown3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.secNameLabel);
            this.groupBox1.Controls.Add(this.sectorYpos);
            this.groupBox1.Controls.Add(this.sectorXpos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sectorYposNum);
            this.groupBox1.Controls.Add(this.sectorXposNum);
            this.groupBox1.Location = new System.Drawing.Point(4, 185);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(262, 174);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sector stats";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 159;
            this.label6.Text = "Sector Name:";
            // 
            // secNameLabel
            // 
            this.secNameLabel.AutoSize = true;
            this.secNameLabel.Location = new System.Drawing.Point(122, 18);
            this.secNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secNameLabel.Name = "secNameLabel";
            this.secNameLabel.Size = new System.Drawing.Size(116, 15);
            this.secNameLabel.TabIndex = 158;
            this.secNameLabel.Text = "-- Item name here --";
            // 
            // sectorYpos
            // 
            this.sectorYpos.Enabled = false;
            this.sectorYpos.Location = new System.Drawing.Point(186, 141);
            this.sectorYpos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorYpos.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.sectorYpos.Name = "sectorYpos";
            this.sectorYpos.Size = new System.Drawing.Size(59, 23);
            this.sectorYpos.TabIndex = 14;
            this.sectorYpos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sectorYpos.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // sectorXpos
            // 
            this.sectorXpos.Enabled = false;
            this.sectorXpos.Location = new System.Drawing.Point(119, 141);
            this.sectorXpos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorXpos.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.sectorXpos.Name = "sectorXpos";
            this.sectorXpos.Size = new System.Drawing.Size(59, 23);
            this.sectorXpos.TabIndex = 13;
            this.sectorXpos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sectorXpos.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(145, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "x / y Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(182, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sec Import";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(115, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "GalSize";
            // 
            // sectorYposNum
            // 
            this.sectorYposNum.Enabled = false;
            this.sectorYposNum.Location = new System.Drawing.Point(186, 70);
            this.sectorYposNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorYposNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.sectorYposNum.Name = "sectorYposNum";
            this.sectorYposNum.Size = new System.Drawing.Size(59, 23);
            this.sectorYposNum.TabIndex = 7;
            this.sectorYposNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sectorYposNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // sectorXposNum
            // 
            this.sectorXposNum.Enabled = false;
            this.sectorXposNum.Location = new System.Drawing.Point(119, 70);
            this.sectorXposNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorXposNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.sectorXposNum.Name = "sectorXposNum";
            this.sectorXposNum.Size = new System.Drawing.Size(59, 23);
            this.sectorXposNum.TabIndex = 6;
            this.sectorXposNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sectorXposNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // miscDATGroup
            // 
            this.miscDATGroup.Controls.Add(this.sysfamHexLabel);
            this.miscDATGroup.Controls.Add(this.prodFacNum);
            this.miscDATGroup.Controls.Add(this.prodLabel);
            this.miscDATGroup.Controls.Add(this.sysHexLabel);
            this.miscDATGroup.Controls.Add(this.secProdFacNumlabel);
            this.miscDATGroup.Controls.Add(this.secProdFacNum);
            this.miscDATGroup.Controls.Add(this.sysNum);
            this.miscDATGroup.Controls.Add(this.label5);
            this.miscDATGroup.Controls.Add(this.familyLabel);
            this.miscDATGroup.Controls.Add(this.idLabel);
            this.miscDATGroup.Controls.Add(this.familyIdNum);
            this.miscDATGroup.Controls.Add(this.idNum);
            this.miscDATGroup.Controls.Add(this.unknown3Num);
            this.miscDATGroup.Controls.Add(this.unkown3Label);
            this.miscDATGroup.Location = new System.Drawing.Point(308, 0);
            this.miscDATGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.miscDATGroup.Name = "miscDATGroup";
            this.miscDATGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.miscDATGroup.Size = new System.Drawing.Size(204, 196);
            this.miscDATGroup.TabIndex = 13;
            this.miscDATGroup.TabStop = false;
            this.miscDATGroup.Text = "(system) DAT Misc Data";
            // 
            // sysfamHexLabel
            // 
            this.sysfamHexLabel.AutoSize = true;
            this.sysfamHexLabel.Enabled = false;
            this.sysfamHexLabel.Location = new System.Drawing.Point(173, 82);
            this.sysfamHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sysfamHexLabel.Name = "sysfamHexLabel";
            this.sysfamHexLabel.Size = new System.Drawing.Size(26, 15);
            this.sysfamHexLabel.TabIndex = 1147;
            this.sysfamHexLabel.Text = "hex";
            // 
            // prodFacNum
            // 
            this.prodFacNum.Enabled = false;
            this.prodFacNum.Location = new System.Drawing.Point(112, 16);
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
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.Enabled = false;
            this.prodLabel.Location = new System.Drawing.Point(0, 18);
            this.prodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(106, 15);
            this.prodLabel.TabIndex = 0;
            this.prodLabel.Text = "Production Facility";
            // 
            // sysHexLabel
            // 
            this.sysHexLabel.AutoSize = true;
            this.sysHexLabel.Enabled = false;
            this.sysHexLabel.Location = new System.Drawing.Point(173, 170);
            this.sysHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sysHexLabel.Name = "sysHexLabel";
            this.sysHexLabel.Size = new System.Drawing.Size(26, 15);
            this.sysHexLabel.TabIndex = 1146;
            this.sysHexLabel.Text = "hex";
            // 
            // secProdFacNumlabel
            // 
            this.secProdFacNumlabel.AutoSize = true;
            this.secProdFacNumlabel.Enabled = false;
            this.secProdFacNumlabel.Location = new System.Drawing.Point(0, 47);
            this.secProdFacNumlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secProdFacNumlabel.Name = "secProdFacNumlabel";
            this.secProdFacNumlabel.Size = new System.Drawing.Size(92, 15);
            this.secProdFacNumlabel.TabIndex = 0;
            this.secProdFacNumlabel.Text = "Prod Facility + 1";
            // 
            // secProdFacNum
            // 
            this.secProdFacNum.Enabled = false;
            this.secProdFacNum.Location = new System.Drawing.Point(112, 47);
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
            // 
            // sysNum
            // 
            this.sysNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sysNum.Enabled = false;
            this.sysNum.Location = new System.Drawing.Point(112, 167);
            this.sysNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sysNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.sysNum.Name = "sysNum";
            this.sysNum.Size = new System.Drawing.Size(59, 23);
            this.sysNum.TabIndex = 1145;
            this.sysNum.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(0, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 1144;
            this.label5.Text = "System ID";
            // 
            // familyLabel
            // 
            this.familyLabel.AutoSize = true;
            this.familyLabel.Enabled = false;
            this.familyLabel.Location = new System.Drawing.Point(0, 75);
            this.familyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyLabel.Name = "familyLabel";
            this.familyLabel.Size = new System.Drawing.Size(56, 15);
            this.familyLabel.TabIndex = 0;
            this.familyLabel.Text = "Family ID";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Enabled = false;
            this.idLabel.Location = new System.Drawing.Point(0, 140);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(85, 15);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "TextStra.DLL ID";
            // 
            // familyIdNum
            // 
            this.familyIdNum.Location = new System.Drawing.Point(112, 77);
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
            this.familyIdNum.ValueChanged += new System.EventHandler(this.updateFamilyNum);
            // 
            // idNum
            // 
            this.idNum.Enabled = false;
            this.idNum.Location = new System.Drawing.Point(112, 137);
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
            // unknown3Num
            // 
            this.unknown3Num.Enabled = false;
            this.unknown3Num.Location = new System.Drawing.Point(112, 107);
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
            // unkown3Label
            // 
            this.unkown3Label.AutoSize = true;
            this.unkown3Label.Enabled = false;
            this.unkown3Label.Location = new System.Drawing.Point(0, 110);
            this.unkown3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unkown3Label.Name = "unkown3Label";
            this.unkown3Label.Size = new System.Drawing.Size(64, 15);
            this.unkown3Label.TabIndex = 0;
            this.unkown3Label.Text = "Unknown3";
            // 
            // BasicGroup
            // 
            this.BasicGroup.Controls.Add(this.loyalVarNum);
            this.BasicGroup.Controls.Add(this.loyalBaseNum);
            this.BasicGroup.Controls.Add(this.loyaltyLabel);
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
            this.BasicGroup.Text = "Planet stats";
            // 
            // loyalVarNum
            // 
            this.loyalVarNum.Enabled = false;
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
            // 
            // loyalBaseNum
            // 
            this.loyalBaseNum.Enabled = false;
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
            // 
            // loyaltyLabel
            // 
            this.loyaltyLabel.AutoSize = true;
            this.loyaltyLabel.Location = new System.Drawing.Point(0, 137);
            this.loyaltyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loyaltyLabel.Name = "loyaltyLabel";
            this.loyaltyLabel.Size = new System.Drawing.Size(109, 15);
            this.loyaltyLabel.TabIndex = 12;
            this.loyaltyLabel.Text = "sec ID/planet pic ID";
            // 
            // espVarNum
            // 
            this.espVarNum.Enabled = false;
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
            // 
            // combatLabel
            // 
            this.combatLabel.AutoSize = true;
            this.combatLabel.Location = new System.Drawing.Point(7, 102);
            this.combatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.combatLabel.Name = "combatLabel";
            this.combatLabel.Size = new System.Drawing.Size(63, 15);
            this.combatLabel.TabIndex = 0;
            this.combatLabel.Text = "unknown4";
            // 
            // combatBaseNum
            // 
            this.combatBaseNum.Enabled = false;
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
            // 
            // diploLabel
            // 
            this.diploLabel.AutoSize = true;
            this.diploLabel.Location = new System.Drawing.Point(7, 38);
            this.diploLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diploLabel.Name = "diploLabel";
            this.diploLabel.Size = new System.Drawing.Size(63, 15);
            this.diploLabel.TabIndex = 0;
            this.diploLabel.Text = "unknown5";
            // 
            // dipBaseNum
            // 
            this.dipBaseNum.Enabled = false;
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
            // 
            // espBaseNum
            // 
            this.espBaseNum.Enabled = false;
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
            // 
            // espLabel
            // 
            this.espLabel.AutoSize = true;
            this.espLabel.Location = new System.Drawing.Point(7, 72);
            this.espLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.espLabel.Name = "espLabel";
            this.espLabel.Size = new System.Drawing.Size(76, 15);
            this.espLabel.TabIndex = 0;
            this.espLabel.Text = "x / y Position";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.encyText);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(575, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ency";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(4, 167);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(550, 195);
            this.groupBox5.TabIndex = 135;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DAT Misc";
            // 
            // encyText
            // 
            this.encyText.Cursor = System.Windows.Forms.Cursors.No;
            this.encyText.Enabled = false;
            this.encyText.Location = new System.Drawing.Point(0, 0);
            this.encyText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.encyText.Name = "encyText";
            this.encyText.Size = new System.Drawing.Size(559, 160);
            this.encyText.TabIndex = 134;
            this.encyText.TabStop = false;
            this.encyText.Text = "Not Implemented yet....Encylopedia Data...Will add .Someday";
            // 
            // sectorName
            // 
            this.sectorName.AutoSize = true;
            this.sectorName.Location = new System.Drawing.Point(268, 97);
            this.sectorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sectorName.Name = "sectorName";
            this.sectorName.Size = new System.Drawing.Size(116, 15);
            this.sectorName.TabIndex = 157;
            this.sectorName.Text = "-- Item name here --";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "*****This GUI is  for viewing DAT data in the \'rough\'. ";
            // 
            // ItemPicture
            // 
            this.ItemPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemPicture.InitialImage = null;
            this.ItemPicture.Location = new System.Drawing.Point(0, -1);
            this.ItemPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ItemPicture.Name = "ItemPicture";
            this.ItemPicture.Size = new System.Drawing.Size(220, 110);
            this.ItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ItemPicture.TabIndex = 156;
            this.ItemPicture.TabStop = false;
            this.ItemPicture.Click += new System.EventHandler(this.ItemPicture_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(364, 57);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(325, 15);
            this.label12.TabIndex = 158;
            this.label12.Text = "***** System Family ID may be updated 144 = core 146= Rim";
            // 
            // SystemsForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(821, 578);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sectorName);
            this.Controls.Add(this.charListView);
            this.Controls.Add(this.ItemPicture);
            this.Controls.Add(this.openNew);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.ItemSelect);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(837, 617);
            this.MinimumSize = new System.Drawing.Size(837, 617);
            this.Name = "SystemsForm";
            this.Text = "Systems (SYSTEMSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SystemInfoForm_FormClosing);
            this.Load += new System.EventHandler(this.SystemInfoForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SystemInfoForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ItemSelect)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorProdFacNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorSecProdFacNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorFamilyIdNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorIdNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorUnknown3Num)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorYpos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorXpos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorYposNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorXposNum)).EndInit();
            this.miscDATGroup.ResumeLayout(false);
            this.miscDATGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodFacNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secProdFacNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyIdNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown3Num)).EndInit();
            this.BasicGroup.ResumeLayout(false);
            this.BasicGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loyalVarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyalBaseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espVarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBaseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipBaseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espBaseNum)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}