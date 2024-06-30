using Proizvod;

Proizvodi p = new Proizvodi();

try
{
	p.Naziv = "Kruh";
	p.OsnovnaCijena = 4;
	p.Marza = 0.2;
	p.IzracunajCijenu();

	p.Naziv = "Mlijeko";
	p.OsnovnaCijena = 5;
	p.Marza = 0.1;

	p.NaIzracunCijene += (sender, e) => Console.WriteLine("Cijena izracunata");

	p.IzracunajCijenu();
}
catch (Exception e)
{
	Console.WriteLine("Greška:" + e.Message);
}