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
        public IEnumerable<CustomerBook> Loans
        {
            get
            {
             return _appDbContext.CustomerBooks;
            }
        }

        public CustomerBook GetCustomerBookByID(int id)
        {
            return _appDbContext.CustomerBooks.FirstOrDefault(cb => cb.CustomerBookID == id);
        }

        public async Task<CustomerBook> Add(CustomerBook customerBook)
        {
            var result = await _appDbContext.CustomerBooks.AddAsync(customerBook);
            await _appDbContext.SaveChangesAsync();
            return result.Entity;
        }

    }
}
