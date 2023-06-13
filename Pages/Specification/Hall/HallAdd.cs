using LibraryAutomation.Entities;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.Specification.Hall
{
    public partial class HallAdd : Form
    {
        public DatabaseContext _db = new DatabaseContext();

        public HallAdd()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
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
                        var hallno = Convert.ToInt32(textBox1.Text);
                        var list = _db.Halls.Where(x => x.HallNo == hallno).ToList();
                        if (list.Count != 0)
                        {
                            MessageBox.Show("Ayni veri zaten var", "Hata", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            this.Hide();
                        }
                        else
                        {
                            Entities.Hall hall = new Entities.Hall()
                            {
                                HallNo = hallno,
                                CreatedDate = DateTime.Now,
                            };

                            _db.Halls.Add(hall);
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
