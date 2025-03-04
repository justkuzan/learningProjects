using System;
using System.Formats.Asn1;
using System.Globalization;

namespace Homework
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите символ: ");
			string symbol = Console.ReadLine();

			Console.Write("Введите количество: ");
			uint quantity = Convert.ToUInt32(Console.ReadLine());

			PrintLine(symbol, quantity);
		}

		static void PrintLine(string symbol, uint quantity)
		{
			for (int i = 0; i < quantity; i++)
			{
				Console.Write(symbol);
			}
		}
	}
}
