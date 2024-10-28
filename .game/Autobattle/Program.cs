using System;

namespace Autobattle
{
    internal class Config
    {
        public class GladiatorBasicStats
        {
            public int Health { get; set; }
            public int Damage { get; set; }
            public int Armor { get; set; }
        }

        public class GladiatorAdditionalStats
        {
            private float block = 0.1f;
            private float dodge = 0.1f;
        }

        public class GlobalDamageStats
        {
            private float critDamage = 0.5f;
            private float glancing = 0.5f;
            private float miss = 0f;
            private float block = 0.1f;
        }
    }

    internal class GameModel
    {
        private Random _randomGenerator = new Random();
        private Config.GladiatorBasicStats gladiator1;
        private Config.GladiatorBasicStats gladiator2;

        public void GenerateGladiator1()
        {
            gladiator1 = new Config.GladiatorBasicStats
            {
                Health = _randomGenerator.Next(80, 100),
                Damage = _randomGenerator.Next(10, 20),
                Armor = _randomGenerator.Next(5, 15)
            };
        }
        public void GenerateGladiator2()
        {
            gladiator2 = new Config.GladiatorBasicStats
            {
                Health = _randomGenerator.Next(80, 100),
                Damage = _randomGenerator.Next(10, 20),
                Armor = _randomGenerator.Next(5, 15)
            };
        }
        
        public Config.GladiatorBasicStats GetGladiator1()
        {
            return gladiator1;
        }
        public Config.GladiatorBasicStats GetGladiator2()
        {
            return gladiator2;
        }
    }

    internal class GameView
    {
        public void DisplayGladiatorsStats(GameModel gameModel)
        {
            var gladiator1 = gameModel.GetGladiator1();
            var gladiator2 = gameModel.GetGladiator2();
            Console.WriteLine($"{"",10} {"Gladiator 1",-15} {"Gladiator 2",-15}");
            Console.WriteLine($"{"Health:",-10} {gladiator1.Health,-15} {gladiator2.Health,-15}");
            Console.WriteLine($"{"Damage:",-10} {gladiator1.Damage,-15} {gladiator2.Damage,-15}");
            Console.WriteLine($"{"Armor:",-10} {gladiator1.Armor,-15} {gladiator2.Armor,-15}");
        }
    }

    class GameController
    {
        public static void PlayGame()
        {
            var gameModel = new GameModel();
            gameModel.GenerateGladiator1();
            gameModel.GenerateGladiator2();

            var gameView = new GameView();
            gameView.DisplayGladiatorsStats(gameModel);
            
            Console.SetCursorPosition(0, Console.CursorTop+1);
            
        }
    }

    class Program
    {
        public static void Main()
        {
            GameController.PlayGame();
        }
    }
}