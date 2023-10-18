﻿namespace SwRebellionEditor;

public class Tactical : ResourcesDll
{
    public Tactical(string fileName) : base(fileName)
    {
        Names301 = new Dictionary<string, string>
            {
                { "2010", "alliance-mc80-liberty-type-star-cruiser-close" },
                { "2011", "alliance-mc80-liberty-type-star-cruiser-medium" },
                { "2012", "alliance-mc80-liberty-type-star-cruiser-far" },
                { "2020", "alliance-neutron-star-class-bulk-cruiser-close" },
                { "2021", "alliance-neutron-star-class-bulk-cruiser-medium" },
                { "2022", "alliance-neutron-star-class-bulk-cruiser-far" },
                { "2030", "alliance-assault-frigate-mark-1-close" },
                { "2031", "alliance-assault-frigate-mark-1-medium" },
                { "2032", "alliance-assault-frigate-mark-1-far" },
                { "2040", "alliance-ef76-nebulon-b-escort-frigate-close" },
                { "2041", "alliance-ef76-nebulon-b-escort-frigate-medium" },
                { "2042", "alliance-ef76-nebulon-b-escort-frigate-far" },
                { "2050", "alliance-quasar-fire-class-bulk-cruiser-close" },
                { "2051", "alliance-quasar-fire-class-bulk-cruiser-medium" },
                { "2052", "alliance-quasar-fire-class-bulk-cruiser-far" },
                { "2060", "alliance-cr90-corellian-corvette-close" },
                { "2061", "alliance-cr90-corellian-corvette-medium" },
                { "2062", "alliance-cr90-corellian-corvette-far" },
                { "2070", "alliance-medium-transport-close" },
                { "2071", "alliance-medium-transport-medium" },
                { "2072", "alliance-medium-transport-far" },
                { "2080", "alliance-bulk-transport-close" },
                { "2081", "alliance-bulk-transport-medium" },
                { "2082", "alliance-bulk-transport-far" },
                { "2090", "alliance-dp20-frigate-corellian-gunship-close" },
                { "2091", "alliance-dp20-frigate-corellian-gunship-medium" },
                { "2092", "alliance-dp20-frigate-corellian-gunship-far" },
                { "2100", "alliance-republic-dreadnaught-class-heavy-cruiser-close" },
                { "2101", "alliance-republic-dreadnaught-class-heavy-cruiser-medium" },
                { "2102", "alliance-republic-dreadnaught-class-heavy-cruiser-far" },
                { "2110", "alliance-cc-7700-frigate-close" },
                { "2111", "alliance-cc-7700-frigate-medium" },
                { "2112", "alliance-cc-7700-frigate-far" },
                { "2120", "alliance-cc-9600-frigate-close" },
                { "2121", "alliance-cc-9600-frigate-medium" },
                { "2122", "alliance-cc-9600-frigate-far" },
                { "2130", "alliance-bulwark-class-battlecruiser-mark-3-close" },
                { "2131", "alliance-bulwark-class-battlecruiser-mark-3-medium" },
                { "2132", "alliance-bulwark-class-battlecruiser-mark-3-far" },
                { "2140", "alliance-liberator-class-cruiser-close" },
                { "2141", "alliance-liberator-class-cruiser-medium" },
                { "2142", "alliance-liberator-class-cruiser-far" },
                { "2150", "alliance-dauntless-class-heavy-cruiser-close" },
                { "2151", "alliance-dauntless-class-heavy-cruiser-medium" },
                { "2152", "alliance-dauntless-class-heavy-cruiser-far" },
                { "2510", "empire-strike-class-medium-cruiser-close" },
                { "2511", "empire-strike-class-medium-cruiser-medium" },
                { "2512", "empire-strike-class-medium-cruiser-far" },
                { "2520", "empire-lancer-class-frigate-close" },
                { "2521", "empire-lancer-class-frigate-medium" },
                { "2522", "empire-lancer-class-frigate-far" },
                { "2530", "empire-dominator-interdictor-class-star-destroyer-close" },
                { "2531", "empire-dominator-interdictor-class-star-destroyer-medium" },
                { "2532", "empire-dominator-interdictor-class-star-destroyer-far" },
                { "2540", "empire-carrack-class-light-cruiser-close" },
                { "2541", "empire-carrack-class-light-cruiser-medium" },
                { "2542", "empire-carrack-class-light-cruiser-far" },
                { "2550", "empire-victory-class-star-destroyer-mark-1-close" },
                { "2551", "empire-victory-class-star-destroyer-mark-1-medium" },
                { "2552", "empire-victory-class-star-destroyer-mark-1-far" },
                { "2560", "empire-imperial-1-class-star-destroyer-close" },
                { "2561", "empire-imperial-1-class-star-destroyer-medium" },
                { "2562", "empire-imperial-1-class-star-destroyer-far" },
                { "2570", "empire-executor-class-star-dreadnought-close" },
                { "2571", "empire-executor-class-star-dreadnought-medium" },
                { "2572", "empire-executor-class-star-dreadnought-far" },
                { "2580", "empire-assault-transport-close" },
                { "2581", "empire-assault-transport-medium" },
                { "2582", "empire-assault-transport-far" },
                { "2590", "empire-galleon-close" },
                { "2591", "empire-galleon-medium" },
                { "2592", "empire-galleon-far" },
                { "2600", "empire-victory-2-class-star-destroyer-close" },
                { "2601", "empire-victory-2-class-star-destroyer-medium" },
                { "2602", "empire-victory-2-class-star-destroyer-far" },
                { "2610", "empire-imperial-2-class-star-destroyer-close" },
                { "2611", "empire-imperial-2-class-star-destroyer-medium" },
                { "2612", "empire-imperial-2-class-star-destroyer-far" },
                { "2620", "empire-star-galleon-class-frigate-close" },
                { "2621", "empire-star-galleon-class-frigate-medium" },
                { "2622", "empire-star-galleon-class-frigate-far" },
                { "2630", "empire-ton-falk-class-imperial-escort-carrier-close" },
                { "2631", "empire-ton-falk-class-imperial-escort-carrier-medium" },
                { "2632", "empire-ton-falk-class-imperial-escort-carrier-far" },
                { "2640", "empire-imperial-dreadnaught-class-heavy-cruiser-close" },
                { "2641", "empire-imperial-dreadnaught-class-heavy-cruiser-medium" },
                { "2642", "empire-imperial-dreadnaught-class-heavy-cruiser-far" },
            };
        Names303 = new Dictionary<string, string>
            {
                { "4000", "alliance-x-wing-red-close" },
                { "4001", "alliance-x-wing-blue-close" },
                { "4002", "alliance-x-wing-green-close" },
                { "4003", "alliance-x-wing-gold-close" },
                { "4004", "alliance-x-wing-gray-close" },
                { "4005", "alliance-x-wing-red-far" },
                { "4006", "alliance-x-wing-blue-far" },
                { "4007", "alliance-x-wing-gold-far" },
                { "4008", "alliance-x-wing-green-far" },
                { "4009", "alliance-x-wing-gray-far" },
                { "4010", "alliance-y-wing-red-close" },
                { "4011", "alliance-y-wing-blue-close" },
                { "4012", "alliance-y-wing-green-close" },
                { "4013", "alliance-y-wing-gold-close" },
                { "4014", "alliance-y-wing-gray-close" },
                { "4015", "alliance-y-wing-red-far" },
                { "4016", "alliance-y-wing-blue-far" },
                { "4017", "alliance-y-wing-green-far" },
                { "4018", "alliance-y-wing-gold-far" },
                { "4019", "alliance-y-wing-gray-far" },
                { "4020", "alliance-a-wing-red-close" },
                { "4021", "alliance-a-wing-blue-close" },
                { "4022", "alliance-a-wing-green-close" },
                { "4023", "alliance-a-wing-gold-close" },
                { "4024", "alliance-a-wing-gray-close" },
                { "4025", "alliance-a-wing-red-far" },
                { "4026", "alliance-a-wing-blue-far" },
                { "4027", "alliance-a-wing-green-far" },
                { "4028", "alliance-a-wing-gold-far" },
                { "4029", "alliance-a-wing-gray-far" },
                { "4030", "alliance-b-wing-red-close" },
                { "4031", "alliance-b-wing-blue-close" },
                { "4032", "alliance-b-wing-green-close" },
                { "4033", "alliance-b-wing-gold-close" },
                { "4034", "alliance-b-wing-gray-close" },
                { "4035", "alliance-b-wing-red-far" },
                { "4036", "alliance-b-wing-blue-far" },
                { "4037", "alliance-b-wing-green-far" },
                { "4038", "alliance-b-wing-gold-far" },
                { "4039", "alliance-b-wing-gray-far" },
                { "4100", "empire-tie-fighter-red-close" },
                { "4101", "empire-tie-fighter-blue-close" },
                { "4102", "empire-tie-fighter-green-close" },
                { "4103", "empire-tie-fighter-gold-close" },
                { "4104", "empire-tie-fighter-gray-close" },
                { "4105", "empire-tie-fighter-red-far" },
                { "4106", "empire-tie-fighter-blue-far" },
                { "4107", "empire-tie-fighter-green-far" },
                { "4108", "empire-tie-fighter-gold-far" },
                { "4109", "empire-tie-fighter-gray-far" },
                { "4110", "empire-tie-interceptor-red-close" },
                { "4111", "empire-tie-interceptor-blue-close" },
                { "4112", "empire-tie-interceptor-green-close" },
                { "4113", "empire-tie-interceptor-gold-close" },
                { "4114", "empire-tie-interceptor-gray-close" },
                { "4115", "empire-tie-interceptor-red-far" },
                { "4116", "empire-tie-interceptor-blue-far" },
                { "4117", "empire-tie-interceptor-green-far" },
                { "4118", "empire-tie-interceptor-gold-far" },
                { "4119", "empire-tie-interceptor-gray-far" },
                { "4120", "empire-tie-bomber-red-close" },
                { "4121", "empire-tie-bomber-blue-close" },
                { "4122", "empire-tie-bomber-green-close" },
                { "4123", "empire-tie-bomber-gold-close" },
                { "4124", "empire-tie-bomber-gray-close" },
                { "4125", "empire-tie-bomber-red-far" },
                { "4126", "empire-tie-bomber-blue-far" },
                { "4127", "empire-tie-bomber-green-far" },
                { "4128", "empire-tie-bomber-gold-far" },
                { "4129", "empire-tie-bomber-gray-far" },
                { "4130", "empire-tie-defender-red-close" },
                { "4131", "empire-tie-defender-blue-close" },
                { "4132", "empire-tie-defender-green-close" },
                { "4133", "empire-tie-defender-gold-close" },
                { "4134", "empire-tie-defender-gray-close" },
                { "4135", "empire-tie-defender-red-far" },
                { "4136", "empire-tie-defender-blue-far" },
                { "4137", "empire-tie-defender-green-far" },
                { "4138", "empire-tie-defender-gold-far" },
                { "4139", "empire-tie-defender-gray-far" },
                { "5020", "empire-deathstar-2-under-construction" },
            };
        NamesBitmap = new Dictionary<string, string>
            {
                { "2201", "ackbar" },
                { "2202", "afyon" },
                { "2203", "kaiya-andrimetrum" },
                { "2204", "wedge-antilles" },
                { "2205", "lando-calrissian" },
                { "2206", "chewbacca" },
                { "2207", "covell" },
                { "2208", "daala" },
                { "2209", "bren-derlin" },
                { "2210", "jan-dodonna" },
                { "2211", "dorja" },
                { "2212", "drayson" },
                { "2214", "emperor-palpatine" },
                { "2215", "bin-essada" },
                { "2216", "niles-ferrier" },
                { "2217", "borsk-fey'lya" },
                { "2218", "griff" },
                { "2219", "grammel" },
                { "2220", "garm-bel-iblis" },
                { "2221", "garindan" },
                { "2222", "jerjerrod" },
                { "2223", "roget-jiriss" },
                { "2225", "talon-karrde" },
                { "2226", "klev" },
                { "2227", "labansat" },
                { "2228", "bevel-lemelisk" },
                { "2229", "luke-knight" },
                { "2230", "luke-skywalker" },
                { "2231", "crix-madine" },
                { "2232", "ma'w'shiye" },
                { "2233", "menndo" },
                { "2234", "mon-mothma" },
                { "2235", "narra" },
                { "2236", "needa" },
                { "2237", "huoba-neva" },
                { "2239", "bane-nothos" },
                { "2240", "noval-garaint" },
                { "2241", "leia-organa" },
                { "2242", "orlok" },
                { "2243", "orrimaarko" },
                { "2244", "ozzel" },
                { "2245", "page" },
                { "2246", "pellaeon" },
                { "2247", "piett" },
                { "2248", "mazer-rackus" },
                { "2249", "tura-raftican" },
                { "2250", "carlist-rieekan" },
                { "2251", "shenir-rix" },
                { "2253", "screed" },
                { "2254", "syub-snunb" },
                { "2255", "han-solo" },
                { "2256", "adar-tallon" },
                { "2257", "pter-thanas" },
                { "2258", "thrawn" },
                { "2260", "darth-vader" },
                { "2261", "veers" },
                { "2262", "villar" },
                { "2263", "sarin-virgilio" },
                { "2264", "vanden-willard" },
                { "2265", "zuggs" },
                { "2266", "brandei" },
            };
        NamesWave = new Dictionary<string, string>
            {
            };
    }
}
