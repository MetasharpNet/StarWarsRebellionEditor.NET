namespace SwRebellionEditor
{
    public class SYFCCRTB : DatFile
    {
        public uint Field1_1; // 1
        [ArraySize(1)]
        public uint FacilityProbabilitiesCount; // 8
        [ArraySize(0)]
        public uint InfoLength; // 14
        public byte[] Info; // "SeedTableEntry" as 1 byte per char
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
