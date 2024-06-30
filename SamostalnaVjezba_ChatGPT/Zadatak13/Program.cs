// Napišite program koji će zamijeniti sva pojavljivanja određenog znaka u zadanom stringu drugim znakom.
// Program treba tražiti unos stringa i znakova koji se zamjenjuju, a zatim ispisati rezultat zamjene.
// Program treba imati metodu koja će uzeti tri ulazna argumenta: originalni string, znak koji treba zamijeniti i znak kojim treba zamijeniti.
// Metoda treba vratiti string koji je rezultat zamjene.


Console.Write("Unesite string: ");
string originalniString = Console.ReadLine();

Console.Write("Unesite znak koji se zamjenjuje: ");
char znakZamjenjuje = Console.ReadLine()[0];

Console.Write("Unesite znak kojim se zamjenjuje: ");
char znakZamjena = Console.ReadLine()[0];

string rezultat = ZamijeniZnak(originalniString, znakZamjenjuje, znakZamjena);

Console.WriteLine($"Rezultat zamjene: {rezultat}");

static string ZamijeniZnak(string originalniString, char znakZamjenjuje, char znakZamjena)
{
    return originalniString.Replace(znakZamjenjuje, znakZamjena);
}