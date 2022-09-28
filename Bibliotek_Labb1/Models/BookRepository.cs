using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _appDbContext;
        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Book> GetAllBooks
        {
            get
            {
                return _appDbContext.Books;
            }
        }

        public IEnumerable<Book> GetAllBooksInStock
        {
            get
            {
                return _appDbContext.Books.Where(b => b.IsOnLoan == false);
            }
        }

        public Book GetBookById(int bookid)
        {
            return _appDbContext.Books.FirstOrDefault(b => b.BookID == bookid);
        }

        public async Task<Book> GetBookByName(string bookname)
        {
            return await _appDbContext.Books.FirstOrDefaultAsync(b => b.BookName == bookname);
        }

        public async Task<Book> GetBookByAuthor(string bookauthor)
        {
            return await _appDbContext.Books.FirstOrDefaultAsync(a => a.Author == bookauthor);
        }

    }
}
