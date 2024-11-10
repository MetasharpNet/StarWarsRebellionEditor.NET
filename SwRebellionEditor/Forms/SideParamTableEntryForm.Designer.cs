using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class SideParamTableEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;
        private Button Open;
        private Button SaveAs;
        private Button Cancel;
        private Button Ok;
        private Label field2_1Label;
        private Label idLabel;
        private Label parameterIdLabel;
        private Label nameLabel;
        private Label idHexLabel;
        private NumericUpDown id;
        private NumericUpDown field2_1;
        private NumericUpDown parameterId;
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(SideParamTableEntryForm));
            Open = new Button();
            SaveAs = new Button();
            Cancel = new Button();
            Ok = new Button();
            selector = new TrackBar();
            parameterId = new NumericUpDown();
            id = new NumericUpDown();
            field2_1Label = new Label();
            field2_1 = new NumericUpDown();
            idLabel = new Label();
            parameterIdLabel = new Label();
            name = new TextBox();
            nameLabel = new Label();
            idHexLabel = new Label();
            playingAsAllianceGroupBox = new GroupBox();
            allianceEmpireGroupBox = new GroupBox();
            allianceSinglePlayerHardEmpire = new NumericUpDown();
            allianceSinglePlayerMediumEmpire = new NumericUpDown();
            allianceSinglePlayerEasyEmpire = new NumericUpDown();
            allianceSinglePlayerHardLabel = new Label();
            allianceSinglePlayerMediumLabel = new Label();
            allianceSinglePlayerEasyLabel = new Label();
            allianceAllianceGroupBox = new GroupBox();
            allianceSinglePlayerHardAlliance = new NumericUpDown();
            allianceSinglePlayerMediumAlliance = new NumericUpDown();
            allianceSinglePlayerEasyAlliance = new NumericUpDown();
            developmentEmpire = new NumericUpDown();
            developmentAlliance = new NumericUpDown();
            developmentLabel = new Label();
            playingAsEmpireGroupBox = new GroupBox();
            empireEmpireGroupBox = new GroupBox();
            empireSinglePlayerHardEmpire = new NumericUpDown();
            empireSinglePlayerMediumEmpire = new NumericUpDown();
            empireSinglePlayerEasyEmpire = new NumericUpDown();
            empireSinglePlayerHardLabel = new Label();
            empireSinglePlayerMediumLabel = new Label();
            empireSinglePlayerEasyLabel = new Label();
            empireAllianceGroupBox = new GroupBox();
            empireSinglePlayerHardAlliance = new NumericUpDown();
            empireSinglePlayerMediumAlliance = new NumericUpDown();
            empireSinglePlayerEasyAlliance = new NumericUpDown();
            multiPlayerEmpire = new NumericUpDown();
            multiPlayerAlliance = new NumericUpDown();
            multiPlayerLabel = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            ((ISupportInitialize)selector).BeginInit();
            ((ISupportInitialize)parameterId).BeginInit();
            ((ISupportInitialize)id).BeginInit();
            ((ISupportInitialize)field2_1).BeginInit();
            playingAsAllianceGroupBox.SuspendLayout();
            allianceEmpireGroupBox.SuspendLayout();
            ((ISupportInitialize)allianceSinglePlayerHardEmpire).BeginInit();
            ((ISupportInitialize)allianceSinglePlayerMediumEmpire).BeginInit();
            ((ISupportInitialize)allianceSinglePlayerEasyEmpire).BeginInit();
            allianceAllianceGroupBox.SuspendLayout();
            ((ISupportInitialize)allianceSinglePlayerHardAlliance).BeginInit();
            ((ISupportInitialize)allianceSinglePlayerMediumAlliance).BeginInit();
            ((ISupportInitialize)allianceSinglePlayerEasyAlliance).BeginInit();
            ((ISupportInitialize)developmentEmpire).BeginInit();
            ((ISupportInitialize)developmentAlliance).BeginInit();
            playingAsEmpireGroupBox.SuspendLayout();
            empireEmpireGroupBox.SuspendLayout();
            ((ISupportInitialize)empireSinglePlayerHardEmpire).BeginInit();
            ((ISupportInitialize)empireSinglePlayerMediumEmpire).BeginInit();
            ((ISupportInitialize)empireSinglePlayerEasyEmpire).BeginInit();
            empireAllianceGroupBox.SuspendLayout();
            ((ISupportInitialize)empireSinglePlayerHardAlliance).BeginInit();
            ((ISupportInitialize)empireSinglePlayerMediumAlliance).BeginInit();
            ((ISupportInitialize)empireSinglePlayerEasyAlliance).BeginInit();
            ((ISupportInitialize)multiPlayerEmpire).BeginInit();
            ((ISupportInitialize)multiPlayerAlliance).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // Open
            // 
            Open.Location = new Point(305, 414);
            Open.Margin = new Padding(4, 3, 4, 3);
            Open.Name = "Open";
            Open.Size = new Size(88, 34);
            Open.TabIndex = 146;
            Open.TabStop = false;
            Open.Text = "Open...";
            Open.UseVisualStyleBackColor = true;
            Open.Click += Open_Click;
            // 
            // SaveAs
            // 
            SaveAs.Location = new Point(209, 414);
            SaveAs.Margin = new Padding(4, 3, 4, 3);
            SaveAs.Name = "SaveAs";
            SaveAs.Size = new Size(88, 34);
            SaveAs.TabIndex = 147;
            SaveAs.TabStop = false;
            SaveAs.Text = "&SaveAs...";
            SaveAs.UseVisualStyleBackColor = true;
            SaveAs.Click += SaveAs_Click;
            // 
            // Cancel
            // 
            Cancel.DialogResult = DialogResult.Cancel;
            Cancel.Location = new Point(113, 414);
            Cancel.Margin = new Padding(4, 3, 4, 3);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(88, 34);
            Cancel.TabIndex = 154;
            Cancel.Text = "&Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Ok
            // 
            Ok.Location = new Point(17, 414);
            Ok.Margin = new Padding(4, 3, 4, 3);
            Ok.Name = "Ok";
            Ok.Size = new Size(88, 34);
            Ok.TabIndex = 153;
            Ok.Text = "&Ok";
            Ok.UseVisualStyleBackColor = true;
            Ok.Click += Ok_Click;
            // 
            // selector
            // 
            selector.LargeChange = 1;
            selector.Location = new Point(13, 12);
            selector.Margin = new Padding(4, 3, 4, 3);
            selector.Maximum = 19;
            selector.Name = "selector";
            selector.Size = new Size(752, 45);
            selector.TabIndex = 149;
            selector.ValueChanged += GameObjectsSelector_ValueChanged;
            // 
            // parameterId
            // 
            parameterId.Location = new Point(165, 135);
            parameterId.Margin = new Padding(4, 3, 4, 3);
            parameterId.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            parameterId.Name = "parameterId";
            parameterId.Size = new Size(92, 23);
            parameterId.TabIndex = 7;
            parameterId.TextAlign = HorizontalAlignment.Right;
            parameterId.Value = new decimal(new int[] { -1, 0, 0, 0 });
            parameterId.ValueChanged += parameterId_ValueChanged;
            // 
            // id
            // 
            id.ForeColor = Color.Red;
            id.Location = new Point(165, 77);
            id.Margin = new Padding(4, 3, 4, 3);
            id.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            id.Name = "id";
            id.Size = new Size(93, 23);
            id.TabIndex = 10;
            id.TextAlign = HorizontalAlignment.Right;
            id.Value = new decimal(new int[] { -1, 0, 0, 0 });
            id.ValueChanged += id_ValueChanged;
            // 
            // field2_1Label
            // 
            field2_1Label.AutoSize = true;
            field2_1Label.ForeColor = Color.Red;
            field2_1Label.Location = new Point(17, 108);
            field2_1Label.Margin = new Padding(4, 0, 4, 0);
            field2_1Label.Name = "field2_1Label";
            field2_1Label.Size = new Size(93, 15);
            field2_1Label.TabIndex = 0;
            field2_1Label.Text = "Field2 (always 1)";
            // 
            // field2_1
            // 
            field2_1.ForeColor = Color.Red;
            field2_1.Location = new Point(165, 106);
            field2_1.Margin = new Padding(4, 3, 4, 3);
            field2_1.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            field2_1.Name = "field2_1";
            field2_1.Size = new Size(93, 23);
            field2_1.TabIndex = 8;
            field2_1.TextAlign = HorizontalAlignment.Right;
            field2_1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            field2_1.ValueChanged += field2_1_ValueChanged;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.ForeColor = Color.Red;
            idLabel.Location = new Point(17, 79);
            idLabel.Margin = new Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id";
            // 
            // parameterIdLabel
            // 
            parameterIdLabel.AutoSize = true;
            parameterIdLabel.ForeColor = Color.Black;
            parameterIdLabel.Location = new Point(17, 137);
            parameterIdLabel.Margin = new Padding(4, 0, 4, 0);
            parameterIdLabel.Name = "parameterIdLabel";
            parameterIdLabel.Size = new Size(74, 15);
            parameterIdLabel.TabIndex = 166;
            parameterIdLabel.Text = "Parameter Id";
            // 
            // name
            // 
            name.Enabled = false;
            name.Location = new Point(57, 49);
            name.Name = "name";
            name.Size = new Size(699, 23);
            name.TabIndex = 169;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(17, 52);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 168;
            nameLabel.Text = "Name";
            // 
            // idHexLabel
            // 
            idHexLabel.AutoSize = true;
            idHexLabel.ForeColor = Color.Red;
            idHexLabel.Location = new Point(267, 79);
            idHexLabel.Margin = new Padding(4, 0, 4, 0);
            idHexLabel.Name = "idHexLabel";
            idHexLabel.Size = new Size(31, 15);
            idHexLabel.TabIndex = 169;
            idHexLabel.Text = "0x00";
            // 
            // playingAsAllianceGroupBox
            // 
            playingAsAllianceGroupBox.Controls.Add(allianceEmpireGroupBox);
            playingAsAllianceGroupBox.Controls.Add(allianceSinglePlayerHardLabel);
            playingAsAllianceGroupBox.Controls.Add(allianceSinglePlayerMediumLabel);
            playingAsAllianceGroupBox.Controls.Add(allianceSinglePlayerEasyLabel);
            playingAsAllianceGroupBox.Controls.Add(allianceAllianceGroupBox);
            playingAsAllianceGroupBox.Location = new Point(17, 217);
            playingAsAllianceGroupBox.Name = "playingAsAllianceGroupBox";
            playingAsAllianceGroupBox.Size = new Size(370, 132);
            playingAsAllianceGroupBox.TabIndex = 170;
            playingAsAllianceGroupBox.TabStop = false;
            playingAsAllianceGroupBox.Text = "Playing as Alliance";
            // 
            // allianceEmpireGroupBox
            // 
            allianceEmpireGroupBox.Controls.Add(allianceSinglePlayerHardEmpire);
            allianceEmpireGroupBox.Controls.Add(allianceSinglePlayerMediumEmpire);
            allianceEmpireGroupBox.Controls.Add(allianceSinglePlayerEasyEmpire);
            allianceEmpireGroupBox.Location = new Point(254, 13);
            allianceEmpireGroupBox.Name = "allianceEmpireGroupBox";
            allianceEmpireGroupBox.Size = new Size(107, 113);
            allianceEmpireGroupBox.TabIndex = 175;
            allianceEmpireGroupBox.TabStop = false;
            allianceEmpireGroupBox.Text = "Empire Side";
            // 
            // allianceSinglePlayerHardEmpire
            // 
            allianceSinglePlayerHardEmpire.ForeColor = Color.Black;
            allianceSinglePlayerHardEmpire.Location = new Point(8, 82);
            allianceSinglePlayerHardEmpire.Margin = new Padding(4, 3, 4, 3);
            allianceSinglePlayerHardEmpire.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceSinglePlayerHardEmpire.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            allianceSinglePlayerHardEmpire.Name = "allianceSinglePlayerHardEmpire";
            allianceSinglePlayerHardEmpire.Size = new Size(92, 23);
            allianceSinglePlayerHardEmpire.TabIndex = 174;
            allianceSinglePlayerHardEmpire.TextAlign = HorizontalAlignment.Right;
            allianceSinglePlayerHardEmpire.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceSinglePlayerHardEmpire.ValueChanged += allianceSinglePlayerHardEmpire_ValueChanged;
            // 
            // allianceSinglePlayerMediumEmpire
            // 
            allianceSinglePlayerMediumEmpire.ForeColor = Color.Black;
            allianceSinglePlayerMediumEmpire.Location = new Point(7, 53);
            allianceSinglePlayerMediumEmpire.Margin = new Padding(4, 3, 4, 3);
            allianceSinglePlayerMediumEmpire.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceSinglePlayerMediumEmpire.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            allianceSinglePlayerMediumEmpire.Name = "allianceSinglePlayerMediumEmpire";
            allianceSinglePlayerMediumEmpire.Size = new Size(92, 23);
            allianceSinglePlayerMediumEmpire.TabIndex = 173;
            allianceSinglePlayerMediumEmpire.TextAlign = HorizontalAlignment.Right;
            allianceSinglePlayerMediumEmpire.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceSinglePlayerMediumEmpire.ValueChanged += allianceSinglePlayerMediumEmpire_ValueChanged;
            // 
            // allianceSinglePlayerEasyEmpire
            // 
            allianceSinglePlayerEasyEmpire.ForeColor = Color.Black;
            allianceSinglePlayerEasyEmpire.Location = new Point(7, 24);
            allianceSinglePlayerEasyEmpire.Margin = new Padding(4, 3, 4, 3);
            allianceSinglePlayerEasyEmpire.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceSinglePlayerEasyEmpire.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            allianceSinglePlayerEasyEmpire.Name = "allianceSinglePlayerEasyEmpire";
            allianceSinglePlayerEasyEmpire.Size = new Size(92, 23);
            allianceSinglePlayerEasyEmpire.TabIndex = 172;
            allianceSinglePlayerEasyEmpire.TextAlign = HorizontalAlignment.Right;
            allianceSinglePlayerEasyEmpire.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceSinglePlayerEasyEmpire.ValueChanged += allianceSinglePlayerEasyEmpire_ValueChanged;
            // 
            // allianceSinglePlayerHardLabel
            // 
            allianceSinglePlayerHardLabel.AutoSize = true;
            allianceSinglePlayerHardLabel.ForeColor = Color.Black;
            allianceSinglePlayerHardLabel.Location = new Point(10, 97);
            allianceSinglePlayerHardLabel.Margin = new Padding(4, 0, 4, 0);
            allianceSinglePlayerHardLabel.Name = "allianceSinglePlayerHardLabel";
            allianceSinglePlayerHardLabel.Size = new Size(103, 15);
            allianceSinglePlayerHardLabel.TabIndex = 177;
            allianceSinglePlayerHardLabel.Text = "Single Player Hard";
            // 
            // allianceSinglePlayerMediumLabel
            // 
            allianceSinglePlayerMediumLabel.AutoSize = true;
            allianceSinglePlayerMediumLabel.ForeColor = Color.Black;
            allianceSinglePlayerMediumLabel.Location = new Point(10, 68);
            allianceSinglePlayerMediumLabel.Margin = new Padding(4, 0, 4, 0);
            allianceSinglePlayerMediumLabel.Name = "allianceSinglePlayerMediumLabel";
            allianceSinglePlayerMediumLabel.Size = new Size(122, 15);
            allianceSinglePlayerMediumLabel.TabIndex = 176;
            allianceSinglePlayerMediumLabel.Text = "Single Player Medium";
            // 
            // allianceSinglePlayerEasyLabel
            // 
            allianceSinglePlayerEasyLabel.AutoSize = true;
            allianceSinglePlayerEasyLabel.ForeColor = Color.Black;
            allianceSinglePlayerEasyLabel.Location = new Point(10, 39);
            allianceSinglePlayerEasyLabel.Margin = new Padding(4, 0, 4, 0);
            allianceSinglePlayerEasyLabel.Name = "allianceSinglePlayerEasyLabel";
            allianceSinglePlayerEasyLabel.Size = new Size(100, 15);
            allianceSinglePlayerEasyLabel.TabIndex = 175;
            allianceSinglePlayerEasyLabel.Text = "Single Player Easy";
            // 
            // allianceAllianceGroupBox
            // 
            allianceAllianceGroupBox.Controls.Add(allianceSinglePlayerHardAlliance);
            allianceAllianceGroupBox.Controls.Add(allianceSinglePlayerMediumAlliance);
            allianceAllianceGroupBox.Controls.Add(allianceSinglePlayerEasyAlliance);
            allianceAllianceGroupBox.Location = new Point(141, 13);
            allianceAllianceGroupBox.Name = "allianceAllianceGroupBox";
            allianceAllianceGroupBox.Size = new Size(107, 113);
            allianceAllianceGroupBox.TabIndex = 173;
            allianceAllianceGroupBox.TabStop = false;
            allianceAllianceGroupBox.Text = "Alliance Side";
            // 
            // allianceSinglePlayerHardAlliance
            // 
            allianceSinglePlayerHardAlliance.ForeColor = Color.Black;
            allianceSinglePlayerHardAlliance.Location = new Point(7, 82);
            allianceSinglePlayerHardAlliance.Margin = new Padding(4, 3, 4, 3);
            allianceSinglePlayerHardAlliance.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceSinglePlayerHardAlliance.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            allianceSinglePlayerHardAlliance.Name = "allianceSinglePlayerHardAlliance";
            allianceSinglePlayerHardAlliance.Size = new Size(92, 23);
            allianceSinglePlayerHardAlliance.TabIndex = 174;
            allianceSinglePlayerHardAlliance.TextAlign = HorizontalAlignment.Right;
            allianceSinglePlayerHardAlliance.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceSinglePlayerHardAlliance.ValueChanged += allianceSinglePlayerHardAlliance_ValueChanged;
            // 
            // allianceSinglePlayerMediumAlliance
            // 
            allianceSinglePlayerMediumAlliance.ForeColor = Color.Black;
            allianceSinglePlayerMediumAlliance.Location = new Point(7, 53);
            allianceSinglePlayerMediumAlliance.Margin = new Padding(4, 3, 4, 3);
            allianceSinglePlayerMediumAlliance.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceSinglePlayerMediumAlliance.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            allianceSinglePlayerMediumAlliance.Name = "allianceSinglePlayerMediumAlliance";
            allianceSinglePlayerMediumAlliance.Size = new Size(92, 23);
            allianceSinglePlayerMediumAlliance.TabIndex = 173;
            allianceSinglePlayerMediumAlliance.TextAlign = HorizontalAlignment.Right;
            allianceSinglePlayerMediumAlliance.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceSinglePlayerMediumAlliance.ValueChanged += allianceSinglePlayerMediumAlliance_ValueChanged;
            // 
            // allianceSinglePlayerEasyAlliance
            // 
            allianceSinglePlayerEasyAlliance.ForeColor = Color.Black;
            allianceSinglePlayerEasyAlliance.Location = new Point(7, 24);
            allianceSinglePlayerEasyAlliance.Margin = new Padding(4, 3, 4, 3);
            allianceSinglePlayerEasyAlliance.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceSinglePlayerEasyAlliance.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            allianceSinglePlayerEasyAlliance.Name = "allianceSinglePlayerEasyAlliance";
            allianceSinglePlayerEasyAlliance.Size = new Size(92, 23);
            allianceSinglePlayerEasyAlliance.TabIndex = 172;
            allianceSinglePlayerEasyAlliance.TextAlign = HorizontalAlignment.Right;
            allianceSinglePlayerEasyAlliance.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceSinglePlayerEasyAlliance.ValueChanged += allianceSinglePlayerEasyAlliance_ValueChanged;
            // 
            // developmentEmpire
            // 
            developmentEmpire.ForeColor = Color.Red;
            developmentEmpire.Location = new Point(7, 22);
            developmentEmpire.Margin = new Padding(4, 3, 4, 3);
            developmentEmpire.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            developmentEmpire.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            developmentEmpire.Name = "developmentEmpire";
            developmentEmpire.Size = new Size(92, 23);
            developmentEmpire.TabIndex = 172;
            developmentEmpire.TextAlign = HorizontalAlignment.Right;
            developmentEmpire.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            developmentEmpire.ValueChanged += developmentEmpire_ValueChanged;
            // 
            // developmentAlliance
            // 
            developmentAlliance.ForeColor = Color.Red;
            developmentAlliance.Location = new Point(8, 22);
            developmentAlliance.Margin = new Padding(4, 3, 4, 3);
            developmentAlliance.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            developmentAlliance.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            developmentAlliance.Name = "developmentAlliance";
            developmentAlliance.Size = new Size(92, 23);
            developmentAlliance.TabIndex = 172;
            developmentAlliance.TextAlign = HorizontalAlignment.Right;
            developmentAlliance.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            developmentAlliance.ValueChanged += developmentAlliance_ValueChanged;
            // 
            // developmentLabel
            // 
            developmentLabel.AutoSize = true;
            developmentLabel.ForeColor = Color.Red;
            developmentLabel.Location = new Point(17, 188);
            developmentLabel.Margin = new Padding(4, 0, 4, 0);
            developmentLabel.Name = "developmentLabel";
            developmentLabel.Size = new Size(128, 15);
            developmentLabel.TabIndex = 172;
            developmentLabel.Text = "Development (unused)";
            // 
            // playingAsEmpireGroupBox
            // 
            playingAsEmpireGroupBox.Controls.Add(empireEmpireGroupBox);
            playingAsEmpireGroupBox.Controls.Add(empireSinglePlayerHardLabel);
            playingAsEmpireGroupBox.Controls.Add(empireSinglePlayerMediumLabel);
            playingAsEmpireGroupBox.Controls.Add(empireSinglePlayerEasyLabel);
            playingAsEmpireGroupBox.Controls.Add(empireAllianceGroupBox);
            playingAsEmpireGroupBox.Location = new Point(395, 217);
            playingAsEmpireGroupBox.Name = "playingAsEmpireGroupBox";
            playingAsEmpireGroupBox.Size = new Size(370, 132);
            playingAsEmpireGroupBox.TabIndex = 178;
            playingAsEmpireGroupBox.TabStop = false;
            playingAsEmpireGroupBox.Text = "Playing as Empire";
            // 
            // empireEmpireGroupBox
            // 
            empireEmpireGroupBox.Controls.Add(empireSinglePlayerHardEmpire);
            empireEmpireGroupBox.Controls.Add(empireSinglePlayerMediumEmpire);
            empireEmpireGroupBox.Controls.Add(empireSinglePlayerEasyEmpire);
            empireEmpireGroupBox.Location = new Point(254, 13);
            empireEmpireGroupBox.Name = "empireEmpireGroupBox";
            empireEmpireGroupBox.Size = new Size(107, 113);
            empireEmpireGroupBox.TabIndex = 175;
            empireEmpireGroupBox.TabStop = false;
            empireEmpireGroupBox.Text = "Empire Side";
            // 
            // empireSinglePlayerHardEmpire
            // 
            empireSinglePlayerHardEmpire.ForeColor = Color.Black;
            empireSinglePlayerHardEmpire.Location = new Point(7, 82);
            empireSinglePlayerHardEmpire.Margin = new Padding(4, 3, 4, 3);
            empireSinglePlayerHardEmpire.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireSinglePlayerHardEmpire.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            empireSinglePlayerHardEmpire.Name = "empireSinglePlayerHardEmpire";
            empireSinglePlayerHardEmpire.Size = new Size(92, 23);
            empireSinglePlayerHardEmpire.TabIndex = 173;
            empireSinglePlayerHardEmpire.TextAlign = HorizontalAlignment.Right;
            empireSinglePlayerHardEmpire.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireSinglePlayerHardEmpire.ValueChanged += empireSinglePlayerHardEmpire_ValueChanged;
            // 
            // empireSinglePlayerMediumEmpire
            // 
            empireSinglePlayerMediumEmpire.ForeColor = Color.Black;
            empireSinglePlayerMediumEmpire.Location = new Point(7, 53);
            empireSinglePlayerMediumEmpire.Margin = new Padding(4, 3, 4, 3);
            empireSinglePlayerMediumEmpire.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireSinglePlayerMediumEmpire.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            empireSinglePlayerMediumEmpire.Name = "empireSinglePlayerMediumEmpire";
            empireSinglePlayerMediumEmpire.Size = new Size(92, 23);
            empireSinglePlayerMediumEmpire.TabIndex = 172;
            empireSinglePlayerMediumEmpire.TextAlign = HorizontalAlignment.Right;
            empireSinglePlayerMediumEmpire.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireSinglePlayerMediumEmpire.ValueChanged += empireSinglePlayerMediumEmpire_ValueChanged;
            // 
            // empireSinglePlayerEasyEmpire
            // 
            empireSinglePlayerEasyEmpire.ForeColor = Color.Black;
            empireSinglePlayerEasyEmpire.Location = new Point(7, 24);
            empireSinglePlayerEasyEmpire.Margin = new Padding(4, 3, 4, 3);
            empireSinglePlayerEasyEmpire.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireSinglePlayerEasyEmpire.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            empireSinglePlayerEasyEmpire.Name = "empireSinglePlayerEasyEmpire";
            empireSinglePlayerEasyEmpire.Size = new Size(92, 23);
            empireSinglePlayerEasyEmpire.TabIndex = 172;
            empireSinglePlayerEasyEmpire.TextAlign = HorizontalAlignment.Right;
            empireSinglePlayerEasyEmpire.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireSinglePlayerEasyEmpire.ValueChanged += empireSinglePlayerEasyEmpire_ValueChanged;
            // 
            // empireSinglePlayerHardLabel
            // 
            empireSinglePlayerHardLabel.AutoSize = true;
            empireSinglePlayerHardLabel.ForeColor = Color.Black;
            empireSinglePlayerHardLabel.Location = new Point(10, 97);
            empireSinglePlayerHardLabel.Margin = new Padding(4, 0, 4, 0);
            empireSinglePlayerHardLabel.Name = "empireSinglePlayerHardLabel";
            empireSinglePlayerHardLabel.Size = new Size(103, 15);
            empireSinglePlayerHardLabel.TabIndex = 177;
            empireSinglePlayerHardLabel.Text = "Single Player Hard";
            // 
            // empireSinglePlayerMediumLabel
            // 
            empireSinglePlayerMediumLabel.AutoSize = true;
            empireSinglePlayerMediumLabel.ForeColor = Color.Black;
            empireSinglePlayerMediumLabel.Location = new Point(10, 68);
            empireSinglePlayerMediumLabel.Margin = new Padding(4, 0, 4, 0);
            empireSinglePlayerMediumLabel.Name = "empireSinglePlayerMediumLabel";
            empireSinglePlayerMediumLabel.Size = new Size(122, 15);
            empireSinglePlayerMediumLabel.TabIndex = 176;
            empireSinglePlayerMediumLabel.Text = "Single Player Medium";
            // 
            // empireSinglePlayerEasyLabel
            // 
            empireSinglePlayerEasyLabel.AutoSize = true;
            empireSinglePlayerEasyLabel.ForeColor = Color.Black;
            empireSinglePlayerEasyLabel.Location = new Point(10, 39);
            empireSinglePlayerEasyLabel.Margin = new Padding(4, 0, 4, 0);
            empireSinglePlayerEasyLabel.Name = "empireSinglePlayerEasyLabel";
            empireSinglePlayerEasyLabel.Size = new Size(100, 15);
            empireSinglePlayerEasyLabel.TabIndex = 175;
            empireSinglePlayerEasyLabel.Text = "Single Player Easy";
            // 
            // empireAllianceGroupBox
            // 
            empireAllianceGroupBox.Controls.Add(empireSinglePlayerHardAlliance);
            empireAllianceGroupBox.Controls.Add(empireSinglePlayerMediumAlliance);
            empireAllianceGroupBox.Controls.Add(empireSinglePlayerEasyAlliance);
            empireAllianceGroupBox.Location = new Point(141, 13);
            empireAllianceGroupBox.Name = "empireAllianceGroupBox";
            empireAllianceGroupBox.Size = new Size(107, 113);
            empireAllianceGroupBox.TabIndex = 173;
            empireAllianceGroupBox.TabStop = false;
            empireAllianceGroupBox.Text = "Alliance Side";
            // 
            // empireSinglePlayerHardAlliance
            // 
            empireSinglePlayerHardAlliance.ForeColor = Color.Black;
            empireSinglePlayerHardAlliance.Location = new Point(7, 82);
            empireSinglePlayerHardAlliance.Margin = new Padding(4, 3, 4, 3);
            empireSinglePlayerHardAlliance.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireSinglePlayerHardAlliance.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            empireSinglePlayerHardAlliance.Name = "empireSinglePlayerHardAlliance";
            empireSinglePlayerHardAlliance.Size = new Size(92, 23);
            empireSinglePlayerHardAlliance.TabIndex = 173;
            empireSinglePlayerHardAlliance.TextAlign = HorizontalAlignment.Right;
            empireSinglePlayerHardAlliance.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireSinglePlayerHardAlliance.ValueChanged += empireSinglePlayerHardAlliance_ValueChanged;
            // 
            // empireSinglePlayerMediumAlliance
            // 
            empireSinglePlayerMediumAlliance.ForeColor = Color.Black;
            empireSinglePlayerMediumAlliance.Location = new Point(7, 53);
            empireSinglePlayerMediumAlliance.Margin = new Padding(4, 3, 4, 3);
            empireSinglePlayerMediumAlliance.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireSinglePlayerMediumAlliance.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            empireSinglePlayerMediumAlliance.Name = "empireSinglePlayerMediumAlliance";
            empireSinglePlayerMediumAlliance.Size = new Size(92, 23);
            empireSinglePlayerMediumAlliance.TabIndex = 172;
            empireSinglePlayerMediumAlliance.TextAlign = HorizontalAlignment.Right;
            empireSinglePlayerMediumAlliance.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireSinglePlayerMediumAlliance.ValueChanged += empireSinglePlayerMediumAlliance_ValueChanged;
            // 
            // empireSinglePlayerEasyAlliance
            // 
            empireSinglePlayerEasyAlliance.ForeColor = Color.Black;
            empireSinglePlayerEasyAlliance.Location = new Point(7, 24);
            empireSinglePlayerEasyAlliance.Margin = new Padding(4, 3, 4, 3);
            empireSinglePlayerEasyAlliance.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireSinglePlayerEasyAlliance.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            empireSinglePlayerEasyAlliance.Name = "empireSinglePlayerEasyAlliance";
            empireSinglePlayerEasyAlliance.Size = new Size(92, 23);
            empireSinglePlayerEasyAlliance.TabIndex = 172;
            empireSinglePlayerEasyAlliance.TextAlign = HorizontalAlignment.Right;
            empireSinglePlayerEasyAlliance.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireSinglePlayerEasyAlliance.ValueChanged += empireSinglePlayerEasyAlliance_ValueChanged;
            // 
            // multiPlayerEmpire
            // 
            multiPlayerEmpire.ForeColor = Color.Black;
            multiPlayerEmpire.Location = new Point(7, 22);
            multiPlayerEmpire.Margin = new Padding(4, 3, 4, 3);
            multiPlayerEmpire.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            multiPlayerEmpire.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            multiPlayerEmpire.Name = "multiPlayerEmpire";
            multiPlayerEmpire.Size = new Size(92, 23);
            multiPlayerEmpire.TabIndex = 174;
            multiPlayerEmpire.TextAlign = HorizontalAlignment.Right;
            multiPlayerEmpire.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            multiPlayerEmpire.ValueChanged += multiPlayerEmpire_ValueChanged;
            // 
            // multiPlayerAlliance
            // 
            multiPlayerAlliance.ForeColor = Color.Black;
            multiPlayerAlliance.Location = new Point(7, 22);
            multiPlayerAlliance.Margin = new Padding(4, 3, 4, 3);
            multiPlayerAlliance.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            multiPlayerAlliance.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            multiPlayerAlliance.Name = "multiPlayerAlliance";
            multiPlayerAlliance.Size = new Size(92, 23);
            multiPlayerAlliance.TabIndex = 174;
            multiPlayerAlliance.TextAlign = HorizontalAlignment.Right;
            multiPlayerAlliance.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            multiPlayerAlliance.ValueChanged += multiPlayerAlliance_ValueChanged;
            // 
            // multiPlayerLabel
            // 
            multiPlayerLabel.AutoSize = true;
            multiPlayerLabel.ForeColor = Color.Black;
            multiPlayerLabel.Location = new Point(27, 379);
            multiPlayerLabel.Margin = new Padding(4, 0, 4, 0);
            multiPlayerLabel.Name = "multiPlayerLabel";
            multiPlayerLabel.Size = new Size(70, 15);
            multiPlayerLabel.TabIndex = 172;
            multiPlayerLabel.Text = "Multi Player";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(developmentAlliance);
            groupBox1.Location = new Point(158, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(107, 53);
            groupBox1.TabIndex = 175;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alliance Side";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(developmentEmpire);
            groupBox2.Location = new Point(271, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(107, 53);
            groupBox2.TabIndex = 176;
            groupBox2.TabStop = false;
            groupBox2.Text = "Empire Side";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(multiPlayerAlliance);
            groupBox3.Location = new Point(158, 355);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(107, 53);
            groupBox3.TabIndex = 176;
            groupBox3.TabStop = false;
            groupBox3.Text = "Alliance Side";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(multiPlayerEmpire);
            groupBox4.Location = new Point(271, 355);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(107, 53);
            groupBox4.TabIndex = 177;
            groupBox4.TabStop = false;
            groupBox4.Text = "Empire Side";
            // 
            // SideParamTableEntryForm
            // 
            AcceptButton = Ok;
            AutoScaleMode = AutoScaleMode.None;
            CancelButton = Cancel;
            ClientSize = new Size(772, 456);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(playingAsEmpireGroupBox);
            Controls.Add(idLabel);
            Controls.Add(parameterIdLabel);
            Controls.Add(multiPlayerLabel);
            Controls.Add(developmentLabel);
            Controls.Add(name);
            Controls.Add(nameLabel);
            Controls.Add(playingAsAllianceGroupBox);
            Controls.Add(idHexLabel);
            Controls.Add(Open);
            Controls.Add(parameterId);
            Controls.Add(SaveAs);
            Controls.Add(id);
            Controls.Add(Cancel);
            Controls.Add(Ok);
            Controls.Add(selector);
            Controls.Add(field2_1Label);
            Controls.Add(field2_1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(788, 495);
            MinimumSize = new Size(788, 495);
            Name = "SideParamTableEntryForm";
            Text = "Side Parameters Tables (SDPRTB.DAT)";
            FormClosing += GameObjectsListForm_FormClosing;
            Load += GameObjectsListForm_Load;
            KeyDown += GameObjectsListForm_KeyDown;
            ((ISupportInitialize)selector).EndInit();
            ((ISupportInitialize)parameterId).EndInit();
            ((ISupportInitialize)id).EndInit();
            ((ISupportInitialize)field2_1).EndInit();
            playingAsAllianceGroupBox.ResumeLayout(false);
            playingAsAllianceGroupBox.PerformLayout();
            allianceEmpireGroupBox.ResumeLayout(false);
            ((ISupportInitialize)allianceSinglePlayerHardEmpire).EndInit();
            ((ISupportInitialize)allianceSinglePlayerMediumEmpire).EndInit();
            ((ISupportInitialize)allianceSinglePlayerEasyEmpire).EndInit();
            allianceAllianceGroupBox.ResumeLayout(false);
            ((ISupportInitialize)allianceSinglePlayerHardAlliance).EndInit();
            ((ISupportInitialize)allianceSinglePlayerMediumAlliance).EndInit();
            ((ISupportInitialize)allianceSinglePlayerEasyAlliance).EndInit();
            ((ISupportInitialize)developmentEmpire).EndInit();
            ((ISupportInitialize)developmentAlliance).EndInit();
            playingAsEmpireGroupBox.ResumeLayout(false);
            playingAsEmpireGroupBox.PerformLayout();
            empireEmpireGroupBox.ResumeLayout(false);
            ((ISupportInitialize)empireSinglePlayerHardEmpire).EndInit();
            ((ISupportInitialize)empireSinglePlayerMediumEmpire).EndInit();
            ((ISupportInitialize)empireSinglePlayerEasyEmpire).EndInit();
            empireAllianceGroupBox.ResumeLayout(false);
            ((ISupportInitialize)empireSinglePlayerHardAlliance).EndInit();
            ((ISupportInitialize)empireSinglePlayerMediumAlliance).EndInit();
            ((ISupportInitialize)empireSinglePlayerEasyAlliance).EndInit();
            ((ISupportInitialize)multiPlayerEmpire).EndInit();
            ((ISupportInitialize)multiPlayerAlliance).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox playingAsAllianceGroupBox;
        private GroupBox allianceEmpireGroupBox;
        private NumericUpDown allianceSinglePlayerHardEmpire;
        private NumericUpDown allianceSinglePlayerMediumEmpire;
        private NumericUpDown allianceSinglePlayerEasyEmpire;
        private NumericUpDown developmentEmpire;
        private Label allianceSinglePlayerHardLabel;
        private Label allianceSinglePlayerMediumLabel;
        private Label allianceSinglePlayerEasyLabel;
        private GroupBox allianceAllianceGroupBox;
        private NumericUpDown allianceSinglePlayerHardAlliance;
        private NumericUpDown allianceSinglePlayerMediumAlliance;
        private NumericUpDown allianceSinglePlayerEasyAlliance;
        private NumericUpDown developmentAlliance;
        private Label developmentLabel;
        private GroupBox playingAsEmpireGroupBox;
        private GroupBox empireEmpireGroupBox;
        private NumericUpDown multiPlayerEmpire;
        private NumericUpDown empireSinglePlayerHardEmpire;
        private NumericUpDown empireSinglePlayerMediumEmpire;
        private NumericUpDown empireSinglePlayerEasyEmpire;
        private Label empireSinglePlayerHardLabel;
        private Label empireSinglePlayerMediumLabel;
        private Label empireSinglePlayerEasyLabel;
        private GroupBox empireAllianceGroupBox;
        private NumericUpDown multiPlayerAlliance;
        private NumericUpDown empireSinglePlayerHardAlliance;
        private NumericUpDown empireSinglePlayerMediumAlliance;
        private NumericUpDown empireSinglePlayerEasyAlliance;
        private Label multiPlayerLabel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}