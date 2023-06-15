using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    internal class Triangle
    {
        public double SideA {  get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double semi { get; set; }

        public Triangle (double A, double B, double C)
        { 
            SideA = A;
            SideB = B;
            SideC = C;
        }

        public double Area()
        {
            double semi = (SideA + SideB + SideC) / 2;
            double square = semi * (semi - SideA) * (semi - SideB) * (semi - SideC);
            
            if (square > 0) 
            {
                double area = Math.Round(Math.Sqrt (square), 2);
                return area;
            }
            else
            {
                Console.WriteLine("Cannot find area of an impossible triangle");
                return 0;
            }
        }

        public double Perimeter()
        {
            double perimeter = SideC + SideA + SideB;
            return perimeter;
        }
    }
}
