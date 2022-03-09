using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwRebellionEditor
{
    public class TestDatFile : DatFile
    {
        public uint headerUnknown1;
        [ArraySize]
        public uint headerUnknown2;
        public uint headerFamlyNum;
        public uint headerUnknown3;
        public SubTestDatFile[] ships = new SubTestDatFile[8];
    }

    public class SubTestDatFile
    {
        public uint number;
        public uint unknown1;
        public uint prodFacilityNum;
        public uint unknown2;
        public uint familyNum;
        public ushort textstratNum;
        public ushort unknown3;
        public uint rebel;
        public uint empire;
        public uint conCost;
        public uint maintCost;
        public uint researchNum;
        public uint researchDiff;
        public uint unknown4;
        public uint detection;
        public uint shield;
        public uint sublight;
        public uint maneuverablity;
        public uint hyperdrive;
        public uint hyperdrive2;
        public uint firePowerArc1;
        public uint firePowerArc2;
        public uint firePowerArc3;
        public uint firePowerArc4;
        public uint firePowerArc5;
        public uint firePowerArc6;
        public uint firePowerArc7;
        public uint firePowerArc8;
        public uint firePowerArc9;
        public uint firePowerArc10;
        public uint firePowerArc11;
        public uint firePowerArc12;
        public uint turboLaserRange;
        public uint ionRange;
        public uint laserRange;
        public uint sumTurboLaserFP;
        public uint sumIonFP;
        public uint sumLaserFP;
        public uint sumFP;
        public uint torpedoPower;
        public uint torpedoRange;
        public uint squadronSize;
        public uint bombardment;
        [Ignore]
        public string swrName;
        [Ignore]
        public string swrEncyText;
    }
}
