using System;

namespace Learning
{
	enum Color
	{
		red,
		green,
		yellow,
		blue
	}

	class Point
	{
		public int x;
		public int y;
		public Color color;
	}

	class Program
	{
		static void Main()
		{
			Point point = new Point();
			point.x = 2;
			point.y = 3;
			point.color = Color.red;

			Console.WriteLine($"{point.x}, {point.y}, {point.color}");
		}
	}
}