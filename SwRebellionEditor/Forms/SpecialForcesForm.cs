namespace SwRebellionEditor
{
    public partial class SpecialForcesForm : Form
    {
        public SpecialForcesForm()
        {
            InitializeComponent();
        }

        private void updateDipBaseNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].diplomacyBase = (uint)dipBaseNum.Value;
            DisplaySpecOpData(ItemSelect.Value);
            SPECFCSD.SetUnsavedData();
        }

        private void updateDipVarNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].diplomacyVar = (uint)dipVarNum.Value;
            SPECFCSD.SetUnsavedData();
        }

        private void updateEspBaseNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].espionageBase = (uint)espBaseNum.Value;
            DisplaySpecOpData(ItemSelect.Value);
            SPECFCSD.SetUnsavedData();
        }

        private void updateEspVarNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].espionageVar = (uint)espVarNum.Value;
            SPECFCSD.SetUnsavedData();
        }

        private void updateCombatBaseNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].combatBase = (uint)combatBaseNum.Value;
            DisplaySpecOpData(ItemSelect.Value);
            SPECFCSD.SetUnsavedData();
        }

        private void updateCombatVarNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].combatVar = (uint)combatVarNum.Value;
            SPECFCSD.SetUnsavedData();
        }

        private void updateLoyalBaseNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].loyaltyBase = (uint)loyalBaseNum.Value;
            SPECFCSD.SetUnsavedData();
        }

        private void updateLoyalVarNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].loyaltyVar = (uint)loyalVarNum.Value;
            SPECFCSD.SetUnsavedData();
        }

        private void updateConCostNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].conCost = (uint)conCostNum.Value;
            SPECFCSD.SetUnsavedData();
        }

        private void updateMaintCostNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].maintCost = (uint)maintCostNum.Value;
            SPECFCSD.SetUnsavedData();
        }

        private void updateResNumNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].researchNum = (uint)researchNum.Value;
            SPECFCSD.SetUnsavedData();
        }

        private void updateResDiffNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].researchDiff = (uint)resDiffNum.Value;
            SPECFCSD.SetUnsavedData();
        }

        private void updateShipResBaseNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].shipResBase = (uint)shipResBaseNum.Value;
            SPECFCSD.SetUnsavedData();
        }

        private void updateShipResVarNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].shipResVar = (uint)shipResVarNum.Value;
            SPECFCSD.SetUnsavedData();
        }

        private void updateTroopResBaseNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].troopResBase = (uint)troopResBaseNum.Value;
            SPECFCSD.SetUnsavedData();
        }

        private void updateTroopResVarNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].troopResVar = (uint)troopResVarNum.Value;
            SPECFCSD.SetUnsavedData();
        }

        private void updateFacResBaseNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].facilityResBase = (uint)facResBaseNum.Value;
            SPECFCSD.SetUnsavedData();
        }

        private void updateFacResVarNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].facilityResVar = (uint)facResVarNum.Value;
            SPECFCSD.SetUnsavedData();
        }

        private void updateRebelUnitCheck(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].rebel = !rebelUnit.Checked ? 0U : 1U;
            SPECFCSD.SetUnsavedData();
        }

        private void updateEmpireUnitCheck(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].empire = !empireUnit.Checked ? 0U : 1U;
            SPECFCSD.SetUnsavedData();
        }

        private void updateFamilyNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].familyNum = (uint)familyIdNum.Value;
            SPECFCSD.SetUnsavedData();
        }

        private void updateProdFacNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].prodFacilityNum = (uint)prodFacNum.Value;
            SPECFCSD.SetUnsavedData();
        }

        private void updateSecProdFacNum(object sender, EventArgs e)
        {
            SPECFCSD.SpecOp[ItemSelect.Value].unknown2 = (uint)secProdFacNum.Value;
            SPECFCSD.SetUnsavedData();
        }

        private void SpecOpFormUpdateUI(object sender, EventArgs e)
        {
            DisplaySpecOpData(ItemSelect.Value);
        }

        private void DisplaySpecOpData(int index)
        {
            int num = 25 + index;
            SPECFCSD.LockChange();
            ItemName.Text = SPECFCSD.SpecOp[index].swrName;
            dipBaseNum.Value = SPECFCSD.SpecOp[index].diplomacyBase;
            dipVarNum.Value = SPECFCSD.SpecOp[index].diplomacyVar;
            espBaseNum.Value = SPECFCSD.SpecOp[index].espionageBase;
            espVarNum.Value = SPECFCSD.SpecOp[index].espionageVar;
            combatBaseNum.Value = SPECFCSD.SpecOp[index].combatBase;
            combatVarNum.Value = SPECFCSD.SpecOp[index].combatVar;
            loyalBaseNum.Value = SPECFCSD.SpecOp[index].loyaltyBase;
            loyalVarNum.Value = SPECFCSD.SpecOp[index].loyaltyVar;
            conCostNum.Value = SPECFCSD.SpecOp[index].conCost;
            maintCostNum.Value = SPECFCSD.SpecOp[index].maintCost;
            researchNum.Value = SPECFCSD.SpecOp[index].researchNum;
            resDiffNum.Value = SPECFCSD.SpecOp[index].researchDiff;
            shipResBaseNum.Value = SPECFCSD.SpecOp[index].shipResBase;
            shipResVarNum.Value = SPECFCSD.SpecOp[index].shipResVar;
            troopResBaseNum.Value = SPECFCSD.SpecOp[index].troopResBase;
            troopResVarNum.Value = SPECFCSD.SpecOp[index].troopResVar;
            facResBaseNum.Value = SPECFCSD.SpecOp[index].facilityResBase;
            facResVarNum.Value = SPECFCSD.SpecOp[index].facilityResVar;
            rebelUnit.Checked = SPECFCSD.SpecOp[index].rebel > 0U;
            empireUnit.Checked = SPECFCSD.SpecOp[index].empire > 0U;
            prodFacNum.Value = SPECFCSD.SpecOp[index].prodFacilityNum;
            secProdFacNum.Value = SPECFCSD.SpecOp[index].unknown2;
            familyIdNum.Value = SPECFCSD.SpecOp[index].familyNum;
            unknown3Num.Value = SPECFCSD.SpecOp[index].unknown3;
            idNum.Value = SPECFCSD.SpecOp[index].textstratNum;
            missionIdNum.Value = SPECFCSD.SpecOp[index].missionType;
            famHexLabel.Text = SPECFCSD.SpecOp[index].familyNum.ToString("X");
            unitNum.Value = SPECFCSD.SpecOp[index].number;
            unitHexLabel.Text = SPECFCSD.SpecOp[index].number.ToString("X");
            ItemPicture.SizeMode = PictureBoxSizeMode.Zoom;
            ItemPicture.Image = num >= 100 ? Image.FromFile(RegistryKeys.InstalledLocation + "\\edata\\edata." + num) : Image.FromFile(RegistryKeys.InstalledLocation + "\\edata\\edata.0" + num);
            SPECFCSD.UnlockChange();
        }

        private void loadSpecOpImageList()
        {
            int num = 25;
            charListView.Sorting = SortOrder.None;
            SpecOpImageList.Images.Clear();
            for (int index = num; index <= num + SPECFCSD.numUnits - 1; ++index)
            {
                if (index < 100)
                {
                    SpecOpImageList.Images.Add(Image.FromFile(RegistryKeys.InstalledLocation + "\\edata\\edata.0" + index));
                }
                else
                {
                    SpecOpImageList.Images.Add(Image.FromFile(RegistryKeys.InstalledLocation + "\\edata\\edata." + index));
                }

                charListView.Items.Add(SPECFCSD.SpecOp[index - num].swrName, index - num);
            }
        }

        private void charListView_NewSelection()
        {
            ItemSelect.Value = charListView.Items.IndexOf(charListView.FocusedItem);
            DisplaySpecOpData(ItemSelect.Value);
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

        private void charListView_DoubleClick(object sender, EventArgs e)
        {
            charListView_NewSelection();
        }

        private void charListView_Click(object sender, EventArgs e)
        {
            charListView_NewSelection();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (SPECFCSD.unsavedSpecOpData)
            {
                SPECFCSD.GetSpecOpPath();
                SPECFCSD.SaveSpecOpData(SPECFCSD.GetSpecOpPath());
                SPECFCSD.ClearUnsavedData();
            }
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (SPECFCSD.unsavedSpecOpData)
            {
                if (MessageBox.Show(this, "Unsaved SpecOp data, are you sure you want to Close this Dialog?", "Save data", MessageBoxButtons.YesNo) != DialogResult.Yes)
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
                SPECFCSD.SaveSpecOpData(saveFileDialog.FileName);
                SPECFCSD.ClearUnsavedData();
                int num = (int)MessageBox.Show(this, "SpecOp Data Saved", "", MessageBoxButtons.OK);
            }
            ItemSelect.Focus();
        }

        private void openNew_Click(object sender, EventArgs e)
        {
            if (SPECFCSD.unsavedSpecOpData && MessageBox.Show(this, "Save SpecOp data before opening new datafile?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SPECFCSD.SaveSpecOpData(SPECFCSD.GetSpecOpPath());
                SPECFCSD.ClearUnsavedData();
            }
            SPECFCSD.OpenNewSpecOpFile();
            DisplaySpecOpData(ItemSelect.Value);
            ItemSelect.Select();
        }

        private void SpecOpForm_Load(object sender, EventArgs e)
        {
            if (RegistryKeys.PlaySounds)
            {
                Sound.Play(Resources.open_wav);
            }

            if (RegistryKeys.PlayMusic)
            {
                Sound.PlayRandomMusic();
            }

            DisplaySpecOpData(ItemSelect.Value);
            loadSpecOpImageList();
            ItemSelect.Select();
        }

        private void SpecOpForm_KeyDown(object sender, KeyEventArgs e)
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

        private void SpecOpForm_FormClosing(object sender, FormClosingEventArgs e)
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
