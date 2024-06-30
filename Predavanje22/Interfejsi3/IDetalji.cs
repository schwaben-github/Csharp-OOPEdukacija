using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsi3
{
    internal interface IDetalji
    {
        //Svojstvo
        public int Starost { get; set; }

        //Metoda
        string Detalji();
    }
}