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

            var posudbe = DbMethods.DohvatiPosudbu();
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

            DbMethods.DodajPosudbu(p); // Call the method without assigning the result to a variable

            var posudbe = DbMethods.DohvatiPosudbu(); // Retrieve the list of posudbe

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
            int prijateljId;
            if (!int.TryParse(Console.ReadLine(), out prijateljId))
            {
                Console.WriteLine("Neispravan unos ID-a prijatelja.");
                return;
            }
            p.PrijateljId = prijateljId;

            Console.WriteLine();
            Console.WriteLine("Mediji iz baze:");
            Console.WriteLine("ID\tNaslov medija\tTip medija");
            Console.WriteLine("--------------------------------");
            foreach (var medij in DbMethods.DohvatiKolekcije())
            {
                Console.WriteLine($"{medij.MedijId}\t{medij.Naslov}\t{medij.Tip}");
            }
            Console.Write("Unesi ID medija: ");
            int medijId;
            if (!int.TryParse(Console.ReadLine(), out medijId))
            {
                Console.WriteLine("Neispravan unos ID-a medija.");
                return;
            }
            p.MedijId = medijId;

            Console.Write("Unesi datum posudbe (dd.MM.yyyy): ");
            DateTime datumPosudbe;
            if (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out datumPosudbe))
            {
                Console.WriteLine("Neispravan unos datuma posudbe.");
                return;
            }
            p.DatumPosudbe = datumPosudbe;

            Console.Write("Unesi datum povratka (dd.MM.yyyy): ");
            DateTime datumVracanja;
            if (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out datumVracanja))
            {
                Console.WriteLine("Neispravan unos datuma povratka.");
                return;
            }
            p.DatumVracanja = datumVracanja;

            DbMethods.DodajPosudbu(p);
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

            var posudbe = DbMethods.DohvatiPosudbu(); // Retrieve the list of posudbe
            if (posudbe != null) // Check if the list is not null 
            {
                foreach (var p in posudbe)
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
            foreach (var prijatelj in DbMethods.DohvatiPrijatelje())
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
            foreach (var medij in DbMethods.DohvatiKolekcije())
            {
                Console.WriteLine($"{medij.MedijId}\t{medij.Naslov}\t{medij.Tip}");
            }
            Console.Write("Unesi ID medija: ");
            if (!int.TryParse(Console.ReadLine(), out int medijId))
            {
                Console.WriteLine("Neispravan unos ID-a medija.");
                return;
            }
            posudba.MedijId = medijId;

            Console.Write("Unesi datum posudbe (dd.MM.yyyy): ");
            if (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime datumPosudbe))
            {
                Console.WriteLine("Neispravan unos datuma posudbe.");
                return;
            }
            posudba.DatumPosudbe = datumPosudbe;

            Console.Write("Unesi datum povratka (dd.MM.yyyy): ");
            if (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime datumVracanja))
            {
                Console.WriteLine("Neispravan unos datuma povratka.");
                return;
            }
            posudba.DatumVracanja = datumVracanja;

            try
            {
                DbMethods.IzmjeniPosudbu(posudba);
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

            var posudbe = DbMethods.DohvatiPosudbu(); // Retrieve the list of posudbe
            if (posudbe != null)
            {
                foreach (var posudba in posudbe)
                {
                    Console.WriteLine($"{posudba.PosudbaId}\t{posudba.Prijatelj.Ime} {posudba.Prijatelj.Prezime}\t{posudba.Medij.Naslov}\t{posudba.DatumPosudbe}\t{posudba.DatumVracanja}");
                }
            }
            else
            {
                Console.WriteLine("Nema zapisa o posudbama.");
            }

            Console.Write("Unesi ID posudbe koju želiš obrisati: ");
            int id;
            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Neispravan unos ID-a posudbe.");
                return;
            }

            DbMethods.ObrisiPosudbu(id);
            Console.WriteLine();
            Console.WriteLine("Posudba obrisana iz baze!");
            Console.WriteLine("Pritisni tipku za nastavak...");
            Console.ReadKey();
            Izbornici.Posudbe();
        }
    }
}
