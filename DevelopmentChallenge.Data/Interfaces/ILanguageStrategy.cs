
namespace DevelopmentChallenge.Data.Interfaces
{
    public interface ILanguageStrategy
    {
        string GetHeader();
        string GetFooter(int totalShapes, decimal totalPerimeter, decimal totalArea);
        string GetLine(int quantity, string shapeName, decimal area, decimal perimeter);
        string TranslateShapeName(string shapeKey, int quantity);
        string GetEmptyListMessage();
    }
}
