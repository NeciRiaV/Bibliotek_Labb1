using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.Models
{
    interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCutomers { get; }
        Customer GetCustomerBytId(int customerid);
        Customer AddCustomer(Customer customer);
        Customer DeleteCustomer(int customerid);
        Customer EditCustomer(int customerid);
    }
}
