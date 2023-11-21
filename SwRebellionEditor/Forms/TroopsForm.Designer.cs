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
        private Button Open;
        private Button SaveAs;
        private Button Cancel;
        private Button Ok;
        private TrackBar selector;
        private CheckBox isAlliance;
        private CheckBox isEmpire;
        private GroupBox hiddenDataGroupBox;
        private RichTextBox encyclopediaDescription;
        private PictureBox picture;
        private ImageList troopsImages;
        private ListView troopsListView;
        private NumericUpDown field2_1;
        private NumericUpDown textStraDllId;
        private NumericUpDown productionFamily;
        private Label field2_1Label;
        private NumericUpDown familyId;
        private Label productionFamilyLabel;
        private Label textStraDllIdLabel;
        private Label familyIdLabel;
        private Label nextProductionFamilyLabel;
        private NumericUpDown nextProductionFamily;
        private Label familyIdHexLabel;
        private Label idHexLabel;
        private NumericUpDown id;
        private Label idLabel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TroopsForm));
            this.hiddenDataGroupBox = new System.Windows.Forms.GroupBox();
            this.uprisingDefense = new System.Windows.Forms.NumericUpDown();
            this.uprisingDefenseLabel = new System.Windows.Forms.Label();
            this.researchDifficulty = new System.Windows.Forms.NumericUpDown();
            this.field7_2 = new System.Windows.Forms.NumericUpDown();
            this.researchDifficultyLabel = new System.Windows.Forms.Label();
            this.field7_2Label = new System.Windows.Forms.Label();
            this.researchOrder = new System.Windows.Forms.NumericUpDown();
            this.researchOrderLabel = new System.Windows.Forms.Label();
            this.textStraDllId = new System.Windows.Forms.NumericUpDown();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.textStraDllIdLabel = new System.Windows.Forms.Label();
            this.field2_1 = new System.Windows.Forms.NumericUpDown();
            this.familyId = new System.Windows.Forms.NumericUpDown();
            this.productionFamily = new System.Windows.Forms.NumericUpDown();
            this.idHexLabel = new System.Windows.Forms.Label();
            this.familyIdLabel = new System.Windows.Forms.Label();
            this.productionFamilyLabel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.NumericUpDown();
            this.field2_1Label = new System.Windows.Forms.Label();
            this.nextProductionFamilyLabel = new System.Windows.Forms.Label();
            this.nextProductionFamily = new System.Windows.Forms.NumericUpDown();
            this.idLabel = new System.Windows.Forms.Label();
            this.maintenanceCost = new System.Windows.Forms.NumericUpDown();
            this.maintenanceCostLabel = new System.Windows.Forms.Label();
            this.refinedMaterialCost = new System.Windows.Forms.NumericUpDown();
            this.refinedMaterialCostLabel = new System.Windows.Forms.Label();
            this.encyclopediaDescription = new System.Windows.Forms.RichTextBox();
            this.selector = new System.Windows.Forms.TrackBar();
            this.isAlliance = new System.Windows.Forms.CheckBox();
            this.isEmpire = new System.Windows.Forms.CheckBox();
            this.Open = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.troopsImages = new System.Windows.Forms.ImageList(this.components);
            this.troopsListView = new System.Windows.Forms.ListView();
            this.picture = new System.Windows.Forms.PictureBox();
            this.gameDataGroupBox = new System.Windows.Forms.GroupBox();
            this.detection = new System.Windows.Forms.NumericUpDown();
            this.detectionLabel = new System.Windows.Forms.Label();
            this.bombardmentDefense = new System.Windows.Forms.NumericUpDown();
            this.bombardmentDefenseLabel = new System.Windows.Forms.Label();
            this.defenseStrength = new System.Windows.Forms.NumericUpDown();
            this.defenseStrengthLabel = new System.Windows.Forms.Label();
            this.attackStrength = new System.Windows.Forms.NumericUpDown();
            this.attackStrengthLabel = new System.Windows.Forms.Label();
            this.encyclopediaDescriptionLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.hiddenDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uprisingDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refinedMaterialCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.gameDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardmentDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defenseStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackStrength)).BeginInit();
            this.SuspendLayout();
            // 
            // hiddenDataGroupBox
            // 
            this.hiddenDataGroupBox.Controls.Add(this.uprisingDefense);
            this.hiddenDataGroupBox.Controls.Add(this.uprisingDefenseLabel);
            this.hiddenDataGroupBox.Controls.Add(this.researchDifficulty);
            this.hiddenDataGroupBox.Controls.Add(this.field7_2);
            this.hiddenDataGroupBox.Controls.Add(this.researchDifficultyLabel);
            this.hiddenDataGroupBox.Controls.Add(this.field7_2Label);
            this.hiddenDataGroupBox.Controls.Add(this.researchOrder);
            this.hiddenDataGroupBox.Controls.Add(this.researchOrderLabel);
            this.hiddenDataGroupBox.Controls.Add(this.textStraDllId);
            this.hiddenDataGroupBox.Controls.Add(this.familyIdHexLabel);
            this.hiddenDataGroupBox.Controls.Add(this.textStraDllIdLabel);
            this.hiddenDataGroupBox.Controls.Add(this.field2_1);
            this.hiddenDataGroupBox.Controls.Add(this.familyId);
            this.hiddenDataGroupBox.Controls.Add(this.productionFamily);
            this.hiddenDataGroupBox.Controls.Add(this.idHexLabel);
            this.hiddenDataGroupBox.Controls.Add(this.familyIdLabel);
            this.hiddenDataGroupBox.Controls.Add(this.productionFamilyLabel);
            this.hiddenDataGroupBox.Controls.Add(this.id);
            this.hiddenDataGroupBox.Controls.Add(this.field2_1Label);
            this.hiddenDataGroupBox.Controls.Add(this.nextProductionFamilyLabel);
            this.hiddenDataGroupBox.Controls.Add(this.nextProductionFamily);
            this.hiddenDataGroupBox.Controls.Add(this.idLabel);
            this.hiddenDataGroupBox.Location = new System.Drawing.Point(566, 6);
            this.hiddenDataGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hiddenDataGroupBox.Name = "hiddenDataGroupBox";
            this.hiddenDataGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hiddenDataGroupBox.Size = new System.Drawing.Size(232, 420);
            this.hiddenDataGroupBox.TabIndex = 6;
            this.hiddenDataGroupBox.TabStop = false;
            this.hiddenDataGroupBox.Text = "Hidden Data";
            // 
            // uprisingDefense
            // 
            this.uprisingDefense.BackColor = System.Drawing.SystemColors.Window;
            this.uprisingDefense.ForeColor = System.Drawing.SystemColors.WindowText;
            this.uprisingDefense.Location = new System.Drawing.Point(136, 253);
            this.uprisingDefense.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uprisingDefense.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.uprisingDefense.Name = "uprisingDefense";
            this.uprisingDefense.Size = new System.Drawing.Size(59, 23);
            this.uprisingDefense.TabIndex = 1143;
            this.uprisingDefense.TabStop = false;
            this.uprisingDefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.uprisingDefense.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.uprisingDefense.ValueChanged += new System.EventHandler(this.uprisingDefense_ValueChanged);
            // 
            // uprisingDefenseLabel
            // 
            this.uprisingDefenseLabel.AutoSize = true;
            this.uprisingDefenseLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.uprisingDefenseLabel.Location = new System.Drawing.Point(7, 255);
            this.uprisingDefenseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uprisingDefenseLabel.Name = "uprisingDefenseLabel";
            this.uprisingDefenseLabel.Size = new System.Drawing.Size(96, 15);
            this.uprisingDefenseLabel.TabIndex = 1142;
            this.uprisingDefenseLabel.Text = "Uprising Defense";
            // 
            // researchDifficulty
            // 
            this.researchDifficulty.BackColor = System.Drawing.SystemColors.Window;
            this.researchDifficulty.ForeColor = System.Drawing.SystemColors.WindowText;
            this.researchDifficulty.Location = new System.Drawing.Point(136, 227);
            this.researchDifficulty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchDifficulty.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.researchDifficulty.Name = "researchDifficulty";
            this.researchDifficulty.Size = new System.Drawing.Size(59, 23);
            this.researchDifficulty.TabIndex = 1141;
            this.researchDifficulty.TabStop = false;
            this.researchDifficulty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.researchDifficulty.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.researchDifficulty.ValueChanged += new System.EventHandler(this.researchDifficulty_ValueChanged);
            // 
            // field7_2
            // 
            this.field7_2.BackColor = System.Drawing.SystemColors.Window;
            this.field7_2.ForeColor = System.Drawing.Color.Red;
            this.field7_2.Location = new System.Drawing.Point(136, 175);
            this.field7_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.field7_2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.field7_2.Name = "field7_2";
            this.field7_2.Size = new System.Drawing.Size(59, 23);
            this.field7_2.TabIndex = 1129;
            this.field7_2.TabStop = false;
            this.field7_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.field7_2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.field7_2.ValueChanged += new System.EventHandler(this.field7_2_ValueChanged);
            // 
            // researchDifficultyLabel
            // 
            this.researchDifficultyLabel.AutoSize = true;
            this.researchDifficultyLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.researchDifficultyLabel.Location = new System.Drawing.Point(7, 229);
            this.researchDifficultyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.researchDifficultyLabel.Name = "researchDifficultyLabel";
            this.researchDifficultyLabel.Size = new System.Drawing.Size(105, 15);
            this.researchDifficultyLabel.TabIndex = 1140;
            this.researchDifficultyLabel.Text = "Research Difficulty";
            // 
            // field7_2Label
            // 
            this.field7_2Label.AutoSize = true;
            this.field7_2Label.ForeColor = System.Drawing.Color.Red;
            this.field7_2Label.Location = new System.Drawing.Point(6, 177);
            this.field7_2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field7_2Label.Name = "field7_2Label";
            this.field7_2Label.Size = new System.Drawing.Size(93, 15);
            this.field7_2Label.TabIndex = 1128;
            this.field7_2Label.Text = "Field7 (always 2)";
            // 
            // researchOrder
            // 
            this.researchOrder.BackColor = System.Drawing.SystemColors.Window;
            this.researchOrder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.researchOrder.Location = new System.Drawing.Point(136, 201);
            this.researchOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchOrder.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.researchOrder.Name = "researchOrder";
            this.researchOrder.Size = new System.Drawing.Size(59, 23);
            this.researchOrder.TabIndex = 1139;
            this.researchOrder.TabStop = false;
            this.researchOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.researchOrder.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.researchOrder.ValueChanged += new System.EventHandler(this.researchOrder_ValueChanged);
            // 
            // researchOrderLabel
            // 
            this.researchOrderLabel.AutoSize = true;
            this.researchOrderLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.researchOrderLabel.Location = new System.Drawing.Point(7, 203);
            this.researchOrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.researchOrderLabel.Name = "researchOrderLabel";
            this.researchOrderLabel.Size = new System.Drawing.Size(87, 15);
            this.researchOrderLabel.TabIndex = 1138;
            this.researchOrderLabel.Text = "Research Order";
            // 
            // textStraDllId
            // 
            this.textStraDllId.BackColor = System.Drawing.SystemColors.Window;
            this.textStraDllId.ForeColor = System.Drawing.Color.Red;
            this.textStraDllId.Location = new System.Drawing.Point(136, 149);
            this.textStraDllId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textStraDllId.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.textStraDllId.Name = "textStraDllId";
            this.textStraDllId.Size = new System.Drawing.Size(59, 23);
            this.textStraDllId.TabIndex = 148;
            this.textStraDllId.TabStop = false;
            this.textStraDllId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textStraDllId.Value = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.textStraDllId.ValueChanged += new System.EventHandler(this.textStraDllId_ValueChanged);
            // 
            // familyIdHexLabel
            // 
            this.familyIdHexLabel.AutoSize = true;
            this.familyIdHexLabel.ForeColor = System.Drawing.Color.Red;
            this.familyIdHexLabel.Location = new System.Drawing.Point(197, 128);
            this.familyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdHexLabel.Name = "familyIdHexLabel";
            this.familyIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.familyIdHexLabel.TabIndex = 1127;
            this.familyIdHexLabel.Text = "hex";
            // 
            // textStraDllIdLabel
            // 
            this.textStraDllIdLabel.AutoSize = true;
            this.textStraDllIdLabel.ForeColor = System.Drawing.Color.Red;
            this.textStraDllIdLabel.Location = new System.Drawing.Point(7, 151);
            this.textStraDllIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textStraDllIdLabel.Name = "textStraDllIdLabel";
            this.textStraDllIdLabel.Size = new System.Drawing.Size(77, 15);
            this.textStraDllIdLabel.TabIndex = 144;
            this.textStraDllIdLabel.Text = "TextStra.dll Id";
            // 
            // field2_1
            // 
            this.field2_1.BackColor = System.Drawing.SystemColors.Window;
            this.field2_1.ForeColor = System.Drawing.Color.Red;
            this.field2_1.Location = new System.Drawing.Point(136, 45);
            this.field2_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.field2_1.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.field2_1.Name = "field2_1";
            this.field2_1.Size = new System.Drawing.Size(59, 23);
            this.field2_1.TabIndex = 146;
            this.field2_1.TabStop = false;
            this.field2_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.field2_1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.field2_1.ValueChanged += new System.EventHandler(this.field2_1_ValueChanged);
            // 
            // familyId
            // 
            this.familyId.BackColor = System.Drawing.SystemColors.Window;
            this.familyId.ForeColor = System.Drawing.Color.Red;
            this.familyId.Location = new System.Drawing.Point(136, 123);
            this.familyId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.familyId.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.familyId.Name = "familyId";
            this.familyId.Size = new System.Drawing.Size(59, 23);
            this.familyId.TabIndex = 147;
            this.familyId.TabStop = false;
            this.familyId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.familyId.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.familyId.ValueChanged += new System.EventHandler(this.familyId_ValueChanged);
            // 
            // productionFamily
            // 
            this.productionFamily.BackColor = System.Drawing.SystemColors.Window;
            this.productionFamily.ForeColor = System.Drawing.SystemColors.WindowText;
            this.productionFamily.Location = new System.Drawing.Point(136, 71);
            this.productionFamily.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productionFamily.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.productionFamily.Name = "productionFamily";
            this.productionFamily.Size = new System.Drawing.Size(59, 23);
            this.productionFamily.TabIndex = 138;
            this.productionFamily.TabStop = false;
            this.productionFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.productionFamily.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.productionFamily.ValueChanged += new System.EventHandler(this.productionFamily_ValueChanged);
            // 
            // idHexLabel
            // 
            this.idHexLabel.AutoSize = true;
            this.idHexLabel.ForeColor = System.Drawing.Color.Red;
            this.idHexLabel.Location = new System.Drawing.Point(197, 21);
            this.idHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idHexLabel.Name = "idHexLabel";
            this.idHexLabel.Size = new System.Drawing.Size(26, 15);
            this.idHexLabel.TabIndex = 1126;
            this.idHexLabel.Text = "hex";
            // 
            // familyIdLabel
            // 
            this.familyIdLabel.AutoSize = true;
            this.familyIdLabel.ForeColor = System.Drawing.Color.Red;
            this.familyIdLabel.Location = new System.Drawing.Point(7, 125);
            this.familyIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdLabel.Name = "familyIdLabel";
            this.familyIdLabel.Size = new System.Drawing.Size(55, 15);
            this.familyIdLabel.TabIndex = 143;
            this.familyIdLabel.Text = "Family Id";
            // 
            // productionFamilyLabel
            // 
            this.productionFamilyLabel.AutoSize = true;
            this.productionFamilyLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.productionFamilyLabel.Location = new System.Drawing.Point(6, 73);
            this.productionFamilyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productionFamilyLabel.Name = "productionFamilyLabel";
            this.productionFamilyLabel.Size = new System.Drawing.Size(104, 15);
            this.productionFamilyLabel.TabIndex = 140;
            this.productionFamilyLabel.Text = "Production Family";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.Window;
            this.id.ForeColor = System.Drawing.Color.Red;
            this.id.Location = new System.Drawing.Point(136, 19);
            this.id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.id.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(59, 23);
            this.id.TabIndex = 1125;
            this.id.TabStop = false;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.id.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.id.ValueChanged += new System.EventHandler(this.id_ValueChanged);
            // 
            // field2_1Label
            // 
            this.field2_1Label.AutoSize = true;
            this.field2_1Label.ForeColor = System.Drawing.Color.Red;
            this.field2_1Label.Location = new System.Drawing.Point(6, 47);
            this.field2_1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field2_1Label.Name = "field2_1Label";
            this.field2_1Label.Size = new System.Drawing.Size(93, 15);
            this.field2_1Label.TabIndex = 145;
            this.field2_1Label.Text = "Field2 (always 1)";
            // 
            // nextProductionFamilyLabel
            // 
            this.nextProductionFamilyLabel.AutoSize = true;
            this.nextProductionFamilyLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nextProductionFamilyLabel.Location = new System.Drawing.Point(7, 99);
            this.nextProductionFamilyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nextProductionFamilyLabel.Name = "nextProductionFamilyLabel";
            this.nextProductionFamilyLabel.Size = new System.Drawing.Size(121, 15);
            this.nextProductionFamilyLabel.TabIndex = 142;
            this.nextProductionFamilyLabel.Text = "Production Family +1";
            // 
            // nextProductionFamily
            // 
            this.nextProductionFamily.BackColor = System.Drawing.SystemColors.Window;
            this.nextProductionFamily.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nextProductionFamily.Location = new System.Drawing.Point(136, 97);
            this.nextProductionFamily.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextProductionFamily.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nextProductionFamily.Name = "nextProductionFamily";
            this.nextProductionFamily.Size = new System.Drawing.Size(59, 23);
            this.nextProductionFamily.TabIndex = 141;
            this.nextProductionFamily.TabStop = false;
            this.nextProductionFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nextProductionFamily.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.nextProductionFamily.ValueChanged += new System.EventHandler(this.nextProductionFamily_ValueChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.ForeColor = System.Drawing.Color.Red;
            this.idLabel.Location = new System.Drawing.Point(7, 21);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(17, 15);
            this.idLabel.TabIndex = 1124;
            this.idLabel.Text = "Id";
            // 
            // maintenanceCost
            // 
            this.maintenanceCost.BackColor = System.Drawing.SystemColors.Window;
            this.maintenanceCost.ForeColor = System.Drawing.SystemColors.WindowText;
            this.maintenanceCost.Location = new System.Drawing.Point(152, 164);
            this.maintenanceCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maintenanceCost.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.maintenanceCost.Name = "maintenanceCost";
            this.maintenanceCost.Size = new System.Drawing.Size(59, 23);
            this.maintenanceCost.TabIndex = 1133;
            this.maintenanceCost.TabStop = false;
            this.maintenanceCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maintenanceCost.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.maintenanceCost.ValueChanged += new System.EventHandler(this.maintenanceCost_ValueChanged);
            // 
            // maintenanceCostLabel
            // 
            this.maintenanceCostLabel.AutoSize = true;
            this.maintenanceCostLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.maintenanceCostLabel.Location = new System.Drawing.Point(19, 166);
            this.maintenanceCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maintenanceCostLabel.Name = "maintenanceCostLabel";
            this.maintenanceCostLabel.Size = new System.Drawing.Size(103, 15);
            this.maintenanceCostLabel.TabIndex = 1132;
            this.maintenanceCostLabel.Text = "Maintenance Cost";
            // 
            // refinedMaterialCost
            // 
            this.refinedMaterialCost.BackColor = System.Drawing.SystemColors.Window;
            this.refinedMaterialCost.ForeColor = System.Drawing.SystemColors.WindowText;
            this.refinedMaterialCost.Location = new System.Drawing.Point(152, 138);
            this.refinedMaterialCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.refinedMaterialCost.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.refinedMaterialCost.Name = "refinedMaterialCost";
            this.refinedMaterialCost.Size = new System.Drawing.Size(59, 23);
            this.refinedMaterialCost.TabIndex = 1131;
            this.refinedMaterialCost.TabStop = false;
            this.refinedMaterialCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.refinedMaterialCost.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.refinedMaterialCost.ValueChanged += new System.EventHandler(this.refinedMaterialCost_ValueChanged);
            // 
            // refinedMaterialCostLabel
            // 
            this.refinedMaterialCostLabel.AutoSize = true;
            this.refinedMaterialCostLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.refinedMaterialCostLabel.Location = new System.Drawing.Point(18, 140);
            this.refinedMaterialCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.refinedMaterialCostLabel.Name = "refinedMaterialCostLabel";
            this.refinedMaterialCostLabel.Size = new System.Drawing.Size(120, 15);
            this.refinedMaterialCostLabel.TabIndex = 1130;
            this.refinedMaterialCostLabel.Text = "Refined Material Cost";
            // 
            // encyclopediaDescription
            // 
            this.encyclopediaDescription.Location = new System.Drawing.Point(7, 295);
            this.encyclopediaDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.encyclopediaDescription.Name = "encyclopediaDescription";
            this.encyclopediaDescription.Size = new System.Drawing.Size(364, 82);
            this.encyclopediaDescription.TabIndex = 134;
            this.encyclopediaDescription.TabStop = false;
            this.encyclopediaDescription.Text = "";
            this.encyclopediaDescription.TextChanged += new System.EventHandler(this.encyclopediaDescription_TextChanged);
            // 
            // selector
            // 
            this.selector.LargeChange = 1;
            this.selector.Location = new System.Drawing.Point(186, 6);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 9;
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(376, 45);
            this.selector.TabIndex = 1;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            // 
            // isAlliance
            // 
            this.isAlliance.AutoSize = true;
            this.isAlliance.Location = new System.Drawing.Point(247, 47);
            this.isAlliance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isAlliance.Name = "isAlliance";
            this.isAlliance.Size = new System.Drawing.Size(68, 19);
            this.isAlliance.TabIndex = 15;
            this.isAlliance.Text = "Alliance";
            this.isAlliance.UseVisualStyleBackColor = true;
            this.isAlliance.CheckStateChanged += new System.EventHandler(this.isAlliance_CheckStateChanged);
            // 
            // isEmpire
            // 
            this.isEmpire.AutoSize = true;
            this.isEmpire.Location = new System.Drawing.Point(247, 64);
            this.isEmpire.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isEmpire.Name = "isEmpire";
            this.isEmpire.Size = new System.Drawing.Size(63, 19);
            this.isEmpire.TabIndex = 16;
            this.isEmpire.Text = "Empire";
            this.isEmpire.UseVisualStyleBackColor = true;
            this.isEmpire.CheckStateChanged += new System.EventHandler(this.isEmpire_CheckStateChanged);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(459, 430);
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
            this.SaveAs.Location = new System.Drawing.Point(364, 430);
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
            this.Cancel.Location = new System.Drawing.Point(186, 430);
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
            this.Ok.Location = new System.Drawing.Point(91, 430);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 7;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // troopsImages
            // 
            this.troopsImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.troopsImages.ImageSize = new System.Drawing.Size(120, 60);
            this.troopsImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // troopsListView
            // 
            this.troopsListView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.troopsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.troopsListView.GridLines = true;
            this.troopsListView.LargeImageList = this.troopsImages;
            this.troopsListView.Location = new System.Drawing.Point(0, 0);
            this.troopsListView.Margin = new System.Windows.Forms.Padding(0);
            this.troopsListView.MultiSelect = false;
            this.troopsListView.Name = "troopsListView";
            this.troopsListView.ShowGroups = false;
            this.troopsListView.Size = new System.Drawing.Size(179, 426);
            this.troopsListView.TabIndex = 0;
            this.troopsListView.TabStop = false;
            this.troopsListView.UseCompatibleStateImageBehavior = false;
            this.troopsListView.Click += new System.EventHandler(this.troopsListView_Click);
            this.troopsListView.DoubleClick += new System.EventHandler(this.troopsListView_DoubleClick);
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(7, 22);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(220, 110);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 134;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // gameDataGroupBox
            // 
            this.gameDataGroupBox.Controls.Add(this.detection);
            this.gameDataGroupBox.Controls.Add(this.detectionLabel);
            this.gameDataGroupBox.Controls.Add(this.bombardmentDefense);
            this.gameDataGroupBox.Controls.Add(this.bombardmentDefenseLabel);
            this.gameDataGroupBox.Controls.Add(this.defenseStrength);
            this.gameDataGroupBox.Controls.Add(this.defenseStrengthLabel);
            this.gameDataGroupBox.Controls.Add(this.attackStrength);
            this.gameDataGroupBox.Controls.Add(this.attackStrengthLabel);
            this.gameDataGroupBox.Controls.Add(this.encyclopediaDescriptionLabel);
            this.gameDataGroupBox.Controls.Add(this.encyclopediaDescription);
            this.gameDataGroupBox.Controls.Add(this.name);
            this.gameDataGroupBox.Controls.Add(this.isAlliance);
            this.gameDataGroupBox.Controls.Add(this.isEmpire);
            this.gameDataGroupBox.Controls.Add(this.picture);
            this.gameDataGroupBox.Controls.Add(this.refinedMaterialCostLabel);
            this.gameDataGroupBox.Controls.Add(this.refinedMaterialCost);
            this.gameDataGroupBox.Controls.Add(this.maintenanceCost);
            this.gameDataGroupBox.Controls.Add(this.maintenanceCostLabel);
            this.gameDataGroupBox.Location = new System.Drawing.Point(186, 43);
            this.gameDataGroupBox.Name = "gameDataGroupBox";
            this.gameDataGroupBox.Size = new System.Drawing.Size(376, 383);
            this.gameDataGroupBox.TabIndex = 135;
            this.gameDataGroupBox.TabStop = false;
            this.gameDataGroupBox.Text = "In Game Data";
            // 
            // detection
            // 
            this.detection.BackColor = System.Drawing.SystemColors.Window;
            this.detection.ForeColor = System.Drawing.SystemColors.WindowText;
            this.detection.Location = new System.Drawing.Point(152, 268);
            this.detection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.detection.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.detection.Name = "detection";
            this.detection.Size = new System.Drawing.Size(59, 23);
            this.detection.TabIndex = 1141;
            this.detection.TabStop = false;
            this.detection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.detection.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.detection.ValueChanged += new System.EventHandler(this.detection_ValueChanged);
            // 
            // detectionLabel
            // 
            this.detectionLabel.AutoSize = true;
            this.detectionLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.detectionLabel.Location = new System.Drawing.Point(19, 270);
            this.detectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detectionLabel.Name = "detectionLabel";
            this.detectionLabel.Size = new System.Drawing.Size(58, 15);
            this.detectionLabel.TabIndex = 1140;
            this.detectionLabel.Text = "Detection";
            // 
            // bombardmentDefense
            // 
            this.bombardmentDefense.BackColor = System.Drawing.SystemColors.Window;
            this.bombardmentDefense.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bombardmentDefense.Location = new System.Drawing.Point(152, 242);
            this.bombardmentDefense.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bombardmentDefense.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.bombardmentDefense.Name = "bombardmentDefense";
            this.bombardmentDefense.Size = new System.Drawing.Size(59, 23);
            this.bombardmentDefense.TabIndex = 1139;
            this.bombardmentDefense.TabStop = false;
            this.bombardmentDefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bombardmentDefense.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.bombardmentDefense.ValueChanged += new System.EventHandler(this.bombardmentDefense_ValueChanged);
            // 
            // bombardmentDefenseLabel
            // 
            this.bombardmentDefenseLabel.AutoSize = true;
            this.bombardmentDefenseLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bombardmentDefenseLabel.Location = new System.Drawing.Point(19, 244);
            this.bombardmentDefenseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bombardmentDefenseLabel.Name = "bombardmentDefenseLabel";
            this.bombardmentDefenseLabel.Size = new System.Drawing.Size(129, 15);
            this.bombardmentDefenseLabel.TabIndex = 1138;
            this.bombardmentDefenseLabel.Text = "Bombardment Defense";
            // 
            // defenseStrength
            // 
            this.defenseStrength.BackColor = System.Drawing.SystemColors.Window;
            this.defenseStrength.ForeColor = System.Drawing.SystemColors.WindowText;
            this.defenseStrength.Location = new System.Drawing.Point(152, 216);
            this.defenseStrength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.defenseStrength.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.defenseStrength.Name = "defenseStrength";
            this.defenseStrength.Size = new System.Drawing.Size(59, 23);
            this.defenseStrength.TabIndex = 1137;
            this.defenseStrength.TabStop = false;
            this.defenseStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.defenseStrength.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.defenseStrength.ValueChanged += new System.EventHandler(this.defenseStrength_ValueChanged);
            // 
            // defenseStrengthLabel
            // 
            this.defenseStrengthLabel.AutoSize = true;
            this.defenseStrengthLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.defenseStrengthLabel.Location = new System.Drawing.Point(19, 218);
            this.defenseStrengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.defenseStrengthLabel.Name = "defenseStrengthLabel";
            this.defenseStrengthLabel.Size = new System.Drawing.Size(97, 15);
            this.defenseStrengthLabel.TabIndex = 1136;
            this.defenseStrengthLabel.Text = "Defense Strength";
            // 
            // attackStrength
            // 
            this.attackStrength.BackColor = System.Drawing.SystemColors.Window;
            this.attackStrength.ForeColor = System.Drawing.SystemColors.WindowText;
            this.attackStrength.Location = new System.Drawing.Point(152, 190);
            this.attackStrength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.attackStrength.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.attackStrength.Name = "attackStrength";
            this.attackStrength.Size = new System.Drawing.Size(59, 23);
            this.attackStrength.TabIndex = 1135;
            this.attackStrength.TabStop = false;
            this.attackStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attackStrength.Value = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.attackStrength.ValueChanged += new System.EventHandler(this.attackStrength_ValueChanged);
            // 
            // attackStrengthLabel
            // 
            this.attackStrengthLabel.AutoSize = true;
            this.attackStrengthLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.attackStrengthLabel.Location = new System.Drawing.Point(19, 192);
            this.attackStrengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.attackStrengthLabel.Name = "attackStrengthLabel";
            this.attackStrengthLabel.Size = new System.Drawing.Size(89, 15);
            this.attackStrengthLabel.TabIndex = 1134;
            this.attackStrengthLabel.Text = "Attack Strength";
            // 
            // encyclopediaDescriptionLabel
            // 
            this.encyclopediaDescriptionLabel.AutoSize = true;
            this.encyclopediaDescriptionLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.encyclopediaDescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.encyclopediaDescriptionLabel.Location = new System.Drawing.Point(227, 281);
            this.encyclopediaDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encyclopediaDescriptionLabel.Name = "encyclopediaDescriptionLabel";
            this.encyclopediaDescriptionLabel.Size = new System.Drawing.Size(140, 15);
            this.encyclopediaDescriptionLabel.TabIndex = 1127;
            this.encyclopediaDescriptionLabel.Text = "Encyclopedia Description";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(234, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(137, 23);
            this.name.TabIndex = 135;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // TroopsForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(801, 462);
            this.Controls.Add(this.hiddenDataGroupBox);
            this.Controls.Add(this.gameDataGroupBox);
            this.Controls.Add(this.troopsListView);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.selector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(817, 501);
            this.MinimumSize = new System.Drawing.Size(817, 501);
            this.Name = "TroopsForm";
            this.Text = "Troops (TROOPSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.Enter += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);
            this.hiddenDataGroupBox.ResumeLayout(false);
            this.hiddenDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uprisingDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refinedMaterialCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.gameDataGroupBox.ResumeLayout(false);
            this.gameDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardmentDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defenseStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackStrength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gameDataGroupBox;
        private TextBox name;
        private NumericUpDown field7_2;
        private Label field7_2Label;
        private NumericUpDown maintenanceCost;
        private Label maintenanceCostLabel;
        private NumericUpDown refinedMaterialCost;
        private Label refinedMaterialCostLabel;
        private Label encyclopediaDescriptionLabel;
        private NumericUpDown detection;
        private Label detectionLabel;
        private NumericUpDown bombardmentDefense;
        private Label bombardmentDefenseLabel;
        private NumericUpDown defenseStrength;
        private Label defenseStrengthLabel;
        private NumericUpDown attackStrength;
        private Label attackStrengthLabel;
        private NumericUpDown uprisingDefense;
        private Label uprisingDefenseLabel;
        private NumericUpDown researchDifficulty;
        private Label researchDifficultyLabel;
        private NumericUpDown researchOrder;
        private Label researchOrderLabel;
    }
}