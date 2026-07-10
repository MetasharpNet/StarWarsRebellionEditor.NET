namespace SwRebellionEditor;

/// <summary>
/// A UI message log record embedded in a save file.
/// Captures mission reports, battle events, tutorials seen, notifications, construction status.
///
/// Record format: [8-byte category header pattern] [u16 TextLength] [ASCII Text]
/// </summary>
public class SaveMessage
{
    public int Offset;                  // byte offset within save file
    public MessageCategory Category;
    public string Text = "";             // ASCII, TextLength chars
}

/// <summary>
/// Categories of UI messages stored in save files.
/// Each category has a distinct 8-byte header pattern that precedes the text.
/// </summary>
public enum MessageCategory
{
    MissionReport,         // Pattern: 10 00 00 00 10 00 00 00 ("Leia Organa Mission Report", "Han Solo Captured")
    BattleEvent,           // Pattern: 00 01 00 00 10 00 00 00 ("Orbital bombardment of Bortras")
    TutorialTopic,         // Pattern: 00 02 00 00 10 00 00 00 ("Maintenance Points", "Fleet Window")
    Notification,          // Pattern: 00 02 00 00 00 00 00 00 ("Advice Available", "Furthering Our Cause")
    ConstructionStatus,    // Pattern: 08 00 00 00 10 00 00 00 ("Construction Yard Idle on Klatooine")
}

/// <summary>
/// Byte patterns that identify each message category in the save file.
/// </summary>
public static class MessagePatterns
{
    public static readonly Dictionary<MessageCategory, byte[]> Headers = new()
    {
        [MessageCategory.MissionReport]      = new byte[] {0x10, 0x00, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00},
        [MessageCategory.BattleEvent]        = new byte[] {0x00, 0x01, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00},
        [MessageCategory.TutorialTopic]      = new byte[] {0x00, 0x02, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00},
        [MessageCategory.Notification]       = new byte[] {0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00},
        [MessageCategory.ConstructionStatus] = new byte[] {0x08, 0x00, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00},
    };
}
