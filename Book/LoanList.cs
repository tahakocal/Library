using LibraryAutomation.Entities;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace LibraryAutomation.Book
{
    public partial class LoanList : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public LoanList()
        {
            InitializeComponent();
        }

        private void GiveBook_Load(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = _db.Books
                .Include(x => x.Author)
                .Include(x => x.Category)
                .Select(x => new
                {
                    x.Id,
                    x.Title,
                    x.Author.AuthorName,
                    x.Category.CategoryName,
                    x.Description,
                    x.Rented,
                }).ToList();

            dataGridView2.DataSource = _db.Members
                .Include(x => x.Book)
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Surname,
                    x.Email,
                    x.Book.Title,
                    x.Book.Author,
                    x.CreatedDate
                }).ToList();
            dataGridView3.DataSource = _db.RentBooks
                .Include(x => x.Book)
                .Include(x => x.Member)
                .Select(x => new
                {
                    x.Id,
                    x.MemberId,
                    x.Member.Name,
                    x.Member.Surname,
                    x.Member.Email,
                    x.Book,
                    x.Book.Title,
                    x.CreatedDate
                }).ToList();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoanGiveBook give = new LoanGiveBook();
            give.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoanTakeBook take = new LoanTakeBook();
            //take.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //take.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //take.comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //take.comboBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //take.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Books
                .Include(x => x.Author)
                .Include(x => x.Category)
                .Select(x => new
                {
                    x.Id,
                    x.Title,
                    x.Author.AuthorName,
                    x.Category.CategoryName,
                    x.Description,
                    x.Rented,
                }).ToList();

            dataGridView2.DataSource = _db.Members
                .Include(x => x.Book)
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Surname,
                    x.Email,
                    x.Book.Title,
                    x.Book.Author,
                    x.CreatedDate
                }).ToList();
            dataGridView3.DataSource = _db.RentBooks
                .Include(x => x.Book)
                .Include(x => x.Member)
                .Select(x => new
                {
                    x.Id,
                    x.MemberId,
                    x.Member.Name,
                    x.Member.Surname,
                    x.Member.Email,
                    x.Book,
                    x.Book.Title,
                    x.CreatedDate
                }).ToList();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
