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

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public ViewResult List()
        {
            return View(_customerRepository.GetAllCustomers);
        }

        public IActionResult CustomerInfo(int id)
        {
            var customer = _customerRepository.GetCustomerBytId(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        //public IActionResult AddOrEdit(int id)
        //{
        //    if (id == 0)
        //    {
        //        return View(new Customer());
        //    }
        //    else
        //    {
        //        return View(_customerRepository.GetAllCutomers().FindAsync(id));
        //    }
        //}

        //public IActionResult EditEmployee()
        //{
        //    if (true)
        //    {

        //    }
        //}
    }
}
