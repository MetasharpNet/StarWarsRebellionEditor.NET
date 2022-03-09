namespace SwRebellionEditor
{
    // MajChar
    public class MJCHARSD
    {
        private static OpenFileDialog openFileDialog;
        private static string MajCharFullPathname;
        public static int numUnits = 6;
        public static bool unsavedMajCharData;
        private static bool lockChange;
        public static uint headerUnknown1;
        public static uint headerUnknown2;
        public static uint headerFamlyNum;
        public static uint headerUnknown3;
        public static Character[] MajChar;

        public MJCHARSD()
        {
            ClearUnsavedData();
            MajChar = new Character[numUnits];
            LoadMajCharData(SetInitialFileName());
        }

        private static string SetInitialFileName()
        {
            if (RegistryKeys.InstalledLocation == null)
            {
                openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    throw new Exception("No MajChar Data File Specified");
                }

                SetMajCharPath(openFileDialog.FileName);
                return GetMajCharPath();
            }
            SetMajCharPath(RegistryKeys.InstalledLocation + "\\GData\\MJCHARSD.DAT");
            return GetMajCharPath();
        }

        public static string GetMajCharPath()
        {
            return MajCharFullPathname;
        }

        public static bool SetMajCharPath(string MajCharPath)
        {
            MajCharFullPathname = MajCharPath;
            return true;
        }

        public static bool SaveMajCharData(string saveFileName)
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
                    binaryWriter.Write(MajChar[index].number);
                    binaryWriter.Write(MajChar[index].unknown1);
                    binaryWriter.Write(MajChar[index].prodFacilityNum);
                    binaryWriter.Write(MajChar[index].unknown2);
                    binaryWriter.Write(MajChar[index].familyNum);
                    binaryWriter.Write(MajChar[index].textstratNum);
                    binaryWriter.Write(MajChar[index].unknown3);
                    binaryWriter.Write(MajChar[index].rebel);
                    binaryWriter.Write(MajChar[index].empire);
                    binaryWriter.Write(MajChar[index].conCost);
                    binaryWriter.Write(MajChar[index].maintCost);
                    binaryWriter.Write(MajChar[index].researchNum);
                    binaryWriter.Write(MajChar[index].researchDiff);
                    binaryWriter.Write(MajChar[index].diplomacyBase);
                    binaryWriter.Write(MajChar[index].diplomacyVar);
                    binaryWriter.Write(MajChar[index].espionageBase);
                    binaryWriter.Write(MajChar[index].espionageVar);
                    binaryWriter.Write(MajChar[index].shipResBase);
                    binaryWriter.Write(MajChar[index].shipResVar);
                    binaryWriter.Write(MajChar[index].troopResBase);
                    binaryWriter.Write(MajChar[index].troopResVar);
                    binaryWriter.Write(MajChar[index].facilityResBase);
                    binaryWriter.Write(MajChar[index].facilityResVar);
                    binaryWriter.Write(MajChar[index].combatBase);
                    binaryWriter.Write(MajChar[index].combatVar);
                    binaryWriter.Write(MajChar[index].leadershipBase);
                    binaryWriter.Write(MajChar[index].leadershipVar);
                    binaryWriter.Write(MajChar[index].loyaltyBase);
                    binaryWriter.Write(MajChar[index].loyaltyVar);
                    binaryWriter.Write(MajChar[index].jediProbability);
                    binaryWriter.Write(MajChar[index].knownJediFlag);
                    binaryWriter.Write(MajChar[index].jediLevelBase);
                    binaryWriter.Write(MajChar[index].jediLevelVar);
                    binaryWriter.Write(MajChar[index].admiralFlag);
                    binaryWriter.Write(MajChar[index].commanderFlag);
                    binaryWriter.Write(MajChar[index].generalFlag);
                    binaryWriter.Write(MajChar[index].betrayFlag);
                    binaryWriter.Write(MajChar[index].jediTrainFlag);
                }
                SetMajCharPath(saveFileName);
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

        public static void OpenNewMajCharFile()
        {
            openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            LoadMajCharData(openFileDialog.FileName);
            SetMajCharPath(openFileDialog.FileName);
            ClearUnsavedData();
        }

        public static bool LoadMajCharData(string MajCharDataFile)
        {
            if (MajCharDataFile == null)
            {
                return false;
            }

            BinaryReader binaryReader = new BinaryReader(File.Open(MajCharDataFile, FileMode.Open));
            try
            {
                headerUnknown1 = binaryReader.ReadUInt32();
                headerUnknown2 = binaryReader.ReadUInt32();
                headerFamlyNum = binaryReader.ReadUInt32();
                headerUnknown3 = binaryReader.ReadUInt32();
                for (int index = 0; index != numUnits; ++index)
                {
                    MajChar[index].number = binaryReader.ReadUInt32();
                    MajChar[index].unknown1 = binaryReader.ReadUInt32();
                    MajChar[index].prodFacilityNum = binaryReader.ReadUInt32();
                    MajChar[index].unknown2 = binaryReader.ReadUInt32();
                    MajChar[index].familyNum = binaryReader.ReadUInt32();
                    MajChar[index].textstratNum = binaryReader.ReadUInt16();
                    MajChar[index].unknown3 = binaryReader.ReadUInt16();
                    MajChar[index].rebel = binaryReader.ReadUInt32();
                    MajChar[index].empire = binaryReader.ReadUInt32();
                    MajChar[index].conCost = binaryReader.ReadUInt32();
                    MajChar[index].maintCost = binaryReader.ReadUInt32();
                    MajChar[index].researchNum = binaryReader.ReadUInt32();
                    MajChar[index].researchDiff = binaryReader.ReadUInt32();
                    MajChar[index].diplomacyBase = binaryReader.ReadUInt32();
                    MajChar[index].diplomacyVar = binaryReader.ReadUInt32();
                    MajChar[index].espionageBase = binaryReader.ReadUInt32();
                    MajChar[index].espionageVar = binaryReader.ReadUInt32();
                    MajChar[index].shipResBase = binaryReader.ReadUInt32();
                    MajChar[index].shipResVar = binaryReader.ReadUInt32();
                    MajChar[index].troopResBase = binaryReader.ReadUInt32();
                    MajChar[index].troopResVar = binaryReader.ReadUInt32();
                    MajChar[index].facilityResBase = binaryReader.ReadUInt32();
                    MajChar[index].facilityResVar = binaryReader.ReadUInt32();
                    MajChar[index].combatBase = binaryReader.ReadUInt32();
                    MajChar[index].combatVar = binaryReader.ReadUInt32();
                    MajChar[index].leadershipBase = binaryReader.ReadUInt32();
                    MajChar[index].leadershipVar = binaryReader.ReadUInt32();
                    MajChar[index].loyaltyBase = binaryReader.ReadUInt32();
                    MajChar[index].loyaltyVar = binaryReader.ReadUInt32();
                    MajChar[index].jediProbability = binaryReader.ReadUInt32();
                    MajChar[index].knownJediFlag = binaryReader.ReadUInt32();
                    MajChar[index].jediLevelBase = binaryReader.ReadUInt32();
                    MajChar[index].jediLevelVar = binaryReader.ReadUInt32();
                    MajChar[index].admiralFlag = binaryReader.ReadUInt32();
                    MajChar[index].commanderFlag = binaryReader.ReadUInt32();
                    MajChar[index].generalFlag = binaryReader.ReadUInt32();
                    MajChar[index].betrayFlag = binaryReader.ReadUInt32();
                    MajChar[index].jediTrainFlag = binaryReader.ReadUInt32();
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

            unsavedMajCharData = true;
        }

        public static void ClearUnsavedData()
        {
            unsavedMajCharData = false;
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
