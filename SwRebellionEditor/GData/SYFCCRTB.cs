namespace SwRebellionEditor
{
    public class SYFCCRTB : DatFile
    {
        public uint UnknownHeader1; // 1
        [ArraySize]
        public uint FacilityProbabilitiesCount; // 8
        public uint FamilyIdHeader; // 14
        public byte[] SeedTableEntry = new byte[14]; // "SeedTableEntry" as 1 byte per char
        public SYFCCRTB_FacilityProbability[] FacilityProbabilities;
    }
    public class SYFCCRTB_FacilityProbability
    {
        public uint Id;
        public uint EntryId;
        public uint Percent;
        public ushort TypeId;
        public byte Unknown;
        public byte FacilityId;
    }
}
