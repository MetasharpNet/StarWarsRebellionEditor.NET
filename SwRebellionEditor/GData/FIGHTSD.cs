namespace SwRebellionEditor
{
    public class FIGHTSD : DatFile
    {
        public uint Field1_1; // 1
        [ArraySize]
        public uint FightersCount; // 8
        public uint FamilyId; // 28
        public uint Field4_32; // 32
        public FIGHTSD_Fighter[] Fighters;
    }
    public class FIGHTSD_Fighter
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
        public uint DetectionRating;
        public uint ShieldEnergy;
        public uint SublightSpeed;
        public uint SublightManoeuvrability;
        public uint HyperdrivePrimary;
        public uint HyperdriveBackup;
        public uint TurbolaserFore;
        public uint IonCannonFore;
        public uint LaserCannonFore;
        public uint TurbolaserAft;
        public uint IonCannonAft;
        public uint LaserCannonAft;
        public uint TurbolaserPort;
        public uint IonCannonPort;
        public uint LaserCannonPort;
        public uint TurbolaserStarboard;
        public uint IonCannonStarboard;
        public uint LaserCannonStarboard;
        public uint TurbolaserRange;
        public uint IonCannonRange;
        public uint LaserCannonRange;
        public uint TurbolaserTotalFirePower;
        public uint IonCannonTotalFirePower;
        public uint LaserCannonTotalFirePower;
        public uint TotalFirePower;
        public uint TorpedoFore;
        public uint TorpedoRange;
        public uint SquadronSize;
        public uint BombardmentDefense;
        [Ignore]
        public string Name;
        [Ignore]
        public string EncyclopediaDescription;
    }
}
