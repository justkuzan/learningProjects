using System;
using System.Formats.Asn1;

namespace Homework
{
	class Program
	{	
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;

			Console.Write("Введите количество элементов массива:\t");
			int elementsCount = int.Parse(Console.ReadLine() ?? "0");
			
			int[] myArray = new int[elementsCount];
			
			for (int i = 0; i < myArray.Length; i++)
			{
				Console.Write($"\nВведите элемент массива под индексом {i}:\t ");
				myArray[i] = int.Parse(Console.ReadLine() ?? "0");
			}

			Console.WriteLine("\nВывод массива:");
			for (int i = 0; i < myArray.Length; i++)
			{
				Console.WriteLine(myArray[i]);
			}
		}
	}
}
