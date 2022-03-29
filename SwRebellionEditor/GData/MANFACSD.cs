namespace SwRebellionEditor
{
    public class MANFACSD : DatFile
    {
        public uint Field1_1; // 1
        [ArraySize]
        public uint ManufacturingFacilitiesCount; // 6
        public uint FamilyId; // 40
        public uint Field4_44; // 44
        public MANFACSD_ManufacturingFacility[] ManufacturingFacilities;
    }
    public class MANFACSD_ManufacturingFacility
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
        public string EncyclopediaName;
        [Ignore]
        public string EncyclopediaDescription;
    }
}