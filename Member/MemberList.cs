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

namespace Library.Member
{
    public partial class MemberList : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public MemberList()
        {
            InitializeComponent();
        }

        private void MemberList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Users
                .Select(x => new
                {
                    x.Username,
                    x.Name,
                    x.Surname,
                    x.Email,
                    x.CreatedDate,
                    x.Password
                }).ToList();
        }
    }
}
