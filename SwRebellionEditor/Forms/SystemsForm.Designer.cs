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
        private NumericUpDown pictureId;
        private Label systemIdLabel;
        private NumericUpDown yPosition;
        private Label combatLabel;
        private NumericUpDown unknown4;
        private Label unknown2Label;
        private NumericUpDown unknown3;
        private NumericUpDown xPosition;
        private Label positionLabel;
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
        private GroupBox sectorGroupBox;
        private Label sectorTextStraDllIdLabel;
        private NumericUpDown sectorFamilyId;
        private NumericUpDown sectorTextStraDllId;
        private NumericUpDown sectorSecImport;
        private NumericUpDown sectorGalaxySize;
        private NumericUpDown sectorYPosition;
        private NumericUpDown sectorXPosition;
        private Label label4;
        private Label familyIdHexLabel;
        private Label SystemIdHexLabel;
        private NumericUpDown systemId;
        private Label sectorFamilyIdHexLabel;
        private NumericUpDown sectorId;
        private Label label15;
        private Label familyIdInfoLabel;

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
            this.selector = new System.Windows.Forms.TrackBar();
            this.sectorGroupBox = new System.Windows.Forms.GroupBox();
            this.sectorGalaxySizeLabel = new System.Windows.Forms.Label();
            this.sectorSecImportLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sectorYPosition = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.sectorFamilyIdHexLabel = new System.Windows.Forms.Label();
            this.sectorFamilyId = new System.Windows.Forms.NumericUpDown();
            this.sectorXPosition = new System.Windows.Forms.NumericUpDown();
            this.sectorTextStraDllIdLabel = new System.Windows.Forms.Label();
            this.sectorTextStraDllId = new System.Windows.Forms.NumericUpDown();
            this.sectorSecImport = new System.Windows.Forms.NumericUpDown();
            this.sectorGalaxySize = new System.Windows.Forms.NumericUpDown();
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.familyIdInfoLabel = new System.Windows.Forms.Label();
            this.pictureIdLabel = new System.Windows.Forms.Label();
            this.unknown1 = new System.Windows.Forms.NumericUpDown();
            this.unknown1Label = new System.Windows.Forms.Label();
            this.encyclopediaGroupBox = new System.Windows.Forms.GroupBox();
            this.sectorEncyclopediaName = new System.Windows.Forms.TextBox();
            this.sectorEncyclopediaLabel = new System.Windows.Forms.Label();
            this.encyclopediaDescriptionLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.encyclopediaNameLabel = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            this.sectorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorYPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorFamilyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorXPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorTextStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorSecImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorGalaxySize)).BeginInit();
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
            this.systemsListView.Size = new System.Drawing.Size(220, 394);
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
            this.Open.Location = new System.Drawing.Point(527, 475);
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
            this.SaveAs.Location = new System.Drawing.Point(431, 475);
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
            this.Cancel.Location = new System.Drawing.Point(335, 475);
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
            this.Ok.Location = new System.Drawing.Point(239, 475);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 153;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // selector
            // 
            this.selector.LargeChange = 10;
            this.selector.Location = new System.Drawing.Point(228, 12);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 199;
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(275, 45);
            this.selector.TabIndex = 149;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            // 
            // sectorGroupBox
            // 
            this.sectorGroupBox.Controls.Add(this.sectorGalaxySizeLabel);
            this.sectorGroupBox.Controls.Add(this.sectorSecImportLabel);
            this.sectorGroupBox.Controls.Add(this.label4);
            this.sectorGroupBox.Controls.Add(this.sectorYPosition);
            this.sectorGroupBox.Controls.Add(this.label1);
            this.sectorGroupBox.Controls.Add(this.sectorFamilyIdHexLabel);
            this.sectorGroupBox.Controls.Add(this.sectorFamilyId);
            this.sectorGroupBox.Controls.Add(this.sectorXPosition);
            this.sectorGroupBox.Controls.Add(this.sectorTextStraDllIdLabel);
            this.sectorGroupBox.Controls.Add(this.sectorTextStraDllId);
            this.sectorGroupBox.Controls.Add(this.sectorSecImport);
            this.sectorGroupBox.Controls.Add(this.sectorGalaxySize);
            this.sectorGroupBox.Location = new System.Drawing.Point(517, 295);
            this.sectorGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorGroupBox.Name = "sectorGroupBox";
            this.sectorGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorGroupBox.Size = new System.Drawing.Size(451, 174);
            this.sectorGroupBox.TabIndex = 14;
            this.sectorGroupBox.TabStop = false;
            this.sectorGroupBox.Text = "sector (SECTORSD.DAT)";
            // 
            // sectorGalaxySizeLabel
            // 
            this.sectorGalaxySizeLabel.AutoSize = true;
            this.sectorGalaxySizeLabel.Enabled = false;
            this.sectorGalaxySizeLabel.Location = new System.Drawing.Point(17, 114);
            this.sectorGalaxySizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sectorGalaxySizeLabel.Name = "sectorGalaxySizeLabel";
            this.sectorGalaxySizeLabel.Size = new System.Drawing.Size(63, 15);
            this.sectorGalaxySizeLabel.TabIndex = 1152;
            this.sectorGalaxySizeLabel.Text = "galaxy size";
            // 
            // sectorSecImportLabel
            // 
            this.sectorSecImportLabel.AutoSize = true;
            this.sectorSecImportLabel.Enabled = false;
            this.sectorSecImportLabel.Location = new System.Drawing.Point(16, 85);
            this.sectorSecImportLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sectorSecImportLabel.Name = "sectorSecImportLabel";
            this.sectorSecImportLabel.Size = new System.Drawing.Size(63, 15);
            this.sectorSecImportLabel.TabIndex = 1155;
            this.sectorSecImportLabel.Text = "sec import";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(18, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "position (X, Y)";
            // 
            // sectorYPosition
            // 
            this.sectorYPosition.Enabled = false;
            this.sectorYPosition.Location = new System.Drawing.Point(212, 141);
            this.sectorYPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorYPosition.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.sectorYPosition.Name = "sectorYPosition";
            this.sectorYPosition.Size = new System.Drawing.Size(59, 23);
            this.sectorYPosition.TabIndex = 14;
            this.sectorYPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sectorYPosition.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1154;
            this.label1.Text = "family id";
            // 
            // sectorFamilyIdHexLabel
            // 
            this.sectorFamilyIdHexLabel.AutoSize = true;
            this.sectorFamilyIdHexLabel.Enabled = false;
            this.sectorFamilyIdHexLabel.Location = new System.Drawing.Point(212, 29);
            this.sectorFamilyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sectorFamilyIdHexLabel.Name = "sectorFamilyIdHexLabel";
            this.sectorFamilyIdHexLabel.Size = new System.Drawing.Size(31, 15);
            this.sectorFamilyIdHexLabel.TabIndex = 1151;
            this.sectorFamilyIdHexLabel.Text = "0x00";
            // 
            // sectorFamilyId
            // 
            this.sectorFamilyId.Enabled = false;
            this.sectorFamilyId.Location = new System.Drawing.Point(145, 25);
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
            this.sectorFamilyId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sectorFamilyId.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // sectorXPosition
            // 
            this.sectorXPosition.Enabled = false;
            this.sectorXPosition.Location = new System.Drawing.Point(145, 141);
            this.sectorXPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorXPosition.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.sectorXPosition.Name = "sectorXPosition";
            this.sectorXPosition.Size = new System.Drawing.Size(59, 23);
            this.sectorXPosition.TabIndex = 13;
            this.sectorXPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sectorXPosition.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // sectorTextStraDllIdLabel
            // 
            this.sectorTextStraDllIdLabel.AutoSize = true;
            this.sectorTextStraDllIdLabel.Enabled = false;
            this.sectorTextStraDllIdLabel.Location = new System.Drawing.Point(17, 56);
            this.sectorTextStraDllIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sectorTextStraDllIdLabel.Name = "sectorTextStraDllIdLabel";
            this.sectorTextStraDllIdLabel.Size = new System.Drawing.Size(75, 15);
            this.sectorTextStraDllIdLabel.TabIndex = 0;
            this.sectorTextStraDllIdLabel.Text = "textstra.dll id";
            // 
            // sectorTextStraDllId
            // 
            this.sectorTextStraDllId.Enabled = false;
            this.sectorTextStraDllId.Location = new System.Drawing.Point(145, 54);
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
            this.sectorTextStraDllId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sectorTextStraDllId.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // sectorSecImport
            // 
            this.sectorSecImport.Enabled = false;
            this.sectorSecImport.Location = new System.Drawing.Point(145, 83);
            this.sectorSecImport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorSecImport.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.sectorSecImport.Name = "sectorSecImport";
            this.sectorSecImport.Size = new System.Drawing.Size(59, 23);
            this.sectorSecImport.TabIndex = 7;
            this.sectorSecImport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sectorSecImport.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // sectorGalaxySize
            // 
            this.sectorGalaxySize.Enabled = false;
            this.sectorGalaxySize.Location = new System.Drawing.Point(145, 112);
            this.sectorGalaxySize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorGalaxySize.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.sectorGalaxySize.Name = "sectorGalaxySize";
            this.sectorGalaxySize.Size = new System.Drawing.Size(59, 23);
            this.sectorGalaxySize.TabIndex = 6;
            this.sectorGalaxySize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sectorGalaxySize.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // unknown2Label
            // 
            this.unknown2Label.AutoSize = true;
            this.unknown2Label.Location = new System.Drawing.Point(239, 252);
            this.unknown2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unknown2Label.Name = "unknown2Label";
            this.unknown2Label.Size = new System.Drawing.Size(66, 15);
            this.unknown2Label.TabIndex = 0;
            this.unknown2Label.Text = "unknown 2";
            // 
            // unknown3
            // 
            this.unknown3.Location = new System.Drawing.Point(377, 337);
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
            this.sectorId.Location = new System.Drawing.Point(377, 279);
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
            this.label15.Location = new System.Drawing.Point(239, 284);
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
            this.familyIdHexLabel.Location = new System.Drawing.Point(444, 181);
            this.familyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdHexLabel.Name = "familyIdHexLabel";
            this.familyIdHexLabel.Size = new System.Drawing.Size(31, 15);
            this.familyIdHexLabel.TabIndex = 1147;
            this.familyIdHexLabel.Text = "0x00";
            // 
            // productionFacility
            // 
            this.productionFacility.Location = new System.Drawing.Point(377, 121);
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
            this.productionFacilityLabel.Location = new System.Drawing.Point(235, 123);
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
            this.SystemIdHexLabel.Location = new System.Drawing.Point(444, 65);
            this.SystemIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SystemIdHexLabel.Name = "SystemIdHexLabel";
            this.SystemIdHexLabel.Size = new System.Drawing.Size(31, 15);
            this.SystemIdHexLabel.TabIndex = 1146;
            this.SystemIdHexLabel.Text = "0x00";
            // 
            // nextProductionFacilityLabel
            // 
            this.nextProductionFacilityLabel.AutoSize = true;
            this.nextProductionFacilityLabel.Location = new System.Drawing.Point(235, 152);
            this.nextProductionFacilityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nextProductionFacilityLabel.Name = "nextProductionFacilityLabel";
            this.nextProductionFacilityLabel.Size = new System.Drawing.Size(130, 15);
            this.nextProductionFacilityLabel.TabIndex = 0;
            this.nextProductionFacilityLabel.Text = "next production facility";
            // 
            // nextProductionFacility
            // 
            this.nextProductionFacility.Location = new System.Drawing.Point(377, 150);
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
            this.systemId.Location = new System.Drawing.Point(377, 63);
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
            this.familyIdLabel.Location = new System.Drawing.Point(239, 181);
            this.familyIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdLabel.Name = "familyIdLabel";
            this.familyIdLabel.Size = new System.Drawing.Size(53, 15);
            this.familyIdLabel.TabIndex = 0;
            this.familyIdLabel.Text = "family id";
            // 
            // textStraDllIdLabel
            // 
            this.textStraDllIdLabel.AutoSize = true;
            this.textStraDllIdLabel.Location = new System.Drawing.Point(239, 223);
            this.textStraDllIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textStraDllIdLabel.Name = "textStraDllIdLabel";
            this.textStraDllIdLabel.Size = new System.Drawing.Size(75, 15);
            this.textStraDllIdLabel.TabIndex = 0;
            this.textStraDllIdLabel.Text = "textstra.dll id";
            // 
            // familyId
            // 
            this.familyId.Location = new System.Drawing.Point(377, 179);
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
            this.textStraDllId.Location = new System.Drawing.Point(377, 221);
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
            this.unknown2.Location = new System.Drawing.Point(377, 250);
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
            this.unkown3Label.Location = new System.Drawing.Point(239, 339);
            this.unkown3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unkown3Label.Name = "unkown3Label";
            this.unkown3Label.Size = new System.Drawing.Size(66, 15);
            this.unkown3Label.TabIndex = 0;
            this.unkown3Label.Text = "unknown 3";
            // 
            // pictureId
            // 
            this.pictureId.Location = new System.Drawing.Point(377, 308);
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
            this.systemIdLabel.Location = new System.Drawing.Point(235, 65);
            this.systemIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.systemIdLabel.Name = "systemIdLabel";
            this.systemIdLabel.Size = new System.Drawing.Size(57, 15);
            this.systemIdLabel.TabIndex = 12;
            this.systemIdLabel.Text = "system id";
            // 
            // yPosition
            // 
            this.yPosition.Location = new System.Drawing.Point(444, 366);
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
            this.combatLabel.Location = new System.Drawing.Point(239, 397);
            this.combatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.combatLabel.Name = "combatLabel";
            this.combatLabel.Size = new System.Drawing.Size(66, 15);
            this.combatLabel.TabIndex = 0;
            this.combatLabel.Text = "unknown 4";
            // 
            // unknown4
            // 
            this.unknown4.Location = new System.Drawing.Point(377, 395);
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
            this.xPosition.Location = new System.Drawing.Point(377, 366);
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
            this.positionLabel.Location = new System.Drawing.Point(239, 368);
            this.positionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(81, 15);
            this.positionLabel.TabIndex = 0;
            this.positionLabel.Text = "position (X, Y)";
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
            // familyIdInfoLabel
            // 
            this.familyIdInfoLabel.AutoSize = true;
            this.familyIdInfoLabel.Location = new System.Drawing.Point(249, 196);
            this.familyIdInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdInfoLabel.Name = "familyIdInfoLabel";
            this.familyIdInfoLabel.Size = new System.Drawing.Size(120, 15);
            this.familyIdInfoLabel.TabIndex = 158;
            this.familyIdInfoLabel.Text = "144 = Core, 146= Rim";
            // 
            // pictureIdLabel
            // 
            this.pictureIdLabel.AutoSize = true;
            this.pictureIdLabel.Location = new System.Drawing.Point(239, 310);
            this.pictureIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pictureIdLabel.Name = "pictureIdLabel";
            this.pictureIdLabel.Size = new System.Drawing.Size(57, 15);
            this.pictureIdLabel.TabIndex = 1150;
            this.pictureIdLabel.Text = "picture id";
            // 
            // unknown1
            // 
            this.unknown1.Location = new System.Drawing.Point(377, 92);
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
            this.unknown1Label.Location = new System.Drawing.Point(235, 94);
            this.unknown1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unknown1Label.Name = "unknown1Label";
            this.unknown1Label.Size = new System.Drawing.Size(66, 15);
            this.unknown1Label.TabIndex = 1152;
            this.unknown1Label.Text = "unknown 1";
            // 
            // encyclopediaGroupBox
            // 
            this.encyclopediaGroupBox.Controls.Add(this.sectorEncyclopediaName);
            this.encyclopediaGroupBox.Controls.Add(this.sectorEncyclopediaLabel);
            this.encyclopediaGroupBox.Controls.Add(this.encyclopediaDescriptionLabel);
            this.encyclopediaGroupBox.Controls.Add(this.name);
            this.encyclopediaGroupBox.Controls.Add(this.encyclopediaNameLabel);
            this.encyclopediaGroupBox.Controls.Add(this.description);
            this.encyclopediaGroupBox.Location = new System.Drawing.Point(517, 5);
            this.encyclopediaGroupBox.Name = "encyclopediaGroupBox";
            this.encyclopediaGroupBox.Size = new System.Drawing.Size(451, 284);
            this.encyclopediaGroupBox.TabIndex = 1153;
            this.encyclopediaGroupBox.TabStop = false;
            this.encyclopediaGroupBox.Text = "encyclopedia";
            // 
            // sectorEncyclopediaName
            // 
            this.sectorEncyclopediaName.Enabled = false;
            this.sectorEncyclopediaName.Location = new System.Drawing.Point(111, 253);
            this.sectorEncyclopediaName.Name = "sectorEncyclopediaName";
            this.sectorEncyclopediaName.Size = new System.Drawing.Size(331, 23);
            this.sectorEncyclopediaName.TabIndex = 172;
            // 
            // sectorEncyclopediaLabel
            // 
            this.sectorEncyclopediaLabel.AutoSize = true;
            this.sectorEncyclopediaLabel.Location = new System.Drawing.Point(16, 256);
            this.sectorEncyclopediaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sectorEncyclopediaLabel.Name = "sectorEncyclopediaLabel";
            this.sectorEncyclopediaLabel.Size = new System.Drawing.Size(72, 15);
            this.sectorEncyclopediaLabel.TabIndex = 171;
            this.sectorEncyclopediaLabel.Text = "sector name";
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
            // name
            // 
            this.name.Location = new System.Drawing.Point(112, 21);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(331, 23);
            this.name.TabIndex = 169;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
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
            // description
            // 
            this.description.Cursor = System.Windows.Forms.Cursors.No;
            this.description.Enabled = false;
            this.description.Location = new System.Drawing.Point(7, 70);
            this.description.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(436, 172);
            this.description.TabIndex = 134;
            this.description.TabStop = false;
            this.description.Text = "Not Implemented yet....Encylopedia Data...Will add .Someday";
            // 
            // SystemsForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(980, 510);
            this.Controls.Add(this.encyclopediaGroupBox);
            this.Controls.Add(this.sectorGroupBox);
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
            this.Controls.Add(this.familyIdInfoLabel);
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
            this.sectorGroupBox.ResumeLayout(false);
            this.sectorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorYPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorFamilyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorXPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorTextStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorSecImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorGalaxySize)).EndInit();
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
        private TextBox name;
        private Label encyclopediaNameLabel;
        private RichTextBox description;
        private Label sectorGalaxySizeLabel;
        private Label label1;
        private TextBox sectorEncyclopediaName;
        private Label sectorEncyclopediaLabel;
        private Label sectorSecImportLabel;
    }
}