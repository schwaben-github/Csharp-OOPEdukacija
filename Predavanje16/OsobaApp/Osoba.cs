using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Napraviti klasu Osoba sa svojstvima Ime, Prezime i metodama
// Pozdrav (ime) — metoda koji na ekranu ispisuje pozdravnu poruku "Dobar dan, ime!",
// Inicjali (ime) — metoda koja vraća inicijale osobe,
// Kapitalizacija (ime) — funkcija koja vraća prosljeđeni tekst tako da je u svakoj riječi početno slovo veliko, a ostala slova su mala.

namespace OsobaApp
{
    internal class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public void Pozdrav()
        {
            Console.WriteLine($"Dobar dan, {Ime}!");
        }

        public string Inicijali()
        {
            string[] imena = Ime.Split(' ');
            string[] prezimena = Prezime.Split(' ');

            string inicij = "";
            foreach (string i in imena)
            {
                inicij += i[0].ToString().ToUpper() + ". ";
            }
            foreach (string p in prezimena)
            {
                inicij += p[0].ToString().ToUpper() + ". ";
            }
            return inicij;
        }

        public string Kapitalizacija()
        {
            string[] rijeci = Ime.Split(' ');
            string kapitalac = "";
            foreach (string r in rijeci)
            {
                kapitalac += r[0].ToString().ToUpper() + r.Substring(1).ToLower() + " ";
            }
            return kapitalac;
        }
    }
}
