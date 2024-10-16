﻿namespace SwRebellionEditor;

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
        var generalParamTableEntry = GameFile.GeneralParamTableEntries[selectorIndex];
        id.Value = generalParamTableEntry.Id;
        idHexLabel.Text = "0x" + generalParamTableEntry.Id.ToString("X");
        field2_1.Value = generalParamTableEntry.Field2_1;
        parameterId.Value = generalParamTableEntry.ParameterId;
        allianceMultiPlayer.Value = generalParamTableEntry.AllianceMultiPlayer;
        allianceSinglePlayerEasy.Value = generalParamTableEntry.AllianceSinglePlayerEasy;
        allianceSinglePlayerMedium.Value = generalParamTableEntry.AllianceSinglePlayerMedium;
        allianceSinglePlayerHard.Value = generalParamTableEntry.AllianceSinglePlayerHard;
        empireSinglePlayerEasy.Value = generalParamTableEntry.EmpireSinglePlayerEasy;
        empireSinglePlayerMedium.Value = generalParamTableEntry.EmpireSinglePlayerMedium;
        empireSinglePlayerHard.Value = generalParamTableEntry.EmpireSinglePlayerHard;
        empireMultiPlayer.Value = generalParamTableEntry.EmpireMultiPlayer;
        name.Text = generalParamTableEntry.Name;
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
        GameFile.GeneralParamTableEntries[selector.Value].AllianceMultiPlayer = (int)allianceMultiPlayer.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceSinglePlayerEasy_ValueChanged(object sender, EventArgs e)
    {
        GameFile.GeneralParamTableEntries[selector.Value].AllianceSinglePlayerEasy = (int)allianceSinglePlayerEasy.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceSinglePlayerHard_ValueChanged(object sender, EventArgs e)
    {
        GameFile.GeneralParamTableEntries[selector.Value].AllianceSinglePlayerHard = (int)allianceSinglePlayerHard.Value;
        GameFile.UnsavedData = true;
    }
    private void allianceSinglePlayerMedium_ValueChanged(object sender, EventArgs e)
    {
        GameFile.GeneralParamTableEntries[selector.Value].AllianceSinglePlayerMedium = (int)allianceSinglePlayerMedium.Value;
        GameFile.UnsavedData = true;
    }
    private void empireMultiPlayer_ValueChanged(object sender, EventArgs e)
    {
        GameFile.GeneralParamTableEntries[selector.Value].EmpireMultiPlayer = (int)empireMultiPlayer.Value;
        GameFile.UnsavedData = true;
    }
    private void empireSinglePlayerEasy_ValueChanged(object sender, EventArgs e)
    {
        GameFile.GeneralParamTableEntries[selector.Value].EmpireSinglePlayerEasy = (int)empireSinglePlayerEasy.Value;
        GameFile.UnsavedData = true;
    }
    private void empireSinglePlayerHard_ValueChanged(object sender, EventArgs e)
    {
        GameFile.GeneralParamTableEntries[selector.Value].EmpireSinglePlayerHard = (int)empireSinglePlayerHard.Value;
        GameFile.UnsavedData = true;
    }
    private void empireSinglePlayerMedium_ValueChanged(object sender, EventArgs e)
    {
        GameFile.GeneralParamTableEntries[selector.Value].EmpireSinglePlayerMedium = (int)empireSinglePlayerMedium.Value;
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
    private void parameterId_ValueChanged(object sender, EventArgs e)
    {
        GameFile.GeneralParamTableEntries[selector.Value].ParameterId = (uint)parameterId.Value;
        GameFile.UnsavedData = true;
    }

    #endregion
}
