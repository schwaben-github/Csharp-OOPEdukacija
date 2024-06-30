using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VozilaApp
{
    internal class Automobili : CollectionBase
    {
        public int Add(Automobil auto)
        {
            return InnerList.Add(auto);
        }
        public void Remove(Automobil auto)
        {
            InnerList.Remove(auto);
        }
        public Automobil this[int index]
        {
            get
            {
                return (Automobil)InnerList[index];
            }
            set
            {
                InnerList[index] = value;
            }
        }
    }
}
