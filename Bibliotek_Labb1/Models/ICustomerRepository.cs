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
        Task<Customer> AddCustomer(Customer customer);
        Task<Customer> DeleteCustomer(int customerid);
        Task<Customer> EditCustomer(Customer customer);
        Task<IEnumerable<Customer>> GetCustomerLogById(int customer);
    }
}
