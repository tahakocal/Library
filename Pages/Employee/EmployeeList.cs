using LibraryAutomation.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var books = _db.Employees.Where(x => x.Name == txtAdara.Text).ToList();

                dataGridView1.DataSource = books.Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Surname,
                    x.Section.SectionName,
                    x.CreatedDate
                }).ToList();
            }
            else if (radioButton2.Checked)
            {
                var books = _db.Employees.Where(x => x.Section.SectionName == txtSoyadara.Text).ToList();

                dataGridView1.DataSource = books.Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Surname,
                    x.Section.SectionName,
                    x.CreatedDate
                }).ToList();
            }
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "İle Başlayan")
            {
                var books = _db.Employees.Where(x => x.Surname.StartsWith(textBox2.Text)).ToList();
                dataGridView1.DataSource = books.Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Surname,
                    x.Section.SectionName,
                    x.CreatedDate
                }).ToList();
            }
            else if (comboBox1.Text == "İle Biten")
            {
                var books = _db.Employees.Where(x => x.Surname.EndsWith(textBox2.Text)).ToList();
                dataGridView1.DataSource = books.Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Surname,
                    x.Section.SectionName,
                    x.CreatedDate
                }).ToList();

            }
            else if (comboBox1.Text == "İçeren")
            {
                var books = _db.Employees.Where(x => x.Surname.Contains(textBox2.Text)).ToList();
                dataGridView1.DataSource = books.Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Surname,
                    x.Section.SectionName,
                    x.CreatedDate
                }).ToList();
            }
        }
    }
}
