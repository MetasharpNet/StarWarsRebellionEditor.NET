namespace SwRebellionEditor
{
    public class CAPSHPSD : DatFile
    {
        public uint Field1_1; // 1
        [ArraySize]
        public uint CapitalShipsCount; // 30
        public uint FamilyId; // 20
        public uint Field4_28; // 28
        public CAPSHPSD_CapitalShip[] CapitalShips;
    }
    public class CAPSHPSD_CapitalShip
    {
        public uint CapitalShipId;
        public uint Field2_1;
        public uint ProductionFacility;
        public uint NextProductionFacility;
        public uint FamilyId;
        public ushort TextStraDllId;
        public ushort Field7_2;
        public uint IsAllianceUnit;
        public uint IsEmpireUnit;
        public uint RefinedMaterialCost;
        public uint MaintenanceCost;
        public uint ResearchOrder;
        public uint ResearchDifficulty;
        public uint UnknownMoralHp;
        public uint DetectionRating;
        public uint ShieldStrength;
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
        public uint HullStrength;
        public uint TractorBeamPower;
        public uint TractorBeamRange;
        public uint GravityUnknown1;
        public uint GravityUnknown2;
        public uint BombardmentDefense;
        public uint DamageControl;
        public uint WeaponsRecharge;
        public uint ShieldRechargeRate;
        public uint FighterCapacity;
        public uint TroopCapacity;
        public uint Field51_Unknown;
        [Ignore]
        public string EncyclopediaName;
        [Ignore]
        public string EncyclopediaDescription;
    }
}
