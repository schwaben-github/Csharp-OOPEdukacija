namespace Knjiznica
{
    internal class Book
    {
        // Properties
        public string Title { get; set; }
        public string Autor { get; set; }
        public int Year { get; set; }
        public bool IsBorrowed { get; set; }

        // Constructor
        public Book(string title, string autor, int year)
        {
            Title = title;
            Autor = autor;
            Year = year;
            IsBorrowed = false;
        }

        // Methods
        public void Borrow()
        {
            IsBorrowed = true;
            Console.WriteLine($"Knjiga '{Title}' je posuđena.");
        }

        public void Return()
        {
            if (IsBorrowed)
            {
                IsBorrowed = false;
                Console.WriteLine($"Knjiga '{Title}' je vraćena.");
            }
            else
            {
                Console.WriteLine($"Knjiga '{Title}' nije posuđena.");
            }
        }
    }
}
