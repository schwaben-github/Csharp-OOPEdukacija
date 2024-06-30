namespace Potrogrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello();
            Pozdrav("Tibor");
            Pozdrav("Tibor", "Weigand");
            Pozdrav("Tibor", 3);
            Kraj();

        }

        static void Hello()
        {
            Console.WriteLine("Pozdrav iz potprograma!");
        }

        static void Kraj()
        {
            Console.WriteLine("Pritisni tipku za kraj...");
            Console.ReadKey();
        }

        static void Pozdrav(string ime)
        {
            Console.WriteLine("Dobro veče, {0}", ime);
        }

        //overload metode/potprograma
        static void Pozdrav(string ime, string prezime)
        {
            Console.WriteLine("Dobro veče, {0} {1}", ime, prezime);
        }
        static void Pozdrav(string ime, int broj)
        {
            for (int i = 0; i < broj; i++)
            {
                Pozdrav(ime);
            }
        }
    }
}
