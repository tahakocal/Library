using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Employee
{
    public partial class EmployeeList : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public EmployeeList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeRemove remove = new EmployeeRemove();
            remove.textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            remove.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            remove.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            remove.textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            remove.ShowDialog();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeUpdate update = new EmployeeUpdate();
            update.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            update.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            update.comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            update.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeAdd add = new EmployeeAdd();
            add.ShowDialog();
        }
    }
}
