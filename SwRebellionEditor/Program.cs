using System.Diagnostics;
using Vestris.ResourceLib;

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
            //var t1 = DatFile.Load<CAPSHPSD>("E:\\star wars rebellion\\GData\\CAPSHPSD.DAT");
            //t1.Save("E:\\star wars rebellion\\GData\\CAPSHPSD2.DAT");
            //var t2 = DatFile.Load<DEFFACSD>("E:\\star wars rebellion\\GData\\DEFFACSD.DAT");
            //t2.Save("E:\\star wars rebellion\\GData\\DEFFACSD2.DAT");
            //var t3 = DatFile.Load<FIGHTSD>("E:\\star wars rebellion\\GData\\FIGHTSD.DAT");
            //t3.Save("E:\\star wars rebellion\\GData\\FIGHTSD2.DAT");
            //var t4 = DatFile.Load<MJCHARSD>("E:\\star wars rebellion\\GData\\MJCHARSD.DAT");
            //t4.Save("E:\\star wars rebellion\\GData\\MJCHARSD2.DAT");
            //var t5 = DatFile.Load<MANFACSD>("E:\\star wars rebellion\\GData\\MANFACSD.DAT");
            //t5.Save("E:\\star wars rebellion\\GData\\MANFACSD2.DAT");
            //var t6 = DatFile.Load<MNCHARSD>("E:\\star wars rebellion\\GData\\MNCHARSD.DAT");
            //t6.Save("E:\\star wars rebellion\\GData\\MNCHARSD2.DAT");
            //var t7 = DatFile.Load<PROFACSD>("E:\\star wars rebellion\\GData\\PROFACSD.DAT");
            //t7.Save("E:\\star wars rebellion\\GData\\PROFACSD2.DAT");
            //var t8 = DatFile.Load<SPECFCSD>("E:\\star wars rebellion\\GData\\SPECFCSD.DAT");
            //t8.Save("E:\\star wars rebellion\\GData\\SPECFCSD2.DAT");
            //var t9 = DatFile.Load<TROOPSD>("E:\\star wars rebellion\\GData\\TROOPSD.DAT");
            //t9.Save("E:\\star wars rebellion\\GData\\TROOPSD2.DAT");
            //var t10 = DatFile.Load<SYSTEMSD>("E:\\star wars rebellion\\GData\\SYSTEMSD.DAT");
            //t10.Save("E:\\star wars rebellion\\GData\\SYSTEMSD2.DAT");
            //var t11 = DatFile.Load<SECTORSD>("E:\\star wars rebellion\\GData\\SECTORSD.DAT");
            //t11.Save("E:\\star wars rebellion\\GData\\SECTORSD2.DAT");
            //var t12 = DatFile.Load<GNPRTB>("E:\\star wars rebellion\\GData\\GNPRTB.DAT");
            //t12.Save("E:\\star wars rebellion\\GData\\GNPRTB2.DAT");
            //var t13 = DatFile.Load<SYFCCRTB>("E:\\star wars rebellion\\GData\\SYFCCRTB.DAT");
            //t13.Save("E:\\star wars rebellion\\GData\\SYFCCRTB2.DAT");
            //var t14 = DatFile.Load<SYFCRMTB>("E:\\star wars rebellion\\GData\\SYFCRMTB.DAT");
            //t14.Save("E:\\star wars rebellion\\GData\\SYFCRMTB2.DAT");
            //var t15 = DatFile.Load<CMUNALTB>("E:\\star wars rebellion\\GData\\CMUNALTB.DAT");
            //t15.Save("E:\\star wars rebellion\\GData\\CMUNALTB2.DAT");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}