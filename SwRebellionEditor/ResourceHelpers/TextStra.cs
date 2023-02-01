namespace SwRebellionEditor;

public static class TextStra
{
    public static ResourceFile Resources;

    public static readonly string LocalizedAdmiral;
    private const ushort LocalizedAdmiralId = 34817;
    public static readonly string LocalizedCommander;
    private const ushort LocalizedCommanderId = 34818;
    public static readonly string LocalizedGeneral;
    private const ushort LocalizedGeneralId = 34816;

    private const ushort AdmiralOffset = 27648;
    private const ushort CommanderOffset = 26624;
    private const ushort GeneralOffset = 28672;

    static TextStra()
    {
        Resources = new ResourceFile(Path.Combine(Settings.Current.GameFolder, "TEXTSTRA.DLL"));
        LocalizedAdmiral = Resources.RT_STRING[LocalizedAdmiralId];
        LocalizedCommander = Resources.RT_STRING[LocalizedCommanderId];
        LocalizedGeneral = Resources.RT_STRING[LocalizedGeneralId];
    }
    public static void SaveCharacterName(ushort id, string text)
    {
        var prevName = Resources.RT_STRING[id];
        Resources.SaveString(id, text);
        if (text.Contains(" "))
            text = text.Substring(text.IndexOf(" ") + 1);
        Resources.SaveString((ushort)(AdmiralOffset + id), LocalizedAdmiral + " " + text);
        Resources.SaveString((ushort)(CommanderOffset + id), LocalizedCommander + " " + text);
        Resources.SaveString((ushort)(GeneralOffset + id), LocalizedGeneral + " " + text);
    }
}
