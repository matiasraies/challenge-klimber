using DevelopmentChallenge.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Reports
{
    /// <summary>
    /// Generates a formatted report of geometric shapes in the selected language.
    /// </summary>
    public static class ShapeReport
    {
        /// <summary>
        /// Prints a summarized report of a list of geometric shapes using a specified language strategy.
        /// </summary>
        /// <param name="shapes">The list of geometric shapes to include in the report.</param>
        /// <param name="language">The language strategy to use for the report's translations.</param>
        /// <returns>A string containing the formatted report, including total area and perimeter.</returns>
        public static string Print(List<IGeometricShape> shapes, ILanguageStrategy language)
        {
            if (shapes == null || !shapes.Any())
                return language.GetEmptyListMessage();

            var sb = new StringBuilder();
            sb.Append(language.GetHeader());

            // Group shapes by type and compute totals per type
            var grouped = shapes
                .GroupBy(shape => shape.GetType())
                .Select(g =>
                {
                    var shape = g.First();
                    int quantity = g.Count();
                    decimal area = g.Sum(s => s.CalculateArea());
                    decimal perimeter = g.Sum(s => s.CalculatePerimeter());
                    string name = shape.GetName(language, quantity);
                    return language.GetLine(quantity, name, area, perimeter);
                });

            // Add per-shape-type lines to the report
            foreach (var line in grouped)
                sb.Append(line);

            // Calculate overall totals
            decimal totalArea = shapes.Sum(s => s.CalculateArea());
            decimal totalPerimeter = shapes.Sum(s => s.CalculatePerimeter());

            sb.Append(language.GetFooter(shapes.Count, totalPerimeter, totalArea));
            return sb.ToString();
        }
    }
}
