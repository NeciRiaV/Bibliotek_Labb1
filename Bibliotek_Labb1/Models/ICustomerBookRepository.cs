using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.Models
{
    interface ICustomerBookRepository
    {
        Task<IEnumerable<CustomerBook>> GetWholeLog();
    }
}
