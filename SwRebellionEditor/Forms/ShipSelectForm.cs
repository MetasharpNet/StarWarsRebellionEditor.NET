namespace SwRebellionEditor
{/*
    public partial class ShipSelectForm : Form
    {
        public ShipSelectForm()
        {
            InitializeComponent();
        }

        private void LoadRebShips()
        {
            shipSelList.Items.AddRange(new object[15]
{
       "Mon Calamari Cruiser",
       "Bulk Cruiser",
       "Assault Frigate",
       "Nebulon-B Frigate",
       "Alliance Escort Carrier",
       "Corellian Corvette",
       "Medium Transport",
       "Bulk Transport",
       "Corellian Gunship",
       "Alliance DreadNaught",
       "CC-7700 Frigate",
       "Bulwark Battlecruiser",
       "Liberator Cruiser",
       "CC-9600 Frigate",
       "Dauntless Cruiser"
});
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            shipSelList.Enabled = false;
            if (planetRadio1.Checked)
            {
                puGroupBox.Enabled = true;
                puTroopRadio.Enabled = true;
                puFighterRadio.Enabled = true;
                puSpecOpsRadio.Enabled = true;
            }
            else
            {
                puGroupBox.Enabled = false;
                puTroopRadio.Enabled = false;
                puFighterRadio.Enabled = false;
                puSpecOpsRadio.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            shipSelList.Enabled = true;
        }

        private void Form_ShipSelect_Load(object sender, EventArgs e)
        {
            shipSelList.Enabled = false;
            planetRadio1.Checked = true;
            LoadRebShips();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (planetRadio1.Checked)
            {
                CMUNAllianceTablesForm.ShipSelected = "Planetary System";
                if (puTroopRadio.Checked)
                {
                    CMUNAllianceTablesForm.UnitType = 16;
                    Close();
                }
                else if (puFighterRadio.Checked)
                {
                    CMUNAllianceTablesForm.UnitType = 28;
                    Close();
                }
                else if (puSpecOpsRadio.Checked)
                {
                    CMUNAllianceTablesForm.UnitType = 60;
                    Close();
                }
                else
                {
                    CMUNAllianceTablesForm.UnitType = 0;
                }
            }
            else
            {
                CMUNAllianceTablesForm.ShipSelected = (string)shipSelList.SelectedItem;
                Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            CMUNAllianceTablesForm.ShipSelected = "";
            Close();
        }
    }
*/}
