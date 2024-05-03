﻿namespace SwRebellionEditor;

// Bitmap, Version Info

public class Gokres : ResourcesDll
{
    public Gokres(string fileName) : base(fileName)
    {
        NamesBitmap = new Dictionary<string, string>
            {
                { "1"    , "system-mine" },
                { "2"    , "system-refinery" },
                { "256"  , "system-orbital-shipyard" },
                { "257"  , "system-training-facility" },
                { "258"  , "system-construction-yard" },
                { "259"  , "system-advanced-shipyard" },
                { "260"  , "system-advanced-training-facility" },
                { "261"  , "system-advanced-construction-yard" },

                { "262"  , "system-tab-shipyards" },
                { "263"  , "system-tab-construction-yards" },
                { "264"  , "system-tab-training-facilities" },

                { "512"  , "system-kdy-150" },
                { "513"  , "system-lnr-series-1" },
                { "514"  , "system-gencore-level-1" },
                { "515"  , "system-lnr-series-2" },
                { "516"  , "system-gencore-level-2" },
                { "640"  , "system-death-star-shield" },
                { "832"  , "system-alliance-headquarters" },

                { "1088" , "system-alliance-fleet-regiment" },
                { "1089" , "system-alliance-army-regiment" },
                { "1090" , "system-sullustan-regiment" },
                { "1091" , "system-wookiee-regiment" },
                { "1092" , "system-mon-calamari-regiment" },
                { "1152" , "system-stormtrooper-regiment" },
                { "1153" , "system-imperial-fleet-regiment" },
                { "1154" , "system-imperial-army-regiment" },
                { "1155" , "system-war-droid-regiment" },
                { "1156" , "system-dark-trooper-regiment" },
                { "1344" , "system-guerillas" },
                { "1345" , "system-infiltrators" },
                { "1346" , "system-longprobe-y-wing-recon-team" },
                { "1347" , "system-bothan-spies" },
                { "1408" , "system-imperial-probe-droid" },
                { "1409" , "system-imperial-espionage-droid" },
                { "1410" , "system-imperial-commandos" },
                { "1411" , "system-noghri-death-commandos" },
                { "1412" , "system-bounty-hunters" },

                { "1600" , "system-a-wing" },
                { "1601" , "system-b-wing" },
                { "1602" , "system-x-wing" },
                { "1603" , "system-y-wing" },

                { "1664" , "system-tie-fighter" },
                { "1665" , "system-tie-interceptor" },
                { "1666" , "system-tie-bomber" },
                { "1667" , "system-tie-defender" },

                { "1856" , "system-mon-calamari-cruiser" },
                { "1857" , "system-bulk-cruiser" },
                { "1858" , "system-assault-frigate" },
                { "1859" , "system-nebulon-b-frigate" },
                { "1860" , "system-alliance-escort-carrier" },
                { "1861" , "system-corellian-corvette" },
                { "1862" , "system-medium-transport" },
                { "1863" , "system-bulk-transport" },
                { "1864" , "system-corellian-gunship" },
                { "1865" , "system-alliance-dreadnaught" },
                { "1866" , "system-cc-7700-frigate" },
                { "1867" , "system-bulwark-battlecruiser" },
                { "1868" , "system-liberator-cruiser" },
                { "1869" , "system-cc-9600-frigate" },
                { "1870" , "system-dauntless-cruiser" },
                { "1920" , "system-strike-cruiser" },
                { "1921" , "system-lancer-frigate" },
                { "1922" , "system-interdictor-cruiser" },
                { "1923" , "system-carrack-light-cruiser" },
                { "1924" , "system-victory-destroyer" },
                { "1925" , "system-imperial-star-destroyer" },
                { "1926" , "system-super-star-destroyer" },
                { "1927" , "system-assault-transport" },
                { "1928" , "system-death-star" },
                { "1929" , "system-galleon" },
                { "1930" , "system-victory-2-star-destroyer" },
                { "1931" , "system-imperial-2-star-destroyer" },
                { "1932" , "system-star-galleon" },
                { "1933" , "system-imperial-escort-carrier" },
                { "1934" , "system-imperial-dreadnaught" },

                { "2112" , "character-status-mon-mothma" },
                { "2113" , "character-status-leia-organa" },
                { "2114" , "character-status-luke-skywalker" },
                { "2115" , "character-status-han-solo" },
                { "2128" , "character-status-luke-knight" },
                { "2176" , "character-status-emperor-palpatine" },
                { "2177" , "character-status-darth-vader" },
                { "2624" , "character-status-ackbar" },
                { "2625" , "character-status-wedge-antilles" },
                { "2626" , "character-status-lando-calrissian" },
                { "2627" , "character-status-chewbacca" },
                { "2628" , "character-status-jan-dodonna" },
                { "2629" , "character-status-crix-madine" },
                { "2630" , "character-status-carlist-rieekan" },
                { "2631" , "character-status-afyon" },
                { "2632" , "character-status-drayson" },
                { "2633" , "character-status-borsk-fey'lya" },
                { "2634" , "character-status-tura-raftican" },
                { "2635" , "character-status-bren-derlin" },
                { "2636" , "character-status-garm-bel-iblis" },
                { "2637" , "character-status-talon-karrde" },
                { "2638" , "character-status-narra" },
                { "2639" , "character-status-huoba-neva" },
                { "2640" , "character-status-page" },
                { "2641" , "character-status-syub-snunb" },
                { "2642" , "character-status-adar-tallon" },
                { "2643" , "character-status-sarin-virgilio" },
                { "2644" , "character-status-vanden-willard" },
                { "2645" , "character-status-roget-jiriss" },
                { "2646" , "character-status-kaiya-andrimetrum" },
                { "2647" , "character-status-mazer-rackus" },
                { "2648" , "character-status-orrimaarko" },
                { "2649" , "character-status-ma'w'shiye" },
                { "2688" , "character-status-jerjerrod" },
                { "2689" , "character-status-ozzel" },
                { "2690" , "character-status-piett" },
                { "2691" , "character-status-veers" },
                { "2692" , "character-status-brandei" },
                { "2693" , "character-status-covell" },
                { "2694" , "character-status-dorja" },
                { "2695" , "character-status-bin-essada" },
                { "2696" , "character-status-niles-ferrier" },
                { "2697" , "character-status-grammel" },
                { "2698" , "character-status-griff" },
                { "2699" , "character-status-klev" },
                { "2700" , "character-status-needa" },
                { "2701" , "character-status-bane-nothos" },
                { "2702" , "character-status-orlok" },
                { "2703" , "character-status-pellaeon" },
                { "2704" , "character-status-screed" },
                { "2705" , "character-status-thrawn" },
                { "2706" , "character-status-zuggs" },
                { "2707" , "character-status-daala" },
                { "2708" , "character-status-pter-thanas" },
                { "2709" , "character-status-bevel-lemelisk" },
                { "2710" , "character-status-shenir-rix" },
                { "2711" , "character-status-noval-garaint" },
                { "2712" , "character-status-garindan" },
                { "2713" , "character-status-menndo" },
                { "2714" , "character-status-labansat" },
                { "2715" , "character-status-villar" },

                { "3088" , "" },
                { "3089" , "" },
                { "3090" , "" },
                { "3091" , "" },
                { "3092" , "" },
                { "3093" , "" },
                { "3094" , "" },
                { "3095" , "" },
                { "3104" , "" },
                { "3105" , "" },
                { "3106" , "" },
                { "3136" , "" },
                { "3137" , "" },
                { "3138" , "" },
                { "3139" , "" },
                { "3140" , "" },
                { "3141" , "" },
                { "3142" , "" },
                { "3200" , "" },
                { "3201" , "" },
                { "3202" , "" },
                { "3203" , "" },
                { "5185" , "" },
                { "5250" , "" },
                { "5442" , "" },
                { "5504" , "" },
                { "5696" , "" },
                { "5697" , "" },
                { "5698" , "" },
                { "5699" , "" },
                { "5760" , "" },
                { "5761" , "" },
                { "5762" , "" },
                { "5763" , "" },
                { "5952" , "" },
                { "5953" , "" },
                { "5954" , "" },
                { "5955" , "" },
                { "5956" , "" },
                { "5957" , "" },
                { "5958" , "" },
                { "5959" , "" },
                { "5960" , "" },
                { "5961" , "" },
                { "5962" , "" },
                { "5963" , "" },
                { "5964" , "" },
                { "5965" , "" },
                { "5966" , "" },
                { "6016" , "" },
                { "6017" , "" },
                { "6018" , "" },
                { "6019" , "" },
                { "6020" , "" },
                { "6021" , "" },
                { "6022" , "" },
                { "6023" , "" },
                { "6024" , "" },
                { "6025" , "" },
                { "6026" , "" },
                { "6027" , "" },
                { "6028" , "" },
                { "6029" , "" },
                { "6030" , "" },
                { "7184" , "" },
                { "7185" , "" },
                { "7186" , "" },
                { "7187" , "" },
                { "7188" , "" },
                { "7189" , "" },
                { "7190" , "" },
                { "7191" , "" },
                { "7200" , "" },
                { "7201" , "" },
                { "7202" , "" },
                { "7232" , "" },
                { "7233" , "" },
                { "7234" , "" },
                { "7235" , "" },
                { "7236" , "" },
                { "7237" , "" },
                { "7238" , "" },
                { "7296" , "" },
                { "7297" , "" },
                { "7298" , "" },
                { "7299" , "" },
                { "9792" , "" },
                { "9793" , "" },
                { "9794" , "" },
                { "9795" , "" },
                { "9856" , "" },
                { "9857" , "" },
                { "9858" , "" },
                { "9859" , "" },
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
                { "10058", "" },
                { "10059", "" },
                { "10060", "" },
                { "10061", "" },
                { "10062", "" },
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
                { "14151", "" },
                { "16385", "" },
                { "16386", "" },
                { "16640", "" },
                { "16641", "" },
                { "16642", "" },
                { "16643", "" },
                { "16644", "" },
                { "16645", "" },
                { "16896", "" },
                { "16897", "" },
                { "16898", "" },
                { "16899", "" },
                { "16900", "" },
                { "17024", "" },
                { "17216", "" },

                { "17472", "sprite-alliance-fleet-regiment" },
                { "17473", "sprite-alliance-army-regiment" },
                { "17474", "sprite-sullustan-regiment" },
                { "17475", "sprite-wookiee-regiment" },
                { "17476", "sprite-mon-calamari-regiment" },
                { "17536", "sprite-stormtrooper-regiment" },
                { "17537", "sprite-imperial-fleet-regiment" },
                { "17538", "sprite-imperial-army-regiment" },
                { "17539", "sprite-war-droid-regiment" },
                { "17540", "sprite-dark-trooper-regiment" },
                { "17728", "sprite-guerillas" },
                { "17729", "sprite-infiltrators" },
                { "17730", "sprite-longprobe-y-wing-recon-team" },
                { "17731", "sprite-bothan-spies" },
                { "17792", "sprite-imperial-probe-droid" },
                { "17793", "sprite-imperial-espionage-droid" },
                { "17794", "sprite-imperial-commandos" },
                { "17795", "sprite-noghri-death-commandos" },
                { "17796", "sprite-bounty-hunters" },

                { "17984", "sprite-a-wing" },
                { "17985", "sprite-b-wing" },
                { "17986", "sprite-x-wing" },
                { "17987", "sprite-y-wing" },
                { "18048", "sprite-tie-fighter" },
                { "18049", "sprite-tie-interceptor" },
                { "18050", "sprite-tie-bomber" },
                { "18051", "sprite-tie-defender" },

                { "18240", "sprite-mon-calamari-cruiser" },
                { "18241", "sprite-bulk-cruiser" },
                { "18242", "sprite-assault-frigate" },
                { "18243", "sprite-nebulon-b-frigate" },
                { "18244", "sprite-alliance-escort-carrier" },
                { "18245", "sprite-corellian-corvette" },
                { "18246", "sprite-medium-transport" },
                { "18247", "sprite-bulk-transport" },
                { "18248", "sprite-corellian-gunship" },
                { "18249", "sprite-alliance-dreadnaught" },
                { "18250", "sprite-cc-7700-frigate" },
                { "18251", "sprite-bulwark-battlecruiser" },
                { "18252", "sprite-liberator-cruiser" },
                { "18253", "sprite-cc-9600-frigate" },
                { "18254", "sprite-dauntless-cruiser" },
                { "18304", "sprite-strike-cruiser" },
                { "18305", "sprite-lancer-frigate" },
                { "18306", "sprite-interdictor-cruiser" },
                { "18307", "sprite-carrack-light-cruiser" },
                { "18308", "sprite-victory-destroyer" },
                { "18309", "sprite-imperial-star-destroyer" },
                { "18310", "sprite-super-star-destroyer" },
                { "18311", "sprite-assault-transport" },
                { "18312", "sprite-death-star" },
                { "18313", "sprite-galleon" },
                { "18314", "sprite-victory-2-star-destroyer" },
                { "18315", "sprite-imperial-2-star-destroyer" },
                { "18316", "sprite-star-galleon" },
                { "18317", "sprite-imperial-escort-carrier" },
                { "18318", "sprite-imperial-dreadnaught" },

                { "18496", "sprite-mon-mothma" },
                { "18497", "sprite-leia-organa" },
                { "18498", "sprite-luke-skywalker" },
                { "18499", "sprite-han-solo" },
                { "18512", "sprite-luke-knight" },
                { "18560", "sprite-emperor-palpatine" },
                { "18561", "sprite-darth-vader" },
                { "19008", "sprite-ackbar" },
                { "19009", "sprite-wedge-antilles" },
                { "19010", "sprite-lando-calrissian" },
                { "19011", "sprite-chewbacca" },
                { "19012", "sprite-jan-dodonna" },
                { "19013", "sprite-crix-madine" },
                { "19014", "sprite-carlist-rieekan" },
                { "19015", "sprite-afyon" },
                { "19016", "sprite-drayson" },
                { "19017", "sprite-borsk-fey'lya" },
                { "19018", "sprite-tura-raftican" },
                { "19019", "sprite-bren-derlin" },
                { "19020", "sprite-garm-bel-iblis" },
                { "19021", "sprite-talon-karrde" },
                { "19022", "sprite-narra" },
                { "19023", "sprite-huoba-neva" },
                { "19024", "sprite-page" },
                { "19025", "sprite-syub-snunb" },
                { "19026", "sprite-adar-tallon" },
                { "19027", "sprite-sarin-virgilio" },
                { "19028", "sprite-vanden-willard" },
                { "19029", "sprite-roget-jiriss" },
                { "19030", "sprite-kaiya-andrimetrum" },
                { "19031", "sprite-mazer-rackus" },
                { "19032", "sprite-orrimaarko" },
                { "19033", "sprite-ma'w'shiye" },
                { "19072", "sprite-jerjerrod" },
                { "19073", "sprite-ozzel" },
                { "19074", "sprite-piett" },
                { "19075", "sprite-veers" },
                { "19076", "sprite-brandei" },
                { "19077", "sprite-covell" },
                { "19078", "sprite-dorja" },
                { "19079", "sprite-bin-essada" },
                { "19080", "sprite-niles-ferrier" },
                { "19081", "sprite-grammel" },
                { "19082", "sprite-griff" },
                { "19083", "sprite-klev" },
                { "19084", "sprite-needa" },
                { "19085", "sprite-bane-nothos" },
                { "19086", "sprite-orlok" },
                { "19087", "sprite-pellaeon" },
                { "19088", "sprite-screed" },
                { "19089", "sprite-thrawn" },
                { "19090", "sprite-zuggs" },
                { "19091", "sprite-daala" },
                { "19092", "sprite-pter-thanas" },
                { "19093", "sprite-bevel-lemelisk" },
                { "19094", "sprite-shenir-rix" },
                { "19095", "sprite-noval-garaint" },
                { "19096", "sprite-garindan" },
                { "19097", "sprite-menndo" },
                { "19098", "sprite-labansat" },
                { "19099", "sprite-villar" },

                { "19472", "" },
                { "19473", "" },
                { "19474", "" },
                { "19475", "" },
                { "19476", "" },
                { "19477", "" },
                { "19478", "" },
                { "19479", "" },
                { "19488", "" },
                { "19489", "" },
                { "19490", "" },
                { "19520", "" },
                { "19521", "" },
                { "19522", "" },
                { "19523", "" },
                { "19524", "" },
                { "19525", "" },
                { "19526", "" },
                { "19584", "" },
                { "19585", "" },
                { "19586", "" },
                { "19587", "" },
                { "21569", "" },
                { "21634", "" },
                { "21826", "" },
                { "21888", "" },
                { "22080", "" },
                { "22081", "" },
                { "22082", "" },
                { "22083", "" },
                { "22144", "" },
                { "22145", "" },
                { "22146", "" },
                { "22147", "" },
                { "22336", "" },
                { "22337", "" },
                { "22338", "" },
                { "22339", "" },
                { "22340", "" },
                { "22341", "" },
                { "22342", "" },
                { "22343", "" },
                { "22344", "" },
                { "22345", "" },
                { "22346", "" },
                { "22347", "" },
                { "22348", "" },
                { "22349", "" },
                { "22350", "" },
                { "22400", "" },
                { "22401", "" },
                { "22402", "" },
                { "22403", "" },
                { "22404", "" },
                { "22405", "" },
                { "22406", "" },
                { "22407", "" },
                { "22408", "" },
                { "22409", "" },
                { "22410", "" },
                { "22411", "" },
                { "22412", "" },
                { "22413", "" },
                { "22414", "" },
                { "23568", "" },
                { "23569", "" },
                { "23570", "" },
                { "23571", "" },
                { "23572", "" },
                { "23573", "" },
                { "23574", "" },
                { "23575", "" },
                { "23584", "" },
                { "23585", "" },
                { "23586", "" },
                { "23616", "" },
                { "23617", "" },
                { "23618", "" },
                { "23619", "" },
                { "23620", "" },
                { "23621", "" },
                { "23622", "" },
                { "23680", "" },
                { "23681", "" },
                { "23682", "" },
                { "23683", "" },
                { "26176", "" },
                { "26177", "" },
                { "26178", "" },
                { "26179", "" },
                { "26240", "" },
                { "26241", "" },
                { "26242", "" },
                { "26243", "" },
                { "26432", "" },
                { "26433", "" },
                { "26434", "" },
                { "26435", "" },
                { "26436", "" },
                { "26437", "" },
                { "26438", "" },
                { "26439", "" },
                { "26440", "" },
                { "26441", "" },
                { "26442", "" },
                { "26443", "" },
                { "26444", "" },
                { "26445", "" },
                { "26446", "" },
                { "26496", "" },
                { "26497", "" },
                { "26498", "" },
                { "26499", "" },
                { "26500", "" },
                { "26501", "" },
                { "26502", "" },
                { "26503", "" },
                { "26504", "" },
                { "26505", "" },
                { "26506", "" },
                { "26507", "" },
                { "26508", "" },
                { "26509", "" },
                { "26510", "" },
                { "30535", "" },

                { "30784", "sprite-jail-mon-mothma" },
                { "30785", "sprite-jail-leia-organa" },
                { "30786", "sprite-jail-luke-skywalker" },
                { "30787", "sprite-jail-han-solo" },
                { "30800", "sprite-jail-luke-knight" },
                { "30848", "sprite-jail-emperor-palpatine" },
                { "30849", "sprite-jail-darth-vader" },
                { "31296", "sprite-jail-ackbar" },
                { "31297", "sprite-jail-wedge-antilles" },
                { "31298", "sprite-jail-lando-calrissian" },
                { "31299", "sprite-jail-chewbacca" },
                { "31300", "sprite-jail-jan-dodonna" },
                { "31301", "sprite-jail-crix-madine" },
                { "31302", "sprite-jail-carlist-rieekan" },
                { "31303", "sprite-jail-afyon" },
                { "31304", "sprite-jail-drayson" },
                { "31305", "sprite-jail-borsk-fey'lya" },
                { "31306", "sprite-jail-tura-raftican" },
                { "31307", "sprite-jail-bren-derlin" },
                { "31308", "sprite-jail-garm-bel-iblis" },
                { "31309", "sprite-jail-talon-karrde" },
                { "31310", "sprite-jail-narra" },
                { "31311", "sprite-jail-huoba-neva" },
                { "31312", "sprite-jail-page" },
                { "31313", "sprite-jail-syub-snunb" },
                { "31314", "sprite-jail-adar-tallon" },
                { "31315", "sprite-jail-sarin-virgilio" },
                { "31316", "sprite-jail-vanden-willard" },
                { "31317", "sprite-jail-roget-jiriss" },
                { "31318", "sprite-jail-kaiya-andrimetrum" },
                { "31319", "sprite-jail-mazer-rackus" },
                { "31320", "sprite-jail-orrimaarko" },
                { "31321", "sprite-jail-ma'w'shiye" },
                { "31360", "sprite-jail-jerjerrod" },
                { "31361", "sprite-jail-ozzel" },
                { "31362", "sprite-jail-piett" },
                { "31363", "sprite-jail-veers" },
                { "31364", "sprite-jail-brandei" },
                { "31365", "sprite-jail-covell" },
                { "31366", "sprite-jail-dorja" },
                { "31367", "sprite-jail-bin-essada" },
                { "31368", "sprite-jail-niles-ferrier" },
                { "31369", "sprite-jail-grammel" },
                { "31370", "sprite-jail-griff" },
                { "31371", "sprite-jail-klev" },
                { "31372", "sprite-jail-needa" },
                { "31373", "sprite-jail-bane-nothos" },
                { "31374", "sprite-jail-orlok" },
                { "31375", "sprite-jail-pellaeon" },
                { "31376", "sprite-jail-screed" },
                { "31377", "sprite-jail-thrawn" },
                { "31378", "sprite-jail-zuggs" },
                { "31379", "sprite-jail-daala" },
                { "31380", "sprite-jail-pter-thanas" },
                { "31381", "sprite-jail-bevel-lemelisk" },
                { "31382", "sprite-jail-shenir-rix" },
                { "31383", "sprite-jail-noval-garaint" },
                { "31384", "sprite-jail-garindan" },
                { "31385", "sprite-jail-menndo" },
                { "31386", "sprite-jail-labansat" },
                { "31387", "sprite-jail-villar" },
        };
    }
}
