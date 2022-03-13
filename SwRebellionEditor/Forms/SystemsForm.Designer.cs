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
        private Button Open;
        private Button SaveAs;
        private Button Cancel;
        private Button Ok;
        private TrackBar selector;
        private ListView systemsListView;
        private ImageList systemsImageList;
        private PictureBox picture;
        private Label encyclopediaName;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox BasicGroup;
        private NumericUpDown pictureId;
        private NumericUpDown sectorId;
        private Label loyaltyLabel;
        private NumericUpDown yPosition;
        private Label combatLabel;
        private NumericUpDown unknown4;
        private Label diploLabel;
        private NumericUpDown unknown5;
        private NumericUpDown xPosition;
        private Label espLabel;
        private TabPage tabPage2;
        private GroupBox groupBox5;
        private RichTextBox encyclopediaDescription;
        private Label sectorName;
        private GroupBox miscDATGroup;
        private NumericUpDown productionFacility;
        private Label prodLabel;
        private Label secProdFacNumlabel;
        private NumericUpDown nextProductionFacility;
        private Label familyLabel;
        private Label idLabel;
        private NumericUpDown familyId;
        private NumericUpDown textStraDllId;
        private NumericUpDown unknown3;
        private Label unkown3Label;
        private GroupBox groupBox2;
        private NumericUpDown sectorProductionFacility;
        private Label label7;
        private Label label8;
        private NumericUpDown sectorNextProductionFacility;
        private Label label9;
        private Label label10;
        private NumericUpDown sectorFamilyId;
        private NumericUpDown sectorTextStraDllId;
        private NumericUpDown sectorUnknown3;
        private Label label11;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private NumericUpDown sectorImport;
        private NumericUpDown galSize;
        private Label label1;
        private NumericUpDown sectorYpos;
        private NumericUpDown sectorXpos;
        private Label label4;
        private Label label6;
        private Label secNameLabel;
        private Label familyIdHexLabel;
        private Label SystemIdHexLabel;
        private NumericUpDown systemId;
        private Label label5;
        private Label secfamHexLabel;
        private Label secUnitHexLabel;
        private NumericUpDown sectorSectorId;
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
            this.systemsListView = new System.Windows.Forms.ListView();
            this.systemsImageList = new System.Windows.Forms.ImageList(this.components);
            this.Open = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.encyclopediaName = new System.Windows.Forms.Label();
            this.selector = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.secfamHexLabel = new System.Windows.Forms.Label();
            this.sectorProductionFacility = new System.Windows.Forms.NumericUpDown();
            this.secUnitHexLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sectorSectorId = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sectorNextProductionFacility = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sectorFamilyId = new System.Windows.Forms.NumericUpDown();
            this.sectorTextStraDllId = new System.Windows.Forms.NumericUpDown();
            this.sectorUnknown3 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.secNameLabel = new System.Windows.Forms.Label();
            this.sectorYpos = new System.Windows.Forms.NumericUpDown();
            this.sectorXpos = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sectorImport = new System.Windows.Forms.NumericUpDown();
            this.galSize = new System.Windows.Forms.NumericUpDown();
            this.miscDATGroup = new System.Windows.Forms.GroupBox();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.productionFacility = new System.Windows.Forms.NumericUpDown();
            this.prodLabel = new System.Windows.Forms.Label();
            this.SystemIdHexLabel = new System.Windows.Forms.Label();
            this.secProdFacNumlabel = new System.Windows.Forms.Label();
            this.nextProductionFacility = new System.Windows.Forms.NumericUpDown();
            this.systemId = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.familyLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.familyId = new System.Windows.Forms.NumericUpDown();
            this.textStraDllId = new System.Windows.Forms.NumericUpDown();
            this.unknown3 = new System.Windows.Forms.NumericUpDown();
            this.unkown3Label = new System.Windows.Forms.Label();
            this.BasicGroup = new System.Windows.Forms.GroupBox();
            this.pictureId = new System.Windows.Forms.NumericUpDown();
            this.sectorId = new System.Windows.Forms.NumericUpDown();
            this.loyaltyLabel = new System.Windows.Forms.Label();
            this.yPosition = new System.Windows.Forms.NumericUpDown();
            this.combatLabel = new System.Windows.Forms.Label();
            this.unknown4 = new System.Windows.Forms.NumericUpDown();
            this.diploLabel = new System.Windows.Forms.Label();
            this.unknown5 = new System.Windows.Forms.NumericUpDown();
            this.xPosition = new System.Windows.Forms.NumericUpDown();
            this.espLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.encyclopediaDescription = new System.Windows.Forms.RichTextBox();
            this.sectorName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorProductionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorSectorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorNextProductionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorFamilyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorTextStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorUnknown3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorYpos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorXpos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galSize)).BeginInit();
            this.miscDATGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown3)).BeginInit();
            this.BasicGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPosition)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // systemsListView
            // 
            this.systemsListView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.systemsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.systemsListView.GridLines = true;
            this.systemsListView.LargeImageList = this.systemsImageList;
            this.systemsListView.Location = new System.Drawing.Point(0, 108);
            this.systemsListView.Margin = new System.Windows.Forms.Padding(0);
            this.systemsListView.MultiSelect = false;
            this.systemsListView.Name = "systemsListView";
            this.systemsListView.ShowGroups = false;
            this.systemsListView.Size = new System.Drawing.Size(220, 475);
            this.systemsListView.TabIndex = 148;
            this.systemsListView.TabStop = false;
            this.systemsListView.UseCompatibleStateImageBehavior = false;
            this.systemsListView.Click += new System.EventHandler(this.systemsListView_Click);
            this.systemsListView.DoubleClick += new System.EventHandler(this.systemsListView_DoubleClick);
            // 
            // systemsImageList
            // 
            this.systemsImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.systemsImageList.ImageSize = new System.Drawing.Size(120, 60);
            this.systemsImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(663, 543);
            this.Open.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(88, 27);
            this.Open.TabIndex = 146;
            this.Open.TabStop = false;
            this.Open.Text = "Open...";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
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
            // encyclopediaName
            // 
            this.encyclopediaName.AutoSize = true;
            this.encyclopediaName.Location = new System.Drawing.Point(230, 77);
            this.encyclopediaName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encyclopediaName.Name = "encyclopediaName";
            this.encyclopediaName.Size = new System.Drawing.Size(116, 15);
            this.encyclopediaName.TabIndex = 155;
            this.encyclopediaName.Text = "-- Item name here --";
            // 
            // selector
            // 
            this.selector.LargeChange = 10;
            this.selector.Location = new System.Drawing.Point(233, 22);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 199;
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(121, 45);
            this.selector.TabIndex = 149;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
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
            this.groupBox2.Controls.Add(this.sectorProductionFacility);
            this.groupBox2.Controls.Add(this.secUnitHexLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.sectorSectorId);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.sectorNextProductionFacility);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.sectorFamilyId);
            this.groupBox2.Controls.Add(this.sectorTextStraDllId);
            this.groupBox2.Controls.Add(this.sectorUnknown3);
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
            // sectorProductionFacility
            // 
            this.sectorProductionFacility.Enabled = false;
            this.sectorProductionFacility.Location = new System.Drawing.Point(112, 16);
            this.sectorProductionFacility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorProductionFacility.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sectorProductionFacility.Name = "sectorProductionFacility";
            this.sectorProductionFacility.Size = new System.Drawing.Size(59, 23);
            this.sectorProductionFacility.TabIndex = 0;
            this.sectorProductionFacility.TabStop = false;
            this.sectorProductionFacility.Value = new decimal(new int[] {
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
            // sectorSectorId
            // 
            this.sectorSectorId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sectorSectorId.Enabled = false;
            this.sectorSectorId.Location = new System.Drawing.Point(112, 167);
            this.sectorSectorId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorSectorId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.sectorSectorId.Name = "sectorSectorId";
            this.sectorSectorId.Size = new System.Drawing.Size(59, 23);
            this.sectorSectorId.TabIndex = 1149;
            this.sectorSectorId.TabStop = false;
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
            // sectorNextProductionFacility
            // 
            this.sectorNextProductionFacility.Enabled = false;
            this.sectorNextProductionFacility.Location = new System.Drawing.Point(112, 47);
            this.sectorNextProductionFacility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorNextProductionFacility.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sectorNextProductionFacility.Name = "sectorNextProductionFacility";
            this.sectorNextProductionFacility.Size = new System.Drawing.Size(59, 23);
            this.sectorNextProductionFacility.TabIndex = 0;
            this.sectorNextProductionFacility.TabStop = false;
            this.sectorNextProductionFacility.Value = new decimal(new int[] {
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
            // sectorFamilyId
            // 
            this.sectorFamilyId.Enabled = false;
            this.sectorFamilyId.Location = new System.Drawing.Point(112, 77);
            this.sectorFamilyId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorFamilyId.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sectorFamilyId.Name = "sectorFamilyId";
            this.sectorFamilyId.Size = new System.Drawing.Size(59, 23);
            this.sectorFamilyId.TabIndex = 0;
            this.sectorFamilyId.TabStop = false;
            this.sectorFamilyId.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // sectorTextStraDllId
            // 
            this.sectorTextStraDllId.Enabled = false;
            this.sectorTextStraDllId.Location = new System.Drawing.Point(112, 137);
            this.sectorTextStraDllId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorTextStraDllId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.sectorTextStraDllId.Name = "sectorTextStraDllId";
            this.sectorTextStraDllId.Size = new System.Drawing.Size(59, 23);
            this.sectorTextStraDllId.TabIndex = 0;
            this.sectorTextStraDllId.TabStop = false;
            this.sectorTextStraDllId.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // sectorUnknown3
            // 
            this.sectorUnknown3.Enabled = false;
            this.sectorUnknown3.Location = new System.Drawing.Point(112, 107);
            this.sectorUnknown3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorUnknown3.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sectorUnknown3.Name = "sectorUnknown3";
            this.sectorUnknown3.Size = new System.Drawing.Size(59, 23);
            this.sectorUnknown3.TabIndex = 0;
            this.sectorUnknown3.TabStop = false;
            this.sectorUnknown3.Value = new decimal(new int[] {
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
            this.groupBox1.Controls.Add(this.sectorImport);
            this.groupBox1.Controls.Add(this.galSize);
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
            // sectorImport
            // 
            this.sectorImport.Enabled = false;
            this.sectorImport.Location = new System.Drawing.Point(186, 70);
            this.sectorImport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorImport.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.sectorImport.Name = "sectorImport";
            this.sectorImport.Size = new System.Drawing.Size(59, 23);
            this.sectorImport.TabIndex = 7;
            this.sectorImport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sectorImport.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // galSize
            // 
            this.galSize.Enabled = false;
            this.galSize.Location = new System.Drawing.Point(119, 70);
            this.galSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.galSize.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.galSize.Name = "galSize";
            this.galSize.Size = new System.Drawing.Size(59, 23);
            this.galSize.TabIndex = 6;
            this.galSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.galSize.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // miscDATGroup
            // 
            this.miscDATGroup.Controls.Add(this.familyIdHexLabel);
            this.miscDATGroup.Controls.Add(this.productionFacility);
            this.miscDATGroup.Controls.Add(this.prodLabel);
            this.miscDATGroup.Controls.Add(this.SystemIdHexLabel);
            this.miscDATGroup.Controls.Add(this.secProdFacNumlabel);
            this.miscDATGroup.Controls.Add(this.nextProductionFacility);
            this.miscDATGroup.Controls.Add(this.systemId);
            this.miscDATGroup.Controls.Add(this.label5);
            this.miscDATGroup.Controls.Add(this.familyLabel);
            this.miscDATGroup.Controls.Add(this.idLabel);
            this.miscDATGroup.Controls.Add(this.familyId);
            this.miscDATGroup.Controls.Add(this.textStraDllId);
            this.miscDATGroup.Controls.Add(this.unknown3);
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
            // familyIdHexLabel
            // 
            this.familyIdHexLabel.AutoSize = true;
            this.familyIdHexLabel.Enabled = false;
            this.familyIdHexLabel.Location = new System.Drawing.Point(173, 82);
            this.familyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdHexLabel.Name = "familyIdHexLabel";
            this.familyIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.familyIdHexLabel.TabIndex = 1147;
            this.familyIdHexLabel.Text = "hex";
            // 
            // productionFacility
            // 
            this.productionFacility.Enabled = false;
            this.productionFacility.Location = new System.Drawing.Point(112, 16);
            this.productionFacility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productionFacility.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.productionFacility.Name = "productionFacility";
            this.productionFacility.Size = new System.Drawing.Size(59, 23);
            this.productionFacility.TabIndex = 0;
            this.productionFacility.TabStop = false;
            this.productionFacility.Value = new decimal(new int[] {
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
            // SystemIdHexLabel
            // 
            this.SystemIdHexLabel.AutoSize = true;
            this.SystemIdHexLabel.Enabled = false;
            this.SystemIdHexLabel.Location = new System.Drawing.Point(173, 170);
            this.SystemIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SystemIdHexLabel.Name = "SystemIdHexLabel";
            this.SystemIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.SystemIdHexLabel.TabIndex = 1146;
            this.SystemIdHexLabel.Text = "hex";
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
            // nextProductionFacility
            // 
            this.nextProductionFacility.Enabled = false;
            this.nextProductionFacility.Location = new System.Drawing.Point(112, 47);
            this.nextProductionFacility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextProductionFacility.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nextProductionFacility.Name = "nextProductionFacility";
            this.nextProductionFacility.Size = new System.Drawing.Size(59, 23);
            this.nextProductionFacility.TabIndex = 0;
            this.nextProductionFacility.TabStop = false;
            this.nextProductionFacility.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // systemId
            // 
            this.systemId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.systemId.Enabled = false;
            this.systemId.Location = new System.Drawing.Point(112, 167);
            this.systemId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.systemId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.systemId.Name = "systemId";
            this.systemId.Size = new System.Drawing.Size(59, 23);
            this.systemId.TabIndex = 1145;
            this.systemId.TabStop = false;
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
            // familyId
            // 
            this.familyId.Location = new System.Drawing.Point(112, 77);
            this.familyId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.familyId.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.familyId.Name = "familyId";
            this.familyId.Size = new System.Drawing.Size(59, 23);
            this.familyId.TabIndex = 0;
            this.familyId.TabStop = false;
            this.familyId.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.familyId.ValueChanged += new System.EventHandler(this.familyId_ValueChanged);
            // 
            // textStraDllId
            // 
            this.textStraDllId.Enabled = false;
            this.textStraDllId.Location = new System.Drawing.Point(112, 137);
            this.textStraDllId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textStraDllId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.textStraDllId.Name = "textStraDllId";
            this.textStraDllId.Size = new System.Drawing.Size(59, 23);
            this.textStraDllId.TabIndex = 0;
            this.textStraDllId.TabStop = false;
            this.textStraDllId.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // unknown3
            // 
            this.unknown3.Enabled = false;
            this.unknown3.Location = new System.Drawing.Point(112, 107);
            this.unknown3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknown3.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknown3.Name = "unknown3";
            this.unknown3.Size = new System.Drawing.Size(59, 23);
            this.unknown3.TabIndex = 0;
            this.unknown3.TabStop = false;
            this.unknown3.Value = new decimal(new int[] {
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
            this.BasicGroup.Controls.Add(this.pictureId);
            this.BasicGroup.Controls.Add(this.sectorId);
            this.BasicGroup.Controls.Add(this.loyaltyLabel);
            this.BasicGroup.Controls.Add(this.yPosition);
            this.BasicGroup.Controls.Add(this.combatLabel);
            this.BasicGroup.Controls.Add(this.unknown4);
            this.BasicGroup.Controls.Add(this.diploLabel);
            this.BasicGroup.Controls.Add(this.unknown5);
            this.BasicGroup.Controls.Add(this.xPosition);
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
            // pictureId
            // 
            this.pictureId.Enabled = false;
            this.pictureId.Location = new System.Drawing.Point(186, 129);
            this.pictureId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.pictureId.Name = "pictureId";
            this.pictureId.Size = new System.Drawing.Size(59, 23);
            this.pictureId.TabIndex = 11;
            this.pictureId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pictureId.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // sectorId
            // 
            this.sectorId.Enabled = false;
            this.sectorId.Location = new System.Drawing.Point(119, 129);
            this.sectorId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.sectorId.Name = "sectorId";
            this.sectorId.Size = new System.Drawing.Size(59, 23);
            this.sectorId.TabIndex = 10;
            this.sectorId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sectorId.Value = new decimal(new int[] {
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
            // yPosition
            // 
            this.yPosition.Enabled = false;
            this.yPosition.Location = new System.Drawing.Point(186, 69);
            this.yPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.yPosition.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.yPosition.Name = "yPosition";
            this.yPosition.Size = new System.Drawing.Size(59, 23);
            this.yPosition.TabIndex = 7;
            this.yPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.yPosition.Value = new decimal(new int[] {
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
            // unknown4
            // 
            this.unknown4.Enabled = false;
            this.unknown4.Location = new System.Drawing.Point(119, 99);
            this.unknown4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknown4.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.unknown4.Name = "unknown4";
            this.unknown4.Size = new System.Drawing.Size(59, 23);
            this.unknown4.TabIndex = 8;
            this.unknown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unknown4.Value = new decimal(new int[] {
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
            // unknown5
            // 
            this.unknown5.Enabled = false;
            this.unknown5.Location = new System.Drawing.Point(119, 36);
            this.unknown5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknown5.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.unknown5.Name = "unknown5";
            this.unknown5.Size = new System.Drawing.Size(59, 23);
            this.unknown5.TabIndex = 4;
            this.unknown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unknown5.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // xPosition
            // 
            this.xPosition.Enabled = false;
            this.xPosition.Location = new System.Drawing.Point(119, 69);
            this.xPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xPosition.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.xPosition.Name = "xPosition";
            this.xPosition.Size = new System.Drawing.Size(59, 23);
            this.xPosition.TabIndex = 6;
            this.xPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.xPosition.Value = new decimal(new int[] {
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
            this.tabPage2.Controls.Add(this.encyclopediaDescription);
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
            // encyclopediaDescription
            // 
            this.encyclopediaDescription.Cursor = System.Windows.Forms.Cursors.No;
            this.encyclopediaDescription.Enabled = false;
            this.encyclopediaDescription.Location = new System.Drawing.Point(0, 0);
            this.encyclopediaDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.encyclopediaDescription.Name = "encyclopediaDescription";
            this.encyclopediaDescription.Size = new System.Drawing.Size(559, 160);
            this.encyclopediaDescription.TabIndex = 134;
            this.encyclopediaDescription.TabStop = false;
            this.encyclopediaDescription.Text = "Not Implemented yet....Encylopedia Data...Will add .Someday";
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
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(0, -1);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(220, 110);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 156;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
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
            this.Controls.Add(this.systemsListView);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.encyclopediaName);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(837, 617);
            this.MinimumSize = new System.Drawing.Size(837, 617);
            this.Name = "SystemsForm";
            this.Text = "Systems (SYSTEMSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorProductionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorSectorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorNextProductionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorFamilyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorTextStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorUnknown3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorYpos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorXpos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galSize)).EndInit();
            this.miscDATGroup.ResumeLayout(false);
            this.miscDATGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown3)).EndInit();
            this.BasicGroup.ResumeLayout(false);
            this.BasicGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPosition)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}