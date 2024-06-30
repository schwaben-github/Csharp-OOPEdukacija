using DAL;
using DAL.Models;
using PosudbaApp;

namespace PosudbaApp
{
    internal class ModulPosudbe
    {
        public static void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Posudbe iz baze:");
            Console.WriteLine("ID\tNaslov medija\tDatum posudbe");
            Console.WriteLine("--------------------------------");

            var posudbe = DBMethods.DohvatiPosudbe();
            if (posudbe != null) // Check if the list is not null
            {
                foreach (var posudba in posudbe)
                {
                    Console.WriteLine($"{posudba.PosudbaId}\t{posudba.PrijateljId}\t{posudba.DatumPosudbe}\t{posudba.DatumVracanja}\t{posudba.MedijId}");
                }
            }
            else
            {
                Console.WriteLine("Nema zapisa o posudbama.");
            }

            Console.WriteLine();
            Console.WriteLine("Pritisni tipku za nastavak...");
            Console.ReadKey();
            Izbornici.Posudbe();
        }

        public static void Create()
        {
            Console.WriteLine();

            Posudbe p = new Posudbe();
            Console.WriteLine();
            Console.WriteLine("Prijatelji iz baze:");
            Console.WriteLine("ID\tIme i prezime\tTelefon");
            Console.WriteLine("-------------------------------");

            var posudbe = DBMethods.DohvatiPosudbe();
            if (posudbe != null) // Check if the list is not null
            {
                foreach (var posudba in posudbe)
                {
                    Console.WriteLine($"{posudba.PosudbaId}\t{posudba.PrijateljId}\t{posudba.DatumPosudbe}\t{posudba.DatumVracanja}\t{posudba.MedijId}");
                }
            }
            else
            {
                Console.WriteLine("Nema zapisa o posudbama.");
            }

            Console.Write("Unesi ID prijatelja: ");
            p.PrijateljId = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Mediji iz baze:");
            Console.WriteLine("ID\tNaslov medija\tTip medija");
            Console.WriteLine("--------------------------------");
            foreach (var medij in DBMethods.DohvatiMedije())
            {
                Console.WriteLine($"{medij.MedijId}\t{medij.Naslov}\t{medij.Tip}");
            }
            Console.Write("Unesi ID medija: ");
            p.MedijId = int.Parse(Console.ReadLine());

            Console.Write("Unesi datum posudbe (dd.MM.yyyy): ");
            p.DatumPosudbe = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
            Console.Write("Unesi datum povratka (dd.MM.yyyy): ");
            p.DatumVracanja = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

            DBMethods.DodajPosudbu(p);
            Console.WriteLine();
            Console.WriteLine("Posudba dodana u bazu!");
            Console.WriteLine("Pritisni tipku za nastavak...");
            Console.ReadKey();
            Izbornici.Posudbe();
        }

        public static void Update()
        {
            Console.WriteLine();

            Posudbe posudba = new Posudbe();
            Console.WriteLine();
            Console.WriteLine("Posudbe iz baze:");
            Console.WriteLine("ID\tPrijatelj\tMedij\tDatum posudbe\tDatum povratka");
            Console.WriteLine("--------------------------------------------------------");

            var posudbe = DBMethods.DohvatiPosudbe();
            if (posudbe != null) // Check if the list is not null 
            {
                foreach (var p in DBMethods.DohvatiPosudbe())
                {
                    Console.WriteLine($"{p.PosudbaId}\t{p.Prijatelj.Ime} {p.Prijatelj.Prezime}\t{p.Medij.Naslov}\t{p.DatumPosudbe}\t{p.DatumVracanja}");
                }
            }
            else
            {
                Console.WriteLine("Nema zapisa o posudbama.");
            }

            Console.Write("Unesi ID posudbe koju želiš izmijeniti: ");
            if (!int.TryParse(Console.ReadLine(), out int posudbaId))
            {
                Console.WriteLine("Neispravan unos ID-a posudbe.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Prijatelji iz baze:");
            Console.WriteLine("ID\tIme i prezime\tTelefon");
            Console.WriteLine("-------------------------------");
            foreach (var prijatelj in DBMethods.DohvatiPrijatelje())
            {
                Console.WriteLine($"{prijatelj.PrijateljId}\t{prijatelj.Ime} {prijatelj.Prezime}\t{prijatelj.Telefon}");
            }
            Console.Write("Unesi ID prijatelja: ");
            if (!int.TryParse(Console.ReadLine(), out int prijateljId))
            {
                Console.WriteLine("Neispravan unos ID-a prijatelja.");
                return;
            }
            posudba.PrijateljId = prijateljId;

            Console.WriteLine();
            Console.WriteLine("Mediji iz baze:");
            Console.WriteLine("ID\tNaslov medija\tTip medija");
            Console.WriteLine("--------------------------------");
            foreach (var medij in DBMethods.DohvatiMedije())
            {
                Console.WriteLine($"{medij.MedijId}\t{medij.Naslov}\t{medij.Tip}");
            }
            Console.Write("Unesi ID medija: ");
            posudba.MedijId = int.Parse(Console.ReadLine());

            Console.Write("Unesi datum posudbe (dd.MM.yyyy): ");
            posudba.DatumPosudbe = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
            Console.Write("Unesi datum povratka (dd.MM.yyyy): ");
            try
            {
                posudba.DatumVracanja = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
            }
            catch (Exception)
            {
                Console.WriteLine("Datum vraćanja nije upisan...");
            }
            Console.WriteLine();

            try
            {
                DBMethods.IzmjeniPosudbu(posudba);
                Console.WriteLine("Posudba izmijenjena!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Došlo je do greške pri izmjeni posudbe: {ex.Message}");
            }
            Console.WriteLine("Pritisni tipku za nastavak...");
            Console.ReadKey();
            Izbornici.Posudbe();
            Console.WriteLine();
        }

        public static void Delete()
        {
            Console.WriteLine();
            Console.WriteLine("Posudbe iz baze:");
            Console.WriteLine("ID\tPrijatelj\tMedij\tDatum posudbe\tDatum povratka");
            Console.WriteLine("--------------------------------------------------------");

            var posudbe = DBMethods.DohvatiPosudbe();
            if (posudbe != null)
            {
                foreach (var posudba in DBMethods.DohvatiPosudbe())
                {
                    Console.WriteLine($"{posudba.PosudbaId}\t{posudba.Prijatelj.Ime} {posudba.Prijatelj.Prezime}\t{posudba.Medij.Naslov}\t{posudba.DatumPosudbe}\t{posudba.DatumVracanja}");
                }
            }
            else
            {
                Console.WriteLine("Nema zapisa o posudbama.");
            }

            Console.Write("Unesi ID posudbe koju želiš obrisati: ");
            int id = int.Parse(Console.ReadLine());

            DBMethods.ObrisiPosudbu(id);
            Console.WriteLine();
            Console.WriteLine("Posudba obrisana iz baze!");
            Console.WriteLine("Pritisni tipku za nastavak...");
            Console.ReadKey();
            Izbornici.Posudbe();
        }
    }
}
