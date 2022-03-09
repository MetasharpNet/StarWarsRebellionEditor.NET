using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class GeneralParametersTablesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private NumericUpDown empAdvancedNum;
        private GroupBox costGroup;
        private Label conCostLabel;
        private NumericUpDown empNoviceNum;
        private Label maintCostLabel;
        private NumericUpDown empInterNum;
        private RichTextBox encyText;
        private GroupBox groupBox2;
        private NumericUpDown mfAdvancedNum;
        private Label label5;
        private Label label6;
        private NumericUpDown mfNoviceNum;
        private Label label7;
        private NumericUpDown mfInterNum;
        private GroupBox groupBox1;
        private NumericUpDown rebAdvancedNum;
        private Label label2;
        private Label label3;
        private NumericUpDown rebNoviceNum;
        private Label label4;
        private NumericUpDown rebInterNum;
        private Label label1;
        private Button openNew;
        private Button SaveAs;
        private Button Cancel;
        private Button Ok;
        internal TabPage tabPage2;
        private Label label8;
        private SaveFileDialog saveFileDialog;
        private GroupBox groupBox3;
        private NumericUpDown mfUnk5Num;
        private Label label15;
        private NumericUpDown mfUnk4Num;
        private Label label14;
        private NumericUpDown mfUnk3Num;
        private Label label13;
        private NumericUpDown mfUnk2Num;
        private Label label12;
        private NumericUpDown mfUnk1Num;
        private Label label9;
        private Label label10;
        private NumericUpDown empUnk1Num;
        private Label label11;
        private NumericUpDown rebUnk1Num;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mfUnk5Num = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.mfUnk4Num = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.mfUnk3Num = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.mfUnk2Num = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.mfUnk1Num = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.empUnk1Num = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.rebUnk1Num = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mfAdvancedNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mfNoviceNum = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.mfInterNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rebAdvancedNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rebNoviceNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.rebInterNum = new System.Windows.Forms.NumericUpDown();
            this.costGroup = new System.Windows.Forms.GroupBox();
            this.empAdvancedNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.conCostLabel = new System.Windows.Forms.Label();
            this.empNoviceNum = new System.Windows.Forms.NumericUpDown();
            this.maintCostLabel = new System.Windows.Forms.Label();
            this.empInterNum = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.encyText = new System.Windows.Forms.RichTextBox();
            this.openNew = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mfUnk5Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfUnk4Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfUnk3Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfUnk2Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfUnk1Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empUnk1Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rebUnk1Num)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mfAdvancedNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfNoviceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfInterNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rebAdvancedNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rebNoviceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rebInterNum)).BeginInit();
            this.costGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empAdvancedNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empNoviceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empInterNum)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(390, 411);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.costGroup);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(382, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HyperSpace Speed";
            this.tabPage1.ToolTipText = "Current Speed of non-ship object in Hyperspace.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mfUnk5Num);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.mfUnk4Num);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.mfUnk3Num);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.mfUnk2Num);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.mfUnk1Num);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.empUnk1Num);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.rebUnk1Num);
            this.groupBox3.Location = new System.Drawing.Point(203, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(196, 355);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Unknown Values";
            // 
            // mfUnk5Num
            // 
            this.mfUnk5Num.Location = new System.Drawing.Point(110, 329);
            this.mfUnk5Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mfUnk5Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mfUnk5Num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mfUnk5Num.Name = "mfUnk5Num";
            this.mfUnk5Num.Size = new System.Drawing.Size(59, 23);
            this.mfUnk5Num.TabIndex = 14;
            this.mfUnk5Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mfUnk5Num.ValueChanged += new System.EventHandler(this.updateMfUnk5);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 331);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 15);
            this.label15.TabIndex = 13;
            this.label15.Text = "mfUnk5";
            // 
            // mfUnk4Num
            // 
            this.mfUnk4Num.Location = new System.Drawing.Point(110, 302);
            this.mfUnk4Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mfUnk4Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mfUnk4Num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mfUnk4Num.Name = "mfUnk4Num";
            this.mfUnk4Num.Size = new System.Drawing.Size(59, 23);
            this.mfUnk4Num.TabIndex = 12;
            this.mfUnk4Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mfUnk4Num.ValueChanged += new System.EventHandler(this.updateMfUnk4);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 305);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 15);
            this.label14.TabIndex = 11;
            this.label14.Text = "mfUnk4";
            // 
            // mfUnk3Num
            // 
            this.mfUnk3Num.Location = new System.Drawing.Point(110, 272);
            this.mfUnk3Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mfUnk3Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mfUnk3Num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mfUnk3Num.Name = "mfUnk3Num";
            this.mfUnk3Num.Size = new System.Drawing.Size(59, 23);
            this.mfUnk3Num.TabIndex = 10;
            this.mfUnk3Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mfUnk3Num.ValueChanged += new System.EventHandler(this.updateMfUnk3);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 275);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "mfUnk3";
            // 
            // mfUnk2Num
            // 
            this.mfUnk2Num.Location = new System.Drawing.Point(110, 242);
            this.mfUnk2Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mfUnk2Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mfUnk2Num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mfUnk2Num.Name = "mfUnk2Num";
            this.mfUnk2Num.Size = new System.Drawing.Size(59, 23);
            this.mfUnk2Num.TabIndex = 8;
            this.mfUnk2Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mfUnk2Num.ValueChanged += new System.EventHandler(this.updateMfUnk2);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 245);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "mfUnk2";
            // 
            // mfUnk1Num
            // 
            this.mfUnk1Num.Location = new System.Drawing.Point(110, 212);
            this.mfUnk1Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mfUnk1Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mfUnk1Num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mfUnk1Num.Name = "mfUnk1Num";
            this.mfUnk1Num.Size = new System.Drawing.Size(59, 23);
            this.mfUnk1Num.TabIndex = 6;
            this.mfUnk1Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mfUnk1Num.ValueChanged += new System.EventHandler(this.updateMfUnk1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 215);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "mfUnk1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Emp Unk1";
            // 
            // empUnk1Num
            // 
            this.empUnk1Num.Location = new System.Drawing.Point(110, 20);
            this.empUnk1Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empUnk1Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.empUnk1Num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.empUnk1Num.Name = "empUnk1Num";
            this.empUnk1Num.Size = new System.Drawing.Size(59, 23);
            this.empUnk1Num.TabIndex = 4;
            this.empUnk1Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.empUnk1Num.ValueChanged += new System.EventHandler(this.updateEmpUnk);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 142);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Reb Unk1";
            // 
            // rebUnk1Num
            // 
            this.rebUnk1Num.Location = new System.Drawing.Point(110, 140);
            this.rebUnk1Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rebUnk1Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.rebUnk1Num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rebUnk1Num.Name = "rebUnk1Num";
            this.rebUnk1Num.Size = new System.Drawing.Size(59, 23);
            this.rebUnk1Num.TabIndex = 5;
            this.rebUnk1Num.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.rebUnk1Num.ValueChanged += new System.EventHandler(this.updateRebUnk);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mfAdvancedNum);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.mfNoviceNum);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.mfInterNum);
            this.groupBox2.Location = new System.Drawing.Point(7, 249);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(196, 113);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Millenium Falcon";
            // 
            // mfAdvancedNum
            // 
            this.mfAdvancedNum.Location = new System.Drawing.Point(110, 80);
            this.mfAdvancedNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mfAdvancedNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mfAdvancedNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mfAdvancedNum.Name = "mfAdvancedNum";
            this.mfAdvancedNum.Size = new System.Drawing.Size(59, 23);
            this.mfAdvancedNum.TabIndex = 6;
            this.mfAdvancedNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mfAdvancedNum.ValueChanged += new System.EventHandler(this.updatemfAdv);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Expert";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Novice";
            // 
            // mfNoviceNum
            // 
            this.mfNoviceNum.Location = new System.Drawing.Point(110, 20);
            this.mfNoviceNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mfNoviceNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mfNoviceNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mfNoviceNum.Name = "mfNoviceNum";
            this.mfNoviceNum.Size = new System.Drawing.Size(59, 23);
            this.mfNoviceNum.TabIndex = 4;
            this.mfNoviceNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mfNoviceNum.ValueChanged += new System.EventHandler(this.updatemfNov);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Intermediate";
            // 
            // mfInterNum
            // 
            this.mfInterNum.Location = new System.Drawing.Point(110, 50);
            this.mfInterNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mfInterNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mfInterNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mfInterNum.Name = "mfInterNum";
            this.mfInterNum.Size = new System.Drawing.Size(59, 23);
            this.mfInterNum.TabIndex = 5;
            this.mfInterNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mfInterNum.ValueChanged += new System.EventHandler(this.updatemfInt);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rebAdvancedNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rebNoviceNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rebInterNum);
            this.groupBox1.Location = new System.Drawing.Point(7, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(196, 113);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rebellion";
            // 
            // rebAdvancedNum
            // 
            this.rebAdvancedNum.Location = new System.Drawing.Point(110, 80);
            this.rebAdvancedNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rebAdvancedNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.rebAdvancedNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rebAdvancedNum.Name = "rebAdvancedNum";
            this.rebAdvancedNum.Size = new System.Drawing.Size(59, 23);
            this.rebAdvancedNum.TabIndex = 6;
            this.rebAdvancedNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.rebAdvancedNum.ValueChanged += new System.EventHandler(this.updateRebAdv);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Expert";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Novice";
            // 
            // rebNoviceNum
            // 
            this.rebNoviceNum.Location = new System.Drawing.Point(110, 20);
            this.rebNoviceNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rebNoviceNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.rebNoviceNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rebNoviceNum.Name = "rebNoviceNum";
            this.rebNoviceNum.Size = new System.Drawing.Size(59, 23);
            this.rebNoviceNum.TabIndex = 4;
            this.rebNoviceNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.rebNoviceNum.ValueChanged += new System.EventHandler(this.updateRebNov);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Intermediate";
            // 
            // rebInterNum
            // 
            this.rebInterNum.Location = new System.Drawing.Point(110, 50);
            this.rebInterNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rebInterNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.rebInterNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rebInterNum.Name = "rebInterNum";
            this.rebInterNum.Size = new System.Drawing.Size(59, 23);
            this.rebInterNum.TabIndex = 5;
            this.rebInterNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.rebInterNum.ValueChanged += new System.EventHandler(this.updateRebInt);
            // 
            // costGroup
            // 
            this.costGroup.Controls.Add(this.empAdvancedNum);
            this.costGroup.Controls.Add(this.label1);
            this.costGroup.Controls.Add(this.conCostLabel);
            this.costGroup.Controls.Add(this.empNoviceNum);
            this.costGroup.Controls.Add(this.maintCostLabel);
            this.costGroup.Controls.Add(this.empInterNum);
            this.costGroup.Location = new System.Drawing.Point(7, 7);
            this.costGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.costGroup.Name = "costGroup";
            this.costGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.costGroup.Size = new System.Drawing.Size(196, 113);
            this.costGroup.TabIndex = 4;
            this.costGroup.TabStop = false;
            this.costGroup.Text = "Empire";
            // 
            // empAdvancedNum
            // 
            this.empAdvancedNum.Location = new System.Drawing.Point(110, 80);
            this.empAdvancedNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empAdvancedNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.empAdvancedNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.empAdvancedNum.Name = "empAdvancedNum";
            this.empAdvancedNum.Size = new System.Drawing.Size(59, 23);
            this.empAdvancedNum.TabIndex = 6;
            this.empAdvancedNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.empAdvancedNum.ValueChanged += new System.EventHandler(this.updateEmpAdv);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Expert";
            // 
            // conCostLabel
            // 
            this.conCostLabel.AutoSize = true;
            this.conCostLabel.Location = new System.Drawing.Point(27, 22);
            this.conCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conCostLabel.Name = "conCostLabel";
            this.conCostLabel.Size = new System.Drawing.Size(44, 15);
            this.conCostLabel.TabIndex = 0;
            this.conCostLabel.Text = "Novice";
            // 
            // empNoviceNum
            // 
            this.empNoviceNum.Location = new System.Drawing.Point(110, 20);
            this.empNoviceNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empNoviceNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.empNoviceNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.empNoviceNum.Name = "empNoviceNum";
            this.empNoviceNum.Size = new System.Drawing.Size(59, 23);
            this.empNoviceNum.TabIndex = 4;
            this.empNoviceNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.empNoviceNum.ValueChanged += new System.EventHandler(this.updateEmpNov);
            // 
            // maintCostLabel
            // 
            this.maintCostLabel.AutoSize = true;
            this.maintCostLabel.Location = new System.Drawing.Point(27, 52);
            this.maintCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maintCostLabel.Name = "maintCostLabel";
            this.maintCostLabel.Size = new System.Drawing.Size(74, 15);
            this.maintCostLabel.TabIndex = 0;
            this.maintCostLabel.Text = "Intermediate";
            // 
            // empInterNum
            // 
            this.empInterNum.Location = new System.Drawing.Point(110, 50);
            this.empInterNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empInterNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.empInterNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.empInterNum.Name = "empInterNum";
            this.empInterNum.Size = new System.Drawing.Size(59, 23);
            this.empInterNum.TabIndex = 5;
            this.empInterNum.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.empInterNum.ValueChanged += new System.EventHandler(this.updateEmpInt);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.encyText);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(382, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ency Data";
            // 
            // encyText
            // 
            this.encyText.Enabled = false;
            this.encyText.Location = new System.Drawing.Point(0, 0);
            this.encyText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.encyText.Name = "encyText";
            this.encyText.Size = new System.Drawing.Size(400, 118);
            this.encyText.TabIndex = 0;
            this.encyText.TabStop = false;
            this.encyText.Text = "Not Implemented yet....Encylopedia Data...Will add .Someday";
            // 
            // openNew
            // 
            this.openNew.Location = new System.Drawing.Point(316, 441);
            this.openNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openNew.Name = "openNew";
            this.openNew.Size = new System.Drawing.Size(88, 27);
            this.openNew.TabIndex = 22;
            this.openNew.Text = "Open...";
            this.openNew.UseVisualStyleBackColor = true;
            this.openNew.Click += new System.EventHandler(this.openNew_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Location = new System.Drawing.Point(222, 441);
            this.SaveAs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(88, 27);
            this.SaveAs.TabIndex = 21;
            this.SaveAs.Text = "&SaveAs...";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Visible = false;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(107, 441);
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
            this.Ok.Location = new System.Drawing.Point(13, 441);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 19;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "General Param Table Entry - GNPRTB.DAT";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "DAT";
            this.saveFileDialog.Filter = "Data files|*.dat";
            // 
            // GeneralParametersTablesForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(418, 477);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.openNew);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GeneralParametersTablesForm";
            this.Text = "General Parameters Tables (GNPRTB.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TroopForm_FormClosing);
            this.Load += new System.EventHandler(this.GNPRTBForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mfUnk5Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfUnk4Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfUnk3Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfUnk2Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfUnk1Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empUnk1Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rebUnk1Num)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mfAdvancedNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfNoviceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfInterNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rebAdvancedNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rebNoviceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rebInterNum)).EndInit();
            this.costGroup.ResumeLayout(false);
            this.costGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empAdvancedNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empNoviceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empInterNum)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}