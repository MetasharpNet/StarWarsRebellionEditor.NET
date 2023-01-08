namespace SwRebellionEditor
{
    public class SECTORSD : DatFile
    {
        public uint Field1_1;
        [ArraySize]
        public uint SectorsCount;
        public uint FamilyId;
        public uint Field4_Unknown;
        public SECTORSD_Sector[] Sectors;
    }
    public class SECTORSD_Sector
    {
        public uint Id;
        public uint Field2_1;
        public uint ProductionFamily_0;
        public uint NextProductionFamily_0;
        public uint FamilyId;
        public ushort TextStraDllId;
        public ushort Field7_2;
        public uint SecImport;
        public uint GalaxySize;
        public ushort XPosition;
        public ushort YPosition;
        [Ignore]
        public string Name;
        [Ignore]
        public string EncyclopediaDescription;
    }
}
