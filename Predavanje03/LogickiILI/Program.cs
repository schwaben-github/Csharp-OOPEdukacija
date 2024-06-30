Console.Write("Unesi ime: ");
string ime = Console.ReadLine();

/*if (ime.ToUpper() == "TIBOR" || ime.ToUpper() == "HRVOJE" || ime.ToUpper() == "HANA" || ime.ToUpper() == "DENIS" || ime.ToUpper() == "MARIJAN" || ime.ToUpper() == "MARKO")
{
    Console.WriteLine("Dobro došao, polazniče!");
}
else
{
    Console.WriteLine("Krivo ime!");
}*/

// 2. način
// 3. način

string ime = ime.ToUpper();
string ime = ime.Trim();

if (ime == "TIBOR" || ime == "HRVOJE" || ime == "HANA" || ime == "DENIS" || ime == "MARIJAN" || ime == "MARKO")
{
    Console.WriteLine("Dobro došao, polazniče!");
}
else
{
    Console.WriteLine("Krivo ime!");
}