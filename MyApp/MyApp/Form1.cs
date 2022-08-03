using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(btnShow.Text == "Show Password")
            {
                txtPassword.PasswordChar='\0';
                btnShow.Text="Hide Password";
            }
            else
            {
                txtPassword.PasswordChar='P';
                btnShow.Text="Show Password";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtUserName.Text == "Pranav" && txtPassword.Text == "12345678") || (txtUserName.Text == "Anjali" && txtPassword.Text == "12345"))
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Login Failled Please Check User Name or Password");
                txtPassword.Text = "";
                txtUserName.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
