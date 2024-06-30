// Program na početku generira slučajan broj između 1 i 100.
// Korisnik pokušava pogoditi taj broj. Nakon svakog pokušaja,
// program treba reći korisniku je li traženi broj veći ili manji
// od unesenog. Program završava kada korisnik pogodi broj.

Random random = new Random();
int zamisli = random.Next(1, 101);

int pogodi = 0;
do
{
    Console.Write("Pogodi broj između 1 i 100: ");
    while (!int.TryParse(Console.ReadLine(), out pogodi))
    {
        Console.WriteLine("Unesi valjani cijeli broj!");
        Console.Write("Pokušaj još jednom: ");
    }

    if (pogodi < zamisli)
    {
        Console.WriteLine("Zamislio sam veći broj...");
    }
    else if (pogodi > zamisli)
    {
        Console.WriteLine("Zamislio sam manji broj...");
    }
    else
    {
        Console.WriteLine("Čestitam! Pogodio si!");
    }
} while (pogodi != zamisli);
