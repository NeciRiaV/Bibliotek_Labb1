using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(50,MinimumLength = 6)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<CustomerBook> CustomerBook { get; set; }
    }
}
