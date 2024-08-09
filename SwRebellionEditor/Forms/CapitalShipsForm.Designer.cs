using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SwRebellionEditor
{
    partial class CapitalShipsForm
    {
        /// <summary>
        /////// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TrackBar selector;
        private Button Open;
        private Button SaveAs;
        private Button Cancel;
        private Button Ok;
        private RichTextBox encyclopediaDescription;
        private Label textStraDllIdLabel;
        private NumericUpDown textStraDllId;
        private Label field7_2Label;
        private NumericUpDown field7_2;
        private NumericUpDown familyId;
        private Label familyIdLabel;
        private NumericUpDown nextProductionFamily;
        private Label nextProductionFamilyLabel;
        private Label productionFamilyLabel;
        private NumericUpDown productionFamily;
        private NumericUpDown uprisingDefense;
        private Label UprisingDefenseLabel;
        private NumericUpDown researchDifficulty;
        private Label researchDifficultyLabel;
        private CheckBox isEmpire;
        private CheckBox isAlliance;
        private Label detectionLabel;
        private NumericUpDown detection;
        private Label researchOrderLabel;
        private NumericUpDown researchOrder;
        private NumericUpDown maintenanceCost;
        private Label maintenanceCostLabel;
        private PictureBox picture;
        private NumericUpDown refinedMaterialCost;
        private Label refinedMaterialCostLabel;
        private GroupBox attackStrengthGroupBox;
        private Label foreLabel;
        private Label turbolaserRangeLabel;
        private Label starboardLabel;
        private Label portLabel;
        private Label aftLabel;
        private NumericUpDown turbolaserStarboard;
        private NumericUpDown turbolaserPort;
        private NumericUpDown turbolaserAft;
        private NumericUpDown turbolaserFore;
        private Label turboLaserLabel;
        private NumericUpDown ionCannonRange;
        private NumericUpDown ionCannonStarboard;
        private NumericUpDown ionCannonPort;
        private NumericUpDown ionCannonAft;
        private NumericUpDown turbolaserRange;
        private NumericUpDown ionCannonFore;
        private NumericUpDown laserCannonFore;
        private Label laserCannonLabel;
        private Label ionCannonLabel;
        private NumericUpDown laserCannonRange;
        private NumericUpDown laserCannonStarboard;
        private NumericUpDown laserCannonPort;
        private NumericUpDown laserCannonAft;
        private NumericUpDown bombardmentModifier;
        private NumericUpDown weaponRechargeRate;
        private Label bombardmentModifierLabel;
        private Label weaponRechargeRateLabel;
        private NumericUpDown tractorBeamRange;
        private NumericUpDown tractorBeamPower;
        private NumericUpDown interdictionStrength;
        private NumericUpDown gravityWellProjector;
        private Label interdictionStrengthLabel;
        private Label gravityWellProjectorLabel;
        private GroupBox inGameDataGroupBox;
        private NumericUpDown shieldRechargeRate;
        private Label shieldRechargeRateLabel;
        private NumericUpDown shieldStrength;
        private Label shieldStrengthLabel;
        private Label damageControlLabel;
        private NumericUpDown damageControl;
        private Label hullLabel;
        private NumericUpDown hull;
        private NumericUpDown hyperdrive;
        private Label maneuverabilityLabel;
        private NumericUpDown maneuverability;
        private Label subLightEngineLabel;
        private NumericUpDown subLightEngine;
        private Label hyperdriveIfDamagedLabel;
        private NumericUpDown hyperdriveIfDamaged;
        private NumericUpDown fighterCapacity;
        private Label fighterCapacityLabel;
        private NumericUpDown troopCapacity;
        private Label troopCapacityLabel;
        private NumericUpDown ionCannonAttackStrength;
        private NumericUpDown laserCannonAttackStrength;
        private NumericUpDown turbolaserAttackStrength;
        private NumericUpDown overallAttackStrength;
        private NumericUpDown id;
        private Label idLabel;
        private Label familyIdHexLabel;
        private Label idHexLabel;


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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(CapitalShipsForm));
            Open = new Button();
            SaveAs = new Button();
            Cancel = new Button();
            Ok = new Button();
            encyclopediaDescription = new RichTextBox();
            textStraDllIdLabel = new Label();
            textStraDllId = new NumericUpDown();
            field7_2Label = new Label();
            field7_2 = new NumericUpDown();
            familyId = new NumericUpDown();
            familyIdLabel = new Label();
            nextProductionFamily = new NumericUpDown();
            nextProductionFamilyLabel = new Label();
            productionFamilyLabel = new Label();
            productionFamily = new NumericUpDown();
            uprisingDefense = new NumericUpDown();
            UprisingDefenseLabel = new Label();
            researchDifficulty = new NumericUpDown();
            researchDifficultyLabel = new Label();
            isEmpire = new CheckBox();
            isAlliance = new CheckBox();
            selector = new TrackBar();
            detectionLabel = new Label();
            detection = new NumericUpDown();
            researchOrderLabel = new Label();
            researchOrder = new NumericUpDown();
            maintenanceCost = new NumericUpDown();
            maintenanceCostLabel = new Label();
            refinedMaterialCost = new NumericUpDown();
            refinedMaterialCostLabel = new Label();
            bombardmentModifier = new NumericUpDown();
            weaponRechargeRate = new NumericUpDown();
            bombardmentModifierLabel = new Label();
            weaponRechargeRateLabel = new Label();
            interdictionStrengthLabel = new Label();
            gravityWellProjectorLabel = new Label();
            interdictionStrength = new NumericUpDown();
            gravityWellProjector = new NumericUpDown();
            tractorBeamRange = new NumericUpDown();
            tractorBeamPower = new NumericUpDown();
            attackStrengthGroupBox = new GroupBox();
            laserCannonStarboard = new NumericUpDown();
            laserCannonPort = new NumericUpDown();
            laserCannonAft = new NumericUpDown();
            ionCannonStarboard = new NumericUpDown();
            overallAttackStrength = new NumericUpDown();
            ionCannonPort = new NumericUpDown();
            overallLabel = new Label();
            ionCannonAft = new NumericUpDown();
            ionCannonFore = new NumericUpDown();
            laserCannonFore = new NumericUpDown();
            laserCannonLabel = new Label();
            ionCannonLabel = new Label();
            turboLaserLabel = new Label();
            turbolaserStarboard = new NumericUpDown();
            turbolaserPort = new NumericUpDown();
            turbolaserAft = new NumericUpDown();
            turbolaserFore = new NumericUpDown();
            starboardLabel = new Label();
            portLabel = new Label();
            totalAttackLabel = new Label();
            ionCannonAttackStrength = new NumericUpDown();
            aftLabel = new Label();
            laserCannonAttackStrength = new NumericUpDown();
            foreLabel = new Label();
            turbolaserAttackStrength = new NumericUpDown();
            laserCannonRange = new NumericUpDown();
            ionCannonRange = new NumericUpDown();
            turbolaserRange = new NumericUpDown();
            turbolaserRangeLabel = new Label();
            familyIdHexLabel = new Label();
            idHexLabel = new Label();
            id = new NumericUpDown();
            idLabel = new Label();
            inGameDataGroupBox = new GroupBox();
            name = new TextBox();
            encyclopediaDescriptionLabel = new Label();
            troopCapacityLabel = new Label();
            troopCapacity = new NumericUpDown();
            shieldStrengthLabel = new Label();
            shieldStrength = new NumericUpDown();
            fighterCapacity = new NumericUpDown();
            fighterCapacityLabel = new Label();
            tractorBeamPowerLabel = new Label();
            picture = new PictureBox();
            shieldRechargeRateLabel = new Label();
            maneuverabilityLabel = new Label();
            hull = new NumericUpDown();
            hyperdriveLabel = new Label();
            subLightEngineLabel = new Label();
            hullLabel = new Label();
            subLightEngine = new NumericUpDown();
            damageControlLabel = new Label();
            damageControl = new NumericUpDown();
            maneuverability = new NumericUpDown();
            hyperdrive = new NumericUpDown();
            shieldRechargeRate = new NumericUpDown();
            hyperdriveIfDamagedLabel = new Label();
            hyperdriveIfDamaged = new NumericUpDown();
            tractorBeamRangeLabel = new Label();
            field51_0Label = new Label();
            field51_0 = new NumericUpDown();
            field2_1 = new NumericUpDown();
            field2_1Label = new Label();
            hiddenDataGroupBox = new GroupBox();
            laserCannonRangeLabel = new Label();
            ionCannonRangeLabel = new Label();
            warningLabel = new Label();
            ((ISupportInitialize)textStraDllId).BeginInit();
            ((ISupportInitialize)field7_2).BeginInit();
            ((ISupportInitialize)familyId).BeginInit();
            ((ISupportInitialize)nextProductionFamily).BeginInit();
            ((ISupportInitialize)productionFamily).BeginInit();
            ((ISupportInitialize)uprisingDefense).BeginInit();
            ((ISupportInitialize)researchDifficulty).BeginInit();
            ((ISupportInitialize)selector).BeginInit();
            ((ISupportInitialize)detection).BeginInit();
            ((ISupportInitialize)researchOrder).BeginInit();
            ((ISupportInitialize)maintenanceCost).BeginInit();
            ((ISupportInitialize)refinedMaterialCost).BeginInit();
            ((ISupportInitialize)bombardmentModifier).BeginInit();
            ((ISupportInitialize)weaponRechargeRate).BeginInit();
            ((ISupportInitialize)interdictionStrength).BeginInit();
            ((ISupportInitialize)gravityWellProjector).BeginInit();
            ((ISupportInitialize)tractorBeamRange).BeginInit();
            ((ISupportInitialize)tractorBeamPower).BeginInit();
            attackStrengthGroupBox.SuspendLayout();
            ((ISupportInitialize)laserCannonStarboard).BeginInit();
            ((ISupportInitialize)laserCannonPort).BeginInit();
            ((ISupportInitialize)laserCannonAft).BeginInit();
            ((ISupportInitialize)ionCannonStarboard).BeginInit();
            ((ISupportInitialize)overallAttackStrength).BeginInit();
            ((ISupportInitialize)ionCannonPort).BeginInit();
            ((ISupportInitialize)ionCannonAft).BeginInit();
            ((ISupportInitialize)ionCannonFore).BeginInit();
            ((ISupportInitialize)laserCannonFore).BeginInit();
            ((ISupportInitialize)turbolaserStarboard).BeginInit();
            ((ISupportInitialize)turbolaserPort).BeginInit();
            ((ISupportInitialize)turbolaserAft).BeginInit();
            ((ISupportInitialize)turbolaserFore).BeginInit();
            ((ISupportInitialize)ionCannonAttackStrength).BeginInit();
            ((ISupportInitialize)laserCannonAttackStrength).BeginInit();
            ((ISupportInitialize)turbolaserAttackStrength).BeginInit();
            ((ISupportInitialize)laserCannonRange).BeginInit();
            ((ISupportInitialize)ionCannonRange).BeginInit();
            ((ISupportInitialize)turbolaserRange).BeginInit();
            ((ISupportInitialize)id).BeginInit();
            inGameDataGroupBox.SuspendLayout();
            ((ISupportInitialize)troopCapacity).BeginInit();
            ((ISupportInitialize)shieldStrength).BeginInit();
            ((ISupportInitialize)fighterCapacity).BeginInit();
            ((ISupportInitialize)picture).BeginInit();
            ((ISupportInitialize)hull).BeginInit();
            ((ISupportInitialize)subLightEngine).BeginInit();
            ((ISupportInitialize)damageControl).BeginInit();
            ((ISupportInitialize)maneuverability).BeginInit();
            ((ISupportInitialize)hyperdrive).BeginInit();
            ((ISupportInitialize)shieldRechargeRate).BeginInit();
            ((ISupportInitialize)hyperdriveIfDamaged).BeginInit();
            ((ISupportInitialize)field51_0).BeginInit();
            ((ISupportInitialize)field2_1).BeginInit();
            hiddenDataGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // Open
            // 
            Open.Location = new Point(362, 565);
            Open.Margin = new Padding(4, 3, 4, 3);
            Open.Name = "Open";
            Open.Size = new Size(88, 27);
            Open.TabIndex = 0;
            Open.TabStop = false;
            Open.Text = "Open...";
            Open.UseVisualStyleBackColor = true;
            Open.Click += Open_Click;
            // 
            // SaveAs
            // 
            SaveAs.Location = new Point(270, 565);
            SaveAs.Margin = new Padding(4, 3, 4, 3);
            SaveAs.Name = "SaveAs";
            SaveAs.Size = new Size(88, 27);
            SaveAs.TabIndex = 0;
            SaveAs.TabStop = false;
            SaveAs.Text = "&SaveAs...";
            SaveAs.UseVisualStyleBackColor = true;
            SaveAs.Click += SaveAs_Click;
            // 
            // Cancel
            // 
            Cancel.DialogResult = DialogResult.Cancel;
            Cancel.Location = new Point(179, 565);
            Cancel.Margin = new Padding(4, 3, 4, 3);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(88, 27);
            Cancel.TabIndex = 39;
            Cancel.Text = "&Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Ok
            // 
            Ok.Location = new Point(88, 565);
            Ok.Margin = new Padding(4, 3, 4, 3);
            Ok.Name = "Ok";
            Ok.Size = new Size(88, 27);
            Ok.TabIndex = 38;
            Ok.Text = "&Ok";
            Ok.UseVisualStyleBackColor = true;
            Ok.Click += Ok_Click;
            // 
            // encyclopediaDescription
            // 
            encyclopediaDescription.Location = new Point(5, 453);
            encyclopediaDescription.Margin = new Padding(4, 3, 4, 3);
            encyclopediaDescription.Name = "encyclopediaDescription";
            encyclopediaDescription.Size = new Size(428, 66);
            encyclopediaDescription.TabIndex = 0;
            encyclopediaDescription.TabStop = false;
            encyclopediaDescription.Text = "";
            encyclopediaDescription.TextChanged += encyclopediaDescription_TextChanged;
            // 
            // textStraDllIdLabel
            // 
            textStraDllIdLabel.AutoSize = true;
            textStraDllIdLabel.ForeColor = Color.Red;
            textStraDllIdLabel.Location = new Point(7, 148);
            textStraDllIdLabel.Margin = new Padding(4, 0, 4, 0);
            textStraDllIdLabel.Name = "textStraDllIdLabel";
            textStraDllIdLabel.Size = new Size(77, 15);
            textStraDllIdLabel.TabIndex = 106;
            textStraDllIdLabel.Text = "TextStra.dll Id";
            // 
            // textStraDllId
            // 
            textStraDllId.ForeColor = Color.Red;
            textStraDllId.Location = new Point(141, 146);
            textStraDllId.Margin = new Padding(4, 3, 4, 3);
            textStraDllId.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            textStraDllId.Name = "textStraDllId";
            textStraDllId.Size = new Size(59, 23);
            textStraDllId.TabIndex = 112;
            textStraDllId.TabStop = false;
            textStraDllId.TextAlign = HorizontalAlignment.Right;
            textStraDllId.Value = new decimal(new int[] { 65535, 0, 0, 0 });
            textStraDllId.ValueChanged += textStraDllId_ValueChanged;
            // 
            // field7_2Label
            // 
            field7_2Label.AutoSize = true;
            field7_2Label.ForeColor = Color.Red;
            field7_2Label.Location = new Point(7, 173);
            field7_2Label.Margin = new Padding(4, 0, 4, 0);
            field7_2Label.Name = "field7_2Label";
            field7_2Label.Size = new Size(93, 15);
            field7_2Label.TabIndex = 109;
            field7_2Label.Text = "Field7 (always 2)";
            // 
            // field7_2
            // 
            field7_2.ForeColor = Color.Red;
            field7_2.Location = new Point(141, 171);
            field7_2.Margin = new Padding(4, 3, 4, 3);
            field7_2.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            field7_2.Name = "field7_2";
            field7_2.Size = new Size(59, 23);
            field7_2.TabIndex = 110;
            field7_2.TabStop = false;
            field7_2.TextAlign = HorizontalAlignment.Right;
            field7_2.Value = new decimal(new int[] { 2, 0, 0, 0 });
            field7_2.ValueChanged += field7_2_ValueChanged;
            // 
            // familyId
            // 
            familyId.BackColor = SystemColors.Window;
            familyId.ForeColor = Color.Red;
            familyId.Location = new Point(141, 121);
            familyId.Margin = new Padding(4, 3, 4, 3);
            familyId.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            familyId.Name = "familyId";
            familyId.Size = new Size(59, 23);
            familyId.TabIndex = 111;
            familyId.TabStop = false;
            familyId.TextAlign = HorizontalAlignment.Right;
            familyId.Value = new decimal(new int[] { -1, 0, 0, 0 });
            familyId.ValueChanged += familyId_ValueChanged;
            // 
            // familyIdLabel
            // 
            familyIdLabel.AutoSize = true;
            familyIdLabel.ForeColor = Color.Red;
            familyIdLabel.Location = new Point(7, 123);
            familyIdLabel.Margin = new Padding(4, 0, 4, 0);
            familyIdLabel.Name = "familyIdLabel";
            familyIdLabel.Size = new Size(55, 15);
            familyIdLabel.TabIndex = 104;
            familyIdLabel.Text = "Family Id";
            // 
            // nextProductionFamily
            // 
            nextProductionFamily.BackColor = SystemColors.Window;
            nextProductionFamily.Location = new Point(141, 96);
            nextProductionFamily.Margin = new Padding(4, 3, 4, 3);
            nextProductionFamily.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            nextProductionFamily.Name = "nextProductionFamily";
            nextProductionFamily.Size = new Size(59, 23);
            nextProductionFamily.TabIndex = 96;
            nextProductionFamily.TabStop = false;
            nextProductionFamily.TextAlign = HorizontalAlignment.Right;
            nextProductionFamily.Value = new decimal(new int[] { -1, 0, 0, 0 });
            nextProductionFamily.ValueChanged += nextProductionFamily_ValueChanged;
            // 
            // nextProductionFamilyLabel
            // 
            nextProductionFamilyLabel.AutoSize = true;
            nextProductionFamilyLabel.Location = new Point(7, 98);
            nextProductionFamilyLabel.Margin = new Padding(4, 0, 4, 0);
            nextProductionFamilyLabel.Name = "nextProductionFamilyLabel";
            nextProductionFamilyLabel.Size = new Size(121, 15);
            nextProductionFamilyLabel.TabIndex = 97;
            nextProductionFamilyLabel.Text = "Production Family +1";
            // 
            // productionFamilyLabel
            // 
            productionFamilyLabel.AutoSize = true;
            productionFamilyLabel.Location = new Point(7, 73);
            productionFamilyLabel.Margin = new Padding(4, 0, 4, 0);
            productionFamilyLabel.Name = "productionFamilyLabel";
            productionFamilyLabel.Size = new Size(104, 15);
            productionFamilyLabel.TabIndex = 95;
            productionFamilyLabel.Text = "Production Family";
            // 
            // productionFamily
            // 
            productionFamily.BackColor = SystemColors.Window;
            productionFamily.Location = new Point(141, 71);
            productionFamily.Margin = new Padding(4, 3, 4, 3);
            productionFamily.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            productionFamily.Name = "productionFamily";
            productionFamily.Size = new Size(59, 23);
            productionFamily.TabIndex = 93;
            productionFamily.TabStop = false;
            productionFamily.TextAlign = HorizontalAlignment.Right;
            productionFamily.Value = new decimal(new int[] { -1, 0, 0, 0 });
            productionFamily.ValueChanged += productionFamily_ValueChanged;
            // 
            // uprisingDefense
            // 
            uprisingDefense.BackColor = SystemColors.Window;
            uprisingDefense.Location = new Point(141, 246);
            uprisingDefense.Margin = new Padding(4, 3, 4, 3);
            uprisingDefense.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            uprisingDefense.Name = "uprisingDefense";
            uprisingDefense.Size = new Size(59, 23);
            uprisingDefense.TabIndex = 125;
            uprisingDefense.TabStop = false;
            uprisingDefense.TextAlign = HorizontalAlignment.Right;
            uprisingDefense.Value = new decimal(new int[] { -1, 0, 0, 0 });
            uprisingDefense.ValueChanged += uprisingDefense_ValueChanged;
            // 
            // UprisingDefenseLabel
            // 
            UprisingDefenseLabel.AutoSize = true;
            UprisingDefenseLabel.Location = new Point(7, 248);
            UprisingDefenseLabel.Margin = new Padding(4, 0, 4, 0);
            UprisingDefenseLabel.Name = "UprisingDefenseLabel";
            UprisingDefenseLabel.Size = new Size(96, 15);
            UprisingDefenseLabel.TabIndex = 94;
            UprisingDefenseLabel.Text = "Uprising Defense";
            // 
            // researchDifficulty
            // 
            researchDifficulty.Location = new Point(141, 221);
            researchDifficulty.Margin = new Padding(4, 3, 4, 3);
            researchDifficulty.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            researchDifficulty.Name = "researchDifficulty";
            researchDifficulty.Size = new Size(59, 23);
            researchDifficulty.TabIndex = 8;
            researchDifficulty.TextAlign = HorizontalAlignment.Right;
            researchDifficulty.Value = new decimal(new int[] { -1, 0, 0, 0 });
            researchDifficulty.ValueChanged += researchDifficulty_ValueChanged;
            // 
            // researchDifficultyLabel
            // 
            researchDifficultyLabel.AutoSize = true;
            researchDifficultyLabel.Location = new Point(7, 223);
            researchDifficultyLabel.Margin = new Padding(4, 0, 4, 0);
            researchDifficultyLabel.Name = "researchDifficultyLabel";
            researchDifficultyLabel.Size = new Size(105, 15);
            researchDifficultyLabel.TabIndex = 0;
            researchDifficultyLabel.Text = "Research Difficulty";
            // 
            // isEmpire
            // 
            isEmpire.AutoSize = true;
            isEmpire.Location = new Point(242, 74);
            isEmpire.Margin = new Padding(4, 3, 4, 3);
            isEmpire.Name = "isEmpire";
            isEmpire.Size = new Size(63, 19);
            isEmpire.TabIndex = 16;
            isEmpire.Text = "Empire";
            isEmpire.UseVisualStyleBackColor = true;
            isEmpire.CheckedChanged += isEmpire_CheckedChanged;
            // 
            // isAlliance
            // 
            isAlliance.AutoSize = true;
            isAlliance.Location = new Point(242, 53);
            isAlliance.Margin = new Padding(4, 3, 4, 3);
            isAlliance.Name = "isAlliance";
            isAlliance.Size = new Size(68, 19);
            isAlliance.TabIndex = 15;
            isAlliance.Text = "Alliance";
            isAlliance.UseVisualStyleBackColor = true;
            isAlliance.CheckedChanged += isAlliance_CheckedChanged;
            // 
            // selector
            // 
            selector.LargeChange = 1;
            selector.Location = new Point(7, 5);
            selector.Margin = new Padding(4, 3, 4, 3);
            selector.Maximum = 29;
            selector.Name = "selector";
            selector.Size = new Size(443, 45);
            selector.TabIndex = 1;
            selector.ValueChanged += GameObjectsSelector_ValueChanged;
            // 
            // detectionLabel
            // 
            detectionLabel.AutoSize = true;
            detectionLabel.Location = new Point(228, 228);
            detectionLabel.Margin = new Padding(4, 0, 4, 0);
            detectionLabel.Name = "detectionLabel";
            detectionLabel.Size = new Size(58, 15);
            detectionLabel.TabIndex = 0;
            detectionLabel.Text = "Detection";
            // 
            // detection
            // 
            detection.Location = new Point(365, 226);
            detection.Margin = new Padding(4, 3, 4, 3);
            detection.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            detection.Name = "detection";
            detection.Size = new Size(59, 23);
            detection.TabIndex = 5;
            detection.TextAlign = HorizontalAlignment.Right;
            detection.Value = new decimal(new int[] { -1, 0, 0, 0 });
            detection.ValueChanged += detection_ValueChanged;
            // 
            // researchOrderLabel
            // 
            researchOrderLabel.AutoSize = true;
            researchOrderLabel.Location = new Point(7, 198);
            researchOrderLabel.Margin = new Padding(4, 0, 4, 0);
            researchOrderLabel.Name = "researchOrderLabel";
            researchOrderLabel.Size = new Size(87, 15);
            researchOrderLabel.TabIndex = 0;
            researchOrderLabel.Text = "Research Order";
            // 
            // researchOrder
            // 
            researchOrder.Location = new Point(141, 196);
            researchOrder.Margin = new Padding(4, 3, 4, 3);
            researchOrder.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            researchOrder.Name = "researchOrder";
            researchOrder.Size = new Size(59, 23);
            researchOrder.TabIndex = 7;
            researchOrder.TextAlign = HorizontalAlignment.Right;
            researchOrder.Value = new decimal(new int[] { -1, 0, 0, 0 });
            researchOrder.ValueChanged += researchOrder_ValueChanged;
            // 
            // maintenanceCost
            // 
            maintenanceCost.Location = new Point(146, 151);
            maintenanceCost.Margin = new Padding(4, 3, 4, 3);
            maintenanceCost.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            maintenanceCost.Name = "maintenanceCost";
            maintenanceCost.Size = new Size(59, 23);
            maintenanceCost.TabIndex = 3;
            maintenanceCost.TextAlign = HorizontalAlignment.Right;
            maintenanceCost.Value = new decimal(new int[] { -1, 0, 0, 0 });
            maintenanceCost.ValueChanged += maintenanceCost_ValueChanged;
            // 
            // maintenanceCostLabel
            // 
            maintenanceCostLabel.AutoSize = true;
            maintenanceCostLabel.Location = new Point(13, 155);
            maintenanceCostLabel.Margin = new Padding(4, 0, 4, 0);
            maintenanceCostLabel.Name = "maintenanceCostLabel";
            maintenanceCostLabel.Size = new Size(103, 15);
            maintenanceCostLabel.TabIndex = 0;
            maintenanceCostLabel.Text = "Maintenance Cost";
            // 
            // refinedMaterialCost
            // 
            refinedMaterialCost.Location = new Point(146, 126);
            refinedMaterialCost.Margin = new Padding(4, 3, 4, 3);
            refinedMaterialCost.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            refinedMaterialCost.Name = "refinedMaterialCost";
            refinedMaterialCost.Size = new Size(59, 23);
            refinedMaterialCost.TabIndex = 2;
            refinedMaterialCost.TextAlign = HorizontalAlignment.Right;
            refinedMaterialCost.Value = new decimal(new int[] { -1, 0, 0, 0 });
            refinedMaterialCost.ValueChanged += refinedMaterialCost_ValueChanged;
            // 
            // refinedMaterialCostLabel
            // 
            refinedMaterialCostLabel.AutoSize = true;
            refinedMaterialCostLabel.Location = new Point(13, 130);
            refinedMaterialCostLabel.Margin = new Padding(4, 0, 4, 0);
            refinedMaterialCostLabel.Name = "refinedMaterialCostLabel";
            refinedMaterialCostLabel.Size = new Size(120, 15);
            refinedMaterialCostLabel.TabIndex = 0;
            refinedMaterialCostLabel.Text = "Refined Material Cost";
            // 
            // bombardmentModifier
            // 
            bombardmentModifier.Location = new Point(365, 276);
            bombardmentModifier.Margin = new Padding(4, 3, 4, 3);
            bombardmentModifier.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            bombardmentModifier.Name = "bombardmentModifier";
            bombardmentModifier.Size = new Size(59, 23);
            bombardmentModifier.TabIndex = 37;
            bombardmentModifier.TextAlign = HorizontalAlignment.Right;
            bombardmentModifier.Value = new decimal(new int[] { -1, 0, 0, 0 });
            bombardmentModifier.ValueChanged += bombardmentModifier_ValueChanged;
            // 
            // weaponRechargeRate
            // 
            weaponRechargeRate.Location = new Point(365, 251);
            weaponRechargeRate.Margin = new Padding(4, 3, 4, 3);
            weaponRechargeRate.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            weaponRechargeRate.Name = "weaponRechargeRate";
            weaponRechargeRate.Size = new Size(59, 23);
            weaponRechargeRate.TabIndex = 36;
            weaponRechargeRate.TextAlign = HorizontalAlignment.Right;
            weaponRechargeRate.Value = new decimal(new int[] { -1, 0, 0, 0 });
            weaponRechargeRate.ValueChanged += weaponRecharge_ValueChanged;
            // 
            // bombardmentModifierLabel
            // 
            bombardmentModifierLabel.AutoSize = true;
            bombardmentModifierLabel.BackColor = SystemColors.Control;
            bombardmentModifierLabel.Location = new Point(228, 278);
            bombardmentModifierLabel.Margin = new Padding(4, 0, 4, 0);
            bombardmentModifierLabel.Name = "bombardmentModifierLabel";
            bombardmentModifierLabel.RightToLeft = RightToLeft.No;
            bombardmentModifierLabel.Size = new Size(132, 15);
            bombardmentModifierLabel.TabIndex = 0;
            bombardmentModifierLabel.Text = "Bombardment Modifier";
            bombardmentModifierLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // weaponRechargeRateLabel
            // 
            weaponRechargeRateLabel.AutoSize = true;
            weaponRechargeRateLabel.BackColor = SystemColors.Control;
            weaponRechargeRateLabel.Location = new Point(228, 253);
            weaponRechargeRateLabel.Margin = new Padding(4, 0, 4, 0);
            weaponRechargeRateLabel.Name = "weaponRechargeRateLabel";
            weaponRechargeRateLabel.RightToLeft = RightToLeft.No;
            weaponRechargeRateLabel.Size = new Size(129, 15);
            weaponRechargeRateLabel.TabIndex = 0;
            weaponRechargeRateLabel.Text = "Weapon Recharge Rate";
            weaponRechargeRateLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // interdictionStrengthLabel
            // 
            interdictionStrengthLabel.AutoSize = true;
            interdictionStrengthLabel.BackColor = SystemColors.Control;
            interdictionStrengthLabel.Location = new Point(7, 348);
            interdictionStrengthLabel.Margin = new Padding(4, 0, 4, 0);
            interdictionStrengthLabel.Name = "interdictionStrengthLabel";
            interdictionStrengthLabel.RightToLeft = RightToLeft.No;
            interdictionStrengthLabel.Size = new Size(116, 15);
            interdictionStrengthLabel.TabIndex = 0;
            interdictionStrengthLabel.Text = "Interdiction Strength";
            interdictionStrengthLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // gravityWellProjectorLabel
            // 
            gravityWellProjectorLabel.AutoSize = true;
            gravityWellProjectorLabel.BackColor = SystemColors.Control;
            gravityWellProjectorLabel.Location = new Point(7, 323);
            gravityWellProjectorLabel.Margin = new Padding(4, 0, 4, 0);
            gravityWellProjectorLabel.Name = "gravityWellProjectorLabel";
            gravityWellProjectorLabel.RightToLeft = RightToLeft.No;
            gravityWellProjectorLabel.Size = new Size(121, 15);
            gravityWellProjectorLabel.TabIndex = 0;
            gravityWellProjectorLabel.Text = "Gravity Well Projector";
            gravityWellProjectorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // interdictionStrength
            // 
            interdictionStrength.BackColor = SystemColors.Window;
            interdictionStrength.Location = new Point(141, 346);
            interdictionStrength.Margin = new Padding(4, 3, 4, 3);
            interdictionStrength.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            interdictionStrength.Name = "interdictionStrength";
            interdictionStrength.Size = new Size(59, 23);
            interdictionStrength.TabIndex = 0;
            interdictionStrength.TabStop = false;
            interdictionStrength.TextAlign = HorizontalAlignment.Right;
            interdictionStrength.Value = new decimal(new int[] { -1, 0, 0, 0 });
            interdictionStrength.ValueChanged += interdictionStrength_ValueChanged;
            // 
            // gravityWellProjector
            // 
            gravityWellProjector.BackColor = SystemColors.Window;
            gravityWellProjector.Location = new Point(141, 321);
            gravityWellProjector.Margin = new Padding(4, 3, 4, 3);
            gravityWellProjector.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            gravityWellProjector.Name = "gravityWellProjector";
            gravityWellProjector.Size = new Size(59, 23);
            gravityWellProjector.TabIndex = 0;
            gravityWellProjector.TabStop = false;
            gravityWellProjector.TextAlign = HorizontalAlignment.Right;
            gravityWellProjector.Value = new decimal(new int[] { -1, 0, 0, 0 });
            gravityWellProjector.ValueChanged += gravityWellProjector_ValueChanged;
            // 
            // tractorBeamRange
            // 
            tractorBeamRange.Location = new Point(141, 296);
            tractorBeamRange.Margin = new Padding(4, 3, 4, 3);
            tractorBeamRange.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            tractorBeamRange.Name = "tractorBeamRange";
            tractorBeamRange.Size = new Size(59, 23);
            tractorBeamRange.TabIndex = 35;
            tractorBeamRange.TextAlign = HorizontalAlignment.Right;
            tractorBeamRange.Value = new decimal(new int[] { -1, 0, 0, 0 });
            tractorBeamRange.ValueChanged += tractorBeamRange_ValueChanged;
            // 
            // tractorBeamPower
            // 
            tractorBeamPower.Location = new Point(365, 151);
            tractorBeamPower.Margin = new Padding(4, 3, 4, 3);
            tractorBeamPower.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            tractorBeamPower.Name = "tractorBeamPower";
            tractorBeamPower.Size = new Size(59, 23);
            tractorBeamPower.TabIndex = 34;
            tractorBeamPower.TextAlign = HorizontalAlignment.Right;
            tractorBeamPower.Value = new decimal(new int[] { -1, 0, 0, 0 });
            tractorBeamPower.ValueChanged += tractorBeamPower_ValueChanged;
            // 
            // attackStrengthGroupBox
            // 
            attackStrengthGroupBox.Controls.Add(warningLabel);
            attackStrengthGroupBox.Controls.Add(laserCannonStarboard);
            attackStrengthGroupBox.Controls.Add(laserCannonPort);
            attackStrengthGroupBox.Controls.Add(laserCannonAft);
            attackStrengthGroupBox.Controls.Add(ionCannonStarboard);
            attackStrengthGroupBox.Controls.Add(overallAttackStrength);
            attackStrengthGroupBox.Controls.Add(ionCannonPort);
            attackStrengthGroupBox.Controls.Add(overallLabel);
            attackStrengthGroupBox.Controls.Add(ionCannonAft);
            attackStrengthGroupBox.Controls.Add(ionCannonFore);
            attackStrengthGroupBox.Controls.Add(laserCannonFore);
            attackStrengthGroupBox.Controls.Add(laserCannonLabel);
            attackStrengthGroupBox.Controls.Add(ionCannonLabel);
            attackStrengthGroupBox.Controls.Add(turboLaserLabel);
            attackStrengthGroupBox.Controls.Add(turbolaserStarboard);
            attackStrengthGroupBox.Controls.Add(turbolaserPort);
            attackStrengthGroupBox.Controls.Add(turbolaserAft);
            attackStrengthGroupBox.Controls.Add(turbolaserFore);
            attackStrengthGroupBox.Controls.Add(starboardLabel);
            attackStrengthGroupBox.Controls.Add(portLabel);
            attackStrengthGroupBox.Controls.Add(totalAttackLabel);
            attackStrengthGroupBox.Controls.Add(ionCannonAttackStrength);
            attackStrengthGroupBox.Controls.Add(aftLabel);
            attackStrengthGroupBox.Controls.Add(laserCannonAttackStrength);
            attackStrengthGroupBox.Controls.Add(foreLabel);
            attackStrengthGroupBox.Controls.Add(turbolaserAttackStrength);
            attackStrengthGroupBox.Location = new Point(5, 300);
            attackStrengthGroupBox.Margin = new Padding(4, 3, 4, 3);
            attackStrengthGroupBox.Name = "attackStrengthGroupBox";
            attackStrengthGroupBox.Padding = new Padding(4, 3, 4, 3);
            attackStrengthGroupBox.Size = new Size(428, 137);
            attackStrengthGroupBox.TabIndex = 10;
            attackStrengthGroupBox.TabStop = false;
            attackStrengthGroupBox.Text = "Attack Strength";
            // 
            // laserCannonStarboard
            // 
            laserCannonStarboard.Location = new Point(291, 108);
            laserCannonStarboard.Margin = new Padding(4, 3, 4, 3);
            laserCannonStarboard.Maximum = new decimal(new int[] { 536870911, 0, 0, 0 });
            laserCannonStarboard.Name = "laserCannonStarboard";
            laserCannonStarboard.Size = new Size(59, 23);
            laserCannonStarboard.TabIndex = 30;
            laserCannonStarboard.TextAlign = HorizontalAlignment.Right;
            laserCannonStarboard.Value = new decimal(new int[] { 536870911, 0, 0, 0 });
            laserCannonStarboard.ValueChanged += laserCannonStarboard_ValueChanged;
            // 
            // laserCannonPort
            // 
            laserCannonPort.Location = new Point(224, 108);
            laserCannonPort.Margin = new Padding(4, 3, 4, 3);
            laserCannonPort.Maximum = new decimal(new int[] { 536870911, 0, 0, 0 });
            laserCannonPort.Name = "laserCannonPort";
            laserCannonPort.Size = new Size(59, 23);
            laserCannonPort.TabIndex = 27;
            laserCannonPort.TextAlign = HorizontalAlignment.Right;
            laserCannonPort.Value = new decimal(new int[] { 536870911, 0, 0, 0 });
            laserCannonPort.ValueChanged += laserCannonPort_ValueChanged;
            // 
            // laserCannonAft
            // 
            laserCannonAft.Location = new Point(158, 108);
            laserCannonAft.Margin = new Padding(4, 3, 4, 3);
            laserCannonAft.Maximum = new decimal(new int[] { 536870911, 0, 0, 0 });
            laserCannonAft.Name = "laserCannonAft";
            laserCannonAft.Size = new Size(59, 23);
            laserCannonAft.TabIndex = 24;
            laserCannonAft.TextAlign = HorizontalAlignment.Right;
            laserCannonAft.Value = new decimal(new int[] { 536870911, 0, 0, 0 });
            laserCannonAft.ValueChanged += laserCannonAft_ValueChanged;
            // 
            // ionCannonStarboard
            // 
            ionCannonStarboard.Location = new Point(291, 83);
            ionCannonStarboard.Margin = new Padding(4, 3, 4, 3);
            ionCannonStarboard.Maximum = new decimal(new int[] { 536870911, 0, 0, 0 });
            ionCannonStarboard.Name = "ionCannonStarboard";
            ionCannonStarboard.Size = new Size(59, 23);
            ionCannonStarboard.TabIndex = 29;
            ionCannonStarboard.TextAlign = HorizontalAlignment.Right;
            ionCannonStarboard.Value = new decimal(new int[] { 536870911, 0, 0, 0 });
            ionCannonStarboard.ValueChanged += ionCannonStarboard_ValueChanged;
            // 
            // overallAttackStrength
            // 
            overallAttackStrength.BackColor = SystemColors.Menu;
            overallAttackStrength.Enabled = false;
            overallAttackStrength.Location = new Point(360, 15);
            overallAttackStrength.Margin = new Padding(4, 3, 4, 3);
            overallAttackStrength.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            overallAttackStrength.Name = "overallAttackStrength";
            overallAttackStrength.Size = new Size(59, 23);
            overallAttackStrength.TabIndex = 152;
            overallAttackStrength.TabStop = false;
            overallAttackStrength.TextAlign = HorizontalAlignment.Right;
            overallAttackStrength.Value = new decimal(new int[] { -1, 0, 0, 0 });
            overallAttackStrength.ValueChanged += overallAttackStrength_ValueChanged;
            // 
            // ionCannonPort
            // 
            ionCannonPort.Location = new Point(224, 83);
            ionCannonPort.Margin = new Padding(4, 3, 4, 3);
            ionCannonPort.Maximum = new decimal(new int[] { 536870911, 0, 0, 0 });
            ionCannonPort.Name = "ionCannonPort";
            ionCannonPort.Size = new Size(59, 23);
            ionCannonPort.TabIndex = 26;
            ionCannonPort.TextAlign = HorizontalAlignment.Right;
            ionCannonPort.Value = new decimal(new int[] { 536870911, 0, 0, 0 });
            ionCannonPort.ValueChanged += ionCannonPort_ValueChanged;
            // 
            // overallLabel
            // 
            overallLabel.AutoSize = true;
            overallLabel.BackColor = SystemColors.Control;
            overallLabel.Location = new Point(308, 19);
            overallLabel.Margin = new Padding(4, 0, 4, 0);
            overallLabel.Name = "overallLabel";
            overallLabel.RightToLeft = RightToLeft.No;
            overallLabel.Size = new Size(44, 15);
            overallLabel.TabIndex = 154;
            overallLabel.Text = "Overall";
            overallLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ionCannonAft
            // 
            ionCannonAft.Location = new Point(158, 83);
            ionCannonAft.Margin = new Padding(4, 3, 4, 3);
            ionCannonAft.Maximum = new decimal(new int[] { 536870911, 0, 0, 0 });
            ionCannonAft.Name = "ionCannonAft";
            ionCannonAft.Size = new Size(59, 23);
            ionCannonAft.TabIndex = 23;
            ionCannonAft.TextAlign = HorizontalAlignment.Right;
            ionCannonAft.Value = new decimal(new int[] { 536870911, 0, 0, 0 });
            ionCannonAft.ValueChanged += ionCannonAft_ValueChanged;
            // 
            // ionCannonFore
            // 
            ionCannonFore.Location = new Point(91, 83);
            ionCannonFore.Margin = new Padding(4, 3, 4, 3);
            ionCannonFore.Maximum = new decimal(new int[] { 536870911, 0, 0, 0 });
            ionCannonFore.Name = "ionCannonFore";
            ionCannonFore.Size = new Size(59, 23);
            ionCannonFore.TabIndex = 20;
            ionCannonFore.TextAlign = HorizontalAlignment.Right;
            ionCannonFore.Value = new decimal(new int[] { 536870911, 0, 0, 0 });
            ionCannonFore.ValueChanged += ionCannonFore_ValueChanged;
            // 
            // laserCannonFore
            // 
            laserCannonFore.Location = new Point(91, 108);
            laserCannonFore.Margin = new Padding(4, 3, 4, 3);
            laserCannonFore.Maximum = new decimal(new int[] { 536870911, 0, 0, 0 });
            laserCannonFore.Name = "laserCannonFore";
            laserCannonFore.Size = new Size(59, 23);
            laserCannonFore.TabIndex = 21;
            laserCannonFore.TextAlign = HorizontalAlignment.Right;
            laserCannonFore.Value = new decimal(new int[] { 536870911, 0, 0, 0 });
            laserCannonFore.ValueChanged += laserCannonFore_ValueChanged;
            // 
            // laserCannonLabel
            // 
            laserCannonLabel.AutoSize = true;
            laserCannonLabel.BackColor = SystemColors.Control;
            laserCannonLabel.Location = new Point(7, 110);
            laserCannonLabel.Margin = new Padding(4, 0, 4, 0);
            laserCannonLabel.Name = "laserCannonLabel";
            laserCannonLabel.RightToLeft = RightToLeft.No;
            laserCannonLabel.Size = new Size(79, 15);
            laserCannonLabel.TabIndex = 0;
            laserCannonLabel.Text = "Laser Cannon";
            laserCannonLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ionCannonLabel
            // 
            ionCannonLabel.AutoSize = true;
            ionCannonLabel.BackColor = SystemColors.Control;
            ionCannonLabel.Location = new Point(7, 85);
            ionCannonLabel.Margin = new Padding(4, 0, 4, 0);
            ionCannonLabel.Name = "ionCannonLabel";
            ionCannonLabel.RightToLeft = RightToLeft.No;
            ionCannonLabel.Size = new Size(69, 15);
            ionCannonLabel.TabIndex = 0;
            ionCannonLabel.Text = "Ion Cannon";
            ionCannonLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // turboLaserLabel
            // 
            turboLaserLabel.AutoSize = true;
            turboLaserLabel.BackColor = SystemColors.Control;
            turboLaserLabel.Location = new Point(6, 60);
            turboLaserLabel.Margin = new Padding(4, 0, 4, 0);
            turboLaserLabel.Name = "turboLaserLabel";
            turboLaserLabel.RightToLeft = RightToLeft.No;
            turboLaserLabel.Size = new Size(62, 15);
            turboLaserLabel.TabIndex = 0;
            turboLaserLabel.Text = "Turbolaser";
            turboLaserLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // turbolaserStarboard
            // 
            turbolaserStarboard.Location = new Point(291, 58);
            turbolaserStarboard.Margin = new Padding(4, 3, 4, 3);
            turbolaserStarboard.Maximum = new decimal(new int[] { 536870911, 0, 0, 0 });
            turbolaserStarboard.Name = "turbolaserStarboard";
            turbolaserStarboard.Size = new Size(59, 23);
            turbolaserStarboard.TabIndex = 28;
            turbolaserStarboard.TextAlign = HorizontalAlignment.Right;
            turbolaserStarboard.Value = new decimal(new int[] { 536870911, 0, 0, 0 });
            turbolaserStarboard.ValueChanged += turbolaserStarboard_ValueChanged;
            // 
            // turbolaserPort
            // 
            turbolaserPort.Location = new Point(224, 58);
            turbolaserPort.Margin = new Padding(4, 3, 4, 3);
            turbolaserPort.Maximum = new decimal(new int[] { 536870911, 0, 0, 0 });
            turbolaserPort.Name = "turbolaserPort";
            turbolaserPort.Size = new Size(59, 23);
            turbolaserPort.TabIndex = 25;
            turbolaserPort.TextAlign = HorizontalAlignment.Right;
            turbolaserPort.Value = new decimal(new int[] { 536870911, 0, 0, 0 });
            turbolaserPort.ValueChanged += turbolaserPort_ValueChanged;
            // 
            // turbolaserAft
            // 
            turbolaserAft.Location = new Point(158, 58);
            turbolaserAft.Margin = new Padding(4, 3, 4, 3);
            turbolaserAft.Maximum = new decimal(new int[] { 536870911, 0, 0, 0 });
            turbolaserAft.Name = "turbolaserAft";
            turbolaserAft.Size = new Size(59, 23);
            turbolaserAft.TabIndex = 22;
            turbolaserAft.TextAlign = HorizontalAlignment.Right;
            turbolaserAft.Value = new decimal(new int[] { 536870911, 0, 0, 0 });
            turbolaserAft.ValueChanged += turbolaserAft_ValueChanged;
            // 
            // turbolaserFore
            // 
            turbolaserFore.Location = new Point(91, 58);
            turbolaserFore.Margin = new Padding(4, 3, 4, 3);
            turbolaserFore.Maximum = new decimal(new int[] { 536870911, 0, 0, 0 });
            turbolaserFore.Name = "turbolaserFore";
            turbolaserFore.Size = new Size(59, 23);
            turbolaserFore.TabIndex = 19;
            turbolaserFore.TextAlign = HorizontalAlignment.Right;
            turbolaserFore.Value = new decimal(new int[] { 536870911, 0, 0, 0 });
            turbolaserFore.ValueChanged += turbolaserFore_ValueChanged;
            // 
            // starboardLabel
            // 
            starboardLabel.AutoSize = true;
            starboardLabel.BackColor = SystemColors.Control;
            starboardLabel.Location = new Point(291, 41);
            starboardLabel.Margin = new Padding(4, 0, 4, 0);
            starboardLabel.Name = "starboardLabel";
            starboardLabel.RightToLeft = RightToLeft.No;
            starboardLabel.Size = new Size(58, 15);
            starboardLabel.TabIndex = 0;
            starboardLabel.Text = "Starboard";
            starboardLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.BackColor = SystemColors.Control;
            portLabel.Location = new Point(224, 41);
            portLabel.Margin = new Padding(4, 0, 4, 0);
            portLabel.Name = "portLabel";
            portLabel.RightToLeft = RightToLeft.No;
            portLabel.Size = new Size(29, 15);
            portLabel.TabIndex = 0;
            portLabel.Text = "Port";
            portLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // totalAttackLabel
            // 
            totalAttackLabel.AutoSize = true;
            totalAttackLabel.BackColor = SystemColors.Control;
            totalAttackLabel.Location = new Point(355, 41);
            totalAttackLabel.Margin = new Padding(4, 0, 4, 0);
            totalAttackLabel.Name = "totalAttackLabel";
            totalAttackLabel.RightToLeft = RightToLeft.No;
            totalAttackLabel.Size = new Size(69, 15);
            totalAttackLabel.TabIndex = 153;
            totalAttackLabel.Text = "Total Attack";
            totalAttackLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ionCannonAttackStrength
            // 
            ionCannonAttackStrength.BackColor = SystemColors.Menu;
            ionCannonAttackStrength.Enabled = false;
            ionCannonAttackStrength.Location = new Point(360, 83);
            ionCannonAttackStrength.Margin = new Padding(4, 3, 4, 3);
            ionCannonAttackStrength.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            ionCannonAttackStrength.Name = "ionCannonAttackStrength";
            ionCannonAttackStrength.Size = new Size(59, 23);
            ionCannonAttackStrength.TabIndex = 150;
            ionCannonAttackStrength.TabStop = false;
            ionCannonAttackStrength.TextAlign = HorizontalAlignment.Right;
            ionCannonAttackStrength.Value = new decimal(new int[] { -1, 0, 0, 0 });
            ionCannonAttackStrength.ValueChanged += ionCannonAttackStrength_ValueChanged;
            // 
            // aftLabel
            // 
            aftLabel.AutoSize = true;
            aftLabel.BackColor = SystemColors.Control;
            aftLabel.Location = new Point(158, 41);
            aftLabel.Margin = new Padding(4, 0, 4, 0);
            aftLabel.Name = "aftLabel";
            aftLabel.RightToLeft = RightToLeft.No;
            aftLabel.Size = new Size(23, 15);
            aftLabel.TabIndex = 0;
            aftLabel.Text = "Aft";
            aftLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // laserCannonAttackStrength
            // 
            laserCannonAttackStrength.BackColor = SystemColors.Menu;
            laserCannonAttackStrength.Enabled = false;
            laserCannonAttackStrength.Location = new Point(360, 108);
            laserCannonAttackStrength.Margin = new Padding(4, 3, 4, 3);
            laserCannonAttackStrength.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            laserCannonAttackStrength.Name = "laserCannonAttackStrength";
            laserCannonAttackStrength.Size = new Size(59, 23);
            laserCannonAttackStrength.TabIndex = 149;
            laserCannonAttackStrength.TabStop = false;
            laserCannonAttackStrength.TextAlign = HorizontalAlignment.Right;
            laserCannonAttackStrength.Value = new decimal(new int[] { -1, 0, 0, 0 });
            laserCannonAttackStrength.ValueChanged += laserCannonAttackStrength_ValueChanged;
            // 
            // foreLabel
            // 
            foreLabel.AutoSize = true;
            foreLabel.BackColor = SystemColors.Control;
            foreLabel.Location = new Point(91, 41);
            foreLabel.Margin = new Padding(4, 0, 4, 0);
            foreLabel.Name = "foreLabel";
            foreLabel.RightToLeft = RightToLeft.No;
            foreLabel.Size = new Size(30, 15);
            foreLabel.TabIndex = 0;
            foreLabel.Text = "Fore";
            foreLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // turbolaserAttackStrength
            // 
            turbolaserAttackStrength.BackColor = SystemColors.Menu;
            turbolaserAttackStrength.Enabled = false;
            turbolaserAttackStrength.Location = new Point(360, 58);
            turbolaserAttackStrength.Margin = new Padding(4, 3, 4, 3);
            turbolaserAttackStrength.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            turbolaserAttackStrength.Name = "turbolaserAttackStrength";
            turbolaserAttackStrength.Size = new Size(59, 23);
            turbolaserAttackStrength.TabIndex = 145;
            turbolaserAttackStrength.TabStop = false;
            turbolaserAttackStrength.TextAlign = HorizontalAlignment.Right;
            turbolaserAttackStrength.Value = new decimal(new int[] { -1, 0, 0, 0 });
            turbolaserAttackStrength.ValueChanged += turbolaserAttackStrength_ValueChanged;
            // 
            // laserCannonRange
            // 
            laserCannonRange.Location = new Point(7, 446);
            laserCannonRange.Margin = new Padding(4, 3, 4, 3);
            laserCannonRange.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            laserCannonRange.Name = "laserCannonRange";
            laserCannonRange.Size = new Size(59, 23);
            laserCannonRange.TabIndex = 33;
            laserCannonRange.TextAlign = HorizontalAlignment.Right;
            laserCannonRange.Value = new decimal(new int[] { -1, 0, 0, 0 });
            laserCannonRange.ValueChanged += laserCannonRange_ValueChanged;
            // 
            // ionCannonRange
            // 
            ionCannonRange.Location = new Point(7, 421);
            ionCannonRange.Margin = new Padding(4, 3, 4, 3);
            ionCannonRange.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            ionCannonRange.Name = "ionCannonRange";
            ionCannonRange.Size = new Size(59, 23);
            ionCannonRange.TabIndex = 32;
            ionCannonRange.TextAlign = HorizontalAlignment.Right;
            ionCannonRange.Value = new decimal(new int[] { -1, 0, 0, 0 });
            ionCannonRange.ValueChanged += ionCannonRange_ValueChanged;
            // 
            // turbolaserRange
            // 
            turbolaserRange.Location = new Point(7, 396);
            turbolaserRange.Margin = new Padding(4, 3, 4, 3);
            turbolaserRange.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            turbolaserRange.Name = "turbolaserRange";
            turbolaserRange.Size = new Size(59, 23);
            turbolaserRange.TabIndex = 31;
            turbolaserRange.TextAlign = HorizontalAlignment.Right;
            turbolaserRange.Value = new decimal(new int[] { -1, 0, 0, 0 });
            turbolaserRange.ValueChanged += turbolaserRange_ValueChanged;
            // 
            // turbolaserRangeLabel
            // 
            turbolaserRangeLabel.AutoSize = true;
            turbolaserRangeLabel.BackColor = SystemColors.Control;
            turbolaserRangeLabel.Location = new Point(70, 398);
            turbolaserRangeLabel.Margin = new Padding(4, 0, 4, 0);
            turbolaserRangeLabel.Name = "turbolaserRangeLabel";
            turbolaserRangeLabel.RightToLeft = RightToLeft.No;
            turbolaserRangeLabel.Size = new Size(98, 15);
            turbolaserRangeLabel.TabIndex = 0;
            turbolaserRangeLabel.Text = "Turbolaser Range";
            turbolaserRangeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // familyIdHexLabel
            // 
            familyIdHexLabel.AutoSize = true;
            familyIdHexLabel.Enabled = false;
            familyIdHexLabel.ForeColor = Color.Red;
            familyIdHexLabel.Location = new Point(201, 123);
            familyIdHexLabel.Margin = new Padding(4, 0, 4, 0);
            familyIdHexLabel.Name = "familyIdHexLabel";
            familyIdHexLabel.Size = new Size(26, 15);
            familyIdHexLabel.TabIndex = 1115;
            familyIdHexLabel.Text = "hex";
            // 
            // idHexLabel
            // 
            idHexLabel.AutoSize = true;
            idHexLabel.Enabled = false;
            idHexLabel.ForeColor = Color.Red;
            idHexLabel.Location = new Point(201, 23);
            idHexLabel.Margin = new Padding(4, 0, 4, 0);
            idHexLabel.Name = "idHexLabel";
            idHexLabel.Size = new Size(26, 15);
            idHexLabel.TabIndex = 1114;
            idHexLabel.Text = "hex";
            // 
            // id
            // 
            id.BackColor = SystemColors.Window;
            id.ForeColor = Color.Red;
            id.Location = new Point(141, 21);
            id.Margin = new Padding(4, 3, 4, 3);
            id.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            id.Name = "id";
            id.Size = new Size(59, 23);
            id.TabIndex = 1113;
            id.TabStop = false;
            id.TextAlign = HorizontalAlignment.Right;
            id.Value = new decimal(new int[] { -1, 0, 0, 0 });
            id.ValueChanged += id_ValueChanged;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.ForeColor = Color.Red;
            idLabel.Location = new Point(7, 23);
            idLabel.Margin = new Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 1112;
            idLabel.Text = "Id";
            // 
            // inGameDataGroupBox
            // 
            inGameDataGroupBox.Controls.Add(name);
            inGameDataGroupBox.Controls.Add(encyclopediaDescriptionLabel);
            inGameDataGroupBox.Controls.Add(troopCapacityLabel);
            inGameDataGroupBox.Controls.Add(troopCapacity);
            inGameDataGroupBox.Controls.Add(bombardmentModifier);
            inGameDataGroupBox.Controls.Add(shieldStrengthLabel);
            inGameDataGroupBox.Controls.Add(bombardmentModifierLabel);
            inGameDataGroupBox.Controls.Add(attackStrengthGroupBox);
            inGameDataGroupBox.Controls.Add(shieldStrength);
            inGameDataGroupBox.Controls.Add(fighterCapacity);
            inGameDataGroupBox.Controls.Add(weaponRechargeRateLabel);
            inGameDataGroupBox.Controls.Add(maintenanceCost);
            inGameDataGroupBox.Controls.Add(fighterCapacityLabel);
            inGameDataGroupBox.Controls.Add(weaponRechargeRate);
            inGameDataGroupBox.Controls.Add(refinedMaterialCostLabel);
            inGameDataGroupBox.Controls.Add(maintenanceCostLabel);
            inGameDataGroupBox.Controls.Add(refinedMaterialCost);
            inGameDataGroupBox.Controls.Add(tractorBeamPowerLabel);
            inGameDataGroupBox.Controls.Add(encyclopediaDescription);
            inGameDataGroupBox.Controls.Add(picture);
            inGameDataGroupBox.Controls.Add(isEmpire);
            inGameDataGroupBox.Controls.Add(isAlliance);
            inGameDataGroupBox.Controls.Add(tractorBeamPower);
            inGameDataGroupBox.Controls.Add(shieldRechargeRateLabel);
            inGameDataGroupBox.Controls.Add(maneuverabilityLabel);
            inGameDataGroupBox.Controls.Add(hull);
            inGameDataGroupBox.Controls.Add(hyperdriveLabel);
            inGameDataGroupBox.Controls.Add(subLightEngineLabel);
            inGameDataGroupBox.Controls.Add(hullLabel);
            inGameDataGroupBox.Controls.Add(subLightEngine);
            inGameDataGroupBox.Controls.Add(detection);
            inGameDataGroupBox.Controls.Add(damageControlLabel);
            inGameDataGroupBox.Controls.Add(detectionLabel);
            inGameDataGroupBox.Controls.Add(damageControl);
            inGameDataGroupBox.Controls.Add(maneuverability);
            inGameDataGroupBox.Controls.Add(hyperdrive);
            inGameDataGroupBox.Controls.Add(shieldRechargeRate);
            inGameDataGroupBox.Location = new Point(7, 40);
            inGameDataGroupBox.Margin = new Padding(4, 3, 4, 3);
            inGameDataGroupBox.Name = "inGameDataGroupBox";
            inGameDataGroupBox.Padding = new Padding(4, 3, 4, 3);
            inGameDataGroupBox.Size = new Size(439, 524);
            inGameDataGroupBox.TabIndex = 2;
            inGameDataGroupBox.TabStop = false;
            inGameDataGroupBox.Text = "In Game Data";
            // 
            // name
            // 
            name.Location = new Point(220, 20);
            name.Name = "name";
            name.Size = new Size(213, 23);
            name.TabIndex = 1117;
            name.TextChanged += name_TextChanged;
            // 
            // encyclopediaDescriptionLabel
            // 
            encyclopediaDescriptionLabel.AutoSize = true;
            encyclopediaDescriptionLabel.BackColor = SystemColors.ControlDarkDark;
            encyclopediaDescriptionLabel.ForeColor = Color.White;
            encyclopediaDescriptionLabel.Location = new Point(288, 440);
            encyclopediaDescriptionLabel.Margin = new Padding(4, 0, 4, 0);
            encyclopediaDescriptionLabel.Name = "encyclopediaDescriptionLabel";
            encyclopediaDescriptionLabel.Size = new Size(140, 15);
            encyclopediaDescriptionLabel.TabIndex = 19;
            encyclopediaDescriptionLabel.Text = "Encyclopedia Description";
            // 
            // troopCapacityLabel
            // 
            troopCapacityLabel.AutoSize = true;
            troopCapacityLabel.Location = new Point(13, 203);
            troopCapacityLabel.Margin = new Padding(4, 0, 4, 0);
            troopCapacityLabel.Name = "troopCapacityLabel";
            troopCapacityLabel.Size = new Size(86, 15);
            troopCapacityLabel.TabIndex = 0;
            troopCapacityLabel.Text = "Troop Capacity";
            // 
            // troopCapacity
            // 
            troopCapacity.Location = new Point(146, 201);
            troopCapacity.Margin = new Padding(4, 3, 4, 3);
            troopCapacity.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            troopCapacity.Name = "troopCapacity";
            troopCapacity.Size = new Size(59, 23);
            troopCapacity.TabIndex = 18;
            troopCapacity.TextAlign = HorizontalAlignment.Right;
            troopCapacity.Value = new decimal(new int[] { -1, 0, 0, 0 });
            troopCapacity.ValueChanged += troopCapacity_ValueChanged;
            // 
            // shieldStrengthLabel
            // 
            shieldStrengthLabel.AutoSize = true;
            shieldStrengthLabel.Location = new Point(13, 228);
            shieldStrengthLabel.Margin = new Padding(4, 0, 4, 0);
            shieldStrengthLabel.Name = "shieldStrengthLabel";
            shieldStrengthLabel.Size = new Size(87, 15);
            shieldStrengthLabel.TabIndex = 0;
            shieldStrengthLabel.Text = "Shield Strength";
            // 
            // shieldStrength
            // 
            shieldStrength.Location = new Point(146, 226);
            shieldStrength.Margin = new Padding(4, 3, 4, 3);
            shieldStrength.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            shieldStrength.Name = "shieldStrength";
            shieldStrength.Size = new Size(59, 23);
            shieldStrength.TabIndex = 13;
            shieldStrength.TextAlign = HorizontalAlignment.Right;
            shieldStrength.Value = new decimal(new int[] { -1, 0, 0, 0 });
            shieldStrength.ValueChanged += shieldStrength_ValueChanged;
            // 
            // fighterCapacity
            // 
            fighterCapacity.Location = new Point(146, 176);
            fighterCapacity.Margin = new Padding(4, 3, 4, 3);
            fighterCapacity.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            fighterCapacity.Name = "fighterCapacity";
            fighterCapacity.Size = new Size(59, 23);
            fighterCapacity.TabIndex = 17;
            fighterCapacity.TextAlign = HorizontalAlignment.Right;
            fighterCapacity.Value = new decimal(new int[] { -1, 0, 0, 0 });
            fighterCapacity.ValueChanged += fighterCapacity_ValueChanged;
            // 
            // fighterCapacityLabel
            // 
            fighterCapacityLabel.AutoSize = true;
            fighterCapacityLabel.Location = new Point(13, 180);
            fighterCapacityLabel.Margin = new Padding(4, 0, 4, 0);
            fighterCapacityLabel.Name = "fighterCapacityLabel";
            fighterCapacityLabel.Size = new Size(93, 15);
            fighterCapacityLabel.TabIndex = 0;
            fighterCapacityLabel.Text = "Fighter Capacity";
            // 
            // tractorBeamPowerLabel
            // 
            tractorBeamPowerLabel.AutoSize = true;
            tractorBeamPowerLabel.Location = new Point(228, 155);
            tractorBeamPowerLabel.Margin = new Padding(4, 0, 4, 0);
            tractorBeamPowerLabel.Name = "tractorBeamPowerLabel";
            tractorBeamPowerLabel.Size = new Size(112, 15);
            tractorBeamPowerLabel.TabIndex = 1116;
            tractorBeamPowerLabel.Text = "Tractor Beam Power";
            // 
            // picture
            // 
            picture.BorderStyle = BorderStyle.FixedSingle;
            picture.InitialImage = null;
            picture.Location = new Point(8, 20);
            picture.Margin = new Padding(4, 3, 4, 3);
            picture.Name = "picture";
            picture.Size = new Size(205, 104);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.TabIndex = 114;
            picture.TabStop = false;
            // 
            // shieldRechargeRateLabel
            // 
            shieldRechargeRateLabel.AutoSize = true;
            shieldRechargeRateLabel.Location = new Point(228, 128);
            shieldRechargeRateLabel.Margin = new Padding(4, 0, 4, 0);
            shieldRechargeRateLabel.Name = "shieldRechargeRateLabel";
            shieldRechargeRateLabel.Size = new Size(117, 15);
            shieldRechargeRateLabel.TabIndex = 0;
            shieldRechargeRateLabel.Text = "Shield Recharge Rate";
            // 
            // maneuverabilityLabel
            // 
            maneuverabilityLabel.AutoSize = true;
            maneuverabilityLabel.Location = new Point(228, 203);
            maneuverabilityLabel.Margin = new Padding(4, 0, 4, 0);
            maneuverabilityLabel.Name = "maneuverabilityLabel";
            maneuverabilityLabel.Size = new Size(92, 15);
            maneuverabilityLabel.TabIndex = 0;
            maneuverabilityLabel.Text = "Maneuverability";
            // 
            // hull
            // 
            hull.Location = new Point(146, 276);
            hull.Margin = new Padding(4, 3, 4, 3);
            hull.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            hull.Name = "hull";
            hull.Size = new Size(59, 23);
            hull.TabIndex = 4;
            hull.TextAlign = HorizontalAlignment.Right;
            hull.Value = new decimal(new int[] { -1, 0, 0, 0 });
            hull.ValueChanged += hull_ValueChanged;
            // 
            // hyperdriveLabel
            // 
            hyperdriveLabel.AutoSize = true;
            hyperdriveLabel.Location = new Point(13, 254);
            hyperdriveLabel.Margin = new Padding(4, 0, 4, 0);
            hyperdriveLabel.Name = "hyperdriveLabel";
            hyperdriveLabel.Size = new Size(132, 15);
            hyperdriveLabel.TabIndex = 115;
            hyperdriveLabel.Text = "Hyperdrive (low=faster)";
            // 
            // subLightEngineLabel
            // 
            subLightEngineLabel.AutoSize = true;
            subLightEngineLabel.Location = new Point(228, 180);
            subLightEngineLabel.Margin = new Padding(4, 0, 4, 0);
            subLightEngineLabel.Name = "subLightEngineLabel";
            subLightEngineLabel.Size = new Size(98, 15);
            subLightEngineLabel.TabIndex = 0;
            subLightEngineLabel.Text = "Sub-Light Engine";
            // 
            // hullLabel
            // 
            hullLabel.AutoSize = true;
            hullLabel.Location = new Point(13, 278);
            hullLabel.Margin = new Padding(4, 0, 4, 0);
            hullLabel.Name = "hullLabel";
            hullLabel.Size = new Size(29, 15);
            hullLabel.TabIndex = 0;
            hullLabel.Text = "Hull";
            // 
            // subLightEngine
            // 
            subLightEngine.Location = new Point(365, 176);
            subLightEngine.Margin = new Padding(4, 3, 4, 3);
            subLightEngine.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            subLightEngine.Name = "subLightEngine";
            subLightEngine.Size = new Size(59, 23);
            subLightEngine.TabIndex = 9;
            subLightEngine.TextAlign = HorizontalAlignment.Right;
            subLightEngine.Value = new decimal(new int[] { -1, 0, 0, 0 });
            subLightEngine.ValueChanged += subLightEngine_ValueChanged;
            // 
            // damageControlLabel
            // 
            damageControlLabel.AutoSize = true;
            damageControlLabel.Location = new Point(228, 103);
            damageControlLabel.Margin = new Padding(4, 0, 4, 0);
            damageControlLabel.Name = "damageControlLabel";
            damageControlLabel.Size = new Size(94, 15);
            damageControlLabel.TabIndex = 0;
            damageControlLabel.Text = "Damage Control";
            // 
            // damageControl
            // 
            damageControl.Location = new Point(365, 101);
            damageControl.Margin = new Padding(4, 3, 4, 3);
            damageControl.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            damageControl.Name = "damageControl";
            damageControl.Size = new Size(59, 23);
            damageControl.TabIndex = 6;
            damageControl.TextAlign = HorizontalAlignment.Right;
            damageControl.Value = new decimal(new int[] { -1, 0, 0, 0 });
            damageControl.ValueChanged += damageControl_ValueChanged;
            // 
            // maneuverability
            // 
            maneuverability.Location = new Point(365, 201);
            maneuverability.Margin = new Padding(4, 3, 4, 3);
            maneuverability.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            maneuverability.Name = "maneuverability";
            maneuverability.Size = new Size(59, 23);
            maneuverability.TabIndex = 10;
            maneuverability.TextAlign = HorizontalAlignment.Right;
            maneuverability.Value = new decimal(new int[] { -1, 0, 0, 0 });
            maneuverability.ValueChanged += maneuverability_ValueChanged;
            // 
            // hyperdrive
            // 
            hyperdrive.Location = new Point(146, 251);
            hyperdrive.Margin = new Padding(4, 3, 4, 3);
            hyperdrive.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            hyperdrive.Name = "hyperdrive";
            hyperdrive.Size = new Size(59, 23);
            hyperdrive.TabIndex = 11;
            hyperdrive.TextAlign = HorizontalAlignment.Right;
            hyperdrive.Value = new decimal(new int[] { -1, 0, 0, 0 });
            hyperdrive.ValueChanged += hyperdrive_ValueChanged;
            // 
            // shieldRechargeRate
            // 
            shieldRechargeRate.Location = new Point(365, 126);
            shieldRechargeRate.Margin = new Padding(4, 3, 4, 3);
            shieldRechargeRate.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            shieldRechargeRate.Name = "shieldRechargeRate";
            shieldRechargeRate.Size = new Size(59, 23);
            shieldRechargeRate.TabIndex = 14;
            shieldRechargeRate.TextAlign = HorizontalAlignment.Right;
            shieldRechargeRate.Value = new decimal(new int[] { -1, 0, 0, 0 });
            shieldRechargeRate.ValueChanged += shieldRechargeRate_ValueChanged;
            // 
            // hyperdriveIfDamagedLabel
            // 
            hyperdriveIfDamagedLabel.AutoSize = true;
            hyperdriveIfDamagedLabel.Location = new Point(7, 273);
            hyperdriveIfDamagedLabel.Margin = new Padding(4, 0, 4, 0);
            hyperdriveIfDamagedLabel.Name = "hyperdriveIfDamagedLabel";
            hyperdriveIfDamagedLabel.Size = new Size(129, 15);
            hyperdriveIfDamagedLabel.TabIndex = 0;
            hyperdriveIfDamagedLabel.Text = "Hyperdrive if Damaged";
            // 
            // hyperdriveIfDamaged
            // 
            hyperdriveIfDamaged.Location = new Point(141, 271);
            hyperdriveIfDamaged.Margin = new Padding(4, 3, 4, 3);
            hyperdriveIfDamaged.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            hyperdriveIfDamaged.Name = "hyperdriveIfDamaged";
            hyperdriveIfDamaged.Size = new Size(59, 23);
            hyperdriveIfDamaged.TabIndex = 12;
            hyperdriveIfDamaged.TextAlign = HorizontalAlignment.Right;
            hyperdriveIfDamaged.Value = new decimal(new int[] { -1, 0, 0, 0 });
            hyperdriveIfDamaged.ValueChanged += hyperdriveIfDamaged_ValueChanged;
            // 
            // tractorBeamRangeLabel
            // 
            tractorBeamRangeLabel.AutoSize = true;
            tractorBeamRangeLabel.Location = new Point(7, 298);
            tractorBeamRangeLabel.Margin = new Padding(4, 0, 4, 0);
            tractorBeamRangeLabel.Name = "tractorBeamRangeLabel";
            tractorBeamRangeLabel.Size = new Size(112, 15);
            tractorBeamRangeLabel.TabIndex = 1117;
            tractorBeamRangeLabel.Text = "Tractor Beam Range";
            // 
            // field51_0Label
            // 
            field51_0Label.AutoSize = true;
            field51_0Label.ForeColor = Color.Red;
            field51_0Label.Location = new Point(7, 373);
            field51_0Label.Margin = new Padding(4, 0, 4, 0);
            field51_0Label.Name = "field51_0Label";
            field51_0Label.Size = new Size(99, 15);
            field51_0Label.TabIndex = 1118;
            field51_0Label.Text = "Field51 (always 0)";
            // 
            // field51_0
            // 
            field51_0.ForeColor = Color.Red;
            field51_0.Location = new Point(141, 371);
            field51_0.Margin = new Padding(4, 3, 4, 3);
            field51_0.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            field51_0.Name = "field51_0";
            field51_0.Size = new Size(59, 23);
            field51_0.TabIndex = 1119;
            field51_0.TabStop = false;
            field51_0.TextAlign = HorizontalAlignment.Right;
            field51_0.ValueChanged += field51_0_ValueChanged;
            // 
            // field2_1
            // 
            field2_1.ForeColor = Color.Red;
            field2_1.Location = new Point(141, 46);
            field2_1.Margin = new Padding(4, 3, 4, 3);
            field2_1.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            field2_1.Name = "field2_1";
            field2_1.Size = new Size(59, 23);
            field2_1.TabIndex = 1121;
            field2_1.TabStop = false;
            field2_1.TextAlign = HorizontalAlignment.Right;
            field2_1.Value = new decimal(new int[] { 2, 0, 0, 0 });
            field2_1.ValueChanged += field2_1_ValueChanged;
            // 
            // field2_1Label
            // 
            field2_1Label.AutoSize = true;
            field2_1Label.ForeColor = Color.Red;
            field2_1Label.Location = new Point(7, 48);
            field2_1Label.Margin = new Padding(4, 0, 4, 0);
            field2_1Label.Name = "field2_1Label";
            field2_1Label.Size = new Size(93, 15);
            field2_1Label.TabIndex = 1120;
            field2_1Label.Text = "Field2 (always 1)";
            // 
            // hiddenDataGroupBox
            // 
            hiddenDataGroupBox.Controls.Add(laserCannonRangeLabel);
            hiddenDataGroupBox.Controls.Add(nextProductionFamilyLabel);
            hiddenDataGroupBox.Controls.Add(turbolaserRange);
            hiddenDataGroupBox.Controls.Add(ionCannonRangeLabel);
            hiddenDataGroupBox.Controls.Add(field2_1);
            hiddenDataGroupBox.Controls.Add(ionCannonRange);
            hiddenDataGroupBox.Controls.Add(field51_0);
            hiddenDataGroupBox.Controls.Add(turbolaserRangeLabel);
            hiddenDataGroupBox.Controls.Add(laserCannonRange);
            hiddenDataGroupBox.Controls.Add(field2_1Label);
            hiddenDataGroupBox.Controls.Add(idLabel);
            hiddenDataGroupBox.Controls.Add(field51_0Label);
            hiddenDataGroupBox.Controls.Add(researchDifficultyLabel);
            hiddenDataGroupBox.Controls.Add(nextProductionFamily);
            hiddenDataGroupBox.Controls.Add(textStraDllId);
            hiddenDataGroupBox.Controls.Add(interdictionStrengthLabel);
            hiddenDataGroupBox.Controls.Add(textStraDllIdLabel);
            hiddenDataGroupBox.Controls.Add(productionFamilyLabel);
            hiddenDataGroupBox.Controls.Add(field7_2Label);
            hiddenDataGroupBox.Controls.Add(gravityWellProjectorLabel);
            hiddenDataGroupBox.Controls.Add(familyId);
            hiddenDataGroupBox.Controls.Add(productionFamily);
            hiddenDataGroupBox.Controls.Add(researchOrderLabel);
            hiddenDataGroupBox.Controls.Add(interdictionStrength);
            hiddenDataGroupBox.Controls.Add(familyIdLabel);
            hiddenDataGroupBox.Controls.Add(researchDifficulty);
            hiddenDataGroupBox.Controls.Add(idHexLabel);
            hiddenDataGroupBox.Controls.Add(gravityWellProjector);
            hiddenDataGroupBox.Controls.Add(hyperdriveIfDamaged);
            hiddenDataGroupBox.Controls.Add(familyIdHexLabel);
            hiddenDataGroupBox.Controls.Add(field7_2);
            hiddenDataGroupBox.Controls.Add(tractorBeamRangeLabel);
            hiddenDataGroupBox.Controls.Add(researchOrder);
            hiddenDataGroupBox.Controls.Add(UprisingDefenseLabel);
            hiddenDataGroupBox.Controls.Add(id);
            hiddenDataGroupBox.Controls.Add(tractorBeamRange);
            hiddenDataGroupBox.Controls.Add(uprisingDefense);
            hiddenDataGroupBox.Controls.Add(hyperdriveIfDamagedLabel);
            hiddenDataGroupBox.Location = new Point(448, 2);
            hiddenDataGroupBox.Name = "hiddenDataGroupBox";
            hiddenDataGroupBox.Size = new Size(233, 475);
            hiddenDataGroupBox.TabIndex = 1122;
            hiddenDataGroupBox.TabStop = false;
            hiddenDataGroupBox.Text = "Hidden Data";
            // 
            // laserCannonRangeLabel
            // 
            laserCannonRangeLabel.AutoSize = true;
            laserCannonRangeLabel.BackColor = SystemColors.Control;
            laserCannonRangeLabel.Location = new Point(70, 448);
            laserCannonRangeLabel.Margin = new Padding(4, 0, 4, 0);
            laserCannonRangeLabel.Name = "laserCannonRangeLabel";
            laserCannonRangeLabel.RightToLeft = RightToLeft.No;
            laserCannonRangeLabel.Size = new Size(115, 15);
            laserCannonRangeLabel.TabIndex = 1123;
            laserCannonRangeLabel.Text = "Laser Cannon Range";
            laserCannonRangeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ionCannonRangeLabel
            // 
            ionCannonRangeLabel.AutoSize = true;
            ionCannonRangeLabel.BackColor = SystemColors.Control;
            ionCannonRangeLabel.Location = new Point(70, 423);
            ionCannonRangeLabel.Margin = new Padding(4, 0, 4, 0);
            ionCannonRangeLabel.Name = "ionCannonRangeLabel";
            ionCannonRangeLabel.RightToLeft = RightToLeft.No;
            ionCannonRangeLabel.Size = new Size(105, 15);
            ionCannonRangeLabel.TabIndex = 1122;
            ionCannonRangeLabel.Text = "Ion Cannon Range";
            ionCannonRangeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // warningLabel
            // 
            warningLabel.AutoSize = true;
            warningLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline);
            warningLabel.ForeColor = SystemColors.AppWorkspace;
            warningLabel.Location = new Point(8, 19);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new Size(267, 15);
            warningLabel.TabIndex = 1123;
            warningLabel.Text = "/!\\ each attack value x hull must be < 536 870 911";
            // 
            // CapitalShipsForm
            // 
            AcceptButton = Ok;
            AutoScaleMode = AutoScaleMode.None;
            CancelButton = Cancel;
            ClientSize = new Size(686, 596);
            Controls.Add(hiddenDataGroupBox);
            Controls.Add(inGameDataGroupBox);
            Controls.Add(Open);
            Controls.Add(SaveAs);
            Controls.Add(Cancel);
            Controls.Add(Ok);
            Controls.Add(selector);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(702, 635);
            MinimumSize = new Size(702, 635);
            Name = "CapitalShipsForm";
            Text = "Capital Ships (CAPSHPSD.DAT)";
            FormClosing += GameObjectsListForm_FormClosing;
            Load += GameObjectsListForm_Load;
            Enter += GameObjectsSelector_ValueChanged;
            KeyDown += GameObjectsListForm_KeyDown;
            ((ISupportInitialize)textStraDllId).EndInit();
            ((ISupportInitialize)field7_2).EndInit();
            ((ISupportInitialize)familyId).EndInit();
            ((ISupportInitialize)nextProductionFamily).EndInit();
            ((ISupportInitialize)productionFamily).EndInit();
            ((ISupportInitialize)uprisingDefense).EndInit();
            ((ISupportInitialize)researchDifficulty).EndInit();
            ((ISupportInitialize)selector).EndInit();
            ((ISupportInitialize)detection).EndInit();
            ((ISupportInitialize)researchOrder).EndInit();
            ((ISupportInitialize)maintenanceCost).EndInit();
            ((ISupportInitialize)refinedMaterialCost).EndInit();
            ((ISupportInitialize)bombardmentModifier).EndInit();
            ((ISupportInitialize)weaponRechargeRate).EndInit();
            ((ISupportInitialize)interdictionStrength).EndInit();
            ((ISupportInitialize)gravityWellProjector).EndInit();
            ((ISupportInitialize)tractorBeamRange).EndInit();
            ((ISupportInitialize)tractorBeamPower).EndInit();
            attackStrengthGroupBox.ResumeLayout(false);
            attackStrengthGroupBox.PerformLayout();
            ((ISupportInitialize)laserCannonStarboard).EndInit();
            ((ISupportInitialize)laserCannonPort).EndInit();
            ((ISupportInitialize)laserCannonAft).EndInit();
            ((ISupportInitialize)ionCannonStarboard).EndInit();
            ((ISupportInitialize)overallAttackStrength).EndInit();
            ((ISupportInitialize)ionCannonPort).EndInit();
            ((ISupportInitialize)ionCannonAft).EndInit();
            ((ISupportInitialize)ionCannonFore).EndInit();
            ((ISupportInitialize)laserCannonFore).EndInit();
            ((ISupportInitialize)turbolaserStarboard).EndInit();
            ((ISupportInitialize)turbolaserPort).EndInit();
            ((ISupportInitialize)turbolaserAft).EndInit();
            ((ISupportInitialize)turbolaserFore).EndInit();
            ((ISupportInitialize)ionCannonAttackStrength).EndInit();
            ((ISupportInitialize)laserCannonAttackStrength).EndInit();
            ((ISupportInitialize)turbolaserAttackStrength).EndInit();
            ((ISupportInitialize)laserCannonRange).EndInit();
            ((ISupportInitialize)ionCannonRange).EndInit();
            ((ISupportInitialize)turbolaserRange).EndInit();
            ((ISupportInitialize)id).EndInit();
            inGameDataGroupBox.ResumeLayout(false);
            inGameDataGroupBox.PerformLayout();
            ((ISupportInitialize)troopCapacity).EndInit();
            ((ISupportInitialize)shieldStrength).EndInit();
            ((ISupportInitialize)fighterCapacity).EndInit();
            ((ISupportInitialize)picture).EndInit();
            ((ISupportInitialize)hull).EndInit();
            ((ISupportInitialize)subLightEngine).EndInit();
            ((ISupportInitialize)damageControl).EndInit();
            ((ISupportInitialize)maneuverability).EndInit();
            ((ISupportInitialize)hyperdrive).EndInit();
            ((ISupportInitialize)shieldRechargeRate).EndInit();
            ((ISupportInitialize)hyperdriveIfDamaged).EndInit();
            ((ISupportInitialize)field51_0).EndInit();
            ((ISupportInitialize)field2_1).EndInit();
            hiddenDataGroupBox.ResumeLayout(false);
            hiddenDataGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label encyclopediaDescriptionLabel;
        private Label hyperdriveLabel;
        private Label totalAttackLabel;
        private Label overallLabel;
        private Label tractorBeamPowerLabel;
        private Label tractorBeamRangeLabel;
        private Label field51_0Label;
        private NumericUpDown field51_0;
        private NumericUpDown field2_1;
        private Label field2_1Label;
        private GroupBox hiddenDataGroupBox;
        private TextBox name;
        private Label laserCannonRangeLabel;
        private Label ionCannonRangeLabel;
        private Label warningLabel;
    }
}