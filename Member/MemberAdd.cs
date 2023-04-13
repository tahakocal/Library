using System;
using System.Drawing;
using System.Windows.Forms;
using LibraryAutomation.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryAutomation.Member
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
