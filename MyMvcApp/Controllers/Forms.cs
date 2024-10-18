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

        public FormsController(IbookRepo ibookRepo, ILogger<FormsController> logger)
        {
            _Ibook = ibookRepo;
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
        public IActionResult AddCustomer(CustomerModel customer)
        {
            if (ModelState.IsValid)
            {
                return Content("Customer added successfully");
            }
            return View(customer);
        }
    }
}
