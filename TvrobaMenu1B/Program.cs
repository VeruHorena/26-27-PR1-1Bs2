namespace TvrobaMenu1B
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int volba;
            int a=0, b=0;
            int soucet = 0;
  

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("MENU:");
            Console.WriteLine("-----------");
            Console.WriteLine("1. Načti hodnoty");
            Console.WriteLine("2. Vypiš hodnoty");
            Console.WriteLine("3. Proveď součet");
            Console.WriteLine("4. Konec programu");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Zadej svoji volbu:");
            while(int.TryParse(Console.ReadLine(), out volba) == false)
            {
                Console.WriteLine("Jsi jouda, zadej hodnotu znovu.");
            }
            switch (volba)
            {
                case 1:
                    Console.WriteLine("Zadej hodnotu a:");
                    while (int.TryParse(Console.ReadLine(), out a) == false)
                    {
                        Console.WriteLine("Zadej znovu hodnotu a:");
                    }
                    Console.WriteLine("Zadej hodnotu b:");
                    while (int.TryParse(Console.ReadLine(), out b) == false)
                    {
                        Console.WriteLine("Zadej znovu hodnotu b:");
                    }
                    break;
                case 2: Console.WriteLine("Hodnota a je: " + a);
                        Console.WriteLine("Hodnota b je: " + b);
                    break;
                case 3:
                    soucet = a + b;
                    Console.WriteLine("Součet hodnot je: " + soucet);
                    break;
                case 4: return;

            }
        }
    }
}
