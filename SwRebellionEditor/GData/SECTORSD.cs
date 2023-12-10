using System.Reflection;

namespace SwRebellionEditor;

public class SECTORSD : DatFile
{
    public uint Field1_1;
    [ArraySize]
    public uint SectorsCount;
    public uint FamilyId;
    public uint Field4_Unknown;
    public SECTORSD_Sector[] Sectors;

    #region Custom Import/Export
    protected override bool CustomCsvToField(FieldInfo? entryField, object? entry, string fieldName, string fieldValue)
    {
        switch (fieldName)
        {
            case "Group":
                entryField.SetValue(entry, (fieldValue == "Core" ? 1 : (fieldValue == "Rim (inner)" ? 2 : (fieldValue == "Rim (outer)" ? 3 : UInt32.Parse(fieldValue)))));
                return true;
            case "GalaxySize":
                entryField.SetValue(entry, (fieldValue == "Standard" ? 1 : (fieldValue == "Large" ? 2 : (fieldValue == "Huge" ? 3 : UInt32.Parse(fieldValue)))));
                return true;
            default:
                return false;
        }
    }
    protected override string CustomFieldToCsv(string fieldName, object fieldValue)
    {
        switch (fieldName)
        {
            case "Group":
                var group = (uint)fieldValue;
                return (group == 1 ? "Core" : (group == 2 ? "Rim (inner)" : (group == 3 ? "Rim (outer)" : group.ToString())));
            case "GalaxySize":
                var galaxySize = (uint)fieldValue;
                return (galaxySize == 1 ? "Standard" : (galaxySize == 2 ? "Large" : (galaxySize == 3 ? "Huge" : galaxySize.ToString())));
            default:
                return "";
        }
    }
    #endregion
}
public class SECTORSD_Sector
{
    public uint Id;
    public uint Field2_1; // 1
    public uint ProductionFamily_0; // 0
    public uint NextProductionFamily_0; // 0
    public uint FamilyId; // 128:sector
    public ushort TextStraDllId;
    public ushort Field7_2; // 2
    public uint Group; // 1:high, 2:medium, 3:low
    public uint GalaxySize; // 1:standard, 2:large, 3:huge, +4:inative
    public ushort XPosition;
    public ushort YPosition;
    [Ignore]
    public string Name;
}
