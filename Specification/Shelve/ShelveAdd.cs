using Library.Entities;

namespace Library.Specification.Shelve
{
    public partial class ShelveAdd : Form
    {
        public DatabaseContext _db = new DatabaseContext();

        public ShelveAdd()
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
                    var shelveNo = Convert.ToInt32(textBox1.Text);

                    Entities.Shelve shelve = new Entities.Shelve()
                    {
                        ShelveNo = shelveNo,
                        ShelveName = textBox2.Text,
                        CreatedDate = DateTime.Now,
                    };

                    _db.Shelves.Add(shelve);
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
