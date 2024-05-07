using SwRebellionEditor.ResourceHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SwRebellionEditor;

public partial class ExportForm : ExportDesignForm
{
    #region .ctor

    public ExportForm()
    {
        InitializeComponent();
    }

    #endregion

    #region Events
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

        // --------------------- CSVS ---------------------
        Directory.CreateDirectory("export\\csv");

        var sectorsGameFilePath = Path.Combine(Settings.Current.GDataFolder, "SECTORSD.DAT");
        var sectorsGameFile = DatFile.Load<SECTORSD>(sectorsGameFilePath);
        foreach (var s in sectorsGameFile.Sectors)
        {
            s.Name = ResourcesDlls.Textstra.RT_STRING[s.TextStraDllId];
        }
        File.WriteAllText(".\\export\\csv\\sectors.csv", sectorsGameFile.EntriesToCsv("Sectors"));

        GameFilePath = Path.Combine(Settings.Current.GDataFolder, "SYSTEMSD.DAT");
        GameFile = DatFile.Load<SYSTEMSD>(GameFilePath);
        foreach (var s in GameFile.Systems)
        {
            s.Name = ResourcesDlls.Textstra.RT_STRING[s.TextStraDllId];
            s.EncyclopediaDescription = ResourcesDlls.Encytext.RT_RCDATA[(s.TextStraDllId - 4096).ToString()];
        }
        File.WriteAllText(".\\export\\csv\\systems.csv", GameFile.EntriesToCsv("Systems"));

        var majorCharactersGameFilePath = Path.Combine(Settings.Current.GDataFolder, "MJCHARSD.DAT");
        var majorCharactersGameFile = DatFile.Load<MJCHARSD>(majorCharactersGameFilePath);
        foreach (var mc in majorCharactersGameFile.MajorCharacters)
        {
            mc.Name = ResourcesDlls.Textstra.RT_STRING[mc.TextStraDllId];
            mc.EncyclopediaDescription = ResourcesDlls.Encytext.RT_RCDATA[(mc.TextStraDllId - 4096).ToString()];
        }
        File.WriteAllText(".\\export\\csv\\majorcharacters.csv", majorCharactersGameFile.EntriesToCsv("MajorCharacters"));

        var minorCharactersGameFilePath = Path.Combine(Settings.Current.GDataFolder, "MNCHARSD.DAT");
        var minorCharactersGameFile = DatFile.Load<MNCHARSD>(minorCharactersGameFilePath);
        foreach (var mc in minorCharactersGameFile.MinorCharacters)
        {
            mc.Name = ResourcesDlls.Textstra.RT_STRING[mc.TextStraDllId];
            mc.EncyclopediaDescription = ResourcesDlls.Encytext.RT_RCDATA[(mc.TextStraDllId - 4096).ToString()];
        }
        File.WriteAllText(".\\export\\csv\\minorcharacters.csv", minorCharactersGameFile.EntriesToCsv("MinorCharacters"));

        var troopsGameFilePath = Path.Combine(Settings.Current.GDataFolder, "TROOPSD.DAT");
        var troopsGameFile = DatFile.Load<TROOPSD>(troopsGameFilePath);
        foreach (var t in troopsGameFile.Troops)
        {
            t.Name = ResourcesDlls.Textstra.RT_STRING[t.TextStraDllId];
            t.EncyclopediaDescription = ResourcesDlls.Encytext.RT_RCDATA[(t.TextStraDllId - 4096).ToString()];
        }
        File.WriteAllText(".\\export\\csv\\troops.csv", troopsGameFile.EntriesToCsv("Troops"));

        var specialForcesGameFilePath = Path.Combine(Settings.Current.GDataFolder, "SPECFCSD.DAT");
        var specialForcesGameFile = DatFile.Load<SPECFCSD>(specialForcesGameFilePath);
        foreach (var sf in specialForcesGameFile.SpecialForces)
        {
            sf.Name = ResourcesDlls.Textstra.RT_STRING[sf.TextStraDllId];
            sf.EncyclopediaDescription = ResourcesDlls.Encytext.RT_RCDATA[(sf.TextStraDllId - 4096).ToString()];
        }
        File.WriteAllText(".\\export\\csv\\specialforces.csv", specialForcesGameFile.EntriesToCsv("SpecialForces"));

