﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Entities;

namespace Library
{
    public partial class Login : Form
    {
        DatabaseContext _db = new DatabaseContext();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                if (string.IsNullOrEmpty(textBox2.Text))
                {

                }

                if (string.IsNullOrEmpty(textBox1.Text))
                {

                }
            }
            else
            {
                var checkuser = _db.Users.SingleOrDefault(x => x.Username == textBox1.Text && x.Password == textBox2.Text);

                if (checkuser != null)
                {
                    HomePage home = new HomePage();
                    home.Show();
                    this.Hide();
                }
            }
        }
    }
}
