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

namespace Library
{
    public partial class Register : Form
    {
        private DatabaseContext _db = new DatabaseContext();
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                if (string.IsNullOrEmpty(textBox5.Text))
                {

                }
                if (string.IsNullOrEmpty(textBox4.Text))
                {

                }
                if (string.IsNullOrEmpty(textBox3.Text))
                {

                }
                if (string.IsNullOrEmpty(textBox2.Text))
                {

                }
                if (string.IsNullOrEmpty(textBox1.Text))
                {

                }
            }
            else
            {
                try
                {
                    User user = new User()
                    {
                        Name = textBox1.Text,
                        Surname = textBox2.Text,
                        Username = textBox5.Text,
                        Email = textBox3.Text,
                        Password = textBox4.Text,
                        CreatedDate = DateTime.Now,
                    };

                    _db.Users.Add(user);
                    _db.SaveChanges();
                    MessageBox.Show("Kayıt olundu", "Başarılı", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt olurken hata ile karşılaşıldı. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK);
                }

            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
