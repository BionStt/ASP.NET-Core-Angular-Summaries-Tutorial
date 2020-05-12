using System.Collections.Generic;
using Summaries_Tutorial.Data;

namespace Summaries_Tutorial.Data
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        void UpdateBook(int id, Book newBook);
        void DeleteBook(int id);
        void AddBook(Book newBook);
    }
}