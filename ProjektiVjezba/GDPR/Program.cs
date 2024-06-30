// U glavnom programu napravi listu objekata tipa Student i omogući unos novog studenta sve dok se za ime ne upiše „kraj“.
// Nakon unosa za svakog studenta u lisƟ ispiši inicijale, starost i je li OIB ispravan.
// Na kraju ispiši sve studente koji studiraju u Osijeku i stariji su od 24 godine.
// Program osiguraj od grešaka.

namespace GDPR
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studenti = new List<Student>();
            while (true)
            {
                var student = new Student();
                try
                {
                    Console.Write("Unesite ime studenta: ");
                    student.Ime = Console.ReadLine();
                    if (student.Ime == "kraj")
                        break;
                    Console.Write("Unesite prezime studenta: ");
                    student.Prezime = Console.ReadLine();
                    Console.Write("Unesite godinu rođenja studenta: ");
                    student.GodinaRodjenja = int.Parse(Console.ReadLine());
                    Console.Write("Unesite mjesto studiranja studenta: ");
                    student.MjestoStudiranja = Console.ReadLine();
                    Console.Write("Unesite OIB studenta: ");
                    student.OIB = Console.ReadLine();

                    studenti.Add(student);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Greška: " + e.Message);
                }
            }

            foreach (var student in studenti)
            {
                Console.WriteLine("Inicijali: " + student.Inicijali());
                Console.WriteLine("Starost: " + student.Starost());
                Console.WriteLine("OIB ispravan: " + student.ProvjeriOIB());
                Console.WriteLine();
            }

            Console.WriteLine("Studenti koji studiraju u Osijeku i stariji su od 24 godine:");
            foreach (var student in studenti)
            {
                if (student.MjestoStudiranja == "Osijek" && student.Starost() > 24)
                {
                    Console.WriteLine(student.Ime + " " + student.Prezime);
                }
            }
        }
    }
}