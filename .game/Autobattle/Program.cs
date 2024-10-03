using System;
using System.Threading;

namespace Autobattle
{
    class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Random rand = new Random();

            float health1 = rand.Next(90, 110);
            int damage1  = rand.Next(15, 35);
            int armor1 = rand.Next(45, 100);

            float health2 = rand.Next(80, 120);
            int damage2 = rand.Next(12, 38);
            int armor2 = rand.Next(65, 100);

            System.Console.WriteLine($"Gladiator CASSIUS - {health1} HP, {damage1} DMG, {armor1} ARMOR");
            Thread.Sleep(500);
            System.Console.WriteLine($"Gladiator TITUS - {health2} HP, {damage2} DMG, {armor2} ARMOR");
            
            Console.WriteLine();
            Thread.Sleep(1500);
            System.Console.WriteLine("LETS THE BATTLE BEGIN!");
            Console.WriteLine();
            Thread.Sleep(1500);

            while(health1 > 0 && health2 > 0)
            {
                health1 -= Convert.ToSingle(rand.Next(0, damage2 + 1)) / 100 * armor1;
                health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armor2;

                System.Console.WriteLine("CASSIUS HP: " + health1);
                Thread.Sleep(350);
                System.Console.WriteLine("TITUS HP: " + health2);
                Thread.Sleep(1000);
                Console.WriteLine();
            }

            if (health1 <= 0 && health2 <= 0)
            {
                System.Console.WriteLine("Draw. Both gladiators died.");
            }
            else if (health1 <= 0)
            {
                System.Console.WriteLine("-----------------------------");
                System.Console.WriteLine("Gladiator CASSIUS fell.\nTITUS won a crushing victory!");
                Console.WriteLine();
            }
            else if (health2 <= 0)
            {
                System.Console.WriteLine("-----------------------------");
                System.Console.WriteLine("Gladiator TITUS fell.\nCASSIUS won a crushing victory!");
                Console.WriteLine();
            }

        }
    }
}
