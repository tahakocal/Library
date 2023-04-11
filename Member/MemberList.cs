using Library.Entities;
using System.Data;

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
            dataGridView1.DataSource = _db.Members
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Surname,
                    x.Email,
                    x.CreatedDate,
                }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemberUpdate update = new MemberUpdate();
            update.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            update.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            update.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            update.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Members
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Surname,
                    x.Email,
                    x.CreatedDate
                }).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MemberRemove remove = new MemberRemove();
            remove.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            remove.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            remove.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            remove.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            remove.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberAdd add = new MemberAdd();
            add.ShowDialog();
        }
    }
}
