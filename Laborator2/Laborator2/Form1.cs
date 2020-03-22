using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborator2
{
    public partial class Form1 : Form
    {
        private float number1 { get; set; }
        private bool number1set { get; set; }
        private float number2 { get; set; }
        private string operatorr { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            this.richTextBox1.AppendText(b.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string pattern = "^-?(0|([1-9][0-9]*))((\\.[0-9]+)?)$";
            Match m = Regex.Match(this.richTextBox1.Text, pattern);
            if (!m.Success)
            {
                this.richTextBox1.Text = "Syntax Error";
                return;
            }
            if (!this.number1set)
            {
                number1 = float.Parse(this.richTextBox1.Text);
                number1set = true;
                this.operatorr = b.Text;
            }
            else
            {
                number2 = float.Parse(this.richTextBox1.Text);
                this.operatorr = b.Text;

            }
            this.richTextBox1.Text = String.Empty;
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            this.richTextBox1.AppendText(b.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            this.richTextBox1.Text = "asfs";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            this.richTextBox1.AppendText(b.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            this.richTextBox1.AppendText(b.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            this.richTextBox1.AppendText(b.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            this.richTextBox1.AppendText(b.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            this.richTextBox1.AppendText(b.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            this.richTextBox1.AppendText(b.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            this.richTextBox1.AppendText(b.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            this.richTextBox1.AppendText(b.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            this.richTextBox1.AppendText(b.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string pattern = "^-?(0|([1-9][0-9]*))((\\.[0-9]+)?)$";
            Match m = Regex.Match(this.richTextBox1.Text, pattern);
            if (!m.Success)
            {
                this.richTextBox1.Text = "Syntax Error";
                return;
            }
            if (!this.number1set)
            {
                number1 = float.Parse(this.richTextBox1.Text);
                number1set = true;
                this.operatorr = b.Text;
            }
            else
            {
                number2 = float.Parse(this.richTextBox1.Text);
                this.operatorr = b.Text;

            }
            this.richTextBox1.Text = String.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string pattern = "^-?(0|([1-9][0-9]*))((\\.[0-9]+)?)$";
            Match m = Regex.Match(this.richTextBox1.Text, pattern);
            if (!m.Success)
            {
                this.richTextBox1.Text = "Syntax Error";
                return;
            }
            if (!this.number1set)
            {
                number1 = float.Parse(this.richTextBox1.Text);
                number1set = true;
                this.operatorr = b.Text;
            }
            else
            {
                number2 = float.Parse(this.richTextBox1.Text);
                this.operatorr = b.Text;

            }
            this.richTextBox1.Text = String.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string pattern = "^-?(0|([1-9][0-9]*))((\\.[0-9]+)?)$";
            Match m = Regex.Match(this.richTextBox1.Text, pattern);
            if (!m.Success)
            {
                this.richTextBox1.Text = "Syntax Error";
                return;
            }
            if (!this.number1set)
            {
                number1 = float.Parse(this.richTextBox1.Text);
                number1set = true;
                this.operatorr = b.Text;
            }
            else
            {
                number2 = float.Parse(this.richTextBox1.Text);
                this.operatorr = b.Text;

            }
            this.richTextBox1.Text = String.Empty;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text.Length > 0)
            {
                this.richTextBox1.Text = this.richTextBox1.Text.Substring(0, this.richTextBox1.Text.Length - 1);
            }
        }
        private void Button17_Click(object sender, EventArgs e)
        {
            if (!number1set || operatorr == String.Empty)
            {
                this.richTextBox1.Text = "Error";
            }
            else
            {
                string pattern = "^-?(0|([1-9][0-9]*))((\\.[0-9]+)?)$";
                Match m = Regex.Match(this.richTextBox1.Text, pattern);
                if (!m.Success)
                {
                    this.richTextBox1.Text = "Syntax Error";
                    return;
                }
                number2 = float.Parse(this.richTextBox1.Text);
                if (operatorr == "+")
                {
                    this.richTextBox1.Text = (number1 + number2).ToString();
                    number1set = false;
                    operatorr = String.Empty;
                }
                else if (operatorr == "-")
                {
                    this.richTextBox1.Text = (number1 - number2).ToString();
                    number1set = false;
                    operatorr = String.Empty;

                }
                else if (operatorr == "*")
                {
                    this.richTextBox1.Text = (number1 * number2).ToString();
                    number1set = false;
                    operatorr = String.Empty;

                }
                else if (operatorr == "/")
                {
                    this.richTextBox1.Text = (number1 / number2).ToString();
                    number1set = false;
                    operatorr = String.Empty;

                }
            }


        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!this.richTextBox1.Text.StartsWith("-"))
                this.richTextBox1.Text = "-" + this.richTextBox1.Text;
            else
            {
                this.richTextBox1.Text = this.richTextBox1.Text.Substring(1);
            }
        }
        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            switch (e.KeyChar)
            {
                case '0':
                    button10_Click(button10, e);
                    break;
                case '1':
                    button5_Click(button5, e);
                    break;
                case '2':
                    button12_Click(button12, e);
                    break;
                case '3':
                    button13_Click(button13, e);
                    break;
                case '4':
                    button8_Click(button8, e);
                    break;
                case '5':
                    button9_Click(button9, e);
                    break;
                case '6':
                    button11_Click(button11, e);
                    break;
                case '7':
                    button1_Click(button1, e);
                    break;
                case '8':
                    button2_Click(button2, e);
                    break;
                case '9':
                    button3_Click(button3, e);
                    break;
                case '+':
                    button14_Click(button14, e);
                    break;
                case '*':
                    button7_Click(button7, e);
                    break;
                case '-':
                    button6_Click(button6, e);
                    break;
                case '.':
                    button16_Click(button16, e);
                    break;
                case '/':
                    button4_Click(button4, e);
                    break;
                case '=':
                    Button17_Click(button17, e);
                    break;
                case 'd':
                    button18_Click(button18, e);
                    break;
                case 'r':
                    button15_Click(button15, e);
                    break;


            }
        }

    }
}
