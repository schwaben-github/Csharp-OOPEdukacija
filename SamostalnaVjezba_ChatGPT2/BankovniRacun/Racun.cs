namespace BankovniRacun
{
    internal class Racun
    {
        // Properties
        public int BrojRacuna { get; }
        public string ImeVlasnika { get; }
        public decimal StanjeRacuna { get; private set; }

        // Constructor
        public Racun(int brojRacuna, string imeVlasnika, decimal pocetnoStanje)
        {
            BrojRacuna = brojRacuna;
            ImeVlasnika = imeVlasnika;
            StanjeRacuna = pocetnoStanje;
        }

        // Methods
        public void Uplati(decimal iznos)
        {
            if (iznos > 0)
            {
                StanjeRacuna += iznos;
                Console.WriteLine($"Uplata od {iznos} EUR je uspješno izvršena na račun broj {BrojRacuna}.\nNovo stanje računa: {StanjeRacuna} EUR.");
            }
            else
            {
                Console.WriteLine("Neispravan iznos uplate. Molimo unesite pozitivan iznos.");
            }

        }

        public void Isplati(decimal iznos)
        {
            if (iznos > 0 && iznos <= StanjeRacuna)
            {
                StanjeRacuna -= iznos;
                Console.WriteLine($"Isplata od {iznos} EUR uspješno izvršena s računa broj {BrojRacuna}. Novo stanje računa: {StanjeRacuna} EUR.");
            }
            else if (iznos <= 0)
            {
                Console.WriteLine("Neispravan iznos isplate. Molimo unesite pozitivan iznos.");
            }
            else
            {
                Console.WriteLine("Nemate dovoljno sredstava na računu za isplatu.");
            }
        }

        public void PrikaziStanje()
        {
            Console.WriteLine($"Trenutno stanje računa broj {BrojRacuna} za vlasnika {ImeVlasnika} iznosi: {StanjeRacuna} EUR.");
        }
    }
}
