using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLib.Figures.Abstract;

namespace GeometryLib.Figures
{
	/// <summary>
	/// Класс круга. Иммутабельный. Предназначен для оценки длины и площади любого круга.
	/// </summary>
	public class Circle : IFigure
	{
		private double _area;
		private double _perimeter;

		public Circle(double radius)
		{
			if (radius <= 0)
			{
				throw new ArgumentOutOfRangeException("Радиус не может быть меньше или равен нулю");
			}
			Radius = radius;
			_area = Math.PI * Radius * Radius;
			_perimeter = 2 * Math.PI * Radius;
		}

		public double Area => _area;

		public double Perimeter => _perimeter;

		public double Radius { get; }
	}
}