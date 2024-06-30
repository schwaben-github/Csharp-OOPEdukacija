using System;
using KolikoPonavljanja;

Console.Write("Unesite rečenicu: ");
string recenica = Console.ReadLine()?.ToLower();
string[] rijeci = recenica?.Split(' ');

PonavljanjeRijeci ponavljanjeRijeci = new PonavljanjeRijeci(recenica);

ponavljanjeRijeci.IspisiPonavljanja();

Console.WriteLine();
Console.WriteLine("Pritisnite bilo koju tipku za izlazak iz programa.");
Console.ReadKey();
