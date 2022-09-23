﻿using Microsoft.EntityFrameworkCore;
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
        
        public async Task<Customer> AddCustomer(Customer customer)
        {
            var newCustomer = await _appDbContext.Customers.AddAsync(customer);
            await _appDbContext.SaveChangesAsync();
            return newCustomer.Entity;
        }

        public async Task<Customer> DeleteCustomer(int customerid)
        {
            var deletedCustomer = await _appDbContext.Customers.FirstOrDefaultAsync(c => c.CustomerID == customerid);
            if (deletedCustomer != null)
            {
                _appDbContext.Remove(deletedCustomer);
                await _appDbContext.SaveChangesAsync();
                return deletedCustomer;
            }
            return null;
        }

        public async Task<Customer> EditCustomer(Customer customer)
        {
            var result = await _appDbContext.Customers.FirstOrDefaultAsync(c => c.CustomerID == customer.CustomerID);
            if (result != null)
            {
                result.FullName = customer.FullName;
                result.Email = customer.Email;
                result.PhoneNumber = customer.PhoneNumber;
                result.Adress = customer.Adress;
                result.City = customer.City;
                result.ZipCode = customer.ZipCode;

                await _appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

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


        //public IEnumerable<Customer> GetCustomerLogById(int customerid)
        //{
        //    IQueryable<Customer> customer = _appDbContext.Customers.Include(cb => cb.CustomerBook).Where(cb => cb.CustomerID == customerid);
        //    if (!customer.Equals(customerid))
        //    {
        //        customer = customer.Where(c => c.CustomerID == customerid);

        //    }
        //    return customer.ToList();
        //}
    }
}
