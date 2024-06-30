using StaticsInstancom;

try
{
    Console.Write("Unesi prirodni broj: ");
    int broj = int.Parse(Console.ReadLine());
    if (broj <= 0)
    {
        throw new Exception("Broj nije prirodan (veći od nule)!");
    }

    Console.WriteLine("Odaberi jednu od opcija:");
    Console.WriteLine("1. Prost ili složen");
    Console.WriteLine("2. Savršen");

    string odabir = Console.ReadLine();
    switch (odabir)
    {
        case "1":
            /*string odgovor;
            if (Klasa.Prost(broj))
            {
                odgovor = "prost";
            }
            else
            {
                odgovor = "složen";
            }*/

            string odgovor = Klasa.Prost(broj) ? "prost" : "složen";
            Console.WriteLine("Broj je " + odgovor);
            break;
        case "2":
            Klasa klasa = new Klasa();

            string odgovor2 = klasa.Savrsen(broj) ? "je" : "nije";

            if (klasa.Savrsen(broj))
            {
                Console.WriteLine("Broj {0} {1} savršen.", broj, odgovor2);
            }
            else
            {
                Console.WriteLine("Broj {0} {1} savršen.", broj, odgovor2);
            }
            break;
        default:
            Console.WriteLine("Nepostojeća opcija!");
            break;
    }
}
catch (Exception e)
{
    Console.WriteLine("Greška! Detalji: " + e.Message);
}