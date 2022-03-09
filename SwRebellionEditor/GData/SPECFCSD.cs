namespace SwRebellionEditor
{
    // SpecOp
    public class SPECFCSD
    {
        private static OpenFileDialog openFileDialog;
        private static string SpecOpFullPathname;
        public static int numUnits = 9;
        public static bool unsavedSpecOpData;
        private static bool lockChange;
        public static uint headerUnknown1;
        public static uint headerUnknown2;
        public static uint headerFamlyNum;
        public static uint headerUnknown3;
        public static SpecialForce[] SpecOp;

        public SPECFCSD()
        {
            ClearUnsavedData();
            SpecOp = new SpecialForce[numUnits];
            LoadSpecOpData(setInitialFileName());
        }

        private static string setInitialFileName()
        {
            if (RegistryKeys.InstalledLocation == null)
            {
                openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    throw new Exception("No SpecOp Data File Specified");
                }

                SetSpecOpPath(openFileDialog.FileName);
                return GetSpecOpPath();
            }
            SetSpecOpPath(RegistryKeys.InstalledLocation + "\\GData\\SPECFCSD.DAT");
            return GetSpecOpPath();
        }

        public static string GetSpecOpPath()
        {
            return SpecOpFullPathname;
        }

        public static bool SetSpecOpPath(string SpecOpPath)
        {
            SpecOpFullPathname = SpecOpPath;
            return true;
        }

        public static bool SaveSpecOpData(string saveFileName)
        {
            var binaryWriter = new BinaryWriter(File.Open(saveFileName, FileMode.Create));
            try
            {
                binaryWriter.Write(headerUnknown1);
                binaryWriter.Write(headerUnknown2);
                binaryWriter.Write(headerFamlyNum);
                binaryWriter.Write(headerUnknown3);
                for (int index = 0; index != numUnits; ++index)
                {
                    binaryWriter.Write(SpecOp[index].number);
                    binaryWriter.Write(SpecOp[index].unknown1);
                    binaryWriter.Write(SpecOp[index].prodFacilityNum);
                    binaryWriter.Write(SpecOp[index].unknown2);
                    binaryWriter.Write(SpecOp[index].familyNum);
                    binaryWriter.Write(SpecOp[index].textstratNum);
                    binaryWriter.Write(SpecOp[index].unknown3);
                    binaryWriter.Write(SpecOp[index].rebel);
                    binaryWriter.Write(SpecOp[index].empire);
                    binaryWriter.Write(SpecOp[index].conCost);
                    binaryWriter.Write(SpecOp[index].maintCost);
                    binaryWriter.Write(SpecOp[index].researchNum);
                    binaryWriter.Write(SpecOp[index].researchDiff);
                    binaryWriter.Write(SpecOp[index].diplomacyBase);
                    binaryWriter.Write(SpecOp[index].diplomacyVar);
                    binaryWriter.Write(SpecOp[index].espionageBase);
                    binaryWriter.Write(SpecOp[index].espionageVar);
                    binaryWriter.Write(SpecOp[index].shipResBase);
                    binaryWriter.Write(SpecOp[index].shipResVar);
                    binaryWriter.Write(SpecOp[index].troopResBase);
                    binaryWriter.Write(SpecOp[index].troopResVar);
                    binaryWriter.Write(SpecOp[index].facilityResBase);
                    binaryWriter.Write(SpecOp[index].facilityResVar);
                    binaryWriter.Write(SpecOp[index].combatBase);
                    binaryWriter.Write(SpecOp[index].combatVar);
                    binaryWriter.Write(SpecOp[index].leadershipBase);
                    binaryWriter.Write(SpecOp[index].leadershipVar);
                    binaryWriter.Write(SpecOp[index].loyaltyBase);
                    binaryWriter.Write(SpecOp[index].loyaltyVar);
                    binaryWriter.Write(SpecOp[index].missionType);
                }
                SetSpecOpPath(saveFileName);
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

        public static void OpenNewSpecOpFile()
        {
            openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            LoadSpecOpData(openFileDialog.FileName);
            SetSpecOpPath(openFileDialog.FileName);
            ClearUnsavedData();
        }

        public static bool LoadSpecOpData(string SpecOpDataFile)
        {
            if (SpecOpDataFile == null)
            {
                return false;
            }

            var binaryReader = new BinaryReader(File.Open(SpecOpDataFile, FileMode.Open));
            try
            {
                headerUnknown1 = binaryReader.ReadUInt32();
                headerUnknown2 = binaryReader.ReadUInt32();
                headerFamlyNum = binaryReader.ReadUInt32();
                headerUnknown3 = binaryReader.ReadUInt32();
                for (int index = 0; index != numUnits; ++index)
                {
                    SpecOp[index].number = binaryReader.ReadUInt32();
                    SpecOp[index].unknown1 = binaryReader.ReadUInt32();
                    SpecOp[index].prodFacilityNum = binaryReader.ReadUInt32();
                    SpecOp[index].unknown2 = binaryReader.ReadUInt32();
                    SpecOp[index].familyNum = binaryReader.ReadUInt32();
                    SpecOp[index].textstratNum = binaryReader.ReadUInt16();
                    SpecOp[index].unknown3 = binaryReader.ReadUInt16();
                    SpecOp[index].rebel = binaryReader.ReadUInt32();
                    SpecOp[index].empire = binaryReader.ReadUInt32();
                    SpecOp[index].conCost = binaryReader.ReadUInt32();
                    SpecOp[index].maintCost = binaryReader.ReadUInt32();
                    SpecOp[index].researchNum = binaryReader.ReadUInt32();
                    SpecOp[index].researchDiff = binaryReader.ReadUInt32();
                    SpecOp[index].diplomacyBase = binaryReader.ReadUInt32();
                    SpecOp[index].diplomacyVar = binaryReader.ReadUInt32();
                    SpecOp[index].espionageBase = binaryReader.ReadUInt32();
                    SpecOp[index].espionageVar = binaryReader.ReadUInt32();
                    SpecOp[index].shipResBase = binaryReader.ReadUInt32();
                    SpecOp[index].shipResVar = binaryReader.ReadUInt32();
                    SpecOp[index].troopResBase = binaryReader.ReadUInt32();
                    SpecOp[index].troopResVar = binaryReader.ReadUInt32();
                    SpecOp[index].facilityResBase = binaryReader.ReadUInt32();
                    SpecOp[index].facilityResVar = binaryReader.ReadUInt32();
                    SpecOp[index].combatBase = binaryReader.ReadUInt32();
                    SpecOp[index].combatVar = binaryReader.ReadUInt32();
                    SpecOp[index].leadershipBase = binaryReader.ReadUInt32();
                    SpecOp[index].leadershipVar = binaryReader.ReadUInt32();
                    SpecOp[index].loyaltyBase = binaryReader.ReadUInt32();
                    SpecOp[index].loyaltyVar = binaryReader.ReadUInt32();
                    SpecOp[index].missionType = binaryReader.ReadUInt32();
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
            if (lockChange)
            {
                return;
            }

            unsavedSpecOpData = true;
        }

        public static void ClearUnsavedData()
        {
            unsavedSpecOpData = false;
        }

        public static void LockChange()
        {
            lockChange = true;
        }

        public static void UnlockChange()
        {
            lockChange = false;
        }
    }
}
