// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ovo je 1. Zadatak");
Console.WriteLine(1);
Console.WriteLine(2);
Console.WriteLine(3);
Console.ReadLine();

Console.WriteLine("Ovo je 2. Zadatak");
Console.Write(1);
Console.Write(2);
Console.Write(3);
Console.ReadLine();

Console.WriteLine("Ovo je 3. Zadatak");
int prvi = 11;
int drugi = 17;
int treci = 28;
Console.Write("{0} {1} {2}", prvi, drugi, treci);
Console.ReadLine();

Console.WriteLine("Ovo je 4. Zadatak");
Console.WriteLine($"Brojevi lota 6 od 42 glase: {prvi}, {drugi} i {treci}");
Console.ReadLine();

Console.WriteLine("Ovo je 5. Zadatak");
int num = 10;
Console.WriteLine(num++);
Console.WriteLine(num);
Console.ReadLine();

Console.WriteLine("Ovo je 6. Zadatak");
Console.WriteLine(--num); // Smanjiti prije ispisa!!!
// Console.WriteLine(num);
Console.ReadLine();

Console.WriteLine("Ovo je 7. Zadatak");
Console.Write("Unesi prvi broj: ");
int broj1 = int.Parse(Console.ReadLine());

Console.Write("Unesi drugi broj: ");
int broj2 = int.Parse(Console.ReadLine());

// Matematičke operacije
int zbroj = broj1 + broj2;
int razlika = broj1 - broj2;
int umnozak = broj1 * broj2;
double kolicnik = (double)broj1 / broj2;  // Konverzija u double za decimalni rezultat

// Ispis rezultata
Console.WriteLine($"{broj1} + {broj2} = {zbroj}");
Console.WriteLine($"{broj1} - {broj2} = {razlika}");
Console.WriteLine($"{broj1} * {broj2} = {umnozak}");
Console.WriteLine($"{broj1} / {broj2} = {kolicnik}");
Console.ReadLine();

Console.WriteLine("Ovo je 8. Zadatak");
float broj1_float = 5.0f;
float broj2_float = 3.0f;

double broj1_double = 5.0;
double broj2_double = 3.0;

decimal broj1_decimal = 5.0m;
decimal broj2_decimal = 3.0m;

// Matematičke operacije
float zbroj_float = broj1_float + broj2_float;
float razlika_float = broj1_float - broj2_float;
float umnozak_float = broj1_float * broj2_float;
float kolicnik_float = broj1_float / broj2_float;

double zbroj_double = broj1_double + broj2_double;
double razlika_double = broj1_double - broj2_double;
double umnozak_double = broj1_double * broj2_double;
double kolicnik_double = broj1_double / broj2_double;

decimal zbroj_decimal = broj1_decimal + broj2_decimal;
decimal razlika_decimal = broj1_decimal - broj2_decimal;
decimal umnozak_decimal = broj1_decimal * broj2_decimal;
decimal kolicnik_decimal = broj1_decimal / broj2_decimal;

// Ispis rezultata
Console.WriteLine($"float: {broj1_float} + {broj2_float} = {zbroj_float}");
Console.WriteLine($"float: {broj1_float} - {broj2_float} = {razlika_float}");
Console.WriteLine($"float: {broj1_float} * {broj2_float} = {umnozak_float}");
Console.WriteLine($"float: {broj1_float} / {broj2_float} = {kolicnik_float}");

Console.WriteLine($"double: {broj1_double} + {broj2_double} = {zbroj_double}");
Console.WriteLine($"double: {broj1_double} - {broj2_double} = {razlika_double}");
Console.WriteLine($"double: {broj1_double} * {broj2_double} = {umnozak_double}");
Console.WriteLine($"double: {broj1_double} / {broj2_double} = {kolicnik_double}");

Console.WriteLine($"decimal: {broj1_decimal} + {broj2_decimal} = {zbroj_decimal}");
Console.WriteLine($"decimal: {broj1_decimal} - {broj2_decimal} = {razlika_decimal}");
Console.WriteLine($"decimal: {broj1_decimal} * {broj2_decimal} = {umnozak_decimal}");
Console.WriteLine($"decimal: {broj1_decimal} / {broj2_decimal} = {kolicnik_decimal}");
Console.ReadLine();

// Rezultati se razlikuju po broju decimalnih mjesta!
// float: 32-bitni tip, manja preciznost ali veća efikasnost
// double: 64-bitni tip, 2x veća preciznost od float
// decimal: 128-bitni tip podataka, najveća preciznost