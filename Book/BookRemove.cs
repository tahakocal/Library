using Library.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Book
{
    public partial class BookRemove : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public BookRemove()
        {
            InitializeComponent();
        }

        private void BookRemove_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Silmek istediginizden emin misiniz ?", "Sil", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (answer == DialogResult.Yes)
            {
                try
                {
                    var toInt = Convert.ToInt32(textBox1.Text);
                    var getData = _db.Books.Find(toInt);

                    _db.Books.Remove(getData);
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
