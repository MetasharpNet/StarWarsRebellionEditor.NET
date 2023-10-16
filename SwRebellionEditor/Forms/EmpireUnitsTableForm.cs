namespace SwRebellionEditor;

public partial class EmpireUnitsTableForm : EmpireUnitsTableDesignForm
{
    #region .ctor

    public EmpireUnitsTableForm()
    {
        GameFilePath = Path.Combine(Settings.Current.GDataFolder, "CMUNEMTB.DAT");
        GameFile = DatFile.Load<CMUNEMTB>(GameFilePath);
        InitializeComponent();
    }

    #endregion

    #region Business Layer

    protected override void DisplayGameItemsImages()
    {
        var previousUnsavedData = GameFile.UnsavedData;

        groupComboBox.Items.AddRange(Identifier.EmpireCapitalShips);
        groupComboBox.Items.AddRange(Identifier.EmpireUnits);
        itemComboBox.Items.AddRange(Identifier.EmpireCapitalShips);
        itemComboBox.Items.AddRange(Identifier.EmpireUnits);
        foreach (var group in GameFile.Groups)
        {
            groupsDataGridView.Rows.Add(new object[3]
                {
                    group.Index,
                    group.RandomTreshold,
                    group.ToString()
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
        var orderedGroups = GameFile.Groups.OrderBy(f => f.RandomTreshold).ToList();
        for (int i = 0; i < orderedGroups.Count; i++)
        {
            orderedGroups[i].Index = (uint)i + 1;
            groupsDataGridView.Rows[i].Cells[0].Value = orderedGroups[i].Index;
            groupsDataGridView.Rows[i].Cells[1].Value = orderedGroups[i].RandomTreshold;
            groupsDataGridView.Rows[i].Cells[2].Value = orderedGroups[i].ToString();
        }
        GameFile.Groups = orderedGroups.ToArray();
        _eventsEnabled = true;
    }

    private void groupsDataGridView_SelectionChanged(object sender, EventArgs e)
    {
        if (groupsDataGridView.SelectedCells.Count != 1)
        {
            itemsListView.Items.Clear();
            return;
        }
        var groupId = Int32.Parse(groupsDataGridView.SelectedCells[0].RowIndex.ToString());
        var group = GameFile.Groups[groupId];
        groupsDataGridView.Rows[groupId].Cells[2].Value = group.ToString();
        itemsListView.Items.Clear();
        foreach (var item in group.Items)
        {
            itemsListView.Items.Add(new ListViewItem(new string[1] { item.ToString() }));
        }
    }
    private void groupsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (_eventsEnabled && e.ColumnIndex == 1 && e.RowIndex >= 0)
        {
            var groupId = e.RowIndex;
            var group = GameFile.Groups[groupId];
            group.RandomTreshold = uint.Parse(groupsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            UpdateIndexes();
            GameFile.UnsavedData = true;
        }
    }

    #endregion

    #region Add/Remove events

    private void addGroupButton_Click(object sender, EventArgs e)
    {
        if (groupComboBox.SelectedItem == null)
            return;
        var item = new CMUNEMTB_Item
            {
                Field1_1 = 1,
                Field2_0 = 0,
                Item = Identifier.ToValue(groupComboBox.Text)
            };
        var group = new CMUNEMTB_Group
            {
                Field2_1 = 1,
                Field4_1 = 1,
                Field5_1 = 1,
                Index = (uint)GameFile.Groups.Length + 1,
                RandomTreshold = 100,
                Items = new CMUNEMTB_Item[] { item },
                ItemsCount = 1
            };
        var groups = new List<CMUNEMTB_Group>(GameFile.Groups);
        groups.Add(group);
        GameFile.Groups = groups.ToArray();
        groupsDataGridView.Rows.Add(new object[3]
            {
                group.Index,
                group.RandomTreshold,
                group.ToString()
            });
        GameFile.GroupsCount++;
        GameFile.UnsavedData = true;
        groupsDataGridView_SelectionChanged(sender, e);
    }

    private void delGroupButton_Click(object sender, EventArgs e)
    {
        if (groupsDataGridView.SelectedCells.Count != 1)
            return;
        var groupId = Int32.Parse(groupsDataGridView.SelectedCells[0].RowIndex.ToString());
        var groups = new List<CMUNEMTB_Group>(GameFile.Groups);
        groups.RemoveAt(groupId);
        GameFile.Groups = groups.ToArray();
        groupsDataGridView.Rows.RemoveAt(groupId);
        itemsListView.Items.Clear();
        GameFile.GroupsCount--;
        GameFile.UnsavedData = true;
        for (int i = 0; i < GameFile.Groups.Length; i++)
        {
            GameFile.Groups[i].Index = (uint)i + 1;
            groupsDataGridView.Rows[i].Cells[0].Value = GameFile.Groups[i].Index;
        }
        UpdateIndexes();
        groupsDataGridView_SelectionChanged(sender, e);
        if (GameFile.GroupsCount > 0)
            groupsDataGridView.CurrentCell = groupsDataGridView.Rows[(int)Math.Min(groupId, GameFile.GroupsCount - 1)].Cells[2];
    }

    private void addItemButton_Click(object sender, EventArgs e)
    {
        if (groupsDataGridView.SelectedCells.Count != 1)
            return;
        if (itemComboBox.SelectedItem == null)
            return;
        var groupId = Int32.Parse(groupsDataGridView.SelectedCells[0].RowIndex.ToString());
        var group = GameFile.Groups[groupId];
        var items = new List<CMUNEMTB_Item>(group.Items);
        items.Add(new CMUNEMTB_Item
            {
                Field1_1 = 1,
                Field2_0 = 0,
                Item = Identifier.ToValue(itemComboBox.Text)
            });
        group.Items = items.ToArray();
        group.ItemsCount = (uint)items.Count;
        GameFile.UnsavedData = true;
        groupsDataGridView_SelectionChanged(sender, e);
    }

    private void delItemButton_Click(object sender, EventArgs e)
    {
        if (groupsDataGridView.SelectedCells.Count != 1)
            return;
        if (itemsListView.SelectedItems.Count != 1)
            return;
        var itemId = Int32.Parse(itemsListView.SelectedIndices[0].ToString());
        if (itemId == 0)
            return;
        var groupId = Int32.Parse(groupsDataGridView.SelectedCells[0].RowIndex.ToString());
        var group = GameFile.Groups[groupId];
        var items = new List<CMUNEMTB_Item>(group.Items);
        items.RemoveAt(itemId);
        group.Items = items.ToArray();
        group.ItemsCount = (uint)items.Count;
        GameFile.UnsavedData = true;
        groupsDataGridView_SelectionChanged(sender, e);
        itemsListView.Items[(int)Math.Min(itemId, group.ItemsCount - 1)].Selected = true;
    }

    #endregion
}
