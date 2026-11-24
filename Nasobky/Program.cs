namespace Nasobky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo;
            Console.WriteLine("Zadej hodnotu zakladu");
            while(int.TryParse(Console.ReadLine(), out cislo)==false)
            {
                Console.WriteLine("Chybna hodnota, zadej znovu:");
            }
            //int nasobek;
            Console.WriteLine("Nasobky pomoci cyklu for");
            int i = 1;
            for (i = 1; i <= 10; i++)
            {
               // nasobek = cislo * i;
                Console.WriteLine(i + ".nasobek cisla " + cislo + " je " + (cislo*i));
            }
            Console.WriteLine("Nasobky pomoci cyklu while");
            i = 1;
            while (i <= 10) { 
                Console.WriteLine(i + ".nasobek cisla " + cislo + " je " + (cislo * i));
                i++;
            } ;
                
            
        }
    }
}
