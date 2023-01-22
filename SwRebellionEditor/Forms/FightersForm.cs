namespace SwRebellionEditor;

public partial class FightersForm : FightersDesignForm
{
    #region .ctor

    public FightersForm()
    {
        GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\FIGHTSD.DAT";
        GameFile = DatFile.Load<FIGHTSD>(GameFilePath);
        InitializeComponent();
        InitializeBaseComponent(selector);
        selector.Maximum = (int)GameFile.FightersCount - 1;
    }

    #endregion

    #region Business Layer

    protected override void DisplaySelectedGameObject(int selectorIndex)
    {
        var previousUnsavedData = GameFile.UnsavedData;
        var fighter = GameFile.Fighters[selectorIndex];
        bombardmentDefense.Value = fighter.BombardmentDefense;
        detection.Value = fighter.Detection;
        encyclopediaDescription.Text = fighter.EncyclopediaDescription;
        familyId.Value = fighter.FamilyId;
        familyIdHexLabel.Text = "0x" + fighter.FamilyId.ToString("x");
        field2_1.Value = fighter.Field2_1;
        field7_2.Value = fighter.Field7_2;
        hyperdrive.Value = fighter.Hyperdrive;
        hyperdriveIfDamaged.Value = fighter.HyperdriveIfDamaged;
        id.Value = fighter.Id;
        idHexLabel.Text = "0x" + fighter.Id.ToString("X");
        ionCannonAft.Value = fighter.IonCannonAft;
        ionCannonAttackStrength.Value = fighter.IonCannonAttackStrength;
        ionCannonFore.Value = fighter.IonCannonFore;
        ionCannonPort.Value = fighter.IonCannonPort;
        ionCannonRange.Value = fighter.IonCannonRange;
        ionCannonStarboard.Value = fighter.IonCannonStarboard;
        isAlliance.Checked = fighter.IsAlliance > 0U;
        isEmpire.Checked = fighter.IsEmpire > 0U;
        laserCannonAft.Value = fighter.LaserCannonAft;
        laserCannonAttackStrength.Value = fighter.LaserCannonAttackStrength;
        laserCannonFore.Value = fighter.LaserCannonFore;
        laserCannonPort.Value = fighter.LaserCannonPort;
        laserCannonRange.Value = fighter.LaserCannonRange;
        laserCannonStarboard.Value = fighter.LaserCannonStarboard;
        maintenanceCost.Value = fighter.MaintenanceCost;
        maneuverability.Value = fighter.Maneuverability;
        name.Text = fighter.Name;
        nextProductionFamily.Value = fighter.NextProductionFamily;
        overallAttackStrength.Value = fighter.OverallAttackStrength;
        productionFamily.Value = fighter.ProductionFamily;
        refinedMaterialCost.Value = fighter.RefinedMaterialCost;
        researchDifficulty.Value = fighter.ResearchDifficulty;
        researchOrder.Value = fighter.ResearchOrder;
        shieldStrength.Value = fighter.ShieldStrength;
        squadronSize.Value = fighter.SquadronSize;
        subLightEngine.Value = fighter.SubLightEngine;
        textStraDllId.Value = fighter.TextStraDllId;
        torpedoes.Value = fighter.Torpedoes;
        torpedoesRange.Value = fighter.TorpedoesRange;
        turbolaserAft.Value = fighter.TurbolaserAft;
        turbolaserAttackStrength.Value = fighter.TurbolaserAttackStrength;
        turbolaserFore.Value = fighter.TurbolaserFore;
        turbolaserPort.Value = fighter.TurbolaserPort;
        turbolaserRange.Value = fighter.TurbolaserRange;
        turbolaserStarboard.Value = fighter.TurbolaserStarboard;
        uprisingDefense.Value = fighter.UprisingDefense;

        picture.SizeMode = PictureBoxSizeMode.Zoom;
        var edataId = 34 + selectorIndex;
        var filepath = RegistryKeys.InstalledLocation + "\\EData\\EDATA." + edataId.ToString("000");
        if (File.Exists(filepath))
            picture.Image = Image.FromFile(filepath);
        else
            picture.Image = null;
        GameFile.UnsavedData = previousUnsavedData;
    }
    protected override void LoadSideInfo()
    {
        foreach (var f in GameFile.Fighters)
        {
            f.Name = TextStra.Resources.GetString(f.TextStraDllId);
            f.EncyclopediaDescription = EncyText.Resources.GetRcdata((f.TextStraDllId - 4096).ToString());
        }
    }
    protected override void SaveSideInfo()
    {
        TextStra.Resources.SaveString(Convert.ToUInt16(textStraDllId.Value), name.Text);
        EncyText.Resources.UpdateRcdata((textStraDllId.Value - 4096).ToString(), encyclopediaDescription.Text);
    }
    private void UpdateTotals(int selectorIndex)
    {
        var fighter = GameFile.Fighters[selectorIndex];

        uint turboLaserAttackStrengthTmp = fighter.TurbolaserFore + fighter.TurbolaserAft + fighter.TurbolaserPort + fighter.TurbolaserStarboard;
        uint ionCannonAttackStrengthTmp = fighter.IonCannonFore + fighter.IonCannonAft + fighter.IonCannonPort + fighter.IonCannonStarboard;
        uint laserCannonAttackStrengthTmp = fighter.LaserCannonFore + fighter.LaserCannonAft + fighter.LaserCannonPort + fighter.LaserCannonStarboard;

        GameFile.Fighters[selector.Value].TurbolaserAttackStrength = turboLaserAttackStrengthTmp;
        GameFile.Fighters[selector.Value].IonCannonAttackStrength = ionCannonAttackStrengthTmp;
        GameFile.Fighters[selector.Value].LaserCannonAttackStrength = laserCannonAttackStrengthTmp;
        GameFile.Fighters[selector.Value].OverallAttackStrength = turboLaserAttackStrengthTmp + ionCannonAttackStrengthTmp + laserCannonAttackStrengthTmp;

        turbolaserAttackStrength.Value = fighter.TurbolaserAttackStrength;
        ionCannonAttackStrength.Value = fighter.IonCannonAttackStrength;
        laserCannonAttackStrength.Value = fighter.LaserCannonAttackStrength;
        //torpedoesAttackStrength.Value = fighter.Torpedoes;
        overallAttackStrength.Value = fighter.OverallAttackStrength;
    }

