namespace SwRebellionEditor;

public partial class CMUNAllianceTablesForm : CMUNAllianceTablesDesignForm
{
    #region .ctor

    public CMUNAllianceTablesForm()
    {
        GameFilePath = Path.Combine(Settings.Current.GDataFolder, "CMUNALTB.DAT");
        GameFile = DatFile.Load<CMUNALTB>(GameFilePath);
        InitializeComponent();
    }

    #endregion

    #region Business Layer

    public string[] CapitalShips = new string[]
        {
            "Alliance DreadNaught",
            "Alliance Escort Carrier",
            "Assault Frigate",
            "Bulk Cruiser",
            "Bulk Transport",
            "Bulwark Battlecruiser",
            "CC-7700 Frigate",
            "CC-9600 Frigate",
            "Corellian Corvette",
            "Corellian Gunship",
            "Dauntless Cruiser",
            "Liberator Cruiser",
            "Medium Transport",
            "Mon Calamari Cruiser",
            "Nebulon-B Frigate",
        };
    public string[] Units = new string[]
        {
            "A-wing",
            "B-wing",
            "X-wing",
            "Y-wing",
            "Alliance Army Regiment",
            "Alliance Fleet Regiment",
            "Mon Calamari Regiment",
            "Sullustan Regiment",
            "Wookie Regiment",
            "Bothian Spies",
            "Guerrillas",
            "Infiltrators",
            "Longmount Y-wing Recon Team",
        };

    protected override void DisplayGameItemsImages()
    {
        var previousUnsavedData = GameFile.UnsavedData;

        capitalShipComboBox.Items.AddRange(CapitalShips);
        capitalShipComboBox.Items.AddRange(Units);
        unitComboBox.Items.AddRange(CapitalShips);
        unitComboBox.Items.AddRange(Units);
        foreach (var army in GameFile.Armies)
        {
            armiesListView.Items.Add(new ListViewItem(new string[3]
                {
                    army.Index.ToString(),
                    army.Probability.ToString(),
                    army.ToString()
                }));
        }

        GameFile.UnsavedData = previousUnsavedData;
    }

    #endregion

    #region Changed events

    private void armiesListView_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (armiesListView.SelectedItems.Count != 1)
        {
            unitsListView.Items.Clear();
            return;
        }
        var armyId = Int32.Parse(armiesListView.SelectedItems[0].SubItems[0].Text);
        var army = GameFile.Armies[armyId - 1];
        unitsListView.Items.Clear();
        foreach (var unit in army.Units)
        {
            unitsListView.Items.Add(new ListViewItem(new string[2]
                {
                    unit.ToString(),
                    ""
                }));
        }
    }

    #endregion
}
