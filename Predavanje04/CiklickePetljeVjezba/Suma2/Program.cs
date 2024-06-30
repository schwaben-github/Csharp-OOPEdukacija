int broj;
int suma = 0;
try
{
	do
	{
		Console.Write("Unesite prirodni broj: ");
		broj = int.Parse(Console.ReadLine());

		suma += broj;

	} while (broj != 0);
}
catch (Exception ex)
{
    Console.WriteLine("Pogrešan unos!" + ex.Message);
}

Console.WriteLine("Suma unesenih brojeva je: {0}", suma);