    #endregion

    #region Changed events

    private void bombardmentDefense_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].BombardmentDefense = (uint)bombardmentDefense.Value;
        GameFile.UnsavedData = true;
    }
    private void detection_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].Detection = (uint)detection.Value;
        GameFile.UnsavedData = true;
    }
    private void encyclopediaDescription_TextChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].EncyclopediaDescription = encyclopediaDescription.Text;
        GameFile.UnsavedData = true;
    }
    private void familyId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].FamilyId = (uint)familyId.Value;
        GameFile.UnsavedData = true;
    }
    private void field2_1_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].Field2_1 = (ushort)field2_1.Value;
        GameFile.UnsavedData = true;
    }
    private void field7_2_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].Field7_2 = (ushort)field7_2.Value;
        GameFile.UnsavedData = true;
    }
    private void hyperdrive_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].Hyperdrive = (uint)hyperdrive.Value;
        GameFile.UnsavedData = true;
    }
    private void hyperdriveIfDamaged_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].HyperdriveIfDamaged = (uint)hyperdriveIfDamaged.Value;
        GameFile.UnsavedData = true;
    }
    private void id_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].Id = (uint)id.Value;
        GameFile.UnsavedData = true;
    }
    private void ionCannonAft_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].IonCannonAft = (uint)ionCannonAft.Value;
        UpdateTotals(selector.Value);
        GameFile.UnsavedData = true;
    }
    private void ionCannonAttackStrength_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].IonCannonAttackStrength = (uint)ionCannonAttackStrength.Value;
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
    private void ionCannonStarboard_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].IonCannonStarboard = (uint)ionCannonStarboard.Value;
        UpdateTotals(selector.Value);
        GameFile.UnsavedData = true;
    }
    private void isAlliance_CheckedChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].IsAlliance = isAlliance.Checked ? 1U : 0U;
        GameFile.UnsavedData = true;
    }
    private void isEmpire_CheckedChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].IsEmpire = isEmpire.Checked ? 1U : 0U;
        GameFile.UnsavedData = true;
    }
    private void laserCannonAft_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].LaserCannonAft = (uint)laserCannonAft.Value;
        UpdateTotals(selector.Value);
        GameFile.UnsavedData = true;
    }
    private void laserCannonAttackStrength_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].LaserCannonAttackStrength = (uint)laserCannonAttackStrength.Value;
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
    private void laserCannonStarboard_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].LaserCannonStarboard = (uint)laserCannonStarboard.Value;
        UpdateTotals(selector.Value);
        GameFile.UnsavedData = true;
    }
    private void maintenanceCost_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].MaintenanceCost = (uint)maintenanceCost.Value;
        GameFile.UnsavedData = true;
    }
    private void maneuverability_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].Maneuverability = (uint)maneuverability.Value;
        GameFile.UnsavedData = true;
    }
    private void name_TextChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].Name = name.Text;
        GameFile.UnsavedData = true;
    }
    private void nextProductionFamily_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].NextProductionFamily = (uint)nextProductionFamily.Value;
        GameFile.UnsavedData = true;
    }
    private void overallAttackStrength_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].OverallAttackStrength = (uint)overallAttackStrength.Value;
        GameFile.UnsavedData = true;
    }
    private void productionFamily_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].ProductionFamily = (uint)productionFamily.Value;
        GameFile.UnsavedData = true;
    }
    private void refinedMaterialCost_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].RefinedMaterialCost = (uint)refinedMaterialCost.Value;
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
    private void shieldStrength_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].ShieldStrength = (uint)shieldStrength.Value;
        GameFile.UnsavedData = true;
    }
    private void squadronSize_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].SquadronSize = (uint)squadronSize.Value;
        GameFile.UnsavedData = true;
    }
    private void subLightEngine_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].SubLightEngine = (uint)subLightEngine.Value;
        GameFile.UnsavedData = true;
    }
    private void textStraDllId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].TextStraDllId = (ushort)textStraDllId.Value;
        GameFile.UnsavedData = true;
    }
    private void torpedoes_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].Torpedoes = (uint)torpedoes.Value;
        UpdateTotals(selector.Value);
        GameFile.UnsavedData = true;
    }
    private void torpedoesRange_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].TorpedoesRange = (uint)torpedoesRange.Value;
        UpdateTotals(selector.Value);
        GameFile.UnsavedData = true;
    }
    private void turbolaserAft_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].TurbolaserAft = (uint)turbolaserAft.Value;
        UpdateTotals(selector.Value);
        GameFile.UnsavedData = true;
    }
    private void turbolaserAttackStrength_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].TurbolaserAttackStrength = (uint)turbolaserAttackStrength.Value;
        UpdateTotals(selector.Value);
        GameFile.UnsavedData = true;
    }
    private void turbolaserFore_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].TurbolaserFore = (uint)turbolaserFore.Value;
        UpdateTotals(selector.Value);
        GameFile.UnsavedData = true;
    }
    private void turbolaserPort_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].TurbolaserPort = (uint)turbolaserPort.Value;
        UpdateTotals(selector.Value);
        GameFile.UnsavedData = true;
    }
    private void turbolaserRange_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].TurbolaserRange = (uint)turbolaserRange.Value;
        GameFile.UnsavedData = true;
    }
    private void turbolaserStarboard_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].TurbolaserStarboard = (uint)turbolaserStarboard.Value;
        UpdateTotals(selector.Value);
        GameFile.UnsavedData = true;
    }
    private void uprisingDefense_ValueChanged(object sender, EventArgs e)
    {
        GameFile.Fighters[selector.Value].UprisingDefense = (uint)uprisingDefense.Value;
        GameFile.UnsavedData = true;
    }

    #endregion
}
