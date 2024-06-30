using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcijalniIspit;

class Program
{
    static void Main()
    {
        List<Racunalo> racunala = new List<Racunalo>();

        while (true)
        {
            Console.Write("Odaberite vrstu računala (1 - Desktop, 2 - Laptop, 0 - Izlaz): ");
            string vrstaRacunalaInput = Console.ReadLine();

            if (vrstaRacunalaInput == "0")
            {
                break;
            }

            try
            {
                int vrstaRacunala = int.Parse(vrstaRacunalaInput);

                Console.Write("Unesite naziv: ");
                string naziv = Console.ReadLine();

                Console.Write("Unesite cijenu: ");
                double cijena = double.Parse(Console.ReadLine());

                Console.Write("Unesite trajanje jamstva u mjesecima: ");
                int jamstvoMjeseci = int.Parse(Console.ReadLine());

                Console.Write("Unesite datum kupnje (yyyy-mm-dd): ");
                DateTime datumKupnje = DateTime.Parse(Console.ReadLine());

                if (vrstaRacunala == 1)
                {
                    Racunalo racunalo = new Racunalo(naziv, cijena, jamstvoMjeseci, datumKupnje);
                    racunalo.NaPromjenuDatumaKupnje += Racunalo_NaPromjenuDatumaKupnje;
                    racunala.Add(racunalo);
                }
                else if (vrstaRacunala == 2)
                {
                    Console.Write("Unesite trajanje baterije u satima: ");
                    double trajanjeBaterije = double.Parse(Console.ReadLine());

                    Laptop laptop = new Laptop(naziv, cijena, jamstvoMjeseci, datumKupnje, trajanjeBaterije);
                    laptop.NaPromjenuDatumaKupnje += Racunalo_NaPromjenuDatumaKupnje;
                    racunala.Add(laptop);
                }
                else
                {
                    Console.WriteLine("Nepoznata vrsta računala. Pokušajte ponovno.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Došlo je do greške: {ex.Message}. Pokušajte ponovno.");
            }
        }

        foreach (var racunalo in racunala)
        {
            Console.WriteLine(racunalo.ToString());
            Console.WriteLine(new string('-', 50));
        }

        using (StreamWriter writer = new StreamWriter("racunala.txt"))
        {
            foreach (var racunalo in racunala)
            {
                writer.WriteLine(racunalo.ToString());
                writer.WriteLine(new string('-', 50));
            }
        }
    }

    private static void Racunalo_NaPromjenuDatumaKupnje(object sender, EventArgs e)
    {
        Racunalo racunalo = sender as Racunalo;
        string jeLiUJamstvu = (DateTime.Now <= racunalo.DatumKupnje.AddMonths(racunalo.JamstvoMjeseci)) ? "Da" : "Ne";
        Console.WriteLine($"Datum kupnje je promijenjen. Računalo je u jamstvu: {jeLiUJamstvu}");
    }
}