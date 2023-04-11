using Library.Entities;

namespace Library
{
    public partial class MemberUpdate : Form
    {
        public DatabaseContext _db = new DatabaseContext();

        public MemberUpdate()
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
                    var toInt = Convert.ToInt32(textBox1.Text);
                    var getData = _db.Members.Find(toInt);

                    getData.Name = textBox2.Text;
                    getData.Surname = textBox3.Text;
                    getData.Email = textBox4.Text;
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
    }
}
