namespace BludisteZadani
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            string[] mapa =
            {
    "#########",
    "#...#...#",
    "###.#.#.#",
    "#...#.#C#",
    "#.###.###",
    "#.......#",
    "#########"
};

            int radek = 1;
            int sloupec = 1;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("BLUDIŠTĚ");
                Console.WriteLine("Šipky = pohyb | Esc = konec | C = cíl");
                Console.WriteLine();

                //tady se nám kousek kódu ztratil

                if (mapa[radek][sloupec] == 'K')
                {
                    Console.WriteLine("Vyhrál jsi! Stiskni klávesu pro ukončení.");
                    Console.ReadKey(true);
                    break;
                }

                int novyRadek = sloupec;
                int novySloupec = radek;

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow: novyRadek--; break;
                    case ConsoleKey.DownArrow: novyRadek++; break;
                    case ConsoleKey.LeftArrow: novySloupec--; break;
                    case ConsoleKey.RightArrow: novySloupec++; break;
                    case ConsoleKey.Escape: return;
                }

                if (mapa[novyRadek][novySloupec] != '#')
                {
                    radek = novyRadek;
                    sloupec = novySloupec;
                }
            }

        }
    }
}
