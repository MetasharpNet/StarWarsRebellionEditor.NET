namespace SwRebellionEditor
{
    // Capital Ship
    public class CAPSHPSD2
    {
        private static bool _lockChange;
        private static OpenFileDialog _openFileDialog;
        private static string _capShipFullPathname;
        private static int _numUnits = 30;

        public static bool unsavedCapShipData;
        public static uint headerUnknown1;
        public static uint headerUnknown2;
        public static uint headerFamlyNum;
        public static uint headerUnknown3;
        public static CapitalShip[] CapShip;

        public CAPSHPSD2()
        {
            ClearUnsavedData();
            CapShip = new CapitalShip[_numUnits];
            LoadCapShipData(SetInitialFileName());
        }

        private static string SetInitialFileName()
        {
            if (RegistryKeys.InstalledLocation == null)
            {
                _openFileDialog = new OpenFileDialog();
                if (_openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    throw new Exception("No CapShip Data File Specified");
                }

                SetCapShipPath(_openFileDialog.FileName);
                return GetCapShipPath();
            }
            SetCapShipPath(RegistryKeys.InstalledLocation + "\\GData\\CAPSHPSD.DAT");
            return GetCapShipPath();
        }

        public static string GetCapShipPath()
        {
            return _capShipFullPathname;
        }

        public static bool SetCapShipPath(string CapShipPath)
        {
            _capShipFullPathname = CapShipPath;
            return true;
        }

        public static bool SaveCapShipData(string saveFileName)
        {
            var binaryWriter = new BinaryWriter(File.Open(saveFileName, FileMode.Create));
            try
            {
                binaryWriter.Write(headerUnknown1);
                binaryWriter.Write(headerUnknown2);
                binaryWriter.Write(headerFamlyNum);
                binaryWriter.Write(headerUnknown3);
                for (int index = 0; index != _numUnits; ++index)
                {
                    binaryWriter.Write(CapShip[index].number);
                    binaryWriter.Write(CapShip[index].unknown1);
                    binaryWriter.Write(CapShip[index].prodFacilityNum);
                    binaryWriter.Write(CapShip[index].unknown2);
                    binaryWriter.Write(CapShip[index].familyNum);
                    binaryWriter.Write(CapShip[index].textstratNum);
                    binaryWriter.Write(CapShip[index].unknown3);
                    binaryWriter.Write(CapShip[index].rebel);
                    binaryWriter.Write(CapShip[index].empire);
                    binaryWriter.Write(CapShip[index].conCost);
                    binaryWriter.Write(CapShip[index].maintCost);
                    binaryWriter.Write(CapShip[index].researchNum);
                    binaryWriter.Write(CapShip[index].researchDiff);
                    binaryWriter.Write(CapShip[index].unknown4);
                    binaryWriter.Write(CapShip[index].detection);
                    binaryWriter.Write(CapShip[index].shield);
                    binaryWriter.Write(CapShip[index].sublight);
                    binaryWriter.Write(CapShip[index].maneuverablity);
                    binaryWriter.Write(CapShip[index].hyperdrive);
                    binaryWriter.Write(CapShip[index].hyperdrive2);
                    binaryWriter.Write(CapShip[index].firePowerArc1);
                    binaryWriter.Write(CapShip[index].firePowerArc2);
                    binaryWriter.Write(CapShip[index].firePowerArc3);
                    binaryWriter.Write(CapShip[index].firePowerArc4);
                    binaryWriter.Write(CapShip[index].firePowerArc5);
                    binaryWriter.Write(CapShip[index].firePowerArc6);
                    binaryWriter.Write(CapShip[index].firePowerArc7);
                    binaryWriter.Write(CapShip[index].firePowerArc8);
                    binaryWriter.Write(CapShip[index].firePowerArc9);
                    binaryWriter.Write(CapShip[index].firePowerArc10);
                    binaryWriter.Write(CapShip[index].firePowerArc11);
                    binaryWriter.Write(CapShip[index].firePowerArc12);
                    binaryWriter.Write(CapShip[index].turboLaserRange);
                    binaryWriter.Write(CapShip[index].ionRange);
                    binaryWriter.Write(CapShip[index].laserRange);
                    binaryWriter.Write(CapShip[index].sumTurboLaserFP);
                    binaryWriter.Write(CapShip[index].sumIonFP);
                    binaryWriter.Write(CapShip[index].sumLaserFP);
                    binaryWriter.Write(CapShip[index].sumFP);
                    binaryWriter.Write(CapShip[index].hull);
                    binaryWriter.Write(CapShip[index].tractorBeamPower);
                    binaryWriter.Write(CapShip[index].tractorBeamRange);
                    binaryWriter.Write(CapShip[index].gravity1);
                    binaryWriter.Write(CapShip[index].gravity2);
                    binaryWriter.Write(CapShip[index].bombardment);
                    binaryWriter.Write(CapShip[index].damageControl);
                    binaryWriter.Write(CapShip[index].weaponRecharge);
                    binaryWriter.Write(CapShip[index].shieldRecharge);
                    binaryWriter.Write(CapShip[index].fighterSquad);
                    binaryWriter.Write(CapShip[index].troops);
                    binaryWriter.Write(CapShip[index].unknown5);
                }
                SetCapShipPath(saveFileName);
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

        public static void OpenNewCapShipFile()
        {
            _openFileDialog = new OpenFileDialog();
            if (_openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            LoadCapShipData(_openFileDialog.FileName);
            SetCapShipPath(_openFileDialog.FileName);
            ClearUnsavedData();
        }

        public static bool LoadCapShipData(string CapShipDataFile)
        {
            if (CapShipDataFile == null)
            {
                return false;
            }

            BinaryReader binaryReader = new BinaryReader(File.Open(CapShipDataFile, FileMode.Open));
            try
            {
                headerUnknown1 = binaryReader.ReadUInt32();
                headerUnknown2 = binaryReader.ReadUInt32();
                headerFamlyNum = binaryReader.ReadUInt32();
                headerUnknown3 = binaryReader.ReadUInt32();
                for (int index = 0; index != _numUnits; ++index)
                {
                    CapShip[index].number = binaryReader.ReadUInt32();
                    CapShip[index].unknown1 = binaryReader.ReadUInt32();
                    CapShip[index].prodFacilityNum = binaryReader.ReadUInt32();
                    CapShip[index].unknown2 = binaryReader.ReadUInt32();
                    CapShip[index].familyNum = binaryReader.ReadUInt32();
                    CapShip[index].textstratNum = binaryReader.ReadUInt16();
                    CapShip[index].unknown3 = binaryReader.ReadUInt16();
                    CapShip[index].rebel = binaryReader.ReadUInt32();
                    CapShip[index].empire = binaryReader.ReadUInt32();
                    CapShip[index].conCost = binaryReader.ReadUInt32();
                    CapShip[index].maintCost = binaryReader.ReadUInt32();
                    CapShip[index].researchNum = binaryReader.ReadUInt32();
                    CapShip[index].researchDiff = binaryReader.ReadUInt32();
                    CapShip[index].unknown4 = binaryReader.ReadUInt32();
                    CapShip[index].detection = binaryReader.ReadUInt32();
                    CapShip[index].shield = binaryReader.ReadUInt32();
                    CapShip[index].sublight = binaryReader.ReadUInt32();
                    CapShip[index].maneuverablity = binaryReader.ReadUInt32();
                    CapShip[index].hyperdrive = binaryReader.ReadUInt32();
                    CapShip[index].hyperdrive2 = binaryReader.ReadUInt32();
                    CapShip[index].firePowerArc1 = binaryReader.ReadUInt32();
                    CapShip[index].firePowerArc2 = binaryReader.ReadUInt32();
                    CapShip[index].firePowerArc3 = binaryReader.ReadUInt32();
                    CapShip[index].firePowerArc4 = binaryReader.ReadUInt32();
                    CapShip[index].firePowerArc5 = binaryReader.ReadUInt32();
                    CapShip[index].firePowerArc6 = binaryReader.ReadUInt32();
                    CapShip[index].firePowerArc7 = binaryReader.ReadUInt32();
                    CapShip[index].firePowerArc8 = binaryReader.ReadUInt32();
                    CapShip[index].firePowerArc9 = binaryReader.ReadUInt32();
                    CapShip[index].firePowerArc10 = binaryReader.ReadUInt32();
                    CapShip[index].firePowerArc11 = binaryReader.ReadUInt32();
                    CapShip[index].firePowerArc12 = binaryReader.ReadUInt32();
                    CapShip[index].turboLaserRange = binaryReader.ReadUInt32();
                    CapShip[index].ionRange = binaryReader.ReadUInt32();
                    CapShip[index].laserRange = binaryReader.ReadUInt32();
                    CapShip[index].sumTurboLaserFP = binaryReader.ReadUInt32();
                    CapShip[index].sumIonFP = binaryReader.ReadUInt32();
                    CapShip[index].sumLaserFP = binaryReader.ReadUInt32();
                    CapShip[index].sumFP = binaryReader.ReadUInt32();
                    CapShip[index].hull = binaryReader.ReadUInt32();
                    CapShip[index].tractorBeamPower = binaryReader.ReadUInt32();
                    CapShip[index].tractorBeamRange = binaryReader.ReadUInt32();
                    CapShip[index].gravity1 = binaryReader.ReadUInt32();
                    CapShip[index].gravity2 = binaryReader.ReadUInt32();
                    CapShip[index].bombardment = binaryReader.ReadUInt32();
                    CapShip[index].damageControl = binaryReader.ReadUInt32();
                    CapShip[index].weaponRecharge = binaryReader.ReadUInt32();
                    CapShip[index].shieldRecharge = binaryReader.ReadUInt32();
                    CapShip[index].fighterSquad = binaryReader.ReadUInt32();
                    CapShip[index].troops = binaryReader.ReadUInt32();
                    CapShip[index].unknown5 = binaryReader.ReadUInt32();
                }
            }
            catch (EndOfStreamException)
            {
            }
            finally
            {
                binaryReader.Close();
            }
            return true;
        }

        public static void SetUnsavedData()
        {
            if (_lockChange)
            {
                return;
            }

            unsavedCapShipData = true;
        }

        public static void ClearUnsavedData()
        {
            unsavedCapShipData = false;
        }

        public static void LockChange()
        {
            _lockChange = true;
        }

        public static void UnlockChange()
        {
            _lockChange = false;
        }
    }
}
