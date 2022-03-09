namespace SwRebellionEditor
{
    public partial class CMUNAllianceTablesForm : Form
    {
        public CMUNAllianceTablesForm()
        {
            InitializeComponent();
        }

        private void LoadRebShips()
        {
            recTypeBox.Items.AddRange(new object[16]
{
       "Planetary System",
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

        private void LoadRebFighters()
        {
            addFighterBox.Items.AddRange(new object[5]
            {
         "A-Wing",
         "B-Wing",
         "X-Wing",
         "Y-Wing",
         ""
            });
            addFighterBox.SelectedIndex = 4;
        }

        private void LoadRebTroops()
        {
            addTroopBox.Items.AddRange(new object[6]
            {
         "Alliance Fleet Regiment",
         "Alliance Army Regiment",
         "Sullustan Regiment",
         "Wookie Regiment",
         "Mon Calamari Regiment",
         ""
            });
            addTroopBox.SelectedIndex = 5;
        }

        private void LoadRebSpecOps()
        {
            addSpecOpsBox.Items.AddRange(new object[6]
            {
         "Guerrillas",
         "Infiltrators",
         "Longmount Y-Wing Recon Team",
         "Bothian Spies",
         "Imperial Probe Droid",
         ""
            });
            addSpecOpsBox.SelectedIndex = 5;
        }

        private int CapShipNum(string capShipName)
        {
            switch (capShipName)
            {
                case "Mon Calamari Cruiser":
                    return 64;
                case "Bulk Cruiser":
                    return 65;
                case "Assault Frigate":
                    return 66;
                case "Nebulon-B Frigate":
                    return 67;
                case "Alliance Escort Carrier":
                    return 68;
                case "Corellian Corvette":
                    return 69;
                case "Medium Transport":
                    return 70;
                case "Bulk Transport":
                    return 71;
                case "Corellian Gunship":
                    return 72;
                case "Alliance DreadNaught":
                    return 73;
                case "CC-7700 Frigate":
                    return 74;
                case "Bulwark Battlecruiser":
                    return 75;
                case "Liberator Cruiser":
                    return 76;
                case "CC-9600 Frigate":
                    return 77;
                case "Dauntless Cruiser":
                    return 78;
                case "Strike Cruiser":
                    return 128;
                case "Lancer Frigate":
                    return 129;
                case "Interdictor Cruiser":
                    return 130;
                case "Carrack Light Cruiser":
                    return 131;
                case "Victory Star Destroyer":
                    return 132;
                case "Imperial Star Destroyer":
                    return 133;
                case "Super Star Destroyer":
                    return 134;
                case "Assult Shuttle":
                    return 135;
                case "Death Star":
                    return 136;
                case "Galleon":
                    return 137;
                case "Victory II Star Destroyer":
                    return 138;
                case "Imperial II Star Destroyer":
                    return 139;
                case "Star Galleon":
                    return 140;
                case "Imperial Escort Carrier":
                    return 141;
                case "Imperial Dreadnaught":
                    return 142;
                default:
                    return 0;
            }
        }

        private string CapShipName(int unitNum)
        {
            switch (unitNum)
            {
                case 64:
                    return "Mon Calamari Cruiser";
                case 65:
                    return "Bulk Cruiser";
                case 66:
                    return "Assault Frigate";
                case 67:
                    return "Nebulon-B Frigate";
                case 68:
                    return "Alliance Escort Carrier";
                case 69:
                    return "Corellian Corvette";
                case 70:
                    return "Medium Transport";
                case 71:
                    return "Bulk Transport";
                case 72:
                    return "Corellian Gunship";
                case 73:
                    return "Alliance DreadNaught";
                case 74:
                    return "CC-7700 Frigate";
                case 75:
                    return "Bulwark Battlecruiser";
                case 76:
                    return "Liberator Cruiser";
                case 77:
                    return "CC-9600 Frigate";
                case 78:
                    return "Dauntless Cruiser";
                case 128:
                    return "Strike Cruiser";
                case 129:
                    return "Lancer Frigate";
                case 130:
                    return "Interdictor Cruiser";
                case 131:
                    return "Carrack Light Cruiser";
                case 132:
                    return "Victory Star Destroyer";
                case 133:
                    return "Imperial Star Destroyer";
                case 134:
                    return "Super Star Destroyer";
                case 135:
                    return "Assult Shuttle";
                case 136:
                    return "Death Star";
                case 137:
                    return "Galleon";
                case 138:
                    return "Victory II Star Destroyer";
                case 139:
                    return "Imperial II Star Destroyer";
                case 140:
                    return "Star Galleon";
                case 141:
                    return "Imperial Escort Carrier";
                case 142:
                    return "Imperial Dreadnaught";
                default:
                    return "Unknown Ship ID";
            }
        }

        private string TroopName(int unitNum)
        {
            switch (unitNum)
            {
                case 1:
                    return "Alliance Fleet Regiment";
                case 2:
                    return "Alliance Army Regiment";
                case 3:
                    return "Sullustan Regiment";
                case 4:
                    return "Wookie Regiment";
                case 5:
                    return "Mon Calamari Regiment";
                case 6:
                    return "Stormtrooper Regiment";
                case 7:
                    return "Imperial Fleet Regiment";
                case 8:
                    return "Imperial Army Regiment";
                case 9:
                    return "War Droid Regiment";
                case 10:
                    return "Dark Trooper Regiment";
                default:
                    return "Unknown Troop ID";
            }
        }

        private int TroopNum(string unitName)
        {
            switch (unitName)
            {
                case "Alliance Fleet Regiment":
                    return 1;
                case "Alliance Army Regiment":
                    return 2;
                case "Sullustan Regiment":
                    return 3;
                case "Wookie Regiment":
                    return 4;
                case "Mon Calamari Regiment":
                    return 5;
                case "Stormtrooper Regiment":
                    return 6;
                case "Imperial Fleet Regiment":
                    return 7;
                case "Imperial Army Regiment":
                    return 8;
                case "War Droid Regiment":
                    return 9;
                case "Dark Trooper Regiment":
                    return 10;
                default:
                    return 0;
            }
        }

        private string SpecOpsName(int unitNum)
        {
            switch (unitNum)
            {
                case 1:
                    return "Guerrillas";
                case 2:
                    return "Infiltrators";
                case 3:
                    return "Longmount Y-Wing Recon Team";
                case 4:
                    return "Bothian Spies";
                case 5:
                    return "Imperial Probe Droid";
                case 6:
                    return "Imperial Espionage Droid";
                case 7:
                    return "Imperial Commandos";
                case 8:
                    return "Noghri Death Commandos";
                case 9:
                    return "Bounty Hunters";
                default:
                    return "Unknown Special Forces unit ID";
            }
        }

        private int SpecOpsNum(string unitName)
        {
            switch (unitName)
            {
                case "Guerrillas":
                    return 1;
                case "Infiltrators":
                    return 2;
                case "Longmount Y-Wing Recon Team":
                    return 3;
                case "Bothian Spies":
                    return 4;
                case "Imperial Probe Droid":
                    return 5;
                case "Imperial Espionage Droid":
                    return 6;
                case "Imperial Commandos":
                    return 7;
                case "Noghri Death Commandos":
                    return 8;
                case "Bounty Hunters":
                    return 9;
                default:
                    return 0;
            }
        }

        private string FighterName(int unitNum)
        {
            switch (unitNum)
            {
                case 1:
                    return "A-Wing";
                case 2:
                    return "B-Wing";
                case 3:
                    return "X-Wing";
                case 4:
                    return "Y-Wing";
                case 5:
                    return "Tie Fighter";
                case 6:
                    return "Tie Interceptor";
                case 7:
                    return "Tie Bomber";
                case 8:
                    return "Tie Defender";
                default:
                    return "Unknown Fighter ID";
            }
        }

        private int FighterNum(string unitName)
        {
            switch (unitName)
            {
                case "A-Wing":
                    return 1;
                case "B-Wing":
                    return 2;
                case "X-Wing":
                    return 3;
                case "Y-Wing":
                    return 4;
                case "Tie Fighter":
                    return 5;
                case "Tie Interceptor":
                    return 6;
                case "Tie Bomber":
                    return 7;
                case "Tie Defender":
                    return 8;
                default:
                    return 0;
            }
        }

        private string unitName(int i)
        {
            Ship ship = CMUNALTB.Ships[i];
            switch (ship.famNum)
            {
                case 16:
                    return TroopName(ship.unitNum);
                case 20:
                    return CapShipName(ship.unitNum);
                case 28:
                    return FighterName(ship.unitNum);
                case 60:
                    return SpecOpsName(ship.unitNum);
                default:
                    return "Invalid Family ID for unit";
            }
        }

        private int FighterCount(int index)
        {
            int num = 0;
            CapitalShipCargo cargo1 = new CapitalShipCargo("init");
            CapitalShipCargo cargo2 = CMUNALTB.Cargos[index];
            for (int index1 = 0; index1 != cargo2.Fighters.Length; ++index1)
            {
                if (cargo2.Fighters[index1] > 0)
                {
                    num += cargo2.Fighters[index1];
                }
            }
            return num;
        }

        private int SpecOpsCount(int index)
        {
            int num = 0;
            CapitalShipCargo cargo1 = new CapitalShipCargo("init");
            CapitalShipCargo cargo2 = CMUNALTB.Cargos[index];
            for (int index1 = 0; index1 != cargo2.SpecOps.Length; ++index1)
            {
                if (cargo2.SpecOps[index1] > 0)
                {
                    num += cargo2.SpecOps[index1];
                }
            }
            return num;
        }

        private int TroopCount(int index)
        {
            int num = 0;
            CapitalShipCargo cargo1 = new CapitalShipCargo("init");
            CapitalShipCargo cargo2 = CMUNALTB.Cargos[index];
            for (int index1 = 0; index1 != cargo2.Troops.Length; ++index1)
            {
                if (cargo2.Troops[index1] > 0)
                {
                    num += cargo2.Troops[index1];
                }
            }
            return num;
        }

        private void TroopCargo(int index)
        {
            CapitalShipCargo cargo1 = new CapitalShipCargo("init");
            CapitalShipCargo cargo2 = CMUNALTB.Cargos[index];
            for (int unitNum = 0; unitNum != cargo2.Troops.Length; ++unitNum)
            {
                for (int troop = cargo2.Troops[unitNum]; troop > 0; --troop)
                {
                    troopCargoBox.Items.Add(TroopName(unitNum));
                }
            }
            if (troopCargoBox.Items.Count <= 0)
            {
                return;
            }

            troopCargoBox.SelectedIndex = 0;
        }

        private void FighterCargo(int index)
        {
            CapitalShipCargo cargo1 = new CapitalShipCargo("init");
            CapitalShipCargo cargo2 = CMUNALTB.Cargos[index];
            for (int unitNum = 0; unitNum != cargo2.Fighters.Length; ++unitNum)
            {
                for (int fighter = cargo2.Fighters[unitNum]; fighter > 0; --fighter)
                {
                    FighterCargoBox.Items.Add(FighterName(unitNum));
                }
            }
            if (FighterCargoBox.Items.Count <= 0)
            {
                return;
            }

            FighterCargoBox.SelectedIndex = 0;
        }

        private void SpecOpsCargo(int index)
        {
            CapitalShipCargo cargo1 = new CapitalShipCargo("init");
            CapitalShipCargo cargo2 = CMUNALTB.Cargos[index];
            for (int unitNum = 0; unitNum != cargo2.SpecOps.Length; ++unitNum)
            {
                for (int specOp = cargo2.SpecOps[unitNum]; specOp > 0; --specOp)
                {
                    specOpsCargoBox.Items.Add(SpecOpsName(unitNum));
                }
            }
            if (specOpsCargoBox.Items.Count <= 0)
            {
                return;
            }

            specOpsCargoBox.SelectedIndex = 0;
        }

        private void DisplayShipData()
        {
            shipListView.Items.Clear();
            for (int index = 0; index != CMUNALTB.Ships.Count; ++index)
            {
                Ship ship = CMUNALTB.Ships[index];
                shipListView.Items.Add(new ListViewItem(new string[6]
                {
          ship.recNum.ToString(),
          ship.percChance.ToString(),
          unitName(index),
          TroopCount(index).ToString(),
          FighterCount(index).ToString(),
          SpecOpsCount(index).ToString()
                }));
            }
        }

        private void AddInitControl(bool state)
        {
            recTypeBox.Enabled = false;
            unitPercNum.Enabled = state;
            addTroopBox.Enabled = state;
            addFighterBox.Enabled = state;
            addSpecOpsBox.Enabled = state;
        }

        private void ShipCargoInitControl(bool state)
        {
            addTroopButton.Enabled = state;
            addFighterButton.Enabled = state;
            addSpecOpsButton.Enabled = state;
            troopCargoBox.Enabled = state;
            FighterCargoBox.Enabled = state;
            specOpsCargoBox.Enabled = state;
            delTroopButton.Enabled = state;
            delFighterButton.Enabled = state;
            delSpecOpsButton.Enabled = state;
        }

        private void ShipCargoLabels(bool state)
        {
            maxCargoBox.Enabled = state;
            maxTroopLabel.Enabled = state;
            MaxFighterLabel.Enabled = state;
            shipCargoBox.Enabled = state;
            shipTroopLabel.Enabled = state;
            shipFighterLabel.Enabled = state;
            shipSpecOpsLabel.Enabled = state;
        }

        private void LoadControls(int index)
        {
            Ship ship = CMUNALTB.Ships[index];
            if (ship.famNum == 20)
            {
                addTroopBox.SelectedItem = "";
                addFighterBox.SelectedItem = "";
                addSpecOpsBox.SelectedItem = "";
                ShipCargoLabels(true);
                recTypeBox.SelectedIndex = recTypeBox.FindString(CapShipName(ship.unitNum));
                maxTroopCap.Text = MaxTroopCap(ship.unitNum).ToString();
                maxFighterCap.Text = MaxFighterCap(ship.unitNum).ToString();
                shipTroopLoad.Text = TroopCount(index).ToString();
                shipFighterLoad.Text = FighterCount(index).ToString();
                shipSpecOpsLoad.Text = SpecOpsCount(index).ToString();
                FighterCargoBox.Items.Clear();
                FighterCargo(index);
                if (MaxFighterCap(ship.unitNum) > FighterCount(index))
                {
                    addFighterButton.Enabled = true;
                    addFighterBox.Enabled = true;
                }
                else
                {
                    addFighterButton.Enabled = false;
                    addFighterBox.Enabled = false;
                }
                if (MaxFighterCap(ship.unitNum) > Convert.ToInt32(shipFighterLoad.Text))
                {
                    addFighterBox.SelectedIndex = 0;
                }

                if (FighterCount(index) > 0)
                {
                    delFighterButton.Enabled = true;
                }
                else
                {
                    delFighterButton.Enabled = false;
                }

                if (MaxFighterCap(ship.unitNum) > 0)
                {
                    FighterCargoBox.Enabled = true;
                }
                else
                {
                    FighterCargoBox.Enabled = false;
                }

                troopCargoBox.Items.Clear();
                TroopCargo(index);
                if (MaxTroopCap(ship.unitNum) > TroopCount(index))
                {
                    addTroopButton.Enabled = true;
                    addTroopBox.Enabled = true;
                }
                else
                {
                    addTroopBox.Enabled = false;
                    addTroopButton.Enabled = false;
                }
                if (MaxTroopCap(ship.unitNum) > Convert.ToInt32(shipTroopLoad.Text))
                {
                    addTroopBox.SelectedIndex = 0;
                }

                if (TroopCount(index) > 0)
                {
                    delTroopButton.Enabled = true;
                }
                else
                {
                    delTroopButton.Enabled = false;
                }

                if (MaxTroopCap(ship.unitNum) > 0)
                {
                    troopCargoBox.Enabled = true;
                }
                else
                {
                    troopCargoBox.Enabled = false;
                }

                specOpsCargoBox.Items.Clear();
                SpecOpsCargo(index);
                addSpecOpsBox.Enabled = true;
                addSpecOpsButton.Enabled = true;
                addSpecOpsBox.SelectedIndex = 0;
                if (SpecOpsCount(index) > 0)
                {
                    delSpecOpsButton.Enabled = true;
                    specOpsCargoBox.Enabled = true;
                }
                else
                {
                    delSpecOpsButton.Enabled = false;
                    specOpsCargoBox.Enabled = false;
                }
            }
            else
            {
                ShipCargoLabels(false);
                ShipCargoInitControl(false);
                maxTroopCap.Text = "";
                maxFighterCap.Text = "";
                shipTroopLoad.Text = "";
                shipFighterLoad.Text = "";
                shipSpecOpsLoad.Text = "";
                recTypeBox.SelectedIndex = recTypeBox.FindString("Planetary System");
                FighterCargoBox.Items.Clear();
                troopCargoBox.Items.Clear();
                specOpsCargoBox.Items.Clear();
                switch (ship.famNum)
                {
                    case 16:
                        addTroopBox.Enabled = true;
                        addFighterBox.Enabled = false;
                        addSpecOpsBox.Enabled = false;
                        addTroopBox.SelectedItem = TroopName(ship.unitNum);
                        addFighterBox.SelectedItem = "";
                        addSpecOpsBox.SelectedItem = "";
                        break;
                    case 28:
                        addTroopBox.Enabled = false;
                        addFighterBox.Enabled = true;
                        addSpecOpsBox.Enabled = false;
                        addTroopBox.SelectedItem = "";
                        addFighterBox.SelectedItem = FighterName(ship.unitNum);
                        addSpecOpsBox.SelectedItem = "";
                        break;
                    case 60:
                        addTroopBox.Enabled = false;
                        addFighterBox.Enabled = false;
                        addSpecOpsBox.Enabled = true;
                        addTroopBox.SelectedItem = "";
                        addFighterBox.SelectedItem = "";
                        addSpecOpsBox.SelectedItem = SpecOpsName(ship.unitNum);
                        break;
                }
            }
            unitPercNum.Value = ship.percChance;
        }

        private int MaxTroopCap(int shipNum)
        {
            for (int index = 0; index != CAPSHPSD2.CapShip.Length; ++index)
            {
                if (shipNum == CAPSHPSD2.CapShip[index].number)
                {
                    return (int)CAPSHPSD2.CapShip[index].troops;
                }
            }
            return 0;
        }

        private int MaxFighterCap(int shipNum)
        {
            for (int index = 0; index != CAPSHPSD2.CapShip.Length; ++index)
            {
                if (shipNum == CAPSHPSD2.CapShip[index].number)
                {
                    return (int)CAPSHPSD2.CapShip[index].fighterSquad;
                }
            }
            return 0;
        }

        private void Form_CMUNALTB_Load(object sender, EventArgs e)
        {
            LoadRebShips();
            LoadRebTroops();
            LoadRebFighters();
            LoadRebSpecOps();
            DisplayShipData();
            AddInitControl(true);
            ShipCargoInitControl(false);
            shipListView.Items[0].Selected = true;
            shipListView.EnsureVisible(shipListView.SelectedItems[0].Index);
        }

        private void shipListView_selectChanged()
        {
            LoadControls(currIndex);
            updateButton.Enabled = true;
            delButton.Enabled = true;
            unitPercNum.Enabled = true;
        }

        private void shipListView_ItemSelectionChanged(
          object sender,
          ListViewItemSelectionChangedEventArgs e)
        {
            currIndex = e.ItemIndex;
            shipListView_selectChanged();
        }

        private void DeleteTroop()
        {
            Ship ship = CMUNALTB.Ships[currIndex];
            int selectedIndex = troopCargoBox.SelectedIndex;
            troopCargoBox.Items.RemoveAt(selectedIndex);
            if (troopCargoBox.Items.Count > selectedIndex)
            {
                troopCargoBox.SelectedIndex = selectedIndex;
            }
            else
            {
                delTroopButton.Enabled = false;
            }

            shipTroopLoad.Text = (Convert.ToInt32(shipTroopLoad.Text) - 1).ToString();
            if (MaxTroopCap(ship.unitNum) > Convert.ToInt32(shipTroopLoad.Text))
            {
                addTroopButton.Enabled = true;
                addTroopBox.Enabled = true;
                addTroopBox.SelectedIndex = 0;
            }
            else
            {
                addTroopButton.Enabled = false;
                addTroopBox.Enabled = false;
            }
        }

        private void DeleteFighter()
        {
            Ship ship = CMUNALTB.Ships[currIndex];
            int selectedIndex = FighterCargoBox.SelectedIndex;
            FighterCargoBox.Items.RemoveAt(selectedIndex);
            if (FighterCargoBox.Items.Count > selectedIndex)
            {
                FighterCargoBox.SelectedIndex = selectedIndex;
            }
            else
            {
                delFighterButton.Enabled = false;
            }

            shipFighterLoad.Text = (Convert.ToInt32(shipFighterLoad.Text) - 1).ToString();
            if (MaxFighterCap(ship.unitNum) > Convert.ToInt32(shipFighterLoad.Text))
            {
                addFighterButton.Enabled = true;
                addFighterBox.Enabled = true;
                addFighterBox.SelectedIndex = 0;
            }
            else
            {
                addFighterButton.Enabled = false;
                addFighterBox.Enabled = false;
            }
        }

        private void DeleteSpecOps()
        {
            int selectedIndex = specOpsCargoBox.SelectedIndex;
            specOpsCargoBox.Items.RemoveAt(selectedIndex);
            if (specOpsCargoBox.Items.Count > selectedIndex)
            {
                specOpsCargoBox.SelectedIndex = selectedIndex;
            }
            else
            {
                delSpecOpsButton.Enabled = false;
            }

            shipSpecOpsLoad.Text = (Convert.ToInt32(shipSpecOpsLoad.Text) - 1).ToString();
        }

        private void AddTroop()
        {
            Ship ship = CMUNALTB.Ships[currIndex];
            if (MaxTroopCap(ship.unitNum) > Convert.ToInt32(shipTroopLoad.Text))
            {
                troopCargoBox.Items.Add(addTroopBox.SelectedItem);
                troopCargoBox.SelectedIndex = 0;
                shipTroopLoad.Text = (Convert.ToInt32(shipTroopLoad.Text) + 1).ToString();
                if (MaxTroopCap(ship.unitNum) == Convert.ToInt32(shipTroopLoad.Text))
                {
                    addTroopButton.Enabled = false;
                }
                else if (Convert.ToInt32(shipTroopLoad.Text) == 0)
                {
                    delTroopButton.Enabled = false;
                }
                else
                {
                    delTroopButton.Enabled = true;
                }
            }
            else
            {
                addTroopButton.Enabled = false;
                addTroopBox.Enabled = false;
            }
        }

        private void AddFighter()
        {
            Ship ship = CMUNALTB.Ships[currIndex];
            CapitalShipCargo cargo = new CapitalShipCargo("init");
            if (MaxFighterCap(ship.unitNum) > Convert.ToInt32(shipFighterLoad.Text))
            {
                FighterCargoBox.Items.Add(addFighterBox.SelectedItem);
                FighterCargoBox.SelectedIndex = 0;
                shipFighterLoad.Text = (Convert.ToInt32(shipFighterLoad.Text) + 1).ToString();
                if (MaxFighterCap(ship.unitNum) == Convert.ToInt32(shipFighterLoad.Text))
                {
                    addFighterButton.Enabled = false;
                }
                else if (Convert.ToInt32(shipFighterLoad.Text) == 0)
                {
                    delFighterButton.Enabled = false;
                }
                else
                {
                    delFighterButton.Enabled = true;
                }
            }
            else
            {
                addFighterButton.Enabled = false;
                addFighterBox.Enabled = false;
            }
        }

        private void AddSpecOps()
        {
            specOpsCargoBox.Items.Add(addSpecOpsBox.SelectedItem);
            specOpsCargoBox.SelectedIndex = 0;
            specOpsCargoBox.Enabled = true;
            shipSpecOpsLoad.Text = (Convert.ToInt32(shipSpecOpsLoad.Text) + 1).ToString();
            if (Convert.ToInt32(shipSpecOpsLoad.Text) == 0)
            {
                delSpecOpsButton.Enabled = false;
            }
            else
            {
                delSpecOpsButton.Enabled = true;
            }
        }

        private void UpdateCargo()
        {
            CapitalShipCargo cargo = new CapitalShipCargo("init");
            while (troopCargoBox.Items.Count > 0)
            {
                string unitName = (string)troopCargoBox.Items[0];
                cargo.Troops[TroopNum(unitName)] = cargo.Troops[TroopNum(unitName)] + 1;
                troopCargoBox.Items.RemoveAt(0);
            }
            while (FighterCargoBox.Items.Count > 0)
            {
                string unitName = (string)FighterCargoBox.Items[0];
                cargo.Fighters[FighterNum(unitName)] = cargo.Fighters[FighterNum(unitName)] + 1;
                FighterCargoBox.Items.RemoveAt(0);
            }
            while (specOpsCargoBox.Items.Count > 0)
            {
                string unitName = (string)specOpsCargoBox.Items[0];
                cargo.SpecOps[SpecOpsNum(unitName)] = cargo.SpecOps[SpecOpsNum(unitName)] + 1;
                specOpsCargoBox.Items.RemoveAt(0);
            }
            CMUNALTB.Cargos.Insert(currIndex, cargo);
            CMUNALTB.Cargos.RemoveAt(currIndex + 1);
        }

        private void UpdateUnit()
        {
            if (shipListView.Items.Count <= 0)
            {
                return;
            }

            Ship ship = CMUNALTB.Ships[currIndex];
            string capShipName = (string)recTypeBox.Items[recTypeBox.SelectedIndex];
            if (ship.famNum == 20)
            {
                ship.unitNum = (ushort)CapShipNum(capShipName);
                ship.percChance = (ushort)unitPercNum.Value;
                UpdateCargo();
            }
            else
            {
                ship.percChance = (ushort)unitPercNum.Value;
                switch (ship.famNum)
                {
                    case 16:
                        ship.famNum = 16;
                        ship.unitNum = (ushort)TroopNum((string)addTroopBox.SelectedItem);
                        break;
                    case 28:
                        ship.famNum = 28;
                        ship.unitNum = (ushort)FighterNum((string)addFighterBox.SelectedItem);
                        break;
                    case 60:
                        ship.famNum = 60;
                        ship.unitNum = (ushort)SpecOpsNum((string)addSpecOpsBox.SelectedItem);
                        break;
                }
            }
            CMUNALTB.Ships.Insert(currIndex, ship);
            CMUNALTB.Ships.RemoveAt(currIndex + 1);
            DisplayShipData();
            shipListView.Focus();
            shipListView.Items[currIndex].Selected = true;
            shipListView.EnsureVisible(shipListView.SelectedItems[0].Index);
            newButton.Enabled = true;
        }

        private void delTroopButton_Click(object sender, EventArgs e)
        {
            DeleteTroop();
        }

        private void addTroopButton_Click(object sender, EventArgs e)
        {
            AddTroop();
        }

        private void delFighterButton_Click(object sender, EventArgs e)
        {
            DeleteFighter();
        }

        private void addFighterButton_Click(object sender, EventArgs e)
        {
            AddFighter();
        }

        private void addSpecOpsButton_Click(object sender, EventArgs e)
        {
            AddSpecOps();
        }

        private void delSpecOpsButton_Click(object sender, EventArgs e)
        {
            DeleteSpecOps();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateUnit();
        }

        private void shipListView_Leave(object sender, EventArgs e)
        {
            dupbutton.Enabled = false;
            delButton.Enabled = false;
        }

        private void shipListView_Enter(object sender, EventArgs e)
        {
            dupbutton.Enabled = true;
            delButton.Enabled = true;
        }

        private void recTypeBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        public static string ShipSelected
        {
            get => shipSelected;
            set => shipSelected = value;
        }

        public static int UnitType
        {
            get => unitType;
            set => unitType = value;
        }

        private void addShip()
        {
            Form form = new ShipSelectForm();
            form.Parent = form.ParentForm;
            form.Text = "Starting Unit Selection";
            int num = (int)form.ShowDialog();
            Ship ship;
            if (currIndex <= 0)
            {
                currIndex = 0;
            }
            else
            {
                ship = CMUNALTB.Ships[currIndex];
            }

            CapitalShipCargo cargo = new CapitalShipCargo("init");
            switch (shipSelected)
            {
                case "Planetary System":
                    ship.famNum = (byte)unitType;
                    ship.recNum = (ushort)(CMUNALTB.Ships.Count + 1);
                    ship.percChance = 0U;
                    ship.recType = 1U;
                    ship.unitNum = 1;
                    ship.unknown1 = 1U;
                    ship.unknown2 = 1U;
                    ship.unknown3 = 1U;
                    ship.unknown4 = 1U;
                    ship.unknown5 = 1U;
                    ship.unknown6 = 0;
                    CMUNALTB.Ships.Add(ship);
                    CMUNALTB.Cargos.Add(cargo);
                    currIndex = CMUNALTB.Ships.Count - 1;
                    DisplayShipData();
                    shipListView.Focus();
                    shipListView.Items[CMUNALTB.Ships.Count - 1].Selected = true;
                    shipListView.EnsureVisible(shipListView.SelectedItems[0].Index);
                    delButton.Enabled = true;
                    dupbutton.Enabled = true;
                    break;
                case "":
                    break;
                default:
                    if (CapShipNum(CMUNAllianceTablesForm.shipSelected) == 0)
                    {
                        break;
                    }

                    ship.famNum = 20;
                    ship.recNum = (ushort)(CMUNALTB.Ships.Count + 1);
                    ship.percChance = 0U;
                    ship.recType = 1U;
                    ship.unitNum = (ushort)CapShipNum(CMUNAllianceTablesForm.shipSelected);
                    ship.unknown1 = 1U;
                    ship.unknown2 = 1U;
                    ship.unknown3 = 1U;
                    ship.unknown4 = 1U;
                    ship.unknown5 = 1U;
                    ship.unknown6 = 0;
                    CMUNALTB.Ships.Add(ship);
                    CMUNALTB.Cargos.Add(cargo);
                    currIndex = CMUNALTB.Ships.Count - 1;
                    DisplayShipData();
                    shipListView.Focus();
                    shipListView.Items[CMUNALTB.Ships.Count - 1].Selected = true;
                    shipListView.EnsureVisible(shipListView.SelectedItems[0].Index);
                    delButton.Enabled = true;
                    dupbutton.Enabled = true;
                    break;
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            addShip();
        }

        private void DelShip()
        {
            if (currIndex < 0)
            {
                currIndex = 0;
            }

            CMUNALTB.Ships.RemoveAt(currIndex);
            CMUNALTB.Cargos.RemoveAt(currIndex);
            DisplayShipData();
            shipListView.Focus();
            if (CMUNALTB.Ships.Count >= 1)
            {
                if (currIndex >= shipListView.Items.Count)
                {
                    currIndex = shipListView.Items.Count - 1;
                }

                shipListView.Items[currIndex].Selected = true;
                shipListView.EnsureVisible(shipListView.SelectedItems[0].Index);
            }
            if (CMUNALTB.Ships.Count >= 1)
            {
                return;
            }

            delButton.Enabled = false;
            dupbutton.Enabled = false;
            ShipCargoInitControl(false);
            AddInitControl(false);
            updateButton.Enabled = false;
            recTypeBox.SelectedIndex = recTypeBox.Items.IndexOf("");
            addTroopBox.SelectedIndex = addTroopBox.Items.IndexOf("");
            addFighterBox.SelectedIndex = addFighterBox.Items.IndexOf("");
            addSpecOpsBox.SelectedIndex = addSpecOpsBox.Items.IndexOf("");
            troopCargoBox.SelectedIndex = troopCargoBox.Items.IndexOf("");
            FighterCargoBox.SelectedIndex = FighterCargoBox.Items.IndexOf("");
            specOpsCargoBox.SelectedIndex = specOpsCargoBox.Items.IndexOf("");
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            DelShip();
        }

        private void DupShip()
        {
            Ship ship = CMUNALTB.Ships[currIndex];
            CapitalShipCargo cargo1 = new CapitalShipCargo("init");
            CapitalShipCargo cargo2 = CMUNALTB.Cargos[currIndex];
            ship.recNum = (ushort)(CMUNALTB.Ships.Count + 1);
            CMUNALTB.Ships.Add(ship);
            CMUNALTB.Cargos.Add(cargo2);
            currIndex = CMUNALTB.Ships.Count + 1;
            DisplayShipData();
            shipListView.Focus();
            shipListView.Items[CMUNALTB.Ships.Count - 1].Selected = true;
            shipListView.EnsureVisible(shipListView.SelectedItems[0].Index);
        }

        private void dupbutton_Click(object sender, EventArgs e)
        {
            DupShip();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            CMUNALTB.SaveTableData(CMUNALTB.GetTablePath());
            Close();
        }
    }
}
