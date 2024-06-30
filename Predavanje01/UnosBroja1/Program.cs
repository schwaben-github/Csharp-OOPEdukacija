// See https://aka.ms/new-console-template for more information

//1. eksplicitna pretvorba - konverzija
int broj1 = Convert.ToInt32("111");
int broj2 = 222;

//2. implicitna pretvorba cijelog broja u decimal
decimal broj3 = 333;

decimal broj4 = 15.555m;
//d - double
//e - eksponent
//c - char (1 znak)
//i - inkrement, iterator, integer

//3. eksplicitna pretvorba - kastanje
broj2 = (int)broj4;
Console.WriteLine(broj2);

//4. unos teksta
Console.WriteLine("Unesi neki tekst: ");
string uneseniTekst = Console.ReadLine();

Console.WriteLine("Unio si tekst: " + uneseniTekst);

//5. Unos broja
Console.Write("Unesi prvi broj: ");
int prviBroj = Convert.ToInt32(Console.ReadLine()); //1

Console.Write("Unesi drugi broj: ");
string sDrugiBroj = Console.ReadLine(); //2
int drugiBroj = int.Parse(sDrugiBroj);

Console.WriteLine("Zbroj brojeva je: ");
Console.WriteLine(prviBroj + sDrugiBroj); //12
Console.WriteLine(prviBroj + drugiBroj); //3
