using Bibliotek_Labb1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.ViewModels
{
    public class CustomerLogViewModel
    {
        public IEnumerable<CustomerBook> CustomerLoans { get; set; }
        public Customer Customer { get; set; }
        public Book Book { get; set; }
        public CustomerBook CustomerBook { get; set; }
    }
}
