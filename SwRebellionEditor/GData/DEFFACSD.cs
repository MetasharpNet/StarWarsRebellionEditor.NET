namespace SwRebellionEditor
{
    public class DEFFACSD : DatFile
    {
        public uint Field1_1; // 1
        [ArraySize]
        public uint DefenseFacilitiesCount; // 6
        public uint FamilyId; // 34
        public uint Field4_40; // 40
        public DEFFACSD_DefenseFacility[] DefenseFacilities;
    }
    public class DEFFACSD_DefenseFacility
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
        public uint ConstructionCost;
        public uint MaintenanceCost;
        public uint ResearchOrder;
        public uint ResearchDifficulty;
        public uint UnknownMoralHp;
        public uint FirePowerRating;
        public uint ShieldRating;
        [Ignore]
        public string EncyclopediaName;
        [Ignore]
        public string EncyclopediaDescription;
    }
}
