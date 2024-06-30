using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila
{
    internal class Automobili : System.Collections.CollectionBase
    {
        public void Add(Automobil automobil)
        {
            List.Add(automobil);
        }

        public void Remove(Automobil automobil)
        {
            List.Remove(automobil);
        }

        public Automobil this[int index]
        {
            get
            {
                return (Automobil)List[index];
            }
            set
            {
                List[index] = value;
            }
        }
    }
}
