using LibraryAutomation.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.Specification.Author
{
    public partial class SpecAuthor : Form
    {
        public DatabaseContext _db = new DatabaseContext();

        public SpecAuthor()
        {
            InitializeComponent();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            AuthorAdd add = new AuthorAdd();
            add.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AuthorUpdate update = new AuthorUpdate();
            update.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            update.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            update.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            update.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AuthorRemove remove = new AuthorRemove();
            remove.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            remove.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            remove.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            remove.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            remove.ShowDialog();
        }

        private void SpecAuthor_Load_1(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtAdara.Enabled = true;
            txtSoyadara.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtSoyadara.Enabled = true;
            txtAdara.Enabled = false;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var books = _db.Authors.Where(x => x.AuthorName.Contains(txtAdara.Text)).ToList();

                dataGridView1.DataSource = books.Select(x => new
                {
                    x.Id,
                    x.AuthorName,
                    x.AuthorSurname,
                    x.AuthorDescription,
                }).ToList();
            }
            else if (radioButton2.Checked)
            {
                var books = _db.Authors.Where(x => x.AuthorDescription.Contains(txtSoyadara.Text)).ToList();
                dataGridView1.DataSource = books.Select(x => new
                {
                    x.Id,
                    x.AuthorName,
                    x.AuthorSurname,
                    x.AuthorDescription,
                }).ToList();
            }
        }
    }
}
