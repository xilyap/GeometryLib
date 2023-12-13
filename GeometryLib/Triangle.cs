using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
	public class Triangle : IFigure
	{
		public Triangle(double v1, double v2, double v3)
		{
			V1 = v1;
			V2 = v2;
			V3 = v3;
		}

		public double V1 { get; }
		public double V2 { get; }
		public double V3 { get; }

		public double GetArea()
		{
			var p = GetPerimeter() / 2;
			var res = Math.Sqrt(p * (p - V1) * (p - V2) * (p - V3)); ;
			return res;
		}

		public double GetPerimeter()
		{
			return V1 + V2 + V3;
		}
		public bool isRight()
		{
			List<double> items = new List<double>() { V1 * V1, V2 * V2, V3 * V3 };
			items.Sort();
			return items[2] == items[1] + items[0];
		}
	}
}