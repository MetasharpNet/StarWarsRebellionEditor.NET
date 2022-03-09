namespace SwRebellionEditor
{
    public partial class FightersForm : FightersDesignForm
    {
        #region .ctor

        public FightersForm()
        {
            GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\FIGHTSD.DAT";
            GameFile = DatFile.Load<FIGHTSD>(GameFilePath);
            InitializeComponent();
            InitializeBaseComponent(selector);
        }

        #endregion

        #region Business Layer

        protected override void DisplaySelectedGameObject(int selectorIndex)
        {
            var fighter = GameFile.Fighters[selectorIndex];
            bombardmentMod.Value = fighter.BombardmentMod;
            constructionCost.Value = fighter.ConstructionCost;
            detectionRating.Value = fighter.DetectionRating;
            encyclopediaName.Text = fighter.EncyclopediaName;
            familyId.Value = fighter.FamilyId;
            familyIdHexLabel.Text = fighter.FamilyId.ToString("X");
            fighterId.Value = fighter.FighterId;
            fighterIdHexLabel.Text = fighter.FighterId.ToString("x");
            hyperdriveBackup.Value = fighter.HyperdriveBackup;
            hyperdrivePrimary.Value = fighter.HyperdrivePrimary;
            isAllianceUnit.Checked = fighter.IsAllianceUnit > 0U;
            isEmpireUnit.Checked = fighter.IsEmpireUnit > 0U;
            maintenanceCost.Value = fighter.MaintenanceCost;
            productionFacility.Value = fighter.ProductionFacility;
            researchDifficulty.Value = fighter.ResearchDifficulty;
            researchOrder.Value = fighter.ResearchOrder;
            shieldsMaxCapacity.Value = fighter.ShieldsMaxCapacity;
            sublightManoeuvrability.Value = fighter.SublightManoeuvrability;
            sublightSpeed.Value = fighter.SublightSpeed;
            textStraDllId.Value = fighter.TextStraDllId;
            unknownMoralHp.Value = fighter.UnknownMoralHp;

            fpArc1Num.Value = fighter.firePowerArc1;
            fpArc2Num.Value = fighter.firePowerArc2;
            fpArc3Num.Value = fighter.firePowerArc3;
            fpArc4Num.Value = fighter.firePowerArc4;
            fpArc5Num.Value = fighter.firePowerArc5;
            fpArc6Num.Value = fighter.firePowerArc6;
            fpArc7Num.Value = fighter.firePowerArc7;
            fpArc8Num.Value = fighter.firePowerArc8;
            fpArc9Num.Value = fighter.firePowerArc9;
            fpArc10Num.Value = fighter.firePowerArc10;
            fpArc11Num.Value = fighter.firePowerArc11;
            fpArc12Num.Value = fighter.firePowerArc12;
            torpPowNum.Value = fighter.torpedoPower;
            torpRanNum.Value = fighter.torpedoRange;
            squadSizeNum.Value = fighter.squadronSize;
            turboRanNum.Value = fighter.turboLaserRange;
            ionRanNum.Value = fighter.ionRange;
            laserRanNum.Value = fighter.laserRange;
            secProdFacNum.Value = fighter.unknown2;
            unknown3Num.Value = fighter.unknown3;
            sumTurboNum.Value = fighter.sumTurboLaserFP;
            sumIonNum.Value = fighter.sumIonFP;
            sumLaserNum.Value = fighter.sumLaserFP;
            sumFPNum.Value = fighter.sumFP;

            picture.SizeMode = PictureBoxSizeMode.Zoom;
            var edataId = 34 + selectorIndex;
            picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
            /*
            capitalShipId.Value = capitalShip.CapitalShipId;
            capitalShipIdHexLabel.Text = capitalShip.CapitalShipId.ToString("X");
            cargoFighters.Value = capitalShip.CargoFighters;
            cargoTroops.Value = capitalShip.CargoTroops;
            damageControl.Value = capitalShip.DamageControl;
            hullStrength.Value = capitalShip.HullStrength;
            gravityUnknown1.Value = capitalShip.GravityUnknown1;
            gravityUnknown2.Value = capitalShip.GravityUnknown2;
            ionCannonAft.Value = capitalShip.IonCannonAft;
            ionCannonFore.Value = capitalShip.IonCannonFore;
            ionCannonPort.Value = capitalShip.IonCannonPort;
            ionCannonRange.Value = capitalShip.IonCannonRange;
            ionCannonStar.Value = capitalShip.IonCannonStar;
            ionCannonTotalFirePower.Value = capitalShip.IonCannonTotalFirePower;
            laserCannonAft.Value = capitalShip.LaserCannonAft;
            laserCannonFore.Value = capitalShip.LaserCannonFore;
            laserCannonPort.Value = capitalShip.LaserCannonPort;
            laserCannonRange.Value = capitalShip.LaserCannonRange;
            laserCannonStar.Value = capitalShip.LaserCannonStar;
            laserCannonTotalFirePower.Value = capitalShip.LaserCannonTotalFirePower;
            nextProductionFacility.Value = capitalShip.NextProductionFacility;
            shieldsRechargeRate.Value = capitalShip.ShieldsRechargeRate;
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
            weaponsRecharge.Value = capitalShip.WeaponsRecharge;*/

        }

        #endregion

        #region Checked/ValueChanged events


        #endregion

        private void updateConCost(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].ConstructionCost = (uint)constructionCost.Value;
            GameFile.UnsavedData = true;
        }

        private void updateMaintCost(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].MaintenanceCost = (uint)maintenanceCost.Value;
            GameFile.UnsavedData = true;
        }

        private void updateDetectionNum(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].DetectionRating = (uint)detectionRating.Value;
            GameFile.UnsavedData = true;
        }

        private void updateResearchNum(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].ResearchOrder = (uint)researchOrder.Value;
            GameFile.UnsavedData = true;
        }

        private void updateResDiffNum(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].ResearchDifficulty = (uint)researchDifficulty.Value;
            GameFile.UnsavedData = true;
        }

        private void updateSublightNum(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].SublightSpeed = (uint)sublightSpeed.Value;
            GameFile.UnsavedData = true;
        }

        private void updateManeuverNum(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].SublightManoeuvrability = (uint)sublightManoeuvrability.Value;
            GameFile.UnsavedData = true;
        }

        private void updateHyperNum(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].HyperdrivePrimary = (uint)hyperdrivePrimary.Value;
            GameFile.UnsavedData = true;
        }

        private void updateHyper2Num(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].HyperdriveBackup = (uint)hyperdriveBackup.Value;
            GameFile.UnsavedData = true;
        }

        private void updateShieldNum(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].ShieldsMaxCapacity = (uint)shieldsMaxCapacity.Value;
            GameFile.UnsavedData = true;
        }

        private void updateRebelUnitCheck(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].IsAllianceUnit = !isAllianceUnit.Checked ? 0U : 1U;
            GameFile.UnsavedData = true;
        }

        private void updateEmpireUnitCheck(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].IsEmpireUnit = !isEmpireUnit.Checked ? 0U : 1U;
            GameFile.UnsavedData = true;
        }

        private void updateSumFP(int selectorIndex)
        {
            var fighter = GameFile.Fighters[selectorIndex];
            uint num1 = 0;
            uint num2 = 0;
            uint num3 = 0;
            uint num4 = num1 + fighter.firePowerArc1 + fighter.firePowerArc4 + fighter.firePowerArc7 + fighter.firePowerArc10;
            uint num5 = num2 + fighter.firePowerArc2 + fighter.firePowerArc5 + fighter.firePowerArc8 + fighter.firePowerArc11;
            uint num6 = num3 + fighter.firePowerArc3 + fighter.firePowerArc6 + fighter.firePowerArc9 + fighter.firePowerArc12;
            GameFile.Fighters[selector.Value].sumTurboLaserFP = num4;
            GameFile.Fighters[selector.Value].sumIonFP = num5;
            GameFile.Fighters[selector.Value].sumLaserFP = num6;
            GameFile.Fighters[selector.Value].sumFP = num4 + num5 + num6;
            sumTurboNum.Value = fighter.sumTurboLaserFP;
            sumIonNum.Value = fighter.sumIonFP;
            sumLaserNum.Value = fighter.sumLaserFP;
            sumFPNum.Value = fighter.sumFP;
        }

        private void updateFpArc1Num(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].firePowerArc1 = (uint)fpArc1Num.Value;
            updateSumFP(selector.Value);
            GameFile.UnsavedData = true;
        }

        private void updateFpArc2Num(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].firePowerArc2 = (uint)fpArc2Num.Value;
            updateSumFP(selector.Value);
            GameFile.UnsavedData = true;
        }

        private void updateFpArc3Num(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].firePowerArc3 = (uint)fpArc3Num.Value;
            updateSumFP(selector.Value);
            GameFile.UnsavedData = true;
        }

        private void updateFpArc4Num(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].firePowerArc4 = (uint)fpArc4Num.Value;
            updateSumFP(selector.Value);
            GameFile.UnsavedData = true;
        }

        private void updateFpArc5Num(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].firePowerArc5 = (uint)fpArc5Num.Value;
            updateSumFP(selector.Value);
            GameFile.UnsavedData = true;
        }

        private void updateFpArc6Num(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].firePowerArc6 = (uint)fpArc6Num.Value;
            updateSumFP(selector.Value);
            GameFile.UnsavedData = true;
        }

        private void updateFpArc7Num(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].firePowerArc7 = (uint)fpArc7Num.Value;
            updateSumFP(selector.Value);
            GameFile.UnsavedData = true;
        }

        private void updateFpArc8Num(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].firePowerArc8 = (uint)fpArc8Num.Value;
            updateSumFP(selector.Value);
            GameFile.UnsavedData = true;
        }

        private void updateFpArc9Num(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].firePowerArc9 = (uint)fpArc9Num.Value;
            updateSumFP(selector.Value);
            GameFile.UnsavedData = true;
        }

        private void updateFpArc10Num(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].firePowerArc10 = (uint)fpArc10Num.Value;
            updateSumFP(selector.Value);
            GameFile.UnsavedData = true;
        }

        private void updateFpArc11Num(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].firePowerArc11 = (uint)fpArc11Num.Value;
            updateSumFP(selector.Value);
            GameFile.UnsavedData = true;
        }

        private void updateFpArc12Num(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].firePowerArc12 = (uint)fpArc12Num.Value;
            updateSumFP(selector.Value);
            GameFile.UnsavedData = true;
        }

        private void updateTurboRanNum(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].turboLaserRange = (uint)turboRanNum.Value;
            GameFile.UnsavedData = true;
        }

        private void updateIonRanNum(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].ionRange = (uint)ionRanNum.Value;
            GameFile.UnsavedData = true;
        }

        private void updateLaserRanNum(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].laserRange = (uint)laserRanNum.Value;
            GameFile.UnsavedData = true;
        }

        private void updateTorpRanNum(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].torpedoRange = (uint)torpRanNum.Value;
            GameFile.UnsavedData = true;
        }

        private void updateTorpPowNum(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].torpedoPower = (uint)torpPowNum.Value;
            GameFile.UnsavedData = true;
        }

        private void updateSquadSizeNum(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].squadronSize = (uint)squadSizeNum.Value;
            GameFile.UnsavedData = true;
        }

        private void updateBombardNum(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].BombardmentMod = (uint)bombardmentMod.Value;
            GameFile.UnsavedData = true;
        }

        private void updateUnknownMoralHpNum(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].UnknownMoralHp = (uint)unknownMoralHp.Value;
            GameFile.UnsavedData = true;
        }

        private void updateProdFacNum(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].ProductionFacility = (uint)productionFacility.Value;
            GameFile.UnsavedData = true;
        }

        private void updateSecProdFacNum(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].unknown2 = (uint)secProdFacNum.Value;
            GameFile.UnsavedData = true;
        }

        private void updateFamilyIdNum(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].FamilyId = (uint)familyId.Value;
            GameFile.UnsavedData = true;
        }
    }
}
