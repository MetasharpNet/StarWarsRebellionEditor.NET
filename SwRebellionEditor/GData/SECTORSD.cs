namespace SwRebellionEditor
{
    public class SECTORSD
    {
        private static OpenFileDialog openFileDialog;
        private static string SectorFullPathname;
        public static int numUnits = 20;
        public static bool unsavedSectorData;
        private static bool lockChange;
        public static uint headerUnknown1;
        public static uint headerNumUnits;
        public static uint headerFamlyNum;
        public static uint headerUnknown3;
        public static SpaceSector[] Sectors;

        public SECTORSD()
        {
            ClearUnsavedData();
            Sectors = new SpaceSector[numUnits];
            LoadSectorData(SetInitialFileName());
        }

        private static string SetInitialFileName()
        {
            if (RegistryKeys.InstalledLocation == null)
            {
                openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    throw new Exception("No Sector Data File Specified");
                }

                SetSectorPath(openFileDialog.FileName);
                return GetSectorPath();
            }
            SetSectorPath(RegistryKeys.InstalledLocation + "\\GData\\SECTORSD.DAT");
            return GetSectorPath();
        }

        public static string GetSectorPath()
        {
            return SectorFullPathname;
        }

        public static bool SetSectorPath(string SectorPath)
        {
            SectorFullPathname = SectorPath;
            return true;
        }

        public static bool SaveSectorData(string saveFileName)
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
                    binaryWriter.Write(Sectors[index].number);
                    binaryWriter.Write(Sectors[index].unknown1);
                    binaryWriter.Write(Sectors[index].prodFacilityNum);
                    binaryWriter.Write(Sectors[index].unknown2);
                    binaryWriter.Write(Sectors[index].familyNum);
                    binaryWriter.Write(Sectors[index].textstratNum);
                    binaryWriter.Write(Sectors[index].unknown3);
                    binaryWriter.Write(Sectors[index].secImport);
                    binaryWriter.Write(Sectors[index].galSize);
                    binaryWriter.Write(Sectors[index].xPos);
                    binaryWriter.Write(Sectors[index].yPos);
                }
                SetSectorPath(saveFileName);
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

        public static void OpenNewSectorFile()
        {
            openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            LoadSectorData(openFileDialog.FileName);
            SetSectorPath(openFileDialog.FileName);
            ClearUnsavedData();
        }

        public static bool LoadSectorData(string SectorDataFile)
        {
            if (SectorDataFile == null)
            {
                return false;
            }

            var binaryReader = new BinaryReader(File.Open(SectorDataFile, FileMode.Open));
            try
            {
                headerUnknown1 = binaryReader.ReadUInt32();
                headerNumUnits = binaryReader.ReadUInt32();
                headerFamlyNum = binaryReader.ReadUInt32();
                headerUnknown3 = binaryReader.ReadUInt32();
                numUnits = (int)headerNumUnits;
                for (int index = 0; index != numUnits; ++index)
                {
                    Sectors[index].number = binaryReader.ReadUInt32();
                    Sectors[index].unknown1 = binaryReader.ReadUInt32();
                    Sectors[index].prodFacilityNum = binaryReader.ReadUInt32();
                    Sectors[index].unknown2 = binaryReader.ReadUInt32();
                    Sectors[index].familyNum = binaryReader.ReadUInt32();
                    Sectors[index].textstratNum = binaryReader.ReadUInt16();
                    Sectors[index].unknown3 = binaryReader.ReadUInt16();
                    Sectors[index].secImport = binaryReader.ReadUInt32();
                    Sectors[index].galSize = binaryReader.ReadUInt32();
                    Sectors[index].xPos = binaryReader.ReadUInt16();
                    Sectors[index].yPos = binaryReader.ReadUInt16();
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

            unsavedSectorData = true;
        }

        public static void ClearUnsavedData()
        {
            unsavedSectorData = false;
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
