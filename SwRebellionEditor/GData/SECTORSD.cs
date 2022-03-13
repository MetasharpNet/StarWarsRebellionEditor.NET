namespace SwRebellionEditor
{
    public class SECTORSD : DatFile
    {
        public uint UnknownHeader1;
        [ArraySize]
        public uint SectorsCount;
        public uint HeaderFamilyId;
        public uint UnknownHeader2;
        public SECTORSD_Sector[] Sectors;
    }
    public class SECTORSD_Sector
    {
        public uint SectorId;
        public uint Unknown1;
        public uint ProductionFacility;
        public uint NextProductionFacility;
        public uint FamilyId;
        public ushort TextStraDllId;
        public ushort Unknown2;
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
