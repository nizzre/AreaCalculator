using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculator;

namespace AreaCalculatorTest
{
    /// <summary>
    /// Summary description for CircleTest
    /// </summary>
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Circle_10_GetArea_Returns_100Pi()
        {
            //Arrange 
            var r = 10d;
            var s = r * r * Math.PI;
            var circle = new Circle(r);

            //Act
            var area = circle.GetArea();

            // Assert
            Assert.AreEqual(area, s);
        }

        /// <summary>
        /// Площадь вписанного в квадрат круга всегда меньше площади квадрата
        /// </summary>
        [TestMethod]
        public void CircleInscribedSquareArea_Less_SquareArea()
        {
            //Arrange 

            //Квадрат
            var a = 10d;
            var s = a * a;

            //У вписанной окружности радиус равен половине стороны квадрата
            var r = a / 2;

            var circle = new Circle(r);

            //Act
            var circleArea = circle.GetArea();

            // Assert
            Assert.IsTrue(circleArea < s);
        }
    }
}
