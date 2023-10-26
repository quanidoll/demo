using Microsoft.AspNetCore.Mvc;
namespace DemoMvc.Controllers
{
    public class ThuchanhController : Controller
    {
        //khai bao cac phuong thuc
         public IActionResult Index()
        {
            return View();
        }
    }
}
