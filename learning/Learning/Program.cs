using System;

namespace Learning
{
	class Program
	{
		static void Main()
		{
			int[,] myArray =
			{
				{ 25, 12, 7, 4, 69 },
				{ 1, 19, 56, 81, 44 },
				{ 73, 92, 17, 46, 31 }
			};

			int height = myArray.GetLength(0); //получаем количество строк массива
			int width = myArray.GetLength(1); //получаем количество столбцов массива

			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
					Console.Write(myArray[y, x] + "\t");
				}
				Console.WriteLine();
			}
		}
	}
}