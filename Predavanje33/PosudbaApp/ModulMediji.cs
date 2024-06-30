using DAL;
using DAL.Models;
using PosudbaApp;

namespace PosudbaApp
{
    internal class ModulMediji
    {
        public static void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Mediji iz baze:");
            Console.WriteLine("ID\tNaslov medija\t\tTip medija");
            Console.WriteLine("--------------------------------");

            var mediji = DBMethods.DohvatiMedije;
            if (mediji != null)
            {
                foreach (var medij in DBMethods.DohvatiMedije())
                {
                    Console.WriteLine($"{medij.MedijId}\t{medij.Naslov}\t{medij.Tip}");
                }
            }
            else
            {
                Console.WriteLine("Nema zapisa o medijima.");
            }
            
            Console.WriteLine();
            Console.WriteLine("Pritisni tipku za nastavak...");
            Console.ReadKey();
            Izbornici.Mediji();
        }

        public static void Create()
        {
            Console.WriteLine();
            Mediji m = new Mediji();
            Console.Write("Unesi naslov medija: ");
            m.Naslov = Console.ReadLine();
            Console.Write("Unesi tip medija: ");
            m.Tip = Console.ReadLine();
            DBMethods.DodajMedij(m);
            Console.WriteLine();
            Console.WriteLine("Medij dodan u bazu!");
            Console.WriteLine("Pritisni tipku za nastavak...");
            Console.ReadKey();
            Izbornici.Mediji();
        }

        public static void Update()
        {
            Console.WriteLine();

            Mediji medij = new Mediji();
            Console.WriteLine();
            Console.WriteLine("Mediji iz baze:");
            Console.WriteLine("ID\tNaslov medija\tTip medija");
            Console.WriteLine("--------------------------------");
            foreach (var m in DBMethods.DohvatiMedije())
            {
                Console.WriteLine($"{m.MedijId}\t{m.Naslov}\t{m.Tip}");
            }
            Console.Write("Unesi ID medija kojeg želiš izmijeniti: ");
            
            medij.MedijId = int.Parse(Console.ReadLine());
            Console.Write("Unesi novi naslov medija: ");
            medij.Naslov = Console.ReadLine();
            Console.Write("Unesi novi tip medija: ");
            medij.Tip = Console.ReadLine();
            DBMethods.IzmjeniMedij(medij);
            Console.WriteLine();
            Console.WriteLine("Medij izmijenjen!");
            Console.WriteLine("Pritisni tipku za nastavak...");
            Console.ReadKey();
            Izbornici.Mediji();
        }

        public static void Delete()
        {
            Console.WriteLine();

            Mediji medij = new Mediji();
            Console.WriteLine();
            Console.WriteLine("Mediji iz baze:");
            Console.WriteLine("ID\tNaslov medija\tTip medija");
            Console.WriteLine("--------------------------------");
            foreach (var m in DBMethods.DohvatiMedije())
            {
                Console.WriteLine($"{m.MedijId}\t{m.Naslov}\t{m.Tip}");
            }
            Console.Write("Unesi ID medija kojeg želiš obrisati: ");
            int medijId = int.Parse(Console.ReadLine());
            DBMethods.ObrisiMedij(medijId);
            Console.WriteLine();
            Console.WriteLine("Medij obrisan!");
            Console.WriteLine("Pritisni tipku za nastavak...");
            Console.ReadKey();
            Izbornici.Mediji();
        }
    }
}
