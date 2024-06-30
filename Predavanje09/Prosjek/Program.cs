IspisiProsjek(3.7);
IspisiProsjek2(3.7);

partial class Program
{
    static string IspisiProsjek(double prosjek)
    {
        if (prosjek < 1 || prosjek > 5)
        {
            Console.WriteLine("Ne postojeći prosjek!");
        }
        else if (prosjek >= 4.5)
        {
            Console.WriteLine("Prosjek je odličan!");
        }
        else if (prosjek >= 3.5)
        {
            Console.WriteLine("Prosjek je vrlo dobar!");
        }
        else if (prosjek >= 2.5)
        {
            Console.WriteLine("Prosjek je dobar!");
        }
        else if (prosjek >= 1.5)
        {
            Console.WriteLine("Prosjek je dovoljan!");
        }
        else if (prosjek == 1)
        {
            Console.WriteLine("Prosjek je nedovoljan!");
        }
        return "Return!?";
    }

    static void IspisiProsjek2(double prosjek)
    {
        if (prosjek < 1 || prosjek > 5)
        {
            Console.WriteLine("Ne postojeći prosjek!");
        }
        else if (prosjek >= 4.5)
        {
            Console.WriteLine("Prosjek je odličan!");
        }
        else if (prosjek >= 3.5)
        {
            Console.WriteLine("Prosjek je vrlo dobar!");
        }
        else if (prosjek >= 2.5)
        {
            Console.WriteLine("Prosjek je dobar!");
        }
        else if (prosjek >= 1.5)
        {
            Console.WriteLine("Prosjek je dovoljan!");
        }
        else if (prosjek == 1)
        {
            Console.WriteLine("Prosjek je nedovoljan!");
        }
    }
}