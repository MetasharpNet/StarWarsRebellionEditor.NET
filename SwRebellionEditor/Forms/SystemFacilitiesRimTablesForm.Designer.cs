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
        private NumericUpDown percNum1;
        private ComboBox FacilityBox8;
        private NumericUpDown facType8;
        private NumericUpDown percNum8;
        private ComboBox FacilityBox7;
        private NumericUpDown facType7;
        private NumericUpDown percNum7;
        private ComboBox FacilityBox6;
        private NumericUpDown facType6;
        private NumericUpDown percNum6;
        private ComboBox FacilityBox5;
        private NumericUpDown facType5;
        private NumericUpDown percNum5;
        private ComboBox FacilityBox4;
        private NumericUpDown facType4;
        private NumericUpDown percNum4;
        private ComboBox FacilityBox3;
        private NumericUpDown facType3;
        private NumericUpDown percNum3;
        private NumericUpDown percNum2;
        private ComboBox FacilityBox1;
        private Label label2;
        private SaveFileDialog saveFileDialog;
        private ComboBox FacilityBox2;
        private NumericUpDown facType2;
        private Label label1;
        private NumericUpDown facType1;
        private Label idLabel;
        private Button openNew;
        private Button SaveAs;
        private Button Ok;
        private Button Cancel;
        private Label troopName;
        private CheckBox checkBox1;

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
            this.percNum1 = new System.Windows.Forms.NumericUpDown();
            this.FacilityBox8 = new System.Windows.Forms.ComboBox();
            this.facType8 = new System.Windows.Forms.NumericUpDown();
            this.percNum8 = new System.Windows.Forms.NumericUpDown();
            this.FacilityBox7 = new System.Windows.Forms.ComboBox();
            this.facType7 = new System.Windows.Forms.NumericUpDown();
            this.percNum7 = new System.Windows.Forms.NumericUpDown();
            this.FacilityBox6 = new System.Windows.Forms.ComboBox();
            this.facType6 = new System.Windows.Forms.NumericUpDown();
            this.percNum6 = new System.Windows.Forms.NumericUpDown();
            this.FacilityBox5 = new System.Windows.Forms.ComboBox();
            this.facType5 = new System.Windows.Forms.NumericUpDown();
            this.percNum5 = new System.Windows.Forms.NumericUpDown();
            this.FacilityBox4 = new System.Windows.Forms.ComboBox();
            this.facType4 = new System.Windows.Forms.NumericUpDown();
            this.percNum4 = new System.Windows.Forms.NumericUpDown();
            this.FacilityBox3 = new System.Windows.Forms.ComboBox();
            this.facType3 = new System.Windows.Forms.NumericUpDown();
            this.percNum3 = new System.Windows.Forms.NumericUpDown();
            this.percNum2 = new System.Windows.Forms.NumericUpDown();
            this.FacilityBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.FacilityBox2 = new System.Windows.Forms.ComboBox();
            this.facType2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.facType1 = new System.Windows.Forms.NumericUpDown();
            this.idLabel = new System.Windows.Forms.Label();
            this.openNew = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.troopName = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.percNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facType8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percNum8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facType7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percNum7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facType6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percNum6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facType5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percNum5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facType4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percNum4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facType3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percNum3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facType2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facType1)).BeginInit();
            this.SuspendLayout();
            // 
            // percNum1
            // 
            this.percNum1.Location = new System.Drawing.Point(219, 42);
            this.percNum1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.percNum1.Name = "percNum1";
            this.percNum1.Size = new System.Drawing.Size(59, 23);
            this.percNum1.TabIndex = 87;
            this.percNum1.TabStop = false;
            this.percNum1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.percNum1.ValueChanged += new System.EventHandler(this.updatePercNum1);
            // 
            // FacilityBox8
            // 
            this.FacilityBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacilityBox8.Enabled = false;
            this.FacilityBox8.FormattingEnabled = true;
            this.FacilityBox8.Items.AddRange(new object[] {
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
            this.FacilityBox8.Location = new System.Drawing.Point(14, 257);
            this.FacilityBox8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FacilityBox8.Name = "FacilityBox8";
            this.FacilityBox8.Size = new System.Drawing.Size(178, 23);
            this.FacilityBox8.TabIndex = 86;
            this.FacilityBox8.Visible = false;
            this.FacilityBox8.SelectionChangeCommitted += new System.EventHandler(this.updateFacilityBox8);
            // 
            // facType8
            // 
            this.facType8.Enabled = false;
            this.facType8.Location = new System.Drawing.Point(314, 258);
            this.facType8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facType8.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facType8.Name = "facType8";
            this.facType8.Size = new System.Drawing.Size(59, 23);
            this.facType8.TabIndex = 85;
            this.facType8.TabStop = false;
            this.facType8.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facType8.Visible = false;
            this.facType8.ValueChanged += new System.EventHandler(this.updateFacType8);
            // 
            // percNum8
            // 
            this.percNum8.Enabled = false;
            this.percNum8.Location = new System.Drawing.Point(219, 258);
            this.percNum8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.percNum8.Name = "percNum8";
            this.percNum8.Size = new System.Drawing.Size(59, 23);
            this.percNum8.TabIndex = 84;
            this.percNum8.TabStop = false;
            this.percNum8.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.percNum8.Visible = false;
            this.percNum8.ValueChanged += new System.EventHandler(this.updatePercNum8);
            // 
            // FacilityBox7
            // 
            this.FacilityBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacilityBox7.FormattingEnabled = true;
            this.FacilityBox7.Items.AddRange(new object[] {
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
            this.FacilityBox7.Location = new System.Drawing.Point(14, 226);
            this.FacilityBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FacilityBox7.Name = "FacilityBox7";
            this.FacilityBox7.Size = new System.Drawing.Size(178, 23);
            this.FacilityBox7.TabIndex = 83;
            this.FacilityBox7.SelectionChangeCommitted += new System.EventHandler(this.updateFacilityBox7);
            // 
            // facType7
            // 
            this.facType7.Location = new System.Drawing.Point(314, 227);
            this.facType7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facType7.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facType7.Name = "facType7";
            this.facType7.Size = new System.Drawing.Size(59, 23);
            this.facType7.TabIndex = 82;
            this.facType7.TabStop = false;
            this.facType7.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facType7.ValueChanged += new System.EventHandler(this.updateFacType7);
            // 
            // percNum7
            // 
            this.percNum7.Location = new System.Drawing.Point(219, 227);
            this.percNum7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.percNum7.Name = "percNum7";
            this.percNum7.Size = new System.Drawing.Size(59, 23);
            this.percNum7.TabIndex = 81;
            this.percNum7.TabStop = false;
            this.percNum7.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.percNum7.ValueChanged += new System.EventHandler(this.updatePercNum7);
            // 
            // FacilityBox6
            // 
            this.FacilityBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacilityBox6.FormattingEnabled = true;
            this.FacilityBox6.Items.AddRange(new object[] {
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
            this.FacilityBox6.Location = new System.Drawing.Point(14, 195);
            this.FacilityBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FacilityBox6.Name = "FacilityBox6";
            this.FacilityBox6.Size = new System.Drawing.Size(178, 23);
            this.FacilityBox6.TabIndex = 80;
            this.FacilityBox6.SelectionChangeCommitted += new System.EventHandler(this.updateFacilityBox6);
            // 
            // facType6
            // 
            this.facType6.Location = new System.Drawing.Point(314, 196);
            this.facType6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facType6.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facType6.Name = "facType6";
            this.facType6.Size = new System.Drawing.Size(59, 23);
            this.facType6.TabIndex = 79;
            this.facType6.TabStop = false;
            this.facType6.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facType6.ValueChanged += new System.EventHandler(this.updateFacType6);
            // 
            // percNum6
            // 
            this.percNum6.Location = new System.Drawing.Point(219, 196);
            this.percNum6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.percNum6.Name = "percNum6";
            this.percNum6.Size = new System.Drawing.Size(59, 23);
            this.percNum6.TabIndex = 78;
            this.percNum6.TabStop = false;
            this.percNum6.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.percNum6.ValueChanged += new System.EventHandler(this.updatePercNum6);
            // 
            // FacilityBox5
            // 
            this.FacilityBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacilityBox5.FormattingEnabled = true;
            this.FacilityBox5.Items.AddRange(new object[] {
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
            this.FacilityBox5.Location = new System.Drawing.Point(14, 164);
            this.FacilityBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FacilityBox5.Name = "FacilityBox5";
            this.FacilityBox5.Size = new System.Drawing.Size(178, 23);
            this.FacilityBox5.TabIndex = 77;
            this.FacilityBox5.SelectionChangeCommitted += new System.EventHandler(this.updateFacilityBox5);
            // 
            // facType5
            // 
            this.facType5.Location = new System.Drawing.Point(314, 165);
            this.facType5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facType5.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facType5.Name = "facType5";
            this.facType5.Size = new System.Drawing.Size(59, 23);
            this.facType5.TabIndex = 76;
            this.facType5.TabStop = false;
            this.facType5.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facType5.ValueChanged += new System.EventHandler(this.updateFacType5);
            // 
            // percNum5
            // 
            this.percNum5.Location = new System.Drawing.Point(219, 165);
            this.percNum5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.percNum5.Name = "percNum5";
            this.percNum5.Size = new System.Drawing.Size(59, 23);
            this.percNum5.TabIndex = 75;
            this.percNum5.TabStop = false;
            this.percNum5.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.percNum5.ValueChanged += new System.EventHandler(this.updatePercNum5);
            // 
            // FacilityBox4
            // 
            this.FacilityBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacilityBox4.FormattingEnabled = true;
            this.FacilityBox4.Items.AddRange(new object[] {
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
            this.FacilityBox4.Location = new System.Drawing.Point(14, 133);
            this.FacilityBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FacilityBox4.Name = "FacilityBox4";
            this.FacilityBox4.Size = new System.Drawing.Size(178, 23);
            this.FacilityBox4.TabIndex = 74;
            this.FacilityBox4.SelectionChangeCommitted += new System.EventHandler(this.updateFacilityBox4);
            // 
            // facType4
            // 
            this.facType4.Location = new System.Drawing.Point(314, 134);
            this.facType4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facType4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facType4.Name = "facType4";
            this.facType4.Size = new System.Drawing.Size(59, 23);
            this.facType4.TabIndex = 73;
            this.facType4.TabStop = false;
            this.facType4.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facType4.ValueChanged += new System.EventHandler(this.updateFacType4);
            // 
            // percNum4
            // 
            this.percNum4.Location = new System.Drawing.Point(219, 134);
            this.percNum4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.percNum4.Name = "percNum4";
            this.percNum4.Size = new System.Drawing.Size(59, 23);
            this.percNum4.TabIndex = 72;
            this.percNum4.TabStop = false;
            this.percNum4.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.percNum4.ValueChanged += new System.EventHandler(this.updatePercNum4);
            // 
            // FacilityBox3
            // 
            this.FacilityBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacilityBox3.FormattingEnabled = true;
            this.FacilityBox3.Items.AddRange(new object[] {
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
            this.FacilityBox3.Location = new System.Drawing.Point(14, 102);
            this.FacilityBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FacilityBox3.Name = "FacilityBox3";
            this.FacilityBox3.Size = new System.Drawing.Size(178, 23);
            this.FacilityBox3.TabIndex = 71;
            this.FacilityBox3.SelectionChangeCommitted += new System.EventHandler(this.updateFacilityBox3);
            // 
            // facType3
            // 
            this.facType3.Location = new System.Drawing.Point(314, 103);
            this.facType3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facType3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facType3.Name = "facType3";
            this.facType3.Size = new System.Drawing.Size(59, 23);
            this.facType3.TabIndex = 70;
            this.facType3.TabStop = false;
            this.facType3.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facType3.ValueChanged += new System.EventHandler(this.updateFacType3);
            // 
            // percNum3
            // 
            this.percNum3.Location = new System.Drawing.Point(219, 103);
            this.percNum3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.percNum3.Name = "percNum3";
            this.percNum3.Size = new System.Drawing.Size(59, 23);
            this.percNum3.TabIndex = 69;
            this.percNum3.TabStop = false;
            this.percNum3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.percNum3.ValueChanged += new System.EventHandler(this.updatePercNum3);
            // 
            // percNum2
            // 
            this.percNum2.Location = new System.Drawing.Point(219, 72);
            this.percNum2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.percNum2.Name = "percNum2";
            this.percNum2.Size = new System.Drawing.Size(59, 23);
            this.percNum2.TabIndex = 66;
            this.percNum2.TabStop = false;
            this.percNum2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.percNum2.ValueChanged += new System.EventHandler(this.updatePercNum2);
            // 
            // FacilityBox1
            // 
            this.FacilityBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacilityBox1.FormattingEnabled = true;
            this.FacilityBox1.Items.AddRange(new object[] {
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
            this.FacilityBox1.Location = new System.Drawing.Point(14, 39);
            this.FacilityBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FacilityBox1.Name = "FacilityBox1";
            this.FacilityBox1.Size = new System.Drawing.Size(178, 23);
            this.FacilityBox1.TabIndex = 65;
            this.FacilityBox1.SelectionChangeCommitted += new System.EventHandler(this.updateFacilityBox1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 64;
            this.label2.Text = "Facility";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "DAT";
            this.saveFileDialog.Filter = "Data files|*.dat";
            // 
            // FacilityBox2
            // 
            this.FacilityBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacilityBox2.FormattingEnabled = true;
            this.FacilityBox2.Items.AddRange(new object[] {
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
            this.FacilityBox2.Location = new System.Drawing.Point(14, 70);
            this.FacilityBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FacilityBox2.Name = "FacilityBox2";
            this.FacilityBox2.Size = new System.Drawing.Size(178, 23);
            this.FacilityBox2.TabIndex = 68;
            this.FacilityBox2.SelectionChangeCommitted += new System.EventHandler(this.updateFacilityBox2);
            // 
            // facType2
            // 
            this.facType2.Location = new System.Drawing.Point(314, 72);
            this.facType2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facType2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facType2.Name = "facType2";
            this.facType2.Size = new System.Drawing.Size(59, 23);
            this.facType2.TabIndex = 67;
            this.facType2.TabStop = false;
            this.facType2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facType2.ValueChanged += new System.EventHandler(this.updateFacType2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(310, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 63;
            this.label1.Text = "Facility Num";
            // 
            // facType1
            // 
            this.facType1.Location = new System.Drawing.Point(314, 40);
            this.facType1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facType1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facType1.Name = "facType1";
            this.facType1.Size = new System.Drawing.Size(59, 23);
            this.facType1.TabIndex = 62;
            this.facType1.TabStop = false;
            this.facType1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.facType1.ValueChanged += new System.EventHandler(this.updateFacType1);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Enabled = false;
            this.idLabel.Location = new System.Drawing.Point(216, 22);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(47, 15);
            this.idLabel.TabIndex = 61;
            this.idLabel.Text = "Percent";
            // 
            // openNew
            // 
            this.openNew.Location = new System.Drawing.Point(314, 309);
            this.openNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openNew.Name = "openNew";
            this.openNew.Size = new System.Drawing.Size(88, 27);
            this.openNew.TabIndex = 60;
            this.openNew.Text = "Open...";
            this.openNew.UseVisualStyleBackColor = true;
            this.openNew.Click += new System.EventHandler(this.openNew_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Location = new System.Drawing.Point(219, 309);
            this.SaveAs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(88, 27);
            this.SaveAs.TabIndex = 59;
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
            this.Ok.TabIndex = 57;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(105, 309);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 27);
            this.Cancel.TabIndex = 58;
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
            this.troopName.TabIndex = 56;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(384, 265);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 88;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // SystemFacilitiesRimTablesForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(413, 360);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.percNum1);
            this.Controls.Add(this.FacilityBox8);
            this.Controls.Add(this.facType8);
            this.Controls.Add(this.percNum8);
            this.Controls.Add(this.FacilityBox7);
            this.Controls.Add(this.facType7);
            this.Controls.Add(this.percNum7);
            this.Controls.Add(this.FacilityBox6);
            this.Controls.Add(this.facType6);
            this.Controls.Add(this.percNum6);
            this.Controls.Add(this.FacilityBox5);
            this.Controls.Add(this.facType5);
            this.Controls.Add(this.percNum5);
            this.Controls.Add(this.FacilityBox4);
            this.Controls.Add(this.facType4);
            this.Controls.Add(this.percNum4);
            this.Controls.Add(this.FacilityBox3);
            this.Controls.Add(this.facType3);
            this.Controls.Add(this.percNum3);
            this.Controls.Add(this.percNum2);
            this.Controls.Add(this.FacilityBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FacilityBox2);
            this.Controls.Add(this.facType2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.facType1);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.openNew);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.troopName);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SystemFacilitiesRimTablesForm";
            this.Text = "System Facilities Rim Tables (SYFCRMTB.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableForm_FormClosing);
            this.Load += new System.EventHandler(this.TableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.percNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facType8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percNum8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facType7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percNum7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facType6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percNum6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facType5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percNum5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facType4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percNum4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facType3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percNum3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facType2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facType1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}