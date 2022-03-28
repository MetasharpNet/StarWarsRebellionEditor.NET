using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwRebellionEditor
{
    // BEWARE : 0x12345678 in C# code, is stored in little endian in files as "78 56 34 12" if you look at the file with an hexadecimal editor
    public enum Identifiers : uint
    {
        // families
        SystemFacilityByte            =       0x0E, // In Hexadecimal Editor: 0E          - Decimal:            14
        TroopByte                     =       0x10, // In Hexadecimal Editor: 10          - Decimal:            16
        CapitalShipByte               =       0x14, // In Hexadecimal Editor: 14          - Decimal:            20
        DeathStarByte                 =       0x18, // In Hexadecimal Editor: 18          - Decimal:            24
        FighterByte                   =       0x1C, // In Hexadecimal Editor: 1C          - Decimal:            28
        AllianceFacilityByte          =       0x20, // In Hexadecimal Editor: 20          - Decimal:            32
        DefenseFacilityByte           =       0x22, // In Hexadecimal Editor: 22          - Decimal:            34
        ManufacturingFacilityByte     =       0x28, // In Hexadecimal Editor: 28          - Decimal:            40
        ProductionFacilityByte        =       0x2C, // In Hexadecimal Editor: 2C          - Decimal:            44
        MajorCharactersByte           =       0x30, // In Hexadecimal Editor: 30          - Decimal:            48
        MinorCharactersByte           =       0x38, // In Hexadecimal Editor: 38          - Decimal:            56
        SectorByte                    =       0x80, // In Hexadecimal Editor: 80          - Decimal:           128
        SystemByte                    =       0x90, // In Hexadecimal Editor: 90          - Decimal:           144
        // troops
        AllianceFleetRegiment         = 0x10000001, // In Hexadecimal Editor: 01 00 00 10 - Decimal:   268 435 457
        AllianceArmyRegiment          = 0x10000002, // In Hexadecimal Editor: 02 00 00 10 - Decimal:   268 435 458
        SullustanRegiment             = 0x10000003, // In Hexadecimal Editor: 03 00 00 10 - Decimal:   268 435 459
        WookieRegiment                = 0x10000004, // In Hexadecimal Editor: 04 00 00 10 - Decimal:   268 435 460
        MonCalamariRegiment           = 0x10000005, // In Hexadecimal Editor: 05 00 00 10 - Decimal:   268 435 461
        StormtrooperRegiment          = 0x10000006, // In Hexadecimal Editor: 06 00 00 10 - Decimal:   268 435 462
        ImperialFleetRegiment         = 0x10000007, // In Hexadecimal Editor: 07 00 00 10 - Decimal:   268 435 463
        ImperialArmyRegiment          = 0x10000008, // In Hexadecimal Editor: 08 00 00 10 - Decimal:   268 435 464
        WarDroidRegiment              = 0x10000009, // In Hexadecimal Editor: 09 00 00 10 - Decimal:   268 435 465
        DarkTrooperRegiment           = 0x1000000A, // In Hexadecimal Editor: 0A 00 00 10 - Decimal:   268 435 466
        // capital ships
        MonCalamariCruiser            = 0x14000040, // In Hexadecimal Editor: 40 00 00 14 - Decimal:   335 544 384
        BulkCruiser                   = 0x14000041, // In Hexadecimal Editor: 41 00 00 14 - Decimal:   335 544 385
        AssaultFrigate                = 0x14000042, // In Hexadecimal Editor: 42 00 00 14 - Decimal:   335 544 386
        NebulonBFrigate               = 0x14000043, // In Hexadecimal Editor: 43 00 00 14 - Decimal:   335 544 387
        AllianceEscortCarrier         = 0x14000044, // In Hexadecimal Editor: 44 00 00 14 - Decimal:   335 544 388
        CorellianCorvette             = 0x14000045, // In Hexadecimal Editor: 45 00 00 14 - Decimal:   335 544 389
        MediumTransport               = 0x14000046, // In Hexadecimal Editor: 46 00 00 14 - Decimal:   335 544 390
        BulkTransport                 = 0x14000047, // In Hexadecimal Editor: 47 00 00 14 - Decimal:   335 544 391
        CorellianGunship              = 0x14000048, // In Hexadecimal Editor: 48 00 00 14 - Decimal:   335 544 392
        AllianceDreadnaught           = 0x14000049, // In Hexadecimal Editor: 49 00 00 14 - Decimal:   335 544 393
        CC7700Frigate                 = 0x1400004A, // In Hexadecimal Editor: 4A 00 00 14 - Decimal:   335 544 394
        BulwarkBattlecruiser          = 0x1400004B, // In Hexadecimal Editor: 4B 00 00 14 - Decimal:   335 544 395
        LiberatorCruiser              = 0x1400004C, // In Hexadecimal Editor: 4C 00 00 14 - Decimal:   335 544 396
        CC9600Frigate                 = 0x1400004D, // In Hexadecimal Editor: 4D 00 00 14 - Decimal:   335 544 397
        DauntlessCruiser              = 0x1400004E, // In Hexadecimal Editor: 4E 00 00 14 - Decimal:   335 544 398
        StrikeCruiser                 = 0x14000080, // In Hexadecimal Editor: 80 00 00 14 - Decimal:   335 544 448
        LancerFrigate                 = 0x14000081, // In Hexadecimal Editor: 81 00 00 14 - Decimal:   335 544 449
        InterdictorCruiser            = 0x14000082, // In Hexadecimal Editor: 82 00 00 14 - Decimal:   335 544 450
        CarrackLightCruiser           = 0x14000083, // In Hexadecimal Editor: 83 00 00 14 - Decimal:   335 544 451
        VictoryDestroyer              = 0x14000084, // In Hexadecimal Editor: 84 00 00 14 - Decimal:   335 544 452
        ImperialStarDestroyer         = 0x14000085, // In Hexadecimal Editor: 85 00 00 14 - Decimal:   335 544 453
        SuperStarDestroyer            = 0x14000086, // In Hexadecimal Editor: 86 00 00 14 - Decimal:   335 544 454
        AssaultTransport              = 0x14000087, // In Hexadecimal Editor: 87 00 00 14 - Decimal:   335 544 455
        Galleon                       = 0x14000089, // In Hexadecimal Editor: 89 00 00 14 - Decimal:   335 544 457
        VictoryIIStarDestroyer        = 0x1400008A, // In Hexadecimal Editor: 8A 00 00 14 - Decimal:   335 544 458
        ImperialIIStarDestroyer       = 0x1400008B, // In Hexadecimal Editor: 8B 00 00 14 - Decimal:   335 544 459
        StarGalleon                   = 0x1400008C, // In Hexadecimal Editor: 8C 00 00 14 - Decimal:   335 544 460
        ImperialEscortCarrier         = 0x1400008D, // In Hexadecimal Editor: 8D 00 00 14 - Decimal:   335 544 461
        ImperialDreadnaught           = 0x1400008E, // In Hexadecimal Editor: 8E 00 00 14 - Decimal:   335 544 462
        DeathStar                     = 0x18000088, // In Hexadecimal Editor: 88 00 00 18 - Decimal:   402 653 320
        // fighters
        Awing                         = 0x1C000001, // In Hexadecimal Editor: 01 00 00 1C - Decimal:   469 762 049
        Bwing                         = 0x1C000002, // In Hexadecimal Editor: 02 00 00 1C - Decimal:   469 762 050
        Xwing                         = 0x1C000003, // In Hexadecimal Editor: 03 00 00 1C - Decimal:   469 762 051
        Ywing                         = 0x1C000004, // In Hexadecimal Editor: 04 00 00 1C - Decimal:   469 762 052
        TIEFighter                    = 0x1C000005, // In Hexadecimal Editor: 05 00 00 1C - Decimal:   469 762 053
        TIEInterceptor                = 0x1C000006, // In Hexadecimal Editor: 06 00 00 1C - Decimal:   469 762 054
        TIEBomber                     = 0x1C000007, // In Hexadecimal Editor: 07 00 00 1C - Decimal:   469 762 055
        TIEDefender                   = 0x1C000008, // In Hexadecimal Editor: 08 00 00 1C - Decimal:   469 762 056
        // ???
        AllianceHeadquarters          = 0x20000001, // In Hexadecimal Editor: 01 00 00 20 - Decimal:   536 870 913
        KDYv150                       = 0x22000001, // In Hexadecimal Editor: 01 00 00 22 - Decimal:   570 425 345
        // defense facilities
        LNRSeriesI                    = 0x23000002, // In Hexadecimal Editor: 02 00 00 23 - Decimal:   587 202 562
        LNRSeriesII                   = 0x23000005, // In Hexadecimal Editor: 05 00 00 23 - Decimal:   587 202 565
        GenCoreLevelI                 = 0x24000003, // In Hexadecimal Editor: 03 00 00 24 - Decimal:   603 979 779
        GenCoreLevelII                = 0x24000006, // In Hexadecimal Editor: 06 00 00 24 - Decimal:   603 979 782
        DeathStarShield               = 0x25000004, // In Hexadecimal Editor: 04 00 00 25 - Decimal:   620 756 996
        // manufacturing facilities
        Shipyard                      = 0x28000001, // In Hexadecimal Editor: 01 00 00 28 - Decimal:   671 088 641
        AdvancedShipyard              = 0x28000004, // In Hexadecimal Editor: 04 00 00 28 - Decimal:   671 088 644
        TrainingFacility              = 0x29000002, // In Hexadecimal Editor: 02 00 00 29 - Decimal:   687 865 858
        AdvancedTrainingFacility      = 0x29000005, // In Hexadecimal Editor: 05 00 00 29 - Decimal:   687 865 861
        ConstructionYard              = 0x2A000003, // In Hexadecimal Editor: 03 00 00 2A - Decimal:   704 643 075
        AdvancedConstructionYard      = 0x2A000006, // In Hexadecimal Editor: 06 00 00 2A - Decimal:   704 643 078
        RnDManufacturingFacilitiesEnd = 0x2B000000, // In Hexadecimal Editor: 00 00 00 2B - Decimal:   721 420 288
        // production facilities
        Mine                          = 0x2C000001, // In Hexadecimal Editor: 01 00 00 2C - Decimal:   738 197 505
        Refinery                      = 0x2D000002, // In Hexadecimal Editor: 02 00 00 2D - Decimal:   754 974 722
        // major characters
        MonMothma                     = 0x30000240, // In Hexadecimal Editor: 40 02 00 30 - Decimal:   805 306 944
        LeiaOrgana                    = 0x31000241, // In Hexadecimal Editor: 41 02 00 31 - Decimal:   822 084 161
        LukeSkywalker                 = 0x32000242, // In Hexadecimal Editor: 42 02 00 32 - Decimal:   838 861 378
        HanSolo                       = 0x33000243, // In Hexadecimal Editor: 43 02 00 33 - Decimal:   855 638 595
        EmperorPalpatine              = 0x34000280, // In Hexadecimal Editor: 80 02 00 34 - Decimal:   872 415 872
        DarthVader                    = 0x35000281, // In Hexadecimal Editor: 81 02 00 35 - Decimal:   889 193 089
        // minor characters
        Ackbar                        = 0x38000340, // In Hexadecimal Editor: 40 03 00 38 - Decimal:   939 524 928
        WedgeAntilles                 = 0x38000341, // In Hexadecimal Editor: 41 03 00 38 - Decimal:   939 524 929
        LandoCalrissian               = 0x38000342, // In Hexadecimal Editor: 42 03 00 38 - Decimal:   939 524 930
        Chewbacca                     = 0x38000343, // In Hexadecimal Editor: 43 03 00 38 - Decimal:   939 524 931
        JanDodonna                    = 0x38000344, // In Hexadecimal Editor: 44 03 00 38 - Decimal:   939 524 932
        CrixMadine                    = 0x38000345, // In Hexadecimal Editor: 45 03 00 38 - Decimal:   939 524 933
        CarlistRieekan                = 0x38000346, // In Hexadecimal Editor: 46 03 00 38 - Decimal:   939 524 934
        Afyon                         = 0x38000347, // In Hexadecimal Editor: 47 03 00 38 - Decimal:   939 524 935
        Drayson                       = 0x38000348, // In Hexadecimal Editor: 48 03 00 38 - Decimal:   939 524 936
        BorskFeylya                   = 0x38000349, // In Hexadecimal Editor: 49 03 00 38 - Decimal:   939 524 937
        TuraRaftican                  = 0x3800034A, // In Hexadecimal Editor: 4A 03 00 38 - Decimal:   939 524 938
        BrenDerlin                    = 0x3800034B, // In Hexadecimal Editor: 4B 03 00 38 - Decimal:   939 524 939
        GarmBelIblis                  = 0x3800034C, // In Hexadecimal Editor: 4C 03 00 38 - Decimal:   939 524 940
        TalonKarrde                   = 0x3800034D, // In Hexadecimal Editor: 4D 03 00 38 - Decimal:   939 524 941
        Narra                         = 0x3800034E, // In Hexadecimal Editor: 4E 03 00 38 - Decimal:   939 524 942
        HuobaNeva                     = 0x3800034F, // In Hexadecimal Editor: 4F 03 00 38 - Decimal:   939 524 943
        Page                          = 0x38000350, // In Hexadecimal Editor: 50 03 00 38 - Decimal:   939 524 944
        SyubSnunb                     = 0x38000351, // In Hexadecimal Editor: 51 03 00 38 - Decimal:   939 524 945
        AdarTallon                    = 0x38000352, // In Hexadecimal Editor: 52 03 00 38 - Decimal:   939 524 946
        SarinVirgilio                 = 0x38000353, // In Hexadecimal Editor: 53 03 00 38 - Decimal:   939 524 947
        VandenWillard                 = 0x38000354, // In Hexadecimal Editor: 54 03 00 38 - Decimal:   939 524 948
        RogetJiriss                   = 0x38000355, // In Hexadecimal Editor: 55 03 00 38 - Decimal:   939 524 949
        KaiyaAndrimetrum              = 0x38000356, // In Hexadecimal Editor: 56 03 00 38 - Decimal:   939 524 950
        MazerRackus                   = 0x38000357, // In Hexadecimal Editor: 57 03 00 38 - Decimal:   939 524 951
        Orrimaarko                    = 0x38000358, // In Hexadecimal Editor: 58 03 00 38 - Decimal:   939 524 952
        Mawshiye                      = 0x38000359, // In Hexadecimal Editor: 59 03 00 38 - Decimal:   939 524 953
        Jerjerrod                     = 0x38000380, // In Hexadecimal Editor: 80 03 00 38 - Decimal:   939 524 992
        Ozzel                         = 0x38000381, // In Hexadecimal Editor: 81 03 00 38 - Decimal:   939 524 993
        Piett                         = 0x38000382, // In Hexadecimal Editor: 82 03 00 38 - Decimal:   939 524 994
        Veers                         = 0x38000383, // In Hexadecimal Editor: 83 03 00 38 - Decimal:   939 524 995
        Brandei                       = 0x38000384, // In Hexadecimal Editor: 84 03 00 38 - Decimal:   939 524 996
        Covell                        = 0x38000385, // In Hexadecimal Editor: 85 03 00 38 - Decimal:   939 524 997
        Dorja                         = 0x38000386, // In Hexadecimal Editor: 86 03 00 38 - Decimal:   939 524 998
        BinEssada                     = 0x38000387, // In Hexadecimal Editor: 87 03 00 38 - Decimal:   939 524 999
        NilesFerrier                  = 0x38000388, // In Hexadecimal Editor: 88 03 00 38 - Decimal:   939 525 000
        Grammel                       = 0x38000389, // In Hexadecimal Editor: 89 03 00 38 - Decimal:   939 525 001
        Griff                         = 0x3800038A, // In Hexadecimal Editor: 8A 03 00 38 - Decimal:   939 525 002
        Klev                          = 0x3800038B, // In Hexadecimal Editor: 8B 03 00 38 - Decimal:   939 525 003
        Needa                         = 0x3800038C, // In Hexadecimal Editor: 8C 03 00 38 - Decimal:   939 525 004
        BaneNothos                    = 0x3800038D, // In Hexadecimal Editor: 8D 03 00 38 - Decimal:   939 525 005
        Orlok                         = 0x3800038E, // In Hexadecimal Editor: 8E 03 00 38 - Decimal:   939 525 006
        Pellaeon                      = 0x3800038F, // In Hexadecimal Editor: 8F 03 00 38 - Decimal:   939 525 007
        Screed                        = 0x38000390, // In Hexadecimal Editor: 90 03 00 38 - Decimal:   939 525 008
        Thrawn                        = 0x38000391, // In Hexadecimal Editor: 91 03 00 38 - Decimal:   939 525 009
        Zuggs                         = 0x38000392, // In Hexadecimal Editor: 92 03 00 38 - Decimal:   939 525 010
        Daala                         = 0x38000393, // In Hexadecimal Editor: 93 03 00 38 - Decimal:   939 525 011
        PterThanas                    = 0x38000394, // In Hexadecimal Editor: 94 03 00 38 - Decimal:   939 525 012
        BevelLemelisk                 = 0x38000395, // In Hexadecimal Editor: 95 03 00 38 - Decimal:   939 525 013
        ShenirRix                     = 0x38000396, // In Hexadecimal Editor: 96 03 00 38 - Decimal:   939 525 014
        NovalGaraint                  = 0x38000397, // In Hexadecimal Editor: 97 03 00 38 - Decimal:   939 525 015
        Garindan                      = 0x38000398, // In Hexadecimal Editor: 98 03 00 38 - Decimal:   939 525 016
        Menndo                        = 0x38000399, // In Hexadecimal Editor: 99 03 00 38 - Decimal:   939 525 017
        Labansat                      = 0x3800039A, // In Hexadecimal Editor: 9A 03 00 38 - Decimal:   939 525 018
        Villar                        = 0x3800039B, // In Hexadecimal Editor: 9B 03 00 38 - Decimal:   939 525 019
        // spec ops
        Guerillas                     = 0x3C000001, // In Hexadecimal Editor: 01 00 00 3C - Decimal: 1 006 632 961
        Infiltrators                  = 0x3C000002, // In Hexadecimal Editor: 02 00 00 3C - Decimal: 1 006 632 962
        LongprobeYwingReconTeam       = 0x3C000003, // In Hexadecimal Editor: 03 00 00 3C - Decimal: 1 006 632 963
        BothanSpies                   = 0x3C000004, // In Hexadecimal Editor: 04 00 00 3C - Decimal: 1 006 632 964
        ImperialProbeDroid            = 0x3C000005, // In Hexadecimal Editor: 05 00 00 3C - Decimal: 1 006 632 965
        ImperialEspionageDroid        = 0x3C000006, // In Hexadecimal Editor: 06 00 00 3C - Decimal: 1 006 632 966
        ImperialCommandos             = 0x3C000007, // In Hexadecimal Editor: 07 00 00 3C - Decimal: 1 006 632 967
        NoghriDeathCommandos          = 0x3C000008, // In Hexadecimal Editor: 08 00 00 3C - Decimal: 1 006 632 968
        BountyHunters                 = 0x3C000009, // In Hexadecimal Editor: 09 00 00 3C - Decimal: 1 006 632 969
        // missions
        Move                          = 0x41000001, // In Hexadecimal Editor: 01 00 00 41 - Decimal: 1 090 519 041
        Return                        = 0x42000002, // In Hexadecimal Editor: 02 00 00 42 - Decimal: 1 107 296 258
        Autorouting                   = 0x43000003, // In Hexadecimal Editor: 03 00 00 43 - Decimal: 1 124 073 475
        Adrift                        = 0x44000004, // In Hexadecimal Editor: 04 00 00 44 - Decimal: 1 140 850 692
        Diplomacy                     = 0x51000010, // In Hexadecimal Editor: 10 00 00 51 - Decimal: 1 358 954 512
        Espionage                     = 0x52000013, // In Hexadecimal Editor: 13 00 00 52 - Decimal: 1 375 731 731
        ShipDesignResearch            = 0x53000020, // In Hexadecimal Editor: 20 00 00 53 - Decimal: 1 392 508 960
        FacilityDesignResearch        = 0x53000021, // In Hexadecimal Editor: 21 00 00 53 - Decimal: 1 392 508 961
        TroopTrainingResearch         = 0x53000022, // In Hexadecimal Editor: 22 00 00 53 - Decimal: 1 392 508 962
        Reconnaissance                = 0x54000015, // In Hexadecimal Editor: 15 00 00 54 - Decimal: 1 409 286 165
        Recruitment                   = 0x55000016, // In Hexadecimal Editor: 16 00 00 55 - Decimal: 1 426 063 382
        InciteUprising                = 0x56000040, // In Hexadecimal Editor: 40 00 00 56 - Decimal: 1 442 840 640
        SubdueUprising                = 0x57000080, // In Hexadecimal Editor: 80 00 00 57 - Decimal: 1 459 617 920
        JediTraining                  = 0x58000042, // In Hexadecimal Editor: 42 00 00 58 - Decimal: 1 476 395 074
        Rescue                        = 0x61000011, // In Hexadecimal Editor: 11 00 00 61 - Decimal: 1 627 389 969
        Abduction                     = 0x62000017, // In Hexadecimal Editor: 17 00 00 62 - Decimal: 1 644 167 191
        Assassination                 = 0x63000081, // In Hexadecimal Editor: 81 00 00 63 - Decimal: 1 660 944 513
        Palace                        = 0x64000044, // In Hexadecimal Editor: 44 00 00 64 - Decimal: 1 677 721 668
        Bounty                        = 0x65000083, // In Hexadecimal Editor: 83 00 00 65 - Decimal: 1 694 498 947
        Sabotage                      = 0x69000012, // In Hexadecimal Editor: 12 00 00 69 - Decimal: 1 761 607 698
        DeathStarSabotage             = 0x6A000041, // In Hexadecimal Editor: 41 00 00 6A - Decimal: 1 778 384 961
        Dagobah                       = 0x71000043, // In Hexadecimal Editor: 43 00 00 71 - Decimal: 1 895 825 475
        Vacation                      = 0x72000045, // In Hexadecimal Editor: 45 00 00 72 - Decimal: 1 912 602 693
        Sabbatical                    = 0x72000046, // In Hexadecimal Editor: 46 00 00 72 - Decimal: 1 912 602 694
        Pickup                        = 0x73000082, // In Hexadecimal Editor: 82 00 00 73 - Decimal: 1 929 379 970
        // systems
        Coruscant                     = 0x90000109, // In Hexadecimal Editor: 09 01 00 90 - Decimal: 2 415 919 369
        Yavin                         = 0x92000121, // In Hexadecimal Editor: 21 01 00 92 - Decimal: 2 449 473 825
    }
}
