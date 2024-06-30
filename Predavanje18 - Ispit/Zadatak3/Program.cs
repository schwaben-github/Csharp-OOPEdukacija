using System;
using System.Globalization;
using System.IO;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Unesi ime učenika: ");
                string ime = Console.ReadLine();

                Console.Write("Unesi prezime učenika: ");
                string prezime = Console.ReadLine();

                Console.Write("Unesi datum rođenja učenika (dd.MM.yyyy.): ");
                DateTime datumRodjenja = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy.", null);

                Console.Write("Unesi prosjek učenika: ");
                double prosjek = Math.Round(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), 1);

                Ucenik ucenik = new Ucenik(ime, prezime, datumRodjenja, prosjek);
                ucenik.NaPromjenuDatumaRodjenja += Ucenik_NaPromjenuDatumaRodjenja;

                Console.WriteLine("Učenik: " + ucenik.Ime + " " + ucenik.Prezime + ", " + ucenik.Starost() + " godina, " + ucenik.ProsjekRijecima());
                Console.WriteLine("Datum rođenja: " + ucenik.DatumRodjenja.ToString("dd.MM.yyyy."));

                // Datoteka se sprema u bin\Debug\net8.0\ folderu projekta
                // Nova verzija datoteke se kreira svaki put kada se program pokrene
                // Ovo sam "pokupio" s interneta, nisam siguran da li je točno
                using (StreamWriter sw = new StreamWriter("ucenik.txt", false))
                {
                    sw.WriteLine("Učenik: " + ucenik.Ime + " " + ucenik.Prezime + ", " + ucenik.Starost() + " godina, " + ucenik.ProsjekRijecima());
                    sw.WriteLine("Datum rođenja: " + ucenik.DatumRodjenja.ToString("dd.MM.yyyy."));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Doslo je do pogreske: " + e.Message);
            }
        }

        public static void Ucenik_NaPromjenuDatumaRodjenja(object sender, EventArgs e)
        {
            Ucenik ucenik = (Ucenik)sender;
            Console.WriteLine("Datum rođenja promijenjen u: " + ucenik.DatumRodjenja.ToString("dd.MM.yyyy."));
        }
    }
}