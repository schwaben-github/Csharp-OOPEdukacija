try
{
	while (true)
	{
		Console.Write("Unesi godinu: ");
		int godina = int.Parse(Console.ReadLine());

		if ((godina % 4 == 0 && godina % 100 != 0) || (godina % 400 == 0))
		{
			Console.WriteLine("Godina je (bila) prijestupna.");
		}
		else
		{
			Console.WriteLine("Godina nije (bila) prijestupna.");
		}
		// Provjera za nastavak ili prekid programa
		Console.Write("Želite li provjeriti još jednu godinu? (y/n): ");
		string odgovor = Console.ReadLine().ToLower();
		if (odgovor != "y")
		{
			break; // Izlazak iz petlje i završetak programa
		}
	}
}
catch (Exception ex)
{
	    Console.WriteLine("Dogodial se greška! Detalji:" + ex.Message);
}