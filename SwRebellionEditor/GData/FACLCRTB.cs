namespace SwRebellionEditor;

public class FACLCRTB : DatFile
{
    public uint Field1_1; // 1
    [ArraySize(1)]
    public uint GroupsCount; // 12
    [ArraySize(0)]
    public uint InfoLength; // 20
    public byte[] Info; // "SeedFamilyTableEntry" as 1 byte per char
    public FACLCRTB_Group[] Groups;
}
public class FACLCRTB_Group
{
    public uint Index; // index based 1
    public uint Field2_1; // 1
    public uint IndexBis; // = Index
    public uint Field4_1; // 1
    public uint Field5_1; // 1
    [ArraySize]
    public uint ItemsCount;
    public FACLCRTB_Item[] Items;
    public override string ToString()
    {
        return String.Join<FACLCRTB_Item>(",", Items);
    }

}
public class FACLCRTB_Item
{
    public uint Field1_1; // 1
    public uint Field2_0; // 0
    public uint Item;
    public override string ToString()
    {
        return Identifier.ToName(Item);
    }
}
