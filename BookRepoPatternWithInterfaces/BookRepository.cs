using System;
using System.Collections.Generic;
using System.Text;

namespace BookRepoPatternWithInterfaces
{
    class BookRepository : IBookRepository
    {
        private List<Book> _books = new List<Book>();
        public void CreateBook(Book bookToCreate)
        {
            _books.Add(bookToCreate);
        }

        public void DeleteBook(int indexOfBook)
        {
            _books.RemoveAt(indexOfBook);
        }

        public List<Book> GetAllBooks()
        {
            return _books;
        }

        public Book GetSingleBook(int indexOfBookToFind)
        {
            return _books[indexOfBookToFind];
        }

        public void UpdateBook(int indexOfBook, Book updatedBook)
        {
            Book existingBook = _books[indexOfBook];
            existingBook = updatedBook;
        }
    }
}
