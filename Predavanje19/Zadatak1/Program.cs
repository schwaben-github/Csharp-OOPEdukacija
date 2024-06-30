Console.Write("Unesi tekst: ");
string tekst = Console.ReadLine();

string naopako = new string(tekst.Reverse().ToArray());

Console.WriteLine("Tekst naopako: " + naopako);