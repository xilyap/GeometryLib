using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{

	public class Circle:IFigure
	{
		public double Radius { get; set; }

		public Circle(double radius)
		{
			this.Radius = radius;
		}

		public double GetArea()
		{
			return (float) Math.PI * Radius * Radius;
		}
	}
}
