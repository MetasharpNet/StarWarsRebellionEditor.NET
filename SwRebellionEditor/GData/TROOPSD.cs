namespace SwRebellionEditor
{
    public class TROOPSD
    {
        private static OpenFileDialog openFileDialog;
        private static string troopFullPathname;
        private static int numUnits = 10;
        public static bool unsavedTroopData;
        private static bool lockChange;
        public static uint headerUnknown1;
        public static uint headerUnknown2;
        public static uint headerFamlyNum;
        public static uint headerUnknown3;
        public static Troop[] Troops;

        public TROOPSD()
        {
            ClearUnsavedData();
            Troops = new Troop[numUnits];
            LoadTroopData(SetInitialFileName());
        }

        private static string SetInitialFileName()
        {
            if (RegistryKeys.InstalledLocation == null)
            {
                openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    throw new Exception("No troop Data File Specified");
                }

                SetTroopPath(openFileDialog.FileName);
                return GetTroopPath();
            }
            SetTroopPath(RegistryKeys.InstalledLocation + "\\GData\\TROOPSD.DAT");
            return GetTroopPath();
        }

        public static string GetTroopPath()
        {
            return troopFullPathname;
        }

        public static bool SetTroopPath(string troopsdPath)
        {
            troopFullPathname = troopsdPath;
            return true;
        }

        public static bool SaveTroopData(string saveFileName)
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
                    binaryWriter.Write(Troops[index].number);
                    binaryWriter.Write(Troops[index].unknown1);
                    binaryWriter.Write(Troops[index].prodFacilityNum);
                    binaryWriter.Write(Troops[index].unknown2);
                    binaryWriter.Write(Troops[index].familyNum);
                    binaryWriter.Write(Troops[index].textstratNum);
                    binaryWriter.Write(Troops[index].unknown3);
                    binaryWriter.Write(Troops[index].rebel);
                    binaryWriter.Write(Troops[index].empire);
                    binaryWriter.Write(Troops[index].conCost);
                    binaryWriter.Write(Troops[index].maintCost);
                    binaryWriter.Write(Troops[index].researchNum);
                    binaryWriter.Write(Troops[index].researchDiff);
                    binaryWriter.Write(Troops[index].unknown4);
                    binaryWriter.Write(Troops[index].detection);
                    binaryWriter.Write(Troops[index].bombardment);
                    binaryWriter.Write(Troops[index].attack);
                    binaryWriter.Write(Troops[index].defense);
                }
                SetTroopPath(saveFileName);
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

        public static void OpenNewTroopFile()
        {
            openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            LoadTroopData(openFileDialog.FileName);
            SetTroopPath(openFileDialog.FileName);
            ClearUnsavedData();
        }

        public static bool LoadTroopData(string troopDataFile)
        {
            if (troopDataFile == null)
            {
                return false;
            }

            var binaryReader = new BinaryReader(File.Open(troopDataFile, FileMode.Open));
            try
            {
                headerUnknown1 = binaryReader.ReadUInt32();
                headerUnknown2 = binaryReader.ReadUInt32();
                headerFamlyNum = binaryReader.ReadUInt32();
                headerUnknown3 = binaryReader.ReadUInt32();
                for (int index = 0; index != numUnits; ++index)
                {
                    Troops[index].number = binaryReader.ReadUInt32();
                    Troops[index].unknown1 = binaryReader.ReadUInt32();
                    Troops[index].prodFacilityNum = binaryReader.ReadUInt32();
                    Troops[index].unknown2 = binaryReader.ReadUInt32();
                    Troops[index].familyNum = binaryReader.ReadUInt32();
                    Troops[index].textstratNum = binaryReader.ReadUInt16();
                    Troops[index].unknown3 = binaryReader.ReadUInt16();
                    Troops[index].rebel = binaryReader.ReadUInt32();
                    Troops[index].empire = binaryReader.ReadUInt32();
                    Troops[index].conCost = binaryReader.ReadUInt32();
                    Troops[index].maintCost = binaryReader.ReadUInt32();
                    Troops[index].researchNum = binaryReader.ReadUInt32();
                    Troops[index].researchDiff = binaryReader.ReadUInt32();
                    Troops[index].unknown4 = binaryReader.ReadUInt32();
                    Troops[index].detection = binaryReader.ReadUInt32();
                    Troops[index].bombardment = binaryReader.ReadUInt32();
                    Troops[index].attack = binaryReader.ReadUInt32();
                    Troops[index].defense = binaryReader.ReadUInt32();
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

        public static void setUnsavedData()
        {
            if (lockChange)
            {
                return;
            }

            unsavedTroopData = true;
        }

        public static void ClearUnsavedData()
        {
            unsavedTroopData = false;
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