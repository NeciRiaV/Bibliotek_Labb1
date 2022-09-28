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
        public IEnumerable<Customer> GetAllCustomers
        {
            get
            {
                return _appDbContext.Customers;

            }
        }

        //Add Customer
        public async Task<Customer> Add(Customer customer)
        {
            var result = await _appDbContext.Customers.AddAsync(customer);
            await _appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        //Edit Customer
        public async Task<Customer> Edit(Customer customer)
        {
            _appDbContext.Customers.Update(customer);
            await _appDbContext.SaveChangesAsync();
            return customer;
        }

        //Delete Customer
        public async Task<Customer> Delete(int id)
        {
            var deleteCustomer = await _appDbContext.Customers.FindAsync(id);
            if (deleteCustomer != null)
            {
                _appDbContext.Customers.Remove(deleteCustomer);
                await _appDbContext.SaveChangesAsync();
            }
            return deleteCustomer;

        }

        //Get Single Customer
        public Customer GetCustomerBytId(int customerid)
        {
            return _appDbContext.Customers.FirstOrDefault(c => c.CustomerID == customerid);
        }

        public IEnumerable<Customer> GetCustomerLog
        {
            get
            {
                return _appDbContext.Customers;
            }
        }


    }
}
