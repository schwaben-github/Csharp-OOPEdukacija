using System.Collections;
using System.Globalization;
using VozilaApp;

// flag koji provjerava želi li korisnik unijeti još vozila
string unos = "da";

//instanciramo liste
ArrayList vozila = new ArrayList();
Automobili auti = new Automobili();

try
{
    while (unos.ToLower() == "da")
    {
        //odabir tipa vozila
        Console.Write("Za unos automobila unesi 1, a za unos broda unesi 2: ");
        string odabir = Console.ReadLine();
        Console.WriteLine("--------------------------------------------------");
        if (odabir == "1")
        {
            Automobil auto = new Automobil();
            Console.Write("Unesi naziv automobila: ");
            auto.Naziv = Console.ReadLine();

            Console.Write("Unesi boju automobila: ");
            auto.Boja = Console.ReadLine();

            Console.Write("Unesi KS automobila: ");
            auto.KS = int.Parse(Console.ReadLine());

            Console.Write("Unesi ccm automobila: ");
            auto.ccm = double.Parse(Console.ReadLine());

            //objekt tipa automobil dodaje se u obje liste
            vozila.Add(auto);
            auti.Add(auto);
        }
        else if (odabir == "2")
        {
            Brod brod = new Brod();
            brod.NaPromjenuIstisnine += new Brod.NaPromjenuIstisnineDelegat(b_NaPromjenuIstisnine);
            Console.Write("Unesi naziv broda: ");
            brod.Naziv = Console.ReadLine();

            Console.Write("Unesi boju broda: ");
            brod.Boja = Console.ReadLine();

            Console.Write("Unesi KS broda: ");
            brod.KS = int.Parse(Console.ReadLine());

            Console.Write("Unesi istisninu: ");
            brod.Istisnina = double.Parse(Console.ReadLine());

            vozila.Add(brod);
        }
        else
        {
            Console.WriteLine("Nepoznati odabir!");
        }
        Console.WriteLine("Želiš li unijeti još vozila (da/ne)? ");
        unos = Console.ReadLine();
        Console.WriteLine("--------------------------------------------------");
    }

    //ispis svih vozila
    Console.WriteLine("-------------------- sva vozila -----------------------");
    foreach (object item in vozila)
    {
        Vozilo vozilo = (Vozilo)item;
        Console.WriteLine("Naziv: {0}, Boja: {1}, KS: {2}, KW: {3}", vozilo.Naziv, vozilo.Boja, vozilo.KS,
            vozilo.KSuKW());
    }

    //ispis svih automobila
    Console.WriteLine("---------------------- svi auti ------------------------");
    foreach (Automobil automobil in auti)
    {
        Console.WriteLine(automobil.ToString());
    }

}
catch (Exception e)
{
    Console.WriteLine("Dogodila se greška: " + e.Message);
}



partial class Program
{
    static void b_NaPromjenuIstisnine(object sender, EventArgs e)
    {
        Brod brod = (Brod)sender;
        Console.WriteLine("Promijenila se istisnina! Nova istisnina je: " + brod.Istisnina);
    }
}