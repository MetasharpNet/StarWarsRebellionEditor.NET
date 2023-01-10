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
        public uint ProductionFamily_0;
        public uint NextProductionFamily_0;
        public uint FamilyId;
        public ushort TextStraDllId;
        public ushort Field7_2;
        public uint IsAlliance;
        public uint IsEmpire;
        public uint RefinedMaterialCost_0;
        public uint MaintenanceCost;
        public uint ResearchOrder_0;
        public uint ResearchDifficulty_0;
        public uint DiplomacyBase;
        public uint DiplomacyVariance;
        public uint EspionageBase;
        public uint EspionageVariance;
        public uint ShipDesignBase;
        public uint ShipDesignVariance;
        public uint TroopTrainingBase;
        public uint TroopTrainingVariance;
        public uint FacilityDesignBase;
        public uint FacilityDesignVariance;
        public uint CombatBase;
        public uint CombatVariance;
        public uint LeadershipBase;
        public uint LeadershipVariance;
        public uint LoyaltyBase;
        public uint LoyaltyVariance;
        public uint JediProbability;
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
