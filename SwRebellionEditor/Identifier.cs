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
}
