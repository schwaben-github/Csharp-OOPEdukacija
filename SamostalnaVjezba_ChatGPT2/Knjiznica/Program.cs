using Knjiznica;

Library library = new Library();

while (true)
{
    Console.WriteLine("\nOdaberite opciju:");
    Console.WriteLine("1. Dodaj knjigu");
    Console.WriteLine("2. Posudi knjigu");
    Console.WriteLine("3. Vrati knjigu");
    Console.WriteLine("4. Pretraži knjige po autoru");
    Console.WriteLine("5. Pretraži knjige po naslovu");
    Console.WriteLine("6. Izlaz");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Unesite naslov knjige: ");
            string title = Console.ReadLine();
            Console.Write("Unesite autora knjige: ");
            string author = Console.ReadLine();
            int year;
            while (true)
            {
                Console.Write("Unesite godinu izdanja knjige: ");
                try
                {
                    year = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Neispravan unos! Molim cijeli broj za godinu izdanja.");
                }
            }
            library.AddBook(new Book(title, author, year));
            break;

        case "2":
            Console.Write("Unesite naslov knjige koju želite posuditi: ");
            string borrowTitle = Console.ReadLine();
            library.BorrowBook(borrowTitle);
            break;

        case "3":
            Console.Write("Unesite naslov knjige koju vraćate: ");
            string returnTitle = Console.ReadLine();
            library.ReturnBook(returnTitle);
            break;

        case "4":
            Console.Write("Unesite ime autora po kojem želite pretražiti knjige: ");
            string authorToSearch = Console.ReadLine();
            Console.WriteLine($"Knjige autora '{authorToSearch}':");
            foreach (Book book in library.SearchByAutor(authorToSearch))
            {
                Console.WriteLine($"{book.Title} ({book.Year})");
            }
            break;

        case "5":
            Console.Write("Unesite dio naslova po kojem želite pretražiti knjige: ");
            string titleToSearch = Console.ReadLine();
            Console.WriteLine($"\nKnjige s naslovom koji sadrži '{titleToSearch}':");
            foreach (Book book in library.SearchByTitle(titleToSearch))
            {
                Console.WriteLine($"{book.Title} ({book.Autor}, {book.Year})");
            }
            break;

        case "6":
            Console.WriteLine("Hvala na korištenju programa!");
            return;

        default:
            Console.WriteLine("Nepoznata opcija. Molimo odaberite ponovno.");
            break;
    }
}

/*Library library = new Library();

// Dodavanje nekoliko knjiga u knjižnicu
library.AddBook(new Book("Harry Potter and the Philosopher's Stone", "J.K. Rowling", 1997));
library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925));
library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960));
library.AddBook(new Book("Harry Potter and the Chamber of Secrets", "J.K. Rowling", 1998));
library.AddBook(new Book("Harry Potter and the Order of the Phoenix", "J.K. Rowling", 2003));
library.AddBook(new Book("Go Set a Watchman", "Harper Lee", 2015));
library.AddBook(new Book("The Bell Jar", "Sylvia Plath", 1963));

// Posuđivanje knjige
library.BorrowBook("Go Set a Watchman");
library.BorrowBook("The Great Gatsby");

// Vraćanje knjige
library.ReturnBook("Harry Potter Stone");

// Pretraga knjiga po autoru
String autorToSearch = "J.K. Rowling";
Console.WriteLine($"Knjige autora '{autorToSearch}'");
foreach (Book book in library.SearchByAutor(autorToSearch))
{
    Console.WriteLine($"- {book.Title} ({book.Year})");
}

// Pretraga knjiga po naslovu
String titleToSearch = "mockingbird";
Console.WriteLine($"\nKnjige koje sadrže '{titleToSearch}' u naslovu");
foreach (Book book in library.SearchByTitle(titleToSearch))
{
    Console.WriteLine($"- {book.Title} ({book.Autor}, {book.Year})");
}*/