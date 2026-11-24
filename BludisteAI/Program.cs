namespace BludisteAI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mapa = VytvorBludiste();

            int radek = 1;
            int sloupec = 1;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("BLUDIŠTĚ");
                Console.WriteLine("Šipky = pohyb | Esc = konec | C = cíl");
                Console.WriteLine();

                for (int r = 0; r < mapa.Length; r++)
                {
                    for (int s = 0; s < mapa[r].Length; s++)
                    {
                        if (r == radek && s == sloupec)
                            Console.Write('X');
                        else
                            Console.Write(mapa[r][s]);
                    }

                    Console.WriteLine();
                }

                if (mapa[radek][sloupec] == 'C')
                {
                    Console.WriteLine("Vyhrál jsi! Stiskni klávesu pro ukončení.");
                    Console.ReadKey(true);
                    break;
                }

                int novyRadek = radek;
                int novySloupec = sloupec;

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        novyRadek--;
                        break;

                    case ConsoleKey.DownArrow:
                        novyRadek++;
                        break;

                    case ConsoleKey.LeftArrow:
                        novySloupec--;
                        break;

                    case ConsoleKey.RightArrow:
                        novySloupec++;
                        break;

                    case ConsoleKey.Escape:
                        return;

                    default:
                        continue;
                }

                // Skutečnou pozici změníme jen při kroku do chodby nebo cíle.
                if (mapa[novyRadek][novySloupec] != '#')
                {
                    radek = novyRadek;
                    sloupec = novySloupec;
                }
            }

            static string[] VytvorBludiste()
            {
                const int vyska = 7;
                const int sirka = 9;

                char[][] pole = new char[vyska][];

                // Na začátku je všude zeď.
                for (int r = 0; r < vyska; r++)
                {
                    pole[r] = new char[sirka];
                    Array.Fill(pole[r], '#');
                }

                var nahoda = new Random();
                VykopejChodby(1, 1);

                // Cíl označíme až po vykopání chodeb.
                pole[3][7] = 'C';

                string[] vysledek = new string[vyska];

                for (int r = 0; r < vyska; r++)
                {
                    vysledek[r] = new string(pole[r]);
                }

                return vysledek;

                void VykopejChodby(int r, int s)
                {
                    pole[r][s] = '.';

                    // Kandidáti leží o dvě políčka dál.
                    // Mezi současným a dalším políčkem je jedna zeď.
                    var smery = new (int Dr, int Ds)[]
                    {
            (-2, 0),
            (2, 0),
            (0, -2),
            (0, 2)
                    };

                    // Zamícháme pořadí, ve kterém směry zkoušíme.
                    for (int i = smery.Length - 1; i > 0; i--)
                    {
                        int j = nahoda.Next(i + 1);
                        (smery[i], smery[j]) = (smery[j], smery[i]);
                    }

                    foreach (var (dr, ds) in smery)
                    {
                        int dalsiRadek = r + dr;
                        int dalsiSloupec = s + ds;

                        // Obvod bludiště ponecháme celý ze zdí.
                        if (dalsiRadek <= 0 || dalsiRadek >= vyska - 1 ||
                            dalsiSloupec <= 0 || dalsiSloupec >= sirka - 1)
                        {
                            continue;
                        }

                        if (pole[dalsiRadek][dalsiSloupec] == '#')
                        {
                            // Otevřeme zeď mezi oběma políčky a pokračujeme dál.
                            pole[r + dr / 2][s + ds / 2] = '.';
                            VykopejChodby(dalsiRadek, dalsiSloupec);
                        }
                    }
                }
            }
        }
    }
}
