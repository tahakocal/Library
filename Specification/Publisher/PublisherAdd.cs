using System;
using System.Drawing;
using System.Windows.Forms;
using LibraryAutomation.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryAutomation.Specification.Publisher
{
    public partial class PublisherAdd : Form
    {
        public DatabaseContext _db = new DatabaseContext();

        public PublisherAdd()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) )
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
                        Entities.Publisher publisher = new Entities.Publisher()
                        {
                            PublisherName = textBox1.Text,
                            CreatedDate = DateTime.Now,
                        };

                        _db.Publishers.Add(publisher);
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
}
