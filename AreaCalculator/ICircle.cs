using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    /// <summary>
    /// Круг
    /// </summary>
    public interface ICircle : IFigure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        double Radius { get; }
    }
}
