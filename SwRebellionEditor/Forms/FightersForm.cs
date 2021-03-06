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
            var previousUnsavedData = GameFile.UnsavedData;
            var fighter = GameFile.Fighters[selectorIndex];
            bombardmentMod.Value = fighter.BombardmentDefense;
            constructionCost.Value = fighter.RefinedMaterialCost;
            detectionRating.Value = fighter.DetectionRating;
            name.Text = fighter.Name;
            familyId.Value = fighter.FamilyId;
            familyIdHexLabel.Text = "0x" + fighter.FamilyId.ToString("X");
            fighterId.Value = fighter.FighterId;
            fighterIdHexLabel.Text = "0x" + fighter.FighterId.ToString("X");
            hyperdriveBackup.Value = fighter.HyperdriveBackup;
            hyperdrivePrimary.Value = fighter.HyperdrivePrimary;
            ionCannonAft.Value = fighter.IonCannonAft;
            ionCannonFore.Value = fighter.IonCannonFore;
            ionCannonPort.Value = fighter.IonCannonPort;
            ionCannonRange.Value = fighter.IonCannonRange;
            ionCannonStar.Value = fighter.IonCannonStarboard;
            ionCannonTotalFirePower.Value = fighter.IonCannonTotalFirePower;
            isAllianceUnit.Checked = fighter.IsAllianceUnit > 0U;
            isEmpireUnit.Checked = fighter.IsEmpireUnit > 0U;
            laserCannonAft.Value = fighter.LaserCannonAft;
            laserCannonFore.Value = fighter.LaserCannonFore;
            laserCannonPort.Value = fighter.LaserCannonPort;
            laserCannonRange.Value = fighter.LaserCannonRange;
            laserCannonStar.Value = fighter.LaserCannonStarboard;
            laserCannonTotalFirePower.Value = fighter.LaserCannonTotalFirePower;
            maintenanceCost.Value = fighter.MaintenanceCost;
            nextProductionFacility.Value = fighter.NextProductionFacility;
            productionFacility.Value = fighter.ProductionFacility;
            researchDifficulty.Value = fighter.ResearchDifficulty;
            researchOrder.Value = fighter.ResearchOrder;
            shieldsMaxCapacity.Value = fighter.ShieldEnergy;
            squadronSize.Value = fighter.SquadronSize;
            sublightManoeuvrability.Value = fighter.SublightManoeuvrability;
            sublightSpeed.Value = fighter.SublightSpeed;
            textStraDllId.Value = fighter.TextStraDllId;
            torpedoFore.Value = fighter.TorpedoFore;
            torpedoRange.Value = fighter.TorpedoRange;
            totalFirePower.Value = fighter.TotalFirePower;
            turboLaserAft.Value = fighter.TurbolaserAft;
            turboLaserFore.Value = fighter.TurbolaserFore;
            turboLaserPort.Value = fighter.TurbolaserPort;
            turboLaserRange.Value = fighter.TurbolaserRange;
            turboLaserStar.Value = fighter.TurbolaserStarboard;
            turboLaserTotalFirePower.Value = fighter.TurbolaserTotalFirePower;
            unknown.Value = fighter.Field7_Unknown;
            unknownMoralHp.Value = fighter.UnknownMoralHp;

            picture.SizeMode = PictureBoxSizeMode.Zoom;
            var edataId = 34 + selectorIndex;
            picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
            GameFile.UnsavedData = previousUnsavedData;
        }
        protected override void LoadSideInfo()
        {
            foreach (var f in GameFile.Fighters)
                f.Name = TextStra.Get(f.TextStraDllId.ToString());
        }
        private void UpdateTotals(int selectorIndex)
        {
            var fighter = GameFile.Fighters[selectorIndex];

            uint turboLaserTotalFirePowerTmp = fighter.TurbolaserFore + fighter.TurbolaserAft + fighter.TurbolaserPort + fighter.TurbolaserStarboard;
            uint ionCannonTotalFirePowerTmp = fighter.IonCannonFore + fighter.IonCannonAft + fighter.IonCannonPort + fighter.IonCannonStarboard;
            uint laserCannonTotalFirePowerTmp = fighter.LaserCannonFore + fighter.LaserCannonAft + fighter.LaserCannonPort + fighter.LaserCannonStarboard;

            GameFile.Fighters[selector.Value].TurbolaserTotalFirePower = turboLaserTotalFirePowerTmp;
            GameFile.Fighters[selector.Value].IonCannonTotalFirePower = ionCannonTotalFirePowerTmp;
            GameFile.Fighters[selector.Value].LaserCannonTotalFirePower = laserCannonTotalFirePowerTmp;
            GameFile.Fighters[selector.Value].TotalFirePower = turboLaserTotalFirePowerTmp + ionCannonTotalFirePowerTmp + laserCannonTotalFirePowerTmp;

            turboLaserTotalFirePower.Value = fighter.TurbolaserTotalFirePower;
            ionCannonTotalFirePower.Value = fighter.IonCannonTotalFirePower;
            laserCannonTotalFirePower.Value = fighter.LaserCannonTotalFirePower;
            totalFirePower.Value = fighter.TotalFirePower;
        }

        #endregion

        #region Changed events

        private void bombardmentMod_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].BombardmentDefense = (uint)bombardmentMod.Value;
            GameFile.UnsavedData = true;
        }
        private void constructionCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].RefinedMaterialCost = (uint)constructionCost.Value;
            GameFile.UnsavedData = true;
        }
        private void detectionRating_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].DetectionRating = (uint)detectionRating.Value;
            GameFile.UnsavedData = true;
        }
        private void familyId_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].FamilyId = (uint)familyId.Value;
            GameFile.UnsavedData = true;
        }
        private void hyperdriveBackup_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].HyperdriveBackup = (uint)hyperdriveBackup.Value;
            GameFile.UnsavedData = true;
        }
        private void hyperdrivePrimary_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].HyperdrivePrimary = (uint)hyperdrivePrimary.Value;
            GameFile.UnsavedData = true;
        }
        private void ionCannonAft_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].IonCannonAft = (uint)ionCannonAft.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void ionCannonFore_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].IonCannonFore = (uint)ionCannonFore.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void ionCannonPort_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].IonCannonPort = (uint)ionCannonPort.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void ionCannonRange_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].IonCannonRange = (uint)ionCannonRange.Value;
            GameFile.UnsavedData = true;
        }
        private void ionCannonStar_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].IonCannonStarboard = (uint)ionCannonStar.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void isEmpireUnit_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].IsEmpireUnit = isEmpireUnit.Checked ? 1U : 0U;
            GameFile.UnsavedData = true;
        }
        private void isAllianceUnit_CheckStateChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].IsAllianceUnit = isAllianceUnit.Checked ? 1U : 0U;
            GameFile.UnsavedData = true;
        }
        private void laserCannonAft_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].LaserCannonAft = (uint)laserCannonAft.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void laserCannonFore_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].LaserCannonFore = (uint)laserCannonFore.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void laserCannonPort_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].LaserCannonPort = (uint)laserCannonPort.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void laserCannonRange_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].LaserCannonRange = (uint)laserCannonRange.Value;
            GameFile.UnsavedData = true;
        }
        private void laserCannonStar_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].LaserCannonStarboard = (uint)laserCannonStar.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void maintenanceCost_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].MaintenanceCost = (uint)maintenanceCost.Value;
            GameFile.UnsavedData = true;
        }
        private void nextProductionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].NextProductionFacility = (uint)nextProductionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void productionFacility_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].ProductionFacility = (uint)productionFacility.Value;
            GameFile.UnsavedData = true;
        }
        private void researchDifficulty_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].ResearchDifficulty = (uint)researchDifficulty.Value;
            GameFile.UnsavedData = true;
        }
        private void researchOrder_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].ResearchOrder = (uint)researchOrder.Value;
            GameFile.UnsavedData = true;
        }
        private void shieldsMaxCapacity_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].ShieldEnergy = (uint)shieldsMaxCapacity.Value;
            GameFile.UnsavedData = true;
        }
        private void squadronSize_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].SquadronSize = (uint)squadronSize.Value;
            GameFile.UnsavedData = true;
        }
        private void sublightManoeuvrability_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].SublightManoeuvrability = (uint)sublightManoeuvrability.Value;
            GameFile.UnsavedData = true;
        }
        private void sublightSpeed_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].SublightSpeed = (uint)sublightSpeed.Value;
            GameFile.UnsavedData = true;
        }
        private void torpedoFore_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].TorpedoFore = (uint)torpedoFore.Value;
            GameFile.UnsavedData = true;
        }
        private void torpedoRange_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].TorpedoRange = (uint)torpedoRange.Value;
            GameFile.UnsavedData = true;
        }
        private void turboLaserAft_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].TurbolaserAft = (uint)turboLaserAft.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void turboLaserFore_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].TurbolaserFore = (uint)turboLaserFore.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void turboLaserPort_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].TurbolaserPort = (uint)turboLaserPort.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void turboLaserRange_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].TurbolaserRange = (uint)turboLaserRange.Value;
            GameFile.UnsavedData = true;
        }
        private void turboLaserStar_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].TurbolaserStarboard = (uint)turboLaserStar.Value;
            UpdateTotals(selector.Value);
            GameFile.UnsavedData = true;
        }
        private void unknownMoralHp_ValueChanged(object sender, EventArgs e)
        {
            GameFile.Fighters[selector.Value].UnknownMoralHp = (uint)unknownMoralHp.Value;
            GameFile.UnsavedData = true;
        }

        #endregion
    }
}
