// See https://aka.ms/new-console-template for more information

// Računske operacije
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