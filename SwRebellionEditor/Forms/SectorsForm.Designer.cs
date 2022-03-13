using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class SectorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button Open;
        private Button SaveAs;
        private Button Cancel;
        private Button Ok;
        private GroupBox encyclopediaGroupBox;
        private Label productionFacilityLabel;
        private Label unknown1Label;
        private Label sectorIdLabel;
        private Label positionLabel;
        private Label galaxySizeLabel;
        private Label label12;
        private Label label5;
        private Label familyIdLabel;
        private Label textStraDllIdLabel;
        private Label unknown2Label;
        private Label secImportLabel;
        private Label descriptionLabel;
        private Label nameLabel;
        private Label familyIdHexLabel;
        private Label sectorIdHexLabel;
        private NumericUpDown productionFacility;
        private NumericUpDown sectorId;
        private NumericUpDown yPosition;
        private NumericUpDown unknown1;
        private NumericUpDown xPosition;
        private NumericUpDown secImport;
        private NumericUpDown nextProductionFacility;
        private NumericUpDown familyId;
        private NumericUpDown galaxySize;
        private NumericUpDown textStraDllId;
        private NumericUpDown unknown2;
        private RichTextBox encyclopediaDescription;
        private TextBox encyclopediaName;
        private TrackBar selector;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectorsForm));
            this.Open = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.selector = new System.Windows.Forms.TrackBar();
            this.familyId = new System.Windows.Forms.NumericUpDown();
            this.galaxySize = new System.Windows.Forms.NumericUpDown();
            this.galaxySizeLabel = new System.Windows.Forms.Label();
            this.secImport = new System.Windows.Forms.NumericUpDown();
            this.nextProductionFacility = new System.Windows.Forms.NumericUpDown();
            this.productionFacility = new System.Windows.Forms.NumericUpDown();
            this.sectorId = new System.Windows.Forms.NumericUpDown();
            this.productionFacilityLabel = new System.Windows.Forms.Label();
            this.yPosition = new System.Windows.Forms.NumericUpDown();
            this.unknown1Label = new System.Windows.Forms.Label();
            this.unknown1 = new System.Windows.Forms.NumericUpDown();
            this.sectorIdLabel = new System.Windows.Forms.Label();
            this.xPosition = new System.Windows.Forms.NumericUpDown();
            this.positionLabel = new System.Windows.Forms.Label();
            this.encyclopediaDescription = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.familyIdLabel = new System.Windows.Forms.Label();
            this.textStraDllIdLabel = new System.Windows.Forms.Label();
            this.textStraDllId = new System.Windows.Forms.NumericUpDown();
            this.unknown2 = new System.Windows.Forms.NumericUpDown();
            this.unknown2Label = new System.Windows.Forms.Label();
            this.secImportLabel = new System.Windows.Forms.Label();
            this.encyclopediaGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.encyclopediaName = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.sectorIdHexLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galaxySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown2)).BeginInit();
            this.encyclopediaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(314, 360);
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
            this.SaveAs.Location = new System.Drawing.Point(218, 360);
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
            this.Cancel.Location = new System.Drawing.Point(122, 360);
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
            this.Ok.Location = new System.Drawing.Point(26, 360);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 153;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // selector
            // 
            this.selector.LargeChange = 10;
            this.selector.Location = new System.Drawing.Point(10, 12);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 19;
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(279, 45);
            this.selector.TabIndex = 149;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            // 
            // familyId
            // 
            this.familyId.Location = new System.Drawing.Point(163, 174);
            this.familyId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.familyId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.familyId.Name = "familyId";
            this.familyId.Size = new System.Drawing.Size(59, 23);
            this.familyId.TabIndex = 14;
            this.familyId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.familyId.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.familyId.ValueChanged += new System.EventHandler(this.familyId_ValueChanged);
            // 
            // galaxySize
            // 
            this.galaxySize.Location = new System.Drawing.Point(163, 290);
            this.galaxySize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.galaxySize.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.galaxySize.Name = "galaxySize";
            this.galaxySize.Size = new System.Drawing.Size(59, 23);
            this.galaxySize.TabIndex = 13;
            this.galaxySize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.galaxySize.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.galaxySize.ValueChanged += new System.EventHandler(this.galaxySize_ValueChanged);
            // 
            // galaxySizeLabel
            // 
            this.galaxySizeLabel.AutoSize = true;
            this.galaxySizeLabel.Enabled = false;
            this.galaxySizeLabel.Location = new System.Drawing.Point(26, 292);
            this.galaxySizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.galaxySizeLabel.Name = "galaxySizeLabel";
            this.galaxySizeLabel.Size = new System.Drawing.Size(63, 15);
            this.galaxySizeLabel.TabIndex = 12;
            this.galaxySizeLabel.Text = "galaxy size";
            // 
            // secImport
            // 
            this.secImport.Location = new System.Drawing.Point(163, 261);
            this.secImport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secImport.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.secImport.Name = "secImport";
            this.secImport.Size = new System.Drawing.Size(59, 23);
            this.secImport.TabIndex = 7;
            this.secImport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.secImport.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.secImport.ValueChanged += new System.EventHandler(this.secImport_ValueChanged);
            // 
            // nextProductionFacility
            // 
            this.nextProductionFacility.Location = new System.Drawing.Point(163, 145);
            this.nextProductionFacility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextProductionFacility.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nextProductionFacility.Name = "nextProductionFacility";
            this.nextProductionFacility.Size = new System.Drawing.Size(59, 23);
            this.nextProductionFacility.TabIndex = 6;
            this.nextProductionFacility.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nextProductionFacility.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nextProductionFacility.ValueChanged += new System.EventHandler(this.nextProductionFacility_ValueChanged);
            // 
            // productionFacility
            // 
            this.productionFacility.Location = new System.Drawing.Point(163, 116);
            this.productionFacility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productionFacility.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.productionFacility.Name = "productionFacility";
            this.productionFacility.Size = new System.Drawing.Size(59, 23);
            this.productionFacility.TabIndex = 11;
            this.productionFacility.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.productionFacility.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.productionFacility.ValueChanged += new System.EventHandler(this.productionFacility_ValueChanged);
            // 
            // sectorId
            // 
            this.sectorId.Location = new System.Drawing.Point(163, 58);
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
            this.sectorId.ValueChanged += new System.EventHandler(this.sectorId_ValueChanged);
            // 
            // productionFacilityLabel
            // 
            this.productionFacilityLabel.AutoSize = true;
            this.productionFacilityLabel.Location = new System.Drawing.Point(26, 118);
            this.productionFacilityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productionFacilityLabel.Name = "productionFacilityLabel";
            this.productionFacilityLabel.Size = new System.Drawing.Size(104, 15);
            this.productionFacilityLabel.TabIndex = 12;
            this.productionFacilityLabel.Text = "production facility";
            // 
            // yPosition
            // 
            this.yPosition.Location = new System.Drawing.Point(230, 319);
            this.yPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.yPosition.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.yPosition.Name = "yPosition";
            this.yPosition.Size = new System.Drawing.Size(59, 23);
            this.yPosition.TabIndex = 7;
            this.yPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.yPosition.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.yPosition.ValueChanged += new System.EventHandler(this.yPosition_ValueChanged);
            // 
            // unknown1Label
            // 
            this.unknown1Label.AutoSize = true;
            this.unknown1Label.Location = new System.Drawing.Point(26, 89);
            this.unknown1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unknown1Label.Name = "unknown1Label";
            this.unknown1Label.Size = new System.Drawing.Size(66, 15);
            this.unknown1Label.TabIndex = 0;
            this.unknown1Label.Text = "unknown 1";
            // 
            // unknown1
            // 
            this.unknown1.Location = new System.Drawing.Point(163, 87);
            this.unknown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknown1.Name = "unknown1";
            this.unknown1.Size = new System.Drawing.Size(59, 23);
            this.unknown1.TabIndex = 8;
            this.unknown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unknown1.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknown1.ValueChanged += new System.EventHandler(this.unknown1_ValueChanged);
            // 
            // sectorIdLabel
            // 
            this.sectorIdLabel.AutoSize = true;
            this.sectorIdLabel.Location = new System.Drawing.Point(26, 60);
            this.sectorIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sectorIdLabel.Name = "sectorIdLabel";
            this.sectorIdLabel.Size = new System.Drawing.Size(52, 15);
            this.sectorIdLabel.TabIndex = 0;
            this.sectorIdLabel.Text = "sector id";
            // 
            // xPosition
            // 
            this.xPosition.Location = new System.Drawing.Point(163, 319);
            this.xPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xPosition.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.xPosition.Name = "xPosition";
            this.xPosition.Size = new System.Drawing.Size(59, 23);
            this.xPosition.TabIndex = 6;
            this.xPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.xPosition.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.xPosition.ValueChanged += new System.EventHandler(this.xPosition_ValueChanged);
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(26, 321);
            this.positionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(81, 15);
            this.positionLabel.TabIndex = 0;
            this.positionLabel.Text = "position (X, Y)";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(330, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(325, 15);
            this.label12.TabIndex = 158;
            this.label12.Text = "***** System Family ID may be updated 144 = core 146= Rim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 15);
            this.label5.TabIndex = 160;
            this.label5.Text = "next production facility";
            // 
            // familyIdLabel
            // 
            this.familyIdLabel.AutoSize = true;
            this.familyIdLabel.Location = new System.Drawing.Point(26, 176);
            this.familyIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdLabel.Name = "familyIdLabel";
            this.familyIdLabel.Size = new System.Drawing.Size(53, 15);
            this.familyIdLabel.TabIndex = 161;
            this.familyIdLabel.Text = "family id";
            // 
            // textStraDllIdLabel
            // 
            this.textStraDllIdLabel.AutoSize = true;
            this.textStraDllIdLabel.Location = new System.Drawing.Point(26, 205);
            this.textStraDllIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textStraDllIdLabel.Name = "textStraDllIdLabel";
            this.textStraDllIdLabel.Size = new System.Drawing.Size(75, 15);
            this.textStraDllIdLabel.TabIndex = 163;
            this.textStraDllIdLabel.Text = "textstra.dll id";
            // 
            // textStraDllId
            // 
            this.textStraDllId.Location = new System.Drawing.Point(163, 203);
            this.textStraDllId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textStraDllId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.textStraDllId.Name = "textStraDllId";
            this.textStraDllId.Size = new System.Drawing.Size(59, 23);
            this.textStraDllId.TabIndex = 162;
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
            this.unknown2.Location = new System.Drawing.Point(163, 232);
            this.unknown2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknown2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknown2.Name = "unknown2";
            this.unknown2.Size = new System.Drawing.Size(59, 23);
            this.unknown2.TabIndex = 165;
            this.unknown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unknown2.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknown2.ValueChanged += new System.EventHandler(this.unknown2_ValueChanged);
            // 
            // unknown2Label
            // 
            this.unknown2Label.AutoSize = true;
            this.unknown2Label.Location = new System.Drawing.Point(26, 234);
            this.unknown2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unknown2Label.Name = "unknown2Label";
            this.unknown2Label.Size = new System.Drawing.Size(66, 15);
            this.unknown2Label.TabIndex = 164;
            this.unknown2Label.Text = "unknown 2";
            // 
            // secImportLabel
            // 
            this.secImportLabel.AutoSize = true;
            this.secImportLabel.Location = new System.Drawing.Point(26, 263);
            this.secImportLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secImportLabel.Name = "secImportLabel";
            this.secImportLabel.Size = new System.Drawing.Size(63, 15);
            this.secImportLabel.TabIndex = 166;
            this.secImportLabel.Text = "sec import";
            // 
            // encyclopediaGroupBox
            // 
            this.encyclopediaGroupBox.Controls.Add(this.descriptionLabel);
            this.encyclopediaGroupBox.Controls.Add(this.encyclopediaName);
            this.encyclopediaGroupBox.Controls.Add(this.nameLabel);
            this.encyclopediaGroupBox.Controls.Add(this.encyclopediaDescription);
            this.encyclopediaGroupBox.Location = new System.Drawing.Point(299, 58);
            this.encyclopediaGroupBox.Name = "encyclopediaGroupBox";
            this.encyclopediaGroupBox.Size = new System.Drawing.Size(451, 284);
            this.encyclopediaGroupBox.TabIndex = 167;
            this.encyclopediaGroupBox.TabStop = false;
            this.encyclopediaGroupBox.Text = "encyclopedia";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(17, 49);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(66, 15);
            this.descriptionLabel.TabIndex = 170;
            this.descriptionLabel.Text = "description";
            // 
            // encyclopediaName
            // 
            this.encyclopediaName.Enabled = false;
            this.encyclopediaName.Location = new System.Drawing.Point(112, 21);
            this.encyclopediaName.Name = "encyclopediaName";
            this.encyclopediaName.Size = new System.Drawing.Size(331, 23);
            this.encyclopediaName.TabIndex = 169;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(17, 24);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(72, 15);
            this.nameLabel.TabIndex = 168;
            this.nameLabel.Text = "sector name";
            // 
            // familyIdHexLabel
            // 
            this.familyIdHexLabel.AutoSize = true;
            this.familyIdHexLabel.Location = new System.Drawing.Point(230, 176);
            this.familyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdHexLabel.Name = "familyIdHexLabel";
            this.familyIdHexLabel.Size = new System.Drawing.Size(31, 15);
            this.familyIdHexLabel.TabIndex = 168;
            this.familyIdHexLabel.Text = "0x00";
            // 
            // sectorIdHexLabel
            // 
            this.sectorIdHexLabel.AutoSize = true;
            this.sectorIdHexLabel.Location = new System.Drawing.Point(230, 60);
            this.sectorIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sectorIdHexLabel.Name = "sectorIdHexLabel";
            this.sectorIdHexLabel.Size = new System.Drawing.Size(31, 15);
            this.sectorIdHexLabel.TabIndex = 169;
            this.sectorIdHexLabel.Text = "0x00";
            // 
            // SectorsForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(761, 399);
            this.Controls.Add(this.sectorIdHexLabel);
            this.Controls.Add(this.familyIdHexLabel);
            this.Controls.Add(this.encyclopediaGroupBox);
            this.Controls.Add(this.secImportLabel);
            this.Controls.Add(this.unknown2);
            this.Controls.Add(this.unknown2Label);
            this.Controls.Add(this.textStraDllIdLabel);
            this.Controls.Add(this.textStraDllId);
            this.Controls.Add(this.familyIdLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.familyId);
            this.Controls.Add(this.galaxySize);
            this.Controls.Add(this.galaxySizeLabel);
            this.Controls.Add(this.productionFacility);
            this.Controls.Add(this.secImport);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.sectorId);
            this.Controls.Add(this.nextProductionFacility);
            this.Controls.Add(this.productionFacilityLabel);
            this.Controls.Add(this.yPosition);
            this.Controls.Add(this.unknown1);
            this.Controls.Add(this.unknown1Label);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.xPosition);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.sectorIdLabel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.selector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "SectorsForm";
            this.Text = "Sectors (SECTORSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galaxySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown2)).EndInit();
            this.encyclopediaGroupBox.ResumeLayout(false);
            this.encyclopediaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}