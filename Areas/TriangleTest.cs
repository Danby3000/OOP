using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    [TestFixture]
    internal class TriangleTest
    {
        [Test]
        public void TriangleAreaTest () 
        {
        Triangle t = new Triangle(1,1,1);
        double area = t.Area();
        Assert.AreEqual(0.43, area);
        }

        [Test]
        public void TriangleAreaTest1()
        {
            Triangle t = new Triangle(1.6, 1.6, 1.6);
            double area = t.Area();
            Assert.AreEqual(1.11, area);
        }

        [Test]
        public void TrianglePerimeterTest() {
            Triangle t = new Triangle(1,1,1);
            double perim = t.Perimeter();
            Assert.AreEqual(3, perim);
        }

        [Test]
        public void TrianglePerimeterTest1()
        {
            Triangle t = new Triangle(3, 4, 5);
            double perim = t.Perimeter();
            Assert.AreEqual(12, perim);
        }

        [Test]
        public void TriangleImpossibleTest() 
        {
            Triangle t = new Triangle(1, 1, 10);
            double area = t.Area();
            Assert.AreEqual(0, area);
        }
    }
}
