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
    }
}
