using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Proizvodi : CollectionBase
    {
        public object this[int index]
        {
            get
            {
                return (Proizvod)List[index];
            }
            set
            {
                List[index] = value;
            }
        }

        public int Add(Proizvod proizvod)
        {
            return InnerList.Add(proizvod);
        }

        public void Remove(Proizvod proizvod)
        {
            InnerList.Remove(proizvod);
        }

        
    }
}
