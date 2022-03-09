namespace SwRebellionEditor
{
    public class DEFFACSD : DatFile
    {
        public uint UnknownHeader1; //1
        [ArraySize]
        public uint DefenseFacilitiesCount; //6
        public uint FamilyIdHeader; //34
        public uint UnknownHeader2; //40
        public DEFFACSD_DefenseFacility[] DefenseFacilities;
    }

    public class DEFFACSD_DefenseFacility
    {
        public uint UnitId;
        public uint Unknown1;
        public uint ProductionFacility;
        public uint NextProductionFacility;
        public uint FamilyId;
        public ushort TextStraDllId;
        public ushort Unknown2;
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
