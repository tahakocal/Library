using Library.Entities;

namespace Library.Specification.Publisher
{
    public partial class PublisherAdd : Form
    {
        public DatabaseContext _db = new DatabaseContext();

        public PublisherAdd()
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
                    Entities.Publisher publisher = new Entities.Publisher()
                    {
                        PublisherName = textBox1.Text,
                        CreatedDate = DateTime.Now,
                    };

                    _db.Publishers.Add(publisher);
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
