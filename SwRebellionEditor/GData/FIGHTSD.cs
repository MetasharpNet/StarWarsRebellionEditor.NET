namespace SwRebellionEditor
{
    public class FIGHTSD : DatFile
    {
        public uint UnknownHeader1; // 1
        [ArraySize]
        public uint FightersCount; // 8
        public uint FamilyIdHeader; // 28
        public uint UnknownHeader2; // 32
        public FIGHTSD_Fighter[] Fighters;
    }

    public class FIGHTSD_Fighter
    {
        public uint FighterId;
        public uint unknown1;
        public uint ProductionFacility;
        public uint NextProductionFacility;
        public uint FamilyId;
        public ushort TextStraDllId;
        public ushort Unknown;
        public uint IsAllianceUnit;
        public uint IsEmpireUnit;
        public uint ConstructionCost;
        public uint MaintenanceCost;
        public uint ResearchOrder;
        public uint ResearchDifficulty;
        public uint UnknownMoralHp;
        public uint DetectionRating;
        public uint ShieldsMaxCapacity;
        public uint SublightSpeed;
        public uint SublightManoeuvrability;
        public uint HyperdrivePrimary;
        public uint HyperdriveBackup;
        public uint TurboLaserFore;
        public uint IonCannonFore;
        public uint LaserCannonFore;
        public uint TurboLaserAft;
        public uint IonCannonAft;
        public uint LaserCannonAft;
        public uint TurboLaserPort;
        public uint IonCannonPort;
        public uint LaserCannonPort;
        public uint TurboLaserStar;
        public uint IonCannonStar;
        public uint LaserCannonStar;
        public uint TurboLaserRange;
        public uint IonCannonRange;
        public uint LaserCannonRange;
        public uint TurboLaserTotalFirePower;
        public uint IonCannonTotalFirePower;
        public uint LaserCannonTotalFirePower;
        public uint TotalFirePower;
        public uint TorpedoFore;
        public uint TorpedoRange;
        public uint SquadronSize;
        public uint BombardmentMod;
        [Ignore]
        public string EncyclopediaName;
        [Ignore]
        public string swrEncyText;
    }
}
