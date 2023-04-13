using System;
using System.Drawing;
using System.Windows.Forms;
using LibraryAutomation.Entities;

namespace LibraryAutomation.Specification.Hall
{
    public partial class HallAdd : Form
    {
        public DatabaseContext _db = new DatabaseContext();

        public HallAdd()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.BackColor = Color.White;
                textBox1.BackColor = Color.White;

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
                        var hallno = Convert.ToInt32(textBox1.Text);

                        Entities.Hall hall = new Entities.Hall()
                        {
                            HallNo = hallno,
                            HallName = textBox2.Text,
                            CreatedDate = DateTime.Now,
                        };

                        _db.Halls.Add(hall);
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
