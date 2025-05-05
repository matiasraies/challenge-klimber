using DevelopmentChallenge.Data.Shapes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Shapes
{
    [TestFixture]
    public class TrapezoidTests
    {
        [Test]
        public void AreaAndPerimeter()
        {
            var trap = new Trapezoid(10, 8, 6, 6);
            Assert.That(trap.CalculateArea(), Is.EqualTo(54));
            Assert.That(trap.CalculatePerimeter(), Is.EqualTo(30));
        }
    }
}