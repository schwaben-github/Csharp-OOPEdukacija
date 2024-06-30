// Napravite program koji traži unos riječi od korisnika.
// Program treba nastaviti tražiti unos dok korisnik ne unese riječ koja je već prethodno unesena.
// Nakon toga, program treba ispisati tu riječ koja se ponovila i završiti izvršavanje.

List<string> uneseneRijeci = new List<string>();
 
while (true)
{
    Console.Write("Unosi riječi. Program će završiti kada uneseš već jednom unesenu riječ: ");
    string rijec = Console.ReadLine().Trim().ToLower();

    if (uneseneRijeci.Contains(rijec))
    {
        Console.WriteLine($"Riječ '{rijec}' je već unesena! Završavam program...");
        break;
    }
    else
    {
        uneseneRijeci.Add(rijec);
    }
}