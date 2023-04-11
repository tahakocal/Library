using Library.Entities;

namespace Library.Specification.Hall
{
    public partial class HallUpdate : Form
    {
        public DatabaseContext _db = new DatabaseContext();

        public HallUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Güncellemek istediginizden emin misiniz ?", "Güncelle", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (answer == DialogResult.Yes)
            {
                try
                {
                    var hallno = Convert.ToInt32(textBox2.Text);
                    var toInt = Convert.ToInt32(textBox1.Text);
                    var getData = _db.Halls.Find(toInt);

                    getData.HallNo = hallno;
                    getData.HallName = textBox3.Text;
                    getData.CreatedDate = DateTime.Now;


                    _db.SaveChanges();
                    MessageBox.Show("Başarıyla güncellendi", "Başarılı", MessageBoxButtons.OK,
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
