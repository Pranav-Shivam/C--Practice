using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WhatsApp
{
    public partial class Form1 : Form
    {
        public OleDbConnection ob = new OleDbConnection();

        public Form1()
        {
            ob.ConnectionString = @"Provider=Microsoft.jet.OLEDB.4.0;Data Source=E:\CSharp\WhatsApp\login.mdb";
            InitializeComponent();
        }

        private void lblShowHide_Click(object sender, EventArgs e)
        {
            if (lblShowHide.Text == "ShowPassword")
            {
                textBox2.PasswordChar = '\0';
                lblShowHide.Text = "HidePassword";
            }
            else
            {
                textBox2.PasswordChar = '*';
                lblShowHide.Text = "ShowPassword";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "SystemUser" && textBox2.Text == "Admin")
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                lblError.Visible = true;
                lblEPass.Visible = true;
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            lblEPass.Visible = false;

       }
    }
}
