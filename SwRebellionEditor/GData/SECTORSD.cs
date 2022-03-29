namespace SwRebellionEditor
{
    public class SECTORSD : DatFile
    {
        public uint Field1_1;
        [ArraySize]
        public uint SectorsCount;
        public uint FamilyId;
        public uint Fields4_Unknown;
        public SECTORSD_Sector[] Sectors;
    }
    public class SECTORSD_Sector
    {
        public uint SectorId;
        public uint Field2_Unknown;
        public uint ProductionFacility;
        public uint NextProductionFacility;
        public uint FamilyId;
        public ushort TextStraDllId;
        public ushort Field7_Unknown;
        public uint SecImport;
        public uint GalaxySize;
        public ushort XPosition;
        public ushort YPosition;
        [Ignore]
        public string EncyclopediaName;
        [Ignore]
        public string EncyclopediaDescription;
    }
}
