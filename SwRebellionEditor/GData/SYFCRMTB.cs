namespace SwRebellionEditor
{
    public class SYFCRMTB
    {
        public static string fileName = "SYFCRMTB.DAT";
        private static OpenFileDialog openFileDialog;
        private static string tableFullPathname;
        public static int numUnits = 7;
        public static bool unsavedTableData;
        private static bool lockChange;
        public static uint headerUnknown1;
        public static uint headerUnknown2;
        public static uint headerUnknown3;
        public static byte headerChar1;
        public static byte headerChar2;
        public static byte headerChar3;
        public static byte headerChar4;
        public static byte headerChar5;
        public static byte headerChar6;
        public static byte headerChar7;
        public static byte headerChar8;
        public static byte headerChar9;
        public static byte headerChar10;
        public static byte headerChar11;
        public static byte headerChar12;
        public static byte headerChar13;
        public static byte headerChar14;
        public static FacilityProbability[] Table;

        public SYFCRMTB()
        {
            ClearUnsavedData();
            Table = new FacilityProbability[numUnits];
            LoadTableData(SetInitialFileName());
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

                SetTablePath(openFileDialog.FileName);
                return GetTablePath();
            }
            SetTablePath(RegistryKeys.InstalledLocation + "\\GData\\" + fileName);
            return GetTablePath();
        }

        public static string GetTablePath()
        {
            return tableFullPathname;
        }

        public static bool SetTablePath(string tablePath)
        {
            tableFullPathname = tablePath;
            return true;
        }

        public static bool SaveTableData(string saveFileName)
        {
            var binaryWriter = new BinaryWriter(File.Open(saveFileName, FileMode.Create));
            try
            {
                binaryWriter.Write(headerUnknown1);
                binaryWriter.Write(headerUnknown2);
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
                for (int index = 0; index != numUnits; ++index)
                {
                    binaryWriter.Write(Table[index].recNum);
                    binaryWriter.Write(Table[index].entNum1);
                    binaryWriter.Write(Table[index].ent1chance);
                    binaryWriter.Write(Table[index].entNum2);
                    binaryWriter.Write(Table[index].unknown1);
                    binaryWriter.Write(Table[index].facilityNum);
                }
                SetTablePath(saveFileName);
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

        public static void OpenNewTableFile()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = RegistryKeys.InstalledLocation + "\\Gdata";
            openFileDialog.Filter = "Data Files (*.dat)| *.dat";
            openFileDialog.FileName = fileName;
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            LoadTableData(openFileDialog.FileName);
            SetTablePath(openFileDialog.FileName);
            ClearUnsavedData();
        }

        public static bool LoadTableData(string tableDataFile)
        {
            if (tableDataFile == null)
            {
                return false;
            }

            var binaryReader = new BinaryReader(File.Open(tableDataFile, FileMode.Open));
            try
            {
                headerUnknown1 = binaryReader.ReadUInt32();
                headerUnknown2 = binaryReader.ReadUInt32();
                headerUnknown3 = binaryReader.ReadUInt32();
                headerChar1 = binaryReader.ReadByte();
                headerChar2 = binaryReader.ReadByte();
                headerChar3 = binaryReader.ReadByte();
                headerChar4 = binaryReader.ReadByte();
                headerChar5 = binaryReader.ReadByte();
                headerChar6 = binaryReader.ReadByte();
                headerChar7 = binaryReader.ReadByte();
                headerChar8 = binaryReader.ReadByte();
                headerChar9 = binaryReader.ReadByte();
                headerChar10 = binaryReader.ReadByte();
                headerChar11 = binaryReader.ReadByte();
                headerChar12 = binaryReader.ReadByte();
                headerChar13 = binaryReader.ReadByte();
                headerChar14 = binaryReader.ReadByte();
                for (int index = 0; index != numUnits; ++index)
                {
                    Table[index].recNum = binaryReader.ReadUInt32();
                    Table[index].entNum1 = binaryReader.ReadUInt32();
                    Table[index].ent1chance = binaryReader.ReadUInt32();
                    Table[index].entNum2 = binaryReader.ReadUInt16();
                    Table[index].unknown1 = binaryReader.ReadByte();
                    Table[index].facilityNum = binaryReader.ReadByte();
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

            unsavedTableData = true;
        }

        public static void ClearUnsavedData()
        {
            unsavedTableData = false;
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
