using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

/*
Написать метод для поиска индекса элемента массива (тип элементов в массиве - int).
Метод должен вернуть индекс первого найденного элемента.
Если элемент в массиве не найден - метод возвращает -1.
*/

namespace Homework
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] myArray = new int[] { 21, 34, 87, 56 };

			Console.Write("Введите индекс искомого числа в массиве: ");
			int userIndex = int.Parse(Console.ReadLine());

			int result = Index(myArray, userIndex);
			Console.WriteLine(result);
		}

		static int Index(int[] myArray, int userIndex)
		{
			for (int i = 0; i < myArray.Length; i++)
			{
				if (myArray[i] == userIndex)
				{
					return i;
				}
			}
			return -1;
		}
	}
}
