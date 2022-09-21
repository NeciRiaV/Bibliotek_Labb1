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
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _appDbContext.Books.ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetAllBooksInStock()
        {
            IQueryable<Book> instock = _appDbContext.Books.Where(b => b.IsOnLoan == false);
            return await instock.ToListAsync();
        }

        public async Task<Book> GetBookById(int bookid)
        {
            return await _appDbContext.Books.FirstOrDefaultAsync(b => b.BookID == bookid);
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
