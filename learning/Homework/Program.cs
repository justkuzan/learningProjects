using System;
using System.Formats.Asn1;
using System.Globalization;

namespace Homework
{
	class Program
	{	
		//Наименьшее число в массиве
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			
			int[] myArray = new int[] {24,17,4,39};
			
			int k = myArray[0];

			Console.WriteLine("\nНаименьшее число в массиве:");
			
			for (int i = 1; i < myArray.Length; i++)
			{
				if(myArray[i] < k)
				{
					k = myArray[i];
				}
			}
			
			Console.WriteLine(k);
			
			
		}
	}
}
