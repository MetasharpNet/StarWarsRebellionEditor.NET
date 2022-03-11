namespace SwRebellionEditor
{
    public class MNCHARSD : DatFile
    {
        public uint UnknownHeader1;
        [ArraySize]
        public uint MinorCharactersCount;
        public uint FamilyIdHeader;
        public uint UnknownHeader2;
        public MNCHARSD_MinorCharacter[] MinorCharacters;
    }
    public class MNCHARSD_MinorCharacter
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
        public uint TroopsResearchVariance;
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
        public uint canBeCommander;
        public uint CanBeGeneral;
        public uint IsUnableToBetray;
        public uint IsJediTrainer;
        [Ignore]
        public string EncyclopediaName;
        [Ignore]
        public string EncyclopediaDescription;
    }
}
