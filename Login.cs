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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public partial class Login : Form
    {
        DatabaseContext _db = new DatabaseContext();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.BackColor = Color.White;
                textBox1.BackColor = Color.White;

                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    textBox2.BackColor = Color.DarkRed;
                    textBox2.Focus();
                }

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    textBox1.BackColor = Color.DarkRed;
                    textBox1.Focus();
                }
            }
            else
            {
                textBox2.BackColor = Color.White;
                textBox1.BackColor = Color.White;

                var checkuser = _db.Users.SingleOrDefault(x => x.Username == textBox1.Text && x.Password == textBox2.Text);

                if (checkuser != null)
                {
                    HomePage home = new HomePage();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Hata", MessageBoxButtons.OK);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
