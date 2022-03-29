namespace SwRebellionEditor
{
    public class TROOPSD : DatFile
    {
        public uint UnknownHeader1; // 1
        [ArraySize]
        public uint TroopsCount; // 10
        public uint FamilyId; // 16
        public uint UnknownHeader2;  // 20
        public TROOPSD_Troop[] Troops;
    }
    public class TROOPSD_Troop
    {
        public uint TroopId;
        public uint Unknown1;
        public uint ProductionFacility;
        public uint NextProductionFacility;
        public uint FamilyId;
        public ushort TextStraDllId;
        public ushort Unknwown2;
        public uint IsAllianceUnit;
        public uint IsEmpireUnit;
        public uint ConstructionCost;
        public uint MaintenanceCost;
        public uint ResearchOrder;
        public uint ResearchDifficulty;
        public uint UnknownMoralHp;
        public uint DetectionRating;
        public uint BombardmentRating;
        public uint AttackRating;
        public uint DefenseRating;
        [Ignore]
        public string EncyclopediaName;
        [Ignore]
        public string EncyclopediaText;
    }
}