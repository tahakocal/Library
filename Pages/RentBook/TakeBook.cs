using LibraryAutomation.Entities;
using System;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.RentBook
{
    public partial class TakeBook : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public TakeBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var answer = MessageBox.Show("Silmek istediginizden emin misiniz ?", "Sil", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (answer == DialogResult.Yes)
            {
                try
                {
                    var toInt = Convert.ToInt32(textBox6.Text);
                    var bookNo = Convert.ToInt32(textBox1.Text);

                    var getData = _db.RentBooks.Find(toInt);

                    var getData2 = _db.Books.Find(bookNo);
                    getData2.Rented = false;

                    _db.RentBooks.Remove(getData);
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
