namespace SwRebellionEditor
{
    public class TROOPSD : DatFile
    {
        public uint Field1_1; // 1
        [ArraySize]
        public uint TroopsCount; // 10
        public uint FamilyId; // 16
        public uint Field4_20;  // 20
        public TROOPSD_Troop[] Troops;
    }
    public class TROOPSD_Troop
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
        public uint ResearchOrder;
        public uint ResearchDifficulty;
        public uint UnknownMoralHp;
        public uint Detection;
        public uint BombardmentDefense;
        public uint AttackStrength;
        public uint DefenseStrength;
        [Ignore]
        public string Name;
        [Ignore]
        public string EncyclopediaDescription;
    }
}