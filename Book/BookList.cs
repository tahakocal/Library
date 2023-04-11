using Library.Entities;
using System.Data;
using System.Data.Entity;

namespace Library.Book
{
    public partial class BookList : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public BookList()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookAdd add = new BookAdd();
            add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookUpdate update = new BookUpdate();
            update.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            update.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            update.comboBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            update.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[5].Value.Equals(true))
            {
                update.radioButton1.Checked = true;
            }
            else
            {
                update.radioButton2.Checked = true;
            }
            update.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookRemove remove = new BookRemove();
            remove.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            remove.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            remove.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            remove.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            remove.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
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

        private void BookList_Load(object sender, EventArgs e)
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

        }
    }
}
