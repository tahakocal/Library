using LibraryAutomation.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.Specification.Publisher
{
    public partial class SpecPublisher : Form
    {
        public DatabaseContext _db = new DatabaseContext();

        public SpecPublisher()
        {
            InitializeComponent();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Publishers
                .Select(x => new
                {
                    x.Id,
                    x.PublisherName,
                }).ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PublisherAdd add = new PublisherAdd();
            add.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PublisherUpdate update = new PublisherUpdate();
            update.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            update.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PublisherRemove remove = new PublisherRemove();
            remove.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            remove.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            remove.ShowDialog();
        }

        private void SpecPublisher_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Publishers
                .Select(x => new
                {
                    x.Id,
                    x.PublisherName,
                }).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var books = _db.Publishers.Where(x => x.PublisherName == txtAdara.Text).ToList();

            dataGridView1.DataSource = books.Select(x => new
            {
                x.Id,
                x.PublisherName,
            }).ToList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "İle Başlayan")
            {
                var books = _db.Publishers.Where(x => x.PublisherName.StartsWith(textBox2.Text)).ToList();
                dataGridView1.DataSource = _db.Publishers
                    .Select(x => new
                    {
                        x.Id,
                        x.PublisherName,
                    }).ToList();
            }
            else if (comboBox1.Text == "İle Biten")
            {
                var books = _db.Publishers.Where(x => x.PublisherName.EndsWith(textBox2.Text)).ToList();
                dataGridView1.DataSource = _db.Publishers
                    .Select(x => new
                    {
                        x.Id,
                        x.PublisherName,
                    }).ToList();

            }
            else if (comboBox1.Text == "İçeren")
            {
                var books = _db.Publishers.Where(x => x.PublisherName.Contains(textBox2.Text)).ToList();
                dataGridView1.DataSource = _db.Publishers
                    .Select(x => new
                    {
                        x.Id,
                        x.PublisherName,
                    }).ToList();
            }
        }
    }
}
