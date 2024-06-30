// Napišite program koji implementira jednostavan kalkulator.
// Korisnik unosi dva broja i operaciju (+, -, *, /).
// Program izračunava rezultat i ispisuje ga.
//
// Dodatne napomene:
// Provjerite ispravnost unosa (npr. provjera da li su uneseni brojevi).
// Dodajte opciju za izlaz iz programa.

while (true)
{
    double rezultat = 0;

    // Provjera ispravnosti unesenih brojeva
    bool validInput = false;
    double broj1 = 0;
    double broj2 = 0;
    while (!validInput)
    {
        Console.Write("Unesi prvi broj: ");
        string input1 = Console.ReadLine();
        if (double.TryParse(input1, out broj1))
        {
            validInput = true;
        }
        else
        {
            Console.WriteLine("Neispravan unos. Unesite broj.");
        }
    }

    validInput = false;
    while (!validInput)
    {
        Console.Write("Unesi drugi broj: ");
        string input2 = Console.ReadLine();
        if (double.TryParse(input2, out broj2))
        {
            validInput = true;
        }
        else
        {
            Console.WriteLine("Neispravan unos. Unesite broj.");
        }
    }

    Console.Write("Unesi računsku operaciju (+, -, *, /, q za izlaz): ");
    string operation = (Console.ReadLine()).ToLower();

    switch (operation)
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
            if (broj2 != 0)
            {
                rezultat = broj1 / broj2;
            }
            else
            {
                Console.WriteLine("Dijeljenje s nulom nije dozvoljeno.");
            }
            break;
        case "q":
            Console.WriteLine("Izlaz iz programa.");
            return; // Prekini program
        default:
            Console.WriteLine("Nepoznata računska operacija.");
            break;
    }

    // Ispis rezultata sa formatiranjem
    Console.WriteLine($"Rezultat: {broj1} {operation} {broj2} = {rezultat:F2}"); // F2 za formatiranje na 2 decimalna mjesta

    // Provjera za nastavak ili prekid programa
    Console.Write("Želite li ponovno računati? (y/n): ");
    string odgovor = Console.ReadLine().ToLower();
    if (odgovor != "y")
    {
        break; // Izlazak iz petlje i završetak programa
    }
}
