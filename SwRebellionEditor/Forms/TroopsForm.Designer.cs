using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class TroopsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TrackBar selector;
        private PictureBox picture;
        private Label conCostLabel;
        private NumericUpDown constructionCost;
        private Label maintCostLabel;
        private NumericUpDown maintenanceCost;
        private NumericUpDown researchOrder;
        private Label researchLabel;
        private Label BombardLabel;
        private NumericUpDown bombardmentRating;
        private NumericUpDown defenseRating;
        private Label defenseLabel;
        private NumericUpDown atttackRating;
        private Label attacklabel;
        private Label DetectionLabel;
        private NumericUpDown detectionRating;
        private CheckBox isAllianceUnit;
        private CheckBox isEmpireUnit;
        private Label idLabel;
        private NumericUpDown textStraDllId;
        private Label unkown3Label;
        private NumericUpDown unknwown2;
        private NumericUpDown familyId;
        private Label familyLabel;
        private NumericUpDown nextProductionFamily;
        private Label secProdFacNumlabel;
        private Label prodLabel;
        private NumericUpDown productionFamily;
        private NumericUpDown unknownMoralHp;
        private Label UnkownMoralHPlabel;
        private NumericUpDown researchDifficulty;
        private Label resDiffLabel;
        private Label name;
        private RichTextBox encyText;
        private Button Ok;
        private Button Cancel;
        private Button SaveAs;
        private SaveFileDialog saveFileDialog;
        private Button openNew;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox costGroup;
        private TabPage tabPage2;
        private GroupBox researchBox;
        private GroupBox troopStatsBox;
        private GroupBox miscDATGroup;
        private Label familyIdHexLabel;
        private Label troopIdHexLabel;
        private NumericUpDown troopId;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TroopsForm));
            this.conCostLabel = new System.Windows.Forms.Label();
            this.constructionCost = new System.Windows.Forms.NumericUpDown();
            this.maintCostLabel = new System.Windows.Forms.Label();
            this.maintenanceCost = new System.Windows.Forms.NumericUpDown();
            this.researchOrder = new System.Windows.Forms.NumericUpDown();
            this.researchLabel = new System.Windows.Forms.Label();
            this.BombardLabel = new System.Windows.Forms.Label();
            this.bombardmentRating = new System.Windows.Forms.NumericUpDown();
            this.defenseRating = new System.Windows.Forms.NumericUpDown();
            this.defenseLabel = new System.Windows.Forms.Label();
            this.atttackRating = new System.Windows.Forms.NumericUpDown();
            this.attacklabel = new System.Windows.Forms.Label();
            this.DetectionLabel = new System.Windows.Forms.Label();
            this.detectionRating = new System.Windows.Forms.NumericUpDown();
            this.selector = new System.Windows.Forms.TrackBar();
            this.isAllianceUnit = new System.Windows.Forms.CheckBox();
            this.isEmpireUnit = new System.Windows.Forms.CheckBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.textStraDllId = new System.Windows.Forms.NumericUpDown();
            this.unkown3Label = new System.Windows.Forms.Label();
            this.unknwown2 = new System.Windows.Forms.NumericUpDown();
            this.familyId = new System.Windows.Forms.NumericUpDown();
            this.familyLabel = new System.Windows.Forms.Label();
            this.nextProductionFamily = new System.Windows.Forms.NumericUpDown();
            this.secProdFacNumlabel = new System.Windows.Forms.Label();
            this.prodLabel = new System.Windows.Forms.Label();
            this.productionFamily = new System.Windows.Forms.NumericUpDown();
            this.unknownMoralHp = new System.Windows.Forms.NumericUpDown();
            this.UnkownMoralHPlabel = new System.Windows.Forms.Label();
            this.researchDifficulty = new System.Windows.Forms.NumericUpDown();
            this.resDiffLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.encyText = new System.Windows.Forms.RichTextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openNew = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.miscDATGroup = new System.Windows.Forms.GroupBox();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.troopIdHexLabel = new System.Windows.Forms.Label();
            this.troopId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.troopStatsBox = new System.Windows.Forms.GroupBox();
            this.researchBox = new System.Windows.Forms.GroupBox();
            this.costGroup = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.constructionCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardmentRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defenseRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atttackRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectionRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknwown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknownMoralHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.miscDATGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.troopId)).BeginInit();
            this.troopStatsBox.SuspendLayout();
            this.researchBox.SuspendLayout();
            this.costGroup.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // conCostLabel
            // 
            this.conCostLabel.AutoSize = true;
            this.conCostLabel.Location = new System.Drawing.Point(7, 18);
            this.conCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conCostLabel.Name = "conCostLabel";
            this.conCostLabel.Size = new System.Drawing.Size(103, 15);
            this.conCostLabel.TabIndex = 0;
            this.conCostLabel.Text = "Construction Cost";
            // 
            // conCostNum
            // 
            this.constructionCost.Location = new System.Drawing.Point(119, 18);
            this.constructionCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.constructionCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.constructionCost.Name = "conCostNum";
            this.constructionCost.Size = new System.Drawing.Size(59, 23);
            this.constructionCost.TabIndex = 4;
            this.constructionCost.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.constructionCost.ValueChanged += new System.EventHandler(this.constructionCost_ValueChanged);
            // 
            // maintCostLabel
            // 
            this.maintCostLabel.AutoSize = true;
            this.maintCostLabel.Location = new System.Drawing.Point(7, 46);
            this.maintCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maintCostLabel.Name = "maintCostLabel";
            this.maintCostLabel.Size = new System.Drawing.Size(103, 15);
            this.maintCostLabel.TabIndex = 0;
            this.maintCostLabel.Text = "Maintenance Cost";
            // 
            // maintCostNum
            // 
            this.maintenanceCost.Location = new System.Drawing.Point(119, 48);
            this.maintenanceCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maintenanceCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maintenanceCost.Name = "maintCostNum";
            this.maintenanceCost.Size = new System.Drawing.Size(59, 23);
            this.maintenanceCost.TabIndex = 5;
            this.maintenanceCost.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maintenanceCost.ValueChanged += new System.EventHandler(this.maintenanceCost_ValueChanged);
            // 
            // researchNum
            // 
            this.researchOrder.Location = new System.Drawing.Point(119, 16);
            this.researchOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchOrder.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.researchOrder.Name = "researchNum";
            this.researchOrder.Size = new System.Drawing.Size(59, 23);
            this.researchOrder.TabIndex = 6;
            this.researchOrder.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.researchOrder.ValueChanged += new System.EventHandler(this.researchOrder_ValueChanged);
            // 
            // researchLabel
            // 
            this.researchLabel.AutoSize = true;
            this.researchLabel.Location = new System.Drawing.Point(7, 18);
            this.researchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.researchLabel.Name = "researchLabel";
            this.researchLabel.Size = new System.Drawing.Size(54, 15);
            this.researchLabel.TabIndex = 0;
            this.researchLabel.Text = "Research";
            // 
            // BombardLabel
            // 
            this.BombardLabel.AutoSize = true;
            this.BombardLabel.Location = new System.Drawing.Point(7, 81);
            this.BombardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BombardLabel.Name = "BombardLabel";
            this.BombardLabel.Size = new System.Drawing.Size(96, 15);
            this.BombardLabel.TabIndex = 0;
            this.BombardLabel.Text = "Bombard. Rating";
            // 
            // bombardNum
            // 
            this.bombardmentRating.Location = new System.Drawing.Point(119, 78);
            this.bombardmentRating.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bombardmentRating.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bombardmentRating.Name = "bombardNum";
            this.bombardmentRating.Size = new System.Drawing.Size(59, 23);
            this.bombardmentRating.TabIndex = 9;
            this.bombardmentRating.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bombardmentRating.ValueChanged += new System.EventHandler(this.bombardmentRating_ValueChanged);
            // 
            // defNum
            // 
            this.defenseRating.Location = new System.Drawing.Point(119, 48);
            this.defenseRating.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.defenseRating.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.defenseRating.Name = "defNum";
            this.defenseRating.Size = new System.Drawing.Size(59, 23);
            this.defenseRating.TabIndex = 8;
            this.defenseRating.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.defenseRating.ValueChanged += new System.EventHandler(this.defenseRating_ValueChanged);
            // 
            // defenseLabel
            // 
            this.defenseLabel.AutoSize = true;
            this.defenseLabel.Location = new System.Drawing.Point(7, 48);
            this.defenseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.defenseLabel.Name = "defenseLabel";
            this.defenseLabel.Size = new System.Drawing.Size(86, 15);
            this.defenseLabel.TabIndex = 0;
            this.defenseLabel.Text = "Defense Rating";
            // 
            // attackNum
            // 
            this.atttackRating.Location = new System.Drawing.Point(119, 18);
            this.atttackRating.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atttackRating.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.atttackRating.Name = "attackNum";
            this.atttackRating.Size = new System.Drawing.Size(59, 23);
            this.atttackRating.TabIndex = 7;
            this.atttackRating.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.atttackRating.ValueChanged += new System.EventHandler(this.atttackRating_ValueChanged);
            // 
            // attacklabel
            // 
            this.attacklabel.AutoSize = true;
            this.attacklabel.Location = new System.Drawing.Point(7, 18);
            this.attacklabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.attacklabel.Name = "attacklabel";
            this.attacklabel.Size = new System.Drawing.Size(78, 15);
            this.attacklabel.TabIndex = 0;
            this.attacklabel.Text = "Attack Rating";
            // 
            // DetectionLabel
            // 
            this.DetectionLabel.AutoSize = true;
            this.DetectionLabel.Location = new System.Drawing.Point(7, 111);
            this.DetectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DetectionLabel.Name = "DetectionLabel";
            this.DetectionLabel.Size = new System.Drawing.Size(95, 15);
            this.DetectionLabel.TabIndex = 0;
            this.DetectionLabel.Text = "Detection Rating";
            // 
            // detectNum
            // 
            this.detectionRating.Location = new System.Drawing.Point(119, 108);
            this.detectionRating.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.detectionRating.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.detectionRating.Name = "detectNum";
            this.detectionRating.Size = new System.Drawing.Size(59, 23);
            this.detectionRating.TabIndex = 10;
            this.detectionRating.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.detectionRating.ValueChanged += new System.EventHandler(this.detectionRating_ValueChanged);
            // 
            // ItemSelect
            // 
            this.selector.Location = new System.Drawing.Point(236, 20);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 9;
            this.selector.Name = "ItemSelect";
            this.selector.Size = new System.Drawing.Size(121, 45);
            this.selector.TabIndex = 1;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            // 
            // rebelUnit
            // 
            this.isAllianceUnit.AutoSize = true;
            this.isAllianceUnit.Location = new System.Drawing.Point(26, 97);
            this.isAllianceUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isAllianceUnit.Name = "rebelUnit";
            this.isAllianceUnit.Size = new System.Drawing.Size(93, 19);
            this.isAllianceUnit.TabIndex = 2;
            this.isAllianceUnit.Text = "Alliance Unit";
            this.isAllianceUnit.UseVisualStyleBackColor = true;
            this.isAllianceUnit.CheckStateChanged += new System.EventHandler(this.isAllianceUnit_CheckStateChanged);
            // 
            // empireUnit
            // 
            this.isEmpireUnit.AutoSize = true;
            this.isEmpireUnit.Location = new System.Drawing.Point(132, 97);
            this.isEmpireUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isEmpireUnit.Name = "empireUnit";
            this.isEmpireUnit.Size = new System.Drawing.Size(94, 19);
            this.isEmpireUnit.TabIndex = 3;
            this.isEmpireUnit.Text = "Imperial Unit";
            this.isEmpireUnit.UseVisualStyleBackColor = true;
            this.isEmpireUnit.CheckStateChanged += new System.EventHandler(this.isEmpireUnit_CheckStateChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Enabled = false;
            this.idLabel.Location = new System.Drawing.Point(7, 165);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(85, 15);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "TextStra.DLL ID";
            // 
            // idNum
            // 
            this.textStraDllId.Enabled = false;
            this.textStraDllId.Location = new System.Drawing.Point(118, 163);
            this.textStraDllId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textStraDllId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.textStraDllId.Name = "idNum";
            this.textStraDllId.Size = new System.Drawing.Size(59, 23);
            this.textStraDllId.TabIndex = 0;
            this.textStraDllId.TabStop = false;
            this.textStraDllId.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // unkown3Label
            // 
            this.unkown3Label.AutoSize = true;
            this.unkown3Label.Enabled = false;
            this.unkown3Label.Location = new System.Drawing.Point(7, 135);
            this.unkown3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unkown3Label.Name = "unkown3Label";
            this.unkown3Label.Size = new System.Drawing.Size(58, 15);
            this.unkown3Label.TabIndex = 0;
            this.unkown3Label.Text = "Unknown";
            // 
            // unknown3Num
            // 
            this.unknwown2.Enabled = false;
            this.unknwown2.Location = new System.Drawing.Point(118, 133);
            this.unknwown2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknwown2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknwown2.Name = "unknown3Num";
            this.unknwown2.Size = new System.Drawing.Size(59, 23);
            this.unknwown2.TabIndex = 0;
            this.unknwown2.TabStop = false;
            this.unknwown2.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // familyIdNum
            // 
            this.familyId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.familyId.Enabled = false;
            this.familyId.Location = new System.Drawing.Point(118, 103);
            this.familyId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.familyId.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.familyId.Name = "familyIdNum";
            this.familyId.Size = new System.Drawing.Size(59, 23);
            this.familyId.TabIndex = 0;
            this.familyId.TabStop = false;
            this.familyId.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.familyId.ValueChanged += new System.EventHandler(this.familyId_ValueChanged);
            // 
            // familyLabel
            // 
            this.familyLabel.AutoSize = true;
            this.familyLabel.Enabled = false;
            this.familyLabel.Location = new System.Drawing.Point(7, 105);
            this.familyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyLabel.Name = "familyLabel";
            this.familyLabel.Size = new System.Drawing.Size(56, 15);
            this.familyLabel.TabIndex = 0;
            this.familyLabel.Text = "Family ID";
            // 
            // secProdFacNum
            // 
            this.nextProductionFamily.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nextProductionFamily.Enabled = false;
            this.nextProductionFamily.Location = new System.Drawing.Point(118, 73);
            this.nextProductionFamily.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextProductionFamily.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nextProductionFamily.Name = "secProdFacNum";
            this.nextProductionFamily.Size = new System.Drawing.Size(59, 23);
            this.nextProductionFamily.TabIndex = 0;
            this.nextProductionFamily.TabStop = false;
            this.nextProductionFamily.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nextProductionFamily.ValueChanged += new System.EventHandler(this.nextProductionFamily_ValueChanged);
            // 
            // secProdFacNumlabel
            // 
            this.secProdFacNumlabel.AutoSize = true;
            this.secProdFacNumlabel.Enabled = false;
            this.secProdFacNumlabel.Location = new System.Drawing.Point(7, 75);
            this.secProdFacNumlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secProdFacNumlabel.Name = "secProdFacNumlabel";
            this.secProdFacNumlabel.Size = new System.Drawing.Size(92, 15);
            this.secProdFacNumlabel.TabIndex = 0;
            this.secProdFacNumlabel.Text = "Production Family +1";
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.Enabled = false;
            this.prodLabel.Location = new System.Drawing.Point(7, 45);
            this.prodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(106, 15);
            this.prodLabel.TabIndex = 0;
            this.prodLabel.Text = "Production Family";
            // 
            // prodFacNum
            // 
            this.productionFamily.BackColor = System.Drawing.SystemColors.ControlLight;
            this.productionFamily.Enabled = false;
            this.productionFamily.Location = new System.Drawing.Point(118, 43);
            this.productionFamily.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productionFamily.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.productionFamily.Name = "prodFacNum";
            this.productionFamily.Size = new System.Drawing.Size(59, 23);
            this.productionFamily.TabIndex = 0;
            this.productionFamily.TabStop = false;
            this.productionFamily.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.productionFamily.ValueChanged += new System.EventHandler(this.productionFamily_ValueChanged);
            // 
            // unknownMoralHpNum
            // 
            this.unknownMoralHp.Location = new System.Drawing.Point(118, 13);
            this.unknownMoralHp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknownMoralHp.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknownMoralHp.Name = "unknownMoralHpNum";
            this.unknownMoralHp.Size = new System.Drawing.Size(59, 23);
            this.unknownMoralHp.TabIndex = 12;
            this.unknownMoralHp.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unknownMoralHp.ValueChanged += new System.EventHandler(this.unknownMoralHp_ValueChanged);
            // 
            // UnkownMoralHPlabel
            // 
            this.UnkownMoralHPlabel.AutoSize = true;
            this.UnkownMoralHPlabel.Location = new System.Drawing.Point(6, 15);
            this.UnkownMoralHPlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnkownMoralHPlabel.Name = "UnkownMoralHPlabel";
            this.UnkownMoralHPlabel.Size = new System.Drawing.Size(95, 15);
            this.UnkownMoralHPlabel.TabIndex = 0;
            this.UnkownMoralHPlabel.Text = "Unknown - ?HP?";
            // 
            // resDiffNum
            // 
            this.researchDifficulty.Location = new System.Drawing.Point(119, 43);
            this.researchDifficulty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchDifficulty.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.researchDifficulty.Name = "resDiffNum";
            this.researchDifficulty.Size = new System.Drawing.Size(59, 23);
            this.researchDifficulty.TabIndex = 11;
            this.researchDifficulty.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.researchDifficulty.ValueChanged += new System.EventHandler(this.researchDifficulty_ValueChanged);
            // 
            // resDiffLabel
            // 
            this.resDiffLabel.AutoSize = true;
            this.resDiffLabel.Location = new System.Drawing.Point(7, 43);
            this.resDiffLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resDiffLabel.Name = "resDiffLabel";
            this.resDiffLabel.Size = new System.Drawing.Size(105, 15);
            this.resDiffLabel.TabIndex = 0;
            this.resDiffLabel.Text = "Research Difficulty";
            // 
            // troopName
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(232, 75);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "troopName";
            this.name.Size = new System.Drawing.Size(0, 15);
            this.name.TabIndex = 13;
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
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(22, 487);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 13;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(117, 487);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 27);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Location = new System.Drawing.Point(231, 487);
            this.SaveAs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(88, 27);
            this.SaveAs.TabIndex = 15;
            this.SaveAs.Text = "&SaveAs...";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "DAT";
            this.saveFileDialog.Filter = "Data files|*.dat";
            // 
            // openNew
            // 
            this.openNew.Location = new System.Drawing.Point(326, 487);
            this.openNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openNew.Name = "openNew";
            this.openNew.Size = new System.Drawing.Size(88, 27);
            this.openNew.TabIndex = 16;
            this.openNew.Text = "Open...";
            this.openNew.UseVisualStyleBackColor = true;
            this.openNew.Click += new System.EventHandler(this.Open_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 123);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(421, 358);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.miscDATGroup);
            this.tabPage1.Controls.Add(this.troopStatsBox);
            this.tabPage1.Controls.Add(this.researchBox);
            this.tabPage1.Controls.Add(this.costGroup);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(413, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Troop Data";
            // 
            // miscDATGroup
            // 
            this.miscDATGroup.Controls.Add(this.familyIdHexLabel);
            this.miscDATGroup.Controls.Add(this.UnkownMoralHPlabel);
            this.miscDATGroup.Controls.Add(this.troopIdHexLabel);
            this.miscDATGroup.Controls.Add(this.unknownMoralHp);
            this.miscDATGroup.Controls.Add(this.troopId);
            this.miscDATGroup.Controls.Add(this.label1);
            this.miscDATGroup.Controls.Add(this.productionFamily);
            this.miscDATGroup.Controls.Add(this.prodLabel);
            this.miscDATGroup.Controls.Add(this.secProdFacNumlabel);
            this.miscDATGroup.Controls.Add(this.nextProductionFamily);
            this.miscDATGroup.Controls.Add(this.familyLabel);
            this.miscDATGroup.Controls.Add(this.idLabel);
            this.miscDATGroup.Controls.Add(this.familyId);
            this.miscDATGroup.Controls.Add(this.textStraDllId);
            this.miscDATGroup.Controls.Add(this.unknwown2);
            this.miscDATGroup.Controls.Add(this.unkown3Label);
            this.miscDATGroup.Location = new System.Drawing.Point(192, 7);
            this.miscDATGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.miscDATGroup.Name = "miscDATGroup";
            this.miscDATGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.miscDATGroup.Size = new System.Drawing.Size(212, 314);
            this.miscDATGroup.TabIndex = 7;
            this.miscDATGroup.TabStop = false;
            this.miscDATGroup.Text = "DAT Misc Data";
            // 
            // famHexLabel
            // 
            this.familyIdHexLabel.AutoSize = true;
            this.familyIdHexLabel.Enabled = false;
            this.familyIdHexLabel.Location = new System.Drawing.Point(178, 107);
            this.familyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdHexLabel.Name = "famHexLabel";
            this.familyIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.familyIdHexLabel.TabIndex = 1119;
            this.familyIdHexLabel.Text = "hex";
            // 
            // unitHexLabel
            // 
            this.troopIdHexLabel.AutoSize = true;
            this.troopIdHexLabel.Enabled = false;
            this.troopIdHexLabel.Location = new System.Drawing.Point(178, 195);
            this.troopIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.troopIdHexLabel.Name = "unitHexLabel";
            this.troopIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.troopIdHexLabel.TabIndex = 1118;
            this.troopIdHexLabel.Text = "hex";
            // 
            // unitNum
            // 
            this.troopId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.troopId.Enabled = false;
            this.troopId.Location = new System.Drawing.Point(118, 193);
            this.troopId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.troopId.Name = "unitNum";
            this.troopId.Size = new System.Drawing.Size(59, 23);
            this.troopId.TabIndex = 1117;
            this.troopId.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(6, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1116;
            this.label1.Text = "Troop ID";
            // 
            // troopStatsBox
            // 
            this.troopStatsBox.Controls.Add(this.attacklabel);
            this.troopStatsBox.Controls.Add(this.atttackRating);
            this.troopStatsBox.Controls.Add(this.defenseLabel);
            this.troopStatsBox.Controls.Add(this.defenseRating);
            this.troopStatsBox.Controls.Add(this.bombardmentRating);
            this.troopStatsBox.Controls.Add(this.BombardLabel);
            this.troopStatsBox.Controls.Add(this.detectionRating);
            this.troopStatsBox.Controls.Add(this.DetectionLabel);
            this.troopStatsBox.Location = new System.Drawing.Point(4, 181);
            this.troopStatsBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopStatsBox.Name = "troopStatsBox";
            this.troopStatsBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopStatsBox.Size = new System.Drawing.Size(182, 144);
            this.troopStatsBox.TabIndex = 6;
            this.troopStatsBox.TabStop = false;
            this.troopStatsBox.Text = "Troop Stats";
            // 
            // researchBox
            // 
            this.researchBox.Controls.Add(this.researchLabel);
            this.researchBox.Controls.Add(this.researchOrder);
            this.researchBox.Controls.Add(this.resDiffLabel);
            this.researchBox.Controls.Add(this.researchDifficulty);
            this.researchBox.Location = new System.Drawing.Point(4, 96);
            this.researchBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchBox.Name = "researchBox";
            this.researchBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchBox.Size = new System.Drawing.Size(182, 78);
            this.researchBox.TabIndex = 5;
            this.researchBox.TabStop = false;
            this.researchBox.Text = "Research";
            // 
            // costGroup
            // 
            this.costGroup.Controls.Add(this.conCostLabel);
            this.costGroup.Controls.Add(this.constructionCost);
            this.costGroup.Controls.Add(this.maintCostLabel);
            this.costGroup.Controls.Add(this.maintenanceCost);
            this.costGroup.Location = new System.Drawing.Point(4, 3);
            this.costGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.costGroup.Name = "costGroup";
            this.costGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.costGroup.Size = new System.Drawing.Size(182, 85);
            this.costGroup.TabIndex = 4;
            this.costGroup.TabStop = false;
            this.costGroup.Text = "Costs";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.encyText);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(413, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ency Data";
            // 
            // troopPicture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(26, 14);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picture.Name = "troopPicture";
            this.picture.Size = new System.Drawing.Size(147, 74);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // TroopsForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(425, 520);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.openNew);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.name);
            this.Controls.Add(this.isEmpireUnit);
            this.Controls.Add(this.isAllianceUnit);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(441, 559);
            this.MinimumSize = new System.Drawing.Size(441, 559);
            this.Name = "TroopsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Troops (TROOPSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.Enter += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.constructionCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardmentRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defenseRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atttackRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectionRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknwown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unknownMoralHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.miscDATGroup.ResumeLayout(false);
            this.miscDATGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.troopId)).EndInit();
            this.troopStatsBox.ResumeLayout(false);
            this.troopStatsBox.PerformLayout();
            this.researchBox.ResumeLayout(false);
            this.researchBox.PerformLayout();
            this.costGroup.ResumeLayout(false);
            this.costGroup.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}