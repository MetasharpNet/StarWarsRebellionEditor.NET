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
        datFile.PostLoad();
        return datFile;
    }

    public virtual void PostLoad() { }

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
                    ++currentArray;
                    break;
                case "Char":
                    outputBinaryWriter.Write((char)inputFieldInfo.GetValue(inputObject));
                    break;
                case "Char[]":
                    outputBinaryWriter.Write((char[])inputFieldInfo.GetValue(inputObject));
                    ++currentArray;
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

    public void CsvToEntries(string csv, string entriesFieldName, string entriesCountFieldName, string separator = ";")
    {
        var datFileType   = GetType();
        var datFileFields = datFileType.GetFields();
        var entriesField  = datFileType.GetField(entriesFieldName);
        var entries       = entriesField.GetValue(this);
        var entriesType   = entriesField.FieldType;
        var entryType     = entriesField.FieldType.GetElementType();
        var entryFields   = entryType.GetFields();

        var lines = csv.Split(Environment.NewLine);
        var header = lines[0].Split(separator);
        // identify fields columns positions
        var fieldPositions = new Dictionary<string, int>();
        for (int i = 0; i < header.Length; ++i)
        {
            var fieldName = header[i];
            foreach (var entryField in entryFields)
            {
                if (entryField.Name == fieldName)
                {
                    fieldPositions[fieldName] = i;
                    break;
                }
            }
        }
        // entries
        uint entriesCount = 0;
        for (int i = 1; i < lines.Length; ++i)
        {
            var line = lines[i];
            if (line == "")
                continue;
            var columns = line.Split(separator);
            var entry = Activator.CreateInstance(entryType);
            foreach (var entryField in entryFields)
            {
                var fieldName = entryField.Name;
                var fieldPosition = fieldPositions[fieldName];
                var fieldType = entryField.FieldType;

                if (CustomCsvToField(entryField, entry, fieldName, columns[fieldPosition]))
                {
                    continue;
                }
                switch (fieldType.Name)
                {
                    case "7BitEncodedInt":
                        entryField.SetValue(entry, Convert.ToInt32(columns[fieldPosition]));
                        break;
                    case "7BitEncodedInt64":
                        entryField.SetValue(entry, Convert.ToInt64(columns[fieldPosition]));
                        break;
                    case "Boolean":
                        entryField.SetValue(entry, Convert.ToBoolean(columns[fieldPosition]));
                        break;
                    case "Byte":
                        entryField.SetValue(entry, Convert.ToByte(columns[fieldPosition]));
                        break;
                    case "Byte[]":
                        entryField.SetValue(entry, Convert.FromBase64String(columns[fieldPosition]));
                        break;
                    case "Char":
                        entryField.SetValue(entry, Convert.ToChar(columns[fieldPosition]));
                        break;
                    case "Char[]":
                        entryField.SetValue(entry, columns[fieldPosition].ToArray());
                        break;
                    case "Decimal":
                        entryField.SetValue(entry, Convert.ToDecimal(columns[fieldPosition]));
                        break;
                    case "Double":
                        entryField.SetValue(entry, Convert.ToDouble(columns[fieldPosition]));
                        break;
                    case "Int16":
                        entryField.SetValue(entry, Convert.ToInt16(columns[fieldPosition]));
                        break;
                    case "Int32":
                        entryField.SetValue(entry, Convert.ToInt32(columns[fieldPosition]));
                        break;
                    case "Int64":
                        entryField.SetValue(entry, Convert.ToInt64(columns[fieldPosition]));
                        break;
                    case "SByte":
                        entryField.SetValue(entry, Convert.ToSByte(columns[fieldPosition]));
                        break;
                    case "Single":
                        entryField.SetValue(entry, Convert.ToSingle(columns[fieldPosition]));
                        break;
                    case "String":
                        if (columns[fieldPosition].StartsWith("\"") && columns[fieldPosition].EndsWith("\""))
                            columns[fieldPosition] = columns[fieldPosition].Substring(1, columns[fieldPosition].Length - 2);
                        if (fieldName == "Name")
                        {
                            var textStraDllId = entryType.GetField("TextStraDllId");
                            if (textStraDllId != null && textStraDllId.GetValue(entry) != null)
                                ResourcesDlls.Textstra.SaveString(Convert.ToUInt16(textStraDllId.GetValue(entry)), columns[fieldPosition]);
                        }
                        else if(fieldName == "EncyclopediaDescription")
                        {
                            var textStraDllId = entryType.GetField("TextStraDllId");
                            if (textStraDllId != null && textStraDllId.GetValue(entry) != null)
                                ResourcesDlls.Encytext.SaveRcdata((Convert.ToUInt16(textStraDllId.GetValue(entry)) - 4096).ToString(), columns[fieldPosition]);
                        }
                        else
                            entryField.SetValue(entry, columns[fieldPosition]); 
                        entryField.SetValue(entry, columns[fieldPosition]);
                        break;
                    case "UInt16":
                        entryField.SetValue(entry, Convert.ToUInt16(columns[fieldPosition]));
                        break;
                    case "UInt32":
                        entryField.SetValue(entry, Convert.ToUInt32(columns[fieldPosition]));
                        break;
                    case "UInt64":
                        entryField.SetValue(entry, Convert.ToUInt64(columns[fieldPosition]));
                        break;
                    default:
                        if (fieldType.IsArray)
                        {
                            CustomCsvToEntries(csv, entriesFieldName, entriesCountFieldName, separator);
                            return;
                        }
                        else
                            throw new ApplicationException("fieldType: " + fieldType.Name + " not managed in DatFile.cs. Add the code to manage it.");
                        
                }
            }
            dynamic entriesArray = entriesField.GetValue(this);
            entriesArray.SetValue(entry, entriesCount);
            ++entriesCount;
        }
        // entries count
        var entriesCountField = datFileType.GetField(entriesCountFieldName);
        entriesCountField.SetValue(this, entriesCount);
    }

    public string EntriesToCsv(string entriesFieldName, string separator = ";")
    {
        var datFileType   = GetType();
        var datFileFields = datFileType.GetFields();
        var entriesField  = datFileType.GetField(entriesFieldName);
        var entries       = entriesField.GetValue(this);
        var entryType     = entriesField.FieldType.GetElementType();
        var entryFields   = entryType.GetFields();

        var csv = "";
        // header
        foreach (var entryField in entryFields)
        {
            csv += entryField.Name + separator;
        }
        csv += Environment.NewLine;

        // data
        foreach (var entry in (dynamic)entries)
        {
            foreach (var entryField in entryFields)
            {
                var fieldType = entryField.FieldType;
                var customField = CustomFieldToCsv(entryField.Name, entryField.GetValue(entry));
                if (!String.IsNullOrEmpty(customField))
                {
                    csv += customField + separator;
                    continue;
                }
                switch (fieldType.Name)
                {
                    case "7BitEncodedInt":
                        csv += ((int)entryField.GetValue(entry)).ToString();
                        break;
                    case "7BitEncodedInt64":
                        csv += ((long)entryField.GetValue(entry)).ToString();
                        break;
                    case "Boolean":
                        csv += ((bool)entryField.GetValue(entry)).ToString();
                        break;
                    case "Byte":
                        csv += ((byte)entryField.GetValue(entry)).ToString();
                        break;
                    case "Byte[]":
                        csv += ((byte[])entryField.GetValue(entry)).ToString();
                        break;
                    case "Char":
                        csv += ((char)entryField.GetValue(entry)).ToString();
                        break;
                    case "Char[]":
                        csv += ((char[])entryField.GetValue(entry)).ToString();
                        break;
                    case "Decimal":
                        csv += ((decimal)entryField.GetValue(entry)).ToString();
                        break;
                    case "Double":
                        csv += ((double)entryField.GetValue(entry)).ToString();
                        break;
                    case "Half":
                        csv += ((Half)entryField.GetValue(entry)).ToString();
                        break;
                    case "Int16":
                        csv += ((short)entryField.GetValue(entry)).ToString();
                        break;
                    case "Int32":
                        csv += ((int)entryField.GetValue(entry)).ToString();
                        break;
                    case "Int64":
                        csv += ((long)entryField.GetValue(entry)).ToString();
                        break;
                    case "SByte":
                        csv += ((sbyte)entryField.GetValue(entry)).ToString();
                        break;
                    case "Single":
                        csv += ((Single)entryField.GetValue(entry)).ToString();
                        break;
                    case "String":
                        csv += "\"" + ((string)entryField.GetValue(entry)).ToString().Replace(separator, (separator == ";" ? "," : ";")).Replace("\"", "") + "\"";
                        break;
                    case "UInt16":
                        csv += ((ushort)entryField.GetValue(entry)).ToString();
                        break;
                    case "UInt32":
                        csv += ((uint)entryField.GetValue(entry)).ToString();
                        break;
                    case "UInt64":
                        csv += ((ulong)entryField.GetValue(entry)).ToString();
                        break;
                    default:
                        if (fieldType.IsArray)
                        {
                            return CustomEntriesToCsv(separator);
                        }
                        else
                            throw new ApplicationException("fieldType: " + fieldType.Name + " not managed in DatFile.cs. Add the code to manage it.");
                }
                csv += separator;
            }
            csv += Environment.NewLine;
        }
        return csv;
    }

    #region Custom

    /// <summary>
    /// To override in child class if the entries contain arrays
    /// </summary>
    /// <param name="csv"></param>
    /// <param name="entriesFieldName"></param>
    /// <param name="entriesCountFieldName"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    protected virtual string CustomCsvToEntries(string csv, string entriesFieldName, string entriesCountFieldName, string separator = ";")
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// To override in child class if the entries contain arrays
    /// </summary>
    /// <param name="separator"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    protected virtual string CustomEntriesToCsv(string separator = ";")
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// To override in child class if the entries contain arrays
    /// </summary>
    /// <param name="entryField"></param>
    /// <param name="entry"></param>
    /// <param name="fieldName"></param>
    /// <param name="fieldValue"></param>
    /// <returns></returns>
    protected virtual bool CustomCsvToField(FieldInfo? entryField, object? entry, string fieldName, string fieldValue)
    {
        return false;
    }
    /// <summary>
    /// To override in child class if the entries contain arrays
    /// </summary>
    /// <param name="fieldName"></param>
    /// <param name="fieldValue"></param>
    /// <returns></returns>
    protected virtual string CustomFieldToCsv(string fieldName, object fieldValue)
    {
        return "";
    }

    #endregion
}
