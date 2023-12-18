using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Figures.Abstract
{
	//todo: Рассмотреть вариант отделения интерфейсов IAreable IPerimetable
	public interface IFigure
	{
		public double Area { get; }

		public double Perimeter { get; }
	}
}