using System;
using System.Collections;

namespace Vozila
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList svaVozila = new ArrayList();

            Automobili automobili = new Automobili();

            Vozilo vozilo1 = new Vozilo();

            string odgovor;
            do
            {
                Console.WriteLine("Odaberite unos vozila:");
                Console.WriteLine("1. Unos automobila");
                Console.WriteLine("2. Unos broda");
                Console.Write("Vaš odabir: ");
                int odabir = int.Parse(Console.ReadLine());

                switch (odabir)
                {
                    case 1:
                        Automobil noviAutomobil = UnesiAutomobil();
                        svaVozila.Add(noviAutomobil);
                        automobili.Add(noviAutomobil);
                        break;
                    case 2:
                        Brod noviBrod = UnesiBrod();
                        svaVozila.Add(noviBrod);
                        break;
                    default:
                        Console.WriteLine("Neispravan odabir.");
                        break;
                }

                Console.WriteLine("Želite li unijeti još vozila? (da/ne)");
                odgovor = Console.ReadLine();
            } while (odgovor.ToLower() == "da");


            Console.WriteLine("\nSva unesena vozila:");
            foreach (Vozilo vozilo in svaVozila)
            {
                Console.WriteLine($"Vozilo: {vozilo.Naziv}, KS: {vozilo.KS}, Boja: {vozilo.Boja}");
            }

            Console.WriteLine("\nSvi uneseni automobili:");
            foreach (Automobil automobil in automobili)
            {
                Console.WriteLine($"Automobil: {automobil} KS / {automobil.KSuKW()} KW");
            }
        }

        static Automobil UnesiAutomobil()
        {
            Automobil noviAutomobil = new Automobil();
            Console.Write("Unesite naziv automobila: ");
            noviAutomobil.Naziv = Console.ReadLine();
            Console.Write("Unesite boju automobila: ");
            noviAutomobil.Boja = Console.ReadLine();
            Console.Write("Unesite snagu automobila (KS): ");
            noviAutomobil.KS = int.Parse(Console.ReadLine());
            Console.Write("Unesite zapreminu motora (ccm): ");
            noviAutomobil.ccm = double.Parse(Console.ReadLine());
            return noviAutomobil;
        }

        static Brod UnesiBrod()
        {
            Brod noviBrod = new Brod();
            Console.Write("Unesite naziv broda: ");
            noviBrod.Naziv = Console.ReadLine();
            Console.Write("Unesite boju broda: ");
            noviBrod.Boja = Console.ReadLine();
            Console.Write("Unesite snagu broda (KS): ");
            noviBrod.KS = int.Parse(Console.ReadLine());
            Console.Write("Unesite istisninu broda: ");
            noviBrod.Istisnina = double.Parse(Console.ReadLine());
            return noviBrod;
        }
    }
}
