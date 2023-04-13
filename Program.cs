using System;
using System.Windows.Forms;
using LibraryAutomation.Book;
using LibraryAutomation.Employee;
using LibraryAutomation.Member;
using LibraryAutomation.Specification.Author;
using LibraryAutomation.Specification.Hall;
using LibraryAutomation.Specification.Publisher;
using LibraryAutomation.Specification.Shelve;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.Run(new SpecShelve());
        }
    }
}