        var capitalShipsGameFilePath = Path.Combine(Settings.Current.GDataFolder, "CAPSHPSD.DAT");
        var capitalShipsGameFile = DatFile.Load<CAPSHPSD>(capitalShipsGameFilePath);
        foreach (var cs in capitalShipsGameFile.CapitalShips)
        {
            cs.Name = ResourcesDlls.Textstra.RT_STRING[cs.TextStraDllId];
            cs.EncyclopediaDescription = ResourcesDlls.Encytext.RT_RCDATA[(cs.TextStraDllId - 4096).ToString()];
        }
        File.WriteAllText(".\\export\\csv\\capitalships.csv", capitalShipsGameFile.EntriesToCsv("CapitalShips"));

        var fightersGameFilePath = Path.Combine(Settings.Current.GDataFolder, "FIGHTSD.DAT");
        var fightersGameFile = DatFile.Load<FIGHTSD>(fightersGameFilePath);
        foreach (var f in fightersGameFile.Fighters)
        {
            f.Name = ResourcesDlls.Textstra.RT_STRING[f.TextStraDllId];
            f.EncyclopediaDescription = ResourcesDlls.Encytext.RT_RCDATA[(f.TextStraDllId - 4096).ToString()];
        }
        File.WriteAllText(".\\export\\csv\\fighters.csv", fightersGameFile.EntriesToCsv("Fighters"));

        var defenseFacilitiesGameFilePath = Path.Combine(Settings.Current.GDataFolder, "DEFFACSD.DAT");
        var defenseFacilitiesGameFile = DatFile.Load<DEFFACSD>(defenseFacilitiesGameFilePath);
        foreach (var df in defenseFacilitiesGameFile.DefenseFacilities)
        {
            df.Name = ResourcesDlls.Textstra.RT_STRING[df.TextStraDllId];
            df.EncyclopediaDescription = ResourcesDlls.Encytext.RT_RCDATA[(df.TextStraDllId - 4096).ToString()];
        }
        File.WriteAllText(".\\export\\csv\\defensefacilities.csv", defenseFacilitiesGameFile.EntriesToCsv("DefenseFacilities"));

        var manufacturingFacilitiesGameFilePath = Path.Combine(Settings.Current.GDataFolder, "MANFACSD.DAT");
        var manufacturingFacilitiesGameFile = DatFile.Load<MANFACSD>(manufacturingFacilitiesGameFilePath);
        foreach (var mf in manufacturingFacilitiesGameFile.ManufacturingFacilities)
        {
            mf.Name = ResourcesDlls.Textstra.RT_STRING[mf.TextStraDllId];
            mf.EncyclopediaDescription = ResourcesDlls.Encytext.RT_RCDATA[(mf.TextStraDllId - 4096).ToString()];
        }
        File.WriteAllText(".\\export\\csv\\manufacturingfacilities.csv", manufacturingFacilitiesGameFile.EntriesToCsv("ManufacturingFacilities"));

        var productionFacilitiesGameFilePath = Path.Combine(Settings.Current.GDataFolder, "PROFACSD.DAT");
        var productionFacilitiesGameFile = DatFile.Load<PROFACSD>(productionFacilitiesGameFilePath);
        foreach (var pf in productionFacilitiesGameFile.ProductionFacilities)
        {
            pf.Name = ResourcesDlls.Textstra.RT_STRING[pf.TextStraDllId];
            pf.EncyclopediaDescription = ResourcesDlls.Encytext.RT_RCDATA[(pf.TextStraDllId - 4096).ToString()];
        }
        File.WriteAllText(".\\export\\csv\\productionfacilities.csv", productionFacilitiesGameFile.EntriesToCsv("ProductionFacilities"));

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

