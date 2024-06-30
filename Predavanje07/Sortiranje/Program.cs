int iUnos = -1;
List<int> list = new List<int>();

while (iUnos != 0)
{
    Console.Write("Unesi prirodni broj: ");
	try
	{
		iUnos = int.Parse(Console.ReadLine());
		if (iUnos < 0)
		{
			throw new Exception("Broj je manji od nule.");
		}
	}
	catch (Exception e)
	{
        Console.WriteLine("Greška! Detalji: " + e.Message);
        Console.WriteLine("Ponovi unos...");
		iUnos = -1; // Reset vrijednosti, ukoliko exception!
    }
	finally
	{
		if (iUnos > 0)
		{
			list.Add(iUnos);
		}
	}
}

list.Sort();
foreach (int item in list)
{
    Console.WriteLine(item);
}