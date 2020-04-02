using System;
using System.Collections.Generic;

namespace BookRepoPatternWithInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IBookRepository bookRepo = new BookRepository();
            // Creating a new book
            Book newBook = new Book()
            {
                Title = "Meditions",
                Author = "Marcus Aurelius",
                PageAmount = 220,
                Genre = "Philosophy"
            };
            bookRepo.CreateBook(newBook);
            // Read all books
            List<Book> books = bookRepo.GetAllBooks();
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{i} {books[i].Title} {books[i].Author}");
            }
            int indexToRetrieveBook = Convert.ToInt32(Console.ReadLine());
            // Read single book
            bookRepo.GetSingleBook(indexToRetrieveBook);
            // Update a book
            Book updatedBook = newBook;
            updatedBook.PageAmount = 93;
            bookRepo.UpdateBook(indexToRetrieveBook, updatedBook);
            // Delete a book
            bookRepo.DeleteBook(indexToRetrieveBook);
        }
    }
}
