using Bibliotek_Labb1.Models;
using Bibliotek_Labb1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICustomerBookRepository _customerBookRepository;

        private CustomerController(ICustomerRepository customerRepository, ICustomerBookRepository customerBookRepository)
        {
            _customerRepository = customerRepository;
            _customerBookRepository = customerBookRepository;
        }

        public ViewResult List(string fullname)
        {
            IEnumerable<Customer> customers;
            if (string.IsNullOrEmpty(fullname))
            {
                customers = _customerRepository.GetAllCutomers().OrderBy(c => c.CustomerID);
            }
            else
            {
                customers = _customerRepository.GetAllCutomers().Where(c => c.FullName == fullname);
            }

            return View(new CustomerListViewModel
            {
                Customers = customers
            });
        }

        public IActionResult AddOrEdit(int id)
        {
            if (id == 0)
            {
                return View(new Customer());
            }
            else
            {
                return View(_customerRepository.GetAllCutomers().FindAsync(id));
            }
        }
        
        public IActionResult EditEmployee()
        {
            if (true)
            {

            }
        }
    }
}
