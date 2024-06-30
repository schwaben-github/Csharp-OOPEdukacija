// Napiši program u kojem se ispisuju svi prirodni brojevi iz intervala [1, uneseni broj n] unatrag.

try
{
	Console.Write("Unesite broj n: ");
	int n = int.Parse(Console.ReadLine());

	for (int i = n; i >= 1; i--)
	{
		Console.WriteLine(i);
	}
}
catch (Exception ex)
{
    Console.WriteLine("Pogrešan unos! " + ex.Message);
}