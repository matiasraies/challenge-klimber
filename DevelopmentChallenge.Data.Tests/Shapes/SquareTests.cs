using DevelopmentChallenge.Data.Shapes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Shapes
{
    [TestFixture]
    public class SquareTests
    {
        [Test]
        public void AreaAndPerimeter()
        {
            var square = new Square(4);
            Assert.That(square.CalculateArea(), Is.EqualTo(16));
            Assert.That(square.CalculatePerimeter(), Is.EqualTo(16));
        }
    }
}