Console.Write("Unesite prirodni broj: ");
int broj = int.Parse(Console.ReadLine());

List<int> djelitelji = new List<int>();
int sumaDjelitelja = 0;
for (int i = 1; i <= broj; i++)
{
    if (broj % i == 0)
    {
        djelitelji.Add(i);
        sumaDjelitelja += i;
    }
}

if (sumaDjelitelja == broj)
{
    Console.WriteLine("Broj je savršen.");
}
else
{
    Console.WriteLine("Broj nije savršen.");
}

Console.WriteLine("Djelitelji broja {0} su: {1}", broj, string.Join(", ", djelitelji));
