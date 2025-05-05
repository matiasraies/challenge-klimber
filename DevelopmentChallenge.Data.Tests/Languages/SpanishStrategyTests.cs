using DevelopmentChallenge.Data.Languages;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Languages
{
    [TestFixture]
    public class SpanishStrategyTests
    {
        [TestCase("Square", 1, ExpectedResult = "Cuadrado")]
        [TestCase("Circle", 2, ExpectedResult = "Círculos")]
        public string TranslateShapeName(string key, int count)
        {
            return new SpanishStrategy().TranslateShapeName(key, count);
        }
    }
}