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
        public async Task<IEnumerable<CustomerBook>> GetWholeLog()
        {
             return await _appDbContext.CustomerBooks.ToListAsync();
        }

    }
}
