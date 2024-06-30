Console.WriteLine("╔════ MENUE ═════╗");
Console.WriteLine("║   1. KS u KW   ║");
Console.WriteLine("║   2. KW u KS   ║");
Console.WriteLine("╚════════════════╝");
Console.WriteLine();
Console.Write("Odaberi opciju (1 ili 2): ");
string odabir = Console.ReadLine();

switch (odabir)
{
	case "1":
        Console.Write("Unesi KS: ");
		Console.Write("To je KW: " + KSuKW(double.Parse(Console.ReadLine())));
        break;
;	
	case "2":
        Console.Write("Unesi KW: ");
		Console.Write("To je KS: " + KWuKS(double.Parse(Console.ReadLine())));
        break;
	
	default:
        Console.WriteLine("Nepoznata opcija!");
        break;
}

partial class Program
{
	static double KSuKW(double x)
	{
		return Math.Round(x * 0.736);
	}

	static double KWuKS(double x)
	{
		return Math.Round(x * 1.359);
	}
}
