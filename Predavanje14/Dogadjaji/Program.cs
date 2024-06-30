using Dogadjaji;

Osoba o = new Osoba();

o.Ime = "Pero";
o.NaPromjenaImena += new Osoba.NaPromjenaImenaDelegat(osoba_NaPromjenaImena);
o.Ime = "Ivo";
o.NaPromjenaImena -= new Osoba.NaPromjenaImenaDelegat(osoba_NaPromjenaImena);
o.Ime = "Marko";

partial class Program
{
    static void osoba_NaPromjenaImena(object sender, EventArgs e)
    {
        Console.WriteLine("Osoba je promijenila ime: {0}", ((Osoba)sender).Ime);
    }
}