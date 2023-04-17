using LibraryAutomation.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.RentBook
{
    public partial class GiveBook : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public GiveBook()
        {
            InitializeComponent();
        }

        private void GiveBook_Load(object sender, System.EventArgs e)
        {
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text)
                || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                textBox4.BackColor = Color.White;
                textBox5.BackColor = Color.White;



                if (string.IsNullOrEmpty(textBox5.Text))
                {
                    textBox5.BackColor = Color.Red;
                    textBox5.Focus();
                }
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

                var answer = MessageBox.Show("Eklemek istediginizden emin misiniz ?", "Ekle", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (answer == DialogResult.Yes)
                {
                    try
                    {
                        bool rented;

                        var bookNo = Convert.ToInt32(textBox1.Text);
                        var memberNo = Convert.ToInt32(textBox3.Text);

                        Entities.RentBook book = new Entities.RentBook()
                        {
                            BookId = bookNo,
                            MemberId = memberNo,
                            From = dateTimePicker1.Value,
                            To = dateTimePicker2.Value,
                            CreatedDate = DateTime.Now,
                        };

                        var getData = _db.Books.Find(bookNo);
                        getData.Rented = true;

                        _db.RentBooks.Add(book);
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
