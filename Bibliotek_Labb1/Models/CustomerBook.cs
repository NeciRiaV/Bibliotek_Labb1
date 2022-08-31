using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.Models
{
    public class CustomerBook
    {
        [Key]
        public int CustomerBookID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
        public DateTime BookBorrowed { get; set; }
        public DateTime BookReturned { get; set; }
    }
}
