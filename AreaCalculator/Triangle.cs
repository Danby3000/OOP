using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCalculator
{
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }

        public int sideA = 0;
        public int sideB = 0;
        public int sideC = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sideA = Int32.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sideB = Int32.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            sideC = Int32.Parse(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double semi = (sideA + sideB + sideC) / 2;
            double square = semi * (semi - sideA) * (semi - sideB) * (semi - sideC);

            if (square > 0)
            {
                double area = Math.Sqrt(square);
                textBox4.Text = area.ToString();
            }
            else
            {
                textBox4.Text = "Dimensions create an impossible triangle, try again. But seriously this time!";
            }
        }
    }
}
