using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;

        public CustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Customer> GetAllCutomers
        {
            get
            {
                return _appDbContext.Customers;
            }
        }

        public Customer AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer DeleteCustomer(int customerid)
        {
            throw new NotImplementedException();
        }

        public Customer EditCustomer(int customerid)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerBytId(int customerid)
        {
            return _appDbContext.Customers.FirstOrDefault(c => c.CustomerID == customerid);
        }
    }
}
