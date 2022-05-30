using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num1 ;
        int num2 ;
        int a;
        float d;
        int m;
        int s;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox2.Text);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = num1 + num2;
            s = num1 - num2;
            m = num1 * num2;
            d = (float)num1 / num2;
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("The sum is as follows: " + a.ToString());
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
            if (radioButton2.Checked==true)
            {
                if (num1<num2)
                {
                    MessageBox.Show("Number 1 should be greater");
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                }
                else if (num1>num2)
                {
                    MessageBox.Show("The division is as follows: " + d.ToString());
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                }
            }
            if (radioButton3.Checked==true)
            {
                MessageBox.Show("The difference is as follows: "+s);
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
            if (radioButton4.Checked==true)
            {
                MessageBox.Show("The product is as follows: "+m.ToString());
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
