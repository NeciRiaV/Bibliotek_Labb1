using Bibliotek_Labb1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }

        public string viewAllBooks { get; set; }
    }
}
