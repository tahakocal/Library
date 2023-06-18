using LibraryAutomation.Entities;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.Specification.Section
{
    public partial class SectionAdd : Form
    {
        public DatabaseContext _db = new DatabaseContext();

        public SectionAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {

                textBox1.BackColor = Color.White;

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
                        var list = _db.Sections.Where(x => x.SectionName == textBox1.Text).ToList();
                        if (list.Count != 0)
                        {
                            MessageBox.Show("Ayni veri zaten var", "Hata", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            this.Hide();
                        }
                        else
                        {
                            Entities.Section section = new Entities.Section()
                            {
                                SectionName = textBox1.Text,
                                CreatedDate = DateTime.Now,
                            };

                            _db.Sections.Add(section);
                            _db.SaveChanges();
                            MessageBox.Show("Başarıyla eklendi", "Başarılı", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.Hide();
                        }
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
}
