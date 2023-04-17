using LibraryAutomation.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.Specification.Hall
{
    public partial class SpecHall : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public SpecHall()
        {
            InitializeComponent();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Halls
                .Select(x => new
                {
                    x.Id,
                    x.HallNo,
                }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HallAdd add = new HallAdd();
            add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HallUpdate update = new HallUpdate();
            update.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            update.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HallRemove remove = new HallRemove();
            remove.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            remove.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            remove.ShowDialog();
        }

        private void SpecHall_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Halls
                .Select(x => new
                {
                    x.Id,
                    x.HallNo,
                }).ToList();
        }

    }
}
