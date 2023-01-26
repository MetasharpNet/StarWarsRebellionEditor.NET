namespace SwRebellionEditor;

public partial class SystemFacilitiesCoreTablesForm : SystemFacilitiesCoreTablesDesignForm
{
    #region .ctor

    public SystemFacilitiesCoreTablesForm()
    {
        GameFilePath = Path.Combine(Settings.Current.GDataFolder, "SYFCCRTB.DAT");
        GameFile = DatFile.Load<SYFCCRTB>(GameFilePath);
        InitializeComponent();
    }

    #endregion

    #region Business Layer

    protected override void DisplaySelectedGameObject(int selectorIndex)
    {
        var previousUnsavedData = GameFile.UnsavedData;
        facilityPercent0.Value = GameFile.FacilityProbabilities[0].Percent;
        facilityPercent1.Value = GameFile.FacilityProbabilities[1].Percent;
        facilityPercent2.Value = GameFile.FacilityProbabilities[2].Percent;
        facilityPercent3.Value = GameFile.FacilityProbabilities[3].Percent;
        facilityPercent4.Value = GameFile.FacilityProbabilities[4].Percent;
        facilityPercent5.Value = GameFile.FacilityProbabilities[5].Percent;
        facilityPercent6.Value = GameFile.FacilityProbabilities[6].Percent;
        facilityPercent7.Value = GameFile.FacilityProbabilities[7].Percent;
        facilityType0.Value = GameFile.FacilityProbabilities[0].TypeId;
        facilityType1.Value = GameFile.FacilityProbabilities[1].TypeId;
        facilityType2.Value = GameFile.FacilityProbabilities[2].TypeId;
        facilityType3.Value = GameFile.FacilityProbabilities[3].TypeId;
        facilityType4.Value = GameFile.FacilityProbabilities[4].TypeId;
        facilityType5.Value = GameFile.FacilityProbabilities[5].TypeId;
        facilityType6.Value = GameFile.FacilityProbabilities[6].TypeId;
        facilityType7.Value = GameFile.FacilityProbabilities[7].TypeId;
        SelectFacilityIndex(facilityBox0, GameFile.FacilityProbabilities[0]);
        SelectFacilityIndex(facilityBox1, GameFile.FacilityProbabilities[1]);
        SelectFacilityIndex(facilityBox2, GameFile.FacilityProbabilities[2]);
        SelectFacilityIndex(facilityBox3, GameFile.FacilityProbabilities[3]);
        SelectFacilityIndex(facilityBox4, GameFile.FacilityProbabilities[4]);
        SelectFacilityIndex(facilityBox5, GameFile.FacilityProbabilities[5]);
        SelectFacilityIndex(facilityBox6, GameFile.FacilityProbabilities[6]);
        SelectFacilityIndex(facilityBox7, GameFile.FacilityProbabilities[7]);
        GameFile.UnsavedData = previousUnsavedData;
    }
    public byte FacilityStringToByte(string facility)
    {
        switch (facility)
        {
            case "Refinery":
                return 45;
            case "Construction":
                return 42;
            case "Advanced Construction":
                return 42;
            case "Shipyard":
                return 41;
            case "Advanced Shipyard":
                return 41;
            case "Training":
                return 40;
            case "Advanced Troop Training":
                return 40;
            case "Shield":
                return 36;
            case "Shield Generator II":
                return 36;
            case "Laser":
                return 35;
            case "Laser II":
                return 35;
            case "Ion":
                return 34;
            default:
                return 0;
        }
    }
    public decimal FacilityStringToFacilityTypeDecimal(string facility)
    {
        switch (facility)
        {
            case "Advanced Construction":
                return 6;
            case "Advanced Troop Training":
                return 5;
            case "Advanced Shipyard":
                return 4;
            case "Construction":
            case "Shield":
            case "Shield Generator II":
                return 3;
            case "Laser":
            case "Laser II":
            case "Refinery":
            case "Training":
                return 2;
            case "Ion":
            case "Shipyard":
                return 1;
            default:
                return 0;
        }
    }
    public void UpdateFacilityComboBox(ComboBox facility, decimal newFacilityId)
    {
        if (facility.Text == "Advanced Construction" && newFacilityId == 1)
            facility.Text = "Construction";
        else if (facility.Text == "Advanced Troop Training" && newFacilityId == 2)
            facility.Text = "Training";
        else if (facility.Text == "Advanced Shipyard" && newFacilityId == 3)
            facility.Text = "Shipyard";
        else if (facility.Text == "Construction" && newFacilityId == 4)
            facility.Text = "Advanced Construction";
        else if (facility.Text == "Training" && newFacilityId == 5)
            facility.Text = "Advanced Troop Training";
        else if (facility.Text == "Shipyard" && newFacilityId == 6)
            facility.Text = "Advanced Shipyard";
    }
    private void SelectFacilityIndex(ComboBox facility, SYFCCRTB_FacilityProbability facilityProbability)
    {
        switch (facilityProbability.FacilityId)
        {
            case 34:
                facility.SelectedIndex = facility.FindString("Ion");
                break;
            case 35:
                facility.SelectedIndex = facility.FindString("Laser");
                break;
            case 36:
                facility.SelectedIndex = facility.FindString("Shield");
                break;
            case 40:
                if (facilityProbability.TypeId == 6)
                {
                    facility.SelectedIndex = facility.FindString("Advanced Shipyard");
                    break;
                }
                facility.SelectedIndex = facility.FindString("Shipyard");
                break;
            case 41:
                if (facilityProbability.TypeId == 5)
                {
                    facility.SelectedIndex = facility.FindString("Advanced Troop ");
                    break;
                }
                facility.SelectedIndex = facilityBox2.FindString("Training");
                break;
            case 42:
                if (facilityProbability.TypeId == 4)
                {
                    facility.SelectedIndex = facility.FindString("Advanced Construction");
                    break;
                }
                facility.SelectedIndex = facility.FindString("Construction");
                break;
            case 45:
                facility.SelectedIndex = facility.FindString("Refinery");
                break;
        }
    }

