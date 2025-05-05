using DevelopmentChallenge.Data.Shapes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Shapes
{
    [TestFixture]
    public class EquilateralTriangleTests
    {
        [Test]
        public void AreaAndPerimeter()
        {
            var triangle = new EquilateralTriangle(4);
            Assert.That(triangle.CalculateArea(), Is.EqualTo((decimal)(System.Math.Sqrt(3) / 4) * 16).Within((decimal)0.01));
            Assert.That(triangle.CalculatePerimeter(), Is.EqualTo(12));
        }
    }
}