namespace SwRebellionEditor
{
    public partial class TroopsForm : Form
    {
        public TroopsForm()
        {
            InitializeComponent();
        }

        private void updateConCost(object sender, EventArgs e)
        {
            TROOPSD.Troops[ItemSelect.Value].conCost = (uint)conCostNum.Value;
            TROOPSD.setUnsavedData();
        }

        private void updateMaintCost(object sender, EventArgs e)
        {
            TROOPSD.Troops[ItemSelect.Value].maintCost = (uint)maintCostNum.Value;
            TROOPSD.setUnsavedData();
        }

        private void updateResearchNum(object sender, EventArgs e)
        {
            TROOPSD.Troops[ItemSelect.Value].researchNum = (uint)researchNum.Value;
            TROOPSD.setUnsavedData();
        }

        private void updateAttackNum(object sender, EventArgs e)
        {
            TROOPSD.Troops[ItemSelect.Value].attack = (uint)attackNum.Value;
            TROOPSD.setUnsavedData();
        }

        private void updateDefNum(object sender, EventArgs e)
        {
            TROOPSD.Troops[ItemSelect.Value].defense = (uint)defNum.Value;
            TROOPSD.setUnsavedData();
        }

        private void updateBombardNum(object sender, EventArgs e)
        {
            TROOPSD.Troops[ItemSelect.Value].bombardment = (uint)bombardNum.Value;
            TROOPSD.setUnsavedData();
        }

        private void updateDetectNum(object sender, EventArgs e)
        {
            TROOPSD.Troops[ItemSelect.Value].detection = (uint)detectNum.Value;
            TROOPSD.setUnsavedData();
        }

        private void updateResDiffNum(object sender, EventArgs e)
        {
            TROOPSD.Troops[ItemSelect.Value].researchDiff = (uint)resDiffNum.Value;
            TROOPSD.setUnsavedData();
        }

        private void updateUnknownMoralHpNum(object sender, EventArgs e)
        {
            TROOPSD.Troops[ItemSelect.Value].unknown4 = (uint)unknownMoralHpNum.Value;
            TROOPSD.setUnsavedData();
        }

        private void updateProdFacNum(object sender, EventArgs e)
        {
            TROOPSD.Troops[ItemSelect.Value].prodFacilityNum = (uint)prodFacNum.Value;
            TROOPSD.setUnsavedData();
        }

        private void updateSecProdFacNum(object sender, EventArgs e)
        {
            TROOPSD.Troops[ItemSelect.Value].unknown2 = (uint)secProdFacNum.Value;
            TROOPSD.setUnsavedData();
        }

        private void updateFamilyIdNum(object sender, EventArgs e)
        {
            TROOPSD.Troops[ItemSelect.Value].familyNum = (uint)familyIdNum.Value;
            TROOPSD.setUnsavedData();
        }

        private void updateRebelUnitCheck(object sender, EventArgs e)
        {
            TROOPSD.Troops[ItemSelect.Value].rebel = !rebelUnit.Checked ? 0U : 1U;
            TROOPSD.setUnsavedData();
        }

        private void updateEmpireUnitCheck(object sender, EventArgs e)
        {
            TROOPSD.Troops[ItemSelect.Value].empire = !empireUnit.Checked ? 0U : 1U;
            TROOPSD.setUnsavedData();
        }

        private void DisplayTroopData(int index)
        {
            int num = 15 + index;
            TROOPSD.LockChange();
            troopName.Text = TROOPSD.Troops[index].swrName;
            conCostNum.Value = TROOPSD.Troops[index].conCost;
            maintCostNum.Value = TROOPSD.Troops[index].maintCost;
            researchNum.Value = TROOPSD.Troops[index].researchNum;
            attackNum.Value = TROOPSD.Troops[index].attack;
            defNum.Value = TROOPSD.Troops[index].defense;
            bombardNum.Value = TROOPSD.Troops[index].bombardment;
            detectNum.Value = TROOPSD.Troops[index].detection;
            resDiffNum.Value = TROOPSD.Troops[index].researchDiff;
            unknownMoralHpNum.Value = TROOPSD.Troops[index].unknown4;
            rebelUnit.Checked = TROOPSD.Troops[index].rebel > 0U;
            empireUnit.Checked = TROOPSD.Troops[index].empire > 0U;
            prodFacNum.Value = TROOPSD.Troops[index].prodFacilityNum;
            secProdFacNum.Value = TROOPSD.Troops[index].unknown2;
            familyIdNum.Value = TROOPSD.Troops[index].familyNum;
            unknown3Num.Value = TROOPSD.Troops[index].unknown3;
            idNum.Value = TROOPSD.Troops[index].textstratNum;
            famHexLabel.Text = TROOPSD.Troops[index].familyNum.ToString("X");
            unitNum.Value = TROOPSD.Troops[index].number;
            unitHexLabel.Text = TROOPSD.Troops[index].number.ToString("X");
            troopPicture.SizeMode = PictureBoxSizeMode.Zoom;
            troopPicture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\edata\\edata.0" + num);
            TROOPSD.UnlockChange();
        }

        private void TroopFormUpdateUI(object sender, EventArgs e)
        {
            DisplayTroopData(ItemSelect.Value);
        }

        private void TroopForm_Load(object sender, EventArgs e)
        {
            if (RegistryKeys.PlaySounds)
            {
                Sound.Play(Resources.open_wav);
            }

            if (RegistryKeys.PlayMusic)
            {
                Sound.PlayRandomMusic();
            }

            DisplayTroopData(ItemSelect.Value);
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = RegistryKeys.InstalledLocation + "\\Gdata";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                TROOPSD.SaveTroopData(saveFileDialog.FileName);
                TROOPSD.ClearUnsavedData();
                int num = (int)MessageBox.Show(this, "Troop Data Saved", "", MessageBoxButtons.OK);
            }
            ItemSelect.Focus();
        }

        private void openNew_Click(object sender, EventArgs e)
        {
            if (TROOPSD.unsavedTroopData && MessageBox.Show(this, "Save Troop data before opening new datafile?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TROOPSD.SaveTroopData(TROOPSD.GetTroopPath());
                TROOPSD.ClearUnsavedData();
            }
            TROOPSD.OpenNewTroopFile();
            DisplayTroopData(ItemSelect.Value);
            ItemSelect.Focus();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (TROOPSD.unsavedTroopData)
            {
                if (MessageBox.Show(this, "Unsaved Troop data, are you sure you want to Close this Dialog?", "Save data", MessageBoxButtons.YesNo) != DialogResult.Yes)
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

        private void Ok_Click(object sender, EventArgs e)
        {
            if (TROOPSD.unsavedTroopData)
            {
                TROOPSD.GetTroopPath();
                TROOPSD.SaveTroopData(TROOPSD.GetTroopPath());
                TROOPSD.ClearUnsavedData();
            }
            Close();
        }

        private void TroopForm_KeyDown(object sender, KeyEventArgs e)
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

        private void TroopForm_FormClosing(object sender, FormClosingEventArgs e)
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
