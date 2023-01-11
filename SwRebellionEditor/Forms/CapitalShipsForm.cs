namespace SwRebellionEditor;

public partial class CapitalShipsForm : CapitalShipsDesignForm
{
    #region .ctor

    public CapitalShipsForm()
    {
        GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\CAPSHPSD.DAT";
        GameFile = DatFile.Load<CAPSHPSD>(GameFilePath);
        InitializeComponent();
        InitializeBaseComponent(selector);
        selector.Maximum = (int)GameFile.CapitalShipsCount - 1;
    }

    #endregion

    #region Business Layer

    protected override void DisplaySelectedGameObject(int selectorIndex)
    {
        var previousUnsavedData = GameFile.UnsavedData;
        var capitalShip = GameFile.CapitalShips[selectorIndex];
        bombardmentModifier.Value = capitalShip.BombardmentModifier;
        damageControl.Value = capitalShip.DamageControl;
        detection.Value = capitalShip.Detection;
        encyclopediaDescription.Text = capitalShip.EncyclopediaDescription;
        familyId.Value = capitalShip.FamilyId;
        familyIdHexLabel.Text = "0x" + capitalShip.FamilyId.ToString("x");
        field2_1.Value = capitalShip.Field2_1;
        field51_0.Value = capitalShip.Field51_0;
        field7_2.Value = capitalShip.Field7_2;
        fighterCapacity.Value = capitalShip.FighterCapacity;
        gravityWellProjector.Value = capitalShip.GravityWellProjector;
        hull.Value = capitalShip.Hull;
        hyperdrive.Value = capitalShip.Hyperdrive;
        hyperdriveIfDamaged.Value = capitalShip.HyperdriveIfDamaged;
        id.Value = capitalShip.Id;
        idHexLabel.Text = "0x" + capitalShip.Id.ToString("X");
        interdictionStrength.Value = capitalShip.InterdictionStrength;
        ionCannonAft.Value = capitalShip.IonCannonAft;
        ionCannonAttackStrength.Value = capitalShip.IonCannonAttackStrength;
        ionCannonFore.Value = capitalShip.IonCannonFore;
        ionCannonPort.Value = capitalShip.IonCannonPort;
        ionCannonRange.Value = capitalShip.IonCannonRange;
        ionCannonStarboard.Value = capitalShip.IonCannonStarboard;
        isAlliance.Checked = capitalShip.IsAlliance > 0U;
        isEmpire.Checked = capitalShip.IsEmpire > 0U;
        laserCannonAft.Value = capitalShip.LaserCannonAft;
        laserCannonAttackStrength.Value = capitalShip.LaserCannonAttackStrength;
        laserCannonFore.Value = capitalShip.LaserCannonFore;
        laserCannonPort.Value = capitalShip.LaserCannonPort;
        laserCannonRange.Value = capitalShip.LaserCannonRange;
        laserCannonStarboard.Value = capitalShip.LaserCannonStarboard;
        maintenanceCost.Value = capitalShip.MaintenanceCost;
        maneuverability.Value = capitalShip.Maneuverability;
        name.Text = capitalShip.Name;
        nextProductionFamily.Value = capitalShip.NextProductionFamily;
        overallAttackStrength.Value = capitalShip.OverallAttackStrength;
        productionFamily.Value = capitalShip.ProductionFamily;
        refinedMaterialCost.Value = capitalShip.RefinedMaterialCost;
        researchDifficulty.Value = capitalShip.ResearchDifficulty;
        researchOrder.Value = capitalShip.ResearchOrder;
        shieldStrength.Value = capitalShip.ShieldStrength;
        shieldRechargeRate.Value = capitalShip.ShieldRechargeRate;
        subLightEngine.Value = capitalShip.SubLightEngine;
        textStraDllId.Value = capitalShip.TextStraDllId;
        tractorBeamPower.Value = capitalShip.TractorBeamPower;
        tractorBeamRange.Value = capitalShip.TractorBeamRange;
        troopCapacity.Value = capitalShip.TroopCapacity;
        turbolaserAft.Value = capitalShip.TurbolaserAft;
        turbolaserAttackStrength.Value = capitalShip.TurbolaserAttackStrength;
        turbolaserFore.Value = capitalShip.TurbolaserFore;
        turbolaserPort.Value = capitalShip.TurbolaserPort;
        turbolaserRange.Value = capitalShip.TurbolaserRange;
        turbolaserStarboard.Value = capitalShip.TurbolaserStarboard;
        uprisingDefense.Value = capitalShip.UprisingDefense;
        weaponRechargeRate.Value = capitalShip.WeaponRechargeRate;

        picture.SizeMode = PictureBoxSizeMode.Zoom;
        var edataId = 42 + selectorIndex;
        picture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000"));
        GameFile.UnsavedData = previousUnsavedData;
    }
    protected override void LoadSideInfo()
    {
        foreach (var ship in  GameFile.CapitalShips)
            ship.Name = TextStra.GetString(ship.TextStraDllId);
    }
    protected override void SaveSideInfo()
    {
        TextStra.SaveString(Convert.ToUInt16(textStraDllId.Value), name.Text);
        //EncyText.SaveString(Convert.ToUInt16(xxx.Value), name.Text);
    }
    private void UpdateTotals(int selectorIndex)
    {
        var capitalShip = GameFile.CapitalShips[selectorIndex];

        uint turboLaserAttackStrengthTmp = capitalShip.TurbolaserFore + capitalShip.TurbolaserAft + capitalShip.TurbolaserPort + capitalShip.TurbolaserStarboard;
        uint ionCannonAttackStrengthTmp = capitalShip.IonCannonFore + capitalShip.IonCannonAft + capitalShip.IonCannonPort + capitalShip.IonCannonStarboard;
        uint laserCannonAttackStrengthTmp = capitalShip.LaserCannonFore + capitalShip.LaserCannonAft + capitalShip.LaserCannonPort + capitalShip.LaserCannonStarboard;

        GameFile.CapitalShips[selector.Value].TurbolaserAttackStrength = turboLaserAttackStrengthTmp;
        GameFile.CapitalShips[selector.Value].IonCannonAttackStrength = ionCannonAttackStrengthTmp;
        GameFile.CapitalShips[selector.Value].LaserCannonAttackStrength = laserCannonAttackStrengthTmp;
        GameFile.CapitalShips[selector.Value].OverallAttackStrength = turboLaserAttackStrengthTmp + ionCannonAttackStrengthTmp + laserCannonAttackStrengthTmp;

        turbolaserAttackStrength.Value = capitalShip.TurbolaserAttackStrength;
        ionCannonAttackStrength.Value = capitalShip.IonCannonAttackStrength;
        laserCannonAttackStrength.Value = capitalShip.LaserCannonAttackStrength;
        overallAttackStrength.Value = capitalShip.OverallAttackStrength;
    }

