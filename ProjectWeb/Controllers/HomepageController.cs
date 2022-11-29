using Microsoft.AspNetCore.Mvc;
using ProjectWeb.Models;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System;
using ProjectWeb.Data;
using System.Linq;

namespace ProjectWeb.Controllers
{
    public class HomepageController : Controller
    {
        private readonly ApplicationDbContext context;
        public HomepageController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [Route("/")]
        public IActionResult Index()
        {
            return View(context.Records.ToList());
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
        /*[Route("apis")]
        public IActionResult Speech()
        {
            String result = Task.Run(async () =>
            {
                String filePath = @"test.mp3";
                var payload = System.IO.File.ReadAllBytes(filePath);

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("api-key", "FzQoB83BD6hlMe8ADIbimGdUlutj2rdB");

                var response = await client.PostAsync("https://api.fpt.ai/hmi/asr/general", new ByteArrayContent(payload));
                return await response.Content.ReadAsStringAsync();
            }).GetAwaiter().GetResult();
            UnicodeEncoding Unicode = new UnicodeEncoding();
            byte[] FileTextBytes = Unicode.GetBytes(result);
            string res = Unicode.GetString(FileTextBytes);

            var userObj = JObject.Parse(res);
            var userGuid = Convert.ToString(userObj["hypotheses"][0]["utterance"]);
            ViewBag.Speech = userGuid;
            List<Record> data = new List<Record>()
            {
                new Record() { document_name = "abcd", document_id = "12345678", document_type = "Quyết định", book_number = "b-123", version = "#123", last_fix = 15, tag = "Đất đai"},
                new Record() { document_name = "efgh", document_id = "87654321", document_type = "Quyết định", book_number = "b-321", version = "#321", last_fix = 10, tag = "Đất đai"},
                new Record() { document_name = "jklm", document_id = "12345", document_type = "Nghị định", book_number = "b-456", version = "#456", last_fix = 20, tag = "Sở giáo dục"}
            };
            return View("Index", data);
        }*/
    }
}
