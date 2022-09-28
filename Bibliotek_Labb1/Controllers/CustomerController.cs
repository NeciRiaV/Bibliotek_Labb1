using Bibliotek_Labb1.Models;
using Bibliotek_Labb1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly AppDbContext _appContext;
        public CustomerController(ICustomerRepository customerRepository, AppDbContext appContext)
        {
            _customerRepository = customerRepository;
            _appContext = appContext;
        }

        public ViewResult List()
        {
            return View(_customerRepository.GetAllCustomers);
        }

        public IActionResult CustomerInfo(int id)
        {
            var customer = _customerRepository.GetCustomerBytId(id);

            var cInfoViewModel = new CustomerInfoViewModel()
            {
                CustomerInfo = customer
            };
            return View(cInfoViewModel);
        }

        //Add New Customer
        [HttpPost]
        public async Task<ActionResult<Customer>> AddCustomer(Customer customer)
        {
            var newCustomer = await _customerRepository.Add(customer);
            CreatedAtAction(nameof(CustomerInfo), new { id = customer.CustomerID }, newCustomer);
            return View();
        }

        public IActionResult CreateCustomer()
        {
            return View("AddCustomer");
        }

        //Edit Customer

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditCustomer(Customer customer)
        {
            _appContext.Update(customer);
            _appContext.SaveChanges();
            return RedirectToAction(nameof(List));

        }

        public IActionResult UpdateCustomer(int id)
        {
            var customer = _customerRepository.GetCustomerBytId(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }


        //Delete Customer Controller
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            await _customerRepository.Delete(id);
            return View();
        }
    }
}
