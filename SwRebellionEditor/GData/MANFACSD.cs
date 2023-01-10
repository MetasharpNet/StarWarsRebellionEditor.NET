namespace SwRebellionEditor
{
    public class MANFACSD : DatFile
    {
        public uint Field1_1; // 1
        [ArraySize]
        public uint ManufacturingFacilitiesCount; // 6
        public uint FamilyId; // 40
        public uint Field4_44; // 44
        public MANFACSD_ManufacturingFacility[] ManufacturingFacilities;
    }
    public class MANFACSD_ManufacturingFacility
    {
        public uint Id;
        public uint Field2_1;
        public uint ProductionFamily;
        public uint NextProductionFamily;
        public uint FamilyId;
        public ushort TextStraDllId;
        public ushort Field7_2;
        public uint IsAlliance;
        public uint IsEmpire;
        public uint RefinedMaterialCost;
        public uint MaintenanceCost;
        public uint ResearchOrder;
        public uint ResearchDifficulty;
        public uint BombardmentDefense;
        public uint ProcessingRate;
        [Ignore]
        public string Name;
        [Ignore]
        public string EncyclopediaDescription;
    }
}