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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalaxyMapForm));
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.galaxyMap = new System.Windows.Forms.PictureBox();
            this.sectorXLabel = new System.Windows.Forms.Label();
            this.sectorYLabel = new System.Windows.Forms.Label();
            this.sectorY = new System.Windows.Forms.Label();
            this.sectorX = new System.Windows.Forms.Label();
            this.sectorMap = new System.Windows.Forms.PictureBox();
            this.sectorLabel = new System.Windows.Forms.Label();
            this.sectorName = new System.Windows.Forms.Label();
            this.systemName = new System.Windows.Forms.Label();
            this.systemLabel = new System.Windows.Forms.Label();
            this.systemY = new System.Windows.Forms.Label();
            this.systemX = new System.Windows.Forms.Label();
            this.systemYLabel = new System.Windows.Forms.Label();
            this.systemXLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.galaxyMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorMap)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(107, 794);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 27);
            this.Cancel.TabIndex = 20;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(13, 794);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 19;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "DAT";
            this.saveFileDialog.Filter = "Data files|*.dat";
            // 
            // galaxyMap
            // 
            this.galaxyMap.BackColor = System.Drawing.Color.Black;
            this.galaxyMap.Image = global::SwRebellionEditor.Resources.galaxy_768x788_bmp;
            this.galaxyMap.Location = new System.Drawing.Point(3, 3);
            this.galaxyMap.Name = "galaxyMap";
            this.galaxyMap.Size = new System.Drawing.Size(768, 788);
            this.galaxyMap.TabIndex = 23;
            this.galaxyMap.TabStop = false;
            // 
            // sectorXLabel
            // 
            this.sectorXLabel.AutoSize = true;
            this.sectorXLabel.Location = new System.Drawing.Point(804, 58);
            this.sectorXLabel.Name = "sectorXLabel";
            this.sectorXLabel.Size = new System.Drawing.Size(22, 15);
            this.sectorXLabel.TabIndex = 25;
            this.sectorXLabel.Text = "X=";
            // 
            // sectorYLabel
            // 
            this.sectorYLabel.AutoSize = true;
            this.sectorYLabel.Location = new System.Drawing.Point(804, 82);
            this.sectorYLabel.Name = "sectorYLabel";
            this.sectorYLabel.Size = new System.Drawing.Size(22, 15);
            this.sectorYLabel.TabIndex = 26;
            this.sectorYLabel.Text = "Y=";
            // 
            // sectorY
            // 
            this.sectorY.AutoSize = true;
            this.sectorY.Location = new System.Drawing.Point(828, 82);
            this.sectorY.Name = "sectorY";
            this.sectorY.Size = new System.Drawing.Size(12, 15);
            this.sectorY.TabIndex = 28;
            this.sectorY.Text = "-";
            // 
            // sectorX
            // 
            this.sectorX.AutoSize = true;
            this.sectorX.Location = new System.Drawing.Point(828, 58);
            this.sectorX.Name = "sectorX";
            this.sectorX.Size = new System.Drawing.Size(12, 15);
            this.sectorX.TabIndex = 27;
            this.sectorX.Text = "-";
            // 
            // sectorMap
            // 
            this.sectorMap.BackColor = System.Drawing.Color.Black;
            this.sectorMap.Image = global::SwRebellionEditor.Resources.sector_79x102_bmp;
            this.sectorMap.Location = new System.Drawing.Point(785, 127);
            this.sectorMap.Name = "sectorMap";
            this.sectorMap.Size = new System.Drawing.Size(79, 102);
            this.sectorMap.TabIndex = 29;
            this.sectorMap.TabStop = false;
            // 
            // sectorLabel
            // 
            this.sectorLabel.AutoSize = true;
            this.sectorLabel.Location = new System.Drawing.Point(785, 34);
            this.sectorLabel.Name = "sectorLabel";
            this.sectorLabel.Size = new System.Drawing.Size(40, 15);
            this.sectorLabel.TabIndex = 30;
            this.sectorLabel.Text = "Sector";
            // 
            // sectorName
            // 
            this.sectorName.AutoSize = true;
            this.sectorName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sectorName.Location = new System.Drawing.Point(828, 34);
            this.sectorName.Name = "sectorName";
            this.sectorName.Size = new System.Drawing.Size(40, 15);
            this.sectorName.TabIndex = 31;
            this.sectorName.Text = "Name";
            // 
            // systemName
            // 
            this.systemName.AutoSize = true;
            this.systemName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.systemName.Location = new System.Drawing.Point(828, 261);
            this.systemName.Name = "systemName";
            this.systemName.Size = new System.Drawing.Size(40, 15);
            this.systemName.TabIndex = 37;
            this.systemName.Text = "Name";
            // 
            // systemLabel
            // 
            this.systemLabel.AutoSize = true;
            this.systemLabel.Location = new System.Drawing.Point(785, 261);
            this.systemLabel.Name = "systemLabel";
            this.systemLabel.Size = new System.Drawing.Size(45, 15);
            this.systemLabel.TabIndex = 36;
            this.systemLabel.Text = "System";
            // 
            // systemY
            // 
            this.systemY.AutoSize = true;
            this.systemY.Location = new System.Drawing.Point(828, 309);
            this.systemY.Name = "systemY";
            this.systemY.Size = new System.Drawing.Size(12, 15);
            this.systemY.TabIndex = 35;
            this.systemY.Text = "-";
            // 
            // systemX
            // 
            this.systemX.AutoSize = true;
            this.systemX.Location = new System.Drawing.Point(828, 285);
            this.systemX.Name = "systemX";
            this.systemX.Size = new System.Drawing.Size(12, 15);
            this.systemX.TabIndex = 34;
            this.systemX.Text = "-";
            // 
            // systemYLabel
            // 
            this.systemYLabel.AutoSize = true;
            this.systemYLabel.Location = new System.Drawing.Point(804, 309);
            this.systemYLabel.Name = "systemYLabel";
            this.systemYLabel.Size = new System.Drawing.Size(22, 15);
            this.systemYLabel.TabIndex = 33;
            this.systemYLabel.Text = "Y=";
            // 
            // systemXLabel
            // 
            this.systemXLabel.AutoSize = true;
            this.systemXLabel.Location = new System.Drawing.Point(804, 285);
            this.systemXLabel.Name = "systemXLabel";
            this.systemXLabel.Size = new System.Drawing.Size(22, 15);
            this.systemXLabel.TabIndex = 32;
            this.systemXLabel.Text = "X=";
            // 
            // GalaxyMapForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(940, 826);
            this.Controls.Add(this.systemName);
            this.Controls.Add(this.systemLabel);
            this.Controls.Add(this.systemY);
            this.Controls.Add(this.systemX);
            this.Controls.Add(this.systemYLabel);
            this.Controls.Add(this.systemXLabel);
            this.Controls.Add(this.sectorName);
            this.Controls.Add(this.sectorLabel);
            this.Controls.Add(this.sectorMap);
            this.Controls.Add(this.sectorY);
            this.Controls.Add(this.sectorX);
            this.Controls.Add(this.sectorYLabel);
            this.Controls.Add(this.sectorXLabel);
            this.Controls.Add(this.galaxyMap);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(956, 865);
            this.MinimumSize = new System.Drawing.Size(956, 865);
            this.Name = "GalaxyMapForm";
            this.Text = "Galaxy Map";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.galaxyMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
