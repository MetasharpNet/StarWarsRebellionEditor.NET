namespace SwRebellionEditor;

public class SYFCRMTB : DatFile
{
    public uint Field1_1; // 1
    [ArraySize(1)]
    public uint FacilityProbabilitiesCount; // 7
    [ArraySize(0)]
    public uint InfoLength; // 14
    public byte[] Info; // "SeedTableEntry" as 1 byte per char
    public SYFCRMTB_FacilityProbability[] FacilityProbabilities;
}
public class SYFCRMTB_FacilityProbability
{
    public uint Id;
    public uint EntryId;
    public uint Percent;
    public ushort TypeId;
    public byte Field5_Unknown;
    public byte FacilityId;
}
