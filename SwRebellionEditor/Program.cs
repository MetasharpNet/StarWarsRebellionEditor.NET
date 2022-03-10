namespace SwRebellionEditor
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var t1 = DatFile.Load<CAPSHPSD>("E:\\star wars rebellion\\GData\\CAPSHPSD.DAT");
            //t1.Save("E:\\star wars rebellion\\GData\\CAPSHPSD2.DAT");
            var t2 = DatFile.Load<DEFFACSD>("E:\\star wars rebellion\\GData\\DEFFACSD.DAT");
            //t2.Save("E:\\star wars rebellion\\GData\\DEFFACSD2.DAT");
            var t3 = DatFile.Load<FIGHTSD>("E:\\star wars rebellion\\GData\\FIGHTSD.DAT");
            //t3.Save("E:\\star wars rebellion\\GData\\FIGHTSD2.DAT");
            var t4 = DatFile.Load<MJCHARSD>("E:\\star wars rebellion\\GData\\MJCHARSD.DAT");
            //t4.Save("E:\\star wars rebellion\\GData\\MJCHARSD2.DAT");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}