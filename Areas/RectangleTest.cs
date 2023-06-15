using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    [TestFixture]
    internal class RectangleTest
    {
        [Test]
        public void RectangleAreaTest()
        {
            Rectangle r = new Rectangle(1, 1);
            double area = r.Area();
            Assert.AreEqual(1, area);
        }

        [Test]
        public void RectangleAreaTest0 () { 
            Rectangle r = new Rectangle(0, 0);
            double area = r.Area();
            Assert.AreEqual(0, area);
        }

        [Test]
        public void RectanglePerimeterTest () 
        {
            Rectangle r = new Rectangle(1,1);
            double perimeter = r.Perimeter();
            Assert.AreEqual(4, perimeter);
        }
    }
}
