decimal broj1 = 0;
decimal broj2 = 0;
string operacija = "";
decimal rezultat = 0;

try
{
	Console.Write("Unesi prvi broj: ");
	broj1 = decimal.Parse(Console.ReadLine());

	Console.Write("Unesi drugi broj: ");
	broj2 = decimal.Parse(Console.ReadLine());

	Console.Write("Unesi operaciju: ");
	operacija = (Console.ReadLine());

	switch (operacija)
	{
		case "+":
			rezultat = broj1 + broj2;
			break;
		case "-":
			rezultat = broj1 - broj2;
			break;
		case "*":
			rezultat = broj1 * broj2;
			break;
		case "/":
			rezultat = broj1 / broj2;
			break;
		default:
			Console.WriteLine("Nepoznata računska operacija");
			break;
	}
}
catch (Exception ex)
{
    Console.WriteLine("Dogodila se greška! Detalji: " + ex.Message);
}
finally
{
	if (operacija == "+" || operacija == "-" || operacija ==  "*" || operacija == "/")
	{
        Console.WriteLine($"Rezultat: {broj1} {operacija} {broj2} = {rezultat}");
    }
}