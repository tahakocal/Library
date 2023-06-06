using LibraryAutomation.Entities;
using LibraryAutomation.Pages.Book;
using LibraryAutomation.Pages.Employee;
using LibraryAutomation.Pages.Member;
using LibraryAutomation.Pages.RentBook;
using LibraryAutomation.Pages.Specification.Author;
using LibraryAutomation.Pages.Specification.Cabinet;
using LibraryAutomation.Pages.Specification.Category;
using LibraryAutomation.Pages.Specification.Hall;
using LibraryAutomation.Pages.Specification.Publisher;
using LibraryAutomation.Pages.Specification.Section;
using LibraryAutomation.Pages.Specification.Shelve;
using System;
using System.Linq;
using System.Windows.Forms;
using LibraryAutomation.Pages.Report;

namespace LibraryAutomation.Pages
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
            RentList giveBook = new RentList();
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

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz ?", "Çıkış",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bölümlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SectionList section = new SectionList();
            section.Show();
        }

        private void üyeleriRaporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportMember section = new ReportMember();
            section.ShowDialog();

        }

        private void personelleriRaporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportEmployee section = new ReportEmployee();
            section.ShowDialog();
        }

        private void yazarlarıRaporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportAuthor section = new ReportAuthor();
            section.ShowDialog();
        }

        private void kitaplariRaporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportBook section = new ReportBook();
            section.ShowDialog();
        }

        private void salonlarıRaporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportHall section = new ReportHall();
            section.ShowDialog();
        }

        private void raflarıRaporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportShelve section = new ReportShelve();
            section.ShowDialog();
        }

        private void bölümleriRaporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportSectıon section = new ReportSectıon();
            section.ShowDialog();
        }

        private void yayıncılarıRaporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportPublısher section = new ReportPublısher();
            section.ShowDialog();
        }

        private void kategorileriRaporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportCategory section = new ReportCategory();
            section.ShowDialog();
        }

        private void dolaplarıRaporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportCabinet section = new ReportCabinet();
            section.ShowDialog();
        }
    }
}