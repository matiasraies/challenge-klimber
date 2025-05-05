using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Languages
{
    public class ItalianStrategy : ILanguageStrategy
    {
        public string GetHeader() => "<h1>Rapporto sulle forme</h1>";

        public string GetLine(int quantity, string shapeName, decimal area, decimal perimeter) =>
            $"{quantity} {shapeName} | Area {area:#.##} | Perimetro {perimeter:#.##} <br/>";

        public string GetFooter(int totalShapes, decimal totalPerimeter, decimal totalArea) =>
            $"TOTALE:<br/>{totalShapes} forme Perimetro {totalPerimeter:#.##} Area {totalArea:#.##}";

        public string TranslateShapeName(string shapeKey, int quantity)
        {
            switch (shapeKey)
            {
                case "Square": return quantity == 1 ? "Quadrato" : "Quadrati";
                case "Circle": return quantity == 1 ? "Cerchio" : "Cerchi";
                case "Triangle": return quantity == 1 ? "Triangolo" : "Triangoli";
                case "Trapezoid": return quantity == 1 ? "Trapezio" : "Trapezi";
                default: return shapeKey;
            }
        }

        public string GetEmptyListMessage() => "<h1>Elenco vuoto di forme!</h1>";
    }
}
