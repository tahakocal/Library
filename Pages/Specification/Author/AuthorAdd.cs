using LibraryAutomation.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.Specification.Author
{
    public partial class AuthorAdd : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public AuthorAdd()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox1.BackColor = Color.White;

                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    textBox3.BackColor = Color.Red;
                    textBox3.Focus();
                }

                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    textBox2.BackColor = Color.Red;
                    textBox2.Focus();
                }

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    textBox1.BackColor = Color.Red;
                    textBox1.Focus();
                }
            }
            else
            {
                var answer = MessageBox.Show("Eklemek istediginizden emin misiniz ?", "Ekle", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (answer == DialogResult.Yes)
                {
                    try
                    {
                        Entities.Author author = new Entities.Author()
                        {
                            AuthorName = textBox1.Text,
                            AuthorSurname = textBox2.Text,
                            AuthorDescription = textBox3.Text,
                            CreatedDate = DateTime.Now,
                        };

                        _db.Authors.Add(author);
                        _db.SaveChanges();
                        MessageBox.Show("Başarıyla eklendi", "Başarılı", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Hide();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Hata ile karşılaşıldı. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        this.Hide();
                    }
                }
                else
                {
                    this.Hide();
                }
            }
        }
    }
}
