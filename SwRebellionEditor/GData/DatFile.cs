using System.Reflection;

namespace SwRebellionEditor;

public abstract class DatFile
{
    [Ignore]
    public bool UnsavedData;

    private static void LoadFields<T>(BinaryReader inputBinaryReader, FieldInfo[] inputFieldInfos, T outputObject)
        where T : new()
    {
        var arraySizes = new Dictionary<int, int>();
        int currentArray = 0;
        foreach (var inputFieldInfo in inputFieldInfos)
        {
            var ignoreAttribute = inputFieldInfo.GetCustomAttribute<IgnoreAttribute>();
            if (ignoreAttribute != null)
                continue;

            var fieldType = inputFieldInfo.FieldType;
            switch (fieldType.Name)
            {
                case "7BitEncodedInt":
                    inputFieldInfo.SetValue(outputObject, inputBinaryReader.Read7BitEncodedInt());
                    break;
                case "7BitEncodedInt64":
                    inputFieldInfo.SetValue(outputObject, inputBinaryReader.Read7BitEncodedInt64());
                    break;
                case "Boolean":
                    inputFieldInfo.SetValue(outputObject, inputBinaryReader.ReadBoolean());
                    break;
                case "Byte":
                    inputFieldInfo.SetValue(outputObject, inputBinaryReader.ReadByte());
                    break;
                case "Byte[]":
                    dynamic byteArray = inputFieldInfo.GetValue(outputObject);
                    var byteArraySize = (byteArray != null) ? byteArray.Length : arraySizes[currentArray++];
                    inputFieldInfo.SetValue(outputObject, inputBinaryReader.ReadBytes(byteArraySize));
                    break;
                case "Char":
                    inputFieldInfo.SetValue(outputObject, inputBinaryReader.ReadChar());
                    break;
                case "Char[]":
                    dynamic charArray = inputFieldInfo.GetValue(outputObject);
                    var charArraySize = (charArray != null) ? charArray.Length : arraySizes[currentArray++];
                    inputFieldInfo.SetValue(outputObject, inputBinaryReader.ReadChars(charArraySize));
                    break;
                case "Decimal":
                    inputFieldInfo.SetValue(outputObject, inputBinaryReader.ReadDecimal());
                    break;
                case "Double":
                    inputFieldInfo.SetValue(outputObject, inputBinaryReader.ReadDouble());
                    break;
                case "Half":
                    inputFieldInfo.SetValue(outputObject, inputBinaryReader.ReadHalf());
                    break;
                case "Int16":
                    inputFieldInfo.SetValue(outputObject, inputBinaryReader.ReadInt16());
                    break;
                case "Int32":
                    inputFieldInfo.SetValue(outputObject, inputBinaryReader.ReadInt32());
                    break;
                case "Int64":
                    inputFieldInfo.SetValue(outputObject, inputBinaryReader.ReadInt64());
                    break;
                case "SByte":
                    inputFieldInfo.SetValue(outputObject, inputBinaryReader.ReadSByte());
                    break;
                case "Single":
                    inputFieldInfo.SetValue(outputObject, inputBinaryReader.ReadSingle());
                    break;
                case "String":
                    inputFieldInfo.SetValue(outputObject, inputBinaryReader.ReadString());
                    break;
                case "UInt16":
                    inputFieldInfo.SetValue(outputObject, inputBinaryReader.ReadUInt16());
                    break;
                case "UInt32":
                    inputFieldInfo.SetValue(outputObject, inputBinaryReader.ReadUInt32());
                    break;
                case "UInt64":
                    inputFieldInfo.SetValue(outputObject, inputBinaryReader.ReadUInt64());
                    break;
                default:
                    if (fieldType.IsArray)
                    {
                        dynamic tArray = inputFieldInfo.GetValue(outputObject);
                        var arraySize = (tArray != null) ? tArray.Length : arraySizes[currentArray++];
                        dynamic array = Activator.CreateInstance(inputFieldInfo.FieldType, arraySize);
                        for (int i = 0; i < arraySize; ++i)
                        {
                            dynamic arrayElement = Activator.CreateInstance(inputFieldInfo.FieldType.GetElementType());
                            array[i] = arrayElement;
                            LoadFields(inputBinaryReader, inputFieldInfo.FieldType.GetElementType().GetFields(), arrayElement);
                        }
                        inputFieldInfo.SetValue(outputObject, array);
                        break;
                    }
                    else
                        throw new ApplicationException("fieldType: " + fieldType.Name + " not managed in DateFile.cs. Add the code to manage it.");
            }
            var arrayAttribute = inputFieldInfo.GetCustomAttribute<ArraySizeAttribute>();
            if (arrayAttribute != null)
                arraySizes[arrayAttribute.Id] = Convert.ToInt32(inputFieldInfo.GetValue(outputObject));
        }
    }

