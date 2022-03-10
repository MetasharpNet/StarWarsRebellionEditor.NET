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
        private Button Open;
        private Button SaveAs;
        private Button Cancel;
        private Button Ok;
        private TrackBar selector;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label encyclopediaName;
        private GroupBox charLoyalGroup;
        private CheckBox isAllianceUnit;
        private CheckBox isEmpireUnit;
        private GroupBox BasicGroup;
        private NumericUpDown combatVariance;
        private NumericUpDown diplomacyVariance;
        private NumericUpDown espionageVariance;
        private Label combatLabel;
        private NumericUpDown combatBase;
        private Label diploLabel;
        private NumericUpDown diplomacyBase;
        private NumericUpDown espionageBase;
        private Label espLabel;
        private GroupBox researchGroup;
        private Label resVarLabel;
        private Label resBaseLabel;
        private NumericUpDown facilitiesResearchVariance;
        private NumericUpDown shipResearchVariance;
        private NumericUpDown troopsReseachVariance;
        private Label facResLabel;
        private NumericUpDown facilitiesResearchBase;
        private Label shipResLabel;
        private NumericUpDown shipResearchBase;
        private NumericUpDown troopsResearchBase;
        private Label troopResLabel;
        private NumericUpDown loyaltyVariance;
        private NumericUpDown loyaltyBase;
        private Label loyaltyLabel;
        private Label statsVarLabel;
        private Label statsBaseLabel;
        private CheckBox isUnableToBetray;
        private GroupBox jediStatGroup;
        private Label jediVarLabel;
        private Label jediBaseLabel;
        private NumericUpDown jediLevelVariance;
        private Label label12;
        private NumericUpDown jediProbabilityBase;
        private NumericUpDown jediLevelBase;
        private Label label13;
        private GroupBox cmdAbilityGroup;
        private CheckBox canBeCommander;
        private CheckBox canBeAdmiral;
        private CheckBox canBeGeneral;
        private GroupBox jediModStatGroup;
        private Label jediStatVarLabel;
        private Label jediDipLabel;
        private Label jediEspLabel;
        private Label jediStatBaseLabel;
        private NumericUpDown jediEspionageBase;
        private NumericUpDown jediDiplomacyBase;
        private NumericUpDown jediCombatVariance;
        private NumericUpDown jediCombatBase;
        private Label jediCombatLabel;
        private NumericUpDown jediDiplomacyVariance;
        private NumericUpDown jediEspionageVariance;
        private CheckBox isJediTrainer;
        private CheckBox isKnownJedi;
        private GroupBox groupBox5;
        private RichTextBox encyText;
        private PictureBox picture;
        private ImageList majCharImageList;
        private Label leiaForceLabel;
        private ListView charListView;
        private NumericUpDown unknown3Num;
        private NumericUpDown textStraDllId;
        private NumericUpDown prodFacNum;
        private Label unkown3Label;
        private NumericUpDown familyId;
        private Label prodLabel;
        private Label idLabel;
        private Label familyLabel;
        private Label secProdFacNumlabel;
        private NumericUpDown secProdFacNum;
        private Label familyIdHexLabel;
        private Label unitIdHexLabel;
        private NumericUpDown unitId;
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
            this.jediEspionageBase = new System.Windows.Forms.NumericUpDown();
            this.jediDiplomacyBase = new System.Windows.Forms.NumericUpDown();
            this.jediCombatVariance = new System.Windows.Forms.NumericUpDown();
            this.jediCombatBase = new System.Windows.Forms.NumericUpDown();
            this.jediCombatLabel = new System.Windows.Forms.Label();
            this.jediDiplomacyVariance = new System.Windows.Forms.NumericUpDown();
            this.jediEspionageVariance = new System.Windows.Forms.NumericUpDown();
            this.jediStatGroup = new System.Windows.Forms.GroupBox();
            this.isJediTrainer = new System.Windows.Forms.CheckBox();
            this.isKnownJedi = new System.Windows.Forms.CheckBox();
            this.jediVarLabel = new System.Windows.Forms.Label();
            this.jediBaseLabel = new System.Windows.Forms.Label();
            this.jediLevelVariance = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.jediProbabilityBase = new System.Windows.Forms.NumericUpDown();
            this.jediLevelBase = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.researchGroup = new System.Windows.Forms.GroupBox();
            this.resVarLabel = new System.Windows.Forms.Label();
            this.resBaseLabel = new System.Windows.Forms.Label();
            this.facilitiesResearchVariance = new System.Windows.Forms.NumericUpDown();
            this.shipResearchVariance = new System.Windows.Forms.NumericUpDown();
            this.troopsReseachVariance = new System.Windows.Forms.NumericUpDown();
            this.facResLabel = new System.Windows.Forms.Label();
            this.facilitiesResearchBase = new System.Windows.Forms.NumericUpDown();
            this.shipResLabel = new System.Windows.Forms.Label();
            this.shipResearchBase = new System.Windows.Forms.NumericUpDown();
            this.troopsResearchBase = new System.Windows.Forms.NumericUpDown();
            this.troopResLabel = new System.Windows.Forms.Label();
            this.BasicGroup = new System.Windows.Forms.GroupBox();
            this.loyaltyVariance = new System.Windows.Forms.NumericUpDown();
            this.loyaltyBase = new System.Windows.Forms.NumericUpDown();
            this.loyaltyLabel = new System.Windows.Forms.Label();
            this.statsVarLabel = new System.Windows.Forms.Label();
            this.statsBaseLabel = new System.Windows.Forms.Label();
            this.combatVariance = new System.Windows.Forms.NumericUpDown();
            this.diplomacyVariance = new System.Windows.Forms.NumericUpDown();
            this.espionageVariance = new System.Windows.Forms.NumericUpDown();
            this.combatLabel = new System.Windows.Forms.Label();
            this.combatBase = new System.Windows.Forms.NumericUpDown();
            this.diploLabel = new System.Windows.Forms.Label();
            this.diplomacyBase = new System.Windows.Forms.NumericUpDown();
            this.espionageBase = new System.Windows.Forms.NumericUpDown();
            this.espLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.unitIdHexLabel = new System.Windows.Forms.Label();
            this.unitId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.unknown3Num = new System.Windows.Forms.NumericUpDown();
            this.textStraDllId = new System.Windows.Forms.NumericUpDown();
            this.prodFacNum = new System.Windows.Forms.NumericUpDown();
            this.unkown3Label = new System.Windows.Forms.Label();
            this.familyId = new System.Windows.Forms.NumericUpDown();
            this.prodLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.familyLabel = new System.Windows.Forms.Label();
            this.secProdFacNumlabel = new System.Windows.Forms.Label();
            this.secProdFacNum = new System.Windows.Forms.NumericUpDown();
            this.encyText = new System.Windows.Forms.RichTextBox();
            this.encyclopediaName = new System.Windows.Forms.Label();
            this.selector = new System.Windows.Forms.TrackBar();
            this.charLoyalGroup = new System.Windows.Forms.GroupBox();
            this.isUnableToBetray = new System.Windows.Forms.CheckBox();
            this.isAllianceUnit = new System.Windows.Forms.CheckBox();
            this.isEmpireUnit = new System.Windows.Forms.CheckBox();
            this.cmdAbilityGroup = new System.Windows.Forms.GroupBox();
            this.canBeCommander = new System.Windows.Forms.CheckBox();
            this.canBeAdmiral = new System.Windows.Forms.CheckBox();
            this.canBeGeneral = new System.Windows.Forms.CheckBox();
            this.Open = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.majCharImageList = new System.Windows.Forms.ImageList(this.components);
            this.charListView = new System.Windows.Forms.ListView();
            this.picture = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.jediModStatGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jediEspionageBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediDiplomacyBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediCombatVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediCombatBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediDiplomacyVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediEspionageVariance)).BeginInit();
            this.jediStatGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jediLevelVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediProbabilityBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediLevelBase)).BeginInit();
            this.researchGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facilitiesResearchVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipResearchVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopsReseachVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilitiesResearchBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipResearchBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopsResearchBase)).BeginInit();
            this.BasicGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loyaltyVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyaltyBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomacyVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espionageVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomacyBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espionageBase)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown3Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodFacNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secProdFacNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            this.charLoyalGroup.SuspendLayout();
            this.cmdAbilityGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
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
            this.jediModStatGroup.Controls.Add(this.jediEspionageBase);
            this.jediModStatGroup.Controls.Add(this.jediDiplomacyBase);
            this.jediModStatGroup.Controls.Add(this.jediCombatVariance);
            this.jediModStatGroup.Controls.Add(this.jediCombatBase);
            this.jediModStatGroup.Controls.Add(this.jediCombatLabel);
            this.jediModStatGroup.Controls.Add(this.jediDiplomacyVariance);
            this.jediModStatGroup.Controls.Add(this.jediEspionageVariance);
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
            // jediEspionageBase
            // 
            this.jediEspionageBase.Enabled = false;
            this.jediEspionageBase.Location = new System.Drawing.Point(119, 73);
            this.jediEspionageBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediEspionageBase.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.jediEspionageBase.Name = "jediEspionageBase";
            this.jediEspionageBase.Size = new System.Drawing.Size(59, 23);
            this.jediEspionageBase.TabIndex = 0;
            this.jediEspionageBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediEspionageBase.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // jediDiplomacyBase
            // 
            this.jediDiplomacyBase.Enabled = false;
            this.jediDiplomacyBase.Location = new System.Drawing.Point(119, 39);
            this.jediDiplomacyBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediDiplomacyBase.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.jediDiplomacyBase.Name = "jediDiplomacyBase";
            this.jediDiplomacyBase.Size = new System.Drawing.Size(59, 23);
            this.jediDiplomacyBase.TabIndex = 0;
            this.jediDiplomacyBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediDiplomacyBase.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // jediCombatVarNum
            // 
            this.jediCombatVariance.Enabled = false;
            this.jediCombatVariance.Location = new System.Drawing.Point(186, 103);
            this.jediCombatVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediCombatVariance.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.jediCombatVariance.Name = "jediCombatVarNum";
            this.jediCombatVariance.Size = new System.Drawing.Size(59, 23);
            this.jediCombatVariance.TabIndex = 0;
            this.jediCombatVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediCombatVariance.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // jediCombatBase
            // 
            this.jediCombatBase.Enabled = false;
            this.jediCombatBase.Location = new System.Drawing.Point(119, 103);
            this.jediCombatBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediCombatBase.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.jediCombatBase.Name = "jediCombatBase";
            this.jediCombatBase.Size = new System.Drawing.Size(59, 23);
            this.jediCombatBase.TabIndex = 0;
            this.jediCombatBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediCombatBase.Value = new decimal(new int[] {
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
            this.jediDiplomacyVariance.Enabled = false;
            this.jediDiplomacyVariance.Location = new System.Drawing.Point(186, 39);
            this.jediDiplomacyVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediDiplomacyVariance.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.jediDiplomacyVariance.Name = "jediDipVarNum";
            this.jediDiplomacyVariance.Size = new System.Drawing.Size(59, 23);
            this.jediDiplomacyVariance.TabIndex = 0;
            this.jediDiplomacyVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediDiplomacyVariance.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // jediEspVarNum
            // 
            this.jediEspionageVariance.Enabled = false;
            this.jediEspionageVariance.Location = new System.Drawing.Point(186, 73);
            this.jediEspionageVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediEspionageVariance.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.jediEspionageVariance.Name = "jediEspVarNum";
            this.jediEspionageVariance.Size = new System.Drawing.Size(59, 23);
            this.jediEspionageVariance.TabIndex = 0;
            this.jediEspionageVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediEspionageVariance.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // jediStatGroup
            // 
            this.jediStatGroup.Controls.Add(this.isJediTrainer);
            this.jediStatGroup.Controls.Add(this.isKnownJedi);
            this.jediStatGroup.Controls.Add(this.jediVarLabel);
            this.jediStatGroup.Controls.Add(this.jediBaseLabel);
            this.jediStatGroup.Controls.Add(this.jediLevelVariance);
            this.jediStatGroup.Controls.Add(this.label12);
            this.jediStatGroup.Controls.Add(this.jediProbabilityBase);
            this.jediStatGroup.Controls.Add(this.jediLevelBase);
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
            // isJediTrainer
            // 
            this.isJediTrainer.AutoSize = true;
            this.isJediTrainer.Location = new System.Drawing.Point(163, 37);
            this.isJediTrainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isJediTrainer.Name = "isJediTrainer";
            this.isJediTrainer.Size = new System.Drawing.Size(84, 19);
            this.isJediTrainer.TabIndex = 22;
            this.isJediTrainer.Text = "Jedi Trainer";
            this.isJediTrainer.UseVisualStyleBackColor = true;
            this.isJediTrainer.CheckStateChanged += new System.EventHandler(this.updateTrainJediCheck);
            // 
            // isKnownJedi
            // 
            this.isKnownJedi.AutoSize = true;
            this.isKnownJedi.Location = new System.Drawing.Point(10, 37);
            this.isKnownJedi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isKnownJedi.Name = "isKnownJedi";
            this.isKnownJedi.Size = new System.Drawing.Size(86, 19);
            this.isKnownJedi.TabIndex = 21;
            this.isKnownJedi.Text = "Known Jedi";
            this.isKnownJedi.UseVisualStyleBackColor = true;
            this.isKnownJedi.CheckStateChanged += new System.EventHandler(this.updateknownJediCheck);
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
            // jediLevelVariance
            // 
            this.jediLevelVariance.Location = new System.Drawing.Point(186, 137);
            this.jediLevelVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediLevelVariance.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.jediLevelVariance.Name = "jediLevelVariance";
            this.jediLevelVariance.Size = new System.Drawing.Size(59, 23);
            this.jediLevelVariance.TabIndex = 25;
            this.jediLevelVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediLevelVariance.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.jediLevelVariance.ValueChanged += new System.EventHandler(this.updateJediLevelVarNum);
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
            // jediProbabilityBase
            // 
            this.jediProbabilityBase.Location = new System.Drawing.Point(119, 104);
            this.jediProbabilityBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediProbabilityBase.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.jediProbabilityBase.Name = "jediProbabilityBase";
            this.jediProbabilityBase.Size = new System.Drawing.Size(59, 23);
            this.jediProbabilityBase.TabIndex = 23;
            this.jediProbabilityBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediProbabilityBase.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.jediProbabilityBase.ValueChanged += new System.EventHandler(this.updateJediProbBaseNum);
            // 
            // jediLevelBase
            // 
            this.jediLevelBase.Location = new System.Drawing.Point(119, 137);
            this.jediLevelBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jediLevelBase.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.jediLevelBase.Name = "jediLevelBase";
            this.jediLevelBase.Size = new System.Drawing.Size(59, 23);
            this.jediLevelBase.TabIndex = 24;
            this.jediLevelBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.jediLevelBase.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.jediLevelBase.ValueChanged += new System.EventHandler(this.updateJediLevelBaseNum);
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
            this.researchGroup.Controls.Add(this.facilitiesResearchVariance);
            this.researchGroup.Controls.Add(this.shipResearchVariance);
            this.researchGroup.Controls.Add(this.troopsReseachVariance);
            this.researchGroup.Controls.Add(this.facResLabel);
            this.researchGroup.Controls.Add(this.facilitiesResearchBase);
            this.researchGroup.Controls.Add(this.shipResLabel);
            this.researchGroup.Controls.Add(this.shipResearchBase);
            this.researchGroup.Controls.Add(this.troopsResearchBase);
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
            // facilitiesResearchVariance
            // 
            this.facilitiesResearchVariance.Location = new System.Drawing.Point(186, 99);
            this.facilitiesResearchVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilitiesResearchVariance.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.facilitiesResearchVariance.Name = "facilitiesResearchVariance";
            this.facilitiesResearchVariance.Size = new System.Drawing.Size(59, 23);
            this.facilitiesResearchVariance.TabIndex = 9;
            this.facilitiesResearchVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.facilitiesResearchVariance.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.facilitiesResearchVariance.ValueChanged += new System.EventHandler(this.updateFacResVarNum);
            // 
            // shipResearchVariance
            // 
            this.shipResearchVariance.Location = new System.Drawing.Point(186, 36);
            this.shipResearchVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shipResearchVariance.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.shipResearchVariance.Name = "shipResearchVariance";
            this.shipResearchVariance.Size = new System.Drawing.Size(59, 23);
            this.shipResearchVariance.TabIndex = 5;
            this.shipResearchVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shipResearchVariance.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.shipResearchVariance.ValueChanged += new System.EventHandler(this.updateShipResVarNum);
            // 
            // troopsReseachVariance
            // 
            this.troopsReseachVariance.Location = new System.Drawing.Point(186, 69);
            this.troopsReseachVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopsReseachVariance.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.troopsReseachVariance.Name = "troopsReseachVariance";
            this.troopsReseachVariance.Size = new System.Drawing.Size(59, 23);
            this.troopsReseachVariance.TabIndex = 7;
            this.troopsReseachVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.troopsReseachVariance.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.troopsReseachVariance.ValueChanged += new System.EventHandler(this.updateTroopResVarNum);
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
            // facilitiesResearchBase
            // 
            this.facilitiesResearchBase.Location = new System.Drawing.Point(119, 99);
            this.facilitiesResearchBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.facilitiesResearchBase.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.facilitiesResearchBase.Name = "facilitiesResearchBase";
            this.facilitiesResearchBase.Size = new System.Drawing.Size(59, 23);
            this.facilitiesResearchBase.TabIndex = 8;
            this.facilitiesResearchBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.facilitiesResearchBase.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.facilitiesResearchBase.ValueChanged += new System.EventHandler(this.updateFacResBaseNum);
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
            // shipResearchBase
            // 
            this.shipResearchBase.Location = new System.Drawing.Point(119, 36);
            this.shipResearchBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shipResearchBase.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.shipResearchBase.Name = "shipResearchBase";
            this.shipResearchBase.Size = new System.Drawing.Size(59, 23);
            this.shipResearchBase.TabIndex = 4;
            this.shipResearchBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shipResearchBase.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.shipResearchBase.ValueChanged += new System.EventHandler(this.updateShipResBaseNum);
            // 
            // troopsResearchBase
            // 
            this.troopsResearchBase.Location = new System.Drawing.Point(119, 69);
            this.troopsResearchBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopsResearchBase.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.troopsResearchBase.Name = "troopsResearchBase";
            this.troopsResearchBase.Size = new System.Drawing.Size(59, 23);
            this.troopsResearchBase.TabIndex = 6;
            this.troopsResearchBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.troopsResearchBase.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.troopsResearchBase.ValueChanged += new System.EventHandler(this.updateTroopResBaseNum);
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
            this.BasicGroup.Controls.Add(this.loyaltyVariance);
            this.BasicGroup.Controls.Add(this.loyaltyBase);
            this.BasicGroup.Controls.Add(this.loyaltyLabel);
            this.BasicGroup.Controls.Add(this.statsVarLabel);
            this.BasicGroup.Controls.Add(this.statsBaseLabel);
            this.BasicGroup.Controls.Add(this.combatVariance);
            this.BasicGroup.Controls.Add(this.diplomacyVariance);
            this.BasicGroup.Controls.Add(this.espionageVariance);
            this.BasicGroup.Controls.Add(this.combatLabel);
            this.BasicGroup.Controls.Add(this.combatBase);
            this.BasicGroup.Controls.Add(this.diploLabel);
            this.BasicGroup.Controls.Add(this.diplomacyBase);
            this.BasicGroup.Controls.Add(this.espionageBase);
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
            // loyaltyVariance
            // 
            this.loyaltyVariance.Location = new System.Drawing.Point(186, 129);
            this.loyaltyVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loyaltyVariance.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.loyaltyVariance.Name = "loyaltyVariance";
            this.loyaltyVariance.Size = new System.Drawing.Size(59, 23);
            this.loyaltyVariance.TabIndex = 11;
            this.loyaltyVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.loyaltyVariance.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.loyaltyVariance.ValueChanged += new System.EventHandler(this.updateLoyalVarNum);
            // 
            // loyaltyBase
            // 
            this.loyaltyBase.Location = new System.Drawing.Point(119, 129);
            this.loyaltyBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loyaltyBase.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.loyaltyBase.Name = "loyaltyBase";
            this.loyaltyBase.Size = new System.Drawing.Size(59, 23);
            this.loyaltyBase.TabIndex = 10;
            this.loyaltyBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.loyaltyBase.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.loyaltyBase.ValueChanged += new System.EventHandler(this.updateLoyalBaseNum);
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
            // combatVariance
            // 
            this.combatVariance.Location = new System.Drawing.Point(186, 99);
            this.combatVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combatVariance.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.combatVariance.Name = "combatVariance";
            this.combatVariance.Size = new System.Drawing.Size(59, 23);
            this.combatVariance.TabIndex = 9;
            this.combatVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.combatVariance.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.combatVariance.ValueChanged += new System.EventHandler(this.updateCombatVarNum);
            // 
            // diplomacyVariance
            // 
            this.diplomacyVariance.Location = new System.Drawing.Point(186, 36);
            this.diplomacyVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.diplomacyVariance.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.diplomacyVariance.Name = "diplomacyVariance";
            this.diplomacyVariance.Size = new System.Drawing.Size(59, 23);
            this.diplomacyVariance.TabIndex = 5;
            this.diplomacyVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.diplomacyVariance.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.diplomacyVariance.ValueChanged += new System.EventHandler(this.updateDipVarNum);
            // 
            // espionageVariance
            // 
            this.espionageVariance.Location = new System.Drawing.Point(186, 69);
            this.espionageVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.espionageVariance.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.espionageVariance.Name = "espionageVariance";
            this.espionageVariance.Size = new System.Drawing.Size(59, 23);
            this.espionageVariance.TabIndex = 7;
            this.espionageVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.espionageVariance.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.espionageVariance.ValueChanged += new System.EventHandler(this.updateEspVarNum);
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
            // combatBase
            // 
            this.combatBase.Location = new System.Drawing.Point(119, 99);
            this.combatBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combatBase.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.combatBase.Name = "combatBase";
            this.combatBase.Size = new System.Drawing.Size(59, 23);
            this.combatBase.TabIndex = 8;
            this.combatBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.combatBase.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.combatBase.ValueChanged += new System.EventHandler(this.updateCombatBaseNum);
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
            // diplomacyBase
            // 
            this.diplomacyBase.Location = new System.Drawing.Point(119, 36);
            this.diplomacyBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.diplomacyBase.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.diplomacyBase.Name = "diplomacyBase";
            this.diplomacyBase.Size = new System.Drawing.Size(59, 23);
            this.diplomacyBase.TabIndex = 4;
            this.diplomacyBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.diplomacyBase.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.diplomacyBase.ValueChanged += new System.EventHandler(this.updateDipBaseNum);
            // 
            // espionageBase
            // 
            this.espionageBase.Location = new System.Drawing.Point(119, 69);
            this.espionageBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.espionageBase.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.espionageBase.Name = "espionageBase";
            this.espionageBase.Size = new System.Drawing.Size(59, 23);
            this.espionageBase.TabIndex = 6;
            this.espionageBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.espionageBase.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.espionageBase.ValueChanged += new System.EventHandler(this.updateEspBaseNum);
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
            this.groupBox5.Controls.Add(this.familyIdHexLabel);
            this.groupBox5.Controls.Add(this.unitIdHexLabel);
            this.groupBox5.Controls.Add(this.unitId);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.unknown3Num);
            this.groupBox5.Controls.Add(this.textStraDllId);
            this.groupBox5.Controls.Add(this.prodFacNum);
            this.groupBox5.Controls.Add(this.unkown3Label);
            this.groupBox5.Controls.Add(this.familyId);
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
            this.familyIdHexLabel.AutoSize = true;
            this.familyIdHexLabel.Enabled = false;
            this.familyIdHexLabel.Location = new System.Drawing.Point(340, 88);
            this.familyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdHexLabel.Name = "famHexLabel";
            this.familyIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.familyIdHexLabel.TabIndex = 1127;
            this.familyIdHexLabel.Text = "hex";
            // 
            // unitHexLabel
            // 
            this.unitIdHexLabel.AutoSize = true;
            this.unitIdHexLabel.Enabled = false;
            this.unitIdHexLabel.Location = new System.Drawing.Point(340, 175);
            this.unitIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitIdHexLabel.Name = "unitHexLabel";
            this.unitIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.unitIdHexLabel.TabIndex = 1126;
            this.unitIdHexLabel.Text = "hex";
            // 
            // unitNum
            // 
            this.unitId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.unitId.Enabled = false;
            this.unitId.Location = new System.Drawing.Point(279, 173);
            this.unitId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unitId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.unitId.Name = "unitNum";
            this.unitId.Size = new System.Drawing.Size(59, 23);
            this.unitId.TabIndex = 1125;
            this.unitId.TabStop = false;
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
            this.textStraDllId.Enabled = false;
            this.textStraDllId.Location = new System.Drawing.Point(279, 143);
            this.textStraDllId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textStraDllId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.textStraDllId.Name = "idNum";
            this.textStraDllId.Size = new System.Drawing.Size(59, 23);
            this.textStraDllId.TabIndex = 148;
            this.textStraDllId.TabStop = false;
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
            this.familyId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.familyId.Enabled = false;
            this.familyId.Location = new System.Drawing.Point(279, 83);
            this.familyId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.familyId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.familyId.Name = "familyIdNum";
            this.familyId.Size = new System.Drawing.Size(59, 23);
            this.familyId.TabIndex = 147;
            this.familyId.TabStop = false;
            this.familyId.ValueChanged += new System.EventHandler(this.updateFamilyIdNum);
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
            // encyclopediaName
            // 
            this.encyclopediaName.AutoSize = true;
            this.encyclopediaName.Location = new System.Drawing.Point(230, 88);
            this.encyclopediaName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encyclopediaName.Name = "encyclopediaName";
            this.encyclopediaName.Size = new System.Drawing.Size(116, 15);
            this.encyclopediaName.TabIndex = 120;
            this.encyclopediaName.Text = "-- Item name here --";
            // 
            // selector
            // 
            this.selector.LargeChange = 4;
            this.selector.Location = new System.Drawing.Point(233, 32);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 5;
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(121, 45);
            this.selector.TabIndex = 1;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            // 
            // charLoyalGroup
            // 
            this.charLoyalGroup.Controls.Add(this.isUnableToBetray);
            this.charLoyalGroup.Controls.Add(this.isAllianceUnit);
            this.charLoyalGroup.Controls.Add(this.isEmpireUnit);
            this.charLoyalGroup.Location = new System.Drawing.Point(398, 32);
            this.charLoyalGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.charLoyalGroup.Name = "charLoyalGroup";
            this.charLoyalGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.charLoyalGroup.Size = new System.Drawing.Size(182, 98);
            this.charLoyalGroup.TabIndex = 2;
            this.charLoyalGroup.TabStop = false;
            this.charLoyalGroup.Text = "Character Loyalty";
            // 
            // isUnableToBetray
            // 
            this.isUnableToBetray.AutoSize = true;
            this.isUnableToBetray.Location = new System.Drawing.Point(7, 75);
            this.isUnableToBetray.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isUnableToBetray.Name = "isUnableToBetray";
            this.isUnableToBetray.Size = new System.Drawing.Size(113, 19);
            this.isUnableToBetray.TabIndex = 17;
            this.isUnableToBetray.Text = "Unable to Betray";
            this.isUnableToBetray.UseVisualStyleBackColor = true;
            this.isUnableToBetray.CheckStateChanged += new System.EventHandler(this.updateBetrayFlagCheck);
            // 
            // isAllianceUnit
            // 
            this.isAllianceUnit.AutoSize = true;
            this.isAllianceUnit.Location = new System.Drawing.Point(7, 22);
            this.isAllianceUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isAllianceUnit.Name = "isAllianceUnit";
            this.isAllianceUnit.Size = new System.Drawing.Size(68, 19);
            this.isAllianceUnit.TabIndex = 15;
            this.isAllianceUnit.Text = "Alliance";
            this.isAllianceUnit.UseVisualStyleBackColor = true;
            this.isAllianceUnit.CheckStateChanged += new System.EventHandler(this.updateRebelUnitCheck);
            // 
            // isEmpireUnit
            // 
            this.isEmpireUnit.AutoSize = true;
            this.isEmpireUnit.Location = new System.Drawing.Point(7, 48);
            this.isEmpireUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isEmpireUnit.Name = "isEmpireUnit";
            this.isEmpireUnit.Size = new System.Drawing.Size(69, 19);
            this.isEmpireUnit.TabIndex = 16;
            this.isEmpireUnit.Text = "Imperial";
            this.isEmpireUnit.UseVisualStyleBackColor = true;
            this.isEmpireUnit.CheckStateChanged += new System.EventHandler(this.updateEmpireUnitCheck);
            // 
            // cmdAbilityGroup
            // 
            this.cmdAbilityGroup.Controls.Add(this.canBeCommander);
            this.cmdAbilityGroup.Controls.Add(this.canBeAdmiral);
            this.cmdAbilityGroup.Controls.Add(this.canBeGeneral);
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
            this.canBeCommander.AutoSize = true;
            this.canBeCommander.Location = new System.Drawing.Point(7, 75);
            this.canBeCommander.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.canBeCommander.Name = "cmdCommCheck";
            this.canBeCommander.Size = new System.Drawing.Size(93, 19);
            this.canBeCommander.TabIndex = 20;
            this.canBeCommander.Text = "Commander";
            this.canBeCommander.UseVisualStyleBackColor = true;
            this.canBeCommander.CheckStateChanged += new System.EventHandler(this.updateCmdCommCheck);
            // 
            // cmdAdmCheck
            // 
            this.canBeAdmiral.AutoSize = true;
            this.canBeAdmiral.Location = new System.Drawing.Point(7, 22);
            this.canBeAdmiral.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.canBeAdmiral.Name = "cmdAdmCheck";
            this.canBeAdmiral.Size = new System.Drawing.Size(68, 19);
            this.canBeAdmiral.TabIndex = 18;
            this.canBeAdmiral.Text = "Admiral";
            this.canBeAdmiral.UseVisualStyleBackColor = true;
            this.canBeAdmiral.CheckStateChanged += new System.EventHandler(this.updateCmdAdmCheck);
            // 
            // cmdGenCheck
            // 
            this.canBeGeneral.AutoSize = true;
            this.canBeGeneral.Location = new System.Drawing.Point(7, 48);
            this.canBeGeneral.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.canBeGeneral.Name = "cmdGenCheck";
            this.canBeGeneral.Size = new System.Drawing.Size(66, 19);
            this.canBeGeneral.TabIndex = 19;
            this.canBeGeneral.Text = "General";
            this.canBeGeneral.UseVisualStyleBackColor = true;
            this.canBeGeneral.CheckStateChanged += new System.EventHandler(this.updateCmdGenCheck);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(663, 554);
            this.Open.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(88, 27);
            this.Open.TabIndex = 0;
            this.Open.TabStop = false;
            this.Open.Text = "Open...";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
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
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(220, 110);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 134;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.ItemPicture_Click);
            // 
            // MajorCharactersForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(810, 584);
            this.Controls.Add(this.charListView);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.cmdAbilityGroup);
            this.Controls.Add(this.charLoyalGroup);
            this.Controls.Add(this.encyclopediaName);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(826, 623);
            this.MinimumSize = new System.Drawing.Size(826, 623);
            this.Name = "MajorCharactersForm";
            this.Text = "Major Characters (MJCHARSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.MajCharForm_Load);
            this.Enter += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.jediModStatGroup.ResumeLayout(false);
            this.jediModStatGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jediEspionageBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediDiplomacyBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediCombatVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediCombatBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediDiplomacyVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediEspionageVariance)).EndInit();
            this.jediStatGroup.ResumeLayout(false);
            this.jediStatGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jediLevelVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediProbabilityBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jediLevelBase)).EndInit();
            this.researchGroup.ResumeLayout(false);
            this.researchGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facilitiesResearchVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipResearchVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopsReseachVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilitiesResearchBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipResearchBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troopsResearchBase)).EndInit();
            this.BasicGroup.ResumeLayout(false);
            this.BasicGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loyaltyVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loyaltyBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomacyVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espionageVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomacyBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espionageBase)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknown3Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodFacNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secProdFacNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            this.charLoyalGroup.ResumeLayout(false);
            this.charLoyalGroup.PerformLayout();
            this.cmdAbilityGroup.ResumeLayout(false);
            this.cmdAbilityGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}