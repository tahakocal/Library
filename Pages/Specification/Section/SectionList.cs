using LibraryAutomation.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.Specification.Section
{
    public partial class SectionList : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public SectionList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Sections
                .Select(x => new
                {
                    x.Id,
                    x.SectionName,
                    x.CreatedDate
                }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SectionAdd add = new SectionAdd();
            add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SectionUpdate update = new SectionUpdate();
            update.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            update.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SectionRemove remove = new SectionRemove();
            remove.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            remove.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            remove.ShowDialog();

        }

        private void SectionList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Sections
                .Select(x => new
                {
                    x.Id,
                    x.SectionName,
                    x.CreatedDate
                }).ToList();
        }
    }
}
