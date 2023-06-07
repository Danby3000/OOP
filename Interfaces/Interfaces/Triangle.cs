using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Triangle : IShape
    {
        public double height;
        public double width;

        public double Area()
        {
            return (height * width) / 2;
        }

        public double Perimeter()
        {
            return 0;
        }
    }
}
