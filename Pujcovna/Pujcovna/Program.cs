using System.Security.Authentication.ExtendedProtection;

namespace Pujcovna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cena =0;
            int cele;
            int intervaly;
            Console.WriteLine("Zadej pocet minut:");
            int minuty = int.Parse(Console.ReadLine());
            if(minuty<1 || minuty > 720)
            {
                Console.WriteLine("Neplatna hodnota");
              //  return;
            }
            else if (minuty <= 30)
            {
              cena = 40;
              Console.WriteLine("Vysledna cena je: " + cena);
            }
            else
            {
                cele = minuty % 30;
                if (cele > 0)
                {
                    intervaly = 1 + (minuty - 30) / 30;
                }
                else
                {
                    intervaly = (minuty - 30) / 30;
                }
                cena = 40 + intervaly * 25;
                Console.WriteLine("Vysledna cena je: " + cena);
            }
            
        }
    }
}
