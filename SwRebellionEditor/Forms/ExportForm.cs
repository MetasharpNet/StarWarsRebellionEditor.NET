﻿using SwRebellionEditor.ResourceHelpers;

namespace SwRebellionEditor;

public partial class ExportForm : ExportDesignForm
{
    #region .ctor

    private string SectorsGameFilePath;
    private SECTORSD SectorsGameFile;

    public ExportForm()
    {
        SectorsGameFilePath = Path.Combine(Settings.Current.GDataFolder, "SECTORSD.DAT");
        SectorsGameFile = DatFile.Load<SECTORSD>(SectorsGameFilePath);
        GameFilePath = Path.Combine(Settings.Current.GDataFolder, "SYSTEMSD.DAT");
        GameFile = DatFile.Load<SYSTEMSD>(GameFilePath);
        InitializeComponent();
    }

    #endregion

    #region Events
    protected override void LoadSideInfo()
    {
        foreach (var s in GameFile.Systems)
        {
            s.Name = ResourcesDlls.Textstra.RT_STRING[s.TextStraDllId];
            s.EncyclopediaDescription = ResourcesDlls.Encytext.RT_RCDATA[(s.TextStraDllId - 4096).ToString()];
        }
        foreach (var s in SectorsGameFile.Sectors)
        {
            s.Name = ResourcesDlls.Textstra.RT_STRING[s.TextStraDllId];
        }
    }
    private void cancel_Click(object sender, EventArgs e)
    {
        Close();
    }
    private void export_Click(object sender, EventArgs e)
    {
        if (!File.Exists(Settings.Current.REBEXEFilePath))
        {
            try { MessageBox.Show("Please set in the editor a proper game folder. Current: " + Path.GetDirectoryName(Settings.Current.REBEXEFilePath)); }
            catch { MessageBox.Show("Please set in the editor a proper game folder."); }
            return;
        }
        Enabled = false;
        // MANDATORY EXPECTATIONS
        // systems
        // id = 265, sectorid = 36   (Coruscant)
        // id = 289, sectorid = 38   (Yavin)
        // sectors
        // id = 36, galaxysize = 1, importance = 1
        // id = 38, galaxysize = 1

        try { Directory.Delete("export", true); } catch { }
        Directory.CreateDirectory("export");

        // --------------------- SYSTEMS & SECTORS ---------------------
        Directory.CreateDirectory("export\\systems");

        var export = "Sector;Id;X;Y;Group;Galaxy Size" + Environment.NewLine;
        var sectorNames = new Dictionary<uint, string>();
        foreach (var s in SectorsGameFile.Sectors)
        {
            sectorNames.Add(s.Id, s.Name);
            export = export + s.Name + ";"
                            + s.Id + ";"
                            + s.XPosition + ";"
                            + s.YPosition + ";"
                            + (s.Group == 1 ? "Core" : (s.Group == 2 ? "Rim (inner)" : (s.Group == 3 ? "Rim (outer)" : s.Group))) + ";"
                            + (s.GalaxySize == 1 ? "Standard" : (s.GalaxySize == 2 ? "Large" : (s.GalaxySize == 3 ? "Huge" : s.GalaxySize)))
                            + Environment.NewLine;
        }
        File.WriteAllText(".\\export\\systems\\sectors.csv", export);

        export = "Name;Id;TextStraDllId;Sector;X;Y;FamilyId;PictureId;EncyclopediaDescription" + Environment.NewLine;
        foreach (var s in GameFile.Systems)
        {
            export = export + s.Name + ";"
                            + s.Id + ";"
                            + s.TextStraDllId + ";"
                            + (sectorNames.ContainsKey(s.SectorId) ? sectorNames[s.SectorId] : s.SectorId) + ";"
                            + s.XPosition + ";"
                            + s.YPosition + ";"
                            + (s.FamilyId == 144 ? "Core" : (s.FamilyId == 146 ? "Rim" : s.FamilyId)) + ";"
                            + s.PictureId + ";"
                            + "\"" + s.EncyclopediaDescription + "\""
                            + Environment.NewLine;
        }
        File.WriteAllText(".\\export\\systems\\systems.csv", export);

        // ---------------------------- EDATA ----------------------------
        Directory.CreateDirectory("export\\EDATA");
        var files = Directory.GetFiles(Settings.Current.EDataFolder);
        foreach (var filePath in files)
        {
            var fileName = Path.GetFileName(filePath);
            var extension = Path.GetExtension(fileName).Substring(1);
            var name = NamesEdata.ContainsKey(extension) ? NamesEdata[extension] : "";
            var newFileName = extension + "-" + name + ".bmp";
            File.Copy(filePath, Path.Combine(".\\export\\EDATA", newFileName), true);
        }

        // ------------------------------ DLL -----------------------------

        ResourcesDlls.Alsprite.Export(); // WAVE, Bitmap, RCData, Version Info, 302
        ResourcesDlls.Cdderr.Export();   // String Table
        ResourcesDlls.Common.Export();   // WAVE, Bitmap, RCData, Version Info
        ResourcesDlls.Emsprite.Export(); // WAVE, Bitmap, RCData, Version Info, 302
        ResourcesDlls.Encybmap.Export(); // String Table
        ResourcesDlls.Encytext.Export(); // RCData
        ResourcesDlls.Gokres.Export();   // Bitmap, Version Info
        ResourcesDlls.Rebdlog.Export();  // Bitmap, String Table, Version Info
        ResourcesDlls.Strategy.Export(); // WAVE, Bitmap, RCData, Version Info
        ResourcesDlls.Tactical.Export(); // WAVE, Cursor, Bitmap, RCData, Cursor Group, Version Info, 301, 303
        ResourcesDlls.Textcomm.Export(); // Dialog, String Table, Accelerators, Version Info
        ResourcesDlls.Textstra.Export(); // String Table, RCData, Version Info
        ResourcesDlls.Texttact.Export(); // String Table, Version Info
        ResourcesDlls.Voicefxa.Export(); // WAVE, Version Info
        ResourcesDlls.Voicefxe.Export(); // WAVE, Version Info

        // -------------------------- REBEXE.EXE -------------------------
        // Cursor, Icon, RCData, Cursor Group, Icon Group, Version Info, Manifest

        Close();
    }

