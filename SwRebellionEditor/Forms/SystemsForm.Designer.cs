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
        private NumericUpDown pictureId;
        private Label systemIdLabel;
        private NumericUpDown yPosition;
        private Label combatLabel;
        private NumericUpDown unknown4;
        private Label unknown2Label;
        private NumericUpDown unknown3;
        private NumericUpDown xPosition;
        private Label positionLabel;
        private Label sectorName;
        private NumericUpDown productionFacility;
        private Label productionFacilityLabel;
        private Label nextProductionFacilityLabel;
        private NumericUpDown nextProductionFacility;
        private Label familyIdLabel;
        private Label textStraDllIdLabel;
        private NumericUpDown familyId;
        private NumericUpDown textStraDllId;
        private NumericUpDown unknown2;
        private Label unkown3Label;
        private GroupBox groupBox2;
        private NumericUpDown sectorProductionFacility;
        private Label label7;
        private Label label8;
        private NumericUpDown sectorNextProductionFacility;
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
        private NumericUpDown sectorYpos;
        private NumericUpDown sectorXpos;
        private Label label4;
        private Label label6;
        private Label secNameLabel;
        private Label familyIdHexLabel;
        private Label SystemIdHexLabel;
        private NumericUpDown systemId;
        private Label secfamHexLabel;
        private NumericUpDown sectorId;
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.secfamHexLabel = new System.Windows.Forms.Label();
            this.sectorProductionFacility = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sectorNextProductionFacility = new System.Windows.Forms.NumericUpDown();
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
            this.unknown2Label = new System.Windows.Forms.Label();
            this.unknown3 = new System.Windows.Forms.NumericUpDown();
            this.sectorId = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.productionFacility = new System.Windows.Forms.NumericUpDown();
            this.productionFacilityLabel = new System.Windows.Forms.Label();
            this.SystemIdHexLabel = new System.Windows.Forms.Label();
            this.nextProductionFacilityLabel = new System.Windows.Forms.Label();
            this.nextProductionFacility = new System.Windows.Forms.NumericUpDown();
            this.systemId = new System.Windows.Forms.NumericUpDown();
            this.familyIdLabel = new System.Windows.Forms.Label();
            this.textStraDllIdLabel = new System.Windows.Forms.Label();
            this.familyId = new System.Windows.Forms.NumericUpDown();
            this.textStraDllId = new System.Windows.Forms.NumericUpDown();
            this.unknown2 = new System.Windows.Forms.NumericUpDown();
            this.unkown3Label = new System.Windows.Forms.Label();
            this.pictureId = new System.Windows.Forms.NumericUpDown();
            this.systemIdLabel = new System.Windows.Forms.Label();
            this.yPosition = new System.Windows.Forms.NumericUpDown();
            this.combatLabel = new System.Windows.Forms.Label();
            this.unknown4 = new System.Windows.Forms.NumericUpDown();
            this.xPosition = new System.Windows.Forms.NumericUpDown();
            this.positionLabel = new System.Windows.Forms.Label();
            this.sectorName = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureIdLabel = new System.Windows.Forms.Label();
            this.unknown1 = new System.Windows.Forms.NumericUpDown();
            this.unknown1Label = new System.Windows.Forms.Label();
            this.encyclopediaGroupBox = new System.Windows.Forms.GroupBox();
            this.encyclopediaDescriptionLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.encyclopediaNameLabel = new System.Windows.Forms.Label();
            this.encyclopediaDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorProductionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorNextProductionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorFamilyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorTextStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorUnknown3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorYpos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorXpos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown1)).BeginInit();
            this.encyclopediaGroupBox.SuspendLayout();
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
            this.Open.Location = new System.Drawing.Point(527, 556);
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
            this.SaveAs.Location = new System.Drawing.Point(431, 556);
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
            this.Cancel.Location = new System.Drawing.Point(335, 556);
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
            this.Ok.Location = new System.Drawing.Point(239, 556);
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
            this.encyclopediaName.Location = new System.Drawing.Point(623, 42);
            this.encyclopediaName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encyclopediaName.Name = "encyclopediaName";
            this.encyclopediaName.Size = new System.Drawing.Size(116, 15);
            this.encyclopediaName.TabIndex = 155;
            this.encyclopediaName.Text = "-- Item name here --";
            // 
            // selector
            // 
            this.selector.LargeChange = 10;
            this.selector.Location = new System.Drawing.Point(228, 12);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 199;
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(288, 45);
            this.selector.TabIndex = 149;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.secfamHexLabel);
            this.groupBox2.Controls.Add(this.sectorProductionFacility);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.sectorNextProductionFacility);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.sectorFamilyId);
            this.groupBox2.Controls.Add(this.sectorTextStraDllId);
            this.groupBox2.Controls.Add(this.sectorUnknown3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(522, 368);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(204, 174);
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
            this.groupBox1.Location = new System.Drawing.Point(727, 368);
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
            // unknown2Label
            // 
            this.unknown2Label.AutoSize = true;
            this.unknown2Label.Location = new System.Drawing.Point(252, 239);
            this.unknown2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unknown2Label.Name = "unknown2Label";
            this.unknown2Label.Size = new System.Drawing.Size(66, 15);
            this.unknown2Label.TabIndex = 0;
            this.unknown2Label.Text = "unknown 2";
            // 
            // unknown3
            // 
            this.unknown3.Location = new System.Drawing.Point(390, 324);
            this.unknown3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknown3.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.unknown3.Name = "unknown3";
            this.unknown3.Size = new System.Drawing.Size(59, 23);
            this.unknown3.TabIndex = 4;
            this.unknown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unknown3.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.unknown3.ValueChanged += new System.EventHandler(this.unknown3_ValueChanged);
            // 
            // sectorId
            // 
            this.sectorId.BackColor = System.Drawing.SystemColors.Window;
            this.sectorId.Location = new System.Drawing.Point(390, 266);
            this.sectorId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.sectorId.Name = "sectorId";
            this.sectorId.Size = new System.Drawing.Size(59, 23);
            this.sectorId.TabIndex = 1149;
            this.sectorId.TabStop = false;
            this.sectorId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sectorId.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.sectorId.ValueChanged += new System.EventHandler(this.sectorId_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(252, 271);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 15);
            this.label15.TabIndex = 1148;
            this.label15.Text = "sector id";
            // 
            // familyIdHexLabel
            // 
            this.familyIdHexLabel.AutoSize = true;
            this.familyIdHexLabel.Enabled = false;
            this.familyIdHexLabel.Location = new System.Drawing.Point(457, 181);
            this.familyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdHexLabel.Name = "familyIdHexLabel";
            this.familyIdHexLabel.Size = new System.Drawing.Size(31, 15);
            this.familyIdHexLabel.TabIndex = 1147;
            this.familyIdHexLabel.Text = "0x00";
            // 
            // productionFacility
            // 
            this.productionFacility.Location = new System.Drawing.Point(390, 121);
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
            this.productionFacility.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.productionFacility.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.productionFacility.ValueChanged += new System.EventHandler(this.productionFacility_ValueChanged);
            // 
            // productionFacilityLabel
            // 
            this.productionFacilityLabel.AutoSize = true;
            this.productionFacilityLabel.Location = new System.Drawing.Point(248, 123);
            this.productionFacilityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productionFacilityLabel.Name = "productionFacilityLabel";
            this.productionFacilityLabel.Size = new System.Drawing.Size(104, 15);
            this.productionFacilityLabel.TabIndex = 0;
            this.productionFacilityLabel.Text = "production facility";
            // 
            // SystemIdHexLabel
            // 
            this.SystemIdHexLabel.AutoSize = true;
            this.SystemIdHexLabel.Enabled = false;
            this.SystemIdHexLabel.Location = new System.Drawing.Point(457, 65);
            this.SystemIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SystemIdHexLabel.Name = "SystemIdHexLabel";
            this.SystemIdHexLabel.Size = new System.Drawing.Size(31, 15);
            this.SystemIdHexLabel.TabIndex = 1146;
            this.SystemIdHexLabel.Text = "0x00";
            // 
            // nextProductionFacilityLabel
            // 
            this.nextProductionFacilityLabel.AutoSize = true;
            this.nextProductionFacilityLabel.Location = new System.Drawing.Point(248, 152);
            this.nextProductionFacilityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nextProductionFacilityLabel.Name = "nextProductionFacilityLabel";
            this.nextProductionFacilityLabel.Size = new System.Drawing.Size(130, 15);
            this.nextProductionFacilityLabel.TabIndex = 0;
            this.nextProductionFacilityLabel.Text = "next production facility";
            // 
            // nextProductionFacility
            // 
            this.nextProductionFacility.Location = new System.Drawing.Point(390, 150);
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
            this.nextProductionFacility.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nextProductionFacility.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nextProductionFacility.ValueChanged += new System.EventHandler(this.nextProductionFacility_ValueChanged);
            // 
            // systemId
            // 
            this.systemId.BackColor = System.Drawing.SystemColors.Window;
            this.systemId.Location = new System.Drawing.Point(390, 63);
            this.systemId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.systemId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.systemId.Name = "systemId";
            this.systemId.Size = new System.Drawing.Size(59, 23);
            this.systemId.TabIndex = 1145;
            this.systemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.systemId.ValueChanged += new System.EventHandler(this.systemId_ValueChanged);
            // 
            // familyIdLabel
            // 
            this.familyIdLabel.AutoSize = true;
            this.familyIdLabel.Location = new System.Drawing.Point(252, 181);
            this.familyIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdLabel.Name = "familyIdLabel";
            this.familyIdLabel.Size = new System.Drawing.Size(53, 15);
            this.familyIdLabel.TabIndex = 0;
            this.familyIdLabel.Text = "family id";
            // 
            // textStraDllIdLabel
            // 
            this.textStraDllIdLabel.AutoSize = true;
            this.textStraDllIdLabel.Location = new System.Drawing.Point(252, 210);
            this.textStraDllIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textStraDllIdLabel.Name = "textStraDllIdLabel";
            this.textStraDllIdLabel.Size = new System.Drawing.Size(75, 15);
            this.textStraDllIdLabel.TabIndex = 0;
            this.textStraDllIdLabel.Text = "textstra.dll id";
            // 
            // familyId
            // 
            this.familyId.Location = new System.Drawing.Point(390, 179);
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
            this.familyId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.familyId.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.familyId.ValueChanged += new System.EventHandler(this.familyId_ValueChanged);
            // 
            // textStraDllId
            // 
            this.textStraDllId.Location = new System.Drawing.Point(390, 208);
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
            this.textStraDllId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textStraDllId.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.textStraDllId.ValueChanged += new System.EventHandler(this.textStraDllId_ValueChanged);
            // 
            // unknown2
            // 
            this.unknown2.Location = new System.Drawing.Point(390, 237);
            this.unknown2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknown2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknown2.Name = "unknown2";
            this.unknown2.Size = new System.Drawing.Size(59, 23);
            this.unknown2.TabIndex = 0;
            this.unknown2.TabStop = false;
            this.unknown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unknown2.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknown2.ValueChanged += new System.EventHandler(this.unknown2_ValueChanged);
            // 
            // unkown3Label
            // 
            this.unkown3Label.AutoSize = true;
            this.unkown3Label.Location = new System.Drawing.Point(252, 326);
            this.unkown3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unkown3Label.Name = "unkown3Label";
            this.unkown3Label.Size = new System.Drawing.Size(66, 15);
            this.unkown3Label.TabIndex = 0;
            this.unkown3Label.Text = "unknown 3";
            // 
            // pictureId
            // 
            this.pictureId.Location = new System.Drawing.Point(390, 295);
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
            this.pictureId.ValueChanged += new System.EventHandler(this.pictureId_ValueChanged);
            // 
            // systemIdLabel
            // 
            this.systemIdLabel.AutoSize = true;
            this.systemIdLabel.Location = new System.Drawing.Point(248, 65);
            this.systemIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.systemIdLabel.Name = "systemIdLabel";
            this.systemIdLabel.Size = new System.Drawing.Size(57, 15);
            this.systemIdLabel.TabIndex = 12;
            this.systemIdLabel.Text = "system id";
            // 
            // yPosition
            // 
            this.yPosition.Location = new System.Drawing.Point(457, 353);
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
            this.yPosition.ValueChanged += new System.EventHandler(this.yPosition_ValueChanged);
            // 
            // combatLabel
            // 
            this.combatLabel.AutoSize = true;
            this.combatLabel.Location = new System.Drawing.Point(252, 384);
            this.combatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.combatLabel.Name = "combatLabel";
            this.combatLabel.Size = new System.Drawing.Size(66, 15);
            this.combatLabel.TabIndex = 0;
            this.combatLabel.Text = "unknown 4";
            // 
            // unknown4
            // 
            this.unknown4.Location = new System.Drawing.Point(390, 382);
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
            this.unknown4.ValueChanged += new System.EventHandler(this.unknown4_ValueChanged);
            // 
            // xPosition
            // 
            this.xPosition.Location = new System.Drawing.Point(390, 353);
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
            this.xPosition.ValueChanged += new System.EventHandler(this.xPosition_ValueChanged);
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(252, 355);
            this.positionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(81, 15);
            this.positionLabel.TabIndex = 0;
            this.positionLabel.Text = "position (X, Y)";
            // 
            // sectorName
            // 
            this.sectorName.AutoSize = true;
            this.sectorName.Location = new System.Drawing.Point(770, 42);
            this.sectorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sectorName.Name = "sectorName";
            this.sectorName.Size = new System.Drawing.Size(116, 15);
            this.sectorName.TabIndex = 157;
            this.sectorName.Text = "-- Item name here --";
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
            this.label12.Location = new System.Drawing.Point(585, 12);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(325, 15);
            this.label12.TabIndex = 158;
            this.label12.Text = "***** System Family ID may be updated 144 = core 146= Rim";
            // 
            // pictureIdLabel
            // 
            this.pictureIdLabel.AutoSize = true;
            this.pictureIdLabel.Location = new System.Drawing.Point(252, 297);
            this.pictureIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pictureIdLabel.Name = "pictureIdLabel";
            this.pictureIdLabel.Size = new System.Drawing.Size(57, 15);
            this.pictureIdLabel.TabIndex = 1150;
            this.pictureIdLabel.Text = "picture id";
            // 
            // unknown1
            // 
            this.unknown1.Location = new System.Drawing.Point(390, 92);
            this.unknown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknown1.Name = "unknown1";
            this.unknown1.Size = new System.Drawing.Size(59, 23);
            this.unknown1.TabIndex = 1151;
            this.unknown1.TabStop = false;
            this.unknown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unknown1.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknown1.ValueChanged += new System.EventHandler(this.unknown1_ValueChanged);
            // 
            // unknown1Label
            // 
            this.unknown1Label.AutoSize = true;
            this.unknown1Label.Location = new System.Drawing.Point(248, 94);
            this.unknown1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unknown1Label.Name = "unknown1Label";
            this.unknown1Label.Size = new System.Drawing.Size(66, 15);
            this.unknown1Label.TabIndex = 1152;
            this.unknown1Label.Text = "unknown 1";
            // 
            // encyclopediaGroupBox
            // 
            this.encyclopediaGroupBox.Controls.Add(this.encyclopediaDescriptionLabel);
            this.encyclopediaGroupBox.Controls.Add(this.textBox1);
            this.encyclopediaGroupBox.Controls.Add(this.encyclopediaNameLabel);
            this.encyclopediaGroupBox.Controls.Add(this.encyclopediaDescription);
            this.encyclopediaGroupBox.Location = new System.Drawing.Point(535, 65);
            this.encyclopediaGroupBox.Name = "encyclopediaGroupBox";
            this.encyclopediaGroupBox.Size = new System.Drawing.Size(451, 284);
            this.encyclopediaGroupBox.TabIndex = 1153;
            this.encyclopediaGroupBox.TabStop = false;
            this.encyclopediaGroupBox.Text = "encyclopedia";
            // 
            // encyclopediaDescriptionLabel
            // 
            this.encyclopediaDescriptionLabel.AutoSize = true;
            this.encyclopediaDescriptionLabel.Location = new System.Drawing.Point(17, 49);
            this.encyclopediaDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encyclopediaDescriptionLabel.Name = "encyclopediaDescriptionLabel";
            this.encyclopediaDescriptionLabel.Size = new System.Drawing.Size(66, 15);
            this.encyclopediaDescriptionLabel.TabIndex = 170;
            this.encyclopediaDescriptionLabel.Text = "description";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(112, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 23);
            this.textBox1.TabIndex = 169;
            // 
            // encyclopediaNameLabel
            // 
            this.encyclopediaNameLabel.AutoSize = true;
            this.encyclopediaNameLabel.Location = new System.Drawing.Point(17, 24);
            this.encyclopediaNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encyclopediaNameLabel.Name = "encyclopediaNameLabel";
            this.encyclopediaNameLabel.Size = new System.Drawing.Size(77, 15);
            this.encyclopediaNameLabel.TabIndex = 168;
            this.encyclopediaNameLabel.Text = "system name";
            // 
            // encyclopediaDescription
            // 
            this.encyclopediaDescription.Cursor = System.Windows.Forms.Cursors.No;
            this.encyclopediaDescription.Enabled = false;
            this.encyclopediaDescription.Location = new System.Drawing.Point(7, 70);
            this.encyclopediaDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.encyclopediaDescription.Name = "encyclopediaDescription";
            this.encyclopediaDescription.Size = new System.Drawing.Size(436, 208);
            this.encyclopediaDescription.TabIndex = 134;
            this.encyclopediaDescription.TabStop = false;
            this.encyclopediaDescription.Text = "Not Implemented yet....Encylopedia Data...Will add .Someday";
            // 
            // SystemsForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(999, 594);
            this.Controls.Add(this.encyclopediaGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.unknown1Label);
            this.Controls.Add(this.unknown1);
            this.Controls.Add(this.unknown2Label);
            this.Controls.Add(this.combatLabel);
            this.Controls.Add(this.unknown3);
            this.Controls.Add(this.pictureIdLabel);
            this.Controls.Add(this.unknown4);
            this.Controls.Add(this.unkown3Label);
            this.Controls.Add(this.unknown2);
            this.Controls.Add(this.pictureId);
            this.Controls.Add(this.familyIdHexLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nextProductionFacility);
            this.Controls.Add(this.textStraDllId);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.sectorId);
            this.Controls.Add(this.textStraDllIdLabel);
            this.Controls.Add(this.familyIdLabel);
            this.Controls.Add(this.familyId);
            this.Controls.Add(this.nextProductionFacilityLabel);
            this.Controls.Add(this.productionFacilityLabel);
            this.Controls.Add(this.productionFacility);
            this.Controls.Add(this.systemIdLabel);
            this.Controls.Add(this.SystemIdHexLabel);
            this.Controls.Add(this.sectorName);
            this.Controls.Add(this.yPosition);
            this.Controls.Add(this.systemsListView);
            this.Controls.Add(this.systemId);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.xPosition);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.encyclopediaName);
            this.Controls.Add(this.selector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "SystemsForm";
            this.Text = "Systems (SYSTEMSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorProductionFacility)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.unknown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown1)).EndInit();
            this.encyclopediaGroupBox.ResumeLayout(false);
            this.encyclopediaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label pictureIdLabel;
        private NumericUpDown unknown1;
        private Label unknown1Label;
        private GroupBox encyclopediaGroupBox;
        private Label encyclopediaDescriptionLabel;
        private TextBox textBox1;
        private Label encyclopediaNameLabel;
        private RichTextBox encyclopediaDescription;
    }
}