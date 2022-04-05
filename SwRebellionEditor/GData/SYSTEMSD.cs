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
        public uint SystemId;
        public uint Field2_Unknown;
        public uint ProductionFacility;
        public uint NextProductionFacility;
        public uint FamilyId;
        public ushort TextStraDllId;
        public ushort Field7_Unknown;
        public uint SectorId;
        public uint PictureId;
        public uint Field10_Unknown;
        public ushort XPosition;
        public ushort YPosition;
        public uint Field13_Unknown;
        [Ignore]
        public string Name;
        [Ignore]
        public string Description;
    }
}
