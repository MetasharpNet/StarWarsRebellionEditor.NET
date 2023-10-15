namespace SwRebellionEditor;

public class CMUNHQTB : DatFile
{
    public uint Field1_1; // 1
    [ArraySize(1)]
    public uint ArmiesCount; // 12
    [ArraySize(0)]
    public uint InfoLength; // 20
    public byte[] Info; // "SeedFamilyTableEntry" as 1 byte per char
    public CMUNHQTB_Army[] Armies;
}
public class CMUNHQTB_Army
{
    public uint Index; // index based 1
    public uint Field2_1; // 1
    public uint Probability; // 1, 9, 13, 27, 36, 40, 54, 58, 89, 90, 93, 97
    public uint Field4_1; // 1
    public uint Field5_1; // 1
    [ArraySize]
    public uint UnitsCount;
    public CMUNHQTB_Unit[] Units;
    public override string ToString()
    {
        return String.Join<CMUNHQTB_Unit>(",", Units);
    }

}
public class CMUNHQTB_Unit
{
    public uint Field1_1; // 1
    public uint Field2_0; // 0
    public uint Unit;
    public override string ToString()
    {
        return Identifier.ToName(Unit);
    }
}
