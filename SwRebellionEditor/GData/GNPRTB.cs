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
        GeneralParamTableEntries.First(spe => spe.Id ==   1).Name = "Space Travel Time: base (%, lower=faster)"; // ParamId=1

        GeneralParamTableEntries.First(spe => spe.Id ==   2).Name = ""; // ParamId=512
        GeneralParamTableEntries.First(spe => spe.Id ==   3).Name = ""; // ParamId=513
        GeneralParamTableEntries.First(spe => spe.Id ==   4).Name = ""; // ParamId=514
        GeneralParamTableEntries.First(spe => spe.Id ==   5).Name = ""; // ParamId=515
        GeneralParamTableEntries.First(spe => spe.Id ==   6).Name = ""; // ParamId=516
        GeneralParamTableEntries.First(spe => spe.Id ==   7).Name = ""; // ParamId=517
        
        GeneralParamTableEntries.First(spe => spe.Id ==   8).Name = ""; // ParamId=1536
        GeneralParamTableEntries.First(spe => spe.Id ==   9).Name = ""; // ParamId=1537
        GeneralParamTableEntries.First(spe => spe.Id ==  10).Name = ""; // ParamId=1538
        GeneralParamTableEntries.First(spe => spe.Id ==  11).Name = ""; // ParamId=1539
        GeneralParamTableEntries.First(spe => spe.Id ==  12).Name = ""; // ParamId=1540
        GeneralParamTableEntries.First(spe => spe.Id ==  13).Name = ""; // ParamId=1541
        GeneralParamTableEntries.First(spe => spe.Id ==  14).Name = ""; // ParamId=1542
        
        GeneralParamTableEntries.First(spe => spe.Id ==  15).Name = ""; // ParamId=2048
        GeneralParamTableEntries.First(spe => spe.Id ==  16).Name = ""; // ParamId=2049
        GeneralParamTableEntries.First(spe => spe.Id ==  17).Name = ""; // ParamId=2050
        GeneralParamTableEntries.First(spe => spe.Id ==  18).Name = ""; // ParamId=2051
        GeneralParamTableEntries.First(spe => spe.Id ==  19).Name = ""; // ParamId=2052
        GeneralParamTableEntries.First(spe => spe.Id ==  20).Name = ""; // ParamId=2053

        GeneralParamTableEntries.First(spe => spe.Id ==  21).Name = ""; // ParamId=2560
        GeneralParamTableEntries.First(spe => spe.Id ==  22).Name = ""; // ParamId=2561
        GeneralParamTableEntries.First(spe => spe.Id ==  23).Name = ""; // ParamId=2562
        GeneralParamTableEntries.First(spe => spe.Id ==  24).Name = ""; // ParamId=2563
        GeneralParamTableEntries.First(spe => spe.Id ==  25).Name = "Injured character:  Combat points recovered by day"; // ParamId=2564
        GeneralParamTableEntries.First(spe => spe.Id ==  26).Name = ""; // ParamId=2565
        GeneralParamTableEntries.First(spe => spe.Id ==  27).Name = ""; // ParamId=2566
        GeneralParamTableEntries.First(spe => spe.Id ==  28).Name = ""; // ParamId=2567
        GeneralParamTableEntries.First(spe => spe.Id ==  29).Name = ""; // ParamId=2568
        GeneralParamTableEntries.First(spe => spe.Id ==  30).Name = ""; // ParamId=2569
        GeneralParamTableEntries.First(spe => spe.Id ==  31).Name = ""; // ParamId=2570
        GeneralParamTableEntries.First(spe => spe.Id ==  32).Name = ""; // ParamId=2571
        GeneralParamTableEntries.First(spe => spe.Id ==  33).Name = ""; // ParamId=2572
        GeneralParamTableEntries.First(spe => spe.Id ==  34).Name = ""; // ParamId=2573
        GeneralParamTableEntries.First(spe => spe.Id ==  35).Name = ""; // ParamId=2574
        GeneralParamTableEntries.First(spe => spe.Id ==  36).Name = ""; // ParamId=2575
        GeneralParamTableEntries.First(spe => spe.Id ==  37).Name = ""; // ParamId=2576
        GeneralParamTableEntries.First(spe => spe.Id ==  38).Name = ""; // ParamId=2577
        GeneralParamTableEntries.First(spe => spe.Id ==  39).Name = ""; // ParamId=2578
        GeneralParamTableEntries.First(spe => spe.Id ==  40).Name = ""; // ParamId=2579
        GeneralParamTableEntries.First(spe => spe.Id ==  41).Name = ""; // ParamId=2580
        GeneralParamTableEntries.First(spe => spe.Id ==  42).Name = ""; // ParamId=2581
        GeneralParamTableEntries.First(spe => spe.Id ==  43).Name = ""; // ParamId=2582
        GeneralParamTableEntries.First(spe => spe.Id ==  44).Name = ""; // ParamId=2583
        GeneralParamTableEntries.First(spe => spe.Id ==  45).Name = ""; // ParamId=2584
        GeneralParamTableEntries.First(spe => spe.Id ==  46).Name = ""; // ParamId=2585

        GeneralParamTableEntries.First(spe => spe.Id ==  47).Name = ""; // ParamId=2592
        GeneralParamTableEntries.First(spe => spe.Id ==  48).Name = ""; // ParamId=2593

        GeneralParamTableEntries.First(spe => spe.Id ==  49).Name = ""; // ParamId=3072
        GeneralParamTableEntries.First(spe => spe.Id ==  50).Name = ""; // ParamId=3073
        GeneralParamTableEntries.First(spe => spe.Id ==  51).Name = ""; // ParamId=3074
        GeneralParamTableEntries.First(spe => spe.Id ==  52).Name = ""; // ParamId=3075
        GeneralParamTableEntries.First(spe => spe.Id ==  53).Name = "Seat of Power (Emperor on Coruscant): Leadership percentage bonus"; // ParamId=3076
        GeneralParamTableEntries.First(spe => spe.Id ==  54).Name = ""; // ParamId=3077
        GeneralParamTableEntries.First(spe => spe.Id ==  55).Name = ""; // ParamId=3078
        GeneralParamTableEntries.First(spe => spe.Id ==  56).Name = ""; // ParamId=3079
        GeneralParamTableEntries.First(spe => spe.Id ==  57).Name = ""; // ParamId=3080
        GeneralParamTableEntries.First(spe => spe.Id ==  58).Name = ""; // ParamId=3081
        GeneralParamTableEntries.First(spe => spe.Id ==  59).Name = ""; // ParamId=3082
        GeneralParamTableEntries.First(spe => spe.Id ==  60).Name = "Space Travel Time: Han Solo (%, lower=faster)"; // ParamId=3083
        GeneralParamTableEntries.First(spe => spe.Id ==  61).Name = ""; // ParamId=3084
        GeneralParamTableEntries.First(spe => spe.Id ==  62).Name = ""; // ParamId=3085
        GeneralParamTableEntries.First(spe => spe.Id ==  63).Name = ""; // ParamId=3086
        GeneralParamTableEntries.First(spe => spe.Id ==  64).Name = ""; // ParamId=3087

        GeneralParamTableEntries.First(spe => spe.Id ==  65).Name = ""; // ParamId=3584
        GeneralParamTableEntries.First(spe => spe.Id ==  66).Name = ""; // ParamId=3585
        GeneralParamTableEntries.First(spe => spe.Id ==  67).Name = ""; // ParamId=3586
        GeneralParamTableEntries.First(spe => spe.Id ==  68).Name = ""; // ParamId=3587
        GeneralParamTableEntries.First(spe => spe.Id ==  69).Name = "Decoy % stat debuff"; // ParamId=3588
        GeneralParamTableEntries.First(spe => spe.Id ==  70).Name = ""; // ParamId=3589

        GeneralParamTableEntries.First(spe => spe.Id ==  71).Name = ""; // ParamId=4096

        GeneralParamTableEntries.First(spe => spe.Id ==  72).Name = "Damaged Squadron: Days to recover 1 Fighter if Shipyard"; // ParamId=4608
        GeneralParamTableEntries.First(spe => spe.Id ==  73).Name = "Damaged Squadron:Days to recover 1 Fighter if no Shipyard"; // ParamId=4609

        GeneralParamTableEntries.First(spe => spe.Id ==  74).Name = "Space Travel Time: distance divisor (higher=faster)"; // ParamId=5120
        GeneralParamTableEntries.First(spe => spe.Id ==  75).Name = ""; // ParamId=5121
        GeneralParamTableEntries.First(spe => spe.Id ==  76).Name = ""; // ParamId=5122
        GeneralParamTableEntries.First(spe => spe.Id ==  77).Name = ""; // ParamId=5123
        GeneralParamTableEntries.First(spe => spe.Id ==  78).Name = ""; // ParamId=5124
        GeneralParamTableEntries.First(spe => spe.Id ==  79).Name = ""; // ParamId=5125
        GeneralParamTableEntries.First(spe => spe.Id ==  80).Name = ""; // ParamId=5126
        GeneralParamTableEntries.First(spe => spe.Id ==  81).Name = ""; // ParamId=5127
        GeneralParamTableEntries.First(spe => spe.Id ==  82).Name = ""; // ParamId=5128
        GeneralParamTableEntries.First(spe => spe.Id ==  83).Name = "Fleet 1 location probability: Yavin vs HQ"; // ParamId=5129
        GeneralParamTableEntries.First(spe => spe.Id ==  84).Name = "CMUNYVTB.DAT - Alliance Yavin 4: min army n° to deploy"; // ParamId=5130
        GeneralParamTableEntries.First(spe => spe.Id ==  85).Name = "CMUNYVTB.DAT - Alliance Yavin 4: max army n° to deploy"; // ParamId=5131
        GeneralParamTableEntries.First(spe => spe.Id ==  86).Name = "CMUNHQTB.DAT - Alliance HQ: min army n° to deploy"; // ParamId=5132
        GeneralParamTableEntries.First(spe => spe.Id ==  87).Name = "CMUNHQTB.DAT - Alliance HQ: max army n° to deploy"; // ParamId=5133
        GeneralParamTableEntries.First(spe => spe.Id ==  88).Name = "CMUNCRTB.DAT - Empire Coruscant: min army n° to deploy"; // ParamId=5134
        GeneralParamTableEntries.First(spe => spe.Id ==  89).Name = "CMUNCRTB.DAT - Empire Coruscant: max army n° to deploy"; // ParamId=5135
        GeneralParamTableEntries.First(spe => spe.Id ==  90).Name = "CMUNAFTB.DAT - Alliance HQ or Yavin 4 Fleet: min capital ship n° to deploy"; // ParamId=5136
        GeneralParamTableEntries.First(spe => spe.Id ==  91).Name = "CMUNAFTB.DAT - Alliance HQ or Yavin 4 Fleet: max capital ship n° to deploy"; // ParamId=5137
        GeneralParamTableEntries.First(spe => spe.Id ==  92).Name = "CMUNEFTB.DAT - Empire Coruscant Fleet: min capital ship n° to deploy"; // ParamId=5138
        GeneralParamTableEntries.First(spe => spe.Id ==  93).Name = "CMUNEFTB.DAT - Empire Coruscant Fleet: max capital ship n° to deploy"; // ParamId=5139
        GeneralParamTableEntries.First(spe => spe.Id ==  94).Name = "FACLHQTB.DAT - Alliance HQ: min facilities group n° to deploy"; // ParamId=5140
        GeneralParamTableEntries.First(spe => spe.Id ==  95).Name = "FACLHQTB.DAT - Alliance HQ: max facilities group n° to deploy"; // ParamId=5141
        GeneralParamTableEntries.First(spe => spe.Id ==  96).Name = "FACLCRTB.DAT - Empire Coruscant: min facilities group n° to deploy"; // ParamId=5142
        GeneralParamTableEntries.First(spe => spe.Id ==  97).Name = "FACLCRTB.DAT - Empire Coruscant: max facilities group n° to deploy"; // ParamId=5143

        GeneralParamTableEntries.First(spe => spe.Id ==  98).Name = ""; // ParamId=5152

        GeneralParamTableEntries.First(spe => spe.Id ==  99).Name = ""; // ParamId=6144
        GeneralParamTableEntries.First(spe => spe.Id == 100).Name = ""; // ParamId=6145
        GeneralParamTableEntries.First(spe => spe.Id == 101).Name = "Luke goes to Dagobah: base (days)"; // ParamId=6146
        GeneralParamTableEntries.First(spe => spe.Id == 102).Name = "Luke goes to Dagobah: random extra (days)"; // ParamId=6147
        GeneralParamTableEntries.First(spe => spe.Id == 103).Name = "Bounty Hunter Frequency: base (days)"; // ParamId=6148
        GeneralParamTableEntries.First(spe => spe.Id == 104).Name = "Bounty Hunter Frequency: random extra (days)"; // ParamId=6149
        GeneralParamTableEntries.First(spe => spe.Id == 105).Name = ""; // ParamId=6150
        GeneralParamTableEntries.First(spe => spe.Id == 106).Name = ""; // ParamId=6151
        GeneralParamTableEntries.First(spe => spe.Id == 107).Name = ""; // ParamId=6152
        GeneralParamTableEntries.First(spe => spe.Id == 108).Name = ""; // ParamId=6153
        GeneralParamTableEntries.First(spe => spe.Id == 109).Name = ""; // ParamId=6154
        GeneralParamTableEntries.First(spe => spe.Id == 110).Name = ""; // ParamId=6155
        GeneralParamTableEntries.First(spe => spe.Id == 111).Name = "Diplomacy points gain after Diplomacy success"; // ParamId=6156
        GeneralParamTableEntries.First(spe => spe.Id == 112).Name = "Espionage points gain after Espionage success"; // ParamId=6157
        GeneralParamTableEntries.First(spe => spe.Id == 113).Name = ""; // ParamId=6158
        GeneralParamTableEntries.First(spe => spe.Id == 114).Name = "Leadership points gain after Recruitment success"; // ParamId=6159
        GeneralParamTableEntries.First(spe => spe.Id == 115).Name = "Leadership points gain after Incite Uprising success"; // ParamId=6160
        GeneralParamTableEntries.First(spe => spe.Id == 116).Name = "Leadership points gain after Subdue Uprising success"; // ParamId=6161
        GeneralParamTableEntries.First(spe => spe.Id == 117).Name = ""; // ParamId=6162
        GeneralParamTableEntries.First(spe => spe.Id == 118).Name = "Combat points gain after Abduction success"; // ParamId=6163
        GeneralParamTableEntries.First(spe => spe.Id == 119).Name = ""; // ParamId=6164
        GeneralParamTableEntries.First(spe => spe.Id == 120).Name = "Espionage points gain after Sabotage success"; // ParamId=6165
        GeneralParamTableEntries.First(spe => spe.Id == 121).Name = "Combat points gain after Sabotage success"; // ParamId=6166
        GeneralParamTableEntries.First(spe => spe.Id == 122).Name = ""; // ParamId=6167
        GeneralParamTableEntries.First(spe => spe.Id == 123).Name = ""; // ParamId=6168
        GeneralParamTableEntries.First(spe => spe.Id == 124).Name = ""; // ParamId=6169
        GeneralParamTableEntries.First(spe => spe.Id == 125).Name = ""; // ParamId=6170
        GeneralParamTableEntries.First(spe => spe.Id == 126).Name = ""; // ParamId=6171
        GeneralParamTableEntries.First(spe => spe.Id == 127).Name = ""; // ParamId=6172
        GeneralParamTableEntries.First(spe => spe.Id == 128).Name = ""; // ParamId=6173
        GeneralParamTableEntries.First(spe => spe.Id == 129).Name = ""; // ParamId=6174
        GeneralParamTableEntries.First(spe => spe.Id == 130).Name = ""; // ParamId=6175
        GeneralParamTableEntries.First(spe => spe.Id == 131).Name = ""; // ParamId=6176
        GeneralParamTableEntries.First(spe => spe.Id == 132).Name = ""; // ParamId=6177
        GeneralParamTableEntries.First(spe => spe.Id == 133).Name = ""; // ParamId=6178
        GeneralParamTableEntries.First(spe => spe.Id == 134).Name = ""; // ParamId=6179
        GeneralParamTableEntries.First(spe => spe.Id == 135).Name = ""; // ParamId=6180
        GeneralParamTableEntries.First(spe => spe.Id == 136).Name = ""; // ParamId=6181

        GeneralParamTableEntries.First(spe => spe.Id == 137).Name = "Popularity % gain after diplomacy success on occupied system: Base Value"; // ParamId=6183
        GeneralParamTableEntries.First(spe => spe.Id == 138).Name = "Popularity % gain after diplomacy success on occupied system: Random Extra"; // ParamId=6184
        GeneralParamTableEntries.First(spe => spe.Id == 139).Name = "Popularity % gain after diplomacy success on neutral system: Base Value"; // ParamId=6185
        GeneralParamTableEntries.First(spe => spe.Id == 140).Name = "Popularity % gain after diplomacy success on neutral system: Random Extra"; // ParamId=6186
        GeneralParamTableEntries.First(spe => spe.Id == 141).Name = ""; // ParamId=6187
        GeneralParamTableEntries.First(spe => spe.Id == 142).Name = ""; // ParamId=6188
        GeneralParamTableEntries.First(spe => spe.Id == 143).Name = ""; // ParamId=6189
        GeneralParamTableEntries.First(spe => spe.Id == 144).Name = ""; // ParamId=6190

        GeneralParamTableEntries.First(spe => spe.Id == 145).Name = "Maintenance Shortfall Frequency (days)"; // ParamId=7168
        GeneralParamTableEntries.First(spe => spe.Id == 146).Name = "Related to default (non mission) research rate (lower=faster) - To test"; // ParamId=7169
        GeneralParamTableEntries.First(spe => spe.Id == 147).Name = "Related to default (non mission) research rate (lower=faster) - To test"; // ParamId=7170

        GeneralParamTableEntries.First(spe => spe.Id == 148).Name = ""; // ParamId=7680
        GeneralParamTableEntries.First(spe => spe.Id == 149).Name = ""; // ParamId=7681
        GeneralParamTableEntries.First(spe => spe.Id == 150).Name = ""; // ParamId=7682
        GeneralParamTableEntries.First(spe => spe.Id == 151).Name = "Required Shield Generators to Prevent Assault"; // ParamId=7683
        GeneralParamTableEntries.First(spe => spe.Id == 152).Name = ""; // ParamId=7684
        GeneralParamTableEntries.First(spe => spe.Id == 153).Name = ""; // ParamId=7685
        GeneralParamTableEntries.First(spe => spe.Id == 154).Name = ""; // ParamId=7686
        GeneralParamTableEntries.First(spe => spe.Id == 155).Name = ""; // ParamId=7687
        GeneralParamTableEntries.First(spe => spe.Id == 156).Name = ""; // ParamId=7688
        GeneralParamTableEntries.First(spe => spe.Id == 157).Name = ""; // ParamId=7689
        GeneralParamTableEntries.First(spe => spe.Id == 158).Name = ""; // ParamId=7690
        GeneralParamTableEntries.First(spe => spe.Id == 159).Name = ""; // ParamId=7691
        GeneralParamTableEntries.First(spe => spe.Id == 160).Name = ""; // ParamId=7692
        GeneralParamTableEntries.First(spe => spe.Id == 161).Name = ""; // ParamId=7693
        GeneralParamTableEntries.First(spe => spe.Id == 162).Name = ""; // ParamId=7694
        GeneralParamTableEntries.First(spe => spe.Id == 163).Name = ""; // ParamId=7695
        GeneralParamTableEntries.First(spe => spe.Id == 164).Name = ""; // ParamId=7696
        GeneralParamTableEntries.First(spe => spe.Id == 165).Name = ""; // ParamId=7697
        GeneralParamTableEntries.First(spe => spe.Id == 166).Name = ""; // ParamId=7698
        GeneralParamTableEntries.First(spe => spe.Id == 167).Name = ""; // ParamId=7699
        GeneralParamTableEntries.First(spe => spe.Id == 168).Name = ""; // ParamId=7700
        GeneralParamTableEntries.First(spe => spe.Id == 169).Name = ""; // ParamId=7701
        GeneralParamTableEntries.First(spe => spe.Id == 170).Name = ""; // ParamId=7702
        GeneralParamTableEntries.First(spe => spe.Id == 171).Name = "Informants Info Frequency: Base Value (lower=faster)"; // ParamId=7703
        GeneralParamTableEntries.First(spe => spe.Id == 172).Name = "Informants Info Frequency: Random Extra (lower=faster)"; // ParamId=7704
        GeneralParamTableEntries.First(spe => spe.Id == 173).Name = ""; // ParamId=7705
        GeneralParamTableEntries.First(spe => spe.Id == 174).Name = ""; // ParamId=7706
        GeneralParamTableEntries.First(spe => spe.Id == 175).Name = "Uprising: Base Value"; // ParamId=7707
        GeneralParamTableEntries.First(spe => spe.Id == 176).Name = "Uprising: Random Extra"; // ParamId=7708
        GeneralParamTableEntries.First(spe => spe.Id == 177).Name = "Informants: Success Event Index in table increment to random(8)"; // ParamId=7709
        GeneralParamTableEntries.First(spe => spe.Id == 178).Name = "Informants: Success if random(8) is above"; // ParamId=7710
        GeneralParamTableEntries.First(spe => spe.Id == 179).Name = "Systems: Mines slots (Raw Materials) min value allowed"; // ParamId=7711
        GeneralParamTableEntries.First(spe => spe.Id == 180).Name = "Systems: Mines slots (Raw Materials) max value allowed"; // ParamId=7712
        GeneralParamTableEntries.First(spe => spe.Id == 181).Name = "Systems: Buildings slots (Energy) min value allowed"; // ParamId=7713
        GeneralParamTableEntries.First(spe => spe.Id == 182).Name = "Systems: Buildings slots (Energy) max value allowed"; // ParamId=7714
        GeneralParamTableEntries.First(spe => spe.Id == 183).Name = "Natural Disaster: Raw material lost & Energy slots lost"; // ParamId=7715
        GeneralParamTableEntries.First(spe => spe.Id == 184).Name = "Natural Disaster: % to lose a Facility (applied to each)"; // ParamId=7716
        GeneralParamTableEntries.First(spe => spe.Id == 185).Name = "Natural Disaster: Frequency base (days)"; // ParamId=7717
        GeneralParamTableEntries.First(spe => spe.Id == 186).Name = "Natural Disaster: Frequency random extra (days)"; // ParamId=7718
        GeneralParamTableEntries.First(spe => spe.Id == 187).Name = "Resource Event: Frequency base (days)"; // ParamId=7719
        GeneralParamTableEntries.First(spe => spe.Id == 188).Name = "Resource Event: Frequency random extra (days)"; // ParamId=7720
        GeneralParamTableEntries.First(spe => spe.Id == 189).Name = "Core Systems: Buildings slots (Energy) base amount"; // ParamId=7721
        GeneralParamTableEntries.First(spe => spe.Id == 190).Name = "Core Systems: Buildings slots (Energy) random extra amount"; // ParamId=7722
        GeneralParamTableEntries.First(spe => spe.Id == 191).Name = "Core Systems: Mines slots (Raw Materials) base amount"; // ParamId=7723
        GeneralParamTableEntries.First(spe => spe.Id == 192).Name = "Core Systems: Mines slots (Raw Materials) random extra amount"; // ParamId=7724
        GeneralParamTableEntries.First(spe => spe.Id == 193).Name = "Rim Systems: Buildings slots (Energy) base amount"; // ParamId=7725
        GeneralParamTableEntries.First(spe => spe.Id == 194).Name = "Rim Systems: Buildings slots (Energy) random extra amount 1"; // ParamId=7726
        GeneralParamTableEntries.First(spe => spe.Id == 195).Name = "Rim Systems: Buildings slots (Energy) random extra amount 2"; // ParamId=7727
        GeneralParamTableEntries.First(spe => spe.Id == 196).Name = "Rim Systems: Mines slots (Raw Materials) base amount"; // ParamId=7728
        GeneralParamTableEntries.First(spe => spe.Id == 197).Name = "Rim Systems: Mines slots (Raw Materials) random extra amount"; // ParamId=7729
        GeneralParamTableEntries.First(spe => spe.Id == 198).Name = "Core Systems: Populated systems percentage"; // ParamId=7730
        GeneralParamTableEntries.First(spe => spe.Id == 199).Name = "Rim Systems: Populated systems percentage"; // ParamId=7731
        GeneralParamTableEntries.First(spe => spe.Id == 200).Name = ""; // ParamId=7732
        GeneralParamTableEntries.First(spe => spe.Id == 201).Name = ""; // ParamId=7733
        GeneralParamTableEntries.First(spe => spe.Id == 202).Name = ""; // ParamId=7734
        GeneralParamTableEntries.First(spe => spe.Id == 203).Name = ""; // ParamId=7735
        GeneralParamTableEntries.First(spe => spe.Id == 204).Name = ""; // ParamId=7736
        GeneralParamTableEntries.First(spe => spe.Id == 205).Name = ""; // ParamId=7737

        GeneralParamTableEntries.First(spe => spe.Id == 206).Name = "Populary % required on system to join side"; // ParamId=7760
        GeneralParamTableEntries.First(spe => spe.Id == 207).Name = "Garrison Requirement: Uprising threshold"; // ParamId=7761
        GeneralParamTableEntries.First(spe => spe.Id == 208).Name = "Garrison Requirement: Troop's order contribution"; // ParamId=7762
        GeneralParamTableEntries.First(spe => spe.Id == 209).Name = ""; // ParamId=7763
        GeneralParamTableEntries.First(spe => spe.Id == 210).Name = "??? Core Sector Neutral System support Base Popularity (%)"; // ParamId=7764
        GeneralParamTableEntries.First(spe => spe.Id == 211).Name = ""; // ParamId=7765
        GeneralParamTableEntries.First(spe => spe.Id == 212).Name = "Core System non mine slots multiplicator to generate facilities"; // ParamId=7766
        GeneralParamTableEntries.First(spe => spe.Id == 213).Name = ""; // ParamId=7767

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
