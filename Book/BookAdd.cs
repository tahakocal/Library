using Library.Entities;

namespace Library.Book
{
    public partial class BookAdd : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public BookAdd()
        {
            InitializeComponent();
        }

        private void BookAdd_Load(object sender, EventArgs e)
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

                    Entities.Book book = new Entities.Book()
                    {
                        Title = textBox2.Text,
                        Description = textBox5.Text,
                        CategoryId = categoryId,
                        AuthorId = authorId,
                        Rented = rented,
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
}
