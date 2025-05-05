using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Languages
{
    public class SpanishStrategy : ILanguageStrategy
    {
        public string GetHeader() => "<h1>Reporte de Formas</h1>";

        public string GetLine(int quantity, string shapeName, decimal area, decimal perimeter) =>
            $"{quantity} {shapeName} | Area {area:#.##} | Perimetro {perimeter:#.##} <br/>";

        public string GetFooter(int totalShapes, decimal totalPerimeter, decimal totalArea) =>
            $"TOTAL:<br/>{totalShapes} formas Perimetro {totalPerimeter:#.##} Area {totalArea:#.##}";

        public string TranslateShapeName(string shapeKey, int quantity)
        {
            switch (shapeKey)
            {
                case "Square": return quantity == 1 ? "Cuadrado" : "Cuadrados";
                case "Circle": return quantity == 1 ? "Círculo" : "Círculos";
                case "Triangle": return quantity == 1 ? "Triángulo" : "Triángulos";
                case "Trapezoid": return quantity == 1 ? "Trapecio" : "Trapecios";
                default: return shapeKey;
            }
        }

        public string GetEmptyListMessage() => "<h1>Lista vacía de formas!</h1>";
    }
}
