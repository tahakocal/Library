using Library.Book;
using Library.Employee;
using Library.Member;
using Library.Reports;
using Library.Specification;
using Library.Specification.Hall;
using Library.Specification.Publisher;

namespace Library
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
            GiveBook giveBook = new GiveBook();
            giveBook.Show();
        }

        private void kitapGeriAlmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
        }

        private void üyeleriRaporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportMember report = new ReportMember();
            report.Show();
        }

        private void yazarlarýRaporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportAuthor report = new ReportAuthor();
            report.Show();
        }

        private void personelleriRaporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportEmployee report = new ReportEmployee();
            report.Show();
        }

        private void ödünçVerilenKitaplarýRaporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportGiveBook report = new ReportGiveBook();
            report.Show();
        }

        private void kitapTürleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpecBook specBook = new SpecBook();
            specBook.Show();
        }

        private void yayýnEviToolStripMenuItem_Click(object sender, EventArgs e)
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