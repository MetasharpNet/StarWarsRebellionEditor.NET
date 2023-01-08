namespace SwRebellionEditor
{
    public class SYSTEMSD : DatFile
    {
        public uint Field1_1; // 1
        [ArraySize]
        public uint SystemsCount; // 200
        public uint FamilyId; // 144
        public uint Field4_152; // 152
        public SYSTEMSD_System[] Systems;
    }
    public class SYSTEMSD_System
    {
        public uint Id;
        public uint Field2_1;
        public uint ProductionFacility_0;
        public uint NextProductionFacility_0;
        public uint FamilyId;
        public ushort TextStraDllId;
        public ushort Field7_2;
        public uint SectorId;
        public uint PictureId;
        public uint Field10_1;
        public ushort XPosition;
        public ushort YPosition;
        public uint Field13_0;
        [Ignore]
        public string Name;
        [Ignore]
        public string EncyclopediaDescription;
    }
}
