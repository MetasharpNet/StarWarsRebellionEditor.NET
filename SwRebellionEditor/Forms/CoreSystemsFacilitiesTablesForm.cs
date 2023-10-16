namespace SwRebellionEditor;

public partial class CoreSystemsFacilitiesTablesForm : CoreSystemsFacilitiesTablesDesignForm
{
    #region .ctor

    public CoreSystemsFacilitiesTablesForm()
    {
        GameFilePath = Path.Combine(Settings.Current.GDataFolder, "SYFCCRTB.DAT");
        GameFile = DatFile.Load<SYFCCRTB>(GameFilePath);
        InitializeComponent();
    }

    #endregion

    #region Business Layer

    protected override void DisplayGameItemsImages()
    {
        var previousUnsavedData = GameFile.UnsavedData;
        facilityComboBox.Items.AddRange(Identifier.Facilities.Where(f => f != "Alliance Headquarters").ToArray());
        foreach (var facility in GameFile.Facilities)
        {
            facilitiesDataGridView.Rows.Add(new object[3]
                {
                    facility.Entry,
                    facility.RandomTreshold,
                    facility.ToString()
                });
        }
        GameFile.UnsavedData = previousUnsavedData;
    }

    #endregion

    #region Changed events

    private bool _eventsEnabled = true;

    private void UpdateIndexes()
    {
        _eventsEnabled = false;
        var orderedFacilities = GameFile.Facilities.OrderBy(f => f.RandomTreshold).ToList();
        for (int i = 0; i < orderedFacilities.Count; i++)
        {
            orderedFacilities[i].Entry = (uint)i + 1;
            facilitiesDataGridView.Rows[i].Cells[0].Value = orderedFacilities[i].Entry;
            facilitiesDataGridView.Rows[i].Cells[1].Value = orderedFacilities[i].RandomTreshold;
            facilitiesDataGridView.Rows[i].Cells[2].Value = orderedFacilities[i].ToString();
        }
        GameFile.Facilities = orderedFacilities.ToArray();
        _eventsEnabled = true;
    }

    private void facilitiesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (_eventsEnabled && e.ColumnIndex == 1 && e.RowIndex >= 0)
        {
            var facilityId = e.RowIndex;
            var facility = GameFile.Facilities[facilityId];
            facility.RandomTreshold = uint.Parse(facilitiesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            UpdateIndexes();
            GameFile.UnsavedData = true;
            _eventsEnabled = true;
        }
    }

    #endregion

    #region Add/Remove events

    private void addGroupButton_Click(object sender, EventArgs e)
    {
        if (facilityComboBox.SelectedItem == null)
            return;
        var facility = new SYFCCRTB_Facility
        {
            Entry = (uint)GameFile.Facilities.Length + 1,
            Field2_1 = 1,
            RandomTreshold = 100,
            Facility = Identifier.ToValue(facilityComboBox.SelectedItem.ToString())
        };
        var facilities = new List<SYFCCRTB_Facility>(GameFile.Facilities);
        facilities.Add(facility);
        GameFile.Facilities = facilities.ToArray();
        facilitiesDataGridView.Rows.Add(new object[3]
            {
                facility.Entry,
                facility.RandomTreshold,
                facility.ToString()
            });
        GameFile.FacilitiesCount++;
        GameFile.UnsavedData = true;
    }

    private void delGroupButton_Click(object sender, EventArgs e)
    {
        if (facilitiesDataGridView.SelectedCells.Count != 1)
            return;
        var facilityId = Int32.Parse(facilitiesDataGridView.SelectedCells[0].RowIndex.ToString());
        var facilities = new List<SYFCCRTB_Facility>(GameFile.Facilities);
        facilities.RemoveAt(facilityId);
        GameFile.Facilities = facilities.ToArray();
        facilitiesDataGridView.Rows.RemoveAt(facilityId);
        GameFile.FacilitiesCount--;
        GameFile.UnsavedData = true;
        UpdateIndexes();
        if (GameFile.FacilitiesCount > 0)
            facilitiesDataGridView.CurrentCell = facilitiesDataGridView.Rows[(int)Math.Min(facilityId, GameFile.FacilitiesCount - 1)].Cells[2];
    }

    #endregion
}
