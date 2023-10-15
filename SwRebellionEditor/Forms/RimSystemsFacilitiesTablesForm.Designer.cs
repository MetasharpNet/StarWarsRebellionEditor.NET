using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class RimSystemsFacilitiesTablesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;
        private Button openNew;
        private Button SaveAs;
        private Button Ok;
        private SaveFileDialog saveFileDialog;
        private Button Cancel;
        private Label troopName;
        private Label idLabel;
        private Label label1;
        private NumericUpDown facilityType0;
        private Label label2;
        private ComboBox facilityBox0;
        private ComboBox facilityBox1;
        private NumericUpDown facilityType1;
        private NumericUpDown facilityPercent1;
        private ComboBox facilityBox2;
        private NumericUpDown facilityType2;
        private NumericUpDown facilityPercent2;
        private ComboBox facilityBox3;
        private NumericUpDown facilityType3;
        private NumericUpDown facilityPercent3;
        private ComboBox facilityBox4;
        private NumericUpDown facilityType4;
        private NumericUpDown facilityPercent4;
        private ComboBox facilityBox5;
        private NumericUpDown facilityType5;
        private NumericUpDown facilityPercent5;
        private ComboBox facilityBox6;
        private NumericUpDown facilityType6;
        private NumericUpDown facilityPercent6;
        private NumericUpDown facilityPercent0;

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
            openNew = new Button();
            SaveAs = new Button();
            Ok = new Button();
            saveFileDialog = new SaveFileDialog();
            Cancel = new Button();
            troopName = new Label();
            idLabel = new Label();
            label1 = new Label();
            facilityType0 = new NumericUpDown();
            label2 = new Label();
            facilityBox0 = new ComboBox();
            facilityBox1 = new ComboBox();
            facilityType1 = new NumericUpDown();
            facilityPercent1 = new NumericUpDown();
            facilityBox2 = new ComboBox();
            facilityType2 = new NumericUpDown();
            facilityPercent2 = new NumericUpDown();
            facilityBox3 = new ComboBox();
            facilityType3 = new NumericUpDown();
            facilityPercent3 = new NumericUpDown();
            facilityBox4 = new ComboBox();
            facilityType4 = new NumericUpDown();
            facilityPercent4 = new NumericUpDown();
            facilityBox5 = new ComboBox();
            facilityType5 = new NumericUpDown();
            facilityPercent5 = new NumericUpDown();
            facilityBox6 = new ComboBox();
            facilityType6 = new NumericUpDown();
            facilityPercent6 = new NumericUpDown();
            facilityPercent0 = new NumericUpDown();
            ((ISupportInitialize)facilityType0).BeginInit();
            ((ISupportInitialize)facilityType1).BeginInit();
            ((ISupportInitialize)facilityPercent1).BeginInit();
            ((ISupportInitialize)facilityType2).BeginInit();
            ((ISupportInitialize)facilityPercent2).BeginInit();
            ((ISupportInitialize)facilityType3).BeginInit();
            ((ISupportInitialize)facilityPercent3).BeginInit();
            ((ISupportInitialize)facilityType4).BeginInit();
            ((ISupportInitialize)facilityPercent4).BeginInit();
            ((ISupportInitialize)facilityType5).BeginInit();
            ((ISupportInitialize)facilityPercent5).BeginInit();
            ((ISupportInitialize)facilityType6).BeginInit();
            ((ISupportInitialize)facilityPercent6).BeginInit();
            ((ISupportInitialize)facilityPercent0).BeginInit();
            SuspendLayout();
            // 
            // openNew
            // 
            openNew.Location = new Point(314, 309);
            openNew.Margin = new Padding(4, 3, 4, 3);
            openNew.Name = "openNew";
            openNew.Size = new Size(88, 27);
            openNew.TabIndex = 26;
            openNew.Text = "Open...";
            openNew.UseVisualStyleBackColor = true;
            openNew.Click += Open_Click;
            // 
            // SaveAs
            // 
            SaveAs.Location = new Point(219, 309);
            SaveAs.Margin = new Padding(4, 3, 4, 3);
            SaveAs.Name = "SaveAs";
            SaveAs.Size = new Size(88, 27);
            SaveAs.TabIndex = 25;
            SaveAs.Text = "&SaveAs...";
            SaveAs.UseVisualStyleBackColor = true;
            SaveAs.Click += SaveAs_Click;
            // 
            // Ok
            // 
            Ok.Location = new Point(10, 309);
            Ok.Margin = new Padding(4, 3, 4, 3);
            Ok.Name = "Ok";
            Ok.Size = new Size(88, 27);
            Ok.TabIndex = 23;
            Ok.Text = "&Ok";
            Ok.UseVisualStyleBackColor = true;
            Ok.Click += Ok_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "DAT";
            saveFileDialog.Filter = "Data files|*.dat";
            // 
            // Cancel
            // 
            Cancel.DialogResult = DialogResult.Cancel;
            Cancel.Location = new Point(105, 309);
            Cancel.Margin = new Padding(4, 3, 4, 3);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(88, 27);
            Cancel.TabIndex = 24;
            Cancel.Text = "&Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // troopName
            // 
            troopName.AutoSize = true;
            troopName.Location = new Point(282, 76);
            troopName.Margin = new Padding(4, 0, 4, 0);
            troopName.Name = "troopName";
            troopName.Size = new Size(0, 15);
            troopName.TabIndex = 22;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Enabled = false;
            idLabel.Location = new Point(216, 22);
            idLabel.Margin = new Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(47, 15);
            idLabel.TabIndex = 28;
            idLabel.Text = "Percent";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(310, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 30;
            label1.Text = "Facility Type";
            // 
            // facilityType0
            // 
            facilityType0.Location = new Point(314, 40);
            facilityType0.Margin = new Padding(4, 3, 4, 3);
            facilityType0.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            facilityType0.Name = "facilityType0";
            facilityType0.Size = new Size(59, 23);
            facilityType0.TabIndex = 29;
            facilityType0.TabStop = false;
            facilityType0.Value = new decimal(new int[] { 255, 0, 0, 0 });
            facilityType0.ValueChanged += facilityType0_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new Point(10, 22);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 32;
            label2.Text = "Facility";
            // 
            // facilityBox0
            // 
            facilityBox0.DropDownStyle = ComboBoxStyle.DropDownList;
            facilityBox0.FormattingEnabled = true;
            facilityBox0.Items.AddRange(new object[] { "Refinery", "Shipyard", "Training", "Construction", "Shield", "Laser", "Ion", "Advanced Shipyard", "Advanced Troop Training", "Advanced Construction", "Shield Generator Type II", "Laser Type II" });
            facilityBox0.Location = new Point(14, 39);
            facilityBox0.Margin = new Padding(4, 3, 4, 3);
            facilityBox0.Name = "facilityBox0";
            facilityBox0.Size = new Size(178, 23);
            facilityBox0.TabIndex = 33;
            facilityBox0.SelectionChangeCommitted += facilityBox0_SelectionChangeCommitted;
            // 
            // facilityBox1
            // 
            facilityBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            facilityBox1.FormattingEnabled = true;
            facilityBox1.Items.AddRange(new object[] { "Refinery", "Shipyard", "Training", "Construction", "Shield", "Laser", "Ion", "Advanced Shipyard", "Advanced Troop Training", "Advanced Construction", "Shield Generator Type II", "Laser Type II" });
            facilityBox1.Location = new Point(14, 70);
            facilityBox1.Margin = new Padding(4, 3, 4, 3);
            facilityBox1.Name = "facilityBox1";
            facilityBox1.Size = new Size(178, 23);
            facilityBox1.TabIndex = 36;
            facilityBox1.SelectionChangeCommitted += facilityBox1_SelectionChangeCommitted;
            // 
            // facilityType1
            // 
            facilityType1.Location = new Point(314, 72);
            facilityType1.Margin = new Padding(4, 3, 4, 3);
            facilityType1.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            facilityType1.Name = "facilityType1";
            facilityType1.Size = new Size(59, 23);
            facilityType1.TabIndex = 35;
            facilityType1.TabStop = false;
            facilityType1.Value = new decimal(new int[] { 255, 0, 0, 0 });
            facilityType1.ValueChanged += facilityType1_ValueChanged;
            // 
            // facilityPercent1
            // 
            facilityPercent1.Location = new Point(219, 72);
            facilityPercent1.Margin = new Padding(4, 3, 4, 3);
            facilityPercent1.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            facilityPercent1.Name = "facilityPercent1";
            facilityPercent1.Size = new Size(59, 23);
            facilityPercent1.TabIndex = 34;
            facilityPercent1.TabStop = false;
            facilityPercent1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            facilityPercent1.ValueChanged += facilityPercent1_ValueChanged;
            // 
            // facilityBox2
            // 
            facilityBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            facilityBox2.FormattingEnabled = true;
            facilityBox2.Items.AddRange(new object[] { "Refinery", "Shipyard", "Training", "Construction", "Shield", "Laser", "Ion", "Advanced Shipyard", "Advanced Troop Training", "Advanced Construction", "Shield Generator Type II", "Laser Type II" });
            facilityBox2.Location = new Point(14, 102);
            facilityBox2.Margin = new Padding(4, 3, 4, 3);
            facilityBox2.Name = "facilityBox2";
            facilityBox2.Size = new Size(178, 23);
            facilityBox2.TabIndex = 39;
            facilityBox2.SelectionChangeCommitted += facilityBox2_SelectionChangeCommitted;
            // 
            // facilityType2
            // 
            facilityType2.Location = new Point(314, 103);
            facilityType2.Margin = new Padding(4, 3, 4, 3);
            facilityType2.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            facilityType2.Name = "facilityType2";
            facilityType2.Size = new Size(59, 23);
            facilityType2.TabIndex = 38;
            facilityType2.TabStop = false;
            facilityType2.Value = new decimal(new int[] { 255, 0, 0, 0 });
            facilityType2.ValueChanged += facilityType2_ValueChanged;
            // 
            // facilityPercent2
            // 
            facilityPercent2.Location = new Point(219, 103);
            facilityPercent2.Margin = new Padding(4, 3, 4, 3);
            facilityPercent2.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            facilityPercent2.Name = "facilityPercent2";
            facilityPercent2.Size = new Size(59, 23);
            facilityPercent2.TabIndex = 37;
            facilityPercent2.TabStop = false;
            facilityPercent2.Value = new decimal(new int[] { 100, 0, 0, 0 });
            facilityPercent2.ValueChanged += facilityPercent2_ValueChanged;
            // 
            // facilityBox3
            // 
            facilityBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            facilityBox3.FormattingEnabled = true;
            facilityBox3.Items.AddRange(new object[] { "Refinery", "Shipyard", "Training", "Construction", "Shield", "Laser", "Ion", "Advanced Shipyard", "Advanced Troop Training", "Advanced Construction", "Shield Generator II", "Laser II" });
            facilityBox3.Location = new Point(14, 133);
            facilityBox3.Margin = new Padding(4, 3, 4, 3);
            facilityBox3.Name = "facilityBox3";
            facilityBox3.Size = new Size(178, 23);
            facilityBox3.TabIndex = 42;
            facilityBox3.SelectionChangeCommitted += facilityBox3_SelectionChangeCommitted;
            // 
            // facilityType3
            // 
            facilityType3.Location = new Point(314, 134);
            facilityType3.Margin = new Padding(4, 3, 4, 3);
            facilityType3.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            facilityType3.Name = "facilityType3";
            facilityType3.Size = new Size(59, 23);
            facilityType3.TabIndex = 41;
            facilityType3.TabStop = false;
            facilityType3.Value = new decimal(new int[] { 255, 0, 0, 0 });
            facilityType3.ValueChanged += facilityType3_ValueChanged;
            // 
            // facilityPercent3
            // 
            facilityPercent3.Location = new Point(219, 134);
            facilityPercent3.Margin = new Padding(4, 3, 4, 3);
            facilityPercent3.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            facilityPercent3.Name = "facilityPercent3";
            facilityPercent3.Size = new Size(59, 23);
            facilityPercent3.TabIndex = 40;
            facilityPercent3.TabStop = false;
            facilityPercent3.Value = new decimal(new int[] { 100, 0, 0, 0 });
            facilityPercent3.ValueChanged += facilityPercent3_ValueChanged;
            // 
            // facilityBox4
            // 
            facilityBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            facilityBox4.FormattingEnabled = true;
            facilityBox4.Items.AddRange(new object[] { "Refinery", "Shipyard", "Training", "Construction", "Shield", "Laser", "Ion", "Advanced Shipyard", "Advanced Troop Training", "Advanced Construction", "Shield Generator Type II", "Laser Type II" });
            facilityBox4.Location = new Point(14, 164);
            facilityBox4.Margin = new Padding(4, 3, 4, 3);
            facilityBox4.Name = "facilityBox4";
            facilityBox4.Size = new Size(178, 23);
            facilityBox4.TabIndex = 45;
            facilityBox4.SelectionChangeCommitted += facilityBox4_SelectionChangeCommitted;
            // 
            // facilityType4
            // 
            facilityType4.Location = new Point(314, 165);
            facilityType4.Margin = new Padding(4, 3, 4, 3);
            facilityType4.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            facilityType4.Name = "facilityType4";
            facilityType4.Size = new Size(59, 23);
            facilityType4.TabIndex = 44;
            facilityType4.TabStop = false;
            facilityType4.Value = new decimal(new int[] { 255, 0, 0, 0 });
            facilityType4.ValueChanged += facilityType4_ValueChanged;
            // 
            // facilityPercent4
            // 
            facilityPercent4.Location = new Point(219, 165);
            facilityPercent4.Margin = new Padding(4, 3, 4, 3);
            facilityPercent4.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            facilityPercent4.Name = "facilityPercent4";
            facilityPercent4.Size = new Size(59, 23);
            facilityPercent4.TabIndex = 43;
            facilityPercent4.TabStop = false;
            facilityPercent4.Value = new decimal(new int[] { 100, 0, 0, 0 });
            facilityPercent4.ValueChanged += facilityPercent4_ValueChanged;
            // 
            // facilityBox5
            // 
            facilityBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            facilityBox5.FormattingEnabled = true;
            facilityBox5.Items.AddRange(new object[] { "Refinery", "Shipyard", "Training", "Construction", "Shield", "Laser", "Ion", "Advanced Shipyard", "Advanced Troop Training", "Advanced Construction", "Shield Generator Type II", "Laser Type II" });
            facilityBox5.Location = new Point(14, 195);
            facilityBox5.Margin = new Padding(4, 3, 4, 3);
            facilityBox5.Name = "facilityBox5";
            facilityBox5.Size = new Size(178, 23);
            facilityBox5.TabIndex = 48;
            facilityBox5.SelectionChangeCommitted += facilityBox5_SelectionChangeCommitted;
            // 
            // facilityType5
            // 
            facilityType5.Location = new Point(314, 196);
            facilityType5.Margin = new Padding(4, 3, 4, 3);
            facilityType5.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            facilityType5.Name = "facilityType5";
            facilityType5.Size = new Size(59, 23);
            facilityType5.TabIndex = 47;
            facilityType5.TabStop = false;
            facilityType5.Value = new decimal(new int[] { 255, 0, 0, 0 });
            facilityType5.ValueChanged += facilityType5_ValueChanged;
            // 
            // facilityPercent5
            // 
            facilityPercent5.Location = new Point(219, 196);
            facilityPercent5.Margin = new Padding(4, 3, 4, 3);
            facilityPercent5.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            facilityPercent5.Name = "facilityPercent5";
            facilityPercent5.Size = new Size(59, 23);
            facilityPercent5.TabIndex = 46;
            facilityPercent5.TabStop = false;
            facilityPercent5.Value = new decimal(new int[] { 100, 0, 0, 0 });
            facilityPercent5.ValueChanged += facilityPercent5_ValueChanged;
            // 
            // facilityBox6
            // 
            facilityBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            facilityBox6.FormattingEnabled = true;
            facilityBox6.Items.AddRange(new object[] { "Refinery", "Shipyard", "Training", "Construction", "Shield", "Laser", "Ion", "Advanced Shipyard", "Advanced Troop Training", "Advanced Construction", "Shield Generator Type II", "Laser Type II" });
            facilityBox6.Location = new Point(14, 226);
            facilityBox6.Margin = new Padding(4, 3, 4, 3);
            facilityBox6.Name = "facilityBox6";
            facilityBox6.Size = new Size(178, 23);
            facilityBox6.TabIndex = 51;
            facilityBox6.SelectionChangeCommitted += facilityBox6_SelectionChangeCommitted;
            // 
            // facilityType6
            // 
            facilityType6.Location = new Point(314, 227);
            facilityType6.Margin = new Padding(4, 3, 4, 3);
            facilityType6.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            facilityType6.Name = "facilityType6";
            facilityType6.Size = new Size(59, 23);
            facilityType6.TabIndex = 50;
            facilityType6.TabStop = false;
            facilityType6.Value = new decimal(new int[] { 255, 0, 0, 0 });
            facilityType6.ValueChanged += facilityType6_ValueChanged;
            // 
            // facilityPercent6
            // 
            facilityPercent6.Location = new Point(219, 227);
            facilityPercent6.Margin = new Padding(4, 3, 4, 3);
            facilityPercent6.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            facilityPercent6.Name = "facilityPercent6";
            facilityPercent6.Size = new Size(59, 23);
            facilityPercent6.TabIndex = 49;
            facilityPercent6.TabStop = false;
            facilityPercent6.Value = new decimal(new int[] { 100, 0, 0, 0 });
            facilityPercent6.ValueChanged += facilityPercent6_ValueChanged;
            // 
            // facilityPercent0
            // 
            facilityPercent0.Location = new Point(219, 42);
            facilityPercent0.Margin = new Padding(4, 3, 4, 3);
            facilityPercent0.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            facilityPercent0.Name = "facilityPercent0";
            facilityPercent0.Size = new Size(59, 23);
            facilityPercent0.TabIndex = 55;
            facilityPercent0.TabStop = false;
            facilityPercent0.Value = new decimal(new int[] { 100, 0, 0, 0 });
            facilityPercent0.ValueChanged += facilityPercent0_ValueChanged;
            // 
            // RimSystemsFacilitiesTablesForm
            // 
            AcceptButton = Ok;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Cancel;
            ClientSize = new Size(413, 360);
            Controls.Add(facilityPercent0);
            Controls.Add(facilityBox6);
            Controls.Add(facilityType6);
            Controls.Add(facilityPercent6);
            Controls.Add(facilityBox5);
            Controls.Add(facilityType5);
            Controls.Add(facilityPercent5);
            Controls.Add(facilityBox4);
            Controls.Add(facilityType4);
            Controls.Add(facilityPercent4);
            Controls.Add(facilityBox3);
            Controls.Add(facilityType3);
            Controls.Add(facilityPercent3);
            Controls.Add(facilityBox2);
            Controls.Add(facilityType2);
            Controls.Add(facilityPercent2);
            Controls.Add(facilityBox1);
            Controls.Add(facilityType1);
            Controls.Add(facilityPercent1);
            Controls.Add(facilityBox0);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(facilityType0);
            Controls.Add(idLabel);
            Controls.Add(openNew);
            Controls.Add(SaveAs);
            Controls.Add(Ok);
            Controls.Add(Cancel);
            Controls.Add(troopName);
            Margin = new Padding(4, 3, 4, 3);
            Name = "RimSystemsFacilitiesTablesForm";
            Text = "Rim Systems Facilities Table (SYFCRMTB.DAT)";
            FormClosing += GameObjectsListForm_FormClosing;
            Load += GameObjectsListForm_Load;
            ((ISupportInitialize)facilityType0).EndInit();
            ((ISupportInitialize)facilityType1).EndInit();
            ((ISupportInitialize)facilityPercent1).EndInit();
            ((ISupportInitialize)facilityType2).EndInit();
            ((ISupportInitialize)facilityPercent2).EndInit();
            ((ISupportInitialize)facilityType3).EndInit();
            ((ISupportInitialize)facilityPercent3).EndInit();
            ((ISupportInitialize)facilityType4).EndInit();
            ((ISupportInitialize)facilityPercent4).EndInit();
            ((ISupportInitialize)facilityType5).EndInit();
            ((ISupportInitialize)facilityPercent5).EndInit();
            ((ISupportInitialize)facilityType6).EndInit();
            ((ISupportInitialize)facilityPercent6).EndInit();
            ((ISupportInitialize)facilityPercent0).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}