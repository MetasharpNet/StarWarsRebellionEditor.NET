namespace SwRebellionEditor
{
    public partial class SystemsForm : Form
    {
        public SystemsForm()
        {
            InitializeComponent();
        }

        private void updateDipBaseNum(object sender, EventArgs e)
        {
            SYSTEMSD.Systems[ItemSelect.Value].diplomacyBase = (uint)dipBaseNum.Value;
            DisplaySystemData(ItemSelect.Value);
            SYSTEMSD.SetUnsavedData();
        }

        private void updateEspBaseNum(object sender, EventArgs e)
        {
            SYSTEMSD.Systems[ItemSelect.Value].espionageBase = (uint)espBaseNum.Value;
            DisplaySystemData(ItemSelect.Value);
            SYSTEMSD.SetUnsavedData();
        }

        private void updateEspVarNum(object sender, EventArgs e)
        {
            SYSTEMSD.Systems[ItemSelect.Value].espionageVar = (uint)espVarNum.Value;
            SYSTEMSD.SetUnsavedData();
        }

        private void updateCombatBaseNum(object sender, EventArgs e)
        {
            SYSTEMSD.Systems[ItemSelect.Value].combatBase = (uint)combatBaseNum.Value;
            DisplaySystemData(ItemSelect.Value);
            SYSTEMSD.SetUnsavedData();
        }

        private void updateFamilyNum(object sender, EventArgs e)
        {
            SYSTEMSD.Systems[ItemSelect.Value].familyNum = (uint)familyIdNum.Value;
            SYSTEMSD.SetUnsavedData();
        }

        private void updateLoyalBaseNum(object sender, EventArgs e)
        {
            SYSTEMSD.Systems[ItemSelect.Value].loyaltyBase = (uint)loyalBaseNum.Value;
            SYSTEMSD.SetUnsavedData();
        }

        private void updateLoyalVarNum(object sender, EventArgs e)
        {
            SYSTEMSD.Systems[ItemSelect.Value].loyaltyVar = (uint)loyalVarNum.Value;
            SYSTEMSD.SetUnsavedData();
        }

        private void SystemFormUpdateUI(object sender, EventArgs e)
        {
            DisplaySystemData(ItemSelect.Value);
        }

        private void DisplaySystemData(int index)
        {
            int num = 165;
            SYSTEMSD.LockChange();
            ItemName.Text = SYSTEMSD.Systems[index].swrName;
            sectorName.Text = "Sector(" + SECTORSD.Sectors[SYSTEMSD.Systems[index].sectorID - 20U].swrName + ")";
            dipBaseNum.Value = SYSTEMSD.Systems[index].unknown5;
            espBaseNum.Value = SYSTEMSD.Systems[index].xPos;
            espVarNum.Value = SYSTEMSD.Systems[index].yPos;
            combatBaseNum.Value = SYSTEMSD.Systems[index].unknown4;
            loyalBaseNum.Value = SYSTEMSD.Systems[index].sectorID;
            loyalVarNum.Value = SYSTEMSD.Systems[index].planetPicID;
            prodFacNum.Value = SYSTEMSD.Systems[index].prodFacilityNum;
            secProdFacNum.Value = SYSTEMSD.Systems[index].unknown2;
            familyIdNum.Value = SYSTEMSD.Systems[index].familyNum;
            unknown3Num.Value = SYSTEMSD.Systems[index].unknown3;
            idNum.Value = SYSTEMSD.Systems[index].textstratNum;
            sysfamHexLabel.Text = SYSTEMSD.Systems[index].familyNum.ToString("X");
            sysNum.Value = SYSTEMSD.Systems[index].number;
            sysHexLabel.Text = SYSTEMSD.Systems[index].number.ToString("X");
            secNameLabel.Text = SECTORSD.Sectors[SYSTEMSD.Systems[index].sectorID - 20U].swrName;
            sectorYposNum.Value = SECTORSD.Sectors[SYSTEMSD.Systems[index].sectorID - 20U].secImport;
            sectorXposNum.Value = SECTORSD.Sectors[SYSTEMSD.Systems[index].sectorID - 20U].galSize;
            sectorYpos.Value = SECTORSD.Sectors[SYSTEMSD.Systems[index].sectorID - 20U].xPos;
            sectorXpos.Value = SECTORSD.Sectors[SYSTEMSD.Systems[index].sectorID - 20U].yPos;
            sectorProdFacNum.Value = SECTORSD.Sectors[SYSTEMSD.Systems[index].sectorID - 20U].prodFacilityNum;
            sectorSecProdFacNum.Value = SECTORSD.Sectors[SYSTEMSD.Systems[index].sectorID - 20U].unknown2;
            sectorFamilyIdNum.Value = SECTORSD.Sectors[SYSTEMSD.Systems[index].sectorID - 20U].familyNum;
            sectorUnknown3Num.Value = SECTORSD.Sectors[SYSTEMSD.Systems[index].sectorID - 20U].unknown3;
            sectorIdNum.Value = SECTORSD.Sectors[SYSTEMSD.Systems[index].sectorID - 20U].textstratNum;
            secfamHexLabel.Text = SECTORSD.Sectors[SYSTEMSD.Systems[index].sectorID - 20U].familyNum.ToString("X");
            secNum.Value = SECTORSD.Sectors[SYSTEMSD.Systems[index].sectorID - 20U].number;
            secUnitHexLabel.Text = SECTORSD.Sectors[SYSTEMSD.Systems[index].sectorID - 20U].number.ToString("X");
            ItemPicture.Image = num >= 100 ? Image.FromFile(RegistryKeys.InstalledLocation + "\\edata\\edata." + (num + SYSTEMSD.Systems[index].planetPicID)) : Image.FromFile(RegistryKeys.InstalledLocation + "\\edata\\edata.0" + num);
            SYSTEMSD.UnlockChange();
        }

        private void loadSystemImageList()
        {
            int num = 165;
            SystemImageList.Images.Clear();
            for (int imageIndex = 0; imageIndex <= SYSTEMSD.numUnits - 1; ++imageIndex)
            {
                SystemImageList.Images.Add(Image.FromFile(RegistryKeys.InstalledLocation + "\\edata\\edata." + (num + SYSTEMSD.Systems[imageIndex].planetPicID)));
                charListView.Items.Add(SYSTEMSD.Systems[imageIndex].swrName, imageIndex);
            }
        }

        private void charListView_NewSelection()
        {
            ItemSelect.Value = charListView.Items.IndexOf(charListView.FocusedItem);
            DisplaySystemData(ItemSelect.Value);
            ItemSelect.Select();
        }

        private void ItemPicture_Click(object sender, EventArgs e)
        {
            if (charListView.Items.Count > ItemSelect.Value + 1 && ItemSelect.Value - 1 >= 0)
            {
                charListView.Items[ItemSelect.Value + 1].EnsureVisible();
                charListView.Items[ItemSelect.Value - 1].EnsureVisible();
            }
            else
            {
                charListView.Items[ItemSelect.Value].EnsureVisible();
            }

            ItemSelect.Select();
        }

        private void ListView_DoubleClick(object sender, EventArgs e)
        {
            charListView_NewSelection();
        }

        private void ListView_Click(object sender, EventArgs e)
        {
            charListView_NewSelection();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (SYSTEMSD.unsavedSystemData)
            {
                SYSTEMSD.GetSystemPath();
                SYSTEMSD.SaveSystemData(SYSTEMSD.GetSystemPath());
                SYSTEMSD.ClearUnsavedData();
            }
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (SYSTEMSD.unsavedSystemData)
            {
                if (MessageBox.Show(this, "Unsaved System data, are you sure you want to Close this Dialog?", "Save data", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }

                Close();
            }
            else
            {
                Close();
            }
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = RegistryKeys.InstalledLocation + "\\Gdata";
            saveFileDialog.Filter = "Data Files (*.dat)| *.dat";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                SYSTEMSD.SaveSystemData(saveFileDialog.FileName);
                SYSTEMSD.ClearUnsavedData();
                int num = (int)MessageBox.Show(this, "System Data Saved", "", MessageBoxButtons.OK);
            }
            ItemSelect.Focus();
        }

        private void openNew_Click(object sender, EventArgs e)
        {
            if (SYSTEMSD.unsavedSystemData && MessageBox.Show(this, "Save System data before opening new datafile?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SYSTEMSD.SaveSystemData(SYSTEMSD.GetSystemPath());
                SYSTEMSD.ClearUnsavedData();
            }
            SYSTEMSD.OpenNewSystemFile();
            DisplaySystemData(ItemSelect.Value);
            ItemSelect.Select();
        }

        private void SystemInfoForm_Load(object sender, EventArgs e)
        {
            DisplaySystemData(ItemSelect.Value);
            loadSystemImageList();
            if (RegistryKeys.PlaySounds)
            {
                Sound.Play(Resources.open_wav);
            }

            ItemSelect.Select();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
        }

        private void SystemInfoForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 114)
            {
                if (e.Shift)
                {
                    if (ItemSelect.Value - ItemSelect.LargeChange > ItemSelect.Minimum)
                    {
                        ItemSelect.Value -= ItemSelect.LargeChange;
                    }
                    else
                    {
                        ItemSelect.Value = ItemSelect.Minimum;
                    }
                }
                else
                {
                    if (ItemSelect.Value <= ItemSelect.Minimum)
                    {
                        return;
                    }

                    --ItemSelect.Value;
                }
            }
            else
            {
                if (e.KeyValue != 115)
                {
                    return;
                }

                if (e.Shift)
                {
                    if (ItemSelect.Value + ItemSelect.LargeChange < ItemSelect.Maximum)
                    {
                        ItemSelect.Value += ItemSelect.LargeChange;
                    }
                    else
                    {
                        ItemSelect.Value = ItemSelect.Maximum;
                    }
                }
                else
                {
                    if (ItemSelect.Value >= ItemSelect.Maximum)
                    {
                        return;
                    }

                    ++ItemSelect.Value;
                }
            }
        }

        private void SystemInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (RegistryKeys.PlaySounds)
            {
                Sound.Play(Resources.close_wav);
            }

            if (!RegistryKeys.PlayMusic)
            {
                return;
            }

            Sound.PlayRandomMusic();
        }
    }
}
