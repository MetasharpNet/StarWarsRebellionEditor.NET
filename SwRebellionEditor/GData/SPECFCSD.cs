namespace SwRebellionEditor
{
    public class SPECFCSD : DatFile
    {
        public uint Field1_1; // 1
        [ArraySize]
        public uint SpecialForcesCount; // 9
        public uint FamilyId; // 60
        public uint Field4_64; // 64
        public SPECFCSD_SpecialForce[] SpecialForces;
    }
    public class SPECFCSD_SpecialForce
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
        public uint RefinedMaterialCost;
        public uint MaintenanceCost;
        public uint ResearchOrder_0;
        public uint ResearchDifficulty_0;
        public uint DiplomacyBase;
        public uint DiplomacyVariance;
        public uint EspionageBase;
        public uint EspionageVariance;
        public uint ShipDesignBase_0;
        public uint ShipDesignVariance_0;
        public uint TroopTrainingBase_0;
        public uint TroopTrainingVariance_0;
        public uint FacilityDesignBase_0;
        public uint FacilityDesignVariance_0;
        public uint CombatBase;
        public uint CombatVariance;
        public uint LeadershipBase;
        public uint LeadershipVariance;
        public uint LoyaltyBase;
        public uint LoyaltyVariance;
        public uint MissionId;
        [Ignore]
        public string Name;
        [Ignore]
        public string EncyclopediaDescription;
    }
}
