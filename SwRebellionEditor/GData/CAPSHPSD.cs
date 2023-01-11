namespace SwRebellionEditor;

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
    public uint Id;
    public uint Field2_1; // 1
    public uint ProductionFamily; // 40:orbitalshipyard
    public uint NextProductionFamily; // 41
    public uint FamilyId; // 20:capitalship, 24:deathstar
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
    public uint Hull;
    public uint TractorBeamPower;
    public uint TractorBeamRange;
    public uint GravityWellProjector;
    public uint InterdictionStrength;
    public uint BombardmentModifier;
    public uint DamageControl;
    public uint WeaponRechargeRate;
    public uint ShieldRechargeRate;
    public uint FighterCapacity;
    public uint TroopCapacity;
    public uint Field51_0; // 0
    [Ignore]
    public string Name;
    [Ignore]
    public string EncyclopediaDescription;
}
