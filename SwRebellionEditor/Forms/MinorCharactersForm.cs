namespace SwRebellionEditor
{
    public partial class MinorCharactersForm : Form
    {
        public MinorCharactersForm()
        {
            InitializeComponent();
        }

        private void updateDipBaseNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].diplomacyBase = (uint)dipBaseNum.Value;
            DisplayMinCharData(ItemSelect.Value);
            MNCHARSD.SetUnsavedData();
        }

        private void updateDipVarNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].diplomacyVar = (uint)dipVarNum.Value;
            MNCHARSD.SetUnsavedData();
        }

        private void updateEspBaseNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].espionageBase = (uint)espBaseNum.Value;
            DisplayMinCharData(ItemSelect.Value);
            MNCHARSD.SetUnsavedData();
        }

        private void updateEspVarNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].espionageVar = (uint)espVarNum.Value;
            MNCHARSD.SetUnsavedData();
        }

        private void updateCombatBaseNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].combatBase = (uint)combatBaseNum.Value;
            DisplayMinCharData(ItemSelect.Value);
            MNCHARSD.SetUnsavedData();
        }

        private void updateCombatVarNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].combatVar = (uint)combatVarNum.Value;
            MNCHARSD.SetUnsavedData();
        }

        private void updateLoyalBaseNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].loyaltyBase = (uint)loyalBaseNum.Value;
            MNCHARSD.SetUnsavedData();
        }

        private void updateLoyalVarNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].loyaltyVar = (uint)loyalVarNum.Value;
            MNCHARSD.SetUnsavedData();
        }

        private void updateShipResBaseNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].shipResBase = (uint)shipResBaseNum.Value;
            MNCHARSD.SetUnsavedData();
        }

        private void updateShipResVarNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].shipResVar = (uint)shipResVarNum.Value;
            MNCHARSD.SetUnsavedData();
        }

        private void updateTroopResBaseNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].troopResBase = (uint)troopResBaseNum.Value;
            MNCHARSD.SetUnsavedData();
        }

        private void updateTroopResVarNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].troopResVar = (uint)troopResVarNum.Value;
            MNCHARSD.SetUnsavedData();
        }

        private void updateFacResBaseNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].facilityResBase = (uint)facResBaseNum.Value;
            MNCHARSD.SetUnsavedData();
        }

        private void updateFacResVarNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].facilityResVar = (uint)facResVarNum.Value;
            MNCHARSD.SetUnsavedData();
        }

        private void updateJediProbBaseNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].jediProbability = (uint)jediProbBaseNum.Value;
            MNCHARSD.SetUnsavedData();
        }

        private void updateJediLevelBaseNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].jediLevelBase = (uint)jediLevelBaseNum.Value;
            MNCHARSD.SetUnsavedData();
        }

        private void updateJediLevelVarNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].jediLevelVar = (uint)jediLevelVarNum.Value;
            MNCHARSD.SetUnsavedData();
        }

        private void updateknownJediCheck(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].knownJediFlag = !knownJediCheck.Checked ? 0U : 1U;
            MNCHARSD.SetUnsavedData();
        }

        private void updateTrainJediCheck(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].jediTrainFlag = !trainJediCheck.Checked ? 0U : 1U;
            MNCHARSD.SetUnsavedData();
        }

        private void updateRebelUnitCheck(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].rebel = !rebelUnit.Checked ? 0U : 1U;
            MNCHARSD.SetUnsavedData();
        }

        private void updateEmpireUnitCheck(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].empire = !empireUnit.Checked ? 0U : 1U;
            MNCHARSD.SetUnsavedData();
        }

        private void updateBetrayFlagCheck(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].betrayFlag = !betrayFlagCheck.Checked ? 0U : 1U;
            MNCHARSD.SetUnsavedData();
        }

        private void updateCmdAdmCheck(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].admiralFlag = !cmdAdmCheck.Checked ? 0U : 1U;
            MNCHARSD.SetUnsavedData();
        }

        private void updateCmdGenCheck(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].generalFlag = !cmdGenCheck.Checked ? 0U : 1U;
            MNCHARSD.SetUnsavedData();
        }

        private void updateCmdCommCheck(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].commanderFlag = !cmdCommCheck.Checked ? 0U : 1U;
            MNCHARSD.SetUnsavedData();
        }

        private void updateProdFacNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].prodFacilityNum = (uint)prodFacNum.Value;
            MNCHARSD.SetUnsavedData();
        }

        private void updateSecProdFacNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].unknown2 = (uint)secProdFacNum.Value;
            MNCHARSD.SetUnsavedData();
        }

        private void MinCharFormUpdateUI(object sender, EventArgs e)
        {
            DisplayMinCharData(ItemSelect.Value);
        }

        private void updateFamilyIdNum(object sender, EventArgs e)
        {
            MNCHARSD.MinChar[ItemSelect.Value].familyNum = (uint)familyIdNum.Value;
            MNCHARSD.SetUnsavedData();
        }

        private void DisplayMinCharData(int index)
        {
            int num1 = 78 + index;
            MNCHARSD.LockChange();
            ItemName.Text = MNCHARSD.MinChar[index].swrName;
            dipBaseNum.Value = MNCHARSD.MinChar[index].diplomacyBase;
            dipVarNum.Value = MNCHARSD.MinChar[index].diplomacyVar;
            espBaseNum.Value = MNCHARSD.MinChar[index].espionageBase;
            espVarNum.Value = MNCHARSD.MinChar[index].espionageVar;
            combatBaseNum.Value = MNCHARSD.MinChar[index].combatBase;
            combatVarNum.Value = MNCHARSD.MinChar[index].combatVar;
            loyalBaseNum.Value = MNCHARSD.MinChar[index].loyaltyBase;
            loyalVarNum.Value = MNCHARSD.MinChar[index].loyaltyVar;
            shipResBaseNum.Value = MNCHARSD.MinChar[index].shipResBase;
            shipResVarNum.Value = MNCHARSD.MinChar[index].shipResVar;
            troopResBaseNum.Value = MNCHARSD.MinChar[index].troopResBase;
            troopResVarNum.Value = MNCHARSD.MinChar[index].troopResVar;
            facResBaseNum.Value = MNCHARSD.MinChar[index].facilityResBase;
            facResVarNum.Value = MNCHARSD.MinChar[index].facilityResVar;
            knownJediCheck.Checked = MNCHARSD.MinChar[index].knownJediFlag > 0U;
            trainJediCheck.Checked = MNCHARSD.MinChar[index].jediTrainFlag > 0U;
            jediProbBaseNum.Value = MNCHARSD.MinChar[index].jediProbability;
            jediLevelBaseNum.Value = MNCHARSD.MinChar[index].jediLevelBase;
            jediLevelVarNum.Value = MNCHARSD.MinChar[index].jediLevelVar;
            if (MNCHARSD.MinChar[index].swrName != "Leia Organa")
            {
                leiaForceLabel.Text = "";
                float num2 = MNCHARSD.MinChar[index].jediLevelBase / 100f;
                jediDipBaseNum.Value = (int)(MNCHARSD.MinChar[index].diplomacyBase + MNCHARSD.MinChar[index].diplomacyBase * (double)num2);
                jediDipVarNum.Value = MNCHARSD.MinChar[index].diplomacyVar;
                float num3 = MNCHARSD.MinChar[index].jediLevelBase / 100f;
                jediEspBaseNum.Value = (int)(MNCHARSD.MinChar[index].espionageBase + MNCHARSD.MinChar[index].espionageBase * (double)num3);
                jediEspVarNum.Value = MNCHARSD.MinChar[index].espionageVar;
                float num4 = MNCHARSD.MinChar[index].jediLevelBase / 100f;
                jediCombatBaseNum.Value = (int)(MNCHARSD.MinChar[index].combatBase + MNCHARSD.MinChar[index].combatBase * (double)num4);
                jediCombatVarNum.Value = MNCHARSD.MinChar[index].combatVar;
            }
            else
            {
                leiaForceLabel.Text = "Leia has no Force ability at start of game";
                jediDipBaseNum.Value = MNCHARSD.MinChar[index].diplomacyBase;
                jediEspBaseNum.Value = MNCHARSD.MinChar[index].espionageBase;
                jediCombatBaseNum.Value = MNCHARSD.MinChar[index].combatBase;
            }
            rebelUnit.Checked = MNCHARSD.MinChar[index].rebel > 0U;
            empireUnit.Checked = MNCHARSD.MinChar[index].empire > 0U;
            betrayFlagCheck.Checked = MNCHARSD.MinChar[index].betrayFlag > 0U;
            cmdAdmCheck.Checked = MNCHARSD.MinChar[index].admiralFlag > 0U;
            cmdGenCheck.Checked = MNCHARSD.MinChar[index].generalFlag > 0U;
            cmdCommCheck.Checked = MNCHARSD.MinChar[index].commanderFlag > 0U;
            familyIdNum.Value = MNCHARSD.MinChar[index].familyNum;
            idNum.Value = MNCHARSD.MinChar[index].textstratNum;
            famHexLabel.Text = MNCHARSD.MinChar[index].familyNum.ToString("X");
            unitNum.Value = MNCHARSD.MinChar[index].number;
            unitHexLabel.Text = MNCHARSD.MinChar[index].number.ToString("X");
            ItemPicture.SizeMode = PictureBoxSizeMode.Zoom;
            ItemPicture.Image = num1 >= 100 ? Image.FromFile(RegistryKeys.InstalledLocation + "\\edata\\edata." + num1) : Image.FromFile(RegistryKeys.InstalledLocation + "\\edata\\edata.0" + num1);
            MNCHARSD.UnlockChange();
        }

        private void loadMinCharImageList()
        {
            int num = 78;
            charListView.Sorting = SortOrder.None;
            MinCharImageList.Images.Clear();
            for (int index = num; index <= num + MNCHARSD.numUnits - 1; ++index)
            {
                if (index < 100)
                {
                    MinCharImageList.Images.Add(Image.FromFile(RegistryKeys.InstalledLocation + "\\edata\\edata.0" + index));
                }
                else
                {
                    MinCharImageList.Images.Add(Image.FromFile(RegistryKeys.InstalledLocation + "\\edata\\edata." + index));
                }

                charListView.Items.Add(MNCHARSD.MinChar[index - num].swrName, index - num);
            }
        }

        private void charListView_NewSelection()
        {
            ItemSelect.Value = charListView.Items.IndexOf(charListView.FocusedItem);
            DisplayMinCharData(ItemSelect.Value);
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
            if (MNCHARSD.unsavedMinCharData)
            {
                MNCHARSD.GetMinCharPath();
                MNCHARSD.SaveMinCharData(MNCHARSD.GetMinCharPath());
                MNCHARSD.ClearUnsavedData();
            }
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (MNCHARSD.unsavedMinCharData)
            {
                if (MessageBox.Show(this, "Unsaved MinChar data, are you sure you want to Close this Dialog?", "Save data", MessageBoxButtons.YesNo) != DialogResult.Yes)
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
                MNCHARSD.SaveMinCharData(saveFileDialog.FileName);
                MNCHARSD.ClearUnsavedData();
                int num = (int)MessageBox.Show(this, "MinChar Data Saved", "", MessageBoxButtons.OK);
            }
            ItemSelect.Focus();
        }

        private void openNew_Click(object sender, EventArgs e)
        {
            if (MNCHARSD.unsavedMinCharData && MessageBox.Show(this, "Save MinChar data before opening new datafile?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MNCHARSD.SaveMinCharData(MNCHARSD.GetMinCharPath());
                MNCHARSD.ClearUnsavedData();
            }
            MNCHARSD.OpenNewMinCharFile();
            DisplayMinCharData(ItemSelect.Value);
            ItemSelect.Select();
        }

        private void MinCharForm_Load(object sender, EventArgs e)
        {
            DisplayMinCharData(ItemSelect.Value);
            loadMinCharImageList();
            if (RegistryKeys.PlaySounds)
            {
                Sound.Play(Resources.open_wav);
            }

            if (RegistryKeys.PlayMusic)
            {
                Sound.PlayRandomMusic();
            }

            ItemSelect.Select();
        }

        private void MinCharForm_KeyDown(object sender, KeyEventArgs e)
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

        private void MinCharForm_FormClosing(object sender, FormClosingEventArgs e)
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
