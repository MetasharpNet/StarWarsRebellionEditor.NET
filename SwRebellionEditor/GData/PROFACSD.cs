namespace SwRebellionEditor
{
    public class PROFACSD : DatFile
    {
        public uint Field1_1; // 1
        [ArraySize]
        public uint ProductionFacilitiesCount; // 2
        public uint FamilyId; // 44
        public uint Field4_48; // 48
        public PROFACSD_ProductionFacility[] ProductionFacilities;
    }
    public class PROFACSD_ProductionFacility
    {
        public uint Id;
        public uint Field2_1;
        public uint ProductionFamily;
        public uint NextProductionFamily;
        public uint FamilyId;
        public ushort TextStraDllId;
        public ushort Field7_2;
        public uint IsAlliance;
        public uint IsEmpire;
        public uint RefinedMaterialCost;
        public uint MaintenanceCost;
        public uint ResearchOrder;
        public uint ResearchDifficulty;
        public uint BombardmentDefense;
        public uint ProductionRate;
        [Ignore]
        public string Name;
        [Ignore]
        public string EncyclopediaDescription;
    }
}
