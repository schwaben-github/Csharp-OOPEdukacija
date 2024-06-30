using System.Collections;

ArrayList mojiBrojevi = Unos();
Console.WriteLine(" SVI BROJEVI :");
Ispis(mojiBrojevi);

Console.WriteLine(" PARNI :");
ArrayList parni = IzvuciParne(mojiBrojevi);
Ispis(parni);

Console.WriteLine(" NEPARNI :");
Ispis(IzvuciNeparne(mojiBrojevi));

Console.WriteLine(" BEZ NEPARNIH: ");
Ispis(IzbaciNeparne(mojiBrojevi));

partial class Program
{
    /// <summary>
    /// Method returns numbers entered until "0" has been entered
    /// </summary>
    /// <returns></returns>
    static ArrayList Unos()
    {
        int i = 0;
        int broj = -1;
        ArrayList brojevi = new ArrayList();
        while (true)
        {
            Console.Write($"Unesi {i + 1}. broj: ");
            try
            {
                broj = int.Parse(Console.ReadLine());
                if (broj == 0)
                {
                    break;
                }
                brojevi.Add(broj);
                i++;
            }
            catch (Exception)
            {
                Console.WriteLine("Krivi unos!");
            }
            
        }
        return brojevi;
    }

    /// <summary>
    /// Method sends ArrayList to console output
    /// </summary>
    /// <param name="lstBrojevi">List if integer numbers</param>
    static void Ispis(ArrayList lstBrojevi)
    {
        foreach (int element in lstBrojevi)
        {
            Console.WriteLine(element);
        }
    }

    /// <summary>
    /// Returns even numbers 
    /// </summary>
    /// <param name="lista">List of integers</param>
    /// <returns></returns>
    static ArrayList IzvuciParne(ArrayList lista)
    {
        ArrayList parni = new ArrayList();
        foreach (int element in lista)
        {
            if (element % 2 == 0)
            {
                parni.Add(element);
            }
        }
        return parni;
    }

    /// <summary>
    /// Returns odd numbers
    /// </summary>
    /// <param name="lista">List of integers</param>
    /// <returns></returns>
    static ArrayList IzvuciNeparne(ArrayList lista)
    {
        ArrayList neparni = new ArrayList();
        foreach (int element in lista)
        {
            if (element % 2 != 0)
            {
                neparni.Add(element);
            }
        }
        return neparni;
    }

    /// <summary>
    /// Kicks out the odd numbers from the ArrayList
    /// </summary>
    /// <param name="brojevi">List of casted integers</param>
    /// <returns></returns>
    static ArrayList IzbaciNeparne(ArrayList brojevi)
    {
        for (int i = brojevi.Count - 1; i >= 0; i--)
        {
            if ((int)brojevi[i] % 2 != 0)
            {
                brojevi.RemoveAt(i);
            }
        }
        return brojevi;
    }
}
