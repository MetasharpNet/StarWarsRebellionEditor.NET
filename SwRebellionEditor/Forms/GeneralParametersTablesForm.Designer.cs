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
        private NumericUpDown empireExpertHyperspaceSpeedMod;
        private GroupBox costGroup;
        private Label conCostLabel;
        private NumericUpDown empireNoviceHyperspaceSpeedMod;
        private Label maintCostLabel;
        private NumericUpDown empireIntermediateHyperspaceSpeedMod;
        private RichTextBox encyText;
        private GroupBox groupBox2;
        private NumericUpDown falconExpertHyperspaceSpeedMod;
        private Label label5;
        private Label label6;
        private NumericUpDown falconNoviceHyperspaceSpeedMod;
        private Label label7;
        private NumericUpDown falconIntermediateHyperspaceSpeedMod;
        private GroupBox allianceGroupBox;
        private NumericUpDown allianceExpertHyperspaceSpeedMod;
        private Label label2;
        private Label label3;
        private NumericUpDown allianceNoviceHyperspaceSpeedMod;
        private Label label4;
        private NumericUpDown allianceIntermediateHyperspaceSpeedMod;
        private Label label1;
        private Button openNew;
        private Button SaveAs;
        private Button Cancel;
        private Button Ok;
        internal TabPage tabPage2;
        private SaveFileDialog saveFileDialog;
        private GroupBox groupBox3;
        private NumericUpDown falconUnknown5;
        private Label label15;
        private NumericUpDown falconUnknown4;
        private Label label14;
        private NumericUpDown falconUnknown3;
        private Label label13;
        private NumericUpDown falconUnknown2;
        private Label label12;
        private NumericUpDown falconUnknown1;
        private Label label9;
        private Label label10;
        private NumericUpDown empireUnknown;
        private Label label11;
        private NumericUpDown allianceUnknown;

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
            this.falconUnknown5 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.falconUnknown4 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.falconUnknown3 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.falconUnknown2 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.falconUnknown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.empireUnknown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.allianceUnknown = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.falconExpertHyperspaceSpeedMod = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.falconNoviceHyperspaceSpeedMod = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.falconIntermediateHyperspaceSpeedMod = new System.Windows.Forms.NumericUpDown();
            this.allianceGroupBox = new System.Windows.Forms.GroupBox();
            this.allianceExpertHyperspaceSpeedMod = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.allianceNoviceHyperspaceSpeedMod = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.allianceIntermediateHyperspaceSpeedMod = new System.Windows.Forms.NumericUpDown();
            this.costGroup = new System.Windows.Forms.GroupBox();
            this.empireExpertHyperspaceSpeedMod = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.conCostLabel = new System.Windows.Forms.Label();
            this.empireNoviceHyperspaceSpeedMod = new System.Windows.Forms.NumericUpDown();
            this.maintCostLabel = new System.Windows.Forms.Label();
            this.empireIntermediateHyperspaceSpeedMod = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.encyText = new System.Windows.Forms.RichTextBox();
            this.openNew = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.falconUnknown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falconUnknown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falconUnknown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falconUnknown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falconUnknown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empireUnknown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allianceUnknown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.falconExpertHyperspaceSpeedMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falconNoviceHyperspaceSpeedMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falconIntermediateHyperspaceSpeedMod)).BeginInit();
            this.allianceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allianceExpertHyperspaceSpeedMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allianceNoviceHyperspaceSpeedMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allianceIntermediateHyperspaceSpeedMod)).BeginInit();
            this.costGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empireExpertHyperspaceSpeedMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empireNoviceHyperspaceSpeedMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empireIntermediateHyperspaceSpeedMod)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 12);
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
            this.tabPage1.Controls.Add(this.allianceGroupBox);
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
            this.groupBox3.Controls.Add(this.falconUnknown5);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.falconUnknown4);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.falconUnknown3);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.falconUnknown2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.falconUnknown1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.empireUnknown);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.allianceUnknown);
            this.groupBox3.Location = new System.Drawing.Point(203, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(196, 355);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Unknown Values";
            // 
            // falconUnknown5
            // 
            this.falconUnknown5.Location = new System.Drawing.Point(116, 329);
            this.falconUnknown5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.falconUnknown5.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.falconUnknown5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.falconUnknown5.Name = "falconUnknown5";
            this.falconUnknown5.Size = new System.Drawing.Size(59, 23);
            this.falconUnknown5.TabIndex = 14;
            this.falconUnknown5.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.falconUnknown5.ValueChanged += new System.EventHandler(this.falconUnknown5_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 330);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 15);
            this.label15.TabIndex = 13;
            this.label15.Text = "Falcon Unknown 5";
            // 
            // falconUnknown4
            // 
            this.falconUnknown4.Location = new System.Drawing.Point(116, 302);
            this.falconUnknown4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.falconUnknown4.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.falconUnknown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.falconUnknown4.Name = "falconUnknown4";
            this.falconUnknown4.Size = new System.Drawing.Size(59, 23);
            this.falconUnknown4.TabIndex = 12;
            this.falconUnknown4.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.falconUnknown4.ValueChanged += new System.EventHandler(this.falconUnknown4_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 304);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 15);
            this.label14.TabIndex = 11;
            this.label14.Text = "Falcon Unknown 4";
            // 
            // falconUnknown3
            // 
            this.falconUnknown3.Location = new System.Drawing.Point(116, 272);
            this.falconUnknown3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.falconUnknown3.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.falconUnknown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.falconUnknown3.Name = "falconUnknown3";
            this.falconUnknown3.Size = new System.Drawing.Size(59, 23);
            this.falconUnknown3.TabIndex = 10;
            this.falconUnknown3.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.falconUnknown3.ValueChanged += new System.EventHandler(this.falconUnknown3_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 274);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Falcon Unknown 3";
            // 
            // falconUnknown2
            // 
            this.falconUnknown2.Location = new System.Drawing.Point(116, 242);
            this.falconUnknown2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.falconUnknown2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.falconUnknown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.falconUnknown2.Name = "falconUnknown2";
            this.falconUnknown2.Size = new System.Drawing.Size(59, 23);
            this.falconUnknown2.TabIndex = 8;
            this.falconUnknown2.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.falconUnknown2.ValueChanged += new System.EventHandler(this.falconUnknown2_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 244);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "Falcon Unknown 2";
            // 
            // falconUnknown1
            // 
            this.falconUnknown1.Location = new System.Drawing.Point(116, 212);
            this.falconUnknown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.falconUnknown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.falconUnknown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.falconUnknown1.Name = "falconUnknown1";
            this.falconUnknown1.Size = new System.Drawing.Size(59, 23);
            this.falconUnknown1.TabIndex = 6;
            this.falconUnknown1.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.falconUnknown1.ValueChanged += new System.EventHandler(this.falconUnknown1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 214);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Falcon Unknown 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Empire Unknown";
            // 
            // empireUnknown
            // 
            this.empireUnknown.Location = new System.Drawing.Point(116, 20);
            this.empireUnknown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empireUnknown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.empireUnknown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.empireUnknown.Name = "empireUnknown";
            this.empireUnknown.Size = new System.Drawing.Size(59, 23);
            this.empireUnknown.TabIndex = 4;
            this.empireUnknown.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.empireUnknown.ValueChanged += new System.EventHandler(this.empireUnknown_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 142);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Alliance Unknown";
            // 
            // allianceUnknown
            // 
            this.allianceUnknown.Location = new System.Drawing.Point(116, 140);
            this.allianceUnknown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.allianceUnknown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.allianceUnknown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.allianceUnknown.Name = "allianceUnknown";
            this.allianceUnknown.Size = new System.Drawing.Size(59, 23);
            this.allianceUnknown.TabIndex = 5;
            this.allianceUnknown.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.allianceUnknown.ValueChanged += new System.EventHandler(this.allianceUnknown_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.falconExpertHyperspaceSpeedMod);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.falconNoviceHyperspaceSpeedMod);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.falconIntermediateHyperspaceSpeedMod);
            this.groupBox2.Location = new System.Drawing.Point(7, 249);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(196, 113);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Millenium Falcon";
            // 
            // falconExpertHyperspaceSpeedMod
            // 
            this.falconExpertHyperspaceSpeedMod.Location = new System.Drawing.Point(110, 80);
            this.falconExpertHyperspaceSpeedMod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.falconExpertHyperspaceSpeedMod.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.falconExpertHyperspaceSpeedMod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.falconExpertHyperspaceSpeedMod.Name = "falconExpertHyperspaceSpeedMod";
            this.falconExpertHyperspaceSpeedMod.Size = new System.Drawing.Size(59, 23);
            this.falconExpertHyperspaceSpeedMod.TabIndex = 6;
            this.falconExpertHyperspaceSpeedMod.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.falconExpertHyperspaceSpeedMod.ValueChanged += new System.EventHandler(this.falconExpertHyperspaceSpeedMod_ValueChanged);
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
            // falconNoviceHyperspaceSpeedMod
            // 
            this.falconNoviceHyperspaceSpeedMod.Location = new System.Drawing.Point(110, 20);
            this.falconNoviceHyperspaceSpeedMod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.falconNoviceHyperspaceSpeedMod.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.falconNoviceHyperspaceSpeedMod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.falconNoviceHyperspaceSpeedMod.Name = "falconNoviceHyperspaceSpeedMod";
            this.falconNoviceHyperspaceSpeedMod.Size = new System.Drawing.Size(59, 23);
            this.falconNoviceHyperspaceSpeedMod.TabIndex = 4;
            this.falconNoviceHyperspaceSpeedMod.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.falconNoviceHyperspaceSpeedMod.ValueChanged += new System.EventHandler(this.falconNoviceHyperspaceSpeedMod_ValueChanged);
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
            // falconIntermediateHyperspaceSpeedMod
            // 
            this.falconIntermediateHyperspaceSpeedMod.Location = new System.Drawing.Point(110, 50);
            this.falconIntermediateHyperspaceSpeedMod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.falconIntermediateHyperspaceSpeedMod.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.falconIntermediateHyperspaceSpeedMod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.falconIntermediateHyperspaceSpeedMod.Name = "falconIntermediateHyperspaceSpeedMod";
            this.falconIntermediateHyperspaceSpeedMod.Size = new System.Drawing.Size(59, 23);
            this.falconIntermediateHyperspaceSpeedMod.TabIndex = 5;
            this.falconIntermediateHyperspaceSpeedMod.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.falconIntermediateHyperspaceSpeedMod.ValueChanged += new System.EventHandler(this.falconIntermediateHyperspaceSpeedMod_ValueChanged);
            // 
            // allianceGroupBox
            // 
            this.allianceGroupBox.Controls.Add(this.allianceExpertHyperspaceSpeedMod);
            this.allianceGroupBox.Controls.Add(this.label2);
            this.allianceGroupBox.Controls.Add(this.label3);
            this.allianceGroupBox.Controls.Add(this.allianceNoviceHyperspaceSpeedMod);
            this.allianceGroupBox.Controls.Add(this.label4);
            this.allianceGroupBox.Controls.Add(this.allianceIntermediateHyperspaceSpeedMod);
            this.allianceGroupBox.Location = new System.Drawing.Point(7, 127);
            this.allianceGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.allianceGroupBox.Name = "allianceGroupBox";
            this.allianceGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.allianceGroupBox.Size = new System.Drawing.Size(196, 113);
            this.allianceGroupBox.TabIndex = 7;
            this.allianceGroupBox.TabStop = false;
            this.allianceGroupBox.Text = "Alliance";
            // 
            // allianceExpertHyperspaceSpeedMod
            // 
            this.allianceExpertHyperspaceSpeedMod.Location = new System.Drawing.Point(110, 80);
            this.allianceExpertHyperspaceSpeedMod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.allianceExpertHyperspaceSpeedMod.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.allianceExpertHyperspaceSpeedMod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.allianceExpertHyperspaceSpeedMod.Name = "allianceExpertHyperspaceSpeedMod";
            this.allianceExpertHyperspaceSpeedMod.Size = new System.Drawing.Size(59, 23);
            this.allianceExpertHyperspaceSpeedMod.TabIndex = 6;
            this.allianceExpertHyperspaceSpeedMod.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.allianceExpertHyperspaceSpeedMod.ValueChanged += new System.EventHandler(this.allianceExpertHyperspaceSpeedMod_ValueChanged);
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
            // allianceNoviceHyperspaceSpeedMod
            // 
            this.allianceNoviceHyperspaceSpeedMod.Location = new System.Drawing.Point(110, 20);
            this.allianceNoviceHyperspaceSpeedMod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.allianceNoviceHyperspaceSpeedMod.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.allianceNoviceHyperspaceSpeedMod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.allianceNoviceHyperspaceSpeedMod.Name = "allianceNoviceHyperspaceSpeedMod";
            this.allianceNoviceHyperspaceSpeedMod.Size = new System.Drawing.Size(59, 23);
            this.allianceNoviceHyperspaceSpeedMod.TabIndex = 4;
            this.allianceNoviceHyperspaceSpeedMod.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.allianceNoviceHyperspaceSpeedMod.ValueChanged += new System.EventHandler(this.allianceNoviceHyperspaceSpeedMod_ValueChanged);
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
            // allianceIntermediateHyperspaceSpeedMod
            // 
            this.allianceIntermediateHyperspaceSpeedMod.Location = new System.Drawing.Point(110, 50);
            this.allianceIntermediateHyperspaceSpeedMod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.allianceIntermediateHyperspaceSpeedMod.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.allianceIntermediateHyperspaceSpeedMod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.allianceIntermediateHyperspaceSpeedMod.Name = "allianceIntermediateHyperspaceSpeedMod";
            this.allianceIntermediateHyperspaceSpeedMod.Size = new System.Drawing.Size(59, 23);
            this.allianceIntermediateHyperspaceSpeedMod.TabIndex = 5;
            this.allianceIntermediateHyperspaceSpeedMod.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.allianceIntermediateHyperspaceSpeedMod.ValueChanged += new System.EventHandler(this.allianceIntermediateHyperspaceSpeedMod_ValueChanged);
            // 
            // costGroup
            // 
            this.costGroup.Controls.Add(this.empireExpertHyperspaceSpeedMod);
            this.costGroup.Controls.Add(this.label1);
            this.costGroup.Controls.Add(this.conCostLabel);
            this.costGroup.Controls.Add(this.empireNoviceHyperspaceSpeedMod);
            this.costGroup.Controls.Add(this.maintCostLabel);
            this.costGroup.Controls.Add(this.empireIntermediateHyperspaceSpeedMod);
            this.costGroup.Location = new System.Drawing.Point(7, 7);
            this.costGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.costGroup.Name = "costGroup";
            this.costGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.costGroup.Size = new System.Drawing.Size(196, 113);
            this.costGroup.TabIndex = 4;
            this.costGroup.TabStop = false;
            this.costGroup.Text = "Empire";
            // 
            // empireExpertHyperspaceSpeedMod
            // 
            this.empireExpertHyperspaceSpeedMod.Location = new System.Drawing.Point(110, 80);
            this.empireExpertHyperspaceSpeedMod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empireExpertHyperspaceSpeedMod.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.empireExpertHyperspaceSpeedMod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.empireExpertHyperspaceSpeedMod.Name = "empireExpertHyperspaceSpeedMod";
            this.empireExpertHyperspaceSpeedMod.Size = new System.Drawing.Size(59, 23);
            this.empireExpertHyperspaceSpeedMod.TabIndex = 6;
            this.empireExpertHyperspaceSpeedMod.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.empireExpertHyperspaceSpeedMod.ValueChanged += new System.EventHandler(this.empireExpertHyperspaceSpeedMod_ValueChanged);
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
            // empireNoviceHyperspaceSpeedMod
            // 
            this.empireNoviceHyperspaceSpeedMod.Location = new System.Drawing.Point(110, 20);
            this.empireNoviceHyperspaceSpeedMod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empireNoviceHyperspaceSpeedMod.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.empireNoviceHyperspaceSpeedMod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.empireNoviceHyperspaceSpeedMod.Name = "empireNoviceHyperspaceSpeedMod";
            this.empireNoviceHyperspaceSpeedMod.Size = new System.Drawing.Size(59, 23);
            this.empireNoviceHyperspaceSpeedMod.TabIndex = 4;
            this.empireNoviceHyperspaceSpeedMod.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.empireNoviceHyperspaceSpeedMod.ValueChanged += new System.EventHandler(this.empireNoviceHyperspaceSpeedMod_ValueChanged);
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
            // empireIntermediateHyperspaceSpeedMod
            // 
            this.empireIntermediateHyperspaceSpeedMod.Location = new System.Drawing.Point(110, 50);
            this.empireIntermediateHyperspaceSpeedMod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empireIntermediateHyperspaceSpeedMod.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.empireIntermediateHyperspaceSpeedMod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.empireIntermediateHyperspaceSpeedMod.Name = "empireIntermediateHyperspaceSpeedMod";
            this.empireIntermediateHyperspaceSpeedMod.Size = new System.Drawing.Size(59, 23);
            this.empireIntermediateHyperspaceSpeedMod.TabIndex = 5;
            this.empireIntermediateHyperspaceSpeedMod.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.empireIntermediateHyperspaceSpeedMod.ValueChanged += new System.EventHandler(this.empireIntermediateHyperspaceSpeedMod_ValueChanged);
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
            this.openNew.Click += new System.EventHandler(this.Open_Click);
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
            this.Controls.Add(this.openNew);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GeneralParametersTablesForm";
            this.Text = "General Parameters Tables (GNPRTB.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.falconUnknown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falconUnknown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falconUnknown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falconUnknown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falconUnknown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empireUnknown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allianceUnknown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.falconExpertHyperspaceSpeedMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falconNoviceHyperspaceSpeedMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falconIntermediateHyperspaceSpeedMod)).EndInit();
            this.allianceGroupBox.ResumeLayout(false);
            this.allianceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allianceExpertHyperspaceSpeedMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allianceNoviceHyperspaceSpeedMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allianceIntermediateHyperspaceSpeedMod)).EndInit();
            this.costGroup.ResumeLayout(false);
            this.costGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empireExpertHyperspaceSpeedMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empireNoviceHyperspaceSpeedMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empireIntermediateHyperspaceSpeedMod)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
