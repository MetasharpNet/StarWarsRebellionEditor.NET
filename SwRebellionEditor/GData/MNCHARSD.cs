using System.Reflection;

namespace SwRebellionEditor;

public class MNCHARSD : DatFile
{
    public uint Field1_1; // 1
    [ArraySize]
    public uint MinorCharactersCount; // 54
    public uint FamilyId; // 56
    public uint Field4_60; // 60
    public MNCHARSD_MinorCharacter[] MinorCharacters;

    #region Custom Import/Export
    protected override bool CustomCsvToField(FieldInfo? entryField, object? entry, string fieldName, string fieldValue)
    {
        switch (fieldName)
        {
            case "AdmiralName":
                return true;
            case "CommanderName":
                return true;
            case "GeneralName":
                return true;
            default:
                return false;
        }
    }
    protected override string CustomFieldToCsv(string fieldName, object fieldValue)
    {
        switch (fieldName)
        {
            case "AdmiralName":
                return "-";
            case "CommanderName":
                return "-";
            case "GeneralName":
                return "-";
            default:
                return "";
        }
    }
    #endregion
}
public class MNCHARSD_MinorCharacter
{
    public uint Id;
    public uint Field2_1; // 1
    public uint ProductionFamily_0; // 0
    public uint NextProductionFamily_0; // 0
    public uint FamilyId; // 56:minorcharacter
    public ushort TextStraDllId;
    public ushort Field7_2; // 2
    public uint IsAlliance;
    public uint IsEmpire;
    public uint RefinedMaterialCost_0; // 0
    public uint MaintenanceCost;
    public uint ResearchOrder_0; // 0
    public uint ResearchDifficulty_0; // 0
    public uint DiplomacyBase;
    public uint DiplomacyVariance;
    public uint EspionageBase;
    public uint EspionageVariance;
    public uint ShipDesignBase;
    public uint ShipDesignVariance;
    public uint TroopTrainingBase;
    public uint TroopTrainingVariance;
    public uint FacilityDesignBase;
    public uint FacilityDesignVariance;
    public uint CombatBase;
    public uint CombatVariance;
    public uint LeadershipBase;
    public uint LeadershipVariance;
    public uint LoyaltyBase;
    public uint LoyaltyVariance;
    public uint JediProbability;
    public uint IsKnownJedi;
    public uint JediLevelBase;
    public uint JediLevelVariance;
    public uint CanBeAdmiral;
    public uint CanBeCommander;
    public uint CanBeGeneral;
    public uint IsUnableToBetray;
    public uint IsJediTrainer;
    [Ignore]
    public string Name;
    [Ignore]
    public string AdmiralName;
    [Ignore]
    public string CommanderName;
    [Ignore]
    public string GeneralName;
    [Ignore]
    public string EncyclopediaDescription;
}