        // ---------------------------- MDATA ----------------------------
        Directory.CreateDirectory("export\\MDATA");
        files = Directory.GetFiles(Settings.Current.MDATAFolder);
        foreach (var filePath in files)
        {
            var fileName = Path.GetFileName(filePath);
            var extension = Path.GetExtension(fileName).Substring(1);
            var name = NamesMDATA.ContainsKey(extension) ? NamesMDATA[extension] : "";
            // if 3 first bytes are SMK, then it's a video
            var bytes = File.ReadAllBytes(filePath);
            string ext = "wav";
            if (bytes[0] == 0x53 && bytes[1] == 0x4D && bytes[2] == 0x4B)
                ext = "smk";
            var newFileName = extension + "-" + name + "." + ext;
            File.Copy(filePath, Path.Combine(".\\export\\MDATA", newFileName), true);
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
        // facilities
        { "001"  , "edata-facility-mine" },
        { "002"  , "edata-facility-refinery" },
        { "003"  , "edata-facility-orbital-shipyard" },
        { "004"  , "edata-facility-training-facility" },
        { "005"  , "edata-facility-construction-yard" },
        { "006"  , "edata-facility-advanced-shipyard" },
        { "007"  , "edata-facility-advanced-training-facility" },
        { "008"  , "edata-facility-advanced-construction-yard" },
        { "009"  , "edata-facility-kdy-150" },
        { "010"  , "edata-facility-lnr-series-1" },
        { "011"  , "edata-facility-gencore-level-1" },
        { "012"  , "edata-facility-lnr-series-2" },
        { "013"  , "edata-facility-gencore-level-2" },
        { "014"  , "edata-facility-death-star-shield" },
        // troops
        { "015"  , "edata-troop-alliance-alliance-fleet-regiment" },
        { "016"  , "edata-troop-alliance-alliance-army-regiment" },
        { "017"  , "edata-troop-alliance-sullustan-regiment" },
        { "018"  , "edata-troop-alliance-wookiee-regiment" },
        { "019"  , "edata-troop-alliance-mon-calamari-regiment" },
        { "020"  , "edata-troop-empire-stormtrooper-regiment" },
        { "021"  , "edata-troop-empire-imperial-fleet-regiment" },
        { "022"  , "edata-troop-empire-imperial-army-regiment" },
        { "023"  , "edata-troop-empire-war-droid-regiment" },
        { "024"  , "edata-troop-empire-dark-trooper-regiment" },
        // special forces
        { "025"  , "edata-special-force-alliance-guerillas" },
        { "026"  , "edata-special-force-alliance-infiltrators" },
        { "027"  , "edata-special-force-alliance-longprobe-y-wing-recon-team" },
        { "028"  , "edata-special-force-alliance-bothan-spies" },
        { "029"  , "edata-special-force-empire-imperial-probe-droid" },
        { "030"  , "edata-special-force-empire-imperial-espionage-droid" },
        { "031"  , "edata-special-force-empire-imperial-commandos" },
        { "032"  , "edata-special-force-empire-noghri-death-commandos" },
        { "033"  , "edata-special-force-empire-bounty-hunters" },
        // fighters
        { "034"  , "edata-fighter-alliance-a-wing" },
        { "035"  , "edata-fighter-alliance-b-wing" },
        { "036"  , "edata-fighter-alliance-x-wing" },
        { "037"  , "edata-fighter-alliance-y-wing" },
        { "038"  , "edata-fighter-empire-tie-fighter" },
        { "039"  , "edata-fighter-empire-tie-interceptor" },
        { "040"  , "edata-fighter-empire-tie-bomber" },
        { "041"  , "edata-fighter-empire-tie-defender" },
        // capital ships
        { "042"  , "edata-2010-ship-alliance-mon-calamari-cruiser" },
        { "043"  , "edata-2020-ship-alliance-bulk-cruiser" },
        { "044"  , "edata-2030-ship-alliance-assault-frigate" },
        { "045"  , "edata-2040-ship-alliance-nebulon-b-frigate" },
        { "046"  , "edata-2050-ship-alliance-alliance-escort-carrier" },
        { "047"  , "edata-2060-ship-alliance-corellian-corvette" },
        { "048"  , "edata-2070-ship-alliance-medium-transport" },
        { "049"  , "edata-2080-ship-alliance-bulk-transport" },
        { "050"  , "edata-2090-ship-alliance-corellian-gunship" },
        { "051"  , "edata-2100-ship-alliance-alliance-dreadnaught" },
        { "052"  , "edata-2110-ship-alliance-cc-7700-frigate" },
        { "053"  , "edata-2130-ship-alliance-bulwark-battlecruiser" },
        { "054"  , "edata-2140-ship-alliance-liberator-cruiser" },
        { "055"  , "edata-2120-ship-alliance-cc-9600-frigate" },
        { "056"  , "edata-2150-ship-alliance-dauntless-cruiser" },
        { "057"  , "edata-2510-ship-empire-strike-cruiser" },
        { "058"  , "edata-2520-ship-empire-lancer-frigate" },
        { "059"  , "edata-2530-ship-empire-interdictor-cruiser" },
        { "060"  , "edata-2540-ship-empire-carrack-light-cruiser" },
        { "061"  , "edata-2550-ship-empire-victory-destroyer" },
        { "062"  , "edata-2560-ship-empire-imperial-star-destroyer" },
        { "063"  , "edata-2570-ship-empire-super-star-destroyer" },
        { "064"  , "edata-2580-ship-empire-assault-transport" },
        { "065"  , "edata-5010-ship-empire-death-star" },
        { "066"  , "edata-2590-ship-empire-galleon" },
        { "067"  , "edata-2600-ship-empire-victory-2-star-destroyer" },
        { "068"  , "edata-2610-ship-empire-imperial-2-star-destroyer" },
        { "069"  , "edata-2620-ship-empire-star-galleon" },
        { "070"  , "edata-2630-ship-empire-imperial-escort-carrier" },
        { "071"  , "edata-2640-ship-empire-imperial-dreadnaught" },
        // characters
        { "072"  , "edata-character-alliance-mon-mothma" },
        { "073"  , "edata-character-alliance-leia-organa" },
        { "074"  , "edata-character-alliance-luke-skywalker" },
        { "075"  , "edata-character-alliance-han-solo" },
        { "076"  , "edata-character-empire-emperor-palpatine" },
        { "077"  , "edata-character-empire-darth-vader" },
        { "078"  , "edata-character-alliance-ackbar" },
        { "079"  , "edata-character-alliance-wedge-antilles" },
        { "080"  , "edata-character-alliance-lando-calrissian" },
        { "081"  , "edata-character-alliance-chewbacca" },
        { "082"  , "edata-character-alliance-jan-dodonna" },
        { "083"  , "edata-character-alliance-crix-madine" },
        { "084"  , "edata-character-alliance-carlist-rieekan" },
        { "085"  , "edata-character-alliance-afyon" },
        { "086"  , "edata-character-alliance-drayson" },
        { "087"  , "edata-character-alliance-borsk-fey'lya" },
        { "088"  , "edata-character-alliance-tura-raftican" },
        { "089"  , "edata-character-alliance-bren-derlin" },
        { "090"  , "edata-character-alliance-garm-bel-iblis" },
        { "091"  , "edata-character-alliance-talon-karrde" },
        { "092"  , "edata-character-alliance-narra" },
        { "093"  , "edata-character-alliance-huoba-neva" },
        { "094"  , "edata-character-alliance-page" },
        { "095"  , "edata-character-alliance-syub-snunb" },
        { "096"  , "edata-character-alliance-adar-tallon" },
        { "097"  , "edata-character-alliance-sarin-virgilio" },
        { "098"  , "edata-character-alliance-vanden-willard" },
        { "099"  , "edata-character-alliance-roget-jiriss" },
        { "100"  , "edata-character-alliance-kaiya-andrimetrum" },
        { "101"  , "edata-character-alliance-mazer-rackus" },
        { "102"  , "edata-character-alliance-orrimaarko" },
        { "103"  , "edata-character-alliance-ma'w'shiye" },
        { "104"  , "edata-character-empire-jerjerrod" },
        { "105"  , "edata-character-empire-ozzel" },
        { "106"  , "edata-character-empire-piett" },
        { "107"  , "edata-character-empire-veers" },
        { "108"  , "edata-character-empire-brandei" },
        { "109"  , "edata-character-empire-covell" },
        { "110"  , "edata-character-empire-dorja" },
        { "111"  , "edata-character-empire-bin-essada" },
        { "112"  , "edata-character-empire-niles-ferrier" },
        { "113"  , "edata-character-empire-grammel" },
        { "114"  , "edata-character-empire-griff" },
        { "115"  , "edata-character-empire-klev" },
        { "116"  , "edata-character-empire-needa" },
        { "117"  , "edata-character-empire-bane-nothos" },
        { "118"  , "edata-character-empire-orlok" },
        { "119"  , "edata-character-empire-pellaeon" },
        { "120"  , "edata-character-empire-screed" },
        { "121"  , "edata-character-empire-thrawn" },
        { "122"  , "edata-character-empire-zuggs" },
        { "123"  , "edata-character-empire-daala" },
        { "124"  , "edata-character-empire-pter-thanas" },
        { "125"  , "edata-character-empire-bevel-lemelisk" },
        { "126"  , "edata-character-empire-shenir-rix" },
        { "127"  , "edata-character-empire-noval-garaint" },
        { "128"  , "edata-character-empire-garindan" },
        { "129"  , "edata-character-empire-menndo" },
        { "130"  , "edata-character-empire-labansat" },
        { "131"  , "edata-character-empire-villar" },
        // events
        { "132"  , "edata-events-fleet-alliance" },
        { "133"  , "edata-events-fleet-empire" },
        // missions
        { "134"  , "edata-mission-diplomacy-alliance" },
        { "135"  , "edata-mission-diplomacy-empire" },
        { "136"  , "edata-mission-rescue-alliance" },
        { "137"  , "edata-mission-rescue-empire" },
        { "138"  , "edata-mission-sabotage-alliance" },
        { "139"  , "edata-mission-sabotage-empire" },
        { "140"  , "edata-mission-espionage-alliance" },
        { "141"  , "edata-mission-espionage-empire" },
        { "142"  , "edata-mission-ship-design-research-alliance" },
        { "143"  , "edata-mission-ship-design-research-empire" },
        { "146"  , "edata-mission-facility-design-research" },
        { "148"  , "edata-mission-troop-training-research-alliance" },
        { "149"  , "edata-mission-troop-training-research-empire" },
        { "150"  , "edata-mission-reconnaissance-alliance" },
        { "151"  , "edata-mission-reconnaissance-empire" },
        { "152"  , "edata-mission-recruitment-alliance" },
        { "153"  , "edata-mission-recruitment-empire" },
        { "154"  , "edata-mission-abduction-alliance" },
        { "155"  , "edata-mission-abduction-empire" },
        { "156"  , "edata-mission-incite-uprising-alliance" },
        { "157"  , "edata-mission-incite uprising-empire" },
        { "158"  , "edata-mission-death-star-sabotage" },
        { "160"  , "edata-mission-jedi-training-alliance" },
        { "161"  , "edata-mission-jedi-training-empire" },
        { "162"  , "edata-mission-subdue-uprising-alliance" },
        { "163"  , "edata-mission-subdue-uprising-empire" },
        { "164"  , "edata-mission-assassination" },
        // systems (base game)
        { "166"  , "edata-system-01-blue-green" },
        { "167"  , "edata-system-02-dark-green-blue" },
        { "168"  , "edata-system-03-dark-green-blue" },
        { "169"  , "edata-system-04-blue-green" },
        { "170"  , "edata-system-05-blue-brown" },
        { "171"  , "edata-system-06-green-blue" },
        { "172"  , "edata-system-07-blue" },
        { "173"  , "edata-system-08-rock" },
        { "174"  , "edata-system-09-yellow" },
        { "175"  , "edata-system-10-green-blue" },
        { "176"  , "edata-system-11-blue-green" },
        { "177"  , "edata-system-12-green-blue" },
        { "178"  , "edata-system-13-dark-green-blue" },
        { "179"  , "edata-system-14-dark-green" },
        { "180"  , "edata-system-15-orange" },
        { "181"  , "edata-system-16-asteroid" },
        { "182"  , "edata-system-17-brown-blue" },
        { "183"  , "edata-system-18-white" },
        { "184"  , "edata-system-19-blue-green" },
        { "185"  , "edata-system-20-dark-green-blue" },
        { "186"  , "edata-system-21-yellow-ring" },
        { "187"  , "edata-system-22-brown" },
        { "188"  , "edata-system-23-purple-gray" },
        { "189"  , "edata-system-24-red" },
        { "190"  , "edata-system-25-blue-white" },
        { "191"  , "edata-system-26-green-blue" },
        // characters
        { "192"  , "edata-character-alliance-luke-skywalker-jedi-knight" },
        // systems (25th anniv patch)
        { "14001", "edata-system-abregado-rae" },
        { "14002", "edata-system-agamar" },
        { "14003", "edata-system-ahch-to" },
        { "14004", "edata-system-ajan-kloss-(moon)" },
        { "14005", "edata-system-anaxes" },
        { "14006", "edata-system-anoat-(atlas)" },
        { "14007", "edata-system-ansion-(atlas)" },
        { "14008", "edata-system-bakura-(atlas)" },
        { "14009", "edata-system-balmorra" },
        { "14010", "edata-system-belderone" },
        { "14011", "edata-system-belsavis" },
        { "14012", "edata-system-bescane" },
        { "14013", "edata-system-bespin-(gas-giant)-(atlas)" },
        { "14014", "edata-system-bestine-(atlas)" },
        { "14015", "edata-system-bith" },
        { "14016", "edata-system-bonadan-(atlas)" },
        { "14017", "edata-system-boonta" },
        { "14018", "edata-system-borosk" },
        { "14019", "edata-system-bothawui-(atlas)" },
        { "14020", "edata-system-boz-pity-(atlas)" },
        { "14021", "edata-system-brentaal-iv-(atlas)" },
        { "14022", "edata-system-byss-(atlas)" },
        { "14023", "edata-system-cantonica" },
        { "14024", "edata-system-carida" },
        { "14025", "edata-system-cato-neimoidia" },
        { "14026", "edata-system-celanon" },
        { "14027", "edata-system-chandrila" },
        { "14028", "edata-system-chardaan" },
        { "14029", "edata-system-christophsis-(atlas)" },
        { "14030", "edata-system-circumtore" },
        { "14031", "edata-system-commenor" },
        { "14032", "edata-system-concord-dawn" },
        { "14033", "edata-system-corellia-(atlas)" },
        { "14034", "edata-system-corsin" },
        { "14035", "edata-system-coruscant" },
        { "14036", "edata-system-crait" },
        { "14037", "edata-system-csilla-(atlas)" },
        { "14038", "edata-system-cyphar" },
        { "14039", "edata-system-daalang" },
        { "14040", "edata-system-dagobah-(atlas)" },
        { "14041", "edata-system-dantooine-(atlas)" },
        { "14042", "edata-system-dathomir-(atlas)" },
        { "14043", "edata-system-delaya-(alderaan)" },
        { "14044", "edata-system-dellalt" },
        { "14045", "edata-system-dennogra" },
        { "14046", "edata-system-denon" },
        { "14047", "edata-system-devaron" },
        { "14048", "edata-system-dolla" },
        { "14049", "edata-system-d'qar" },
        { "14050", "edata-system-dromund-kaas" },
        { "14051", "edata-system-dubrillion" },
        { "14052", "edata-system-duro-(atlas)" },
        { "14053", "edata-system-eadu" },
        { "14054", "edata-system-earth" },
        { "14055", "edata-system-empress-teta" },
        { "14056", "edata-system-endor-(moon)-(atlas)" },
        { "14057", "edata-system-eriadu-(atlas)" },
        { "14058", "edata-system-esseles" },
        { "14059", "edata-system-exegol" },
        { "14060", "edata-system-exodeen" },
        { "14061", "edata-system-farstine" },
        { "14062", "edata-system-felucia-(atlas)" },
        { "14063", "edata-system-florn" },
        { "14064", "edata-system-fondor-(atlas)" },
        { "14065", "edata-system-formos" },
        { "14066", "edata-system-gamor" },
        { "14067", "edata-system-gamorr-(atlas)" },
        { "14068", "edata-system-geonosis-(atlas)" },
        { "14069", "edata-system-gerrenthum" },
        { "14070", "edata-system-ghorman" },
        { "14071", "edata-system-glee-anselm" },
        { "14072", "edata-system-hapes-(atlas)" },
        { "14073", "edata-system-honoghr-(atlas)" },
        { "14074", "edata-system-hosnian-prime" },
        { "14075", "edata-system-hoth-(atlas)" },
        { "14076", "edata-system-iego-(atlas)" },
        { "14077", "edata-system-ilum" },
        { "14078", "edata-system-iridonia" },
        { "14079", "edata-system-isde-naha" },
        { "14080", "edata-system-ithor-(atlas)" },
        { "14081", "edata-system-jaemus" },
        { "14082", "edata-system-jakku" },
        { "14083", "edata-system-jedha-(moon)" },
        { "14084", "edata-system-kabal" },
        { "14085", "edata-system-kalee-(atlas)" },
        { "14086", "edata-system-kaller" },
        { "14087", "edata-system-kamino-(atlas)" },
        { "14088", "edata-system-karfeddion" },
        { "14089", "edata-system-kashyyyk-(atlas)" },
        { "14090", "edata-system-kef-bir-(moon)" },
        { "14091", "edata-system-keitum" },
        { "14092", "edata-system-kessel" },
        { "14093", "edata-system-kimiji" },
        { "14094", "edata-system-kuat-(atlas)" },
        { "14095", "edata-system-lah'mu" },
        { "14096", "edata-system-lok" },
        { "14097", "edata-system-lothal" },
        { "14098", "edata-system-lotho-minor" },
        { "14099", "edata-system-lutrillia" },
        { "14100", "edata-system-lwhekk" },
        { "14101", "edata-system-makeb" },
        { "14102", "edata-system-malastare-(atlas)" },
        { "14103", "edata-system-manaan" },
        { "14104", "edata-system-mandalore-(atlas)" },
        { "14105", "edata-system-maridun" },
        { "14106", "edata-system-milagro" },
        { "14107", "edata-system-mimban-(circarpous-v)" },
        { "14108", "edata-system-mirial" },
        { "14109", "edata-system-mon-calamari-(atlas)" },
        { "14110", "edata-system-mon-gazza" },
        { "14111", "edata-system-moraband-(korriban)-(atlas)" },
        { "14112", "edata-system-mortis" },
        { "14113", "edata-system-mustafar-(atlas)" },
        { "14114", "edata-system-muunilinst" },
        { "14115", "edata-system-mygeeto-(atlas)" },
        { "14116", "edata-system-naboo-(atlas)" },
        { "14117", "edata-system-nagi-(atlas)" },
        { "14118", "edata-system-nal-hutta-(atlas)" },
        { "14119", "edata-system-nar-shaddaa-(moon)-(atlas)" },
        { "14120", "edata-system-neimoidia-(atlas)" },
        { "14121", "edata-system-nelvaan" },
        { "14122", "edata-system-nevarro" },
        { "14123", "edata-system-nexus-ortai" },
        { "14124", "edata-system-nubia-(atlas)" },
        { "14125", "edata-system-n'zoth-(atlas)" },
        { "14126", "edata-system-onderon-(atlas)" },
        { "14127", "edata-system-ord-mantel-(atlas)" },
        { "14128", "edata-system-ord-trasi" },
        { "14129", "edata-system-ossus-(atlas)" },
        { "14130", "edata-system-pakuuni" },
        { "14131", "edata-system-palanhi" },
        { "14132", "edata-system-parnassos" },
        { "14133", "edata-system-pasaana" },
        { "14134", "edata-system-pax" },
        { "14135", "edata-system-polis-massa" },
        { "14136", "edata-system-quarzite" },
        { "14137", "edata-system-quermia" },
        { "14138", "edata-system-quesh" },
        { "14139", "edata-system-rakata-prime-(lehon)-(atlas)" },
        { "14140", "edata-system-randon" },
        { "14141", "edata-system-rattatak-(atlas)" },
        { "14142", "edata-system-raxus-prime-(atlas)" },
        { "14143", "edata-system-rhen-var-(atlas)" },
        { "14144", "edata-system-rishi-(atlas)" },
        { "14145", "edata-system-rodia-(atlas)" },
        { "14146", "edata-system-ruusan-(atlas)" },
        { "14147", "edata-system-ryloth-(atlas)" },
        { "14148", "edata-system-saleucami-(atlas)" },
        { "14149", "edata-system-savareen" },
        { "14150", "edata-system-scarif" },
        { "14151", "edata-system-sernpidal-(atlas)" },
        { "14152", "edata-system-shadda-bi-boran-(atlas)" },
        { "14153", "edata-system-shili" },
        { "14154", "edata-system-sissubo" },
        { "14155", "edata-system-skako-minor" },
        { "14156", "edata-system-sleheyron" },
        { "14157", "edata-system-sluis-van" },
        { "14158", "edata-system-smuggler's-run" },
        { "14159", "edata-system-socorro" },
        { "14160", "edata-system-sorgan" },
        { "14161", "edata-system-sriluur" },
        { "14162", "edata-system-sullust" },
        { "14163", "edata-system-sy-myrth" },
        { "14164", "edata-system-taanab-(atlas)" },
        { "14165", "edata-system-takodana" },
        { "14166", "edata-system-talus" },
        { "14167", "edata-system-taris" },
        { "14168", "edata-system-tatooine" },
        { "14169", "edata-system-telos-iv" },
        { "14170", "edata-system-tepasi" },
        { "14171", "edata-system-terminus" },
        { "14172", "edata-system-teth-(atlas)" },
        { "14173", "edata-system-the-redoubt-(brask-oto)" },
        { "14174", "edata-system-thyferra-(atlas)" },
        { "14175", "edata-system-tirahnn" },
        { "14176", "edata-system-toydaria-(atlas)" },
        { "14177", "edata-system-tralus" },
        { "14178", "edata-system-trandosha" },
        { "14179", "edata-system-trask-(moon)" },
        { "14180", "edata-system-triton-(atlas)" },
        { "14181", "edata-system-tund-(atlas)" },
        { "14182", "edata-system-tython" },
        { "14183", "edata-system-umbara" },
        { "14184", "edata-system-utapau-(atlas)" },
        { "14185", "edata-system-vandor" },
        { "14186", "edata-system-vinsoth" },
        { "14187", "edata-system-voss" },
        { "14188", "edata-system-wellspring-of-life" },
        { "14189", "edata-system-wobani" },
        { "14190", "edata-system-word-tandell" },
        { "14191", "edata-system-wroona-(moon)" },
        { "14192", "edata-system-yaga-minor" },
        { "14193", "edata-system-yag'dhul" },
        { "14194", "edata-system-yavin-4-(moon)-(atlas)" },
        { "14195", "edata-system-yavin-prime-(gas-giant)" },
        { "14196", "edata-system-zakuul" },
        { "14197", "edata-system-zeltros" },
        { "14198", "edata-system-ziost" },
        { "14199", "edata-system-zonama-sekot-(atlas)" },
        { "14200", "edata-system-zygerria" },
    };

