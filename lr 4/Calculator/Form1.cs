using System;
using System.Windows.Forms;
using Summ;

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
    }
}
