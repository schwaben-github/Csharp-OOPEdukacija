using System.Globalization;
using Zadatak3;

try
{
    Ucenik ucenik = new Ucenik();

    Console.Write("Unesi ime učenika: ");
    ucenik.Ime = Console.ReadLine();

    Console.Write("Unesi prezime učenika: ");
    ucenik.Prezime = Console.ReadLine();

    // 3. Pretplata na događaj
    ucenik.NaPromjenuDatumaRodjenja += Ucenik_NaPromjenuDatumaRodjenja;

    Console.Write("Unesi datum rođenja učenika (d.M.yyyy.): ");
    ucenik.DatumRodjenja = DateTime.Parse(Console.ReadLine());

    Console.Write("Unesi prosjek učenika: ");
    ucenik.Prosjek = double.Parse(Console.ReadLine());

    Console.WriteLine("Učenik: " + ucenik.Ime + " " + ucenik.Prezime + ", " + ucenik.Starost() + " godina, " + ucenik.ProsjekRijecima());
    Console.WriteLine("Datum rođenja: " + ucenik.DatumRodjenja.ToString("dd.MM.yyyy."));

    using (StreamWriter sw = new StreamWriter("ucenik.txt", false))
    {
        sw.WriteLine("Učenik: " + ucenik.Ime + " " + ucenik.Prezime + ", " + ucenik.Starost() + " godina, " + ucenik.ProsjekRijecima());
        sw.WriteLine("Datum rođenja: " + ucenik.DatumRodjenja.ToString("dd.MM.yyyy."));
    }
}
catch (Exception e)
{
    Console.WriteLine("Došlo je do pogreške: " + e.Message);
}

// Metoda Ucenik_NaPromjenuDatumaRodjenja koja ispisuje starost učenika kada se promijeni datum rođenja.
partial class Program
{
    public static void Ucenik_NaPromjenuDatumaRodjenja(object sender, EventArgs e)
    {
        Ucenik ucenik = (Ucenik)sender;
        Console.WriteLine("Starost učenika: " + ucenik.Starost());
    }

}