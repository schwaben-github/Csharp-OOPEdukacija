while (true)
{
    double rezultat = 0;

    Console.Write("Unesi prvi broj: ");
    double broj1 = int.Parse(Console.ReadLine());

    Console.Write("Unesi drugi broj: ");
    double broj2 = int.Parse(Console.ReadLine());

    Console.Write("Unesi računsku operaciju (+, -, *, /): ");
    string operation = (Console.ReadLine());

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
                continue; // Ponovni unos
            }
            break;
        default:
            Console.WriteLine("Nepoznata računska operacija.");
            continue; // Ponovni unos
    }

    // Ispis rezultata
    Console.WriteLine($"Rezultat: {broj1} {operation} {broj2} = {rezultat}");

    // Provjera za nastavak ili prekid programa
    Console.Write("Želite li ponovno računati? (y/n): ");
    string odgovor = Console.ReadLine().ToLower();
    if (odgovor != "y")
    {
        break; // Izlazak iz petlje i završetak programa
    }
}