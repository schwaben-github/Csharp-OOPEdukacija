// Napišite program koji će prebrojati broj riječi u zadanom stringu. Riječ se definira kao skup znakova odvojenih bjelinama (razmacima).
// Program treba tražiti unos stringa i ispisati broj riječi u stringu.
// Program treba imati metodu koja će uzeti jedan ulazni argument: string. Metoda treba vratiti broj riječi u stringu.

Console.Write("Unesite string: ");
string originalniString = Console.ReadLine();

int rezultat = PrebrojiRijeci(originalniString);
Console.WriteLine($"Broj riječi u stringu je: {rezultat}");

static int PrebrojiRijeci(string originalniString)
{
    string[] rijeci = originalniString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return rijeci.Length;
}
