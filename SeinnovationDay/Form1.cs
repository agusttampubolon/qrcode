using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeinnovationDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 6000;
            timer1.Enabled=true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!panel2.ContainsFocus)
            {
                textBox2.Focus();
            }
            //textBox1.Focus();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox1.TextChanged += TextBox1_TextChanged;
            //textBox1.Focus();
            textBox2.LostFocus += TextBox2_LostFocus;
            panel2.Hide();
             
        }

        private void TextBox2_LostFocus(object sender, EventArgs e)
        {
            if (this.textBox2.Text != "")
            {
                call(this.textBox2.Text);
            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            //MessageBox.Show(this.textBox2.Text);
            //call(this.textBox2.Text);
        }

        public void call(string text)
        {
            if (text != "")
            {
                panel2.Hide();
                
                webBrowser1.Navigate("https://seinnovationday.co.id/checkin/printdata?unique_code=" + text);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(lblInput.Text!= "")
            {
                call("JKT" + lblInput.Text);
            }
            else
            {
                MessageBox.Show("Please type your ID");
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }
    }
}
