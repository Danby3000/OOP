using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    internal class Circle
    {
        public double radius { get; set; }
        public double diameter { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
            this.diameter = 2*radius;
        }

        public double Area() 
        { 
            double area = Math.Round(Math.PI * (radius*radius), 2);
            return area; 
        }

        public double Perimeter()
        {
            return Math.Round(Math.PI * diameter, 2);
        }

    }
}
