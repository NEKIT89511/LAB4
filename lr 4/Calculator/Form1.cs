using System;
using System.Windows.Forms;
using Summ;
using Difference;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "/";
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double res = Evaiuate.Evaiuate.del(number1, number2);
            label3.Text = Convert.ToString(res);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double res = Summ.Summ.sum(number1, number2);
            label3.Text = Convert.ToString(res);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double rezult = Difference.Difference.dif(number1, number2);
            label3.Text = Convert.ToString(rezult);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label3.Text = "";
            label1.Text = "";
        }
    }
}
