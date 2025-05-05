
namespace DevelopmentChallenge.Data.Interfaces
{
    public interface IGeometricShape
    {
        decimal CalculateArea();
        decimal CalculatePerimeter();
        string GetName(ILanguageStrategy language, int quantity);
    }
}
