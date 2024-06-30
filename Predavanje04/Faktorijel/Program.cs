// Napiši program u kojem se za uneseni x ispisuje njegov faktorijel x!
// Primjer: 10! = 1 * 2 * 3 * 4 * 5 * 6 * 7 * 8 * 9 * 10 = 3628800
//
// unlong - unsigned long

try
{
	Console.Write("Unesi prirodni broj: ");
	ulong iUnos = ulong.Parse(Console.ReadLine());
	ulong ulUmnozak = 1;

	for (ulong i = 2; i < iUnos; i++)
	{
		ulUmnozak = ulUmnozak * i;
	}
	Console.WriteLine($"Faktorijel broja {iUnos} je {ulUmnozak}");
}
catch (Exception ex)
{

    Console.WriteLine("Dogodila se greška! Detalji: " + ex.Message);
}