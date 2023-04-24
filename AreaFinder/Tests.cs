using System;
using NUnit.Framework;

namespace AreaFinder.Tests
{
    [TestFixture]
    public class FigureTests
    {
        [Test]
        public void TestCircleArea()
        {
            double radius = 5;
            Circle circle = new Circle(radius);
            Assert.AreEqual(Math.PI * Math.Pow(radius, 2), circle.GetArea());
        }

        [Test]
        public void TestTriangleArea()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.AreEqual(6, triangle.GetArea());
        }

        [Test]
        public void TestRightTriangle()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.IsTrue(triangle.IsRightTriangle());
        }
    }

}