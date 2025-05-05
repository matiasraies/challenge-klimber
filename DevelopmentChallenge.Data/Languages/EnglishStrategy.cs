using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Languages
{
    public class EnglishStrategy : ILanguageStrategy
    {
        public string GetHeader() => "<h1>Shapes report</h1>";

        public string GetLine(int quantity, string shapeName, decimal area, decimal perimeter) =>
            $"{quantity} {shapeName} | Area {area:#.##} | Perimeter {perimeter:#.##} <br/>";

        public string GetFooter(int totalShapes, decimal totalPerimeter, decimal totalArea) =>
            $"TOTAL:<br/>{totalShapes} shapes Perimeter {totalPerimeter:#.##} Area {totalArea:#.##}";

        public string TranslateShapeName(string shapeKey, int quantity)
        {
            switch (shapeKey)
            {
                case "Square": return quantity == 1 ? "Square" : "Squares";
                case "Circle": return quantity == 1 ? "Circle" : "Circles";
                case "Triangle": return quantity == 1 ? "Triangle" : "Triangles";
                case "Trapezoid": return quantity == 1 ? "Trapezoid" : "Trapezoids";
                default: return shapeKey;
            }
        }

        public string GetEmptyListMessage() => "<h1>Empty list of shapes!</h1>";
    }
}
