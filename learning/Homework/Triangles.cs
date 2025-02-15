using System;
using System.Formats.Asn1;

namespace Homework
{

	class Triangles
	{	
		public static void FirstTriangle(int userNumber)
		{	
			Console.Write("\nВведите высоту треугольника: ");
			userNumber = int.Parse(Console.ReadLine());
			
			for (int i = 0; i < userNumber; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
		
		public static void SecondTriangle(int userNumber)
		{	
			Console.Write("\nВведите высоту треугольника: ");
			userNumber = int.Parse(Console.ReadLine());
			
			for (int i = 0; i < userNumber; i++)
			{
				for (int j = userNumber; j > i; j--)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
		
		public static void ThirdTriangle(int userNumber)
		{	
			Console.Write("\nВведите высоту треугольника: ");
			userNumber = int.Parse(Console.ReadLine());
			
			for (int i = 0; i < userNumber; i++)
			{
				for (int j = userNumber; j > i; j--)
				{
					Console.Write(" ");
				}

				for (int j = 0; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
		
		public static void ForthTriangle(int userNumber)
		{	
			Console.Write("\nВведите высоту треугольника: ");
			userNumber = int.Parse(Console.ReadLine());
			
			for (int i = 0; i < userNumber; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					Console.Write(" ");
				}
				
				for (int j = userNumber; j > i; j--)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}
