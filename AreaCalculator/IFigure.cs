using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    /// <summary>
    /// Базовый интерфейс для геометрических фигур
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        /// <returns>площадь фигуры</returns>
        double GetArea();
    }
}
