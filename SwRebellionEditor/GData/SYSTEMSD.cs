using System.Reflection;

namespace SwRebellionEditor;

public class SYSTEMSD : DatFile
{
    public uint Field1_1; // 1
    [ArraySize]
    public uint SystemsCount; // 200
    public uint FamilyId; // 144
    public uint Field4_152; // 152
    public SYSTEMSD_System[] Systems;

    #region Custom Import/Export
    protected override bool CustomCsvToField(FieldInfo? entryField, object? entry, string fieldName, string fieldValue)
    {
        switch (fieldName)
        {
            case "FamilyId":
                entryField.SetValue(entry, (fieldValue == "Explored" ? 144 : (fieldValue == "Unexplored" ? 146 : UInt32.Parse(fieldValue))));
                return true;
            default:
                return false;
        }
    }
    protected override string CustomFieldToCsv(string fieldName, object fieldValue)
    {
        switch (fieldName)
        {
            case "FamilyId":
                var group = (uint)fieldValue;
                return (group == 144 ? "Explored" : (group == 146 ? "Unexplored" : group.ToString()));
            default:
                return "";
        }
    }
    #endregion
}
public class SYSTEMSD_System
{
    public uint Id;
    public uint Field2_1; // 1
    public uint ProductionFamily_0; // 0
    public uint NextProductionFamily_0; // 0
    public uint FamilyId; // 144:core, 146:rim
    public ushort TextStraDllId;
    public ushort Field7_2; // 2
    public uint SectorId;
    public uint PictureId;
    public uint Field10_1; // 1
    public ushort XPosition;
    public ushort YPosition;
    public uint Field13_0; // 0
    [Ignore]
    public string Name;
    [Ignore]
    public string EncyclopediaDescription;
}
