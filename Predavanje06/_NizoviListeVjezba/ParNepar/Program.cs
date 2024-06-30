
List<int> lstParni = new List<int>();
List<int> lstNeparni = new List<int>();

int broj;

for (int i = 0; i < 10; i++)
{
    Console.Write("Unesi {0}. element niza: ", i + 1);
    broj = Convert.ToInt32(Console.ReadLine());

    if (broj % 2 == 0)
    {
        lstParni.Add(broj);
    }
    else
    {
        lstNeparni.Add(broj);
    }
}

Console.WriteLine("============== parni =============");
foreach (int item in lstParni)
{
    Console.WriteLine(item);
}
Console.WriteLine("============= neparni ============");
foreach (int item in lstNeparni)
{
    Console.WriteLine(item);
}