    public static TDatFile Load<TDatFile>(string filePath)
        where TDatFile : DatFile, new()
    {
        using var fileStream = File.Open(filePath, FileMode.Open);
        using var binaryReader = new BinaryReader(fileStream);
        var datFile = new TDatFile();
        var t = datFile.GetType();
        var fields = t.GetFields();
        LoadFields(binaryReader, fields, datFile);
        binaryReader.Close();
        return datFile;
    }

    public void SaveFields<T>(BinaryWriter outputBinaryWriter, FieldInfo[] inputFieldInfos, T inputObject)
        where T : new()
    {
        var arraySizes = new Dictionary<int, int>();
        int currentArray = 0;
        foreach (var inputFieldInfo in inputFieldInfos)
        {
            var ignoreAttribute = inputFieldInfo.GetCustomAttribute<IgnoreAttribute>();
            if (ignoreAttribute != null)
                continue;

            var fieldType = inputFieldInfo.FieldType;
            switch (fieldType.Name)
            {
                case "7BitEncodedInt":
                    outputBinaryWriter.Write((int)inputFieldInfo.GetValue(inputObject));
                    break;
                case "7BitEncodedInt64":
                    outputBinaryWriter.Write((long)inputFieldInfo.GetValue(inputObject));
                    break;
                case "Boolean":
                    outputBinaryWriter.Write((bool)inputFieldInfo.GetValue(inputObject));
                    break;
                case "Byte":
                    outputBinaryWriter.Write((byte)inputFieldInfo.GetValue(inputObject));
                    break;
                case "Byte[]":
                    outputBinaryWriter.Write((byte[])inputFieldInfo.GetValue(inputObject));
                    break;
                case "Char":
                    outputBinaryWriter.Write((char)inputFieldInfo.GetValue(inputObject));
                    break;
                case "Char[]":
                    outputBinaryWriter.Write((char[])inputFieldInfo.GetValue(inputObject));
                    break;
                case "Decimal":
                    outputBinaryWriter.Write((decimal)inputFieldInfo.GetValue(inputObject));
                    break;
                case "Double":
                    outputBinaryWriter.Write((double)inputFieldInfo.GetValue(inputObject));
                    break;
                case "Half":
                    outputBinaryWriter.Write((Half)inputFieldInfo.GetValue(inputObject));
                    break;
                case "Int16":
                    outputBinaryWriter.Write((short)inputFieldInfo.GetValue(inputObject));
                    break;
                case "Int32":
                    outputBinaryWriter.Write((int)inputFieldInfo.GetValue(inputObject));
                    break;
                case "Int64":
                    outputBinaryWriter.Write((long)inputFieldInfo.GetValue(inputObject));
                    break;
                case "SByte":
                    outputBinaryWriter.Write((sbyte)inputFieldInfo.GetValue(inputObject));
                    break;
                case "Single":
                    outputBinaryWriter.Write((Single)inputFieldInfo.GetValue(inputObject));
                    break;
                case "String":
                    outputBinaryWriter.Write((string)inputFieldInfo.GetValue(inputObject));
                    break;
                case "UInt16":
                    outputBinaryWriter.Write((ushort)inputFieldInfo.GetValue(inputObject));
                    break;
                case "UInt32":
                    outputBinaryWriter.Write((uint)inputFieldInfo.GetValue(inputObject));
                    break;
                case "UInt64":
                    outputBinaryWriter.Write((ulong)inputFieldInfo.GetValue(inputObject));
                    break;
                default:
                    if (fieldType.IsArray)
                    {
                        dynamic array = inputFieldInfo.GetValue(inputObject);
                        for (int i = 0; i < arraySizes[currentArray]; ++i)
                            SaveFields(outputBinaryWriter, array[i].GetType().GetFields(), array[i]);
                        ++currentArray;
                        break;
                    }
                    else
                        throw new ApplicationException("fieldType: " + fieldType.Name + " not managed in DateFile.cs. Add the code to manage it.");
            }
            var arrayAttribute = inputFieldInfo.GetCustomAttribute<ArraySizeAttribute>();
            if (arrayAttribute != null)
                arraySizes[arrayAttribute.Id] = Convert.ToInt32(inputFieldInfo.GetValue(inputObject));
        }
    }

    public void Save(string filePath)
    {
        using var fileStream = File.Open(filePath, FileMode.Create);
        using var binaryWriter = new BinaryWriter(fileStream);
        var t = GetType();
        var fields = t.GetFields();
        SaveFields(binaryWriter, fields, (dynamic)this);
        binaryWriter.Close();
    }
}
