namespace SwRebellionEditor
{
    public partial class GeneralParametersTablesForm : Form
    {
        public GeneralParametersTablesForm()
        {
            InitializeComponent();
        }

        private void updateEmpNov(object sender, EventArgs e)
        {
            GNPRTB.GNPRTBrec[0].empNov = (byte)empNoviceNum.Value;
            GNPRTB.SetUnsavedData();
        }

        private void updateEmpInt(object sender, EventArgs e)
        {
            GNPRTB.GNPRTBrec[0].empInt = (byte)empInterNum.Value;
            GNPRTB.SetUnsavedData();
        }

        private void updateEmpAdv(object sender, EventArgs e)
        {
            GNPRTB.GNPRTBrec[0].empAdv = (byte)empAdvancedNum.Value;
            GNPRTB.SetUnsavedData();
        }

        private void updateRebNov(object sender, EventArgs e)
        {
            GNPRTB.GNPRTBrec[0].rebNov = (byte)rebNoviceNum.Value;
            GNPRTB.SetUnsavedData();
        }

        private void updateRebInt(object sender, EventArgs e)
        {
            GNPRTB.GNPRTBrec[0].rebInt = (byte)rebInterNum.Value;
            GNPRTB.SetUnsavedData();
        }

        private void updateRebAdv(object sender, EventArgs e)
        {
            GNPRTB.GNPRTBrec[0].rebAdv = (byte)rebAdvancedNum.Value;
            GNPRTB.SetUnsavedData();
        }

        private void updatemfNov(object sender, EventArgs e)
        {
            GNPRTB.GNPRTBrec[0].mfNov = (byte)mfNoviceNum.Value;
            GNPRTB.SetUnsavedData();
        }

        private void updatemfInt(object sender, EventArgs e)
        {
            GNPRTB.GNPRTBrec[0].mfInt = (byte)mfInterNum.Value;
            GNPRTB.SetUnsavedData();
        }

        private void updatemfAdv(object sender, EventArgs e)
        {
            GNPRTB.GNPRTBrec[0].mfAdv = (byte)mfAdvancedNum.Value;
            GNPRTB.SetUnsavedData();
        }

        private void updateRebUnk(object sender, EventArgs e)
        {
            GNPRTB.GNPRTBrec[0].rebUnk = (byte)rebUnk1Num.Value;
            GNPRTB.SetUnsavedData();
        }

        private void updateEmpUnk(object sender, EventArgs e)
        {
            GNPRTB.GNPRTBrec[0].empUnk = (byte)empUnk1Num.Value;
            GNPRTB.SetUnsavedData();
        }

        private void updateMfUnk1(object sender, EventArgs e)
        {
            GNPRTB.GNPRTBrec[0].mfUnk1 = (byte)mfUnk1Num.Value;
            GNPRTB.SetUnsavedData();
        }

        private void updateMfUnk2(object sender, EventArgs e)
        {
            GNPRTB.GNPRTBrec[0].mfUnk2 = (byte)mfUnk2Num.Value;
            GNPRTB.SetUnsavedData();
        }

        private void updateMfUnk3(object sender, EventArgs e)
        {
            GNPRTB.GNPRTBrec[0].mfUnk3 = (byte)mfUnk3Num.Value;
            GNPRTB.SetUnsavedData();
        }

        private void updateMfUnk4(object sender, EventArgs e)
        {
            GNPRTB.GNPRTBrec[0].mfUnk4 = (byte)mfUnk4Num.Value;
            GNPRTB.SetUnsavedData();
        }

        private void updateMfUnk5(object sender, EventArgs e)
        {
            GNPRTB.GNPRTBrec[0].mfUnk5 = (byte)mfUnk5Num.Value;
            GNPRTB.SetUnsavedData();
        }

        private void GNPRTBForm_Load(object sender, EventArgs e)
        {
            if (RegistryKeys.PlaySounds)
            {
                Sound.Play(Resources.open_wav);
            }

            if (RegistryKeys.PlayMusic)
            {
                Sound.PlayRandomMusic();
            }

            DisplayGNPRTBData(0);
        }

        private void DisplayGNPRTBData(int index)
        {
            GNPRTB.LockChange();
            empNoviceNum.Value = GNPRTB.GNPRTBrec[0].empNov;
            empInterNum.Value = GNPRTB.GNPRTBrec[0].empInt;
            empAdvancedNum.Value = GNPRTB.GNPRTBrec[0].empAdv;
            rebNoviceNum.Value = GNPRTB.GNPRTBrec[0].rebNov;
            rebInterNum.Value = GNPRTB.GNPRTBrec[0].rebInt;
            rebAdvancedNum.Value = GNPRTB.GNPRTBrec[0].rebAdv;
            mfNoviceNum.Value = GNPRTB.GNPRTBrec[0].mfNov;
            mfInterNum.Value = GNPRTB.GNPRTBrec[0].mfInt;
            mfAdvancedNum.Value = GNPRTB.GNPRTBrec[0].mfAdv;
            empUnk1Num.Value = GNPRTB.GNPRTBrec[0].empUnk;
            rebUnk1Num.Value = GNPRTB.GNPRTBrec[0].rebUnk;
            mfUnk1Num.Value = GNPRTB.GNPRTBrec[0].mfUnk1;
            mfUnk2Num.Value = GNPRTB.GNPRTBrec[0].mfUnk2;
            mfUnk3Num.Value = GNPRTB.GNPRTBrec[0].mfUnk3;
            mfUnk4Num.Value = GNPRTB.GNPRTBrec[0].mfUnk4;
            mfUnk5Num.Value = GNPRTB.GNPRTBrec[0].mfUnk5;
            GNPRTB.UnlockChange();
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = RegistryKeys.InstalledLocation + "\\Gdata";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                GNPRTB.SaveGNPRTBData(saveFileDialog.FileName);
                GNPRTB.ClearUnsavedData();
                int num = (int)MessageBox.Show(this, "GNPRTB.DAT Data Saved", "", MessageBoxButtons.OK);
            }
            empNoviceNum.Focus();
        }

        private void openNew_Click(object sender, EventArgs e)
        {
            if (GNPRTB.unsavedGNPRTBData && MessageBox.Show(this, "Save GNPRTB.DAT data before opening new datafile?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GNPRTB.SaveGNPRTBData(GNPRTB.GetGNPRTBPath());
                GNPRTB.ClearUnsavedData();
            }
            GNPRTB.OpenNewGNPRTBFile();
            DisplayGNPRTBData(0);
            empNoviceNum.Focus();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (GNPRTB.unsavedGNPRTBData)
            {
                if (MessageBox.Show(this, "Unsaved GNPRTB.DAT data, are you sure you want to Close this Dialog?", "Save data", MessageBoxButtons.YesNo) != DialogResult.Yes)
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
            if (GNPRTB.unsavedGNPRTBData)
            {
                GNPRTB.GetGNPRTBPath();
                GNPRTB.SaveGNPRTBData(GNPRTB.GetGNPRTBPath());
                GNPRTB.ClearUnsavedData();
            }
            Close();
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
