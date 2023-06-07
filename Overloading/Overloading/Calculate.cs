using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    internal class Calculate : Arithmetic
    {
        public float Add(float x, float y)
        {
            Console.WriteLine("Add floats called");
            return x + y;
        }

        public String Add(String x, String y) 
        {
            Console.WriteLine("Add strings called");
            return "Hello " + x + " " + y;

        }
    }
}
