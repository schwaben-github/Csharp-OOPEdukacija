using System.Linq.Expressions;
using System.Text;

// Anonimna funkcija
// x => x * x
// x je ulazni parametar, x * x je izraz koji se izvršava
// x => x * x je ekvivalentno sa delegate int Funkcija(int x) { return x * x; }


// Lambda izraz sa 1 ulaznim parametrom
Func<double, double> f1 = x => x * x;
double rezultat = f1(5);
Console.WriteLine(rezultat); // 25
Console.WriteLine("-----------------------------------");

// Lambda izraz sa 2 ulazna parametra
Func<int, int, int> f2 = (x, y) => x + y;
int rezultat2 = f2(5, 6);
Console.WriteLine(rezultat2); // 11
Console.WriteLine("-----------------------------------");

// Lambda izraz bez ulaznih parametara
Func<string> f3 = () => DateTime.Now.ToShortDateString();
string rezultat3 = f3();
Console.WriteLine(rezultat3); // 13.05.2024
Console.WriteLine("-----------------------------------");

// Eksplicitni navod ulaznih parametara
Func<int, string, bool> f4 = (int x, string s) => s.Length > x;
bool rezultat4 = f4(5, "Otorinolaringologija");
Console.WriteLine(rezultat4); // True
Console.WriteLine("-----------------------------------");

// foreach sa lambda izrazom
List<string> imena = new List<string>()
{
    "Iva",
    "Ivo",
    "Marko",
    "Ana",
    "Josip",
    "Ivana"
};
string rezultat5 = "";
imena.ForEach(i => rezultat5 += (i + ", "));
Console.WriteLine(rezultat5); // Iva, Ivo, Marko, Ana, Josip, Ivana,
Console.WriteLine("-----------------------------------");

// Metoda Count()
int[] brojevi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int neparni = brojevi.Count(b => b % 2 == 1);
Console.WriteLine($"Lista  {string.Join(" ", brojevi)} ima ukupno {neparni} neparnih brojeva.");
Console.WriteLine("-----------------------------------");

//metoda Select()
int[] brojevi2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
IEnumerable<int> kvadrati = brojevi2.Select(x => x * x);
StringBuilder stringBuilder = new StringBuilder();
foreach (var kvadrat in kvadrati)
{
    stringBuilder.AppendLine(kvadrat.ToString());
}
Console.WriteLine(stringBuilder);
Console.WriteLine("-----------------------------------");

//metoda Where()
int[] brojevi3 = { 0, 1, 2, 3, 4, 5, 6 };
var upit = brojevi3.Where(n => n % 2 == 0).ToList();
foreach(int item in upit)
{
    stringBuilder.AppendLine(item.ToString());
}
Console.WriteLine(stringBuilder);
Console.WriteLine("-----------------------------------");

//metoda Where() sa StringComparison
string[] imena2 = { "Marko", "Luka", "Ivan", "Marija", "Ivana", "Josip", "Damir" };
IEnumerable<string> upit2 = imena2.Where(s => s.StartsWith("m", StringComparison.CurrentCultureIgnoreCase));
stringBuilder = new StringBuilder();
foreach (string item in upit2)
{
    stringBuilder.AppendLine(item);
}
Console.WriteLine(stringBuilder);
Console.WriteLine("-----------------------------------");

// Kombinacija Where() i Select()
string[] imena3 = { "Petar", "Mia", "Ina", "Đuro", "Koraljka", "Anica", "Josipa" };
var upit3 = imena3.Where(s => s.Length == 5).Select(s => s.ToUpper()).ToArray();
stringBuilder = new StringBuilder();
foreach (string item in upit3)
{
    stringBuilder.AppendLine(item);
}
Console.WriteLine(stringBuilder);
Console.WriteLine("-----------------------------------");

// LINQ upiti u sintaksi upita (preporuceno)...
int[] brojevi4 = { 5, 10, 8, 3, 6, 12, 9, 4, 11, 22, 23, 24 };
IEnumerable<int> sintaksaUpita = from broj in brojevi4
                                 where broj % 2 == 0
                                 orderby broj
                                 select broj;
foreach (int item in sintaksaUpita)
{
    Console.WriteLine(item);
}
Console.WriteLine("-----------------------------------");

// ...i u sintaksi metode
IEnumerable<int> sintaksaMetode = brojevi4.Where(x => x % 2 == 0).OrderBy(x => x);
foreach (int item in sintaksaMetode)
{
    Console.WriteLine(item);
}