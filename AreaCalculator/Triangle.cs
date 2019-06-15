using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    /// <summary>
    /// Класс для рассчёта площади треугольника
    /// </summary>
    public class Triangle : ITriangle
    {
        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="a">Сторона A треугольника</param>
        /// <param name="b">Сторона B треугольника</param>
        /// <param name="c">Сторона C треугольника</param>
        public Triangle(double a, double b, double c)
            : base()
        {
            Sides = new List<double> { a, b, c };

            CheckFigure();
        }

        /// <summary>
        /// Коллекция сторон треугольника
        /// </summary>
        public IReadOnlyCollection<double> Sides { get; private set; }

        /// <summary>
        /// Проверка переданных параметров фигуры
        /// </summary>
        protected void CheckFigure()
        {
            if (Sides.Any(s => s <= 0))
                throw new ArgumentException("Сторона c треугольника должна быть больше 0");

            var orderedSides = Sides.OrderByDescending(s => s);
            var longestSide = orderedSides.First();
            var shortSides = orderedSides.Skip(1);
            if (longestSide > shortSides.Sum())
                throw new ApplicationException("Переданная фигура не является треугольником");
        }

        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        /// <returns>площадь фигуры</returns>
        public double GetArea()
        {
            var p = Sides.Sum() / 2;
            return Math.Sqrt(p * Sides.Aggregate(1d, (mult, s) => mult * (p - s)));
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            var orderedSides = Sides.OrderByDescending(s => s);
            var hypotenuse = orderedSides.First();
            var cathetuses = orderedSides.Skip(1);

            return hypotenuse * hypotenuse == cathetuses.Sum(s => s * s); //.Aggregate(0d, (summ, s) => summ + s * s);
        }

        /// <summary>
        /// Является ли треугольник равносторонним
        /// </summary>
        /// <returns></returns>
        public bool IsRegular() 
            => Sides.All(s => s == Sides.First());
    }
}
