using Library.Entities;

namespace Library.Specification.Hall
{
    public partial class HallAdd : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public HallAdd()
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
                    var hallno = Convert.ToInt32(textBox1.Text);

                    Entities.Hall hall = new Entities.Hall()
                    {
                        HallNo = hallno,
                        HallName = textBox2.Text,
                        CreatedDate = DateTime.Now,
                    };

                    _db.Halls.Add(hall);
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

        private void HallAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
