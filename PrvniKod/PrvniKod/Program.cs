namespace PrvniKod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string uzivatel;
            int vek;
            Console.WriteLine("Zadej sve jmeno:");
            uzivatel = Console.ReadLine();
            Console.WriteLine("Ahoj "+uzivatel);
            Console.WriteLine("Zadej svuj vek:");
            vek = int.Parse(Console.ReadLine());
            Console.WriteLine("To je super, ze je ti " + vek + " let.");
           
        }
    }
}
