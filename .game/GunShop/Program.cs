class GunShop
{
    public static void Main(string[] args)
    {
        var player = Player.GetPlayer();
        player.Print();
        
        var gun = Gun.GetGun();
        gun.Print();
        
        Buying();
    }
    
    public class Player
    {
        int playerMoney = 10000;
        int playerDamage;
        bool hasAGun = false;
 
        public static Player GetPlayer()
        {
            var player = new Player();
            return player;
        }

        public void Print()
        {
            Console.WriteLine($"Player's money: {playerMoney}\nPlayer's damage: {playerDamage}\nHas a gun: {hasAGun}\n");
        }
    }
    
    public class Gun
    {
        public string weaponBrand;
        public int weaponDamage;
        public int weaponPrice;
        public static Gun GetGun()
        {
            var gun = new Gun();
            Random rand = new Random();
            
            string weaponName = "UZI AK47 P90 AUG(Bullpup) Krieg-552 M249 M3 M4-A1";
            string[] words = weaponName.Split(' ');
            int num = rand.Next(0, words.Length);
            
            gun.weaponBrand = words[num];
            gun.weaponDamage = rand.Next(20, 80);
            gun.weaponPrice = rand.Next(3000, 9000);
            return gun;
        }

        public void Print()
        {
            Console.WriteLine($"Weapon: {weaponBrand}\nDamage: {weaponDamage}\nPrice: {weaponPrice}\n");
            Console.WriteLine("Press ENTER to buy / Press ESC to return to weapon selection\n");
            ConsoleKeyInfo charKey = Console.ReadKey();
            // switch (charKey.Key)
            // {
            //     case ConsoleKey.Enter:
            //         if (Player.playerMoney = weaponPrice);
            //         break;
            //     case ConsoleKey.Escape:
            //         Main();
            //         break;
            // }
        }
    }
    public static void Buying()
    {
        Gun.GetGun();
        var playerGun = new Gun;
        Console.WriteLine($"Weapon: {gun.weaponBrand}\nDamage: {Gun.GetGun().weaponDamage}\nPrice: {Gun.GetGun().weaponPrice}\n");
    }
    
    // Random rand = new Random();
    // private Gun gun = new Gun();
    // weaponDamage = rand.Next(1, 100);
    