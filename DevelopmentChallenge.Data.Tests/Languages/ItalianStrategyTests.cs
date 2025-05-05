using DevelopmentChallenge.Data.Languages;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Languages
{
    [TestFixture]
    public class ItalianStrategyTests
    {
        [TestCase("Trapezoid", 1, ExpectedResult = "Trapezio")]
        [TestCase("Circle", 2, ExpectedResult = "Cerchi")]
        public string TranslateShapeName(string key, int count)
        {
            return new ItalianStrategy().TranslateShapeName(key, count);
        }
    }
}