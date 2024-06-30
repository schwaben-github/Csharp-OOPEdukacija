// Unos podataka za prvi račun
using BankovniRacun;

Console.WriteLine("Unesite podatke za prvi račun:");
Console.Write("Broj računa: ");
int brojRacuna1 = int.Parse(Console.ReadLine());
Console.Write("Ime vlasnika: ");
string imeVlasnika1 = Console.ReadLine();
Console.Write("Početno stanje računa (EUR): ");
decimal pocetnoStanje1 = decimal.Parse(Console.ReadLine());

// Stvaranje prvog računa
Racun racun1 = new Racun(brojRacuna1, imeVlasnika1, pocetnoStanje1);

// Unos podataka za drugi račun
Console.WriteLine("\nUnesite podatke za drugi račun:");
Console.Write("Broj računa: ");
int brojRacuna2 = int.Parse(Console.ReadLine());
Console.Write("Ime vlasnika: ");
string imeVlasnika2 = Console.ReadLine();
Console.Write("Početno stanje računa (EUR): ");
decimal pocetnoStanje2 = decimal.Parse(Console.ReadLine());

// Stvaranje drugog računa
Racun racun2 = new Racun(brojRacuna2, imeVlasnika2, pocetnoStanje2);

// Testiranje funkcionalnosti računa
Console.WriteLine("\nTrenutna stanja računa:");
racun1.PrikaziStanje();
racun2.PrikaziStanje();

// Uplata novca na prvi račun
Console.WriteLine("\nUplata novca na prvi račun:");
Console.Write("Unesite iznos uplate (EUR): ");
decimal iznosUplate = decimal.Parse(Console.ReadLine());
racun1.Uplati(iznosUplate);

// Isplata novca s drugog računa
Console.WriteLine("\nIsplata novca s drugog računa:");
Console.Write("Unesite iznos isplate (EUR): ");
decimal iznosIsplate = decimal.Parse(Console.ReadLine());
racun2.Isplati(iznosIsplate);

// Ispis trenutnih stanja računa
Console.WriteLine("\nNakon transakcija:");
racun1.PrikaziStanje();
racun2.PrikaziStanje();


/*// Stvaranje nekoliko bankovnih računa radi testiranja
using BankovniRacun;

Racun racun1 = new Racun(123456, "John Doe", 1000);
Racun racun2 = new Racun(654321, "Jane Smith", 500);

// Testiranje funkcionalnosti računa
Console.WriteLine("Trenutna stanja računa:");
racun1.PrikaziStanje();
racun2.PrikaziStanje();

racun1.Uplati(600);
racun2.Isplati(300);

Console.WriteLine("\nNakon transakcija:");
racun1.PrikaziStanje();
racun2.PrikaziStanje();*/