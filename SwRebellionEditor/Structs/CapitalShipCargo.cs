namespace SwRebellionEditor
{
    public struct CapitalShipCargo
    {
        public int[] Troops;
        public int[] SpecOps;
        public int[] Fighters;

        public CapitalShipCargo(string i)
        {
            Troops = new int[10];
            SpecOps = new int[9];
            Fighters = new int[8];
        }
    }
}
