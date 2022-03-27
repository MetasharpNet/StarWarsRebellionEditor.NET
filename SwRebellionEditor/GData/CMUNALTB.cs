namespace SwRebellionEditor
{
    public class CMUNALTB : DatFile
    {
        public uint UnknownHeader1; // 1
        [ArraySize]
        public uint CapitalShipsCount; // 12
        public uint FamilyIdHeader; // 20
        public byte[] SeedFamilyTableEntry = new byte[20]; // "SeedFamilyTableEntry" as 1 byte per char
        public CMUNALTB_CapitalShip[] CapitalShips;
    }
    public class CMUNALTB_CapitalShip
    {
        public uint unknown1; // index based 1
        public uint unknown2; 
        public uint percChance;
        public uint unknown4;
        public uint unknown5;
        [ArraySize]
        public uint CargosCount;
        public CMUNALTB_Cargo[] Cargos;
    }
    public class CMUNALTB_Cargo
    {
        public uint RecNum; // 1
        public uint RecType; // 0
        public ushort Unknown3; // index based 0
        public byte Unknown4; // 0
        public byte CargoType; // 16:Troop, 28:Fighter, 60: SpecOp
        public override string ToString()
        {
            switch (CargoType)
            {
                case 16: // 0x10
                    return "Troop";
                case 28: // 0x1C
                    return "Fighter";
                case 60: // 0x3C
                    return "SpecOp";
                default:
                    return "";
            }
        }
    }
}
