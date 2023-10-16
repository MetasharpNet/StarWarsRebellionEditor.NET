namespace SwRebellionEditor;

// https://swrebellion.net/forums/topic/9639-mechanics-inside-rebellion-part-ii/

public class SDPRTB : DatFile
{
    public uint Field1_1;
    [ArraySize(1)]
    public uint SideParamTableEntriesCount;
    [ArraySize(0)]
    public uint InfoLength; // 19
    public byte[] Info; // "SideParamTableEntry" as 1 byte per char
    public SDPRTB_SideParamTableEntry[] SideParamTableEntries;

    [Ignore]
    public SDPRTB_SideParamTableEntry MinorCharactersInSmallGalaxy => SideParamTableEntries.First(spe => spe.Id == 4);
    [Ignore]
    public SDPRTB_SideParamTableEntry MinorCharactersInMediumGalaxy => SideParamTableEntries.First(spe => spe.Id == 5);
    [Ignore]
    public SDPRTB_SideParamTableEntry MinorCharactersInLargeGalaxy => SideParamTableEntries.First(spe => spe.Id == 6);
    [Ignore]
    public SDPRTB_SideParamTableEntry SideLotteryCoreSystems1_ProbaForEachSide => SideParamTableEntries.First(spe => spe.Id == 30);
    [Ignore]
    public SDPRTB_SideParamTableEntry SideLotteryCoreSystems2_ProbaForEachSide => SideParamTableEntries.First(spe => spe.Id == 31);
    [Ignore]
    public SDPRTB_SideParamTableEntry SideLotteryCoreSystems1_PopularitySupportBase => SideParamTableEntries.First(spe => spe.Id == 32);
    [Ignore]
    public SDPRTB_SideParamTableEntry SideLotteryCoreSystems1_PopularitySupportVar => SideParamTableEntries.First(spe => spe.Id == 33);
    [Ignore]
    public SDPRTB_SideParamTableEntry SideLotteryCoreSystems2_PopularitySupportBase => SideParamTableEntries.First(spe => spe.Id == 34);
    [Ignore]
    public SDPRTB_SideParamTableEntry SideLotteryCoreSystems2_PopularitySupportVar => SideParamTableEntries.First(spe => spe.Id == 35);

    public override void PostLoad()
    {
        SideParamTableEntries.First(spe => spe.Id == 4).Name = "Starting Minor Characters in Small Galaxy = 7 + ?";
        SideParamTableEntries.First(spe => spe.Id == 5).Name = "Starting Minor Characters in Medium Galaxy = 7 + ?";
        SideParamTableEntries.First(spe => spe.Id == 6).Name = "Starting Minor Characters in Large Galaxy = 7 + ?";
        SideParamTableEntries.First(spe => spe.Id == 23).Name = "% of Available Maintenance used to deploy Units at Day 0.";
        SideParamTableEntries.First(spe => spe.Id == 30).Name = "Core Sector Owned Systems with support";
        SideParamTableEntries.First(spe => spe.Id == 31).Name = "Core Sector Owned Systems without support";
        SideParamTableEntries.First(spe => spe.Id == 32).Name = "Core Sector Owned Systems with support Base Popularity (%)";
        SideParamTableEntries.First(spe => spe.Id == 33).Name = "Core Sector Owned Systems with support Random Extra Popularity (%)";
        SideParamTableEntries.First(spe => spe.Id == 34).Name = "Core Sector Owned Systems without support Base Popularity (%)";
        SideParamTableEntries.First(spe => spe.Id == 35).Name = "Core Sector Owned Systems without support Random Extra Popularity (%)";
    }
}
public class SDPRTB_SideParamTableEntry
{
    public uint Id;
    public uint Field2_1; // 1
    public uint Unknown; // Second Byte sets Entry Group (???)
    public int AllianceMultiPlayerAlliance;
    public int AllianceMultiPlayerEmpire;
    public int AllianceSinglePlayerEasyAlliance;
    public int AllianceSinglePlayerEasyEmpire;
    public int AllianceSinglePlayerMediumAlliance;
    public int AllianceSinglePlayerMediumEmpire;
    public int AllianceSinglePlayerHardAlliance;
    public int AllianceSinglePlayerHardEmpire;
    public int EmpireSinglePlayerEasyAlliance;
    public int EmpireSinglePlayerEasyEmpire;
    public int EmpireSinglePlayerMediumAlliance;
    public int EmpireSinglePlayerMediumEmpire;
    public int EmpireSinglePlayerHardAlliance;
    public int EmpireSinglePlayerHardEmpire;
    public int EmpireMultiPlayerAlliance;
    public int EmpireMultiPlayerEmpire;
    [Ignore]
    public string Name = "Unknown Side Param Table Entry";
}
