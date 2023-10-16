namespace SwRebellionEditor;

public class SYFCRMTB : DatFile
{
    public uint Field1_1; // 1
    [ArraySize(1)]
    public uint FacilitiesCount; // 7
    [ArraySize(0)]
    public uint InfoLength; // 14
    public byte[] Info; // "SeedTableEntry" as 1 byte per char
    public SYFCRMTB_Facility[] Facilities;
}
public class SYFCRMTB_Facility
{
    public uint Index; // index based 1
    public uint Field2_1; // 1
    public uint RandomTreshold; // 0-100
    public uint Facility;
    public override string ToString()
    {
        return Identifier.ToName(Facility);
    }
}
