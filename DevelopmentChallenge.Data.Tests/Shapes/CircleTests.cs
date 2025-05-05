using DevelopmentChallenge.Data.Shapes;
using NUnit.Framework;
using System;

namespace DevelopmentChallenge.Data.Tests.Shapes
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void AreaAndPerimeter()
        {
            var circle = new Circle(2);
            Assert.That(circle.CalculateArea(), Is.EqualTo(Math.PI).Within(0.0000001));
            Assert.That(circle.CalculatePerimeter(), Is.EqualTo(Math.PI * 2).Within(0.0000001));
        }
    }
}