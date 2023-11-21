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
        private IContainer components = null;
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
        private NumericUpDown sectorGroup;
        private NumericUpDown sectorGalaxySize;
        private NumericUpDown sectorYPosition;
        private NumericUpDown sectorXPosition;
        private Label label4;
        private Label familyIdStringLabel;
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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(SystemsForm));
            systemsListView = new ListView();
            systemsImageList = new ImageList(components);
            Open = new Button();
            SaveAs = new Button();
            Cancel = new Button();
            Ok = new Button();
            selector = new TrackBar();
            sectorGroupBox = new GroupBox();
            sectorName = new TextBox();
            sectorGalaxySizeLabel = new Label();
            sectorNameLabel = new Label();
            sectorSecImportLabel = new Label();
            sectorFamilyIdHexLabel = new Label();
            label4 = new Label();
            sectorFamilyId = new NumericUpDown();
            sectorYPosition = new NumericUpDown();
            sectorFamilyIdLabel = new Label();
            sectorTextStraDllIdLabel = new Label();
            sectorXPosition = new NumericUpDown();
            sectorTextStraDllId = new NumericUpDown();
            sectorGroup = new NumericUpDown();
            sectorGalaxySize = new NumericUpDown();
            Field7_2Label = new Label();
            field10_1 = new NumericUpDown();
            sectorId = new NumericUpDown();
            sectorIdLabel = new Label();
            familyIdStringLabel = new Label();
            productionFamily_0 = new NumericUpDown();
            productionFamily_0Label = new Label();
            idHexLabel = new Label();
            nextProductionFamily_0Label = new Label();
            nextProductionFamily_0 = new NumericUpDown();
            id = new NumericUpDown();
            familyIdLabel = new Label();
            textStraDllIdLabel = new Label();
            familyId = new NumericUpDown();
            textStraDllId = new NumericUpDown();
            field7_2 = new NumericUpDown();
            field10_1Label = new Label();
            pictureId = new NumericUpDown();
            idLabel = new Label();
            yPosition = new NumericUpDown();
            field13_0Label = new Label();
            field13_0 = new NumericUpDown();
            xPosition = new NumericUpDown();
            positionLabel = new Label();
            picture = new PictureBox();
            familyIdInfoLabel = new Label();
            pictureIdLabel = new Label();
            field2_1 = new NumericUpDown();
            field2_1Label = new Label();
            inGameDataGroupBox = new GroupBox();
            sprite = new PictureBox();
            encyclopediaDescriptionLabel = new Label();
            name = new TextBox();
            nameLabel = new Label();
            encyclopediaDescription = new RichTextBox();
            hiddenDataGroupBox = new GroupBox();
            infoLabel = new Label();
            ((ISupportInitialize)selector).BeginInit();
            sectorGroupBox.SuspendLayout();
            ((ISupportInitialize)sectorFamilyId).BeginInit();
            ((ISupportInitialize)sectorYPosition).BeginInit();
            ((ISupportInitialize)sectorXPosition).BeginInit();
            ((ISupportInitialize)sectorTextStraDllId).BeginInit();
            ((ISupportInitialize)sectorGroup).BeginInit();
            ((ISupportInitialize)sectorGalaxySize).BeginInit();
            ((ISupportInitialize)field10_1).BeginInit();
            ((ISupportInitialize)sectorId).BeginInit();
            ((ISupportInitialize)productionFamily_0).BeginInit();
            ((ISupportInitialize)nextProductionFamily_0).BeginInit();
            ((ISupportInitialize)id).BeginInit();
            ((ISupportInitialize)familyId).BeginInit();
            ((ISupportInitialize)textStraDllId).BeginInit();
            ((ISupportInitialize)field7_2).BeginInit();
            ((ISupportInitialize)pictureId).BeginInit();
            ((ISupportInitialize)yPosition).BeginInit();
            ((ISupportInitialize)field13_0).BeginInit();
            ((ISupportInitialize)xPosition).BeginInit();
            ((ISupportInitialize)picture).BeginInit();
            ((ISupportInitialize)field2_1).BeginInit();
            inGameDataGroupBox.SuspendLayout();
            ((ISupportInitialize)sprite).BeginInit();
            hiddenDataGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // systemsListView
            // 
            systemsListView.BackColor = SystemColors.ControlLight;
            systemsListView.BorderStyle = BorderStyle.FixedSingle;
            systemsListView.GridLines = true;
            systemsListView.LargeImageList = systemsImageList;
            systemsListView.Location = new Point(4, 3);
            systemsListView.Margin = new Padding(0);
            systemsListView.MultiSelect = false;
            systemsListView.Name = "systemsListView";
            systemsListView.ShowGroups = false;
            systemsListView.Size = new Size(185, 440);
            systemsListView.TabIndex = 1;
            systemsListView.TabStop = false;
            systemsListView.UseCompatibleStateImageBehavior = false;
            systemsListView.Click += systemsListView_Click;
            systemsListView.DoubleClick += systemsListView_DoubleClick;
            // 
            // systemsImageList
            // 
            systemsImageList.ColorDepth = ColorDepth.Depth8Bit;
            systemsImageList.ImageSize = new Size(120, 60);
            systemsImageList.TransparentColor = Color.Transparent;
            // 
            // Open
            // 
            Open.Location = new Point(403, 449);
            Open.Margin = new Padding(4, 3, 4, 3);
            Open.Name = "Open";
            Open.Size = new Size(88, 27);
            Open.TabIndex = 21;
            Open.TabStop = false;
            Open.Text = "Open...";
            Open.UseVisualStyleBackColor = true;
            Open.Click += Open_Click;
            // 
            // SaveAs
            // 
            SaveAs.Location = new Point(307, 449);
            SaveAs.Margin = new Padding(4, 3, 4, 3);
            SaveAs.Name = "SaveAs";
            SaveAs.Size = new Size(88, 27);
            SaveAs.TabIndex = 20;
            SaveAs.TabStop = false;
            SaveAs.Text = "&SaveAs...";
            SaveAs.UseVisualStyleBackColor = true;
            SaveAs.Click += SaveAs_Click;
            // 
            // Cancel
            // 
            Cancel.DialogResult = DialogResult.Cancel;
            Cancel.Location = new Point(211, 449);
            Cancel.Margin = new Padding(4, 3, 4, 3);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(88, 27);
            Cancel.TabIndex = 19;
            Cancel.Text = "&Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Ok
            // 
            Ok.Location = new Point(115, 449);
            Ok.Margin = new Padding(4, 3, 4, 3);
            Ok.Name = "Ok";
            Ok.Size = new Size(88, 27);
            Ok.TabIndex = 18;
            Ok.Text = "&Ok";
            Ok.UseVisualStyleBackColor = true;
            Ok.Click += Ok_Click;
            // 
            // selector
            // 
            selector.LargeChange = 1;
            selector.Location = new Point(193, 3);
            selector.Margin = new Padding(4, 3, 4, 3);
            selector.Maximum = 199;
            selector.Name = "selector";
            selector.Size = new Size(447, 45);
            selector.TabIndex = 2;
            selector.ValueChanged += GameObjectsSelector_ValueChanged;
            // 
            // sectorGroupBox
            // 
            sectorGroupBox.Controls.Add(sectorName);
            sectorGroupBox.Controls.Add(sectorGalaxySizeLabel);
            sectorGroupBox.Controls.Add(sectorNameLabel);
            sectorGroupBox.Controls.Add(sectorSecImportLabel);
            sectorGroupBox.Controls.Add(sectorFamilyIdHexLabel);
            sectorGroupBox.Controls.Add(label4);
            sectorGroupBox.Controls.Add(sectorFamilyId);
            sectorGroupBox.Controls.Add(sectorYPosition);
            sectorGroupBox.Controls.Add(sectorFamilyIdLabel);
            sectorGroupBox.Controls.Add(sectorTextStraDllIdLabel);
            sectorGroupBox.Controls.Add(sectorXPosition);
            sectorGroupBox.Controls.Add(sectorTextStraDllId);
            sectorGroupBox.Controls.Add(sectorGroup);
            sectorGroupBox.Controls.Add(sectorGalaxySize);
            sectorGroupBox.Location = new Point(193, 337);
            sectorGroupBox.Margin = new Padding(4, 3, 4, 3);
            sectorGroupBox.Name = "sectorGroupBox";
            sectorGroupBox.Padding = new Padding(4, 3, 4, 3);
            sectorGroupBox.Size = new Size(483, 106);
            sectorGroupBox.TabIndex = 0;
            sectorGroupBox.TabStop = false;
            sectorGroupBox.Text = "Sector (SECTORSD.DAT)";
            // 
            // sectorName
            // 
            sectorName.Enabled = false;
            sectorName.Location = new Point(63, 22);
            sectorName.Name = "sectorName";
            sectorName.Size = new Size(134, 23);
            sectorName.TabIndex = 0;
            // 
            // sectorGalaxySizeLabel
            // 
            sectorGalaxySizeLabel.AutoSize = true;
            sectorGalaxySizeLabel.Enabled = false;
            sectorGalaxySizeLabel.Location = new Point(259, 50);
            sectorGalaxySizeLabel.Margin = new Padding(4, 0, 4, 0);
            sectorGalaxySizeLabel.Name = "sectorGalaxySizeLabel";
            sectorGalaxySizeLabel.Size = new Size(65, 15);
            sectorGalaxySizeLabel.TabIndex = 0;
            sectorGalaxySizeLabel.Text = "Galaxy Size";
            // 
            // sectorNameLabel
            // 
            sectorNameLabel.AutoSize = true;
            sectorNameLabel.Enabled = false;
            sectorNameLabel.Location = new Point(10, 25);
            sectorNameLabel.Margin = new Padding(4, 0, 4, 0);
            sectorNameLabel.Name = "sectorNameLabel";
            sectorNameLabel.Size = new Size(39, 15);
            sectorNameLabel.TabIndex = 171;
            sectorNameLabel.Text = "Name";
            // 
            // sectorSecImportLabel
            // 
            sectorSecImportLabel.AutoSize = true;
            sectorSecImportLabel.Enabled = false;
            sectorSecImportLabel.Location = new Point(259, 25);
            sectorSecImportLabel.Margin = new Padding(4, 0, 4, 0);
            sectorSecImportLabel.Name = "sectorSecImportLabel";
            sectorSecImportLabel.Size = new Size(40, 15);
            sectorSecImportLabel.TabIndex = 0;
            sectorSecImportLabel.Text = "Group";
            // 
            // sectorFamilyIdHexLabel
            // 
            sectorFamilyIdHexLabel.AutoSize = true;
            sectorFamilyIdHexLabel.Enabled = false;
            sectorFamilyIdHexLabel.Location = new Point(205, 52);
            sectorFamilyIdHexLabel.Margin = new Padding(4, 0, 4, 0);
            sectorFamilyIdHexLabel.Name = "sectorFamilyIdHexLabel";
            sectorFamilyIdHexLabel.Size = new Size(31, 15);
            sectorFamilyIdHexLabel.TabIndex = 0;
            sectorFamilyIdHexLabel.Text = "0x00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Location = new Point(259, 76);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 0;
            label4.Text = "Position (X, Y)";
            // 
            // sectorFamilyId
            // 
            sectorFamilyId.Enabled = false;
            sectorFamilyId.Location = new Point(138, 48);
            sectorFamilyId.Margin = new Padding(4, 3, 4, 3);
            sectorFamilyId.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            sectorFamilyId.Name = "sectorFamilyId";
            sectorFamilyId.Size = new Size(59, 23);
            sectorFamilyId.TabIndex = 0;
            sectorFamilyId.TabStop = false;
            sectorFamilyId.TextAlign = HorizontalAlignment.Right;
            sectorFamilyId.Value = new decimal(new int[] { -1, 0, 0, 0 });
            // 
            // sectorYPosition
            // 
            sectorYPosition.Enabled = false;
            sectorYPosition.Location = new Point(417, 74);
            sectorYPosition.Margin = new Padding(4, 3, 4, 3);
            sectorYPosition.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            sectorYPosition.Name = "sectorYPosition";
            sectorYPosition.Size = new Size(59, 23);
            sectorYPosition.TabIndex = 0;
            sectorYPosition.TextAlign = HorizontalAlignment.Right;
            sectorYPosition.Value = new decimal(new int[] { -1, 0, 0, 0 });
            // 
            // sectorFamilyIdLabel
            // 
            sectorFamilyIdLabel.AutoSize = true;
            sectorFamilyIdLabel.Enabled = false;
            sectorFamilyIdLabel.Location = new Point(10, 52);
            sectorFamilyIdLabel.Margin = new Padding(4, 0, 4, 0);
            sectorFamilyIdLabel.Name = "sectorFamilyIdLabel";
            sectorFamilyIdLabel.Size = new Size(55, 15);
            sectorFamilyIdLabel.TabIndex = 1154;
            sectorFamilyIdLabel.Text = "Family Id";
            // 
            // sectorTextStraDllIdLabel
            // 
            sectorTextStraDllIdLabel.AutoSize = true;
            sectorTextStraDllIdLabel.Enabled = false;
            sectorTextStraDllIdLabel.Location = new Point(10, 76);
            sectorTextStraDllIdLabel.Margin = new Padding(4, 0, 4, 0);
            sectorTextStraDllIdLabel.Name = "sectorTextStraDllIdLabel";
            sectorTextStraDllIdLabel.Size = new Size(77, 15);
            sectorTextStraDllIdLabel.TabIndex = 0;
            sectorTextStraDllIdLabel.Text = "TextStra.dll Id";
            // 
            // sectorXPosition
            // 
            sectorXPosition.Enabled = false;
            sectorXPosition.Location = new Point(350, 74);
            sectorXPosition.Margin = new Padding(4, 3, 4, 3);
            sectorXPosition.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            sectorXPosition.Name = "sectorXPosition";
            sectorXPosition.Size = new Size(59, 23);
            sectorXPosition.TabIndex = 0;
            sectorXPosition.TextAlign = HorizontalAlignment.Right;
            sectorXPosition.Value = new decimal(new int[] { -1, 0, 0, 0 });
            // 
            // sectorTextStraDllId
            // 
            sectorTextStraDllId.Enabled = false;
            sectorTextStraDllId.Location = new Point(138, 74);
            sectorTextStraDllId.Margin = new Padding(4, 3, 4, 3);
            sectorTextStraDllId.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            sectorTextStraDllId.Name = "sectorTextStraDllId";
            sectorTextStraDllId.Size = new Size(59, 23);
            sectorTextStraDllId.TabIndex = 0;
            sectorTextStraDllId.TabStop = false;
            sectorTextStraDllId.TextAlign = HorizontalAlignment.Right;
            sectorTextStraDllId.Value = new decimal(new int[] { -1, 0, 0, 0 });
            // 
            // sectorGroup
            // 
            sectorGroup.Enabled = false;
            sectorGroup.Location = new Point(350, 22);
            sectorGroup.Margin = new Padding(4, 3, 4, 3);
            sectorGroup.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            sectorGroup.Name = "sectorGroup";
            sectorGroup.Size = new Size(59, 23);
            sectorGroup.TabIndex = 0;
            sectorGroup.TextAlign = HorizontalAlignment.Right;
            sectorGroup.Value = new decimal(new int[] { -1, 0, 0, 0 });
            // 
            // sectorGalaxySize
            // 
            sectorGalaxySize.Enabled = false;
            sectorGalaxySize.Location = new Point(350, 48);
            sectorGalaxySize.Margin = new Padding(4, 3, 4, 3);
            sectorGalaxySize.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            sectorGalaxySize.Name = "sectorGalaxySize";
            sectorGalaxySize.Size = new Size(59, 23);
            sectorGalaxySize.TabIndex = 0;
            sectorGalaxySize.TextAlign = HorizontalAlignment.Right;
            sectorGalaxySize.Value = new decimal(new int[] { -1, 0, 0, 0 });
            // 
            // Field7_2Label
            // 
            Field7_2Label.AutoSize = true;
            Field7_2Label.ForeColor = Color.Red;
            Field7_2Label.Location = new Point(11, 180);
            Field7_2Label.Margin = new Padding(4, 0, 4, 0);
            Field7_2Label.Name = "Field7_2Label";
            Field7_2Label.Size = new Size(93, 15);
            Field7_2Label.TabIndex = 0;
            Field7_2Label.Text = "Field7 (always 2)";
            // 
            // field10_1
            // 
            field10_1.ForeColor = Color.Red;
            field10_1.Location = new Point(153, 256);
            field10_1.Margin = new Padding(4, 3, 4, 3);
            field10_1.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            field10_1.Name = "field10_1";
            field10_1.Size = new Size(59, 23);
            field10_1.TabIndex = 14;
            field10_1.TextAlign = HorizontalAlignment.Right;
            field10_1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            field10_1.ValueChanged += field10_1_ValueChanged;
            // 
            // sectorId
            // 
            sectorId.BackColor = SystemColors.Window;
            sectorId.Location = new Point(153, 204);
            sectorId.Margin = new Padding(4, 3, 4, 3);
            sectorId.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            sectorId.Name = "sectorId";
            sectorId.Size = new Size(59, 23);
            sectorId.TabIndex = 12;
            sectorId.TabStop = false;
            sectorId.TextAlign = HorizontalAlignment.Right;
            sectorId.Value = new decimal(new int[] { -1, 0, 0, 0 });
            sectorId.ValueChanged += sectorId_ValueChanged;
            // 
            // sectorIdLabel
            // 
            sectorIdLabel.AutoSize = true;
            sectorIdLabel.Location = new Point(11, 206);
            sectorIdLabel.Margin = new Padding(4, 0, 4, 0);
            sectorIdLabel.Name = "sectorIdLabel";
            sectorIdLabel.Size = new Size(53, 15);
            sectorIdLabel.TabIndex = 0;
            sectorIdLabel.Text = "Sector Id";
            // 
            // familyIdStringLabel
            // 
            familyIdStringLabel.AutoSize = true;
            familyIdStringLabel.ForeColor = Color.Blue;
            familyIdStringLabel.Location = new Point(220, 128);
            familyIdStringLabel.Margin = new Padding(4, 0, 4, 0);
            familyIdStringLabel.Name = "familyIdStringLabel";
            familyIdStringLabel.Size = new Size(31, 15);
            familyIdStringLabel.TabIndex = 0;
            familyIdStringLabel.Text = "0x00";
            // 
            // productionFamily_0
            // 
            productionFamily_0.ForeColor = Color.FromArgb(192, 0, 192);
            productionFamily_0.Location = new Point(153, 74);
            productionFamily_0.Margin = new Padding(4, 3, 4, 3);
            productionFamily_0.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            productionFamily_0.Name = "productionFamily_0";
            productionFamily_0.Size = new Size(59, 23);
            productionFamily_0.TabIndex = 7;
            productionFamily_0.TabStop = false;
            productionFamily_0.TextAlign = HorizontalAlignment.Right;
            productionFamily_0.ValueChanged += productionFamily_0_ValueChanged;
            // 
            // productionFamily_0Label
            // 
            productionFamily_0Label.AutoSize = true;
            productionFamily_0Label.ForeColor = Color.FromArgb(192, 0, 192);
            productionFamily_0Label.Location = new Point(11, 76);
            productionFamily_0Label.Margin = new Padding(4, 0, 4, 0);
            productionFamily_0Label.Name = "productionFamily_0Label";
            productionFamily_0Label.Size = new Size(104, 15);
            productionFamily_0Label.TabIndex = 0;
            productionFamily_0Label.Text = "Production Family";
            // 
            // idHexLabel
            // 
            idHexLabel.AutoSize = true;
            idHexLabel.ForeColor = Color.Red;
            idHexLabel.Location = new Point(220, 24);
            idHexLabel.Margin = new Padding(4, 0, 4, 0);
            idHexLabel.Name = "idHexLabel";
            idHexLabel.Size = new Size(31, 15);
            idHexLabel.TabIndex = 0;
            idHexLabel.Text = "0x00";
            // 
            // nextProductionFamily_0Label
            // 
            nextProductionFamily_0Label.AutoSize = true;
            nextProductionFamily_0Label.ForeColor = Color.FromArgb(192, 0, 192);
            nextProductionFamily_0Label.Location = new Point(11, 102);
            nextProductionFamily_0Label.Margin = new Padding(4, 0, 4, 0);
            nextProductionFamily_0Label.Name = "nextProductionFamily_0Label";
            nextProductionFamily_0Label.Size = new Size(121, 15);
            nextProductionFamily_0Label.TabIndex = 0;
            nextProductionFamily_0Label.Text = "Production Family +1";
            // 
            // nextProductionFamily_0
            // 
            nextProductionFamily_0.ForeColor = Color.FromArgb(192, 0, 192);
            nextProductionFamily_0.Location = new Point(153, 100);
            nextProductionFamily_0.Margin = new Padding(4, 3, 4, 3);
            nextProductionFamily_0.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            nextProductionFamily_0.Name = "nextProductionFamily_0";
            nextProductionFamily_0.Size = new Size(59, 23);
            nextProductionFamily_0.TabIndex = 8;
            nextProductionFamily_0.TabStop = false;
            nextProductionFamily_0.TextAlign = HorizontalAlignment.Right;
            nextProductionFamily_0.ValueChanged += nextProductionFamily_0_ValueChanged;
            // 
            // id
            // 
            id.BackColor = SystemColors.Window;
            id.ForeColor = Color.Red;
            id.Location = new Point(153, 22);
            id.Margin = new Padding(4, 3, 4, 3);
            id.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            id.Name = "id";
            id.Size = new Size(59, 23);
            id.TabIndex = 5;
            id.TextAlign = HorizontalAlignment.Right;
            id.Value = new decimal(new int[] { -1, 0, 0, 0 });
            id.ValueChanged += id_ValueChanged;
            // 
            // familyIdLabel
            // 
            familyIdLabel.AutoSize = true;
            familyIdLabel.ForeColor = Color.Blue;
            familyIdLabel.Location = new Point(11, 128);
            familyIdLabel.Margin = new Padding(4, 0, 4, 0);
            familyIdLabel.Name = "familyIdLabel";
            familyIdLabel.Size = new Size(63, 15);
            familyIdLabel.TabIndex = 0;
            familyIdLabel.Text = "Family Id *";
            // 
            // textStraDllIdLabel
            // 
            textStraDllIdLabel.AutoSize = true;
            textStraDllIdLabel.ForeColor = Color.Red;
            textStraDllIdLabel.Location = new Point(11, 154);
            textStraDllIdLabel.Margin = new Padding(4, 0, 4, 0);
            textStraDllIdLabel.Name = "textStraDllIdLabel";
            textStraDllIdLabel.Size = new Size(77, 15);
            textStraDllIdLabel.TabIndex = 0;
            textStraDllIdLabel.Text = "TextStra.dll Id";
            // 
            // familyId
            // 
            familyId.ForeColor = Color.Blue;
            familyId.Location = new Point(153, 126);
            familyId.Margin = new Padding(4, 3, 4, 3);
            familyId.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            familyId.Name = "familyId";
            familyId.Size = new Size(59, 23);
            familyId.TabIndex = 9;
            familyId.TabStop = false;
            familyId.TextAlign = HorizontalAlignment.Right;
            familyId.Value = new decimal(new int[] { -1, 0, 0, 0 });
            familyId.ValueChanged += familyId_ValueChanged;
            // 
            // textStraDllId
            // 
            textStraDllId.ForeColor = Color.Red;
            textStraDllId.Location = new Point(153, 152);
            textStraDllId.Margin = new Padding(4, 3, 4, 3);
            textStraDllId.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            textStraDllId.Name = "textStraDllId";
            textStraDllId.Size = new Size(59, 23);
            textStraDllId.TabIndex = 10;
            textStraDllId.TabStop = false;
            textStraDllId.TextAlign = HorizontalAlignment.Right;
            textStraDllId.Value = new decimal(new int[] { 65535, 0, 0, 0 });
            textStraDllId.ValueChanged += textStraDllId_ValueChanged;
            // 
            // field7_2
            // 
            field7_2.ForeColor = Color.Red;
            field7_2.Location = new Point(153, 178);
            field7_2.Margin = new Padding(4, 3, 4, 3);
            field7_2.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            field7_2.Name = "field7_2";
            field7_2.Size = new Size(59, 23);
            field7_2.TabIndex = 11;
            field7_2.TabStop = false;
            field7_2.TextAlign = HorizontalAlignment.Right;
            field7_2.Value = new decimal(new int[] { 2, 0, 0, 0 });
            field7_2.ValueChanged += field7_2_ValueChanged;
            // 
            // field10_1Label
            // 
            field10_1Label.AutoSize = true;
            field10_1Label.ForeColor = Color.Red;
            field10_1Label.Location = new Point(11, 258);
            field10_1Label.Margin = new Padding(4, 0, 4, 0);
            field10_1Label.Name = "field10_1Label";
            field10_1Label.Size = new Size(99, 15);
            field10_1Label.TabIndex = 0;
            field10_1Label.Text = "Field10 (always 1)";
            // 
            // pictureId
            // 
            pictureId.Location = new Point(153, 230);
            pictureId.Margin = new Padding(4, 3, 4, 3);
            pictureId.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            pictureId.Name = "pictureId";
            pictureId.Size = new Size(59, 23);
            pictureId.TabIndex = 13;
            pictureId.TextAlign = HorizontalAlignment.Right;
            pictureId.Value = new decimal(new int[] { -1, 0, 0, 0 });
            pictureId.ValueChanged += pictureId_ValueChanged;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.ForeColor = Color.Red;
            idLabel.Location = new Point(11, 24);
            idLabel.Margin = new Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id";
            // 
            // yPosition
            // 
            yPosition.Location = new Point(220, 282);
            yPosition.Margin = new Padding(4, 3, 4, 3);
            yPosition.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            yPosition.Name = "yPosition";
            yPosition.Size = new Size(59, 23);
            yPosition.TabIndex = 16;
            yPosition.TextAlign = HorizontalAlignment.Right;
            yPosition.Value = new decimal(new int[] { 65535, 0, 0, 0 });
            yPosition.ValueChanged += yPosition_ValueChanged;
            // 
            // field13_0Label
            // 
            field13_0Label.AutoSize = true;
            field13_0Label.ForeColor = Color.Red;
            field13_0Label.Location = new Point(11, 310);
            field13_0Label.Margin = new Padding(4, 0, 4, 0);
            field13_0Label.Name = "field13_0Label";
            field13_0Label.Size = new Size(99, 15);
            field13_0Label.TabIndex = 0;
            field13_0Label.Text = "Field13 (always 0)";
            // 
            // field13_0
            // 
            field13_0.ForeColor = Color.Red;
            field13_0.Location = new Point(153, 308);
            field13_0.Margin = new Padding(4, 3, 4, 3);
            field13_0.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            field13_0.Name = "field13_0";
            field13_0.Size = new Size(59, 23);
            field13_0.TabIndex = 17;
            field13_0.TextAlign = HorizontalAlignment.Right;
            field13_0.ValueChanged += field13_0_ValueChanged;
            // 
            // xPosition
            // 
            xPosition.Location = new Point(153, 282);
            xPosition.Margin = new Padding(4, 3, 4, 3);
            xPosition.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            xPosition.Name = "xPosition";
            xPosition.Size = new Size(59, 23);
            xPosition.TabIndex = 15;
            xPosition.TextAlign = HorizontalAlignment.Right;
            xPosition.Value = new decimal(new int[] { 65535, 0, 0, 0 });
            xPosition.ValueChanged += xPosition_ValueChanged;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new Point(11, 284);
            positionLabel.Margin = new Padding(4, 0, 4, 0);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(81, 15);
            positionLabel.TabIndex = 0;
            positionLabel.Text = "Position (X, Y)";
            // 
            // picture
            // 
            picture.BorderStyle = BorderStyle.FixedSingle;
            picture.InitialImage = null;
            picture.Location = new Point(7, 22);
            picture.Margin = new Padding(4, 3, 4, 3);
            picture.Name = "picture";
            picture.Size = new Size(220, 110);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.TabIndex = 156;
            picture.TabStop = false;
            picture.Click += picture_Click;
            // 
            // familyIdInfoLabel
            // 
            familyIdInfoLabel.AutoSize = true;
            familyIdInfoLabel.ForeColor = Color.Blue;
            familyIdInfoLabel.Location = new Point(684, 345);
            familyIdInfoLabel.Margin = new Padding(4, 0, 4, 0);
            familyIdInfoLabel.Name = "familyIdInfoLabel";
            familyIdInfoLabel.Size = new Size(177, 15);
            familyIdInfoLabel.TabIndex = 0;
            familyIdInfoLabel.Text = "* 144=Explored 146=Unexplored";
            // 
            // pictureIdLabel
            // 
            pictureIdLabel.AutoSize = true;
            pictureIdLabel.Location = new Point(11, 232);
            pictureIdLabel.Margin = new Padding(4, 0, 4, 0);
            pictureIdLabel.Name = "pictureIdLabel";
            pictureIdLabel.Size = new Size(57, 15);
            pictureIdLabel.TabIndex = 0;
            pictureIdLabel.Text = "Picture Id";
            // 
            // field2_1
            // 
            field2_1.ForeColor = Color.Red;
            field2_1.Location = new Point(153, 48);
            field2_1.Margin = new Padding(4, 3, 4, 3);
            field2_1.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            field2_1.Name = "field2_1";
            field2_1.Size = new Size(59, 23);
            field2_1.TabIndex = 6;
            field2_1.TabStop = false;
            field2_1.TextAlign = HorizontalAlignment.Right;
            field2_1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            field2_1.ValueChanged += field2_1_ValueChanged;
            // 
            // field2_1Label
            // 
            field2_1Label.AutoSize = true;
            field2_1Label.ForeColor = Color.Red;
            field2_1Label.Location = new Point(11, 50);
            field2_1Label.Margin = new Padding(4, 0, 4, 0);
            field2_1Label.Name = "field2_1Label";
            field2_1Label.Size = new Size(93, 15);
            field2_1Label.TabIndex = 0;
            field2_1Label.Text = "Field2 (always 1)";
            // 
            // inGameDataGroupBox
            // 
            inGameDataGroupBox.Controls.Add(sprite);
            inGameDataGroupBox.Controls.Add(encyclopediaDescriptionLabel);
            inGameDataGroupBox.Controls.Add(name);
            inGameDataGroupBox.Controls.Add(nameLabel);
            inGameDataGroupBox.Controls.Add(encyclopediaDescription);
            inGameDataGroupBox.Controls.Add(picture);
            inGameDataGroupBox.Location = new Point(193, 45);
            inGameDataGroupBox.Name = "inGameDataGroupBox";
            inGameDataGroupBox.Size = new Size(447, 289);
            inGameDataGroupBox.TabIndex = 1153;
            inGameDataGroupBox.TabStop = false;
            inGameDataGroupBox.Text = "In Game Data";
            // 
            // sprite
            // 
            sprite.AllowDrop = true;
            sprite.Location = new Point(238, 86);
            sprite.Name = "sprite";
            sprite.Size = new Size(37, 37);
            sprite.TabIndex = 169;
            sprite.TabStop = false;
            sprite.DragDrop += sprite_DragDrop;
            sprite.DragEnter += sprite_DragEnter;
            // 
            // encyclopediaDescriptionLabel
            // 
            encyclopediaDescriptionLabel.AutoSize = true;
            encyclopediaDescriptionLabel.BackColor = SystemColors.ControlDarkDark;
            encyclopediaDescriptionLabel.ForeColor = Color.White;
            encyclopediaDescriptionLabel.Location = new Point(293, 124);
            encyclopediaDescriptionLabel.Margin = new Padding(4, 0, 4, 0);
            encyclopediaDescriptionLabel.Name = "encyclopediaDescriptionLabel";
            encyclopediaDescriptionLabel.Size = new Size(140, 15);
            encyclopediaDescriptionLabel.TabIndex = 0;
            encyclopediaDescriptionLabel.Text = "Encyclopedia Description";
            // 
            // name
            // 
            name.Location = new Point(232, 54);
            name.Name = "name";
            name.Size = new Size(211, 23);
            name.TabIndex = 3;
            name.TextChanged += name_TextChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(236, 33);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 168;
            nameLabel.Text = "Name";
            // 
            // encyclopediaDescription
            // 
            encyclopediaDescription.Location = new Point(7, 138);
            encyclopediaDescription.Margin = new Padding(4, 3, 4, 3);
            encyclopediaDescription.Name = "encyclopediaDescription";
            encyclopediaDescription.Size = new Size(436, 145);
            encyclopediaDescription.TabIndex = 4;
            encyclopediaDescription.TabStop = false;
            encyclopediaDescription.Text = "";
            encyclopediaDescription.TextChanged += encyclopediaDescription_TextChanged;
            // 
            // hiddenDataGroupBox
            // 
            hiddenDataGroupBox.Controls.Add(id);
            hiddenDataGroupBox.Controls.Add(idHexLabel);
            hiddenDataGroupBox.Controls.Add(idLabel);
            hiddenDataGroupBox.Controls.Add(field2_1);
            hiddenDataGroupBox.Controls.Add(productionFamily_0);
            hiddenDataGroupBox.Controls.Add(productionFamily_0Label);
            hiddenDataGroupBox.Controls.Add(nextProductionFamily_0Label);
            hiddenDataGroupBox.Controls.Add(nextProductionFamily_0);
            hiddenDataGroupBox.Controls.Add(field2_1Label);
            hiddenDataGroupBox.Controls.Add(familyIdLabel);
            hiddenDataGroupBox.Controls.Add(familyId);
            hiddenDataGroupBox.Controls.Add(familyIdStringLabel);
            hiddenDataGroupBox.Controls.Add(textStraDllIdLabel);
            hiddenDataGroupBox.Controls.Add(Field7_2Label);
            hiddenDataGroupBox.Controls.Add(positionLabel);
            hiddenDataGroupBox.Controls.Add(xPosition);
            hiddenDataGroupBox.Controls.Add(field13_0Label);
            hiddenDataGroupBox.Controls.Add(yPosition);
            hiddenDataGroupBox.Controls.Add(sectorId);
            hiddenDataGroupBox.Controls.Add(field10_1);
            hiddenDataGroupBox.Controls.Add(sectorIdLabel);
            hiddenDataGroupBox.Controls.Add(textStraDllId);
            hiddenDataGroupBox.Controls.Add(pictureIdLabel);
            hiddenDataGroupBox.Controls.Add(pictureId);
            hiddenDataGroupBox.Controls.Add(field7_2);
            hiddenDataGroupBox.Controls.Add(field13_0);
            hiddenDataGroupBox.Controls.Add(field10_1Label);
            hiddenDataGroupBox.Location = new Point(648, 3);
            hiddenDataGroupBox.Name = "hiddenDataGroupBox";
            hiddenDataGroupBox.Size = new Size(297, 339);
            hiddenDataGroupBox.TabIndex = 0;
            hiddenDataGroupBox.TabStop = false;
            hiddenDataGroupBox.Text = "Hidden Data";
            // 
            // infoLabel
            // 
            infoLabel.ForeColor = Color.Blue;
            infoLabel.Location = new Point(687, 376);
            infoLabel.Margin = new Padding(4, 0, 4, 0);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(252, 67);
            infoLabel.TabIndex = 1155;
            infoLabel.Text = "Unexplored Systems (planets): alliance starts at 100% support, empire at 50%-50%. Side Param Table Entries 30 to 31 defines the % of affiliated Systems (planets).";
            // 
            // SystemsForm
            // 
            AcceptButton = Ok;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.None;
            CancelButton = Cancel;
            ClientSize = new Size(949, 481);
            Controls.Add(infoLabel);
            Controls.Add(hiddenDataGroupBox);
            Controls.Add(inGameDataGroupBox);
            Controls.Add(sectorGroupBox);
            Controls.Add(familyIdInfoLabel);
            Controls.Add(systemsListView);
            Controls.Add(Open);
            Controls.Add(SaveAs);
            Controls.Add(Cancel);
            Controls.Add(Ok);
            Controls.Add(selector);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(965, 520);
            MinimumSize = new Size(965, 520);
            Name = "SystemsForm";
            Text = "Systems (SYSTEMSD.DAT)";
            FormClosing += GameObjectsListForm_FormClosing;
            Load += GameObjectsListForm_Load;
            KeyDown += GameObjectsListForm_KeyDown;
            ((ISupportInitialize)selector).EndInit();
            sectorGroupBox.ResumeLayout(false);
            sectorGroupBox.PerformLayout();
            ((ISupportInitialize)sectorFamilyId).EndInit();
            ((ISupportInitialize)sectorYPosition).EndInit();
            ((ISupportInitialize)sectorXPosition).EndInit();
            ((ISupportInitialize)sectorTextStraDllId).EndInit();
            ((ISupportInitialize)sectorGroup).EndInit();
            ((ISupportInitialize)sectorGalaxySize).EndInit();
            ((ISupportInitialize)field10_1).EndInit();
            ((ISupportInitialize)sectorId).EndInit();
            ((ISupportInitialize)productionFamily_0).EndInit();
            ((ISupportInitialize)nextProductionFamily_0).EndInit();
            ((ISupportInitialize)id).EndInit();
            ((ISupportInitialize)familyId).EndInit();
            ((ISupportInitialize)textStraDllId).EndInit();
            ((ISupportInitialize)field7_2).EndInit();
            ((ISupportInitialize)pictureId).EndInit();
            ((ISupportInitialize)yPosition).EndInit();
            ((ISupportInitialize)field13_0).EndInit();
            ((ISupportInitialize)xPosition).EndInit();
            ((ISupportInitialize)picture).EndInit();
            ((ISupportInitialize)field2_1).EndInit();
            inGameDataGroupBox.ResumeLayout(false);
            inGameDataGroupBox.PerformLayout();
            ((ISupportInitialize)sprite).EndInit();
            hiddenDataGroupBox.ResumeLayout(false);
            hiddenDataGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private PictureBox sprite;
        private Label infoLabel;
    }
}