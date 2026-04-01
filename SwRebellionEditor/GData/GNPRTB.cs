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
        GeneralParamTableEntries.First(spe => spe.Id ==   1).Name = "Space Travel Time: Base (%, lower=faster)"; // ParamId=1

        GeneralParamTableEntries.First(spe => spe.Id ==   2).Name = "Defense Facility Response Chance: Divisor"; // ParamId=512
        GeneralParamTableEntries.First(spe => spe.Id ==   3).Name = "Troop Kill Contest: Commander Rating Divisor"; // ParamId=513
        GeneralParamTableEntries.First(spe => spe.Id ==   4).Name = "Troop Kill Contest: Random Width"; // ParamId=514
        GeneralParamTableEntries.First(spe => spe.Id ==   5).Name = "Troop Kill Contest Defender: Win Max Score"; // ParamId=515
        GeneralParamTableEntries.First(spe => spe.Id ==   6).Name = "Troop Kill Contest Attacker: Win Min Score"; // ParamId=516
        GeneralParamTableEntries.First(spe => spe.Id ==   7).Name = "Planetary Defense: Repeat Trial Success Chance"; // ParamId=517
        
        GeneralParamTableEntries.First(spe => spe.Id ==   8).Name = "Capital Ship KDY_LNR Contribution: Officer Divisor"; // ParamId=1536
        GeneralParamTableEntries.First(spe => spe.Id ==   9).Name = "Capital Ship Assault: Officer Divisor"; // ParamId=1537
        GeneralParamTableEntries.First(spe => spe.Id ==  10).Name = "Capital Strike Permission Threshold: Min"; // ParamId=1538
        GeneralParamTableEntries.First(spe => spe.Id ==  11).Name = "Capital Strike Permission Threshold: Max"; // ParamId=1539
        GeneralParamTableEntries.First(spe => spe.Id ==  12).Name = "Plain System Energy Strike Resistance"; // ParamId=1540
        GeneralParamTableEntries.First(spe => spe.Id ==  13).Name = "Allocated System Energy Strike Resistance"; // ParamId=1541
        GeneralParamTableEntries.First(spe => spe.Id ==  14).Name = "Capital Planning: Minor Character Injury Chance"; // ParamId=1542
        
        GeneralParamTableEntries.First(spe => spe.Id ==  15).Name = "Capital Ship Production: Progress Scale"; // ParamId=2048
        GeneralParamTableEntries.First(spe => spe.Id ==  16).Name = "Capital Ship Production: Progress Gate Random Width"; // ParamId=2049
        GeneralParamTableEntries.First(spe => spe.Id ==  17).Name = "Capital Ship Production: Progress Gate Threshold"; // ParamId=2050
        GeneralParamTableEntries.First(spe => spe.Id ==  18).Name = "Capital Ship Production: Progress Outcome Selector Random Width"; // ParamId=2051
        GeneralParamTableEntries.First(spe => spe.Id ==  19).Name = "Capital Ship Fast Repair: Delay (ticks)"; // ParamId=2052
        GeneralParamTableEntries.First(spe => spe.Id ==  20).Name = "Capital Ship Normal Repair: Delay (ticks)"; // ParamId=2053

        GeneralParamTableEntries.First(spe => spe.Id ==  21).Name = "Fast Heal: Force Rank Threshold"; // ParamId=2560
        GeneralParamTableEntries.First(spe => spe.Id ==  22).Name = "Character Fast Heal: Recovery Delay (ticks)"; // ParamId=2561
        GeneralParamTableEntries.First(spe => spe.Id ==  23).Name = "Character Normal Heal: Recovery Delay (ticks)"; // ParamId=2562
        GeneralParamTableEntries.First(spe => spe.Id ==  24).Name = "Character Fast Heal: Injury Reduction Per Tick"; // ParamId=2563
        GeneralParamTableEntries.First(spe => spe.Id ==  25).Name = "Injured character: Combat points recovered by day"; // ParamId=2564
        GeneralParamTableEntries.First(spe => spe.Id ==  26).Name = "Abduction Injury: Chance Floor"; // ParamId=2565
        GeneralParamTableEntries.First(spe => spe.Id ==  27).Name = "Abduction Injury: Flat Bonus"; // ParamId=2566
        GeneralParamTableEntries.First(spe => spe.Id ==  28).Name = "Abduction Injury: Random Bonus Width"; // ParamId=2567
        GeneralParamTableEntries.First(spe => spe.Id ==  29).Name = "Secondary Injury: Chance Floor"; // ParamId=2568
        GeneralParamTableEntries.First(spe => spe.Id ==  30).Name = "Secondary Injury: Flat Bonus"; // ParamId=2569
        GeneralParamTableEntries.First(spe => spe.Id ==  31).Name = "Secondary Injury: Random Bonus Width"; // ParamId=2570
        GeneralParamTableEntries.First(spe => spe.Id ==  32).Name = "Character Comparison Fallback Injury: Chance Floor"; // ParamId=2571
        GeneralParamTableEntries.First(spe => spe.Id ==  33).Name = "Character Comparison Fallback Injury: Base Amount"; // ParamId=2572
        GeneralParamTableEntries.First(spe => spe.Id ==  34).Name = "Character Comparison Fallback Injury: Random Spread"; // ParamId=2573
        GeneralParamTableEntries.First(spe => spe.Id ==  35).Name = "Assassination Post-Hit Injury: Gate and Random Width"; // ParamId=2574
        GeneralParamTableEntries.First(spe => spe.Id ==  36).Name = "Assassination Post-Hit Injury: Base Amount"; // ParamId=2575
        GeneralParamTableEntries.First(spe => spe.Id ==  37).Name = "Assassination Post-Hit Injury: Random Spread"; // ParamId=2576
        GeneralParamTableEntries.First(spe => spe.Id ==  38).Name = "Minor Personnel Post-Injury Followup Chance"; // ParamId=2577
        GeneralParamTableEntries.First(spe => spe.Id ==  39).Name = "Encounter Opponent Injury: Combat Bonus"; // ParamId=2578
        GeneralParamTableEntries.First(spe => spe.Id ==  40).Name = "Low Force Status Threshold"; // ParamId=2579
        GeneralParamTableEntries.First(spe => spe.Id ==  41).Name = "Discovering Force User Threshold"; // ParamId=2580
        GeneralParamTableEntries.First(spe => spe.Id ==  42).Name = "Force Qualified Character Threshold"; // ParamId=2581
        GeneralParamTableEntries.First(spe => spe.Id ==  43).Name = "Force User Discovery Scan: Base Delay (ticks)"; // ParamId=2582
        GeneralParamTableEntries.First(spe => spe.Id ==  44).Name = "Force User Discovery Scan: Random Spread (ticks)"; // ParamId=2583
        GeneralParamTableEntries.First(spe => spe.Id ==  45).Name = "Escape Attempt Timer: Base Delay (ticks)"; // ParamId=2584
        GeneralParamTableEntries.First(spe => spe.Id ==  46).Name = "Escape Attempt Timer: Random Spread (ticks)"; // ParamId=2585

        GeneralParamTableEntries.First(spe => spe.Id ==  47).Name = "Loyalty Shift: Random Spread"; // ParamId=2592
        GeneralParamTableEntries.First(spe => spe.Id ==  48).Name = "Loyalty Shift: Base Amount"; // ParamId=2593

        GeneralParamTableEntries.First(spe => spe.Id ==  49).Name = "Luke vs Vader: Force Gain Scale (%)"; // ParamId=3072
        GeneralParamTableEntries.First(spe => spe.Id ==  50).Name = "Luke vs Emperor: Force Gain Scale (%)"; // ParamId=3073
        GeneralParamTableEntries.First(spe => spe.Id ==  51).Name = "Leia vs Vader: Force Gain Scale (%)"; // ParamId=3074
        GeneralParamTableEntries.First(spe => spe.Id ==  52).Name = "Leia vs Emperor: Force Gain Scale (%)"; // ParamId=3075
        GeneralParamTableEntries.First(spe => spe.Id ==  53).Name = "Seat of Power (Emperor on Coruscant): Leadership Bonus (%)"; // ParamId=3076
        GeneralParamTableEntries.First(spe => spe.Id ==  54).Name = "Luke Dagobah Completion: Injury Force Rank Ceiling"; // ParamId=3077
        GeneralParamTableEntries.First(spe => spe.Id ==  55).Name = "Luke Knows Heritage: Force Rank Threshold"; // ParamId=3078
        GeneralParamTableEntries.First(spe => spe.Id ==  56).Name = "Luke Dagobah Completion: Injury Base Amount"; // ParamId=3079
        GeneralParamTableEntries.First(spe => spe.Id ==  57).Name = "Luke Dagobah Completion: Injury Random Spread"; // ParamId=3080
        GeneralParamTableEntries.First(spe => spe.Id ==  58).Name = "Luke Ordinary Mission: Force Reward"; // ParamId=3081
        GeneralParamTableEntries.First(spe => spe.Id ==  59).Name = "Leia Ordinary Mission: Force Reward"; // ParamId=3082
        GeneralParamTableEntries.First(spe => spe.Id ==  60).Name = "Space Travel Time: Han Solo (%, lower=faster)"; // ParamId=3083
        GeneralParamTableEntries.First(spe => spe.Id ==  61).Name = "Luke vs Vader: Force Gain Min"; // ParamId=3084
        GeneralParamTableEntries.First(spe => spe.Id ==  62).Name = "Luke vs Emperor: Force Gain Min"; // ParamId=3085
        GeneralParamTableEntries.First(spe => spe.Id ==  63).Name = "Leia vs Vader: Force Gain Min (After Heritage)"; // ParamId=3086
        GeneralParamTableEntries.First(spe => spe.Id ==  64).Name = "Leia vs Emperor: Force Gain Min (After Heritage)"; // ParamId=3087

        GeneralParamTableEntries.First(spe => spe.Id ==  65).Name = "Hostile Foil Score Bias"; // ParamId=3584
        GeneralParamTableEntries.First(spe => spe.Id ==  66).Name = "Local Side Force User Selector: Low Rank Threshold"; // ParamId=3585
        GeneralParamTableEntries.First(spe => spe.Id ==  67).Name = "Cross Side Force User Selector: High Rank Threshold"; // ParamId=3586
        GeneralParamTableEntries.First(spe => spe.Id ==  68).Name = "Force User Selector: Encounter Probability Offset"; // ParamId=3587
        GeneralParamTableEntries.First(spe => spe.Id ==  69).Name = "Decoy % Stat Debuff"; // ParamId=3588
        GeneralParamTableEntries.First(spe => spe.Id ==  70).Name = "Defending Personnel: Espionage Penalty Scale (%)"; // ParamId=3589

        GeneralParamTableEntries.First(spe => spe.Id ==  71).Name = "Processing Facility Point Present: Scale (%)"; // ParamId=4096

        GeneralParamTableEntries.First(spe => spe.Id ==  72).Name = "Damaged Squadron: Days to recover 1 Fighter if Shipyard"; // ParamId=4608
        GeneralParamTableEntries.First(spe => spe.Id ==  73).Name = "Damaged Squadron:Days to recover 1 Fighter if no Shipyard"; // ParamId=4609

        GeneralParamTableEntries.First(spe => spe.Id ==  74).Name = "Space Travel Time: Distance Divisor (higher=faster)"; // ParamId=5120
        GeneralParamTableEntries.First(spe => spe.Id ==  75).Name = "Direct System Support Shift Amount"; // ParamId=5121
        GeneralParamTableEntries.First(spe => spe.Id ==  76).Name = "Direct System Support Threshold"; // ParamId=5122
        GeneralParamTableEntries.First(spe => spe.Id ==  77).Name = "Sector Scan Support Shift Amount"; // ParamId=5123
        GeneralParamTableEntries.First(spe => spe.Id ==  78).Name = "Sector Scan Support Threshold"; // ParamId=5124
        GeneralParamTableEntries.First(spe => spe.Id ==  79).Name = "Alliance Low Support: Startup Support Shift Magnitude"; // ParamId=5125
        GeneralParamTableEntries.First(spe => spe.Id ==  80).Name = "Alliance Low Support: Startup Support Threshold"; // ParamId=5126
        GeneralParamTableEntries.First(spe => spe.Id ==  81).Name = "HQ Triggered Startup Support Shift Magnitude"; // ParamId=5127
        GeneralParamTableEntries.First(spe => spe.Id ==  82).Name = "HQ Triggered Startup Support Threshold"; // ParamId=5128
        GeneralParamTableEntries.First(spe => spe.Id ==  83).Name = "Fleet 1 location probability: Yavin vs HQ"; // ParamId=5129
        GeneralParamTableEntries.First(spe => spe.Id ==  84).Name = "CMUNYVTB.DAT - Alliance Yavin 4: Min army n° to deploy"; // ParamId=5130
        GeneralParamTableEntries.First(spe => spe.Id ==  85).Name = "CMUNYVTB.DAT - Alliance Yavin 4: Max army n° to deploy"; // ParamId=5131
        GeneralParamTableEntries.First(spe => spe.Id ==  86).Name = "CMUNHQTB.DAT - Alliance HQ: Min army n° to deploy"; // ParamId=5132
        GeneralParamTableEntries.First(spe => spe.Id ==  87).Name = "CMUNHQTB.DAT - Alliance HQ: Max army n° to deploy"; // ParamId=5133
        GeneralParamTableEntries.First(spe => spe.Id ==  88).Name = "CMUNCRTB.DAT - Empire Coruscant: Min army n° to deploy"; // ParamId=5134
        GeneralParamTableEntries.First(spe => spe.Id ==  89).Name = "CMUNCRTB.DAT - Empire Coruscant: Max army n° to deploy"; // ParamId=5135
        GeneralParamTableEntries.First(spe => spe.Id ==  90).Name = "CMUNAFTB.DAT - Alliance HQ or Yavin 4 Fleet: Min capital ship n° to deploy"; // ParamId=5136
        GeneralParamTableEntries.First(spe => spe.Id ==  91).Name = "CMUNAFTB.DAT - Alliance HQ or Yavin 4 Fleet: Max capital ship n° to deploy"; // ParamId=5137
        GeneralParamTableEntries.First(spe => spe.Id ==  92).Name = "CMUNEFTB.DAT - Empire Coruscant Fleet: Min capital ship n° to deploy"; // ParamId=5138
        GeneralParamTableEntries.First(spe => spe.Id ==  93).Name = "CMUNEFTB.DAT - Empire Coruscant Fleet: Max capital ship n° to deploy"; // ParamId=5139
        GeneralParamTableEntries.First(spe => spe.Id ==  94).Name = "FACLHQTB.DAT - Alliance HQ: Min facilities group n° to deploy"; // ParamId=5140
        GeneralParamTableEntries.First(spe => spe.Id ==  95).Name = "FACLHQTB.DAT - Alliance HQ: Max facilities group n° to deploy"; // ParamId=5141
        GeneralParamTableEntries.First(spe => spe.Id ==  96).Name = "FACLCRTB.DAT - Empire Coruscant: Min facilities group n° to deploy"; // ParamId=5142
        GeneralParamTableEntries.First(spe => spe.Id ==  97).Name = "FACLCRTB.DAT - Empire Coruscant: Max facilities group n° to deploy"; // ParamId=5143

        GeneralParamTableEntries.First(spe => spe.Id ==  98).Name = "Startup Balance: Payload Divisor"; // ParamId=5152

        GeneralParamTableEntries.First(spe => spe.Id ==  99).Name = "Uprising Mission: Leadership Divisor"; // ParamId=6144
        GeneralParamTableEntries.First(spe => spe.Id == 100).Name = "Incite Uprising: Fixed Bias"; // ParamId=6145
        GeneralParamTableEntries.First(spe => spe.Id == 101).Name = "Luke goes to Dagobah: Base (days)"; // ParamId=6146
        GeneralParamTableEntries.First(spe => spe.Id == 102).Name = "Luke goes to Dagobah: Max Random Extra (days)"; // ParamId=6147
        GeneralParamTableEntries.First(spe => spe.Id == 103).Name = "Bounty Hunter Frequency: Base (days)"; // ParamId=6148
        GeneralParamTableEntries.First(spe => spe.Id == 104).Name = "Bounty Hunter Frequency: Max Random Extra (days)"; // ParamId=6149
        GeneralParamTableEntries.First(spe => spe.Id == 105).Name = "Mission Manager: Bounty Hunter Han Intervention Chance"; // ParamId=6150
        GeneralParamTableEntries.First(spe => spe.Id == 106).Name = "Story Selector: Luke Low Rank Fallback Threshold"; // ParamId=6151
        GeneralParamTableEntries.First(spe => spe.Id == 107).Name = "Luke Low Rank Story Fallback: Injury Base Amount"; // ParamId=6152
        GeneralParamTableEntries.First(spe => spe.Id == 108).Name = "Luke Low Rank Story Fallback: Injury Random Spread"; // ParamId=6153
        GeneralParamTableEntries.First(spe => spe.Id == 109).Name = "Palace Resolution: Espionage Divisor"; // ParamId=6154
        GeneralParamTableEntries.First(spe => spe.Id == 110).Name = "Palace Resolution: Combat Divisor"; // ParamId=6155
        GeneralParamTableEntries.First(spe => spe.Id == 111).Name = "Diplomacy success: Diplomacy points gain"; // ParamId=6156
        GeneralParamTableEntries.First(spe => spe.Id == 112).Name = "Espionage success: Espionage points gain"; // ParamId=6157
        GeneralParamTableEntries.First(spe => spe.Id == 113).Name = "Research success: Research points gain"; // ParamId=6158
        GeneralParamTableEntries.First(spe => spe.Id == 114).Name = "Recruitment success: Leadership points gain"; // ParamId=6159
        GeneralParamTableEntries.First(spe => spe.Id == 115).Name = "Incite Uprising success: Leadership points gain"; // ParamId=6160
        GeneralParamTableEntries.First(spe => spe.Id == 116).Name = "Subdue Uprising success: Leadership points gain"; // ParamId=6161
        GeneralParamTableEntries.First(spe => spe.Id == 117).Name = "Rescue success: Combat points gain"; // ParamId=6162
        GeneralParamTableEntries.First(spe => spe.Id == 118).Name = "Abduction success: Combat points gain"; // ParamId=6163
        GeneralParamTableEntries.First(spe => spe.Id == 119).Name = "Assassination success: Combat points gain"; // ParamId=6164
        GeneralParamTableEntries.First(spe => spe.Id == 120).Name = "Sabotage success: Espionage points gain"; // ParamId=6165
        GeneralParamTableEntries.First(spe => spe.Id == 121).Name = "Sabotage success: Combat points gain"; // ParamId=6166
        GeneralParamTableEntries.First(spe => spe.Id == 122).Name = "Death Star Sabotage Success: Espionage Points Gain"; // ParamId=6167
        GeneralParamTableEntries.First(spe => spe.Id == 123).Name = "Death Star Sabotage Success: Combat Points Gain"; // ParamId=6168
        GeneralParamTableEntries.First(spe => spe.Id == 124).Name = "Palace Success: Espionage Points Gain"; // ParamId=6169
        GeneralParamTableEntries.First(spe => spe.Id == 125).Name = "Palace Success: Combat Points Gain"; // ParamId=6170
        GeneralParamTableEntries.First(spe => spe.Id == 126).Name = "Research Success: Research Points Base Amount"; // ParamId=6171
        GeneralParamTableEntries.First(spe => spe.Id == 127).Name = "Research Success: Research Points Random Spread"; // ParamId=6172
        GeneralParamTableEntries.First(spe => spe.Id == 128).Name = "Jedi Training success: Jedi level gain: Max Random Extra"; // ParamId=6173
        GeneralParamTableEntries.First(spe => spe.Id == 129).Name = "Dagobah Completed: Force Rank Bonus Scale (%)"; // ParamId=6174
        GeneralParamTableEntries.First(spe => spe.Id == 130).Name = "Dagobah Pre-Completed: Force Rank Bonus Divisor"; // ParamId=6175
        GeneralParamTableEntries.First(spe => spe.Id == 131).Name = "Espionage Extra Reveal System Count: Floor"; // ParamId=6176
        GeneralParamTableEntries.First(spe => spe.Id == 132).Name = "Espionage Extra Reveal System Count: Random Spread"; // ParamId=6177
        GeneralParamTableEntries.First(spe => spe.Id == 133).Name = "Espionage Extra Reveal System Coruscant Count: Floor"; // ParamId=6178
        GeneralParamTableEntries.First(spe => spe.Id == 134).Name = "Espionage Extra Reveal System Coruscant Count: Random Spread"; // ParamId=6179
        GeneralParamTableEntries.First(spe => spe.Id == 135).Name = "Espionage Extra Reveal System Alliance HQ Count: Floor"; // ParamId=6180
        GeneralParamTableEntries.First(spe => spe.Id == 136).Name = "Espionage Extra Reveal System Alliance HQ Count: Random Spread"; // ParamId=6181

        GeneralParamTableEntries.First(spe => spe.Id == 137).Name = "Diplomacy Success on occupied System Popularity gain: Base (%)"; // ParamId=6183
        GeneralParamTableEntries.First(spe => spe.Id == 138).Name = "Diplomacy Success on occupied System Popularity gain: Max Random Extra (%)"; // ParamId=6184
        GeneralParamTableEntries.First(spe => spe.Id == 139).Name = "Diplomacy Success on neutral System Popularity gain: Base (%)"; // ParamId=6185
        GeneralParamTableEntries.First(spe => spe.Id == 140).Name = "Diplomacy Success on neutral System Popularity gain: Max Random Extra (%)"; // ParamId=6186
        GeneralParamTableEntries.First(spe => spe.Id == 141).Name = "Subdue Uprising Matching Side Support Shift: Floor"; // ParamId=6187
        GeneralParamTableEntries.First(spe => spe.Id == 142).Name = "Subdue Uprising Matching Side Support Shift: Random Spread"; // ParamId=6188
        GeneralParamTableEntries.First(spe => spe.Id == 143).Name = "Subdue Uprising Neutral Target Support Shift: Floor"; // ParamId=6189
        GeneralParamTableEntries.First(spe => spe.Id == 144).Name = "Subdue Uprising Neutral Target Support Shift: Random Spread"; // ParamId=6190

        GeneralParamTableEntries.First(spe => spe.Id == 145).Name = "Maintenance Shortfall Frequency (days)"; // ParamId=7168
        GeneralParamTableEntries.First(spe => spe.Id == 146).Name = "Related to default (non mission) research rate (lower=faster) - To test"; // ParamId=7169
        GeneralParamTableEntries.First(spe => spe.Id == 147).Name = "Related to default (non mission) research rate (lower=faster) - To test"; // ParamId=7170

        GeneralParamTableEntries.First(spe => spe.Id == 148).Name = "Core Strong Support Threshold"; // ParamId=7680
        GeneralParamTableEntries.First(spe => spe.Id == 149).Name = "Core Weak Support Threshold"; // ParamId=7681
        GeneralParamTableEntries.First(spe => spe.Id == 150).Name = "Uprising Active Garrison Multiplier"; // ParamId=7682
        GeneralParamTableEntries.First(spe => spe.Id == 151).Name = "Required Shield Generators to Prevent Assault"; // ParamId=7683
        GeneralParamTableEntries.First(spe => spe.Id == 152).Name = "No KDY Blockade: Capital Ship Production Penalty"; // ParamId=7684
        GeneralParamTableEntries.First(spe => spe.Id == 153).Name = "No KDY Blockade: Fighter Production Penalty"; // ParamId=7685
        GeneralParamTableEntries.First(spe => spe.Id == 154).Name = "Low Support: Hostile Fleet Shift Penalty"; // ParamId=7686
        GeneralParamTableEntries.First(spe => spe.Id == 155).Name = "Low Support: Hostile Fighter Shift Penalty"; // ParamId=7687
        GeneralParamTableEntries.First(spe => spe.Id == 156).Name = "Low Support: Adjusted Hostile Troop Shift Penalty"; // ParamId=7688
        GeneralParamTableEntries.First(spe => spe.Id == 157).Name = "Smuggling Support Shift"; // ParamId=7689
        GeneralParamTableEntries.First(spe => spe.Id == 158).Name = "Smuggling Support Threshold"; // ParamId=7690
        GeneralParamTableEntries.First(spe => spe.Id == 159).Name = "Empire Troop Warning Support Shift"; // ParamId=7691
        GeneralParamTableEntries.First(spe => spe.Id == 160).Name = "Smuggling Followup Timer: Base Delay"; // ParamId=7692
        GeneralParamTableEntries.First(spe => spe.Id == 161).Name = "Blockade Support Shift (Matching Side)"; // ParamId=7693
        GeneralParamTableEntries.First(spe => spe.Id == 162).Name = "Blockade Support Timer: Base Delay (Matching Side)"; // ParamId=7694
        GeneralParamTableEntries.First(spe => spe.Id == 163).Name = "Blockade Support Shift (Mismatched Side)"; // ParamId=7695
        GeneralParamTableEntries.First(spe => spe.Id == 164).Name = "Blockade Support Timer: Base Delay (Mismatched Side)"; // ParamId=7696
        GeneralParamTableEntries.First(spe => spe.Id == 165).Name = "Active Uprising Controller Support Shift"; // ParamId=7697
        GeneralParamTableEntries.First(spe => spe.Id == 166).Name = "Active Uprising Support Drift Timer: Base Delay"; // ParamId=7698
        GeneralParamTableEntries.First(spe => spe.Id == 167).Name = "Uprising Clear Timer: Base Delay"; // ParamId=7699
        GeneralParamTableEntries.First(spe => spe.Id == 168).Name = "Uprising Clear Timer: Random Spread"; // ParamId=7700
        GeneralParamTableEntries.First(spe => spe.Id == 169).Name = "Uprising Incident Timer: Base Delay"; // ParamId=7701
        GeneralParamTableEntries.First(spe => spe.Id == 170).Name = "Uprising Incident Timer: Random Spread"; // ParamId=7702
        GeneralParamTableEntries.First(spe => spe.Id == 171).Name = "Informants Info Frequency: Base (lower=faster)"; // ParamId=7703
        GeneralParamTableEntries.First(spe => spe.Id == 172).Name = "Informants Info Frequency: Max Random Extra (lower=faster)"; // ParamId=7704
        GeneralParamTableEntries.First(spe => spe.Id == 173).Name = "Orbital Strike Selected Side Support Shift"; // ParamId=7705
        GeneralParamTableEntries.First(spe => spe.Id == 174).Name = "Alliance HQ System Support Shift Magnitude"; // ParamId=7706
        GeneralParamTableEntries.First(spe => spe.Id == 175).Name = "Uprising: Base"; // ParamId=7707
        GeneralParamTableEntries.First(spe => spe.Id == 176).Name = "Uprising: Max Random Extra"; // ParamId=7708
        GeneralParamTableEntries.First(spe => spe.Id == 177).Name = "Informants: Success Event Index in table increment to random(8)"; // ParamId=7709
        GeneralParamTableEntries.First(spe => spe.Id == 178).Name = "Informants: Success if random(8) is above"; // ParamId=7710
        GeneralParamTableEntries.First(spe => spe.Id == 179).Name = "Systems Mines slots (Raw Materials): Min"; // ParamId=7711
        GeneralParamTableEntries.First(spe => spe.Id == 180).Name = "Systems Mines slots (Raw Materials): Max"; // ParamId=7712
        GeneralParamTableEntries.First(spe => spe.Id == 181).Name = "Systems Buildings slots (Energy): Min"; // ParamId=7713
        GeneralParamTableEntries.First(spe => spe.Id == 182).Name = "Systems Buildings slots (Energy): Max"; // ParamId=7714
        GeneralParamTableEntries.First(spe => spe.Id == 183).Name = "Natural Disaster: Raw material lost & Energy slots lost"; // ParamId=7715
        GeneralParamTableEntries.First(spe => spe.Id == 184).Name = "Natural Disaster: % to lose a Facility (applied to each)"; // ParamId=7716
        GeneralParamTableEntries.First(spe => spe.Id == 185).Name = "Natural Disaster Frequency: Base (days)"; // ParamId=7717
        GeneralParamTableEntries.First(spe => spe.Id == 186).Name = "Natural Disaster Frequency: Max Random Extra (days)"; // ParamId=7718
        GeneralParamTableEntries.First(spe => spe.Id == 187).Name = "Resource Event Frequency: Base (days)"; // ParamId=7719
        GeneralParamTableEntries.First(spe => spe.Id == 188).Name = "Resource Event Frequency: Max Random Extra (days)"; // ParamId=7720
        GeneralParamTableEntries.First(spe => spe.Id == 189).Name = "Core Systems Buildings slots (Energy): Base"; // ParamId=7721
        GeneralParamTableEntries.First(spe => spe.Id == 190).Name = "Core Systems Buildings slots (Energy): Max Random Extra"; // ParamId=7722
        GeneralParamTableEntries.First(spe => spe.Id == 191).Name = "Core Systems Mines slots (Raw Materials): Base"; // ParamId=7723
        GeneralParamTableEntries.First(spe => spe.Id == 192).Name = "Core Systems Mines slots (Raw Materials): Max Random Extra"; // ParamId=7724
        GeneralParamTableEntries.First(spe => spe.Id == 193).Name = "Rim Systems Buildings slots (Energy): Base"; // ParamId=7725
        GeneralParamTableEntries.First(spe => spe.Id == 194).Name = "Rim Systems Buildings slots (Energy): Max Random Extra 1"; // ParamId=7726
        GeneralParamTableEntries.First(spe => spe.Id == 195).Name = "Rim Systems Buildings slots (Energy): Max Random Extra 2"; // ParamId=7727
        GeneralParamTableEntries.First(spe => spe.Id == 196).Name = "Rim Systems Mines slots (Raw Materials): Base"; // ParamId=7728
        GeneralParamTableEntries.First(spe => spe.Id == 197).Name = "Rim Systems Mines slots (Raw Materials): Max Random Extra"; // ParamId=7729
        GeneralParamTableEntries.First(spe => spe.Id == 198).Name = "Core Systems: Populated systems (%)"; // ParamId=7730
        GeneralParamTableEntries.First(spe => spe.Id == 199).Name = "Rim Systems: Populated systems (%)"; // ParamId=7731
        GeneralParamTableEntries.First(spe => spe.Id == 200).Name = "Low Support Branch: Max Controller Support"; // ParamId=7732
        GeneralParamTableEntries.First(spe => spe.Id == 201).Name = "Low Support Upper Band: Base Shift"; // ParamId=7733
        GeneralParamTableEntries.First(spe => spe.Id == 202).Name = "Low Support Middle Band: Max Support"; // ParamId=7734
        GeneralParamTableEntries.First(spe => spe.Id == 203).Name = "Low Support Middle Band: Base Shift"; // ParamId=7735
        GeneralParamTableEntries.First(spe => spe.Id == 204).Name = "Low Support Lower Band: Max Support"; // ParamId=7736
        GeneralParamTableEntries.First(spe => spe.Id == 205).Name = "Low Support Lower Band: Base Shift"; // ParamId=7737

        GeneralParamTableEntries.First(spe => spe.Id == 206).Name = "Popularity required on System to Join Side (%)"; // ParamId=7760
        GeneralParamTableEntries.First(spe => spe.Id == 207).Name = "Garrison Requirement: Uprising Threshold"; // ParamId=7761
        GeneralParamTableEntries.First(spe => spe.Id == 208).Name = "Garrison Requirement: Troop's Order Contribution"; // ParamId=7762
        GeneralParamTableEntries.First(spe => spe.Id == 209).Name = "Raw and Refined Materials collection rate (lower=faster)"; // ParamId=7763
        GeneralParamTableEntries.First(spe => spe.Id == 210).Name = "??? Core Sector Neutral System support Initial Popularity (%)"; // ParamId=7764
        GeneralParamTableEntries.First(spe => spe.Id == 211).Name = "Rim Systems: Neutral system support at day 0. Random range=[50%*(1-X%),50%*(1+X%)]"; // ParamId=7765
        GeneralParamTableEntries.First(spe => spe.Id == 212).Name = "Core Systems: Each free slot gets: FreeSlots*X% chances to generate a mine"; // ParamId=7766
        GeneralParamTableEntries.First(spe => spe.Id == 213).Name = "Rim Systems: Each free slot gets: FreeSlots*X% chances to generate a mine"; // ParamId=7767

        foreach (var param in GeneralParamTableEntries)
        {
            if (string.IsNullOrEmpty(param.Name))
            {
                param.Name = $"Unknown General Param Table Entry {param.Id}";
            }
        }
    }
}
public class GNPRTB_GeneralParamTableEntry
{
    public uint Id;
    public uint Field2_1; // 1
    public uint ParameterId;
    public int Development;
    public int AllianceSinglePlayerEasy;
    public int AllianceSinglePlayerMedium;
    public int AllianceSinglePlayerHard;
    public int EmpireSinglePlayerEasy;
    public int EmpireSinglePlayerMedium;
    public int EmpireSinglePlayerHard;
    public int MultiPlayer;
    [Ignore]
    public string Name = "Unknown General Param Table Entry";
}
