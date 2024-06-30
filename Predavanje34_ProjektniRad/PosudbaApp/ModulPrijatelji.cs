using DAL;
using DAL.Models;
using PosudbaApp;

namespace PosudbaApp
{
    public class ModulPrijatelji
    {
        public static void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Prijatelji iz baze:");
            Console.WriteLine("ID\tIme i prezime\tTelefon");
            Console.WriteLine("-------------------------------");

            var prijatelji = DbMethods.DohvatiPrijatelje();
            if (prijatelji != null)
            {
                foreach (var prijatelj in DbMethods.DohvatiPrijatelje())
                {
                    Console.WriteLine($"{prijatelj.PrijateljId}\t{prijatelj.Ime} {prijatelj.Prezime}\t{prijatelj.Telefon}");
                }
            }
            else
            {
                Console.WriteLine("Nema zapisa o prijateljima.");
            }

            Console.WriteLine();
            Console.WriteLine("Pritisni tipku za nastavak...");
            Console.ReadKey();
            Izbornici.Prijatelji();
        }

        public static void Create()
        {
            Console.WriteLine();
            Prijatelji p = new Prijatelji();
            Console.Write("Unesi ime: ");
            p.Ime = Console.ReadLine();
            Console.Write("Unesi prezime: ");
            p.Prezime = Console.ReadLine();
            Console.Write("Unesi telefon: ");
            p.Telefon = Console.ReadLine();
            DbMethods.DodajPrijatelja(p);
            Console.WriteLine();
            Console.WriteLine("Prijatelj dodan u bazu!");
            Console.WriteLine("Pritisni tipku za nastavak...");
            Console.ReadKey();
            Izbornici.Prijatelji();
        }

        public static void Update()
        {
            Console.WriteLine();

            Prijatelji prijatelj = new Prijatelji();
            Console.WriteLine();
            Console.WriteLine("Prijatelji iz baze:");
            Console.WriteLine("ID\tIme i prezime\tTelefon");
            Console.WriteLine("-------------------------------");
            foreach (var p in DbMethods.DohvatiPrijatelje())
            {
                Console.WriteLine($"{p.PrijateljId}\t{p.Ime} {p.Prezime}\t{p.Telefon}");
            }
            Console.Write("Unesi ID prijatelja kojeg želiš izmijeniti: ");
            prijatelj.PrijateljId = int.Parse(Console.ReadLine());
            Console.Write("Unesi novo ime: ");
            prijatelj.Ime = Console.ReadLine();
            Console.Write("Unesi novo prezime: ");
            prijatelj.Prezime = Console.ReadLine();
            Console.Write("Unesi novi telefon: ");
            prijatelj.Telefon = Console.ReadLine();
            DbMethods.IzmjeniPrijatelja(prijatelj);
            Console.WriteLine();
            Console.WriteLine("Prijatelj izmijenjen u bazi!");
            Console.WriteLine("Pritisni tipku za nastavak...");
            Console.ReadKey();
            Izbornici.Prijatelji();
        }

        public static void Delete()
        {
            Console.WriteLine();
            Prijatelji prijatelj = new Prijatelji();
            Console.WriteLine();
            Console.WriteLine("Prijatelji iz baze:");
            Console.WriteLine("ID\tIme i prezime\tTelefon");
            Console.WriteLine("-------------------------------");
            foreach (Prijatelji p in DbMethods.DohvatiPrijatelje())
            {
                Console.WriteLine($"{prijatelj.PrijateljId}\t{prijatelj.Ime} {prijatelj.Prezime}\t{prijatelj.Telefon}");
            }
            Console.Write("Unesi ID prijatelja kojeg želiš obrisati: ");
            try
            {
                int id = int.Parse(Console.ReadLine());
                DbMethods.ObrisiPrijatelja(id);
                Console.WriteLine("Prijatelj je obrisan iz baze.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: " + e.Message);
            }
            Console.WriteLine("Pritisni tipku za nastavak...");
            Console.ReadKey();
            Izbornici.Prijatelji();
        }
    }
}
