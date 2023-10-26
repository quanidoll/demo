using Microsoft.AspNetCore.Mvc;
namespace DemoMvc.Controllers
{
    public class DemoController : Controller
    {
        //khai bao cac phuong thuc
         public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string fName, string Email)
        {
            string strResult = "Hello" + fName + "-" + "Email cua ban" + Email;
            ViewBag.thongbao = strResult;
            return View();
        }
    }
}

