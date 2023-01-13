using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class ProductionFacilitiesForm
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
        private RichTextBox encyclopediaDescription;
        private Label textStraDllIdLabel;
        private NumericUpDown textStraDllId;
        private Label field2_1Label;
        private NumericUpDown field2_1;
        private NumericUpDown familyId;
        private Label familyIdLabel;
        private NumericUpDown nextProductionFamily;
        private Label nextProductionFamilyLabel;
        private Label productionFamilyLabel;
        private NumericUpDown productionFamily;
        private NumericUpDown bombardmentDefense;
        private Label bombardmentDefenseLabel;
        private NumericUpDown researchDifficulty;
        private Label researchDifficultyLabel;
        private CheckBox isEmpire;
        private CheckBox isAlliance;
        private Label processingRateLabel;
        private NumericUpDown processingRate;
        private Label researchOrderLabel;
        private NumericUpDown researchOrder;
        private PictureBox picture;
        private NumericUpDown maintenanceCost;
        private Label refinedMaterialCostLabel;
        private Label maintenanceCostLabel;
        private NumericUpDown refinedMaterialCost;
        private GroupBox hiddenDataGroupBox;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionFacilitiesForm));
            this.Open = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.encyclopediaDescription = new System.Windows.Forms.RichTextBox();
            this.textStraDllIdLabel = new System.Windows.Forms.Label();
            this.textStraDllId = new System.Windows.Forms.NumericUpDown();
            this.field2_1Label = new System.Windows.Forms.Label();
            this.field2_1 = new System.Windows.Forms.NumericUpDown();
            this.familyId = new System.Windows.Forms.NumericUpDown();
            this.familyIdLabel = new System.Windows.Forms.Label();
            this.nextProductionFamily = new System.Windows.Forms.NumericUpDown();
            this.nextProductionFamilyLabel = new System.Windows.Forms.Label();
            this.productionFamilyLabel = new System.Windows.Forms.Label();
            this.productionFamily = new System.Windows.Forms.NumericUpDown();
            this.bombardmentDefense = new System.Windows.Forms.NumericUpDown();
            this.bombardmentDefenseLabel = new System.Windows.Forms.Label();
            this.researchDifficulty = new System.Windows.Forms.NumericUpDown();
            this.researchDifficultyLabel = new System.Windows.Forms.Label();
            this.isEmpire = new System.Windows.Forms.CheckBox();
            this.isAlliance = new System.Windows.Forms.CheckBox();
            this.selector = new System.Windows.Forms.TrackBar();
            this.processingRateLabel = new System.Windows.Forms.Label();
            this.processingRate = new System.Windows.Forms.NumericUpDown();
            this.researchOrderLabel = new System.Windows.Forms.Label();
            this.researchOrder = new System.Windows.Forms.NumericUpDown();
            this.maintenanceCost = new System.Windows.Forms.NumericUpDown();
            this.refinedMaterialCostLabel = new System.Windows.Forms.Label();
            this.maintenanceCostLabel = new System.Windows.Forms.Label();
            this.refinedMaterialCost = new System.Windows.Forms.NumericUpDown();
            this.hiddenDataGroupBox = new System.Windows.Forms.GroupBox();
            this.field7_2Label = new System.Windows.Forms.Label();
            this.field7_2 = new System.Windows.Forms.NumericUpDown();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.NumericUpDown();
            this.idLabel = new System.Windows.Forms.Label();
            this.idHexLabel = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.inGameDataGroupBox = new System.Windows.Forms.GroupBox();
            this.encyclopediaDescriptionLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardmentDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processingRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refinedMaterialCost)).BeginInit();
            this.hiddenDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.field7_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.inGameDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(399, 302);
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
            this.SaveAs.Location = new System.Drawing.Point(304, 302);
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
            this.Cancel.Location = new System.Drawing.Point(190, 302);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 27);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(95, 302);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 9;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // encyclopediaDescription
            // 
            this.encyclopediaDescription.Location = new System.Drawing.Point(220, 111);
            this.encyclopediaDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.encyclopediaDescription.Name = "encyclopediaDescription";
            this.encyclopediaDescription.Size = new System.Drawing.Size(260, 131);
            this.encyclopediaDescription.TabIndex = 67;
            this.encyclopediaDescription.TabStop = false;
            this.encyclopediaDescription.Text = "";
            this.encyclopediaDescription.TextChanged += new System.EventHandler(this.encyclopediaDescription_TextChanged);
            // 
            // textStraDllIdLabel
            // 
            this.textStraDllIdLabel.AutoSize = true;
            this.textStraDllIdLabel.ForeColor = System.Drawing.Color.Red;
            this.textStraDllIdLabel.Location = new System.Drawing.Point(14, 154);
            this.textStraDllIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textStraDllIdLabel.Name = "textStraDllIdLabel";
            this.textStraDllIdLabel.Size = new System.Drawing.Size(77, 15);
            this.textStraDllIdLabel.TabIndex = 68;
            this.textStraDllIdLabel.Text = "TextStra.dll Id";
            // 
            // textStraDllId
            // 
            this.textStraDllId.BackColor = System.Drawing.SystemColors.Window;
            this.textStraDllId.ForeColor = System.Drawing.Color.Red;
            this.textStraDllId.Location = new System.Drawing.Point(145, 152);
            this.textStraDllId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textStraDllId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.textStraDllId.Name = "textStraDllId";
            this.textStraDllId.Size = new System.Drawing.Size(59, 23);
            this.textStraDllId.TabIndex = 74;
            this.textStraDllId.TabStop = false;
            this.textStraDllId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textStraDllId.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.textStraDllId.ValueChanged += new System.EventHandler(this.textStraDllId_ValueChanged);
            // 
            // field2_1Label
            // 
            this.field2_1Label.AutoSize = true;
            this.field2_1Label.ForeColor = System.Drawing.Color.Red;
            this.field2_1Label.Location = new System.Drawing.Point(14, 50);
            this.field2_1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field2_1Label.Name = "field2_1Label";
            this.field2_1Label.Size = new System.Drawing.Size(93, 15);
            this.field2_1Label.TabIndex = 71;
            this.field2_1Label.Text = "Field2 (always 1)";
            // 
            // field2_1
            // 
            this.field2_1.BackColor = System.Drawing.SystemColors.Window;
            this.field2_1.ForeColor = System.Drawing.Color.Red;
            this.field2_1.Location = new System.Drawing.Point(145, 48);
            this.field2_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.field2_1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.field2_1.Name = "field2_1";
            this.field2_1.Size = new System.Drawing.Size(59, 23);
            this.field2_1.TabIndex = 72;
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
            this.familyId.Location = new System.Drawing.Point(145, 126);
            this.familyId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.familyId.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.familyId.Name = "familyId";
            this.familyId.Size = new System.Drawing.Size(59, 23);
            this.familyId.TabIndex = 73;
            this.familyId.TabStop = false;
            this.familyId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.familyId.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.familyId.ValueChanged += new System.EventHandler(this.familyId_ValueChanged);
            // 
            // familyIdLabel
            // 
            this.familyIdLabel.AutoSize = true;
            this.familyIdLabel.ForeColor = System.Drawing.Color.Red;
            this.familyIdLabel.Location = new System.Drawing.Point(14, 128);
            this.familyIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdLabel.Name = "familyIdLabel";
            this.familyIdLabel.Size = new System.Drawing.Size(55, 15);
            this.familyIdLabel.TabIndex = 66;
            this.familyIdLabel.Text = "Family Id";
            // 
            // nextProductionFamily
            // 
            this.nextProductionFamily.BackColor = System.Drawing.SystemColors.Window;
            this.nextProductionFamily.Location = new System.Drawing.Point(146, 100);
            this.nextProductionFamily.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextProductionFamily.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nextProductionFamily.Name = "nextProductionFamily";
            this.nextProductionFamily.Size = new System.Drawing.Size(59, 23);
            this.nextProductionFamily.TabIndex = 58;
            this.nextProductionFamily.TabStop = false;
            this.nextProductionFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nextProductionFamily.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nextProductionFamily.ValueChanged += new System.EventHandler(this.nextProductionFamily_ValueChanged);
            // 
            // nextProductionFamilyLabel
            // 
            this.nextProductionFamilyLabel.AutoSize = true;
            this.nextProductionFamilyLabel.Location = new System.Drawing.Point(14, 102);
            this.nextProductionFamilyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nextProductionFamilyLabel.Name = "nextProductionFamilyLabel";
            this.nextProductionFamilyLabel.Size = new System.Drawing.Size(121, 15);
            this.nextProductionFamilyLabel.TabIndex = 59;
            this.nextProductionFamilyLabel.Text = "Production Family +1";
            // 
            // productionFamilyLabel
            // 
            this.productionFamilyLabel.AutoSize = true;
            this.productionFamilyLabel.Location = new System.Drawing.Point(14, 76);
            this.productionFamilyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productionFamilyLabel.Name = "productionFamilyLabel";
            this.productionFamilyLabel.Size = new System.Drawing.Size(104, 15);
            this.productionFamilyLabel.TabIndex = 57;
            this.productionFamilyLabel.Text = "Production Family";
            // 
            // productionFamily
            // 
            this.productionFamily.BackColor = System.Drawing.SystemColors.Window;
            this.productionFamily.Location = new System.Drawing.Point(146, 74);
            this.productionFamily.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productionFamily.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.productionFamily.Name = "productionFamily";
            this.productionFamily.Size = new System.Drawing.Size(59, 23);
            this.productionFamily.TabIndex = 55;
            this.productionFamily.TabStop = false;
            this.productionFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.productionFamily.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.productionFamily.ValueChanged += new System.EventHandler(this.productionFamily_ValueChanged);
            // 
            // bombardmentDefense
            // 
            this.bombardmentDefense.Location = new System.Drawing.Point(154, 161);
            this.bombardmentDefense.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bombardmentDefense.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bombardmentDefense.Name = "bombardmentDefense";
            this.bombardmentDefense.Size = new System.Drawing.Size(59, 23);
            this.bombardmentDefense.TabIndex = 87;
            this.bombardmentDefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bombardmentDefense.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bombardmentDefense.ValueChanged += new System.EventHandler(this.bombardmentDefense_ValueChanged);
            // 
            // bombardmentDefenseLabel
            // 
            this.bombardmentDefenseLabel.AutoSize = true;
            this.bombardmentDefenseLabel.Location = new System.Drawing.Point(11, 163);
            this.bombardmentDefenseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bombardmentDefenseLabel.Name = "bombardmentDefenseLabel";
            this.bombardmentDefenseLabel.Size = new System.Drawing.Size(129, 15);
            this.bombardmentDefenseLabel.TabIndex = 56;
            this.bombardmentDefenseLabel.Text = "Bombardment Defense";
            // 
            // researchDifficulty
            // 
            this.researchDifficulty.ForeColor = System.Drawing.SystemColors.WindowText;
            this.researchDifficulty.Location = new System.Drawing.Point(145, 230);
            this.researchDifficulty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchDifficulty.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchDifficulty.Name = "researchDifficulty";
            this.researchDifficulty.Size = new System.Drawing.Size(59, 23);
            this.researchDifficulty.TabIndex = 86;
            this.researchDifficulty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.researchDifficulty.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchDifficulty.ValueChanged += new System.EventHandler(this.researchDifficulty_ValueChanged);
            // 
            // researchDifficultyLabel
            // 
            this.researchDifficultyLabel.AutoSize = true;
            this.researchDifficultyLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.researchDifficultyLabel.Location = new System.Drawing.Point(14, 232);
            this.researchDifficultyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.researchDifficultyLabel.Name = "researchDifficultyLabel";
            this.researchDifficultyLabel.Size = new System.Drawing.Size(105, 15);
            this.researchDifficultyLabel.TabIndex = 64;
            this.researchDifficultyLabel.Text = "Research Difficulty";
            // 
            // isEmpire
            // 
            this.isEmpire.AutoSize = true;
            this.isEmpire.Location = new System.Drawing.Point(220, 77);
            this.isEmpire.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isEmpire.Name = "isEmpire";
            this.isEmpire.Size = new System.Drawing.Size(63, 19);
            this.isEmpire.TabIndex = 3;
            this.isEmpire.Text = "Empire";
            this.isEmpire.UseVisualStyleBackColor = true;
            this.isEmpire.CheckStateChanged += new System.EventHandler(this.isEmpire_CheckStateChanged);
            // 
            // isAlliance
            // 
            this.isAlliance.AutoSize = true;
            this.isAlliance.Location = new System.Drawing.Point(220, 58);
            this.isAlliance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isAlliance.Name = "isAlliance";
            this.isAlliance.Size = new System.Drawing.Size(68, 19);
            this.isAlliance.TabIndex = 2;
            this.isAlliance.Text = "Alliance";
            this.isAlliance.UseVisualStyleBackColor = true;
            this.isAlliance.CheckStateChanged += new System.EventHandler(this.isAlliance_CheckStateChanged);
            // 
            // selector
            // 
            this.selector.LargeChange = 1;
            this.selector.Location = new System.Drawing.Point(23, 12);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 1;
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(469, 45);
            this.selector.TabIndex = 75;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            // 
            // processingRateLabel
            // 
            this.processingRateLabel.AutoSize = true;
            this.processingRateLabel.Location = new System.Drawing.Point(14, 258);
            this.processingRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.processingRateLabel.Name = "processingRateLabel";
            this.processingRateLabel.Size = new System.Drawing.Size(90, 15);
            this.processingRateLabel.TabIndex = 65;
            this.processingRateLabel.Text = "Processing Rate";
            // 
            // processingRate
            // 
            this.processingRate.Location = new System.Drawing.Point(145, 256);
            this.processingRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.processingRate.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.processingRate.Name = "processingRate";
            this.processingRate.Size = new System.Drawing.Size(58, 23);
            this.processingRate.TabIndex = 85;
            this.processingRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.processingRate.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.processingRate.ValueChanged += new System.EventHandler(this.processingRate_ValueChanged);
            // 
            // researchOrderLabel
            // 
            this.researchOrderLabel.AutoSize = true;
            this.researchOrderLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.researchOrderLabel.Location = new System.Drawing.Point(14, 206);
            this.researchOrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.researchOrderLabel.Name = "researchOrderLabel";
            this.researchOrderLabel.Size = new System.Drawing.Size(87, 15);
            this.researchOrderLabel.TabIndex = 60;
            this.researchOrderLabel.Text = "Research Order";
            // 
            // researchOrder
            // 
            this.researchOrder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.researchOrder.Location = new System.Drawing.Point(145, 204);
            this.researchOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchOrder.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchOrder.Name = "researchOrder";
            this.researchOrder.Size = new System.Drawing.Size(58, 23);
            this.researchOrder.TabIndex = 81;
            this.researchOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.researchOrder.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchOrder.ValueChanged += new System.EventHandler(this.researchOrder_ValueChanged);
            // 
            // maintenanceCost
            // 
            this.maintenanceCost.Location = new System.Drawing.Point(154, 136);
            this.maintenanceCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maintenanceCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maintenanceCost.Name = "maintenanceCost";
            this.maintenanceCost.Size = new System.Drawing.Size(58, 23);
            this.maintenanceCost.TabIndex = 97;
            this.maintenanceCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maintenanceCost.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maintenanceCost.ValueChanged += new System.EventHandler(this.maintenanceCost_ValueChanged);
            // 
            // refinedMaterialCostLabel
            // 
            this.refinedMaterialCostLabel.AutoSize = true;
            this.refinedMaterialCostLabel.Location = new System.Drawing.Point(11, 113);
            this.refinedMaterialCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.refinedMaterialCostLabel.Name = "refinedMaterialCostLabel";
            this.refinedMaterialCostLabel.Size = new System.Drawing.Size(120, 15);
            this.refinedMaterialCostLabel.TabIndex = 94;
            this.refinedMaterialCostLabel.Text = "Refined Material Cost";
            // 
            // maintenanceCostLabel
            // 
            this.maintenanceCostLabel.AutoSize = true;
            this.maintenanceCostLabel.Location = new System.Drawing.Point(11, 138);
            this.maintenanceCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maintenanceCostLabel.Name = "maintenanceCostLabel";
            this.maintenanceCostLabel.Size = new System.Drawing.Size(103, 15);
            this.maintenanceCostLabel.TabIndex = 95;
            this.maintenanceCostLabel.Text = "Maintenance Cost";
            // 
            // refinedMaterialCost
            // 
            this.refinedMaterialCost.Location = new System.Drawing.Point(154, 111);
            this.refinedMaterialCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.refinedMaterialCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.refinedMaterialCost.Name = "refinedMaterialCost";
            this.refinedMaterialCost.Size = new System.Drawing.Size(58, 23);
            this.refinedMaterialCost.TabIndex = 96;
            this.refinedMaterialCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.refinedMaterialCost.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.refinedMaterialCost.ValueChanged += new System.EventHandler(this.refinedMaterialCost_ValueChanged);
            // 
            // hiddenDataGroupBox
            // 
            this.hiddenDataGroupBox.Controls.Add(this.field7_2Label);
            this.hiddenDataGroupBox.Controls.Add(this.field7_2);
            this.hiddenDataGroupBox.Controls.Add(this.processingRateLabel);
            this.hiddenDataGroupBox.Controls.Add(this.processingRate);
            this.hiddenDataGroupBox.Controls.Add(this.familyIdHexLabel);
            this.hiddenDataGroupBox.Controls.Add(this.researchOrderLabel);
            this.hiddenDataGroupBox.Controls.Add(this.id);
            this.hiddenDataGroupBox.Controls.Add(this.researchDifficultyLabel);
            this.hiddenDataGroupBox.Controls.Add(this.idLabel);
            this.hiddenDataGroupBox.Controls.Add(this.productionFamilyLabel);
            this.hiddenDataGroupBox.Controls.Add(this.researchDifficulty);
            this.hiddenDataGroupBox.Controls.Add(this.researchOrder);
            this.hiddenDataGroupBox.Controls.Add(this.idHexLabel);
            this.hiddenDataGroupBox.Controls.Add(this.field2_1);
            this.hiddenDataGroupBox.Controls.Add(this.field2_1Label);
            this.hiddenDataGroupBox.Controls.Add(this.productionFamily);
            this.hiddenDataGroupBox.Controls.Add(this.nextProductionFamilyLabel);
            this.hiddenDataGroupBox.Controls.Add(this.familyIdLabel);
            this.hiddenDataGroupBox.Controls.Add(this.textStraDllIdLabel);
            this.hiddenDataGroupBox.Controls.Add(this.nextProductionFamily);
            this.hiddenDataGroupBox.Controls.Add(this.familyId);
            this.hiddenDataGroupBox.Controls.Add(this.textStraDllId);
            this.hiddenDataGroupBox.Location = new System.Drawing.Point(506, 12);
            this.hiddenDataGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hiddenDataGroupBox.Name = "hiddenDataGroupBox";
            this.hiddenDataGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hiddenDataGroupBox.Size = new System.Drawing.Size(254, 284);
            this.hiddenDataGroupBox.TabIndex = 8;
            this.hiddenDataGroupBox.TabStop = false;
            this.hiddenDataGroupBox.Text = "Hidden Data";
            // 
            // field7_2Label
            // 
            this.field7_2Label.AutoSize = true;
            this.field7_2Label.ForeColor = System.Drawing.Color.Red;
            this.field7_2Label.Location = new System.Drawing.Point(14, 180);
            this.field7_2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field7_2Label.Name = "field7_2Label";
            this.field7_2Label.Size = new System.Drawing.Size(93, 15);
            this.field7_2Label.TabIndex = 1136;
            this.field7_2Label.Text = "Field7 (always 2)";
            // 
            // field7_2
            // 
            this.field7_2.BackColor = System.Drawing.SystemColors.Window;
            this.field7_2.ForeColor = System.Drawing.Color.Red;
            this.field7_2.Location = new System.Drawing.Point(145, 178);
            this.field7_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.field7_2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.field7_2.Name = "field7_2";
            this.field7_2.Size = new System.Drawing.Size(59, 23);
            this.field7_2.TabIndex = 1137;
            this.field7_2.TabStop = false;
            this.field7_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.field7_2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.field7_2.ValueChanged += new System.EventHandler(this.field7_2_ValueChanged);
            // 
            // familyIdHexLabel
            // 
            this.familyIdHexLabel.AutoSize = true;
            this.familyIdHexLabel.Enabled = false;
            this.familyIdHexLabel.ForeColor = System.Drawing.Color.Red;
            this.familyIdHexLabel.Location = new System.Drawing.Point(206, 130);
            this.familyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdHexLabel.Name = "familyIdHexLabel";
            this.familyIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.familyIdHexLabel.TabIndex = 1135;
            this.familyIdHexLabel.Text = "hex";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.Window;
            this.id.ForeColor = System.Drawing.Color.Red;
            this.id.Location = new System.Drawing.Point(145, 22);
            this.id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.id.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(59, 23);
            this.id.TabIndex = 1133;
            this.id.TabStop = false;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.id.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.id.ValueChanged += new System.EventHandler(this.id_ValueChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.ForeColor = System.Drawing.Color.Red;
            this.idLabel.Location = new System.Drawing.Point(14, 24);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(17, 15);
            this.idLabel.TabIndex = 1132;
            this.idLabel.Text = "Id";
            // 
            // idHexLabel
            // 
            this.idHexLabel.AutoSize = true;
            this.idHexLabel.Enabled = false;
            this.idHexLabel.ForeColor = System.Drawing.Color.Red;
            this.idHexLabel.Location = new System.Drawing.Point(206, 24);
            this.idHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idHexLabel.Name = "idHexLabel";
            this.idHexLabel.Size = new System.Drawing.Size(26, 15);
            this.idHexLabel.TabIndex = 1134;
            this.idHexLabel.Text = "hex";
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(24, 22);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(147, 74);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 76;
            this.picture.TabStop = false;
            // 
            // inGameDataGroupBox
            // 
            this.inGameDataGroupBox.Controls.Add(this.encyclopediaDescriptionLabel);
            this.inGameDataGroupBox.Controls.Add(this.name);
            this.inGameDataGroupBox.Controls.Add(this.encyclopediaDescription);
            this.inGameDataGroupBox.Controls.Add(this.maintenanceCost);
            this.inGameDataGroupBox.Controls.Add(this.refinedMaterialCostLabel);
            this.inGameDataGroupBox.Controls.Add(this.bombardmentDefense);
            this.inGameDataGroupBox.Controls.Add(this.bombardmentDefenseLabel);
            this.inGameDataGroupBox.Controls.Add(this.maintenanceCostLabel);
            this.inGameDataGroupBox.Controls.Add(this.refinedMaterialCost);
            this.inGameDataGroupBox.Controls.Add(this.isEmpire);
            this.inGameDataGroupBox.Controls.Add(this.isAlliance);
            this.inGameDataGroupBox.Controls.Add(this.picture);
            this.inGameDataGroupBox.Location = new System.Drawing.Point(12, 48);
            this.inGameDataGroupBox.Name = "inGameDataGroupBox";
            this.inGameDataGroupBox.Size = new System.Drawing.Size(487, 248);
            this.inGameDataGroupBox.TabIndex = 90;
            this.inGameDataGroupBox.TabStop = false;
            this.inGameDataGroupBox.Text = "In Game Data";
            // 
            // encyclopediaDescriptionLabel
            // 
            this.encyclopediaDescriptionLabel.AutoSize = true;
            this.encyclopediaDescriptionLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.encyclopediaDescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.encyclopediaDescriptionLabel.Location = new System.Drawing.Point(335, 98);
            this.encyclopediaDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encyclopediaDescriptionLabel.Name = "encyclopediaDescriptionLabel";
            this.encyclopediaDescriptionLabel.Size = new System.Drawing.Size(140, 15);
            this.encyclopediaDescriptionLabel.TabIndex = 1126;
            this.encyclopediaDescriptionLabel.Text = "Encyclopedia Description";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(220, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(260, 23);
            this.name.TabIndex = 98;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // ProductionFacilitiesForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(766, 334);
            this.Controls.Add(this.hiddenDataGroupBox);
            this.Controls.Add(this.inGameDataGroupBox);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.selector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(782, 373);
            this.MinimumSize = new System.Drawing.Size(782, 373);
            this.Name = "ProductionFacilitiesForm";
            this.Text = "Production Facilities (PROFACSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.Enter += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardmentDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processingRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refinedMaterialCost)).EndInit();
            this.hiddenDataGroupBox.ResumeLayout(false);
            this.hiddenDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.field7_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.inGameDataGroupBox.ResumeLayout(false);
            this.inGameDataGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox inGameDataGroupBox;
        private TextBox name;
        private Label encyclopediaDescriptionLabel;
        private Label field7_2Label;
        private NumericUpDown field7_2;
    }
}