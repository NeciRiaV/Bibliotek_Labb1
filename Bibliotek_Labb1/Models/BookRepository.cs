using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.Models
{
    public class BookRepository : IBookRepository
    {
        public IEnumerable<Book> GetAllBooks => throw new NotImplementedException();

        public Book GetBookById(int bookid)
        {
            throw new NotImplementedException();
        }
    }
}
