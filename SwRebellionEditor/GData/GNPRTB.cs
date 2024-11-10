namespace SwRebellionEditor;

public class GNPRTB : DatFile
{
    public uint Field1_1;
    [ArraySize(1)]
    public uint GeneralParamTableEntriesCount; // 213
    [ArraySize(0)]
    public uint InfoLength; // 22
    public byte[] Info; // "GeneralParamTableEntry" as 1 byte per char
    public GNPRTB_GeneralParamTableEntry[] GeneralParamTableEntries;

    public override void PostLoad()
    {
        GeneralParamTableEntries.First(spe => spe.Id ==   1).Name = "Space Travel Time: base (%, lower=faster)";
        
        GeneralParamTableEntries.First(spe => spe.Id ==  25).Name = "Injured character:  Combat points recovered by day";

        GeneralParamTableEntries.First(spe => spe.Id ==  53).Name = "Seat of Power (Emperor on Coruscant): Leadership percentage bonus";
        GeneralParamTableEntries.First(spe => spe.Id ==  60).Name = "Space Travel Time: Han Solo (%, lower=faster)";
        
        GeneralParamTableEntries.First(spe => spe.Id ==  72).Name = "Damaged Squadron: Days to recover 1 Fighter if Shipyard";
        GeneralParamTableEntries.First(spe => spe.Id ==  73).Name = "Damaged Squadron:Days to recover 1 Fighter if no Shipyard";

        GeneralParamTableEntries.First(spe => spe.Id ==  74).Name = "Space Travel Time: distance divisor (higher=faster)";
        GeneralParamTableEntries.First(spe => spe.Id ==  83).Name = "Fleet 1 location probability: Yavin vs HQ";
        
        GeneralParamTableEntries.First(spe => spe.Id ==  84).Name = "CMUNYVTB.DAT - Alliance Yavin 4: min army n° to deploy";
        GeneralParamTableEntries.First(spe => spe.Id ==  85).Name = "CMUNYVTB.DAT - Alliance Yavin 4: max army n° to deploy";
        GeneralParamTableEntries.First(spe => spe.Id ==  86).Name = "CMUNHQTB.DAT - Alliance HQ: min army n° to deploy";
        GeneralParamTableEntries.First(spe => spe.Id ==  87).Name = "CMUNHQTB.DAT - Alliance HQ: max army n° to deploy";
        GeneralParamTableEntries.First(spe => spe.Id ==  88).Name = "CMUNCRTB.DAT - Empire Coruscant: min army n° to deploy";
        GeneralParamTableEntries.First(spe => spe.Id ==  89).Name = "CMUNCRTB.DAT - Empire Coruscant: max army n° to deploy";
        GeneralParamTableEntries.First(spe => spe.Id ==  90).Name = "CMUNAFTB.DAT - Alliance HQ or Yavin 4 Fleet: min capital ship n° to deploy";
        GeneralParamTableEntries.First(spe => spe.Id ==  91).Name = "CMUNAFTB.DAT - Alliance HQ or Yavin 4 Fleet: max capital ship n° to deploy";
        GeneralParamTableEntries.First(spe => spe.Id ==  92).Name = "CMUNEFTB.DAT - Empire Coruscant Fleet: min capital ship n° to deploy";
        GeneralParamTableEntries.First(spe => spe.Id ==  93).Name = "CMUNEFTB.DAT - Empire Coruscant Fleet: max capital ship n° to deploy";
        GeneralParamTableEntries.First(spe => spe.Id ==  94).Name = "FACLHQTB.DAT - Alliance HQ: min facilities group n° to deploy";
        GeneralParamTableEntries.First(spe => spe.Id ==  95).Name = "FACLHQTB.DAT - Alliance HQ: max facilities group n° to deploy";
        GeneralParamTableEntries.First(spe => spe.Id ==  96).Name = "FACLCRTB.DAT - Empire Coruscant: min facilities group n° to deploy";
        GeneralParamTableEntries.First(spe => spe.Id ==  97).Name = "FACLCRTB.DAT - Empire Coruscant: max facilities group n° to deploy";
        
        GeneralParamTableEntries.First(spe => spe.Id == 101).Name = "Luke goes to Dagobah: base (days)";
        GeneralParamTableEntries.First(spe => spe.Id == 102).Name = "Luke goes to Dagobah: random extra (days)";
        GeneralParamTableEntries.First(spe => spe.Id == 103).Name = "Bounty Hunter Frequency: base (days)";
        GeneralParamTableEntries.First(spe => spe.Id == 104).Name = "Bounty Hunter Frequency: random extra (days)";

        GeneralParamTableEntries.First(spe => spe.Id == 111).Name = "Diplomacy points gain after Diplomacy success";
        GeneralParamTableEntries.First(spe => spe.Id == 112).Name = "Espionage points gain after Espionage success";
        GeneralParamTableEntries.First(spe => spe.Id == 114).Name = "Leadership points gain after Recruitment success";
        GeneralParamTableEntries.First(spe => spe.Id == 115).Name = "Leadership points gain after Incite Uprising success";
        GeneralParamTableEntries.First(spe => spe.Id == 116).Name = "Leadership points gain after Subdue Uprising success";
        GeneralParamTableEntries.First(spe => spe.Id == 118).Name = "Combat points gain after Abduction success";
        GeneralParamTableEntries.First(spe => spe.Id == 120).Name = "Espionage points gain after Sabotage success";
        GeneralParamTableEntries.First(spe => spe.Id == 121).Name = "Combat points gain after Sabotage success";

        GeneralParamTableEntries.First(spe => spe.Id == 137).Name = "Popularity % gain after diplomacy success on occupied system: Base Value";
        GeneralParamTableEntries.First(spe => spe.Id == 138).Name = "Popularity % gain after diplomacy success on occupied system: Random Extra";
        GeneralParamTableEntries.First(spe => spe.Id == 139).Name = "Popularity % gain after diplomacy success on neutral system: Base Value";
        GeneralParamTableEntries.First(spe => spe.Id == 140).Name = "Popularity % gain after diplomacy success on neutral system: Random Extra";

        GeneralParamTableEntries.First(spe => spe.Id == 145).Name = "Maintenance Shortfall Frequency (days)";
        GeneralParamTableEntries.First(spe => spe.Id == 146).Name = "Related to default (non mission) research rate (lower=faster) - To test";
        GeneralParamTableEntries.First(spe => spe.Id == 147).Name = "Related to default (non mission) research rate (lower=faster) - To test";
        
        GeneralParamTableEntries.First(spe => spe.Id == 151).Name = "Required Shield Generators to Prevent Assault";

        GeneralParamTableEntries.First(spe => spe.Id == 171).Name = "Informants Info Frequency: Base Value (lower=faster)";
        GeneralParamTableEntries.First(spe => spe.Id == 172).Name = "Informants Info Frequency: Random Extra (lower=faster)";

        GeneralParamTableEntries.First(spe => spe.Id == 175).Name = "Uprising: BAse Value";
        GeneralParamTableEntries.First(spe => spe.Id == 176).Name = "Uprising: Random Extra";
        GeneralParamTableEntries.First(spe => spe.Id == 175).Name = "Inform Table: Base Value";
        GeneralParamTableEntries.First(spe => spe.Id == 176).Name = "Inform Table: Random Extra";
        GeneralParamTableEntries.First(spe => spe.Id == 177).Name = "Informants: Success Event Index in table increment to random(8)";
        GeneralParamTableEntries.First(spe => spe.Id == 178).Name = "Informants: Success if random(8) is above";
        GeneralParamTableEntries.First(spe => spe.Id == 179).Name = "Systems: Mines slots (Raw Materials) min value allowed";
        GeneralParamTableEntries.First(spe => spe.Id == 180).Name = "Systems: Mines slots (Raw Materials) max value allowed";
        GeneralParamTableEntries.First(spe => spe.Id == 181).Name = "Systems: Buildings slots (Energy) min value allowed";
        GeneralParamTableEntries.First(spe => spe.Id == 182).Name = "Systems: Buildings slots (Energy) max value allowed";
        GeneralParamTableEntries.First(spe => spe.Id == 183).Name = "Natural Disaster: Raw material lost & Energy slots lost";
        GeneralParamTableEntries.First(spe => spe.Id == 184).Name = "Natural Disaster: % to lose a Facility (applied to each)";
        GeneralParamTableEntries.First(spe => spe.Id == 185).Name = "Natural Disaster: Frequency base (days)";
        GeneralParamTableEntries.First(spe => spe.Id == 186).Name = "Natural Disaster: Frequency random extra (days)";
        GeneralParamTableEntries.First(spe => spe.Id == 187).Name = "Resource Event: Frequency base (days)";
        GeneralParamTableEntries.First(spe => spe.Id == 188).Name = "Resource Event: Frequency random extra (days)";

        GeneralParamTableEntries.First(spe => spe.Id == 189).Name = "Core Systems: Buildings slots (Energy) base amount";
        GeneralParamTableEntries.First(spe => spe.Id == 190).Name = "Core Systems: Buildings slots (Energy) random extra amount";
        GeneralParamTableEntries.First(spe => spe.Id == 191).Name = "Core Systems: Mines slots (Raw Materials) base amount";
        GeneralParamTableEntries.First(spe => spe.Id == 192).Name = "Core Systems: Mines slots (Raw Materials) random extra amount";
        GeneralParamTableEntries.First(spe => spe.Id == 193).Name = "Rim Systems: Buildings slots (Energy) base amount";
        GeneralParamTableEntries.First(spe => spe.Id == 194).Name = "Rim Systems: Buildings slots (Energy) random extra amount 1";
        GeneralParamTableEntries.First(spe => spe.Id == 195).Name = "Rim Systems: Buildings slots (Energy) random extra amount 2";
        GeneralParamTableEntries.First(spe => spe.Id == 196).Name = "Rim Systems: Mines slots (Raw Materials) base amount";
        GeneralParamTableEntries.First(spe => spe.Id == 197).Name = "Rim Systems: Mines slots (Raw Materials) random extra amount";
        GeneralParamTableEntries.First(spe => spe.Id == 198).Name = "Core Systems: Populated systems percentage";
        GeneralParamTableEntries.First(spe => spe.Id == 199).Name = "Rim Systems: Populated systems percentage";

        GeneralParamTableEntries.First(spe => spe.Id == 206).Name = "Populary % required on system to join side";
        GeneralParamTableEntries.First(spe => spe.Id == 207).Name = "Garrison Requirement: Uprising threshold";
        GeneralParamTableEntries.First(spe => spe.Id == 208).Name = "Garrison Requirement: Troop's order contribution";

        GeneralParamTableEntries.First(spe => spe.Id == 210).Name = "??? Core Sector Neutral System support Base Popularity (%)";
    }
}
public class GNPRTB_GeneralParamTableEntry
{
    public uint Id;
    public uint Field2_1; // 1
    public uint ParameterId;
    public int AllianceMultiPlayer;
    public int AllianceSinglePlayerEasy;
    public int AllianceSinglePlayerMedium;
    public int AllianceSinglePlayerHard;
    public int EmpireSinglePlayerEasy;
    public int EmpireSinglePlayerMedium;
    public int EmpireSinglePlayerHard;
    public int EmpireMultiPlayer;
    [Ignore]
    public string Name = "Unknown General Param Table Entry";
}
