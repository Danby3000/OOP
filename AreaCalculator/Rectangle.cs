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
    public partial class Rectangle : Form
    {
        public Rectangle()
        {
            InitializeComponent();
        }

        int length = 0;
        int width = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (length == 0 || width == 0)
            {
                textBox3.Text = "Rectangles can only be 0 in the Z axis";
            }
            else
            {
                double area = length * width;
                textBox3.Text = area.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            length = Int32.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            width = Int32.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
