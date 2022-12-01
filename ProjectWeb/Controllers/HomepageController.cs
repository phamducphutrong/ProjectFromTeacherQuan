using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Threading.Tasks;
using System;
using ProjectWeb.Data;
using System.Linq;
using ProjectWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectWeb.Controllers
{
    public class HomepageController : Controller
    {
        private readonly ApplicationDbContext context;
        public HomepageController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.Categories = context.Categories.ToList();
            return View(context.Records.Include(category => category.Category).ToList());
        }
        [Route("/")]
        [HttpPost]
        public IActionResult Index(int id)
        {
            Record record = context.Records.Include(record => record.Category).FirstOrDefault(record => record.id== id);
            TempData["document_id"] = record.document_id;
            TempData["book_number"] = record.book_number;
            TempData["category_id"] = record.Category.Id;
            TempData["category_name"] = record.Category.Name;
            TempData["dear_to"] = record.Dear_to;
            TempData["destination"] = record.Destination;
            TempData["content"] = record.Content;
            TempData["image"] = record.Image;
            TempData["signed_day"] = record.signed_day.ToShortDateString();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            context.Records.Remove(context.Records.Find(id));
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [Route("choosingtemplate")]
        public IActionResult ChoosingTemplate()
        {
            return View(context.Templates.ToList());
        }
        public IActionResult EditTemplate()
        {
            return View();
        }
    }
}
