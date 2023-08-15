using SwRebellionEditor.ResourceHelpers;
using System.Drawing.Imaging;
using System.Globalization;

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
            s.Name = TextStra.Resources.RT_STRING[s.TextStraDllId];
            s.EncyclopediaDescription = EncyText.Resources.RT_RCDATA[(s.TextStraDllId - 4096).ToString()];
        }
    }
    private void cancel_Click(object sender, EventArgs e)
    {
        Close();
    }
    private void export_Click(object sender, EventArgs e)
    {
        this.Enabled = false;
        // MANDATORY EXPECTATIONS
        // systems
        // id = 265, sectorid = 36   (Coruscant)
        // id = 289, sectorid = 38   (Yavin)
        // sectors
        // id = 36, galaxysize = 1, importance = 1
        // id = 38, galaxysize = 1

        try { Directory.Delete("export", true); } catch { }
        Directory.CreateDirectory("export");

        // ---------------------------- EDATA ----------------------------
        Directory.CreateDirectory("export\\EDATA");
        var files = Directory.GetFiles(Settings.Current.EDataFolder);
        foreach (var filePath in files)
        {
            var fileName = Path.GetFileName(filePath);
            var newFileName = Path.GetExtension(fileName).Substring(1) + "-.bmp";
            File.Copy(filePath, Path.Combine(".\\export\\EDATA", newFileName), true);
        }

        // -------------------------- ALSPRITE.DLL -------------------------
        // WAVE, Bitmap, RCData, Version Info, 302
        Directory.CreateDirectory("export\\ALSPRITE.DLL");
        Directory.CreateDirectory("export\\ALSPRITE.DLL\\Bitmap");
        var ids = Alsprite.Resources.RT_BITMAP.Keys.ToList();
        foreach (var id in ids)
        {
            var lang = Alsprite.Resources.GetBitmapLanguage(id);
            DIB.ToDDB(Alsprite.Resources.RT_BITMAP[id].Bitmap, ".\\export\\ALSPRITE.DLL\\Bitmap\\" + id + "-" + lang + "-" + ".bmp");
        }

        // -------------------------- CDDERR.DLL -------------------------
        // String Table

        // -------------------------- COMMON.DLL -------------------------
        // WAVE, Bitmap, RCData, Version Info
        Directory.CreateDirectory("export\\COMMON.DLL");
        Directory.CreateDirectory("export\\COMMON.DLL\\Bitmap");
        ids = Common.Resources.RT_BITMAP.Keys.ToList();
        foreach (var id in ids)
        {
            var lang = Common.Resources.GetBitmapLanguage(id);
            DIB.ToDDB(Common.Resources.RT_BITMAP[id].Bitmap, ".\\export\\COMMON.DLL\\Bitmap\\" + id + "-" + lang + "-" + ".bmp");
        }

        // -------------------------- EMSPRITE.DLL -------------------------
        // WAVE, Bitmap, RCData, Version Info, 302
        Directory.CreateDirectory("export\\EMSPRITE.DLL");
        Directory.CreateDirectory("export\\EMSPRITE.DLL\\Bitmap");
        ids = Emsprite.Resources.RT_BITMAP.Keys.ToList();
        foreach (var id in ids)
        {
            var lang = Emsprite.Resources.GetBitmapLanguage(id);
            DIB.ToDDB(Emsprite.Resources.RT_BITMAP[id].Bitmap, ".\\export\\EMSPRITE.DLL\\Bitmap\\" + id + "-" + lang + "-" + ".bmp");
        }

        // -------------------------- ENCYBMAP.DLL -------------------------
        // String Table

        // -------------------------- ENCYTEXT.DLL -------------------------
        // RCData

        // -------------------------- GOKRES.DLL -------------------------
        // Bitmap, Version Info
        Directory.CreateDirectory("export\\GOKRES.DLL");
        Directory.CreateDirectory("export\\GOKRES.DLL\\Bitmap");
        ids = Gokres.Resources.RT_BITMAP.Keys.ToList();
        foreach (var id in ids)
        {
            var lang = Gokres.Resources.GetBitmapLanguage(id);
            var name = Gokres_Bitmap_Names.ContainsKey(id) ? Gokres_Bitmap_Names[id] : "";
            DIB.ToDDB(Gokres.Resources.RT_BITMAP[id].Bitmap, ".\\export\\GOKRES.DLL\\Bitmap\\" + id + "-" + lang + "-" + name + ".bmp");
        }

        // -------------------------- REBDLOG.DLL -------------------------
        // Bitmap, String Table, Version Info
        Directory.CreateDirectory("export\\REBDLOG.DLL");
        Directory.CreateDirectory("export\\REBDLOG.DLL\\Bitmap");
        ids = Rebdlog.Resources.RT_BITMAP.Keys.ToList();
        foreach (var id in ids)
        {
            var lang = Rebdlog.Resources.GetBitmapLanguage(id);
            DIB.ToDDB(Rebdlog.Resources.RT_BITMAP[id].Bitmap, ".\\export\\REBDLOG.DLL\\Bitmap\\" + id + "-" + lang + "-" + ".bmp");
        }

        // -------------------------- REBEXE.EXE -------------------------
        // Cursor, Icon, RCData, Cursor Group, Icon Group, Version Info, Manifest

        // -------------------------- STRATEGY.DLL -------------------------
        // WAVE, Bitmap, RCData, Version Info
        Directory.CreateDirectory("export\\STRATEGY.DLL");
        Directory.CreateDirectory("export\\STRATEGY.DLL\\Bitmap");
        ids = Strategy.Resources.RT_BITMAP.Keys.ToList();
        foreach (var id in ids)
        {
            var lang = Strategy.Resources.GetBitmapLanguage(id);
            var name = Strategy_Bitmap_Names.ContainsKey(id) ? Strategy_Bitmap_Names[id] : "";
            DIB.ToDDB(Strategy.Resources.RT_BITMAP[id].Bitmap, ".\\export\\STRATEGY.DLL\\Bitmap\\" + id + "-" + lang + "-" + name + ".bmp");
        }

        // -------------------------- TACTICAL.DLL -------------------------
        // WAVE, Cursor, Bitmap, RCData, Cursor Group, Version Info, 301, 303
        Directory.CreateDirectory("export\\TACTICAL.DLL");
        Directory.CreateDirectory("export\\TACTICAL.DLL\\Bitmap");
        ids = Tactical.Resources.RT_BITMAP.Keys.ToList();
        foreach (var id in ids)
        {
            var lang = Tactical.Resources.GetBitmapLanguage(id);
            var name = Tactical_Bitmap_Names.ContainsKey(id) ? Tactical_Bitmap_Names[id] : "";
            DIB.ToDDB(Tactical.Resources.RT_BITMAP[id].Bitmap, ".\\export\\TACTICAL.DLL\\Bitmap\\" + id + "-" + lang + "-" + name + ".bmp");
        }
        Directory.CreateDirectory("export\\TACTICAL.DLL\\301");
        ids = Tactical.Resources.RT_301.Keys.ToList();
        foreach (var id in ids)
        {
            var lang = Tactical.Resources.Get301Language(id);
            var name = Tactical_301_Names.ContainsKey(id) ? Tactical_301_Names[id] : "";
            File.WriteAllBytes(".\\export\\TACTICAL.DLL\\301\\" + id + "-" + lang + "-" + name + ".x", Tactical.Resources.RT_301[id]);
        }
        Directory.CreateDirectory("export\\TACTICAL.DLL\\303");
        ids = Tactical.Resources.RT_303.Keys.ToList();
        foreach (var id in ids)
        {
            var lang = Tactical.Resources.Get303Language(id);
            var name = Tactical_303_Names.ContainsKey(id) ? Tactical_303_Names[id] : "";
            File.WriteAllBytes(".\\export\\TACTICAL.DLL\\303\\" + id + "-" + lang + "-" + name + ".bin", Tactical.Resources.RT_303[id]);
            try
            {
                var bi = new BinImage(".\\export\\TACTICAL.DLL\\303\\" + id + "-" + lang + "-" + name + ".bin");
                var b = bi.ToBitmap(new AdobeColorTable(".\\tactical-dll.act"));
                b.Save(".\\export\\TACTICAL.DLL\\303\\" + id + "-" + lang + "-" + name + ".bmp");
            }
            catch
            {
                File.Move(".\\export\\TACTICAL.DLL\\303\\" + id + "-" + lang + "-" + name + ".bin", ".\\export\\TACTICAL.DLL\\303\\" + id + "-" + lang + "-" + name + ".act");
            }
        }

        // -------------------------- TEXTCOMM.DLL -------------------------
        // Dialog, String Table, Accelerators, Version Info

        // -------------------------- TEXTSTRA.DLL -------------------------
        // String Table, RCData, Version Info

        // -------------------------- TEXTTACT.DLL -------------------------
        // String Table, Version Info

        // -------------------------- VOICEFXA.DLL -------------------------
        // WAVE, Version Info

        // -------------------------- VOICEFXE.DLL -------------------------
        // WAVE, Version Info

        this.Close();
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

    Dictionary<string, string> Common_Bitmap_Names = new Dictionary<string, string>
    {
        { "20001", "common-main-screen" },
    };

    Dictionary<string, string> Edata_Names = new Dictionary<string, string>
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
        { "14122", "edata-nevarro.png" },
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

    Dictionary<string, string> Gokres_Bitmap_Names = new Dictionary<string, string>
    {
        { "2112", "gokres-build-mon-mothma" },
        { "2113", "gokres-build-leia-organa" },
        { "2114", "gokres-build-luke-skywalker" },
        { "2115", "gokres-build-han-solo" },
        { "2128", "gokres-build-luke-knight" },
        { "2176", "gokres-build-emperor-palpatine" },
        { "2177", "gokres-build-darth-vader" },
        { "2624", "gokres-build-ackbar" },
        { "2625", "gokres-build-wedge-antilles" },
        { "2626", "gokres-build-lando-calrissian" },
        { "2627", "gokres-build-chewbacca" },
        { "2628", "gokres-build-jan-dodonna" },
        { "2629", "gokres-build-crix-madine" },
        { "2630", "gokres-build-carlist-rieekan" },
        { "2631", "gokres-build-afyon" },
        { "2632", "gokres-build-drayson" },
        { "2633", "gokres-build-borsk-fey'lya" },
        { "2634", "gokres-build-tura-raftican" },
        { "2635", "gokres-build-bren-derlin" },
        { "2636", "gokres-build-garm-bel-iblis" },
        { "2637", "gokres-build-talon-karrde" },
        { "2638", "gokres-build-narra" },
        { "2639", "gokres-build-huoba-neva" },
        { "2640", "gokres-build-page" },
        { "2641", "gokres-build-syub-snunb" },
        { "2642", "gokres-build-adar-tallon" },
        { "2643", "gokres-build-sarin-virgilio" },
        { "2644", "gokres-build-vanden-willard" },
        { "2645", "gokres-build-roget-jiriss" },
        { "2646", "gokres-build-kaiya-andrimetrum" },
        { "2647", "gokres-build-mazer-rackus" },
        { "2648", "gokres-build-orrimaarko" },
        { "2649", "gokres-build-ma'w'shiye" },
        { "2688", "gokres-build-jerjerrod" },
        { "2689", "gokres-build-ozzel" },
        { "2690", "gokres-build-piett" },
        { "2691", "gokres-build-veers" },
        { "2692", "gokres-build-brandei" },
        { "2693", "gokres-build-covell" },
        { "2694", "gokres-build-dorja" },
        { "2695", "gokres-build-bin-essada" },
        { "2696", "gokres-build-niles-ferrier" },
        { "2697", "gokres-build-grammel" },
        { "2698", "gokres-build-griff" },
        { "2699", "gokres-build-klev" },
        { "2700", "gokres-build-needa" },
        { "2701", "gokres-build-bane-nothos" },
        { "2702", "gokres-build-orlok" },
        { "2703", "gokres-build-pellaeon" },
        { "2704", "gokres-build-screed" },
        { "2705", "gokres-build-thrawn" },
        { "2706", "gokres-build-zuggs" },
        { "2707", "gokres-build-daala" },
        { "2708", "gokres-build-pter-thanas" },
        { "2709", "gokres-build-bevel-lemelisk" },
        { "2710", "gokres-build-shenir-rix" },
        { "2711", "gokres-build-noval-garaint" },
        { "2712", "gokres-build-garindan" },
        { "2713", "gokres-build-menndo" },
        { "2714", "gokres-build-labansat" },
        { "2715", "gokres-build-villar" },
        { "18496", "gokres-fleet-mon-mothma" },
        { "18497", "gokres-fleet-leia-organa" },
        { "18498", "gokres-fleet-luke-skywalker" },
        { "18499", "gokres-fleet-han-solo" },
        { "18512", "gokres-fleet-luke-knight" },
        { "18560", "gokres-fleet-emperor-palpatine" },
        { "18561", "gokres-fleet-darth-vader" },
        { "19008", "gokres-fleet-ackbar" },
        { "19009", "gokres-fleet-wedge-antilles" },
        { "19010", "gokres-fleet-lando-calrissian" },
        { "19011", "gokres-fleet-chewbacca" },
        { "19012", "gokres-fleet-jan-dodonna" },
        { "19013", "gokres-fleet-crix-madine" },
        { "19014", "gokres-fleet-carlist-rieekan" },
        { "19015", "gokres-fleet-afyon" },
        { "19016", "gokres-fleet-drayson" },
        { "19017", "gokres-fleet-borsk-fey'lya" },
        { "19018", "gokres-fleet-tura-raftican" },
        { "19019", "gokres-fleet-bren-derlin" },
        { "19020", "gokres-fleet-garm-bel-iblis" },
        { "19021", "gokres-fleet-talon-karrde" },
        { "19022", "gokres-fleet-narra" },
        { "19023", "gokres-fleet-huoba-neva" },
        { "19024", "gokres-fleet-page" },
        { "19025", "gokres-fleet-syub-snunb" },
        { "19026", "gokres-fleet-adar-tallon" },
        { "19027", "gokres-fleet-sarin-virgilio" },
        { "19028", "gokres-fleet-vanden-willard" },
        { "19029", "gokres-fleet-roget-jiriss" },
        { "19030", "gokres-fleet-kaiya-andrimetrum" },
        { "19031", "gokres-fleet-mazer-rackus" },
        { "19032", "gokres-fleet-orrimaarko" },
        { "19033", "gokres-fleet-ma'w'shiye" },
        { "19072", "gokres-fleet-jerjerrod" },
        { "19073", "gokres-fleet-ozzel" },
        { "19074", "gokres-fleet-piett" },
        { "19075", "gokres-fleet-veers" },
        { "19076", "gokres-fleet-brandei" },
        { "19077", "gokres-fleet-covell" },
        { "19078", "gokres-fleet-dorja" },
        { "19079", "gokres-fleet-bin-essada" },
        { "19080", "gokres-fleet-niles-ferrier" },
        { "19081", "gokres-fleet-grammel" },
        { "19082", "gokres-fleet-griff" },
        { "19083", "gokres-fleet-klev" },
        { "19084", "gokres-fleet-needa" },
        { "19085", "gokres-fleet-bane-nothos" },
        { "19086", "gokres-fleet-orlok" },
        { "19087", "gokres-fleet-pellaeon" },
        { "19088", "gokres-fleet-screed" },
        { "19089", "gokres-fleet-thrawn" },
        { "19090", "gokres-fleet-zuggs" },
        { "19091", "gokres-fleet-daala" },
        { "19092", "gokres-fleet-pter-thanas" },
        { "19093", "gokres-fleet-bevel-lemelisk" },
        { "19094", "gokres-fleet-shenir-rix" },
        { "19095", "gokres-fleet-noval-garaint" },
        { "19096", "gokres-fleet-garindan" },
        { "19097", "gokres-fleet-menndo" },
        { "19098", "gokres-fleet-labansat" },
        { "19099", "gokres-fleet-villar" },
    };

    Dictionary<string, string> Strategy_Bitmap_Names = new Dictionary<string, string>
    {
        { "902", "strategy-galaxy-background" },
        { "903", "strategy-galaxy-background-dark" },
        { "6208", "strategy-events-mon-mothma" },
        { "6209", "strategy-events-leia-organa" },
        { "6210", "strategy-events-luke-skywalker" },
        { "6211", "strategy-events-han-solo" },
        { "6224", "strategy-events-luke-knight" },
        { "6272", "strategy-events-emperor-palpatine" },
        { "6273", "strategy-events-darth-vader" },
        { "6720", "strategy-events-ackbar" },
        { "6721", "strategy-events-wedge-antilles" },
        { "6722", "strategy-events-lando-calrissian" },
        { "6723", "strategy-events-chewbacca" },
        { "6724", "strategy-events-jan-dodonna" },
        { "6725", "strategy-events-crix-madine" },
        { "6726", "strategy-events-carlist-rieekan" },
        { "6727", "strategy-events-afyon" },
        { "6728", "strategy-events-drayson" },
        { "6729", "strategy-events-borsk-fey'lya" },
        { "6730", "strategy-events-tura-raftican" },
        { "6731", "strategy-events-bren-derlin" },
        { "6732", "strategy-events-garm-bel-iblis" },
        { "6733", "strategy-events-talon-karrde" },
        { "6734", "strategy-events-narra" },
        { "6735", "strategy-events-huoba-neva" },
        { "6736", "strategy-events-page" },
        { "6737", "strategy-events-syub-snunb" },
        { "6738", "strategy-events-adar-tallon" },
        { "6739", "strategy-events-sarin-virgilio" },
        { "6740", "strategy-events-vanden-willard" },
        { "6741", "strategy-events-roget-jiriss" },
        { "6742", "strategy-events-kaiya-andrimetrum" },
        { "6743", "strategy-events-mazer-rackus" },
        { "6744", "strategy-events-orrimaarko" },
        { "6745", "strategy-events-ma'w'shiye" },
        { "6784", "strategy-events-jerjerrod" },
        { "6785", "strategy-events-ozzel" },
        { "6786", "strategy-events-piett" },
        { "6787", "strategy-events-veers" },
        { "6788", "strategy-events-brandei" },
        { "6789", "strategy-events-covell" },
        { "6790", "strategy-events-dorja" },
        { "6791", "strategy-events-bin-essada" },
        { "6792", "strategy-events-niles-ferrier" },
        { "6793", "strategy-events-grammel" },
        { "6794", "strategy-events-griff" },
        { "6795", "strategy-events-klev" },
        { "6796", "strategy-events-needa" },
        { "6797", "strategy-events-bane-nothos" },
        { "6798", "strategy-events-orlok" },
        { "6799", "strategy-events-pellaeon" },
        { "6800", "strategy-events-screed" },
        { "6801", "strategy-events-thrawn" },
        { "6802", "strategy-events-zuggs" },
        { "6803", "strategy-events-daala" },
        { "6804", "strategy-events-pter-thanas" },
        { "6805", "strategy-events-bevel-lemelisk" },
        { "6806", "strategy-events-shenir-rix" },
        { "6807", "strategy-events-noval-garaint" },
        { "6808", "strategy-events-garindan" },
        { "6809", "strategy-events-menndo" },
        { "6810", "strategy-events-labansat" },
        { "6811", "strategy-events-villar" },
        { "11000", "strategy-info-ackbar" },
        { "11001", "strategy-info-afyon" },
        { "11002", "strategy-info-kaiya-andrimetrum" },
        { "11003", "strategy-info-wedge-antilles" },
        { "11004", "strategy-info-brandei" },
        { "11005", "strategy-info-lando-calrissian" },
        { "11006", "strategy-info-chewbacca" },
        { "11007", "strategy-info-covell" },
        { "11008", "strategy-info-daala" },
        { "11009", "strategy-info-bren-derlin" },
        { "11010", "strategy-info-jan-dodonna" },
        { "11011", "strategy-info-dorja" },
        { "11012", "strategy-info-drayson" },
        { "11013", "strategy-info-emperor-palpatine" },
        { "11014", "strategy-info-bin-essada" },
        { "11015", "strategy-info-niles-ferrier" },
        { "11016", "strategy-info-borsk-fey'lya" },
        { "11017", "strategy-info-griff" },
        { "11018", "strategy-info-grammel" },
        { "11019", "strategy-info-garm-bel-iblis" },
        { "11020", "strategy-info-garindan" },
        { "11021", "strategy-info-jerjerrod" },
        { "11022", "strategy-info-roget-jiriss" },
        { "11023", "strategy-info-talon-karrde" },
        { "11024", "strategy-info-klev" },
        { "11025", "strategy-info-labansat" },
        { "11026", "strategy-info-bevel-lemelisk" },
        { "11027", "strategy-info-luke-knight" },
        { "11028", "strategy-info-luke-skywalker" },
        { "11029", "strategy-info-crix-madine" },
        { "11030", "strategy-info-ma'w'shiye" },
        { "11031", "strategy-info-menndo" },
        { "11032", "strategy-info-mon-mothma" },
        { "11033", "strategy-info-narra" },
        { "11034", "strategy-info-needa" },
        { "11035", "strategy-info-huoba-neva" },
        { "11036", "strategy-info-bane-nothos" },
        { "11037", "strategy-info-noval-garaint" },
        { "11038", "strategy-info-leia-organa" },
        { "11039", "strategy-info-orlok" },
        { "11040", "strategy-info-orrimaarko" },
        { "11041", "strategy-info-ozzel" },
        { "11042", "strategy-info-page" },
        { "11043", "strategy-info-pellaeon" },
        { "11044", "strategy-info-piett" },
        { "11045", "strategy-info-mazer-rackus" },
        { "11046", "strategy-info-tura-raftican" },
        { "11047", "strategy-info-carlist-rieekan" },
        { "11048", "strategy-info-shenir-rix" },
        { "11049", "strategy-info-screed" },
        { "11050", "strategy-info-syub-snunb" },
        { "11051", "strategy-info-han-solo" },
        { "11052", "strategy-info" },
        { "11053", "strategy-info-pter-thanas" },
        { "11054", "strategy-info-thrawn" },
        { "11055", "strategy-info-darth-vader" },
        { "11056", "strategy-info-veers" },
        { "11057", "strategy-info-villar" },
        { "11058", "strategy-info-sarin-virgilio" },
        { "11059", "strategy-info-vanden-willard" },
        { "11060", "strategy-info-zuggs" },
    };

    Dictionary<string, string> Tactical_301_Names = new Dictionary<string, string>
    {
        { "2010", "tactical-alliance-mc80-liberty-type-star-cruiser-close" },
        { "2011", "tactical-alliance-mc80-liberty-type-star-cruiser-medium" },
        { "2012", "tactical-alliance-mc80-liberty-type-star-cruiser-far" },
        { "2020", "tactical-alliance-neutron-star-class-bulk-cruiser-close" },
        { "2021", "tactical-alliance-neutron-star-class-bulk-cruiser-medium" },
        { "2022", "tactical-alliance-neutron-star-class-bulk-cruiser-far" },
        { "2030", "tactical-alliance-assault-frigate-mark-1-close" },
        { "2031", "tactical-alliance-assault-frigate-mark-1-medium" },
        { "2032", "tactical-alliance-assault-frigate-mark-1-far" },
        { "2040", "tactical-alliance-ef76-nebulon-b-escort-frigate-close" },
        { "2041", "tactical-alliance-ef76-nebulon-b-escort-frigate-medium" },
        { "2042", "tactical-alliance-ef76-nebulon-b-escort-frigate-far" },
        { "2050", "tactical-alliance-quasar-fire-class-bulk-cruiser-close" },
        { "2051", "tactical-alliance-quasar-fire-class-bulk-cruiser-medium" },
        { "2052", "tactical-alliance-quasar-fire-class-bulk-cruiser-far" },
        { "2060", "tactical-alliance-cr90-corellian-corvette-close" },
        { "2061", "tactical-alliance-cr90-corellian-corvette-medium" },
        { "2062", "tactical-alliance-cr90-corellian-corvette-far" },
        { "2070", "tactical-alliance-medium-transport-close" },
        { "2071", "tactical-alliance-medium-transport-medium" },
        { "2072", "tactical-alliance-medium-transport-far" },
        { "2080", "tactical-alliance-bulk-transport-close" },
        { "2081", "tactical-alliance-bulk-transport-medium" },
        { "2082", "tactical-alliance-bulk-transport-far" },
        { "2090", "tactical-alliance-dp20-frigate-corellian-gunship-close" },
        { "2091", "tactical-alliance-dp20-frigate-corellian-gunship-medium" },
        { "2092", "tactical-alliance-dp20-frigate-corellian-gunship-far" },
        { "2100", "tactical-alliance-republic-dreadnaught-class-heavy-cruiser-close" },
        { "2101", "tactical-alliance-republic-dreadnaught-class-heavy-cruiser-medium" },
        { "2102", "tactical-alliance-republic-dreadnaught-class-heavy-cruiser-far" },
        { "2110", "tactical-alliance-cc-7700-frigate-close" },
        { "2111", "tactical-alliance-cc-7700-frigate-medium" },
        { "2112", "tactical-alliance-cc-7700-frigate-far" },
        { "2120", "tactical-alliance-cc-9600-frigate-close" },
        { "2121", "tactical-alliance-cc-9600-frigate-medium" },
        { "2122", "tactical-alliance-cc-9600-frigate-far" },
        { "2130", "tactical-alliance-bulwark-class-battlecruiser-mark-3-close" },
        { "2131", "tactical-alliance-bulwark-class-battlecruiser-mark-3-medium" },
        { "2132", "tactical-alliance-bulwark-class-battlecruiser-mark-3-far" },
        { "2140", "tactical-alliance-liberator-class-cruiser-close" },
        { "2141", "tactical-alliance-liberator-class-cruiser-medium" },
        { "2142", "tactical-alliance-liberator-class-cruiser-far" },
        { "2150", "tactical-alliance-dauntless-class-heavy-cruiser-close" },
        { "2151", "tactical-alliance-dauntless-class-heavy-cruiser-medium" },
        { "2152", "tactical-alliance-dauntless-class-heavy-cruiser-far" },
        { "2510", "tactical-empire-strike-class-medium-cruiser-close" },
        { "2511", "tactical-empire-strike-class-medium-cruiser-medium" },
        { "2512", "tactical-empire-strike-class-medium-cruiser-far" },
        { "2520", "tactical-empire-lancer-class-frigate-close" },
        { "2521", "tactical-empire-lancer-class-frigate-medium" },
        { "2522", "tactical-empire-lancer-class-frigate-far" },
        { "2530", "tactical-empire-dominator-interdictor-class-star-destroyer-close" },
        { "2531", "tactical-empire-dominator-interdictor-class-star-destroyer-medium" },
        { "2532", "tactical-empire-dominator-interdictor-class-star-destroyer-far" },
        { "2540", "tactical-empire-carrack-class-light-cruiser-close" },
        { "2541", "tactical-empire-carrack-class-light-cruiser-medium" },
        { "2542", "tactical-empire-carrack-class-light-cruiser-far" },
        { "2550", "tactical-empire-victory-class-star-destroyer-mark-1-close" },
        { "2551", "tactical-empire-victory-class-star-destroyer-mark-1-medium" },
        { "2552", "tactical-empire-victory-class-star-destroyer-mark-1-far" },
        { "2560", "tactical-empire-imperial-1-class-star-destroyer-close" },
        { "2561", "tactical-empire-imperial-1-class-star-destroyer-medium" },
        { "2562", "tactical-empire-imperial-1-class-star-destroyer-far" },
        { "2570", "tactical-empire-executor-class-star-dreadnought-close" },
        { "2571", "tactical-empire-executor-class-star-dreadnought-medium" },
        { "2572", "tactical-empire-executor-class-star-dreadnought-far" },
        { "2580", "tactical-empire-assault-transport-close" },
        { "2581", "tactical-empire-assault-transport-medium" },
        { "2582", "tactical-empire-assault-transport-far" },
        { "2590", "tactical-empire-galleon-close" },
        { "2591", "tactical-empire-galleon-medium" },
        { "2592", "tactical-empire-galleon-far" },
        { "2600", "tactical-empire-victory-2-class-star-destroyer-close" },
        { "2601", "tactical-empire-victory-2-class-star-destroyer-medium" },
        { "2602", "tactical-empire-victory-2-class-star-destroyer-far" },
        { "2610", "tactical-empire-imperial-2-class-star-destroyer-close" },
        { "2611", "tactical-empire-imperial-2-class-star-destroyer-medium" },
        { "2612", "tactical-empire-imperial-2-class-star-destroyer-far" },
        { "2620", "tactical-empire-star-galleon-class-frigate-close" },
        { "2621", "tactical-empire-star-galleon-class-frigate-medium" },
        { "2622", "tactical-empire-star-galleon-class-frigate-far" },
        { "2630", "tactical-empire-ton-falk-class-imperial-escort-carrier-close" },
        { "2631", "tactical-empire-ton-falk-class-imperial-escort-carrier-medium" },
        { "2632", "tactical-empire-ton-falk-class-imperial-escort-carrier-far" },
        { "2640", "tactical-empire-imperial-dreadnaught-class-heavy-cruiser-close" },
        { "2641", "tactical-empire-imperial-dreadnaught-class-heavy-cruiser-medium" },
        { "2642", "tactical-empire-imperial-dreadnaught-class-heavy-cruiser-far" },
    };

    Dictionary<string, string> Tactical_303_Names = new Dictionary<string, string>
    {
        { "4000", "tactical-alliance-x-wing-red-close" },
        { "4001", "tactical-alliance-x-wing-blue-close" },
        { "4002", "tactical-alliance-x-wing-green-close" },
        { "4003", "tactical-alliance-x-wing-gold-close" },
        { "4004", "tactical-alliance-x-wing-gray-close" },
        { "4005", "tactical-alliance-x-wing-red-far" },
        { "4006", "tactical-alliance-x-wing-blue-far" },
        { "4007", "tactical-alliance-x-wing-gold-far" },
        { "4008", "tactical-alliance-x-wing-green-far" },
        { "4009", "tactical-alliance-x-wing-gray-far" },
        { "4010", "tactical-alliance-y-wing-red-close" },
        { "4011", "tactical-alliance-y-wing-blue-close" },
        { "4012", "tactical-alliance-y-wing-green-close" },
        { "4013", "tactical-alliance-y-wing-gold-close" },
        { "4014", "tactical-alliance-y-wing-gray-close" },
        { "4015", "tactical-alliance-y-wing-red-far" },
        { "4016", "tactical-alliance-y-wing-blue-far" },
        { "4017", "tactical-alliance-y-wing-green-far" },
        { "4018", "tactical-alliance-y-wing-gold-far" },
        { "4019", "tactical-alliance-y-wing-gray-far" },
        { "4020", "tactical-alliance-a-wing-red-close" },
        { "4021", "tactical-alliance-a-wing-blue-close" },
        { "4022", "tactical-alliance-a-wing-green-close" },
        { "4023", "tactical-alliance-a-wing-gold-close" },
        { "4024", "tactical-alliance-a-wing-gray-close" },
        { "4025", "tactical-alliance-a-wing-red-far" },
        { "4026", "tactical-alliance-a-wing-blue-far" },
        { "4027", "tactical-alliance-a-wing-green-far" },
        { "4028", "tactical-alliance-a-wing-gold-far" },
        { "4029", "tactical-alliance-a-wing-gray-far" },
        { "4030", "tactical-alliance-b-wing-red-close" },
        { "4031", "tactical-alliance-b-wing-blue-close" },
        { "4032", "tactical-alliance-b-wing-green-close" },
        { "4033", "tactical-alliance-b-wing-gold-close" },
        { "4034", "tactical-alliance-b-wing-gray-close" },
        { "4035", "tactical-alliance-b-wing-red-far" },
        { "4036", "tactical-alliance-b-wing-blue-far" },
        { "4037", "tactical-alliance-b-wing-green-far" },
        { "4038", "tactical-alliance-b-wing-gold-far" },
        { "4039", "tactical-alliance-b-wing-gray-far" },
        { "4100", "tactical-empire-tie-fighter-red-close" },
        { "4101", "tactical-empire-tie-fighter-blue-close" },
        { "4102", "tactical-empire-tie-fighter-green-close" },
        { "4103", "tactical-empire-tie-fighter-gold-close" },
        { "4104", "tactical-empire-tie-fighter-gray-close" },
        { "4105", "tactical-empire-tie-fighter-red-far" },
        { "4106", "tactical-empire-tie-fighter-blue-far" },
        { "4107", "tactical-empire-tie-fighter-green-far" },
        { "4108", "tactical-empire-tie-fighter-gold-far" },
        { "4109", "tactical-empire-tie-fighter-gray-far" },
        { "4110", "tactical-empire-tie-interceptor-red-close" },
        { "4111", "tactical-empire-tie-interceptor-blue-close" },
        { "4112", "tactical-empire-tie-interceptor-green-close" },
        { "4113", "tactical-empire-tie-interceptor-gold-close" },
        { "4114", "tactical-empire-tie-interceptor-gray-close" },
        { "4115", "tactical-empire-tie-interceptor-red-far" },
        { "4116", "tactical-empire-tie-interceptor-blue-far" },
        { "4117", "tactical-empire-tie-interceptor-green-far" },
        { "4118", "tactical-empire-tie-interceptor-gold-far" },
        { "4119", "tactical-empire-tie-interceptor-gray-far" },
        { "4120", "tactical-empire-tie-bomber-red-close" },
        { "4121", "tactical-empire-tie-bomber-blue-close" },
        { "4122", "tactical-empire-tie-bomber-green-close" },
        { "4123", "tactical-empire-tie-bomber-gold-close" },
        { "4124", "tactical-empire-tie-bomber-gray-close" },
        { "4125", "tactical-empire-tie-bomber-red-far" },
        { "4126", "tactical-empire-tie-bomber-blue-far" },
        { "4127", "tactical-empire-tie-bomber-green-far" },
        { "4128", "tactical-empire-tie-bomber-gold-far" },
        { "4129", "tactical-empire-tie-bomber-gray-far" },
        { "4130", "tactical-empire-tie-defender-red-close" },
        { "4131", "tactical-empire-tie-defender-blue-close" },
        { "4132", "tactical-empire-tie-defender-green-close" },
        { "4133", "tactical-empire-tie-defender-gold-close" },
        { "4134", "tactical-empire-tie-defender-gray-close" },
        { "4135", "tactical-empire-tie-defender-red-far" },
        { "4136", "tactical-empire-tie-defender-blue-far" },
        { "4137", "tactical-empire-tie-defender-green-far" },
        { "4138", "tactical-empire-tie-defender-gold-far" },
        { "4139", "tactical-empire-tie-defender-gray-far" },
        { "5020", "tactical-empire-deathstar-2-under-construction" },
    };

    Dictionary<string, string> Tactical_Bitmap_Names = new Dictionary<string, string>
    {
        { "2201", "tactical-ackbar" },
        { "2202", "tactical-afyon" },
        { "2203", "tactical-kaiya-andrimetrum" },
        { "2204", "tactical-wedge-antilles" },
        { "2205", "tactical-lando-calrissian" },
        { "2206", "tactical-chewbacca" },
        { "2207", "tactical-covell" },
        { "2208", "tactical-daala" },
        { "2209", "tactical-bren-derlin" },
        { "2210", "tactical-jan-dodonna" },
        { "2211", "tactical-dorja" },
        { "2212", "tactical-drayson" },
        { "2214", "tactical-emperor-palpatine" },
        { "2215", "tactical-bin-essada" },
        { "2216", "tactical-niles-ferrier" },
        { "2217", "tactical-borsk-fey'lya" },
        { "2218", "tactical-griff" },
        { "2219", "tactical-grammel" },
        { "2220", "tactical-garm-bel-iblis" },
        { "2221", "tactical-garindan" },
        { "2222", "tactical-jerjerrod" },
        { "2223", "tactical-roget-jiriss" },
        { "2225", "tactical-talon-karrde" },
        { "2226", "tactical-klev" },
        { "2227", "tactical-labansat" },
        { "2228", "tactical-bevel-lemelisk" },
        { "2229", "tactical-luke-knight" },
        { "2230", "tactical-luke-skywalker" },
        { "2231", "tactical-crix-madine" },
        { "2232", "tactical-ma'w'shiye" },
        { "2233", "tactical-menndo" },
        { "2234", "tactical-mon-mothma" },
        { "2235", "tactical-narra" },
        { "2236", "tactical-needa" },
        { "2237", "tactical-huoba-neva" },
        { "2239", "tactical-bane-nothos" },
        { "2240", "tactical-noval-garaint" },
        { "2241", "tactical-leia-organa" },
        { "2242", "tactical-orlok" },
        { "2243", "tactical-orrimaarko" },
        { "2244", "tactical-ozzel" },
        { "2245", "tactical-page" },
        { "2246", "tactical-pellaeon" },
        { "2247", "tactical-piett" },
        { "2248", "tactical-mazer-rackus" },
        { "2249", "tactical-tura-raftican" },
        { "2250", "tactical-carlist-rieekan" },
        { "2251", "tactical-shenir-rix" },
        { "2253", "tactical-screed" },
        { "2254", "tactical-syub-snunb" },
        { "2255", "tactical-han-solo" },
        { "2256", "tactical-adar-tallon" },
        { "2257", "tactical-pter-thanas" },
        { "2258", "tactical-thrawn" },
        { "2260", "tactical-darth-vader" },
        { "2261", "tactical-veers" },
        { "2262", "tactical-villar" },
        { "2263", "tactical-sarin-virgilio" },
        { "2264", "tactical-vanden-willard" },
        { "2265", "tactical-zuggs" },
        { "2266", "tactical-brandei" },
    };
    
    #endregion
}