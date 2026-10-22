namespace denTydne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int den;
          
            int volba;
            Console.WriteLine("Pro týden od pondělí 1 do neděle 7 zadej 1. \n Pro týden od neděle 1 do soboty 7 zadej 2.");
            if (int.TryParse(Console.ReadLine(), out volba) == false)
            {
                Console.WriteLine("Chybný vstup.");
                return;
            }

            Console.WriteLine("Zadej pořadové číslo dne:");
            //int den = int.Parse(Console.ReadLine());
            if (int.TryParse(Console.ReadLine(),out den) == false)
            {
                Console.WriteLine("Chybný vstup.");
                return;
            }

            if (volba == 2) {
                if (den == 1)
                    den = 7;
                else
                    den = den - 1;
            }
           switch (den)
            {
                case 1:Console.WriteLine("Je to pondělí.");
                    break;
                case 2:
                    Console.WriteLine("Je to úterý.");
                    break;
                case 3:
                    Console.WriteLine("Je to středa.");
                    break;
                case 4:
                    Console.WriteLine("Je to čtvrtek.");
                    break;
                case 5:
                    Console.WriteLine("Je to pátek.");
                    break;
                case 6:
                    Console.WriteLine("Je to sobota.");
                    break;
                case 7:
                    Console.WriteLine("Je to neděle.");
                    break;
                default:Console.WriteLine("Neplatné číslo dne.");
                    break;
            }
        }
    }
}
