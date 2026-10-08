using System.Runtime.InteropServices;
namespace Had
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 5;
            int pocetKroku = 0;
            int prekazkaX = 15;
            int prekazkaY = 10;

            int potravaX;
            int potravaY;
            Random generator = new Random();
            potravaX = generator.Next(1, 31);
            potravaY = generator.Next(1, 21);

            int snezeno = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.SetCursorPosition(x, y);
                Console.Write('O');
                Console.SetCursorPosition(prekazkaX, prekazkaY);
                Console.Write('X');
                Console.SetCursorPosition(potravaX, potravaY);
                Console.Write('J');
                Console.SetCursorPosition(0, 21);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Aktualni skore: " + snezeno);

                ConsoleKeyInfo klavesa = Console.ReadKey();
                if (klavesa.Key == ConsoleKey.RightArrow && x<30)
                {
                    x = x + 1; //x++;
                    pocetKroku++;
                }
                if (klavesa.Key == ConsoleKey.LeftArrow && x>0)
                {
                    x = x - 1; //x--;
                    pocetKroku++;
                }
                if (klavesa.Key == ConsoleKey.UpArrow && y>1)
                {
                    y = y - 1;
                    pocetKroku++;
                }
                if (klavesa.Key == ConsoleKey.DownArrow && y<20)
                {
                    y = y + 1;
                    pocetKroku++;
                }

                if(x==prekazkaX && y == prekazkaY)
                {
                    Console.Clear();
                    Console.WriteLine("Konec hry. Usel jsi: " + pocetKroku + " kroku.");
                    break;
                }
                if(x==potravaX && y == potravaY)
                {
                    potravaX = generator.Next(1, 31);
                    potravaY = generator.Next(1, 21);
                    snezeno++;
                }
            }
            Console.WriteLine("Nezapomen dat odber a like :-)");
        }
    }
}
