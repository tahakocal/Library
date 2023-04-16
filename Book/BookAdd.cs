using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LibraryAutomation.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryAutomation.Book
{
    public partial class BookAdd : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public BookAdd()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text) || comboBox1.Text == "Seçiniz" || comboBox2.Text == "Seçiniz")
            {
                textBox2.BackColor = Color.White;
                textBox5.BackColor = Color.White;
                comboBox2.BackColor = Color.White;
                comboBox1.BackColor = Color.White;



                if (string.IsNullOrEmpty(textBox5.Text))
                {
                    textBox5.BackColor = Color.Red;
                    textBox5.Focus();
                }

                if (string.IsNullOrEmpty(comboBox2.Text) || comboBox2.Text == "Seçiniz")
                {
                    comboBox2.BackColor = Color.Red;
                    comboBox2.Focus();
                }

                if (string.IsNullOrEmpty(comboBox1.Text) || comboBox1.Text == "Seçiniz")
                {
                    comboBox1.BackColor = Color.Red;
                    comboBox1.Focus();
                }

                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    textBox2.BackColor = Color.Red;
                    textBox2.Focus();
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

                        var shelveNo = Convert.ToInt32(comboBox4.Text);
                        var hallNo = Convert.ToInt32(comboBox5.Text);
                        var cabinNo = Convert.ToInt32(comboBox6.Text);

                        var authors = _db.Authors.ToList();
                        var authorId = authors.FirstOrDefault(x => x.AuthorName == comboBox1.Text).Id;

                        var allCategories = _db.Categories.ToList();
                        var categoryId = allCategories.FirstOrDefault(x => x.CategoryName == comboBox2.Text).Id;

                        var publishers = _db.Publishers.ToList();
                        var publisherId = publishers.FirstOrDefault(x => x.PublisherName == comboBox3.Text).Id;

                        var shelves = _db.Shelves.ToList();
                        var shelveId = shelves.FirstOrDefault(x => x.ShelveNo == shelveNo).Id;

                        var halls = _db.Halls.ToList();
                        var hallId = halls.FirstOrDefault(x => x.HallNo == hallNo).Id;

                        var cabinets= _db.Cabinets.ToList();
                        var cabinetId= cabinets.FirstOrDefault(x => x.CabinetNo == cabinNo).Id;

                        //if (radioButton1.Checked)
                        //{
                        //    rented = true;
                        //}
                        //else
                        //{
                        //    rented = false;
                        //}

                        Entities.Book book = new Entities.Book()
                        {
                            Title = textBox2.Text,
                            Description = textBox5.Text,
                            CategoryId = categoryId,
                            AuthorId = authorId,
                            CabinetId = cabinetId,
                            HallId = hallId,
                            ShelveId = shelveId,
                            PublisherId = publisherId,
                            Rented = false,
                            CreatedDate = DateTime.Now,
                        };

                        _db.Books.Add(book);
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

        private void BookAdd_Load_1(object sender, EventArgs e)
        {
            var authors = _db.Authors.ToList();
            foreach (var auth in authors)
            {
                comboBox1.Items.Add(auth.AuthorName);
            }

            var categories = _db.Categories.ToList();
            foreach (var category in categories)
            {
                comboBox2.Items.Add(category.CategoryName);
            }

            var publisher = _db.Publishers.ToList();
            foreach (var publish in publisher)
            {
                comboBox3.Items.Add(publish.PublisherName);
            }

            var shelves = _db.Shelves.ToList();
            foreach (var shelf in shelves)
            {
                comboBox4.Items.Add(shelf.ShelveNo);
            }
            var halls = _db.Halls.ToList();
            foreach (var hall in halls)
            {
                comboBox5.Items.Add(hall.HallNo);
            }
            var cabinets = _db.Cabinets.ToList();
            foreach (var cabinet in cabinets)
            {
                comboBox6.Items.Add(cabinet.CabinetNo);
            }
        }
    }
}
