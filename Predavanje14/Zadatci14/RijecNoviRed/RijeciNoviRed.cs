using System;

namespace RijecNoviRed
{
    internal class RijeciNoviRed
    {
        public string Recenica { get; set; }

        public RijeciNoviRed(string recenica)
        {
            Recenica = recenica;
            IspisiRijeci();
        }

        private void IspisiRijeci()
        {
            string[] rijeci = Recenica.Split(' ');
            foreach (string r in rijeci)
            {
                Console.WriteLine(r);
            }
        }
    }
}
