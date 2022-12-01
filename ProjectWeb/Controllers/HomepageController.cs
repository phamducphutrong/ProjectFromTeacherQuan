using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Threading.Tasks;
using System;
using ProjectWeb.Data;
using System.Linq;
using ProjectWeb.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Xceed.Words.NET;
using Xceed.Document.NET;
using DocumentFormat.OpenXml.Drawing;
using System.Reflection.Metadata;
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
        [Route("New")]
        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        [Route("Create")]
        public IActionResult Create(string font, int size, string where, string no, string date1, string date2, string date3, string date4, string tit, string subTitle,
            string cancu, string ten, string gioitinh, string ngaysinh, string dantoc, string quoctich, string cccd, string ngaycap, string noicap, string hethan, string diachi,
            string hientai, string sdt, string email, string detail, string contentnv, string contentquyen, string noinhan, string nguoiky, string namenguoiky, string filename, string del, string save
            )
        {
            if (del == null)
            {
                string[] content1 = cancu.Split("\n");
                var c = content1.Count();
                string[] content2 = contentnv.Split("\n");
                var c2 = content2.Count();
                string[] content3 = contentquyen.Split("\n");
                var c3 = content3.Count();

                var doc = DocX.Create("wwwroot/file/" + filename + ".docx");

                var local = where;
                var left = doc.InsertParagraph(local);
                left.Font(new Xceed.Document.NET.Font(font)).FontSize(size);
                left.Alignment = Alignment.left;
                left.Append("                 Cộng hòa xã hội chủ nghĩa Việt Nam".ToUpper()).Font(new Xceed.Document.NET.Font(font)).FontSize(size).Bold();


                var r = doc.InsertParagraph("                                                                      Độc lập - Tự do - Hạnh phúc")
                        .Font(new Xceed.Document.NET.Font(font)).FontSize(size).Bold();
                r.Alignment = Alignment.left;



                //r.Append("Độc lập - Tự do - Hạnh phúc").Font(new Xceed.Document.NET.Font(font)).FontSize(13).Bold();
                //.UnderlineStyle(UnderlineStyle.singleLine);

                var date = doc.InsertParagraph("Số: " + no).Font(new Xceed.Document.NET.Font(font)).FontSize(size).SpacingBefore(20);
                date.Alignment = Alignment.left;

                //doc.InsertParagraph("Nghĩa Tâm, ngày 10, tháng size, năm 2022");
                date.Append("                                         " + date1 + ", ngày " + date2 + ", tháng " + date3 + ", năm " + date4 + "").Font(new Xceed.Document.NET.Font(font)).FontSize(size).SpacingAfter(30);

                var title = tit.ToUpper();
                var format = doc.InsertParagraph(title).Font(new Xceed.Document.NET.Font(font)).FontSize(size).Bold();
                format.Alignment = Alignment.center;

                var titleSub = subTitle;
                var formatTitleSub = doc.InsertParagraph(titleSub).Font(new Xceed.Document.NET.Font(font)).FontSize(size).Italic().SpacingAfter(20);
                formatTitleSub.Alignment = Alignment.center;

                title = "Hợp đồng thành viên".ToUpper();
                format = doc.InsertParagraph(title).Font(new Xceed.Document.NET.Font(font)).FontSize(size).Bold().SpacingAfter(20);
                format.Alignment = Alignment.center;
                var content = "";
                for (int i = 0; i < c; i++)
                {
                    content += content1[i];
                }
                format = doc.InsertParagraph(content).Font(new Xceed.Document.NET.Font(font)).FontSize(size).Italic().SpacingAfter(10);

                title = tit.ToUpper();
                format = doc.InsertParagraph(title).Font(new Xceed.Document.NET.Font(font)).FontSize(size).Bold();
                format.Alignment = Alignment.center;

                title = "Điều 1: Nay bổ nhiệm:";
                format = doc.InsertParagraph(title).Font(new Xceed.Document.NET.Font(font)).FontSize(size).Bold();

                content = "Họ và tên: " + ten.ToUpper() + "                           Giới tính: " + gioitinh;
                format = doc.InsertParagraph(content).Font(new Xceed.Document.NET.Font(font)).FontSize(size);

                content = "Sinh ngày: " + ngaysinh + "                   Dân tộc: " + dantoc + "            " + "Quốc tịch: " + quoctich;
                format = doc.InsertParagraph(content).Font(new Xceed.Document.NET.Font(font)).FontSize(size);

                content = "Số CCCD: " + cccd + Environment.NewLine + "Ngày cấp: " + ngaycap + "           " + "Nơi cấp: " + noicap + "       " + "Ngày hết hạn: " + hethan;
                format = doc.InsertParagraph(content).Font(new Xceed.Document.NET.Font(font)).FontSize(size);

                content = "Địa chỉ thường trú: " + diachi + Environment.NewLine + "Chỗ ở hiện tại: " + hientai;
                format = doc.InsertParagraph(content).Font(new Xceed.Document.NET.Font(font)).FontSize(size);

                content = "Điện thoại: " + sdt + Environment.NewLine + "Email: " + email;
                format = doc.InsertParagraph(content).Font(new Xceed.Document.NET.Font(font)).FontSize(size);

                content = "Giữ chức vụ: " + detail + " từ ngày ký quyết định";
                format = doc.InsertParagraph(content).Font(new Xceed.Document.NET.Font(font)).FontSize(size);

                title = "Điều 2: ";
                content = "Ông/ bà " + ten.ToUpper() + " có các nghĩa vụ sau: ";
                format = doc.InsertParagraph(title).Font(new Xceed.Document.NET.Font(font)).FontSize(size).Bold();
                format.Append(content).Font(new Xceed.Document.NET.Font(font)).FontSize(size);

                /*            var c1 = "- Giúp cơ quan tổ chức kế toán, thống kê, hạch toán";
                            var c2 = "- Tuân thủ các yêu cầu pháp lý";
                            var c3 = "- Phải thực hiện đúng chức năng, nhiệm vụ, vai trò của một kế toán";
                            var q1 = "- Yêu cầu các bộ phận thu thập thông tin thống kế chính xác";
                            var q2 = "- Yêu cầu các bộ phận lập chứng từ cho toàn bộ ngân sách thu chi của cơ quan";
                            var q3 = "- Ký duyệt các chứng từ, báo cáo kinh tế và đảm bảo tính hợp lệ";
                            var q4 = "- Được hưởng chế độ lương và phúc lợi xã hội của công dân";*/
                content = "";
                for (int i = 0; i < c2; i++)
                {
                    content += content2[i];
                }
                content += Environment.NewLine + "Và các  quyền: " + Environment.NewLine;
                for (int i = 0; i < c3; i++)
                {
                    content += content3[i];
                }
                format = doc.InsertParagraph(content).Font(new Xceed.Document.NET.Font(font)).FontSize(size).SpacingAfter(10);

                title = "Điều 3: ";
                content = "Quyết định này có hiệu lực kể từ ngày ký.";
                format = doc.InsertParagraph(title).Font(new Xceed.Document.NET.Font(font)).FontSize(size).Bold();
                format.Append(content).Font(new Xceed.Document.NET.Font(font)).FontSize(size).SpacingAfter(30);

                title = "Nơi nhận" + "                                                                 " + nguoiky.ToUpper();
                format = doc.InsertParagraph(title).Font(new Xceed.Document.NET.Font(font)).FontSize(size).Bold();

                content = "- Các phòng ban và ông/bà" + Environment.NewLine + ten;
                var ck = "                                                                        (Ký và ghi rõ họ tên)";
                format = doc.InsertParagraph(content).Font(new Xceed.Document.NET.Font(font)).FontSize(size);
                format.Append(ck).Font(new Xceed.Document.NET.Font(font)).FontSize(10).SpacingAfter(30);

                content = "                                                                                                     " + namenguoiky;
                format = doc.InsertParagraph(content).Font(new Xceed.Document.NET.Font(font)).FontSize(size);
                doc.Save();
                ViewBag.fileName = "file/" + filename + ".docx";
                if (save != null)
                {
                    return RedirectToAction("Index");
                }
                else return View("New");
            }
            else
            {
                return View("New");
            }
        }
    }
}
