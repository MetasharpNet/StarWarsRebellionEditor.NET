using Vestris.ResourceLib;

namespace SwRebellionEditor
{
    public partial class CapitalShipsForm : CapitalShipsDesignForm
    {
        #region .ctor

        public CapitalShipsForm()
        {
            GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\CAPSHPSD.DAT";
            GameFile = DatFile.Load<CAPSHPSD>(GameFilePath);
            InitializeComponent();
            InitializeBaseComponent(selector);
        }

        #endregion

        #region Business Layer

        protected override void DisplaySelectedGameObject(int selectorIndex)
        {
            var previousUnsavedData = GameFile.UnsavedData;
            var capitalShip = GameFile.CapitalShips[selectorIndex];
            backupHyperdrive.Value = capitalShip.BackupHyperdrive;
            bombardmentDefense.Value = capitalShip.BombardmentDefense;
            capitalShipId.Value = capitalShip.CapitalShipId;
            capitalShipIdHexLabel.Text = "0x" + capitalShip.CapitalShipId.ToString("X");
            encyclopediaDescription.Text = capitalShip.EncyclopediaDescription;
            encyclopediaName.Text = capitalShip.EncyclopediaName;
            fighterCapacity.Value = capitalShip.FighterCapacity;
            damageControl.Value = capitalShip.DamageControl;
            detectionRating.Value = capitalShip.DetectionRating;
            familyIdHexLabel.Text = "0x" + capitalShip.FamilyId.ToString("x");
            familyId.Value = capitalShip.FamilyId;
            field7_2.Value = capitalShip.Field7_2;
            field51_0.Value = capitalShip.Field51_0;
            gravityWellProjectors.Value = capitalShip.GravityWellProjectors;
            hullStrength.Value = capitalShip.HullStrength;
            interdictionStrength.Value = capitalShip.InterdictionStrength;
            ionCannonAft.Value = capitalShip.IonCannonAft;
            ionCannonFore.Value = capitalShip.IonCannonFore;
            ionCannonPort.Value = capitalShip.IonCannonPort;
            ionCannonRange.Value = capitalShip.IonCannonRange;
            ionCannonStarboard.Value = capitalShip.IonCannonStarboard;
            ionCannonTotalFirePower.Value = capitalShip.IonCannonTotalFirePower;
            isAllianceUnit.Checked = capitalShip.IsAllianceUnit > 0U;
            isEmpireUnit.Checked = capitalShip.IsEmpireUnit > 0U;
            laserCannonAft.Value = capitalShip.LaserCannonAft;
            laserCannonFore.Value = capitalShip.LaserCannonFore;
            laserCannonPort.Value = capitalShip.LaserCannonPort;
            laserCannonRange.Value = capitalShip.LaserCannonRange;
            laserCannonStarboard.Value = capitalShip.LaserCannonStarboard;
            laserCannonTotalFirePower.Value = capitalShip.LaserCannonTotalFirePower;
            maintenanceCost.Value = capitalShip.MaintenanceCost;
            nextProductionFacility.Value = capitalShip.NextProductionFacility;
            primaryHyperdrive.Value = capitalShip.PrimaryHyperdrive;
            productionFacility.Value = capitalShip.ProductionFacility;
            refinedMaterialCost.Value = capitalShip.RefinedMaterialCost;
            researchDifficulty.Value = capitalShip.ResearchDifficulty;
            researchOrder.Value = capitalShip.ResearchOrder;
            shieldStrength.Value = capitalShip.ShieldStrength;
            shieldRechargeRate.Value = capitalShip.ShieldRechargeRate;
            sublightManoeuvrability.Value = capitalShip.SublightManoeuvrability;
            sublightSpeed.Value = capitalShip.SublightSpeed;
            textStraDllId.Value = capitalShip.TextStraDllId;
            totalFirePower.Value = capitalShip.TotalFirePower;
            tractorBeamStrength.Value = capitalShip.TractorBeamPower;
            tractorBeamRange.Value = capitalShip.TractorBeamRange;
            troopCapacity.Value = capitalShip.TroopCapacity;
            turbolaserAft.Value = capitalShip.TurbolaserAft;
            turbolaserFore.Value = capitalShip.TurbolaserFore;
            turbolaserPort.Value = capitalShip.TurbolaserPort;
            turbolaserRange.Value = capitalShip.TurbolaserRange;
            turbolaserStarboard.Value = capitalShip.TurbolaserStarboard;
            turbolaserTotalFirePower.Value = capitalShip.TurbolaserTotalFirePower;
            moraleModifier.Value = capitalShip.MoraleModifier;
            weaponsRecharge.Value = capitalShip.WeaponsRecharge;

            picture.SizeMode = PictureBoxSizeMode.Zoom;
            var edataId = 42 + selectorIndex;
            picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
            GameFile.UnsavedData = previousUnsavedData;
        }
        protected override void LoadSideInfo()
        {
            foreach (var ship in  GameFile.CapitalShips)
                ship.EncyclopediaName = TextStra.Get(ship.TextStraDllId.ToString());
        }
        private void UpdateTotals(int selectorIndex)
        {
            var capitalShip = GameFile.CapitalShips[selectorIndex];

            uint turboLaserTotalFirePowerTmp = capitalShip.TurbolaserFore + capitalShip.TurbolaserAft + capitalShip.TurbolaserPort + capitalShip.TurbolaserStarboard;
            uint ionCannonTotalFirePowerTmp = capitalShip.IonCannonFore + capitalShip.IonCannonAft + capitalShip.IonCannonPort + capitalShip.IonCannonStarboard;
            uint laserCannonTotalFirePowerTmp = capitalShip.LaserCannonFore + capitalShip.LaserCannonAft + capitalShip.LaserCannonPort + capitalShip.LaserCannonStarboard;

            GameFile.CapitalShips[selector.Value].TurbolaserTotalFirePower = turboLaserTotalFirePowerTmp;
            GameFile.CapitalShips[selector.Value].IonCannonTotalFirePower = ionCannonTotalFirePowerTmp;
            GameFile.CapitalShips[selector.Value].LaserCannonTotalFirePower = laserCannonTotalFirePowerTmp;
            GameFile.CapitalShips[selector.Value].TotalFirePower = turboLaserTotalFirePowerTmp + ionCannonTotalFirePowerTmp + laserCannonTotalFirePowerTmp;

            turbolaserTotalFirePower.Value = capitalShip.TurbolaserTotalFirePower;
            ionCannonTotalFirePower.Value = capitalShip.IonCannonTotalFirePower;
            laserCannonTotalFirePower.Value = capitalShip.LaserCannonTotalFirePower;
            totalFirePower.Value = capitalShip.TotalFirePower;
        }

