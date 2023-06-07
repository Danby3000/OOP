using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    internal class AreaofSquare
    {

        public virtual double Square(double x, double y)
        {
            Console.WriteLine("Calculate area of square power a^b");
            return Math.Pow(x, 2);
        }
    }
}
