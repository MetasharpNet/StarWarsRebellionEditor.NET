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
            this.background = new System.Windows.Forms.PictureBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
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
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Black;
            this.background.Image = global::SwRebellionEditor.Resources.galaxy_768x788_bmp;
            this.background.Location = new System.Drawing.Point(3, 3);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(768, 788);
            this.background.TabIndex = 23;
            this.background.TabStop = false;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(785, 31);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(22, 15);
            this.xLabel.TabIndex = 25;
            this.xLabel.Text = "X=";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(785, 55);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(22, 15);
            this.yLabel.TabIndex = 26;
            this.yLabel.Text = "Y=";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Location = new System.Drawing.Point(813, 55);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(12, 15);
            this.y.TabIndex = 28;
            this.y.Text = "-";
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(813, 31);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(12, 15);
            this.x.TabIndex = 27;
            this.x.Text = "-";
            // 
            // GalaxyMapForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(867, 826);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.background);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GalaxyMapForm";
            this.Text = "Galaxy Map";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox background;
        private Label xLabel;
        private Label yLabel;
        private Label y;
        private Label x;
    }
}
