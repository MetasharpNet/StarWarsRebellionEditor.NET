namespace SwRebellionEditor
{
    public class SPECFCSD : DatFile
    {
        public uint UnknownHeader1; // 1
        [ArraySize]
        public uint SpecialForcesCount; // 9
        public uint FamilyIdHeader; // 60
        public uint UnknownHeader2; // 64
        public SPECFCSD_SpecialForce[] SpecialForces;
    }
    public class SPECFCSD_SpecialForce
    {
        public uint SpecialForceId;
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
        public uint DiplomacyBase;
        public uint DiplomacyVariance;
        public uint EspionageBase;
        public uint EspionageVariance;
        public uint ShipsResearchBase;
        public uint ShipsResearchVariance;
        public uint TroopsResearchBase;
        public uint TroopsResearchVariance;
        public uint FacilitiesResearchBase;
        public uint FacilitiesResearchVariance;
        public uint CombatBase;
        public uint CombatVariance;
        public uint UnusedLeadershipBase;
        public uint UnusedLeadershipVariance;
        public uint LoyaltyBase;
        public uint LoyaltyVariance;
        public uint MissionId;
        [Ignore]
        public string EncyclopediaName;
        [Ignore]
        public string EncyclopediaDescription;
    }
}
