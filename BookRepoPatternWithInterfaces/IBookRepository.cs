using System;
using System.Collections.Generic;
using System.Text;

namespace BookRepoPatternWithInterfaces
{
    interface IBookRepository
    {
        void CreateBook(Book bookToCreate);
        List<Book> GetAllBooks();
        Book GetSingleBook(int indexOfBookToFind);
        void UpdateBook(int indexOfBook, Book updatedBook);
        void DeleteBook(int indexOfBook);
    }
}
