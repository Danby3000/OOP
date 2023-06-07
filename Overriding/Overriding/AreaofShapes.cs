using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    internal class AreaofShapes:AreaofSquare
    {

        public double AreaOfShapes(double x,  double y)
        {
            return x*y;
        }

        public override double Square(double x, double y)
        {
            Console.WriteLine("Area of shapes called square a*b");
            return x*y;
        }
    }
}