    #endregion

    #region Control events

    private void facilityBox0_SelectionChangeCommitted(object sender, EventArgs e)
    {
        GameFile.FacilityProbabilities[0].FacilityId = FacilityStringToByte(facilityBox0.Text);
        facilityType0.Value = FacilityStringToFacilityTypeDecimal(facilityBox0.Text);
        GameFile.UnsavedData = true;
    }
    private void facilityBox1_SelectionChangeCommitted(object sender, EventArgs e)
    {
        GameFile.FacilityProbabilities[1].FacilityId = FacilityStringToByte(facilityBox1.Text);
        facilityType1.Value = FacilityStringToFacilityTypeDecimal(facilityBox1.Text);
        GameFile.UnsavedData = true;
    }
    private void facilityBox2_SelectionChangeCommitted(object sender, EventArgs e)
    {
        GameFile.FacilityProbabilities[2].FacilityId = FacilityStringToByte(facilityBox2.Text);
        facilityType2.Value = FacilityStringToFacilityTypeDecimal(facilityBox2.Text);
        GameFile.UnsavedData = true;
    }
    private void facilityBox3_SelectionChangeCommitted(object sender, EventArgs e)
    {
        GameFile.FacilityProbabilities[3].FacilityId = FacilityStringToByte(facilityBox3.Text);
        facilityType3.Value = FacilityStringToFacilityTypeDecimal(facilityBox3.Text);
        GameFile.UnsavedData = true;
    }
    private void facilityBox4_SelectionChangeCommitted(object sender, EventArgs e)
    {
        GameFile.FacilityProbabilities[4].FacilityId = FacilityStringToByte(facilityBox4.Text);
        facilityType4.Value = FacilityStringToFacilityTypeDecimal(facilityBox4.Text);
        GameFile.UnsavedData = true;
    }
    private void facilityBox5_SelectionChangeCommitted(object sender, EventArgs e)
    {
        GameFile.FacilityProbabilities[5].FacilityId = FacilityStringToByte(facilityBox5.Text);
        facilityType5.Value = FacilityStringToFacilityTypeDecimal(facilityBox5.Text);
        GameFile.UnsavedData = true;
    }
    private void facilityBox6_SelectionChangeCommitted(object sender, EventArgs e)
    {
        GameFile.FacilityProbabilities[6].FacilityId = FacilityStringToByte(facilityBox6.Text);
        facilityType6.Value = FacilityStringToFacilityTypeDecimal(facilityBox6.Text);
        GameFile.UnsavedData = true;
    }
    private void facilityBox7_SelectionChangeCommitted(object sender, EventArgs e)
    {
        GameFile.FacilityProbabilities[7].FacilityId = FacilityStringToByte(facilityBox7.Text);
        facilityType7.Value = FacilityStringToFacilityTypeDecimal(facilityBox7.Text);
        GameFile.UnsavedData = true;
    }
    private void facilityPercent0_ValueChanged(object sender, EventArgs e)
    {
        GameFile.FacilityProbabilities[0].Percent = (ushort)facilityPercent0.Value;
        GameFile.UnsavedData = true;
    }
    private void facilityPercent1_ValueChanged(object sender, EventArgs e)
    {
        GameFile.FacilityProbabilities[1].Percent = (ushort)facilityPercent1.Value;
        GameFile.UnsavedData = true;
    }
    private void facilityPercent2_ValueChanged(object sender, EventArgs e)
    {
        GameFile.FacilityProbabilities[2].Percent = (ushort)facilityPercent2.Value;
        GameFile.UnsavedData = true;
    }
    private void facilityPercent3_ValueChanged(object sender, EventArgs e)
    {
        GameFile.FacilityProbabilities[3].Percent = (ushort)facilityPercent3.Value;
        GameFile.UnsavedData = true;
    }
    private void facilityPercent4_ValueChanged(object sender, EventArgs e)
    {
        GameFile.FacilityProbabilities[4].Percent = (ushort)facilityPercent4.Value;
        GameFile.UnsavedData = true;
    }
    private void facilityPercent5_ValueChanged(object sender, EventArgs e)
    {
        GameFile.FacilityProbabilities[5].Percent = (ushort)facilityPercent5.Value;
        GameFile.UnsavedData = true;
    }
    private void facilityPercent6_ValueChanged(object sender, EventArgs e)
    {
        GameFile.FacilityProbabilities[6].Percent = (ushort)facilityPercent6.Value;
        GameFile.UnsavedData = true;
    }
    private void facilityPercent7_ValueChanged(object sender, EventArgs e)
    {
        GameFile.FacilityProbabilities[7].Percent = (ushort)facilityPercent7.Value;
        GameFile.UnsavedData = true;
    }
    private void facilityType0_ValueChanged(object sender, EventArgs e)
    {
        UpdateFacilityComboBox(facilityBox0, facilityType0.Value);
        GameFile.FacilityProbabilities[0].TypeId = (byte)facilityType0.Value;
        GameFile.UnsavedData = true;
    }
    private void facilityType1_ValueChanged(object sender, EventArgs e)
    {
        UpdateFacilityComboBox(facilityBox1, facilityType1.Value);
        GameFile.FacilityProbabilities[1].TypeId = (byte)facilityType1.Value;
        GameFile.UnsavedData = true;
    }
    private void facilityType2_ValueChanged(object sender, EventArgs e)
    {
        UpdateFacilityComboBox(facilityBox2, facilityType2.Value);
        GameFile.FacilityProbabilities[2].TypeId = (byte)facilityType2.Value;
        GameFile.UnsavedData = true;
    }
    private void facilityType3_ValueChanged(object sender, EventArgs e)
    {
        UpdateFacilityComboBox(facilityBox3, facilityType3.Value);
        GameFile.FacilityProbabilities[3].TypeId = (byte)facilityType3.Value;
        GameFile.UnsavedData = true;
    }
    private void facilityType4_ValueChanged(object sender, EventArgs e)
    {
        UpdateFacilityComboBox(facilityBox4, facilityType4.Value);
        GameFile.FacilityProbabilities[4].TypeId = (byte)facilityType4.Value;
        GameFile.UnsavedData = true;
    }
    private void facilityType5_ValueChanged(object sender, EventArgs e)
    {
        UpdateFacilityComboBox(facilityBox5, facilityType5.Value);
        GameFile.FacilityProbabilities[5].TypeId = (byte)facilityType5.Value;
        GameFile.UnsavedData = true;
    }
    private void facilityType6_ValueChanged(object sender, EventArgs e)
    {
        UpdateFacilityComboBox(facilityBox6, facilityType6.Value);
        GameFile.FacilityProbabilities[6].TypeId = (byte)facilityType6.Value;
        GameFile.UnsavedData = true;
    }
    private void facilityType7_ValueChanged(object sender, EventArgs e)
    {
        UpdateFacilityComboBox(facilityBox7, facilityType7.Value);
        GameFile.FacilityProbabilities[7].TypeId = (byte)facilityType7.Value;
        GameFile.UnsavedData = true;
    }

    #endregion
}
