using Library.Entities;

namespace Library.Employee
{
    public partial class EmployeeAdd : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public EmployeeAdd()
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
                    var allSections = _db.Sections.ToList();
                    var sectionId = allSections.FirstOrDefault(x => x.SectionName == comboBox1.Text)!.Id;

                    Entities.Employee employee = new Entities.Employee()
                    {
                        Name = textBox1.Text,
                        Surname = textBox2.Text,
                        SectionId = sectionId,
                        CreatedDate = DateTime.Now,
                    };

                    _db.Employees.Add(employee);
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

        private void EmployeeAdd_Load(object sender, EventArgs e)
        {
            var sections = _db.Sections.ToList();
            foreach (var sect in sections)
            {
                comboBox1.Items.Add(sect.SectionName);
            }
        }
    }
}
