// Unosi se ime i ispisuje "Dobar dan, {ime}", sve dok korisnik ne unese "kraj"

string ime = "";
do
{
    Console.Write("Unesi ime: ");
    ime = Console.ReadLine();

    if (ime.ToLower() == "kraj")
    {
        break;
    }
    Console.WriteLine($"Dobar dan, {ime}");
} while (ime.ToLower() != "kraj");

Console.WriteLine("*****************************************************");

// Shortcut za uređivanje koda: CTRL + K + D