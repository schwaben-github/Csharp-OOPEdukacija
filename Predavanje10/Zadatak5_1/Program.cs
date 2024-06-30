// Napravi program koji traži unos riječi sve dok se ne unese riječ "kraj".
// Program prevodi upisanu riječ u telefonski broj prema mapiranju standardne tipkovnice te ispisuje telefonski broj na konzolu.
// Program treba biti otporan na greške pri unosu.
// Napraviti metodu RijecUBroj() koja prima 1 string parametar riječ i vraća string
// sa pripadajućim telefonskim brojem. Unos može biti velikim ili malim slovima, a ako
// riječ sadrži brojeve 0 ... 9 ili znak + metoda ih ostavlja onakvima kakvi jesu.
// U glavnom programu omogućiti višestruki unos te za svaki unos pozvati
// metodu RijecUBroj(). Ukoliko upisana riječ sadrži nepoznate znakove, program treba
// vratiti Exception sa odgovarajućom porukom i tražiti ponovni unos. Riječ „kraj” ne
// treba prevoditi u telefonski broj.

string unos;

do
{
    Console.Write("Unesi rijec ('kraj' za kraj): ");
    unos = Console.ReadLine().ToLower();

    if (unos != "kraj")
    {
        try
        {
            string telefon = RijecUBroj(unos);
            Console.WriteLine($"Telefonski broj: {telefon}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        } 
    }

} while (unos != "kraj");

partial class Program
{
    static string RijecUBroj(string rijec)
    {
        string telefon = "";

        foreach (char znak in rijec)
        {
            if (Char.IsLetter(znak))
            {
                string broj = MapirajZnak(znak);
                if (broj == "-1")
                {
                    throw new ArgumentException($"Nepoznat znak '{znak}'. Molimo unesite samo slova, brojeve ili znak +.");
                }
                telefon += broj;
            }
            else
            {
                telefon += znak;
            }
        }
        return telefon;
    }

    static string MapirajZnak(char znak)
    {
        switch (znak)
        {
            case 'a': case 'b': case 'c': return "2";
            case 'd': case 'e': case 'f': return "3";
            case 'g': case 'h': case 'i': return "4";
            case 'j': case 'k': case 'l': return "5";
            case 'm': case 'n': case 'o': return "6";
            case 'p': case 'q': case 'r': case 's': return "7";
            case 't': case 'u': case 'v': return "8";
            case 'w': case 'x': case 'y': case 'z': return "9";
            default: return "-1";
        }
    }
}

