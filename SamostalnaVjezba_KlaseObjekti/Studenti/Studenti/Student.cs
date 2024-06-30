using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenti
{
    public class Student
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public List<int> Ocjene { get; set; }

        public Student(string ime)
        {
            Ime = ime;
            Ocjene = new List<int>();
        }

        public double Prosjek()
        {
            if (Ocjene.Count == 0)
                return 0;
            
            double suma = 0;
            foreach (double ocjena in Ocjene)
            {
                suma += ocjena;
            }
            return suma / Ocjene.Count;
        }

        public override bool Equals(object? obj)
        {
            return obj is Student student &&
                   Prezime == student.Prezime;
        }
    }
}
