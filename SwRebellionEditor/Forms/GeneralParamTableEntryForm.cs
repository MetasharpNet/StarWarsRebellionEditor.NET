namespace SwRebellionEditor;

public partial class GeneralParamTableEntryForm : GeneralParamTableEntryDesignForm
{
    #region .ctor

    public GeneralParamTableEntryForm()
    {
        GameFilePath = Path.Combine(Settings.Current.GDataFolder, "GNPRTB.DAT");
        GameFile = DatFile.Load<GNPRTB>(GameFilePath);
        InitializeComponent();
        InitializeBaseComponent(selector);
        selector.Maximum = (int)GameFile.GeneralParamTableEntriesCount - 1;
    }

    #endregion

    #region Business Layer

    protected override void DisplaySelectedGameObject(int selectorIndex)
    {
        var previousUnsavedData = GameFile.UnsavedData;
        var sideParamEntry = GameFile.GeneralParamTableEntries[selectorIndex];
        id.Value = sideParamEntry.Id;
        field2_1.Value = sideParamEntry.Field2_1;
        unknown.Value = sideParamEntry.Unknown;
        allianceMultiPlayer.Value = sideParamEntry.AllianceMultiPlayer;
        allianceSinglePlayerEasy.Value = sideParamEntry.AllianceSinglePlayerEasy;
        allianceSinglePlayerMedium.Value = sideParamEntry.AllianceSinglePlayerMedium;
        allianceSinglePlayerHard.Value = sideParamEntry.AllianceSinglePlayerHard;
        empireSinglePlayerEasy.Value = sideParamEntry.EmpireSinglePlayerEasy;
        empireSinglePlayerMedium.Value = sideParamEntry.EmpireSinglePlayerMedium;
        empireSinglePlayerHard.Value = sideParamEntry.EmpireSinglePlayerHard;
        empireMultiPlayer.Value = sideParamEntry.EmpireMultiPlayer;
        name.Text = sideParamEntry.Name;
        GameFile.UnsavedData = previousUnsavedData;
    }
    protected override void LoadSideInfo()
    {
        foreach (var s in GameFile.GeneralParamTableEntries)
        {
        }
    }
    protected override void SaveSideInfo()
    {
    }

    #endregion

    #region Changed events

    private void allianceMultiPlayer_ValueChanged(object sender, EventArgs e)
    {
        GameFile.GeneralParamTableEntries[selector.Value].AllianceMultiPlayer = (uint)allianceMultiPlayer.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceSinglePlayerEasy_ValueChanged(object sender, EventArgs e)
    {
        GameFile.GeneralParamTableEntries[selector.Value].AllianceSinglePlayerEasy = (uint)allianceSinglePlayerEasy.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceSinglePlayerHard_ValueChanged(object sender, EventArgs e)
    {
        GameFile.GeneralParamTableEntries[selector.Value].AllianceSinglePlayerHard = (uint)allianceSinglePlayerHard.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceSinglePlayerMedium_ValueChanged(object sender, EventArgs e)
    {
        GameFile.GeneralParamTableEntries[selector.Value].AllianceSinglePlayerMedium = (uint)allianceSinglePlayerMedium.Value;
        GameFile.UnsavedData = true;
    }
    private void empireMultiPlayer_ValueChanged(object sender, EventArgs e)
    {
        GameFile.GeneralParamTableEntries[selector.Value].EmpireMultiPlayer = (uint)empireMultiPlayer.Value;
        GameFile.UnsavedData = true;
    }
    private void empireSinglePlayerEasy_ValueChanged(object sender, EventArgs e)
    {
        GameFile.GeneralParamTableEntries[selector.Value].EmpireSinglePlayerEasy = (uint)empireSinglePlayerEasy.Value;
        GameFile.UnsavedData = true;
    }
    private void empireSinglePlayerHard_ValueChanged(object sender, EventArgs e)
    {
        GameFile.GeneralParamTableEntries[selector.Value].EmpireSinglePlayerHard = (uint)empireSinglePlayerHard.Value;
        GameFile.UnsavedData = true;
    }
    private void empireSinglePlayerMedium_ValueChanged(object sender, EventArgs e)
    {
        GameFile.GeneralParamTableEntries[selector.Value].EmpireSinglePlayerMedium = (uint)empireSinglePlayerMedium.Value;
        GameFile.UnsavedData = true;
    }
    private void field2_1_ValueChanged(object sender, EventArgs e)
    {
        GameFile.GeneralParamTableEntries[selector.Value].Field2_1 = (uint)field2_1.Value;
        GameFile.UnsavedData = true;
    }
    private void id_ValueChanged(object sender, EventArgs e)
    {
        GameFile.GeneralParamTableEntries[selector.Value].Id = (uint)id.Value;
        GameFile.UnsavedData = true;
    }
    private void unknown_ValueChanged(object sender, EventArgs e)
    {
        GameFile.GeneralParamTableEntries[selector.Value].Unknown = (uint)unknown.Value;
        GameFile.UnsavedData = true;
    }

    #endregion
}
