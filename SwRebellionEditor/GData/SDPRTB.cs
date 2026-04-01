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
    public SDPRTB_SideParamTableEntry SmallGalaxyDay0_RandomUnits => SideParamTableEntries.First(spe => spe.Id == 21);
    [Ignore]
    public SDPRTB_SideParamTableEntry MediumGalaxyDay0_RandomUnits => SideParamTableEntries.First(spe => spe.Id == 22);
    [Ignore]
    public SDPRTB_SideParamTableEntry LargeGalaxyDay0_RandomUnits => SideParamTableEntries.First(spe => spe.Id == 23);
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
        SideParamTableEntries.First(spe => spe.Id ==  1).Name = "Loyalty Drift Divisor"; // ParamId=2560
        SideParamTableEntries.First(spe => spe.Id ==  2).Name = "Incoming Side Loyalty Shift: Random Spread"; // ParamId=2561
        SideParamTableEntries.First(spe => spe.Id ==  3).Name = "Incoming Side Loyalty Shift: Base Amount"; // ParamId=2562

        SideParamTableEntries.First(spe => spe.Id ==  4).Name = "Startup Minor Characters in Standard Galaxy = 7 + ?"; // ParamId=5120
        SideParamTableEntries.First(spe => spe.Id ==  5).Name = "Startup Minor Characters in Large Galaxy = 7 + ?"; // ParamId=5121
        SideParamTableEntries.First(spe => spe.Id ==  6).Name = "Startup Minor Characters in Huge Galaxy = 7 + ?"; // ParamId=5122

        SideParamTableEntries.First(spe => spe.Id ==  7).Name = "Local Direct System Support Shift Amount"; // ParamId=5128
        SideParamTableEntries.First(spe => spe.Id ==  8).Name = "Local Direct System Support Threshold"; // ParamId=5129
        SideParamTableEntries.First(spe => spe.Id ==  9).Name = "Local Sector Scan Support Shift Amount"; // ParamId=5130
        SideParamTableEntries.First(spe => spe.Id == 10).Name = "Local Sector Scan Support Threshold"; // ParamId=5131

        SideParamTableEntries.First(spe => spe.Id == 11).Name = "Startup Balance: Counterpart Support Threshold"; // ParamId=5136
        SideParamTableEntries.First(spe => spe.Id == 12).Name = "Startup Balance: Payload Magnitude Cap"; // ParamId=5137
        SideParamTableEntries.First(spe => spe.Id == 13).Name = "Startup Balance: Leading Branch Flat Base"; // ParamId=5138
        SideParamTableEntries.First(spe => spe.Id == 14).Name = "Startup Balance: Leading Branch Gap Scale (%)"; // ParamId=5139
        SideParamTableEntries.First(spe => spe.Id == 15).Name = "Startup Balance: Trailing Branch Flat Base"; // ParamId=5140
        SideParamTableEntries.First(spe => spe.Id == 16).Name = "Startup Balance: Trailing Branch Gap Scale (%)"; // ParamId=5141

        SideParamTableEntries.First(spe => spe.Id == 17).Name = "Peaceful Control Change: Payload Offset"; // ParamId=5152
        SideParamTableEntries.First(spe => spe.Id == 18).Name = "Peaceful Control Change: Event Row"; // ParamId=5153
        SideParamTableEntries.First(spe => spe.Id == 19).Name = "Alternate Control Change: Payload Offset"; // ParamId=5154
        SideParamTableEntries.First(spe => spe.Id == 20).Name = "Alternate Control Change: Event Row"; // ParamId=5155

        SideParamTableEntries.First(spe => spe.Id == 21).Name = "% of Maintenance to deploy Random Units at Day 0 (Standard Galaxy)"; // ParamId=5168
        SideParamTableEntries.First(spe => spe.Id == 22).Name = "% of Maintenance to deploy Random Units at Day 0 (Large Galaxy)"; // ParamId=5169
        SideParamTableEntries.First(spe => spe.Id == 23).Name = "% of Maintenance to deploy Random Units at Day 0 (Huge Galaxy)"; // ParamId=5170

        SideParamTableEntries.First(spe => spe.Id == 24).Name = "Troop Arrival Control Change: Payload"; // ParamId=5184
        SideParamTableEntries.First(spe => spe.Id == 25).Name = "Troop Arrival Control Change: Event Row"; // ParamId=5185
        SideParamTableEntries.First(spe => spe.Id == 26).Name = "Troop Withdrawal Control Change: Payload"; // ParamId=5186
        SideParamTableEntries.First(spe => spe.Id == 27).Name = "Troop Withdrawal Control Change: Event Row"; // ParamId=5187
        SideParamTableEntries.First(spe => spe.Id == 28).Name = "Contested Troop Presence Control Change: Payload"; // ParamId=5188
        SideParamTableEntries.First(spe => spe.Id == 29).Name = "Contested Troop Presence Control Change: Event Row"; // ParamId=5189

        SideParamTableEntries.First(spe => spe.Id == 30).Name = "Core Sector Owned Systems with support"; // ParamId=7680
        SideParamTableEntries.First(spe => spe.Id == 31).Name = "Core Sector Owned Systems without support"; // ParamId=7681
        SideParamTableEntries.First(spe => spe.Id == 32).Name = "Core Sector Owned Systems with support Popularity: Base (%)"; // ParamId=7682
        SideParamTableEntries.First(spe => spe.Id == 33).Name = "Core Sector Owned Systems with support Popularity: Max Random Extra (%)"; // ParamId=7683
        SideParamTableEntries.First(spe => spe.Id == 34).Name = "Core Sector Owned Systems without support Popularity: Base (%)"; // ParamId=7684
        SideParamTableEntries.First(spe => spe.Id == 35).Name = "Core Sector Owned Systems without support Popularity: Max Random Extra (%)"; // ParamId=7685

        foreach (var param in SideParamTableEntries)
        {
            if (string.IsNullOrEmpty(param.Name))
            {
                param.Name = $"Unknown Side Param Table Entry {param.Id}";
            }
        }

    }
}
public class SDPRTB_SideParamTableEntry
{
    public uint Id;
    public uint Field2_1; // 1
    public uint ParameterId;
    public int DevelopmentAlliance;
    public int DevelopmentEmpire;
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
    public int MultiPlayerAlliance;
    public int MultiPlayerEmpire;
    [Ignore]
    public string Name = "Unknown Side Param Table Entry";
}
