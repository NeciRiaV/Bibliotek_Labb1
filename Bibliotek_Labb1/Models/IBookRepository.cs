using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks { get; }
        IEnumerable<Book> GetAllBooksInStock { get; }
        Book GetBookById(int bookid);
        Task<Book> GetBookByName(string bookname);
        Task<Book> GetBookByAuthor(string bookauthor);

    }
}
