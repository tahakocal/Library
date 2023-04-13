using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LibraryAutomation.Entities;

namespace LibraryAutomation.Employee
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(comboBox1.Text) || comboBox1.Text == "Seçiniz")
            {
                textBox3.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox1.BackColor = Color.White;
                comboBox1.BackColor = Color.White;

                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    textBox3.BackColor = Color.Red;
                    textBox3.Focus();
                }
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    textBox2.BackColor = Color.Red;
                    textBox2.Focus();
                }

                if (string.IsNullOrEmpty(comboBox1.Text) || comboBox1.Text == "Seçiniz")
                {
                    comboBox1.BackColor = Color.Red;
                    comboBox1.Focus();
                }

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    textBox1.BackColor = Color.Red;
                    textBox1.Focus();
                }
            }
            else
            {
                var answer = MessageBox.Show("Güncellemek istediginizden emin misiniz ?", "Güncelle", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (answer == DialogResult.Yes)
                {
                    try
                    {
                        var allSections = _db.Sections.ToList();
                        var sectionId = allSections.FirstOrDefault(x => x.SectionName == comboBox1.Text).Id;

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
        }

        private void EmployeeUpdate_Load_1(object sender, EventArgs e)
        {
            var sections = _db.Sections.ToList();
            foreach (var sect in sections)
            {
                comboBox1.Items.Add(sect.SectionName);
            }
        }
    }
}
