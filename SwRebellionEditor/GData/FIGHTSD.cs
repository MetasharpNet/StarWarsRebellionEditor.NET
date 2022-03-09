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
        public uint unknown2;
        public uint FamilyId;
        public ushort TextStraDllId;
        public ushort unknown3;
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
        public uint firePowerArc1;
        public uint firePowerArc2;
        public uint firePowerArc3;
        public uint firePowerArc4;
        public uint firePowerArc5;
        public uint firePowerArc6;
        public uint firePowerArc7;
        public uint firePowerArc8;
        public uint firePowerArc9;
        public uint firePowerArc10;
        public uint firePowerArc11;
        public uint firePowerArc12;
        public uint turboLaserRange;
        public uint ionRange;
        public uint laserRange;
        public uint sumTurboLaserFP;
        public uint sumIonFP;
        public uint sumLaserFP;
        public uint sumFP;
        public uint torpedoPower;
        public uint torpedoRange;
        public uint squadronSize;
        public uint BombardmentMod;
        [Ignore]
        public string EncyclopediaName;
        [Ignore]
        public string swrEncyText;
    }
}
