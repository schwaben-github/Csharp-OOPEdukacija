using System.Globalization;
using System.Runtime.CompilerServices;
using Zadatak3;

string unos = "da";
List<Pas> psi = new List<Pas>();
List<Macka> macke = new List<Macka>();
try
{

    while (unos.ToLower() == "da")
    {
        string odabir = "";
        while (odabir != "1" && odabir != "2")
        {
            Console.WriteLine("Odaberi unos: (1-pas, 2-mačka) ");
            odabir = Console.ReadLine();
        }
        switch (odabir)
        {
            case "1":
                Pas p = new Pas();
                Console.Write("Unesi ime vlasnika: ");
                p.Vlasnik = Console.ReadLine();
                Console.Write("Unesi godinu rođenja (bez točke): ");
                p.GodinaRodjenja = DateTime.ParseExact(Console.ReadLine(), "yyyy", CultureInfo.InvariantCulture);
                Console.Write("Unesi masu u kg: ");
                p.Masa = double.Parse(Console.ReadLine());
                Console.Write("Unesi spol: (0-muški, 1-ženski): ");
                p.Spol = (Spol)int.Parse(Console.ReadLine());
                p.Budjenje += new Pas.BudjenjeDelegat(p_Budjenje);
                Console.Write("Vrijeme buđenja (sati): ");
                p.VrijemeBudjenja = int.Parse(Console.ReadLine());
                p.NaSpavanje += NaSpavanje;
                Console.Write("Vrijeme spavanja (sati): ");
                p.VrijemeSpavanja = int.Parse(Console.ReadLine());
                Console.Write("Unesi ime psa: ");
                p.Ime = Console.ReadLine();
                Console.Write("Unesi pasminu: ");
                p.Pasmina = Console.ReadLine();
                psi.Add(p);
                break;
            case "2":
                Macka m = new Macka();
                Console.Write("Unesi ime vlasnika: ");
                m.Vlasnik = Console.ReadLine();
                Console.Write("Unesi godinu rođenja (bez točke): ");
                m.GodinaRodjenja = DateTime.ParseExact(Console.ReadLine(), "yyyy", CultureInfo.InvariantCulture);
                Console.Write("Unesi masu u kg: ");
                m.Masa = double.Parse(Console.ReadLine());
                Console.Write("Unesi spol: (0-muški, 1-ženski): ");
                m.Spol = (Spol)int.Parse(Console.ReadLine());
                m.Budjenje += new Macka.BudjenjeDelegat(m_Budjenje);
                Console.Write("Vrijeme buđenja (sati): ");
                m.VrijemeBudjenja = int.Parse(Console.ReadLine());
                m.NaSpavanje += NaSpavanje;
                Console.Write("Vrijeme spavanja (sati): ");
                m.VrijemeSpavanja = int.Parse(Console.ReadLine());
                Console.Write("Unesi boju: ");
                m.Boja = Console.ReadLine();
                macke.Add(m);
                break;
            default:
                break;
        }
        Console.Write("Želiš li unijeti još životinja (da/ne)? ");
        unos = Console.ReadLine();
    }

}
catch (Exception e)
{
    Console.WriteLine("Greška: " + e.Message);
}
//1. način
List<Zivotinja> zivotinje = new List<Zivotinja>();
zivotinje.AddRange(psi);

//2. način
foreach (Macka m in macke)
{
    zivotinje.Add(m);
}

foreach (Zivotinja z in zivotinje)
{
    Console.WriteLine("{0}, {1} g. {2}, {3}", z.ToString(), z.Starost(), z.Spol, z.ToString() == "pas" ? ((Pas)z).GlasajSe() : ((Macka)z).GlasajSe());
}

partial class Program
{
    static void p_Budjenje(object sender, EventArgs e)
    {
        Console.WriteLine(((Pas)sender).GlasajSe());
    }
    static void m_Budjenje(object sender, EventArgs e)
    {
        Console.WriteLine(((Macka)sender).GlasajSe());
    }
    static void NaSpavanje(object sender, EventArgs e)
    {
        if (DateTime.Now.Hour > ((Zivotinja)sender).VrijemeSpavanja)
        {
            Console.WriteLine(((Zivotinja)sender).Spavaj());
        }
        else
        {
            Console.WriteLine(((Zivotinja)sender).GlasajSe());
        }
    }
}

// Originalno rješenje:

/*using System.Globalization;
using Zadatak3;

List<Zivotinja> zivotinje = new List<Zivotinja>();

// Unos životinja
while (true)
{
    Console.Write("Odaberi životinju (1 - Pas, 2 - Mačka): ");
    int unosBroj = int.Parse(Console.ReadLine());

    switch (unosBroj)
    {
        case 1:
            UnesiPsa(zivotinje);
            break;
        case 2:
            UnesiMačku(zivotinje);
            break;
        default:
            Console.WriteLine("Neispravan unos. Pokušaj ponovo.");
            break;
    }

    Console.WriteLine("Želiš li unijeti još jednu životinju? (da/ne)");
    if (Console.ReadLine().ToLower() != "da")
    {
        break;
    }
}


Console.WriteLine("\nUnesene životinje:");
foreach (Zivotinja zivotinja in zivotinje)
{
    Console.WriteLine(zivotinja);
}

static void UnesiPsa(List<Zivotinja> zivotinje)
{
    Pas pas = new Pas();

    Console.Write("Unesi ime vlasnika: ");
    pas.Vlasnik = Console.ReadLine();

    Console.Write("Unesi godinu rođenja (bez točke): ");
    pas.GodinaRodjenja = DateTime.ParseExact(Console.ReadLine(), "yyyy", CultureInfo.InvariantCulture);

    Console.Write("Unesi masu u kg: ");
    pas.Masa = double.Parse(Console.ReadLine());

    Console.Write("Unesi spol: (0-muški, 1-ženski): ");
    pas.Spol = (Spol)int.Parse(Console.ReadLine());

    zivotinje.Add(pas);
}

static void UnesiMačku(List<Zivotinja> zivotinje)
{
    Macka macka = new Macka();

    Console.Write("Unesi ime vlasnika: ");
    macka.Vlasnik = Console.ReadLine();

    Console.Write("Unesi godinu rođenja (bez točke): ");
    macka.GodinaRodjenja = DateTime.ParseExact(Console.ReadLine(), "yyyy", CultureInfo.InvariantCulture);

    Console.Write("Unesi masu u kg: ");
    macka.Masa = double.Parse(Console.ReadLine());

    Console.Write("Unesi spol: (0-muški, 1-ženski): ");
    macka.Spol = (Spol)int.Parse(Console.ReadLine());

    Console.Write("Unesi boju mačke: ");
    macka.Boja = Console.ReadLine();

    zivotinje.Add(macka);
}

partial class Program
{
    static void p.Budjenje(object sender, EventArgs e)
    {
        Console.WriteLine(((Pas)sender).GlasajSe());
    }

    static void m.Budjenje(object sender, EventArgs e)
    {
        Console.WriteLine(((Macka)sender).GlasajSe());
    }

    static void p.NaSpavanje(object sender, EventArgs e)
    {
        if (DateTime.Now.Hour > ((Zivotinja)sender.VrijemeSpavanja))
        {

        }
    }


}
*/