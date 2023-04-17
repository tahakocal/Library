using LibraryAutomation.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.Member
{
    public partial class MemberUpdate : Form
    {
        public DatabaseContext _db = new DatabaseContext();

        public MemberUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox1.BackColor = Color.White;

                if (string.IsNullOrEmpty(textBox4.Text))
                {
                    textBox4.BackColor = Color.Red;
                    textBox4.Focus();
                }
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
                var answer = MessageBox.Show("Güncellemek istediginizden emin misiniz ?", "Güncelle",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (answer == DialogResult.Yes)
                {
                    try
                    {
                        var toInt = Convert.ToInt32(textBox1.Text);
                        var getData = _db.Members.Find(toInt);

                        getData.Name = textBox2.Text;
                        getData.Surname = textBox3.Text;
                        getData.Email = textBox4.Text;
                        getData.CreatedDate = DateTime.Now;


                        _db.SaveChanges();
                        MessageBox.Show("Başarıyla güncellendi", "Başarılı", MessageBoxButtons.OK,
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

        private void MemberUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
