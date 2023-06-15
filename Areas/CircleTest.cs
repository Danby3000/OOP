using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    [TestFixture]
    internal class CircleTest
    {
        [Test]
        public void CircleAreaTest()
        {
            Circle c = new Circle(1);
            double Area = c.Area();
            Assert.AreEqual(3.14, Area);
        }

        [Test]
        public void CircleAreaTest0Radius()
        {
            Circle c = new Circle(0);
            double Area = c.Area();
            Assert.AreEqual(0, c.Area());
        }

        [Test]
        public void CirclePerimeterTest() {
            Circle c = new Circle(1);
            double Perimeter = c.Perimeter();
            Assert.AreEqual(6.28, c.Perimeter());
        }
    }
}
