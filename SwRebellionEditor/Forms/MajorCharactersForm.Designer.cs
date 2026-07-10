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
        private Button Cancel;
        private Button Save;
        private TrackBar selector;
        private CheckBox isAlliance;
        private CheckBox isEmpire;
        private NumericUpDown combatVariance;
        private NumericUpDown diplomacyVariance;
        private NumericUpDown espionageVariance;
        private Label combatLabel;
        private NumericUpDown combatBase;
        private Label diplomacyLabel;
        private NumericUpDown diplomacyBase;
        private NumericUpDown espionageBase;
        private Label espionageLabel;
        private NumericUpDown facilityDesignVariance;
        private NumericUpDown shipDesignVariance;
        private NumericUpDown troopTrainingVariance;
        private Label facilityDesignLabel;
        private NumericUpDown facilityDesignBase;
        private Label shipDesignLabel;
        private NumericUpDown shipDesignBase;
        private NumericUpDown troopTrainingBase;
        private Label troopTrainingLabel;
        private NumericUpDown loyaltyVariance;
        private NumericUpDown loyaltyBase;
        private Label loyaltyLabel;
        private Label varianceLabel;
        private Label baseLabel;
        private CheckBox isUnableToBetray;
        private GroupBox hiddenDataGroupBox;
        private Label hiddenVarianceLabel;
        private Label hiddenBaseLabel;
        private NumericUpDown jediLevelVariance;
        private Label jediProbabilityLabel;
        private NumericUpDown jediProbability;
        private NumericUpDown jediLevelBase;
        private Label jediLevelLabel;
        private CheckBox canBeCommander;
        private CheckBox canBeAdmiral;
        private CheckBox canBeGeneral;
        private NumericUpDown jediEspionageBase;
        private NumericUpDown jediDiplomacyBase;
        private NumericUpDown jediCombatBase;
        private NumericUpDown jediLeadershipBase;
        private CheckBox isJediTrainer;
        private CheckBox isKnownJedi;
        private RichTextBox encyclopediaDescription;
        private PictureBox picture;
        private ImageList majorCharactersImages;
        private Label leiaForceLabel;
        private ListView majorCharactersListView;
        private NumericUpDown field2_1;
        private NumericUpDown textStraDllId;
        private NumericUpDown productionFamily_0;
        private Label field2_1Label;
        private NumericUpDown familyId;
        private Label productionFamily_0Label;
        private Label textStraDllIdLabel;
        private Label familyIdLabel;
        private Label nextProductionFamily_0Label;
        private NumericUpDown nextProductionFamily_0;
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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MajorCharactersForm));
            leiaForceLabel = new Label();
            jediEspionageBase = new NumericUpDown();
            jediDiplomacyBase = new NumericUpDown();
            jediCombatBase = new NumericUpDown();
            jediLeadershipBase = new NumericUpDown();
            hiddenDataGroupBox = new GroupBox();
            researchDifficulty_0 = new NumericUpDown();
            loyaltyBase = new NumericUpDown();
            isUnableToBetray = new CheckBox();
            researchDifficulty_0Label = new Label();
            researchOrder_0 = new NumericUpDown();
            loyaltyVariance = new NumericUpDown();
            researchOrder_0Label = new Label();
            maintenanceCost = new NumericUpDown();
            loyaltyLabel = new Label();
            maintenanceCostLabel = new Label();
            refinedMaterialCost_0 = new NumericUpDown();
            refinedMaterialCost_0Label = new Label();
            field7_2 = new NumericUpDown();
            field7_2Label = new Label();
            textStraDllId = new NumericUpDown();
            familyIdHexLabel = new Label();
            textStraDllIdLabel = new Label();
            hiddenVarianceLabel = new Label();
            field2_1 = new NumericUpDown();
            familyId = new NumericUpDown();
            productionFamily_0 = new NumericUpDown();
            idHexLabel = new Label();
            familyIdLabel = new Label();
            hiddenBaseLabel = new Label();
            productionFamily_0Label = new Label();
            id = new NumericUpDown();
            field2_1Label = new Label();
            nextProductionFamily_0Label = new Label();
            jediLevelVariance = new NumericUpDown();
            nextProductionFamily_0 = new NumericUpDown();
            idLabel = new Label();
            jediProbabilityLabel = new Label();
            jediProbability = new NumericUpDown();
            jediLevelBase = new NumericUpDown();
            jediLevelLabel = new Label();
            facilityDesignVariance = new NumericUpDown();
            shipDesignVariance = new NumericUpDown();
            troopTrainingVariance = new NumericUpDown();
            facilityDesignLabel = new Label();
            facilityDesignBase = new NumericUpDown();
            shipDesignLabel = new Label();
            shipDesignBase = new NumericUpDown();
            troopTrainingBase = new NumericUpDown();
            troopTrainingLabel = new Label();
            varianceLabel = new Label();
            combatVariance = new NumericUpDown();
            diplomacyVariance = new NumericUpDown();
            espionageVariance = new NumericUpDown();
            encyclopediaDescription = new RichTextBox();
            isJediTrainer = new CheckBox();
            isKnownJedi = new CheckBox();
            baseLabel = new Label();
            combatLabel = new Label();
            combatBase = new NumericUpDown();
            diplomacyLabel = new Label();
            diplomacyBase = new NumericUpDown();
            espionageBase = new NumericUpDown();
            espionageLabel = new Label();
            selector = new TrackBar();
            isAlliance = new CheckBox();
            isEmpire = new CheckBox();
            canBeCommander = new CheckBox();
            canBeAdmiral = new CheckBox();
            canBeGeneral = new CheckBox();
            Cancel = new Button();
            Save = new Button();
            majorCharactersImages = new ImageList(components);
            majorCharactersListView = new ListView();
            picture = new PictureBox();
            gameDataGroupBox = new GroupBox();
            encyclopediaDescriptionLabel = new Label();
            baseJediModsLabel = new Label();
            leadershipVariance = new NumericUpDown();
            leadershipBase = new NumericUpDown();
            leadershipLabel = new Label();
            name = new TextBox();
            ((ISupportInitialize)jediEspionageBase).BeginInit();
            ((ISupportInitialize)jediDiplomacyBase).BeginInit();
            ((ISupportInitialize)jediCombatBase).BeginInit();
            ((ISupportInitialize)jediLeadershipBase).BeginInit();
            hiddenDataGroupBox.SuspendLayout();
            ((ISupportInitialize)researchDifficulty_0).BeginInit();
            ((ISupportInitialize)loyaltyBase).BeginInit();
            ((ISupportInitialize)researchOrder_0).BeginInit();
            ((ISupportInitialize)loyaltyVariance).BeginInit();
            ((ISupportInitialize)maintenanceCost).BeginInit();
            ((ISupportInitialize)refinedMaterialCost_0).BeginInit();
            ((ISupportInitialize)field7_2).BeginInit();
            ((ISupportInitialize)textStraDllId).BeginInit();
            ((ISupportInitialize)field2_1).BeginInit();
            ((ISupportInitialize)familyId).BeginInit();
            ((ISupportInitialize)productionFamily_0).BeginInit();
            ((ISupportInitialize)id).BeginInit();
            ((ISupportInitialize)jediLevelVariance).BeginInit();
            ((ISupportInitialize)nextProductionFamily_0).BeginInit();
            ((ISupportInitialize)jediProbability).BeginInit();
            ((ISupportInitialize)jediLevelBase).BeginInit();
            ((ISupportInitialize)facilityDesignVariance).BeginInit();
            ((ISupportInitialize)shipDesignVariance).BeginInit();
            ((ISupportInitialize)troopTrainingVariance).BeginInit();
            ((ISupportInitialize)facilityDesignBase).BeginInit();
            ((ISupportInitialize)shipDesignBase).BeginInit();
            ((ISupportInitialize)troopTrainingBase).BeginInit();
            ((ISupportInitialize)combatVariance).BeginInit();
            ((ISupportInitialize)diplomacyVariance).BeginInit();
            ((ISupportInitialize)espionageVariance).BeginInit();
            ((ISupportInitialize)combatBase).BeginInit();
            ((ISupportInitialize)diplomacyBase).BeginInit();
            ((ISupportInitialize)espionageBase).BeginInit();
            ((ISupportInitialize)selector).BeginInit();
            ((ISupportInitialize)picture).BeginInit();
            gameDataGroupBox.SuspendLayout();
            ((ISupportInitialize)leadershipVariance).BeginInit();
            ((ISupportInitialize)leadershipBase).BeginInit();
            SuspendLayout();
            // 
            // leiaForceLabel
            // 
            leiaForceLabel.AutoSize = true;
            leiaForceLabel.ForeColor = Color.Red;
            leiaForceLabel.Location = new Point(6, 435);
            leiaForceLabel.Margin = new Padding(4, 0, 4, 0);
            leiaForceLabel.Name = "leiaForceLabel";
            leiaForceLabel.Size = new Size(79, 15);
            leiaForceLabel.TabIndex = 28;
            leiaForceLabel.Text = "--Leia Label--";
            // 
            // jediEspionageBase
            // 
            jediEspionageBase.Enabled = false;
            jediEspionageBase.Location = new Point(231, 179);
            jediEspionageBase.Margin = new Padding(4, 3, 4, 3);
            jediEspionageBase.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            jediEspionageBase.Name = "jediEspionageBase";
            jediEspionageBase.Size = new Size(59, 23);
            jediEspionageBase.TabIndex = 0;
            jediEspionageBase.TextAlign = HorizontalAlignment.Right;
            jediEspionageBase.Value = new decimal(new int[] { -1, 0, 0, 0 });
            // 
            // jediDiplomacyBase
            // 
            jediDiplomacyBase.Enabled = false;
            jediDiplomacyBase.Location = new Point(231, 153);
            jediDiplomacyBase.Margin = new Padding(4, 3, 4, 3);
            jediDiplomacyBase.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            jediDiplomacyBase.Name = "jediDiplomacyBase";
            jediDiplomacyBase.Size = new Size(59, 23);
            jediDiplomacyBase.TabIndex = 0;
            jediDiplomacyBase.TextAlign = HorizontalAlignment.Right;
            jediDiplomacyBase.Value = new decimal(new int[] { -1, 0, 0, 0 });
            // 
            // jediCombatBase
            // 
            jediCombatBase.Enabled = false;
            jediCombatBase.Location = new Point(231, 205);
            jediCombatBase.Margin = new Padding(4, 3, 4, 3);
            jediCombatBase.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            jediCombatBase.Name = "jediCombatBase";
            jediCombatBase.Size = new Size(59, 23);
            jediCombatBase.TabIndex = 0;
            jediCombatBase.TextAlign = HorizontalAlignment.Right;
            jediCombatBase.Value = new decimal(new int[] { -1, 0, 0, 0 });
            // 
            // jediLeadershipBase
            // 
            jediLeadershipBase.Enabled = false;
            jediLeadershipBase.Location = new Point(231, 231);
            jediLeadershipBase.Margin = new Padding(4, 3, 4, 3);
            jediLeadershipBase.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            jediLeadershipBase.Name = "jediLeadershipBase";
            jediLeadershipBase.Size = new Size(59, 23);
            jediLeadershipBase.TabIndex = 0;
            jediLeadershipBase.TextAlign = HorizontalAlignment.Right;
            jediLeadershipBase.Value = new decimal(new int[] { -1, 0, 0, 0 });
            // 
            // hiddenDataGroupBox
            // 
            hiddenDataGroupBox.Controls.Add(leiaForceLabel);
            hiddenDataGroupBox.Controls.Add(researchDifficulty_0);
            hiddenDataGroupBox.Controls.Add(loyaltyBase);
            hiddenDataGroupBox.Controls.Add(isUnableToBetray);
            hiddenDataGroupBox.Controls.Add(researchDifficulty_0Label);
            hiddenDataGroupBox.Controls.Add(researchOrder_0);
            hiddenDataGroupBox.Controls.Add(loyaltyVariance);
            hiddenDataGroupBox.Controls.Add(researchOrder_0Label);
            hiddenDataGroupBox.Controls.Add(maintenanceCost);
            hiddenDataGroupBox.Controls.Add(loyaltyLabel);
            hiddenDataGroupBox.Controls.Add(maintenanceCostLabel);
            hiddenDataGroupBox.Controls.Add(refinedMaterialCost_0);
            hiddenDataGroupBox.Controls.Add(refinedMaterialCost_0Label);
            hiddenDataGroupBox.Controls.Add(field7_2);
            hiddenDataGroupBox.Controls.Add(field7_2Label);
            hiddenDataGroupBox.Controls.Add(textStraDllId);
            hiddenDataGroupBox.Controls.Add(familyIdHexLabel);
            hiddenDataGroupBox.Controls.Add(textStraDllIdLabel);
            hiddenDataGroupBox.Controls.Add(hiddenVarianceLabel);
            hiddenDataGroupBox.Controls.Add(field2_1);
            hiddenDataGroupBox.Controls.Add(familyId);
            hiddenDataGroupBox.Controls.Add(productionFamily_0);
            hiddenDataGroupBox.Controls.Add(idHexLabel);
            hiddenDataGroupBox.Controls.Add(familyIdLabel);
            hiddenDataGroupBox.Controls.Add(hiddenBaseLabel);
            hiddenDataGroupBox.Controls.Add(productionFamily_0Label);
            hiddenDataGroupBox.Controls.Add(id);
            hiddenDataGroupBox.Controls.Add(field2_1Label);
            hiddenDataGroupBox.Controls.Add(nextProductionFamily_0Label);
            hiddenDataGroupBox.Controls.Add(jediLevelVariance);
            hiddenDataGroupBox.Controls.Add(nextProductionFamily_0);
            hiddenDataGroupBox.Controls.Add(idLabel);
            hiddenDataGroupBox.Controls.Add(jediProbabilityLabel);
            hiddenDataGroupBox.Controls.Add(jediProbability);
            hiddenDataGroupBox.Controls.Add(jediLevelBase);
            hiddenDataGroupBox.Controls.Add(jediLevelLabel);
            hiddenDataGroupBox.Location = new Point(566, 6);
            hiddenDataGroupBox.Margin = new Padding(4, 3, 4, 3);
            hiddenDataGroupBox.Name = "hiddenDataGroupBox";
            hiddenDataGroupBox.Padding = new Padding(4, 3, 4, 3);
            hiddenDataGroupBox.Size = new Size(264, 464);
            hiddenDataGroupBox.TabIndex = 6;
            hiddenDataGroupBox.TabStop = false;
            hiddenDataGroupBox.Text = "Hidden Data";
            // 
            // researchDifficulty_0
            // 
            researchDifficulty_0.BackColor = SystemColors.Window;
            researchDifficulty_0.ForeColor = Color.FromArgb(192, 0, 192);
            researchDifficulty_0.Location = new Point(136, 279);
            researchDifficulty_0.Margin = new Padding(4, 3, 4, 3);
            researchDifficulty_0.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            researchDifficulty_0.Name = "researchDifficulty_0";
            researchDifficulty_0.Size = new Size(59, 23);
            researchDifficulty_0.TabIndex = 1137;
            researchDifficulty_0.TabStop = false;
            researchDifficulty_0.TextAlign = HorizontalAlignment.Right;
            researchDifficulty_0.ValueChanged += researchDifficulty_0_ValueChanged;
            // 
            // loyaltyBase
            // 
            loyaltyBase.Location = new Point(136, 325);
            loyaltyBase.Margin = new Padding(4, 3, 4, 3);
            loyaltyBase.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            loyaltyBase.Name = "loyaltyBase";
            loyaltyBase.Size = new Size(59, 23);
            loyaltyBase.TabIndex = 10;
            loyaltyBase.TextAlign = HorizontalAlignment.Right;
            loyaltyBase.Value = new decimal(new int[] { -1, 0, 0, 0 });
            loyaltyBase.ValueChanged += loyaltyBase_ValueChanged;
            // 
            // isUnableToBetray
            // 
            isUnableToBetray.AutoSize = true;
            isUnableToBetray.Location = new Point(7, 411);
            isUnableToBetray.Margin = new Padding(4, 3, 4, 3);
            isUnableToBetray.Name = "isUnableToBetray";
            isUnableToBetray.Size = new Size(113, 19);
            isUnableToBetray.TabIndex = 17;
            isUnableToBetray.Text = "Unable to Betray";
            isUnableToBetray.UseVisualStyleBackColor = true;
            isUnableToBetray.CheckStateChanged += isUnableToBetray_CheckStateChanged;
            // 
            // researchDifficulty_0Label
            // 
            researchDifficulty_0Label.AutoSize = true;
            researchDifficulty_0Label.ForeColor = Color.FromArgb(192, 0, 192);
            researchDifficulty_0Label.Location = new Point(7, 281);
            researchDifficulty_0Label.Margin = new Padding(4, 0, 4, 0);
            researchDifficulty_0Label.Name = "researchDifficulty_0Label";
            researchDifficulty_0Label.Size = new Size(105, 15);
            researchDifficulty_0Label.TabIndex = 1136;
            researchDifficulty_0Label.Text = "Research Difficulty";
            // 
            // researchOrder_0
            // 
            researchOrder_0.BackColor = SystemColors.Window;
            researchOrder_0.ForeColor = Color.FromArgb(192, 0, 192);
            researchOrder_0.Location = new Point(136, 253);
            researchOrder_0.Margin = new Padding(4, 3, 4, 3);
            researchOrder_0.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            researchOrder_0.Name = "researchOrder_0";
            researchOrder_0.Size = new Size(59, 23);
            researchOrder_0.TabIndex = 1135;
            researchOrder_0.TabStop = false;
            researchOrder_0.TextAlign = HorizontalAlignment.Right;
            researchOrder_0.ValueChanged += researchOrder_0_ValueChanged;
            // 
            // loyaltyVariance
            // 
            loyaltyVariance.Location = new Point(199, 325);
            loyaltyVariance.Margin = new Padding(4, 3, 4, 3);
            loyaltyVariance.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            loyaltyVariance.Name = "loyaltyVariance";
            loyaltyVariance.Size = new Size(59, 23);
            loyaltyVariance.TabIndex = 11;
            loyaltyVariance.TextAlign = HorizontalAlignment.Right;
            loyaltyVariance.Value = new decimal(new int[] { -1, 0, 0, 0 });
            loyaltyVariance.ValueChanged += loyaltyVariance_ValueChanged;
            // 
            // researchOrder_0Label
            // 
            researchOrder_0Label.AutoSize = true;
            researchOrder_0Label.ForeColor = Color.FromArgb(192, 0, 192);
            researchOrder_0Label.Location = new Point(7, 255);
            researchOrder_0Label.Margin = new Padding(4, 0, 4, 0);
            researchOrder_0Label.Name = "researchOrder_0Label";
            researchOrder_0Label.Size = new Size(87, 15);
            researchOrder_0Label.TabIndex = 1134;
            researchOrder_0Label.Text = "Research Order";
            // 
            // maintenanceCost
            // 
            maintenanceCost.BackColor = SystemColors.Window;
            maintenanceCost.ForeColor = SystemColors.WindowText;
            maintenanceCost.Location = new Point(136, 227);
            maintenanceCost.Margin = new Padding(4, 3, 4, 3);
            maintenanceCost.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            maintenanceCost.Name = "maintenanceCost";
            maintenanceCost.Size = new Size(59, 23);
            maintenanceCost.TabIndex = 1133;
            maintenanceCost.TabStop = false;
            maintenanceCost.TextAlign = HorizontalAlignment.Right;
            maintenanceCost.Value = new decimal(new int[] { -1, 0, 0, 0 });
            maintenanceCost.ValueChanged += maintenanceCost_ValueChanged;
            // 
            // loyaltyLabel
            // 
            loyaltyLabel.AutoSize = true;
            loyaltyLabel.Location = new Point(7, 327);
            loyaltyLabel.Margin = new Padding(4, 0, 4, 0);
            loyaltyLabel.Name = "loyaltyLabel";
            loyaltyLabel.Size = new Size(45, 15);
            loyaltyLabel.TabIndex = 12;
            loyaltyLabel.Text = "Loyalty";
            // 
            // maintenanceCostLabel
            // 
            maintenanceCostLabel.AutoSize = true;
            maintenanceCostLabel.ForeColor = SystemColors.WindowText;
            maintenanceCostLabel.Location = new Point(7, 229);
            maintenanceCostLabel.Margin = new Padding(4, 0, 4, 0);
            maintenanceCostLabel.Name = "maintenanceCostLabel";
            maintenanceCostLabel.Size = new Size(103, 15);
            maintenanceCostLabel.TabIndex = 1132;
            maintenanceCostLabel.Text = "Maintenance Cost";
            // 
            // refinedMaterialCost_0
            // 
            refinedMaterialCost_0.BackColor = SystemColors.Window;
            refinedMaterialCost_0.ForeColor = Color.FromArgb(192, 0, 192);
            refinedMaterialCost_0.Location = new Point(136, 201);
            refinedMaterialCost_0.Margin = new Padding(4, 3, 4, 3);
            refinedMaterialCost_0.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            refinedMaterialCost_0.Name = "refinedMaterialCost_0";
            refinedMaterialCost_0.Size = new Size(59, 23);
            refinedMaterialCost_0.TabIndex = 1131;
            refinedMaterialCost_0.TabStop = false;
            refinedMaterialCost_0.TextAlign = HorizontalAlignment.Right;
            refinedMaterialCost_0.ValueChanged += refinedMaterialCost_0_ValueChanged;
            // 
            // refinedMaterialCost_0Label
            // 
            refinedMaterialCost_0Label.AutoSize = true;
            refinedMaterialCost_0Label.ForeColor = Color.FromArgb(192, 0, 192);
            refinedMaterialCost_0Label.Location = new Point(6, 203);
            refinedMaterialCost_0Label.Margin = new Padding(4, 0, 4, 0);
            refinedMaterialCost_0Label.Name = "refinedMaterialCost_0Label";
            refinedMaterialCost_0Label.Size = new Size(120, 15);
            refinedMaterialCost_0Label.TabIndex = 1130;
            refinedMaterialCost_0Label.Text = "Refined Material Cost";
            // 
            // field7_2
            // 
            field7_2.BackColor = SystemColors.Window;
            field7_2.ForeColor = Color.Red;
            field7_2.Location = new Point(136, 175);
            field7_2.Margin = new Padding(4, 3, 4, 3);
            field7_2.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            field7_2.Name = "field7_2";
            field7_2.Size = new Size(59, 23);
            field7_2.TabIndex = 1129;
            field7_2.TabStop = false;
            field7_2.TextAlign = HorizontalAlignment.Right;
            field7_2.Value = new decimal(new int[] { 2, 0, 0, 0 });
            field7_2.ValueChanged += field7_2_ValueChanged;
            // 
            // field7_2Label
            // 
            field7_2Label.AutoSize = true;
            field7_2Label.ForeColor = Color.Red;
            field7_2Label.Location = new Point(6, 177);
            field7_2Label.Margin = new Padding(4, 0, 4, 0);
            field7_2Label.Name = "field7_2Label";
            field7_2Label.Size = new Size(93, 15);
            field7_2Label.TabIndex = 1128;
            field7_2Label.Text = "Field7 (always 2)";
            // 
            // textStraDllId
            // 
            textStraDllId.BackColor = SystemColors.Window;
            textStraDllId.ForeColor = Color.Red;
            textStraDllId.Location = new Point(136, 149);
            textStraDllId.Margin = new Padding(4, 3, 4, 3);
            textStraDllId.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            textStraDllId.Name = "textStraDllId";
            textStraDllId.Size = new Size(59, 23);
            textStraDllId.TabIndex = 148;
            textStraDllId.TabStop = false;
            textStraDllId.TextAlign = HorizontalAlignment.Right;
            textStraDllId.Value = new decimal(new int[] { 65535, 0, 0, 0 });
            textStraDllId.ValueChanged += textStraDllId_ValueChanged;
            // 
            // familyIdHexLabel
            // 
            familyIdHexLabel.AutoSize = true;
            familyIdHexLabel.ForeColor = Color.Red;
            familyIdHexLabel.Location = new Point(197, 128);
            familyIdHexLabel.Margin = new Padding(4, 0, 4, 0);
            familyIdHexLabel.Name = "familyIdHexLabel";
            familyIdHexLabel.Size = new Size(26, 15);
            familyIdHexLabel.TabIndex = 1127;
            familyIdHexLabel.Text = "hex";
            // 
            // textStraDllIdLabel
            // 
            textStraDllIdLabel.AutoSize = true;
            textStraDllIdLabel.ForeColor = Color.Red;
            textStraDllIdLabel.Location = new Point(7, 151);
            textStraDllIdLabel.Margin = new Padding(4, 0, 4, 0);
            textStraDllIdLabel.Name = "textStraDllIdLabel";
            textStraDllIdLabel.Size = new Size(77, 15);
            textStraDllIdLabel.TabIndex = 144;
            textStraDllIdLabel.Text = "TextStra.dll Id";
            // 
            // hiddenVarianceLabel
            // 
            hiddenVarianceLabel.AutoSize = true;
            hiddenVarianceLabel.BackColor = Color.Silver;
            hiddenVarianceLabel.Location = new Point(199, 307);
            hiddenVarianceLabel.Margin = new Padding(4, 0, 4, 0);
            hiddenVarianceLabel.Name = "hiddenVarianceLabel";
            hiddenVarianceLabel.Size = new Size(51, 15);
            hiddenVarianceLabel.TabIndex = 11;
            hiddenVarianceLabel.Text = "Variance";
            // 
            // field2_1
            // 
            field2_1.BackColor = SystemColors.Window;
            field2_1.ForeColor = Color.Red;
            field2_1.Location = new Point(136, 45);
            field2_1.Margin = new Padding(4, 3, 4, 3);
            field2_1.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            field2_1.Name = "field2_1";
            field2_1.Size = new Size(59, 23);
            field2_1.TabIndex = 146;
            field2_1.TabStop = false;
            field2_1.TextAlign = HorizontalAlignment.Right;
            field2_1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            field2_1.ValueChanged += field2_1_ValueChanged;
            // 
            // familyId
            // 
            familyId.BackColor = SystemColors.Window;
            familyId.ForeColor = Color.Red;
            familyId.Location = new Point(136, 123);
            familyId.Margin = new Padding(4, 3, 4, 3);
            familyId.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            familyId.Name = "familyId";
            familyId.Size = new Size(59, 23);
            familyId.TabIndex = 147;
            familyId.TabStop = false;
            familyId.TextAlign = HorizontalAlignment.Right;
            familyId.Value = new decimal(new int[] { -1, 0, 0, 0 });
            familyId.ValueChanged += familyId_ValueChanged;
            // 
            // productionFamily_0
            // 
            productionFamily_0.BackColor = SystemColors.Window;
            productionFamily_0.ForeColor = Color.FromArgb(192, 0, 192);
            productionFamily_0.Location = new Point(136, 71);
            productionFamily_0.Margin = new Padding(4, 3, 4, 3);
            productionFamily_0.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            productionFamily_0.Name = "productionFamily_0";
            productionFamily_0.Size = new Size(59, 23);
            productionFamily_0.TabIndex = 138;
            productionFamily_0.TabStop = false;
            productionFamily_0.TextAlign = HorizontalAlignment.Right;
            productionFamily_0.ValueChanged += productionFamily_0_ValueChanged;
            // 
            // idHexLabel
            // 
            idHexLabel.AutoSize = true;
            idHexLabel.ForeColor = Color.Red;
            idHexLabel.Location = new Point(197, 21);
            idHexLabel.Margin = new Padding(4, 0, 4, 0);
            idHexLabel.Name = "idHexLabel";
            idHexLabel.Size = new Size(26, 15);
            idHexLabel.TabIndex = 1126;
            idHexLabel.Text = "hex";
            // 
            // familyIdLabel
            // 
            familyIdLabel.AutoSize = true;
            familyIdLabel.ForeColor = Color.Red;
            familyIdLabel.Location = new Point(7, 125);
            familyIdLabel.Margin = new Padding(4, 0, 4, 0);
            familyIdLabel.Name = "familyIdLabel";
            familyIdLabel.Size = new Size(55, 15);
            familyIdLabel.TabIndex = 143;
            familyIdLabel.Text = "Family Id";
            // 
            // hiddenBaseLabel
            // 
            hiddenBaseLabel.AutoSize = true;
            hiddenBaseLabel.BackColor = Color.Silver;
            hiddenBaseLabel.Location = new Point(136, 307);
            hiddenBaseLabel.Margin = new Padding(4, 0, 4, 0);
            hiddenBaseLabel.Name = "hiddenBaseLabel";
            hiddenBaseLabel.Size = new Size(31, 15);
            hiddenBaseLabel.TabIndex = 10;
            hiddenBaseLabel.Text = "Base";
            // 
            // productionFamily_0Label
            // 
            productionFamily_0Label.AutoSize = true;
            productionFamily_0Label.ForeColor = Color.FromArgb(192, 0, 192);
            productionFamily_0Label.Location = new Point(6, 73);
            productionFamily_0Label.Margin = new Padding(4, 0, 4, 0);
            productionFamily_0Label.Name = "productionFamily_0Label";
            productionFamily_0Label.Size = new Size(104, 15);
            productionFamily_0Label.TabIndex = 140;
            productionFamily_0Label.Text = "Production Family";
            // 
            // id
            // 
            id.BackColor = SystemColors.Window;
            id.ForeColor = Color.Red;
            id.Location = new Point(136, 19);
            id.Margin = new Padding(4, 3, 4, 3);
            id.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            id.Name = "id";
            id.Size = new Size(59, 23);
            id.TabIndex = 1125;
            id.TabStop = false;
            id.TextAlign = HorizontalAlignment.Right;
            id.Value = new decimal(new int[] { -1, 0, 0, 0 });
            id.ValueChanged += id_ValueChanged;
            // 
            // field2_1Label
            // 
            field2_1Label.AutoSize = true;
            field2_1Label.ForeColor = Color.Red;
            field2_1Label.Location = new Point(6, 47);
            field2_1Label.Margin = new Padding(4, 0, 4, 0);
            field2_1Label.Name = "field2_1Label";
            field2_1Label.Size = new Size(93, 15);
            field2_1Label.TabIndex = 145;
            field2_1Label.Text = "Field2 (always 1)";
            // 
            // nextProductionFamily_0Label
            // 
            nextProductionFamily_0Label.AutoSize = true;
            nextProductionFamily_0Label.ForeColor = Color.FromArgb(192, 0, 192);
            nextProductionFamily_0Label.Location = new Point(7, 99);
            nextProductionFamily_0Label.Margin = new Padding(4, 0, 4, 0);
            nextProductionFamily_0Label.Name = "nextProductionFamily_0Label";
            nextProductionFamily_0Label.Size = new Size(121, 15);
            nextProductionFamily_0Label.TabIndex = 142;
            nextProductionFamily_0Label.Text = "Production Family +1";
            // 
            // jediLevelVariance
            // 
            jediLevelVariance.Location = new Point(199, 377);
            jediLevelVariance.Margin = new Padding(4, 3, 4, 3);
            jediLevelVariance.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            jediLevelVariance.Name = "jediLevelVariance";
            jediLevelVariance.Size = new Size(59, 23);
            jediLevelVariance.TabIndex = 25;
            jediLevelVariance.TextAlign = HorizontalAlignment.Right;
            jediLevelVariance.Value = new decimal(new int[] { -1, 0, 0, 0 });
            jediLevelVariance.ValueChanged += jediLevelVariance_ValueChanged;
            // 
            // nextProductionFamily_0
            // 
            nextProductionFamily_0.BackColor = SystemColors.Window;
            nextProductionFamily_0.ForeColor = Color.FromArgb(192, 0, 192);
            nextProductionFamily_0.Location = new Point(136, 97);
            nextProductionFamily_0.Margin = new Padding(4, 3, 4, 3);
            nextProductionFamily_0.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            nextProductionFamily_0.Name = "nextProductionFamily_0";
            nextProductionFamily_0.Size = new Size(59, 23);
            nextProductionFamily_0.TabIndex = 141;
            nextProductionFamily_0.TabStop = false;
            nextProductionFamily_0.TextAlign = HorizontalAlignment.Right;
            nextProductionFamily_0.ValueChanged += nextProductionFamily_0_ValueChanged;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.ForeColor = Color.Red;
            idLabel.Location = new Point(7, 21);
            idLabel.Margin = new Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 1124;
            idLabel.Text = "Id";
            // 
            // jediProbabilityLabel
            // 
            jediProbabilityLabel.AutoSize = true;
            jediProbabilityLabel.Location = new Point(7, 353);
            jediProbabilityLabel.Margin = new Padding(4, 0, 4, 0);
            jediProbabilityLabel.Name = "jediProbabilityLabel";
            jediProbabilityLabel.Size = new Size(87, 15);
            jediProbabilityLabel.TabIndex = 0;
            jediProbabilityLabel.Text = "Jedi Probability";
            // 
            // jediProbability
            // 
            jediProbability.Location = new Point(136, 351);
            jediProbability.Margin = new Padding(4, 3, 4, 3);
            jediProbability.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            jediProbability.Name = "jediProbability";
            jediProbability.Size = new Size(59, 23);
            jediProbability.TabIndex = 23;
            jediProbability.TextAlign = HorizontalAlignment.Right;
            jediProbability.Value = new decimal(new int[] { -1, 0, 0, 0 });
            jediProbability.ValueChanged += jediProbability_ValueChanged;
            // 
            // jediLevelBase
            // 
            jediLevelBase.Location = new Point(136, 377);
            jediLevelBase.Margin = new Padding(4, 3, 4, 3);
            jediLevelBase.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            jediLevelBase.Name = "jediLevelBase";
            jediLevelBase.Size = new Size(59, 23);
            jediLevelBase.TabIndex = 24;
            jediLevelBase.TextAlign = HorizontalAlignment.Right;
            jediLevelBase.Value = new decimal(new int[] { -1, 0, 0, 0 });
            jediLevelBase.ValueChanged += jediLevelBase_ValueChanged;
            // 
            // jediLevelLabel
            // 
            jediLevelLabel.AutoSize = true;
            jediLevelLabel.Location = new Point(7, 380);
            jediLevelLabel.Margin = new Padding(4, 0, 4, 0);
            jediLevelLabel.Name = "jediLevelLabel";
            jediLevelLabel.Size = new Size(57, 15);
            jediLevelLabel.TabIndex = 0;
            jediLevelLabel.Text = "Jedi Level";
            // 
            // facilityDesignVariance
            // 
            facilityDesignVariance.Location = new Point(165, 309);
            facilityDesignVariance.Margin = new Padding(4, 3, 4, 3);
            facilityDesignVariance.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            facilityDesignVariance.Name = "facilityDesignVariance";
            facilityDesignVariance.Size = new Size(59, 23);
            facilityDesignVariance.TabIndex = 9;
            facilityDesignVariance.TextAlign = HorizontalAlignment.Right;
            facilityDesignVariance.Value = new decimal(new int[] { -1, 0, 0, 0 });
            facilityDesignVariance.ValueChanged += facilityDesignVariance_ValueChanged;
            // 
            // shipDesignVariance
            // 
            shipDesignVariance.Location = new Point(165, 257);
            shipDesignVariance.Margin = new Padding(4, 3, 4, 3);
            shipDesignVariance.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            shipDesignVariance.Name = "shipDesignVariance";
            shipDesignVariance.Size = new Size(59, 23);
            shipDesignVariance.TabIndex = 5;
            shipDesignVariance.TextAlign = HorizontalAlignment.Right;
            shipDesignVariance.Value = new decimal(new int[] { -1, 0, 0, 0 });
            shipDesignVariance.ValueChanged += shipDesignVariance_ValueChanged;
            // 
            // troopTrainingVariance
            // 
            troopTrainingVariance.Location = new Point(165, 283);
            troopTrainingVariance.Margin = new Padding(4, 3, 4, 3);
            troopTrainingVariance.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            troopTrainingVariance.Name = "troopTrainingVariance";
            troopTrainingVariance.Size = new Size(59, 23);
            troopTrainingVariance.TabIndex = 7;
            troopTrainingVariance.TextAlign = HorizontalAlignment.Right;
            troopTrainingVariance.Value = new decimal(new int[] { -1, 0, 0, 0 });
            troopTrainingVariance.ValueChanged += troopTrainingVariance_ValueChanged;
            // 
            // facilityDesignLabel
            // 
            facilityDesignLabel.AutoSize = true;
            facilityDesignLabel.Location = new Point(12, 311);
            facilityDesignLabel.Margin = new Padding(4, 0, 4, 0);
            facilityDesignLabel.Name = "facilityDesignLabel";
            facilityDesignLabel.Size = new Size(83, 15);
            facilityDesignLabel.TabIndex = 0;
            facilityDesignLabel.Text = "Facility Design";
            // 
            // facilityDesignBase
            // 
            facilityDesignBase.Location = new Point(102, 309);
            facilityDesignBase.Margin = new Padding(4, 3, 4, 3);
            facilityDesignBase.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            facilityDesignBase.Name = "facilityDesignBase";
            facilityDesignBase.Size = new Size(59, 23);
            facilityDesignBase.TabIndex = 8;
            facilityDesignBase.TextAlign = HorizontalAlignment.Right;
            facilityDesignBase.Value = new decimal(new int[] { -1, 0, 0, 0 });
            facilityDesignBase.ValueChanged += facilityDesignBase_ValueChanged;
            // 
            // shipDesignLabel
            // 
            shipDesignLabel.AutoSize = true;
            shipDesignLabel.Location = new Point(12, 259);
            shipDesignLabel.Margin = new Padding(4, 0, 4, 0);
            shipDesignLabel.Name = "shipDesignLabel";
            shipDesignLabel.Size = new Size(69, 15);
            shipDesignLabel.TabIndex = 0;
            shipDesignLabel.Text = "Ship Design";
            // 
            // shipDesignBase
            // 
            shipDesignBase.Location = new Point(102, 257);
            shipDesignBase.Margin = new Padding(4, 3, 4, 3);
            shipDesignBase.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            shipDesignBase.Name = "shipDesignBase";
            shipDesignBase.Size = new Size(59, 23);
            shipDesignBase.TabIndex = 4;
            shipDesignBase.TextAlign = HorizontalAlignment.Right;
            shipDesignBase.Value = new decimal(new int[] { -1, 0, 0, 0 });
            shipDesignBase.ValueChanged += shipDesignBase_ValueChanged;
            // 
            // troopTrainingBase
            // 
            troopTrainingBase.Location = new Point(102, 283);
            troopTrainingBase.Margin = new Padding(4, 3, 4, 3);
            troopTrainingBase.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            troopTrainingBase.Name = "troopTrainingBase";
            troopTrainingBase.Size = new Size(59, 23);
            troopTrainingBase.TabIndex = 6;
            troopTrainingBase.TextAlign = HorizontalAlignment.Right;
            troopTrainingBase.Value = new decimal(new int[] { -1, 0, 0, 0 });
            troopTrainingBase.ValueChanged += troopTrainingBase_ValueChanged;
            // 
            // troopTrainingLabel
            // 
            troopTrainingLabel.AutoSize = true;
            troopTrainingLabel.Location = new Point(12, 285);
            troopTrainingLabel.Margin = new Padding(4, 0, 4, 0);
            troopTrainingLabel.Name = "troopTrainingLabel";
            troopTrainingLabel.Size = new Size(82, 15);
            troopTrainingLabel.TabIndex = 0;
            troopTrainingLabel.Text = "Troop Training";
            // 
            // varianceLabel
            // 
            varianceLabel.AutoSize = true;
            varianceLabel.BackColor = Color.Silver;
            varianceLabel.Enabled = false;
            varianceLabel.Location = new Point(165, 135);
            varianceLabel.Margin = new Padding(4, 0, 4, 0);
            varianceLabel.Name = "varianceLabel";
            varianceLabel.Size = new Size(51, 15);
            varianceLabel.TabIndex = 11;
            varianceLabel.Text = "Variance";
            // 
            // combatVariance
            // 
            combatVariance.Location = new Point(165, 205);
            combatVariance.Margin = new Padding(4, 3, 4, 3);
            combatVariance.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            combatVariance.Name = "combatVariance";
            combatVariance.Size = new Size(59, 23);
            combatVariance.TabIndex = 9;
            combatVariance.TextAlign = HorizontalAlignment.Right;
            combatVariance.Value = new decimal(new int[] { -1, 0, 0, 0 });
            combatVariance.ValueChanged += combatVariance_ValueChanged;
            // 
            // diplomacyVariance
            // 
            diplomacyVariance.Location = new Point(165, 153);
            diplomacyVariance.Margin = new Padding(4, 3, 4, 3);
            diplomacyVariance.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            diplomacyVariance.Name = "diplomacyVariance";
            diplomacyVariance.Size = new Size(59, 23);
            diplomacyVariance.TabIndex = 5;
            diplomacyVariance.TextAlign = HorizontalAlignment.Right;
            diplomacyVariance.Value = new decimal(new int[] { -1, 0, 0, 0 });
            diplomacyVariance.ValueChanged += diplomacyVariance_ValueChanged;
            // 
            // espionageVariance
            // 
            espionageVariance.Location = new Point(165, 179);
            espionageVariance.Margin = new Padding(4, 3, 4, 3);
            espionageVariance.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            espionageVariance.Name = "espionageVariance";
            espionageVariance.Size = new Size(59, 23);
            espionageVariance.TabIndex = 7;
            espionageVariance.TextAlign = HorizontalAlignment.Right;
            espionageVariance.Value = new decimal(new int[] { -1, 0, 0, 0 });
            espionageVariance.ValueChanged += espionageVariance_ValueChanged;
            // 
            // encyclopediaDescription
            // 
            encyclopediaDescription.Location = new Point(7, 338);
            encyclopediaDescription.Margin = new Padding(4, 3, 4, 3);
            encyclopediaDescription.Name = "encyclopediaDescription";
            encyclopediaDescription.Size = new Size(364, 82);
            encyclopediaDescription.TabIndex = 134;
            encyclopediaDescription.TabStop = false;
            encyclopediaDescription.Text = "";
            encyclopediaDescription.TextChanged += encyclopediaDescription_TextChanged;
            // 
            // isJediTrainer
            // 
            isJediTrainer.AutoSize = true;
            isJediTrainer.Location = new Point(247, 113);
            isJediTrainer.Margin = new Padding(4, 3, 4, 3);
            isJediTrainer.Name = "isJediTrainer";
            isJediTrainer.Size = new Size(84, 19);
            isJediTrainer.TabIndex = 22;
            isJediTrainer.Text = "Jedi Trainer";
            isJediTrainer.UseVisualStyleBackColor = true;
            isJediTrainer.CheckStateChanged += isJediTrainer_CheckStateChanged;
            // 
            // isKnownJedi
            // 
            isKnownJedi.AutoSize = true;
            isKnownJedi.Location = new Point(247, 96);
            isKnownJedi.Margin = new Padding(4, 3, 4, 3);
            isKnownJedi.Name = "isKnownJedi";
            isKnownJedi.Size = new Size(86, 19);
            isKnownJedi.TabIndex = 21;
            isKnownJedi.Text = "Known Jedi";
            isKnownJedi.UseVisualStyleBackColor = true;
            isKnownJedi.CheckStateChanged += isKnownJedi_CheckStateChanged;
            // 
            // baseLabel
            // 
            baseLabel.AutoSize = true;
            baseLabel.BackColor = Color.Silver;
            baseLabel.Enabled = false;
            baseLabel.Location = new Point(102, 135);
            baseLabel.Margin = new Padding(4, 0, 4, 0);
            baseLabel.Name = "baseLabel";
            baseLabel.Size = new Size(31, 15);
            baseLabel.TabIndex = 10;
            baseLabel.Text = "Base";
            // 
            // combatLabel
            // 
            combatLabel.AutoSize = true;
            combatLabel.Location = new Point(12, 207);
            combatLabel.Margin = new Padding(4, 0, 4, 0);
            combatLabel.Name = "combatLabel";
            combatLabel.Size = new Size(50, 15);
            combatLabel.TabIndex = 0;
            combatLabel.Text = "Combat";
            // 
            // combatBase
            // 
            combatBase.Location = new Point(102, 205);
            combatBase.Margin = new Padding(4, 3, 4, 3);
            combatBase.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            combatBase.Name = "combatBase";
            combatBase.Size = new Size(59, 23);
            combatBase.TabIndex = 8;
            combatBase.TextAlign = HorizontalAlignment.Right;
            combatBase.Value = new decimal(new int[] { -1, 0, 0, 0 });
            combatBase.ValueChanged += combatBase_ValueChanged;
            // 
            // diplomacyLabel
            // 
            diplomacyLabel.AutoSize = true;
            diplomacyLabel.Location = new Point(12, 155);
            diplomacyLabel.Margin = new Padding(4, 0, 4, 0);
            diplomacyLabel.Name = "diplomacyLabel";
            diplomacyLabel.Size = new Size(64, 15);
            diplomacyLabel.TabIndex = 0;
            diplomacyLabel.Text = "Diplomacy";
            // 
            // diplomacyBase
            // 
            diplomacyBase.Location = new Point(102, 153);
            diplomacyBase.Margin = new Padding(4, 3, 4, 3);
            diplomacyBase.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            diplomacyBase.Name = "diplomacyBase";
            diplomacyBase.Size = new Size(59, 23);
            diplomacyBase.TabIndex = 4;
            diplomacyBase.TextAlign = HorizontalAlignment.Right;
            diplomacyBase.Value = new decimal(new int[] { -1, 0, 0, 0 });
            diplomacyBase.ValueChanged += diplomacyBase_ValueChanged;
            // 
            // espionageBase
            // 
            espionageBase.Location = new Point(102, 179);
            espionageBase.Margin = new Padding(4, 3, 4, 3);
            espionageBase.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            espionageBase.Name = "espionageBase";
            espionageBase.Size = new Size(59, 23);
            espionageBase.TabIndex = 6;
            espionageBase.TextAlign = HorizontalAlignment.Right;
            espionageBase.Value = new decimal(new int[] { -1, 0, 0, 0 });
            espionageBase.ValueChanged += espionageBase_ValueChanged;
            // 
            // espionageLabel
            // 
            espionageLabel.AutoSize = true;
            espionageLabel.Location = new Point(12, 181);
            espionageLabel.Margin = new Padding(4, 0, 4, 0);
            espionageLabel.Name = "espionageLabel";
            espionageLabel.Size = new Size(61, 15);
            espionageLabel.TabIndex = 0;
            espionageLabel.Text = "Espionage";
            // 
            // selector
            // 
            selector.LargeChange = 1;
            selector.Location = new Point(186, 6);
            selector.Margin = new Padding(4, 3, 4, 3);
            selector.Maximum = 5;
            selector.Name = "selector";
            selector.Size = new Size(376, 45);
            selector.TabIndex = 1;
            selector.ValueChanged += GameObjectsSelector_ValueChanged;
            // 
            // isAlliance
            // 
            isAlliance.AutoSize = true;
            isAlliance.Location = new Point(247, 47);
            isAlliance.Margin = new Padding(4, 3, 4, 3);
            isAlliance.Name = "isAlliance";
            isAlliance.Size = new Size(68, 19);
            isAlliance.TabIndex = 15;
            isAlliance.Text = "Alliance";
            isAlliance.UseVisualStyleBackColor = true;
            isAlliance.CheckStateChanged += isAlliance_CheckStateChanged;
            // 
            // isEmpire
            // 
            isEmpire.AutoSize = true;
            isEmpire.Location = new Point(247, 64);
            isEmpire.Margin = new Padding(4, 3, 4, 3);
            isEmpire.Name = "isEmpire";
            isEmpire.Size = new Size(63, 19);
            isEmpire.TabIndex = 16;
            isEmpire.Text = "Empire";
            isEmpire.UseVisualStyleBackColor = true;
            isEmpire.CheckStateChanged += isEmpire_CheckStateChanged;
            // 
            // canBeCommander
            // 
            canBeCommander.AutoSize = true;
            canBeCommander.Location = new Point(252, 301);
            canBeCommander.Margin = new Padding(4, 3, 4, 3);
            canBeCommander.Name = "canBeCommander";
            canBeCommander.Size = new Size(93, 19);
            canBeCommander.TabIndex = 20;
            canBeCommander.Text = "Commander";
            canBeCommander.UseVisualStyleBackColor = true;
            canBeCommander.CheckStateChanged += canBeCommander_CheckStateChanged;
            // 
            // canBeAdmiral
            // 
            canBeAdmiral.AutoSize = true;
            canBeAdmiral.Location = new Point(252, 267);
            canBeAdmiral.Margin = new Padding(4, 3, 4, 3);
            canBeAdmiral.Name = "canBeAdmiral";
            canBeAdmiral.Size = new Size(68, 19);
            canBeAdmiral.TabIndex = 18;
            canBeAdmiral.Text = "Admiral";
            canBeAdmiral.UseVisualStyleBackColor = true;
            canBeAdmiral.CheckStateChanged += canBeAdmiral_CheckStateChanged;
            // 
            // canBeGeneral
            // 
            canBeGeneral.AutoSize = true;
            canBeGeneral.Location = new Point(252, 284);
            canBeGeneral.Margin = new Padding(4, 3, 4, 3);
            canBeGeneral.Name = "canBeGeneral";
            canBeGeneral.Size = new Size(66, 19);
            canBeGeneral.TabIndex = 19;
            canBeGeneral.Text = "General";
            canBeGeneral.UseVisualStyleBackColor = true;
            canBeGeneral.CheckStateChanged += canBeGeneral_CheckStateChanged;
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.Red;
            Cancel.DialogResult = DialogResult.Cancel;
            Cancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancel.ForeColor = Color.White;
            Cancel.Location = new Point(736, 476);
            Cancel.Margin = new Padding(4, 3, 4, 3);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(88, 27);
            Cancel.TabIndex = 8;
            Cancel.Text = "&Cancel";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // Save
            // 
            Save.BackColor = Color.FromArgb(0, 192, 0);
            Save.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Save.ForeColor = Color.White;
            Save.Location = new Point(589, 476);
            Save.Margin = new Padding(4, 3, 4, 3);
            Save.Name = "Save";
            Save.Size = new Size(88, 27);
            Save.TabIndex = 7;
            Save.Text = "&Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // majorCharactersImages
            // 
            majorCharactersImages.ColorDepth = ColorDepth.Depth24Bit;
            majorCharactersImages.ImageSize = new Size(120, 60);
            majorCharactersImages.TransparentColor = Color.Transparent;
            // 
            // majorCharactersListView
            // 
            majorCharactersListView.BackColor = SystemColors.ControlLight;
            majorCharactersListView.BorderStyle = BorderStyle.FixedSingle;
            majorCharactersListView.GridLines = true;
            majorCharactersListView.LargeImageList = majorCharactersImages;
            majorCharactersListView.Location = new Point(0, 0);
            majorCharactersListView.Margin = new Padding(0);
            majorCharactersListView.MultiSelect = false;
            majorCharactersListView.Name = "majorCharactersListView";
            majorCharactersListView.ShowGroups = false;
            majorCharactersListView.Size = new Size(179, 476);
            majorCharactersListView.TabIndex = 0;
            majorCharactersListView.TabStop = false;
            majorCharactersListView.UseCompatibleStateImageBehavior = false;
            majorCharactersListView.Click += majorCharactersListView_Click;
            majorCharactersListView.DoubleClick += majorCharactersListView_DoubleClick;
            // 
            // picture
            // 
            picture.BorderStyle = BorderStyle.FixedSingle;
            picture.InitialImage = null;
            picture.Location = new Point(7, 22);
            picture.Margin = new Padding(4, 3, 4, 3);
            picture.Name = "picture";
            picture.Size = new Size(220, 110);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.TabIndex = 134;
            picture.TabStop = false;
            picture.Click += picture_Click;
            // 
            // gameDataGroupBox
            // 
            gameDataGroupBox.Controls.Add(encyclopediaDescriptionLabel);
            gameDataGroupBox.Controls.Add(baseJediModsLabel);
            gameDataGroupBox.Controls.Add(canBeCommander);
            gameDataGroupBox.Controls.Add(encyclopediaDescription);
            gameDataGroupBox.Controls.Add(leadershipVariance);
            gameDataGroupBox.Controls.Add(canBeAdmiral);
            gameDataGroupBox.Controls.Add(jediEspionageBase);
            gameDataGroupBox.Controls.Add(canBeGeneral);
            gameDataGroupBox.Controls.Add(jediLeadershipBase);
            gameDataGroupBox.Controls.Add(jediDiplomacyBase);
            gameDataGroupBox.Controls.Add(leadershipBase);
            gameDataGroupBox.Controls.Add(jediCombatBase);
            gameDataGroupBox.Controls.Add(facilityDesignVariance);
            gameDataGroupBox.Controls.Add(leadershipLabel);
            gameDataGroupBox.Controls.Add(isJediTrainer);
            gameDataGroupBox.Controls.Add(shipDesignVariance);
            gameDataGroupBox.Controls.Add(varianceLabel);
            gameDataGroupBox.Controls.Add(troopTrainingVariance);
            gameDataGroupBox.Controls.Add(name);
            gameDataGroupBox.Controls.Add(combatVariance);
            gameDataGroupBox.Controls.Add(facilityDesignLabel);
            gameDataGroupBox.Controls.Add(isKnownJedi);
            gameDataGroupBox.Controls.Add(diplomacyVariance);
            gameDataGroupBox.Controls.Add(facilityDesignBase);
            gameDataGroupBox.Controls.Add(isAlliance);
            gameDataGroupBox.Controls.Add(espionageVariance);
            gameDataGroupBox.Controls.Add(shipDesignLabel);
            gameDataGroupBox.Controls.Add(baseLabel);
            gameDataGroupBox.Controls.Add(shipDesignBase);
            gameDataGroupBox.Controls.Add(isEmpire);
            gameDataGroupBox.Controls.Add(picture);
            gameDataGroupBox.Controls.Add(troopTrainingBase);
            gameDataGroupBox.Controls.Add(diplomacyBase);
            gameDataGroupBox.Controls.Add(espionageLabel);
            gameDataGroupBox.Controls.Add(troopTrainingLabel);
            gameDataGroupBox.Controls.Add(combatLabel);
            gameDataGroupBox.Controls.Add(espionageBase);
            gameDataGroupBox.Controls.Add(combatBase);
            gameDataGroupBox.Controls.Add(diplomacyLabel);
            gameDataGroupBox.Location = new Point(186, 43);
            gameDataGroupBox.Name = "gameDataGroupBox";
            gameDataGroupBox.Size = new Size(376, 427);
            gameDataGroupBox.TabIndex = 135;
            gameDataGroupBox.TabStop = false;
            gameDataGroupBox.Text = "In Game Data";
            // 
            // encyclopediaDescriptionLabel
            // 
            encyclopediaDescriptionLabel.AutoSize = true;
            encyclopediaDescriptionLabel.BackColor = SystemColors.ControlDarkDark;
            encyclopediaDescriptionLabel.ForeColor = Color.White;
            encyclopediaDescriptionLabel.Location = new Point(227, 324);
            encyclopediaDescriptionLabel.Margin = new Padding(4, 0, 4, 0);
            encyclopediaDescriptionLabel.Name = "encyclopediaDescriptionLabel";
            encyclopediaDescriptionLabel.Size = new Size(140, 15);
            encyclopediaDescriptionLabel.TabIndex = 1127;
            encyclopediaDescriptionLabel.Text = "Encyclopedia Description";
            // 
            // baseJediModsLabel
            // 
            baseJediModsLabel.AutoSize = true;
            baseJediModsLabel.BackColor = Color.Silver;
            baseJediModsLabel.Enabled = false;
            baseJediModsLabel.Location = new Point(232, 135);
            baseJediModsLabel.Margin = new Padding(4, 0, 4, 0);
            baseJediModsLabel.Name = "baseJediModsLabel";
            baseJediModsLabel.Size = new Size(98, 15);
            baseJediModsLabel.TabIndex = 139;
            baseJediModsLabel.Text = "Base + Jedi mods";
            // 
            // leadershipVariance
            // 
            leadershipVariance.Location = new Point(165, 231);
            leadershipVariance.Margin = new Padding(4, 3, 4, 3);
            leadershipVariance.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            leadershipVariance.Name = "leadershipVariance";
            leadershipVariance.Size = new Size(59, 23);
            leadershipVariance.TabIndex = 138;
            leadershipVariance.TextAlign = HorizontalAlignment.Right;
            leadershipVariance.Value = new decimal(new int[] { -1, 0, 0, 0 });
            leadershipVariance.ValueChanged += leadershipVariance_ValueChanged;
            // 
            // leadershipBase
            // 
            leadershipBase.Location = new Point(102, 231);
            leadershipBase.Margin = new Padding(4, 3, 4, 3);
            leadershipBase.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            leadershipBase.Name = "leadershipBase";
            leadershipBase.Size = new Size(59, 23);
            leadershipBase.TabIndex = 137;
            leadershipBase.TextAlign = HorizontalAlignment.Right;
            leadershipBase.Value = new decimal(new int[] { -1, 0, 0, 0 });
            leadershipBase.ValueChanged += leadershipBase_ValueChanged;
            // 
            // leadershipLabel
            // 
            leadershipLabel.AutoSize = true;
            leadershipLabel.Location = new Point(12, 233);
            leadershipLabel.Margin = new Padding(4, 0, 4, 0);
            leadershipLabel.Name = "leadershipLabel";
            leadershipLabel.Size = new Size(64, 15);
            leadershipLabel.TabIndex = 136;
            leadershipLabel.Text = "Leadership";
            // 
            // name
            // 
            name.Location = new Point(234, 22);
            name.Name = "name";
            name.Size = new Size(137, 23);
            name.TabIndex = 135;
            name.TextChanged += name_TextChanged;
            // 
            // MajorCharactersForm
            // 
            AcceptButton = Save;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            CancelButton = Cancel;
            ClientSize = new Size(834, 512);
            Controls.Add(hiddenDataGroupBox);
            Controls.Add(gameDataGroupBox);
            Controls.Add(majorCharactersListView);
            Controls.Add(Cancel);
            Controls.Add(Save);
            Controls.Add(selector);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimumSize = new Size(850, 551);
            Name = "MajorCharactersForm";
            Text = "Major Characters (MJCHARSD.DAT)";
            FormClosing += GameObjectsListForm_FormClosing;
            Load += GameObjectsListForm_Load;
            Enter += GameObjectsSelector_ValueChanged;
            KeyDown += GameObjectsListForm_KeyDown;
            ((ISupportInitialize)jediEspionageBase).EndInit();
            ((ISupportInitialize)jediDiplomacyBase).EndInit();
            ((ISupportInitialize)jediCombatBase).EndInit();
            ((ISupportInitialize)jediLeadershipBase).EndInit();
            hiddenDataGroupBox.ResumeLayout(false);
            hiddenDataGroupBox.PerformLayout();
            ((ISupportInitialize)researchDifficulty_0).EndInit();
            ((ISupportInitialize)loyaltyBase).EndInit();
            ((ISupportInitialize)researchOrder_0).EndInit();
            ((ISupportInitialize)loyaltyVariance).EndInit();
            ((ISupportInitialize)maintenanceCost).EndInit();
            ((ISupportInitialize)refinedMaterialCost_0).EndInit();
            ((ISupportInitialize)field7_2).EndInit();
            ((ISupportInitialize)textStraDllId).EndInit();
            ((ISupportInitialize)field2_1).EndInit();
            ((ISupportInitialize)familyId).EndInit();
            ((ISupportInitialize)productionFamily_0).EndInit();
            ((ISupportInitialize)id).EndInit();
            ((ISupportInitialize)jediLevelVariance).EndInit();
            ((ISupportInitialize)nextProductionFamily_0).EndInit();
            ((ISupportInitialize)jediProbability).EndInit();
            ((ISupportInitialize)jediLevelBase).EndInit();
            ((ISupportInitialize)facilityDesignVariance).EndInit();
            ((ISupportInitialize)shipDesignVariance).EndInit();
            ((ISupportInitialize)troopTrainingVariance).EndInit();
            ((ISupportInitialize)facilityDesignBase).EndInit();
            ((ISupportInitialize)shipDesignBase).EndInit();
            ((ISupportInitialize)troopTrainingBase).EndInit();
            ((ISupportInitialize)combatVariance).EndInit();
            ((ISupportInitialize)diplomacyVariance).EndInit();
            ((ISupportInitialize)espionageVariance).EndInit();
            ((ISupportInitialize)combatBase).EndInit();
            ((ISupportInitialize)diplomacyBase).EndInit();
            ((ISupportInitialize)espionageBase).EndInit();
            ((ISupportInitialize)selector).EndInit();
            ((ISupportInitialize)picture).EndInit();
            gameDataGroupBox.ResumeLayout(false);
            gameDataGroupBox.PerformLayout();
            ((ISupportInitialize)leadershipVariance).EndInit();
            ((ISupportInitialize)leadershipBase).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private GroupBox gameDataGroupBox;
        private TextBox name;
        private NumericUpDown leadershipVariance;
        private NumericUpDown leadershipBase;
        private Label leadershipLabel;
        private NumericUpDown field7_2;
        private Label field7_2Label;
        private NumericUpDown researchDifficulty_0;
        private Label researchDifficulty_0Label;
        private NumericUpDown researchOrder_0;
        private Label researchOrder_0Label;
        private NumericUpDown maintenanceCost;
        private Label maintenanceCostLabel;
        private NumericUpDown refinedMaterialCost_0;
        private Label refinedMaterialCost_0Label;
        private Label baseJediModsLabel;
        private Label encyclopediaDescriptionLabel;
    }
}








