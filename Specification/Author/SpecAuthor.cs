using System;
using System.Linq;
using System.Windows.Forms;
using LibraryAutomation.Entities;

namespace LibraryAutomation.Specification.Author
{
    public partial class SpecAuthor : Form
    {
        public DatabaseContext _db = new DatabaseContext();

        public SpecAuthor()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Authors
                .Select(x => new
                {
                    x.Id,
                    x.AuthorName,
                    x.AuthorSurname,
                    x.AuthorDescription,
                }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthorAdd add = new AuthorAdd();
            add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AuthorUpdate update = new AuthorUpdate();
            update.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            update.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            update.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            update.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AuthorRemove remove = new AuthorRemove();
            remove.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            remove.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            remove.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            remove.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            remove.ShowDialog();
        }

        private void SpecAuthor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Authors
                .Select(x => new
                {
                    x.Id,
                    x.AuthorName,
                    x.AuthorSurname,
                    x.AuthorDescription,
                }).ToList();
        }
    }
}
