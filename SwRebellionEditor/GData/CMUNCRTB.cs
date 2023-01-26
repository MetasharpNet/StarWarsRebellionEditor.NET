namespace SwRebellionEditor;


// CorHQ
public class CMUNCRTB
{
    private static ushort tempNumUnits;
    private static ushort temp;
    private static OpenFileDialog openFileDialog;
    private static string CorHQFullPathname;
    public static int numUnits = 200;
    public static bool unsavedSystemData;
    private static bool lockChange;
    public static uint headerUnknown1;
    public static uint headerNumUnits;
    public static uint headerFamlyNum;
    public static uint headerUnknown3;
    public static AllianceHeadquarter[] CorHQ;

    public CMUNCRTB()
    {
        ClearUnsavedData();
        CorHQ = new AllianceHeadquarter[numUnits];
        LoadCorHQData(SetInitialFileName());
    }

    private static string SetInitialFileName()
    {
        if (Settings.Current.GameFolder == null)
        {
            openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                throw new Exception("No CorHQ Data File Specified");
            }

            SetCorHQPath(openFileDialog.FileName);
            return GetCorHQPath();
        }
        SetCorHQPath(Path.Combine(Settings.Current.GDataFolder, "CMUNCRTB.dat"));
        return GetCorHQPath();
    }

    public static string GetCorHQPath()
    {
        return CorHQFullPathname;
    }

    public static bool SetCorHQPath(string CorHQPath)
    {
        CorHQFullPathname = CorHQPath;
        return true;
    }

    public static bool SaveCorHQData(string saveFileName)
    {
        BinaryWriter binaryWriter = new BinaryWriter(File.Open(saveFileName, FileMode.Create));
        try
        {
            binaryWriter.Write(headerUnknown1);
            binaryWriter.Write(headerNumUnits);
            binaryWriter.Write(headerFamlyNum);
            binaryWriter.Write(headerUnknown3);
            int num = 0;
            while (num != numUnits)
            {
                ++num;
            }

            SetCorHQPath(saveFileName);
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

    public static void OpenNewCorHQFile()
    {
        openFileDialog = new OpenFileDialog();
        if (openFileDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        LoadCorHQData(openFileDialog.FileName);
        SetCorHQPath(openFileDialog.FileName);
        ClearUnsavedData();
    }

    public static bool LoadCorHQData(string CorHQDataFile)
    {
        if (CorHQDataFile == null)
        {
            return false;
        }

        BinaryReader binaryReader = new BinaryReader(File.Open(CorHQDataFile, FileMode.Open));
        try
        {
            headerUnknown1 = binaryReader.ReadUInt32();
            headerNumUnits = binaryReader.ReadUInt32();
            headerFamlyNum = binaryReader.ReadUInt32();
            for (int index = 0; index < 5; ++index)
            {
                headerUnknown3 = binaryReader.ReadUInt32();
            }

            for (int index = 0; index < 5; ++index)
            {
                headerUnknown3 = binaryReader.ReadUInt32();
            }

            tempNumUnits = binaryReader.ReadUInt16();
            temp = binaryReader.ReadUInt16();
            for (int index = 0; index < 3; ++index)
            {
                headerUnknown3 = binaryReader.ReadUInt32();
            }

            CorHQ = new AllianceHeadquarter[tempNumUnits - 1];
            for (int index = 0; index != tempNumUnits - 1; ++index)
            {
                CorHQ[index].test01 = binaryReader.ReadUInt32();
                CorHQ[index].test02 = binaryReader.ReadUInt32();
                CorHQ[index].test03 = binaryReader.ReadUInt16();
                CorHQ[index].test04 = binaryReader.ReadUInt16();
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
