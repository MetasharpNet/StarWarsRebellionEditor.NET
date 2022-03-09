namespace SwRebellionEditor
{
    public class CMUNALTB
    {
        private BinaryReader _binaryReader;
        private static string _fileName = "CMUNALTB.DAT";
        private static bool _unsavedTableData = false;
        private static OpenFileDialog _openFileDialog;
        private static string _tableFullPathname;
        private static bool _lockChange;
        public static int numUnits = 0;
        private static uint headerUnknown1;
        private static uint headerUnknown2;
        private static uint headerUnknown3;
        private static byte headerChar1;
        private static byte headerChar2;
        private static byte headerChar3;
        private static byte headerChar4;
        private static byte headerChar5;
        private static byte headerChar6;
        private static byte headerChar7;
        private static byte headerChar8;
        private static byte headerChar9;
        private static byte headerChar10;
        private static byte headerChar11;
        private static byte headerChar12;
        private static byte headerChar13;
        private static byte headerChar14;
        private static byte headerChar15;
        private static byte headerChar16;
        private static byte headerChar17;
        private static byte headerChar18;
        private static byte headerChar19;
        private static byte headerChar20;
        private int[] Troops;
        private int[] SpecOps;
        private int[] Fighters;
        public static Ship[] shipTable;
        public static CapitalShipCargo[] cargoHold;
        public static List<Ship> Ships;
        public static List<CapitalShipCargo> Cargos;

        public CMUNALTB()
        {
            if (SetInitialFileName() == null)
            {
                return;
            }

            _binaryReader = new BinaryReader(File.Open(GetTablePath(), FileMode.Open));
            ClearUnsavedData();
            LoadHeaderData();
            shipTable = new Ship[numUnits];
            cargoHold = new CapitalShipCargo[numUnits];
            for (int index = 0; index != cargoHold.Length; ++index)
            {
                cargoHold[index] = new CapitalShipCargo("init");
            }

            LoadData();
            Ships = new List<Ship>(shipTable);
            Cargos = new List<CapitalShipCargo>(cargoHold);
        }

        public string FileName
        {
            get => _fileName;
            set => _fileName = value;
        }

        public static void SetUnsavedData()
        {
            if (_lockChange)
            {
                return;
            }

            _unsavedTableData = true;
        }

        public static void ClearUnsavedData()
        {
            _unsavedTableData = false;
        }

        public static void LockChange()
        {
            _lockChange = true;
        }

        public static void UnlockChange()
        {
            _lockChange = false;
        }

        public static string GetTablePath()
        {
            return _tableFullPathname;
        }

        public static bool SetTablePath(string tablePath)
        {
            _tableFullPathname = tablePath;
            return true;
        }

        public string TableFullPathname => _tableFullPathname;

        private static string SetInitialFileName()
        {
            if (RegistryKeys.InstalledLocation == null)
            {
                _openFileDialog = new OpenFileDialog();
                if (_openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    throw new Exception("No Data File Specified");
                }

                SetTablePath(_openFileDialog.FileName);
                return GetTablePath();
            }
            SetTablePath(RegistryKeys.InstalledLocation + "\\GData\\" + _fileName);
            return GetTablePath();
        }

        private void LoadHeaderData()
        {
            headerUnknown1 = _binaryReader.ReadUInt32();
            headerUnknown2 = _binaryReader.ReadUInt32();
            numUnits = (int)headerUnknown2;
            headerUnknown3 = _binaryReader.ReadUInt32();
            headerChar1 = _binaryReader.ReadByte();
            headerChar2 = _binaryReader.ReadByte();
            headerChar3 = _binaryReader.ReadByte();
            headerChar4 = _binaryReader.ReadByte();
            headerChar5 = _binaryReader.ReadByte();
            headerChar6 = _binaryReader.ReadByte();
            headerChar7 = _binaryReader.ReadByte();
            headerChar8 = _binaryReader.ReadByte();
            headerChar9 = _binaryReader.ReadByte();
            headerChar10 = _binaryReader.ReadByte();
            headerChar11 = _binaryReader.ReadByte();
            headerChar12 = _binaryReader.ReadByte();
            headerChar13 = _binaryReader.ReadByte();
            headerChar14 = _binaryReader.ReadByte();
            headerChar15 = _binaryReader.ReadByte();
            headerChar16 = _binaryReader.ReadByte();
            headerChar17 = _binaryReader.ReadByte();
            headerChar18 = _binaryReader.ReadByte();
            headerChar19 = _binaryReader.ReadByte();
            headerChar20 = _binaryReader.ReadByte();
        }

        private void LoadCargo(int index)
        {
            ushort index1 = _binaryReader.ReadUInt16();
            int num = _binaryReader.ReadByte();
            switch (_binaryReader.ReadByte())
            {
                case 16:
                    cargoHold[index].Troops[index1] = cargoHold[index].Troops[index1] + 1;
                    break;
                case 28:
                    cargoHold[index].Fighters[index1] = cargoHold[index].Fighters[index1] + 1;
                    break;
                case 60:
                    cargoHold[index].SpecOps[index1] = cargoHold[index].SpecOps[index1] + 1;
                    break;
            }
        }

        private void LoadData()
        {
            for (int index = 0; index != numUnits; ++index)
            {
                shipTable[index].recNum = _binaryReader.ReadUInt32();
                for (shipTable[index].recType = _binaryReader.ReadUInt32(); shipTable[index].recType == 0U; shipTable[index].recType = _binaryReader.ReadUInt32())
                {
                    LoadCargo(index - 1);
                    shipTable[index].recNum = _binaryReader.ReadUInt32();
                }
                shipTable[index].percChance = _binaryReader.ReadUInt32();
                shipTable[index].unknown1 = _binaryReader.ReadUInt32();
                shipTable[index].unknown2 = _binaryReader.ReadUInt32();
                shipTable[index].unknown3 = _binaryReader.ReadUInt32();
                shipTable[index].unknown4 = _binaryReader.ReadUInt32();
                shipTable[index].unknown5 = _binaryReader.ReadUInt32();
                shipTable[index].unitNum = _binaryReader.ReadUInt16();
                shipTable[index].unknown6 = _binaryReader.ReadByte();
                shipTable[index].famNum = _binaryReader.ReadByte();
            }
            _binaryReader.Close();
        }

        private static int TotalCargoUnits(CapitalShipCargo currCargo)
        {
            int num = 0;
            for (int index = 0; index != currCargo.Troops.Length; ++index)
            {
                num += currCargo.Troops[index];
            }

            for (int index = 0; index != currCargo.Fighters.Length; ++index)
            {
                num += currCargo.Fighters[index];
            }

            for (int index = 0; index != currCargo.SpecOps.Length; ++index)
            {
                num += currCargo.SpecOps[index];
            }

            return num;
        }

        public static bool SaveTableData(string saveFileName)
        {
            var binaryWriter = new BinaryWriter(File.Open(saveFileName, FileMode.Create));
            try
            {
                binaryWriter.Write(headerUnknown1);
                binaryWriter.Write((uint)Ships.Count);
                binaryWriter.Write(headerUnknown3);
                binaryWriter.Write(headerChar1);
                binaryWriter.Write(headerChar2);
                binaryWriter.Write(headerChar3);
                binaryWriter.Write(headerChar4);
                binaryWriter.Write(headerChar5);
                binaryWriter.Write(headerChar6);
                binaryWriter.Write(headerChar7);
                binaryWriter.Write(headerChar8);
                binaryWriter.Write(headerChar9);
                binaryWriter.Write(headerChar10);
                binaryWriter.Write(headerChar11);
                binaryWriter.Write(headerChar12);
                binaryWriter.Write(headerChar13);
                binaryWriter.Write(headerChar14);
                binaryWriter.Write(headerChar15);
                binaryWriter.Write(headerChar16);
                binaryWriter.Write(headerChar17);
                binaryWriter.Write(headerChar18);
                binaryWriter.Write(headerChar19);
                binaryWriter.Write(headerChar20);
                for (int index1 = 0; index1 != Ships.Count; ++index1)
                {
                    var ship = Ships[index1];
                    var cargo1 = new CapitalShipCargo("init");
                    var cargo2 = Cargos[index1];
                    binaryWriter.Write(index1 + 1);
                    binaryWriter.Write(ship.recType);
                    binaryWriter.Write(ship.percChance);
                    binaryWriter.Write(ship.unknown1);
                    binaryWriter.Write(ship.unknown2);
                    binaryWriter.Write(TotalCargoUnits(cargo2) + 1);
                    binaryWriter.Write(ship.unknown4);
                    binaryWriter.Write(ship.unknown5);
                    binaryWriter.Write(ship.unitNum);
                    binaryWriter.Write(ship.unknown6);
                    binaryWriter.Write(ship.famNum);
                    for (int index2 = 0; index2 != cargo2.Troops.Length; ++index2)
                    {
                        for (int index3 = 0; index3 != cargo2.Troops[index2]; ++index3)
                        {
                            binaryWriter.Write(1U);
                            binaryWriter.Write(0U);
                            binaryWriter.Write((ushort)index2);
                            binaryWriter.Write((byte)0);
                            binaryWriter.Write((byte)16);
                        }
                    }
                    for (int index4 = 0; index4 != cargo2.Fighters.Length; ++index4)
                    {
                        for (int index5 = 0; index5 != cargo2.Fighters[index4]; ++index5)
                        {
                            binaryWriter.Write(1U);
                            binaryWriter.Write(0U);
                            binaryWriter.Write((ushort)index4);
                            binaryWriter.Write((byte)0);
                            binaryWriter.Write((byte)28);
                        }
                    }
                    for (int index6 = 0; index6 != cargo2.SpecOps.Length; ++index6)
                    {
                        for (int index7 = 0; index7 != cargo2.SpecOps[index6]; ++index7)
                        {
                            binaryWriter.Write(1U);
                            binaryWriter.Write(0U);
                            binaryWriter.Write((ushort)index6);
                            binaryWriter.Write((byte)0);
                            binaryWriter.Write((byte)60);
                        }
                    }
                }
                SYFCCRTB.SetTablePath(saveFileName);
                return true;
            }
            catch (EndOfStreamException)
            {
            }
            finally
            {
                binaryWriter.Close();
            }
            return true;
        }
    }
}
