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
        private RichTextBox description;
        private Label name;
        private Label idLabel;
        private NumericUpDown textStraDllId;
        private Label unkown3Label;
        private NumericUpDown field7_2;
        private NumericUpDown familyId;
        private Label familyLabel;
        private NumericUpDown nextProductionFacility;
        private Label secProdFacNumlabel;
        private Label prodLabel;
        private NumericUpDown productionFacility;
        private NumericUpDown moraleModifier;
        private Label UnkownMoralHPlabel;
        private NumericUpDown researchDifficulty;
        private Label resDiffLabel;
        private CheckBox isEmpireUnit;
        private CheckBox isAllianceUnit;
        private Label DetectionLabel;
        private NumericUpDown detectionRating;
        private Label researchLabel;
        private NumericUpDown researchOrder;
        private NumericUpDown maintenanceCost;
        private Label maintCostLabel;
        private PictureBox picture;
        private NumericUpDown refinedMaterialCost;
        private Label conCostLabel;
        private GroupBox attackStrengthGroup;
        private Label wepForeLabel;
        private Label label6;
        private Label label5;
        private Label wepPortLabel;
        private Label wepAftLabel;
        private NumericUpDown turbolaserStarboard;
        private NumericUpDown turbolaserPort;
        private NumericUpDown turbolaserAft;
        private NumericUpDown turbolaserFore;
        private Label wepTurboLabel;
        private NumericUpDown ionCannonRange;
        private NumericUpDown ionCannonStarboard;
        private NumericUpDown ionCannonPort;
        private NumericUpDown ionCannonAft;
        private NumericUpDown turbolaserRange;
        private NumericUpDown ionCannonFore;
        private NumericUpDown laserCannonFore;
        private Label wepLaserLabel;
        private Label wepIonLabel;
        private NumericUpDown laserCannonRange;
        private NumericUpDown laserCannonStarboard;
        private NumericUpDown laserCannonPort;
        private NumericUpDown laserCannonAft;
        private NumericUpDown bombardmentDefense;
        private NumericUpDown weaponsRecharge;
        private Label bombardLabel;
        private Label wepRechLabel;
        private NumericUpDown tractorBeamRange;
        private NumericUpDown tractorBeamStrength;
        private NumericUpDown interdictionStrength;
        private NumericUpDown gravityWellProjectors;
        private Label gravWell2Label;
        private Label gravWell1Label;
        private GroupBox costsGroup;
        private NumericUpDown shieldRechargeRate;
        private Label shieldRechLabel;
        private NumericUpDown shieldStrength;
        private Label shieldLabel;
        private Label damageConLabel;
        private NumericUpDown damageControl;
        private Label hullLabel;
        private NumericUpDown hullStrength;
        private NumericUpDown primaryHyperdrive;
        private Label manuverLabel;
        private NumericUpDown sublightManoeuvrability;
        private Label sublightLabel;
        private NumericUpDown sublightSpeed;
        private Label hyper2Label;
        private NumericUpDown backupHyperdrive;
        private NumericUpDown fighterCapacity;
        private Label fighterNumLabel;
        private NumericUpDown troopCapacity;
        private Label infRegNumLabel;
        private NumericUpDown ionCannonTotalFirePower;
        private NumericUpDown laserCannonTotalFirePower;
        private NumericUpDown turbolaserTotalFirePower;
        private NumericUpDown totalFirePower;
        private NumericUpDown capitalShipId;
        private Label label1;
        private Label familyIdHexLabel;
        private Label capitalShipIdHexLabel;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapitalShipsForm));
            this.Open = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.RichTextBox();
            this.name = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.textStraDllId = new System.Windows.Forms.NumericUpDown();
            this.unkown3Label = new System.Windows.Forms.Label();
            this.field7_2 = new System.Windows.Forms.NumericUpDown();
            this.familyId = new System.Windows.Forms.NumericUpDown();
            this.familyLabel = new System.Windows.Forms.Label();
            this.nextProductionFacility = new System.Windows.Forms.NumericUpDown();
            this.secProdFacNumlabel = new System.Windows.Forms.Label();
            this.prodLabel = new System.Windows.Forms.Label();
            this.productionFacility = new System.Windows.Forms.NumericUpDown();
            this.moraleModifier = new System.Windows.Forms.NumericUpDown();
            this.UnkownMoralHPlabel = new System.Windows.Forms.Label();
            this.researchDifficulty = new System.Windows.Forms.NumericUpDown();
            this.resDiffLabel = new System.Windows.Forms.Label();
            this.isEmpireUnit = new System.Windows.Forms.CheckBox();
            this.isAllianceUnit = new System.Windows.Forms.CheckBox();
            this.selector = new System.Windows.Forms.TrackBar();
            this.DetectionLabel = new System.Windows.Forms.Label();
            this.detectionRating = new System.Windows.Forms.NumericUpDown();
            this.researchLabel = new System.Windows.Forms.Label();
            this.researchOrder = new System.Windows.Forms.NumericUpDown();
            this.maintenanceCost = new System.Windows.Forms.NumericUpDown();
            this.maintCostLabel = new System.Windows.Forms.Label();
            this.refinedMaterialCost = new System.Windows.Forms.NumericUpDown();
            this.conCostLabel = new System.Windows.Forms.Label();
            this.bombardmentDefense = new System.Windows.Forms.NumericUpDown();
            this.weaponsRecharge = new System.Windows.Forms.NumericUpDown();
            this.bombardLabel = new System.Windows.Forms.Label();
            this.wepRechLabel = new System.Windows.Forms.Label();
            this.gravWell2Label = new System.Windows.Forms.Label();
            this.gravWell1Label = new System.Windows.Forms.Label();
            this.interdictionStrength = new System.Windows.Forms.NumericUpDown();
            this.gravityWellProjectors = new System.Windows.Forms.NumericUpDown();
            this.tractorBeamRange = new System.Windows.Forms.NumericUpDown();
            this.tractorBeamStrength = new System.Windows.Forms.NumericUpDown();
            this.attackStrengthGroup = new System.Windows.Forms.GroupBox();
            this.laserCannonStarboard = new System.Windows.Forms.NumericUpDown();
            this.laserCannonPort = new System.Windows.Forms.NumericUpDown();
            this.laserCannonAft = new System.Windows.Forms.NumericUpDown();
            this.ionCannonStarboard = new System.Windows.Forms.NumericUpDown();
            this.ionCannonPort = new System.Windows.Forms.NumericUpDown();
            this.ionCannonAft = new System.Windows.Forms.NumericUpDown();
            this.ionCannonFore = new System.Windows.Forms.NumericUpDown();
            this.laserCannonFore = new System.Windows.Forms.NumericUpDown();
            this.wepLaserLabel = new System.Windows.Forms.Label();
            this.wepIonLabel = new System.Windows.Forms.Label();
            this.wepTurboLabel = new System.Windows.Forms.Label();
            this.turbolaserStarboard = new System.Windows.Forms.NumericUpDown();
            this.turbolaserPort = new System.Windows.Forms.NumericUpDown();
            this.turbolaserAft = new System.Windows.Forms.NumericUpDown();
            this.turbolaserFore = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.wepPortLabel = new System.Windows.Forms.Label();
            this.wepAftLabel = new System.Windows.Forms.Label();
            this.wepForeLabel = new System.Windows.Forms.Label();
            this.laserCannonRange = new System.Windows.Forms.NumericUpDown();
            this.ionCannonRange = new System.Windows.Forms.NumericUpDown();
            this.turbolaserRange = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.familyIdHexLabel = new System.Windows.Forms.Label();
            this.capitalShipIdHexLabel = new System.Windows.Forms.Label();
            this.capitalShipId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.totalFirePower = new System.Windows.Forms.NumericUpDown();
            this.ionCannonTotalFirePower = new System.Windows.Forms.NumericUpDown();
            this.laserCannonTotalFirePower = new System.Windows.Forms.NumericUpDown();
            this.turbolaserTotalFirePower = new System.Windows.Forms.NumericUpDown();
            this.costsGroup = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.infRegNumLabel = new System.Windows.Forms.Label();
            this.troopCapacity = new System.Windows.Forms.NumericUpDown();
            this.shieldLabel = new System.Windows.Forms.Label();
            this.shieldStrength = new System.Windows.Forms.NumericUpDown();
            this.fighterCapacity = new System.Windows.Forms.NumericUpDown();
            this.fighterNumLabel = new System.Windows.Forms.Label();
            this.shieldRechargeRate = new System.Windows.Forms.NumericUpDown();
            this.shieldRechLabel = new System.Windows.Forms.Label();
            this.damageConLabel = new System.Windows.Forms.Label();
            this.damageControl = new System.Windows.Forms.NumericUpDown();
            this.hullLabel = new System.Windows.Forms.Label();
            this.hullStrength = new System.Windows.Forms.NumericUpDown();
            this.manuverLabel = new System.Windows.Forms.Label();
            this.sublightManoeuvrability = new System.Windows.Forms.NumericUpDown();
            this.sublightLabel = new System.Windows.Forms.Label();
            this.sublightSpeed = new System.Windows.Forms.NumericUpDown();
            this.primaryHyperdrive = new System.Windows.Forms.NumericUpDown();
            this.hyper2Label = new System.Windows.Forms.Label();
            this.backupHyperdrive = new System.Windows.Forms.NumericUpDown();
            this.picture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.field51_0 = new System.Windows.Forms.NumericUpDown();
            this.field2_1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moraleModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectionRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refinedMaterialCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardmentDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponsRecharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interdictionStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravityWellProjectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractorBeamRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractorBeamStrength)).BeginInit();
            this.attackStrengthGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonStarboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonAft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonStarboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonAft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonFore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonFore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserStarboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserAft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserFore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitalShipId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalFirePower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonTotalFirePower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonTotalFirePower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserTotalFirePower)).BeginInit();
            this.costsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.troopCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fighterCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldRechargeRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hullStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sublightManoeuvrability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sublightSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primaryHyperdrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupHyperdrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field51_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2_1)).BeginInit();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(307, 493);
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
            this.SaveAs.Location = new System.Drawing.Point(215, 493);
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
            this.Cancel.Location = new System.Drawing.Point(124, 493);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 27);
            this.Cancel.TabIndex = 39;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(33, 493);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(88, 27);
            this.Ok.TabIndex = 38;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // description
            // 
            this.description.Cursor = System.Windows.Forms.Cursors.No;
            this.description.Enabled = false;
            this.description.Location = new System.Drawing.Point(8, 144);
            this.description.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(565, 65);
            this.description.TabIndex = 0;
            this.description.TabStop = false;
            this.description.Text = "Not Implemented yet....Encylopedia Data...Will add .Someday";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(226, 15);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(120, 15);
            this.name.TabIndex = 0;
            this.name.Text = "CAPITAL SHIP NAME";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(471, 488);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(85, 15);
            this.idLabel.TabIndex = 106;
            this.idLabel.Text = "TextStra.DLL ID";
            // 
            // textStraDllId
            // 
            this.textStraDllId.Location = new System.Drawing.Point(617, 488);
            this.textStraDllId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textStraDllId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.textStraDllId.Name = "textStraDllId";
            this.textStraDllId.Size = new System.Drawing.Size(59, 23);
            this.textStraDllId.TabIndex = 112;
            this.textStraDllId.TabStop = false;
            this.textStraDllId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // unkown3Label
            // 
            this.unkown3Label.AutoSize = true;
            this.unkown3Label.Location = new System.Drawing.Point(248, 464);
            this.unkown3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unkown3Label.Name = "unkown3Label";
            this.unkown3Label.Size = new System.Drawing.Size(49, 15);
            this.unkown3Label.TabIndex = 109;
            this.unkown3Label.Text = "Field7_2";
            // 
            // field7_2
            // 
            this.field7_2.Location = new System.Drawing.Point(381, 462);
            this.field7_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.field7_2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.field7_2.Name = "field7_2";
            this.field7_2.Size = new System.Drawing.Size(59, 23);
            this.field7_2.TabIndex = 110;
            this.field7_2.TabStop = false;
            this.field7_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.field7_2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.field7_2.ValueChanged += new System.EventHandler(this.field7_2_ValueChanged);
            // 
            // familyId
            // 
            this.familyId.BackColor = System.Drawing.SystemColors.Window;
            this.familyId.Location = new System.Drawing.Point(617, 337);
            this.familyId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.familyId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.familyId.Name = "familyId";
            this.familyId.Size = new System.Drawing.Size(59, 23);
            this.familyId.TabIndex = 111;
            this.familyId.TabStop = false;
            this.familyId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.familyId.ValueChanged += new System.EventHandler(this.familyId_ValueChanged);
            // 
            // familyLabel
            // 
            this.familyLabel.AutoSize = true;
            this.familyLabel.Location = new System.Drawing.Point(471, 339);
            this.familyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyLabel.Name = "familyLabel";
            this.familyLabel.Size = new System.Drawing.Size(56, 15);
            this.familyLabel.TabIndex = 104;
            this.familyLabel.Text = "Family ID";
            // 
            // nextProductionFacility
            // 
            this.nextProductionFacility.BackColor = System.Drawing.SystemColors.Window;
            this.nextProductionFacility.Location = new System.Drawing.Point(661, 91);
            this.nextProductionFacility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextProductionFacility.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nextProductionFacility.Name = "nextProductionFacility";
            this.nextProductionFacility.Size = new System.Drawing.Size(59, 23);
            this.nextProductionFacility.TabIndex = 96;
            this.nextProductionFacility.TabStop = false;
            this.nextProductionFacility.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nextProductionFacility.ValueChanged += new System.EventHandler(this.nextProductionFacility_ValueChanged);
            // 
            // secProdFacNumlabel
            // 
            this.secProdFacNumlabel.AutoSize = true;
            this.secProdFacNumlabel.Enabled = false;
            this.secProdFacNumlabel.Location = new System.Drawing.Point(527, 93);
            this.secProdFacNumlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secProdFacNumlabel.Name = "secProdFacNumlabel";
            this.secProdFacNumlabel.Size = new System.Drawing.Size(123, 15);
            this.secProdFacNumlabel.TabIndex = 97;
            this.secProdFacNumlabel.Text = "Production Facility +1";
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.Enabled = false;
            this.prodLabel.Location = new System.Drawing.Point(527, 68);
            this.prodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(106, 15);
            this.prodLabel.TabIndex = 95;
            this.prodLabel.Text = "Production Facility";
            // 
            // productionFacility
            // 
            this.productionFacility.BackColor = System.Drawing.SystemColors.Window;
            this.productionFacility.Location = new System.Drawing.Point(661, 66);
            this.productionFacility.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productionFacility.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.productionFacility.Name = "productionFacility";
            this.productionFacility.Size = new System.Drawing.Size(59, 23);
            this.productionFacility.TabIndex = 93;
            this.productionFacility.TabStop = false;
            this.productionFacility.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.productionFacility.ValueChanged += new System.EventHandler(this.productionFacility_ValueChanged);
            // 
            // moraleModifier
            // 
            this.moraleModifier.BackColor = System.Drawing.SystemColors.Window;
            this.moraleModifier.Location = new System.Drawing.Point(381, 437);
            this.moraleModifier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.moraleModifier.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.moraleModifier.Name = "moraleModifier";
            this.moraleModifier.Size = new System.Drawing.Size(59, 23);
            this.moraleModifier.TabIndex = 125;
            this.moraleModifier.TabStop = false;
            this.moraleModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.moraleModifier.ValueChanged += new System.EventHandler(this.moraleModifier_ValueChanged);
            // 
            // UnkownMoralHPlabel
            // 
            this.UnkownMoralHPlabel.AutoSize = true;
            this.UnkownMoralHPlabel.Location = new System.Drawing.Point(248, 439);
            this.UnkownMoralHPlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnkownMoralHPlabel.Name = "UnkownMoralHPlabel";
            this.UnkownMoralHPlabel.Size = new System.Drawing.Size(92, 15);
            this.UnkownMoralHPlabel.TabIndex = 94;
            this.UnkownMoralHPlabel.Text = "Morale Modifier";
            // 
            // researchDifficulty
            // 
            this.researchDifficulty.Location = new System.Drawing.Point(661, 41);
            this.researchDifficulty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchDifficulty.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.researchDifficulty.Name = "researchDifficulty";
            this.researchDifficulty.Size = new System.Drawing.Size(59, 23);
            this.researchDifficulty.TabIndex = 8;
            this.researchDifficulty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.researchDifficulty.ValueChanged += new System.EventHandler(this.researchDifficulty_ValueChanged);
            // 
            // resDiffLabel
            // 
            this.resDiffLabel.AutoSize = true;
            this.resDiffLabel.Location = new System.Drawing.Point(527, 43);
            this.resDiffLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resDiffLabel.Name = "resDiffLabel";
            this.resDiffLabel.Size = new System.Drawing.Size(105, 15);
            this.resDiffLabel.TabIndex = 0;
            this.resDiffLabel.Text = "Research Difficulty";
            // 
            // isEmpireUnit
            // 
            this.isEmpireUnit.AutoSize = true;
            this.isEmpireUnit.Location = new System.Drawing.Point(395, 66);
            this.isEmpireUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isEmpireUnit.Name = "isEmpireUnit";
            this.isEmpireUnit.Size = new System.Drawing.Size(63, 19);
            this.isEmpireUnit.TabIndex = 16;
            this.isEmpireUnit.Text = "Empire";
            this.isEmpireUnit.UseVisualStyleBackColor = true;
            this.isEmpireUnit.CheckedChanged += new System.EventHandler(this.isEmpireUnit_CheckedChanged);
            // 
            // isAllianceUnit
            // 
            this.isAllianceUnit.AutoSize = true;
            this.isAllianceUnit.Location = new System.Drawing.Point(395, 44);
            this.isAllianceUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isAllianceUnit.Name = "isAllianceUnit";
            this.isAllianceUnit.Size = new System.Drawing.Size(68, 19);
            this.isAllianceUnit.TabIndex = 15;
            this.isAllianceUnit.Text = "Alliance";
            this.isAllianceUnit.UseVisualStyleBackColor = true;
            this.isAllianceUnit.CheckedChanged += new System.EventHandler(this.isAllianceUnit_CheckedChanged);
            // 
            // selector
            // 
            this.selector.LargeChange = 15;
            this.selector.Location = new System.Drawing.Point(220, 66);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selector.Maximum = 29;
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(159, 45);
            this.selector.TabIndex = 1;
            this.selector.ValueChanged += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            // 
            // DetectionLabel
            // 
            this.DetectionLabel.AutoSize = true;
            this.DetectionLabel.Location = new System.Drawing.Point(15, 389);
            this.DetectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DetectionLabel.Name = "DetectionLabel";
            this.DetectionLabel.Size = new System.Drawing.Size(98, 15);
            this.DetectionLabel.TabIndex = 0;
            this.DetectionLabel.Text = "Detection Rating ";
            // 
            // detectionRating
            // 
            this.detectionRating.Location = new System.Drawing.Point(153, 387);
            this.detectionRating.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.detectionRating.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.detectionRating.Name = "detectionRating";
            this.detectionRating.Size = new System.Drawing.Size(59, 23);
            this.detectionRating.TabIndex = 5;
            this.detectionRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.detectionRating.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.detectionRating.ValueChanged += new System.EventHandler(this.detectionRating_ValueChanged);
            // 
            // researchLabel
            // 
            this.researchLabel.AutoSize = true;
            this.researchLabel.Location = new System.Drawing.Point(527, 18);
            this.researchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.researchLabel.Name = "researchLabel";
            this.researchLabel.Size = new System.Drawing.Size(87, 15);
            this.researchLabel.TabIndex = 0;
            this.researchLabel.Text = "Research Order";
            // 
            // researchOrder
            // 
            this.researchOrder.Location = new System.Drawing.Point(661, 16);
            this.researchOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.researchOrder.Name = "researchOrder";
            this.researchOrder.Size = new System.Drawing.Size(59, 23);
            this.researchOrder.TabIndex = 7;
            this.researchOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.researchOrder.ValueChanged += new System.EventHandler(this.researchOrder_ValueChanged);
            // 
            // maintenanceCost
            // 
            this.maintenanceCost.Location = new System.Drawing.Point(140, 43);
            this.maintenanceCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maintenanceCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maintenanceCost.Name = "maintenanceCost";
            this.maintenanceCost.Size = new System.Drawing.Size(59, 23);
            this.maintenanceCost.TabIndex = 3;
            this.maintenanceCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maintenanceCost.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maintenanceCost.ValueChanged += new System.EventHandler(this.maintenanceCost_ValueChanged);
            // 
            // maintCostLabel
            // 
            this.maintCostLabel.AutoSize = true;
            this.maintCostLabel.Location = new System.Drawing.Point(10, 47);
            this.maintCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maintCostLabel.Name = "maintCostLabel";
            this.maintCostLabel.Size = new System.Drawing.Size(103, 15);
            this.maintCostLabel.TabIndex = 0;
            this.maintCostLabel.Text = "Maintenance Cost";
            // 
            // refinedMaterialCost
            // 
            this.refinedMaterialCost.Location = new System.Drawing.Point(140, 18);
            this.refinedMaterialCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.refinedMaterialCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.refinedMaterialCost.Name = "refinedMaterialCost";
            this.refinedMaterialCost.Size = new System.Drawing.Size(59, 23);
            this.refinedMaterialCost.TabIndex = 2;
            this.refinedMaterialCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.refinedMaterialCost.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.refinedMaterialCost.ValueChanged += new System.EventHandler(this.refinedMaterialCost_ValueChanged);
            // 
            // conCostLabel
            // 
            this.conCostLabel.AutoSize = true;
            this.conCostLabel.Location = new System.Drawing.Point(9, 22);
            this.conCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conCostLabel.Name = "conCostLabel";
            this.conCostLabel.Size = new System.Drawing.Size(120, 15);
            this.conCostLabel.TabIndex = 0;
            this.conCostLabel.Text = "Refined Material Cost";
            // 
            // bombardmentDefense
            // 
            this.bombardmentDefense.Location = new System.Drawing.Point(153, 437);
            this.bombardmentDefense.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bombardmentDefense.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bombardmentDefense.Name = "bombardmentDefense";
            this.bombardmentDefense.Size = new System.Drawing.Size(59, 23);
            this.bombardmentDefense.TabIndex = 37;
            this.bombardmentDefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bombardmentDefense.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bombardmentDefense.ValueChanged += new System.EventHandler(this.bombardmentDefense_ValueChanged);
            // 
            // weaponsRecharge
            // 
            this.weaponsRecharge.Location = new System.Drawing.Point(662, 264);
            this.weaponsRecharge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.weaponsRecharge.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.weaponsRecharge.Name = "weaponsRecharge";
            this.weaponsRecharge.Size = new System.Drawing.Size(59, 23);
            this.weaponsRecharge.TabIndex = 36;
            this.weaponsRecharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.weaponsRecharge.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.weaponsRecharge.ValueChanged += new System.EventHandler(this.weaponsRecharge_ValueChanged);
            // 
            // bombardLabel
            // 
            this.bombardLabel.AutoSize = true;
            this.bombardLabel.BackColor = System.Drawing.SystemColors.Control;
            this.bombardLabel.Location = new System.Drawing.Point(15, 439);
            this.bombardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bombardLabel.Name = "bombardLabel";
            this.bombardLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bombardLabel.Size = new System.Drawing.Size(129, 15);
            this.bombardLabel.TabIndex = 0;
            this.bombardLabel.Text = "Bombardment Defense";
            this.bombardLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wepRechLabel
            // 
            this.wepRechLabel.AutoSize = true;
            this.wepRechLabel.BackColor = System.Drawing.SystemColors.Control;
            this.wepRechLabel.Location = new System.Drawing.Point(598, 267);
            this.wepRechLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wepRechLabel.Name = "wepRechLabel";
            this.wepRechLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wepRechLabel.Size = new System.Drawing.Size(56, 15);
            this.wepRechLabel.TabIndex = 0;
            this.wepRechLabel.Text = "Recharge";
            this.wepRechLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gravWell2Label
            // 
            this.gravWell2Label.AutoSize = true;
            this.gravWell2Label.BackColor = System.Drawing.SystemColors.Control;
            this.gravWell2Label.Location = new System.Drawing.Point(248, 414);
            this.gravWell2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gravWell2Label.Name = "gravWell2Label";
            this.gravWell2Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gravWell2Label.Size = new System.Drawing.Size(116, 15);
            this.gravWell2Label.TabIndex = 0;
            this.gravWell2Label.Text = "Interdiction Strength";
            this.gravWell2Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gravWell1Label
            // 
            this.gravWell1Label.AutoSize = true;
            this.gravWell1Label.BackColor = System.Drawing.SystemColors.Control;
            this.gravWell1Label.Location = new System.Drawing.Point(248, 389);
            this.gravWell1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gravWell1Label.Name = "gravWell1Label";
            this.gravWell1Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gravWell1Label.Size = new System.Drawing.Size(126, 15);
            this.gravWell1Label.TabIndex = 0;
            this.gravWell1Label.Text = "Gravity Well Projectors";
            this.gravWell1Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // interdictionStrength
            // 
            this.interdictionStrength.BackColor = System.Drawing.SystemColors.Window;
            this.interdictionStrength.Location = new System.Drawing.Point(381, 412);
            this.interdictionStrength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.interdictionStrength.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.interdictionStrength.Name = "interdictionStrength";
            this.interdictionStrength.Size = new System.Drawing.Size(59, 23);
            this.interdictionStrength.TabIndex = 0;
            this.interdictionStrength.TabStop = false;
            this.interdictionStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.interdictionStrength.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.interdictionStrength.ValueChanged += new System.EventHandler(this.interdictionStrength_ValueChanged);
            // 
            // gravityWellProjectors
            // 
            this.gravityWellProjectors.BackColor = System.Drawing.SystemColors.Window;
            this.gravityWellProjectors.Location = new System.Drawing.Point(381, 387);
            this.gravityWellProjectors.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gravityWellProjectors.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.gravityWellProjectors.Name = "gravityWellProjectors";
            this.gravityWellProjectors.Size = new System.Drawing.Size(59, 23);
            this.gravityWellProjectors.TabIndex = 0;
            this.gravityWellProjectors.TabStop = false;
            this.gravityWellProjectors.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gravityWellProjectors.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.gravityWellProjectors.ValueChanged += new System.EventHandler(this.gravityWellProjectors_ValueChanged);
            // 
            // tractorBeamRange
            // 
            this.tractorBeamRange.Location = new System.Drawing.Point(381, 362);
            this.tractorBeamRange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tractorBeamRange.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.tractorBeamRange.Name = "tractorBeamRange";
            this.tractorBeamRange.Size = new System.Drawing.Size(59, 23);
            this.tractorBeamRange.TabIndex = 35;
            this.tractorBeamRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tractorBeamRange.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.tractorBeamRange.ValueChanged += new System.EventHandler(this.tractorBeamRange_ValueChanged);
            // 
            // tractorBeamStrength
            // 
            this.tractorBeamStrength.Location = new System.Drawing.Point(381, 337);
            this.tractorBeamStrength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tractorBeamStrength.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.tractorBeamStrength.Name = "tractorBeamStrength";
            this.tractorBeamStrength.Size = new System.Drawing.Size(59, 23);
            this.tractorBeamStrength.TabIndex = 34;
            this.tractorBeamStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tractorBeamStrength.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.tractorBeamStrength.ValueChanged += new System.EventHandler(this.tractorBeamStrength_ValueChanged);
            // 
            // attackStrengthGroup
            // 
            this.attackStrengthGroup.Controls.Add(this.laserCannonStarboard);
            this.attackStrengthGroup.Controls.Add(this.laserCannonPort);
            this.attackStrengthGroup.Controls.Add(this.laserCannonAft);
            this.attackStrengthGroup.Controls.Add(this.ionCannonStarboard);
            this.attackStrengthGroup.Controls.Add(this.ionCannonPort);
            this.attackStrengthGroup.Controls.Add(this.ionCannonAft);
            this.attackStrengthGroup.Controls.Add(this.ionCannonFore);
            this.attackStrengthGroup.Controls.Add(this.laserCannonFore);
            this.attackStrengthGroup.Controls.Add(this.wepLaserLabel);
            this.attackStrengthGroup.Controls.Add(this.wepIonLabel);
            this.attackStrengthGroup.Controls.Add(this.wepTurboLabel);
            this.attackStrengthGroup.Controls.Add(this.turbolaserStarboard);
            this.attackStrengthGroup.Controls.Add(this.turbolaserPort);
            this.attackStrengthGroup.Controls.Add(this.turbolaserAft);
            this.attackStrengthGroup.Controls.Add(this.turbolaserFore);
            this.attackStrengthGroup.Controls.Add(this.label5);
            this.attackStrengthGroup.Controls.Add(this.wepPortLabel);
            this.attackStrengthGroup.Controls.Add(this.wepAftLabel);
            this.attackStrengthGroup.Controls.Add(this.wepForeLabel);
            this.attackStrengthGroup.Location = new System.Drawing.Point(213, 14);
            this.attackStrengthGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.attackStrengthGroup.Name = "attackStrengthGroup";
            this.attackStrengthGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.attackStrengthGroup.Size = new System.Drawing.Size(360, 112);
            this.attackStrengthGroup.TabIndex = 10;
            this.attackStrengthGroup.TabStop = false;
            this.attackStrengthGroup.Text = "Attack Strength";
            // 
            // laserCannonStarboard
            // 
            this.laserCannonStarboard.Location = new System.Drawing.Point(291, 83);
            this.laserCannonStarboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.laserCannonStarboard.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonStarboard.Name = "laserCannonStarboard";
            this.laserCannonStarboard.Size = new System.Drawing.Size(59, 23);
            this.laserCannonStarboard.TabIndex = 30;
            this.laserCannonStarboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.laserCannonStarboard.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonStarboard.ValueChanged += new System.EventHandler(this.laserCannonStarboard_ValueChanged);
            // 
            // laserCannonPort
            // 
            this.laserCannonPort.Location = new System.Drawing.Point(224, 83);
            this.laserCannonPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.laserCannonPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonPort.Name = "laserCannonPort";
            this.laserCannonPort.Size = new System.Drawing.Size(59, 23);
            this.laserCannonPort.TabIndex = 27;
            this.laserCannonPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.laserCannonPort.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonPort.ValueChanged += new System.EventHandler(this.laserCannonPort_ValueChanged);
            // 
            // laserCannonAft
            // 
            this.laserCannonAft.Location = new System.Drawing.Point(158, 83);
            this.laserCannonAft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.laserCannonAft.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonAft.Name = "laserCannonAft";
            this.laserCannonAft.Size = new System.Drawing.Size(59, 23);
            this.laserCannonAft.TabIndex = 24;
            this.laserCannonAft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.laserCannonAft.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonAft.ValueChanged += new System.EventHandler(this.laserCannonAft_ValueChanged);
            // 
            // ionCannonStarboard
            // 
            this.ionCannonStarboard.Location = new System.Drawing.Point(291, 58);
            this.ionCannonStarboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ionCannonStarboard.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonStarboard.Name = "ionCannonStarboard";
            this.ionCannonStarboard.Size = new System.Drawing.Size(59, 23);
            this.ionCannonStarboard.TabIndex = 29;
            this.ionCannonStarboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ionCannonStarboard.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonStarboard.ValueChanged += new System.EventHandler(this.ionCannonStarboard_ValueChanged);
            // 
            // ionCannonPort
            // 
            this.ionCannonPort.Location = new System.Drawing.Point(224, 58);
            this.ionCannonPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ionCannonPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonPort.Name = "ionCannonPort";
            this.ionCannonPort.Size = new System.Drawing.Size(59, 23);
            this.ionCannonPort.TabIndex = 26;
            this.ionCannonPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ionCannonPort.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonPort.ValueChanged += new System.EventHandler(this.ionCannonPort_ValueChanged);
            // 
            // ionCannonAft
            // 
            this.ionCannonAft.Location = new System.Drawing.Point(158, 58);
            this.ionCannonAft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ionCannonAft.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonAft.Name = "ionCannonAft";
            this.ionCannonAft.Size = new System.Drawing.Size(59, 23);
            this.ionCannonAft.TabIndex = 23;
            this.ionCannonAft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ionCannonAft.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonAft.ValueChanged += new System.EventHandler(this.ionCannonAft_ValueChanged);
            // 
            // ionCannonFore
            // 
            this.ionCannonFore.Location = new System.Drawing.Point(91, 58);
            this.ionCannonFore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ionCannonFore.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonFore.Name = "ionCannonFore";
            this.ionCannonFore.Size = new System.Drawing.Size(59, 23);
            this.ionCannonFore.TabIndex = 20;
            this.ionCannonFore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ionCannonFore.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonFore.ValueChanged += new System.EventHandler(this.ionCannonFore_ValueChanged);
            // 
            // laserCannonFore
            // 
            this.laserCannonFore.Location = new System.Drawing.Point(91, 83);
            this.laserCannonFore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.laserCannonFore.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonFore.Name = "laserCannonFore";
            this.laserCannonFore.Size = new System.Drawing.Size(59, 23);
            this.laserCannonFore.TabIndex = 21;
            this.laserCannonFore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.laserCannonFore.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonFore.ValueChanged += new System.EventHandler(this.laserCannonFore_ValueChanged);
            // 
            // wepLaserLabel
            // 
            this.wepLaserLabel.AutoSize = true;
            this.wepLaserLabel.BackColor = System.Drawing.SystemColors.Control;
            this.wepLaserLabel.Location = new System.Drawing.Point(7, 85);
            this.wepLaserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wepLaserLabel.Name = "wepLaserLabel";
            this.wepLaserLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wepLaserLabel.Size = new System.Drawing.Size(79, 15);
            this.wepLaserLabel.TabIndex = 0;
            this.wepLaserLabel.Text = "Laser Cannon";
            this.wepLaserLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wepIonLabel
            // 
            this.wepIonLabel.AutoSize = true;
            this.wepIonLabel.BackColor = System.Drawing.SystemColors.Control;
            this.wepIonLabel.Location = new System.Drawing.Point(7, 60);
            this.wepIonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wepIonLabel.Name = "wepIonLabel";
            this.wepIonLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wepIonLabel.Size = new System.Drawing.Size(69, 15);
            this.wepIonLabel.TabIndex = 0;
            this.wepIonLabel.Text = "Ion Cannon";
            this.wepIonLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wepTurboLabel
            // 
            this.wepTurboLabel.AutoSize = true;
            this.wepTurboLabel.BackColor = System.Drawing.SystemColors.Control;
            this.wepTurboLabel.Location = new System.Drawing.Point(6, 35);
            this.wepTurboLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wepTurboLabel.Name = "wepTurboLabel";
            this.wepTurboLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wepTurboLabel.Size = new System.Drawing.Size(62, 15);
            this.wepTurboLabel.TabIndex = 0;
            this.wepTurboLabel.Text = "Turbolaser";
            this.wepTurboLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // turbolaserStarboard
            // 
            this.turbolaserStarboard.Location = new System.Drawing.Point(291, 33);
            this.turbolaserStarboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turbolaserStarboard.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserStarboard.Name = "turbolaserStarboard";
            this.turbolaserStarboard.Size = new System.Drawing.Size(59, 23);
            this.turbolaserStarboard.TabIndex = 28;
            this.turbolaserStarboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.turbolaserStarboard.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserStarboard.ValueChanged += new System.EventHandler(this.turbolaserStarboard_ValueChanged);
            // 
            // turbolaserPort
            // 
            this.turbolaserPort.Location = new System.Drawing.Point(224, 33);
            this.turbolaserPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turbolaserPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserPort.Name = "turbolaserPort";
            this.turbolaserPort.Size = new System.Drawing.Size(59, 23);
            this.turbolaserPort.TabIndex = 25;
            this.turbolaserPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.turbolaserPort.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserPort.ValueChanged += new System.EventHandler(this.turbolaserPort_ValueChanged);
            // 
            // turbolaserAft
            // 
            this.turbolaserAft.Location = new System.Drawing.Point(158, 33);
            this.turbolaserAft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turbolaserAft.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserAft.Name = "turbolaserAft";
            this.turbolaserAft.Size = new System.Drawing.Size(59, 23);
            this.turbolaserAft.TabIndex = 22;
            this.turbolaserAft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.turbolaserAft.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserAft.ValueChanged += new System.EventHandler(this.turbolaserAft_ValueChanged);
            // 
            // turbolaserFore
            // 
            this.turbolaserFore.Location = new System.Drawing.Point(91, 33);
            this.turbolaserFore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turbolaserFore.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserFore.Name = "turbolaserFore";
            this.turbolaserFore.Size = new System.Drawing.Size(59, 23);
            this.turbolaserFore.TabIndex = 19;
            this.turbolaserFore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.turbolaserFore.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserFore.ValueChanged += new System.EventHandler(this.turbolaserFore_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(291, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Starboard";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wepPortLabel
            // 
            this.wepPortLabel.AutoSize = true;
            this.wepPortLabel.BackColor = System.Drawing.SystemColors.Control;
            this.wepPortLabel.Location = new System.Drawing.Point(224, 16);
            this.wepPortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wepPortLabel.Name = "wepPortLabel";
            this.wepPortLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wepPortLabel.Size = new System.Drawing.Size(29, 15);
            this.wepPortLabel.TabIndex = 0;
            this.wepPortLabel.Text = "Port";
            this.wepPortLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wepAftLabel
            // 
            this.wepAftLabel.AutoSize = true;
            this.wepAftLabel.BackColor = System.Drawing.SystemColors.Control;
            this.wepAftLabel.Location = new System.Drawing.Point(158, 16);
            this.wepAftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wepAftLabel.Name = "wepAftLabel";
            this.wepAftLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wepAftLabel.Size = new System.Drawing.Size(23, 15);
            this.wepAftLabel.TabIndex = 0;
            this.wepAftLabel.Text = "Aft";
            this.wepAftLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wepForeLabel
            // 
            this.wepForeLabel.AutoSize = true;
            this.wepForeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.wepForeLabel.Location = new System.Drawing.Point(91, 16);
            this.wepForeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wepForeLabel.Name = "wepForeLabel";
            this.wepForeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wepForeLabel.Size = new System.Drawing.Size(30, 15);
            this.wepForeLabel.TabIndex = 0;
            this.wepForeLabel.Text = "Fore";
            this.wepForeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // laserCannonRange
            // 
            this.laserCannonRange.Location = new System.Drawing.Point(595, 214);
            this.laserCannonRange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.laserCannonRange.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonRange.Name = "laserCannonRange";
            this.laserCannonRange.Size = new System.Drawing.Size(59, 23);
            this.laserCannonRange.TabIndex = 33;
            this.laserCannonRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.laserCannonRange.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonRange.ValueChanged += new System.EventHandler(this.laserCannonRange_ValueChanged);
            // 
            // ionCannonRange
            // 
            this.ionCannonRange.Location = new System.Drawing.Point(595, 189);
            this.ionCannonRange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ionCannonRange.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonRange.Name = "ionCannonRange";
            this.ionCannonRange.Size = new System.Drawing.Size(59, 23);
            this.ionCannonRange.TabIndex = 32;
            this.ionCannonRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ionCannonRange.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonRange.ValueChanged += new System.EventHandler(this.ionCannonRange_ValueChanged);
            // 
            // turbolaserRange
            // 
            this.turbolaserRange.Location = new System.Drawing.Point(595, 164);
            this.turbolaserRange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turbolaserRange.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserRange.Name = "turbolaserRange";
            this.turbolaserRange.Size = new System.Drawing.Size(59, 23);
            this.turbolaserRange.TabIndex = 31;
            this.turbolaserRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.turbolaserRange.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserRange.ValueChanged += new System.EventHandler(this.turbolaserRange_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(595, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Range";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // familyIdHexLabel
            // 
            this.familyIdHexLabel.AutoSize = true;
            this.familyIdHexLabel.Enabled = false;
            this.familyIdHexLabel.Location = new System.Drawing.Point(686, 339);
            this.familyIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familyIdHexLabel.Name = "familyIdHexLabel";
            this.familyIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.familyIdHexLabel.TabIndex = 1115;
            this.familyIdHexLabel.Text = "hex";
            // 
            // capitalShipIdHexLabel
            // 
            this.capitalShipIdHexLabel.AutoSize = true;
            this.capitalShipIdHexLabel.Enabled = false;
            this.capitalShipIdHexLabel.Location = new System.Drawing.Point(321, 41);
            this.capitalShipIdHexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.capitalShipIdHexLabel.Name = "capitalShipIdHexLabel";
            this.capitalShipIdHexLabel.Size = new System.Drawing.Size(26, 15);
            this.capitalShipIdHexLabel.TabIndex = 1114;
            this.capitalShipIdHexLabel.Text = "hex";
            // 
            // capitalShipId
            // 
            this.capitalShipId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.capitalShipId.Enabled = false;
            this.capitalShipId.Location = new System.Drawing.Point(252, 39);
            this.capitalShipId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.capitalShipId.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.capitalShipId.Name = "capitalShipId";
            this.capitalShipId.Size = new System.Drawing.Size(59, 23);
            this.capitalShipId.TabIndex = 1113;
            this.capitalShipId.TabStop = false;
            this.capitalShipId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(227, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 1112;
            this.label1.Text = "Id";
            // 
            // totalFirePower
            // 
            this.totalFirePower.BackColor = System.Drawing.SystemColors.Menu;
            this.totalFirePower.Enabled = false;
            this.totalFirePower.Location = new System.Drawing.Point(662, 239);
            this.totalFirePower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.totalFirePower.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.totalFirePower.Name = "totalFirePower";
            this.totalFirePower.Size = new System.Drawing.Size(59, 23);
            this.totalFirePower.TabIndex = 152;
            this.totalFirePower.TabStop = false;
            this.totalFirePower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalFirePower.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // ionCannonTotalFirePower
            // 
            this.ionCannonTotalFirePower.BackColor = System.Drawing.SystemColors.Menu;
            this.ionCannonTotalFirePower.Enabled = false;
            this.ionCannonTotalFirePower.Location = new System.Drawing.Point(662, 189);
            this.ionCannonTotalFirePower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ionCannonTotalFirePower.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ionCannonTotalFirePower.Name = "ionCannonTotalFirePower";
            this.ionCannonTotalFirePower.Size = new System.Drawing.Size(59, 23);
            this.ionCannonTotalFirePower.TabIndex = 150;
            this.ionCannonTotalFirePower.TabStop = false;
            this.ionCannonTotalFirePower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ionCannonTotalFirePower.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // laserCannonTotalFirePower
            // 
            this.laserCannonTotalFirePower.BackColor = System.Drawing.SystemColors.Menu;
            this.laserCannonTotalFirePower.Enabled = false;
            this.laserCannonTotalFirePower.Location = new System.Drawing.Point(662, 214);
            this.laserCannonTotalFirePower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.laserCannonTotalFirePower.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.laserCannonTotalFirePower.Name = "laserCannonTotalFirePower";
            this.laserCannonTotalFirePower.Size = new System.Drawing.Size(59, 23);
            this.laserCannonTotalFirePower.TabIndex = 149;
            this.laserCannonTotalFirePower.TabStop = false;
            this.laserCannonTotalFirePower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.laserCannonTotalFirePower.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // turbolaserTotalFirePower
            // 
            this.turbolaserTotalFirePower.BackColor = System.Drawing.SystemColors.Menu;
            this.turbolaserTotalFirePower.Enabled = false;
            this.turbolaserTotalFirePower.Location = new System.Drawing.Point(662, 164);
            this.turbolaserTotalFirePower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.turbolaserTotalFirePower.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turbolaserTotalFirePower.Name = "turbolaserTotalFirePower";
            this.turbolaserTotalFirePower.Size = new System.Drawing.Size(59, 23);
            this.turbolaserTotalFirePower.TabIndex = 145;
            this.turbolaserTotalFirePower.TabStop = false;
            this.turbolaserTotalFirePower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.turbolaserTotalFirePower.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // costsGroup
            // 
            this.costsGroup.Controls.Add(this.label9);
            this.costsGroup.Controls.Add(this.infRegNumLabel);
            this.costsGroup.Controls.Add(this.troopCapacity);
            this.costsGroup.Controls.Add(this.shieldLabel);
            this.costsGroup.Controls.Add(this.attackStrengthGroup);
            this.costsGroup.Controls.Add(this.shieldStrength);
            this.costsGroup.Controls.Add(this.fighterCapacity);
            this.costsGroup.Controls.Add(this.maintenanceCost);
            this.costsGroup.Controls.Add(this.fighterNumLabel);
            this.costsGroup.Controls.Add(this.conCostLabel);
            this.costsGroup.Controls.Add(this.maintCostLabel);
            this.costsGroup.Controls.Add(this.refinedMaterialCost);
            this.costsGroup.Controls.Add(this.description);
            this.costsGroup.Location = new System.Drawing.Point(7, 117);
            this.costsGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.costsGroup.Name = "costsGroup";
            this.costsGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.costsGroup.Size = new System.Drawing.Size(580, 216);
            this.costsGroup.TabIndex = 2;
            this.costsGroup.TabStop = false;
            this.costsGroup.Text = "In Game Data";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(495, 130);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Description";
            // 
            // infRegNumLabel
            // 
            this.infRegNumLabel.AutoSize = true;
            this.infRegNumLabel.Location = new System.Drawing.Point(11, 97);
            this.infRegNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infRegNumLabel.Name = "infRegNumLabel";
            this.infRegNumLabel.Size = new System.Drawing.Size(86, 15);
            this.infRegNumLabel.TabIndex = 0;
            this.infRegNumLabel.Text = "Troop Capacity";
            // 
            // troopCapacity
            // 
            this.troopCapacity.Location = new System.Drawing.Point(140, 93);
            this.troopCapacity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.troopCapacity.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.troopCapacity.Name = "troopCapacity";
            this.troopCapacity.Size = new System.Drawing.Size(59, 23);
            this.troopCapacity.TabIndex = 18;
            this.troopCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.troopCapacity.ValueChanged += new System.EventHandler(this.troopCapacity_ValueChanged);
            // 
            // shieldLabel
            // 
            this.shieldLabel.AutoSize = true;
            this.shieldLabel.Location = new System.Drawing.Point(12, 122);
            this.shieldLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shieldLabel.Name = "shieldLabel";
            this.shieldLabel.Size = new System.Drawing.Size(87, 15);
            this.shieldLabel.TabIndex = 0;
            this.shieldLabel.Text = "Shield Strength";
            // 
            // shieldStrength
            // 
            this.shieldStrength.Location = new System.Drawing.Point(140, 118);
            this.shieldStrength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shieldStrength.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.shieldStrength.Name = "shieldStrength";
            this.shieldStrength.Size = new System.Drawing.Size(59, 23);
            this.shieldStrength.TabIndex = 13;
            this.shieldStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shieldStrength.ValueChanged += new System.EventHandler(this.shieldStrength_ValueChanged);
            // 
            // fighterCapacity
            // 
            this.fighterCapacity.Location = new System.Drawing.Point(140, 68);
            this.fighterCapacity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fighterCapacity.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fighterCapacity.Name = "fighterCapacity";
            this.fighterCapacity.Size = new System.Drawing.Size(59, 23);
            this.fighterCapacity.TabIndex = 17;
            this.fighterCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fighterCapacity.ValueChanged += new System.EventHandler(this.fighterCapacity_ValueChanged);
            // 
            // fighterNumLabel
            // 
            this.fighterNumLabel.AutoSize = true;
            this.fighterNumLabel.Location = new System.Drawing.Point(10, 72);
            this.fighterNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fighterNumLabel.Name = "fighterNumLabel";
            this.fighterNumLabel.Size = new System.Drawing.Size(93, 15);
            this.fighterNumLabel.TabIndex = 0;
            this.fighterNumLabel.Text = "Fighter Capacity";
            // 
            // shieldRechargeRate
            // 
            this.shieldRechargeRate.Location = new System.Drawing.Point(153, 337);
            this.shieldRechargeRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shieldRechargeRate.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.shieldRechargeRate.Name = "shieldRechargeRate";
            this.shieldRechargeRate.Size = new System.Drawing.Size(59, 23);
            this.shieldRechargeRate.TabIndex = 14;
            this.shieldRechargeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shieldRechargeRate.ValueChanged += new System.EventHandler(this.shieldRechargeRate_ValueChanged);
            // 
            // shieldRechLabel
            // 
            this.shieldRechLabel.AutoSize = true;
            this.shieldRechLabel.Location = new System.Drawing.Point(15, 339);
            this.shieldRechLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shieldRechLabel.Name = "shieldRechLabel";
            this.shieldRechLabel.Size = new System.Drawing.Size(117, 15);
            this.shieldRechLabel.TabIndex = 0;
            this.shieldRechLabel.Text = "Shield Recharge Rate";
            // 
            // damageConLabel
            // 
            this.damageConLabel.AutoSize = true;
            this.damageConLabel.Location = new System.Drawing.Point(15, 414);
            this.damageConLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.damageConLabel.Name = "damageConLabel";
            this.damageConLabel.Size = new System.Drawing.Size(94, 15);
            this.damageConLabel.TabIndex = 0;
            this.damageConLabel.Text = "Damage Control";
            // 
            // damageControl
            // 
            this.damageControl.Location = new System.Drawing.Point(153, 412);
            this.damageControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.damageControl.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.damageControl.Name = "damageControl";
            this.damageControl.Size = new System.Drawing.Size(59, 23);
            this.damageControl.TabIndex = 6;
            this.damageControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.damageControl.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.damageControl.ValueChanged += new System.EventHandler(this.damageControl_ValueChanged);
            // 
            // hullLabel
            // 
            this.hullLabel.AutoSize = true;
            this.hullLabel.Location = new System.Drawing.Point(15, 364);
            this.hullLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hullLabel.Name = "hullLabel";
            this.hullLabel.Size = new System.Drawing.Size(77, 15);
            this.hullLabel.TabIndex = 0;
            this.hullLabel.Text = "Hull Strength";
            // 
            // hullStrength
            // 
            this.hullStrength.Location = new System.Drawing.Point(153, 362);
            this.hullStrength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hullStrength.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.hullStrength.Name = "hullStrength";
            this.hullStrength.Size = new System.Drawing.Size(59, 23);
            this.hullStrength.TabIndex = 4;
            this.hullStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hullStrength.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.hullStrength.ValueChanged += new System.EventHandler(this.hullStrength_ValueChanged);
            // 
            // manuverLabel
            // 
            this.manuverLabel.AutoSize = true;
            this.manuverLabel.Location = new System.Drawing.Point(471, 439);
            this.manuverLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manuverLabel.Name = "manuverLabel";
            this.manuverLabel.Size = new System.Drawing.Size(140, 15);
            this.manuverLabel.TabIndex = 0;
            this.manuverLabel.Text = "Sublight Manoeuvrability";
            // 
            // sublightManoeuvrability
            // 
            this.sublightManoeuvrability.Location = new System.Drawing.Point(617, 437);
            this.sublightManoeuvrability.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sublightManoeuvrability.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sublightManoeuvrability.Name = "sublightManoeuvrability";
            this.sublightManoeuvrability.Size = new System.Drawing.Size(59, 23);
            this.sublightManoeuvrability.TabIndex = 10;
            this.sublightManoeuvrability.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sublightManoeuvrability.ValueChanged += new System.EventHandler(this.sublightManoeuvrability_ValueChanged);
            // 
            // sublightLabel
            // 
            this.sublightLabel.AutoSize = true;
            this.sublightLabel.Location = new System.Drawing.Point(471, 414);
            this.sublightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sublightLabel.Name = "sublightLabel";
            this.sublightLabel.Size = new System.Drawing.Size(86, 15);
            this.sublightLabel.TabIndex = 0;
            this.sublightLabel.Text = "Sublight Speed";
            // 
            // sublightSpeed
            // 
            this.sublightSpeed.Location = new System.Drawing.Point(617, 412);
            this.sublightSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sublightSpeed.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sublightSpeed.Name = "sublightSpeed";
            this.sublightSpeed.Size = new System.Drawing.Size(59, 23);
            this.sublightSpeed.TabIndex = 9;
            this.sublightSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sublightSpeed.ValueChanged += new System.EventHandler(this.sublightSpeed_ValueChanged);
            // 
            // primaryHyperdrive
            // 
            this.primaryHyperdrive.Location = new System.Drawing.Point(617, 362);
            this.primaryHyperdrive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.primaryHyperdrive.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.primaryHyperdrive.Name = "primaryHyperdrive";
            this.primaryHyperdrive.Size = new System.Drawing.Size(59, 23);
            this.primaryHyperdrive.TabIndex = 11;
            this.primaryHyperdrive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.primaryHyperdrive.ValueChanged += new System.EventHandler(this.primaryHyperdrive_ValueChanged);
            // 
            // hyper2Label
            // 
            this.hyper2Label.AutoSize = true;
            this.hyper2Label.Location = new System.Drawing.Point(471, 389);
            this.hyper2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hyper2Label.Name = "hyper2Label";
            this.hyper2Label.Size = new System.Drawing.Size(107, 15);
            this.hyper2Label.TabIndex = 0;
            this.hyper2Label.Text = "Backup Hyperdrive";
            // 
            // backupHyperdrive
            // 
            this.backupHyperdrive.Location = new System.Drawing.Point(617, 387);
            this.backupHyperdrive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.backupHyperdrive.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.backupHyperdrive.Name = "backupHyperdrive";
            this.backupHyperdrive.Size = new System.Drawing.Size(59, 23);
            this.backupHyperdrive.TabIndex = 12;
            this.backupHyperdrive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.backupHyperdrive.ValueChanged += new System.EventHandler(this.backupHyperdrive_ValueChanged);
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(7, 7);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(205, 104);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 114;
            this.picture.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 364);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 115;
            this.label2.Text = "Primary Hyperdrive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(652, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 153;
            this.label3.Text = "Total Attack";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(610, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 154;
            this.label4.Text = "Overall";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 339);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 15);
            this.label7.TabIndex = 1116;
            this.label7.Text = "Tractor Beam Strength";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 364);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 1117;
            this.label8.Text = "Tractor Beam Range";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(471, 464);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 1118;
            this.label10.Text = "Field51_0";
            // 
            // field51_0
            // 
            this.field51_0.Location = new System.Drawing.Point(617, 462);
            this.field51_0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.field51_0.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.field51_0.Name = "field51_0";
            this.field51_0.Size = new System.Drawing.Size(59, 23);
            this.field51_0.TabIndex = 1119;
            this.field51_0.TabStop = false;
            this.field51_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.field51_0.ValueChanged += new System.EventHandler(this.field51_0_ValueChanged);
            // 
            // field2_1
            // 
            this.field2_1.Location = new System.Drawing.Point(153, 462);
            this.field2_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.field2_1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.field2_1.Name = "field2_1";
            this.field2_1.Size = new System.Drawing.Size(59, 23);
            this.field2_1.TabIndex = 1121;
            this.field2_1.TabStop = false;
            this.field2_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.field2_1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.field2_1.ValueChanged += new System.EventHandler(this.field2_1_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 464);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 1120;
            this.label11.Text = "Field2_1";
            // 
            // CapitalShipsForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(726, 526);
            this.Controls.Add(this.field2_1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.field51_0);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.wepRechLabel);
            this.Controls.Add(this.weaponsRecharge);
            this.Controls.Add(this.bombardmentDefense);
            this.Controls.Add(this.bombardLabel);
            this.Controls.Add(this.gravWell2Label);
            this.Controls.Add(this.resDiffLabel);
            this.Controls.Add(this.gravWell1Label);
            this.Controls.Add(this.interdictionStrength);
            this.Controls.Add(this.familyIdHexLabel);
            this.Controls.Add(this.gravityWellProjectors);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.researchLabel);
            this.Controls.Add(this.capitalShipIdHexLabel);
            this.Controls.Add(this.researchOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.capitalShipId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.totalFirePower);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.researchDifficulty);
            this.Controls.Add(this.UnkownMoralHPlabel);
            this.Controls.Add(this.moraleModifier);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.field7_2);
            this.Controls.Add(this.ionCannonTotalFirePower);
            this.Controls.Add(this.tractorBeamRange);
            this.Controls.Add(this.textStraDllId);
            this.Controls.Add(this.productionFacility);
            this.Controls.Add(this.unkown3Label);
            this.Controls.Add(this.tractorBeamStrength);
            this.Controls.Add(this.laserCannonTotalFirePower);
            this.Controls.Add(this.familyId);
            this.Controls.Add(this.prodLabel);
            this.Controls.Add(this.turbolaserTotalFirePower);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.familyLabel);
            this.Controls.Add(this.secProdFacNumlabel);
            this.Controls.Add(this.shieldRechLabel);
            this.Controls.Add(this.nextProductionFacility);
            this.Controls.Add(this.manuverLabel);
            this.Controls.Add(this.hullStrength);
            this.Controls.Add(this.laserCannonRange);
            this.Controls.Add(this.hyper2Label);
            this.Controls.Add(this.hullLabel);
            this.Controls.Add(this.isEmpireUnit);
            this.Controls.Add(this.detectionRating);
            this.Controls.Add(this.isAllianceUnit);
            this.Controls.Add(this.DetectionLabel);
            this.Controls.Add(this.ionCannonRange);
            this.Controls.Add(this.sublightManoeuvrability);
            this.Controls.Add(this.costsGroup);
            this.Controls.Add(this.shieldRechargeRate);
            this.Controls.Add(this.turbolaserRange);
            this.Controls.Add(this.primaryHyperdrive);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.damageControl);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.damageConLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sublightSpeed);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.backupHyperdrive);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.sublightLabel);
            this.Controls.Add(this.picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "CapitalShipsForm";
            this.Text = "Capital Ships (CAPSHPSD.DAT)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameObjectsListForm_FormClosing);
            this.Load += new System.EventHandler(this.GameObjectsListForm_Load);
            this.Enter += new System.EventHandler(this.GameObjectsSelector_ValueChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameObjectsListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.textStraDllId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextProductionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moraleModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDifficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectionRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refinedMaterialCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombardmentDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponsRecharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interdictionStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravityWellProjectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractorBeamRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractorBeamStrength)).EndInit();
            this.attackStrengthGroup.ResumeLayout(false);
            this.attackStrengthGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonStarboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonAft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonStarboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonAft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonFore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonFore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserStarboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserAft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserFore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitalShipId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalFirePower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ionCannonTotalFirePower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserCannonTotalFirePower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbolaserTotalFirePower)).EndInit();
            this.costsGroup.ResumeLayout(false);
            this.costsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.troopCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fighterCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldRechargeRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hullStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sublightManoeuvrability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sublightSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primaryHyperdrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupHyperdrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field51_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label9;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label10;
        private NumericUpDown field51_0;
        private NumericUpDown field2_1;
        private Label label11;
    }
}