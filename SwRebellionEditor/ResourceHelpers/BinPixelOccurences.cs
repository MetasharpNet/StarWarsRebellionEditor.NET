namespace SwRebellionEditor;

public class BinPixelOccurences
{
    public byte Occcurences;
    public byte ColorIndex;

    public int RealOccurences => Occcurences == 0 ? 256 : Occcurences;
}
