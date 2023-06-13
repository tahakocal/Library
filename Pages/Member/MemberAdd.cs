using LibraryAutomation.Entities;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.Member
{
    public partial class MemberAdd : Form
    {
        public DatabaseContext _db = new DatabaseContext();

        public MemberAdd()
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
                var answer = MessageBox.Show("Eklemek istediginizden emin misiniz ?", "Ekle",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (answer == DialogResult.Yes)
                {
                    try
                    {
                        var list = _db.Members.Where(x => x.Email == textBox2.Text).ToList();
                        if (list.Count != 0)
                        {
                            MessageBox.Show("Ayni mail adresi zaten var", "Hata", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            this.Hide();
                        }
                        else
                        {
                            Entities.Member member = new Entities.Member()
                            {
                                Name = textBox1.Text,
                                Surname = textBox2.Text,
                                Email = textBox3.Text,
                                CreatedDate = DateTime.Now,
                            };

                            _db.Members.Add(member);
                            _db.SaveChanges();
                            MessageBox.Show("Başarıyla eklendi", "Başarılı", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.Hide();
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Hata ile karşılaşıldı. Lütfen tekrar deneyiniz.", "Hata",
                            MessageBoxButtons.OK,
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
