using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.Models
{
    public class CustomerBookRepository : ICustomerBookRepository
    {
        private readonly AppDbContext _appDbContext;

        public CustomerBookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<CustomerBook> GetWholeLog
        {
            get
            {
                return _appDbContext.CustomerBooks;
            }
        }

        public CustomerBook GetCustomerLogById(Customer customerId, Book bookId)
        {
            throw new NotImplementedException();
        }
    }
}
