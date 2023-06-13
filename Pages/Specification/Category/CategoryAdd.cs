using LibraryAutomation.Entities;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryAutomation.Pages.Specification.Category
{
    public partial class CategoryAdd : Form
    {
        private DatabaseContext _db = new DatabaseContext();
        public CategoryAdd()
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
                        var list = _db.Categories.Where(x => x.CategoryName == textBox1.Text).ToList();
                        if (list.Count != 0)
                        {
                            MessageBox.Show("Ayni veri zaten var", "Hata", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            this.Hide();
                        }
                        else
                        {
                            Entities.Category category = new Entities.Category()
                            {
                                CategoryName = textBox1.Text,
                                CreatedDate = DateTime.Now,
                            };

                            _db.Categories.Add(category);
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
