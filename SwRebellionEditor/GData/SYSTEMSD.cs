namespace SwRebellionEditor
{
    public class SYSTEMSD : DatFile
    {
        public uint UnknownHeader1; // 1
        [ArraySize]
        public uint SystemsCount; // 200
        public uint HeaderFamilyId; // 144
        public uint UnknownHeader2; // 152
        public SYSTEMSD_System[] Systems;
    }
    public class SYSTEMSD_System
    {
        public uint SystemId;
        public uint Unknown1;
        public uint ProductionFacility;
        public uint NextProductionFacility;
        public uint FamilyId;
        public ushort TextStraDllId;
        public ushort Unknown2;
        public uint SectorId;
        public uint PictureId;
        public uint Unknown3;
        public ushort XPosition;
        public ushort YPosition;
        public uint Unknown4;
        [Ignore]
        public string EncyclopediaName;
        [Ignore]
        public string EncyclopediaDescription;
    }
}
