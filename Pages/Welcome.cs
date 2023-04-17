using System;
using System.Windows.Forms;

namespace LibraryAutomation.Pages
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }



        private void Welcome_Load_1(object sender, EventArgs e)
        {

        }
    }
}
