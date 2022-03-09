using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel tableLayoutPanel;
        private Label Product_Label;
        private Label Version_Label;
        private Label Copyright_Label;
        private Label Company_Label;
        private TextBox Description_TextBox;
        private Button OK_Button;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Product_Label = new System.Windows.Forms.Label();
            this.Version_Label = new System.Windows.Forms.Label();
            this.Copyright_Label = new System.Windows.Forms.Label();
            this.Company_Label = new System.Windows.Forms.Label();
            this.Description_TextBox = new System.Windows.Forms.TextBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel.BackgroundImage = global::SwRebellionEditor.Resources.c3po_400x200_bmp;
            this.tableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 373F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 700F));
            this.tableLayoutPanel.Controls.Add(this.Product_Label, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.Version_Label, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.Copyright_Label, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.Company_Label, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.Description_TextBox, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.OK_Button, 1, 6);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(905, 404);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // Product_Label
            // 
            this.Product_Label.BackColor = System.Drawing.SystemColors.WindowText;
            this.Product_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Product_Label.ForeColor = System.Drawing.Color.Lime;
            this.Product_Label.Location = new System.Drawing.Point(42, 63);
            this.Product_Label.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.Product_Label.MaximumSize = new System.Drawing.Size(0, 20);
            this.Product_Label.Name = "Product_Label";
            this.Product_Label.Size = new System.Drawing.Size(362, 20);
            this.Product_Label.TabIndex = 0;
            this.Product_Label.Text = "Product";
            this.Product_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Version_Label
            // 
            this.Version_Label.BackColor = System.Drawing.SystemColors.WindowText;
            this.Version_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Version_Label.ForeColor = System.Drawing.Color.Lime;
            this.Version_Label.Location = new System.Drawing.Point(42, 91);
            this.Version_Label.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.Version_Label.MaximumSize = new System.Drawing.Size(0, 20);
            this.Version_Label.Name = "Version_Label";
            this.Version_Label.Size = new System.Drawing.Size(362, 20);
            this.Version_Label.TabIndex = 0;
            this.Version_Label.Text = "Version";
            this.Version_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Copyright_Label
            // 
            this.Copyright_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Copyright_Label.ForeColor = System.Drawing.Color.Lime;
            this.Copyright_Label.Location = new System.Drawing.Point(42, 119);
            this.Copyright_Label.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.Copyright_Label.MaximumSize = new System.Drawing.Size(0, 20);
            this.Copyright_Label.Name = "Copyright_Label";
            this.Copyright_Label.Size = new System.Drawing.Size(362, 20);
            this.Copyright_Label.TabIndex = 0;
            this.Copyright_Label.Text = "Copyright";
            this.Copyright_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Company_Label
            // 
            this.Company_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Company_Label.ForeColor = System.Drawing.Color.Lime;
            this.Company_Label.Location = new System.Drawing.Point(42, 147);
            this.Company_Label.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.Company_Label.MaximumSize = new System.Drawing.Size(0, 20);
            this.Company_Label.Name = "Company_Label";
            this.Company_Label.Size = new System.Drawing.Size(362, 20);
            this.Company_Label.TabIndex = 0;
            this.Company_Label.Text = "Company";
            this.Company_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Description_TextBox
            // 
            this.Description_TextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Description_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description_TextBox.ForeColor = System.Drawing.Color.Lime;
            this.Description_TextBox.Location = new System.Drawing.Point(42, 178);
            this.Description_TextBox.Margin = new System.Windows.Forms.Padding(7, 3, 4, 3);
            this.Description_TextBox.Multiline = true;
            this.Description_TextBox.Name = "Description_TextBox";
            this.Description_TextBox.ReadOnly = true;
            this.Description_TextBox.Size = new System.Drawing.Size(362, 138);
            this.Description_TextBox.TabIndex = 0;
            this.Description_TextBox.TabStop = false;
            this.Description_TextBox.Text = "Description";
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OK_Button.FlatAppearance.BorderSize = 2;
            this.OK_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OK_Button.Location = new System.Drawing.Point(39, 374);
            this.OK_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(88, 27);
            this.OK_Button.TabIndex = 1;
            this.OK_Button.Text = "&OK";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(903, 402);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "About Star Wars Rebellion Editor .NET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutForm_FormClosing);
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}