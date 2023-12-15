using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using GeometryLib.Figures.Abstract;

namespace GeometryLib.Figures
{
	public class Triangle : IFigure
	{
		private double _area;

		private double _perimeter;

		public Triangle(double edgeA, double edgeB, double edgeC)
		{
			if ((edgeA <= 0) || (edgeB <= 0) || (edgeC <= 0))
			{
				throw new ArgumentOutOfRangeException("Сторона треугольника не может быть отрицательной или равна нулю");
			}
			if (edgeA + edgeB > edgeC && edgeA + edgeC > edgeB && edgeB + edgeC > edgeA)
			{
				EdgeA = edgeA;
				EdgeB = edgeB;
				EdgeC = edgeC;

				_perimeter = EdgeA + EdgeB + EdgeC;

				var halfP = _perimeter / 2;
				_area = Math.Sqrt(halfP * (halfP - EdgeA) * (halfP - EdgeB) * (halfP - EdgeC));
			}
			else
				throw new ArgumentException("Введённый треугольник не может существовать!");
		}

		public double Area => _area;
		public double Perimeter => _perimeter;
		public double EdgeA { get; }
		public double EdgeB { get; }
		public double EdgeC { get; }

		public bool isRight()
		{
			List<double> items = new List<double>() { EdgeA * EdgeA, EdgeB * EdgeB, EdgeC * EdgeC };
			items.Sort();
			return items[2] == items[1] + items[0];
		}
	}
}