using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calulator
{
    public partial class Calculator : Form
    {
        String operation = "0";
        Double Fn = 0.0;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            Fn = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "%";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "1";

            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "2";

            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "3";

            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
                if (textBox1.Text == "0" && textBox1 != null)
                {
                    textBox1.Text = "4";

                }
                else
                {
                    textBox1.Text = textBox1.Text + "4";
                }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "5";

            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="0" && textBox1 != null)
            {
                textBox1.Text = "6";

            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button1_Click(object sender, EventArgs e)
    {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "7";

            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "8";

            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ONN.Checked == true)
            {
                if (textBox1.Text == "0" && textBox1 != null)
                {
                    textBox1.Text = "9";

                }
                else
                {
                    textBox1.Text = textBox1.Text + "9";
            }
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "0";

            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "00";

            }
            else
            {
                textBox1.Text = textBox1.Text + "00";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = ".";

            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void multi_Click(object sender, EventArgs e)
        {
            Fn = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "*";
        }

        private void div_Click(object sender, EventArgs e)
        {
            Fn = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "/";
        }

        private void add_Click(object sender, EventArgs e)
        {
            Fn = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "+";
        }

        private void sub_Click(object sender, EventArgs e)
        {

            Fn = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "-";
        }
        
        private void equal_Click(object sender, EventArgs e)
        {
            Double Sn=Convert.ToDouble(textBox1.Text);
            Double Result;
            switch (operation)
            {
                case "+":
                    {
                        Result=(Fn+Sn);
                        textBox1.Text=Convert.ToString(Result);
                        Fn=0;
                        break;
                    }
                case "-":
                    {
                        Result=(Fn-Sn);
                        textBox1.Text=Convert.ToString(Result);
                        Fn=0;
                        break;
                    }
                case "*":
                    {
                        Result = (Fn * Sn);
                        textBox1.Text = Convert.ToString(Result);
                        Fn = 0;
                        break;

                    }
                case "%":
                    {
                        Result=(Fn%Sn);
                        textBox1.Text=Convert.ToString(Result);
                        Fn=0;
                        break;
                    }
                default:
                        break;
            }
            if (operation == "/")
            {
                Result = Fn / Sn;
                textBox1.Text = Convert.ToString(Result);
                Fn = 0;
            }
 
            
         }
       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void OFF_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ONN_CheckedChanged(object sender, EventArgs e)
        {

        }
        
    }
}
