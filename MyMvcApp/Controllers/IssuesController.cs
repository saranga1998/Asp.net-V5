using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MyMvcApp.Models;

namespace MyMvcApp
{
    public class IssuesController : Controller
    {

        public ILogger<IssuesController> _logger;
        public IissueRepo _issueRepo;

        public IssuesController(ILogger<IssuesController> logger, IissueRepo iissueRepo)
        {
            this._logger = logger;
            this._issueRepo = iissueRepo;
        }

        [HttpGet]
        public async Task<IActionResult> BookIssue()
        {

            var books = await _issueRepo.GetAllBooks();
            ViewBag.BookList = new SelectList(books, "Id", "BookName");

            var Members = await _issueRepo.GetAllMembers();
            ViewBag.CustomerList = new SelectList(Members, "NIC", "CustomerName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BookIssue(CustomerBookModel Issue)
        {

            _logger.LogInformation("BookIssue action was invoked.");
            try
            {
                await _issueRepo.AddBookIssue(Issue);

                _logger.LogDebug("Executing BookIssue logic...");
                return RedirectToAction("BookIssue");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error Issue book");
            }
            return View(Issue);
        }
    }
}