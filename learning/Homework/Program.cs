using System;
using System.Formats.Asn1;

namespace Homework
{
	class Program
	{
		static int userNumber;
		
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			
			do
			{
				SelectTriangle();
			}
			while (Restart());
		}
		
		static void SelectTriangle()
		{
	
			Console.WriteLine("\nВыберите тип треугольника: ");
			Console.WriteLine("\n1. *\n   **\n   ***");
			Console.WriteLine("\n2. ***\n   **\n   *");
			Console.WriteLine("\n3.   *\n    ** \n   ***");
			Console.WriteLine("\n4. ***\n    **\n     *");
			
			int userChoice = int.Parse(Console.ReadLine());
			switch (userChoice)
			{
				case 1:
					Triangles.FirstTriangle(userNumber);
				break;
				
				case 2:
					Triangles.SecondTriangle(userNumber);
				break;
				
				case 3:
					Triangles.ThirdTriangle(userNumber);
				break;
				
				case 4:
					Triangles.ForthTriangle(userNumber);
				break;
				
				default:
					Console.WriteLine("Неизвестная кнопка");
				break;
			}
		}
		
		static bool Restart()
		{
			System.Console.WriteLine("\nХотите попробовать еще раз? (Enter - Да, Esc - Выйти)");
			ConsoleKey key = Console.ReadKey(true).Key;
			return key == ConsoleKey.Enter;
		} 
	}
}
