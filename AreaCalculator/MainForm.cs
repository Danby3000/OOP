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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Circle circle = new Circle();
            circle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rectangle rectangle = new Rectangle();
            rectangle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Triangle triangle = new Triangle();
            triangle.Show();
        }
    }
}
