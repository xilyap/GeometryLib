using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLib.Figures.Abstract;

namespace GeometryLib.Figures
{
	public class Triangle : IFigure
	{
		public Triangle(double edgeA, double edgeB, double edgeC)
		{
			if (edgeA + edgeB > edgeC && edgeA + edgeC > edgeB && edgeB + edgeC > edgeA)
			{
				EdgeA = edgeA;
				EdgeB = edgeB;
				EdgeC = edgeC;
			}
			else
				throw new ArgumentException("Введённый треугольник не может существовать!");
		}

		public double EdgeA { get; }
		public double EdgeB { get; }
		public double EdgeC { get; }

		public double GetArea()
		{
			var p = GetPerimeter() / 2;
			var res = Math.Sqrt(p * (p - EdgeA) * (p - EdgeB) * (p - EdgeC)); ;
			return res;
		}

		public double GetPerimeter()
		{
			return EdgeA + EdgeB + EdgeC;
		}

		public bool isRight()
		{
			List<double> items = new List<double>() { EdgeA * EdgeA, EdgeB * EdgeB, EdgeC * EdgeC };
			items.Sort();
			return items[2] == items[1] + items[0];
		}
	}
}