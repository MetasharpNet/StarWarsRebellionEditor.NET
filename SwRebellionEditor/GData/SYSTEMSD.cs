namespace SwRebellionEditor
{
    public class SYSTEMSD
    {
        private static OpenFileDialog openFileDialog;
        private static string SystemFullPathname;
        public static int numUnits = 200;
        public static bool unsavedSystemData;
        private static bool lockChange;
        public static uint headerUnknown1;
        public static uint headerNumUnits;
        public static uint headerFamlyNum;
        public static uint headerUnknown3;
        public static SpaceSystem[] Systems;

        public SYSTEMSD()
        {
            ClearUnsavedData();
            Systems = new SpaceSystem[numUnits];
            LoadSystemData(SetInitialFileName());
        }

        private static string SetInitialFileName()
        {
            if (RegistryKeys.InstalledLocation == null)
            {
                openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    throw new Exception("No System Data File Specified");
                }

                SetSystemPath(openFileDialog.FileName);
                return GetSystemPath();
            }
            SetSystemPath(RegistryKeys.InstalledLocation + "\\GData\\SYSTEMSD.DAT");
            return GetSystemPath();
        }

        public static string GetSystemPath()
        {
            return SystemFullPathname;
        }

        public static bool SetSystemPath(string SystemPath)
        {
            SystemFullPathname = SystemPath;
            return true;
        }

        public static bool SaveSystemData(string saveFileName)
        {
            var binaryWriter = new BinaryWriter(File.Open(saveFileName, FileMode.Create));
            try
            {
                binaryWriter.Write(headerUnknown1);
                binaryWriter.Write(headerNumUnits);
                binaryWriter.Write(headerFamlyNum);
                binaryWriter.Write(headerUnknown3);
                for (int index = 0; index != numUnits; ++index)
                {
                    binaryWriter.Write(Systems[index].number);
                    binaryWriter.Write(Systems[index].unknown1);
                    binaryWriter.Write(Systems[index].prodFacilityNum);
                    binaryWriter.Write(Systems[index].unknown2);
                    binaryWriter.Write(Systems[index].familyNum);
                    binaryWriter.Write(Systems[index].textstratNum);
                    binaryWriter.Write(Systems[index].unknown3);
                    binaryWriter.Write(Systems[index].sectorID);
                    binaryWriter.Write(Systems[index].planetPicID);
                    binaryWriter.Write(Systems[index].unknown5);
                    binaryWriter.Write(Systems[index].xPos);
                    binaryWriter.Write(Systems[index].yPos);
                    binaryWriter.Write(Systems[index].unknown4);
                }
                SetSystemPath(saveFileName);
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

        public static void OpenNewSystemFile()
        {
            openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            LoadSystemData(openFileDialog.FileName);
            SetSystemPath(openFileDialog.FileName);
            ClearUnsavedData();
        }

        public static bool LoadSystemData(string SystemDataFile)
        {
            if (SystemDataFile == null)
            {
                return false;
            }

            var binaryReader = new BinaryReader(File.Open(SystemDataFile, FileMode.Open));
            try
            {
                headerUnknown1 = binaryReader.ReadUInt32();
                headerNumUnits = binaryReader.ReadUInt32();
                headerFamlyNum = binaryReader.ReadUInt32();
                headerUnknown3 = binaryReader.ReadUInt32();
                numUnits = (int)headerNumUnits;
                for (int index = 0; index != numUnits; ++index)
                {
                    Systems[index].number = binaryReader.ReadUInt32();
                    Systems[index].unknown1 = binaryReader.ReadUInt32();
                    Systems[index].prodFacilityNum = binaryReader.ReadUInt32();
                    Systems[index].unknown2 = binaryReader.ReadUInt32();
                    Systems[index].familyNum = binaryReader.ReadUInt32();
                    Systems[index].textstratNum = binaryReader.ReadUInt16();
                    Systems[index].unknown3 = binaryReader.ReadUInt16();
                    Systems[index].sectorID = binaryReader.ReadUInt32();
                    Systems[index].planetPicID = binaryReader.ReadUInt32();
                    Systems[index].unknown5 = binaryReader.ReadUInt32();
                    Systems[index].xPos = binaryReader.ReadUInt16();
                    Systems[index].yPos = binaryReader.ReadUInt16();
                    Systems[index].unknown4 = binaryReader.ReadUInt32();
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

            unsavedSystemData = true;
        }

        public static void ClearUnsavedData()
        {
            unsavedSystemData = false;
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
