namespace SwRebellionEditor
{
    // Prod Fac
    public class PROFACSD
    {
        private static OpenFileDialog openFileDialog;
        private static string ProdFacFullPathname;
        private static int numUnits = 2;
        public static bool unsavedProdFacData;
        private static bool lockChange;
        public static uint headerUnknown1;
        public static uint headerUnknown2;
        public static uint headerFamlyNum;
        public static uint headerUnknown3;
        public static ProductionFacility[] ProdFac;

        public PROFACSD()
        {
            ClearUnsavedData();
            ProdFac = new ProductionFacility[numUnits];
            LoadProdFacData(SetInitialFileName());
        }

        private static string SetInitialFileName()
        {
            if (RegistryKeys.InstalledLocation == null)
            {
                openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    throw new Exception("No ProdFac Data File Specified");
                }

                SetProdFacPath(openFileDialog.FileName);
                return GetProdFacPath();
            }
            SetProdFacPath(RegistryKeys.InstalledLocation + "\\GData\\PROFACSD.DAT");
            return GetProdFacPath();
        }

        public static string GetProdFacPath()
        {
            return ProdFacFullPathname;
        }

        public static bool SetProdFacPath(string ProdFacPath)
        {
            ProdFacFullPathname = ProdFacPath;
            return true;
        }

        public static bool SaveProdFacData(string saveFileName)
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
                    binaryWriter.Write(ProdFac[index].number);
                    binaryWriter.Write(ProdFac[index].unknown1);
                    binaryWriter.Write(ProdFac[index].prodFacilityNum);
                    binaryWriter.Write(ProdFac[index].unknown2);
                    binaryWriter.Write(ProdFac[index].familyNum);
                    binaryWriter.Write(ProdFac[index].textstratNum);
                    binaryWriter.Write(ProdFac[index].unknown3);
                    binaryWriter.Write(ProdFac[index].rebel);
                    binaryWriter.Write(ProdFac[index].empire);
                    binaryWriter.Write(ProdFac[index].conCost);
                    binaryWriter.Write(ProdFac[index].maintCost);
                    binaryWriter.Write(ProdFac[index].researchNum);
                    binaryWriter.Write(ProdFac[index].researchDiff);
                    binaryWriter.Write(ProdFac[index].unknown4);
                    binaryWriter.Write(ProdFac[index].rate);
                }
                SetProdFacPath(saveFileName);
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

        public static void OpenNewProdFacFile()
        {
            openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            LoadProdFacData(openFileDialog.FileName);
            SetProdFacPath(openFileDialog.FileName);
            ClearUnsavedData();
        }

        public static bool LoadProdFacData(string ProdFacDataFile)
        {
            if (ProdFacDataFile == null)
            {
                return false;
            }

            var binaryReader = new BinaryReader(File.Open(ProdFacDataFile, FileMode.Open));
            try
            {
                headerUnknown1 = binaryReader.ReadUInt32();
                headerUnknown2 = binaryReader.ReadUInt32();
                headerFamlyNum = binaryReader.ReadUInt32();
                headerUnknown3 = binaryReader.ReadUInt32();
                for (int index = 0; index != numUnits; ++index)
                {
                    ProdFac[index].number = binaryReader.ReadUInt32();
                    ProdFac[index].unknown1 = binaryReader.ReadUInt32();
                    ProdFac[index].prodFacilityNum = binaryReader.ReadUInt32();
                    ProdFac[index].unknown2 = binaryReader.ReadUInt32();
                    ProdFac[index].familyNum = binaryReader.ReadUInt32();
                    ProdFac[index].textstratNum = binaryReader.ReadUInt16();
                    ProdFac[index].unknown3 = binaryReader.ReadUInt16();
                    ProdFac[index].rebel = binaryReader.ReadUInt32();
                    ProdFac[index].empire = binaryReader.ReadUInt32();
                    ProdFac[index].conCost = binaryReader.ReadUInt32();
                    ProdFac[index].maintCost = binaryReader.ReadUInt32();
                    ProdFac[index].researchNum = binaryReader.ReadUInt32();
                    ProdFac[index].researchDiff = binaryReader.ReadUInt32();
                    ProdFac[index].unknown4 = binaryReader.ReadUInt32();
                    ProdFac[index].rate = binaryReader.ReadUInt32();
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

            unsavedProdFacData = true;
        }

        public static void ClearUnsavedData()
        {
            unsavedProdFacData = false;
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
