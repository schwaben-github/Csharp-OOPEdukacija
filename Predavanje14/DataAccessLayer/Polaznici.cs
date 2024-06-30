using DataAccessLayer;
using System.Collections;

namespace DataAccessLayer
{
    public class Polaznici : CollectionBase
    {
        //Sjenčanje metode Add naslijeđene iz COllectionBase klase
        public int Add(Polaznik polaznik)
        {
            return InnerList.Add(polaznik);
        }
        public int Add(string ime, string prezime)
        {
            Polaznik polaznik = new Polaznik();
            polaznik.Ime = ime;
            polaznik.Prezime = prezime;
            return base.InnerList.Add(polaznik);
        }

        //Implementacija indeksera
        public object this[int index]
        {
            get
            {
                return (Polaznik)InnerList[index];
            }
        }
    }
}

public class Polaznici : CollectionBase
{
    // hide method Add inherited from CollectionBase class
    public int Add(Polaznik polaznik)
    {
        return InnerList.Add(polaznik);
    }

    public int Add(string ime, string prezime)
    {
        Polaznik polaznik = new Polaznik();
        polaznik.Ime = ime;
        polaznik.Prezime = prezime;
        return InnerList.Add(polaznik);
    }

    // implement indexer
    public object this[int index]
    {
        get
        {
            return (Polaznik)InnerList[index];
        }
    }
}
}
