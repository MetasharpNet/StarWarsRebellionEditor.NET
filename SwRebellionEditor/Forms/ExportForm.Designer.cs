using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class ExportForm
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ExportForm));
            systemsImageList = new ImageList(components);
            cancel = new Button();
            export = new Button();
            titleLabel = new Label();
            contentLabel = new Label();
            line3Label = new Label();
            line1Label = new Label();
            line2Label = new Label();
            line4Label = new Label();
            line5Label = new Label();
            exportInfoLabel = new Label();
            label1 = new Label();
            label2 = new Label();
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
            // export
            // 
            export.Location = new Point(24, 246);
            export.Name = "export";
            export.Size = new Size(110, 23);
            export.TabIndex = 1155;
            export.Text = "Export Data";
            export.UseVisualStyleBackColor = true;
            export.Click += export_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(12, 14);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(202, 15);
            titleLabel.TabIndex = 1156;
            titleLabel.Text = "StarWars Rebellion - Data Exporter";
            // 
            // contentLabel
            // 
            contentLabel.AutoSize = true;
            contentLabel.Location = new Point(24, 38);
            contentLabel.Name = "contentLabel";
            contentLabel.Size = new Size(119, 15);
            contentLabel.TabIndex = 1157;
            contentLabel.Text = "Exported game data :";
            // 
            // line3Label
            // 
            line3Label.AutoSize = true;
            line3Label.Location = new Point(33, 103);
            line3Label.Name = "line3Label";
            line3Label.Size = new Size(188, 15);
            line3Label.TabIndex = 1158;
            line3Label.Text = "- Exported Folders: EDATA, MDATA";
            // 
            // line1Label
            // 
            line1Label.AutoSize = true;
            line1Label.Location = new Point(33, 59);
            line1Label.Name = "line1Label";
            line1Label.Size = new Size(261, 15);
            line1Label.TabIndex = 1159;
            line1Label.Text = "- Export all game resources into an export folder";
            // 
            // line2Label
            // 
            line2Label.AutoSize = true;
            line2Label.Location = new Point(33, 81);
            line2Label.Name = "line2Label";
            line2Label.Size = new Size(464, 15);
            line2Label.TabIndex = 1160;
            line2Label.Text = "- Each subfolder stands for a game folder or game file and contains exported resources";
            // 
            // line4Label
            // 
            line4Label.AutoSize = true;
            line4Label.Location = new Point(33, 125);
            line4Label.Name = "line4Label";
            line4Label.Size = new Size(648, 15);
            line4Label.TabIndex = 1161;
            line4Label.Text = "- Exported Files: ALSPRITE.DLL, COMMON.DLL, EMSPRITE.DLL, GOKRES.DLL, REBDLOG.DLL, STRATEGY.DLL, TACTICAL.DLL";
            // 
            // line5Label
            // 
            line5Label.AutoSize = true;
            line5Label.Location = new Point(33, 163);
            line5Label.Name = "line5Label";
            line5Label.Size = new Size(242, 15);
            line5Label.TabIndex = 1162;
            line5Label.Text = "- Resource exported: 301, 303, Bitmap, WAVE";
            // 
            // exportInfoLabel
            // 
            exportInfoLabel.AutoSize = true;
            exportInfoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            exportInfoLabel.Location = new Point(140, 250);
            exportInfoLabel.Name = "exportInfoLabel";
            exportInfoLabel.Size = new Size(434, 15);
            exportInfoLabel.TabIndex = 1164;
            exportInfoLabel.Text = "This window will freeze for a few minutes then close when the export is completed.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 144);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 1165;
            label1.Text = "VOICEFXA.DLL, VOICEFXE.DLL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 183);
            label2.Name = "label2";
            label2.Size = new Size(516, 15);
            label2.TabIndex = 1166;
            label2.Text = "- Exported Data (US ANSI .csv files split with ';') : Sectors, Systems, Characters, Ships and Facilities";
            // 
            // ExportForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(735, 278);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exportInfoLabel);
            Controls.Add(line5Label);
            Controls.Add(line4Label);
            Controls.Add(line2Label);
            Controls.Add(line1Label);
            Controls.Add(line3Label);
            Controls.Add(contentLabel);
            Controls.Add(titleLabel);
            Controls.Add(export);
            Controls.Add(cancel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(751, 317);
            MinimumSize = new Size(751, 317);
            Name = "ExportForm";
            Text = "Export";
            FormClosing += GameObjectsListForm_FormClosing;
            Load += GameObjectsListForm_Load;
            KeyDown += GameObjectsListForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cancel;
        private Button export;
        private Label titleLabel;
        private Label contentLabel;
        private Label line3Label;
        private Label line1Label;
        private Label line2Label;
        private Label line4Label;
        private Label line5Label;
        private Label exportInfoLabel;
        private Label label1;
        private Label label2;
    }
}