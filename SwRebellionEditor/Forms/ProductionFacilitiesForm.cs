namespace SwRebellionEditor
{
    public partial class ProductionFacilitiesForm : Form
    {
        public ProductionFacilitiesForm()
        {
            InitializeComponent();
        }

        private void updateConCost(object sender, EventArgs e)
        {
            PROFACSD.ProdFac[ItemSelect.Value].conCost = (uint)conCostNum.Value;
            PROFACSD.SetUnsavedData();
        }

        private void updateMaintCost(object sender, EventArgs e)
        {
            PROFACSD.ProdFac[ItemSelect.Value].maintCost = (uint)maintCostNum.Value;
            PROFACSD.SetUnsavedData();
        }

        private void updateResearchNum(object sender, EventArgs e)
        {
            PROFACSD.ProdFac[ItemSelect.Value].researchNum = (uint)researchNum.Value;
            PROFACSD.SetUnsavedData();
        }

        private void updateRateNum(object sender, EventArgs e)
        {
            PROFACSD.ProdFac[ItemSelect.Value].rate = (uint)RateNum.Value;
            PROFACSD.SetUnsavedData();
        }

        private void updateResDiffNum(object sender, EventArgs e)
        {
            PROFACSD.ProdFac[ItemSelect.Value].researchDiff = (uint)resDiffNum.Value;
            PROFACSD.SetUnsavedData();
        }

        private void updateUnknownMoralHpNum(object sender, EventArgs e)
        {
            PROFACSD.ProdFac[ItemSelect.Value].unknown4 = (uint)unknownMoralHpNum.Value;
            PROFACSD.SetUnsavedData();
        }

        private void updateProdFacNum(object sender, EventArgs e)
        {
            PROFACSD.ProdFac[ItemSelect.Value].prodFacilityNum = (uint)prodFacNum.Value;
            PROFACSD.SetUnsavedData();
        }

        private void updateSecProdFacNum(object sender, EventArgs e)
        {
            PROFACSD.ProdFac[ItemSelect.Value].unknown2 = (uint)secProdFacNum.Value;
            PROFACSD.SetUnsavedData();
        }

        private void updateFamilyIdNum(object sender, EventArgs e)
        {
            PROFACSD.ProdFac[ItemSelect.Value].familyNum = (uint)familyIdNum.Value;
            PROFACSD.SetUnsavedData();
        }

        private void updateRebelUnitCheck(object sender, EventArgs e)
        {
            PROFACSD.ProdFac[ItemSelect.Value].rebel = !rebelUnit.Checked ? 0U : 1U;
            PROFACSD.SetUnsavedData();
        }

        private void updateEmpireUnitCheck(object sender, EventArgs e)
        {
            PROFACSD.ProdFac[ItemSelect.Value].empire = !empireUnit.Checked ? 0U : 1U;
            PROFACSD.SetUnsavedData();
        }

        private void ProdFacFormUpdateUI(object sender, EventArgs e)
        {
            DisplayProdFacData(ItemSelect.Value);
        }

        private void DisplayProdFacData(int index)
        {
            int num = 1 + index;
            PROFACSD.LockChange();
            ItemName.Text = PROFACSD.ProdFac[index].swrName;
            conCostNum.Value = PROFACSD.ProdFac[index].conCost;
            maintCostNum.Value = PROFACSD.ProdFac[index].maintCost;
            researchNum.Value = PROFACSD.ProdFac[index].researchNum;
            RateNum.Value = PROFACSD.ProdFac[index].rate;
            resDiffNum.Value = PROFACSD.ProdFac[index].researchDiff;
            unknownMoralHpNum.Value = PROFACSD.ProdFac[index].unknown4;
            rebelUnit.Checked = PROFACSD.ProdFac[index].rebel > 0U;
            empireUnit.Checked = PROFACSD.ProdFac[index].empire > 0U;
            prodFacNum.Value = PROFACSD.ProdFac[index].prodFacilityNum;
            secProdFacNum.Value = PROFACSD.ProdFac[index].unknown2;
            familyIdNum.Value = PROFACSD.ProdFac[index].familyNum;
            unknown3Num.Value = PROFACSD.ProdFac[index].unknown3;
            idNum.Value = PROFACSD.ProdFac[index].textstratNum;
            famHexLabel.Text = PROFACSD.ProdFac[index].familyNum.ToString("X");
            unitNum.Value = PROFACSD.ProdFac[index].number;
            unitHexLabel.Text = PROFACSD.ProdFac[index].number.ToString("X");
            ItemPicture.SizeMode = PictureBoxSizeMode.Zoom;
            ItemPicture.Image = Image.FromFile(RegistryKeys.InstalledLocation + "\\edata\\edata.00" + num);
            PROFACSD.UnlockChange();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (PROFACSD.unsavedProdFacData)
            {
                PROFACSD.GetProdFacPath();
                PROFACSD.SaveProdFacData(PROFACSD.GetProdFacPath());
                PROFACSD.ClearUnsavedData();
            }
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (PROFACSD.unsavedProdFacData)
            {
                if (MessageBox.Show(this, "Unsaved ProdFac data, are you sure you want to Close this Dialog?", "Save data", MessageBoxButtons.YesNo) != DialogResult.Yes)
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
                PROFACSD.SaveProdFacData(saveFileDialog.FileName);
                PROFACSD.ClearUnsavedData();
                int num = (int)MessageBox.Show(this, "ProdFac Data Saved", "", MessageBoxButtons.OK);
            }
            ItemSelect.Focus();
        }

        private void openNew_Click(object sender, EventArgs e)
        {
            if (PROFACSD.unsavedProdFacData && MessageBox.Show(this, "Save ProdFac data before opening new datafile?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PROFACSD.SaveProdFacData(PROFACSD.GetProdFacPath());
                PROFACSD.ClearUnsavedData();
            }
            PROFACSD.OpenNewProdFacFile();
            DisplayProdFacData(ItemSelect.Value);
            ItemSelect.Focus();
        }

        private void ProdFacForm_Load(object sender, EventArgs e)
        {
            if (RegistryKeys.PlaySounds)
            {
                Sound.Play(Resources.open_wav);
            }

            if (RegistryKeys.PlayMusic)
            {
                Sound.PlayRandomMusic();
            }

            DisplayProdFacData(ItemSelect.Value);
            ItemSelect.Select();
        }

        private void ProdFacForm_KeyDown(object sender, KeyEventArgs e)
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

        private void ProdFacForm_FormClosing(object sender, FormClosingEventArgs e)
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
