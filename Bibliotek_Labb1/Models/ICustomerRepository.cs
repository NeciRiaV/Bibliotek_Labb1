using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.Models
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers { get; }
        Customer GetCustomerBytId(int customerid);
        Task<Customer> Add(Customer customer);
        Task<Customer> Edit(Customer customer);
        Task<Customer> Delete(int id);
        //Task<Customer> EditCustomer(Customer customer);
        //IEnumerable<Customer> GetCustomerLogById(int customer);
    }
}
