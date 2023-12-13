namespace GeometryLib.Tests
{
	public class FigureTests
	{
		[Theory]
		[MemberData("TrianglePerAreaData")]
		
		public void ReturnSingleTriangleCorrectArea(float x1, float x2, float x3, float expected)
		{
			var area = new Triangle(x1, x2, x3).GetArea();
			Assert.Equal((double)expected, (double)area,2);
		}

		[Theory]
		[MemberData("CirclePerAreaData")]
		public void ReturnSingleCircleCorrectArea(float r, float expected)
		{
			var area = new Circle(r).GetArea();
			Assert.Equal((double)expected, (double)area, 2);
		}

		[Theory]
		[MemberData("TriangleIsRightData")]
		public void ReturnTriangleRight(float x1, float x2, float x3, bool expected)
		{
			var triangle = new Triangle(x1, x2, x3);
			Assert.Equal(expected, triangle.isRight());
		}

		public static IEnumerable<object[]> TrianglePerAreaData()
		{
			yield return new object[] { 20, 20, 20, 173.21 };
			yield return new object[] { 16, 19, 15, 116.189 };
			yield return new object[]{18, 15, 11, 82.3164};
			yield return new object[] {11, 24, 20, 109.137};
			yield return new object[] {12, 9, 15, 54}; 
			yield return new object[] {6, 6, 11, 13.188};
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
		public static IEnumerable<object[]> TriangleIsRightData()
		{
			yield return new object[] { 20, 20, 20, false };
			yield return new object[] { 16, 19, 15, false };
			yield return new object[] { 18, 15, 11, false };
			yield return new object[] { 11, 24, 20, false };
			yield return new object[] { 12, 9, 15, true };
			yield return new object[] { 6, 6, 11, false };
		}
	}
}