using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Dogadjaji2
{
    public class Polaznici : CollectionBase
    {
        public int Add(Polaznik polaznik)
        {
            return InnerList.Add(polaznik);
        }
        public Polaznik this[int index]
        {
            get
            {
                return (Polaznik)InnerList[index];
            }
        }
    }
}