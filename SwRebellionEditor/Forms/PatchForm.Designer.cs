using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class PatchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;
        private ImageList systemsImageList;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PatchForm));
            systemsImageList = new ImageList(components);
            cancel = new Button();
            patch = new Button();
            titleLabel = new Label();
            contentLabel = new Label();
            line3Label = new Label();
            line1Label = new Label();
            line2Label = new Label();
            line4Label = new Label();
            line5Label = new Label();
            warningLabel = new Label();
            patchInfoLabel = new Label();
            label1Requirement = new Label();
            label1 = new Label();
            charactersWithStatsCheckBox = new CheckBox();
            charactersWithoutStatsCheckBox = new CheckBox();
            patchTest = new Button();
            SuspendLayout();
            // 
            // systemsImageList
            // 
            systemsImageList.ColorDepth = ColorDepth.Depth8Bit;
            systemsImageList.ImageSize = new Size(120, 60);
            systemsImageList.TransparentColor = Color.Transparent;
            // 
            // cancel
            // 
            cancel.Location = new Point(604, 246);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 1154;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // patch
            // 
            patch.Location = new Point(24, 246);
            patch.Name = "patch";
            patch.Size = new Size(110, 23);
            patch.TabIndex = 1155;
            patch.Text = "Patch my game";
            patch.UseVisualStyleBackColor = true;
            patch.Click += patch_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(12, 14);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(239, 15);
            titleLabel.TabIndex = 1156;
            titleLabel.Text = "StarWars Rebellion 25th Anniversary Mod";
            // 
            // contentLabel
            // 
            contentLabel.AutoSize = true;
            contentLabel.Location = new Point(24, 38);
            contentLabel.Name = "contentLabel";
            contentLabel.Size = new Size(56, 15);
            contentLabel.TabIndex = 1157;
            contentLabel.Text = "Content :";
            // 
            // line3Label
            // 
            line3Label.AutoSize = true;
            line3Label.Location = new Point(33, 103);
            line3Label.Name = "line3Label";
            line3Label.Size = new Size(384, 15);
            line3Label.TabIndex = 1158;
            line3Label.Text = "- Newly imagined Sector names (to match the 20 groups of 10 Systems)";
            // 
            // line1Label
            // 
            line1Label.AutoSize = true;
            line1Label.Location = new Point(33, 59);
            line1Label.Name = "line1Label";
            line1Label.Size = new Size(686, 15);
            line1Label.TabIndex = 1159;
            line1Label.Text = "- Revised Top 200 systems from Star Wars franchise based on many aspects (movies, tv series, games, atlas, hyperspace routes, ...)";
            // 
            // line2Label
            // 
            line2Label.AutoSize = true;
            line2Label.Location = new Point(33, 81);
            line2Label.Name = "line2Label";
            line2Label.Size = new Size(607, 15);
            line2Label.TabIndex = 1160;
            line2Label.Text = "- Accurate positionning of Systems and Sectors (through barycenters computation, then proportional projections)";
            // 
            // line4Label
            // 
            line4Label.AutoSize = true;
            line4Label.Location = new Point(33, 125);
            line4Label.Name = "line4Label";
            line4Label.Size = new Size(623, 15);
            line4Label.TabIndex = 1161;
            line4Label.Text = "- Rebexe.exe patch to enable having 200+ Systems sprites and Encyclopedia pictures (no more hardcoded limit of 26)";
            // 
            // line5Label
            // 
            line5Label.AutoSize = true;
            line5Label.Location = new Point(33, 147);
            line5Label.Name = "line5Label";
            line5Label.Size = new Size(678, 15);
            line5Label.TabIndex = 1162;
            line5Label.Text = "- Unique sprites and pictures for ALL 200 systems! + New Encyclopedia descriptions! + New tactical sprites + 3D models (26/29).";
            // 
            // warningLabel
            // 
            warningLabel.AutoSize = true;
            warningLabel.ForeColor = Color.Red;
            warningLabel.Location = new Point(24, 177);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new Size(672, 15);
            warningLabel.TabIndex = 1163;
            warningLabel.Text = "This patch was released 2023-08-05 and is provided without any warranty of any kind. Doesn't work with pre-patch savegames.";
            // 
            // patchInfoLabel
            // 
            patchInfoLabel.AutoSize = true;
            patchInfoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            patchInfoLabel.Location = new Point(140, 250);
            patchInfoLabel.Name = "patchInfoLabel";
            patchInfoLabel.Size = new Size(432, 15);
            patchInfoLabel.TabIndex = 1164;
            patchInfoLabel.Text = "This window will freeze for a few minutes then close when the patch is completed.";
            // 
            // label1Requirement
            // 
            label1Requirement.AutoSize = true;
            label1Requirement.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1Requirement.ForeColor = Color.Red;
            label1Requirement.Location = new Point(393, 14);
            label1Requirement.Name = "label1Requirement";
            label1Requirement.Size = new Size(253, 15);
            label1Requirement.TabIndex = 1165;
            label1Requirement.Text = "Includes update 1.02 (dgvoodoo2 directx 2.81.3)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(408, 29);
            label1.Name = "label1";
            label1.Size = new Size(311, 15);
            label1.TabIndex = 1166;
            label1.Text = "Run dgVoodooCpl.exe after to setup your graphic settings.";
            // 
            // charactersWithStatsCheckBox
            // 
            charactersWithStatsCheckBox.AutoSize = true;
            charactersWithStatsCheckBox.Checked = true;
            charactersWithStatsCheckBox.CheckState = CheckState.Checked;
            charactersWithStatsCheckBox.Location = new Point(33, 210);
            charactersWithStatsCheckBox.Name = "charactersWithStatsCheckBox";
            charactersWithStatsCheckBox.Size = new Size(158, 19);
            charactersWithStatsCheckBox.TabIndex = 1167;
            charactersWithStatsCheckBox.Text = "new characters with stats";
            charactersWithStatsCheckBox.UseVisualStyleBackColor = true;
            charactersWithStatsCheckBox.CheckedChanged += charactersWithStatsCheckBox_CheckedChanged;
            // 
            // charactersWithoutStatsCheckBox
            // 
            charactersWithoutStatsCheckBox.AutoSize = true;
            charactersWithoutStatsCheckBox.Location = new Point(233, 210);
            charactersWithoutStatsCheckBox.Name = "charactersWithoutStatsCheckBox";
            charactersWithoutStatsCheckBox.Size = new Size(176, 19);
            charactersWithoutStatsCheckBox.TabIndex = 1168;
            charactersWithoutStatsCheckBox.Text = "new characters without stats";
            charactersWithoutStatsCheckBox.UseVisualStyleBackColor = true;
            charactersWithoutStatsCheckBox.CheckedChanged += charactersWithoutStatsCheckBox_CheckedChanged;
            // 
            // patchTest
            // 
            patchTest.Location = new Point(450, 207);
            patchTest.Name = "patchTest";
            patchTest.Size = new Size(132, 23);
            patchTest.TabIndex = 1169;
            patchTest.Text = "Patch test folder only";
            patchTest.UseVisualStyleBackColor = true;
            patchTest.Click += patchTest_Click;
            // 
            // PatchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 278);
            Controls.Add(patchTest);
            Controls.Add(charactersWithoutStatsCheckBox);
            Controls.Add(charactersWithStatsCheckBox);
            Controls.Add(label1);
            Controls.Add(label1Requirement);
            Controls.Add(patchInfoLabel);
            Controls.Add(warningLabel);
            Controls.Add(line5Label);
            Controls.Add(line4Label);
            Controls.Add(line2Label);
            Controls.Add(line1Label);
            Controls.Add(line3Label);
            Controls.Add(contentLabel);
            Controls.Add(titleLabel);
            Controls.Add(patch);
            Controls.Add(cancel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(751, 317);
            MinimumSize = new Size(751, 317);
            Name = "PatchForm";
            Text = "Patch";
            FormClosing += GameObjectsListForm_FormClosing;
            Load += GameObjectsListForm_Load;
            KeyDown += GameObjectsListForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cancel;
        private Button patch;
        private Label titleLabel;
        private Label contentLabel;
        private Label line3Label;
        private Label line1Label;
        private Label line2Label;
        private Label line4Label;
        private Label line5Label;
        private Label warningLabel;
        private Label patchInfoLabel;
        private Label label1Requirement;
        private Label label1;
        private CheckBox charactersWithStatsCheckBox;
        private CheckBox charactersWithoutStatsCheckBox;
        private Button patchTest;
    }
}