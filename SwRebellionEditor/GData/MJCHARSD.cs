namespace SwRebellionEditor
{
    public class MJCHARSD : DatFile
    {
        public uint Field1_1; // 1
        [ArraySize]
        public uint MajorCharactersCount; // 6
        public uint FamilyId; // 48
        public uint Field4_56; // 56
        public MJCHARSD_Character[] MajorCharacters;
    }
    public class MJCHARSD_Character
    {
        public uint Id;
        public uint Field2_1;
        public uint ProductionFacility;
        public uint NextProductionFacility;
        public uint FamilyId;
        public ushort TextStraDllId;
        public ushort Field7_2;
        public uint IsAlliance;
        public uint IsEmpire;
        public uint RefinedMaterialCost_Unused;
        public uint MaintenanceCost_Unused;
        public uint ResearchOrder_Unused;
        public uint ResearchDifficulty_Unused;
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
        public uint CanBeCommander;
        public uint CanBeGeneral;
        public uint IsUnableToBetray;
        public uint IsJediTrainer;
        [Ignore]
        public string Name;
        [Ignore]
        public string EncyclopediaDescription;
    }
}
