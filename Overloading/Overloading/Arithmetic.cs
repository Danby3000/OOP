using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    internal class Arithmetic
    {
        public int Add(int x, int y)
        {
            Console.WriteLine("Add ints called");
            return x + y;
        }

        public double Add(double x, double y)
        {
            Console.WriteLine("Add doubles called");
            return x + y;
        }
    }
}
