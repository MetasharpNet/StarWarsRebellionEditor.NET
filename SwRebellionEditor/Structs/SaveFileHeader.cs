namespace SwRebellionEditor;

/// <summary>
/// Header of a Star Wars: Rebellion SAVEGAME.NNN file.
/// No magic bytes — file starts with a length-prefixed save name.
/// </summary>
public struct SaveFileHeader
{
    public ushort NameLength;      // u16 LE
    public string SaveName;        // ASCII bytes, NameLength long
    public uint FormatVersion;     // always 1 in observed saves
    public uint Reserved1;          // always 0
    public uint Reserved2;          // always 1
    public uint SaveIteration;     // increments per save (1, 2, 3, ...)
}
