using System;
using System.Windows.Forms;
using LibraryAutomation.Pages.Book;
using LibraryAutomation.Pages.Employee;
using LibraryAutomation.Pages.Loan;
using LibraryAutomation.Pages.Member;
using LibraryAutomation.Pages.Specification.Author;
using LibraryAutomation.Pages.Specification.Cabinet;
using LibraryAutomation.Pages.Specification.Category;
using LibraryAutomation.Pages.Specification.Hall;
using LibraryAutomation.Pages.Specification.Publisher;
using LibraryAutomation.Pages.Specification.Shelve;

namespace LibraryAutomation
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void üyeEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MemberList member = new MemberList();
            member.Show();
        }

        private void personelEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EmployeeList employee = new EmployeeList();
            employee.Show();
        }

        private void kitapListeleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BookList book = new BookList();
            book.Show();
        }

        private void kitapVerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoanList giveBook = new LoanList();
            giveBook.Show();
        }

        private void kitapTürleriToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CategoryList categoryList = new CategoryList();
            categoryList.Show();
        }

        private void yayınEviToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SpecPublisher publisher = new SpecPublisher();
            publisher.Show();
        }

        private void yazarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SpecAuthor author = new SpecAuthor();
            author.Show();
        }

        private void dolaplarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SpecCabinet cabinet = new SpecCabinet();
            cabinet.Show();
        }

        private void salonlarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SpecHall hall = new SpecHall();
            hall.Show();
        }

        private void raflarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SpecShelve shelve = new SpecShelve();
            shelve.Show();
        }
    }
}