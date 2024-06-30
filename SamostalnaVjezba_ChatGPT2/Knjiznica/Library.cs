using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica
{
    internal class Library
    {
        // Lista knjiga u knjižnici
        private List<Book> books;

        // Konstruktor
        public Library()
        {
            books = new List<Book>();
        }

        // Metoda za dodavanje knjige u knjižnicu
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Knjiga '{book.Title}' je dodana u knjižnicu.");
        }

        // Metoda za posuđivanje knjige
        public void BorrowBook(string title)
        {
            Book book = FindBookByTitle(title);
            if (book != null)
            {
                book.Borrow();
            }
            else
            {
                Console.WriteLine($"Knjiga '{title}' nije pronađena u knjižnici.");
            }
        }

        // Metoda za vraćanje knjige
        public void ReturnBook(string title)
        {
            Book book = FindBookByTitle(title);
            if (book != null)
            {
                book.Return();
            }
            else
            {
                Console.WriteLine($"Knjiga '{title}' nije pronađena u knjižnici.");
            }
        }

        // Metoda za pronalazak knjige po naslovu
        public List<Book> SearchByTitle(string title)
        {
            List<Book> foundBooks = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Title.ToLower().Contains(title.ToLower()))
                {
                    foundBooks.Add(book);
                }
            }
            
            return foundBooks;
        }

        // Metoda za pronalazak knjige po autoru
        public List<Book> SearchByAutor(string autor)
        {
            List<Book> foundBooks = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Autor.ToLower().Contains(autor.ToLower()))
                {
                    foundBooks.Add(book);
                }
            }

            return foundBooks;
        }

        // Pomoćna metoda za pronalazak knjige po naslovu
        private Book FindBookByTitle(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title.ToLower() == title.ToLower())
                {
                    return book;
                }
            }

            return null;
        }
    }
}
