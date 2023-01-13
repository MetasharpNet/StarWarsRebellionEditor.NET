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
        private Label idLabel;
        private NumericUpDown yPosition;
        private Label field13_0Label;
        private NumericUpDown field13_0;
        private Label Field7_2Label;
        private NumericUpDown field10_1;
        private NumericUpDown xPosition;
        private Label positionLabel;
        private NumericUpDown productionFamily_0;
        private Label productionFamily_0Label;
        private Label nextProductionFamily_0Label;
        private NumericUpDown nextProductionFamily_0;
        private Label familyIdLabel;
        private Label textStraDllIdLabel;
        private NumericUpDown familyId;
        private NumericUpDown textStraDllId;
        private NumericUpDown field7_2;
        private Label field10_1Label;
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
        private Label idHexLabel;
        private NumericUpDown id;
        private Label sectorFamilyIdHexLabel;
        private NumericUpDown sectorId;
        private Label sectorIdLabel;
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
            this.sectorName = new System.Windows.Forms.TextBox();
            this.sectorGalaxySizeLabel = new System.Windows.Forms.Label();
            this.sectorNameLabel = new System.Windows.Forms.Label();
            this.sectorSecImportLabel = new System.Windows.Forms.Label();
            this.sectorFamilyIdHexLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sectorFamilyId = new System.Windows.Forms.NumericUpDown();
            this.sectorYPosition = new System.Windows.Forms.NumericUpDown();
            this.sectorFamilyIdLabel = new System.Windows.Forms.Label();
            this.sectorTextStraDllIdLabel = new System.Windows.Forms.Label();
            this.sectorXPosition = new System.Windows.Forms.NumericUpDown();
            this.sectorTextStraDllId = new System.Windows.Forms.NumericUpDown();
            this.sectorSecImport = new System.Windows.Forms.NumericUpDown();
            this.sectorGalaxySize = new System.Windows.Forms.NumericUpDown();
            this.Field7_2Label = new System.Windows.Forms.Label();
            this.field10_1 = new System.Windows.Forms.NumericUpDown();
            this.sectorId = new System.Windows.Forms.NumericUpDown();
            this.sectorIdLabel = new System.Windows.Forms.Label();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.productionFamily_0 = new System.Windows.Forms.NumericUpDown();
            this.productionFamily_0Label = new System.Windows.Forms.Label();
            this.idHexLabel = new System.Windows.Forms.Label();
            this.nextProductionFamily_0Label = new System.Windows.Forms.Label();
            this.nextProductionFamily_0 = new System.Windows.Forms.NumericUpDown();
            this.id = new System.Windows.Forms.NumericUpDown();
            this.familyIdLabel = new System.Windows.Forms.Label();
            this.textStraDllIdLabel = new System.Windows.Forms.Label();
            this.familyId = new System.Windows.Forms.NumericUpDown();
            this.textStraDllId = new System.Windows.Forms.NumericUpDown();
            this.field7_2 = new System.Windows.Forms.NumericUpDown();
            this.field10_1Label = new System.Windows.Forms.Label();
            this.pictureId = new System.Windows.Forms.NumericUpDown();
            this.idLabel = new System.Windows.Forms.Label();
            this.yPosition = new System.Windows.Forms.NumericUpDown();
            this.field13_0Label = new System.Windows.Forms.Label();
            this.field13_0 = new System.Windows.Forms.NumericUpDown();
            this.xPosition = new System.Windows.Forms.NumericUpDown();
            this.positionLabel = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.familyIdInfoLabel = new System.Windows.Forms.Label();
            this.pictureIdLabel = new System.Windows.Forms.Label();
            this.field2_1 = new System.Windows.Forms.NumericUpDown();
            this.field2_1Label = new System.Windows.Forms.Label();
            this.inGameDataGroupBox = new System.Windows.Forms.GroupBox();
            this.encyclopediaDescriptionLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.encyclopediaDescription = new System.Windows.Forms.RichTextBox();
            this.hiddenDataGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            this.sectorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorFamilyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorYPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorXPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorTextStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorSecImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorGalaxySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field10_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFamily_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFamily_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field13_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2_1)).BeginInit();
            this.inGameDataGroupBox.SuspendLayout();
            this.hiddenDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // systemsListView
            // 
            this.systemsListView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.systemsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.systemsListView.GridLines = true;
            this.systemsListView.LargeImageList = this.systemsImageList;
            this.systemsListView.Location = new System.Drawing.Point(4, 3);
            this.systemsListView.Margin = new System.Windows.Forms.Padding(0);
            this.systemsListView.MultiSelect = false;
            this.systemsListView.Name = "systemsListView";
            this.systemsListView.ShowGroups = false;
            this.systemsListView.Size = new System.Drawing.Size(185, 440);
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
            this.Open.Location = new System.Drawing.Point(403, 449);
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
            this.SaveAs.Location = new System.Drawing.Point(307, 449);
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
            this.Cancel.Location = new System.Drawing.Point(211, 449);
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
            this.Ok.Location = new System.Drawing.Point(115, 449);
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
            this.selector.LargeChange = 1;
            this.selector.Location = new System.Drawing.Point(193, 3);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 199;
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(447, 45);
            this.selector.TabIndex = 149;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            // 
            // sectorGroupBox
            // 
            this.sectorGroupBox.Controls.Add(this.sectorName);
            this.sectorGroupBox.Controls.Add(this.sectorGalaxySizeLabel);
            this.sectorGroupBox.Controls.Add(this.sectorNameLabel);
            this.sectorGroupBox.Controls.Add(this.sectorSecImportLabel);
            this.sectorGroupBox.Controls.Add(this.sectorFamilyIdHexLabel);
            this.sectorGroupBox.Controls.Add(this.label4);
            this.sectorGroupBox.Controls.Add(this.sectorFamilyId);
            this.sectorGroupBox.Controls.Add(this.sectorYPosition);
            this.sectorGroupBox.Controls.Add(this.sectorFamilyIdLabel);
            this.sectorGroupBox.Controls.Add(this.sectorTextStraDllIdLabel);
            this.sectorGroupBox.Controls.Add(this.sectorXPosition);
            this.sectorGroupBox.Controls.Add(this.sectorTextStraDllId);
            this.sectorGroupBox.Controls.Add(this.sectorSecImport);
            this.sectorGroupBox.Controls.Add(this.sectorGalaxySize);
            this.sectorGroupBox.Location = new System.Drawing.Point(193, 337);
            this.sectorGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorGroupBox.Name = "sectorGroupBox";
            this.sectorGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sectorGroupBox.Size = new System.Drawing.Size(523, 106);
            this.sectorGroupBox.TabIndex = 14;
            this.sectorGroupBox.TabStop = false;
            this.sectorGroupBox.Text = "Sector (SECTORSD.DAT)";
            // 
            // sectorName
            // 
            this.sectorName.Enabled = false;
            this.sectorName.Location = new System.Drawing.Point(74, 22);
            this.sectorName.Name = "sectorName";
            this.sectorName.Size = new System.Drawing.Size(134, 23);
            this.sectorName.TabIndex = 172;
            // 
            // sectorGalaxySizeLabel
            // 
            this.sectorGalaxySizeLabel.AutoSize = true;
            this.sectorGalaxySizeLabel.Enabled = false;
            this.sectorGalaxySizeLabel.Location = new System.Drawing.Point(293, 50);
            this.sectorGalaxySizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sectorGalaxySizeLabel.Name = "sectorGalaxySizeLabel";
            this.sectorGalaxySizeLabel.Size = new System.Drawing.Size(65, 15);
            this.sectorGalaxySizeLabel.TabIndex = 1152;
            this.sectorGalaxySizeLabel.Text = "Galaxy Size";
            // 
            // sectorNameLabel
            // 
            this.sectorNameLabel.AutoSize = true;
            this.sectorNameLabel.Enabled = false;
            this.sectorNameLabel.Location = new System.Drawing.Point(21, 25);
            this.sectorNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sectorNameLabel.Name = "sectorNameLabel";
            this.sectorNameLabel.Size = new System.Drawing.Size(39, 15);
            this.sectorNameLabel.TabIndex = 171;
            this.sectorNameLabel.Text = "Name";
            // 
            // sectorSecImportLabel
            // 
            this.sectorSecImportLabel.AutoSize = true;
            this.sectorSecImportLabel.Enabled = false;
            this.sectorSecImportLabel.Location = new System.Drawing.Point(293, 25);
            this.sectorSecImportLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sectorSecImportLabel.Name = "sectorSecImportLabel";
            this.sectorSecImportLabel.Size = new System.Drawing.Size(64, 15);
            this.sectorSecImportLabel.TabIndex = 1155;
            this.sectorSecImportLabel.Text = "Sec Import";
            // 
            // sectorFamilyIdHexLabel
            // 
            this.sectorFamilyIdHexLabel.AutoSize = true;
            this.sectorFamilyIdHexLabel.Enabled = false;
            this.sectorFamilyIdHexLabel.Location = new System.Drawing.Point(216, 52);
            this.sectorFamilyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sectorFamilyIdHexLabel.Name = "sectorFamilyIdHexLabel";
            this.sectorFamilyIdHexLabel.Size = new System.Drawing.Size(31, 15);
            this.sectorFamilyIdHexLabel.TabIndex = 1151;
            this.sectorFamilyIdHexLabel.Text = "0x00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(293, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Position (X, Y)";
            // 
            // sectorFamilyId
            // 
            this.sectorFamilyId.Enabled = false;
            this.sectorFamilyId.Location = new System.Drawing.Point(149, 48);
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
            // sectorYPosition
            // 
            this.sectorYPosition.Enabled = false;
            this.sectorYPosition.Location = new System.Drawing.Point(451, 74);
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
            // sectorFamilyIdLabel
            // 
            this.sectorFamilyIdLabel.AutoSize = true;
            this.sectorFamilyIdLabel.Enabled = false;
            this.sectorFamilyIdLabel.Location = new System.Drawing.Point(21, 52);
            this.sectorFamilyIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sectorFamilyIdLabel.Name = "sectorFamilyIdLabel";
            this.sectorFamilyIdLabel.Size = new System.Drawing.Size(55, 15);
            this.sectorFamilyIdLabel.TabIndex = 1154;
            this.sectorFamilyIdLabel.Text = "Family Id";
            // 
            // sectorTextStraDllIdLabel
            // 
            this.sectorTextStraDllIdLabel.AutoSize = true;
            this.sectorTextStraDllIdLabel.Enabled = false;
            this.sectorTextStraDllIdLabel.Location = new System.Drawing.Point(21, 76);
            this.sectorTextStraDllIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sectorTextStraDllIdLabel.Name = "sectorTextStraDllIdLabel";
            this.sectorTextStraDllIdLabel.Size = new System.Drawing.Size(77, 15);
            this.sectorTextStraDllIdLabel.TabIndex = 0;
            this.sectorTextStraDllIdLabel.Text = "TextStra.dll Id";
            // 
            // sectorXPosition
            // 
            this.sectorXPosition.Enabled = false;
            this.sectorXPosition.Location = new System.Drawing.Point(384, 74);
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
            // sectorTextStraDllId
            // 
            this.sectorTextStraDllId.Enabled = false;
            this.sectorTextStraDllId.Location = new System.Drawing.Point(149, 74);
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
            this.sectorSecImport.Location = new System.Drawing.Point(384, 22);
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
            this.sectorGalaxySize.Location = new System.Drawing.Point(384, 48);
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
            // Field7_2Label
            // 
            this.Field7_2Label.AutoSize = true;
            this.Field7_2Label.ForeColor = System.Drawing.Color.Red;
            this.Field7_2Label.Location = new System.Drawing.Point(11, 180);
            this.Field7_2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Field7_2Label.Name = "Field7_2Label";
            this.Field7_2Label.Size = new System.Drawing.Size(93, 15);
            this.Field7_2Label.TabIndex = 0;
            this.Field7_2Label.Text = "Field7 (always 2)";
            // 
            // field10_1
            // 
            this.field10_1.ForeColor = System.Drawing.Color.Red;
            this.field10_1.Location = new System.Drawing.Point(153, 256);
            this.field10_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.field10_1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.field10_1.Name = "field10_1";
            this.field10_1.Size = new System.Drawing.Size(59, 23);
            this.field10_1.TabIndex = 4;
            this.field10_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.field10_1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.field10_1.ValueChanged += new System.EventHandler(this.field10_1_ValueChanged);
            // 
            // sectorId
            // 
            this.sectorId.BackColor = System.Drawing.SystemColors.Window;
            this.sectorId.Location = new System.Drawing.Point(153, 204);
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
            // sectorIdLabel
            // 
            this.sectorIdLabel.AutoSize = true;
            this.sectorIdLabel.Location = new System.Drawing.Point(11, 206);
            this.sectorIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sectorIdLabel.Name = "sectorIdLabel";
            this.sectorIdLabel.Size = new System.Drawing.Size(53, 15);
            this.sectorIdLabel.TabIndex = 1148;
            this.sectorIdLabel.Text = "Sector Id";
            // 
            // familyIdHexLabel
            // 
            this.familyIdHexLabel.AutoSize = true;
            this.familyIdHexLabel.Enabled = false;
            this.familyIdHexLabel.ForeColor = System.Drawing.Color.Red;
            this.familyIdHexLabel.Location = new System.Drawing.Point(220, 128);
            this.familyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdHexLabel.Name = "familyIdHexLabel";
            this.familyIdHexLabel.Size = new System.Drawing.Size(31, 15);
            this.familyIdHexLabel.TabIndex = 1147;
            this.familyIdHexLabel.Text = "0x00";
            // 
            // productionFamily_0
            // 
            this.productionFamily_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.productionFamily_0.Location = new System.Drawing.Point(153, 74);
            this.productionFamily_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productionFamily_0.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.productionFamily_0.Name = "productionFamily_0";
            this.productionFamily_0.Size = new System.Drawing.Size(59, 23);
            this.productionFamily_0.TabIndex = 0;
            this.productionFamily_0.TabStop = false;
            this.productionFamily_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.productionFamily_0.ValueChanged += new System.EventHandler(this.productionFamily_0_ValueChanged);
            // 
            // productionFamily_0Label
            // 
            this.productionFamily_0Label.AutoSize = true;
            this.productionFamily_0Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.productionFamily_0Label.Location = new System.Drawing.Point(11, 76);
            this.productionFamily_0Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productionFamily_0Label.Name = "productionFamily_0Label";
            this.productionFamily_0Label.Size = new System.Drawing.Size(104, 15);
            this.productionFamily_0Label.TabIndex = 0;
            this.productionFamily_0Label.Text = "Production Family";
            // 
            // idHexLabel
            // 
            this.idHexLabel.AutoSize = true;
            this.idHexLabel.Enabled = false;
            this.idHexLabel.ForeColor = System.Drawing.Color.Red;
            this.idHexLabel.Location = new System.Drawing.Point(220, 24);
            this.idHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idHexLabel.Name = "idHexLabel";
            this.idHexLabel.Size = new System.Drawing.Size(31, 15);
            this.idHexLabel.TabIndex = 1146;
            this.idHexLabel.Text = "0x00";
            // 
            // nextProductionFamily_0Label
            // 
            this.nextProductionFamily_0Label.AutoSize = true;
            this.nextProductionFamily_0Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.nextProductionFamily_0Label.Location = new System.Drawing.Point(11, 102);
            this.nextProductionFamily_0Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nextProductionFamily_0Label.Name = "nextProductionFamily_0Label";
            this.nextProductionFamily_0Label.Size = new System.Drawing.Size(121, 15);
            this.nextProductionFamily_0Label.TabIndex = 0;
            this.nextProductionFamily_0Label.Text = "Production Family +1";
            // 
            // nextProductionFamily_0
            // 
            this.nextProductionFamily_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.nextProductionFamily_0.Location = new System.Drawing.Point(153, 100);
            this.nextProductionFamily_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextProductionFamily_0.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nextProductionFamily_0.Name = "nextProductionFamily_0";
            this.nextProductionFamily_0.Size = new System.Drawing.Size(59, 23);
            this.nextProductionFamily_0.TabIndex = 0;
            this.nextProductionFamily_0.TabStop = false;
            this.nextProductionFamily_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nextProductionFamily_0.ValueChanged += new System.EventHandler(this.nextProductionFamily_0_ValueChanged);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.Window;
            this.id.ForeColor = System.Drawing.Color.Red;
            this.id.Location = new System.Drawing.Point(153, 22);
            this.id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.id.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(59, 23);
            this.id.TabIndex = 1145;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.id.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.id.ValueChanged += new System.EventHandler(this.id_ValueChanged);
            // 
            // familyIdLabel
            // 
            this.familyIdLabel.AutoSize = true;
            this.familyIdLabel.ForeColor = System.Drawing.Color.Blue;
            this.familyIdLabel.Location = new System.Drawing.Point(11, 128);
            this.familyIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdLabel.Name = "familyIdLabel";
            this.familyIdLabel.Size = new System.Drawing.Size(63, 15);
            this.familyIdLabel.TabIndex = 0;
            this.familyIdLabel.Text = "Family Id *";
            // 
            // textStraDllIdLabel
            // 
            this.textStraDllIdLabel.AutoSize = true;
            this.textStraDllIdLabel.ForeColor = System.Drawing.Color.Red;
            this.textStraDllIdLabel.Location = new System.Drawing.Point(11, 154);
            this.textStraDllIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textStraDllIdLabel.Name = "textStraDllIdLabel";
            this.textStraDllIdLabel.Size = new System.Drawing.Size(77, 15);
            this.textStraDllIdLabel.TabIndex = 0;
            this.textStraDllIdLabel.Text = "TextStra.dll Id";
            // 
            // familyId
            // 
            this.familyId.ForeColor = System.Drawing.Color.Red;
            this.familyId.Location = new System.Drawing.Point(153, 126);
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
            this.textStraDllId.ForeColor = System.Drawing.Color.Red;
            this.textStraDllId.Location = new System.Drawing.Point(153, 152);
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
            // field7_2
            // 
            this.field7_2.ForeColor = System.Drawing.Color.Red;
            this.field7_2.Location = new System.Drawing.Point(153, 178);
            this.field7_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.field7_2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.field7_2.Name = "field7_2";
            this.field7_2.Size = new System.Drawing.Size(59, 23);
            this.field7_2.TabIndex = 0;
            this.field7_2.TabStop = false;
            this.field7_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.field7_2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.field7_2.ValueChanged += new System.EventHandler(this.field7_2_ValueChanged);
            // 
            // field10_1Label
            // 
            this.field10_1Label.AutoSize = true;
            this.field10_1Label.ForeColor = System.Drawing.Color.Red;
            this.field10_1Label.Location = new System.Drawing.Point(11, 258);
            this.field10_1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field10_1Label.Name = "field10_1Label";
            this.field10_1Label.Size = new System.Drawing.Size(99, 15);
            this.field10_1Label.TabIndex = 0;
            this.field10_1Label.Text = "Field10 (always 1)";
            // 
            // pictureId
            // 
            this.pictureId.Location = new System.Drawing.Point(153, 230);
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
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.ForeColor = System.Drawing.Color.Red;
            this.idLabel.Location = new System.Drawing.Point(11, 24);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(17, 15);
            this.idLabel.TabIndex = 12;
            this.idLabel.Text = "Id";
            // 
            // yPosition
            // 
            this.yPosition.Location = new System.Drawing.Point(220, 282);
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
            // field13_0Label
            // 
            this.field13_0Label.AutoSize = true;
            this.field13_0Label.ForeColor = System.Drawing.Color.Red;
            this.field13_0Label.Location = new System.Drawing.Point(11, 310);
            this.field13_0Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field13_0Label.Name = "field13_0Label";
            this.field13_0Label.Size = new System.Drawing.Size(99, 15);
            this.field13_0Label.TabIndex = 0;
            this.field13_0Label.Text = "Field13 (always 0)";
            // 
            // field13_0
            // 
            this.field13_0.ForeColor = System.Drawing.Color.Red;
            this.field13_0.Location = new System.Drawing.Point(153, 308);
            this.field13_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.field13_0.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.field13_0.Name = "field13_0";
            this.field13_0.Size = new System.Drawing.Size(59, 23);
            this.field13_0.TabIndex = 8;
            this.field13_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.field13_0.ValueChanged += new System.EventHandler(this.field13_0_ValueChanged);
            // 
            // xPosition
            // 
            this.xPosition.Location = new System.Drawing.Point(153, 282);
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
            this.positionLabel.Location = new System.Drawing.Point(11, 284);
            this.positionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(81, 15);
            this.positionLabel.TabIndex = 0;
            this.positionLabel.Text = "Position (X, Y)";
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(7, 22);
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
            this.familyIdInfoLabel.ForeColor = System.Drawing.Color.Blue;
            this.familyIdInfoLabel.Location = new System.Drawing.Point(744, 349);
            this.familyIdInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdInfoLabel.Name = "familyIdInfoLabel";
            this.familyIdInfoLabel.Size = new System.Drawing.Size(116, 15);
            this.familyIdInfoLabel.TabIndex = 158;
            this.familyIdInfoLabel.Text = "* 144=Core 146=Rim";
            // 
            // pictureIdLabel
            // 
            this.pictureIdLabel.AutoSize = true;
            this.pictureIdLabel.Location = new System.Drawing.Point(11, 232);
            this.pictureIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pictureIdLabel.Name = "pictureIdLabel";
            this.pictureIdLabel.Size = new System.Drawing.Size(57, 15);
            this.pictureIdLabel.TabIndex = 1150;
            this.pictureIdLabel.Text = "Picture Id";
            // 
            // field2_1
            // 
            this.field2_1.ForeColor = System.Drawing.Color.Red;
            this.field2_1.Location = new System.Drawing.Point(153, 48);
            this.field2_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.field2_1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.field2_1.Name = "field2_1";
            this.field2_1.Size = new System.Drawing.Size(59, 23);
            this.field2_1.TabIndex = 1151;
            this.field2_1.TabStop = false;
            this.field2_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.field2_1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.field2_1.ValueChanged += new System.EventHandler(this.field2_1_ValueChanged);
            // 
            // field2_1Label
            // 
            this.field2_1Label.AutoSize = true;
            this.field2_1Label.ForeColor = System.Drawing.Color.Red;
            this.field2_1Label.Location = new System.Drawing.Point(11, 50);
            this.field2_1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field2_1Label.Name = "field2_1Label";
            this.field2_1Label.Size = new System.Drawing.Size(93, 15);
            this.field2_1Label.TabIndex = 1152;
            this.field2_1Label.Text = "Field2 (always 1)";
            // 
            // inGameDataGroupBox
            // 
            this.inGameDataGroupBox.Controls.Add(this.encyclopediaDescriptionLabel);
            this.inGameDataGroupBox.Controls.Add(this.name);
            this.inGameDataGroupBox.Controls.Add(this.nameLabel);
            this.inGameDataGroupBox.Controls.Add(this.encyclopediaDescription);
            this.inGameDataGroupBox.Controls.Add(this.picture);
            this.inGameDataGroupBox.Location = new System.Drawing.Point(193, 45);
            this.inGameDataGroupBox.Name = "inGameDataGroupBox";
            this.inGameDataGroupBox.Size = new System.Drawing.Size(447, 289);
            this.inGameDataGroupBox.TabIndex = 1153;
            this.inGameDataGroupBox.TabStop = false;
            this.inGameDataGroupBox.Text = "In Game Data";
            // 
            // encyclopediaDescriptionLabel
            // 
            this.encyclopediaDescriptionLabel.AutoSize = true;
            this.encyclopediaDescriptionLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.encyclopediaDescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.encyclopediaDescriptionLabel.Location = new System.Drawing.Point(293, 124);
            this.encyclopediaDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encyclopediaDescriptionLabel.Name = "encyclopediaDescriptionLabel";
            this.encyclopediaDescriptionLabel.Size = new System.Drawing.Size(140, 15);
            this.encyclopediaDescriptionLabel.TabIndex = 1129;
            this.encyclopediaDescriptionLabel.Text = "Encyclopedia Description";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(232, 54);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(211, 23);
            this.name.TabIndex = 169;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(236, 33);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 168;
            this.nameLabel.Text = "Name";
            // 
            // encyclopediaDescription
            // 
            this.encyclopediaDescription.Location = new System.Drawing.Point(7, 138);
            this.encyclopediaDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.encyclopediaDescription.Name = "encyclopediaDescription";
            this.encyclopediaDescription.Size = new System.Drawing.Size(436, 145);
            this.encyclopediaDescription.TabIndex = 134;
            this.encyclopediaDescription.TabStop = false;
            this.encyclopediaDescription.Text = "";
            this.encyclopediaDescription.TextChanged += new System.EventHandler(this.encyclopediaDescription_TextChanged);
            // 
            // hiddenDataGroupBox
            // 
            this.hiddenDataGroupBox.Controls.Add(this.id);
            this.hiddenDataGroupBox.Controls.Add(this.idHexLabel);
            this.hiddenDataGroupBox.Controls.Add(this.idLabel);
            this.hiddenDataGroupBox.Controls.Add(this.field2_1);
            this.hiddenDataGroupBox.Controls.Add(this.productionFamily_0);
            this.hiddenDataGroupBox.Controls.Add(this.productionFamily_0Label);
            this.hiddenDataGroupBox.Controls.Add(this.nextProductionFamily_0Label);
            this.hiddenDataGroupBox.Controls.Add(this.nextProductionFamily_0);
            this.hiddenDataGroupBox.Controls.Add(this.field2_1Label);
            this.hiddenDataGroupBox.Controls.Add(this.familyIdLabel);
            this.hiddenDataGroupBox.Controls.Add(this.familyId);
            this.hiddenDataGroupBox.Controls.Add(this.familyIdHexLabel);
            this.hiddenDataGroupBox.Controls.Add(this.textStraDllIdLabel);
            this.hiddenDataGroupBox.Controls.Add(this.Field7_2Label);
            this.hiddenDataGroupBox.Controls.Add(this.positionLabel);
            this.hiddenDataGroupBox.Controls.Add(this.xPosition);
            this.hiddenDataGroupBox.Controls.Add(this.field13_0Label);
            this.hiddenDataGroupBox.Controls.Add(this.yPosition);
            this.hiddenDataGroupBox.Controls.Add(this.sectorId);
            this.hiddenDataGroupBox.Controls.Add(this.field10_1);
            this.hiddenDataGroupBox.Controls.Add(this.sectorIdLabel);
            this.hiddenDataGroupBox.Controls.Add(this.textStraDllId);
            this.hiddenDataGroupBox.Controls.Add(this.pictureIdLabel);
            this.hiddenDataGroupBox.Controls.Add(this.pictureId);
            this.hiddenDataGroupBox.Controls.Add(this.field7_2);
            this.hiddenDataGroupBox.Controls.Add(this.field13_0);
            this.hiddenDataGroupBox.Controls.Add(this.field10_1Label);
            this.hiddenDataGroupBox.Location = new System.Drawing.Point(648, 3);
            this.hiddenDataGroupBox.Name = "hiddenDataGroupBox";
            this.hiddenDataGroupBox.Size = new System.Drawing.Size(297, 339);
            this.hiddenDataGroupBox.TabIndex = 1156;
            this.hiddenDataGroupBox.TabStop = false;
            this.hiddenDataGroupBox.Text = "Hidden Data";
            // 
            // SystemsForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(949, 481);
            this.Controls.Add(this.hiddenDataGroupBox);
            this.Controls.Add(this.inGameDataGroupBox);
            this.Controls.Add(this.sectorGroupBox);
            this.Controls.Add(this.familyIdInfoLabel);
            this.Controls.Add(this.systemsListView);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.selector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(965, 520);
            this.MinimumSize = new System.Drawing.Size(965, 520);
            this.Name = "SystemsForm";
            this.Text = "Systems (SYSTEMSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            this.sectorGroupBox.ResumeLayout(false);
            this.sectorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorFamilyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorYPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorXPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorTextStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorSecImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorGalaxySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field10_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFamily_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFamily_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field13_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2_1)).EndInit();
            this.inGameDataGroupBox.ResumeLayout(false);
            this.inGameDataGroupBox.PerformLayout();
            this.hiddenDataGroupBox.ResumeLayout(false);
            this.hiddenDataGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label pictureIdLabel;
        private NumericUpDown field2_1;
        private Label field2_1Label;
        private GroupBox inGameDataGroupBox;
        private TextBox name;
        private Label nameLabel;
        private RichTextBox encyclopediaDescription;
        private Label sectorGalaxySizeLabel;
        private Label sectorFamilyIdLabel;
        private TextBox sectorName;
        private Label sectorNameLabel;
        private Label sectorSecImportLabel;
        private Label encyclopediaDescriptionLabel;
        private GroupBox hiddenDataGroupBox;
    }
}