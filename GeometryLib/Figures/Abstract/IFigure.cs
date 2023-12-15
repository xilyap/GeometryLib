using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Figures.Abstract
{

    public interface IFigure
    {
        public double Area { get; }

        public double Perimeter { get; }
	}
}
