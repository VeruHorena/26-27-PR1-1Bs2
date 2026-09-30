namespace Kalkulacka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vysledek;
            Console.WriteLine("Zadej hodnotu a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadej hodnotu b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadej operaci:");
            char operace = Console.ReadKey().KeyChar;
            if (operace == '-')
            {
                vysledek = a - b;
            }
            else
            {
                vysledek = a + b;
            }
            Console.WriteLine("Vysledek je: " + Math.Round(vysledek, 2));
        }
    }
}
