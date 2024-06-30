string username = "";
string password = "";

Console.Write("Unesi korisničko ime: ");
username =Console.ReadLine();

Console.Write("Unesi lozinku: ");
password =Console.ReadLine();

if (username == "polaznik" && password == "polaznik")
{
    Console.WriteLine("Uspješna prijava!");
}
else
{
    Console.WriteLine("Krivo korisničko ime ili lozinka!");
}