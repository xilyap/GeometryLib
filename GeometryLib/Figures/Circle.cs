using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLib.Figures.Abstract;

namespace GeometryLib.Figures
{
	public class Circle : IFigure
	{
		public double Radius { get; }

		public Circle(double radius)
		{
			if (radius <= 0)
			{
				throw new ArgumentOutOfRangeException("Радиус не может быть меньше или равен нулю");
			}
			Radius = radius;
		}

		public double GetArea()
		{
			return Math.PI * Radius * Radius;
		}

		public double GetPerimeter()
		{
			return Math.PI * Radius * Radius;
		}
	}
}