    Dictionary<string, string> NamesMDATA = new Dictionary<string, string>
    {
        { "000", "mdata-lucas_arts_intro" },
        { "001", "mdata-opening_intro" },
        { "003", "mdata-rebel_alliance_intro" },
        { "004", "mdata-empire_intro" },
        { "005", "mdata-end_credits" },
        { "101", "mdata-death_star_fires" },
        { "102", "mdata-rebel_headquarters_destroyed" },
        { "103", "mdata-coruscant_captured" },
        { "104", "mdata-death_star_sabotaged" },
        { "105", "mdata-rebel_alliance_wins" },
        { "106", "mdata-rebel_alliance_defeated" },
        { "107", "mdata-empire_defeated" },
        { "108", "mdata-empire_wins" },
        { "201", "mdata-trench_run_succeeds" },
        { "202", "mdata-trench_run_fails" },
        { "300", "mdata-e6_battle_of_endor_1_medley_0m0-0m35" },
        { "301", "mdata-" },
        { "302", "mdata-e4_main_title,approaching_death_star,tatooine_rdv_1m30-2m26+2m34-2m49+e6_main_title_(story_continues)_4m30-4m50+e6_emperor_2m17-2m41" },
        { "303", "mdata-" },
        { "304", "mdata-" },
        { "305", "mdata-" },
        { "306", "mdata-e6_emperor_arrives,death_of_yoda,obi‐wan_revelation_medley_3m45-6m14" },
        { "307", "mdata-e5_attacking_a_star destroyer_0m59-1m32" },
        { "308", "mdata-e6_sail_barge_assault_alternate_4m27-4m59" },
        { "309", "mdata-e6_emperor_arrives,death_of_yoda,obi‐wan_revelation_medley_7m04-8m06" },
        { "310", "mdata-e5_imperial_march_darth_vader_theme_0m0-0m43+2m52-2m58" },
        { "311", "mdata-e6_emperor_arrives,death_of_yoda,obi‐wan_revelation_medley_0m09-0m46" },
        { "312", "mdata-e5_battle_of_hoth_medley_0m39-1m11" },
        { "313", "mdata-e5_battle_of_hoth_medley_11m03-11m42+fade10s" },
        { "314", "mdata-e5_imperial_march_darth_vader_theme_2m15-3m03" },
        { "315", "mdata-e6_battle_of_endor_3_medley_3m40-4m28" },
    };
    
    #endregion
}