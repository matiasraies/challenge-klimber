using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Shapes
{
    public class Trapezoid : IGeometricShape
    {
        private readonly decimal _base1, _base2, _height, _side;

        public Trapezoid(decimal base1, decimal base2, decimal height, decimal side)
        {
            _base1 = base1;
            _base2 = base2;
            _height = height;
            _side = side;
        }

        public decimal CalculateArea() => ((_base1 + _base2) / 2) * _height;

        public decimal CalculatePerimeter() => _base1 + _base2 + 2 * _side;

        public string GetName(ILanguageStrategy language, int quantity) =>
            language.TranslateShapeName("Trapezoid", quantity);
    }
}
