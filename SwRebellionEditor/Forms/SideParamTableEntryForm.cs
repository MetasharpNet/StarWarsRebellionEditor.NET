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
        var sideParamTableEntry = GameFile.SideParamTableEntries[selectorIndex];
        id.Value = sideParamTableEntry.Id;
        idHexLabel.Text = "0x" + sideParamTableEntry.Id.ToString("X");
        field2_1.Value = sideParamTableEntry.Field2_1;
        unknown.Value = sideParamTableEntry.Unknown;
        allianceMultiPlayerAlliance.Value = sideParamTableEntry.AllianceMultiPlayerAlliance;
        allianceMultiPlayerEmpire.Value = sideParamTableEntry.AllianceMultiPlayerEmpire;
        allianceSinglePlayerEasyAlliance.Value = sideParamTableEntry.AllianceSinglePlayerEasyAlliance;
        allianceSinglePlayerEasyEmpire.Value = sideParamTableEntry.AllianceSinglePlayerEasyEmpire;
        allianceSinglePlayerMediumAlliance.Value = sideParamTableEntry.AllianceSinglePlayerMediumAlliance;
        allianceSinglePlayerMediumEmpire.Value = sideParamTableEntry.AllianceSinglePlayerMediumEmpire;
        allianceSinglePlayerHardAlliance.Value = sideParamTableEntry.AllianceSinglePlayerHardAlliance;
        allianceSinglePlayerHardEmpire.Value = sideParamTableEntry.AllianceSinglePlayerHardEmpire;
        empireSinglePlayerEasyAlliance.Value = sideParamTableEntry.EmpireSinglePlayerEasyAlliance;
        empireSinglePlayerEasyEmpire.Value = sideParamTableEntry.EmpireSinglePlayerEasyEmpire;
        empireSinglePlayerMediumAlliance.Value = sideParamTableEntry.EmpireSinglePlayerMediumAlliance;
        empireSinglePlayerMediumEmpire.Value = sideParamTableEntry.EmpireSinglePlayerMediumEmpire;
        empireSinglePlayerHardAlliance.Value = sideParamTableEntry.EmpireSinglePlayerHardAlliance;
        empireSinglePlayerHardEmpire.Value = sideParamTableEntry.EmpireSinglePlayerHardEmpire;
        empireMultiPlayerAlliance.Value = sideParamTableEntry.EmpireMultiPlayerAlliance;
        empireMultiPlayerEmpire.Value = sideParamTableEntry.EmpireMultiPlayerEmpire;
        name.Text = sideParamTableEntry.Name;
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
        GameFile.SideParamTableEntries[selector.Value].AllianceMultiPlayerAlliance = (int)allianceMultiPlayerAlliance.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceMultiPlayerEmpire_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].AllianceMultiPlayerEmpire = (int)allianceMultiPlayerEmpire.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceSinglePlayerEasyAlliance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].AllianceSinglePlayerEasyAlliance = (int)allianceSinglePlayerEasyAlliance.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceSinglePlayerEasyEmpire_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].AllianceSinglePlayerEasyEmpire = (int)allianceSinglePlayerEasyEmpire.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceSinglePlayerHardAlliance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].AllianceSinglePlayerHardAlliance = (int)allianceSinglePlayerHardAlliance.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceSinglePlayerHardEmpire_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].AllianceSinglePlayerHardEmpire = (int)allianceSinglePlayerHardEmpire.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceSinglePlayerMediumAlliance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].AllianceSinglePlayerMediumAlliance = (int)allianceSinglePlayerMediumAlliance.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceSinglePlayerMediumEmpire_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].AllianceSinglePlayerMediumEmpire = (int)allianceSinglePlayerMediumEmpire.Value;
        GameFile.UnsavedData = true;
    }
    private void empireMultiPlayerAlliance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].EmpireMultiPlayerAlliance = (int)empireMultiPlayerAlliance.Value;
        GameFile.UnsavedData = true;
    }
    private void empireMultiPlayerEmpire_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].EmpireMultiPlayerEmpire = (int)empireMultiPlayerEmpire.Value;
        GameFile.UnsavedData = true;
    }
    private void empireSinglePlayerEasyAlliance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].EmpireSinglePlayerEasyAlliance = (int)empireSinglePlayerEasyAlliance.Value;
        GameFile.UnsavedData = true;
    }
    private void empireSinglePlayerEasyEmpire_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].EmpireSinglePlayerEasyEmpire = (int)empireSinglePlayerEasyEmpire.Value;
        GameFile.UnsavedData = true;
    }
    private void empireSinglePlayerHardAlliance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].EmpireSinglePlayerHardAlliance = (int)empireSinglePlayerHardAlliance.Value;
        GameFile.UnsavedData = true;
    }
    private void empireSinglePlayerHardEmpire_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].EmpireSinglePlayerHardEmpire = (int)empireSinglePlayerHardEmpire.Value;
        GameFile.UnsavedData = true;
    }
    private void empireSinglePlayerMediumAlliance_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].EmpireSinglePlayerMediumAlliance = (int)empireSinglePlayerMediumAlliance.Value;
        GameFile.UnsavedData = true;
    }
    private void empireSinglePlayerMediumEmpire_ValueChanged(object sender, EventArgs e)
    {
        GameFile.SideParamTableEntries[selector.Value].EmpireSinglePlayerMediumEmpire = (int)empireSinglePlayerMediumEmpire.Value;
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
