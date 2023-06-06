using LibraryAutomation.Pages;
using System;
using System.Windows.Forms;

namespace LibraryAutomation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new HomePage());

            // GÝRÝÞ YAPMA ÝÞLEMLERÝNÝ ATLAMAK ÝÇÝN 

            //      Application.Run(new HomePage());

            // KULLANABÝLÝRSÝNÝZ
        }
    }
}