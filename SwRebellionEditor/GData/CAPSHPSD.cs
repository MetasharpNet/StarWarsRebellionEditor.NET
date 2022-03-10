namespace SwRebellionEditor
{
    public class CAPSHPSD : DatFile
    {
        public uint UnknownHeader1; // 1
        [ArraySize]
        public uint CapitalShipsCount; // 30
        public uint FamilyIdHeader; // 20
        public uint UnknownHeader2; // 28
        public CAPSHPSD_CapitalShip[] CapitalShips;
    }
    public class CAPSHPSD_CapitalShip
    {
        public uint CapitalShipId;
        public uint Unknown1;
        public uint ProductionFacility;
        public uint NextProductionFacility;
        public uint FamilyId;
        public ushort TextStraDllId;
        public ushort Unknown2;
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
        public uint HullStrength;
        public uint TractorBeamPower;
        public uint TractorBeamRange;
        public uint GravityUnknown1;
        public uint GravityUnknown2;
        public uint BombardmentMod;
        public uint DamageControl;
        public uint WeaponsRecharge;
        public uint ShieldsRechargeRate;
        public uint CargoFighters;
        public uint CargoTroops;
        public uint Unknown3;
        [Ignore]
        public string EncyclopediaName;
        [Ignore]
        public string EncyclopediaDescription;
    }
}
