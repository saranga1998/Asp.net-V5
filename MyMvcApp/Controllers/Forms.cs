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

        [HttpGet]
        public IActionResult AddBooks()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBooks(BookModel book)
        {
            if (ModelState.IsValid)
            {
                return Content("Book added successfully");
            }
            return View(book);
        }
    }
}
