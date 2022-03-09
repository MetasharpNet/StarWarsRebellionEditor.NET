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
            var capitalShip = GameFile.CapitalShips[selectorIndex];
            bombardmentMod.Value = capitalShip.BombardmentMod;
            capitalShipId.Value = capitalShip.CapitalShipId;
            capitalShipIdHexLabel.Text = capitalShip.CapitalShipId.ToString("X");
            encyclopediaName.Text = capitalShip.EncyclopediaName;
            cargoFighters.Value = capitalShip.CargoFighters;
            cargoTroops.Value = capitalShip.CargoTroops;
            constructionCost.Value = capitalShip.ConstructionCost;
            damageControl.Value = capitalShip.DamageControl;
            detectionRating.Value = capitalShip.DetectionRating;
            hullStrength.Value = capitalShip.HullStrength;
            familyIdHexLabel.Text = capitalShip.FamilyId.ToString("x");
            familyId.Value = capitalShip.FamilyId;
            gravityUnknown1.Value = capitalShip.GravityUnknown1;
            gravityUnknown2.Value = capitalShip.GravityUnknown2;
            hyperdriveBackup.Value = capitalShip.HyperdriveBackup;
            hyperdrivePrimary.Value = capitalShip.HyperdrivePrimary;
            ionCannonAft.Value = capitalShip.IonCannonAft;
            ionCannonFore.Value = capitalShip.IonCannonFore;
            ionCannonPort.Value = capitalShip.IonCannonPort;
            ionCannonRange.Value = capitalShip.IonCannonRange;
            ionCannonStar.Value = capitalShip.IonCannonStar;
            ionCannonTotalFirePower.Value = capitalShip.IonCannonTotalFirePower;
            isAllianceUnit.Checked = capitalShip.IsAllianceUnit > 0U;
            isEmpireUnit.Checked = capitalShip.IsEmpireUnit > 0U;
            laserCannonAft.Value = capitalShip.LaserCannonAft;
            laserCannonFore.Value = capitalShip.LaserCannonFore;
            laserCannonPort.Value = capitalShip.LaserCannonPort;
            laserCannonRange.Value = capitalShip.LaserCannonRange;
            laserCannonStar.Value = capitalShip.LaserCannonStar;
            laserCannonTotalFirePower.Value = capitalShip.LaserCannonTotalFirePower;
            maintenanceCost.Value = capitalShip.MaintenanceCost;
            nextProductionFacility.Value = capitalShip.NextProductionFacility;
            productionFacility.Value = capitalShip.ProductionFacility;
            researchDifficulty.Value = capitalShip.ResearchDifficulty;
            researchOrder.Value = capitalShip.ResearchOrder;
            shieldsMaxCapacity.Value = capitalShip.ShieldsMaxCapacity;
            shieldsRechargeRate.Value = capitalShip.ShieldsRechargeRate;
            sublightManoeuvrability.Value = capitalShip.SublightManoeuvrability;
            sublightSpeed.Value = capitalShip.SublightSpeed;
            textStraDllId.Value = capitalShip.TextStraDllId;
            totalFirePower.Value = capitalShip.TotalFirePower;
            tractorBeamPower.Value = capitalShip.TractorBeamPower;
            tractorBeamRange.Value = capitalShip.TractorBeamRange;
            turboLaserAft.Value = capitalShip.TurboLaserAft;
            turboLaserFore.Value = capitalShip.TurboLaserFore;
            turboLaserPort.Value = capitalShip.TurboLaserPort;
            turboLaserRange.Value = capitalShip.TurboLaserRange;
            turboLaserStar.Value = capitalShip.TurboLaserStar;
            turboLaserTotalFirePower.Value = capitalShip.TurboLaserTotalFirePower;
            unknown2.Value = capitalShip.Unknown2;
            unknownMoralHp.Value = capitalShip.UnknownMoralHp;
            weaponsRecharge.Value = capitalShip.WeaponsRecharge;

            picture.SizeMode = PictureBoxSizeMode.Zoom;
            var edataId = 42 + selectorIndex;
            picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
        }
        private void UpdateTotals(int selectorIndex)
        {
            var capitalShip = GameFile.CapitalShips[selectorIndex];

            uint turboLaserTotalFirePowerTmp = capitalShip.TurboLaserFore + capitalShip.TurboLaserAft + capitalShip.TurboLaserPort + capitalShip.TurboLaserStar;
            uint ionCannonTotalFirePowerTmp = capitalShip.IonCannonFore + capitalShip.IonCannonAft + capitalShip.IonCannonPort + capitalShip.IonCannonStar;
            uint laserCannonTotalFirePowerTmp = capitalShip.LaserCannonFore + capitalShip.LaserCannonAft + capitalShip.LaserCannonPort + capitalShip.LaserCannonStar;

            GameFile.CapitalShips[selector.Value].TurboLaserTotalFirePower = turboLaserTotalFirePowerTmp;
            GameFile.CapitalShips[selector.Value].IonCannonTotalFirePower = ionCannonTotalFirePowerTmp;
            GameFile.CapitalShips[selector.Value].LaserCannonTotalFirePower = laserCannonTotalFirePowerTmp;
            GameFile.CapitalShips[selector.Value].TotalFirePower = turboLaserTotalFirePowerTmp + ionCannonTotalFirePowerTmp + laserCannonTotalFirePowerTmp;

            turboLaserTotalFirePower.Value = capitalShip.TurboLaserTotalFirePower;
            ionCannonTotalFirePower.Value = capitalShip.IonCannonTotalFirePower;
            laserCannonTotalFirePower.Value = capitalShip.LaserCannonTotalFirePower;
            totalFirePower.Value = capitalShip.TotalFirePower;
        }

        #endregion

        #region Checked/ValueChanged events

        private void bombardmentMod_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].BombardmentMod = (uint)bombardmentMod.Value;
            GameFile.UnsavedData = true;
        }
        private void cargoFighters_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].CargoFighters = (uint)cargoFighters.Value;
            GameFile.UnsavedData = true;
        }
        private void cargoTroops_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].CargoTroops = (uint)cargoTroops.Value;
            GameFile.UnsavedData = true;
        }
        private void constructionCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].ConstructionCost = (uint)constructionCost.Value;
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
        private void doesInterdiction_CheckedChanged(object sender, EventArgs e)
        {
            if (doesInterdiction.Checked)
            {
                GameFile.CapitalShips[selector.Value].GravityUnknown1 = 4U;
                gravityUnknown1.Value = 4M;
                GameFile.CapitalShips[selector.Value].GravityUnknown2 = 100U;
                gravityUnknown2.Value = 100M;
            }
            else
            {
                GameFile.CapitalShips[selector.Value].GravityUnknown1 = 0U;
                gravityUnknown1.Value = 0M;
                GameFile.CapitalShips[selector.Value].GravityUnknown2 = 0U;
                gravityUnknown2.Value = 0M;
            }
            GameFile.UnsavedData = true;
        }
        private void familyId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].FamilyId = (uint)familyId.Value;
            GameFile.UnsavedData = true;
        }
        private void gravityUnknown1_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].GravityUnknown1 = (uint)gravityUnknown1.Value;
            GameFile.UnsavedData = true;
        }
        private void gravityUnknown2_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].GravityUnknown2 = (uint)gravityUnknown2.Value;
            GameFile.UnsavedData = true;
        }
        private void hullStrength_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].HullStrength = (uint)hullStrength.Value;
            GameFile.UnsavedData = true;
        }
        private void hyperdriveBackup_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].HyperdriveBackup = (uint)hyperdriveBackup.Value;
            GameFile.UnsavedData = true;
        }
        private void hyperdrivePrimary_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].HyperdrivePrimary = (uint)hyperdrivePrimary.Value;
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
        private void ionCannonStar_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].IonCannonStar = (uint)ionCannonStar.Value;
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
        private void laserCannonStar_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].LaserCannonStar = (uint)laserCannonStar.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void maintenanceCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].MaintenanceCost = (uint)maintenanceCost.Value;
            GameFile.UnsavedData = true;
        }
        private void nextProductionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].NextProductionFacility = (uint)nextProductionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void productionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].ProductionFacility = (uint)productionFacility.Value;
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
        private void shieldsMaxCapacity_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].ShieldsMaxCapacity = (uint)shieldsMaxCapacity.Value;
            GameFile.UnsavedData = true;
        }
        private void shieldsRechargeRate_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].ShieldsRechargeRate = (uint)shieldsRechargeRate.Value;
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
        private void tractorBeamPower_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].TractorBeamPower = (uint)tractorBeamPower.Value;
            GameFile.UnsavedData = true;
        }
        private void tractorBeamRange_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].TractorBeamRange = (uint)tractorBeamRange.Value;
            GameFile.UnsavedData = true;
        }
        private void turboLaserAft_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].TurboLaserAft = (uint)turboLaserAft.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void turboLaserFore_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].TurboLaserFore = (uint)turboLaserFore.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void turboLaserPort_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].TurboLaserPort = (uint)turboLaserPort.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void turboLaserRange_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].TurboLaserRange = (uint)turboLaserRange.Value;
            GameFile.UnsavedData = true;
        }
        private void turboLaserStar_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].TurboLaserStar = (uint)turboLaserStar.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void unknownMoralHp_ValueChanged(object sender, EventArgs e)
        {
            GameFile.CapitalShips[selector.Value].UnknownMoralHp = (uint)unknownMoralHp.Value;
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
