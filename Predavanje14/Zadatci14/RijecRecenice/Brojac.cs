namespace RijecRecenice
{
    internal class Brojac
    {
        public string Recenica { get; set; }
        public string Brojanje { get; set; }

        public Brojac(string recenica)
        {
            Recenica = recenica;
            Brojanje = BrojiRijeci();
        }

        private string BrojiRijeci()
        {
            string[] rijeci = Recenica.Split(' ');
            return rijeci.Length.ToString();
        }

        public override string ToString()
        {
            return Brojanje;
        }

        public void IspisiBrojRijeci()
        {
            Console.WriteLine(Brojanje);
        }

        public void IspisiBrojPojavljivanjaRijeci()
        {
            string[] rijeci = Recenica.Split(' ');
            Dictionary<string, int> brojPojavljivanja = new Dictionary<string, int>();
            foreach (string rijec in rijeci)
            {
                if (brojPojavljivanja.ContainsKey(rijec))
                {
                    brojPojavljivanja[rijec]++;
                }
                else
                {
                    brojPojavljivanja.Add(rijec, 1);
                }
            }

            foreach (var item in brojPojavljivanja)
            {
                // Console.WriteLine($"{item.Key}: {item.Value}");
                Console.WriteLine($"Riječ {item.Key} se pojavljuje {item.Value} puta.");
            }
        }
    }
}
