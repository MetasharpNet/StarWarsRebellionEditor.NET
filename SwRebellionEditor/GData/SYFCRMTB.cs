namespace SwRebellionEditor
{
    public class SYFCRMTB : DatFile
    {
        public uint UnknownHeader1; // 1
        [ArraySize]
        public uint FacilityProbabilitiesCount; // 7
        public uint FamilyIdHeader; // 14
        public byte[] SeedTableEntry = new byte[14]; // "SeedTableEntry" as 1 byte per char
        public SYFCRMTB_FacilityProbability[] FacilityProbabilities;
    }
    public class SYFCRMTB_FacilityProbability
    {
        public uint Id;
        public uint EntryId;
        public uint Percent;
        public ushort TypeId;
        public byte Unknown;
        public byte FacilityId;
    }
}
