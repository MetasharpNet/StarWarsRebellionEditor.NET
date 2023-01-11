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
        public uint Field2_1; // 1
        public uint ProductionFamily; // 40:orbitalshipyard
        public uint NextProductionFamily; // 41
        public uint FamilyId; // 28:ship
        public ushort TextStraDllId;
        public ushort Field7_2; // 2
        public uint IsAlliance;
        public uint IsEmpire;
        public uint RefinedMaterialCost;
        public uint MaintenanceCost;
        public uint ResearchOrder;
        public uint ResearchDifficulty;
        public uint UprisingDefense; // 0.45 x RefinedMaterialCost
        public uint Detection;
        public uint ShieldStrength;
        public uint SubLightEngine;
        public uint Maneuverability;
        public uint Hyperdrive;
        public uint HyperdriveIfDamaged;
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
        public uint TurbolaserAttackStrength;
        public uint IonCannonAttackStrength;
        public uint LaserCannonAttackStrength;
        public uint OverallAttackStrength;
        public uint Torpedoes;
        public uint TorpedoesRange;
        public uint SquadronSize;
        public uint BombardmentDefense;
        [Ignore]
        public string Name;
        [Ignore]
        public string EncyclopediaDescription;
    }
}
