// Napravi program koji traži unos brojeva od korisnika dok zbroj svih
// unesenih brojeva ne premaši 100. Kada se to dogodi,
// program treba ispisati konačni zbroj.

int zbroj = 0;

Console.WriteLine("Unesi brojeve, čiji zbroj ne smije biti viši od 100.");

while (zbroj < 100)
{
    Console.Write("Unesi broj: ");
    int UNos = int.Parse(Console.ReadLine());
    zbroj += UNos;
}
Console.Write($"Zbroj je premašio 100! Konačni zbroj je: {zbroj}");