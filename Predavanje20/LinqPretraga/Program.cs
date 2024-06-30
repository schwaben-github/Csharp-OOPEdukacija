using LinqPretraga;

List<Brod> brodovi = new List<Brod>();
brodovi.Add( new Brod { Naziv = "Titanic", Model = "RMS Titanic", Lokacija = "Atlantik", Kapacitet = 2435, KS = 46000 });
brodovi.Add( new Brod { Naziv = "Jadranka", Model = "Gliser", Lokacija = "Dubrovnik", Kapacitet = 5, KS = 20.5 });
brodovi.Add( new Brod { Naziv = "Jadranka", Model = "Gliser", Lokacija = "Dubrovnik", Kapacitet = 5, KS = 20.5 });
brodovi.Add( new Brod { Naziv = "Dragica", Model = "Čamac", Lokacija = "Dubrovnik", Kapacitet = 4, KS = 22.5 });
brodovi.Add( new Brod { Naziv = "Perica", Model = "Gliser", Lokacija = "Split", Kapacitet = 3, KS = 120.5 });
brodovi.Add( new Brod { Naziv = "Admiral", Model = "Kruzer", Lokacija = "Zadar", Kapacitet = 100, KS = 200.5 });
brodovi.Add( new Brod { Naziv = "Admiral", Model = "Kruzer", Lokacija = "Zadar", Kapacitet = 100, KS = 200.5 });

// Pretraga brodova po nazivu
// Pretraga brodova po nazivu
Console.Write("Unesi pojam pretrage: ");
string pretraga = Console.ReadLine();

List<Brod> filtriraniBrodovi = (from b in brodovi
                               where b.Naziv.Contains(pretraga)
                               select b).ToList();

foreach (Brod item in filtriraniBrodovi)
{
    Console.WriteLine(item.Naziv + ", " + item.Model);
}
Console.WriteLine("-----------------------------------");

Console.Write("Unesi lokaciju broda:");
string lokacija = Console.ReadLine();

Console.Write("Unesi kapacitet broda:");
int kapacitet = int.Parse(Console.ReadLine());

Console.Write("Unesi KS broda:");
double KS = double.Parse(Console.ReadLine());

List<Brod> filtriraniBrodovi2 = PretraziBrodove(lokacija, kapacitet, KS, brodovi);

foreach (Brod item in filtriraniBrodovi2)
{
    Console.WriteLine(item.Naziv + ", " + item.Model);
}

partial class Program
{
    public static List<Brod> PretraziBrodove(string lokacija, int kapacitet, double ks, List<Brod> brodoviZaPretragu)
    {
        List<Brod> filtriraniBrodovi = (from b in brodoviZaPretragu
                                        where b.Lokacija.ToLower().Contains(lokacija.ToLower()) && b.Kapacitet >= kapacitet
                                        && b.KS >= ks
                                        select b).ToList();
        return filtriraniBrodovi;
    }
}