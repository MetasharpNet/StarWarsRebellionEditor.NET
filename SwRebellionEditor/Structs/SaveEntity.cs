namespace SwRebellionEditor;

/// <summary>
/// An entity record embedded in a save file (Fleet, Ship, Character, Building, etc.).
///
/// Record signature in file: 00 00 [Faction] 00 00 [PositionMarker:0x80|0x90]
/// Followed by: [EntitySubtype:u32] [Count:u32] [NameLength:u16] [Name:ASCII]
///
/// The Identifiers.cs Full Identifier ID can be reconstructed as:
///     (Family &lt;&lt; 24) | EntitySubtype
/// where Family is read from 12 bytes before the record start.
/// </summary>
public class SaveEntity
{
    public int Offset;                           // byte offset within save file
    public Identifiers FullIdentifier;           // from Identifiers.cs (computed)
    public uint EntitySubtype;                   // low 16 bits, stored in record
    public byte Family;                          // high byte, stored 12 bytes before
    public FactionMarker Faction;
    public PositionMarker PositionMarker;        // 0x80 = SectorByte, 0x90 = SystemByte
    public uint Count;                            // typically 1
    public string Name;                           // ASCII, NameLength chars
}

/// <summary>
/// Faction markers observed in save entity records.
/// Empire and Alliance markers appear in pairs (primary + alt) with exactly matching counts.
/// </summary>
public enum FactionMarker : byte
{
    Alliance       = 0x41,    // primary record marker
    Alliance_Alt   = 0x51,    // paired alt record marker (count == Alliance count)
    Alliance_Other = 0x62,    // observed variant
    Empire         = 0x81,    // primary record marker
    Empire_Alt     = 0xA1,    // paired alt record marker (count == Empire count)
    System         = 0x92,    // rare, 1-2 occurrences per save
}

/// <summary>
/// Position marker byte at offset +0x05 of every entity record.
/// Matches Identifiers.cs family byte for sectors and systems.
/// </summary>
public enum PositionMarker : byte
{
    InSector = 0x80,    // Identifiers.SectorByte
    OnSystem = 0x90,    // Identifiers.SystemByte
}
