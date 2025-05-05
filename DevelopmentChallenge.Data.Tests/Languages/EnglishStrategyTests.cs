using DevelopmentChallenge.Data.Languages;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Languages
{
    [TestFixture]
    public class EnglishStrategyTests
    {
        [TestCase("Square", 1, ExpectedResult = "Square")]
        [TestCase("Triangle", 3, ExpectedResult = "Triangles")]
        public string TranslateShapeName(string key, int count)
        {
            return new EnglishStrategy().TranslateShapeName(key, count);
        }
    }
}