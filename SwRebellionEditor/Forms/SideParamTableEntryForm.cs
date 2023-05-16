namespace SwRebellionEditor;

public partial class SideParamTableEntryForm : SideParamTableEntryDesignForm
{
    #region .ctor

    public SideParamTableEntryForm()
    {
        GameFilePath = Path.Combine(Settings.Current.GDataFolder, "SDPRTB.DAT");
        GameFile = DatFile.Load<SDPRTB>(GameFilePath);
        InitializeComponent();
        InitializeBaseComponent(selector);
        selector.Maximum = (int)GameFile.SideParamTableEntriesCount - 1;
    }

    #endregion

    #region Business Layer

    protected override void DisplaySelectedGameObject(int selectorIndex)
    {
        var previousUnsavedData = GameFile.UnsavedData;
        var sideParamEntry = GameFile.SideParamTableEntries[selectorIndex];
        id.Value = sideParamEntry.Id;
        field2_1.Value = sideParamEntry.Field2_1;
        unknown.Value = sideParamEntry.Unknown;
        allianceMultiPlayerAlliance.Value = sideParamEntry.AllianceMultiPlayerAlliance;
        allianceMultiPlayerEmpire.Value = sideParamEntry.AllianceMultiPlayerEmpire;
        allianceSinglePlayerEasyAlliance.Value = sideParamEntry.AllianceSinglePlayerEasyAlliance;
        allianceSinglePlayerEasyEmpire.Value = sideParamEntry.AllianceSinglePlayerEasyEmpire;
        allianceSinglePlayerMediumAlliance.Value = sideParamEntry.AllianceSinglePlayerMediumAlliance;
        allianceSinglePlayerMediumEmpire.Value = sideParamEntry.AllianceSinglePlayerMediumEmpire;
        allianceSinglePlayerHardAlliance.Value = sideParamEntry.AllianceSinglePlayerHardAlliance;
        allianceSinglePlayerHardEmpire.Value = sideParamEntry.AllianceSinglePlayerHardEmpire;
        empireSinglePlayerEasyAlliance.Value = sideParamEntry.EmpireSinglePlayerEasyAlliance;
        empireSinglePlayerEasyEmpire.Value = sideParamEntry.EmpireSinglePlayerEasyEmpire;
        empireSinglePlayerMediumAlliance.Value = sideParamEntry.EmpireSinglePlayerMediumAlliance;
        empireSinglePlayerMediumEmpire.Value = sideParamEntry.EmpireSinglePlayerMediumEmpire;
        empireSinglePlayerHardAlliance.Value = sideParamEntry.EmpireSinglePlayerHardAlliance;
        empireSinglePlayerHardEmpire.Value = sideParamEntry.EmpireSinglePlayerHardEmpire;
        empireMultiPlayerAlliance.Value = sideParamEntry.EmpireMultiPlayerAlliance;
        empireMultiPlayerEmpire.Value = sideParamEntry.EmpireMultiPlayerEmpire;
        name.Text = sideParamEntry.Name;
        GameFile.UnsavedData = previousUnsavedData;
    }
    protected override void LoadSideInfo()
    {
        foreach (var s in GameFile.SideParamTableEntries)
        {
        }
    }
    protected override void SaveSideInfo()
    {
    }

    #endregion

    #region Changed events

    private void allianceMultiPlayerAlliance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].AllianceMultiPlayerAlliance = (uint)allianceMultiPlayerAlliance.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceMultiPlayerEmpire_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].AllianceMultiPlayerEmpire = (uint)allianceMultiPlayerEmpire.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceSinglePlayerEasyAlliance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].AllianceSinglePlayerEasyAlliance = (uint)allianceSinglePlayerEasyAlliance.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceSinglePlayerEasyEmpire_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].AllianceSinglePlayerEasyEmpire = (uint)allianceSinglePlayerEasyEmpire.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceSinglePlayerHardAlliance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].AllianceSinglePlayerHardAlliance = (uint)allianceSinglePlayerHardAlliance.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceSinglePlayerHardEmpire_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].AllianceSinglePlayerHardEmpire = (uint)allianceSinglePlayerHardEmpire.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceSinglePlayerMediumAlliance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].AllianceSinglePlayerMediumAlliance = (uint)allianceSinglePlayerMediumAlliance.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceSinglePlayerMediumEmpire_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].AllianceSinglePlayerMediumEmpire = (uint)allianceSinglePlayerMediumEmpire.Value;
        GameFile.UnsavedData = true;
    }
    private void empireMultiPlayerAlliance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].EmpireMultiPlayerAlliance = (uint)empireMultiPlayerAlliance.Value;
        GameFile.UnsavedData = true;
    }
    private void empireMultiPlayerEmpire_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].EmpireMultiPlayerEmpire = (uint)empireMultiPlayerEmpire.Value;
        GameFile.UnsavedData = true;
    }
    private void empireSinglePlayerEasyAlliance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].EmpireSinglePlayerEasyAlliance = (uint)empireSinglePlayerEasyAlliance.Value;
        GameFile.UnsavedData = true;
    }
    private void empireSinglePlayerEasyEmpire_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].EmpireSinglePlayerEasyEmpire = (uint)empireSinglePlayerEasyEmpire.Value;
        GameFile.UnsavedData = true;
    }
    private void empireSinglePlayerHardAlliance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].EmpireSinglePlayerHardAlliance = (uint)empireSinglePlayerHardAlliance.Value;
        GameFile.UnsavedData = true;
    }
    private void empireSinglePlayerHardEmpire_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].EmpireSinglePlayerHardEmpire = (uint)empireSinglePlayerHardEmpire.Value;
        GameFile.UnsavedData = true;
    }
    private void empireSinglePlayerMediumAlliance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].EmpireSinglePlayerMediumAlliance = (uint)empireSinglePlayerMediumAlliance.Value;
        GameFile.UnsavedData = true;
    }
    private void empireSinglePlayerMediumEmpire_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].EmpireSinglePlayerMediumEmpire = (uint)empireSinglePlayerMediumEmpire.Value;
        GameFile.UnsavedData = true;
    }
    private void field2_1_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].Field2_1 = (uint)field2_1.Value;
        GameFile.UnsavedData = true;
    }
    private void id_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].Id = (uint)id.Value;
        GameFile.UnsavedData = true;
    }
    private void unknown_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].Unknown = (uint)unknown.Value;
        GameFile.UnsavedData = true;
    }

    #endregion
}
