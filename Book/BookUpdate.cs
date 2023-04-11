using Library.Entities;

namespace Library.Book
{
    public partial class BookUpdate : Form
    {
        public DatabaseContext _db = new DatabaseContext();

        public BookUpdate()
        {
            InitializeComponent();
        }

        private void BookUpdate_Load(object sender, EventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Eklemek istediginizden emin misiniz ?", "Ekle", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (answer == DialogResult.Yes)
            {
                try
                {
                    bool rented;

                    var allCategories = _db.Categories.ToList();
                    var categoryId = allCategories.FirstOrDefault(x => x.CategoryName == comboBox2.Text)!.Id;

                    var authors = _db.Authors.ToList();
                    var authorId = authors.FirstOrDefault(x => x.AuthorName == comboBox1.Text)!.Id;

                    if (radioButton1.Checked)
                    {
                        rented = true;
                    }
                    else
                    {
                        rented = false;
                    }

                    var toInt = Convert.ToInt32(textBox1.Text);
                    var getData = _db.Books.Find(toInt);

                    getData.Title = textBox2.Text;
                    getData.Description = textBox5.Text;
                    getData.AuthorId = authorId;
                    getData.CategoryId = categoryId;
                    getData.Rented = rented;
                    getData.CreatedDate = DateTime.Now;

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
