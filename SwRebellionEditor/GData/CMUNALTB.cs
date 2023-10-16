namespace SwRebellionEditor;

public class CMUNALTB : DatFile
{
    public uint Field1_1; // 1
    [ArraySize(1)]
    public uint GroupsCount; // 12
    [ArraySize(0)]
    public uint InfoLength; // 20
    public byte[] Info; // "SeedFamilyTableEntry" as 1 byte per char
    public CMUNALTB_Group[] Groups;
}
public class CMUNALTB_Group
{
    public uint Index; // index based 1
    public uint Field2_1; // 1
    public uint RandomTreshold; // 1, 9, 13, 27, 36, 40, 54, 58, 89, 90, 93, 97
    public uint Field4_1; // 1
    public uint Field5_1; // 1
    [ArraySize]
    public uint ItemsCount;
    public CMUNALTB_Item[] Items;
    public override string ToString()
    {
        return String.Join<CMUNALTB_Item>(",", Items);
    }

}
public class CMUNALTB_Item
{
    public uint Field1_1; // 1
    public uint Field2_0; // 0
    public uint Item;
    public override string ToString()
    {
        return Identifier.ToName(Item);
    }
}
