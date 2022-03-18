using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class SystemFacilitiesRimTablesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
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
            this.openNew = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Cancel = new System.Windows.Forms.Button();
            this.troopName = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.facilityType0 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.facilityBox0 = new System.Windows.Forms.ComboBox();
            this.facilityBox1 = new System.Windows.Forms.ComboBox();
            this.facilityType1 = new System.Windows.Forms.NumericUpDown();
            this.facilityPercent1 = new System.Windows.Forms.NumericUpDown();
            this.facilityBox2 = new System.Windows.Forms.ComboBox();
            this.facilityType2 = new System.Windows.Forms.NumericUpDown();
            this.facilityPercent2 = new System.Windows.Forms.NumericUpDown();
            this.facilityBox3 = new System.Windows.Forms.ComboBox();
            this.facilityType3 = new System.Windows.Forms.NumericUpDown();
            this.facilityPercent3 = new System.Windows.Forms.NumericUpDown();
            this.facilityBox4 = new System.Windows.Forms.ComboBox();
            this.facilityType4 = new System.Windows.Forms.NumericUpDown();
            this.facilityPercent4 = new System.Windows.Forms.NumericUpDown();
            this.facilityBox5 = new System.Windows.Forms.ComboBox();
            this.facilityType5 = new System.Windows.Forms.NumericUpDown();
            this.facilityPercent5 = new System.Windows.Forms.NumericUpDown();
            this.facilityBox6 = new System.Windows.Forms.ComboBox();
            this.facilityType6 = new System.Windows.Forms.NumericUpDown();
            this.facilityPercent6 = new System.Windows.Forms.NumericUpDown();
            this.facilityPercent0 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.facilityType0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityPercent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityType2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityPercent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityType3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityPercent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityType4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityPercent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityType5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityPercent5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityType6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityPercent6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityPercent0)).BeginInit();
            this.SuspendLayout();
            // 
            // openNew
            // 
            this.openNew.Location = new System.Drawing.Point(314, 309);
            this.openNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openNew.Name = "openNew";
            this.openNew.Size = new System.Drawing.Size(88, 27);
            this.openNew.TabIndex = 26;
            this.openNew.Text = "Open...";
            this.openNew.UseVisualStyleBackColor = true;
            this.openNew.Click += new System.EventHandler(this.Open_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Location = new System.Drawing.Point(219, 309);
            this.SaveAs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(88, 27);
            this.SaveAs.TabIndex = 25;
            this.SaveAs.Text = "&SaveAs...";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(10, 309);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 23;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "DAT";
            this.saveFileDialog.Filter = "Data files|*.dat";
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(105, 309);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 27);
            this.Cancel.TabIndex = 24;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // troopName
            // 
            this.troopName.AutoSize = true;
            this.troopName.Location = new System.Drawing.Point(282, 76);
            this.troopName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.troopName.Name = "troopName";
            this.troopName.Size = new System.Drawing.Size(0, 15);
            this.troopName.TabIndex = 22;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Enabled = false;
            this.idLabel.Location = new System.Drawing.Point(216, 22);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(47, 15);
            this.idLabel.TabIndex = 28;
            this.idLabel.Text = "Percent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(310, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Facility Type";
            // 
            // facilityType0
            // 
            this.facilityType0.Location = new System.Drawing.Point(314, 40);
            this.facilityType0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityType0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facilityType0.Name = "facilityType0";
            this.facilityType0.Size = new System.Drawing.Size(59, 23);
            this.facilityType0.TabIndex = 29;
            this.facilityType0.TabStop = false;
            this.facilityType0.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facilityType0.ValueChanged += new System.EventHandler(this.facilityType0_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Facility";
            // 
            // facilityBox0
            // 
            this.facilityBox0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facilityBox0.FormattingEnabled = true;
            this.facilityBox0.Items.AddRange(new object[] {
            "Refinery",
            "Shipyard",
            "Training",
            "Construction",
            "Shield",
            "Laser",
            "Ion",
            "Advanced Shipyard",
            "Advanced Troop Training",
            "Advanced Construction",
            "Shield Generator Type II",
            "Laser Type II"});
            this.facilityBox0.Location = new System.Drawing.Point(14, 39);
            this.facilityBox0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityBox0.Name = "facilityBox0";
            this.facilityBox0.Size = new System.Drawing.Size(178, 23);
            this.facilityBox0.TabIndex = 33;
            this.facilityBox0.SelectionChangeCommitted += new System.EventHandler(this.facilityBox0_SelectionChangeCommitted);
            // 
            // facilityBox1
            // 
            this.facilityBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facilityBox1.FormattingEnabled = true;
            this.facilityBox1.Items.AddRange(new object[] {
            "Refinery",
            "Shipyard",
            "Training",
            "Construction",
            "Shield",
            "Laser",
            "Ion",
            "Advanced Shipyard",
            "Advanced Troop Training",
            "Advanced Construction",
            "Shield Generator Type II",
            "Laser Type II"});
            this.facilityBox1.Location = new System.Drawing.Point(14, 70);
            this.facilityBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityBox1.Name = "facilityBox1";
            this.facilityBox1.Size = new System.Drawing.Size(178, 23);
            this.facilityBox1.TabIndex = 36;
            this.facilityBox1.SelectionChangeCommitted += new System.EventHandler(this.facilityBox1_SelectionChangeCommitted);
            // 
            // facilityType1
            // 
            this.facilityType1.Location = new System.Drawing.Point(314, 72);
            this.facilityType1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityType1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facilityType1.Name = "facilityType1";
            this.facilityType1.Size = new System.Drawing.Size(59, 23);
            this.facilityType1.TabIndex = 35;
            this.facilityType1.TabStop = false;
            this.facilityType1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facilityType1.ValueChanged += new System.EventHandler(this.facilityType1_ValueChanged);
            // 
            // facilityPercent1
            // 
            this.facilityPercent1.Location = new System.Drawing.Point(219, 72);
            this.facilityPercent1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityPercent1.Name = "facilityPercent1";
            this.facilityPercent1.Size = new System.Drawing.Size(59, 23);
            this.facilityPercent1.TabIndex = 34;
            this.facilityPercent1.TabStop = false;
            this.facilityPercent1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.facilityPercent1.ValueChanged += new System.EventHandler(this.facilityPercent1_ValueChanged);
            // 
            // facilityBox2
            // 
            this.facilityBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facilityBox2.FormattingEnabled = true;
            this.facilityBox2.Items.AddRange(new object[] {
            "Refinery",
            "Shipyard",
            "Training",
            "Construction",
            "Shield",
            "Laser",
            "Ion",
            "Advanced Shipyard",
            "Advanced Troop Training",
            "Advanced Construction",
            "Shield Generator Type II",
            "Laser Type II"});
            this.facilityBox2.Location = new System.Drawing.Point(14, 102);
            this.facilityBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityBox2.Name = "facilityBox2";
            this.facilityBox2.Size = new System.Drawing.Size(178, 23);
            this.facilityBox2.TabIndex = 39;
            this.facilityBox2.SelectionChangeCommitted += new System.EventHandler(this.facilityBox2_SelectionChangeCommitted);
            // 
            // facilityType2
            // 
            this.facilityType2.Location = new System.Drawing.Point(314, 103);
            this.facilityType2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityType2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facilityType2.Name = "facilityType2";
            this.facilityType2.Size = new System.Drawing.Size(59, 23);
            this.facilityType2.TabIndex = 38;
            this.facilityType2.TabStop = false;
            this.facilityType2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facilityType2.ValueChanged += new System.EventHandler(this.facilityType2_ValueChanged);
            // 
            // facilityPercent2
            // 
            this.facilityPercent2.Location = new System.Drawing.Point(219, 103);
            this.facilityPercent2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityPercent2.Name = "facilityPercent2";
            this.facilityPercent2.Size = new System.Drawing.Size(59, 23);
            this.facilityPercent2.TabIndex = 37;
            this.facilityPercent2.TabStop = false;
            this.facilityPercent2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.facilityPercent2.ValueChanged += new System.EventHandler(this.facilityPercent2_ValueChanged);
            // 
            // facilityBox3
            // 
            this.facilityBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facilityBox3.FormattingEnabled = true;
            this.facilityBox3.Items.AddRange(new object[] {
            "Refinery",
            "Shipyard",
            "Training",
            "Construction",
            "Shield",
            "Laser",
            "Ion",
            "Advanced Shipyard",
            "Advanced Troop Training",
            "Advanced Construction",
            "Shield Generator II",
            "Laser II"});
            this.facilityBox3.Location = new System.Drawing.Point(14, 133);
            this.facilityBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityBox3.Name = "facilityBox3";
            this.facilityBox3.Size = new System.Drawing.Size(178, 23);
            this.facilityBox3.TabIndex = 42;
            this.facilityBox3.SelectionChangeCommitted += new System.EventHandler(this.facilityBox3_SelectionChangeCommitted);
            // 
            // facilityType3
            // 
            this.facilityType3.Location = new System.Drawing.Point(314, 134);
            this.facilityType3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityType3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facilityType3.Name = "facilityType3";
            this.facilityType3.Size = new System.Drawing.Size(59, 23);
            this.facilityType3.TabIndex = 41;
            this.facilityType3.TabStop = false;
            this.facilityType3.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facilityType3.ValueChanged += new System.EventHandler(this.facilityType3_ValueChanged);
            // 
            // facilityPercent3
            // 
            this.facilityPercent3.Location = new System.Drawing.Point(219, 134);
            this.facilityPercent3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityPercent3.Name = "facilityPercent3";
            this.facilityPercent3.Size = new System.Drawing.Size(59, 23);
            this.facilityPercent3.TabIndex = 40;
            this.facilityPercent3.TabStop = false;
            this.facilityPercent3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.facilityPercent3.ValueChanged += new System.EventHandler(this.facilityPercent3_ValueChanged);
            // 
            // facilityBox4
            // 
            this.facilityBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facilityBox4.FormattingEnabled = true;
            this.facilityBox4.Items.AddRange(new object[] {
            "Refinery",
            "Shipyard",
            "Training",
            "Construction",
            "Shield",
            "Laser",
            "Ion",
            "Advanced Shipyard",
            "Advanced Troop Training",
            "Advanced Construction",
            "Shield Generator Type II",
            "Laser Type II"});
            this.facilityBox4.Location = new System.Drawing.Point(14, 164);
            this.facilityBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityBox4.Name = "facilityBox4";
            this.facilityBox4.Size = new System.Drawing.Size(178, 23);
            this.facilityBox4.TabIndex = 45;
            this.facilityBox4.SelectionChangeCommitted += new System.EventHandler(this.facilityBox4_SelectionChangeCommitted);
            // 
            // facilityType4
            // 
            this.facilityType4.Location = new System.Drawing.Point(314, 165);
            this.facilityType4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityType4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facilityType4.Name = "facilityType4";
            this.facilityType4.Size = new System.Drawing.Size(59, 23);
            this.facilityType4.TabIndex = 44;
            this.facilityType4.TabStop = false;
            this.facilityType4.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facilityType4.ValueChanged += new System.EventHandler(this.facilityType4_ValueChanged);
            // 
            // facilityPercent4
            // 
            this.facilityPercent4.Location = new System.Drawing.Point(219, 165);
            this.facilityPercent4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityPercent4.Name = "facilityPercent4";
            this.facilityPercent4.Size = new System.Drawing.Size(59, 23);
            this.facilityPercent4.TabIndex = 43;
            this.facilityPercent4.TabStop = false;
            this.facilityPercent4.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.facilityPercent4.ValueChanged += new System.EventHandler(this.facilityPercent4_ValueChanged);
            // 
            // facilityBox5
            // 
            this.facilityBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facilityBox5.FormattingEnabled = true;
            this.facilityBox5.Items.AddRange(new object[] {
            "Refinery",
            "Shipyard",
            "Training",
            "Construction",
            "Shield",
            "Laser",
            "Ion",
            "Advanced Shipyard",
            "Advanced Troop Training",
            "Advanced Construction",
            "Shield Generator Type II",
            "Laser Type II"});
            this.facilityBox5.Location = new System.Drawing.Point(14, 195);
            this.facilityBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityBox5.Name = "facilityBox5";
            this.facilityBox5.Size = new System.Drawing.Size(178, 23);
            this.facilityBox5.TabIndex = 48;
            this.facilityBox5.SelectionChangeCommitted += new System.EventHandler(this.facilityBox5_SelectionChangeCommitted);
            // 
            // facilityType5
            // 
            this.facilityType5.Location = new System.Drawing.Point(314, 196);
            this.facilityType5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityType5.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facilityType5.Name = "facilityType5";
            this.facilityType5.Size = new System.Drawing.Size(59, 23);
            this.facilityType5.TabIndex = 47;
            this.facilityType5.TabStop = false;
            this.facilityType5.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facilityType5.ValueChanged += new System.EventHandler(this.facilityType5_ValueChanged);
            // 
            // facilityPercent5
            // 
            this.facilityPercent5.Location = new System.Drawing.Point(219, 196);
            this.facilityPercent5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityPercent5.Name = "facilityPercent5";
            this.facilityPercent5.Size = new System.Drawing.Size(59, 23);
            this.facilityPercent5.TabIndex = 46;
            this.facilityPercent5.TabStop = false;
            this.facilityPercent5.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.facilityPercent5.ValueChanged += new System.EventHandler(this.facilityPercent5_ValueChanged);
            // 
            // facilityBox6
            // 
            this.facilityBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facilityBox6.FormattingEnabled = true;
            this.facilityBox6.Items.AddRange(new object[] {
            "Refinery",
            "Shipyard",
            "Training",
            "Construction",
            "Shield",
            "Laser",
            "Ion",
            "Advanced Shipyard",
            "Advanced Troop Training",
            "Advanced Construction",
            "Shield Generator Type II",
            "Laser Type II"});
            this.facilityBox6.Location = new System.Drawing.Point(14, 226);
            this.facilityBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityBox6.Name = "facilityBox6";
            this.facilityBox6.Size = new System.Drawing.Size(178, 23);
            this.facilityBox6.TabIndex = 51;
            this.facilityBox6.SelectionChangeCommitted += new System.EventHandler(this.facilityBox6_SelectionChangeCommitted);
            // 
            // facilityType6
            // 
            this.facilityType6.Location = new System.Drawing.Point(314, 227);
            this.facilityType6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityType6.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facilityType6.Name = "facilityType6";
            this.facilityType6.Size = new System.Drawing.Size(59, 23);
            this.facilityType6.TabIndex = 50;
            this.facilityType6.TabStop = false;
            this.facilityType6.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facilityType6.ValueChanged += new System.EventHandler(this.facilityType6_ValueChanged);
            // 
            // facilityPercent6
            // 
            this.facilityPercent6.Location = new System.Drawing.Point(219, 227);
            this.facilityPercent6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityPercent6.Name = "facilityPercent6";
            this.facilityPercent6.Size = new System.Drawing.Size(59, 23);
            this.facilityPercent6.TabIndex = 49;
            this.facilityPercent6.TabStop = false;
            this.facilityPercent6.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.facilityPercent6.ValueChanged += new System.EventHandler(this.facilityPercent6_ValueChanged);
            // 
            // facilityPercent0
            // 
            this.facilityPercent0.Location = new System.Drawing.Point(219, 42);
            this.facilityPercent0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilityPercent0.Name = "facilityPercent0";
            this.facilityPercent0.Size = new System.Drawing.Size(59, 23);
            this.facilityPercent0.TabIndex = 55;
            this.facilityPercent0.TabStop = false;
            this.facilityPercent0.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.facilityPercent0.ValueChanged += new System.EventHandler(this.facilityPercent0_ValueChanged);
            // 
            // SystemFacilitiesRimTablesForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(413, 360);
            this.Controls.Add(this.facilityPercent0);
            this.Controls.Add(this.facilityBox6);
            this.Controls.Add(this.facilityType6);
            this.Controls.Add(this.facilityPercent6);
            this.Controls.Add(this.facilityBox5);
            this.Controls.Add(this.facilityType5);
            this.Controls.Add(this.facilityPercent5);
            this.Controls.Add(this.facilityBox4);
            this.Controls.Add(this.facilityType4);
            this.Controls.Add(this.facilityPercent4);
            this.Controls.Add(this.facilityBox3);
            this.Controls.Add(this.facilityType3);
            this.Controls.Add(this.facilityPercent3);
            this.Controls.Add(this.facilityBox2);
            this.Controls.Add(this.facilityType2);
            this.Controls.Add(this.facilityPercent2);
            this.Controls.Add(this.facilityBox1);
            this.Controls.Add(this.facilityType1);
            this.Controls.Add(this.facilityPercent1);
            this.Controls.Add(this.facilityBox0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.facilityType0);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.openNew);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.troopName);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SystemFacilitiesRimTablesForm";
            this.Text = "System Facilities Core Tables (SYFCCRTB.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facilityType0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityPercent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityType2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityPercent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityType3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityPercent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityType4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityPercent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityType5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityPercent5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityType6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityPercent6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityPercent0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}