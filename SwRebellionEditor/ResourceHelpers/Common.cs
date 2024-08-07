﻿namespace SwRebellionEditor;

// WAVE, Bitmap, RCData, Version Info

public class Common : ResourcesDll
{
    public Common(string fileName) : base(fileName)
    {
        NamesBitmap = new Dictionary<string, string>
            {
                { "10001", "select galaxy size-huge-low" },
                { "10002", "select galaxy size-large-mid" },
                { "10003", "select galaxy size-standard-top" },
                { "10005", "play head to head-pressed" },
                { "10007", "start game as empire-pressed" },
                { "10009", "start game as alliance-pressed" },
                { "10011", "exit-pressed" },
                { "10013", "load a saved game-pressed" },
                { "10014", "select galaxy size-anim low mid" },
                { "10015", "select galaxy size-anim mid top" },
                { "10017", "huge galaxy-pressed" },
                { "10018", "large galaxy-pressed" },
                { "10019", "standard galaxy-pressed" },
                { "10020", "return to command center-strategy-alliance-unpressed" },
                { "10021", "return to command center-strategy-alliance-pressed" },
                { "10022", "return to command center-strategy-alliance-disabled" },
                { "10023", "return to command center-strategy-empire-unpressed" },
                { "10024", "return to command center-strategy-empire-pressed" },
                { "10025", "return to command center-strategy-empire-disabled" },
                { "10026", "return to command center-tactical-unpressed" },
                { "10027", "return to command center-tactical-pressed" },
                { "10028", "return to command center-tactical-disabled" },
                { "10029", "multiplayer-unpressed" },
                { "10030", "multiplayer-pressed" },
                { "10031", "multiplayer-disabled" },
                { "10035", "restart the game-unpressed" },
                { "10036", "restart the game-pressed" },
                { "10037", "restart the game-disabled" },
                { "10038", "exit-unpressed" },
                { "10039", "exit-pressed" },
                { "10040", "play music-off" },
                { "10041", "play music-on" },
                { "10042", "play music-disabled" },
                { "10043", "display option-off" },
                { "10044", "display option-on" },
                { "10045", "display option-disabled" },
                { "10046", "save game-unpressed" },
                { "10047", "save game-pressed" },
                { "10048", "save game-disabled" },
                { "10049", "load game-unpressed" },
                { "10050", "load game-pressed" },
                { "10051", "load game-disabled" },
                { "10052", "music volume-background" },
                { "10053", "sound effects volume-background" },
                { "10054", "volume-slider" },

                { "10055", "multiplayer-side-galactic empire" },
                { "10056", "multiplayer-side-rebel alliance" },
                { "10057", "multiplayer-play head to head" },
                { "10100", "multiplayer-setup 1-background" },
                { "10101", "multiplayer-setup 2-background" },
                { "10102", "multiplayer-setup 3-background" },
                { "10103", "multiplayer-setup 4-background" },
                { "10110", "multiplayer-text field-selected" },
                { "10111", "multiplayer-text field-unselected" },
                { "10112", "multiplayer-radio button-unchecked" },
                { "10113", "multiplayer-radio button-checked" },
                { "10114", "multiplayer-alliance-unpressed" },
                { "10115", "multiplayer-alliance-pressed" },
                { "10116", "multiplayer-alliance-disabled" },
                { "10117", "multiplayer-empire-unpressed" },
                { "10118", "multiplayer-empire-pressed" },
                { "10119", "multiplayer-empire-disabled" },
                { "10120", "multiplayer-galaxy size-standard-unpressed" },
                { "10121", "multiplayer-galaxy size-standard-pressed" },
                { "10122", "multiplayer-galaxy size-standard-disabled" },
                { "10123", "multiplayer-galaxy size-large-unpressed" },
                { "10124", "multiplayer-galaxy size-large-pressed" },
                { "10125", "multiplayer-galaxy size-large-disabled" },
                { "10126", "multiplayer-galaxy size-huge-unpressed" },
                { "10127", "multiplayer-galaxy size-huge-pressed" },
                { "10128", "multiplayer-galaxy size-huge-disabled" },
                { "10129", "multiplayer-previous-unpressed" },
                { "10130", "multiplayer-previous-pressed" },
                { "10131", "multiplayer-previous-disabled" },
                { "10132", "multiplayer-next-unpressed" },
                { "10133", "multiplayer-next-pressed" },
                { "10134", "multiplayer-next-disabled" },
                { "10135", "multiplayer-cancel-unpressed" },
                { "10136", "multiplayer-cancel-pressed" },
                { "10137", "multiplayer-cancel-disabled" },
                { "10138", "multiplayer-validate-unpressed" },
                { "10139", "multiplayer-validate-pressed" },
                { "10140", "multiplayer-validate-disabled" },
                { "10141", "tactical-game options-unpressed" },
                { "10142", "tactical-game options-pressed" },
                { "10143", "tactical-game options-disabled" },
                { "10144", "multiplayer-victory conditions-unpressed" },
                { "10145", "multiplayer-victory conditions-pressed" },
                { "10146", "multiplayer-victory conditions-disabled" },

                { "10147", "unselected" },
                { "10148", "selected" },
                { "10150", "scrollbar-none" },
                { "10151", "scrollbar-up-unpressed" },
                { "10152", "scrollbar-up-pressed" },
                { "10153", "scrollbar-down-unpressed" },
                { "10154", "scrollbar-down-pressed" },
                { "10155", "scrollbar-handle-medium" },
                { "10156", "scrollbar-handle-large" },
                { "10157", "scrollbar-handle-small" },
                { "10158", "victory conditions-standard game" },
                { "10159", "victory conditions-headquarters victory" },

                { "11001", "start game as empire-anim 01" },
                { "11002", "start game as empire-anim 02" },
                { "11003", "start game as empire-anim 03" },
                { "11004", "start game as empire-anim 04" },
                { "11005", "start game as empire-anim 05" },
                { "11006", "start game as empire-anim 06" },
                { "11007", "start game as empire-anim 07" },
                { "11008", "start game as empire-anim 08" },
                { "11009", "start game as empire-anim 09" },
                { "11010", "start game as empire-anim 10" },
                { "11011", "start game as empire-anim 11" },
                { "11012", "start game as empire-anim 12" },
                { "11013", "start game as empire-anim 13" },
                { "11014", "start game as empire-anim 14" },
                { "11015", "start game as empire-anim 15" },
                { "11031", "start game as alliance-anim 01" },
                { "11032", "start game as alliance-anim 02" },
                { "11033", "start game as alliance-anim 03" },
                { "11034", "start game as alliance-anim 04" },
                { "11035", "start game as alliance-anim 05" },
                { "11036", "start game as alliance-anim 06" },
                { "11037", "start game as alliance-anim 07" },
                { "11038", "start game as alliance-anim 08" },
                { "11039", "start game as alliance-anim 09" },
                { "11040", "start game as alliance-anim 10" },
                { "11041", "start game as alliance-anim 11" },
                { "11042", "start game as alliance-anim 12" },
                { "11043", "start game as alliance-anim 13" },
                { "11044", "start game as alliance-anim 14" },
                { "11045", "start game as alliance-anim 15" },

                { "11061", "novice-anim 01" },
                { "11062", "novice-anim 02" },
                { "11063", "novice-anim 03" },
                { "11064", "novice-anim 04" },
                { "11065", "novice-anim 05" },
                { "11066", "novice-anim 06" },
                { "11067", "novice-anim 07" },
                { "11068", "novice-anim 08" },
                { "11069", "novice-anim 09" },
                { "11070", "novice-anim 10" },
                { "11071", "novice-anim 11" },
                { "11072", "novice-anim 12" },
                { "11073", "novice-anim 13" },
                { "11074", "novice-anim 14" },
                { "11075", "novice-anim 15" },
                { "11076", "novice-anim 16" },
                { "11077", "novice-anim 17" },
                { "11078", "novice-anim 18" },
                { "11079", "novice-anim 19" },
                { "11080", "novice-anim 20" },
                { "11081", "novice-anim 21" },
                { "11082", "novice-anim 22" },
                { "11083", "novice-anim 23" },
                { "11084", "novice-anim 24" },
                { "11085", "novice-anim 25" },
                { "11086", "novice-anim 26" },
                { "11087", "novice-anim 27" },
                { "11088", "novice-anim 28" },
                { "11089", "novice-anim 29" },
                { "11090", "novice-anim 30" },
                { "11091", "intermediate-anim 01" },
                { "11092", "intermediate-anim 02" },
                { "11093", "intermediate-anim 03" },
                { "11094", "intermediate-anim 04" },
                { "11095", "intermediate-anim 05" },
                { "11096", "intermediate-anim 06" },
                { "11097", "intermediate-anim 07" },
                { "11098", "intermediate-anim 08" },
                { "11099", "intermediate-anim 09" },
                { "11100", "intermediate-anim 10" },
                { "11101", "intermediate-anim 11" },
                { "11102", "intermediate-anim 12" },
                { "11103", "intermediate-anim 13" },
                { "11104", "intermediate-anim 14" },
                { "11105", "intermediate-anim 15" },
                { "11106", "intermediate-anim 16" },
                { "11107", "intermediate-anim 17" },
                { "11108", "intermediate-anim 18" },
                { "11109", "intermediate-anim 19" },
                { "11110", "intermediate-anim 20" },
                { "11111", "intermediate-anim 21" },
                { "11112", "intermediate-anim 22" },
                { "11113", "intermediate-anim 23" },
                { "11114", "intermediate-anim 24" },
                { "11115", "intermediate-anim 25" },
                { "11116", "intermediate-anim 26" },
                { "11117", "intermediate-anim 27" },
                { "11118", "intermediate-anim 28" },
                { "11119", "intermediate-anim 29" },
                { "11120", "intermediate-anim 30" },
                { "11121", "expert-anim 01" },
                { "11122", "expert-anim 02" },
                { "11123", "expert-anim 03" },
                { "11124", "expert-anim 04" },
                { "11125", "expert-anim 05" },
                { "11126", "expert-anim 06" },
                { "11127", "expert-anim 07" },
                { "11128", "expert-anim 08" },
                { "11129", "expert-anim 09" },
                { "11130", "expert-anim 10" },
                { "11131", "expert-anim 11" },
                { "11132", "expert-anim 12" },
                { "11133", "expert-anim 13" },
                { "11134", "expert-anim 14" },
                { "11135", "expert-anim 15" },
                { "11136", "expert-anim 16" },
                { "11137", "expert-anim 17" },
                { "11138", "expert-anim 18" },
                { "11139", "expert-anim 19" },
                { "11140", "expert-anim 20" },
                { "11141", "expert-anim 21" },
                { "11142", "expert-anim 22" },
                { "11143", "expert-anim 23" },
                { "11144", "expert-anim 24" },
                { "11145", "expert-anim 25" },
                { "11146", "expert-anim 26" },
                { "11147", "expert-anim 27" },
                { "11148", "expert-anim 28" },
                { "11149", "expert-anim 29" },
                { "11150", "expert-anim 30" },
                { "11151", "play head to head-anim 01" },
                { "11152", "play head to head-anim 02" },
                { "11153", "play head to head-anim 03" },
                { "11154", "play head to head-anim 04" },
                { "11155", "play head to head-anim 05" },
                { "11156", "play head to head-anim 06" },
                { "11157", "play head to head-anim 07" },
                { "11158", "play head to head-anim 08" },
                { "11159", "play head to head-anim 09" },
                { "11160", "play head to head-anim 10" },
                { "11161", "play head to head-anim 11" },
                { "11162", "play head to head-anim 12" },
                { "11163", "play head to head-anim 13" },
                { "11164", "play head to head-anim 14" },
                { "11165", "play head to head-anim 15" },
                { "11166", "play head to head-anim 16" },
                { "11167", "play head to head-anim 17" },
                { "11168", "play head to head-anim 18" },
                { "11169", "play head to head-anim 19" },
                { "11170", "play head to head-anim 20" },
                { "11171", "play head to head-anim 21" },
                { "11172", "play head to head-anim 22" },
                { "11173", "play head to head-anim 23" },
                { "11174", "play head to head-anim 24" },
                { "11175", "play head to head-anim 25" },
                { "11176", "play head to head-anim 26" },
                { "11177", "play head to head-anim 27" },
                { "11178", "play head to head-anim 28" },
                { "11179", "play head to head-anim 29" },
                { "11180", "play head to head-anim 30" },
                { "11181", "exit-anim 01" },
                { "11182", "exit-anim 02" },
                { "11183", "exit-anim 03" },
                { "11184", "exit-anim 04" },
                { "11185", "exit-anim 05" },
                { "11186", "exit-anim 06" },
                { "11187", "exit-anim 07" },
                { "11188", "exit-anim 08" },
                { "11189", "exit-anim 09" },
                { "11190", "exit-anim 10" },
                { "11191", "exit-anim 11" },
                { "11192", "exit-anim 12" },
                { "11193", "exit-anim 13" },
                { "11194", "exit-anim 14" },
                { "11195", "exit-anim 15" },
                { "11196", "exit-anim 16" },
                { "11197", "exit-anim 17" },
                { "11198", "exit-anim 18" },
                { "11199", "exit-anim 19" },
                { "11200", "exit-anim 20" },
                { "11201", "exit-anim 21" },
                { "11202", "exit-anim 22" },
                { "11203", "exit-anim 23" },
                { "11204", "exit-anim 24" },
                { "11205", "exit-anim 25" },
                { "11206", "exit-anim 26" },
                { "11207", "exit-anim 27" },
                { "11208", "exit-anim 28" },
                { "11209", "exit-anim 29" },
                { "11210", "exit-anim 30" },
                { "11241", "load a saved game-anim 01" },
                { "11242", "load a saved game-anim 02" },
                { "11243", "load a saved game-anim 03" },
                { "11244", "load a saved game-anim 04" },
                { "11245", "load a saved game-anim 05" },
                { "11246", "load a saved game-anim 06" },
                { "11247", "load a saved game-anim 07" },
                { "11248", "load a saved game-anim 08" },
                { "11249", "load a saved game-anim 09" },
                { "11250", "load a saved game-anim 10" },
                { "11251", "load a saved game-anim 11" },
                { "11252", "load a saved game-anim 12" },
                { "11253", "load a saved game-anim 13" },
                { "11254", "load a saved game-anim 14" },
                { "11255", "load a saved game-anim 15" },
                { "11256", "load a saved game-anim 16" },
                { "11257", "load a saved game-anim 17" },
                { "11258", "load a saved game-anim 18" },
                { "11259", "load a saved game-anim 19" },
                { "11260", "load a saved game-anim 20" },
                { "11261", "load a saved game-anim 21" },
                { "11262", "load a saved game-anim 22" },
                { "11263", "load a saved game-anim 23" },
                { "11264", "load a saved game-anim 24" },
                { "11265", "load a saved game-anim 25" },
                { "11266", "load a saved game-anim 26" },
                { "11267", "load a saved game-anim 27" },
                { "11268", "load a saved game-anim 28" },
                { "11269", "load a saved game-anim 29" },
                { "11270", "load a saved game-anim 30" },

                { "11271", "credits-unpressed" },
                { "11272", "credits-pressed" },
                { "11273", "novice-pressed" },
                { "11274", "expert-pressed" },
                { "11275", "intermediate-pressed" },
                { "20001", "main-screen" },
                { "20002", "settings" },
                { "COCKPIT_BUTTON_GAMESCALE_HUGE_UP" , "huge galaxy" },
                { "COCKPIT_BUTTON_GAMESCALE_LARGE_UP", "large galaxy" },
                { "COCKPIT_BUTTON_GAMESCALE_STD_UP"  , "standard galaxy" },
            };
        NamesWave = new Dictionary<string, string>
            {
                { "8000", "main menu-galaxy size" },
                { "8001", "main menu-setup multiplayer" },
                { "8002", "main menu-faction" },
                { "8003", "main menu-exit game" },
                { "8004", "main menu-change difficulty or galaxy size" },
            };
    }
}
