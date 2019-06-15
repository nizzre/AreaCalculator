using System;
using AreaCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaCalculatorTest
{
    [TestClass]
    public class TriangleTest
    {

        [TestMethod]
        public void Triangle_3_4_5_GetArea_Returns_6()
        {
            //Arrange 
            var a = 3d;
            var b = 4d;
            var c = 5d;
            var s = 6d;

            var triangle = new Triangle(a, b, c);

            //Act
            var area = triangle.GetArea();

            // Assert
            Assert.AreEqual(area, s);
        }

        /// <summary>
        /// Проверка на прямоугольный треугольник
        /// </summary>
        [TestMethod]
        public void Triangle_3_4_5_IsRight()
        {
            //Arrange 
            var a = 3d;
            var b = 4d;
            var c = 5d;

            var triangle = new Triangle(a, b, c);

            //Act
            var isRight = triangle.IsRight();

            // Assert
            Assert.IsTrue(isRight);
        }

        /// <summary>
        /// Проверка на не прямоугольный треугольник
        /// </summary>
        [TestMethod]
        public void Triangle_3_4_4_IsNotRight()
        {
            //Arrange 
            var a = 3d;
            var b = 4d;
            var c = 4d;

            var triangle = new Triangle(a, b, c);

            //Act
            var isRight = triangle.IsRight();

            // Assert
            Assert.IsFalse(isRight);
        }

        /// <summary>
        /// Проверка на равносторонний треугольник
        /// </summary>
        [TestMethod]
        public void Triangle_3_3_3_IsRegular()
        {
            //Arrange 
            var a = 3d;

            var triangle = new Triangle(a, a, a);

            //Act
            var isRegular = triangle.IsRegular();

            // Assert
            Assert.IsTrue(isRegular);
        }

        /// <summary>
        /// Проверка на не равносторонний треугольник
        /// </summary>
        [TestMethod]
        public void Triangle_3_4_4_IsNotRegular()
        {
            //Arrange 
            var a = 3d;
            var b = 4d;
            var c = 4d;

            var triangle = new Triangle(a, b, c);

            //Act
            var isRegular = triangle.IsRegular();

            // Assert
            Assert.IsFalse(isRegular);
        }
    }
}
