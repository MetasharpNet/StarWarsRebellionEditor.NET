namespace SwRebellionEditor;

public class GNPRTB : DatFile
{
    public uint Field1_1;
    [ArraySize(1)]
    public uint GeneralParamTableEntriesCount;
    [ArraySize(0)]
    public uint InfoLength; // 22
    public byte[] Info; // "GeneralParamTableEntry" as 1 byte per char
    public GNPRTB_GeneralParamTableEntry[] GeneralParamTableEntries;

    public override void PostLoad()
    {
        GeneralParamTableEntries.First(spe => spe.Id == 1).Name = "Space Travel Time: base (%, lower=faster)";
        GeneralParamTableEntries.First(spe => spe.Id == 53).Name = "Seat of Power (Emperor on Coruscant): Leadership percentage bonus";
        GeneralParamTableEntries.First(spe => spe.Id == 60).Name = "Space Travel Time: Han Solo (%, lower=faster)";
        GeneralParamTableEntries.First(spe => spe.Id == 83).Name = "Fleet 1 location probability: Yavin vs HQ";
        
        GeneralParamTableEntries.First(spe => spe.Id == 84).Name = "CMUNYVTB.DAT - First parent item";
        GeneralParamTableEntries.First(spe => spe.Id == 85).Name = "CMUNYVTB.DAT - Max parent items";
        GeneralParamTableEntries.First(spe => spe.Id == 86).Name = "CMUNHQTB.DAT - First parent item";
        GeneralParamTableEntries.First(spe => spe.Id == 87).Name = "CMUNHQTB.DAT - Max parent items";
        GeneralParamTableEntries.First(spe => spe.Id == 88).Name = "CMUNCRTB.DAT - First parent item";
        GeneralParamTableEntries.First(spe => spe.Id == 89).Name = "CMUNCRTB.DAT - Max parent items";
        GeneralParamTableEntries.First(spe => spe.Id == 90).Name = "CMUNAFTB.DAT - First parent item";
        GeneralParamTableEntries.First(spe => spe.Id == 91).Name = "CMUNAFTB.DAT - Max parent items";
        GeneralParamTableEntries.First(spe => spe.Id == 92).Name = "CMUNEFTB.DAT - First parent item";
        GeneralParamTableEntries.First(spe => spe.Id == 93).Name = "CMUNEFTB.DAT - Max parent items";
        GeneralParamTableEntries.First(spe => spe.Id == 94).Name = "FACLHQTB.DAT - First parent item";
        GeneralParamTableEntries.First(spe => spe.Id == 95).Name = "FACLHQTB.DAT - Max parent items";
        GeneralParamTableEntries.First(spe => spe.Id == 96).Name = "FACLCRTB.DAT - First parent item";
        GeneralParamTableEntries.First(spe => spe.Id == 97).Name = "FACLCRTB.DAT - Max parent items";
        
        GeneralParamTableEntries.First(spe => spe.Id == 101).Name = "Luke goes to Dagobah: base (days)";
        GeneralParamTableEntries.First(spe => spe.Id == 102).Name = "Luke goes to Dagobah: random extra (days)";
        GeneralParamTableEntries.First(spe => spe.Id == 103).Name = "Bounty Hunter Frequency: base (days)";
        GeneralParamTableEntries.First(spe => spe.Id == 104).Name = "Bounty Hunter Frequency: random extra (days)";
        GeneralParamTableEntries.First(spe => spe.Id == 145).Name = "Maintenance Shortfall Frequency (days)";
        GeneralParamTableEntries.First(spe => spe.Id == 151).Name = "Required Shield Generators to Prevent Assault";
        
        GeneralParamTableEntries.First(spe => spe.Id == 180).Name = "Systems: Mines slots (Raw Materials) max value allowed";
        GeneralParamTableEntries.First(spe => spe.Id == 182).Name = "Systems: Buildings slots (Energy) max value allowed";
        
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

        GeneralParamTableEntries.First(spe => spe.Id == 207).Name = "Garrison Requirement: Uprising threshold";
        GeneralParamTableEntries.First(spe => spe.Id == 208).Name = "Garrison Requirement: Troop's order contribution";
    }
}
public class GNPRTB_GeneralParamTableEntry
{
    public uint Id;
    public uint Field2_1; // 1
    public uint Unknown; // Second Byte sets Entry Group (???)
    public uint AllianceMultiPlayer;
    public uint AllianceSinglePlayerEasy;
    public uint AllianceSinglePlayerMedium;
    public uint AllianceSinglePlayerHard;
    public uint EmpireSinglePlayerEasy;
    public uint EmpireSinglePlayerMedium;
    public uint EmpireSinglePlayerHard;
    public uint EmpireMultiPlayer;
    [Ignore]
    public string Name = "Unknown General Param Table Entry";
}
