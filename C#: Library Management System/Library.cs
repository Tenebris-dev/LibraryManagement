// Library.cs
using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ListBooks()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
        }

        public void CheckOutBook(int index)
        {
            if (index >= 0 && index < books.Count)
            {
                books[index].CheckOut();
            }
        }

        public void ReturnBook(int index)
        {
            if (index >= 0 && index < books.Count)
            {
                books[index].Return();
            }
        }

        public static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBook(new Book("1984", "George Orwell"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee"));
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald"));

            Console.WriteLine("All Books:");
            library.ListBooks();

            Console.WriteLine("\nChecking out the first book...");
            library.CheckOutBook(0);

            Console.WriteLine("\nAll Books:");
            library.ListBooks();
        }
    }
}