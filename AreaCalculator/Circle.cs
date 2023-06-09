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
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
            
        }

        int radius = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            radius = Int32.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radius == 0)
            {
                textBox2.Text = "Circles cannot have a radius of 0 (unless we are talking about black holes)";
            }
            else
            {
                double area = Math.PI * (radius * radius);
                textBox2.Text = area.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
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
