namespace SwRebellionEditor
{
    public class MJCHARSD : DatFile
    {
        public uint UnknownHeader1; // 1
        [ArraySize]
        public uint MajorCharactersCount; // 6
        public uint FamilyIdHeader; // 48
        public uint UnknownHeader2; // 56
        public MJCHARSD_Character[] MajorCharacters;
    }
    public class MJCHARSD_Character
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
        public uint UnusedContructionCost;
        public uint UnusedMaintenanceCost;
        public uint UnusedResearchOrder;
        public uint UnusedResearchDifficulty;
        public uint DiplomacyBase;
        public uint DiplomacyVariance;
        public uint EspionageBase;
        public uint EspionageVariance;
        public uint ShipResearchBase;
        public uint ShipResearchVariance;
        public uint TroopsResearchBase;
        public uint TroopsReseachVariance;
        public uint FacilitiesResearchBase;
        public uint FacilitiesResearchVariance;
        public uint CombatBase;
        public uint CombatVariance;
        public uint UnusedLeadershipBase;
        public uint UnusedLeadershipVariance;
        public uint LoyaltyBase;
        public uint LoyaltyVariance;
        public uint JediProbabilityBase;
        public uint IsKnownJedi;
        public uint JediLevelBase;
        public uint JediLevelVariance;
        public uint CanBeAdmiral;
        public uint CanBeCommander;
        public uint CanBeGeneral;
        public uint IsUnableToBetray;
        public uint IsJediTrainer;
        [Ignore]
        public string EncyclopediaName;
        [Ignore]
        public string EncyclopediaDescription;
    }
}
