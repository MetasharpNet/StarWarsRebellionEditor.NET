namespace SwRebellionEditor
{
    public class MNCHARSD : DatFile
    {
        public uint Field1_1; // 1
        [ArraySize]
        public uint MinorCharactersCount; // 54
        public uint FamilyId; // 56
        public uint Field4_60; // 60
        public MNCHARSD_MinorCharacter[] MinorCharacters;
    }
    public class MNCHARSD_MinorCharacter
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
        public uint LeadershipBase_Unused;
        public uint LeadershipVariance_Unused;
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
