using DevelopmentChallenge.Data.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Shapes
{
    public class Circle : IGeometricShape
    {
        private readonly decimal _diameter;

        public Circle(decimal diameter) => _diameter = diameter;

        public decimal CalculateArea() => (decimal)Math.PI * (_diameter / 2) * (_diameter / 2);

        public decimal CalculatePerimeter() => (decimal)Math.PI * _diameter;

        public string GetName(ILanguageStrategy language, int quantity) =>
            language.TranslateShapeName("Circle", quantity);
    }
}
