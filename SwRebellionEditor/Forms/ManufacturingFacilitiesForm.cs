namespace SwRebellionEditor
{
    public partial class ManufacturingFacilitiesForm : Form
    {
        public ManufacturingFacilitiesForm()
        {
            InitializeComponent();
        }

        private void updateConCost(object sender, EventArgs e)
        {
            MANFACSD.Manufacturing[ItemSelect.Value].conCost = (uint)conCostNum.Value;
            MANFACSD.SetUnsavedData();
        }

        private void updateMaintCost(object sender, EventArgs e)
        {
            MANFACSD.Manufacturing[ItemSelect.Value].maintCost = (uint)maintCostNum.Value;
            MANFACSD.SetUnsavedData();
        }

        private void updateResearchNum(object sender, EventArgs e)
        {
            MANFACSD.Manufacturing[ItemSelect.Value].researchNum = (uint)researchNum.Value;
            MANFACSD.SetUnsavedData();
        }

        private void updateRateNum(object sender, EventArgs e)
        {
            MANFACSD.Manufacturing[ItemSelect.Value].rate = (uint)RateNum.Value;
            MANFACSD.SetUnsavedData();
        }

        private void updateResDiffNum(object sender, EventArgs e)
        {
            MANFACSD.Manufacturing[ItemSelect.Value].researchDiff = (uint)resDiffNum.Value;
            MANFACSD.SetUnsavedData();
        }

        private void updateUnknownMoralHpNum(object sender, EventArgs e)
        {
            MANFACSD.Manufacturing[ItemSelect.Value].unknown4 = (uint)unknownMoralHpNum.Value;
            MANFACSD.SetUnsavedData();
        }

        private void updateProdFacNum(object sender, EventArgs e)
        {
            MANFACSD.Manufacturing[ItemSelect.Value].prodFacilityNum = (uint)prodFacNum.Value;
            MANFACSD.SetUnsavedData();
        }

        private void updateSecProdFacNum(object sender, EventArgs e)
        {
            MANFACSD.Manufacturing[ItemSelect.Value].unknown2 = (uint)secProdFacNum.Value;
            MANFACSD.SetUnsavedData();
        }

        private void updateFamilyIdNum(object sender, EventArgs e)
        {
            MANFACSD.Manufacturing[ItemSelect.Value].familyNum = (uint)familyIdNum.Value;
            MANFACSD.SetUnsavedData();
        }

        private void updateRebelUnitCheck(object sender, EventArgs e)
        {
            MANFACSD.Manufacturing[ItemSelect.Value].rebel = !rebelUnit.Checked ? 0U : 1U;
            MANFACSD.SetUnsavedData();
        }

        private void updateEmpireUnitCheck(object sender, EventArgs e)
        {
            MANFACSD.Manufacturing[ItemSelect.Value].empire = !empireUnit.Checked ? 0U : 1U;
            MANFACSD.SetUnsavedData();
        }

        private void ManufacturingFormUpdateUI(object sender, EventArgs e)
        {
            DisplayManufacturingData(ItemSelect.Value);
        }

        private void DisplayManufacturingData(int index)
        {
            int num = 3 + index;
            MANFACSD.LockChange();
            ItemName.Text = MANFACSD.Manufacturing[index].swrName;
            conCostNum.Value = MANFACSD.Manufacturing[index].conCost;
            maintCostNum.Value = MANFACSD.Manufacturing[index].maintCost;
            researchNum.Value = MANFACSD.Manufacturing[index].researchNum;
            RateNum.Value = MANFACSD.Manufacturing[index].rate;
            resDiffNum.Value = MANFACSD.Manufacturing[index].researchDiff;
            unknownMoralHpNum.Value = MANFACSD.Manufacturing[index].unknown4;
            rebelUnit.Checked = MANFACSD.Manufacturing[index].rebel > 0U;
            empireUnit.Checked = MANFACSD.Manufacturing[index].empire > 0U;
            prodFacNum.Value = MANFACSD.Manufacturing[index].prodFacilityNum;
            secProdFacNum.Value = MANFACSD.Manufacturing[index].unknown2;
            familyIdNum.Value = MANFACSD.Manufacturing[index].familyNum;
            unknown3Num.Value = MANFACSD.Manufacturing[index].unknown3;
            idNum.Value = MANFACSD.Manufacturing[index].textstratNum;
            famHexLabel.Text = MANFACSD.Manufacturing[index].familyNum.ToString("X");
            unitNum.Value = MANFACSD.Manufacturing[index].number;
            unitHexLabel.Text = MANFACSD.Manufacturing[index].number.ToString("X");
            ItemPicture.SizeMode = PictureBoxSizeMode.Zoom;
            ItemPicture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\edata\\edata.00" + num);
            MANFACSD.UnlockChange();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (MANFACSD.unsavedManufacturingData)
            {
                MANFACSD.GetManufacturingPath();
                MANFACSD.SaveManufacturingData(MANFACSD.GetManufacturingPath());
                MANFACSD.ClearUnsavedData();
            }
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (MANFACSD.unsavedManufacturingData)
            {
                if (MessageBox.Show(this, "Unsaved Manufacturing data, are you sure you want to Close this Dialog?", "Save data", MessageBoxButtons.YesNo) != DialogResult.Yes)
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
                MANFACSD.SaveManufacturingData(saveFileDialog.FileName);
                MANFACSD.ClearUnsavedData();
                int num = (int)MessageBox.Show(this, "Manufacturing Data Saved", "", MessageBoxButtons.OK);
            }
            ItemSelect.Focus();
        }

        private void openNew_Click(object sender, EventArgs e)
        {
            if (MANFACSD.unsavedManufacturingData && MessageBox.Show(this, "Save Manufacturing data before opening new datafile?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MANFACSD.SaveManufacturingData(MANFACSD.GetManufacturingPath());
                MANFACSD.ClearUnsavedData();
            }
            MANFACSD.OpenNewManufacturingFile();
            DisplayManufacturingData(ItemSelect.Value);
            ItemSelect.Focus();
        }

        private void ManufacturingForm_Load(object sender, EventArgs e)
        {
            if (RegistryKeys.PlaySounds)
            {
                Sound.Play(Resources.open_wav);
            }

            if (RegistryKeys.PlayMusic)
            {
                Sound.PlayRandomMusic();
            }

            DisplayManufacturingData(ItemSelect.Value);
            ItemSelect.Focus();
        }

        private void ManufacturingForm_KeyDown(object sender, KeyEventArgs e)
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

        private void ManufacturingForm_FormClosing(object sender, FormClosingEventArgs e)
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
