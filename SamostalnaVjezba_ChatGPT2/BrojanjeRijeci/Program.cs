namespace BrojanjeRijeci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // omoguci korisniku unos teksta, a zatim svori objekt klase "Brojac" i ispiši broj riječi u unesenom tekstu
            Console.WriteLine("Unesite rečenicu:");
            string recenica = Console.ReadLine();
            Brojac brojac = new Brojac(recenica);
            brojac.IspisiBrojRijeci();
            Console.WriteLine();

            // ispiši broj pojavljivanja svake riječi u unesenom tekstu
            brojac.IspisiBrojPojavljivanjaRijeci();

            Console.ReadKey();
        }
    }
}
