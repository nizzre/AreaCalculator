using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    /// <summary>
    /// Класс для рассчёта радиуса круга
    /// </summary>
    public class Circle : ICircle
    {
        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius)
        {
            Radius = radius;

            CheckFigure();
        }

        /// <summary>
        /// Проверка переданных параметров фигуры
        /// </summary>
        protected void CheckFigure()
        {
            if (Radius <= 0)
                throw new ArgumentException("Радиус круга должен быть больше 0");
        }

        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; private set; }

        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        /// <returns>площадь фигуры</returns>
        public double GetArea()
            => Radius * Radius * Math.PI;
    }
}
