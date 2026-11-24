namespace CyklyProcviceni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cyklus s pevnym poctem opakovani");
            Console.WriteLine("Cisla vzestupne");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Cisla sestupne");
            for(int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Cyklus s podminkou na zacatku");
            Console.WriteLine("Cisla vzestupne");
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine("Cisla sestupne");
            int bz = 10;
            while (bz >=1)
            {
                Console.WriteLine(bz);
                bz--;
            }

            Console.WriteLine("Cyklus s podminkou na konci");
            Console.WriteLine("Cisla vzestupne");
            int fn = 1;
            do
            {
                Console.WriteLine(fn);
                fn++;
            } while (fn <= 10);


            Console.WriteLine("Cisla sestupne");
            int hm = 10;
            do
            {
                Console.WriteLine(hm);
                hm--;
            } while (hm >=1);
        }
    }
}
