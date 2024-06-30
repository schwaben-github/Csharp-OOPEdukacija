using System;
using System.Collections;

using Proizvodi;

Proizvod p = new Proizvod();

p.Naziv = "Kruh";
p.OsnovnaCijena = 4;
p.Marza = 0.2;
p.IzracunajCijenu();

p.Naziv = "Mlijeko";
p.OsnovnaCijena = 5;
p.Marza = 0.1;

p.NaIzracunCijene += (sender, e) => Console.WriteLine("Cijena izracunata");

p.IzracunajCijenu();