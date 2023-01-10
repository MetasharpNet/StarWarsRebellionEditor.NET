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
        private GroupBox inGameDataGroupBox;
        private Label productionFamily_0Label;
        private Label field2_1Label;
        private Label idLabel;
        private Label positionLabel;
        private Label galaxySizeLabel;
        private Label familyCommentLabel;
        private Label nextProductionFamily_0Label;
        private Label familyIdLabel;
        private Label textStraDllIdLabel;
        private Label field7_2Label;
        private Label secImportLabel;
        private Label nameLabel;
        private Label familyIdHexLabel;
        private Label idHexLabel;
        private NumericUpDown productionFamily_0;
        private NumericUpDown id;
        private NumericUpDown yPosition;
        private NumericUpDown field2_1;
        private NumericUpDown xPosition;
        private NumericUpDown secImport;
        private NumericUpDown nextProductionFamily_0;
        private NumericUpDown familyId;
        private NumericUpDown galaxySize;
        private NumericUpDown textStraDllId;
        private NumericUpDown field7_2;
        private RichTextBox encyclopediaDescription;
        private TextBox name;
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
            this.nextProductionFamily_0 = new System.Windows.Forms.NumericUpDown();
            this.productionFamily_0 = new System.Windows.Forms.NumericUpDown();
            this.id = new System.Windows.Forms.NumericUpDown();
            this.productionFamily_0Label = new System.Windows.Forms.Label();
            this.yPosition = new System.Windows.Forms.NumericUpDown();
            this.field2_1Label = new System.Windows.Forms.Label();
            this.field2_1 = new System.Windows.Forms.NumericUpDown();
            this.idLabel = new System.Windows.Forms.Label();
            this.xPosition = new System.Windows.Forms.NumericUpDown();
            this.positionLabel = new System.Windows.Forms.Label();
            this.encyclopediaDescription = new System.Windows.Forms.RichTextBox();
            this.familyCommentLabel = new System.Windows.Forms.Label();
            this.nextProductionFamily_0Label = new System.Windows.Forms.Label();
            this.familyIdLabel = new System.Windows.Forms.Label();
            this.textStraDllIdLabel = new System.Windows.Forms.Label();
            this.textStraDllId = new System.Windows.Forms.NumericUpDown();
            this.field7_2 = new System.Windows.Forms.NumericUpDown();
            this.field7_2Label = new System.Windows.Forms.Label();
            this.secImportLabel = new System.Windows.Forms.Label();
            this.inGameDataGroupBox = new System.Windows.Forms.GroupBox();
            this.encyclopediaDescriptionLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.idHexLabel = new System.Windows.Forms.Label();
            this.hiddenDataGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galaxySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFamily_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFamily_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7_2)).BeginInit();
            this.inGameDataGroupBox.SuspendLayout();
            this.hiddenDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(363, 296);
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
            this.SaveAs.Location = new System.Drawing.Point(267, 296);
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
            this.Cancel.Location = new System.Drawing.Point(171, 296);
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
            this.Ok.Location = new System.Drawing.Point(75, 296);
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
            this.selector.Location = new System.Drawing.Point(13, 12);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 19;
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(346, 45);
            this.selector.TabIndex = 149;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            // 
            // familyId
            // 
            this.familyId.ForeColor = System.Drawing.Color.Red;
            this.familyId.Location = new System.Drawing.Point(147, 121);
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
            this.galaxySize.Location = new System.Drawing.Point(147, 225);
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
            this.galaxySizeLabel.ForeColor = System.Drawing.Color.Green;
            this.galaxySizeLabel.Location = new System.Drawing.Point(10, 227);
            this.galaxySizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.galaxySizeLabel.Name = "galaxySizeLabel";
            this.galaxySizeLabel.Size = new System.Drawing.Size(78, 15);
            this.galaxySizeLabel.TabIndex = 12;
            this.galaxySizeLabel.Text = "Galaxy Size **";
            // 
            // secImport
            // 
            this.secImport.Location = new System.Drawing.Point(147, 199);
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
            // nextProductionFamily_0
            // 
            this.nextProductionFamily_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.nextProductionFamily_0.Location = new System.Drawing.Point(147, 95);
            this.nextProductionFamily_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextProductionFamily_0.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nextProductionFamily_0.Name = "nextProductionFamily_0";
            this.nextProductionFamily_0.Size = new System.Drawing.Size(59, 23);
            this.nextProductionFamily_0.TabIndex = 6;
            this.nextProductionFamily_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nextProductionFamily_0.ValueChanged += new System.EventHandler(this.nextProductionFamily_0_ValueChanged);
            // 
            // productionFamily_0
            // 
            this.productionFamily_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.productionFamily_0.Location = new System.Drawing.Point(147, 69);
            this.productionFamily_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productionFamily_0.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.productionFamily_0.Name = "productionFamily_0";
            this.productionFamily_0.Size = new System.Drawing.Size(59, 23);
            this.productionFamily_0.TabIndex = 11;
            this.productionFamily_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.productionFamily_0.ValueChanged += new System.EventHandler(this.productionFamily_0_ValueChanged);
            // 
            // id
            // 
            this.id.ForeColor = System.Drawing.Color.Red;
            this.id.Location = new System.Drawing.Point(147, 17);
            this.id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.id.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(59, 23);
            this.id.TabIndex = 10;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.id.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.id.ValueChanged += new System.EventHandler(this.id_ValueChanged);
            // 
            // productionFamily_0Label
            // 
            this.productionFamily_0Label.AutoSize = true;
            this.productionFamily_0Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.productionFamily_0Label.Location = new System.Drawing.Point(10, 71);
            this.productionFamily_0Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productionFamily_0Label.Name = "productionFamily_0Label";
            this.productionFamily_0Label.Size = new System.Drawing.Size(104, 15);
            this.productionFamily_0Label.TabIndex = 12;
            this.productionFamily_0Label.Text = "Production Family";
            // 
            // yPosition
            // 
            this.yPosition.Location = new System.Drawing.Point(214, 251);
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
            // field2_1Label
            // 
            this.field2_1Label.AutoSize = true;
            this.field2_1Label.ForeColor = System.Drawing.Color.Red;
            this.field2_1Label.Location = new System.Drawing.Point(10, 45);
            this.field2_1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field2_1Label.Name = "field2_1Label";
            this.field2_1Label.Size = new System.Drawing.Size(93, 15);
            this.field2_1Label.TabIndex = 0;
            this.field2_1Label.Text = "Field2 (always 1)";
            // 
            // field2_1
            // 
            this.field2_1.ForeColor = System.Drawing.Color.Red;
            this.field2_1.Location = new System.Drawing.Point(147, 43);
            this.field2_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.field2_1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.field2_1.Name = "field2_1";
            this.field2_1.Size = new System.Drawing.Size(59, 23);
            this.field2_1.TabIndex = 8;
            this.field2_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.field2_1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.field2_1.ValueChanged += new System.EventHandler(this.field2_1_ValueChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.ForeColor = System.Drawing.Color.Red;
            this.idLabel.Location = new System.Drawing.Point(10, 19);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(17, 15);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Id";
            // 
            // xPosition
            // 
            this.xPosition.Location = new System.Drawing.Point(147, 251);
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
            this.positionLabel.Location = new System.Drawing.Point(10, 253);
            this.positionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(81, 15);
            this.positionLabel.TabIndex = 0;
            this.positionLabel.Text = "Position (X, Y)";
            // 
            // encyclopediaDescription
            // 
            this.encyclopediaDescription.Cursor = System.Windows.Forms.Cursors.No;
            this.encyclopediaDescription.Enabled = false;
            this.encyclopediaDescription.Location = new System.Drawing.Point(7, 66);
            this.encyclopediaDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.encyclopediaDescription.MaximumSize = new System.Drawing.Size(334, 136);
            this.encyclopediaDescription.MinimumSize = new System.Drawing.Size(334, 136);
            this.encyclopediaDescription.Name = "encyclopediaDescription";
            this.encyclopediaDescription.Size = new System.Drawing.Size(334, 136);
            this.encyclopediaDescription.TabIndex = 134;
            this.encyclopediaDescription.TabStop = false;
            this.encyclopediaDescription.Text = "Not implemented yet.";
            this.encyclopediaDescription.TextChanged += new System.EventHandler(this.encyclopediaDescription_TextChanged);
            // 
            // familyCommentLabel
            // 
            this.familyCommentLabel.AutoSize = true;
            this.familyCommentLabel.ForeColor = System.Drawing.Color.Blue;
            this.familyCommentLabel.Location = new System.Drawing.Point(19, 268);
            this.familyCommentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyCommentLabel.Name = "familyCommentLabel";
            this.familyCommentLabel.Size = new System.Drawing.Size(116, 15);
            this.familyCommentLabel.TabIndex = 158;
            this.familyCommentLabel.Text = "* 144=Core 146=Rim";
            // 
            // nextProductionFamily_0Label
            // 
            this.nextProductionFamily_0Label.AutoSize = true;
            this.nextProductionFamily_0Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.nextProductionFamily_0Label.Location = new System.Drawing.Point(10, 97);
            this.nextProductionFamily_0Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nextProductionFamily_0Label.Name = "nextProductionFamily_0Label";
            this.nextProductionFamily_0Label.Size = new System.Drawing.Size(121, 15);
            this.nextProductionFamily_0Label.TabIndex = 160;
            this.nextProductionFamily_0Label.Text = "Production Family +1";
            // 
            // familyIdLabel
            // 
            this.familyIdLabel.AutoSize = true;
            this.familyIdLabel.ForeColor = System.Drawing.Color.Blue;
            this.familyIdLabel.Location = new System.Drawing.Point(10, 123);
            this.familyIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdLabel.Name = "familyIdLabel";
            this.familyIdLabel.Size = new System.Drawing.Size(63, 15);
            this.familyIdLabel.TabIndex = 161;
            this.familyIdLabel.Text = "Family Id *";
            // 
            // textStraDllIdLabel
            // 
            this.textStraDllIdLabel.AutoSize = true;
            this.textStraDllIdLabel.ForeColor = System.Drawing.Color.Red;
            this.textStraDllIdLabel.Location = new System.Drawing.Point(10, 149);
            this.textStraDllIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textStraDllIdLabel.Name = "textStraDllIdLabel";
            this.textStraDllIdLabel.Size = new System.Drawing.Size(77, 15);
            this.textStraDllIdLabel.TabIndex = 163;
            this.textStraDllIdLabel.Text = "TextStra.dll Id";
            // 
            // textStraDllId
            // 
            this.textStraDllId.ForeColor = System.Drawing.Color.Red;
            this.textStraDllId.Location = new System.Drawing.Point(147, 147);
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
            // field7_2
            // 
            this.field7_2.ForeColor = System.Drawing.Color.Red;
            this.field7_2.Location = new System.Drawing.Point(147, 173);
            this.field7_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.field7_2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.field7_2.Name = "field7_2";
            this.field7_2.Size = new System.Drawing.Size(59, 23);
            this.field7_2.TabIndex = 165;
            this.field7_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.field7_2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.field7_2.ValueChanged += new System.EventHandler(this.field7_2_ValueChanged);
            // 
            // field7_2Label
            // 
            this.field7_2Label.AutoSize = true;
            this.field7_2Label.ForeColor = System.Drawing.Color.Red;
            this.field7_2Label.Location = new System.Drawing.Point(10, 175);
            this.field7_2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field7_2Label.Name = "field7_2Label";
            this.field7_2Label.Size = new System.Drawing.Size(93, 15);
            this.field7_2Label.TabIndex = 164;
            this.field7_2Label.Text = "Field7 (always 2)";
            // 
            // secImportLabel
            // 
            this.secImportLabel.AutoSize = true;
            this.secImportLabel.Location = new System.Drawing.Point(10, 201);
            this.secImportLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secImportLabel.Name = "secImportLabel";
            this.secImportLabel.Size = new System.Drawing.Size(64, 15);
            this.secImportLabel.TabIndex = 166;
            this.secImportLabel.Text = "Sec Import";
            // 
            // inGameDataGroupBox
            // 
            this.inGameDataGroupBox.Controls.Add(this.encyclopediaDescriptionLabel);
            this.inGameDataGroupBox.Controls.Add(this.name);
            this.inGameDataGroupBox.Controls.Add(this.nameLabel);
            this.inGameDataGroupBox.Controls.Add(this.encyclopediaDescription);
            this.inGameDataGroupBox.Location = new System.Drawing.Point(12, 52);
            this.inGameDataGroupBox.Name = "inGameDataGroupBox";
            this.inGameDataGroupBox.Size = new System.Drawing.Size(347, 208);
            this.inGameDataGroupBox.TabIndex = 167;
            this.inGameDataGroupBox.TabStop = false;
            this.inGameDataGroupBox.Text = "In Game Data";
            // 
            // encyclopediaDescriptionLabel
            // 
            this.encyclopediaDescriptionLabel.AutoSize = true;
            this.encyclopediaDescriptionLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.encyclopediaDescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.encyclopediaDescriptionLabel.Location = new System.Drawing.Point(191, 52);
            this.encyclopediaDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encyclopediaDescriptionLabel.Name = "encyclopediaDescriptionLabel";
            this.encyclopediaDescriptionLabel.Size = new System.Drawing.Size(140, 15);
            this.encyclopediaDescriptionLabel.TabIndex = 1128;
            this.encyclopediaDescriptionLabel.Text = "Encyclopedia Description";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(63, 21);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(278, 23);
            this.name.TabIndex = 169;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(17, 24);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 168;
            this.nameLabel.Text = "Name";
            // 
            // familyIdHexLabel
            // 
            this.familyIdHexLabel.AutoSize = true;
            this.familyIdHexLabel.ForeColor = System.Drawing.Color.Red;
            this.familyIdHexLabel.Location = new System.Drawing.Point(214, 123);
            this.familyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdHexLabel.Name = "familyIdHexLabel";
            this.familyIdHexLabel.Size = new System.Drawing.Size(31, 15);
            this.familyIdHexLabel.TabIndex = 168;
            this.familyIdHexLabel.Text = "0x00";
            // 
            // idHexLabel
            // 
            this.idHexLabel.AutoSize = true;
            this.idHexLabel.ForeColor = System.Drawing.Color.Red;
            this.idHexLabel.Location = new System.Drawing.Point(214, 19);
            this.idHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idHexLabel.Name = "idHexLabel";
            this.idHexLabel.Size = new System.Drawing.Size(31, 15);
            this.idHexLabel.TabIndex = 169;
            this.idHexLabel.Text = "0x00";
            // 
            // hiddenDataGroupBox
            // 
            this.hiddenDataGroupBox.Controls.Add(this.idLabel);
            this.hiddenDataGroupBox.Controls.Add(this.familyIdHexLabel);
            this.hiddenDataGroupBox.Controls.Add(this.secImportLabel);
            this.hiddenDataGroupBox.Controls.Add(this.idHexLabel);
            this.hiddenDataGroupBox.Controls.Add(this.field7_2);
            this.hiddenDataGroupBox.Controls.Add(this.id);
            this.hiddenDataGroupBox.Controls.Add(this.field7_2Label);
            this.hiddenDataGroupBox.Controls.Add(this.galaxySize);
            this.hiddenDataGroupBox.Controls.Add(this.field2_1Label);
            this.hiddenDataGroupBox.Controls.Add(this.galaxySizeLabel);
            this.hiddenDataGroupBox.Controls.Add(this.field2_1);
            this.hiddenDataGroupBox.Controls.Add(this.secImport);
            this.hiddenDataGroupBox.Controls.Add(this.nextProductionFamily_0Label);
            this.hiddenDataGroupBox.Controls.Add(this.textStraDllIdLabel);
            this.hiddenDataGroupBox.Controls.Add(this.yPosition);
            this.hiddenDataGroupBox.Controls.Add(this.productionFamily_0Label);
            this.hiddenDataGroupBox.Controls.Add(this.textStraDllId);
            this.hiddenDataGroupBox.Controls.Add(this.nextProductionFamily_0);
            this.hiddenDataGroupBox.Controls.Add(this.familyIdLabel);
            this.hiddenDataGroupBox.Controls.Add(this.xPosition);
            this.hiddenDataGroupBox.Controls.Add(this.familyId);
            this.hiddenDataGroupBox.Controls.Add(this.positionLabel);
            this.hiddenDataGroupBox.Controls.Add(this.productionFamily_0);
            this.hiddenDataGroupBox.Location = new System.Drawing.Point(366, 12);
            this.hiddenDataGroupBox.Name = "hiddenDataGroupBox";
            this.hiddenDataGroupBox.Size = new System.Drawing.Size(278, 280);
            this.hiddenDataGroupBox.TabIndex = 170;
            this.hiddenDataGroupBox.TabStop = false;
            this.hiddenDataGroupBox.Text = "Hidden Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(182, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 15);
            this.label1.TabIndex = 171;
            this.label1.Text = "** 1=Small 2=Medium 3=Large";
            // 
            // SectorsForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(650, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hiddenDataGroupBox);
            this.Controls.Add(this.inGameDataGroupBox);
            this.Controls.Add(this.familyCommentLabel);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.selector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(666, 367);
            this.MinimumSize = new System.Drawing.Size(666, 367);
            this.Name = "SectorsForm";
            this.Text = "Sectors (SECTORSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galaxySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFamily_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFamily_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7_2)).EndInit();
            this.inGameDataGroupBox.ResumeLayout(false);
            this.inGameDataGroupBox.PerformLayout();
            this.hiddenDataGroupBox.ResumeLayout(false);
            this.hiddenDataGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label encyclopediaDescriptionLabel;
        private GroupBox hiddenDataGroupBox;
        private Label label1;
    }
}