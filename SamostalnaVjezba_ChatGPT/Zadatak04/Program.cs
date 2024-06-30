// Napiši program koji će provjeriti je li zadanu riječ moguće permutirati
// tako da bude palindrom. Palindromska permutacija je permutacija znakova
// riječi koja tvori palindrom, tj. riječ koja se čita isto i s lijeva na desno
// i s desna na lijevo. 

Console.Write("Unesi riječ: ");
string rijec = Console.ReadLine().ToLower().Replace(" ", "").Replace(",", "").Replace("!", "").Replace("?", "");

bool mogucaPermutacija = ProvjeriPermutaciju(rijec);
if (mogucaPermutacija)
{
    Console.WriteLine("Moguće je permutirati unesenu riječ tako da bude palindrom.");
}
else
{
    Console.WriteLine("Nije moguće permutirati unesenu riječ tako da bude palindrom.");
}

if (Palindrom(rijec))
{
    Console.WriteLine("Riječ je palindrom!");
}
else
{
    Console.WriteLine("Riječ nije palindrom!");
}

static bool ProvjeriPermutaciju(string rijec)
{
    var brojacSlova = new int[26];

    foreach (char znak in rijec)
    {
        if (char.IsLetter(znak))
        {
            brojacSlova[znak - 'a']++;
        }
    }

    int neparniBrojZnakova = brojacSlova.Count(count => count % 2 != 0);

    return neparniBrojZnakova <= 1;
}
partial class Program
{
    static bool Palindrom(string rijec)
    {
        char[] slova = rijec.ToCharArray();

        Array.Reverse(slova);
        string naopako = new string(slova);
        if (rijec == naopako)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}