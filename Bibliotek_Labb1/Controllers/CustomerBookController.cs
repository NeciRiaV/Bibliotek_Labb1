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
    public class CustomerBookController : Controller
    {
        private readonly ICustomerBookRepository _loan;
        private readonly AppDbContext _appContext;

        public CustomerBookController(ICustomerBookRepository loan, AppDbContext appContext)
        {
            _loan = loan;
            _appContext = appContext;
        }

        public IActionResult CustomerBookLog(int id)
        {
            var cb = _loan.GetCustomerBookByID(id);
            return View(cb);
        }

        [HttpGet("{id}")]
        public IActionResult CustomerBookLogs(int id)
        {
            var cus = _appContext.CustomerBooks.FirstOrDefault(cb => cb.CustomerID == id);
            if(cus == null)
            {
                return NotFound("Not Loans Found");
            }
            else if (cus.CustomerID == id)
            {
                var loans = _appContext.CustomerBooks.Include(b => b.Book).Where(c => c.CustomerID == id);
                var customerLogViewModel = new CustomerLogViewModel()
                {
                    CustomerLoans = loans
                };
                return View(customerLogViewModel);
            }
            return View();
        }


        public IActionResult LoanBook()
        {
            var loans = _appContext.CustomerBooks.Include(b => b.Book);
            var customerLogViewModel = new CustomerLogViewModel()
            {
                CustomerLoans = loans
            };
            return View(customerLogViewModel);
        }

        [HttpPost]
        public async Task<ActionResult<CustomerBook>> AddLoanedBook(CustomerBook customerBook)
        {
            var newCustomerBook = await _loan.Add(customerBook);
            CreatedAtAction(nameof(CustomerBookLog), new { id = customerBook.CustomerBookID }, newCustomerBook);
            return View();
        }

    }
}
