using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class GeneralParamTableEntryForm
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
            allianceGroupBox = new GroupBox();
            allianceSinglePlayerHard = new NumericUpDown();
            allianceSinglePlayerMedium = new NumericUpDown();
            allianceSinglePlayerHardLabel = new Label();
            allianceSinglePlayerEasy = new NumericUpDown();
            allianceSinglePlayerMediumLabel = new Label();
            allianceMultiPlayer = new NumericUpDown();
            allianceSinglePlayerEasyLabel = new Label();
            allianceMultiplayerLabel = new Label();
            empireGroupBox = new GroupBox();
            empireMultiPlayer = new NumericUpDown();
            empireSinglePlayerHard = new NumericUpDown();
            empireSinglePlayerHardLabel = new Label();
            empireSinglePlayerMedium = new NumericUpDown();
            empireSinglePlayerMediumLabel = new Label();
            empireSinglePlayerEasy = new NumericUpDown();
            empireSinglePlayerEasyLabel = new Label();
            empireMultiPlayerLabel = new Label();
            ((ISupportInitialize)selector).BeginInit();
            ((ISupportInitialize)parameterId).BeginInit();
            ((ISupportInitialize)id).BeginInit();
            ((ISupportInitialize)field2_1).BeginInit();
            allianceGroupBox.SuspendLayout();
            ((ISupportInitialize)allianceSinglePlayerHard).BeginInit();
            ((ISupportInitialize)allianceSinglePlayerMedium).BeginInit();
            ((ISupportInitialize)allianceSinglePlayerEasy).BeginInit();
            ((ISupportInitialize)allianceMultiPlayer).BeginInit();
            empireGroupBox.SuspendLayout();
            ((ISupportInitialize)empireMultiPlayer).BeginInit();
            ((ISupportInitialize)empireSinglePlayerHard).BeginInit();
            ((ISupportInitialize)empireSinglePlayerMedium).BeginInit();
            ((ISupportInitialize)empireSinglePlayerEasy).BeginInit();
            SuspendLayout();
            // 
            // Open
            // 
            Open.Location = new Point(307, 310);
            Open.Margin = new Padding(4, 3, 4, 3);
            Open.Name = "Open";
            Open.Size = new Size(88, 27);
            Open.TabIndex = 146;
            Open.TabStop = false;
            Open.Text = "Open...";
            Open.UseVisualStyleBackColor = true;
            Open.Click += Open_Click;
            // 
            // SaveAs
            // 
            SaveAs.Location = new Point(211, 310);
            SaveAs.Margin = new Padding(4, 3, 4, 3);
            SaveAs.Name = "SaveAs";
            SaveAs.Size = new Size(88, 27);
            SaveAs.TabIndex = 147;
            SaveAs.TabStop = false;
            SaveAs.Text = "&SaveAs...";
            SaveAs.UseVisualStyleBackColor = true;
            SaveAs.Click += SaveAs_Click;
            // 
            // Cancel
            // 
            Cancel.DialogResult = DialogResult.Cancel;
            Cancel.Location = new Point(115, 310);
            Cancel.Margin = new Padding(4, 3, 4, 3);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(88, 27);
            Cancel.TabIndex = 154;
            Cancel.Text = "&Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Ok
            // 
            Ok.Location = new Point(19, 310);
            Ok.Margin = new Padding(4, 3, 4, 3);
            Ok.Name = "Ok";
            Ok.Size = new Size(88, 27);
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
            selector.Size = new Size(485, 45);
            selector.TabIndex = 149;
            selector.ValueChanged += GameObjectsSelector_ValueChanged;
            // 
            // parameterId
            // 
            parameterId.Location = new Point(128, 135);
            parameterId.Margin = new Padding(4, 3, 4, 3);
            parameterId.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            parameterId.Name = "parameterId";
            parameterId.Size = new Size(85, 23);
            parameterId.TabIndex = 7;
            parameterId.TextAlign = HorizontalAlignment.Right;
            parameterId.Value = new decimal(new int[] { -1, 0, 0, 0 });
            parameterId.ValueChanged += parameterId_ValueChanged;
            // 
            // id
            // 
            id.ForeColor = Color.Red;
            id.Location = new Point(128, 77);
            id.Margin = new Padding(4, 3, 4, 3);
            id.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            id.Name = "id";
            id.Size = new Size(85, 23);
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
            field2_1.Location = new Point(128, 106);
            field2_1.Margin = new Padding(4, 3, 4, 3);
            field2_1.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            field2_1.Name = "field2_1";
            field2_1.Size = new Size(85, 23);
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
            name.Location = new Point(63, 49);
            name.Name = "name";
            name.Size = new Size(435, 23);
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
            idHexLabel.Location = new Point(221, 79);
            idHexLabel.Margin = new Padding(4, 0, 4, 0);
            idHexLabel.Name = "idHexLabel";
            idHexLabel.Size = new Size(31, 15);
            idHexLabel.TabIndex = 169;
            idHexLabel.Text = "0x00";
            // 
            // allianceGroupBox
            // 
            allianceGroupBox.Controls.Add(allianceSinglePlayerHard);
            allianceGroupBox.Controls.Add(allianceSinglePlayerMedium);
            allianceGroupBox.Controls.Add(allianceSinglePlayerHardLabel);
            allianceGroupBox.Controls.Add(allianceSinglePlayerEasy);
            allianceGroupBox.Controls.Add(allianceSinglePlayerMediumLabel);
            allianceGroupBox.Controls.Add(allianceMultiPlayer);
            allianceGroupBox.Controls.Add(allianceSinglePlayerEasyLabel);
            allianceGroupBox.Controls.Add(allianceMultiplayerLabel);
            allianceGroupBox.Location = new Point(12, 160);
            allianceGroupBox.Name = "allianceGroupBox";
            allianceGroupBox.Size = new Size(240, 141);
            allianceGroupBox.TabIndex = 170;
            allianceGroupBox.TabStop = false;
            allianceGroupBox.Text = "Alliance";
            // 
            // allianceSinglePlayerHard
            // 
            allianceSinglePlayerHard.ForeColor = Color.Black;
            allianceSinglePlayerHard.Location = new Point(141, 108);
            allianceSinglePlayerHard.Margin = new Padding(4, 3, 4, 3);
            allianceSinglePlayerHard.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceSinglePlayerHard.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            allianceSinglePlayerHard.Name = "allianceSinglePlayerHard";
            allianceSinglePlayerHard.Size = new Size(92, 23);
            allianceSinglePlayerHard.TabIndex = 174;
            allianceSinglePlayerHard.TextAlign = HorizontalAlignment.Right;
            allianceSinglePlayerHard.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceSinglePlayerHard.ValueChanged += allianceSinglePlayerHard_ValueChanged;
            // 
            // allianceSinglePlayerMedium
            // 
            allianceSinglePlayerMedium.ForeColor = Color.Black;
            allianceSinglePlayerMedium.Location = new Point(141, 79);
            allianceSinglePlayerMedium.Margin = new Padding(4, 3, 4, 3);
            allianceSinglePlayerMedium.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceSinglePlayerMedium.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            allianceSinglePlayerMedium.Name = "allianceSinglePlayerMedium";
            allianceSinglePlayerMedium.Size = new Size(92, 23);
            allianceSinglePlayerMedium.TabIndex = 173;
            allianceSinglePlayerMedium.TextAlign = HorizontalAlignment.Right;
            allianceSinglePlayerMedium.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceSinglePlayerMedium.ValueChanged += allianceSinglePlayerMedium_ValueChanged;
            // 
            // allianceSinglePlayerHardLabel
            // 
            allianceSinglePlayerHardLabel.AutoSize = true;
            allianceSinglePlayerHardLabel.ForeColor = Color.Black;
            allianceSinglePlayerHardLabel.Location = new Point(9, 110);
            allianceSinglePlayerHardLabel.Margin = new Padding(4, 0, 4, 0);
            allianceSinglePlayerHardLabel.Name = "allianceSinglePlayerHardLabel";
            allianceSinglePlayerHardLabel.Size = new Size(103, 15);
            allianceSinglePlayerHardLabel.TabIndex = 177;
            allianceSinglePlayerHardLabel.Text = "Single Player Hard";
            // 
            // allianceSinglePlayerEasy
            // 
            allianceSinglePlayerEasy.ForeColor = Color.Black;
            allianceSinglePlayerEasy.Location = new Point(141, 50);
            allianceSinglePlayerEasy.Margin = new Padding(4, 3, 4, 3);
            allianceSinglePlayerEasy.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceSinglePlayerEasy.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            allianceSinglePlayerEasy.Name = "allianceSinglePlayerEasy";
            allianceSinglePlayerEasy.Size = new Size(92, 23);
            allianceSinglePlayerEasy.TabIndex = 172;
            allianceSinglePlayerEasy.TextAlign = HorizontalAlignment.Right;
            allianceSinglePlayerEasy.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceSinglePlayerEasy.ValueChanged += allianceSinglePlayerEasy_ValueChanged;
            // 
            // allianceSinglePlayerMediumLabel
            // 
            allianceSinglePlayerMediumLabel.AutoSize = true;
            allianceSinglePlayerMediumLabel.ForeColor = Color.Black;
            allianceSinglePlayerMediumLabel.Location = new Point(9, 81);
            allianceSinglePlayerMediumLabel.Margin = new Padding(4, 0, 4, 0);
            allianceSinglePlayerMediumLabel.Name = "allianceSinglePlayerMediumLabel";
            allianceSinglePlayerMediumLabel.Size = new Size(122, 15);
            allianceSinglePlayerMediumLabel.TabIndex = 176;
            allianceSinglePlayerMediumLabel.Text = "Single Player Medium";
            // 
            // allianceMultiPlayer
            // 
            allianceMultiPlayer.ForeColor = Color.Black;
            allianceMultiPlayer.Location = new Point(141, 21);
            allianceMultiPlayer.Margin = new Padding(4, 3, 4, 3);
            allianceMultiPlayer.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceMultiPlayer.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            allianceMultiPlayer.Name = "allianceMultiPlayer";
            allianceMultiPlayer.Size = new Size(92, 23);
            allianceMultiPlayer.TabIndex = 172;
            allianceMultiPlayer.TextAlign = HorizontalAlignment.Right;
            allianceMultiPlayer.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            allianceMultiPlayer.ValueChanged += allianceMultiPlayer_ValueChanged;
            // 
            // allianceSinglePlayerEasyLabel
            // 
            allianceSinglePlayerEasyLabel.AutoSize = true;
            allianceSinglePlayerEasyLabel.ForeColor = Color.Black;
            allianceSinglePlayerEasyLabel.Location = new Point(9, 52);
            allianceSinglePlayerEasyLabel.Margin = new Padding(4, 0, 4, 0);
            allianceSinglePlayerEasyLabel.Name = "allianceSinglePlayerEasyLabel";
            allianceSinglePlayerEasyLabel.Size = new Size(100, 15);
            allianceSinglePlayerEasyLabel.TabIndex = 175;
            allianceSinglePlayerEasyLabel.Text = "Single Player Easy";
            // 
            // allianceMultiplayerLabel
            // 
            allianceMultiplayerLabel.AutoSize = true;
            allianceMultiplayerLabel.ForeColor = Color.Black;
            allianceMultiplayerLabel.Location = new Point(9, 23);
            allianceMultiplayerLabel.Margin = new Padding(4, 0, 4, 0);
            allianceMultiplayerLabel.Name = "allianceMultiplayerLabel";
            allianceMultiplayerLabel.Size = new Size(70, 15);
            allianceMultiplayerLabel.TabIndex = 172;
            allianceMultiplayerLabel.Text = "Multi Player";
            // 
            // empireGroupBox
            // 
            empireGroupBox.Controls.Add(empireMultiPlayer);
            empireGroupBox.Controls.Add(empireSinglePlayerHard);
            empireGroupBox.Controls.Add(empireSinglePlayerHardLabel);
            empireGroupBox.Controls.Add(empireSinglePlayerMedium);
            empireGroupBox.Controls.Add(empireSinglePlayerMediumLabel);
            empireGroupBox.Controls.Add(empireSinglePlayerEasy);
            empireGroupBox.Controls.Add(empireSinglePlayerEasyLabel);
            empireGroupBox.Controls.Add(empireMultiPlayerLabel);
            empireGroupBox.Location = new Point(258, 160);
            empireGroupBox.Name = "empireGroupBox";
            empireGroupBox.Size = new Size(240, 141);
            empireGroupBox.TabIndex = 178;
            empireGroupBox.TabStop = false;
            empireGroupBox.Text = "Empire";
            // 
            // empireMultiPlayer
            // 
            empireMultiPlayer.ForeColor = Color.Black;
            empireMultiPlayer.Location = new Point(141, 108);
            empireMultiPlayer.Margin = new Padding(4, 3, 4, 3);
            empireMultiPlayer.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireMultiPlayer.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            empireMultiPlayer.Name = "empireMultiPlayer";
            empireMultiPlayer.Size = new Size(92, 23);
            empireMultiPlayer.TabIndex = 174;
            empireMultiPlayer.TextAlign = HorizontalAlignment.Right;
            empireMultiPlayer.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireMultiPlayer.ValueChanged += empireMultiPlayer_ValueChanged;
            // 
            // empireSinglePlayerHard
            // 
            empireSinglePlayerHard.ForeColor = Color.Black;
            empireSinglePlayerHard.Location = new Point(141, 79);
            empireSinglePlayerHard.Margin = new Padding(4, 3, 4, 3);
            empireSinglePlayerHard.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireSinglePlayerHard.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            empireSinglePlayerHard.Name = "empireSinglePlayerHard";
            empireSinglePlayerHard.Size = new Size(92, 23);
            empireSinglePlayerHard.TabIndex = 173;
            empireSinglePlayerHard.TextAlign = HorizontalAlignment.Right;
            empireSinglePlayerHard.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireSinglePlayerHard.ValueChanged += empireSinglePlayerHard_ValueChanged;
            // 
            // empireSinglePlayerHardLabel
            // 
            empireSinglePlayerHardLabel.AutoSize = true;
            empireSinglePlayerHardLabel.ForeColor = Color.Black;
            empireSinglePlayerHardLabel.Location = new Point(10, 81);
            empireSinglePlayerHardLabel.Margin = new Padding(4, 0, 4, 0);
            empireSinglePlayerHardLabel.Name = "empireSinglePlayerHardLabel";
            empireSinglePlayerHardLabel.Size = new Size(103, 15);
            empireSinglePlayerHardLabel.TabIndex = 177;
            empireSinglePlayerHardLabel.Text = "Single Player Hard";
            // 
            // empireSinglePlayerMedium
            // 
            empireSinglePlayerMedium.ForeColor = Color.Black;
            empireSinglePlayerMedium.Location = new Point(141, 50);
            empireSinglePlayerMedium.Margin = new Padding(4, 3, 4, 3);
            empireSinglePlayerMedium.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireSinglePlayerMedium.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            empireSinglePlayerMedium.Name = "empireSinglePlayerMedium";
            empireSinglePlayerMedium.Size = new Size(92, 23);
            empireSinglePlayerMedium.TabIndex = 172;
            empireSinglePlayerMedium.TextAlign = HorizontalAlignment.Right;
            empireSinglePlayerMedium.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireSinglePlayerMedium.ValueChanged += empireSinglePlayerMedium_ValueChanged;
            // 
            // empireSinglePlayerMediumLabel
            // 
            empireSinglePlayerMediumLabel.AutoSize = true;
            empireSinglePlayerMediumLabel.ForeColor = Color.Black;
            empireSinglePlayerMediumLabel.Location = new Point(10, 52);
            empireSinglePlayerMediumLabel.Margin = new Padding(4, 0, 4, 0);
            empireSinglePlayerMediumLabel.Name = "empireSinglePlayerMediumLabel";
            empireSinglePlayerMediumLabel.Size = new Size(122, 15);
            empireSinglePlayerMediumLabel.TabIndex = 176;
            empireSinglePlayerMediumLabel.Text = "Single Player Medium";
            // 
            // empireSinglePlayerEasy
            // 
            empireSinglePlayerEasy.ForeColor = Color.Black;
            empireSinglePlayerEasy.Location = new Point(141, 21);
            empireSinglePlayerEasy.Margin = new Padding(4, 3, 4, 3);
            empireSinglePlayerEasy.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireSinglePlayerEasy.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            empireSinglePlayerEasy.Name = "empireSinglePlayerEasy";
            empireSinglePlayerEasy.Size = new Size(92, 23);
            empireSinglePlayerEasy.TabIndex = 172;
            empireSinglePlayerEasy.TextAlign = HorizontalAlignment.Right;
            empireSinglePlayerEasy.Value = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            empireSinglePlayerEasy.ValueChanged += empireSinglePlayerEasy_ValueChanged;
            // 
            // empireSinglePlayerEasyLabel
            // 
            empireSinglePlayerEasyLabel.AutoSize = true;
            empireSinglePlayerEasyLabel.ForeColor = Color.Black;
            empireSinglePlayerEasyLabel.Location = new Point(10, 23);
            empireSinglePlayerEasyLabel.Margin = new Padding(4, 0, 4, 0);
            empireSinglePlayerEasyLabel.Name = "empireSinglePlayerEasyLabel";
            empireSinglePlayerEasyLabel.Size = new Size(100, 15);
            empireSinglePlayerEasyLabel.TabIndex = 175;
            empireSinglePlayerEasyLabel.Text = "Single Player Easy";
            // 
            // empireMultiPlayerLabel
            // 
            empireMultiPlayerLabel.AutoSize = true;
            empireMultiPlayerLabel.ForeColor = Color.Black;
            empireMultiPlayerLabel.Location = new Point(10, 110);
            empireMultiPlayerLabel.Margin = new Padding(4, 0, 4, 0);
            empireMultiPlayerLabel.Name = "empireMultiPlayerLabel";
            empireMultiPlayerLabel.Size = new Size(70, 15);
            empireMultiPlayerLabel.TabIndex = 172;
            empireMultiPlayerLabel.Text = "Multi Player";
            // 
            // GeneralParamTableEntryForm
            // 
            AcceptButton = Ok;
            AutoScaleMode = AutoScaleMode.None;
            CancelButton = Cancel;
            ClientSize = new Size(504, 343);
            Controls.Add(empireGroupBox);
            Controls.Add(idLabel);
            Controls.Add(parameterIdLabel);
            Controls.Add(name);
            Controls.Add(nameLabel);
            Controls.Add(allianceGroupBox);
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
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(520, 382);
            MinimumSize = new Size(520, 382);
            Name = "GeneralParamTableEntryForm";
            Text = "General Parameters Tables (GNPRTB.DAT)";
            FormClosing += GameObjectsListForm_FormClosing;
            Load += GameObjectsListForm_Load;
            KeyDown += GameObjectsListForm_KeyDown;
            ((ISupportInitialize)selector).EndInit();
            ((ISupportInitialize)parameterId).EndInit();
            ((ISupportInitialize)id).EndInit();
            ((ISupportInitialize)field2_1).EndInit();
            allianceGroupBox.ResumeLayout(false);
            allianceGroupBox.PerformLayout();
            ((ISupportInitialize)allianceSinglePlayerHard).EndInit();
            ((ISupportInitialize)allianceSinglePlayerMedium).EndInit();
            ((ISupportInitialize)allianceSinglePlayerEasy).EndInit();
            ((ISupportInitialize)allianceMultiPlayer).EndInit();
            empireGroupBox.ResumeLayout(false);
            empireGroupBox.PerformLayout();
            ((ISupportInitialize)empireMultiPlayer).EndInit();
            ((ISupportInitialize)empireSinglePlayerHard).EndInit();
            ((ISupportInitialize)empireSinglePlayerMedium).EndInit();
            ((ISupportInitialize)empireSinglePlayerEasy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox allianceGroupBox;

        private Label allianceSinglePlayerHardLabel;
        private Label allianceSinglePlayerMediumLabel;
        private Label allianceSinglePlayerEasyLabel;
        private NumericUpDown allianceSinglePlayerHard;
        private NumericUpDown allianceSinglePlayerMedium;
        private NumericUpDown allianceSinglePlayerEasy;
        private NumericUpDown allianceMultiPlayer;
        private Label allianceMultiplayerLabel;
        private GroupBox empireGroupBox;
        private Label empireSinglePlayerHardLabel;
        private Label empireSinglePlayerMediumLabel;
        private Label empireSinglePlayerEasyLabel;
        private NumericUpDown empireMultiPlayer;
        private NumericUpDown empireSinglePlayerHard;
        private NumericUpDown empireSinglePlayerMedium;
        private NumericUpDown empireSinglePlayerEasy;
        private Label empireMultiPlayerLabel;
    }
}