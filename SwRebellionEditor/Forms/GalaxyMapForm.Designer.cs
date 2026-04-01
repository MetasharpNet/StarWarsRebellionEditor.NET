using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class GalaxyMapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button Cancel;
        private Button Ok;
        private SaveFileDialog saveFileDialog;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(GalaxyMapForm));
            Cancel = new Button();
            Ok = new Button();
            saveFileDialog = new SaveFileDialog();
            galaxyMap = new PictureBox();
            sectorXLabel = new Label();
            sectorYLabel = new Label();
            sectorY = new Label();
            sectorX = new Label();
            sectorMap = new PictureBox();
            sectorLabel = new Label();
            sectorName = new Label();
            systemName = new Label();
            systemLabel = new Label();
            systemY = new Label();
            systemX = new Label();
            systemYLabel = new Label();
            systemXLabel = new Label();
            systemInfo1Label = new Label();
            systemInfo2Label = new Label();
            systemInfo3Label = new Label();
            ((ISupportInitialize)galaxyMap).BeginInit();
            ((ISupportInitialize)sectorMap).BeginInit();
            SuspendLayout();
            // 
            // Cancel
            // 
            Cancel.DialogResult = DialogResult.Cancel;
            Cancel.Location = new Point(112, 803);
            Cancel.Margin = new Padding(4, 3, 4, 3);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(88, 27);
            Cancel.TabIndex = 20;
            Cancel.Text = "&Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Ok
            // 
            Ok.Location = new Point(13, 803);
            Ok.Margin = new Padding(4, 3, 4, 3);
            Ok.Name = "Ok";
            Ok.Size = new Size(88, 27);
            Ok.TabIndex = 19;
            Ok.Text = "&Ok";
            Ok.UseVisualStyleBackColor = true;
            Ok.Click += Ok_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "DAT";
            saveFileDialog.Filter = "Data files|*.dat";
            // 
            // galaxyMap
            // 
            galaxyMap.BackColor = Color.Black;
            galaxyMap.Image = Resources.galaxy_768x788_bmp;
            galaxyMap.Location = new Point(3, 9);
            galaxyMap.Margin = new Padding(0);
            galaxyMap.Name = "galaxyMap";
            galaxyMap.Size = new Size(768, 788);
            galaxyMap.SizeMode = PictureBoxSizeMode.Zoom;
            galaxyMap.TabIndex = 23;
            galaxyMap.TabStop = false;
            // 
            // sectorXLabel
            // 
            sectorXLabel.AutoSize = true;
            sectorXLabel.Location = new Point(804, 62);
            sectorXLabel.Name = "sectorXLabel";
            sectorXLabel.Size = new Size(22, 15);
            sectorXLabel.TabIndex = 25;
            sectorXLabel.Text = "X=";
            // 
            // sectorYLabel
            // 
            sectorYLabel.AutoSize = true;
            sectorYLabel.Location = new Point(804, 91);
            sectorYLabel.Name = "sectorYLabel";
            sectorYLabel.Size = new Size(22, 15);
            sectorYLabel.TabIndex = 26;
            sectorYLabel.Text = "Y=";
            // 
            // sectorY
            // 
            sectorY.AutoSize = true;
            sectorY.Location = new Point(844, 91);
            sectorY.Name = "sectorY";
            sectorY.Size = new Size(12, 15);
            sectorY.TabIndex = 28;
            sectorY.Text = "-";
            // 
            // sectorX
            // 
            sectorX.AutoSize = true;
            sectorX.Location = new Point(844, 62);
            sectorX.Name = "sectorX";
            sectorX.Size = new Size(12, 15);
            sectorX.TabIndex = 27;
            sectorX.Text = "-";
            // 
            // sectorMap
            // 
            sectorMap.BackColor = Color.Black;
            sectorMap.Image = Resources.sector_79x102_bmp;
            sectorMap.Location = new Point(785, 133);
            sectorMap.Name = "sectorMap";
            sectorMap.Size = new Size(79, 102);
            sectorMap.SizeMode = PictureBoxSizeMode.Zoom;
            sectorMap.TabIndex = 29;
            sectorMap.TabStop = false;
            // 
            // sectorLabel
            // 
            sectorLabel.AutoSize = true;
            sectorLabel.Location = new Point(785, 34);
            sectorLabel.Name = "sectorLabel";
            sectorLabel.Size = new Size(40, 15);
            sectorLabel.TabIndex = 30;
            sectorLabel.Text = "Sector";
            // 
            // sectorName
            // 
            sectorName.AutoSize = true;
            sectorName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            sectorName.Location = new Point(841, 34);
            sectorName.Name = "sectorName";
            sectorName.Size = new Size(40, 15);
            sectorName.TabIndex = 31;
            sectorName.Text = "Name";
            // 
            // systemName
            // 
            systemName.AutoSize = true;
            systemName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            systemName.Location = new Point(844, 338);
            systemName.Name = "systemName";
            systemName.Size = new Size(40, 15);
            systemName.TabIndex = 37;
            systemName.Text = "Name";
            // 
            // systemLabel
            // 
            systemLabel.AutoSize = true;
            systemLabel.Location = new Point(785, 338);
            systemLabel.Name = "systemLabel";
            systemLabel.Size = new Size(45, 15);
            systemLabel.TabIndex = 36;
            systemLabel.Text = "System";
            // 
            // systemY
            // 
            systemY.AutoSize = true;
            systemY.Location = new Point(848, 386);
            systemY.Name = "systemY";
            systemY.Size = new Size(12, 15);
            systemY.TabIndex = 35;
            systemY.Text = "-";
            // 
            // systemX
            // 
            systemX.AutoSize = true;
            systemX.Location = new Point(848, 362);
            systemX.Name = "systemX";
            systemX.Size = new Size(12, 15);
            systemX.TabIndex = 34;
            systemX.Text = "-";
            // 
            // systemYLabel
            // 
            systemYLabel.AutoSize = true;
            systemYLabel.Location = new Point(804, 386);
            systemYLabel.Name = "systemYLabel";
            systemYLabel.Size = new Size(22, 15);
            systemYLabel.TabIndex = 33;
            systemYLabel.Text = "Y=";
            // 
            // systemXLabel
            // 
            systemXLabel.AutoSize = true;
            systemXLabel.Location = new Point(804, 362);
            systemXLabel.Name = "systemXLabel";
            systemXLabel.Size = new Size(22, 15);
            systemXLabel.TabIndex = 32;
            systemXLabel.Text = "X=";
            // 
            // systemInfo1Label
            // 
            systemInfo1Label.AutoSize = true;
            systemInfo1Label.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            systemInfo1Label.ForeColor = Color.Maroon;
            systemInfo1Label.Location = new Point(784, 258);
            systemInfo1Label.Name = "systemInfo1Label";
            systemInfo1Label.Size = new Size(127, 15);
            systemInfo1Label.TabIndex = 38;
            systemInfo1Label.Text = "System rectangle has 4";
            // 
            // systemInfo2Label
            // 
            systemInfo2Label.AutoSize = true;
            systemInfo2Label.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            systemInfo2Label.ForeColor = Color.Maroon;
            systemInfo2Label.Location = new Point(785, 280);
            systemInfo2Label.Name = "systemInfo2Label";
            systemInfo2Label.Size = new Size(133, 15);
            systemInfo2Label.TabIndex = 39;
            systemInfo2Label.Text = "pixels of X margin and 1";
            // 
            // systemInfo3Label
            // 
            systemInfo3Label.AutoSize = true;
            systemInfo3Label.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            systemInfo3Label.ForeColor = Color.Maroon;
            systemInfo3Label.Location = new Point(785, 303);
            systemInfo3Label.Name = "systemInfo3Label";
            systemInfo3Label.Size = new Size(132, 15);
            systemInfo3Label.TabIndex = 40;
            systemInfo3Label.Text = "pixel of Y margin inside.";
            // 
            // GalaxyMapForm
            // 
            AcceptButton = Ok;
            AutoScaleMode = AutoScaleMode.None;
            CancelButton = Cancel;
            ClientSize = new Size(985, 835);
            Controls.Add(systemInfo3Label);
            Controls.Add(systemInfo2Label);
            Controls.Add(systemInfo1Label);
            Controls.Add(systemName);
            Controls.Add(systemLabel);
            Controls.Add(systemY);
            Controls.Add(systemX);
            Controls.Add(systemYLabel);
            Controls.Add(systemXLabel);
            Controls.Add(sectorName);
            Controls.Add(sectorLabel);
            Controls.Add(sectorMap);
            Controls.Add(sectorY);
            Controls.Add(sectorX);
            Controls.Add(sectorYLabel);
            Controls.Add(sectorXLabel);
            Controls.Add(galaxyMap);
            Controls.Add(Cancel);
            Controls.Add(Ok);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "GalaxyMapForm";
            Text = "Galaxy Map";
            FormClosing += GameObjectsListForm_FormClosing;
            Load += GameObjectsListForm_Load;
            ((ISupportInitialize)galaxyMap).EndInit();
            ((ISupportInitialize)sectorMap).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private PictureBox galaxyMap;
        private Label sectorXLabel;
        private Label sectorYLabel;
        private Label sectorY;
        private Label sectorX;
        private PictureBox sectorMap;
        private Label sectorLabel;
        private Label sectorName;
        private Label systemName;
        private Label systemLabel;
        private Label systemY;
        private Label systemX;
        private Label systemYLabel;
        private Label systemXLabel;
        private Label systemInfo1Label;
        private Label systemInfo2Label;
        private Label systemInfo3Label;
    }
}
