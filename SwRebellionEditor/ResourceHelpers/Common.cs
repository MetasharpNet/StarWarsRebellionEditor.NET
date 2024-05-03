﻿namespace SwRebellionEditor;

// WAVE, Bitmap, RCData, Version Info

public class Common : ResourcesDll
{
    public Common(string fileName) : base(fileName)
    {
        NamesBitmap = new Dictionary<string, string>
            {
                { "10001", "" },
                { "10002", "" },
                { "10003", "" },
                { "10005", "" },
                { "10007", "" },
                { "10009", "" },
                { "10011", "" },
                { "10013", "" },
                { "10014", "" },
                { "10015", "" },
                { "10017", "" },
                { "10018", "" },
                { "10019", "" },
                { "10020", "" },
                { "10021", "" },
                { "10022", "" },
                { "10023", "" },
                { "10024", "" },
                { "10025", "" },
                { "10026", "" },
                { "10027", "" },
                { "10028", "" },
                { "10029", "" },
                { "10030", "" },
                { "10031", "" },
                { "10035", "" },
                { "10036", "" },
                { "10037", "" },
                { "10038", "" },
                { "10039", "" },
                { "10040", "" },
                { "10041", "" },
                { "10042", "" },
                { "10043", "" },
                { "10044", "" },
                { "10045", "" },
                { "10046", "" },
                { "10047", "" },
                { "10048", "" },
                { "10049", "" },
                { "10050", "" },
                { "10051", "" },
                { "10052", "" },
                { "10053", "" },
                { "10054", "" },
                { "10055", "" },
                { "10056", "" },
                { "10057", "" },
                { "10100", "" },
                { "10101", "" },
                { "10102", "" },
                { "10103", "" },
                { "10110", "" },
                { "10111", "" },
                { "10112", "" },
                { "10113", "" },
                { "10114", "" },
                { "10115", "" },
                { "10116", "" },
                { "10117", "" },
                { "10118", "" },
                { "10119", "" },
                { "10120", "" },
                { "10121", "" },
                { "10122", "" },
                { "10123", "" },
                { "10124", "" },
                { "10125", "" },
                { "10126", "" },
                { "10127", "" },
                { "10128", "" },
                { "10129", "" },
                { "10130", "" },
                { "10131", "" },
                { "10132", "" },
                { "10133", "" },
                { "10134", "" },
                { "10135", "" },
                { "10136", "" },
                { "10137", "" },
                { "10138", "" },
                { "10139", "" },
                { "10140", "" },
                { "10141", "" },
                { "10142", "" },
                { "10143", "" },
                { "10144", "" },
                { "10145", "" },
                { "10146", "" },
                { "10147", "" },
                { "10148", "" },
                { "10150", "" },
                { "10151", "" },
                { "10152", "" },
                { "10153", "" },
                { "10154", "" },
                { "10155", "" },
                { "10156", "" },
                { "10157", "" },
                { "10158", "" },
                { "10159", "" },
                { "11001", "" },
                { "11002", "" },
                { "11003", "" },
                { "11004", "" },
                { "11005", "" },
                { "11006", "" },
                { "11007", "" },
                { "11008", "" },
                { "11009", "" },
                { "11010", "" },
                { "11011", "" },
                { "11012", "" },
                { "11013", "" },
                { "11014", "" },
                { "11015", "" },
                { "11031", "" },
                { "11032", "" },
                { "11033", "" },
                { "11034", "" },
                { "11035", "" },
                { "11036", "" },
                { "11037", "" },
                { "11038", "" },
                { "11039", "" },
                { "11040", "" },
                { "11041", "" },
                { "11042", "" },
                { "11043", "" },
                { "11044", "" },
                { "11045", "" },
                { "11061", "" },
                { "11062", "" },
                { "11063", "" },
                { "11064", "" },
                { "11065", "" },
                { "11066", "" },
                { "11067", "" },
                { "11068", "" },
                { "11069", "" },
                { "11070", "" },
                { "11071", "" },
                { "11072", "" },
                { "11073", "" },
                { "11074", "" },
                { "11075", "" },
                { "11076", "" },
                { "11077", "" },
                { "11078", "" },
                { "11079", "" },
                { "11080", "" },
                { "11081", "" },
                { "11082", "" },
                { "11083", "" },
                { "11084", "" },
                { "11085", "" },
                { "11086", "" },
                { "11087", "" },
                { "11088", "" },
                { "11089", "" },
                { "11090", "" },
                { "11091", "" },
                { "11092", "" },
                { "11093", "" },
                { "11094", "" },
                { "11095", "" },
                { "11096", "" },
                { "11097", "" },
                { "11098", "" },
                { "11099", "" },
                { "11100", "" },
                { "11101", "" },
                { "11102", "" },
                { "11103", "" },
                { "11104", "" },
                { "11105", "" },
                { "11106", "" },
                { "11107", "" },
                { "11108", "" },
                { "11109", "" },
                { "11110", "" },
                { "11111", "" },
                { "11112", "" },
                { "11113", "" },
                { "11114", "" },
                { "11115", "" },
                { "11116", "" },
                { "11117", "" },
                { "11118", "" },
                { "11119", "" },
                { "11120", "" },
                { "11121", "" },
                { "11122", "" },
                { "11123", "" },
                { "11124", "" },
                { "11125", "" },
                { "11126", "" },
                { "11127", "" },
                { "11128", "" },
                { "11129", "" },
                { "11130", "" },
                { "11131", "" },
                { "11132", "" },
                { "11133", "" },
                { "11134", "" },
                { "11135", "" },
                { "11136", "" },
                { "11137", "" },
                { "11138", "" },
                { "11139", "" },
                { "11140", "" },
                { "11141", "" },
                { "11142", "" },
                { "11143", "" },
                { "11144", "" },
                { "11145", "" },
                { "11146", "" },
                { "11147", "" },
                { "11148", "" },
                { "11149", "" },
                { "11150", "" },
                { "11151", "" },
                { "11152", "" },
                { "11153", "" },
                { "11154", "" },
                { "11155", "" },
                { "11156", "" },
                { "11157", "" },
                { "11158", "" },
                { "11159", "" },
                { "11160", "" },
                { "11161", "" },
                { "11162", "" },
                { "11163", "" },
                { "11164", "" },
                { "11165", "" },
                { "11166", "" },
                { "11167", "" },
                { "11168", "" },
                { "11169", "" },
                { "11170", "" },
                { "11171", "" },
                { "11172", "" },
                { "11173", "" },
                { "11174", "" },
                { "11175", "" },
                { "11176", "" },
                { "11177", "" },
                { "11178", "" },
                { "11179", "" },
                { "11180", "" },
                { "11181", "" },
                { "11182", "" },
                { "11183", "" },
                { "11184", "" },
                { "11185", "" },
                { "11186", "" },
                { "11187", "" },
                { "11188", "" },
                { "11189", "" },
                { "11190", "" },
                { "11191", "" },
                { "11192", "" },
                { "11193", "" },
                { "11194", "" },
                { "11195", "" },
                { "11196", "" },
                { "11197", "" },
                { "11198", "" },
                { "11199", "" },
                { "11200", "" },
                { "11201", "" },
                { "11202", "" },
                { "11203", "" },
                { "11204", "" },
                { "11205", "" },
                { "11206", "" },
                { "11207", "" },
                { "11208", "" },
                { "11209", "" },
                { "11210", "" },
                { "11241", "" },
                { "11242", "" },
                { "11243", "" },
                { "11244", "" },
                { "11245", "" },
                { "11246", "" },
                { "11247", "" },
                { "11248", "" },
                { "11249", "" },
                { "11250", "" },
                { "11251", "" },
                { "11252", "" },
                { "11253", "" },
                { "11254", "" },
                { "11255", "" },
                { "11256", "" },
                { "11257", "" },
                { "11258", "" },
                { "11259", "" },
                { "11260", "" },
                { "11261", "" },
                { "11262", "" },
                { "11263", "" },
                { "11264", "" },
                { "11265", "" },
                { "11266", "" },
                { "11267", "" },
                { "11268", "" },
                { "11269", "" },
                { "11270", "" },
                { "11271", "" },
                { "11272", "" },
                { "11273", "" },
                { "11274", "" },
                { "11275", "" },
                { "20001", "main-screen" },
                { "20002", "" },
                { "COCKPIT_BUTTON_GAMESCALE_HUGE_UP" , "" },
                { "COCKPIT_BUTTON_GAMESCALE_LARGE_UP", "" },
                { "COCKPIT_BUTTON_GAMESCALE_STD_UP"  , "" },
            };
        NamesWave = new Dictionary<string, string>
            {
                { "8000", "" },
                { "8001", "" },
                { "8002", "" },
                { "8003", "" },
                { "8004", "" },
            };
    }
}
