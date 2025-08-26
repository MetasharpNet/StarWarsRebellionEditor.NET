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
            label1Requirement = new Label();
            label1 = new Label();
            unitsWithStatsCheckBox = new CheckBox();
            unitsWithoutStatsCheckBox = new CheckBox();
            patchTest = new Button();
            label2 = new Label();
            compatibleGalaxyMapCheckBox = new CheckBox();
            accurateGalaxyMapCheckBox = new CheckBox();
            label3 = new Label();
            buttonSwitchToCompatible = new Button();
            label4 = new Label();
            label5 = new Label();
            buttonSwitchToAccurate = new Button();
            buttonDisableBriefings = new Button();
            groupBoxMap = new GroupBox();
            groupBoxBriefings = new GroupBox();
            buttonEnableBriefings = new Button();
            groupBoxMap.SuspendLayout();
            groupBoxBriefings.SuspendLayout();
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
            cancel.ForeColor = SystemColors.ActiveCaptionText;
            cancel.Location = new Point(604, 326);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 1154;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // patch
            // 
            patch.Location = new Point(24, 326);
            patch.Name = "patch";
            patch.Size = new Size(119, 23);
            patch.TabIndex = 1155;
            patch.Text = "Patch my game";
            patch.UseVisualStyleBackColor = true;
            patch.Click += patch_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            titleLabel.Location = new Point(12, 14);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(239, 15);
            titleLabel.TabIndex = 1156;
            titleLabel.Text = "StarWars Rebellion 25th Anniversary Mod";
            // 
            // contentLabel
            // 
            contentLabel.AutoSize = true;
            contentLabel.Location = new Point(12, 39);
            contentLabel.Name = "contentLabel";
            contentLabel.Size = new Size(56, 15);
            contentLabel.TabIndex = 1157;
            contentLabel.Text = "Content :";
            // 
            // line3Label
            // 
            line3Label.AutoSize = true;
            line3Label.Location = new Point(21, 104);
            line3Label.Name = "line3Label";
            line3Label.Size = new Size(384, 15);
            line3Label.TabIndex = 1158;
            line3Label.Text = "- Newly imagined Sector names (to match the 20 groups of 10 Systems)";
            // 
            // line1Label
            // 
            line1Label.AutoSize = true;
            line1Label.Location = new Point(21, 60);
            line1Label.Name = "line1Label";
            line1Label.Size = new Size(686, 15);
            line1Label.TabIndex = 1159;
            line1Label.Text = "- Revised Top 200 systems from Star Wars franchise based on many aspects (movies, tv series, games, atlas, hyperspace routes, ...)";
            // 
            // line2Label
            // 
            line2Label.AutoSize = true;
            line2Label.Location = new Point(21, 82);
            line2Label.Name = "line2Label";
            line2Label.Size = new Size(607, 15);
            line2Label.TabIndex = 1160;
            line2Label.Text = "- Accurate positionning of Systems and Sectors (through barycenters computation, then proportional projections)";
            // 
            // line4Label
            // 
            line4Label.AutoSize = true;
            line4Label.Location = new Point(21, 126);
            line4Label.Name = "line4Label";
            line4Label.Size = new Size(623, 15);
            line4Label.TabIndex = 1161;
            line4Label.Text = "- Rebexe.exe patch to enable having 200+ Systems sprites and Encyclopedia pictures (no more hardcoded limit of 26)";
            // 
            // line5Label
            // 
            line5Label.AutoSize = true;
            line5Label.Location = new Point(21, 148);
            line5Label.Name = "line5Label";
            line5Label.Size = new Size(698, 15);
            line5Label.TabIndex = 1162;
            line5Label.Text = "- Unique sprites and pictures for ALL 200 systems! + New Encyclopedia descriptions! + New tactical sprites + HD 3D models (29/29).";
            // 
            // warningLabel
            // 
            warningLabel.AutoSize = true;
            warningLabel.ForeColor = Color.Red;
            warningLabel.Location = new Point(24, 231);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new Size(350, 15);
            warningLabel.TabIndex = 1163;
            warningLabel.Text = "Released 2025-08 and provided without any warranty of any kind.";
            // 
            // label1Requirement
            // 
            label1Requirement.AutoSize = true;
            label1Requirement.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label1Requirement.ForeColor = Color.Red;
            label1Requirement.Location = new Point(393, 14);
            label1Requirement.Name = "label1Requirement";
            label1Requirement.Size = new Size(253, 15);
            label1Requirement.TabIndex = 1165;
            label1Requirement.Text = "Includes update 1.02 (dgvoodoo2 directx 2.86.2)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(408, 29);
            label1.Name = "label1";
            label1.Size = new Size(311, 15);
            label1.TabIndex = 1166;
            label1.Text = "Run dgVoodooCpl.exe after to setup your graphic settings.";
            // 
            // unitsWithStatsCheckBox
            // 
            unitsWithStatsCheckBox.AutoSize = true;
            unitsWithStatsCheckBox.Checked = true;
            unitsWithStatsCheckBox.CheckState = CheckState.Checked;
            unitsWithStatsCheckBox.Location = new Point(21, 291);
            unitsWithStatsCheckBox.Name = "unitsWithStatsCheckBox";
            unitsWithStatsCheckBox.Size = new Size(105, 19);
            unitsWithStatsCheckBox.TabIndex = 1167;
            unitsWithStatsCheckBox.Text = "units with stats";
            unitsWithStatsCheckBox.UseVisualStyleBackColor = true;
            unitsWithStatsCheckBox.CheckedChanged += unitsWithStatsCheckBox_CheckedChanged;
            // 
            // unitsWithoutStatsCheckBox
            // 
            unitsWithoutStatsCheckBox.AutoSize = true;
            unitsWithoutStatsCheckBox.Location = new Point(189, 290);
            unitsWithoutStatsCheckBox.Name = "unitsWithoutStatsCheckBox";
            unitsWithoutStatsCheckBox.Size = new Size(123, 19);
            unitsWithoutStatsCheckBox.TabIndex = 1168;
            unitsWithoutStatsCheckBox.Text = "units without stats";
            unitsWithoutStatsCheckBox.UseVisualStyleBackColor = true;
            unitsWithoutStatsCheckBox.CheckedChanged += unitsWithoutStatsCheckBox_CheckedChanged;
            // 
            // patchTest
            // 
            patchTest.ForeColor = Color.Purple;
            patchTest.Location = new Point(310, 326);
            patchTest.Name = "patchTest";
            patchTest.Size = new Size(150, 23);
            patchTest.TabIndex = 1169;
            patchTest.Text = "Patch test folder only";
            patchTest.UseVisualStyleBackColor = false;
            patchTest.Click += patchTest_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 171);
            label2.Name = "label2";
            label2.Size = new Size(148, 15);
            label2.TabIndex = 1170;
            label2.Text = "- Higher definition musics.";
            // 
            // compatibleGalaxyMapCheckBox
            // 
            compatibleGalaxyMapCheckBox.AutoSize = true;
            compatibleGalaxyMapCheckBox.Checked = true;
            compatibleGalaxyMapCheckBox.CheckState = CheckState.Checked;
            compatibleGalaxyMapCheckBox.Location = new Point(21, 264);
            compatibleGalaxyMapCheckBox.Name = "compatibleGalaxyMapCheckBox";
            compatibleGalaxyMapCheckBox.Size = new Size(150, 19);
            compatibleGalaxyMapCheckBox.TabIndex = 1171;
            compatibleGalaxyMapCheckBox.Text = "compatible galaxy map";
            compatibleGalaxyMapCheckBox.UseVisualStyleBackColor = true;
            compatibleGalaxyMapCheckBox.CheckedChanged += compatibleGalaxyMapCheckBox_CheckedChanged;
            // 
            // accurateGalaxyMapCheckBox
            // 
            accurateGalaxyMapCheckBox.AutoSize = true;
            accurateGalaxyMapCheckBox.Location = new Point(189, 264);
            accurateGalaxyMapCheckBox.Name = "accurateGalaxyMapCheckBox";
            accurateGalaxyMapCheckBox.Size = new Size(511, 19);
            accurateGalaxyMapCheckBox.TabIndex = 1172;
            accurateGalaxyMapCheckBox.Text = "accurate galaxy map (not compatible with base game savegames or base game multiplayer)";
            accurateGalaxyMapCheckBox.UseVisualStyleBackColor = true;
            accurateGalaxyMapCheckBox.CheckedChanged += accurateGalaxyMapCheckBox_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(24, 206);
            label3.Name = "label3";
            label3.Size = new Size(664, 15);
            label3.TabIndex = 1173;
            label3.Text = "For the patch  to work, you might need to disable antivirus such as Norton which might silentlt prevent proper files patching.";
            // 
            // buttonSwitchToCompatible
            // 
            buttonSwitchToCompatible.ForeColor = Color.Green;
            buttonSwitchToCompatible.Location = new Point(21, 72);
            buttonSwitchToCompatible.Name = "buttonSwitchToCompatible";
            buttonSwitchToCompatible.Size = new Size(177, 23);
            buttonSwitchToCompatible.TabIndex = 1174;
            buttonSwitchToCompatible.Text = "Switch to Compatible map";
            buttonSwitchToCompatible.UseVisualStyleBackColor = true;
            buttonSwitchToCompatible.Click += buttonSwitchToCompatible_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 25);
            label4.Name = "label4";
            label4.Size = new Size(459, 15);
            label4.TabIndex = 1175;
            label4.Text = "After successfull install, you can quick switch planet positions with the buttons below.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 45);
            label5.Name = "label5";
            label5.Size = new Size(418, 15);
            label5.TabIndex = 1176;
            label5.Text = "This allow you for ex to use some saves for compatible and some for accurate.";
            // 
            // buttonSwitchToAccurate
            // 
            buttonSwitchToAccurate.ForeColor = Color.Red;
            buttonSwitchToAccurate.Location = new Point(219, 72);
            buttonSwitchToAccurate.Name = "buttonSwitchToAccurate";
            buttonSwitchToAccurate.Size = new Size(166, 23);
            buttonSwitchToAccurate.TabIndex = 1177;
            buttonSwitchToAccurate.Text = "Switch to Accurate map";
            buttonSwitchToAccurate.UseVisualStyleBackColor = true;
            buttonSwitchToAccurate.Click += buttonSwitchToAccurate_Click;
            // 
            // buttonDisableBriefings
            // 
            buttonDisableBriefings.Location = new Point(17, 30);
            buttonDisableBriefings.Name = "buttonDisableBriefings";
            buttonDisableBriefings.Size = new Size(166, 23);
            buttonDisableBriefings.TabIndex = 1178;
            buttonDisableBriefings.Text = "Disable Briefings";
            buttonDisableBriefings.UseVisualStyleBackColor = true;
            buttonDisableBriefings.Click += buttonDisableBriefings_Click;
            // 
            // groupBoxMap
            // 
            groupBoxMap.Controls.Add(buttonSwitchToAccurate);
            groupBoxMap.Controls.Add(buttonSwitchToCompatible);
            groupBoxMap.Controls.Add(label4);
            groupBoxMap.Controls.Add(label5);
            groupBoxMap.Location = new Point(12, 367);
            groupBoxMap.Name = "groupBoxMap";
            groupBoxMap.Size = new Size(477, 105);
            groupBoxMap.TabIndex = 1179;
            groupBoxMap.TabStop = false;
            groupBoxMap.Text = "Map Type Switchs";
            // 
            // groupBoxBriefings
            // 
            groupBoxBriefings.Controls.Add(buttonEnableBriefings);
            groupBoxBriefings.Controls.Add(buttonDisableBriefings);
            groupBoxBriefings.Location = new Point(500, 372);
            groupBoxBriefings.Name = "groupBoxBriefings";
            groupBoxBriefings.Size = new Size(200, 100);
            groupBoxBriefings.TabIndex = 1180;
            groupBoxBriefings.TabStop = false;
            groupBoxBriefings.Text = "New Game Briefings";
            // 
            // buttonEnableBriefings
            // 
            buttonEnableBriefings.Location = new Point(17, 61);
            buttonEnableBriefings.Name = "buttonEnableBriefings";
            buttonEnableBriefings.Size = new Size(166, 23);
            buttonEnableBriefings.TabIndex = 1179;
            buttonEnableBriefings.Text = "(Re) Enable Briefings";
            buttonEnableBriefings.UseVisualStyleBackColor = true;
            buttonEnableBriefings.Click += buttonEnableBriefings_Click;
            // 
            // PatchForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(735, 487);
            Controls.Add(groupBoxBriefings);
            Controls.Add(groupBoxMap);
            Controls.Add(label3);
            Controls.Add(accurateGalaxyMapCheckBox);
            Controls.Add(compatibleGalaxyMapCheckBox);
            Controls.Add(label2);
            Controls.Add(patchTest);
            Controls.Add(unitsWithoutStatsCheckBox);
            Controls.Add(unitsWithStatsCheckBox);
            Controls.Add(label1);
            Controls.Add(label1Requirement);
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
            MinimumSize = new Size(751, 317);
            Name = "PatchForm";
            Text = "Patch";
            FormClosing += GameObjectsListForm_FormClosing;
            Load += GameObjectsListForm_Load;
            KeyDown += GameObjectsListForm_KeyDown;
            groupBoxMap.ResumeLayout(false);
            groupBoxMap.PerformLayout();
            groupBoxBriefings.ResumeLayout(false);
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
        private Label label1Requirement;
        private Label label1;
        private CheckBox unitsWithStatsCheckBox;
        private CheckBox unitsWithoutStatsCheckBox;
        private Button patchTest;
        private Label label2;
        private CheckBox compatibleGalaxyMapCheckBox;
        private CheckBox accurateGalaxyMapCheckBox;
        private Label label3;
        private Button buttonSwitchToCompatible;
        private Label label4;
        private Label label5;
        private Button buttonSwitchToAccurate;
        private Button buttonDisableBriefings;
        private GroupBox groupBoxMap;
        private GroupBox groupBoxBriefings;
        private Button buttonEnableBriefings;
    }
}