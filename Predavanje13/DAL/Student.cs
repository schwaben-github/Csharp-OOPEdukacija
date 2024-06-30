using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DAL = Data Access Layer
namespace DAL
{
    public class Student: Osoba
    {
        public int Matematika { get; set; }
        public int Kemija { get; set; }
        public int Fizika { get; set; }

        public double Prosjek()
        {
            return (Matematika + Kemija + Fizika) / 3.0;
        }
    }
}
