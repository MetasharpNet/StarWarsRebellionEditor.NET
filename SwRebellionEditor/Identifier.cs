namespace SwRebellionEditor;

public static class Identifier
{
    public static string ToName(uint enumAsUint)
    {
        if (Enum.IsDefined(typeof(Identifiers), enumAsUint))
            return Enum.GetName(typeof(Identifiers), enumAsUint)!.Replace("__", "-").Replace("_", " ");
        return "";
    }
    public static uint ToValue(string enumAsString)
    {
        enumAsString = enumAsString.Replace(" ", "_").Replace("-", "__");
        return (uint)Enum.Parse(typeof(Identifiers), enumAsString);
    }
    public static bool IsPersonnel(int id)
    {
        var prefix = id >> 24;
        return (uint)Identifiers.MinPersonnelByte <= prefix && prefix <= (uint)Identifiers.MaxPersonnelByte;
    }
    public static bool IsTroop(int id)
    {
        return (id >> 24) == (uint)Identifiers.TroopByte;
    }
    public static bool IsSector(int id)
    {
        return (id >> 24) == (uint)Identifiers.SectorByte;
    }

    #region Alliance
    public static string[] AllianceCapitalShips = new string[]
        {
            "Alliance Dreadnaught",
            "Alliance Escort Carrier",
            "Assault Frigate",
            "Bulk Cruiser",
            "Bulk Transport",
            "Bulwark Battlecruiser",
            "CC-7700 Frigate",
            "CC-9600 Frigate",
            "Corellian Corvette",
            "Corellian Gunship",
            "Dauntless Cruiser",
            "Liberator Cruiser",
            "Medium Transport",
            "Mon Calamari Cruiser",
            "Nebulon-B Frigate"
        };
    public static string[] AllianceUnits = new string[]
        {
            "A-wing",
            "B-wing",
            "X-wing",
            "Y-wing",

            "Alliance Army Regiment",
            "Alliance Fleet Regiment",
            "Mon Calamari Regiment",
            "Sullustan Regiment",
            "Wookie Regiment",
            
            "Bothan Spies",
            "Guerillas",
            "Infiltrators",
            "Longprobe Y-wing Recon Team",
        };
    #endregion

    #region Empire
    public static string[] EmpireCapitalShips = new string[]
        {
            "Assault Transport",
            "Carrack Light Cruiser",
            "Death Star",
            "Galleon",
            "Imperial Dreadnaught",
            "Imperial Escort Carrier",
            "Imperial Star_Destroyer",
            "Imperial II Star Destroyer",
            "Interdictor Cruiser",
            "Lancer Frigate",
            "Star Galleon",
            "Strike Cruiser",
            "Super Star Destroyer",
            "Victory Destroyer",
            "Victory II Star Destroyer"
        };
    public static string[] EmpireUnits = new string[]
        {
            "TIE Bomber",
            "TIE Defender",
            "TIE Fighter",
            "TIE Interceptor",

            "Dark Trooper Regiment",
            "Imperial Army Regiment",
            "Imperial Fleet Regiment",
            "Stormtrooper Regiment",
            "War Droid Regiment",
            
            "Bounty Hunters",
            "Imperial Commandos",
            "Imperial Espionage Droid",
            "Imperial Probe Droid",
            "Noghri Death Commandos",
        };
    #endregion

    #region Neutral
    public static string[] Facilities = new string[]
        {
            "Mine",
            "Refinery",

            "Construction Yard",
            "Advanced Construction Yard",
            "Training Facility",
            "Advanced Training Facility",
            "Orbital Shipyard",
            "Advanced Shipyard",

            "Death Star Shield",
            "GenCore Level I",
            "GenCore Level II",
            "KDY-150",
            "LNR Series I",
            "LNR Series II",

            "Alliance Headquarters",
        };
    #endregion
}
