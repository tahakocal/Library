using System;
using System.Windows.Forms;
using LibraryAutomation.Book;
using LibraryAutomation.Employee;
using LibraryAutomation.Member;
using LibraryAutomation.Reports;
using LibraryAutomation.Specification.Author;
using LibraryAutomation.Specification.Cabinet;
using LibraryAutomation.Specification.Category;
using LibraryAutomation.Specification.Hall;
using LibraryAutomation.Specification.Publisher;
using LibraryAutomation.Specification.Shelve;

namespace LibraryAutomation
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void üyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberList member = new MemberList();
            member.Show();
        }

        private void üyeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberRemove member = new MemberRemove();
            member.Show();

        }

        private void üyeGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberRemove member = new MemberRemove();
            member.Show();
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeList employee = new EmployeeList();
            employee.Show();
        }

        private void personelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeRemove employee = new EmployeeRemove();
            employee.Show();
        }

        private void personelGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeUpdate employee = new EmployeeUpdate();
            employee.Show();
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookAdd book = new BookAdd();
            book.Show();
        }

        private void kitapSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookRemove book = new BookRemove();
            book.Show();
        }

        private void kitapListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookList book = new BookList();
            book.Show();
        }

        private void kitapVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoanList giveBook = new LoanList();
            giveBook.Show();
        }

        private void kitapGeriAlmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void üyeleriRaporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportMember report = new ReportMember();
            report.Show();
        }

        private void yazarlarıRaporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportAuthor report = new ReportAuthor();
            report.Show();
        }

        private void personelleriRaporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportEmployee report = new ReportEmployee();
            report.Show();
        }

        private void ödünçVerilenKitaplarıRaporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportGiveBook report = new ReportGiveBook();
            report.Show();
        }

        private void kitapTürleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryList categoryList = new CategoryList();
            categoryList.Show();
        }

        private void yayınEviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpecPublisher publisher = new SpecPublisher();
            publisher.Show();
        }

        private void yazarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpecAuthor author = new SpecAuthor();
            author.Show();
        }

        private void dolaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpecHall hall = new SpecHall();
            hall.Show();
        }

        private void salonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpecCabinet cabinet = new SpecCabinet();
            cabinet.Show();
        }

        private void raflarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpecShelve shelve = new SpecShelve();
            shelve.Show();
        }
    }
}