    public string TrimDecimal(string s)
    {
        if (s.IndexOf(',') > -1)
            s = s.Substring(0, s.IndexOf(","));
        if (s.IndexOf('.') > -1)
            s = s.Substring(0, s.IndexOf("."));
        if (s.Length < 1)
            s = "0";
        return s;
    }

    #endregion

    #region easy names

    Dictionary<string, string> NamesEdata = new Dictionary<string, string>
    {
        { "001", "edata-mine" },
        { "002", "edata-refinery" },
        { "003", "edata-orbital-shipyard" },
        { "004", "edata-training-facility" },
        { "005", "edata-construction-yard" },
        { "006", "edata-advanced-shipyard" },
        { "007", "edata-advanced-training-facility" },
        { "008", "edata-advanced-construction-yard" },
        { "009", "edata-kdy-150" },
        { "010", "edata-lnr-series-1" },
        { "011", "edata-gencore-level-1" },
        { "012", "edata-lnr-series-2" },
        { "013", "edata-gencore-level-2" },
        { "014", "edata-death-star-shield" },
        { "015", "edata-alliance-fleet-regiment" },
        { "016", "edata-alliance-army-regiment" },
        { "017", "edata-sullustan-regiment" },
        { "018", "edata-wookiee-regiment" },
        { "019", "edata-mon-calamari-regiment" },
        { "020", "edata-stormtrooper-regiment" },
        { "021", "edata-imperial-fleet-regiment" },
        { "022", "edata-imperial-army-regiment" },
        { "023", "edata-war-droid-regiment" },
        { "024", "edata-dark-trooper-regiment" },
        { "025", "edata-guerillas" },
        { "026", "edata-infiltrators" },
        { "027", "edata-longprobe-y-wing-recon-team" },
        { "028", "edata-bothan-spies" },
        { "029", "edata-imperial-probe-droid" },
        { "030", "edata-imperial-espionage-droid" },
        { "031", "edata-imperial-commandos" },
        { "032", "edata-noghri-death-commandos" },
        { "033", "edata-bounty-hunters" },
        { "034", "edata-a-wing" },
        { "035", "edata-b-wing" },
        { "036", "edata-x-wing" },
        { "037", "edata-y-wing" },
        { "038", "edata-tie-fighter" },
        { "039", "edata-tie-interceptor" },
        { "040", "edata-tie-bomber" },
        { "041", "edata-tie-defender" },
        { "042", "edata-mon-calamari-cruiser" },
        { "043", "edata-bulk-cruiser" },
        { "044", "edata-assault-frigate" },
        { "045", "edata-nebulon-b-frigate" },
        { "046", "edata-alliance-escort-carrier" },
        { "047", "edata-corellian-corvette" },
        { "048", "edata-medium-transport" },
        { "049", "edata-bulk-transport" },
        { "050", "edata-corellian-gunship" },
        { "051", "edata-alliance-dreadnaught" },
        { "052", "edata-cc-7700-frigate" },
        { "053", "edata-bulwark-battlecruiser" },
        { "054", "edata-liberator-cruiser" },
        { "055", "edata-cc-9600-frigate" },
        { "056", "edata-dauntless-cruiser" },
        { "057", "edata-strike-cruiser" },
        { "058", "edata-lancer-frigate" },
        { "059", "edata-interdictor-cruiser" },
        { "060", "edata-carrack-light-cruiser" },
        { "061", "edata-victory-destroyer" },
        { "062", "edata-imperial-star-destroyer" },
        { "063", "edata-super-star-destroyer" },
        { "064", "edata-assault-transport" },
        { "065", "edata-death-star" },
        { "066", "edata-galleon" },
        { "067", "edata-victory-2-star-destroyer" },
        { "068", "edata-imperial-2-star-destroyer" },
        { "069", "edata-star-galleon" },
        { "070", "edata-imperial-escort-carrier" },
        { "071", "edata-imperial-dreadnaught" },
        { "072", "edata-mon-mothma" },
        { "073", "edata-leia-organa" },
        { "074", "edata-luke-skywalker" },
        { "075", "edata-han-solo" },
        { "076", "edata-emperor-palpatine" },
        { "077", "edata-darth-vader" },
        { "078", "edata-ackbar" },
        { "079", "edata-wedge-antilles" },
        { "080", "edata-lando-calrissian" },
        { "081", "edata-chewbacca" },
        { "082", "edata-jan-dodonna" },
        { "083", "edata-crix-madine" },
        { "084", "edata-carlist-rieekan" },
        { "085", "edata-afyon" },
        { "086", "edata-drayson" },
        { "087", "edata-borsk-fey'lya" },
        { "088", "edata-tura-raftican" },
        { "089", "edata-bren-derlin" },
        { "090", "edata-garm-bel-iblis" },
        { "091", "edata-talon-karrde" },
        { "092", "edata-narra" },
        { "093", "edata-huoba-neva" },
        { "094", "edata-page" },
        { "095", "edata-syub-snunb" },
        { "096", "edata-adar-tallon" },
        { "097", "edata-sarin-virgilio" },
        { "098", "edata-vanden-willard" },
        { "099", "edata-roget-jiriss" },
        { "100", "edata-kaiya-andrimetrum" },
        { "101", "edata-mazer-rackus" },
        { "102", "edata-orrimaarko" },
        { "103", "edata-ma'w'shiye" },
        { "104", "edata-jerjerrod" },
        { "105", "edata-ozzel" },
        { "106", "edata-piett" },
        { "107", "edata-veers" },
        { "108", "edata-brandei" },
        { "109", "edata-covell" },
        { "110", "edata-dorja" },
        { "111", "edata-bin-essada" },
        { "112", "edata-niles-ferrier" },
        { "113", "edata-grammel" },
        { "114", "edata-griff" },
        { "115", "edata-klev" },
        { "116", "edata-needa" },
        { "117", "edata-bane-nothos" },
        { "118", "edata-orlok" },
        { "119", "edata-pellaeon" },
        { "120", "edata-screed" },
        { "121", "edata-thrawn" },
        { "122", "edata-zuggs" },
        { "123", "edata-daala" },
        { "124", "edata-pter-thanas" },
        { "125", "edata-bevel-lemelisk" },
        { "126", "edata-shenir-rix" },
        { "127", "edata-noval-garaint" },
        { "128", "edata-garindan" },
        { "129", "edata-menndo" },
        { "130", "edata-labansat" },
        { "131", "edata-villar" },
        { "132", "edata-fleet-alliance" },
        { "133", "edata-fleet-empire" },
        { "134", "edata-diplomacy-alliance" },
        { "135", "edata-diplomacy-empire" },
        { "136", "edata-rescue-alliance" },
        { "137", "edata-rescue-empire" },
        { "138", "edata-sabotage-alliance" },
        { "139", "edata-sabotage-empire" },
        { "140", "edata-espionage" },
        { "141", "edata-espionage-empire" },
        { "142", "edata-ship-design-research-alliance" },
        { "143", "edata-ship-design-research-empire" },
        { "146", "edata-facility-design-research" },
        { "148", "edata-troop-training-research-alliance" },
        { "149", "edata-troop-training-research-empire" },
        { "150", "edata-reconnaissance-alliance" },
        { "151", "edata-reconnaissance-empire" },
        { "152", "edata-recruitment-alliance" },
        { "153", "edata-recruitment-empire" },
        { "154", "edata-abduction-alliance" },
        { "155", "edata-abduction-empire" },
        { "156", "edata-incite-uprising-alliance" },
        { "157", "edata-incite uprising-empire" },
        { "158", "edata-death-star-sabotage" },
        { "160", "edata-jedi-training-alliance" },
        { "161", "edata-jedi-training-empire" },
        { "162", "edata-subdue-uprising-alliance" },
        { "163", "edata-subdue-uprising-empire" },
        { "164", "edata-assassination" },
        { "166", "edata-system-01" },
        { "167", "edata-system-02" },
        { "168", "edata-system-03" },
        { "169", "edata-system-04" },
        { "170", "edata-system-05" },
        { "171", "edata-system-06" },
        { "172", "edata-system-07" },
        { "173", "edata-system-08" },
        { "174", "edata-system-09" },
        { "175", "edata-system-10" },
        { "176", "edata-system-11" },
        { "177", "edata-system-12" },
        { "178", "edata-system-13" },
        { "179", "edata-system-14" },
        { "180", "edata-system-15" },
        { "181", "edata-system-16" },
        { "182", "edata-system-17" },
        { "183", "edata-system-18" },
        { "184", "edata-system-19" },
        { "185", "edata-system-20" },
        { "186", "edata-system-21" },
        { "187", "edata-system-22" },
        { "188", "edata-system-23" },
        { "189", "edata-system-24" },
        { "190", "edata-system-25" },
        { "191", "edata-system-26" },
        { "192", "edata-luke-skywalker-jedi-knight" },
        { "14001", "edata-abregado-rae" },
        { "14002", "edata-agamar" },
        { "14003", "edata-ahch-to" },
        { "14004", "edata-ajan-kloss-(moon)" },
        { "14005", "edata-anaxes" },
        { "14006", "edata-anoat-(atlas)" },
        { "14007", "edata-ansion-(atlas)" },
        { "14008", "edata-bakura-(atlas)" },
        { "14009", "edata-balmorra" },
        { "14010", "edata-belderone" },
        { "14011", "edata-belsavis" },
        { "14012", "edata-bescane" },
        { "14013", "edata-bespin-(gas-giant)-(atlas)" },
        { "14014", "edata-bestine-(atlas)" },
        { "14015", "edata-bith" },
        { "14016", "edata-bonadan-(atlas)" },
        { "14017", "edata-boonta" },
        { "14018", "edata-borosk" },
        { "14019", "edata-bothawui-(atlas)" },
        { "14020", "edata-boz-pity-(atlas)" },
        { "14021", "edata-brentaal-iv-(atlas)" },
        { "14022", "edata-byss-(atlas)" },
        { "14023", "edata-cantonica" },
        { "14024", "edata-carida" },
        { "14025", "edata-cato-neimoidia" },
        { "14026", "edata-celanon" },
        { "14027", "edata-chandrila" },
        { "14028", "edata-chardaan" },
        { "14029", "edata-christophsis-(atlas)" },
        { "14030", "edata-circumtore" },
        { "14031", "edata-commenor" },
        { "14032", "edata-concord-dawn" },
        { "14033", "edata-corellia-(atlas)" },
        { "14034", "edata-corsin" },
        { "14035", "edata-coruscant" },
        { "14036", "edata-crait" },
        { "14037", "edata-csilla-(atlas)" },
        { "14038", "edata-cyphar" },
        { "14039", "edata-daalang" },
        { "14040", "edata-dagobah-(atlas)" },
        { "14041", "edata-dantooine-(atlas)" },
        { "14042", "edata-dathomir-(atlas)" },
        { "14043", "edata-delaya-(alderaan)" },
        { "14044", "edata-dellalt" },
        { "14045", "edata-dennogra" },
        { "14046", "edata-denon" },
        { "14047", "edata-devaron" },
        { "14048", "edata-dolla" },
        { "14049", "edata-d'qar" },
        { "14050", "edata-dromund-kaas" },
        { "14051", "edata-dubrillion" },
        { "14052", "edata-duro-(atlas)" },
        { "14053", "edata-eadu" },
        { "14054", "edata-earth" },
        { "14055", "edata-empress-teta" },
        { "14056", "edata-endor-(moon)-(atlas)" },
        { "14057", "edata-eriadu-(atlas)" },
        { "14058", "edata-esseles" },
        { "14059", "edata-exegol" },
        { "14060", "edata-exodeen" },
        { "14061", "edata-farstine" },
        { "14062", "edata-felucia-(atlas)" },
        { "14063", "edata-florn" },
        { "14064", "edata-fondor-(atlas)" },
        { "14065", "edata-formos" },
        { "14066", "edata-gamor" },
        { "14067", "edata-gamorr-(atlas)" },
        { "14068", "edata-geonosis-(atlas)" },
        { "14069", "edata-gerrenthum" },
        { "14070", "edata-ghorman" },
        { "14071", "edata-glee-anselm" },
        { "14072", "edata-hapes-(atlas)" },
        { "14073", "edata-honoghr-(atlas)" },
        { "14074", "edata-hosnian-prime" },
        { "14075", "edata-hoth-(atlas)" },
        { "14076", "edata-iego-(atlas)" },
        { "14077", "edata-ilum" },
        { "14078", "edata-iridonia" },
        { "14079", "edata-isde-naha" },
        { "14080", "edata-ithor-(atlas)" },
        { "14081", "edata-jaemus" },
        { "14082", "edata-jakku" },
        { "14083", "edata-jedha-(moon)" },
        { "14084", "edata-kabal" },
        { "14085", "edata-kalee-(atlas)" },
        { "14086", "edata-kaller" },
        { "14087", "edata-kamino-(atlas)" },
        { "14088", "edata-karfeddion" },
        { "14089", "edata-kashyyyk-(atlas)" },
        { "14090", "edata-kef-bir-(moon)" },
        { "14091", "edata-keitum" },
        { "14092", "edata-kessel" },
        { "14093", "edata-kimiji" },
        { "14094", "edata-kuat-(atlas)" },
        { "14095", "edata-lah'mu" },
        { "14096", "edata-lok" },
        { "14097", "edata-lothal" },
        { "14098", "edata-lotho-minor" },
        { "14099", "edata-lutrillia" },
        { "14100", "edata-lwhekk" },
        { "14101", "edata-makeb" },
        { "14102", "edata-malastare-(atlas)" },
        { "14103", "edata-manaan" },
        { "14104", "edata-mandalore-(atlas)" },
        { "14105", "edata-maridun" },
        { "14106", "edata-milagro" },
        { "14107", "edata-mimban-(circarpous-v)" },
        { "14108", "edata-mirial" },
        { "14109", "edata-mon-calamari-(atlas)" },
        { "14110", "edata-mon-gazza" },
        { "14111", "edata-moraband-(korriban)-(atlas)" },
        { "14112", "edata-mortis" },
        { "14113", "edata-mustafar-(atlas)" },
        { "14114", "edata-muunilinst" },
        { "14115", "edata-mygeeto-(atlas)" },
        { "14116", "edata-naboo-(atlas)" },
        { "14117", "edata-nagi-(atlas)" },
        { "14118", "edata-nal-hutta-(atlas)" },
        { "14119", "edata-nar-shaddaa-(moon)-(atlas)" },
        { "14120", "edata-neimoidia-(atlas)" },
        { "14121", "edata-nelvaan" },
        { "14122", "edata-nevarro" },
        { "14123", "edata-nexus-ortai" },
        { "14124", "edata-nubia-(atlas)" },
        { "14125", "edata-n'zoth-(atlas)" },
        { "14126", "edata-onderon-(atlas)" },
        { "14127", "edata-ord-mantel-(atlas)" },
        { "14128", "edata-ord-trasi" },
        { "14129", "edata-ossus-(atlas)" },
        { "14130", "edata-pakuuni" },
        { "14131", "edata-palanhi" },
        { "14132", "edata-parnassos" },
        { "14133", "edata-pasaana" },
        { "14134", "edata-pax" },
        { "14135", "edata-polis-massa" },
        { "14136", "edata-quarzite" },
        { "14137", "edata-quermia" },
        { "14138", "edata-quesh" },
        { "14139", "edata-rakata-prime-(lehon)-(atlas)" },
        { "14140", "edata-randon" },
        { "14141", "edata-rattatak-(atlas)" },
        { "14142", "edata-raxus-prime-(atlas)" },
        { "14143", "edata-rhen-var-(atlas)" },
        { "14144", "edata-rishi-(atlas)" },
        { "14145", "edata-rodia-(atlas)" },
        { "14146", "edata-ruusan-(atlas)" },
        { "14147", "edata-ryloth-(atlas)" },
        { "14148", "edata-saleucami-(atlas)" },
        { "14149", "edata-savareen" },
        { "14150", "edata-scarif" },
        { "14151", "edata-sernpidal-(atlas)" },
        { "14152", "edata-shadda-bi-boran-(atlas)" },
        { "14153", "edata-shili" },
        { "14154", "edata-sissubo" },
        { "14155", "edata-skako-minor" },
        { "14156", "edata-sleheyron" },
        { "14157", "edata-sluis-van" },
        { "14158", "edata-smuggler's-run" },
        { "14159", "edata-socorro" },
        { "14160", "edata-sorgan" },
        { "14161", "edata-sriluur" },
        { "14162", "edata-sullust" },
        { "14163", "edata-sy-myrth" },
        { "14164", "edata-taanab-(atlas)" },
        { "14165", "edata-takodana" },
        { "14166", "edata-talus" },
        { "14167", "edata-taris" },
        { "14168", "edata-tatooine" },
        { "14169", "edata-telos-iv" },
        { "14170", "edata-tepasi" },
        { "14171", "edata-terminus" },
        { "14172", "edata-teth-(atlas)" },
        { "14173", "edata-the-redoubt-(brask-oto)" },
        { "14174", "edata-thyferra-(atlas)" },
        { "14175", "edata-tirahnn" },
        { "14176", "edata-toydaria-(atlas)" },
        { "14177", "edata-tralus" },
        { "14178", "edata-trandosha" },
        { "14179", "edata-trask-(moon)" },
        { "14180", "edata-triton-(atlas)" },
        { "14181", "edata-tund-(atlas)" },
        { "14182", "edata-tython" },
        { "14183", "edata-umbara" },
        { "14184", "edata-utapau-(atlas)" },
        { "14185", "edata-vandor" },
        { "14186", "edata-vinsoth" },
        { "14187", "edata-voss" },
        { "14188", "edata-wellspring-of-life" },
        { "14189", "edata-wobani" },
        { "14190", "edata-word-tandell" },
        { "14191", "edata-wroona-(moon)" },
        { "14192", "edata-yaga-minor" },
        { "14193", "edata-yag'dhul" },
        { "14194", "edata-yavin-4-(moon)-(atlas)" },
        { "14195", "edata-yavin-prime-(gas-giant)" },
        { "14196", "edata-zakuul" },
        { "14197", "edata-zeltros" },
        { "14198", "edata-ziost" },
        { "14199", "edata-zonama-sekot-(atlas)" },
        { "14200", "edata-zygerria" },
    };

    #endregion
}