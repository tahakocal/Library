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

namespace Library.Book
{
    public partial class BookList : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public BookList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Books
                .Include(x => x.Author)
                .Include(x => x.Category)
                .Select(x => new
                {
                    x.Title,
                    x.Description,
                    x.Author.AuthorName,
                    x.Category.CategoryName,
                    x.Rented,
                }).ToList();
        }
    }
}
