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
        public uint UnitId;
        public uint Field2_Unknown;
        public uint ProductionFacility;
        public uint NextProductionFacility;
        public uint FamilyId;
        public ushort TextStraDllId;
        public ushort Field7_Unknown;
        public uint IsAllianceUnit;
        public uint IsEmpireUnit;
        public uint RefinedMaterialCost;
        public uint MaintenanceCost;
        public uint ResearchOrder;
        public uint ResearchDifficulty;
        public uint BombardmentDefense;
        public uint ProductionRate;
        [Ignore]
        public string Name;
        [Ignore]
        public string Description;
    }
}
