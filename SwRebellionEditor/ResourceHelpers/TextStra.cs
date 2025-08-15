namespace SwRebellionEditor;

// String Table, RCData, Version Info

public class Textstra : ResourcesDll
{
    public readonly string LocalizedAdmiral;
    private const ushort   LocalizedAdmiralId   = 34817;
    public readonly string LocalizedCommander;
    private const ushort   LocalizedCommanderId = 34818;
    public readonly string LocalizedGeneral;
    private const ushort   LocalizedGeneralId   = 34816;

    private const ushort AdmiralOffset   = 27648;
    private const ushort CommanderOffset = 26624;
    private const ushort GeneralOffset   = 28672;

    public Textstra(string fileName) : base(fileName)
    {
        LocalizedAdmiral   = RT_STRING[LocalizedAdmiralId];
        LocalizedCommander = RT_STRING[LocalizedCommanderId];
        LocalizedGeneral   = RT_STRING[LocalizedGeneralId];
    }
    public void SaveCharacterName(ushort id, string text)
    {
        var prevName = RT_STRING[id];
        SaveString(id, text);
        if (text.Contains(" "))
            text = text.Substring(text.IndexOf(" ") + 1);
        SaveString((ushort)(AdmiralOffset + id), LocalizedAdmiral + " " + text);
        SaveString((ushort)(CommanderOffset + id), LocalizedCommander + " " + text);
        SaveString((ushort)(GeneralOffset + id), LocalizedGeneral + " " + text);
    }
}
