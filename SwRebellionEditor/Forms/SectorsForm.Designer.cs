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
        private Label groupLabel;
        private Label nameLabel;
        private Label familyIdHexLabel;
        private Label idHexLabel;
        private NumericUpDown productionFamily_0;
        private NumericUpDown id;
        private NumericUpDown yPosition;
        private NumericUpDown field2_1;
        private NumericUpDown xPosition;
        private NumericUpDown group;
        private NumericUpDown nextProductionFamily_0;
        private NumericUpDown familyId;
        private NumericUpDown galaxySize;
        private NumericUpDown textStraDllId;
        private NumericUpDown field7_2;
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(SectorsForm));
            Open = new Button();
            SaveAs = new Button();
            Cancel = new Button();
            Ok = new Button();
            selector = new TrackBar();
            familyId = new NumericUpDown();
            galaxySize = new NumericUpDown();
            galaxySizeLabel = new Label();
            group = new NumericUpDown();
            nextProductionFamily_0 = new NumericUpDown();
            productionFamily_0 = new NumericUpDown();
            id = new NumericUpDown();
            productionFamily_0Label = new Label();
            yPosition = new NumericUpDown();
            field2_1Label = new Label();
            field2_1 = new NumericUpDown();
            idLabel = new Label();
            xPosition = new NumericUpDown();
            positionLabel = new Label();
            familyCommentLabel = new Label();
            nextProductionFamily_0Label = new Label();
            familyIdLabel = new Label();
            textStraDllIdLabel = new Label();
            textStraDllId = new NumericUpDown();
            field7_2 = new NumericUpDown();
            field7_2Label = new Label();
            groupLabel = new Label();
            inGameDataGroupBox = new GroupBox();
            name = new TextBox();
            nameLabel = new Label();
            familyIdHexLabel = new Label();
            idHexLabel = new Label();
            hiddenDataGroupBox = new GroupBox();
            label1 = new Label();
            infoLabel = new Label();
            ((ISupportInitialize)selector).BeginInit();
            ((ISupportInitialize)familyId).BeginInit();
            ((ISupportInitialize)galaxySize).BeginInit();
            ((ISupportInitialize)group).BeginInit();
            ((ISupportInitialize)nextProductionFamily_0).BeginInit();
            ((ISupportInitialize)productionFamily_0).BeginInit();
            ((ISupportInitialize)id).BeginInit();
            ((ISupportInitialize)yPosition).BeginInit();
            ((ISupportInitialize)field2_1).BeginInit();
            ((ISupportInitialize)xPosition).BeginInit();
            ((ISupportInitialize)textStraDllId).BeginInit();
            ((ISupportInitialize)field7_2).BeginInit();
            inGameDataGroupBox.SuspendLayout();
            hiddenDataGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // Open
            // 
            Open.Location = new Point(363, 296);
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
            SaveAs.Location = new Point(267, 296);
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
            Cancel.Location = new Point(171, 296);
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
            Ok.Location = new Point(75, 296);
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
            selector.Size = new Size(346, 45);
            selector.TabIndex = 149;
            selector.ValueChanged += GameObjectsSelector_ValueChanged;
            // 
            // familyId
            // 
            familyId.ForeColor = Color.Red;
            familyId.Location = new Point(147, 121);
            familyId.Margin = new Padding(4, 3, 4, 3);
            familyId.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            familyId.Name = "familyId";
            familyId.Size = new Size(59, 23);
            familyId.TabIndex = 14;
            familyId.TextAlign = HorizontalAlignment.Right;
            familyId.Value = new decimal(new int[] { 128, 0, 0, 0 });
            familyId.ValueChanged += familyId_ValueChanged;
            // 
            // galaxySize
            // 
            galaxySize.Location = new Point(147, 225);
            galaxySize.Margin = new Padding(4, 3, 4, 3);
            galaxySize.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            galaxySize.Name = "galaxySize";
            galaxySize.Size = new Size(59, 23);
            galaxySize.TabIndex = 13;
            galaxySize.TextAlign = HorizontalAlignment.Right;
            galaxySize.Value = new decimal(new int[] { -1, 0, 0, 0 });
            galaxySize.ValueChanged += galaxySize_ValueChanged;
            // 
            // galaxySizeLabel
            // 
            galaxySizeLabel.AutoSize = true;
            galaxySizeLabel.ForeColor = Color.Green;
            galaxySizeLabel.Location = new Point(10, 227);
            galaxySizeLabel.Margin = new Padding(4, 0, 4, 0);
            galaxySizeLabel.Name = "galaxySizeLabel";
            galaxySizeLabel.Size = new Size(78, 15);
            galaxySizeLabel.TabIndex = 12;
            galaxySizeLabel.Text = "Galaxy Size **";
            // 
            // group
            // 
            group.Location = new Point(147, 199);
            group.Margin = new Padding(4, 3, 4, 3);
            group.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            group.Name = "group";
            group.Size = new Size(59, 23);
            group.TabIndex = 7;
            group.TextAlign = HorizontalAlignment.Right;
            group.Value = new decimal(new int[] { -1, 0, 0, 0 });
            group.ValueChanged += group_ValueChanged;
            // 
            // nextProductionFamily_0
            // 
            nextProductionFamily_0.ForeColor = Color.FromArgb(192, 0, 192);
            nextProductionFamily_0.Location = new Point(147, 95);
            nextProductionFamily_0.Margin = new Padding(4, 3, 4, 3);
            nextProductionFamily_0.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            nextProductionFamily_0.Name = "nextProductionFamily_0";
            nextProductionFamily_0.Size = new Size(59, 23);
            nextProductionFamily_0.TabIndex = 6;
            nextProductionFamily_0.TextAlign = HorizontalAlignment.Right;
            nextProductionFamily_0.ValueChanged += nextProductionFamily_0_ValueChanged;
            // 
            // productionFamily_0
            // 
            productionFamily_0.ForeColor = Color.FromArgb(192, 0, 192);
            productionFamily_0.Location = new Point(147, 69);
            productionFamily_0.Margin = new Padding(4, 3, 4, 3);
            productionFamily_0.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            productionFamily_0.Name = "productionFamily_0";
            productionFamily_0.Size = new Size(59, 23);
            productionFamily_0.TabIndex = 11;
            productionFamily_0.TextAlign = HorizontalAlignment.Right;
            productionFamily_0.ValueChanged += productionFamily_0_ValueChanged;
            // 
            // id
            // 
            id.ForeColor = Color.Red;
            id.Location = new Point(147, 17);
            id.Margin = new Padding(4, 3, 4, 3);
            id.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            id.Name = "id";
            id.Size = new Size(59, 23);
            id.TabIndex = 10;
            id.TextAlign = HorizontalAlignment.Right;
            id.Value = new decimal(new int[] { -1, 0, 0, 0 });
            id.ValueChanged += id_ValueChanged;
            // 
            // productionFamily_0Label
            // 
            productionFamily_0Label.AutoSize = true;
            productionFamily_0Label.ForeColor = Color.FromArgb(192, 0, 192);
            productionFamily_0Label.Location = new Point(10, 71);
            productionFamily_0Label.Margin = new Padding(4, 0, 4, 0);
            productionFamily_0Label.Name = "productionFamily_0Label";
            productionFamily_0Label.Size = new Size(104, 15);
            productionFamily_0Label.TabIndex = 12;
            productionFamily_0Label.Text = "Production Family";
            // 
            // yPosition
            // 
            yPosition.Location = new Point(214, 251);
            yPosition.Margin = new Padding(4, 3, 4, 3);
            yPosition.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            yPosition.Name = "yPosition";
            yPosition.Size = new Size(59, 23);
            yPosition.TabIndex = 7;
            yPosition.TextAlign = HorizontalAlignment.Right;
            yPosition.Value = new decimal(new int[] { 65535, 0, 0, 0 });
            yPosition.ValueChanged += yPosition_ValueChanged;
            // 
            // field2_1Label
            // 
            field2_1Label.AutoSize = true;
            field2_1Label.ForeColor = Color.Red;
            field2_1Label.Location = new Point(10, 45);
            field2_1Label.Margin = new Padding(4, 0, 4, 0);
            field2_1Label.Name = "field2_1Label";
            field2_1Label.Size = new Size(93, 15);
            field2_1Label.TabIndex = 0;
            field2_1Label.Text = "Field2 (always 1)";
            // 
            // field2_1
            // 
            field2_1.ForeColor = Color.Red;
            field2_1.Location = new Point(147, 43);
            field2_1.Margin = new Padding(4, 3, 4, 3);
            field2_1.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            field2_1.Name = "field2_1";
            field2_1.Size = new Size(59, 23);
            field2_1.TabIndex = 8;
            field2_1.TextAlign = HorizontalAlignment.Right;
            field2_1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            field2_1.ValueChanged += field2_1_ValueChanged;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.ForeColor = Color.Red;
            idLabel.Location = new Point(10, 19);
            idLabel.Margin = new Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id";
            // 
            // xPosition
            // 
            xPosition.Location = new Point(147, 251);
            xPosition.Margin = new Padding(4, 3, 4, 3);
            xPosition.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            xPosition.Name = "xPosition";
            xPosition.Size = new Size(59, 23);
            xPosition.TabIndex = 6;
            xPosition.TextAlign = HorizontalAlignment.Right;
            xPosition.Value = new decimal(new int[] { 65535, 0, 0, 0 });
            xPosition.ValueChanged += xPosition_ValueChanged;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new Point(10, 253);
            positionLabel.Margin = new Padding(4, 0, 4, 0);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(81, 15);
            positionLabel.TabIndex = 0;
            positionLabel.Text = "Position (X, Y)";
            // 
            // familyCommentLabel
            // 
            familyCommentLabel.AutoSize = true;
            familyCommentLabel.ForeColor = Color.Blue;
            familyCommentLabel.Location = new Point(148, 213);
            familyCommentLabel.Margin = new Padding(4, 0, 4, 0);
            familyCommentLabel.Name = "familyCommentLabel";
            familyCommentLabel.Size = new Size(207, 15);
            familyCommentLabel.TabIndex = 158;
            familyCommentLabel.Text = "* 1=Core 2=Rim (inner) 3=Rim (outer)";
            // 
            // nextProductionFamily_0Label
            // 
            nextProductionFamily_0Label.AutoSize = true;
            nextProductionFamily_0Label.ForeColor = Color.FromArgb(192, 0, 192);
            nextProductionFamily_0Label.Location = new Point(10, 97);
            nextProductionFamily_0Label.Margin = new Padding(4, 0, 4, 0);
            nextProductionFamily_0Label.Name = "nextProductionFamily_0Label";
            nextProductionFamily_0Label.Size = new Size(121, 15);
            nextProductionFamily_0Label.TabIndex = 160;
            nextProductionFamily_0Label.Text = "Production Family +1";
            // 
            // familyIdLabel
            // 
            familyIdLabel.AutoSize = true;
            familyIdLabel.ForeColor = Color.Red;
            familyIdLabel.Location = new Point(10, 123);
            familyIdLabel.Margin = new Padding(4, 0, 4, 0);
            familyIdLabel.Name = "familyIdLabel";
            familyIdLabel.Size = new Size(122, 15);
            familyIdLabel.TabIndex = 161;
            familyIdLabel.Text = "Family Id (always 128)";
            // 
            // textStraDllIdLabel
            // 
            textStraDllIdLabel.AutoSize = true;
            textStraDllIdLabel.ForeColor = Color.Red;
            textStraDllIdLabel.Location = new Point(10, 149);
            textStraDllIdLabel.Margin = new Padding(4, 0, 4, 0);
            textStraDllIdLabel.Name = "textStraDllIdLabel";
            textStraDllIdLabel.Size = new Size(77, 15);
            textStraDllIdLabel.TabIndex = 163;
            textStraDllIdLabel.Text = "TextStra.dll Id";
            // 
            // textStraDllId
            // 
            textStraDllId.ForeColor = Color.Red;
            textStraDllId.Location = new Point(147, 147);
            textStraDllId.Margin = new Padding(4, 3, 4, 3);
            textStraDllId.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            textStraDllId.Name = "textStraDllId";
            textStraDllId.Size = new Size(59, 23);
            textStraDllId.TabIndex = 162;
            textStraDllId.TextAlign = HorizontalAlignment.Right;
            textStraDllId.Value = new decimal(new int[] { 65535, 0, 0, 0 });
            textStraDllId.ValueChanged += textStraDllId_ValueChanged;
            // 
            // field7_2
            // 
            field7_2.ForeColor = Color.Red;
            field7_2.Location = new Point(147, 173);
            field7_2.Margin = new Padding(4, 3, 4, 3);
            field7_2.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            field7_2.Name = "field7_2";
            field7_2.Size = new Size(59, 23);
            field7_2.TabIndex = 165;
            field7_2.TextAlign = HorizontalAlignment.Right;
            field7_2.Value = new decimal(new int[] { 2, 0, 0, 0 });
            field7_2.ValueChanged += field7_2_ValueChanged;
            // 
            // field7_2Label
            // 
            field7_2Label.AutoSize = true;
            field7_2Label.ForeColor = Color.Red;
            field7_2Label.Location = new Point(10, 175);
            field7_2Label.Margin = new Padding(4, 0, 4, 0);
            field7_2Label.Name = "field7_2Label";
            field7_2Label.Size = new Size(93, 15);
            field7_2Label.TabIndex = 164;
            field7_2Label.Text = "Field7 (always 2)";
            // 
            // groupLabel
            // 
            groupLabel.AutoSize = true;
            groupLabel.ForeColor = Color.Blue;
            groupLabel.Location = new Point(10, 201);
            groupLabel.Margin = new Padding(4, 0, 4, 0);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new Size(45, 15);
            groupLabel.TabIndex = 166;
            groupLabel.Text = "Group*";
            // 
            // inGameDataGroupBox
            // 
            inGameDataGroupBox.Controls.Add(name);
            inGameDataGroupBox.Controls.Add(nameLabel);
            inGameDataGroupBox.Location = new Point(12, 52);
            inGameDataGroupBox.Name = "inGameDataGroupBox";
            inGameDataGroupBox.Size = new Size(347, 52);
            inGameDataGroupBox.TabIndex = 167;
            inGameDataGroupBox.TabStop = false;
            inGameDataGroupBox.Text = "In Game Data";
            // 
            // name
            // 
            name.Location = new Point(63, 21);
            name.Name = "name";
            name.Size = new Size(278, 23);
            name.TabIndex = 169;
            name.TextChanged += name_TextChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(17, 24);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 168;
            nameLabel.Text = "Name";
            // 
            // familyIdHexLabel
            // 
            familyIdHexLabel.AutoSize = true;
            familyIdHexLabel.ForeColor = Color.Red;
            familyIdHexLabel.Location = new Point(214, 123);
            familyIdHexLabel.Margin = new Padding(4, 0, 4, 0);
            familyIdHexLabel.Name = "familyIdHexLabel";
            familyIdHexLabel.Size = new Size(31, 15);
            familyIdHexLabel.TabIndex = 168;
            familyIdHexLabel.Text = "0x00";
            // 
            // idHexLabel
            // 
            idHexLabel.AutoSize = true;
            idHexLabel.ForeColor = Color.Red;
            idHexLabel.Location = new Point(214, 19);
            idHexLabel.Margin = new Padding(4, 0, 4, 0);
            idHexLabel.Name = "idHexLabel";
            idHexLabel.Size = new Size(31, 15);
            idHexLabel.TabIndex = 169;
            idHexLabel.Text = "0x00";
            // 
            // hiddenDataGroupBox
            // 
            hiddenDataGroupBox.Controls.Add(idLabel);
            hiddenDataGroupBox.Controls.Add(familyIdHexLabel);
            hiddenDataGroupBox.Controls.Add(groupLabel);
            hiddenDataGroupBox.Controls.Add(idHexLabel);
            hiddenDataGroupBox.Controls.Add(field7_2);
            hiddenDataGroupBox.Controls.Add(id);
            hiddenDataGroupBox.Controls.Add(field7_2Label);
            hiddenDataGroupBox.Controls.Add(galaxySize);
            hiddenDataGroupBox.Controls.Add(field2_1Label);
            hiddenDataGroupBox.Controls.Add(galaxySizeLabel);
            hiddenDataGroupBox.Controls.Add(field2_1);
            hiddenDataGroupBox.Controls.Add(group);
            hiddenDataGroupBox.Controls.Add(nextProductionFamily_0Label);
            hiddenDataGroupBox.Controls.Add(textStraDllIdLabel);
            hiddenDataGroupBox.Controls.Add(yPosition);
            hiddenDataGroupBox.Controls.Add(productionFamily_0Label);
            hiddenDataGroupBox.Controls.Add(textStraDllId);
            hiddenDataGroupBox.Controls.Add(nextProductionFamily_0);
            hiddenDataGroupBox.Controls.Add(familyIdLabel);
            hiddenDataGroupBox.Controls.Add(xPosition);
            hiddenDataGroupBox.Controls.Add(familyId);
            hiddenDataGroupBox.Controls.Add(positionLabel);
            hiddenDataGroupBox.Controls.Add(productionFamily_0);
            hiddenDataGroupBox.Location = new Point(366, 12);
            hiddenDataGroupBox.Name = "hiddenDataGroupBox";
            hiddenDataGroupBox.Size = new Size(278, 280);
            hiddenDataGroupBox.TabIndex = 170;
            hiddenDataGroupBox.TabStop = false;
            hiddenDataGroupBox.Text = "Hidden Data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Green;
            label1.Location = new Point(116, 239);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(239, 15);
            label1.TabIndex = 171;
            label1.Text = "** 1=Standard 2=Large 3=Huge +4=Inactive";
            // 
            // infoLabel
            // 
            infoLabel.ForeColor = Color.Blue;
            infoLabel.Location = new Point(32, 120);
            infoLabel.Margin = new Padding(4, 0, 4, 0);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(308, 76);
            infoLabel.TabIndex = 172;
            infoLabel.Text = resources.GetString("infoLabel.Text");
            // 
            // SectorsForm
            // 
            AcceptButton = Ok;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.None;
            CancelButton = Cancel;
            ClientSize = new Size(650, 328);
            Controls.Add(infoLabel);
            Controls.Add(label1);
            Controls.Add(hiddenDataGroupBox);
            Controls.Add(inGameDataGroupBox);
            Controls.Add(familyCommentLabel);
            Controls.Add(Open);
            Controls.Add(SaveAs);
            Controls.Add(Cancel);
            Controls.Add(Ok);
            Controls.Add(selector);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(666, 367);
            MinimumSize = new Size(666, 367);
            Name = "SectorsForm";
            Text = "Sectors (SECTORSD.DAT)";
            FormClosing += GameObjectsListForm_FormClosing;
            Load += GameObjectsListForm_Load;
            KeyDown += GameObjectsListForm_KeyDown;
            ((ISupportInitialize)selector).EndInit();
            ((ISupportInitialize)familyId).EndInit();
            ((ISupportInitialize)galaxySize).EndInit();
            ((ISupportInitialize)group).EndInit();
            ((ISupportInitialize)nextProductionFamily_0).EndInit();
            ((ISupportInitialize)productionFamily_0).EndInit();
            ((ISupportInitialize)id).EndInit();
            ((ISupportInitialize)yPosition).EndInit();
            ((ISupportInitialize)field2_1).EndInit();
            ((ISupportInitialize)xPosition).EndInit();
            ((ISupportInitialize)textStraDllId).EndInit();
            ((ISupportInitialize)field7_2).EndInit();
            inGameDataGroupBox.ResumeLayout(false);
            inGameDataGroupBox.PerformLayout();
            hiddenDataGroupBox.ResumeLayout(false);
            hiddenDataGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox hiddenDataGroupBox;
        private Label label1;
        private Label infoLabel;
    }
}