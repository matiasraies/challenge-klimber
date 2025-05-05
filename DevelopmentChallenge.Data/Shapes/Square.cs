using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Shapes
{
    public class Square : IGeometricShape
    {
        private readonly decimal _side;

        public Square(decimal side) => _side = side;

        public decimal CalculateArea() => _side * _side;

        public decimal CalculatePerimeter() => _side * 4;

        public string GetName(ILanguageStrategy language, int quantity) =>
            language.TranslateShapeName("Square", quantity);
    }
}
