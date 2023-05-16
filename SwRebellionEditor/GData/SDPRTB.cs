﻿namespace SwRebellionEditor;

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
    public SDPRTB_SideParamTableEntry MinorCharactersInSmallGalaxy { get { return SideParamTableEntries.First(spe => spe.Id == 4); } }
    [Ignore]
    public SDPRTB_SideParamTableEntry MinorCharactersInMediumGalaxy { get { return SideParamTableEntries.First(spe => spe.Id == 5); } }
    [Ignore]
    public SDPRTB_SideParamTableEntry MinorCharactersInLargeGalaxy { get { return SideParamTableEntries.First(spe => spe.Id == 6); } }
    [Ignore]
    public SDPRTB_SideParamTableEntry SideLotteryCoreSystems1_ProbaForEachSide { get { return SideParamTableEntries.First(spe => spe.Id == 30); } }
    [Ignore]
    public SDPRTB_SideParamTableEntry SideLotteryCoreSystems2_ProbaForEachSide { get { return SideParamTableEntries.First(spe => spe.Id == 31); } }
    [Ignore]
    public SDPRTB_SideParamTableEntry SideLotteryCoreSystems1_PopularitySupportBase { get { return SideParamTableEntries.First(spe => spe.Id == 32); } }
    [Ignore]
    public SDPRTB_SideParamTableEntry SideLotteryCoreSystems1_PopularitySupportVar { get { return SideParamTableEntries.First(spe => spe.Id == 33); } }
    [Ignore]
    public SDPRTB_SideParamTableEntry SideLotteryCoreSystems2_PopularitySupportBase { get { return SideParamTableEntries.First(spe => spe.Id == 34); } }
    [Ignore]
    public SDPRTB_SideParamTableEntry SideLotteryCoreSystems2_PopularitySupportVar { get { return SideParamTableEntries.First(spe => spe.Id == 35); } }

    public override void PostLoad()
    {
        SideParamTableEntries.First(spe => spe.Id == 4).Name = "Starting Minor Characters in Small Galaxy = 7 + ?";
        SideParamTableEntries.First(spe => spe.Id == 5).Name = "Starting Minor Characters in Medium Galaxy = 7 + ?";
        SideParamTableEntries.First(spe => spe.Id == 6).Name = "Starting Minor Characters in Large Galaxy = 7 + ?";
        SideParamTableEntries.First(spe => spe.Id == 30).Name = "Core Systems 1 - % Probability for each side";
        SideParamTableEntries.First(spe => spe.Id == 31).Name = "Core Systems 2 - % Probability for each side";
        SideParamTableEntries.First(spe => spe.Id == 32).Name = "Core Systems 1 - % Popular Support Base";
        SideParamTableEntries.First(spe => spe.Id == 33).Name = "Core Systems 1 - % Popular Support Var";
        SideParamTableEntries.First(spe => spe.Id == 34).Name = "Core Systems 2 - % Popular Support Base";
        SideParamTableEntries.First(spe => spe.Id == 35).Name = "Core Systems 2 - % Popular Support Var";
    }
}
public class SDPRTB_SideParamTableEntry
{
    public uint Id;
    public uint Field2_1; // 1
    public uint Unknown; // Second Byte sets Entry Group (???)
    public uint AllianceMultiPlayerAlliance;
    public uint AllianceMultiPlayerEmpire;
    public uint AllianceSinglePlayerEasyAlliance;
    public uint AllianceSinglePlayerEasyEmpire;
    public uint AllianceSinglePlayerMediumAlliance;
    public uint AllianceSinglePlayerMediumEmpire;
    public uint AllianceSinglePlayerHardAlliance;
    public uint AllianceSinglePlayerHardEmpire;
    public uint EmpireSinglePlayerEasyAlliance;
    public uint EmpireSinglePlayerEasyEmpire;
    public uint EmpireSinglePlayerMediumAlliance;
    public uint EmpireSinglePlayerMediumEmpire;
    public uint EmpireSinglePlayerHardAlliance;
    public uint EmpireSinglePlayerHardEmpire;
    public uint EmpireMultiPlayerAlliance;
    public uint EmpireMultiPlayerEmpire;
    [Ignore]
    public string Name = "Unknown Side Param Table Entry";
}
