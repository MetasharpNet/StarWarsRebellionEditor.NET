namespace SwRebellionEditor
{
    public class MNCHARSD
    {
        private static OpenFileDialog openFileDialog;
        private static string MinCharFullPathname;
        public static int numUnits = 54;
        public static bool unsavedMinCharData;
        private static bool lockChange;
        public static uint headerUnknown1;
        public static uint headerUnknown2;
        public static uint headerFamlyNum;
        public static uint headerUnknown3;
        public static Character[] MinChar;

        public MNCHARSD()
        {
            ClearUnsavedData();
            MinChar = new Character[numUnits];
            LoadMinCharData(SetInitialFileName());
        }

        private static string SetInitialFileName()
        {
            if (RegistryKeys.InstalledLocation == null)
            {
                openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    throw new Exception("No MinChar Data File Specified");
                }

                SetMinCharPath(openFileDialog.FileName);
                return GetMinCharPath();
            }
            SetMinCharPath(RegistryKeys.InstalledLocation + "\\GData\\MNCHARSD.DAT");
            return GetMinCharPath();
        }
        
        public static string GetMinCharPath()
        {
            return MinCharFullPathname;
        }

        public static bool SetMinCharPath(string MinCharPath)
        {
            MinCharFullPathname = MinCharPath;
            return true;
        }

        public static bool SaveMinCharData(string saveFileName)
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
                    binaryWriter.Write(MinChar[index].number);
                    binaryWriter.Write(MinChar[index].unknown1);
                    binaryWriter.Write(MinChar[index].prodFacilityNum);
                    binaryWriter.Write(MinChar[index].unknown2);
                    binaryWriter.Write(MinChar[index].familyNum);
                    binaryWriter.Write(MinChar[index].textstratNum);
                    binaryWriter.Write(MinChar[index].unknown3);
                    binaryWriter.Write(MinChar[index].rebel);
                    binaryWriter.Write(MinChar[index].empire);
                    binaryWriter.Write(MinChar[index].conCost);
                    binaryWriter.Write(MinChar[index].maintCost);
                    binaryWriter.Write(MinChar[index].researchNum);
                    binaryWriter.Write(MinChar[index].researchDiff);
                    binaryWriter.Write(MinChar[index].diplomacyBase);
                    binaryWriter.Write(MinChar[index].diplomacyVar);
                    binaryWriter.Write(MinChar[index].espionageBase);
                    binaryWriter.Write(MinChar[index].espionageVar);
                    binaryWriter.Write(MinChar[index].shipResBase);
                    binaryWriter.Write(MinChar[index].shipResVar);
                    binaryWriter.Write(MinChar[index].troopResBase);
                    binaryWriter.Write(MinChar[index].troopResVar);
                    binaryWriter.Write(MinChar[index].facilityResBase);
                    binaryWriter.Write(MinChar[index].facilityResVar);
                    binaryWriter.Write(MinChar[index].combatBase);
                    binaryWriter.Write(MinChar[index].combatVar);
                    binaryWriter.Write(MinChar[index].leadershipBase);
                    binaryWriter.Write(MinChar[index].leadershipVar);
                    binaryWriter.Write(MinChar[index].loyaltyBase);
                    binaryWriter.Write(MinChar[index].loyaltyVar);
                    binaryWriter.Write(MinChar[index].jediProbability);
                    binaryWriter.Write(MinChar[index].knownJediFlag);
                    binaryWriter.Write(MinChar[index].jediLevelBase);
                    binaryWriter.Write(MinChar[index].jediLevelVar);
                    binaryWriter.Write(MinChar[index].admiralFlag);
                    binaryWriter.Write(MinChar[index].commanderFlag);
                    binaryWriter.Write(MinChar[index].generalFlag);
                    binaryWriter.Write(MinChar[index].betrayFlag);
                    binaryWriter.Write(MinChar[index].jediTrainFlag);
                }
                SetMinCharPath(saveFileName);
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

        public static void OpenNewMinCharFile()
        {
            openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            LoadMinCharData(openFileDialog.FileName);
            SetMinCharPath(openFileDialog.FileName);
            ClearUnsavedData();
        }

        public static bool LoadMinCharData(string MinCharDataFile)
        {
            if (MinCharDataFile == null)
            {
                return false;
            }

            BinaryReader binaryReader = new BinaryReader(File.Open(MinCharDataFile, FileMode.Open));
            try
            {
                headerUnknown1 = binaryReader.ReadUInt32();
                headerUnknown2 = binaryReader.ReadUInt32();
                headerFamlyNum = binaryReader.ReadUInt32();
                headerUnknown3 = binaryReader.ReadUInt32();
                for (int index = 0; index != numUnits; ++index)
                {
                    MinChar[index].number = binaryReader.ReadUInt32();
                    MinChar[index].unknown1 = binaryReader.ReadUInt32();
                    MinChar[index].prodFacilityNum = binaryReader.ReadUInt32();
                    MinChar[index].unknown2 = binaryReader.ReadUInt32();
                    MinChar[index].familyNum = binaryReader.ReadUInt32();
                    MinChar[index].textstratNum = binaryReader.ReadUInt16();
                    MinChar[index].unknown3 = binaryReader.ReadUInt16();
                    MinChar[index].rebel = binaryReader.ReadUInt32();
                    MinChar[index].empire = binaryReader.ReadUInt32();
                    MinChar[index].conCost = binaryReader.ReadUInt32();
                    MinChar[index].maintCost = binaryReader.ReadUInt32();
                    MinChar[index].researchNum = binaryReader.ReadUInt32();
                    MinChar[index].researchDiff = binaryReader.ReadUInt32();
                    MinChar[index].diplomacyBase = binaryReader.ReadUInt32();
                    MinChar[index].diplomacyVar = binaryReader.ReadUInt32();
                    MinChar[index].espionageBase = binaryReader.ReadUInt32();
                    MinChar[index].espionageVar = binaryReader.ReadUInt32();
                    MinChar[index].shipResBase = binaryReader.ReadUInt32();
                    MinChar[index].shipResVar = binaryReader.ReadUInt32();
                    MinChar[index].troopResBase = binaryReader.ReadUInt32();
                    MinChar[index].troopResVar = binaryReader.ReadUInt32();
                    MinChar[index].facilityResBase = binaryReader.ReadUInt32();
                    MinChar[index].facilityResVar = binaryReader.ReadUInt32();
                    MinChar[index].combatBase = binaryReader.ReadUInt32();
                    MinChar[index].combatVar = binaryReader.ReadUInt32();
                    MinChar[index].leadershipBase = binaryReader.ReadUInt32();
                    MinChar[index].leadershipVar = binaryReader.ReadUInt32();
                    MinChar[index].loyaltyBase = binaryReader.ReadUInt32();
                    MinChar[index].loyaltyVar = binaryReader.ReadUInt32();
                    MinChar[index].jediProbability = binaryReader.ReadUInt32();
                    MinChar[index].knownJediFlag = binaryReader.ReadUInt32();
                    MinChar[index].jediLevelBase = binaryReader.ReadUInt32();
                    MinChar[index].jediLevelVar = binaryReader.ReadUInt32();
                    MinChar[index].admiralFlag = binaryReader.ReadUInt32();
                    MinChar[index].commanderFlag = binaryReader.ReadUInt32();
                    MinChar[index].generalFlag = binaryReader.ReadUInt32();
                    MinChar[index].betrayFlag = binaryReader.ReadUInt32();
                    MinChar[index].jediTrainFlag = binaryReader.ReadUInt32();
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

            unsavedMinCharData = true;
        }

        public static void ClearUnsavedData()
        {
            unsavedMinCharData = false;
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
