using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers
{
    public class FormsController : Controller
    {
        private readonly ILogger<FormsController> _logger;
        private readonly IbookRepo _Ibook;

        public FormsController(IbookRepo Ibook, ILogger<FormsController> logger)
        {
            _Ibook = Ibook;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult AddBooks()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBooks(BookModel book)
        {
            _logger.LogInformation("AddBooks action was invoked.");
            try
            {
                await _Ibook.AddBook(book);

                _logger.LogDebug("Executing AddBooks logic...");
                return RedirectToAction("AddBooks");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding book");
            }
            return View(book);

        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(CustomerModel customer)
        {
            _logger.LogInformation("AddCustomers action was invoked.");
            try
            {
                await _Ibook.AddCustomer(customer);

                _logger.LogDebug("Executing AddCustomers logic...");
                return RedirectToAction("AddCustomer");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding book");
            }
            return View(customer);
        }

        [HttpGet]
        public async Task<IActionResult> ShowBooks()
        {
            var books = await _Ibook.GetAllBooks();
            return View(books);
        }

        [HttpGet]

        public async Task<IActionResult> ShowCustomers(){
            var customers = await _Ibook.GetAllCustomers();
            return View(customers);
        }
    }
}
