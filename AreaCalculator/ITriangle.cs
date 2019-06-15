using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public interface ITriangle : IFigure
    {
        /// <summary>
        /// Коллекция сторон треугольника
        /// </summary>
        IReadOnlyCollection<double> Sides { get; }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        bool IsRight();
        
        /// <summary>
        /// Является ли треугольник равносторонним
        /// </summary>
        /// <returns></returns>
        bool IsRegular();
    }
}