        #endregion

        #region Changed events

        private void backupHyperdrive_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].BackupHyperdrive = (uint)backupHyperdrive.Value;
            GameFile.UnsavedData = true;
        }
        private void bombardmentDefense_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].BombardmentDefense = (uint)bombardmentDefense.Value;
            GameFile.UnsavedData = true;
        }
        private void damageControl_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].DamageControl = (uint)damageControl.Value;
            GameFile.UnsavedData = true;
        }
        private void detectionRating_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].DetectionRating = (uint)detectionRating.Value;
            GameFile.UnsavedData = true;
        }
        private void familyId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].FamilyId = (uint)familyId.Value;
            GameFile.UnsavedData = true;
        }
        private void field7_2_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].Field7_2 = (ushort)field7_2.Value;
            GameFile.UnsavedData = true;
        }
        private void field51_0_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].Field51_0 = (uint)field51_0.Value;
            GameFile.UnsavedData = true;
        }
        private void fighterCapacity_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].FighterCapacity = (uint)fighterCapacity.Value;
            GameFile.UnsavedData = true;
        }
        private void gravityWellProjectors_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].GravityWellProjectors = (uint)gravityWellProjectors.Value;
            GameFile.UnsavedData = true;
        }
        private void hullStrength_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].HullStrength = (uint)hullStrength.Value;
            GameFile.UnsavedData = true;
        }
        private void interdictionStrength_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].InterdictionStrength = (uint)interdictionStrength.Value;
            GameFile.UnsavedData = true;
        }
        private void ionCannonAft_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].IonCannonAft = (uint)ionCannonAft.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void ionCannonFore_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].IonCannonFore = (uint)ionCannonFore.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void ionCannonPort_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].IonCannonPort = (uint)ionCannonPort.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void ionCannonRange_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].IonCannonRange = (uint)ionCannonRange.Value;
            GameFile.UnsavedData = true;
        }
        private void ionCannonStarboard_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].IonCannonStarboard = (uint)ionCannonStarboard.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void isAllianceUnit_CheckedChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].IsAllianceUnit = isAllianceUnit.Checked ? 1U : 0U;
            GameFile.UnsavedData = true;
        }
        private void isEmpireUnit_CheckedChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].IsEmpireUnit = isEmpireUnit.Checked ? 1U : 0U;
            GameFile.UnsavedData = true;
        }
        private void laserCannonAft_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].LaserCannonAft = (uint)laserCannonAft.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void laserCannonFore_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].LaserCannonFore = (uint)laserCannonFore.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void laserCannonPort_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].LaserCannonPort = (uint)laserCannonPort.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void laserCannonRange_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].LaserCannonRange = (uint)laserCannonRange.Value;
            GameFile.UnsavedData = true;
        }
        private void laserCannonStarboard_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].LaserCannonStarboard = (uint)laserCannonStarboard.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void maintenanceCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].MaintenanceCost = (uint)maintenanceCost.Value;
            GameFile.UnsavedData = true;
        }
        private void moraleModifier_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].MoraleModifier = (uint)moraleModifier.Value;
            GameFile.UnsavedData = true;
        }
        private void nextProductionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].NextProductionFacility = (uint)nextProductionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void primaryHyperdrive_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].PrimaryHyperdrive = (uint)primaryHyperdrive.Value;
            GameFile.UnsavedData = true;
        }
        private void productionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].ProductionFacility = (uint)productionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void refinedMaterialCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].RefinedMaterialCost = (uint)refinedMaterialCost.Value;
            GameFile.UnsavedData = true;
        }
        private void researchDifficulty_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].ResearchDifficulty = (uint)researchDifficulty.Value;
            GameFile.UnsavedData = true;
        }
        private void researchOrder_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].ResearchOrder = (uint)researchOrder.Value;
            GameFile.UnsavedData = true;
        }
        private void shieldRechargeRate_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].ShieldRechargeRate = (uint)shieldRechargeRate.Value;
            GameFile.UnsavedData = true;
        }
        private void shieldStrength_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].ShieldStrength = (uint)shieldStrength.Value;
            GameFile.UnsavedData = true;
        }
        private void sublightManoeuvrability_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].SublightManoeuvrability = (uint)sublightManoeuvrability.Value;
            GameFile.UnsavedData = true;
        }
        private void sublightSpeed_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].SublightSpeed = (uint)sublightSpeed.Value;
            GameFile.UnsavedData = true;
        }
        private void tractorBeamStrength_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].TractorBeamPower = (uint)tractorBeamStrength.Value;
            GameFile.UnsavedData = true;
        }
        private void tractorBeamRange_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].TractorBeamRange = (uint)tractorBeamRange.Value;
            GameFile.UnsavedData = true;
        }
        private void troopCapacity_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].TroopCapacity = (uint)troopCapacity.Value;
            GameFile.UnsavedData = true;
        }
        private void turbolaserAft_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].TurbolaserAft = (uint)turbolaserAft.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void turbolaserFore_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].TurbolaserFore = (uint)turbolaserFore.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void turbolaserPort_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].TurbolaserPort = (uint)turbolaserPort.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void turbolaserRange_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].TurbolaserRange = (uint)turbolaserRange.Value;
            GameFile.UnsavedData = true;
        }
        private void turbolaserStarboard_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].TurbolaserStarboard = (uint)turbolaserStarboard.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void weaponsRecharge_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].WeaponsRecharge = (uint)weaponsRecharge.Value;
            GameFile.UnsavedData = true;
        }

        #endregion

    }
}
