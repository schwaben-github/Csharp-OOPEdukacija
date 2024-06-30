using Rodjendan;

Console.Write("Unesi ime: ");
string ime = Console.ReadLine();
Console.Write("Unesi prezime: ");
string prezime = Console.ReadLine();
Osoba o = new Osoba(ime, prezime);
o.Rodjendan += new Osoba.RodjendanDelegat(o_Rodjendan);
Console.Write("Unesi datum rođenja: ");
o.DatumRodjenja = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Starost je: {0}", o.Starost);

Console.WriteLine($"Dan kada se {ime} rodio/la bio je: {o.DayOfBirthday()}.");

Console.WriteLine("-----------------------------------------------------------");
Console.Write("Unesi spol (0 = muski, 1 = zenski): ");
int mojSpol = int.Parse(Console.ReadLine());

if (mojSpol == 0)
{
    o.Spol = Spol.Muski;
}
else
{
    o.Spol = Spol.Zenski;
}

Console.WriteLine(o.Spol);
Console.WriteLine("Uneseni spol je: " + (int)o.Spol);
Console.WriteLine("Spol je: " + (int)o.Spol);
Console.WriteLine("-----------------------------------------------------------");

partial class Program
{
    static void o_Rodjendan(object sender, EventArgs e)
    {
        Console.WriteLine("Promjenio se datum rođenja na: {0}", ((Osoba)sender).DatumRodjenja.ToShortDateString());
    }
}