// Na internetu sam pročitao o tzv. rekurziji.
// Dio programa sa case blokovima bi se stavio u funkciju,
// koja bi se rekurzivno pozivala nakon svake izvršene operacije,
// osim ako korisnik ne unese opciju za izlaz iz programa!
// 
// Na taj način omogućio bi se ponovni odabir opcije nakon
// svake izvršene operacije, bez korištenja petlji!


using System;

class Program
{
    static void Main(string[] args)
    {
        PokreniProgram();
    }

    static void PokreniProgram()
    {
        Console.WriteLine("╔════════ MENUE ════════╗");
        Console.WriteLine("║ 1. Rastavi rečenicu   ║");
        Console.WriteLine("║ 2. Prebroji riječi    ║");
        Console.WriteLine("║ 3. Pronađi riječ      ║");
        Console.WriteLine("║ 4. Izbaci riječ       ║");
        Console.WriteLine("║ 5. Presloži rečenicu  ║");
        Console.WriteLine("║ x. Izlaz              ║");
        Console.WriteLine("╚═══════════════════════╝");
        Console.WriteLine();
        Console.Write("Odaberi opciju: ");
        string opcija = Console.ReadLine();

        if (opcija == "x")
            return;

        Console.Write("Unesi rečenicu: ");
        string recenica = Console.ReadLine();

        switch (opcija)
        {
            case "1":
                List<string> rijeci = RastaviRecenicu(recenica);
                foreach (string r in rijeci)
                {
                    if (!string.IsNullOrEmpty(r))
                    {
                        Console.WriteLine(r);
                    }
                }
                Console.WriteLine();
                break;
            case "2":
                Console.WriteLine("Broj riječi u rečenici je: " + PrebrojiRijeci(recenica));
                Console.WriteLine();
                break;
            case "3":
                Console.Write("Unesi riječ: ");
                string rijec = Console.ReadLine();
                Console.WriteLine("Riječ se pojavljuje " + PronadjiRijec(recenica, rijec) + " puta.");
                Console.WriteLine();
                break;
            case "4":
                Console.Write("Unesi riječ koju želiš izbaciti: ");
                string rijecZaIzbaciti = Console.ReadLine();
                Console.WriteLine("Rečenica nakon izbacivanja riječi:");
                Console.WriteLine(IzbaciRijec(recenica, rijecZaIzbaciti));
                Console.WriteLine();
                break;
            case "5":
                Console.WriteLine("Presložena rečenica:");
                Console.WriteLine(PresloziRecenicu(recenica));
                Console.WriteLine();
                break;
            default:
                Console.WriteLine("Nepostojeća opcija.");
                Console.WriteLine();
                break;


        }

        PokreniProgram(); // Rekurzivni poziv metode za ponovno pokretanje programa
    }



    static string Interpunkcija(string rijec)
    {
        return rijec.Trim().ToLower().Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "");
    }

    static List<string> RastaviRecenicu(string recenica)
    {
        List<string> rijeci = recenica.Split(" ").ToList();

        for (int i = 0; i < rijeci.Count; i++)
        {
            if (!string.IsNullOrEmpty(Interpunkcija(rijeci[i])))
            {
                rijeci[i] = Interpunkcija(rijeci[i]);
            }
        }

        return rijeci;
    }

    static int PrebrojiRijeci(string recenica)
    {
        return RastaviRecenicu(recenica).Count();
    }

    static int PronadjiRijec(string recenica, string rijec)
    {
        List<string> rijeci = RastaviRecenicu(recenica);
        int brojac = 0;
        foreach (string r in rijeci)
        {
            if (r == rijec.ToLower())
            {
                brojac++;
            }
        }
        return brojac;
    }

    static string IzbaciRijec(string recenica, string rijecZaIzbaciti)
    {
        List<string> rijeci = RastaviRecenicu(recenica);
        rijeci.RemoveAll(r => r.ToLower() == rijecZaIzbaciti.ToLower());
        return string.Join(" ", rijeci);
    }

    static string PresloziRecenicu(string recenica)
    {
        Random random = new Random();
        List<string> rijeci = RastaviRecenicu(recenica);
        List<string> preslozeno = new List<string>();

        while (rijeci.Count > 0)
        {
            int index = random.Next(rijeci.Count);
            preslozeno.Add(rijeci[index]);
            rijeci.RemoveAt(index);
        }

        return string.Join(" ", preslozeno);
    }
}