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
        private IContainer components = null;
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(AboutForm));
            tableLayoutPanel = new TableLayoutPanel();
            Product_Label = new Label();
            Version_Label = new Label();
            Copyright_Label = new Label();
            Company_Label = new Label();
            Description_TextBox = new TextBox();
            OK_Button = new Button();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.BackgroundImage = Resources.c3po_400x200_bmp;
            tableLayoutPanel.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 373F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 700F));
            tableLayoutPanel.Controls.Add(Product_Label, 1, 1);
            tableLayoutPanel.Controls.Add(Version_Label, 1, 2);
            tableLayoutPanel.Controls.Add(Copyright_Label, 1, 3);
            tableLayoutPanel.Controls.Add(Company_Label, 1, 4);
            tableLayoutPanel.Controls.Add(Description_TextBox, 1, 5);
            tableLayoutPanel.Controls.Add(OK_Button, 1, 6);
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 7;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 55.55556F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel.Size = new Size(905, 404);
            tableLayoutPanel.TabIndex = 0;
            // 
            // Product_Label
            // 
            Product_Label.BackColor = SystemColors.WindowText;
            Product_Label.Dock = DockStyle.Fill;
            Product_Label.ForeColor = Color.Lime;
            Product_Label.Location = new Point(42, 63);
            Product_Label.Margin = new Padding(7, 0, 4, 0);
            Product_Label.MaximumSize = new Size(0, 20);
            Product_Label.Name = "Product_Label";
            Product_Label.Size = new Size(362, 20);
            Product_Label.TabIndex = 0;
            Product_Label.Text = "Product";
            Product_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Version_Label
            // 
            Version_Label.BackColor = SystemColors.WindowText;
            Version_Label.Dock = DockStyle.Fill;
            Version_Label.ForeColor = Color.Lime;
            Version_Label.Location = new Point(42, 91);
            Version_Label.Margin = new Padding(7, 0, 4, 0);
            Version_Label.MaximumSize = new Size(0, 20);
            Version_Label.Name = "Version_Label";
            Version_Label.Size = new Size(362, 20);
            Version_Label.TabIndex = 0;
            Version_Label.Text = "Version";
            Version_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Copyright_Label
            // 
            Copyright_Label.Dock = DockStyle.Fill;
            Copyright_Label.ForeColor = Color.Lime;
            Copyright_Label.Location = new Point(42, 119);
            Copyright_Label.Margin = new Padding(7, 0, 4, 0);
            Copyright_Label.MaximumSize = new Size(0, 20);
            Copyright_Label.Name = "Copyright_Label";
            Copyright_Label.Size = new Size(362, 20);
            Copyright_Label.TabIndex = 0;
            Copyright_Label.Text = "Copyright";
            Copyright_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Company_Label
            // 
            Company_Label.Dock = DockStyle.Fill;
            Company_Label.ForeColor = Color.Lime;
            Company_Label.Location = new Point(42, 147);
            Company_Label.Margin = new Padding(7, 0, 4, 0);
            Company_Label.MaximumSize = new Size(0, 20);
            Company_Label.Name = "Company_Label";
            Company_Label.Size = new Size(362, 20);
            Company_Label.TabIndex = 0;
            Company_Label.Text = "Company";
            Company_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Description_TextBox
            // 
            Description_TextBox.BackColor = SystemColors.WindowFrame;
            Description_TextBox.BorderStyle = BorderStyle.None;
            Description_TextBox.Dock = DockStyle.Fill;
            Description_TextBox.ForeColor = Color.Lime;
            Description_TextBox.Location = new Point(42, 178);
            Description_TextBox.Margin = new Padding(7, 3, 4, 3);
            Description_TextBox.Multiline = true;
            Description_TextBox.Name = "Description_TextBox";
            Description_TextBox.ReadOnly = true;
            Description_TextBox.Size = new Size(362, 138);
            Description_TextBox.TabIndex = 0;
            Description_TextBox.TabStop = false;
            Description_TextBox.Text = "Description";
            // 
            // OK_Button
            // 
            OK_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OK_Button.DialogResult = DialogResult.Cancel;
            OK_Button.FlatAppearance.BorderSize = 2;
            OK_Button.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            OK_Button.Location = new Point(39, 374);
            OK_Button.Margin = new Padding(4, 3, 4, 3);
            OK_Button.Name = "OK_Button";
            OK_Button.Size = new Size(88, 27);
            OK_Button.TabIndex = 1;
            OK_Button.Text = "&OK";
            OK_Button.Click += OK_Button_Click;
            // 
            // AboutForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(903, 402);
            Controls.Add(tableLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            Padding = new Padding(10);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "About Star Wars Rebellion Editor .NET";
            FormClosing += AboutForm_FormClosing;
            Load += AboutForm_Load;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}