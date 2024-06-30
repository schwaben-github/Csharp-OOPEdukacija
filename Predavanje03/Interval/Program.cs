Console.Write("Unesi jedan cijeli broj: ");
int broj = -1;

try
{
    broj = int.Parse(Console.ReadLine());
    if (broj >= 0 && broj <= 12)
	{
		Console.WriteLine($"Broj {broj} je u intervalu [0, 12].");
	}
	else
	{
		Console.WriteLine($"Broj {broj} nije u intervalu [0, 12].");
	}
}
catch (Exception)
{

    Console.WriteLine("Nisi unio broj!");
}