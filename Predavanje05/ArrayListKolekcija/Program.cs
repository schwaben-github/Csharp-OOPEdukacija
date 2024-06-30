using System.Collections;

// deklaracija arrayliste
ArrayList arrayLista = new ArrayList();

// unos elemenata
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Unesi {0}. broj: ", i+1);
    int broj = int.Parse(Console.ReadLine());
    arrayLista.Add(broj);
}

arrayLista.Add(20);
arrayLista.Add(30);
arrayLista.Add(40);

arrayLista.Sort();
arrayLista.Reverse();
arrayLista.Add("miš");  // type-unsafe kolekcija! .Sort() više ne radi!

// ispis elemenata
for (int i = 0; i < arrayLista.Count; i++)
{
    Console.WriteLine(arrayLista[i]);
}