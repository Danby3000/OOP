using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    internal class Rectangle
    {

        public double height {  get; set; }
        public double width { get; set; }

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public double Area() 
        { 
            return height * width; 
        }

      
        public double Perimeter()
        {
            return (width*2) + (height*2);
        }

    }
}
