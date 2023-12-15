using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Tests.Figures
{
	public class CircleTests
	{
		[Fact]
		public void ShouldThrowIncorrectCircle()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10));
		}

		[Theory]
		[MemberData(nameof(CirclePerAreaData))]
		public void ReturnSingleCircleCorrectArea(double r, double expected)
		{
			var area = new Circle(r).Area;
			Assert.Equal(expected, area, 2);
		}

		[Theory]
		[MemberData(nameof(CirclePerPerimeterData))]
		public void ReturnSingleCircleCorrectPerimeter(double r, double expected)
		{
			var perimeter = new Circle(r).Perimeter;
			Assert.Equal(expected, perimeter, 2);
		}

		public static IEnumerable<object[]> CirclePerAreaData()
		{
			yield return new object[] { 5, 78.5398 };
			yield return new object[] { 16, 804.247719296 };
			yield return new object[] { 18, 1017.876019734 };
			yield return new object[] { 11, 380.1327110735 };
			yield return new object[] { 4, 50.265482456 };
			yield return new object[] { 6, 113.097335526 };
		}

		public static IEnumerable<object[]> CirclePerPerimeterData()
		{
			yield return new object[] { 5, 31.41592 };
			yield return new object[] { 16, 100.530944 };
			yield return new object[] { 18, 113.097312 };
			yield return new object[] { 11, 69.115024 };
			yield return new object[] { 4, 25.132736 };
			yield return new object[] { 6, 37.699104 };
		}
	}
}