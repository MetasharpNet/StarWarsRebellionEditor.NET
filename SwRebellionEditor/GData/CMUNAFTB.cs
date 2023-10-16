namespace SwRebellionEditor;

public class CMUNAFTB : DatFile
{
    public uint Field1_1; // 1
    [ArraySize(1)]
    public uint GroupsCount; // 12
    [ArraySize(0)]
    public uint InfoLength; // 20
    public byte[] Info; // "SeedFamilyTableEntry" as 1 byte per char
    public CMUNAFTB_Group[] Groups;
}
public class CMUNAFTB_Group
{
    public uint Entry; // 1, 2, ...
    public uint Field2_1; // 1
    public uint EntryBis; // = Entry
    public uint Field4_1; // 1
    public uint Field5_1; // 1
    [ArraySize]
    public uint ItemsCount;
    public CMUNAFTB_Item[] Items;
    public override string ToString()
    {
        return String.Join<CMUNAFTB_Item>(",", Items);
    }

}
public class CMUNAFTB_Item
{
    public uint Field1_1; // 1
    public uint Field2_0; // 0
    public uint Item;
    public override string ToString()
    {
        return Identifier.ToName(Item);
    }
}
