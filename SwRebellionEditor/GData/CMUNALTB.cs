namespace SwRebellionEditor
{
    public class CMUNALTB : DatFile
    {
        public uint Field1_One; // 1
        [ArraySize]
        public uint UnitsGroupsCount; // 12
        public uint FamilyId; // 20
        public byte[] SeedFamilyTableEntry = new byte[20]; // "SeedFamilyTableEntry" as 1 byte per char
        public CMUNALTB_UnitsGroup[] UnitsGroups;
    }
    public class CMUNALTB_UnitsGroup
    {
        public uint Index; // index based 1
        public uint Field2_One; // 1
        public uint Probability; // 1, 9, 13, 27, 36, 40, 54, 58, 89, 90, 93, 97
        public uint Field4_One; // 1
        public uint Field5_One; // 1
        [ArraySize]
        public uint UnitsCount;
        public CMUNALTB_Unit[] Units;
        public override string ToString()
        {
            return String.Join<CMUNALTB_Unit>(",", Units);
        }

    }
    public class CMUNALTB_Unit
    {
        public uint Field1_One; // 1
        public uint Field2_Zero; // 0
        public uint Unit;
        public override string ToString()
        {
            return Enum.GetName(typeof(Identifiers), Unit);
        }
    }
}
