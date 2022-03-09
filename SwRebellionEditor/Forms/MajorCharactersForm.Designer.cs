using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class MajorCharactersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label ItemName;
        private TrackBar ItemSelect;
        private GroupBox charLoyalGroup;
        private CheckBox rebelUnit;
        private CheckBox empireUnit;
        private GroupBox BasicGroup;
        private NumericUpDown combatVarNum;
        private NumericUpDown dipVarNum;
        private NumericUpDown espVarNum;
        private Label combatLabel;
        private NumericUpDown combatBaseNum;
        private Label diploLabel;
        private NumericUpDown dipBaseNum;
        private NumericUpDown espBaseNum;
        private Label espLabel;
        private GroupBox researchGroup;
        private Label resVarLabel;
        private Label resBaseLabel;
        private NumericUpDown facResVarNum;
        private NumericUpDown shipResVarNum;
        private NumericUpDown troopResVarNum;
        private Label facResLabel;
        private NumericUpDown facResBaseNum;
        private Label shipResLabel;
        private NumericUpDown shipResBaseNum;
        private NumericUpDown troopResBaseNum;
        private Label troopResLabel;
        private NumericUpDown loyalVarNum;
        private NumericUpDown loyalBaseNum;
        private Label loyaltyLabel;
        private Label statsVarLabel;
        private Label statsBaseLabel;
        private CheckBox betrayFlagCheck;
        private GroupBox jediStatGroup;
        private Label jediVarLabel;
        private Label jediBaseLabel;
        private NumericUpDown jediLevelVarNum;
        private Label label12;
        private NumericUpDown jediProbBaseNum;
        private NumericUpDown jediLevelBaseNum;
        private Label label13;
        private GroupBox cmdAbilityGroup;
        private CheckBox cmdCommCheck;
        private CheckBox cmdAdmCheck;
        private CheckBox cmdGenCheck;
        private GroupBox jediModStatGroup;
        private Label jediStatVarLabel;
        private Label jediDipLabel;
        private Label jediEspLabel;
        private Label jediStatBaseLabel;
        private NumericUpDown jediEspBaseNum;
        private NumericUpDown jediDipBaseNum;
        private NumericUpDown jediCombatVarNum;
        private NumericUpDown jediCombatBaseNum;
        private Label jediCombatLabel;
        private NumericUpDown jediDipVarNum;
        private NumericUpDown jediEspVarNum;
        private CheckBox trainJediCheck;
        private CheckBox knownJediCheck;
        private Button openNew;
        private Button SaveAs;
        private Button Cancel;
        private Button Ok;
        private GroupBox groupBox5;
        private RichTextBox encyText;
        private PictureBox ItemPicture;
        private ImageList majCharImageList;
        private Label leiaForceLabel;
        private ListView charListView;
        private NumericUpDown unknown3Num;
        private NumericUpDown idNum;
        private NumericUpDown prodFacNum;
        private Label unkown3Label;
        private NumericUpDown familyIdNum;
        private Label prodLabel;
        private Label idLabel;
        private Label familyLabel;
        private Label secProdFacNumlabel;
        private NumericUpDown secProdFacNum;
        private Label famHexLabel;
        private Label unitHexLabel;
        private NumericUpDown unitNum;
        private Label label1;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MajorCharactersForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.jediModStatGroup = new System.Windows.Forms.GroupBox();
            this.leiaForceLabel = new System.Windows.Forms.Label();
            this.jediStatVarLabel = new System.Windows.Forms.Label();
            this.jediDipLabel = new System.Windows.Forms.Label();
            this.jediEspLabel = new System.Windows.Forms.Label();
            this.jediStatBaseLabel = new System.Windows.Forms.Label();
            this.jediEspBaseNum = new System.Windows.Forms.NumericUpDown();
            this.jediDipBaseNum = new System.Windows.Forms.NumericUpDown();
            this.jediCombatVarNum = new System.Windows.Forms.NumericUpDown();
            this.jediCombatBaseNum = new System.Windows.Forms.NumericUpDown();
            this.jediCombatLabel = new System.Windows.Forms.Label();
            this.jediDipVarNum = new System.Windows.Forms.NumericUpDown();
            this.jediEspVarNum = new System.Windows.Forms.NumericUpDown();
            this.jediStatGroup = new System.Windows.Forms.GroupBox();
            this.trainJediCheck = new System.Windows.Forms.CheckBox();
            this.knownJediCheck = new System.Windows.Forms.CheckBox();
            this.jediVarLabel = new System.Windows.Forms.Label();
            this.jediBaseLabel = new System.Windows.Forms.Label();
            this.jediLevelVarNum = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.jediProbBaseNum = new System.Windows.Forms.NumericUpDown();
            this.jediLevelBaseNum = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.researchGroup = new System.Windows.Forms.GroupBox();
            this.resVarLabel = new System.Windows.Forms.Label();
            this.resBaseLabel = new System.Windows.Forms.Label();
            this.facResVarNum = new System.Windows.Forms.NumericUpDown();
            this.shipResVarNum = new System.Windows.Forms.NumericUpDown();
            this.troopResVarNum = new System.Windows.Forms.NumericUpDown();
            this.facResLabel = new System.Windows.Forms.Label();
            this.facResBaseNum = new System.Windows.Forms.NumericUpDown();
            this.shipResLabel = new System.Windows.Forms.Label();
            this.shipResBaseNum = new System.Windows.Forms.NumericUpDown();
            this.troopResBaseNum = new System.Windows.Forms.NumericUpDown();
            this.troopResLabel = new System.Windows.Forms.Label();
            this.BasicGroup = new System.Windows.Forms.GroupBox();
            this.loyalVarNum = new System.Windows.Forms.NumericUpDown();
            this.loyalBaseNum = new System.Windows.Forms.NumericUpDown();
            this.loyaltyLabel = new System.Windows.Forms.Label();
            this.statsVarLabel = new System.Windows.Forms.Label();
            this.statsBaseLabel = new System.Windows.Forms.Label();
            this.combatVarNum = new System.Windows.Forms.NumericUpDown();
            this.dipVarNum = new System.Windows.Forms.NumericUpDown();
            this.espVarNum = new System.Windows.Forms.NumericUpDown();
            this.combatLabel = new System.Windows.Forms.Label();
            this.combatBaseNum = new System.Windows.Forms.NumericUpDown();
            this.diploLabel = new System.Windows.Forms.Label();
            this.dipBaseNum = new System.Windows.Forms.NumericUpDown();
            this.espBaseNum = new System.Windows.Forms.NumericUpDown();
            this.espLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.famHexLabel = new System.Windows.Forms.Label();
            this.unitHexLabel = new System.Windows.Forms.Label();
            this.unitNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.unknown3Num = new System.Windows.Forms.NumericUpDown();
            this.idNum = new System.Windows.Forms.NumericUpDown();
            this.prodFacNum = new System.Windows.Forms.NumericUpDown();
            this.unkown3Label = new System.Windows.Forms.Label();
            this.familyIdNum = new System.Windows.Forms.NumericUpDown();
            this.prodLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.familyLabel = new System.Windows.Forms.Label();
            this.secProdFacNumlabel = new System.Windows.Forms.Label();
            this.secProdFacNum = new System.Windows.Forms.NumericUpDown();
            this.encyText = new System.Windows.Forms.RichTextBox();
            this.ItemName = new System.Windows.Forms.Label();
            this.ItemSelect = new System.Windows.Forms.TrackBar();
            this.charLoyalGroup = new System.Windows.Forms.GroupBox();
            this.betrayFlagCheck = new System.Windows.Forms.CheckBox();
            this.rebelUnit = new System.Windows.Forms.CheckBox();
            this.empireUnit = new System.Windows.Forms.CheckBox();
            this.cmdAbilityGroup = new System.Windows.Forms.GroupBox();
            this.cmdCommCheck = new System.Windows.Forms.CheckBox();
            this.cmdAdmCheck = new System.Windows.Forms.CheckBox();
            this.cmdGenCheck = new System.Windows.Forms.CheckBox();
            this.openNew = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.majCharImageList = new System.Windows.Forms.ImageList(this.components);
            this.charListView = new System.Windows.Forms.ListView();
            this.ItemPicture = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.jediModStatGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jediEspBaseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediDipBaseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediCombatVarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediCombatBaseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediDipVarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediEspVarNum)).BeginInit();
            this.jediStatGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jediLevelVarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediProbBaseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediLevelBaseNum)).BeginInit();
            this.researchGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facResVarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipResVarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopResVarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facResBaseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipResBaseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopResBaseNum)).BeginInit();
            this.BasicGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loyalVarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyalBaseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatVarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipVarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espVarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBaseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipBaseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espBaseNum)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown3Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodFacNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyIdNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secProdFacNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSelect)).BeginInit();
            this.charLoyalGroup.SuspendLayout();
            this.cmdAbilityGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(233, 137);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(569, 410);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.jediModStatGroup);
            this.tabPage1.Controls.Add(this.jediStatGroup);
            this.tabPage1.Controls.Add(this.researchGroup);
            this.tabPage1.Controls.Add(this.BasicGroup);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(561, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stats";
            // 
            // jediModStatGroup
            // 
            this.jediModStatGroup.Controls.Add(this.leiaForceLabel);
            this.jediModStatGroup.Controls.Add(this.jediStatVarLabel);
            this.jediModStatGroup.Controls.Add(this.jediDipLabel);
            this.jediModStatGroup.Controls.Add(this.jediEspLabel);
            this.jediModStatGroup.Controls.Add(this.jediStatBaseLabel);
            this.jediModStatGroup.Controls.Add(this.jediEspBaseNum);
            this.jediModStatGroup.Controls.Add(this.jediDipBaseNum);
            this.jediModStatGroup.Controls.Add(this.jediCombatVarNum);
            this.jediModStatGroup.Controls.Add(this.jediCombatBaseNum);
            this.jediModStatGroup.Controls.Add(this.jediCombatLabel);
            this.jediModStatGroup.Controls.Add(this.jediDipVarNum);
            this.jediModStatGroup.Controls.Add(this.jediEspVarNum);
            this.jediModStatGroup.Location = new System.Drawing.Point(273, 204);
            this.jediModStatGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediModStatGroup.Name = "jediModStatGroup";
            this.jediModStatGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediModStatGroup.Size = new System.Drawing.Size(262, 168);
            this.jediModStatGroup.TabIndex = 0;
            this.jediModStatGroup.TabStop = false;
            this.jediModStatGroup.Text = "Jedi Modded Stats, at Game Start";
            // 
            // leiaForceLabel
            // 
            this.leiaForceLabel.AutoSize = true;
            this.leiaForceLabel.Location = new System.Drawing.Point(7, 140);
            this.leiaForceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leiaForceLabel.Name = "leiaForceLabel";
            this.leiaForceLabel.Size = new System.Drawing.Size(79, 15);
            this.leiaForceLabel.TabIndex = 28;
            this.leiaForceLabel.Text = "--Leia Label--";
            // 
            // jediStatVarLabel
            // 
            this.jediStatVarLabel.AutoSize = true;
            this.jediStatVarLabel.BackColor = System.Drawing.Color.Silver;
            this.jediStatVarLabel.Enabled = false;
            this.jediStatVarLabel.Location = new System.Drawing.Point(182, 21);
            this.jediStatVarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jediStatVarLabel.Name = "jediStatVarLabel";
            this.jediStatVarLabel.Size = new System.Drawing.Size(51, 15);
            this.jediStatVarLabel.TabIndex = 27;
            this.jediStatVarLabel.Text = "Variance";
            // 
            // jediDipLabel
            // 
            this.jediDipLabel.AutoSize = true;
            this.jediDipLabel.Location = new System.Drawing.Point(7, 42);
            this.jediDipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jediDipLabel.Name = "jediDipLabel";
            this.jediDipLabel.Size = new System.Drawing.Size(64, 15);
            this.jediDipLabel.TabIndex = 18;
            this.jediDipLabel.Text = "Diplomacy";
            // 
            // jediEspLabel
            // 
            this.jediEspLabel.AutoSize = true;
            this.jediEspLabel.Location = new System.Drawing.Point(7, 75);
            this.jediEspLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jediEspLabel.Name = "jediEspLabel";
            this.jediEspLabel.Size = new System.Drawing.Size(61, 15);
            this.jediEspLabel.TabIndex = 19;
            this.jediEspLabel.Text = "Espionage";
            // 
            // jediStatBaseLabel
            // 
            this.jediStatBaseLabel.AutoSize = true;
            this.jediStatBaseLabel.BackColor = System.Drawing.Color.Silver;
            this.jediStatBaseLabel.Enabled = false;
            this.jediStatBaseLabel.Location = new System.Drawing.Point(115, 21);
            this.jediStatBaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jediStatBaseLabel.Name = "jediStatBaseLabel";
            this.jediStatBaseLabel.Size = new System.Drawing.Size(31, 15);
            this.jediStatBaseLabel.TabIndex = 26;
            this.jediStatBaseLabel.Text = "Base";
            // 
            // jediEspBaseNum
            // 
            this.jediEspBaseNum.Enabled = false;
            this.jediEspBaseNum.Location = new System.Drawing.Point(119, 73);
            this.jediEspBaseNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediEspBaseNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.jediEspBaseNum.Name = "jediEspBaseNum";
            this.jediEspBaseNum.Size = new System.Drawing.Size(59, 23);
            this.jediEspBaseNum.TabIndex = 0;
            this.jediEspBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediEspBaseNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // jediDipBaseNum
            // 
            this.jediDipBaseNum.Enabled = false;
            this.jediDipBaseNum.Location = new System.Drawing.Point(119, 39);
            this.jediDipBaseNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediDipBaseNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.jediDipBaseNum.Name = "jediDipBaseNum";
            this.jediDipBaseNum.Size = new System.Drawing.Size(59, 23);
            this.jediDipBaseNum.TabIndex = 0;
            this.jediDipBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediDipBaseNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // jediCombatVarNum
            // 
            this.jediCombatVarNum.Enabled = false;
            this.jediCombatVarNum.Location = new System.Drawing.Point(186, 103);
            this.jediCombatVarNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediCombatVarNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.jediCombatVarNum.Name = "jediCombatVarNum";
            this.jediCombatVarNum.Size = new System.Drawing.Size(59, 23);
            this.jediCombatVarNum.TabIndex = 0;
            this.jediCombatVarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediCombatVarNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // jediCombatBaseNum
            // 
            this.jediCombatBaseNum.Enabled = false;
            this.jediCombatBaseNum.Location = new System.Drawing.Point(119, 103);
            this.jediCombatBaseNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediCombatBaseNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.jediCombatBaseNum.Name = "jediCombatBaseNum";
            this.jediCombatBaseNum.Size = new System.Drawing.Size(59, 23);
            this.jediCombatBaseNum.TabIndex = 0;
            this.jediCombatBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediCombatBaseNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // jediCombatLabel
            // 
            this.jediCombatLabel.AutoSize = true;
            this.jediCombatLabel.Location = new System.Drawing.Point(7, 105);
            this.jediCombatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jediCombatLabel.Name = "jediCombatLabel";
            this.jediCombatLabel.Size = new System.Drawing.Size(50, 15);
            this.jediCombatLabel.TabIndex = 17;
            this.jediCombatLabel.Text = "Combat";
            // 
            // jediDipVarNum
            // 
            this.jediDipVarNum.Enabled = false;
            this.jediDipVarNum.Location = new System.Drawing.Point(186, 39);
            this.jediDipVarNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediDipVarNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.jediDipVarNum.Name = "jediDipVarNum";
            this.jediDipVarNum.Size = new System.Drawing.Size(59, 23);
            this.jediDipVarNum.TabIndex = 0;
            this.jediDipVarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediDipVarNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // jediEspVarNum
            // 
            this.jediEspVarNum.Enabled = false;
            this.jediEspVarNum.Location = new System.Drawing.Point(186, 73);
            this.jediEspVarNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediEspVarNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.jediEspVarNum.Name = "jediEspVarNum";
            this.jediEspVarNum.Size = new System.Drawing.Size(59, 23);
            this.jediEspVarNum.TabIndex = 0;
            this.jediEspVarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediEspVarNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // jediStatGroup
            // 
            this.jediStatGroup.Controls.Add(this.trainJediCheck);
            this.jediStatGroup.Controls.Add(this.knownJediCheck);
            this.jediStatGroup.Controls.Add(this.jediVarLabel);
            this.jediStatGroup.Controls.Add(this.jediBaseLabel);
            this.jediStatGroup.Controls.Add(this.jediLevelVarNum);
            this.jediStatGroup.Controls.Add(this.label12);
            this.jediStatGroup.Controls.Add(this.jediProbBaseNum);
            this.jediStatGroup.Controls.Add(this.jediLevelBaseNum);
            this.jediStatGroup.Controls.Add(this.label13);
            this.jediStatGroup.Location = new System.Drawing.Point(4, 204);
            this.jediStatGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediStatGroup.Name = "jediStatGroup";
            this.jediStatGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediStatGroup.Size = new System.Drawing.Size(262, 168);
            this.jediStatGroup.TabIndex = 6;
            this.jediStatGroup.TabStop = false;
            this.jediStatGroup.Text = "Jedi Stats";
            // 
            // trainJediCheck
            // 
            this.trainJediCheck.AutoSize = true;
            this.trainJediCheck.Location = new System.Drawing.Point(163, 37);
            this.trainJediCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trainJediCheck.Name = "trainJediCheck";
            this.trainJediCheck.Size = new System.Drawing.Size(74, 19);
            this.trainJediCheck.TabIndex = 22;
            this.trainJediCheck.Text = "Train Jedi";
            this.trainJediCheck.UseVisualStyleBackColor = true;
            this.trainJediCheck.CheckStateChanged += new System.EventHandler(this.updateTrainJediCheck);
            // 
            // knownJediCheck
            // 
            this.knownJediCheck.AutoSize = true;
            this.knownJediCheck.Location = new System.Drawing.Point(10, 37);
            this.knownJediCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.knownJediCheck.Name = "knownJediCheck";
            this.knownJediCheck.Size = new System.Drawing.Size(86, 19);
            this.knownJediCheck.TabIndex = 21;
            this.knownJediCheck.Text = "Known Jedi";
            this.knownJediCheck.UseVisualStyleBackColor = true;
            this.knownJediCheck.CheckStateChanged += new System.EventHandler(this.updateknownJediCheck);
            // 
            // jediVarLabel
            // 
            this.jediVarLabel.AutoSize = true;
            this.jediVarLabel.BackColor = System.Drawing.Color.Silver;
            this.jediVarLabel.Enabled = false;
            this.jediVarLabel.Location = new System.Drawing.Point(182, 85);
            this.jediVarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jediVarLabel.Name = "jediVarLabel";
            this.jediVarLabel.Size = new System.Drawing.Size(51, 15);
            this.jediVarLabel.TabIndex = 11;
            this.jediVarLabel.Text = "Variance";
            // 
            // jediBaseLabel
            // 
            this.jediBaseLabel.AutoSize = true;
            this.jediBaseLabel.BackColor = System.Drawing.Color.Silver;
            this.jediBaseLabel.Enabled = false;
            this.jediBaseLabel.Location = new System.Drawing.Point(115, 85);
            this.jediBaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jediBaseLabel.Name = "jediBaseLabel";
            this.jediBaseLabel.Size = new System.Drawing.Size(31, 15);
            this.jediBaseLabel.TabIndex = 10;
            this.jediBaseLabel.Text = "Base";
            // 
            // jediLevelVarNum
            // 
            this.jediLevelVarNum.Location = new System.Drawing.Point(186, 137);
            this.jediLevelVarNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediLevelVarNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.jediLevelVarNum.Name = "jediLevelVarNum";
            this.jediLevelVarNum.Size = new System.Drawing.Size(59, 23);
            this.jediLevelVarNum.TabIndex = 25;
            this.jediLevelVarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediLevelVarNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.jediLevelVarNum.ValueChanged += new System.EventHandler(this.updateJediLevelVarNum);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 106);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Probability";
            // 
            // jediProbBaseNum
            // 
            this.jediProbBaseNum.Location = new System.Drawing.Point(119, 104);
            this.jediProbBaseNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediProbBaseNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.jediProbBaseNum.Name = "jediProbBaseNum";
            this.jediProbBaseNum.Size = new System.Drawing.Size(59, 23);
            this.jediProbBaseNum.TabIndex = 23;
            this.jediProbBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediProbBaseNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.jediProbBaseNum.ValueChanged += new System.EventHandler(this.updateJediProbBaseNum);
            // 
            // jediLevelBaseNum
            // 
            this.jediLevelBaseNum.Location = new System.Drawing.Point(119, 137);
            this.jediLevelBaseNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediLevelBaseNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.jediLevelBaseNum.Name = "jediLevelBaseNum";
            this.jediLevelBaseNum.Size = new System.Drawing.Size(59, 23);
            this.jediLevelBaseNum.TabIndex = 24;
            this.jediLevelBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediLevelBaseNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.jediLevelBaseNum.ValueChanged += new System.EventHandler(this.updateJediLevelBaseNum);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 140);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Jedi Level";
            // 
            // researchGroup
            // 
            this.researchGroup.Controls.Add(this.resVarLabel);
            this.researchGroup.Controls.Add(this.resBaseLabel);
            this.researchGroup.Controls.Add(this.facResVarNum);
            this.researchGroup.Controls.Add(this.shipResVarNum);
            this.researchGroup.Controls.Add(this.troopResVarNum);
            this.researchGroup.Controls.Add(this.facResLabel);
            this.researchGroup.Controls.Add(this.facResBaseNum);
            this.researchGroup.Controls.Add(this.shipResLabel);
            this.researchGroup.Controls.Add(this.shipResBaseNum);
            this.researchGroup.Controls.Add(this.troopResBaseNum);
            this.researchGroup.Controls.Add(this.troopResLabel);
            this.researchGroup.Location = new System.Drawing.Point(273, 7);
            this.researchGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchGroup.Name = "researchGroup";
            this.researchGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchGroup.Size = new System.Drawing.Size(262, 171);
            this.researchGroup.TabIndex = 5;
            this.researchGroup.TabStop = false;
            this.researchGroup.Text = "Research Stats";
            // 
            // resVarLabel
            // 
            this.resVarLabel.AutoSize = true;
            this.resVarLabel.BackColor = System.Drawing.Color.Silver;
            this.resVarLabel.Enabled = false;
            this.resVarLabel.Location = new System.Drawing.Point(182, 17);
            this.resVarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resVarLabel.Name = "resVarLabel";
            this.resVarLabel.Size = new System.Drawing.Size(51, 15);
            this.resVarLabel.TabIndex = 11;
            this.resVarLabel.Text = "Variance";
            // 
            // resBaseLabel
            // 
            this.resBaseLabel.AutoSize = true;
            this.resBaseLabel.BackColor = System.Drawing.Color.Silver;
            this.resBaseLabel.Enabled = false;
            this.resBaseLabel.Location = new System.Drawing.Point(115, 17);
            this.resBaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resBaseLabel.Name = "resBaseLabel";
            this.resBaseLabel.Size = new System.Drawing.Size(31, 15);
            this.resBaseLabel.TabIndex = 10;
            this.resBaseLabel.Text = "Base";
            // 
            // facResVarNum
            // 
            this.facResVarNum.Location = new System.Drawing.Point(186, 99);
            this.facResVarNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facResVarNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.facResVarNum.Name = "facResVarNum";
            this.facResVarNum.Size = new System.Drawing.Size(59, 23);
            this.facResVarNum.TabIndex = 9;
            this.facResVarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.facResVarNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.facResVarNum.ValueChanged += new System.EventHandler(this.updateFacResVarNum);
            // 
            // shipResVarNum
            // 
            this.shipResVarNum.Location = new System.Drawing.Point(186, 36);
            this.shipResVarNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shipResVarNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.shipResVarNum.Name = "shipResVarNum";
            this.shipResVarNum.Size = new System.Drawing.Size(59, 23);
            this.shipResVarNum.TabIndex = 5;
            this.shipResVarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shipResVarNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.shipResVarNum.ValueChanged += new System.EventHandler(this.updateShipResVarNum);
            // 
            // troopResVarNum
            // 
            this.troopResVarNum.Location = new System.Drawing.Point(186, 69);
            this.troopResVarNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopResVarNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.troopResVarNum.Name = "troopResVarNum";
            this.troopResVarNum.Size = new System.Drawing.Size(59, 23);
            this.troopResVarNum.TabIndex = 7;
            this.troopResVarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.troopResVarNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.troopResVarNum.ValueChanged += new System.EventHandler(this.updateTroopResVarNum);
            // 
            // facResLabel
            // 
            this.facResLabel.AutoSize = true;
            this.facResLabel.Location = new System.Drawing.Point(7, 102);
            this.facResLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.facResLabel.Name = "facResLabel";
            this.facResLabel.Size = new System.Drawing.Size(44, 15);
            this.facResLabel.TabIndex = 0;
            this.facResLabel.Text = "Facility";
            // 
            // facResBaseNum
            // 
            this.facResBaseNum.Location = new System.Drawing.Point(119, 99);
            this.facResBaseNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facResBaseNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.facResBaseNum.Name = "facResBaseNum";
            this.facResBaseNum.Size = new System.Drawing.Size(59, 23);
            this.facResBaseNum.TabIndex = 8;
            this.facResBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.facResBaseNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.facResBaseNum.ValueChanged += new System.EventHandler(this.updateFacResBaseNum);
            // 
            // shipResLabel
            // 
            this.shipResLabel.AutoSize = true;
            this.shipResLabel.Location = new System.Drawing.Point(7, 38);
            this.shipResLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shipResLabel.Name = "shipResLabel";
            this.shipResLabel.Size = new System.Drawing.Size(30, 15);
            this.shipResLabel.TabIndex = 0;
            this.shipResLabel.Text = "Ship";
            // 
            // shipResBaseNum
            // 
            this.shipResBaseNum.Location = new System.Drawing.Point(119, 36);
            this.shipResBaseNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shipResBaseNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.shipResBaseNum.Name = "shipResBaseNum";
            this.shipResBaseNum.Size = new System.Drawing.Size(59, 23);
            this.shipResBaseNum.TabIndex = 4;
            this.shipResBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shipResBaseNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.shipResBaseNum.ValueChanged += new System.EventHandler(this.updateShipResBaseNum);
            // 
            // troopResBaseNum
            // 
            this.troopResBaseNum.Location = new System.Drawing.Point(119, 69);
            this.troopResBaseNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopResBaseNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.troopResBaseNum.Name = "troopResBaseNum";
            this.troopResBaseNum.Size = new System.Drawing.Size(59, 23);
            this.troopResBaseNum.TabIndex = 6;
            this.troopResBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.troopResBaseNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.troopResBaseNum.ValueChanged += new System.EventHandler(this.updateTroopResBaseNum);
            // 
            // troopResLabel
            // 
            this.troopResLabel.AutoSize = true;
            this.troopResLabel.Location = new System.Drawing.Point(7, 72);
            this.troopResLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.troopResLabel.Name = "troopResLabel";
            this.troopResLabel.Size = new System.Drawing.Size(37, 15);
            this.troopResLabel.TabIndex = 0;
            this.troopResLabel.Text = "Troop";
            // 
            // BasicGroup
            // 
            this.BasicGroup.Controls.Add(this.loyalVarNum);
            this.BasicGroup.Controls.Add(this.loyalBaseNum);
            this.BasicGroup.Controls.Add(this.loyaltyLabel);
            this.BasicGroup.Controls.Add(this.statsVarLabel);
            this.BasicGroup.Controls.Add(this.statsBaseLabel);
            this.BasicGroup.Controls.Add(this.combatVarNum);
            this.BasicGroup.Controls.Add(this.dipVarNum);
            this.BasicGroup.Controls.Add(this.espVarNum);
            this.BasicGroup.Controls.Add(this.combatLabel);
            this.BasicGroup.Controls.Add(this.combatBaseNum);
            this.BasicGroup.Controls.Add(this.diploLabel);
            this.BasicGroup.Controls.Add(this.dipBaseNum);
            this.BasicGroup.Controls.Add(this.espBaseNum);
            this.BasicGroup.Controls.Add(this.espLabel);
            this.BasicGroup.Location = new System.Drawing.Point(4, 3);
            this.BasicGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BasicGroup.Name = "BasicGroup";
            this.BasicGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BasicGroup.Size = new System.Drawing.Size(262, 174);
            this.BasicGroup.TabIndex = 4;
            this.BasicGroup.TabStop = false;
            this.BasicGroup.Text = "Basic Stats";
            // 
            // loyalVarNum
            // 
            this.loyalVarNum.Location = new System.Drawing.Point(186, 129);
            this.loyalVarNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loyalVarNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.loyalVarNum.Name = "loyalVarNum";
            this.loyalVarNum.Size = new System.Drawing.Size(59, 23);
            this.loyalVarNum.TabIndex = 11;
            this.loyalVarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.loyalVarNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.loyalVarNum.ValueChanged += new System.EventHandler(this.updateLoyalVarNum);
            // 
            // loyalBaseNum
            // 
            this.loyalBaseNum.Location = new System.Drawing.Point(119, 129);
            this.loyalBaseNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loyalBaseNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.loyalBaseNum.Name = "loyalBaseNum";
            this.loyalBaseNum.Size = new System.Drawing.Size(59, 23);
            this.loyalBaseNum.TabIndex = 10;
            this.loyalBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.loyalBaseNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.loyalBaseNum.ValueChanged += new System.EventHandler(this.updateLoyalBaseNum);
            // 
            // loyaltyLabel
            // 
            this.loyaltyLabel.AutoSize = true;
            this.loyaltyLabel.Location = new System.Drawing.Point(7, 137);
            this.loyaltyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loyaltyLabel.Name = "loyaltyLabel";
            this.loyaltyLabel.Size = new System.Drawing.Size(45, 15);
            this.loyaltyLabel.TabIndex = 12;
            this.loyaltyLabel.Text = "Loyalty";
            // 
            // statsVarLabel
            // 
            this.statsVarLabel.AutoSize = true;
            this.statsVarLabel.BackColor = System.Drawing.Color.Silver;
            this.statsVarLabel.Enabled = false;
            this.statsVarLabel.Location = new System.Drawing.Point(182, 17);
            this.statsVarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statsVarLabel.Name = "statsVarLabel";
            this.statsVarLabel.Size = new System.Drawing.Size(51, 15);
            this.statsVarLabel.TabIndex = 11;
            this.statsVarLabel.Text = "Variance";
            // 
            // statsBaseLabel
            // 
            this.statsBaseLabel.AutoSize = true;
            this.statsBaseLabel.BackColor = System.Drawing.Color.Silver;
            this.statsBaseLabel.Enabled = false;
            this.statsBaseLabel.Location = new System.Drawing.Point(115, 17);
            this.statsBaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statsBaseLabel.Name = "statsBaseLabel";
            this.statsBaseLabel.Size = new System.Drawing.Size(31, 15);
            this.statsBaseLabel.TabIndex = 10;
            this.statsBaseLabel.Text = "Base";
            // 
            // combatVarNum
            // 
            this.combatVarNum.Location = new System.Drawing.Point(186, 99);
            this.combatVarNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combatVarNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.combatVarNum.Name = "combatVarNum";
            this.combatVarNum.Size = new System.Drawing.Size(59, 23);
            this.combatVarNum.TabIndex = 9;
            this.combatVarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.combatVarNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.combatVarNum.ValueChanged += new System.EventHandler(this.updateCombatVarNum);
            // 
            // dipVarNum
            // 
            this.dipVarNum.Location = new System.Drawing.Point(186, 36);
            this.dipVarNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dipVarNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.dipVarNum.Name = "dipVarNum";
            this.dipVarNum.Size = new System.Drawing.Size(59, 23);
            this.dipVarNum.TabIndex = 5;
            this.dipVarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dipVarNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.dipVarNum.ValueChanged += new System.EventHandler(this.updateDipVarNum);
            // 
            // espVarNum
            // 
            this.espVarNum.Location = new System.Drawing.Point(186, 69);
            this.espVarNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.espVarNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.espVarNum.Name = "espVarNum";
            this.espVarNum.Size = new System.Drawing.Size(59, 23);
            this.espVarNum.TabIndex = 7;
            this.espVarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.espVarNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.espVarNum.ValueChanged += new System.EventHandler(this.updateEspVarNum);
            // 
            // combatLabel
            // 
            this.combatLabel.AutoSize = true;
            this.combatLabel.Location = new System.Drawing.Point(7, 102);
            this.combatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.combatLabel.Name = "combatLabel";
            this.combatLabel.Size = new System.Drawing.Size(50, 15);
            this.combatLabel.TabIndex = 0;
            this.combatLabel.Text = "Combat";
            // 
            // combatBaseNum
            // 
            this.combatBaseNum.Location = new System.Drawing.Point(119, 99);
            this.combatBaseNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combatBaseNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.combatBaseNum.Name = "combatBaseNum";
            this.combatBaseNum.Size = new System.Drawing.Size(59, 23);
            this.combatBaseNum.TabIndex = 8;
            this.combatBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.combatBaseNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.combatBaseNum.ValueChanged += new System.EventHandler(this.updateCombatBaseNum);
            // 
            // diploLabel
            // 
            this.diploLabel.AutoSize = true;
            this.diploLabel.Location = new System.Drawing.Point(7, 38);
            this.diploLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diploLabel.Name = "diploLabel";
            this.diploLabel.Size = new System.Drawing.Size(64, 15);
            this.diploLabel.TabIndex = 0;
            this.diploLabel.Text = "Diplomacy";
            // 
            // dipBaseNum
            // 
            this.dipBaseNum.Location = new System.Drawing.Point(119, 36);
            this.dipBaseNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dipBaseNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.dipBaseNum.Name = "dipBaseNum";
            this.dipBaseNum.Size = new System.Drawing.Size(59, 23);
            this.dipBaseNum.TabIndex = 4;
            this.dipBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dipBaseNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.dipBaseNum.ValueChanged += new System.EventHandler(this.updateDipBaseNum);
            // 
            // espBaseNum
            // 
            this.espBaseNum.Location = new System.Drawing.Point(119, 69);
            this.espBaseNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.espBaseNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.espBaseNum.Name = "espBaseNum";
            this.espBaseNum.Size = new System.Drawing.Size(59, 23);
            this.espBaseNum.TabIndex = 6;
            this.espBaseNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.espBaseNum.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.espBaseNum.ValueChanged += new System.EventHandler(this.updateEspBaseNum);
            // 
            // espLabel
            // 
            this.espLabel.AutoSize = true;
            this.espLabel.Location = new System.Drawing.Point(7, 72);
            this.espLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.espLabel.Name = "espLabel";
            this.espLabel.Size = new System.Drawing.Size(61, 15);
            this.espLabel.TabIndex = 0;
            this.espLabel.Text = "Espionage";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.encyText);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(561, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ency";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.famHexLabel);
            this.groupBox5.Controls.Add(this.unitHexLabel);
            this.groupBox5.Controls.Add(this.unitNum);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.unknown3Num);
            this.groupBox5.Controls.Add(this.idNum);
            this.groupBox5.Controls.Add(this.prodFacNum);
            this.groupBox5.Controls.Add(this.unkown3Label);
            this.groupBox5.Controls.Add(this.familyIdNum);
            this.groupBox5.Controls.Add(this.prodLabel);
            this.groupBox5.Controls.Add(this.idLabel);
            this.groupBox5.Controls.Add(this.familyLabel);
            this.groupBox5.Controls.Add(this.secProdFacNumlabel);
            this.groupBox5.Controls.Add(this.secProdFacNum);
            this.groupBox5.Location = new System.Drawing.Point(4, 167);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(550, 209);
            this.groupBox5.TabIndex = 135;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DAT Misc";
            // 
            // famHexLabel
            // 
            this.famHexLabel.AutoSize = true;
            this.famHexLabel.Enabled = false;
            this.famHexLabel.Location = new System.Drawing.Point(340, 88);
            this.famHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.famHexLabel.Name = "famHexLabel";
            this.famHexLabel.Size = new System.Drawing.Size(26, 15);
            this.famHexLabel.TabIndex = 1127;
            this.famHexLabel.Text = "hex";
            // 
            // unitHexLabel
            // 
            this.unitHexLabel.AutoSize = true;
            this.unitHexLabel.Enabled = false;
            this.unitHexLabel.Location = new System.Drawing.Point(340, 175);
            this.unitHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitHexLabel.Name = "unitHexLabel";
            this.unitHexLabel.Size = new System.Drawing.Size(26, 15);
            this.unitHexLabel.TabIndex = 1126;
            this.unitHexLabel.Text = "hex";
            // 
            // unitNum
            // 
            this.unitNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.unitNum.Enabled = false;
            this.unitNum.Location = new System.Drawing.Point(279, 173);
            this.unitNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unitNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.unitNum.Name = "unitNum";
            this.unitNum.Size = new System.Drawing.Size(59, 23);
            this.unitNum.TabIndex = 1125;
            this.unitNum.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(167, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1124;
            this.label1.Text = "Unit ID";
            // 
            // unknown3Num
            // 
            this.unknown3Num.Enabled = false;
            this.unknown3Num.Location = new System.Drawing.Point(279, 113);
            this.unknown3Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknown3Num.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknown3Num.Name = "unknown3Num";
            this.unknown3Num.Size = new System.Drawing.Size(59, 23);
            this.unknown3Num.TabIndex = 146;
            this.unknown3Num.TabStop = false;
            // 
            // idNum
            // 
            this.idNum.Enabled = false;
            this.idNum.Location = new System.Drawing.Point(279, 143);
            this.idNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.idNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.idNum.Name = "idNum";
            this.idNum.Size = new System.Drawing.Size(59, 23);
            this.idNum.TabIndex = 148;
            this.idNum.TabStop = false;
            // 
            // prodFacNum
            // 
            this.prodFacNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.prodFacNum.Enabled = false;
            this.prodFacNum.Location = new System.Drawing.Point(279, 22);
            this.prodFacNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prodFacNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.prodFacNum.Name = "prodFacNum";
            this.prodFacNum.Size = new System.Drawing.Size(59, 23);
            this.prodFacNum.TabIndex = 138;
            this.prodFacNum.TabStop = false;
            this.prodFacNum.ValueChanged += new System.EventHandler(this.updateProdFacNum);
            // 
            // unkown3Label
            // 
            this.unkown3Label.AutoSize = true;
            this.unkown3Label.Enabled = false;
            this.unkown3Label.Location = new System.Drawing.Point(167, 115);
            this.unkown3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unkown3Label.Name = "unkown3Label";
            this.unkown3Label.Size = new System.Drawing.Size(58, 15);
            this.unkown3Label.TabIndex = 145;
            this.unkown3Label.Text = "Unknown";
            // 
            // familyIdNum
            // 
            this.familyIdNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.familyIdNum.Enabled = false;
            this.familyIdNum.Location = new System.Drawing.Point(279, 83);
            this.familyIdNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.familyIdNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.familyIdNum.Name = "familyIdNum";
            this.familyIdNum.Size = new System.Drawing.Size(59, 23);
            this.familyIdNum.TabIndex = 147;
            this.familyIdNum.TabStop = false;
            this.familyIdNum.ValueChanged += new System.EventHandler(this.updateFamilyIdNum);
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.Enabled = false;
            this.prodLabel.Location = new System.Drawing.Point(167, 24);
            this.prodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(106, 15);
            this.prodLabel.TabIndex = 140;
            this.prodLabel.Text = "Production Facility";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Enabled = false;
            this.idLabel.Location = new System.Drawing.Point(167, 145);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(85, 15);
            this.idLabel.TabIndex = 144;
            this.idLabel.Text = "TextStra.DLL ID";
            // 
            // familyLabel
            // 
            this.familyLabel.AutoSize = true;
            this.familyLabel.Enabled = false;
            this.familyLabel.Location = new System.Drawing.Point(167, 81);
            this.familyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyLabel.Name = "familyLabel";
            this.familyLabel.Size = new System.Drawing.Size(56, 15);
            this.familyLabel.TabIndex = 143;
            this.familyLabel.Text = "Family ID";
            // 
            // secProdFacNumlabel
            // 
            this.secProdFacNumlabel.AutoSize = true;
            this.secProdFacNumlabel.Enabled = false;
            this.secProdFacNumlabel.Location = new System.Drawing.Point(167, 53);
            this.secProdFacNumlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secProdFacNumlabel.Name = "secProdFacNumlabel";
            this.secProdFacNumlabel.Size = new System.Drawing.Size(92, 15);
            this.secProdFacNumlabel.TabIndex = 142;
            this.secProdFacNumlabel.Text = "Prod Facility + 1";
            // 
            // secProdFacNum
            // 
            this.secProdFacNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.secProdFacNum.Enabled = false;
            this.secProdFacNum.Location = new System.Drawing.Point(279, 53);
            this.secProdFacNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secProdFacNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.secProdFacNum.Name = "secProdFacNum";
            this.secProdFacNum.Size = new System.Drawing.Size(59, 23);
            this.secProdFacNum.TabIndex = 141;
            this.secProdFacNum.TabStop = false;
            this.secProdFacNum.ValueChanged += new System.EventHandler(this.updateSecProdFacNum);
            // 
            // encyText
            // 
            this.encyText.Cursor = System.Windows.Forms.Cursors.No;
            this.encyText.Enabled = false;
            this.encyText.Location = new System.Drawing.Point(0, 0);
            this.encyText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.encyText.Name = "encyText";
            this.encyText.Size = new System.Drawing.Size(559, 160);
            this.encyText.TabIndex = 134;
            this.encyText.TabStop = false;
            this.encyText.Text = "Not Implemented yet....Encylopedia Data...Will add .Someday";
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Location = new System.Drawing.Point(230, 88);
            this.ItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(116, 15);
            this.ItemName.TabIndex = 120;
            this.ItemName.Text = "-- Item name here --";
            // 
            // ItemSelect
            // 
            this.ItemSelect.LargeChange = 4;
            this.ItemSelect.Location = new System.Drawing.Point(233, 32);
            this.ItemSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ItemSelect.Maximum = 5;
            this.ItemSelect.Name = "ItemSelect";
            this.ItemSelect.Size = new System.Drawing.Size(121, 45);
            this.ItemSelect.TabIndex = 1;
            this.ItemSelect.ValueChanged += new System.EventHandler(this.MajCharFormUpdateUI);
            // 
            // charLoyalGroup
            // 
            this.charLoyalGroup.Controls.Add(this.betrayFlagCheck);
            this.charLoyalGroup.Controls.Add(this.rebelUnit);
            this.charLoyalGroup.Controls.Add(this.empireUnit);
            this.charLoyalGroup.Location = new System.Drawing.Point(398, 32);
            this.charLoyalGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.charLoyalGroup.Name = "charLoyalGroup";
            this.charLoyalGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.charLoyalGroup.Size = new System.Drawing.Size(182, 98);
            this.charLoyalGroup.TabIndex = 2;
            this.charLoyalGroup.TabStop = false;
            this.charLoyalGroup.Text = "Character Loyalty";
            // 
            // betrayFlagCheck
            // 
            this.betrayFlagCheck.AutoSize = true;
            this.betrayFlagCheck.Location = new System.Drawing.Point(7, 75);
            this.betrayFlagCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.betrayFlagCheck.Name = "betrayFlagCheck";
            this.betrayFlagCheck.Size = new System.Drawing.Size(119, 19);
            this.betrayFlagCheck.TabIndex = 17;
            this.betrayFlagCheck.Text = "Won\'t Betray Flag";
            this.betrayFlagCheck.UseVisualStyleBackColor = true;
            this.betrayFlagCheck.CheckStateChanged += new System.EventHandler(this.updateBetrayFlagCheck);
            // 
            // rebelUnit
            // 
            this.rebelUnit.AutoSize = true;
            this.rebelUnit.Location = new System.Drawing.Point(7, 22);
            this.rebelUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rebelUnit.Name = "rebelUnit";
            this.rebelUnit.Size = new System.Drawing.Size(68, 19);
            this.rebelUnit.TabIndex = 15;
            this.rebelUnit.Text = "Alliance";
            this.rebelUnit.UseVisualStyleBackColor = true;
            this.rebelUnit.CheckStateChanged += new System.EventHandler(this.updateRebelUnitCheck);
            // 
            // empireUnit
            // 
            this.empireUnit.AutoSize = true;
            this.empireUnit.Location = new System.Drawing.Point(7, 48);
            this.empireUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.empireUnit.Name = "empireUnit";
            this.empireUnit.Size = new System.Drawing.Size(69, 19);
            this.empireUnit.TabIndex = 16;
            this.empireUnit.Text = "Imperial";
            this.empireUnit.UseVisualStyleBackColor = true;
            this.empireUnit.CheckStateChanged += new System.EventHandler(this.updateEmpireUnitCheck);
            // 
            // cmdAbilityGroup
            // 
            this.cmdAbilityGroup.Controls.Add(this.cmdCommCheck);
            this.cmdAbilityGroup.Controls.Add(this.cmdAdmCheck);
            this.cmdAbilityGroup.Controls.Add(this.cmdGenCheck);
            this.cmdAbilityGroup.Location = new System.Drawing.Point(612, 32);
            this.cmdAbilityGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdAbilityGroup.Name = "cmdAbilityGroup";
            this.cmdAbilityGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdAbilityGroup.Size = new System.Drawing.Size(182, 98);
            this.cmdAbilityGroup.TabIndex = 3;
            this.cmdAbilityGroup.TabStop = false;
            this.cmdAbilityGroup.Text = "Command Ability";
            // 
            // cmdCommCheck
            // 
            this.cmdCommCheck.AutoSize = true;
            this.cmdCommCheck.Location = new System.Drawing.Point(7, 75);
            this.cmdCommCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdCommCheck.Name = "cmdCommCheck";
            this.cmdCommCheck.Size = new System.Drawing.Size(93, 19);
            this.cmdCommCheck.TabIndex = 20;
            this.cmdCommCheck.Text = "Commander";
            this.cmdCommCheck.UseVisualStyleBackColor = true;
            this.cmdCommCheck.CheckStateChanged += new System.EventHandler(this.updateCmdCommCheck);
            // 
            // cmdAdmCheck
            // 
            this.cmdAdmCheck.AutoSize = true;
            this.cmdAdmCheck.Location = new System.Drawing.Point(7, 22);
            this.cmdAdmCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdAdmCheck.Name = "cmdAdmCheck";
            this.cmdAdmCheck.Size = new System.Drawing.Size(68, 19);
            this.cmdAdmCheck.TabIndex = 18;
            this.cmdAdmCheck.Text = "Admiral";
            this.cmdAdmCheck.UseVisualStyleBackColor = true;
            this.cmdAdmCheck.CheckStateChanged += new System.EventHandler(this.updateCmdAdmCheck);
            // 
            // cmdGenCheck
            // 
            this.cmdGenCheck.AutoSize = true;
            this.cmdGenCheck.Location = new System.Drawing.Point(7, 48);
            this.cmdGenCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdGenCheck.Name = "cmdGenCheck";
            this.cmdGenCheck.Size = new System.Drawing.Size(66, 19);
            this.cmdGenCheck.TabIndex = 19;
            this.cmdGenCheck.Text = "General";
            this.cmdGenCheck.UseVisualStyleBackColor = true;
            this.cmdGenCheck.CheckStateChanged += new System.EventHandler(this.updateCmdGenCheck);
            // 
            // openNew
            // 
            this.openNew.Location = new System.Drawing.Point(663, 554);
            this.openNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openNew.Name = "openNew";
            this.openNew.Size = new System.Drawing.Size(88, 27);
            this.openNew.TabIndex = 0;
            this.openNew.TabStop = false;
            this.openNew.Text = "Open...";
            this.openNew.UseVisualStyleBackColor = true;
            this.openNew.Click += new System.EventHandler(this.openNew_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Location = new System.Drawing.Point(568, 554);
            this.SaveAs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(88, 27);
            this.SaveAs.TabIndex = 0;
            this.SaveAs.TabStop = false;
            this.SaveAs.Text = "&SaveAs...";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(390, 554);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 27);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(295, 554);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 7;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // majCharImageList
            // 
            this.majCharImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.majCharImageList.ImageSize = new System.Drawing.Size(120, 60);
            this.majCharImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // charListView
            // 
            this.charListView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.charListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.charListView.GridLines = true;
            this.charListView.LargeImageList = this.majCharImageList;
            this.charListView.Location = new System.Drawing.Point(0, 110);
            this.charListView.Margin = new System.Windows.Forms.Padding(0);
            this.charListView.MultiSelect = false;
            this.charListView.Name = "charListView";
            this.charListView.ShowGroups = false;
            this.charListView.Size = new System.Drawing.Size(220, 475);
            this.charListView.TabIndex = 0;
            this.charListView.TabStop = false;
            this.charListView.UseCompatibleStateImageBehavior = false;
            this.charListView.Click += new System.EventHandler(this.charListView_Click);
            this.charListView.DoubleClick += new System.EventHandler(this.charListView_DoubleClick);
            // 
            // ItemPicture
            // 
            this.ItemPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemPicture.InitialImage = null;
            this.ItemPicture.Location = new System.Drawing.Point(0, 0);
            this.ItemPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ItemPicture.Name = "ItemPicture";
            this.ItemPicture.Size = new System.Drawing.Size(220, 110);
            this.ItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ItemPicture.TabIndex = 134;
            this.ItemPicture.TabStop = false;
            this.ItemPicture.Click += new System.EventHandler(this.ItemPicture_Click);
            // 
            // MajorCharactersForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(810, 584);
            this.Controls.Add(this.charListView);
            this.Controls.Add(this.ItemPicture);
            this.Controls.Add(this.openNew);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.cmdAbilityGroup);
            this.Controls.Add(this.charLoyalGroup);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.ItemSelect);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(826, 623);
            this.MinimumSize = new System.Drawing.Size(826, 623);
            this.Name = "MajorCharactersForm";
            this.Text = "Major Characters (MJCHARSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MajCharForm_FormClosing);
            this.Load += new System.EventHandler(this.MajCharForm_Load);
            this.Enter += new System.EventHandler(this.MajCharFormUpdateUI);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MajCharForm_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.jediModStatGroup.ResumeLayout(false);
            this.jediModStatGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jediEspBaseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediDipBaseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediCombatVarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediCombatBaseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediDipVarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediEspVarNum)).EndInit();
            this.jediStatGroup.ResumeLayout(false);
            this.jediStatGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jediLevelVarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediProbBaseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediLevelBaseNum)).EndInit();
            this.researchGroup.ResumeLayout(false);
            this.researchGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facResVarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipResVarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopResVarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facResBaseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipResBaseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopResBaseNum)).EndInit();
            this.BasicGroup.ResumeLayout(false);
            this.BasicGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loyalVarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyalBaseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatVarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipVarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espVarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBaseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipBaseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espBaseNum)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown3Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodFacNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyIdNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secProdFacNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSelect)).EndInit();
            this.charLoyalGroup.ResumeLayout(false);
            this.charLoyalGroup.PerformLayout();
            this.cmdAbilityGroup.ResumeLayout(false);
            this.cmdAbilityGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}