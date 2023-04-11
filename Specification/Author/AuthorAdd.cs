using Library.Entities;

namespace Library.Specification.Author
{
    public partial class AuthorAdd : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public AuthorAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Eklemek istediginizden emin misiniz ?", "Ekle", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (answer == DialogResult.Yes)
            {
                try
                {
                    Entities.Author author = new Entities.Author()
                    {
                        AuthorName = textBox1.Text,
                        AuthorSurname = textBox2.Text,
                        AuthorDescription = textBox3.Text,
                        CreatedDate = DateTime.Now,
                    };

                    _db.Authors.Add(author);
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
