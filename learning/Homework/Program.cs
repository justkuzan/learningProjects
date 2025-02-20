using System;
using System.Formats.Asn1;
using System.Globalization;

namespace Homework
{
	class Program
	{	
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			
			int[] myArray = new int[] {5,6,7,8};
			int result = 0; //не догадался добавить переменную куда будем записывать результат

			Console.WriteLine("\nСумма всех четных чисел массива:");
			
			for (int i = 0; i < myArray.Length; i++)
			{
				if (myArray[i] % 2 == 0)
				{
					result += myArray[i]; //не догадался как суммирование можно реализовать
				}
			}
			
			Console.WriteLine(result);
		}
	}
}
