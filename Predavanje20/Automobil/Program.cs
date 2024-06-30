using System;
using System.Collections.Generic;
using System.Linq;

namespace Automobil
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> automobili = new List<Auto>();
            while (true)
            {
                Console.Write("Unesi marku automobila (ili Enter za kraj): ");
                string marka = Console.ReadLine();
                if (string.IsNullOrEmpty(marka))
                {
                    break;
                }
                Console.Write("Unesi model automobila: ");
                string model = Console.ReadLine();
                Console.Write("Unesi zapreminu motora: ");
                int zapremina = int.Parse(Console.ReadLine());
                automobili.Add(new Auto { Marka = marka, Model = model, Zapremina = zapremina });
            }

            Console.WriteLine("Automobili s zapremninom većom od 1400 ccm, sortirani po modelu:");
            var filtriraniAutomobili = automobili
                .Where(a => a.Zapremina > 1400)
                .OrderBy(a => a.Model);

            var filtriraniAutomobili2 = from auto in automobili
                                        where auto.Zapremina > 1400
                                        orderby auto.Model
                                        select auto;

            Console.WriteLine("-------------- Sintaksa metode -----------------");
            foreach (var automobil in filtriraniAutomobili)
            {
                Console.WriteLine($"{automobil.Marka} {automobil.Model} ({automobil.Zapremina} ccm)");
            }

            Console.WriteLine("-------------- Sintaksa upita -----------------");
            foreach (var automobil in filtriraniAutomobili2)
            {
                Console.WriteLine($"{automobil.Marka} {automobil.Model} ({automobil.Zapremina} ccm)");
            }

            /*var modeli = automobili.Where(a => a.Zapremina > 1400).OrderBy(a => a.Model);
            foreach (var auto in modeli)
            {
                Console.WriteLine(auto.Model);
            }*/
        }
    }
}