using Library.Entities;

namespace Library.Employee
{
    public partial class EmployeeUpdate : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public EmployeeUpdate()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Güncellemek istediginizden emin misiniz ?", "Güncelle", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (answer == DialogResult.Yes)
            {
                try
                {
                    var allSections = _db.Sections.ToList();
                    var sectionId = allSections.FirstOrDefault(x => x.SectionName == comboBox1.Text)!.Id;

                    var toInt = Convert.ToInt32(textBox1.Text);
                    var getData = _db.Employees.Find(toInt);

                    getData.Name = textBox2.Text;
                    getData.Surname = textBox3.Text;
                    getData.SectionId = sectionId;
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

        private void EmployeeUpdate_Load(object sender, EventArgs e)
        {
            var sections = _db.Sections.ToList();
            foreach (var sect in sections)
            {
                comboBox1.Items.Add(sect.SectionName);
            }
        }
    }
}
