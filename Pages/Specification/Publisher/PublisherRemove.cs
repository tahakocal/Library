using System;
using System.Windows.Forms;
using LibraryAutomation.Entities;

namespace LibraryAutomation.Pages.Specification.Publisher
{
    public partial class PublisherRemove : Form
    {
        public DatabaseContext _db = new DatabaseContext();

        public PublisherRemove()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Silmek istediginizden emin misiniz ?", "Sil", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (answer == DialogResult.Yes)
            {
                try
                {
                    var toInt = Convert.ToInt32(textBox1.Text);
                    var getData = _db.Publishers.Find(toInt);

                    _db.Publishers.Remove(getData);
                    _db.SaveChanges();
                    MessageBox.Show("Başarıyla silindi", "Başarılı", MessageBoxButtons.OK,
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
