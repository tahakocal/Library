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

            // G�R�� YAPMA ��LEMLER�N� ATLAMAK ���N 

            //      Application.Run(new HomePage());

            // KULLANAB�L�RS�N�Z
        }
    }
}