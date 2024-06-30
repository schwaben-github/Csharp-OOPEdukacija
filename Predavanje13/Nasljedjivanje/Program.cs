using Nasljedjivanje;

Osoba o = new Osoba("Tibor", "Weigand");
Console.WriteLine(o.ToString()); // Tibor Weigand

Clan c = new Clan("Tibor", "Weigand");
c.ClanskiBroj = "5465542";
Console.WriteLine(c.ToString());

Object obj = new Object();
Console.WriteLine(obj.ToString()); // System.Object

int broj = 5;
Console.WriteLine($"broj.ToString(): {0}", broj.ToString());