    #endregion

    #region Changed events

    private void bombardmentModifier_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].BombardmentModifier = (uint)bombardmentModifier.Value;
        GameFile.UnsavedData = true;
    }
    private void damageControl_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].DamageControl = (uint)damageControl.Value;
        GameFile.UnsavedData = true;
    }
    private void detection_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].Detection = (uint)detection.Value;
        GameFile.UnsavedData = true;
    }
    private void encyclopediaDescription_TextChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].EncyclopediaDescription = encyclopediaDescription.Text;
        GameFile.UnsavedData = true;
    }
    private void familyId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].FamilyId = (uint)familyId.Value;
        GameFile.UnsavedData = true;
    }
    private void field2_1_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].Field2_1 = (ushort)field2_1.Value;
        GameFile.UnsavedData = true;
    }
    private void field51_0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].Field51_0 = (uint)field51_0.Value;
        GameFile.UnsavedData = true;
    }
    private void field7_2_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].Field7_2 = (ushort)field7_2.Value;
        GameFile.UnsavedData = true;
    }
    private void fighterCapacity_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].FighterCapacity = (uint)fighterCapacity.Value;
        GameFile.UnsavedData = true;
    }
    private void gravityWellProjector_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].GravityWellProjector = (uint)gravityWellProjector.Value;
        GameFile.UnsavedData = true;
    }
    private void hull_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].Hull = (uint)hull.Value;
        GameFile.UnsavedData = true;
    }
    private void hyperdrive_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].Hyperdrive = (uint)hyperdrive.Value;
        GameFile.UnsavedData = true;
    }
    private void hyperdriveIfDamaged_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].HyperdriveIfDamaged = (uint)hyperdriveIfDamaged.Value;
        GameFile.UnsavedData = true;
    }
    private void id_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].Id = (uint)id.Value;
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
    private void ionCannonAttackStrength_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].IonCannonAttackStrength = (uint)ionCannonAttackStrength.Value;
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
    private void isAlliance_CheckedChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].IsAlliance = isAlliance.Checked ? 1U : 0U;
        GameFile.UnsavedData = true;
    }
    private void isEmpire_CheckedChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].IsEmpire = isEmpire.Checked ? 1U : 0U;
        GameFile.UnsavedData = true;
    }
    private void laserCannonAft_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].LaserCannonAft = (uint)laserCannonAft.Value;
        UpdateTotals(selector.Value);
        GameFile.UnsavedData = true;
    }
    private void laserCannonAttackStrength_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].LaserCannonAttackStrength = (uint)laserCannonAttackStrength.Value;
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
    private void maneuverability_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].Maneuverability = (uint)maneuverability.Value;
        GameFile.UnsavedData = true;
    }
    private void name_TextChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].Name = name.Text;
        GameFile.UnsavedData = true;
    }
    private void nextProductionFamily_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].NextProductionFamily = (uint)nextProductionFamily.Value;
        GameFile.UnsavedData = true;
    }
    private void overallAttackStrength_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].OverallAttackStrength = (uint)overallAttackStrength.Value;
        GameFile.UnsavedData = true;
    }
    private void productionFamily_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].ProductionFamily = (uint)productionFamily.Value;
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
    private void subLightEngine_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].SubLightEngine = (uint)subLightEngine.Value;
        GameFile.UnsavedData = true;
    }
    private void textStraDllId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].TextStraDllId = (ushort)textStraDllId.Value;
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
    private void turbolaserAttackStrength_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].TurbolaserAttackStrength = (uint)turbolaserAttackStrength.Value;
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
    private void uprisingDefense_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].UprisingDefense = (uint)uprisingDefense.Value;
        GameFile.UnsavedData = true;
    }
    private void weaponRecharge_ValueChanged(object sender, EventArgs e)
    {
        GameFile.CapitalShips[selector.Value].WeaponRechargeRate = (uint)weaponRechargeRate.Value;
        GameFile.UnsavedData = true;
    }

    #endregion
}
