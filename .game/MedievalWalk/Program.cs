using System;

namespace MedievalWalk
{
	class Program
	{
		public static void Main()
		{
			SceneManager();
		}
		
		public static void SceneManager()
		{
			System.Console.WriteLine("You turned into a dark alley. Three figures appeared in front of you. Choose the one you want to interact with: ");
			
			CharList charlist = new CharList();
			System.Console.WriteLine($"1: {charlist.char1}");
			
		}
	}
	
	class CharList()
	{
		public string char1 = "Sorcerer";
		public string char2 = "Three Guards";
		public string char3 = "Bouncer";
			
	}
}