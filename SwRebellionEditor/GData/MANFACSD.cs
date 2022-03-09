namespace SwRebellionEditor
{
    // Manufacturing
    public class MANFACSD
    {
        private static OpenFileDialog openFileDialog;
        private static string ManufacturingFullPathname;
        private static int numUnits = 6;
        public static bool unsavedManufacturingData;
        private static bool lockChange;
        public static uint headerUnknown1;
        public static uint headerUnknown2;
        public static uint headerFamlyNum;
        public static uint headerUnknown3;
        public static ManufacturingFacility[] Manufacturing;

        public MANFACSD()
        {
            ClearUnsavedData();
            Manufacturing = new ManufacturingFacility[numUnits];
            LoadManufacturingData(SetInitialFileName());
        }

        private static string SetInitialFileName()
        {
            if (RegistryKeys.InstalledLocation == null)
            {
                openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    throw new Exception("No Manufacturing Data File Specified");
                }

                SetManufacturingPath(openFileDialog.FileName);
                return GetManufacturingPath();
            }
            SetManufacturingPath(RegistryKeys.InstalledLocation + "\\GData\\MANFACSD.DAT");
            return GetManufacturingPath();
        }

        public static string GetManufacturingPath()
        {
            return ManufacturingFullPathname;
        }

        public static bool SetManufacturingPath(string ManufacturingdPath)
        {
            ManufacturingFullPathname = ManufacturingdPath;
            return true;
        }

        public static bool SaveManufacturingData(string saveFileName)
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
                    binaryWriter.Write(Manufacturing[index].number);
                    binaryWriter.Write(Manufacturing[index].unknown1);
                    binaryWriter.Write(Manufacturing[index].prodFacilityNum);
                    binaryWriter.Write(Manufacturing[index].unknown2);
                    binaryWriter.Write(Manufacturing[index].familyNum);
                    binaryWriter.Write(Manufacturing[index].textstratNum);
                    binaryWriter.Write(Manufacturing[index].unknown3);
                    binaryWriter.Write(Manufacturing[index].rebel);
                    binaryWriter.Write(Manufacturing[index].empire);
                    binaryWriter.Write(Manufacturing[index].conCost);
                    binaryWriter.Write(Manufacturing[index].maintCost);
                    binaryWriter.Write(Manufacturing[index].researchNum);
                    binaryWriter.Write(Manufacturing[index].researchDiff);
                    binaryWriter.Write(Manufacturing[index].unknown4);
                    binaryWriter.Write(Manufacturing[index].rate);
                }
                SetManufacturingPath(saveFileName);
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

        public static void OpenNewManufacturingFile()
        {
            openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            LoadManufacturingData(openFileDialog.FileName);
            SetManufacturingPath(openFileDialog.FileName);
            ClearUnsavedData();
        }

        public static bool LoadManufacturingData(string ManufacturingDataFile)
        {
            if (ManufacturingDataFile == null)
            {
                return false;
            }

            BinaryReader binaryReader = new BinaryReader(File.Open(ManufacturingDataFile, FileMode.Open));
            try
            {
                headerUnknown1 = binaryReader.ReadUInt32();
                headerUnknown2 = binaryReader.ReadUInt32();
                headerFamlyNum = binaryReader.ReadUInt32();
                headerUnknown3 = binaryReader.ReadUInt32();
                for (int index = 0; index != numUnits; ++index)
                {
                    Manufacturing[index].number = binaryReader.ReadUInt32();
                    Manufacturing[index].unknown1 = binaryReader.ReadUInt32();
                    Manufacturing[index].prodFacilityNum = binaryReader.ReadUInt32();
                    Manufacturing[index].unknown2 = binaryReader.ReadUInt32();
                    Manufacturing[index].familyNum = binaryReader.ReadUInt32();
                    Manufacturing[index].textstratNum = binaryReader.ReadUInt16();
                    Manufacturing[index].unknown3 = binaryReader.ReadUInt16();
                    Manufacturing[index].rebel = binaryReader.ReadUInt32();
                    Manufacturing[index].empire = binaryReader.ReadUInt32();
                    Manufacturing[index].conCost = binaryReader.ReadUInt32();
                    Manufacturing[index].maintCost = binaryReader.ReadUInt32();
                    Manufacturing[index].researchNum = binaryReader.ReadUInt32();
                    Manufacturing[index].researchDiff = binaryReader.ReadUInt32();
                    Manufacturing[index].unknown4 = binaryReader.ReadUInt32();
                    Manufacturing[index].rate = binaryReader.ReadUInt32();
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

            unsavedManufacturingData = true;
        }

        public static void ClearUnsavedData()
        {
            unsavedManufacturingData = false;
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