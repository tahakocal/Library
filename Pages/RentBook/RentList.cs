using LibraryAutomation.Entities;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.RentBook
{
    public partial class RentList : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public RentList()
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
                }).Where(x => x.Rented == false).ToList();

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
                    x.BookId,
                    x.Book.Title,
                    x.MemberId,
                    x.Member.Name,
                    x.Member.Surname,
                    x.Member.Email,
                    x.From,
                    x.To,
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
            GiveBook give = new GiveBook();
            give.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            give.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            give.textBox3.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            give.textBox4.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            give.textBox5.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            give.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TakeBook take = new TakeBook();
            take.textBox1.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            take.textBox2.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            take.textBox3.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            take.textBox4.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            take.textBox5.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
            take.textBox6.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            take.dateTimePicker1.Value = Convert.ToDateTime(dataGridView3.CurrentRow.Cells[7].Value);
            take.dateTimePicker2.Value = Convert.ToDateTime(dataGridView3.CurrentRow.Cells[8].Value);
            take.ShowDialog();
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
                }).Where(x => x.Rented == false).ToList();

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
                    x.BookId,
                    x.Book.Title,
                    x.MemberId,
                    x.Member.Name,
                    x.Member.Surname,
                    x.Member.Email,
                    x.From,
                    x.To,
                    x.CreatedDate
                }).ToList();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
