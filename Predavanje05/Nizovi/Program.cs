// Nizovi (Arrays) koriste se za pohranu podataka istog tipa (npr. integera)

// deklaracija niza cijelih brojeva koji ima 3 elementa
int[] nizBrojeva = new int[3];

// inicijalizacija niza
nizBrojeva[0] = 10;
nizBrojeva[1] = 20;
nizBrojeva[2] = 30;

// nije moguće dodati 4. član!
// nizBrojeva[3] = 31;

// deklaracija i inicijalizacija u istoj liniji
double[] doubles = new double[3] {2, 3, 4};
// pojednostavljeno:
double[] doubles2 = [2, 3, 4];

// ispis elemenata
for (int i = 0; i < nizBrojeva.Length; i++)
{
    Console.WriteLine(i + ": " + nizBrojeva[i]);
}

Console.WriteLine("------------------------------------------------------");

// niz stringova
string[] nizStringova = new string[4] {"prvi", "drugi", "treći", "četvrti"};
for (int count = 0; count < nizStringova.Length; count++)
{
    Console.WriteLine("String na indeksu " + count + " je: " + nizStringova[count]);
}

// Nizovi zu nepraktični, jer se mora unaprijed deklarirati broj članova