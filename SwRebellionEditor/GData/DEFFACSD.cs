namespace SwRebellionEditor;

public class DEFFACSD : DatFile
{
    public uint Field1_1; // 1
    [ArraySize]
    public uint DefenseFacilitiesCount; // 6
    public uint FamilyId; // 34
    public uint Field4_40; // 40
    public DEFFACSD_DefenseFacility[] DefenseFacilities;
}
public class DEFFACSD_DefenseFacility
{
    public uint Id;
    public uint Field2_1; // 1
    public uint ProductionFamily; // 42:constructionyard
    public uint NextProductionFamily; // 43
    public uint FamilyId; // 34:kdy, 35:lnr, 36:gencore, 37:deathstarshield
    public ushort TextStraDllId;
    public ushort Field7_2; // 2
    public uint IsAlliance;
    public uint IsEmpire;
    public uint RefinedMaterialCost;
    public uint MaintenanceCost;
    public uint ResearchOrder;
    public uint ResearchDifficulty;
    public uint BombardmentDefense;
    public uint AttackStrength;
    public uint ShieldStrength;
    [Ignore]
    public string Name;
    [Ignore]
    public string EncyclopediaDescription;
}
