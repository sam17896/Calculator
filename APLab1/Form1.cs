using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCalculator
{
    public partial class Form1 : Form
    {
        Int16 sum;
        char c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var v in this.Controls.OfType<Control>())
            {
                if (v is Button || v is TextBox)
                {
                    v.Visible = false;
                }
            }
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            sum = Int16.Parse(textBox1.Text);
            textBox1.Text = "";
            c = '*';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            sum = Int16.Parse(textBox1.Text);
            textBox1.Text = "";
            c = '+';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch (c)
            {
                case '+':
                    if(textBox1.Text!="")
                    sum += Int16.Parse(textBox1.Text);
                    break;
                case '-':
                    if (textBox1.Text != "")
                    sum -= Int16.Parse(textBox1.Text);
                    break;
                case '*':
                    if (textBox1.Text != "")
                    sum *= Int16.Parse(textBox1.Text);
                    break;
                case '/':
                    if (textBox1.Text != "")
                    {
                        if (Int16.Parse(textBox1.Text) != 0)
                        {
                            sum /= Int16.Parse(textBox1.Text);
                        }
                        else
                        {
                            MessageBox.Show("Can't divide with zero", "Error!");
                        }
                    }
                    break;
                default:
                    break;
            }
            textBox1.Text = sum.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            sum = 0;
            c = ' ';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            sum = Int16.Parse(textBox1.Text);
            textBox1.Text = "";
            c = '-';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            sum = Int16.Parse(textBox1.Text);
            textBox1.Text = "";
            c = '/';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var str  = MessageBox.Show("Are you sure you want to exit?", "Message", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(str == DialogResult.Yes)
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 5;
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                foreach (var v in this.Controls.OfType<Control>())
                {
                    if (v is Button || v is TextBox)
                    {
                        v.Visible = true;
                    }
                }
                progressBar1.Visible = false;
            }
        }
    }
}
