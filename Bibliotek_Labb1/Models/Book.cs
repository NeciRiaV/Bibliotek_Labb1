using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public string Description { get; set; }
        public bool IsOnLoan { get; set; }
        public ICollection<CustomerBook> CustomerBook { get; set; }
    }
}
