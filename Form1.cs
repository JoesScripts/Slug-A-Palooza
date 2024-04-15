using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slug_A_Palooza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int num3;
            int num4;
            int num5;
            int sum;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            num3 = Convert.ToInt32(textBox3.Text);
            num4 = Convert.ToInt32(textBox4.Text);
            num5 = Convert.ToInt32(textBox5.Text);
            sum = num1 + num2 + num3 + num4 + num5;
            label7.Text = "You have a total of " + sum + " slugs!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
