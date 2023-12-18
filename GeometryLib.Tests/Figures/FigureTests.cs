using GeometryLib.Figures.Abstract;

namespace GeometryLib.Tests.Figures
{
	public class FigureTests
	{
		private List<IFigure> figures = new List<IFigure>() {
			new Circle( 5),
			new Circle(16),
			new Circle(18),
			 new Circle(11),
			new Circle(4),
			new Circle(6),
			new Triangle(20, 20, 20),
			new Triangle(16, 19, 15),
			new Triangle(18, 15, 11),
			new Triangle(11, 24, 20),
			new Triangle(12, 9, 15),
			new Triangle(6, 6, 11),
			};

		[Fact]
		public void ListOfFiguresTest()
		{
			foreach (IFigure f in figures)
			{
				Console.WriteLine(f.Area);
			}
		}
	}
}