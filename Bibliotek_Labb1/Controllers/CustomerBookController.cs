using Bibliotek_Labb1.Models;
using Bibliotek_Labb1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotek_Labb1.Controllers
{
    public class CustomerBookController : Controller
    {
        private readonly ICustomerBookRepository _appDbContext;

        public CustomerBookController(ICustomerBookRepository appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult CustomerBookLog(int id)
        //{
        //    var customerBook = _appDbContext.Loans.Include(b => b.Book).Where(c => c.CustomerID == id);

        //    var customerlogViewModel = new CustomerLogViewModel
        //    {
        //        CustomerLoans = customerBook
        //    };
        //    return View(customerBook);
        //}
    }
}
