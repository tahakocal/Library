using LibraryAutomation.Entities;
using System;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.Employee
{
    public partial class EmployeeRemove : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public EmployeeRemove()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Silmek istediginizden emin misiniz ?", "Sil", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (answer == DialogResult.Yes)
            {
                try
                {
                    var toInt = Convert.ToInt32(textBox4.Text);
                    var getData = _db.Employees.Find(toInt);

                    _db.Employees.Remove(getData);
                    _db.SaveChanges();
                    MessageBox.Show("Başarıyla silindi", "Başarılı", MessageBoxButtons.OK,
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
