using Microsoft.AspNetCore.Mvc;
using Demo.Models;
using System.Collections.Generic;

namespace Demo.Controllers
{
    public class HomepageController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            List<Record> data = new List<Record>()
            {
                new Record() { document_name = "abcd", document_id = "12345678", document_type = "Quyết định", book_number = "b-123", version = "#123", last_fix = 15, tag = "Đất đai"},
                new Record() { document_name = "efgh", document_id = "87654321", document_type = "Quyết định", book_number = "b-321", version = "#321", last_fix = 10, tag = "Đất đai"},
                new Record() { document_name = "jklm", document_id = "12345", document_type = "Nghị định", book_number = "b-456", version = "#456", last_fix = 20, tag = "Sở giáo dục"}
            };
            return View(data);
        }
        [Route("choosingtemplate")]
        public IActionResult ChoosingTemplate()
        {
            return View();
        }
    }
}
