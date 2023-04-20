using LibraryAutomation.Entities;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.Book
{
    public partial class BookList : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public BookList()
        {
            InitializeComponent();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Books
                .Include(x => x.Author)
                .Include(x => x.Category)
                .Include(x => x.Shelve)
                .Include(x => x.Hall)
                .Include(x => x.Cabinet)
                .Include(x => x.Publisher)
                .Select(x => new
                {
                    x.Id,
                    x.Title,
                    AuthorName = x.Author.AuthorName + " " + x.Author.AuthorSurname,
                    x.Category.CategoryName,
                    x.Description,
                    x.Publisher.PublisherName,
                    x.Shelve.ShelveNo,
                    x.Hall.HallNo,
                    x.Cabinet.CabinetNo,
                    x.Rented,
                }).ToList();
        }

        public void BookList_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Books
                .Include(x => x.Author)
                .Include(x => x.Category)
                .Include(x => x.Shelve)
                .Include(x => x.Hall)
                .Include(x => x.Cabinet)
                .Include(x => x.Publisher)
                .Select(x => new
                {
                    x.Id,
                    x.Title,
                    AuthorName = x.Author.AuthorName + " " + x.Author.AuthorSurname,
                    x.Category.CategoryName,
                    x.Description,
                    x.Publisher.PublisherName,
                    x.Shelve.ShelveNo,
                    x.Hall.HallNo,
                    x.Cabinet.CabinetNo,
                    x.Rented,
                }).ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BookAdd add = new BookAdd();
            add.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BookUpdate update = new BookUpdate();
            update.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            update.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            update.comboBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            update.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            update.comboBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            update.comboBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            update.comboBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            update.comboBox6.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            //if (dataGridView1.CurrentRow.Cells[5].Value.Equals(true))
            //{
            //    update.radioButton1.Checked = true;
            //}
            //else
            //{
            //    update.radioButton2.Checked = true;
            //}
            update.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            BookRemove remove = new BookRemove();
            remove.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            remove.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            remove.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            remove.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            remove.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            remove.comboBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            remove.comboBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            remove.comboBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            remove.comboBox6.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[5].Value.Equals(true))
            {
                remove.radioButton1.Checked = true;
            }
            else
            {
                remove.radioButton2.Checked = true;
            }
            remove.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void updateTable()
        {
            dataGridView1.DataSource = _db.Books
                .Include(x => x.Author)
                .Include(x => x.Category)
                .Include(x => x.Shelve)
                .Include(x => x.Hall)
                .Include(x => x.Cabinet)
                .Include(x => x.Publisher)
                .Select(x => new
                {
                    x.Id,
                    x.Title,
                    V = x.Author.AuthorName + " " + x.Author.AuthorSurname,
                    x.Category.CategoryName,
                    x.Description,
                    x.Publisher.PublisherName,
                    x.Shelve.ShelveNo,
                    x.Hall.HallNo,
                    x.Cabinet.CabinetNo,
                    x.Rented,
                }).ToList();
        }
    }
}
