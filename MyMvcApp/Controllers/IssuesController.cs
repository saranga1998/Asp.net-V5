using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace MyMvcApp{
    public class IssuesController : Controller{
        
        public ILogger<IssuesController> logger;
        public IissueRepo _issueRepo;

        public IssuesController(ILogger<IssuesController> logger,IissueRepo iissueRepo){
            this.logger = logger;
            this._issueRepo = iissueRepo;
        }


        public async Task <IActionResult> BookIssue(){

            var books = await _issueRepo.GetAllBooks();
            ViewBag.BookList = new SelectList(books,"Id","BookName");

            var Members = await _issueRepo.GetAllMembers();
            ViewBag.CustomerList = new SelectList(Members,"NIC","CustomerName");
            return View();
        }
    }
}