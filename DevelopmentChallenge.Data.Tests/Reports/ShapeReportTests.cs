using System.Collections.Generic;
using DevelopmentChallenge.Data.Reports;
using DevelopmentChallenge.Data.Interfaces;
using DevelopmentChallenge.Data.Shapes;
using DevelopmentChallenge.Data.Languages;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Reports
{
    [TestFixture]
    public class ShapeReportTests
    {
        [Test]
        public void EmptyShapeListInSpanish()
        {
            var result = ShapeReport.Print(new List<IGeometricShape>(), new SpanishStrategy());
            Assert.That(result, Is.EqualTo("<h1>Lista vacía de formas!</h1>"));
        }

        [Test]
        public void ReportOneSquareInSpanish()
        {
            var shapes = new List<IGeometricShape> { new Square(5) };

            var result = ShapeReport.Print(shapes, new SpanishStrategy());
            Assert.That(result, Is.EqualTo("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25"));
        }

        [Test]
        public void ReportWithMultipleShapesInSpanish()
        {
            var shapes = new List<IGeometricShape>
            {
                new Square(5), new Circle(3), new EquilateralTriangle(4), new Square(2),
                new EquilateralTriangle(9), new Circle(2.75m), new EquilateralTriangle(4.2m)
            };

            var result = ShapeReport.Print(shapes, new SpanishStrategy());
            Assert.That(result, Is.EqualTo("<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13.01 | Perimetro 18.06 <br/>3 Triángulos | Area 49.64 | Perimetro 51.6 <br/>TOTAL:<br/>7 formas Perimetro 97.66 Area 91.65"));
        }

        [Test]
        public void EmptyShapeListInEnglish()
        {
            var result = ShapeReport.Print(new List<IGeometricShape>(), new EnglishStrategy());
            Assert.That(result, Is.EqualTo("<h1>Empty list of shapes!</h1>"));
        }

        [Test]
        public void ReportWithMultipleSquaresInEnglish()
        {
            var shapes = new List<IGeometricShape>
            {
                new Square(5),
                new Square(1),
                new Square(3)
            };

            var result = ShapeReport.Print(shapes, new EnglishStrategy());
            Assert.That(result, Is.EqualTo("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35"));
        }

        [Test]
        public void ReportWithMultipleShapesInEnglish()
        {
            var shapes = new List<IGeometricShape>
            {
                new Square(5), new Circle(3), new EquilateralTriangle(4), new Square(2),
                new EquilateralTriangle(9), new Circle(2.75m), new EquilateralTriangle(4.2m)
            };

            var result = ShapeReport.Print(shapes, new EnglishStrategy());
            Assert.That(result, Is.EqualTo("<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 97.66 Area 91.65"));
        }

        [Test]
        public void TrapezoidInItalian()
        {
            var shapes = new List<IGeometricShape> { new Trapezoid(10, 8, 6, 6) };
            var result = ShapeReport.Print(shapes, new ItalianStrategy());
            Assert.That(result, Is.EqualTo("<h1>Rapporto sulle forme</h1>1 Trapezio | Area 54 | Perimetro 30 <br/>TOTALE:<br/>1 forme Perimetro 30 Area 54"));
        }
    }
}