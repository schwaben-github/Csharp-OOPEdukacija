namespace BrojanjeRijeci
{
    public class Brojac
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

        // kako bi mogao pratiti broj pojavljivanja svake riječi. Jedan način je korištenje rječnika (Dictionary) gdje će ključevi biti riječi, a vrijednosti broj pojavljivanja tih riječi. Kako bi to implementirao ?
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
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
