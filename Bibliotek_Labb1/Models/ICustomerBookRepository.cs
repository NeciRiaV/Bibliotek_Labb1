using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.Models
{
    interface ICustomerBookRepository
    {
        IEnumerable<CustomerBook> GetWholeLog { get; }
        CustomerBook GetCustomerLogById(Customer customerId, Book bookId);
    }
}
