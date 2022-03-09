namespace SwRebellionEditor
{
    public partial class MajorCharactersForm : Form
    {
        public MajorCharactersForm()
        {
            InitializeComponent();
        }

        private void updateDipBaseNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].diplomacyBase = (uint)dipBaseNum.Value;
            DisplayMajCharData(ItemSelect.Value);
            MJCHARSD.SetUnsavedData();
        }

        private void updateDipVarNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].diplomacyVar = (uint)dipVarNum.Value;
            MJCHARSD.SetUnsavedData();
        }

        private void updateEspBaseNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].espionageBase = (uint)espBaseNum.Value;
            DisplayMajCharData(ItemSelect.Value);
            MJCHARSD.SetUnsavedData();
        }

        private void updateEspVarNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].espionageVar = (uint)espVarNum.Value;
            MJCHARSD.SetUnsavedData();
        }

        private void updateCombatBaseNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].combatBase = (uint)combatBaseNum.Value;
            DisplayMajCharData(ItemSelect.Value);
            MJCHARSD.SetUnsavedData();
        }

        private void updateCombatVarNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].combatVar = (uint)combatVarNum.Value;
            MJCHARSD.SetUnsavedData();
        }

        private void updateLoyalBaseNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].loyaltyBase = (uint)loyalBaseNum.Value;
            MJCHARSD.SetUnsavedData();
        }

        private void updateLoyalVarNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].loyaltyVar = (uint)loyalVarNum.Value;
            MJCHARSD.SetUnsavedData();
        }

        private void updateShipResBaseNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].shipResBase = (uint)shipResBaseNum.Value;
            MJCHARSD.SetUnsavedData();
        }

        private void updateShipResVarNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].shipResVar = (uint)shipResVarNum.Value;
            MJCHARSD.SetUnsavedData();
        }

        private void updateTroopResBaseNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].troopResBase = (uint)troopResBaseNum.Value;
            MJCHARSD.SetUnsavedData();
        }

        private void updateTroopResVarNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].troopResVar = (uint)troopResVarNum.Value;
            MJCHARSD.SetUnsavedData();
        }

        private void updateFacResBaseNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].facilityResBase = (uint)facResBaseNum.Value;
            MJCHARSD.SetUnsavedData();
        }

        private void updateFacResVarNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].facilityResVar = (uint)facResVarNum.Value;
            MJCHARSD.SetUnsavedData();
        }

        private void updateJediProbBaseNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].jediProbability = (uint)jediProbBaseNum.Value;
            MJCHARSD.SetUnsavedData();
        }

        private void updateJediLevelBaseNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].jediLevelBase = (uint)jediLevelBaseNum.Value;
            MJCHARSD.SetUnsavedData();
        }

        private void updateJediLevelVarNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].jediLevelVar = (uint)jediLevelVarNum.Value;
            MJCHARSD.SetUnsavedData();
        }

        private void updateknownJediCheck(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].knownJediFlag = !knownJediCheck.Checked ? 0U : 1U;
            MJCHARSD.SetUnsavedData();
        }

        private void updateTrainJediCheck(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].jediTrainFlag = !trainJediCheck.Checked ? 0U : 1U;
            MJCHARSD.SetUnsavedData();
        }

        private void updateRebelUnitCheck(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].rebel = !rebelUnit.Checked ? 0U : 1U;
            MJCHARSD.SetUnsavedData();
        }

        private void updateEmpireUnitCheck(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].empire = !empireUnit.Checked ? 0U : 1U;
            MJCHARSD.SetUnsavedData();
        }

        private void updateBetrayFlagCheck(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].betrayFlag = !betrayFlagCheck.Checked ? 0U : 1U;
            MJCHARSD.SetUnsavedData();
        }

        private void updateCmdAdmCheck(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].admiralFlag = !cmdAdmCheck.Checked ? 0U : 1U;
            MJCHARSD.SetUnsavedData();
        }

        private void updateCmdGenCheck(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].generalFlag = !cmdGenCheck.Checked ? 0U : 1U;
            MJCHARSD.SetUnsavedData();
        }

        private void updateCmdCommCheck(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].commanderFlag = !cmdCommCheck.Checked ? 0U : 1U;
            MJCHARSD.SetUnsavedData();
        }

        private void updateProdFacNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].prodFacilityNum = (uint)prodFacNum.Value;
            MJCHARSD.SetUnsavedData();
        }

        private void updateSecProdFacNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].unknown2 = (uint)secProdFacNum.Value;
            MJCHARSD.SetUnsavedData();
        }

        private void updateFamilyIdNum(object sender, EventArgs e)
        {
            MJCHARSD.MajChar[ItemSelect.Value].familyNum = (uint)familyIdNum.Value;
            MJCHARSD.SetUnsavedData();
        }

        private void MajCharFormUpdateUI(object sender, EventArgs e)
        {
            DisplayMajCharData(ItemSelect.Value);
        }

        private void DisplayMajCharData(int index)
        {
            int num1 = 72 + index;
            MJCHARSD.LockChange();
            ItemName.Text = MJCHARSD.MajChar[index].swrName;
            dipBaseNum.Value = MJCHARSD.MajChar[index].diplomacyBase;
            dipVarNum.Value = MJCHARSD.MajChar[index].diplomacyVar;
            espBaseNum.Value = MJCHARSD.MajChar[index].espionageBase;
            espVarNum.Value = MJCHARSD.MajChar[index].espionageVar;
            combatBaseNum.Value = MJCHARSD.MajChar[index].combatBase;
            combatVarNum.Value = MJCHARSD.MajChar[index].combatVar;
            loyalBaseNum.Value = MJCHARSD.MajChar[index].loyaltyBase;
            loyalVarNum.Value = MJCHARSD.MajChar[index].loyaltyVar;
            shipResBaseNum.Value = MJCHARSD.MajChar[index].shipResBase;
            shipResVarNum.Value = MJCHARSD.MajChar[index].shipResVar;
            troopResBaseNum.Value = MJCHARSD.MajChar[index].troopResBase;
            troopResVarNum.Value = MJCHARSD.MajChar[index].troopResVar;
            facResBaseNum.Value = MJCHARSD.MajChar[index].facilityResBase;
            facResVarNum.Value = MJCHARSD.MajChar[index].facilityResVar;
            knownJediCheck.Checked = MJCHARSD.MajChar[index].knownJediFlag > 0U;
            trainJediCheck.Checked = MJCHARSD.MajChar[index].jediTrainFlag > 0U;
            jediProbBaseNum.Value = MJCHARSD.MajChar[index].jediProbability;
            jediLevelBaseNum.Value = MJCHARSD.MajChar[index].jediLevelBase;
            jediLevelVarNum.Value = MJCHARSD.MajChar[index].jediLevelVar;
            if (MJCHARSD.MajChar[index].swrName != "Leia Organa")
            {
                leiaForceLabel.Text = "";
                float num2 = MJCHARSD.MajChar[index].jediLevelBase / 100f;
                jediDipBaseNum.Value = (int)(MJCHARSD.MajChar[index].diplomacyBase + MJCHARSD.MajChar[index].diplomacyBase * (double)num2);
                jediDipVarNum.Value = MJCHARSD.MajChar[index].diplomacyVar;
                float num3 = MJCHARSD.MajChar[index].jediLevelBase / 100f;
                jediEspBaseNum.Value = (int)(MJCHARSD.MajChar[index].espionageBase + MJCHARSD.MajChar[index].espionageBase * (double)num3);
                jediEspVarNum.Value = MJCHARSD.MajChar[index].espionageVar;
                float num4 = MJCHARSD.MajChar[index].jediLevelBase / 100f;
                jediCombatBaseNum.Value = (int)(MJCHARSD.MajChar[index].combatBase + MJCHARSD.MajChar[index].combatBase * (double)num4);
                jediCombatVarNum.Value = MJCHARSD.MajChar[index].combatVar;
            }
            else
            {
                leiaForceLabel.Text = "Leia has no Force ability at start of game";
                jediDipBaseNum.Value = MJCHARSD.MajChar[index].diplomacyBase;
                jediEspBaseNum.Value = MJCHARSD.MajChar[index].espionageBase;
                jediCombatBaseNum.Value = MJCHARSD.MajChar[index].combatBase;
            }
            rebelUnit.Checked = MJCHARSD.MajChar[index].rebel > 0U;
            empireUnit.Checked = MJCHARSD.MajChar[index].empire > 0U;
            betrayFlagCheck.Checked = MJCHARSD.MajChar[index].betrayFlag > 0U;
            cmdAdmCheck.Checked = MJCHARSD.MajChar[index].admiralFlag > 0U;
            cmdGenCheck.Checked = MJCHARSD.MajChar[index].generalFlag > 0U;
            cmdCommCheck.Checked = MJCHARSD.MajChar[index].commanderFlag > 0U;
            familyIdNum.Value = MJCHARSD.MajChar[index].familyNum;
            idNum.Value = MJCHARSD.MajChar[index].textstratNum;
            famHexLabel.Text = MJCHARSD.MajChar[index].familyNum.ToString("X");
            unitNum.Value = MJCHARSD.MajChar[index].number;
            unitHexLabel.Text = MJCHARSD.MajChar[index].number.ToString("X");
            ItemPicture.SizeMode = PictureBoxSizeMode.Zoom;
            ItemPicture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA.0" + num1);
            MJCHARSD.UnlockChange();
        }

        private void loadMajCharImageList()
        {
            int num = 72;
            charListView.Sorting = SortOrder.None;
            majCharImageList.Images.Clear();
            for (int index = num; index <= num + MJCHARSD.numUnits - 1; ++index)
            {
                majCharImageList.Images.Add(Image.FromFile(RegistryKeys.InstalledLocation + "\\EData\\EDATA.0" + index));
                charListView.Items.Add(MJCHARSD.MajChar[index - num].swrName, index - num);
            }
        }

        private void charListView_NewSelection()
        {
            ItemSelect.Value = charListView.Items.IndexOf(charListView.FocusedItem);
            DisplayMajCharData(ItemSelect.Value);
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

        private void Ok_Click(object sender, EventArgs e)
        {
            if (MJCHARSD.unsavedMajCharData)
            {
                MJCHARSD.GetMajCharPath();
                MJCHARSD.SaveMajCharData(MJCHARSD.GetMajCharPath());
                MJCHARSD.ClearUnsavedData();
            }
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (MJCHARSD.unsavedMajCharData)
            {
                if (MessageBox.Show(this, "Unsaved MajChar data, are you sure you want to Close this Dialog?", "Save data", MessageBoxButtons.YesNo) != DialogResult.Yes)
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
                MJCHARSD.SaveMajCharData(saveFileDialog.FileName);
                MJCHARSD.ClearUnsavedData();
                int num = (int)MessageBox.Show(this, "MajChar Data Saved", "", MessageBoxButtons.OK);
            }
            ItemSelect.Focus();
        }

        private void openNew_Click(object sender, EventArgs e)
        {
            if (MJCHARSD.unsavedMajCharData && MessageBox.Show(this, "Save MajChar data before opening new datafile?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MJCHARSD.SaveMajCharData(MJCHARSD.GetMajCharPath());
                MJCHARSD.ClearUnsavedData();
            }
            MJCHARSD.OpenNewMajCharFile();
            DisplayMajCharData(ItemSelect.Value);
            ItemSelect.Select();
        }

        private void MajCharForm_Load(object sender, EventArgs e)
        {
            if (RegistryKeys.PlaySounds)
            {
                Sound.Play(Resources.open_wav);
            }

            if (RegistryKeys.PlayMusic)
            {
                Sound.PlayRandomMusic();
            }

            DisplayMajCharData(ItemSelect.Value);
            loadMajCharImageList();
            ItemSelect.Select();
        }

        private void MajCharForm_KeyDown(object sender, KeyEventArgs e)
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

        private void MajCharForm_FormClosing(object sender, FormClosingEventArgs e)
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
