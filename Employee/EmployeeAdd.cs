using LibraryAutomation.Entities;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LibraryAutomation.Employee
{
    public partial class EmployeeAdd : Form
    {
        public DatabaseContext _db = new DatabaseContext();

        public EmployeeAdd()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(comboBox1.Text) || comboBox1.Text == "Seçiniz")
            {
                textBox2.BackColor = Color.White;
                textBox1.BackColor = Color.White;
                comboBox1.BackColor = Color.White;

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
                var answer = MessageBox.Show("Eklemek istediginizden emin misiniz ?", "Ekle", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (answer == DialogResult.Yes)
                {
                    try
                    {
                        var allSections = _db.Sections.ToList();
                        var sectionId = allSections.FirstOrDefault(x => x.SectionName == comboBox1.Text).Id;

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
        }

        private void EmployeeAdd_Load_1(object sender, EventArgs e)
        {
            var sections = _db.Sections.ToList();
            foreach (var sect in sections)
            {
                comboBox1.Items.Add(sect.SectionName);
            }
        }
    }
}
