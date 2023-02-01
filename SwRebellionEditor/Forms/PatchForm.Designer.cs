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
        private System.ComponentModel.IContainer components = null;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatchForm));
            this.systemsImageList = new System.Windows.Forms.ImageList(this.components);
            this.cancel = new System.Windows.Forms.Button();
            this.patch = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentLabel = new System.Windows.Forms.Label();
            this.line3Label = new System.Windows.Forms.Label();
            this.line1Label = new System.Windows.Forms.Label();
            this.line2Label = new System.Windows.Forms.Label();
            this.line4Label = new System.Windows.Forms.Label();
            this.line5Label = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.patchInfoLabel = new System.Windows.Forms.Label();
            this.binPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.binPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // systemsImageList
            // 
            this.systemsImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.systemsImageList.ImageSize = new System.Drawing.Size(120, 60);
            this.systemsImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(358, 211);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 1154;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // patch
            // 
            this.patch.Location = new System.Drawing.Point(24, 211);
            this.patch.Name = "patch";
            this.patch.Size = new System.Drawing.Size(110, 23);
            this.patch.TabIndex = 1155;
            this.patch.Text = "Patch my game";
            this.patch.UseVisualStyleBackColor = true;
            this.patch.Click += new System.EventHandler(this.patch_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(12, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(239, 15);
            this.titleLabel.TabIndex = 1156;
            this.titleLabel.Text = "StarWars Rebellion 25th Anniversary Mod";
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(24, 38);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(56, 15);
            this.contentLabel.TabIndex = 1157;
            this.contentLabel.Text = "Content :";
            // 
            // line3Label
            // 
            this.line3Label.AutoSize = true;
            this.line3Label.Location = new System.Drawing.Point(33, 103);
            this.line3Label.Name = "line3Label";
            this.line3Label.Size = new System.Drawing.Size(384, 15);
            this.line3Label.TabIndex = 1158;
            this.line3Label.Text = "- Newly imagined Sector names (to match the 20 groups of 10 Systems)";
            // 
            // line1Label
            // 
            this.line1Label.AutoSize = true;
            this.line1Label.Location = new System.Drawing.Point(33, 59);
            this.line1Label.Name = "line1Label";
            this.line1Label.Size = new System.Drawing.Size(686, 15);
            this.line1Label.TabIndex = 1159;
            this.line1Label.Text = "- Revised Top 200 systems from Star Wars franchise based on many aspects (movies," +
    " tv series, games, atlas, hyperspace routes, ...)";
            // 
            // line2Label
            // 
            this.line2Label.AutoSize = true;
            this.line2Label.Location = new System.Drawing.Point(33, 81);
            this.line2Label.Name = "line2Label";
            this.line2Label.Size = new System.Drawing.Size(607, 15);
            this.line2Label.TabIndex = 1160;
            this.line2Label.Text = "- Accurate positionning of Systems and Sectors (through barycenters computation, " +
    "then proportional projections)";
            // 
            // line4Label
            // 
            this.line4Label.AutoSize = true;
            this.line4Label.Location = new System.Drawing.Point(33, 125);
            this.line4Label.Name = "line4Label";
            this.line4Label.Size = new System.Drawing.Size(623, 15);
            this.line4Label.TabIndex = 1161;
            this.line4Label.Text = "- Rebexe.exe patch to enable having 200+ Systems sprites and Encyclopedia picture" +
    "s (no more hardcoded limit of 26)";
            // 
            // line5Label
            // 
            this.line5Label.AutoSize = true;
            this.line5Label.Location = new System.Drawing.Point(33, 147);
            this.line5Label.Name = "line5Label";
            this.line5Label.Size = new System.Drawing.Size(268, 15);
            this.line5Label.TabIndex = 1162;
            this.line5Label.Text = "- Unique sprites and pictures for ALL 200 systems!";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(24, 177);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(680, 15);
            this.warningLabel.TabIndex = 1163;
            this.warningLabel.Text = "This patch is currently a work in progress and provided without any warranty of a" +
    "ny kind. Doesn\'t work with existing savegames.";
            // 
            // patchInfoLabel
            // 
            this.patchInfoLabel.AutoSize = true;
            this.patchInfoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.patchInfoLabel.Location = new System.Drawing.Point(140, 215);
            this.patchInfoLabel.Name = "patchInfoLabel";
            this.patchInfoLabel.Size = new System.Drawing.Size(185, 15);
            this.patchInfoLabel.TabIndex = 1164;
            this.patchInfoLabel.Text = "This window will close when done.";
            // 
            // binPicture
            // 
            this.binPicture.Location = new System.Drawing.Point(467, 5);
            this.binPicture.Name = "binPicture";
            this.binPicture.Size = new System.Drawing.Size(256, 256);
            this.binPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.binPicture.TabIndex = 1165;
            this.binPicture.TabStop = false;
            // 
            // PatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 273);
            this.Controls.Add(this.binPicture);
            this.Controls.Add(this.patchInfoLabel);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.line5Label);
            this.Controls.Add(this.line4Label);
            this.Controls.Add(this.line2Label);
            this.Controls.Add(this.line1Label);
            this.Controls.Add(this.line3Label);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.patch);
            this.Controls.Add(this.cancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(751, 284);
            this.Name = "PatchForm";
            this.Text = "Patch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.binPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private PictureBox binPicture;
    }
}