using System;

namespace Learning
{
	class Program
	{
		static void Main()
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			
			System.Console.WriteLine("Введите высоту прямоугольника: ");
			int height = int.Parse(Console.ReadLine());
			
			System.Console.WriteLine("Введите ширину прямоугольника: ");
			int width = int.Parse(Console.ReadLine());
			
			for (int j = 0; j < height; j++)
			{
				for (int i = 0; i < width; i++ )
				{
					System.Console.Write("#");
				}
				System.Console.WriteLine();
			}
		}
	}
}