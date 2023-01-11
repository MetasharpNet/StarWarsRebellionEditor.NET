namespace SwRebellionEditor;

public partial class GeneralParametersTablesForm : GeneralParametersTablesDesignForm
{
    #region .ctor

    public GeneralParametersTablesForm()
    {
        GameFilePath = RegistryKeys.InstalledLocation + "\\GData\\GNPRTB.DAT";
        GameFile = DatFile.Load<GNPRTB>(GameFilePath);
        InitializeComponent();
    }

    #endregion

    #region Business Layer

    protected override void DisplaySelectedGameObject(int selectorIndex)
    {
        var previousUnsavedData = GameFile.UnsavedData;
        allianceExpertHyperspaceSpeedMod.Value = GameFile.AllianceExpertHyperspaceSpeedMod;
        allianceIntermediateHyperspaceSpeedMod.Value = GameFile.AllianceIntermediateHyperspaceSpeedMod;
        allianceNoviceHyperspaceSpeedMod.Value = GameFile.AllianceNoviceHyperspaceSpeedMod;
        allianceUnknown.Value = GameFile.AllianceUnknown;
        empireExpertHyperspaceSpeedMod.Value = GameFile.EmpireExpertHyperspaceSpeedMod;
        empireIntermediateHyperspaceSpeedMod.Value = GameFile.EmpireIntermediateHyperspaceSpeedMod;
        empireNoviceHyperspaceSpeedMod.Value = GameFile.EmpireNoviceHyperspaceSpeedMod;
        empireUnknown.Value = GameFile.EmpireUnknown;
        falconExpertHyperspaceSpeedMod.Value = GameFile.FalconExpertHyperspaceSpeedMod;
        falconIntermediateHyperspaceSpeedMod.Value = GameFile.FalconIntermediateHyperspaceSpeedMod;
        falconNoviceHyperspaceSpeedMod.Value = GameFile.FalconNoviceHyperspaceSpeedMod;
        falconUnknown1.Value = GameFile.FalconUnknown1;
        falconUnknown2.Value = GameFile.FalconUnknown2;
        falconUnknown3.Value = GameFile.FalconUnknown3;
        falconUnknown4.Value = GameFile.FalconUnknown4;
        falconUnknown5.Value = GameFile.FalconUnknown5;
        GameFile.UnsavedData = previousUnsavedData;
    }

    #endregion

    #region Changed events

    private void allianceExpertHyperspaceSpeedMod_ValueChanged(object sender, EventArgs e)
    {
        GameFile.AllianceExpertHyperspaceSpeedMod = (uint)allianceExpertHyperspaceSpeedMod.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceIntermediateHyperspaceSpeedMod_ValueChanged(object sender, EventArgs e)
    {
        GameFile.AllianceIntermediateHyperspaceSpeedMod = (uint)allianceIntermediateHyperspaceSpeedMod.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceNoviceHyperspaceSpeedMod_ValueChanged(object sender, EventArgs e)
    {
        GameFile.AllianceNoviceHyperspaceSpeedMod = (uint)allianceNoviceHyperspaceSpeedMod.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceUnknown_ValueChanged(object sender, EventArgs e)
    {
        GameFile.AllianceUnknown = (uint)allianceUnknown.Value;
        GameFile.UnsavedData = true;
    }
    private void empireExpertHyperspaceSpeedMod_ValueChanged(object sender, EventArgs e)
    {
        GameFile.EmpireExpertHyperspaceSpeedMod = (uint)empireExpertHyperspaceSpeedMod.Value;
        GameFile.UnsavedData = true;
    }
    private void empireIntermediateHyperspaceSpeedMod_ValueChanged(object sender, EventArgs e)
    {
        GameFile.EmpireIntermediateHyperspaceSpeedMod = (uint)empireIntermediateHyperspaceSpeedMod.Value;
        GameFile.UnsavedData = true;
    }
    private void empireNoviceHyperspaceSpeedMod_ValueChanged(object sender, EventArgs e)
    {
        GameFile.EmpireNoviceHyperspaceSpeedMod = (uint)empireNoviceHyperspaceSpeedMod.Value;
        GameFile.UnsavedData = true;
    }
    private void empireUnknown_ValueChanged(object sender, EventArgs e)
    {
        GameFile.EmpireUnknown = (uint)empireUnknown.Value;
        GameFile.UnsavedData = true;
    }
    private void falconExpertHyperspaceSpeedMod_ValueChanged(object sender, EventArgs e)
    {
        GameFile.FalconExpertHyperspaceSpeedMod = (uint)falconExpertHyperspaceSpeedMod.Value;
        GameFile.UnsavedData = true;
    }
    private void falconIntermediateHyperspaceSpeedMod_ValueChanged(object sender, EventArgs e)
    {
        GameFile.FalconIntermediateHyperspaceSpeedMod = (uint)falconIntermediateHyperspaceSpeedMod.Value;
        GameFile.UnsavedData = true;
    }
    private void falconNoviceHyperspaceSpeedMod_ValueChanged(object sender, EventArgs e)
    {
        GameFile.FalconNoviceHyperspaceSpeedMod = (uint)falconNoviceHyperspaceSpeedMod.Value;
        GameFile.UnsavedData = true;
    }
    private void falconUnknown1_ValueChanged(object sender, EventArgs e)
    {
        GameFile.FalconUnknown1 = (uint)falconUnknown1.Value;
        GameFile.UnsavedData = true;
    }
    private void falconUnknown2_ValueChanged(object sender, EventArgs e)
    {
        GameFile.FalconUnknown2 = (uint)falconUnknown2.Value;
        GameFile.UnsavedData = true;
    }
    private void falconUnknown3_ValueChanged(object sender, EventArgs e)
    {
        GameFile.FalconUnknown3 = (uint)falconUnknown3.Value;
        GameFile.UnsavedData = true;
    }
    private void falconUnknown4_ValueChanged(object sender, EventArgs e)
    {
        GameFile.FalconUnknown4 = (uint)falconUnknown4.Value;
        GameFile.UnsavedData = true;
    }
    private void falconUnknown5_ValueChanged(object sender, EventArgs e)
    {
        GameFile.FalconUnknown5 = (uint)falconUnknown5.Value;
        GameFile.UnsavedData = true;
    }

    #endregion
}
