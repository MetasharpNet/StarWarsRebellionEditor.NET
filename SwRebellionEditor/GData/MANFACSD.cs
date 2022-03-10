namespace SwRebellionEditor
{
    public class MANFACSD : DatFile
    {
        public uint UnknownHeader1; // 1
        [ArraySize]
        public uint ManufacturingFacilitiesCount; // 6
        public uint FamilyIdHeader; // 40
        public uint UnknownHeader2; // 44
        public MANFACSD_ManufacturingFacility[] ManufacturingFacilities;
    }
    public class MANFACSD_ManufacturingFacility
    {
        public uint UnitId;
        public uint unknown1;
        public uint ProductionFacility;
        public uint NextProductionFacility;
        public uint FamilyId;
        public ushort TextStraDllId;
        public ushort Unknown;
        public uint IsAllianceUnit;
        public uint IsEmpireUnit;
        public uint ConstructionCost;
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