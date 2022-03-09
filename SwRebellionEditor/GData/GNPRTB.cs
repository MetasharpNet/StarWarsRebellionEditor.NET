namespace SwRebellionEditor
{
    public class GNPRTB
    {
        private static OpenFileDialog openFileDialog;
        private static string GNPRTBFullPathname;
        private static int numUnits = 1;
        public static bool unsavedGNPRTBData;
        private static bool lockChange;
        public static byte[] GNPRTBstream;
        public static HyperspaceModifiers[] GNPRTBrec;

        public GNPRTB()
        {
            ClearUnsavedData();
            GNPRTBrec = new HyperspaceModifiers[numUnits];
            GNPRTBstream = new byte[3500];
            LoadGNPRTBData(SetInitialFileName());
        }

        private static string SetInitialFileName()
        {
            if (RegistryKeys.InstalledLocation == null)
            {
                openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    throw new Exception("No Data File Specified");
                }

                SetGNPRTBPath(openFileDialog.FileName);
                return GetGNPRTBPath();
            }
            SetGNPRTBPath(RegistryKeys.InstalledLocation + "\\GData\\GNPRTB.dat");
            return GetGNPRTBPath();
        }

        public static string GetGNPRTBPath()
        {
            return GNPRTBFullPathname;
        }

        public static bool SetGNPRTBPath(string GNPRTBPath)
        {
            GNPRTBFullPathname = GNPRTBPath;
            return true;
        }

        public static bool SaveGNPRTBData(string saveFileName)
        {
            var binaryWriter = new BinaryWriter(File.Open(saveFileName, FileMode.Open));
            try
            {
                binaryWriter.Seek(50, SeekOrigin.Begin);
                binaryWriter.Write(GNPRTBrec[0].empNov);
                binaryWriter.Seek(54, SeekOrigin.Begin);
                binaryWriter.Write(GNPRTBrec[0].empInt);
                binaryWriter.Seek(58, SeekOrigin.Begin);
                binaryWriter.Write(GNPRTBrec[0].empAdv);
                binaryWriter.Seek(62, SeekOrigin.Begin);
                binaryWriter.Write(GNPRTBrec[0].rebNov);
                binaryWriter.Seek(66, SeekOrigin.Begin);
                binaryWriter.Write(GNPRTBrec[0].rebInt);
                binaryWriter.Seek(70, SeekOrigin.Begin);
                binaryWriter.Write(GNPRTBrec[0].rebAdv);
                binaryWriter.Seek(2654, SeekOrigin.Begin);
                binaryWriter.Write(GNPRTBrec[0].mfNov);
                binaryWriter.Seek(2650, SeekOrigin.Begin);
                binaryWriter.Write(GNPRTBrec[0].mfInt);
                binaryWriter.Seek(2646, SeekOrigin.Begin);
                binaryWriter.Write(GNPRTBrec[0].mfAdv);
                binaryWriter.Seek(46, SeekOrigin.Begin);
                binaryWriter.Write(GNPRTBrec[0].empUnk);
                binaryWriter.Seek(74, SeekOrigin.Begin);
                binaryWriter.Write(GNPRTBrec[0].rebUnk);
                binaryWriter.Seek(2646, SeekOrigin.Begin);
                binaryWriter.Write(GNPRTBrec[0].mfAdv);
                binaryWriter.Seek(2642, SeekOrigin.Begin);
                binaryWriter.Write(GNPRTBrec[0].mfUnk1);
                binaryWriter.Seek(2658, SeekOrigin.Begin);
                binaryWriter.Write(GNPRTBrec[0].mfUnk2);
                binaryWriter.Seek(2662, SeekOrigin.Begin);
                binaryWriter.Write(GNPRTBrec[0].mfUnk3);
                binaryWriter.Seek(2666, SeekOrigin.Begin);
                binaryWriter.Write(GNPRTBrec[0].mfUnk4);
                binaryWriter.Seek(2670, SeekOrigin.Begin);
                binaryWriter.Write(GNPRTBrec[0].mfUnk5);
                SetGNPRTBPath(saveFileName);
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

        public static void OpenNewGNPRTBFile()
        {
            openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            LoadGNPRTBData(openFileDialog.FileName);
            SetGNPRTBPath(openFileDialog.FileName);
            ClearUnsavedData();
        }

        public static bool LoadGNPRTBData(string GNPRTBDataFile)
        {
            if (GNPRTBDataFile == null)
            {
                return false;
            }

            var binaryReader = new BinaryReader(File.Open(GNPRTBDataFile, FileMode.Open));
            try
            {
                for (int index = 0; index != 2800; ++index)
                {
                    GNPRTBstream[index] = binaryReader.ReadByte();
                }
            }
            catch (EndOfStreamException)
            {
            }
            finally
            {
                GNPRTBrec[0].rebNov = GNPRTBstream[50];
                GNPRTBrec[0].rebInt = GNPRTBstream[54];
                GNPRTBrec[0].rebAdv = GNPRTBstream[58];
                GNPRTBrec[0].empNov = GNPRTBstream[62];
                GNPRTBrec[0].empInt = GNPRTBstream[66];
                GNPRTBrec[0].empAdv = GNPRTBstream[70];
                GNPRTBrec[0].mfNov = GNPRTBstream[2646];
                GNPRTBrec[0].mfInt = GNPRTBstream[2650];
                GNPRTBrec[0].mfAdv = GNPRTBstream[2654];
                GNPRTBrec[0].empUnk = GNPRTBstream[74];
                GNPRTBrec[0].rebUnk = GNPRTBstream[46];
                GNPRTBrec[0].mfUnk1 = GNPRTBstream[2642];
                GNPRTBrec[0].mfUnk2 = GNPRTBstream[2658];
                GNPRTBrec[0].mfUnk3 = GNPRTBstream[2662];
                GNPRTBrec[0].mfUnk4 = GNPRTBstream[2666];
                GNPRTBrec[0].mfUnk5 = GNPRTBstream[2670];
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

            unsavedGNPRTBData = true;
        }

        public static void ClearUnsavedData()
        {
            unsavedGNPRTBData = false;
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