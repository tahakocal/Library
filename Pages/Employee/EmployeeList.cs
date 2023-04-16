using System;
using System.Linq;
using System.Windows.Forms;
using LibraryAutomation.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryAutomation.Pages.Employee
{
    public partial class EmployeeList : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public EmployeeList()
        {
            InitializeComponent();
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            EmployeeRemove remove = new EmployeeRemove();
            remove.textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            remove.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            remove.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            remove.textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            remove.ShowDialog();
        }

        private void EmployeeList_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Employees
                .Include(x => x.Section)
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Surname,
                    x.Section.SectionName,
                    x.CreatedDate
                }).ToList();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            EmployeeUpdate update = new EmployeeUpdate();
            update.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            update.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            update.comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            update.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Employees
                .Include(x => x.Section)
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Surname,
                    x.Section.SectionName,
                    x.CreatedDate
                }).ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EmployeeAdd add = new EmployeeAdd();
            add.ShowDialog();
        }
    }
}
