
using StudentOsobaApp;

Console.Write("Unesi ime: ");
string ime = Console.ReadLine();
Console.Write("Unesi prezime: ");
string prezime = Console.ReadLine();

Ucenik u = new Ucenik(ime, prezime);

try
{
	Console.Write("Unesi ocjenu iz matematike: ");
	u.Matematika = int.Parse(Console.ReadLine());

	Console.Write("Unesi ocjenu iz fizike: ");
	u.Fizika = int.Parse(Console.ReadLine());

	Console.Write("Unesi ocjenu iz kemije: ");
	u.Kemija = int.Parse(Console.ReadLine());

    Console.WriteLine($"Puno ime: {u.PunoIme()}");
    Console.WriteLine($"Prosjek: {u.ToString()}");

	if (u.Matematika < 0 || u.Matematika > 5 || u.Fizika < 0 || u.Fizika > 5 || u.Kemija < 0 || u.Kemija > 5)
	{
		throw new Exception("Ocjena je nepostojeća!");
	}

}
catch (Exception e)
{
    Console.WriteLine("Dogodila se greška: " + e.Message);
}