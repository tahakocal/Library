using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAutomation.Entities;
using LibraryAutomation.Specification.Publisher;

namespace LibraryAutomation.Specification.Category
{
    public partial class CategoryList : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public CategoryList()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryUpdate update = new CategoryUpdate();
            update.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            update.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CategoryRemove remove = new CategoryRemove();
            remove.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            remove.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            remove.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Categories
                .Select(x => new
                {
                    x.Id,
                    x.CategoryName,
                }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryAdd add = new CategoryAdd();
            add.ShowDialog();
        }

        private void CategoryList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Categories
                .Select(x => new
                {
                    x.Id,
                    x.CategoryName,
                }).ToList();
        }
    }
}
