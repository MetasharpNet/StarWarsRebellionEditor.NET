namespace SwRebellionEditor
{
    public partial class SystemFacilitiesRimTablesForm : Form
    {
        public SystemFacilitiesRimTablesForm()
        {
            InitializeComponent();
        }

        private int facilityBoxChange(string facility)
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

        private void updateFacilityBox1(object sender, EventArgs e)
        {
            SYFCRMTB.Table[0].facilityNum = (byte)facilityBoxChange(FacilityBox1.Text);
            switch (FacilityBox1.Text)
            {
                case "Advanced Construction":
                    facType1.Value = 6M;
                    break;
                case "Construction":
                    facType1.Value = 3M;
                    break;
                case "Advanced Shipyard":
                    facType1.Value = 4M;
                    break;
                case "Shipyard":
                    facType1.Value = 1M;
                    break;
                case "Advanced Troop Training":
                    facType1.Value = 5M;
                    break;
                case "Training":
                    facType1.Value = 2M;
                    break;
                case "Refinery":
                    facType1.Value = 2M;
                    break;
                case "Shield":
                    facType1.Value = 3M;
                    break;
                case "Shield Generator II":
                    facType1.Value = 3M;
                    break;
                case "Laser":
                    facType1.Value = 2M;
                    break;
                case "Laser II":
                    facType1.Value = 2M;
                    break;
                case "Ion":
                    facType1.Value = 1M;
                    break;
                default:
                    facType1.Value = 0M;
                    break;
            }
            SYFCRMTB.SetUnsavedData();
        }

        private void updateFacilityBox2(object sender, EventArgs e)
        {
            SYFCRMTB.Table[1].facilityNum = (byte)facilityBoxChange(FacilityBox2.Text);
            switch (FacilityBox2.Text)
            {
                case "Advanced Construction":
                    facType2.Value = 6M;
                    break;
                case "Construction":
                    facType2.Value = 3M;
                    break;
                case "Advanced Shipyard":
                    facType2.Value = 4M;
                    break;
                case "Shipyard":
                    facType2.Value = 1M;
                    break;
                case "Advanced Troop Training":
                    facType2.Value = 5M;
                    break;
                case "Training":
                    facType2.Value = 2M;
                    break;
                case "Refinery":
                    facType2.Value = 2M;
                    break;
                case "Shield":
                    facType2.Value = 3M;
                    break;
                case "Shield Generator II":
                    facType2.Value = 3M;
                    break;
                case "Laser":
                    facType2.Value = 2M;
                    break;
                case "Laser II":
                    facType2.Value = 2M;
                    break;
                case "Ion":
                    facType2.Value = 1M;
                    break;
                default:
                    facType2.Value = 0M;
                    break;
            }
            SYFCRMTB.SetUnsavedData();
        }

        private void updateFacilityBox3(object sender, EventArgs e)
        {
            SYFCRMTB.Table[2].facilityNum = (byte)facilityBoxChange(FacilityBox3.Text);
            switch (FacilityBox3.Text)
            {
                case "Advanced Construction":
                    facType3.Value = 6M;
                    break;
                case "Construction":
                    facType3.Value = 3M;
                    break;
                case "Advanced Shipyard":
                    facType3.Value = 4M;
                    break;
                case "Shipyard":
                    facType3.Value = 1M;
                    break;
                case "Advanced Troop Training":
                    facType3.Value = 5M;
                    break;
                case "Training":
                    facType3.Value = 2M;
                    break;
                case "Refinery":
                    facType3.Value = 2M;
                    break;
                case "Shield":
                    facType3.Value = 3M;
                    break;
                case "Shield Generator II":
                    facType3.Value = 3M;
                    break;
                case "Laser":
                    facType3.Value = 2M;
                    break;
                case "Laser II":
                    facType3.Value = 2M;
                    break;
                case "Ion":
                    facType3.Value = 1M;
                    break;
                default:
                    facType3.Value = 0M;
                    break;
            }
            SYFCRMTB.SetUnsavedData();
        }

        private void updateFacilityBox4(object sender, EventArgs e)
        {
            SYFCRMTB.Table[3].facilityNum = (byte)facilityBoxChange(FacilityBox4.Text);
            switch (FacilityBox4.Text)
            {
                case "Advanced Construction":
                    facType4.Value = 6M;
                    break;
                case "Construction":
                    facType4.Value = 3M;
                    break;
                case "Advanced Shipyard":
                    facType4.Value = 4M;
                    break;
                case "Shipyard":
                    facType4.Value = 1M;
                    break;
                case "Advanced Troop Training":
                    facType4.Value = 5M;
                    break;
                case "Training":
                    facType4.Value = 2M;
                    break;
                case "Refinery":
                    facType4.Value = 2M;
                    break;
                case "Shield":
                    facType4.Value = 3M;
                    break;
                case "Shield Generator II":
                    facType4.Value = 3M;
                    break;
                case "Laser":
                    facType4.Value = 2M;
                    break;
                case "Laser II":
                    facType4.Value = 2M;
                    break;
                case "Ion":
                    facType4.Value = 1M;
                    break;
                default:
                    facType4.Value = 0M;
                    break;
            }
            SYFCRMTB.SetUnsavedData();
        }

        private void updateFacilityBox5(object sender, EventArgs e)
        {
            SYFCRMTB.Table[4].facilityNum = (byte)facilityBoxChange(FacilityBox5.Text);
            switch (FacilityBox5.Text)
            {
                case "Advanced Construction":
                    facType5.Value = 6M;
                    break;
                case "Construction":
                    facType5.Value = 3M;
                    break;
                case "Advanced Shipyard":
                    facType5.Value = 4M;
                    break;
                case "Shipyard":
                    facType5.Value = 1M;
                    break;
                case "Advanced Troop Training":
                    facType5.Value = 5M;
                    break;
                case "Training":
                    facType5.Value = 2M;
                    break;
                case "Refinery":
                    facType5.Value = 2M;
                    break;
                case "Shield":
                    facType5.Value = 3M;
                    break;
                case "Shield Generator II":
                    facType5.Value = 3M;
                    break;
                case "Laser":
                    facType5.Value = 2M;
                    break;
                case "Laser II":
                    facType5.Value = 2M;
                    break;
                case "Ion":
                    facType5.Value = 1M;
                    break;
                default:
                    facType5.Value = 0M;
                    break;
            }
            SYFCRMTB.SetUnsavedData();
        }

        private void updateFacilityBox6(object sender, EventArgs e)
        {
            SYFCRMTB.Table[5].facilityNum = (byte)facilityBoxChange(FacilityBox6.Text);
            switch (FacilityBox6.Text)
            {
                case "Advanced Construction":
                    facType6.Value = 6M;
                    break;
                case "Construction":
                    facType6.Value = 3M;
                    break;
                case "Advanced Shipyard":
                    facType6.Value = 4M;
                    break;
                case "Shipyard":
                    facType6.Value = 1M;
                    break;
                case "Advanced Troop Training":
                    facType6.Value = 5M;
                    break;
                case "Training":
                    facType6.Value = 2M;
                    break;
                case "Refinery":
                    facType6.Value = 2M;
                    break;
                case "Shield":
                    facType6.Value = 3M;
                    break;
                case "Shield Generator II":
                    facType6.Value = 3M;
                    break;
                case "Laser":
                    facType6.Value = 2M;
                    break;
                case "Laser II":
                    facType6.Value = 2M;
                    break;
                case "Ion":
                    facType6.Value = 1M;
                    break;
                default:
                    facType6.Value = 0M;
                    break;
            }
            SYFCRMTB.SetUnsavedData();
        }

        private void updateFacilityBox7(object sender, EventArgs e)
        {
            SYFCRMTB.Table[6].facilityNum = (byte)facilityBoxChange(FacilityBox7.Text);
            switch (FacilityBox7.Text)
            {
                case "Advanced Construction":
                    facType7.Value = 6M;
                    break;
                case "Construction":
                    facType7.Value = 3M;
                    break;
                case "Advanced Shipyard":
                    facType7.Value = 4M;
                    break;
                case "Shipyard":
                    facType7.Value = 1M;
                    break;
                case "Advanced Troop Training":
                    facType7.Value = 5M;
                    break;
                case "Training":
                    facType7.Value = 2M;
                    break;
                case "Refinery":
                    facType7.Value = 2M;
                    break;
                case "Shield":
                    facType7.Value = 3M;
                    break;
                case "Shield Generator II":
                    facType7.Value = 3M;
                    break;
                case "Laser":
                    facType7.Value = 2M;
                    break;
                case "Laser II":
                    facType7.Value = 2M;
                    break;
                case "Ion":
                    facType7.Value = 1M;
                    break;
                default:
                    facType7.Value = 0M;
                    break;
            }
            SYFCRMTB.SetUnsavedData();
        }

        private void updateFacilityBox8(object sender, EventArgs e)
        {
            SYFCRMTB.Table[7].facilityNum = (byte)facilityBoxChange(FacilityBox8.Text);
            switch (FacilityBox8.Text)
            {
                case "Advanced Construction":
                    facType8.Value = 6M;
                    break;
                case "Construction":
                    facType8.Value = 3M;
                    break;
                case "Advanced Shipyard":
                    facType8.Value = 4M;
                    break;
                case "Shipyard":
                    facType8.Value = 1M;
                    break;
                case "Advanced Troop Training":
                    facType8.Value = 5M;
                    break;
                case "Training":
                    facType8.Value = 2M;
                    break;
                case "Refinery":
                    facType8.Value = 2M;
                    break;
                case "Shield":
                    facType8.Value = 3M;
                    break;
                case "Shield Generator II":
                    facType8.Value = 3M;
                    break;
                case "Laser":
                    facType8.Value = 2M;
                    break;
                case "Laser II":
                    facType8.Value = 2M;
                    break;
                case "Ion":
                    facType8.Value = 1M;
                    break;
                default:
                    facType8.Value = 0M;
                    break;
            }
            SYFCRMTB.SetUnsavedData();
        }

        private void updateFacType1(object sender, EventArgs e)
        {
            if (FacilityBox1.Text == "Advanced Shipyard" && facType1.Value == 3M)
            {
                FacilityBox1.Text = "Shipyard";
            }

            if (FacilityBox1.Text == "Shipyard" && facType1.Value == 6M)
            {
                FacilityBox1.Text = "Advanced Shipyard";
            }

            if (FacilityBox1.Text == "Advanced Troop Training" && facType1.Value == 2M)
            {
                FacilityBox1.Text = "Training";
            }

            if (FacilityBox1.Text == "Training" && facType1.Value == 5M)
            {
                FacilityBox1.Text = "Advanced Troop Training";
            }

            if (FacilityBox1.Text == "Advanced Construction" && facType1.Value == 1M)
            {
                FacilityBox1.Text = "Construction";
            }

            if (FacilityBox1.Text == "Construction" && facType1.Value == 4M)
            {
                FacilityBox1.Text = "Advanced Construction";
            }

            SYFCRMTB.Table[0].entNum2 = (byte)facType1.Value;
            SYFCRMTB.SetUnsavedData();
        }

        private void updateFacType2(object sender, EventArgs e)
        {
            if (FacilityBox2.Text == "Advanced Shipyard" && facType2.Value == 3M)
            {
                FacilityBox2.Text = "Shipyard";
            }

            if (FacilityBox2.Text == "Shipyard" && facType2.Value == 6M)
            {
                FacilityBox2.Text = "Advanced Shipyard";
            }

            if (FacilityBox2.Text == "Advanced Troop Training" && facType2.Value == 2M)
            {
                FacilityBox2.Text = "Training";
            }

            if (FacilityBox2.Text == "Training" && facType2.Value == 5M)
            {
                FacilityBox2.Text = "Advanced Troop Training";
            }

            if (FacilityBox2.Text == "Advanced Construction" && facType2.Value == 1M)
            {
                FacilityBox2.Text = "Construction";
            }

            if (FacilityBox2.Text == "Construction" && facType2.Value == 4M)
            {
                FacilityBox2.Text = "Advanced Construction";
            }

            SYFCRMTB.Table[1].entNum2 = (byte)facType2.Value;
            SYFCRMTB.SetUnsavedData();
        }

        private void updateFacType3(object sender, EventArgs e)
        {
            if (FacilityBox3.Text == "Advanced Shipyard" && facType3.Value == 3M)
            {
                FacilityBox3.Text = "Shipyard";
            }

            if (FacilityBox3.Text == "Shipyard" && facType3.Value == 6M)
            {
                FacilityBox3.Text = "Advanced Shipyard";
            }

            if (FacilityBox3.Text == "Advanced Troop Training" && facType3.Value == 2M)
            {
                FacilityBox3.Text = "Training";
            }

            if (FacilityBox3.Text == "Training" && facType3.Value == 5M)
            {
                FacilityBox3.Text = "Advanced Troop Training";
            }

            if (FacilityBox3.Text == "Advanced Construction" && facType3.Value == 1M)
            {
                FacilityBox3.Text = "Construction";
            }

            if (FacilityBox3.Text == "Construction" && facType3.Value == 4M)
            {
                FacilityBox3.Text = "Advanced Construction";
            }

            SYFCRMTB.Table[2].entNum2 = (byte)facType3.Value;
            SYFCRMTB.SetUnsavedData();
        }

        private void updateFacType4(object sender, EventArgs e)
        {
            if (FacilityBox4.Text == "Advanced Shipyard" && facType4.Value == 3M)
            {
                FacilityBox4.Text = "Shipyard";
            }

            if (FacilityBox4.Text == "Shipyard" && facType4.Value == 6M)
            {
                FacilityBox4.Text = "Advanced Shipyard";
            }

            if (FacilityBox4.Text == "Advanced Troop Training" && facType4.Value == 2M)
            {
                FacilityBox4.Text = "Training";
            }

            if (FacilityBox4.Text == "Training" && facType4.Value == 5M)
            {
                FacilityBox4.Text = "Advanced Troop Training";
            }

            if (FacilityBox4.Text == "Advanced Construction" && facType4.Value == 1M)
            {
                FacilityBox4.Text = "Construction";
            }

            if (FacilityBox4.Text == "Construction" && facType4.Value == 4M)
            {
                FacilityBox4.Text = "Advanced Construction";
            }

            SYFCRMTB.Table[3].entNum2 = (byte)facType4.Value;
            SYFCRMTB.SetUnsavedData();
        }

        private void updateFacType5(object sender, EventArgs e)
        {
            if (FacilityBox5.Text == "Advanced Shipyard" && facType5.Value == 3M)
            {
                FacilityBox5.Text = "Shipyard";
            }

            if (FacilityBox5.Text == "Shipyard" && facType5.Value == 6M)
            {
                FacilityBox5.Text = "Advanced Shipyard";
            }

            if (FacilityBox5.Text == "Advanced Troop Training" && facType5.Value == 2M)
            {
                FacilityBox5.Text = "Training";
            }

            if (FacilityBox5.Text == "Training" && facType5.Value == 5M)
            {
                FacilityBox5.Text = "Advanced Troop Training";
            }

            if (FacilityBox5.Text == "Advanced Construction" && facType5.Value == 1M)
            {
                FacilityBox5.Text = "Construction";
            }

            if (FacilityBox5.Text == "Construction" && facType5.Value == 4M)
            {
                FacilityBox5.Text = "Advanced Construction";
            }

            SYFCRMTB.Table[4].entNum2 = (byte)facType5.Value;
            SYFCRMTB.SetUnsavedData();
        }

        private void updateFacType6(object sender, EventArgs e)
        {
            if (FacilityBox6.Text == "Advanced Shipyard" && facType6.Value == 3M)
            {
                FacilityBox6.Text = "Shipyard";
            }

            if (FacilityBox6.Text == "Shipyard" && facType6.Value == 6M)
            {
                FacilityBox6.Text = "Advanced Shipyard";
            }

            if (FacilityBox6.Text == "Advanced Troop Training" && facType6.Value == 2M)
            {
                FacilityBox6.Text = "Training";
            }

            if (FacilityBox6.Text == "Training" && facType6.Value == 5M)
            {
                FacilityBox6.Text = "Advanced Troop Training";
            }

            if (FacilityBox6.Text == "Advanced Construction" && facType6.Value == 1M)
            {
                FacilityBox6.Text = "Construction";
            }

            if (FacilityBox6.Text == "Construction" && facType6.Value == 4M)
            {
                FacilityBox6.Text = "Advanced Construction";
            }

            SYFCRMTB.Table[5].entNum2 = (byte)facType6.Value;
            SYFCRMTB.SetUnsavedData();
        }

        private void updateFacType7(object sender, EventArgs e)
        {
            if (FacilityBox7.Text == "Advanced Shipyard" && facType7.Value == 3M)
            {
                FacilityBox7.Text = "Shipyard";
            }

            if (FacilityBox7.Text == "Shipyard" && facType7.Value == 6M)
            {
                FacilityBox7.Text = "Advanced Shipyard";
            }

            if (FacilityBox7.Text == "Advanced Troop Training" && facType7.Value == 2M)
            {
                FacilityBox7.Text = "Training";
            }

            if (FacilityBox7.Text == "Training" && facType7.Value == 5M)
            {
                FacilityBox7.Text = "Advanced Troop Training";
            }

            if (FacilityBox7.Text == "Advanced Construction" && facType7.Value == 1M)
            {
                FacilityBox7.Text = "Construction";
            }

            if (FacilityBox7.Text == "Construction" && facType7.Value == 4M)
            {
                FacilityBox7.Text = "Advanced Construction";
            }

            SYFCRMTB.Table[6].entNum2 = (byte)facType7.Value;
            SYFCRMTB.SetUnsavedData();
        }

        private void updateFacType8(object sender, EventArgs e)
        {
            if (FacilityBox8.Text == "Advanced Shipyard" && facType8.Value == 3M)
            {
                FacilityBox8.Text = "Shipyard";
            }

            if (FacilityBox8.Text == "Shipyard" && facType8.Value == 6M)
            {
                FacilityBox8.Text = "Advanced Shipyard";
            }

            if (FacilityBox8.Text == "Advanced Troop Training" && facType8.Value == 2M)
            {
                FacilityBox8.Text = "Training";
            }

            if (FacilityBox8.Text == "Training" && facType8.Value == 5M)
            {
                FacilityBox8.Text = "Advanced Troop Training";
            }

            if (FacilityBox8.Text == "Advanced Construction" && facType8.Value == 1M)
            {
                FacilityBox8.Text = "Construction";
            }

            if (FacilityBox8.Text == "Construction" && facType8.Value == 4M)
            {
                FacilityBox8.Text = "Advanced Construction";
            }

            SYFCRMTB.Table[7].entNum2 = (byte)facType8.Value;
            SYFCRMTB.SetUnsavedData();
        }

        private void updatePercNum1(object sender, EventArgs e)
        {
            SYFCRMTB.Table[0].ent1chance = (ushort)percNum1.Value;
            SYFCRMTB.SetUnsavedData();
        }

        private void updatePercNum2(object sender, EventArgs e)
        {
            SYFCRMTB.Table[1].ent1chance = (ushort)percNum2.Value;
            SYFCRMTB.SetUnsavedData();
        }

        private void updatePercNum3(object sender, EventArgs e)
        {
            SYFCRMTB.Table[2].ent1chance = (ushort)percNum3.Value;
            SYFCRMTB.SetUnsavedData();
        }

        private void updatePercNum4(object sender, EventArgs e)
        {
            SYFCRMTB.Table[3].ent1chance = (ushort)percNum4.Value;
            SYFCRMTB.SetUnsavedData();
        }

        private void updatePercNum5(object sender, EventArgs e)
        {
            SYFCRMTB.Table[4].ent1chance = (ushort)percNum5.Value;
            SYFCRMTB.SetUnsavedData();
        }

        private void updatePercNum6(object sender, EventArgs e)
        {
            SYFCRMTB.Table[5].ent1chance = (ushort)percNum6.Value;
            SYFCRMTB.SetUnsavedData();
        }

        private void updatePercNum7(object sender, EventArgs e)
        {
            SYFCRMTB.Table[6].ent1chance = (ushort)percNum7.Value;
            SYFCRMTB.SetUnsavedData();
        }

        private void updatePercNum8(object sender, EventArgs e)
        {
            SYFCRMTB.Table[7].ent1chance = (ushort)percNum8.Value;
            SYFCRMTB.SetUnsavedData();
        }

        private void SetFacilityBox()
        {
            switch (SYFCRMTB.Table[0].facilityNum)
            {
                case 34:
                    FacilityBox1.SelectedIndex = FacilityBox1.FindString("Ion");
                    break;
                case 35:
                    FacilityBox1.SelectedIndex = FacilityBox1.FindString("Laser");
                    break;
                case 36:
                    FacilityBox1.SelectedIndex = FacilityBox1.FindString("Shield");
                    break;
                case 40:
                    if (SYFCRMTB.Table[0].entNum2 == 6)
                    {
                        FacilityBox1.SelectedIndex = FacilityBox1.FindString("Advanced Shipyard");
                        break;
                    }
                    FacilityBox1.SelectedIndex = FacilityBox1.FindString("Shipyard");
                    break;
                case 41:
                    FacilityBox1.SelectedIndex = FacilityBox1.FindString("Training");
                    break;
                case 42:
                    FacilityBox1.SelectedIndex = FacilityBox1.FindString("Construction");
                    break;
                case 45:
                    FacilityBox1.SelectedIndex = FacilityBox1.FindString("Refinery");
                    break;
            }
            switch (SYFCRMTB.Table[1].facilityNum)
            {
                case 34:
                    FacilityBox2.SelectedIndex = FacilityBox2.FindString("Ion");
                    break;
                case 35:
                    FacilityBox2.SelectedIndex = FacilityBox2.FindString("Laser");
                    break;
                case 36:
                    FacilityBox2.SelectedIndex = FacilityBox2.FindString("Shield");
                    break;
                case 40:
                    if (SYFCRMTB.Table[1].entNum2 == 6)
                    {
                        FacilityBox2.SelectedIndex = FacilityBox2.FindString("Advanced Shipyard");
                        break;
                    }
                    FacilityBox2.SelectedIndex = FacilityBox2.FindString("Shipyard");
                    break;
                case 41:
                    FacilityBox2.SelectedIndex = FacilityBox2.FindString("Training");
                    break;
                case 42:
                    FacilityBox2.SelectedIndex = FacilityBox2.FindString("Construction");
                    break;
                case 45:
                    FacilityBox2.SelectedIndex = FacilityBox2.FindString("Refinery");
                    break;
            }
            switch (SYFCRMTB.Table[2].facilityNum)
            {
                case 34:
                    FacilityBox3.SelectedIndex = FacilityBox3.FindString("Ion");
                    break;
                case 35:
                    FacilityBox3.SelectedIndex = FacilityBox3.FindString("Laser");
                    break;
                case 36:
                    FacilityBox3.SelectedIndex = FacilityBox3.FindString("Shield");
                    break;
                case 40:
                    if (SYFCRMTB.Table[2].entNum2 == 6)
                    {
                        FacilityBox3.SelectedIndex = FacilityBox3.FindString("Advanced Shipyard");
                        break;
                    }
                    FacilityBox3.SelectedIndex = FacilityBox3.FindString("Shipyard");
                    break;
                case 41:
                    if (SYFCRMTB.Table[2].entNum2 == 5)
                    {
                        FacilityBox3.SelectedIndex = FacilityBox3.FindString("Advanced Troop ");
                        break;
                    }
                    FacilityBox3.SelectedIndex = FacilityBox3.FindString("Training");
                    break;
                case 42:
                    if (SYFCRMTB.Table[2].entNum2 == 4)
                    {
                        FacilityBox3.SelectedIndex = FacilityBox3.FindString("Advanced Construction");
                        break;
                    }
                    FacilityBox3.SelectedIndex = FacilityBox3.FindString("Construction");
                    break;
                case 45:
                    FacilityBox3.SelectedIndex = FacilityBox3.FindString("Refinery");
                    break;
            }
            switch (SYFCRMTB.Table[3].facilityNum)
            {
                case 34:
                    FacilityBox4.SelectedIndex = FacilityBox4.FindString("Ion");
                    break;
                case 35:
                    FacilityBox4.SelectedIndex = FacilityBox4.FindString("Laser");
                    break;
                case 36:
                    FacilityBox4.SelectedIndex = FacilityBox4.FindString("Shield");
                    break;
                case 40:
                    if (SYFCRMTB.Table[3].entNum2 == 6)
                    {
                        FacilityBox4.SelectedIndex = FacilityBox4.FindString("Advanced Shipyard");
                        break;
                    }
                    FacilityBox4.SelectedIndex = FacilityBox4.FindString("Shipyard");
                    break;
                case 41:
                    if (SYFCRMTB.Table[3].entNum2 == 5)
                    {
                        FacilityBox4.SelectedIndex = FacilityBox4.FindString("Advanced Troop ");
                        break;
                    }
                    FacilityBox4.SelectedIndex = FacilityBox4.FindString("Training");
                    break;
                case 42:
                    if (SYFCRMTB.Table[3].entNum2 == 4)
                    {
                        FacilityBox4.SelectedIndex = FacilityBox4.FindString("Advanced Construction");
                        break;
                    }
                    FacilityBox4.SelectedIndex = FacilityBox4.FindString("Construction");
                    break;
                case 45:
                    FacilityBox4.SelectedIndex = FacilityBox4.FindString("Refinery");
                    break;
            }
            switch (SYFCRMTB.Table[4].facilityNum)
            {
                case 34:
                    FacilityBox5.SelectedIndex = FacilityBox5.FindString("Ion");
                    break;
                case 35:
                    FacilityBox5.SelectedIndex = FacilityBox5.FindString("Laser");
                    break;
                case 36:
                    FacilityBox5.SelectedIndex = FacilityBox5.FindString("Shield");
                    break;
                case 40:
                    if (SYFCRMTB.Table[4].entNum2 == 6)
                    {
                        FacilityBox5.SelectedIndex = FacilityBox5.FindString("Advanced Shipyard");
                        break;
                    }
                    FacilityBox5.SelectedIndex = FacilityBox5.FindString("Shipyard");
                    break;
                case 41:
                    if (SYFCRMTB.Table[4].entNum2 == 5)
                    {
                        FacilityBox5.SelectedIndex = FacilityBox5.FindString("Advanced Troop ");
                        break;
                    }
                    FacilityBox5.SelectedIndex = FacilityBox5.FindString("Training");
                    break;
                case 42:
                    if (SYFCRMTB.Table[4].entNum2 == 4)
                    {
                        FacilityBox5.SelectedIndex = FacilityBox5.FindString("Advanced Construction");
                        break;
                    }
                    FacilityBox5.SelectedIndex = FacilityBox5.FindString("Construction");
                    break;
                case 45:
                    FacilityBox5.SelectedIndex = FacilityBox5.FindString("Refinery");
                    break;
            }
            switch (SYFCRMTB.Table[5].facilityNum)
            {
                case 34:
                    FacilityBox6.SelectedIndex = FacilityBox6.FindString("Ion");
                    break;
                case 35:
                    FacilityBox6.SelectedIndex = FacilityBox6.FindString("Laser");
                    break;
                case 36:
                    FacilityBox6.SelectedIndex = FacilityBox6.FindString("Shield");
                    break;
                case 40:
                    if (SYFCRMTB.Table[5].entNum2 == 6)
                    {
                        FacilityBox6.SelectedIndex = FacilityBox6.FindString("Advanced Shipyard");
                        break;
                    }
                    FacilityBox6.SelectedIndex = FacilityBox6.FindString("Shipyard");
                    break;
                case 41:
                    if (SYFCRMTB.Table[5].entNum2 == 5)
                    {
                        FacilityBox6.SelectedIndex = FacilityBox6.FindString("Advanced Troop ");
                        break;
                    }
                    FacilityBox6.SelectedIndex = FacilityBox6.FindString("Training");
                    break;
                case 42:
                    if (SYFCRMTB.Table[5].entNum2 == 4)
                    {
                        FacilityBox6.SelectedIndex = FacilityBox6.FindString("Advanced Construction");
                        break;
                    }
                    FacilityBox6.SelectedIndex = FacilityBox6.FindString("Construction");
                    break;
                case 45:
                    FacilityBox6.SelectedIndex = FacilityBox6.FindString("Refinery");
                    break;
            }
            switch (SYFCRMTB.Table[6].facilityNum)
            {
                case 34:
                    FacilityBox7.SelectedIndex = FacilityBox7.FindString("Ion");
                    break;
                case 35:
                    FacilityBox7.SelectedIndex = FacilityBox7.FindString("Laser");
                    break;
                case 36:
                    FacilityBox7.SelectedIndex = FacilityBox7.FindString("Shield");
                    break;
                case 40:
                    if (SYFCRMTB.Table[6].entNum2 == 6)
                    {
                        FacilityBox7.SelectedIndex = FacilityBox7.FindString("Advanced Shipyard");
                        break;
                    }
                    FacilityBox7.SelectedIndex = FacilityBox7.FindString("Shipyard");
                    break;
                case 41:
                    if (SYFCRMTB.Table[6].entNum2 == 5)
                    {
                        FacilityBox7.SelectedIndex = FacilityBox7.FindString("Advanced Troop ");
                        break;
                    }
                    FacilityBox7.SelectedIndex = FacilityBox7.FindString("Training");
                    break;
                case 42:
                    if (SYFCRMTB.Table[6].entNum2 == 4)
                    {
                        FacilityBox7.SelectedIndex = FacilityBox7.FindString("Advanced Construction");
                        break;
                    }
                    FacilityBox7.SelectedIndex = FacilityBox7.FindString("Construction");
                    break;
                case 45:
                    FacilityBox7.SelectedIndex = FacilityBox7.FindString("Refinery");
                    break;
            }
        }

        private void DisplayTableData(int index)
        {
            SYFCRMTB.LockChange();
            percNum1.Value = SYFCRMTB.Table[0].ent1chance;
            percNum2.Value = SYFCRMTB.Table[1].ent1chance;
            percNum3.Value = SYFCRMTB.Table[2].ent1chance;
            percNum4.Value = SYFCRMTB.Table[3].ent1chance;
            percNum5.Value = SYFCRMTB.Table[4].ent1chance;
            percNum6.Value = SYFCRMTB.Table[5].ent1chance;
            percNum7.Value = SYFCRMTB.Table[6].ent1chance;
            facType1.Value = SYFCRMTB.Table[0].entNum2;
            facType2.Value = SYFCRMTB.Table[1].entNum2;
            facType3.Value = SYFCRMTB.Table[2].entNum2;
            facType4.Value = SYFCRMTB.Table[3].entNum2;
            facType5.Value = SYFCRMTB.Table[4].entNum2;
            facType6.Value = SYFCRMTB.Table[5].entNum2;
            facType7.Value = SYFCRMTB.Table[6].entNum2;
            SetFacilityBox();
            SYFCRMTB.UnlockChange();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            if (RegistryKeys.PlaySounds)
            {
                Sound.Play(Resources.open_wav);
            }

            if (RegistryKeys.PlayMusic)
            {
                Sound.PlayRandomMusic();
            }

            DisplayTableData(0);
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = RegistryKeys.InstalledLocation + "\\Gdata";
            saveFileDialog.Filter = "Data Files (*.dat)| *.dat";
            saveFileDialog.FileName = SYFCRMTB.fileName;
            if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            SYFCRMTB.SaveTableData(saveFileDialog.FileName);
            SYFCRMTB.ClearUnsavedData();
            int num = (int)MessageBox.Show(this, "Table Data Saved", "", MessageBoxButtons.OK);
        }

        private void openNew_Click(object sender, EventArgs e)
        {
            if (SYFCRMTB.unsavedTableData && MessageBox.Show(this, "Save Table data before opening new datafile?", "Save data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SYFCRMTB.SaveTableData(SYFCRMTB.GetTablePath());
                SYFCRMTB.ClearUnsavedData();
            }
            SYFCRMTB.OpenNewTableFile();
            DisplayTableData(0);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (SYFCRMTB.unsavedTableData)
            {
                if (MessageBox.Show(this, "Unsaved Table data, are you sure you want to Close this Dialog?", "Save data", MessageBoxButtons.YesNo) != DialogResult.Yes)
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
            if (SYFCRMTB.unsavedTableData)
            {
                SYFCRMTB.SaveTableData(SYFCRMTB.GetTablePath());
                SYFCRMTB.ClearUnsavedData();
            }
            Close();
        }

        private void TableForm_FormClosing(object sender, FormClosingEventArgs e)
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
