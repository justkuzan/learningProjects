/*

МАССИВЫ

int[] myArray = new int [] {5,6,7}; //инициализация массива, где автоматически выделена память под 3 элемента.

int[] myArray = Enumerable.Repeat(5, 10).ToArray(); //создаст массив из 10 элементов, каждый из которых будет содержать значение 5

int[] myArray = Enumerable.Range(4, 5).ToArray(); //создаст массив из 5 элементов, начинаться которые будут с 4. [0] 4, [1] 5, [2] 6, [3] 7

----------

Домашка на заполнение массива с консоли:

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

----------

Выбираем из массива только четные числа ищем их сумму
Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum()); 

----------

Получаем данные из двумерного массива, перебираем его и выводим типа таблицей. Я специально написал "типа", потому что это не таблица в строгом понимании.

static void Main()
{
	int[,] myArray =  //Не указываем тут количество строк и столбцов двумерного массива, тк массив всегда сам знает сколько в нем строк и столбцов
	
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

----------

*/