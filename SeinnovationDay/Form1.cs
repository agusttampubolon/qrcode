using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeinnovationDay
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();
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
           
            webBrowser1.Hide();
            btnCloseKeyboard.Hide();
            button3.Hide();
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

        public async void call(string text)
        {
            if (text != "")
            {
                if (await Check(text))
                {
                    panel2.Hide();
                    btnCloseKeyboard.Hide();
                    button2.Hide();
                    button1.Show();
                    button3.Show();
                    textBox2.Text = "";
                    lblInput.Text = "";
                    
                    webBrowser1.Show();
                    webBrowser1.Navigate("https://seinnovationday.co.id/checkin/data?unique_code=" + text);
                    webprint.Navigate("https://seinnovationday.co.id/checkin/printdata?unique_code=" + text);
                }
                else
                {
                    MessageBox.Show("Data Not Found! Please enter the valid unique Code");
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(lblInput.Text!= "")
            {
                string unique_code = "JKT" + lblInput.Text;
                call(unique_code);
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
            btnCloseKeyboard.Show();
            button2.Hide();
        }

        private void btnCloseKeyboard_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            btnCloseKeyboard.Hide();
            button2.Show();
            webBrowser1.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblInput.Text = "";
        }

        public async Task<Boolean> Check(string unique_code)
        {
            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri(string.Format("https://seinnovationday.co.id/checkin/check?unique_code={0}", unique_code));
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage responce = await Client.GetAsync("");
                if (responce.IsSuccessStatusCode)
                {
                    var Json = await responce.Content.ReadAsStringAsync();
                    var status = JsonConvert.DeserializeObject<Result>(Json);
                    
                    return status.status;
                }
                else
                {
                    return false;
                }
            }  
        }

        public async Task<Boolean> CheckIn(string unique_code)
        {
            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri(string.Format("https://seinnovationday.co.id/checkin/in?unique_code={0}", unique_code));
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage responce = await Client.GetAsync("");
                if (responce.IsSuccessStatusCode)
                {
                    var Json = await responce.Content.ReadAsStringAsync();
                    var status = JsonConvert.DeserializeObject<Result>(Json);

                    return status.status;
                }
                else
                {
                    return false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.LostFocus += TextBox2_LostFocus;
            panel2.Hide();
            button1.Hide();
            webBrowser1.Hide();
            btnCloseKeyboard.Hide();
            button2.Show();
            button3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webprint.Print();

        }
    }
}

public class Result
{
    public Boolean status { get; set; }
  
}