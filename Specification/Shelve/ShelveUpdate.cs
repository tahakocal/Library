using System;
using System.Drawing;
using System.Windows.Forms;
using LibraryAutomation.Entities;

namespace LibraryAutomation.Specification.Shelve
{
    public partial class ShelveUpdate : Form
    {
        public DatabaseContext _db = new DatabaseContext();

        public ShelveUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.BackColor = Color.White;

                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    textBox2.BackColor = Color.Red;
                    textBox2.Focus();
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
                        var shelveNo = Convert.ToInt32(textBox2.Text);
                        var toInt = Convert.ToInt32(textBox1.Text);
                        var getData = _db.Shelves.Find(toInt);

                        getData.ShelveNo = shelveNo;
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
    }
}
