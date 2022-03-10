namespace SwRebellionEditor
{
    public class MJCHARSD : DatFile
    {
        public uint UnknownHeader1;
        [ArraySize]
        public uint MajorCharactersCount;
        public uint FamilyIdHeader;
        public uint UnknownHeader2;
        public MJCHARSD_Character[] MajorCharacters;
    }
    public class MJCHARSD_Character
    {
        public uint UnitId;
        public uint unknown1;
        public uint prodFacilityNum;
        public uint unknown2;
        public uint FamilyId;
        public ushort TextStraDllId;
        public ushort unknown3;
        public uint IsAllianceUnit;
        public uint IsEmpireUnit;
        public uint conCost;
        public uint maintCost;
        public uint researchNum;
        public uint researchDiff;
        public uint DiplomacyBase;
        public uint DiplomacyVariance;
        public uint EspionageBase;
        public uint EspionageVariance;
        public uint ShipResearchBase;
        public uint ShipResearchVariance;
        public uint TroopsResearchBase;
        public uint troopsReseachVariance;
        public uint FacilitiesResearchBase;
        public uint FacilitiesResearchVariance;
        public uint CombatBase;
        public uint CombatVariance;
        public uint leadershipBase;
        public uint leadershipVar;
        public uint LoyaltyBase;
        public uint LoyaltyVariance;
        public uint JediProbabilityBase;
        public uint IsKnownJedi;
        public uint JediLevelBase;
        public uint JediLevelVariance;
        public uint CanBeAdmiral;
        public uint CanBeCommander;
        public uint CanBeGeneral;
        public uint IsUnableToBetray;
        public uint IsJediTrainer;
        [Ignore]
        public string EncyclopediaName;
        [Ignore]
        public string EncyclopediaDescription;
    }
}
