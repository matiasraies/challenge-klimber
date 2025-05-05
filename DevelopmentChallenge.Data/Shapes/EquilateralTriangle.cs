using DevelopmentChallenge.Data.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Shapes
{
    public class EquilateralTriangle : IGeometricShape
    {
        private readonly decimal _side;

        public EquilateralTriangle(decimal side) => _side = side;

        public decimal CalculateArea() => ((decimal)Math.Sqrt(3) / 4) * _side * _side;

        public decimal CalculatePerimeter() => _side * 3;

        public string GetName(ILanguageStrategy language, int quantity) =>
            language.TranslateShapeName("Triangle", quantity);
    }
}
