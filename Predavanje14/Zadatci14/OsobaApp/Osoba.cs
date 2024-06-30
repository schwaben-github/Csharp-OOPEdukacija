// Napraviti klasu Osoba sa svojstvima Ime, Prezime i metodama
// Pozdrav (ime) — metoda koji na ekranu ispisuje pozdravnu poruku "Dobar dan, ime!",
// Inicjali (ime) — metoda koja vraća inicijale osobe,
// Kapitalizacija (ime) — funkcija koja vraća prosljeđeni tekst tako da je u svakoj riječi početno slovo veliko, a ostala slova su mala.

using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsobaApp
{
    internal class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public void Pozdrav(string ime)
        {
            Console.WriteLine($"Dobar dan, {ime}!");
        }

        public string Inicijali(string ime)
        {
            string[] inicijali = ime.Split(' ');
            string inicij = "";
            foreach (string i in inicijali)
            {
                inicij += i[0];
            }
            return inicij;
        }

        public string Kapitalizacija(string ime)
        {
            string[] rijeci = ime.Split(' ');
            string kapitalac = "";
            foreach (string r in rijeci)
            {
                kapitalac += r[0].ToString().ToUpper() + r.Substring(1).ToLower() + " ";
            }
            return kapitalac;
        }
    }
}
