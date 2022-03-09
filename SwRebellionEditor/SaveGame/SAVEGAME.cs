namespace SwRebellionEditor
{
    public class SAVEGAME
    {
        private static OpenFileDialog openFileDialog;
        private static string SaveGameFullPathname;
        public static int numUnits = 200;
        public static bool unsavedSaveGameData;
        private static bool lockChange;
        public static uint headerUnknown1;
        public static uint headerUnknown2;
        public static uint headerFamlyNum;
        public static uint headerUnknown3;
        public static SavegameChunks[] SaveGame;

        public SAVEGAME()
        {
            ClearUnsavedData();
            SaveGame = new SavegameChunks[numUnits];
            LoadSaveGameData(SetInitialFileName());
        }

        private static string SetInitialFileName()
        {
            if (RegistryKeys.InstalledLocation == null)
            {
                openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    throw new Exception("No SaveGame Data File Specified");
                }

                SetSaveGamePath(openFileDialog.FileName);
                return GetSaveGamePath();
            }
            SetSaveGamePath(RegistryKeys.InstalledLocation + "\\SaveGame\\SAVEGAME.003");
            return GetSaveGamePath();
        }

        public static string GetSaveGamePath()
        {
            return SaveGameFullPathname;
        }

        public static bool SetSaveGamePath(string SaveGamePath)
        {
            SaveGameFullPathname = SaveGamePath;
            return true;
        }

        public static bool SaveSaveGameData(string saveFileName)
        {
            var binaryWriter = new BinaryWriter(File.Open(saveFileName, FileMode.Create));
            try
            {
                binaryWriter.Write(headerUnknown1);
                binaryWriter.Write(headerUnknown2);
                binaryWriter.Write(headerFamlyNum);
                binaryWriter.Write(headerUnknown3);
                int num = 0;
                while (num != numUnits)
                {
                    ++num;
                }

                SetSaveGamePath(saveFileName);
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

        public static void OpenNewSaveGameFile()
        {
            openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            LoadSaveGameData(openFileDialog.FileName);
            SetSaveGamePath(openFileDialog.FileName);
            ClearUnsavedData();
        }

        public static bool LoadSaveGameData(string SaveGameDataFile)
        {
            if (SaveGameDataFile == null)
            {
                return false;
            }

            var binaryReader = new BinaryReader(File.Open(SaveGameDataFile, FileMode.Open));
            try
            {
                headerUnknown1 = binaryReader.ReadUInt32();
                headerUnknown2 = binaryReader.ReadUInt32();
                headerFamlyNum = binaryReader.ReadUInt32();
                headerUnknown3 = binaryReader.ReadUInt32();
                for (int index = 0; index != numUnits; ++index)
                {
                    SaveGame[index].test001 = binaryReader.ReadUInt32();
                    SaveGame[index].test002 = binaryReader.ReadUInt32();
                    SaveGame[index].test003 = binaryReader.ReadUInt32();
                    SaveGame[index].test004 = binaryReader.ReadUInt32();
                    SaveGame[index].test005 = binaryReader.ReadUInt32();
                    SaveGame[index].test006 = binaryReader.ReadUInt32();
                    SaveGame[index].test007 = binaryReader.ReadUInt32();
                    SaveGame[index].test008 = binaryReader.ReadUInt32();
                    SaveGame[index].test009 = binaryReader.ReadUInt32();
                    SaveGame[index].test010 = binaryReader.ReadUInt32();
                    SaveGame[index].test011 = binaryReader.ReadUInt32();
                    SaveGame[index].test012 = binaryReader.ReadUInt32();
                    SaveGame[index].test013 = binaryReader.ReadUInt32();
                    SaveGame[index].test014 = binaryReader.ReadUInt32();
                    SaveGame[index].test015 = binaryReader.ReadUInt32();
                    SaveGame[index].test016 = binaryReader.ReadUInt32();
                    SaveGame[index].test017 = binaryReader.ReadUInt32();
                    SaveGame[index].test018 = binaryReader.ReadUInt32();
                    SaveGame[index].test019 = binaryReader.ReadUInt32();
                    SaveGame[index].test020 = binaryReader.ReadUInt32();
                    SaveGame[index].test021 = binaryReader.ReadUInt32();
                    SaveGame[index].test022 = binaryReader.ReadUInt32();
                    SaveGame[index].test023 = binaryReader.ReadUInt32();
                    SaveGame[index].test024 = binaryReader.ReadUInt32();
                    SaveGame[index].test025 = binaryReader.ReadUInt32();
                    SaveGame[index].test026 = binaryReader.ReadUInt32();
                    SaveGame[index].test027 = binaryReader.ReadUInt32();
                    SaveGame[index].test028 = binaryReader.ReadUInt32();
                    SaveGame[index].test029 = binaryReader.ReadUInt32();
                    SaveGame[index].test030 = binaryReader.ReadUInt32();
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

            unsavedSaveGameData = true;
        }

        public static void ClearUnsavedData()
        {
            unsavedSaveGameData = false;
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