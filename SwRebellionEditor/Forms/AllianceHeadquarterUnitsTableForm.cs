namespace SwRebellionEditor;

public partial class AllianceHeadquarterUnitsTableForm : AllianceHeadquarterUnitsTableDesignForm
{
    #region .ctor

    public AllianceHeadquarterUnitsTableForm()
    {
        GameFilePath = Path.Combine(Settings.Current.GDataFolder, "CMUNHQTB.DAT");
        GameFile = DatFile.Load<CMUNHQTB>(GameFilePath);
        InitializeComponent();
    }

    #endregion

    #region Business Layer

    protected override void DisplayGameItemsImages()
    {
        var previousUnsavedData = GameFile.UnsavedData;

        armyComboBox.Items.AddRange(Identifier.AllianceCapitalShips);
        armyComboBox.Items.AddRange(Identifier.AllianceUnits);
        unitComboBox.Items.AddRange(Identifier.AllianceCapitalShips);
        unitComboBox.Items.AddRange(Identifier.AllianceUnits);
        foreach (var army in GameFile.Armies)
        {
            armiesDataGridView.Rows.Add(new object[3]
            {
                    army.Index,
                    army.Probability,
                    army.ToString()
                });
        }

        GameFile.UnsavedData = previousUnsavedData;
    }

    #endregion

    #region Changed events

    private void armiesDataGridView_SelectionChanged(object sender, EventArgs e)
    {
        if (armiesDataGridView.SelectedCells.Count != 1)
        {
            unitsListView.Items.Clear();
            return;
        }
        var armyId = Int32.Parse(armiesDataGridView.SelectedCells[0].RowIndex.ToString());
        var army = GameFile.Armies[armyId];
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
    private void armiesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == 1 && e.RowIndex >= 0)
        {
            var armyId = e.RowIndex;
            var army = GameFile.Armies[armyId];
            army.Probability = uint.Parse(armiesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            GameFile.UnsavedData = true;
        }
    }

    #endregion

    #region Add/Remove events

    private void addArmyButton_Click(object sender, EventArgs e)
    {
        if (armyComboBox.SelectedItem == null)
            return;
        var unit = new CMUNHQTB_Unit()
        {
            Field1_1 = 1,
            Field2_0 = 0,
            Unit = Identifier.ToValue(armyComboBox.Text)
        };
        var army = new CMUNHQTB_Army()
        {
            Field2_1 = 1,
            Field4_1 = 1,
            Field5_1 = 1,
            Index = (uint)GameFile.Armies.Length + 1,
            Probability = 100,
            Units = new CMUNHQTB_Unit[] { unit },
            UnitsCount = 1
        };
        var armies = new List<CMUNHQTB_Army>(GameFile.Armies);
        armies.Add(army);
        GameFile.Armies = armies.ToArray();
        armiesDataGridView.Rows.Add(new object[3]
            {
                army.Index,
                army.Probability,
                army.ToString()
            });
        GameFile.ArmiesCount++;
        GameFile.UnsavedData = true;
        armiesDataGridView_SelectionChanged(sender, e);
    }

    private void delArmyButton_Click(object sender, EventArgs e)
    {
        if (armiesDataGridView.SelectedCells.Count != 1)
            return;
        var armyId = Int32.Parse(armiesDataGridView.SelectedCells[0].RowIndex.ToString());
        var armies = new List<CMUNHQTB_Army>(GameFile.Armies);
        armies.RemoveAt(armyId);
        GameFile.Armies = armies.ToArray();
        armiesDataGridView.Rows.RemoveAt(armyId);
        unitsListView.Items.Clear();
        GameFile.ArmiesCount--;
        GameFile.UnsavedData = true;
        armiesDataGridView_SelectionChanged(sender, e);
        if (GameFile.ArmiesCount > 0)
            armiesDataGridView.CurrentCell = armiesDataGridView.Rows[(int)Math.Min(armyId, GameFile.ArmiesCount - 1)].Cells[2];
    }

    private void addUnitButton_Click(object sender, EventArgs e)
    {
        if (armiesDataGridView.SelectedCells.Count != 1)
            return;
        if (unitComboBox.SelectedItem == null)
            return;
        var armyId = Int32.Parse(armiesDataGridView.SelectedCells[0].RowIndex.ToString());
        var army = GameFile.Armies[armyId];
        var units = new List<CMUNHQTB_Unit>(army.Units);
        units.Add(new CMUNHQTB_Unit()
        {
            Field1_1 = 1,
            Field2_0 = 0,
            Unit = Identifier.ToValue(unitComboBox.Text)
        });
        army.Units = units.ToArray();
        army.UnitsCount = (uint)units.Count;
        GameFile.UnsavedData = true;
        armiesDataGridView_SelectionChanged(sender, e);
    }

    private void delUnitButton_Click(object sender, EventArgs e)
    {
        if (armiesDataGridView.SelectedCells.Count != 1)
            return;
        if (unitsListView.SelectedItems.Count != 1)
            return;
        var unitId = Int32.Parse(unitsListView.SelectedIndices[0].ToString());
        if (unitId == 0)
            return;
        var armyId = Int32.Parse(armiesDataGridView.SelectedCells[0].RowIndex.ToString());
        var army = GameFile.Armies[armyId];
        var units = new List<CMUNHQTB_Unit>(army.Units);
        units.RemoveAt(unitId);
        army.Units = units.ToArray();
        army.UnitsCount = (uint)units.Count;
        GameFile.UnsavedData = true;
        armiesDataGridView_SelectionChanged(sender, e);
        unitsListView.Items[(int)Math.Min(unitId, army.UnitsCount - 1)].Selected = true;
    }

    #endregion
}
