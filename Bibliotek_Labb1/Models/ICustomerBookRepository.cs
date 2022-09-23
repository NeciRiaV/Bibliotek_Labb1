using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.Models
{
    public interface ICustomerBookRepository
    {
        public IEnumerable<CustomerBook> Loans { get; }
    }
}
