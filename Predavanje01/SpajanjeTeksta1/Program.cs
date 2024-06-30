// See https://aka.ms/new-console-template for more information

int broj = -1;
decimal drugiBroj = 3;
int treciBroj = Convert.ToInt32("232423");
Console.WriteLine(treciBroj);

string _3d = "nešto";
string ime = "Igor";
string prezime = "Jakopiček";

//1. Konkatenacija - spajanje teksta - pomoću operatora +

//cw - snippet za Console.WriteLine
Console.WriteLine(ime + " " + prezime);

string punoIme = ime + " " + prezime;
Console.WriteLine(punoIme);

//2. deklaracija varijable
string OvoJePascalCase;
string ovo_je_ispravan_nacin_imenovanja;

string ovoJeNekiNaziovVarijableUCamelCaseu;
//3. incijalizacija varijable  - assign value - dodjeljivanje vrijednosti

//Console.WriteLine(ovoJeNekiNaziovVarijableUCamelCaseu);
ovoJeNekiNaziovVarijableUCamelCaseu = "abc";
//ovo ne valja: "abc" = ovoJeNekiNaziovVarijableUCamelCaseu;
Console.WriteLine(ovoJeNekiNaziovVarijableUCamelCaseu);

//4. možemo naporaviti inicijalizaciju i deklaraciju varijable u istoj liniji
string ovoJeNovaVarijabla = "def";

//5. hungarian notacija
string sOvoJeString = "";
int iNekiBroj = 1;
List<string> lstLista = new List<string>();

//6. deklaracija više varijabli u istoj liniji
int a, b, c;

/*Isto kao:
 * 
int a;
int b;
int c;

*/

//7. placeholderi - dodjeljuju se vrijednosti u označnim mjestima
Console.WriteLine("{0}         {1}", ime, prezime);

string novoPunoIme = String.Format("{0}         {1}", ime, prezime);
Console.WriteLine(novoPunoIme);

//8. interpolacija sa znakom dolara
Console.WriteLine($"Ovo je puno ime: {punoIme}");

Console.WriteLine("Poslije teksta idi u novu liniju");
Console.Write("Ostani na istoj liniji");
Console.Write("Još uvijek ne idem u drugi red");
