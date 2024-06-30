using DAL;

int counter = 1; // redni broj proizvoda u listi
bool allGreat = false; // provjera da li je korisnik unio sve podatke
string upit = ""; // upit za unos podataka
Proizvodi kosarica = new Proizvodi(); // lista proizvoda u kosarici

// Popunjavanje liste proizvoda
Proizvodi inicijalniProizvodi = PopuniShop();
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("             Dobrodošli u našu trgovinu!");
Console.WriteLine("------------------------------------------------------");

foreach (Proizvod item in inicijalniProizvodi)
{
    Console.WriteLine(counter++ + ". " + item.Naziv + " - " + Math.Round(item.UkupnaCijena, 2) + " EUR, Dostupan: " + (item.Dostupan ? "DA" : "NE"));
}

while (upit.ToLower() != "ne")
{
    while (!allGreat)
    {
        try
        {
            int redniBroj = 0;
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Unesite redni broj proizvoda koji želite dodati u košaricu: ");
            Console.Write("Redni broj: ");
            redniBroj = int.Parse(Console.ReadLine());

            if (((Proizvod)inicijalniProizvodi[redniBroj - 1]).Dostupan)
            {
                kosarica.Add((Proizvod)inicijalniProizvodi[redniBroj - 1]);
                allGreat = true;
            }
            else
            {
                Console.WriteLine("Proizvod je nedostupan, odaberite nesto drugo!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Greska! Detalji: " + ex.Message);
        }
    }
    allGreat = false;
    Console.Write("Zelis li kupiti jos proizvoda? (da / ne) ");
    upit = Console.ReadLine();
}

Narudzba n = new Narudzba();
n.NarudzbaKreirana += new Narudzba.NarudzbaKreiranaDelegate(KreiranjeNarudzbe);
n.DatumKreiranja = DateTime.Now;
n.Proizvodi = new Proizvodi();
n.DostavaIzvrsena = false;
foreach (Proizvod item in kosarica)
{
    n.Proizvodi.Add(item);
    n.UkupnaCijena += item.UkupnaCijena;
}

string sTimeStamp = DateTime.Now.ToString("yyyyddMMHHmmss");
//upis u datoteku
KreirajDatoteku(n, $"narudzba_{sTimeStamp}.txt");

//ispis iz datoteke
Console.WriteLine(ProcitajDatoteku($"narudzba_{sTimeStamp}.txt"));

partial class Program
{
    public static Proizvodi PopuniShop()
    {
        Proizvodi p = new Proizvodi()
        {
            new Proizvod { Naziv = "Mlijeko",Opis="moo white...", Dostupan = true, JedCijena = 1.5m },
            new Proizvod { Naziv = "Kruh", Opis="nije onaj tekuci kruh...", Dostupan = true, JedCijena = 1.0m },
            new Proizvod { Naziv = "Jaja", Opis="nema mucaka! majkemi!", Dostupan = true, JedCijena = 2.5m },
            new Proizvod { Naziv = "Sir", Opis="solid moo white...", Dostupan = true, JedCijena = 1.75m },
            new Proizvod { Naziv = "Salama", Opis="podrigusa!", Dostupan = true, JedCijena = 4.89m }
        };

        return p;
    }

    public static void KreirajDatoteku(Narudzba n, string nazivDatoteke)
    {
        FileStream fs = new FileStream(nazivDatoteke, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("------------------------------------------------------");
            sw.WriteLine("Datum Narudzbe: " + n.DatumKreiranja);
            sw.WriteLine("Dostavljeno: " + (n.DostavaIzvrsena ? "DA" : "NE"));
            sw.WriteLine("Proizvodi:");
            foreach (Proizvod p in n.Proizvodi)
            {
                sw.WriteLine(p.Naziv + " - " + Math.Round(p.UkupnaCijena, 2) + " EUR");
            }
            sw.WriteLine("------------------------------------------------------");
            sw.WriteLine("Ukupna cijena: " + Math.Round(n.UkupnaCijena, 2) + " EUR");
            sw.WriteLine("------------------------------------------------------");
            sw.Close();
    }
    public static string ProcitajDatoteku(string nazivDatoteke)
    {
        FileStream fs = new FileStream(nazivDatoteke, FileMode.Open);
        StreamReader sr = new StreamReader(fs);

        string str = sr.ReadToEnd();
        sr.Close();
        return str;
    }

    public static void KreiranjeNarudzbe(object sender, EventArgs e)
    {
        Narudzba n = sender as Narudzba;
        Console.WriteLine("Narudzba je kreirana u {0}, {1}", n.DatumKreiranja.ToString("dddd"), n.DatumKreiranja);
    }
}
