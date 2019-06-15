using System;
using AreaCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaCalculatorTest
{
    [TestClass]
    public class FigureTest
    {
        /// <summary>
        /// Площадь вписанного в треугольник круга всегда меньше площади треугольника
        /// </summary>
        [TestMethod]
        public void TriangleInscribedCircleArea_Less_TriangleArea()
        {
            //Для упрощения расчётов используем прямоугольный треугольник
            var c = 10d;
            var a = c / 2;
            var b = c * Math.Sqrt(3) / 2;

            //У прямоугольного треугольника радиус вписанной окружности рассчитывается как:
            var r = (a + b - c) / 2;

            IFigure circle = new Circle(r);
            IFigure triangle = new Triangle(a, b, c);

            //Act
            var circleArea = circle.GetArea();
            var triangleArea = triangle.GetArea();

            // Assert
            Assert.IsTrue(circleArea < triangleArea);
        }

        /// <summary>
        /// Площадь описанного вокруг треугольника круга всегда больше площади треугольника
        /// </summary>
        [TestMethod]
        public void TriangleDescribedCircleArea_More_TriangleArea()
        {
            //Arrange 

            //Для упрощения расчётов используем прямоугольный треугольник
            var c = 10d;
            var a = c / 2;
            var b = c * Math.Sqrt(3) / 2;

            //У прямоугольного треугольника гипотенуза является диаметром описанной окружности
            var r = c / 2;

            IFigure circle = new Circle(r);
            IFigure triangle = new Triangle(a, b, c);

            //Act
            var circleArea = circle.GetArea();
            var triangleArea = triangle.GetArea();

            // Assert
            Assert.IsTrue(circleArea > triangleArea);
        }
    }
}
