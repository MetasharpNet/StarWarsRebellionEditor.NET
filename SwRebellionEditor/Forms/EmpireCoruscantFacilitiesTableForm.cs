﻿namespace SwRebellionEditor;

public partial class EmpireCoruscantFacilitiesTableForm : EmpireCoruscantFacilitiesTableDesignForm
{
    #region .ctor

    public EmpireCoruscantFacilitiesTableForm()
    {
        GameFilePath = Path.Combine(Settings.Current.GDataFolder, "FACLCRTB.DAT");
        GameFile = DatFile.Load<FACLCRTB>(GameFilePath);
        InitializeComponent();
    }

    #endregion

    #region Business Layer

    protected override void DisplayGameItemsImages()
    {
        var previousUnsavedData = GameFile.UnsavedData;
        groupComboBox.Items.AddRange(Identifier.Facilities.Where(f => f != "Alliance Headquarters").ToArray());
        itemComboBox.Items.AddRange(Identifier.Facilities.Where(f => f != "Alliance Headquarters").ToArray());
        foreach (var group in GameFile.Groups)
        {
            groupsDataGridView.Rows.Add(new object[2] { group.Entry, group.ToString() });
        }
        GameFile.UnsavedData = previousUnsavedData;
    }

    #endregion

    #region Changed events

    private void groupsDataGridView_SelectionChanged(object sender, EventArgs e)
    {
        if (groupsDataGridView.SelectedCells.Count != 1)
        {
            itemsListView.Items.Clear();
            return;
        }
        var groupId = Int32.Parse(groupsDataGridView.SelectedCells[0].RowIndex.ToString());
        var group = GameFile.Groups[groupId];
        groupsDataGridView.Rows[groupId].Cells[1].Value = group.ToString();
        itemsListView.Items.Clear();
        foreach (var item in group.Items)
        {
            itemsListView.Items.Add(new ListViewItem(new string[1] { item.ToString() }));
        }
    }

    #endregion

    #region Add/Remove events

    private void addGroupButton_Click(object sender, EventArgs e)
    {
        if (groupComboBox.SelectedItem == null)
            return;
        var item = new FACLCRTB_Item
        {
            Field1_1 = 1,
            Field2_0 = 0,
            Item = Identifier.ToValue(groupComboBox.Text)
        };
        var group = new FACLCRTB_Group
        {
            Field2_1 = 1,
            Field4_1 = 1,
            Field5_1 = 1,
            Entry = (uint)GameFile.Groups.Length + 1,
            EntryBis = (uint)GameFile.Groups.Length + 1,
            Items = new FACLCRTB_Item[] { item },
            ItemsCount = 1
        };
        var groups = new List<FACLCRTB_Group>(GameFile.Groups);
        groups.Add(group);
        GameFile.Groups = groups.ToArray();
        groupsDataGridView.Rows.Add(new object[2] { group.Entry, group.ToString() });
        GameFile.GroupsCount++;
        GameFile.UnsavedData = true;
        groupsDataGridView_SelectionChanged(sender, e);
    }

    private void delGroupButton_Click(object sender, EventArgs e)
    {
        if (groupsDataGridView.SelectedCells.Count != 1)
            return;
        var groupId = Int32.Parse(groupsDataGridView.SelectedCells[0].RowIndex.ToString());
        var groups = new List<FACLCRTB_Group>(GameFile.Groups);
        groups.RemoveAt(groupId);
        GameFile.Groups = groups.ToArray();
        groupsDataGridView.Rows.RemoveAt(groupId);
        itemsListView.Items.Clear();
        GameFile.GroupsCount--;
        GameFile.UnsavedData = true;
        for (int i = 0; i < GameFile.Groups.Length; i++)
        {
            GameFile.Groups[i].Entry = (uint)i + 1;
            GameFile.Groups[i].EntryBis = (uint)i + 1;
            groupsDataGridView.Rows[i].Cells[0].Value = GameFile.Groups[i].Entry;
        }
        groupsDataGridView_SelectionChanged(sender, e);
        if (GameFile.GroupsCount > 0)
            groupsDataGridView.CurrentCell = groupsDataGridView.Rows[(int)Math.Min(groupId, GameFile.GroupsCount - 1)].Cells[1];
    }

    private void addItemButton_Click(object sender, EventArgs e)
    {
        if (groupsDataGridView.SelectedCells.Count != 1)
            return;
        if (itemComboBox.SelectedItem == null)
            return;
        var groupId = Int32.Parse(groupsDataGridView.SelectedCells[0].RowIndex.ToString());
        var group = GameFile.Groups[groupId];
        var items = new List<FACLCRTB_Item>(group.Items);
        items.Add(new FACLCRTB_Item
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
        var items = new List<FACLCRTB_Item>(group.Items);
        items.RemoveAt(itemId);
        group.Items = items.ToArray();
        group.ItemsCount = (uint)items.Count;
        GameFile.UnsavedData = true;
        groupsDataGridView_SelectionChanged(sender, e);
        itemsListView.Items[(int)Math.Min(itemId, group.ItemsCount - 1)].Selected = true;
    }

    #endregion
}
